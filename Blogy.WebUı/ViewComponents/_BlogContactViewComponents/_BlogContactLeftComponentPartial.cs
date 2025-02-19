using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.ViewComponents._BlogContactLeftViewComponents
{
    public class _BlogContactLeftComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
