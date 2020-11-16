using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Web;

namespace TechNews.ViewModel {
    public class HomeViewModel {

       

        public int CateId { get; set; }
        public string CateName { get; set; }
        public int PostId { get; set; }
        public string Title { get; set; }
        public string PosterName { get; set; }
        public DateTime PostedDay { get; set; }
        public string Content { get; set; }

        public string mainPic { get; set; }

      
    }
}