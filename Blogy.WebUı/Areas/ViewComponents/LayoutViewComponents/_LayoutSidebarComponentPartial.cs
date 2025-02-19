using Blogy.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.Areas.ViewComponents.LayoutViewComponents
{
    public class _LayoutSidebarComponentPartial:ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;

        public _LayoutSidebarComponentPartial(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task <IViewComponentResult> InvokeAsync()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.v = values.ImageUrl;
            ViewBag.v1 = values.Name + " " + values.Surname;
            return View();
        }
    }
}
