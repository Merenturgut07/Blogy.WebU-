using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.Controllers
{
    [AllowAnonymous]
    public class BlogAboutController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
    }
}
