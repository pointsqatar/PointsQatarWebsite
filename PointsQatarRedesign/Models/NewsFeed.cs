using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointsQatarRedesign.Models
{
    public class Pagination
    {
        public string TotalPages { get; set; }
        public string PageNo { get; set; }
        public string PerPage { get; set; }
        public string WebURL { get; set; }
    }

    public class Image
    {
        public string Photo { get; set; }
        public string Thumb { get; set; }
        public string PhotoCaption { get; set; }
    }

    public class NewsItem
    {
        public string NewsItemId { get; set; }
        public string HeadLine { get; set; }
        public string ByLine { get; set; }
        public string Agency { get; set; }
        public string DateLine { get; set; }
        public string WebURL { get; set; }
        public string Caption { get; set; }
        public string Keywords { get; set; }
        public string Story { get; set; }
        public string CommentCountUrl { get; set; }
        public string CommentFeedUrl { get; set; }
        public string Related { get; set; }
        public Image Image { get; set; }
    }

    public class NewsFeed
    {
        public Pagination Pagination { get; set; }
        public List<NewsItem> NewsItem { get; set; }
    }
}
