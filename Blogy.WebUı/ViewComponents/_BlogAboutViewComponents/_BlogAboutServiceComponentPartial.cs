using Blogy.BussinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.ViewComponents._BlogAboutViewComponents
{
    public class _BlogAboutServiceComponentPartial:ViewComponent
    {
        private readonly IBlogAboutServiceService _blogAboutServiceService;

        public _BlogAboutServiceComponentPartial(IBlogAboutServiceService blogAboutServiceService)
        {
            _blogAboutServiceService = blogAboutServiceService;
        }

        public IViewComponentResult Invoke()
        {
            var values=_blogAboutServiceService.TGetListAll();
            return View(values);
        }
    }
}
