using Blogy.BussinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.Areas.ViewComponents._AdminDashboardComponentsPartial
{
    public class _AdminBlogContactListPartial : ViewComponent
    {
        private readonly IBlogContactService _blogContactService;

        public _AdminBlogContactListPartial(IBlogContactService blogContactService)
        {
            _blogContactService = blogContactService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _blogContactService.TGetListAll().OrderByDescending(x => x.Id).Take(3).ToList();
            return View(values);
        }
    }
}
