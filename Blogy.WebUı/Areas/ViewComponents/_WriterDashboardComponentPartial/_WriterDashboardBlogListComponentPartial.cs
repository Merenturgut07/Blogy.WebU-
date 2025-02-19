using Blogy.BussinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.Areas.ViewComponents._WriterDashboardComponentPartial
{
    public class _WriterDashboardBlogListComponentPartial:ViewComponent
    {
        private readonly IArticleService _articleService;

        public _WriterDashboardBlogListComponentPartial(IArticleService articleService)
        {
            _articleService = articleService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _articleService.TGetListAll();
            return View(values);
        }
    }
}
