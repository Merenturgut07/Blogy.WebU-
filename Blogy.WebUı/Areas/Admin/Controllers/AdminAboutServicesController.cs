using Blogy.BussinessLayer.Abstract;
using Blogy.EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]/{id?}")]
    [Authorize(Roles = "Admin")]
    public class AdminAboutServicesController : Controller
    {
        private readonly IBlogAboutServiceService _blogAboutServiceService;

        public AdminAboutServicesController(IBlogAboutServiceService blogAboutServiceService)
        {
            _blogAboutServiceService = blogAboutServiceService;
        }

        public IActionResult Index()
        {
            var values=_blogAboutServiceService.TGetListAll();
            return View(values);
        }

        public IActionResult DeleteService(int id)
        {
            _blogAboutServiceService.TDelete(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult CreateService()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateService(BlogAboutService blogAboutService)
        {
            _blogAboutServiceService.TInsert(blogAboutService);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateService(int id)
        {
            var values=_blogAboutServiceService.TGetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateService(BlogAboutService blogAboutService)
        {
            _blogAboutServiceService.TUpdate(blogAboutService);
            return RedirectToAction("Index");
        }
    }
}
