using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.ViewComponents._BlogAboutViewComponents
{
    public class _BlogAboutHeadComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
