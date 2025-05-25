using Blogy.BussinessLayer.Abstract;
using Blogy.EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Blogy.WebUI.Controllers
{
    [AllowAnonymous]
    public class BlogController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly ICommentService _commentService;
        private readonly IArticleService _articleService;

        public BlogController(UserManager<AppUser> userManager, ICommentService commentService, IArticleService articleService)
        {
            _userManager = userManager;
            _commentService = commentService;
            _articleService = articleService;
        }

        public IActionResult BlogList(int page = 1)
        {
            ViewBag.Page = page;
            return View();
        }

        public async Task<IActionResult> BlogDetail(int id)
        {
            ViewBag.i = id;

            ViewBag.articleId = id;

            var value = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.userId = value.Id;
            var values = _commentService.TGetById(id);
            return View(values);
        }



        [HttpGet]
        public IActionResult AddComment()
        {
            return View();
        }


        [HttpPost]
        public IActionResult AddComment(Comment comment)
        {
            comment.CommentDate = DateTime.Now;
            comment.Status = true;
            comment.ImageUrl = "deneme";
            _commentService.TInsert(comment);
            return RedirectToAction("BlogList", "Blog");
        }



    }
}
