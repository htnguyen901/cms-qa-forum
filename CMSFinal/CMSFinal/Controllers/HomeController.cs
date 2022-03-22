using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using CMSFinal.Models;
using System.Net;

namespace CMSFinal.Controllers
{
    public class HomeController : Controller
    {
        private CMSEntities db = new CMSEntities();
        public ActionResult Index()
        {
            var ideas = db.Ideas.Include(i => i.AspNetUser).Include(i => i.Category).Include(i => i.Submission);
            return View(ideas.ToList());
        }

        // GET: Ideas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Idea idea = db.Ideas.Find(id);
            if (idea == null)
            {
                return HttpNotFound();
            }
            return View(idea);
        }

        // GET: Ideas/Create
        public ActionResult Create()
        {
            ViewBag.UserId = new SelectList(db.AspNetUsers, "Id", "Email");
            ViewBag.CategoryId = new SelectList(db.Categories, "CategoryId", "CategoryName");
            ViewBag.SubmissionId = new SelectList(db.Submissions, "SubmissionId", "SubmissionName");
            return View();
        }

        // POST: Ideas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdeaId,Title,Description,Content,CreateDate,LastModifiedDate,UserId,CategoryId,SubmissionId")] Idea idea)
        {
            if (ModelState.IsValid)
            {
                db.Ideas.Add(idea);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.UserId = new SelectList(db.AspNetUsers, "Id", "Email", idea.UserId);
            ViewBag.CategoryId = new SelectList(db.Categories, "CategoryId", "CategoryName", idea.CategoryId);
            ViewBag.SubmissionId = new SelectList(db.Submissions, "SubmissionId", "SubmissionName", idea.SubmissionId);
            return View(idea);
        }
    }
}