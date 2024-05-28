using System.Configuration;
using elFinder.NetCore;
using elFinder.NetCore.Drivers.FileSystem;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
namespace dona.Areas.Admin.Controllers

{
    [Area("Admin")]
    public class FileManagerController :Controller
    {
        [Route("/Admin/File-manager")]
        public IActionResult Index()
        {
            return View();
        }
        IWebHostEnvironment _env;
        public FileManagerController(IWebHostEnvironment env)=>_env=env;
        [Route("Admin/connector")]
        public async Task<IActionResult> Connector()
        {
            var connector=GetConnector();
            return await connector.ProcessAsync(Request);
            }
            [Route("Admin/thumb/{hash}")]
            public async Task<IActionResult> Thumbs(string hash)
            {
                var connector=GetConnector();
                return await connector.GetThumbnailAsync(HttpContext.Request,HttpContext.Response,hash);
                }
                private Connector GetConnector()
                {
                    string pathroot="uploads";
                    string requestUrl="files";
                    var driver=new FileSystemDriver();
                    string absoluteUrl= UriHelper.BuildAbsolute(Request.Scheme, Request.Host);
                    
                    var uri=new Uri(absoluteUrl);

                    string rootDirectory=Path.Combine(_env.ContentRootPath,pathroot);
                    string url=$"/{requestUrl}/";
                    string urlthumb=$"{uri.Scheme}://{uri.Authority}/Admin/thumb/";
                    var root=new RootVolume(rootDirectory, url, urlthumb)
                    {
                        IsReadOnly=false,
                        IsLocked=false,
                        Alias="Files",
                        ThumbnailSize=100,
                        };
                        driver.AddRoot(root);
                        return new Connector(driver)
                        {
                            MimeDetect=MimeDetectOption.Internal
                            };
                }

        
    }
}