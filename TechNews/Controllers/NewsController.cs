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

            if (TempData["_PostByCate"] != null) {
                Posts = (List<HomeViewModel>)TempData["_PostByCate"];
            }

            ViewBag.posts = Posts;
            ViewBag.category = _dbContext.Categories.Select(cate => cate).ToList();


            return View();
        }

        [Route("News/Category/{cate_Id}")]
        public ActionResult Category(int cate_Id) {

            var Post = (from post in _dbContext.Posts
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

            var _PostByCate = Post.Where(post => post.CateId == cate_Id).Select(post => post).ToList();
            TempData["_PostByCate"] = _PostByCate;

            return RedirectToAction("Index");
        }



    }
}