using Blogy.BussinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.ViewComponents.BlogDetailsViewComponents
{
    public class _BlogDetailByBlogContentComponenetPartial:ViewComponent
    {
        private readonly IArticleService _articleService;

		public _BlogDetailByBlogContentComponenetPartial(IArticleService articleService)
		{
			_articleService = articleService;
		}

		public IViewComponentResult Invoke(int id)
        {
            var values = _articleService.TGetById(id);
            return View(values);
        }
    }
}
