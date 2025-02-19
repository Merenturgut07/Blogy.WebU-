using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.Areas.ViewComponents.LayoutViewComponents
{
    public class _LayoutHeadComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
