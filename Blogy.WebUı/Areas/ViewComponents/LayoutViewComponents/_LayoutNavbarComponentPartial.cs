using Blogy.BussinessLayer.Concrate;
using Blogy.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.Areas.ViewComponents.LayoutViewComponents
{
	public class _LayoutNavbarComponentPartial:ViewComponent
	{
        public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
