using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CMSFinal.Areas.QaManager.Controllers
{
    public class HomeController : Controller
    {
        // GET: QaManager/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}