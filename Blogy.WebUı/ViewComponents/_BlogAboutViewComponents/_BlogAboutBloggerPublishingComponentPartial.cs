using Blogy.BussinessLayer.Abstract;
using Blogy.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.ViewComponents._BlogAboutViewComponents
{
    public class _BlogAboutBloggerPublishingComponentPartial : ViewComponent
    {
        private readonly IBlogAboutBloggerPublishingService _blogAboutBloggerPublishingService;

        public _BlogAboutBloggerPublishingComponentPartial(IBlogAboutBloggerPublishingService blogAboutBloggerPublishingService)
        {
            _blogAboutBloggerPublishingService = blogAboutBloggerPublishingService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _blogAboutBloggerPublishingService.TGetListAll();
            return View(values);
        }
    }
}
