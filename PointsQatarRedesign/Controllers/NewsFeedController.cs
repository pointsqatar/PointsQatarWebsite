using PointsQatarRedesign.Models;
using PointsQatarReDesignBusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml;

namespace PointsQatarRedesign.Controllers
{
    public class NewsFeedController : Controller
    {
        // GET: NewsFeed
        public ActionResult GetQatarNews()
        {
            string newsFeed = NewsFeedManager.GetQatarNewsFeed();

            List<QatarNewsFeedModel> qatarNews = ConstructQatarNews(newsFeed);
            if (qatarNews != null)
            {
                ViewBag.QatarNews = qatarNews;
            }

            return Json(qatarNews, JsonRequestBehavior.AllowGet);
        }

        private List<QatarNewsFeedModel> ConstructQatarNews(string newsFeedString)
        {
            List<QatarNewsFeedModel> news = new List<QatarNewsFeedModel>();
            if (newsFeedString != "error")
            {
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(newsFeedString);

                foreach (XmlElement item in doc.GetElementsByTagName("item"))
                {
                    string title = item.GetElementsByTagName("title")[0].InnerText;
                    string link = item.GetElementsByTagName("link")[0].InnerText;
                    string desc = item.GetElementsByTagName("description")[0].InnerText;

                    news.Add(new QatarNewsFeedModel { Title = title, Link = link, Description = desc });
                }
            }
            return news;
        }
    }
}