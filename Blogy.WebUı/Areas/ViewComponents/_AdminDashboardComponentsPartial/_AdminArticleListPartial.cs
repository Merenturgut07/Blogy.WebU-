using Blogy.BussinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.Areas.ViewComponents._AdminDashboardComponentsPartial
{
    public class _AdminArticleListPartial : ViewComponent
    {
        private readonly IArticleService _articleService;

        public _AdminArticleListPartial(IArticleService articleService)
        {
            _articleService = articleService;
        }

        public IViewComponentResult Invoke()
        {
            //var values = _articleService.TGetListAll().Take(5).FirstOrDefault();
            var values = _articleService.TGetListAll().OrderByDescending(x => x.ArticleId).Take(5).ToList();
            return View(values);
        }
    }
}
