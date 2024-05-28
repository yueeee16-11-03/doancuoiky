using dona.Model;
using dona.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using PagedList.Core;

namespace dona.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PostController : Controller
    {
        private readonly Datacontext _context;

        public PostController(Datacontext context)
        {
            _context = context;
        }

        [Route("/Admin/post-index{page:int}.html", Name = "PostIndex")]
        public IActionResult Index(int page = 1)
        {
            var post = _context.Posts.OrderByDescending(p => p.PostID);
            int pageSize = 5;
            PagedList<tblPost> models = new(post, page, pageSize);
            if (models == null)
                return NotFound();
            return View(models);
        }

        public IActionResult Index()
        {
            return RedirectToRoute("PostIndex", new { page = 1 });
        }

        public IActionResult Create()
        {
            var mnList = (from m in _context.Menus
                          select new SelectListItem()
                          {
                              Text = m.MenuName,
                              Value = m.MenuID.ToString()
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
        public IActionResult Create(tblPost post)
        {
            if (ModelState.IsValid)
            {
                _context.Posts.Add(post);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public IActionResult Edit(long? id)
        {
            if (id == null || id == 0)
                return NotFound();

            var mn = _context.Posts.Find(id);
            if (mn == null)
                return NotFound();

            var mnList = (from m in _context.Menus
                          select new SelectListItem()
                          {
                              Text = m.MenuName,
                              Value = m.MenuID.ToString()
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
        public IActionResult Edit(tblPost post)
        {
            if (ModelState.IsValid)
            {
                _context.Posts.Update(post);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public IActionResult Delete(long? id)
        {
            if (id == null || id == 0)
                return NotFound();

            var mn = _context.Posts.Find(id);
            if (mn == null)
                return NotFound();

            return View(mn);
        }

        [HttpPost]
        public IActionResult Delete(long id)
        {
            var delPost = _context.Posts.Find(id);
            if (delPost == null)
                return NotFound();

            _context.Posts.Remove(delPost);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
