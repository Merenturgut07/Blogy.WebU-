using Blogy.BussinessLayer.Abstract;
using Blogy.DataAccesLayer.Context;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.Areas.ViewComponents._AdminLayoutViewComponents
{
    public class _AdminLayoutNavbarMessageListPartial:ViewComponent
    {
        private readonly IWriterMessageService _writerMessageService;

        public _AdminLayoutNavbarMessageListPartial(IWriterMessageService writerMessageService)
        {
            _writerMessageService = writerMessageService;
        }

        public IViewComponentResult Invoke()
        {
            string p = "Admin@gmail.com";
            var values=_writerMessageService.GetListReceiverMessage(p).OrderByDescending(x=>x.WriterMessageId).Take(3).ToList();
            return View(values);
        }
    }
}
