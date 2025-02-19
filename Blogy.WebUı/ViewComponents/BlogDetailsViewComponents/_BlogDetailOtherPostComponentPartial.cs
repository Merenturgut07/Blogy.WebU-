using Blogy.BussinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.ViewComponents.BlogDetailsViewComponents
{
    public class _BlogDetailOtherPostComponentPartial:ViewComponent
    {
        private readonly IArticleService _articleService;

        public _BlogDetailOtherPostComponentPartial(IArticleService articleService)
        {
            _articleService = articleService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _articleService.TGetListAll()
                            .OrderByDescending(x => x.ArticleId) // Tarihe göre sıralama (en yeni makaleler önce)
                            .Take(4) // Son 4 makaleyi al
                            .ToList();
            return View(values);
        }
    }
}
