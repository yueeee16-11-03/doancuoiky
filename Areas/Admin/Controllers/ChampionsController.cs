using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using dona.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Data;
using dona.Model;
using PagedList.Core;
namespace dona.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ChampionsController : Controller
    {
        private readonly Datacontext _context;

        public ChampionsController(Datacontext context)
        {
            _context = context;
        }

      [Route("/Admin/champion-index/{page:int}.html", Name = "Championindex")]
public IActionResult Index(int page = 1)
{
    var champion = _context.Champions.OrderByDescending(p => p.ChampionsID);
    int pageSize = 5;
    PagedList<tblChampions> models = new(champion, page, pageSize);
    if (models == null)
        return NotFound();
    return View(models);
}


public IActionResult Index()
{
    return RedirectToRoute("Championindex", new { page = 1 });
}


        public  IActionResult Delete(long? id)
        {
            if(id==null || id==0) 
            return NotFound();
            var mn=_context.Champions.Find(id);
            if(mn==null)
            return NotFound();
            return View(mn);
        }
        
        [HttpPost]
        public IActionResult Delete(long id)
        {
            var delpath=_context.Champions.Find(id);
            if(delpath==null)
            return NotFound();
            _context.Champions.Remove(delpath);
            _context.SaveChanges();
            return RedirectToAction("Index");
            }

             public IActionResult Create()
        {
            var mnList = (from m in _context.paths
                          select new SelectListItem()
                          {
                              Text = m.NamePath,
                              Value = m.PathID.ToString()
                          }).ToList();

            mnList.Insert(0, new SelectListItem()
            {
                Text = "---Select---",
                Value = string.Empty
            });

            ViewBag.mnlist = mnList;
            return View();
        }

        [HttpPost]
        public IActionResult Create(tblChampions cham)
        {
            if (ModelState.IsValid)
            {
                _context.Champions.Add(cham);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
 public IActionResult Edit(long? id)
        {
            if (id == null || id == 0)
                return NotFound();

            var mn = _context.Champions.Find(id);
            if (mn == null)
                return NotFound();

            var mnList = (from m in _context.paths
                          select new SelectListItem()
                          {
                              Text = m.NamePath,
                              Value = m.PathID.ToString()
                          }).ToList();

            mnList.Insert(0, new SelectListItem()
            {
                Text = "---Select---",
                Value = string.Empty
            });

            ViewBag.mnList = mnList;
            return View(mn);
        }

        [HttpPost]
        public IActionResult Edit(tblChampions path)
        {
            if (ModelState.IsValid)
            {
                _context.Champions.Update(path);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }


        }
    }