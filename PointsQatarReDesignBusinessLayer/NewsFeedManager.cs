using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PointsQatarReDesignBusinessLayer
{
    public class NewsFeedManager
    {
        public static string GetNewsFeed()
        {
            string newsFeedURL = ConfigurationManager.AppSettings["newsFeed"];
            string newsfeed = string.Empty;
            using (WebClient client = new WebClient())
            {
                try
                {
                    newsfeed = client.DownloadString(newsFeedURL);
                }
                catch (Exception ex)
                {
                    newsfeed = "error";
                }
            }
            return newsfeed;
        }

        public static string GetQatarNewsFeed()
        {
            string newsFeedURL = ConfigurationManager.AppSettings["qatarNewsFeed"];
            string newsfeed = string.Empty;
            using (WebClient client = new WebClient())
            {
                try
                {
                    newsfeed = client.DownloadString(newsFeedURL);
                }
                catch (Exception ex)
                {
                    newsfeed = "error";
                }
            }
            return newsfeed;
        }
    }
}
