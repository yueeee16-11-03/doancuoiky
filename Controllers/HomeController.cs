using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using dona.Models;

namespace dona.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
private readonly Datacontext _context;
    public HomeController(ILogger<HomeController> logger,Datacontext context)
    {
        _logger = logger;
        _context= context;
    }

    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Champions(){
        return View();
        }

[Route("/post-{slug}-{id:long}.html" ,Name="Details")]
public IActionResult Details (long? id)
{
    if(id==null)return NotFound();
    var post=_context.ViewPostMenus.FirstOrDefault(m=>(m.PostID==id)&& (m.IsActive==true));
    if(post==null) return NotFound();
    return View(post);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
