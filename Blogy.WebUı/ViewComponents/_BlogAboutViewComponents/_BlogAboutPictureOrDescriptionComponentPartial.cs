using Blogy.BussinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.ViewComponents._BlogAboutViewComponents
{
    public class _BlogAboutPictureOrDescriptionComponentPartial:ViewComponent
    {
        private readonly IBlogAboutPictureOrDescriptionService _blogAboutPictureOrDescriptionService;

        public _BlogAboutPictureOrDescriptionComponentPartial(IBlogAboutPictureOrDescriptionService blogAboutPictureOrDescriptionService)
        {
            _blogAboutPictureOrDescriptionService = blogAboutPictureOrDescriptionService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _blogAboutPictureOrDescriptionService.TGetListAll();
            return View(values);
        }
    }
}
