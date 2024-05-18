using Microsoft.AspNetCore.Mvc;
using dona.Models;
namespace dona.Components
{
    [ViewComponent(Name ="Post")]
     public class PostComponents : ViewComponent

        {
            private readonly Datacontext _context;
            public  PostComponents(Datacontext context)
            {
                _context=context;
                }
                public async Task<IViewComponentResult> InvokeAsync()
                {
                    var listofPost=(from p in _context.ViewPostMenus where (p.IsActive==true) orderby p.PostID descending select p).Take(10).ToList();

                      return await Task.FromResult((IViewComponentResult)View ("Default",listofPost));

                }
            }
}