﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Matrix.Web.Controllers
{
    public class JournalController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}