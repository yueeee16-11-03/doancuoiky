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
    public class PathController : Controller
    {
        private readonly Datacontext _context;

        public PathController(Datacontext context)
        {
            _context = context;
        }

      [Route("/Admin/path-index/{page:int}.html", Name = "Pathindex")]
public IActionResult Index(int page = 1)
{
    var path = _context.paths.OrderByDescending(p => p.PathID);
    int pageSize = 5;
    PagedList<tblPath> models = new(path, page, pageSize);
    if (models == null)
        return NotFound();
    return View(models);
}

[ActionName("Index")]
public IActionResult Index()
{
    return RedirectToRoute("Pathindex", new { page = 1 });
}


        public  IActionResult Delete(long? id)
        {
            if(id==null || id==0) 
            return NotFound();
            var mn=_context.paths.Find(id);
            if(mn==null)
            return NotFound();
            return View(mn);
        }
        
        [HttpPost]
        public IActionResult Delete(long id)
        {
            var delpath=_context.paths.Find(id);
            if(delpath==null)
            return NotFound();
            _context.paths.Remove(delpath);
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
        public IActionResult Create(tblPath path)
        {
            if (ModelState.IsValid)
            {
                _context.paths.Add(path);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
 public IActionResult Edit(long? id)
        {
            if (id == null || id == 0)
                return NotFound();

            var mn = _context.paths.Find(id);
            if (mn == null)
                return NotFound();

            var mnList = (from m in _context.paths
                          select new SelectListItem()
                          {
                              Text = m.NameChampions,
                              Value = m.ChampionsID.ToString()
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
        public IActionResult Edit(tblPath path)
        {
            if (ModelState.IsValid)
            {
                _context.paths.Update(path);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }


        }
    }