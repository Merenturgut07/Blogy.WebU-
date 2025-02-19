using Blogy.BussinessLayer.Abstract;
using Blogy.BussinessLayer.Concrate;
using Blogy.DataAccesLayer.EntityFramework;
using Blogy.EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]/{id?}")]
    [Authorize(Roles = "Admin")]
    public class AdminBlogContactController : Controller
    {
        BlogContactManager BlogContactManager  = new BlogContactManager(new EfBlogContactDal());

        private readonly IBlogContactService _blogContactService;

        public AdminBlogContactController(IBlogContactService blogContactService)
        {
            _blogContactService = blogContactService;
        }

        public IActionResult Index()
        {
            var values=_blogContactService.TGetListAll();
            return View(values);
        }

        public IActionResult DeleteContact(int id)
        {
            _blogContactService.TDelete(id);
            return RedirectToAction("Index");
        }

        public IActionResult DetailsContact(int id)
        {
            var values = _blogContactService.TGetById(id);
            return View(values);
        }


    }
}
