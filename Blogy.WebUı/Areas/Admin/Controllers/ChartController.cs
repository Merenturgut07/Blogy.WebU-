using Blogy.WebUI.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]/{id?}")]
    public class ChartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

      public IActionResult CategoryChart()
        {
            List<CategoryClass> list = new List<CategoryClass>();
            list.Add(new CategoryClass 
            {
                categoryname="Teknoloji",
                categorycount=10 
            });
            list.Add(new CategoryClass
            {
                categoryname = "Yazılım",
                categorycount = 14
            });
            list.Add(new CategoryClass
            {
                categoryname = "Spor",
                categorycount = 5
            });
            list.Add(new CategoryClass
            {
                categoryname = "Sinema",
                categorycount = 2
            });

            return Json(new { jsonlist = list });
        }
    }
}
