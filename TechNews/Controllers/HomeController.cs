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
                         join history in _dbContext.Histories on post.postID equals history.postID
                         join user in _dbContext.Accounts on history.posterID equals user.aID
                         join cate in _dbContext.Categories on post.cateID equals cate.cateID

                         select new HomeViewModel() {
                             PostId = post.postID,
                             Title = post.postTitle,
                             Content = post.postContent,
                             PosterName = user.aFullname,
                             PostedDay = (DateTime)history.dateAccepted,
                             CateId = cate.cateID,
                             CateName = cate.cateName

                         }).ToList();

            /*  Posts.ForEach(post => {
                  var _pic = _dbContext.Pictures.Select(pic => pic).Where( p => p.postID == post.PostId);
                  post.UrlPicture.AddRange(_pic);
              });*/

            Posts.ForEach(post => {
                post.mainPic = _dbContext.Pictures.Where(pic => pic.postID == post.PostId).Select(pic => pic.picURL).FirstOrDefault();
            });

            ViewBag.posts = Posts;


            ViewBag.category = _dbContext.Categories.ToList<Category>();

            return View();
        }


        public ActionResult About() {
            ViewBag.Message = "Your application description page.";



            return View();
        }

        public ActionResult Contact() {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
