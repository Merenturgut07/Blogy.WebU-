using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.Controllers
{
	
	public class BlogController : Controller
	{
		[AllowAnonymous]
		public IActionResult BlogList()
		{
			return View();
		}

		public IActionResult BlogDetail(int id)
		{
			ViewBag.i= id;
			return View();
		}
	}
}
