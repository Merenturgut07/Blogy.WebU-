using Blogy.BussinessLayer.Abstract;
using Blogy.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Blogy.WebUI.Areas.ViewComponents.LayoutViewComponents
{
    public class _LayoutNavbarNotificationComponentPartial : ViewComponent
    {
        private readonly INotificationService _notification;

        public _LayoutNavbarNotificationComponentPartial(INotificationService notification)
        {
            _notification = notification;
        }

        public IViewComponentResult Invoke()
        {
            var values = _notification.TGetListAll().OrderByDescending(x=>x.NotificationId).Take(4).ToList();
            return View(values);
        }
    }
}
