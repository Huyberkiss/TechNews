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
        public ActionResult Register(string txtUsername, string txtPassword, string txtFullname, string txtEmail, string txtRole) {
            if (txtUsername == "" || txtUsername == null) {
                return View("Register");
            }

            var account = from Account in dbConnection.Accounts
                          where (Account.aUsername.Equals(txtUsername))
                          select Account;
            if (account.Count() != 0) {
                ViewBag.errorRe = "Username is existed!";
                return View("Register");
            }
            var email = dbConnection.Accounts.Where(info => info.aEmail.Equals(txtEmail));

            if (email.Count() != 0) {
                ViewBag.errorRe = "Email is existed!";
                return View("Register");
            }
            var acc = new Account();
            acc.aUsername = txtUsername;
            acc.aPassword = txtPassword;
            acc.aFullname = txtFullname;
            acc.aEmail = txtEmail;
            acc.aStatus = 0;
            acc.countryID = 1;
            acc.roleID = txtRole.Equals("user") ? 2 : 3;
            acc.aDateAdded = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd"));

            dbConnection.Accounts.Add(acc);

            dbConnection.SaveChanges();

            return RedirectToAction("Login");
        }

    }
}