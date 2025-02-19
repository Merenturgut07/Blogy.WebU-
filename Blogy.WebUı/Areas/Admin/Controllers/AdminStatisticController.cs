using Blogy.DataAccesLayer.Context;
using Blogy.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]/{id?}")]
    public class AdminStatisticController : Controller
    {

        public IActionResult Index()
        {
            BlogyContext c = new BlogyContext();
            // ilk 4 lü  toplam adetleri
            var deger1 = c.Writers.Count().ToString();
            ViewBag.d1 = deger1;
            var deger2 = c.Articles.Count().ToString();
            ViewBag.d2 = deger2;
            var deger3 = c.blogSendContacts.Count().ToString();
            ViewBag.d3 = deger3;
            var deger4 = c.Categories.Count().ToString();
            ViewBag.d4 = deger4;

            // 2. 4 lü


            var deger5 = c.Articles.OrderByDescending(x => x.CreatedDate).Select(x => x.Title).FirstOrDefault();
            ViewBag.d5 = deger5;


            var deger6 = c.notifications.OrderByDescending(x => x.Date).Select(x => x.Name).FirstOrDefault();
            ViewBag.d6 = deger6;


            var deger7 = c.Tags.OrderByDescending(x => x.TagId).Select(x => x.Tag3).FirstOrDefault();
            ViewBag.d7 = deger7;

            var deger8 = c.toDoLists.Count().ToString();
            ViewBag.d8 = deger8;


            //3. 4 lü

            var deger9 = c.toDoLists.OrderByDescending(x => x.ToDoListId).Select(x => x.Description).FirstOrDefault();
            ViewBag.d9 = deger9;


            var deger10 = c.Writers.OrderByDescending(x => x.WriterTableId).Select(x => x.UserName).FirstOrDefault();
            ViewBag.d10 = deger10;


            var deger11 = c.Comments.OrderByDescending(x => x.CommentId).Select(x => x.NameSurname).FirstOrDefault();
            ViewBag.d11 = deger11;

            var deger12 = c.writerMessages
                        .GroupBy(x => x.Receiver) // Alıcıya göre gruplama
                        .OrderByDescending(g => g.Count()) // Mesaj sayısına göre azalan sıralama
                        .Select(g => g.Key) // En çok mesaj alan kişinin e-posta adresini seçme
                        .FirstOrDefault(); // İlkini al (en çok mesaj alan)
            ViewBag.d12 = deger12;




            return View();
        }
    }
}
