using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Class;

namespace TravelTripProje.Controllers
{
    
    public class AdminController : Controller
    {
        Context c = new Context();
        // GET: Admin
        [Authorize]
        public ActionResult Index()
        {
            var values = c.Blogs.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult YeniBlog()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniBlog(Blog p)
        {
            var values = c.Blogs.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult BlogSilme(int id)
        {
            var values = c.Blogs.Find(id);
            c.Blogs.Remove(values);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult BlogGetir(int id)
        {
            var values = c.Blogs.Find(id);
            return View("BlogGetir", values);
        }
        public ActionResult BlogGüncelleme(Blog p)
        {
            var value = c.Blogs.Find(p.ID);
            value.Baslik = p.Baslik;
            value.Tarih = p.Tarih;
            value.Acıklama = p.Acıklama;
            value.BlogImage = p.BlogImage;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult YorumListele()
        {
            var values = c.Yorums.ToList();
            return View(values);
        }
        public ActionResult YorumSil(int id)
        {
            var values = c.Yorums.Find(id);
            c.Yorums.Remove(values);
            c.SaveChanges();
            return RedirectToAction("YorumListele");
        }
        [HttpGet]
        public ActionResult YorumGetir(int id)
        {
            var values = c.Yorums.Find(id);
            return View("YorumGetir", values);
        }
        [HttpPost]
        public ActionResult YorumGüncelle(Yorum p)
        {
            var values = c.Yorums.Find(p.ID);
            values.KullaniciAdi = p.KullaniciAdi;
            values.Mail = p.Mail;
            values.Yorumlar = p.Yorumlar;
            c.SaveChanges();
            return RedirectToAction("YorumListele");
        }



    }
}