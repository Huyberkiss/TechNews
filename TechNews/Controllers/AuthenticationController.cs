using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TechNews.DB;

namespace TechNews.Controllers {
    public class AuthenticationController : Controller {
        TechNewsEntities dbConnection;
        public AuthenticationController() {
            dbConnection = new TechNewsEntities();
            
        }

        // GET: Authentication
        public ActionResult Index() {

            if(Session["user_id"] != null) {
                return RedirectToAction("index", "Home");
            }

            if (TempData["error"] != null) {
               ViewBag.error = "User or password are not correct, please try again";
            }


            return View();
        }



        [HttpPost]
        public ActionResult Login(String user, String password) {

            var User = dbConnection.Accounts.Where(info => info.aUsername.Equals(user) && info.aPassword.Equals(password));

            if (User.Count() == 0) {
                TempData["error"] = true;
                return RedirectToAction("Index");


            }

            

            Session["user_id"] = User.First().aID;

            return RedirectToAction("Index", "Home");
        }

        public ActionResult LogOut() {

            // FormsAuthentication.SignOut();

            Session.Remove("user_id");

            return RedirectToAction("Index", "Home");
        }

    }
}