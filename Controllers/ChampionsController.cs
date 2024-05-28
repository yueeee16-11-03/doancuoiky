    using System.Diagnostics;
    using Microsoft.AspNetCore.Mvc;
    using dona.Models;

    namespace dona.Controllers;

    public class ChampionsController : Controller
    {
        private readonly ILogger<ChampionsController> _logger;
    private readonly Datacontext _context;
        public ChampionsController(ILogger<ChampionsController> logger,Datacontext context)
        {
            _logger = logger;
            _context= context;
        }

        public IActionResult Index()
        {
            return View();
        }

    [Route("/menu-{slug}-{id:long}.html" ,Name="Championdetail")]
    public IActionResult Details (long? id)
    {
        if(id==null)return NotFound();
        var post=_context.Champions.FirstOrDefault(m=>(m.ChampionsID==id)&& (m.IsActive==true));
        if(post==null) return NotFound();
        return View(post);
        }
}
       