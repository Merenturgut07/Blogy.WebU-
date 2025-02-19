using Blogy.BussinessLayer.Abstract;
using Blogy.EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]/{id?}")]
    [Authorize(Roles = "Admin")]
    public class AdminToDoListController : Controller
    {
        private readonly IToDoListService _toDoListService;

        public AdminToDoListController(IToDoListService toDoListService)
        {
            _toDoListService = toDoListService;
        }

        public IActionResult Index()
        {
            var values=_toDoListService.TGetListAll();
            return View(values);
        }

        public IActionResult DeleteToDoList(int id)
        {
            _toDoListService.TDelete(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult CreateToDoList()
        {
            return View();  
        }

        [HttpPost]
        public IActionResult CreateToDoList(ToDoList toDoList)
        {

            _toDoListService.TInsert(toDoList);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateToDoList(int id)
        {
            var values=_toDoListService.TGetById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateToDoList(ToDoList toDoList)
        {
            _toDoListService.TUpdate(toDoList);
            return RedirectToAction("Index");
        }

    }
}
