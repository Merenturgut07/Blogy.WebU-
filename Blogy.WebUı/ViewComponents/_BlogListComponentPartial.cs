using Blogy.BussinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;
using X.PagedList.Extensions;

namespace Blogy.WebUI.ViewComponents
{
	public class _BlogListComponentPartial:ViewComponent
	{
		private readonly IArticleService _articleService;

		public _BlogListComponentPartial(IArticleService articleService)
		{
			_articleService = articleService;
		}

		public IViewComponentResult Invoke(int page=1)
		{
			var values=_articleService.TGetArticleWithWriter().ToPagedList(page,6);
			return View(values);
		}
	}
}
