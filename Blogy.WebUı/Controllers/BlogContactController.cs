using Blogy.BussinessLayer.Abstract;
using Blogy.BussinessLayer.ValidationRules.BlogContactValidation;
using Blogy.EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.Controllers
{
    [AllowAnonymous]
    public class BlogContactController : Controller
    {

        private readonly IBlogContactService _blogContactService;

        public BlogContactController(IBlogContactService blogContactService)
        {
            _blogContactService = blogContactService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(BlogSendContact blogSendContact)
        {
            SendMessageValidation validator = new SendMessageValidation();
            ValidationResult validationResult = validator.Validate(blogSendContact);

            if (validationResult.IsValid)
            {
                // Mesajı veritabanına ekle
                _blogContactService.TInsert(new BlogSendContact()
                {
                    NameSurname = blogSendContact.NameSurname,
                    Mail = blogSendContact.Mail,
                    Subject = blogSendContact.Subject,
                    Message = blogSendContact.Message,
                });

                // Başarı mesajını TempData'ya ekle
                TempData["SuccessMessage"] = "Mesajınız başarılı bir şekilde gönderilmiştir.";

                // Başarıyla işlem yaptıktan sonra, tekrar aynı sayfaya yönlendir
                return RedirectToAction("Index", "BlogContact");
            }
            else
            {
                // Validation hatalarını modelstate'e ekle
                foreach (var item in validationResult.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }

            // Eğer validasyon hatası varsa, hatalarla birlikte tekrar view'i döndür
            return View(blogSendContact);
        }



    }
}

