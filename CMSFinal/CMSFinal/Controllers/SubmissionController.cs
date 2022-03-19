using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CMSFinal.Models;

namespace CMSFinal.Controllers
{
    public class SubmissionController : Controller
    {
        private CMSEntities db = new CMSEntities();

        // GET: Submission
        public ActionResult Index()
        {
            return View(db.Submissions.ToList());
        }

        // GET: Submission/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Submission submission = db.Submissions.Find(id);
            if (submission == null)
            {
                return HttpNotFound();
            }
            return View(submission);
        }

        //GET: Submission/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Submission/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SubmissionId,SubmissionName,SubmissionDescription, ClosureDate, FinalClosureDate")] Submission submission)
        {
            if (ModelState.IsValid)
            {
                db.Submissions.Add(submission);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(submission);
        }
    }
}