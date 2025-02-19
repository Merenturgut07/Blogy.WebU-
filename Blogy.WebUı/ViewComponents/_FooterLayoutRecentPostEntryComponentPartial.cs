using Blogy.BussinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.ViewComponents
{
    public class _FooterLayoutRecentPostEntryComponentPartial:ViewComponent
    {
        private readonly IArticleService _articleService;

        public _FooterLayoutRecentPostEntryComponentPartial(IArticleService articleService)
        {
            _articleService = articleService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _articleService.TGetListAll()
               .OrderByDescending(x => x.ArticleId) // ID'ye göre sırala (Büyükten küçüğe)
               .Take(3)
               .ToList();
            return View(values);
        }
    }
}
