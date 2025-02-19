using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.ViewComponents
{
    public class _FooterLayoutCompanyComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
