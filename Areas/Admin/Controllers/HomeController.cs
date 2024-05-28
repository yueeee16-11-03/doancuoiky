using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using dona.Models;

namespace dona.Areas.Admin.Controllers;
[Area("Admin")]
public class HomeController : Controller
{
  
public IActionResult Index()
{
    return View();
    }
}
