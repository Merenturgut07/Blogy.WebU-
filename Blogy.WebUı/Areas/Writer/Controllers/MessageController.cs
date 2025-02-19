using Blogy.BussinessLayer.Concrate;
using Blogy.DataAccesLayer.Context;
using Blogy.DataAccesLayer.EntityFramework;
using Blogy.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.Areas.Writer.Controllers
{
    [Area("Writer")]
    [Route("Writer/Message")]
    public class MessageController : Controller
    {
        WriterMessageManager writerMessageManager = new WriterMessageManager(new EfWriterMessageDal());

        private readonly UserManager<AppUser> _userManager;

        public MessageController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        [Route("")]
        [Route("ReceiverMessage")]
        public async Task<IActionResult> ReceiverMessage(string p)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            p = values.Email;
            var messagelist = writerMessageManager.GetListReceiverMessage(p);
            return View(messagelist);
        }


        [Route("ReceiverDetails/{id}")]
        public IActionResult ReceiverDetails(int id)
        {
            WriterMessage writerMessage = writerMessageManager.TGetById(id);
            return View(writerMessage);
        }


        [Route("")]
        [Route("SenderMessage")]

        public async Task<IActionResult> SenderMessage(string p)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            p = values.Email;
            var messagelist = writerMessageManager.GetListSenderMessage(p);
            return View(messagelist);
        }


        [Route("SenderDetails/{id}")]
        public IActionResult SenderDetails(int id)
        {
            WriterMessage writerMessage = writerMessageManager.TGetById(id);
            return View(writerMessage);
        }






        [HttpGet]
        [Route("")]
        [Route("SendMessage")]
        public IActionResult SendMessage()
        {
            return View();
        }
        [HttpPost]
        [Route("")]
        [Route("SendMessage")]
        public async Task<IActionResult> SendMessage(WriterMessage p)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            string mail = values.Email;
            string name = values.Name + " " + values.Surname;
            p.Date = Convert.ToDateTime(DateTime.Now.ToShortTimeString());
            p.Sender = mail;
            p.SenderName = name;

            BlogyContext c = new BlogyContext();
            var usernamesurname = c.Users.Where(x => x.Email == p.Receiver).Select(y => y.Name + " " + y.Surname).FirstOrDefault();
            p.ReceiverName = usernamesurname;

            writerMessageManager.TInsert(p);
            return RedirectToAction("SenderMessage");
        }


    }
}
