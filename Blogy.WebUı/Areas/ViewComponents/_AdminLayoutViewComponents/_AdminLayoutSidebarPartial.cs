using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.Areas.ViewComponents._AdminLayoutViewComponents
{
    public class _AdminLayoutSidebarPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
