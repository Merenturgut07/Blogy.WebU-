using Blogy.DataAccesLayer.Context;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.Areas.ViewComponents._AdminDashboardComponentsPartial
{
    public class _AdminFeatureStatisticsPartial : ViewComponent
    {
        BlogyContext c = new BlogyContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = c.Users.Count();
            ViewBag.v2 = c.Articles.Count();
            ViewBag.v3 = c.Categories.Count();
            ViewBag.v4 = c.Articles.OrderByDescending(x => x.ArticleId).Select(x => x.Title).FirstOrDefault();
            return View();
        }
    }
}
