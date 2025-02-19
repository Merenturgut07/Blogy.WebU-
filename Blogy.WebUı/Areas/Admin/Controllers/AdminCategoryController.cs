using Blogy.BussinessLayer.Abstract;
using Blogy.EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]/{id?}")]
    //[Route("Admin/[controller]/[action]")]
    [Authorize(Roles = "Admin")]
    public class AdminCategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public AdminCategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            var values=_categoryService.TGetListAll();
            return View(values);
        }

        [HttpGet]
        public IActionResult CategoryAdd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CategoryAdd(Category category)
        {
            _categoryService.TInsert(category);
            return RedirectToAction("Index");
        }

        //[Route("CategoryDelete/{id}")]
        public IActionResult CategoryDelete(int id)
        {
            _categoryService.TDelete(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult CategoryUpdate(int id)
        {
            var values = _categoryService.TGetById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult CategoryUpdate(Category category)
        {
            _categoryService.TUpdate(category);
            return RedirectToAction("Index");
        }

    }
}
