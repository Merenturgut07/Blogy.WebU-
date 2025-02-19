using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.Areas.ViewComponents.LayoutViewComponents
{
    public class _LayoutNavbarAdminMessageComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
