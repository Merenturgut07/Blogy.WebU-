using Blogy.BussinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.Areas.ViewComponents._AdminDashboardComponentsPartial
{
    public class _AdminPortfolioSliderPartial:ViewComponent
    {
        private readonly IArticleService _articleService;

        public _AdminPortfolioSliderPartial(IArticleService articleService)
        {
            _articleService = articleService;
        }

        public IViewComponentResult Invoke()
        {
            var values=_articleService.TGetListAll();
            return View(values);
        }
    }
}
