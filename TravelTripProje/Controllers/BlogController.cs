using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Class;

namespace TravelTripProje.Controllers
{
    public class BlogController : Controller
    {
        Context c = new Context();
        BlogYorum by = new BlogYorum();
        public ActionResult Index()
        {
            by.Deger1= c.Blogs.ToList();
            //var values = c.Blogs.ToList();
            by.Deger3 = c.Blogs.Take(3).ToList();
            return View(by);
        }
        public ActionResult BlogDetay(int id)
        {
            
            by.Deger1= c.Blogs.Where(x => x.ID == id).ToList();
            by.Deger2 = c.Yorums.Where(x => x.ID == id).ToList();
            //var values = c.Blogs.Where(x => x.ID == id).ToList();
            return View(by);
        }
        [HttpGet]
        public PartialViewResult YorumYap(int id)
        {
            ViewBag.deger = id;
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult YorumYap(Yorum p)
        {
            c.Yorums.Add(p);
            c.SaveChanges();
            return PartialView();
        }
    }
}