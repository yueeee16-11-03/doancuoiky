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
    public class LaneController : Controller
    {
        private readonly Datacontext _context;

        public LaneController(Datacontext context)
        {
            _context = context;
        }

      [Route("/Admin/lane-index/{page:int}.html", Name = "Laneindex")]
public IActionResult Index(int page = 1)
{
    var path = _context.Lanes.OrderByDescending(p => p.LaneID);
    int pageSize = 5;
    PagedList<tblLane> models = new(path, page, pageSize);
    if (models == null)
        return NotFound();
    return View(models);
}

[ActionName("Index")]
public IActionResult Index()
{
    return RedirectToRoute("Laneindex", new { page = 1 });
}


        public  IActionResult Delete(long? id)
        {
            if(id==null || id==0) 
            return NotFound();
            var mn=_context.Lanes.Find(id);
            if(mn==null)
            return NotFound();
            return View(mn);
        }
        
        [HttpPost]
        public IActionResult Delete(long id)
        {
            var delpath=_context.Lanes.Find(id);
            if(delpath==null)
            return NotFound();
            _context.Lanes.Remove(delpath);
            _context.SaveChanges();
            return RedirectToAction("Index");
            }

             public IActionResult Create()
        {
            var mnList = (from m in _context.Games
                          select new SelectListItem()
                          {
                              Text = m.Title,
                              Value = m.GameID.ToString()
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
        public IActionResult Create(tblLane path)
        {
            if (ModelState.IsValid)
            {
                _context.Lanes.Add(path);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
 public IActionResult Edit(long? id)
        {
            if (id == null || id == 0)
                return NotFound();

            var mn = _context.Lanes.Find(id);
            if (mn == null)
                return NotFound();

            var mnList = (from m in _context.Games
                          select new SelectListItem()
                          {
                              Text = m.Title,
                              Value = m.GameID.ToString()
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
        public IActionResult Edit(tblLane path)
        {
            if (ModelState.IsValid)
            {
                _context.Lanes.Update(path);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }


        }
    }