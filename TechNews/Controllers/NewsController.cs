using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TechNews.DB;
using TechNews.ViewModel;

namespace TechNews.Controllers {
    public class NewsController : Controller {
        TechNewsEntities _dbContext;
        public NewsController() {
            _dbContext = new TechNewsEntities();
        }

        // GET: News
        public ActionResult Index() {
            ViewBag.category = _dbContext.Categories.Select(cate => cate).ToList();
            var Posts = (from post in _dbContext.Posts
                         join history in _dbContext.Histories on post.hID equals history.hID
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

            ViewBag.posts = Posts;



            return View();
        }



    }
}