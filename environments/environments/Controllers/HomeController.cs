﻿using Microsoft.AspNetCore.Mvc;

namespace environments.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
