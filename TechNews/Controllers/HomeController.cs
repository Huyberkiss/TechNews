using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TechNews.DB;
using TechNews.ViewModel;

namespace TechNews.Controllers {
    public class HomeController : Controller {

        private TechNewsEntities _dbContext;

        public HomeController() {
            _dbContext = new TechNewsEntities();
        }


        public ActionResult Index() {

            var Posts = (from post in _dbContext.Posts
                         join history in _dbContext.Histories on post.hID equals history.hID
                         join user in _dbContext.Accounts on history.posterID equals user.aID
                         select new HomeViewModel() {
                             Id = post.postID,
                             Title = post.postTitle,
                             Content = post.postContent,
                             PosterName = user.aFullname,
                             PostedDay = (DateTime)history.dateAccepted
                         }).ToList<HomeViewModel>();

            ViewBag.posts = Posts;  


            ViewBag.category = _dbContext.Categories.ToList<Category>();

            return View();
        }


        public ActionResult About(string x, string y) {
            ViewBag.Message = "Your application description page.";


            return View();
        }

        public ActionResult Contact() {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}