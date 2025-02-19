using Blogy.EntityLayer.Concrete;
using Blogy.WebUI.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.Areas.Writer.Controllers
{
    [Area("Writer")]
    [Route("Writer/[controller]/[action]")]
    public class WriterRegisterController : Controller
    {

        private readonly UserManager<AppUser> _userManager;

        public WriterRegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }


        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Index(CreateRegisterViewModel p)
        {
            if (p.Password != null)
            {
                AppUser appUser = new AppUser()
                {
                    Name = p.Name,
                    Email = p.Email,
                    Surname = p.Surname,
                    UserName = p.UserName,
                    Description = "aa",
                    ImageUrl = "bb"
                };

                var result = await _userManager.CreateAsync(appUser, p.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "WriterLogin");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }


                return View();
            }
            else
            {
                ModelState.AddModelError("", "Şifre Alanı Boş Geçilemez");
                return View();
            }

        }



    }
}
