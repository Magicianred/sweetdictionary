using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SweetDictionary.Controllers
{
    public class İstatistikController : Controller
    {
        Context db = new Context();
        // GET: İstatistik
        public ActionResult Index()
        {
            var queryCategoryCount = db.Categories.Count().ToString();
            ViewBag.a1 = queryCategoryCount;

            var querySoftwareTitleCount = db.Headings.Count(x => x.HeadingName == "Yazılım").ToString();
            ViewBag.a2 = querySoftwareTitleCount;
  
            var a3 = (from x in db.Writers select x.WriterFirstName.IndexOf("a")).Distinct().Count().ToString();
            ViewBag.a3 = a3;
   
            var a4 = db.Categories.Where(z=>z.CategoryId == db.Headings.GroupBy(x => x.CategoryId).OrderByDescending(x => x.Count()).Select(x => x.Key).FirstOrDefault()).Select(x => x.CategoryName).FirstOrDefault();
            ViewBag.a4 = a4;
           
            var a5 = db.Categories.Count(x => x.CategoryStatus == true) - db.Categories.Count(x => x.CategoryStatus == false);
            ViewBag.a5 = a5;
            return View();

        }
    }
}