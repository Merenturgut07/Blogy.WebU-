﻿using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.Controllers
{
    public class BlogLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
