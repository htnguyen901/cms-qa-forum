﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CMSFinal.Areas.Administrator.Controllers
{
    public class HomeController : Controller
    {
        [Authorize(Roles="Admin, QAManager")]
        // GET: Administrator/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}