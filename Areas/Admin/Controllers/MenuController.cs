using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using dona.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Data;

namespace dona.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MenuController :Controller
    {
        private readonly Datacontext _context;
public MenuController(Datacontext Context)
{
    _context=Context;
    }
    public IActionResult Index()
    {
        var mnList =_context.Menus.OrderBy(m=>m.MenuID).ToList();
        return View(mnList);
        }
        public  IActionResult Delete(int? id)
        {
            if(id==null || id==0) 
            return NotFound();
            var mn=_context.Menus.Find(id);
            if(mn==null)
            return NotFound();
            return View(mn);
        }
        
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var delMenu=_context.Menus.Find(id);
            if(delMenu==null)
            return NotFound();
            _context.Menus.Remove(delMenu);
            _context.SaveChanges();
            return RedirectToAction("Index");
            }

            public IActionResult Create()
            {
                var mnList=(from m in _context.Menus select new SelectListItem()
                {
                    Text=(m.Levels==1) ? m.MenuName: "-- " +m.MenuName,Value=m.MenuID.ToString()
                }).ToList();
                mnList.Insert(0,new SelectListItem()
                { 
                    Text="---select---",Value="0"
                    });

                    ViewBag.mnList=mnList;
                    return View();
            }
            [HttpPost]
            public IActionResult Create(tblMenu mn)
            {
                if(ModelState.IsValid)
                {
                    _context.Menus.Add(mn);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                    }
                    return View(mn);
                    }
 public  IActionResult Edit(int? id)
                    {
                        if(id==null|| id==0)
                        return NotFound();
                        var mn=_context.Menus.Find(id);
                        if(mn==null)
                        return NotFound();
                        var mnList=(from m in _context.Menus select new SelectListItem()
                        {
                            Text=(m.Levels==1)? m.MenuName :"--" +m.MenuName,
                            Value=m.MenuID.ToString()
                        }).ToList();
                        mnList.Insert(0,new SelectListItem()
                        {
                           Text="---select---",
                           Value="0" 
                        });
                        ViewBag.mnList=mnList;
                        return View(mn);
                    
                    }
                     [HttpPost]
            public IActionResult Edit(tblMenu mn)
            {
                if(ModelState.IsValid)
                {
                    _context.Menus.Update(mn);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                    }
                    return View(mn);
                    }


        }
    }