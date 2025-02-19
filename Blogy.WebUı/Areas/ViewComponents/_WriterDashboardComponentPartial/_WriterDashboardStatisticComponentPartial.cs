using Blogy.DataAccesLayer.Context;
using Blogy.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.Areas.ViewComponents._WriterDashboardComponentPartial
{
    public class _WriterDashboardStatisticComponentPartial : ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly BlogyContext _blogyContext;

        public _WriterDashboardStatisticComponentPartial(UserManager<AppUser> userManager, BlogyContext blogyContext)
        {
            _userManager = userManager;
            _blogyContext = blogyContext;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            BlogyContext c = new BlogyContext();
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.v1 = c.Articles.Count();
            ViewBag.v2 = c.Categories.Count();
            ViewBag.v3 = c.writerMessages.Where(x => x.Receiver == user.Email).Count();
            ViewBag.v4 = c.writerMessages.Where(x => x.Sender == user.Email).Count();
            return View();
        }
    }
}
