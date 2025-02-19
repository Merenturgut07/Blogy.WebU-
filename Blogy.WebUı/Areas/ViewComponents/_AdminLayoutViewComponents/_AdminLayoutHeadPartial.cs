using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.Areas.ViewComponents._AdminLayoutViewComponents
{
    public class _AdminLayoutHeadPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
