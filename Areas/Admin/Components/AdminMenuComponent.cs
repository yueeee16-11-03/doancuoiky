using Microsoft.AspNetCore.Mvc;
using dona.Models;
using System.Linq;  
namespace dona.Areas.Admin.Components
{
    [ViewComponent(Name= "AdminMenu")]
        public class AdminMenuComponent : ViewComponent
    {
          private readonly Datacontext _context;    
            public AdminMenuComponent(Datacontext context)
            {
                _context=context;
                }   
                public async Task<IViewComponentResult> InvokeAsync()
                {
                    var mnlist= (from mn in _context.AdminMenus where (mn.IsActive ==true)
                    select mn).ToList();
                    return await Task.FromResult((IViewComponentResult)View("Default",mnlist));



                }
    }
}