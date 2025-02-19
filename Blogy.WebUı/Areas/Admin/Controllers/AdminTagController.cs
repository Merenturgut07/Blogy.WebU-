using Blogy.BussinessLayer.Abstract;
using Blogy.EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]/{id?}")]
    [Authorize(Roles = "Admin")]
    public class AdminTagController : Controller
    {
        private readonly ITagService _tagService;

        public AdminTagController(ITagService tagService)
        {
            _tagService = tagService;
        }

        public IActionResult Index()
        {
            var values=_tagService.TGetListAll();
            return View(values);
        }

        public IActionResult DeleteTag(int id) 
        {
            _tagService.TDelete(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult CreateTag()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateTag( Tag tag)
        {
            _tagService.TInsert(tag);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateTag(int id)
        {
            var values=_tagService.TGetById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateTag(Tag tag)
        {
            _tagService.TUpdate(tag);
            return RedirectToAction("Index");
        }



    }
}
