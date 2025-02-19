using Blogy.BussinessLayer.Concrate;
using Blogy.DataAccesLayer.Context;
using Blogy.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace Blogy.WebUI.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class DashboardController : Controller
    {
        public ActionResult Index()
        {
             return View();
        }
    }
}
