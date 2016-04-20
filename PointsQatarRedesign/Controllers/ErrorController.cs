using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PointsQatarRedesign.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        public ActionResult NotFound()
        {
            ViewBag.isIndexActive = string.Empty;
            ViewBag.isServicesActive = string.Empty;
            ViewBag.isAboutUsActive = string.Empty;
            ViewBag.isContacuUsActive = string.Empty;
            ViewBag.isPlatformsActive = string.Empty;
            return View("~/Views/Error.cshtml");
        }
    }
}