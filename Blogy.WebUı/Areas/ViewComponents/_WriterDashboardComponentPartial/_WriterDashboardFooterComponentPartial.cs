using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.Areas.ViewComponents._WriterDashboardComponentPartial
{
    public class _WriterDashboardFooterComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
