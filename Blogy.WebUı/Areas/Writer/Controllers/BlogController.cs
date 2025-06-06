﻿using Blogy.BussinessLayer.Abstract;
using Blogy.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace Blogy.WebUI.Areas.Writer.Controllers
{
	[Area("Writer")]
    [Route("Writer/[controller]/[action]/{id?}")]
    //[Route("Writer/[controller]/[action]")]

    public class BlogController : Controller
	{
		private readonly UserManager<AppUser> _userManager;
		private readonly IArticleService _articleService;
		private readonly ICategoryService _categoryService;


		public BlogController(UserManager<AppUser> userManager, IArticleService articleService, ICategoryService categoryService)
		{
			_userManager = userManager;
			_articleService = articleService;
			_categoryService = categoryService;
		}

		public async Task<IActionResult> MyBlogList()
		{
			var user = await _userManager.FindByNameAsync(User.Identity.Name);

			var values= _articleService.TGetArticlesByWriter(user.Id);

			return View(values);
		}


		[HttpGet]
		public IActionResult CreateBlog()
		{
			List<SelectListItem> values = (from x in _categoryService.TGetListAll()
										   select new SelectListItem
										   {
											   Text = x.CategoryName,
											   Value = x.CategoryId.ToString()
										   }).ToList();
			ViewBag.v = values;
										 
			return View();
		}


		[HttpPost]
		public async Task<IActionResult> CreateBlog(Article article)
		{
			var user = await _userManager.FindByNameAsync(User.Identity.Name);
			article.AppUserId=user.Id;
			article.WriterId = user.Id;
			article.CreatedDate = DateTime.Now;
			_articleService.TInsert(article);
			return RedirectToAction("MyBlogList");
		}


		public IActionResult DeleteBlog(int id)
		{
			_articleService.TDelete(id);
			return RedirectToAction("MyBlogList");
		}

		[HttpGet]
		public IActionResult EditBlog(int id)
		{
			List<SelectListItem> values1 = (from x in _categoryService.TGetListAll()
										   select new SelectListItem
										   {
											   Text = x.CategoryName,
											   Value = x.CategoryId.ToString()
										   }).ToList();
			ViewBag.v = values1;
			var values = _articleService.TGetById(id);
			return View(values);
		}

		[HttpPost]
		public IActionResult EditBlog(Article article)
		{
			_articleService.TUpdate(article);
			return RedirectToAction("MyBlogList");
		}

	}
}
