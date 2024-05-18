
using dona.Models;
using Microsoft.AspNetCore.Mvc;
namespace dona.Components
{
     [ViewComponent(Name ="MenuView")]
   
    
        
       
        public class MenuViewComponent : ViewComponent

        {
            private readonly Datacontext _context;
            public MenuViewComponent (Datacontext context)
            {
                _context=context;
                }
                public async Task<IViewComponentResult> InvokeAsync()
                {
                    var listOfMenu= (from m in _context.Menus where (m.IsActive ==true)&&(m.Position ==1)
                    select m).ToList();
                    return await Task.FromResult((IViewComponentResult)View("Default",listOfMenu));



                }
            }
    }

