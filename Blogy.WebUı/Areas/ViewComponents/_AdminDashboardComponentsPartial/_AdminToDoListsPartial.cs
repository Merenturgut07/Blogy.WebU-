using Blogy.BussinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.Areas.ViewComponents._AdminDashboardComponentsPartial
{
    public class _AdminToDoListsPartial:ViewComponent
    {
        private readonly IToDoListService _toDoListService;

        public _AdminToDoListsPartial(IToDoListService toDoListService)
        {
            _toDoListService = toDoListService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _toDoListService.TGetListAll().OrderByDescending(x => x.ToDoListId).Take(5).ToList();
            return View(values);
        }
    }
}
