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
    public class SkinsController : Controller
    {
        private readonly Datacontext _context;

        public SkinsController(Datacontext context)
        {
            _context = context;
        }

      [Route("/Admin/skin-index/{page:int}.html", Name = "skinindex")]
public IActionResult Index(int page = 1)
{
    var path = _context.skins.OrderByDescending(p => p.SkinID);
    int pageSize = 5;
    PagedList<tblSkins> models = new(path, page, pageSize);
    if (models == null)
        return NotFound();
    return View(models);
}

[ActionName("Index")]
public IActionResult Index()
{
    return RedirectToRoute("skinindex", new { page = 1 });
}


        public  IActionResult Delete(long? id)
        {
            if(id==null || id==0) 
            return NotFound();
            var mn=_context.skins.Find(id);
            if(mn==null)
            return NotFound();
            return View(mn);
        }
        
        [HttpPost]
        public IActionResult Delete(long id)
        {
            var delpath=_context.skins.Find(id);
            if(delpath==null)
            return NotFound();
            _context.skins.Remove(delpath);
            _context.SaveChanges();
            return RedirectToAction("Index");
            }

             public IActionResult Create()
        {
            var mnList = (from m in _context.Champions
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

            ViewBag.mnlist = mnList;
            return View();
        }

        [HttpPost]
        public IActionResult Create(tblSkins path)
        {
            if (ModelState.IsValid)
            {
                _context.skins.Add(path);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
 public IActionResult Edit(long? id)
        {
            if (id == null || id == 0)
                return NotFound();

            var mn = _context.skins.Find(id);
            if (mn == null)
                return NotFound();

            var mnList = (from m in _context.Champions
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
        public IActionResult Edit(tblSkins path)
        {
            if (ModelState.IsValid)
            {
                _context.skins.Update(path);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }


        }
    }