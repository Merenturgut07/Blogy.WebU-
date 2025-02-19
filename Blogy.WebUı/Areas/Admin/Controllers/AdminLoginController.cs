using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.Areas.Admin.Controllers
{
    public class AdminLoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
