using Blogy.BussinessLayer.Abstract;
using Blogy.BussinessLayer.Concrate;
using Blogy.DataAccesLayer.Context;
using Blogy.DataAccesLayer.EntityFramework;
using Blogy.EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]/{id?}")]
    [Authorize(Roles = "Admin")]
    public class AdminMessageController : Controller
    {
        private readonly IWriterMessageService _writerMessageService;

        public AdminMessageController(IWriterMessageService writerMessageService)
        {
            _writerMessageService = writerMessageService;
        }

        public IActionResult ReceiverMessageList()
        {
            string p;
            p = "Admin@gmail.com";
            var values = _writerMessageService.GetListReceiverMessage(p);
            return View(values);
        }

        public IActionResult ReceiverMessageDetails(int id)
        {
            var values = _writerMessageService.TGetById(id);
            return View(values);
        }



        public IActionResult SenderMessageList()
        {
            string p;
            p = "Admin@gmail.com";
            var values = _writerMessageService.GetListSenderMessage(p);
            return View(values);
        }

        public IActionResult SenderMessageDetails(int id)
        {
            var values = _writerMessageService.TGetById(id);
            return View(values);
        }

        public IActionResult AdminMessageDelete(int id)
        {
            var val = _writerMessageService.TGetById(id);
            _writerMessageService.TDelete(val.WriterMessageId);
            if (val.Receiver == "Admin@gmail.com")
            {
                return RedirectToAction("ReceiverMessageList");
            }
            else
            {
                return RedirectToAction("SenderMessageList");
            }
        }


        [HttpGet]
        public IActionResult CreateMessage()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateMessage(WriterMessage p)
        {
            p.Sender = "Admin@gmail.com";
            p.SenderName = "Admin";
            p.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            BlogyContext c= new BlogyContext();
            var usernamesurname = c.Users.Where(x => x.Email == p.Receiver).Select(y => y.Name + " " + y.Surname).FirstOrDefault();
            p.ReceiverName = usernamesurname;
            _writerMessageService.TInsert(p);
            return RedirectToAction("SenderMessageList");
        }
    }
}
