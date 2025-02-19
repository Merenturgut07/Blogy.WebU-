using Blogy.DataAccesLayer.Context;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Blogy.WebUI.Areas.ViewComponents._AdminDashboardComponentsPartial
{
    public class _AdminFeatureStatistics2Partial:ViewComponent
    {
        BlogyContext c=new BlogyContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = c.writerMessages.Where(x=>x.Sender=="Admin@gmail.com").Count();
            ViewBag.v2 = c.writerMessages.Where(x=>x.Receiver=="Admin@gmail.com").Count();
            ViewBag.v3 = c.writerMessages.Count();
            return View();
        }
    }
}

