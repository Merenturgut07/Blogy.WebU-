using Blogy.BussinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.ViewComponents
{
    public class _FooterLayoutAboutComponentPartial:ViewComponent
    {
        private readonly ILayoutAboutService _layoutAboutService;

        public _FooterLayoutAboutComponentPartial(ILayoutAboutService layoutAboutService)
        {
            _layoutAboutService = layoutAboutService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _layoutAboutService.TGetListAll();
            return View(values);
        }
    }
}
