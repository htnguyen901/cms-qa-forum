using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CMSFinal.Models;
using Microsoft.AspNet.Identity;

namespace CMSFinal.Areas.Administrator.Controllers
{
    public class UserController : Controller
    {
        private CMSEntities db = new CMSEntities();
        // GET: Administrator/User

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult QaManager() //Publicly get action of 'Trainer' to set in other files
        {
            List<AspNetUser> Managers = new List<AspNetUser>();
            var role = db.AspNetRoles
                .Where(r => r.Name == "QAManager")
                .FirstOrDefault();
            if (role != null)
            {
                var users = db.AspNetUsers
                    .Where(u => u.AspNetRoles.Select(r => r.Id).Contains(role.Id))
                    .ToList();
                return View(users);
            }
            return View();
        }

        public ActionResult QaCoordinator() //Publicly get action of 'TrainingStaff' to set in other files
        {
            List<AspNetUser> Trainers = new List<AspNetUser>();
            var role = db.AspNetRoles
                .Where(r => r.Name == "QACoordinator")
                .FirstOrDefault();
            if (role != null)
            {
                var users = db.AspNetUsers
                    .Where(u => u.AspNetRoles.Select(r => r.Id).Contains(role.Id))
                    .ToList();
                return View(users);
            }
            return View();
        }

        [HttpGet] //Send data using a query string
        public ActionResult Edit(string id) //Publicly get action of 'Edit' to set in other files
        {
            var accountToEdit = this.db.AspNetUsers
                .Where(u => u.Id == id)
                .FirstOrDefault();
            if (accountToEdit == null)
            {
                var PreviousUrl = System.Web.HttpContext.Current.Request.UrlReferrer.ToString();
                return this.Redirect(PreviousUrl);
            }
            return this.View(accountToEdit);
        }

        [HttpPost] //Request method via Http page
        public ActionResult Edit(string id, AspNetUser user) //Get 'Edit' action to set in other files
        {
            var accountToEdit = this.db.AspNetUsers
                .Where(u => u.Id == id)
                .FirstOrDefault();
            if (accountToEdit == null)
            {
                return this.RedirectToAction("Index", "Home");
            }

            if (user != null && this.ModelState.IsValid)
            {
                accountToEdit.FullName = user.FullName;
                accountToEdit.Email = user.Email;
                accountToEdit.UserName = user.UserName;
                accountToEdit.PhoneNumber = user.PhoneNumber;


                this.db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            return this.View(user);
        }

        [HttpGet]
        public ActionResult Delete(string id)
        {
            var url = System.Web.HttpContext.Current.Request.UrlReferrer.ToString();
            var user = db.AspNetUsers.Find(id);
            if (user == null)
            {
                return Redirect(url);
            }
            db.AspNetUsers.Remove(user);

            db.SaveChanges();
            return Redirect(url);
        }


        public ActionResult Role() //Publicly get 'Role' action to detail the role list
        {
            var Roles = db.AspNetRoles.ToList();
            return View(Roles);
        }

        public ActionResult RoleCreate() //Publicly get 'RoleCreate' action to create new roles
        {
            var Role = new AspNetRole();
            return View(Role);
        }

        [HttpPost] //Request method via Http page
        public ActionResult RoleCreate(AspNetRole Role) //Get 'RoleCreate' action to save into database
        {
            db.AspNetRoles.Add(Role);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}