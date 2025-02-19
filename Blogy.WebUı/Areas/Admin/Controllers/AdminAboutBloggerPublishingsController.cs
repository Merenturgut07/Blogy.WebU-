using Blogy.BussinessLayer.Abstract;
using Blogy.EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]/{id?}")]
    [Authorize(Roles="Admin")]
    public class AdminAboutBloggerPublishingsController : Controller
    {
        private readonly IBlogAboutBloggerPublishingService _blogAboutBloggerPublishingService;

        public AdminAboutBloggerPublishingsController(IBlogAboutBloggerPublishingService blogAboutBloggerPublishingService)
        {
            _blogAboutBloggerPublishingService = blogAboutBloggerPublishingService;
        }

        public IActionResult Index()
        {
            var values = _blogAboutBloggerPublishingService.TGetListAll();
            return View(values);
        }

        public IActionResult DeleteBloggerPublishings(int id)
        {
            _blogAboutBloggerPublishingService.TDelete(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult CreateBloggerPublishings()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateBloggerPublishings(BlogAboutBloggerPublishing blogAboutBloggerPublishing)
        {
            _blogAboutBloggerPublishingService.TInsert(blogAboutBloggerPublishing);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateBloggerPublishings(int id)
        {
            var values=_blogAboutBloggerPublishingService.TGetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateBloggerPublishings(BlogAboutBloggerPublishing blogAboutBloggerPublishing)
        {
            _blogAboutBloggerPublishingService.TUpdate(blogAboutBloggerPublishing);
            return RedirectToAction("Index");
        }


    }
}
