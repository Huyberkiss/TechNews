using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TechNews.ViewModel {
    public class HomeViewModel {

        public int Id { get; set; }
        public string Title { get; set; }
        public string PosterName { get; set; }
        public DateTime PostedDay { get; set; }
        public string Content { get; set; }

    }
}