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
    public class SkillsController : Controller
    {
        private readonly Datacontext _context;

        public SkillsController(Datacontext context)
        {
            _context = context;
        }

       [Route("/Admin/skill-index/{page:int}.html", Name ="killIndex")]
       public IActionResult Index(int page = 1)
       {
         var skill = _context.Skills.OrderByDescending(p => p.SkillID);
        int pageSize = 5;
        PagedList<tblSkills> models = new(skill, page, pageSize);
        if (models == null)
        return NotFound();
        return View(models);
        }


        public IActionResult Index()
          {
             return RedirectToRoute("killIndex", new { page = 1 });
          }


        public  IActionResult Delete(long? id)
        {
            if(id==null || id==0) 
            return NotFound();
            var mn=_context.Skills.Find(id);
            if(mn==null)
            return NotFound();
            return View(mn);
        }
        
        [HttpPost]
        public IActionResult Delete(long id)
        {
            var delpath=_context.Skills.Find(id);
            if(delpath==null)
            return NotFound();
            _context.Skills.Remove(delpath);
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
        public IActionResult Create(tblSkills cham)
        {
            if (ModelState.IsValid)
            {
                _context.Skills.Add(cham);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
 public IActionResult Edit(long? id)
        {
            if (id == null || id == 0)
                return NotFound();

            var mn = _context.Skills.Find(id);
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
        public IActionResult Edit(tblSkills path)
        {
            if (ModelState.IsValid)
            {
                _context.Skills.Update(path);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }


        }
    }