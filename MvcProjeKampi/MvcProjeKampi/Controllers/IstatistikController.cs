using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class IstatistikController : Controller
    {
        Context context = new Context();
        // GET: Istatistik
        public ActionResult Index()
        {
            var istatistik1 = context.Categories.Count();
            var istatistik2 = context.Headings.Count(x => x.Category.CategoryID == 7);
            var istatistik3 = context.Writers.Count(x => x.WriterName.Contains("a"));
            var istatistik4 = context.Headings.Max(x => x.Category.CategoryName);
            var istatistik5 = context.Categories.Count(x => x.CategoryStatus == true);
            var istatistik6 = context.Categories.Count(x => x.CategoryStatus == false);
            ViewBag.CategoryCount = istatistik1;
            ViewBag.Heading = istatistik2;
            ViewBag.Writer = istatistik3;
            ViewBag.HeadingMax = istatistik4;
            ViewBag.StatusFark = (istatistik5 - istatistik6);

            return View();
        }
    }
}