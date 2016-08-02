using PointsQatarReDesignBusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PointsQatarRedesign.Models;
using Newtonsoft.Json;
using System.Xml;

namespace PointsQatarRedesign.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [ActionName("index")]
        public ActionResult Index()
        {
            ViewBag.isIndexActive = "active";
            ViewBag.isServicesActive = string.Empty;
            ViewBag.isAboutUsActive = string.Empty;
            ViewBag.isContacuUsActive = string.Empty;
            ViewBag.isPlatformsActive = string.Empty;
            ViewBag.isTradingActive = string.Empty;
            return View();
        }

        [ActionName("services")]
        public ActionResult Services()
        {
            ViewBag.isIndexActive = string.Empty;
            ViewBag.isServicesActive = "active";
            ViewBag.isAboutUsActive = string.Empty;
            ViewBag.isContacuUsActive = string.Empty;
            ViewBag.isPlatformsActive = string.Empty;
            ViewBag.isTradingActive = string.Empty;
            return View();
        }

        [ActionName("contact")]
        public ActionResult Contact()
        {
            ViewBag.isIndexActive = string.Empty;
            ViewBag.isServicesActive = string.Empty;
            ViewBag.isAboutUsActive = string.Empty;
            ViewBag.isContacuUsActive = "active";
            ViewBag.isPlatformsActive = string.Empty;
            ViewBag.isTradingActive = string.Empty;
            return View();
        }

        [ActionName("aboutus")]
        public ActionResult AboutUs()
        {
            ViewBag.isIndexActive = string.Empty;
            ViewBag.isServicesActive = string.Empty;
            ViewBag.isAboutUsActive = "active";
            ViewBag.isContacuUsActive = string.Empty;
            ViewBag.isPlatformsActive = string.Empty;
            ViewBag.isTradingActive = string.Empty;
            return View();
        }

        [ActionName("platforms")]
        public ActionResult Platforms()
        {
            ViewBag.isIndexActive = string.Empty;
            ViewBag.isServicesActive = string.Empty;
            ViewBag.isAboutUsActive = string.Empty;
            ViewBag.isContacuUsActive = string.Empty;
            ViewBag.isPlatformsActive = "active";
            ViewBag.isTradingActive = string.Empty;
            return View();
        }

        [ActionName("trading")]
        public ActionResult Trading()
        {
            ViewBag.isIndexActive = string.Empty;
            ViewBag.isServicesActive = string.Empty;
            ViewBag.isAboutUsActive = string.Empty;
            ViewBag.isContacuUsActive = string.Empty;
            ViewBag.isPlatformsActive = string.Empty;
            ViewBag.isTradingActive = "active";

            return View();
        }
    }
}