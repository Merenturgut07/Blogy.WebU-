using Blogy.BussinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.ViewComponents.BlogDetailsViewComponents
{
    public class _BlogDetailGetOutherBlogPostByWriterComponentPartial:ViewComponent
    {
        private readonly IArticleService _articleService;

        public _BlogDetailGetOutherBlogPostByWriterComponentPartial(IArticleService articleService)
        {
            _articleService = articleService;
        }

        public IViewComponentResult Invoke(int id)
        {
            var values = _articleService.TGetLast3BlogByAppUser(id);
            return View(values);
        }
    }
}
