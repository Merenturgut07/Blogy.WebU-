using Blogy.BussinessLayer.Abstract;
using Blogy.EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]/{id?}")]
    [Authorize(Roles = "Admin")]
    public class AdminAboutDescOrPhotoController : Controller
    {

        private readonly IBlogAboutPictureOrDescriptionService _blogAboutPictureOrDescriptionService;

        public AdminAboutDescOrPhotoController(IBlogAboutPictureOrDescriptionService blogAboutPictureOrDescriptionService)
        {
            _blogAboutPictureOrDescriptionService = blogAboutPictureOrDescriptionService;
        }


        public IActionResult List()
        {
            var values=_blogAboutPictureOrDescriptionService.TGetListAll();
            return View(values);
        }

        [HttpGet]
        public IActionResult Index(int id)
        {
            var values = _blogAboutPictureOrDescriptionService.TGetById(1);
            return View(values);
        }

        [HttpPost]
        public IActionResult Index(BlogAboutPictureOrDescription blogAboutPictureOrDescription)
        {
            _blogAboutPictureOrDescriptionService.TUpdate(blogAboutPictureOrDescription);
            return RedirectToAction("Index");
        }
    }
}
