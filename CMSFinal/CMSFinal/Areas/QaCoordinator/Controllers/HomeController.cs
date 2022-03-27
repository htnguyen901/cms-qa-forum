using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CMSFinal.Areas.QaCoordinator.Controllers
{
    public class HomeController : Controller
    {
        [Authorize(Roles="QACoordinator")]
        // GET: QaCoor/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}