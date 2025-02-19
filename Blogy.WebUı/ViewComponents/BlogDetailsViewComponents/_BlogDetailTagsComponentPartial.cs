using Blogy.BussinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.ViewComponents.BlogDetailsViewComponents
{
	public class _BlogDetailTagsComponentPartial:ViewComponent
	{
		private readonly ITagService _tagService;

        public _BlogDetailTagsComponentPartial(ITagService tagService)
        {
            _tagService = tagService;
        }

        public IViewComponentResult Invoke()
		{
			var values = _tagService.TGetListAll();
			return View(values);
		}
	}
}
