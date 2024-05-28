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
    public class GameController : Controller
    {
        private readonly Datacontext _context;

        public GameController(Datacontext context)
        {
            _context = context;
        }

       [Route("/Admin/game-index/{page:int}.html", Name ="gameIndex")]
       public IActionResult Index(int page = 1)
       {
         var game = _context.Games.OrderByDescending(p => p.GameID);
        int pageSize = 5;
        PagedList<tblGames> models = new(game, page, pageSize);
        if (models == null)
        return NotFound();
        return View(models);
        }


        public IActionResult Index()
          {
             return RedirectToRoute("gameIndex", new { page = 1 });
          }


        public  IActionResult Delete(long? id)
        {
            if(id==null || id==0) 
            return NotFound();
            var mn=_context.Games.Find(id);
            if(mn==null)
            return NotFound();
            return View(mn);
        }
        
        [HttpPost]
        public IActionResult Delete(long id)
        {
            var delpath=_context.Games.Find(id);
            if(delpath==null)
            return NotFound();
            _context.Games.Remove(delpath);
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
        public IActionResult Create(tblGames game)
        {
            if (ModelState.IsValid)
            {
                _context.Games.Add(game);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
 public IActionResult Edit(long? id)
        {
            if (id == null || id == 0)
                return NotFound();

            var mn = _context.Games.Find(id);
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
        public IActionResult Edit(tblGames path)
        {
            if (ModelState.IsValid)
            {
                _context.Games.Update(path);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }


        }
    }