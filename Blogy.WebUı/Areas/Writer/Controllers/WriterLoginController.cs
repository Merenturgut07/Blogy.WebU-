using Blogy.EntityLayer.Concrete;
using Blogy.WebUI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.Areas.Writer.Controllers
{
    [AllowAnonymous]
    [Area("Writer")]
    [Route("Writer/[controller]/[action]")]
    public class WriterLoginController : Controller
    {

        private readonly SignInManager<AppUser> _signInManager;

        public WriterLoginController(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }


        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserSigInViewModel model)
        {
            if (model.UserName != null && model.Password != null)
            {
                var result = await _signInManager.PasswordSignInAsync(model.UserName, model.Password, false, true);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Profile");
                }
                else
                {
                    ModelState.AddModelError("", "Kullanıcı adı veya şifre hatalı");
                }
            }
            else
            {
                ModelState.AddModelError("", "Lütfen Alanları Boş Geçmeyiniz");
            }
            return View();
        }


        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "WriterLogin");
        }


    }
}
