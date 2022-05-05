using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Sınıflar;

namespace TravelTripProje.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context c = new Context();
        [Authorize]
        public ActionResult Index()
        {
            var deger = c.Blogs.ToList();
            
            return View(deger);
        }
        [HttpGet]
        public ActionResult YeniBlog()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniBlog(Blog p)
        {

            //if (results.IsValid)
            //{
                 c.Blogs.Add(p);
                 c.SaveChanges();
                return RedirectToAction("Index");

            //}
            //else
            //{
            //    foreach (var item in results.Errors)
            //    {
            //        ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
            //    }
            //}

            //return View();
        }
        public ActionResult BlogSil(int id)
        {
            var value = c.Blogs.Find(id);
            c.Blogs.Remove(value);
            c.SaveChanges();
            
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult BlogGetir(int id)
        {
            var value = c.Blogs.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult BlogGüncelle(Blog p)
        {
            var bg = c.Blogs.Find(p.ID);
            bg.Aciklama = p.Aciklama;
            bg.Baslik = p.Baslik;
            bg.Tarih = p.Tarih;
            bg.BlogImage = p.BlogImage;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult YorumListesi()
        {
            var yorumlar = c.Yorumlars.ToList();
            return View(yorumlar);
        }
        public ActionResult YorumSil(int id)
        {
            var value = c.Yorumlars.Find(id);
            c.Yorumlars.Remove(value);
            c.SaveChanges();
            return RedirectToAction("YorumListesi");
        }
        [HttpGet]
        public ActionResult YorumGetir(int id)
        {
            var value = c.Yorumlars.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult YorumGüncelle(Yorumlar p)
        {
            var bg = c.Yorumlars.Find(p.ID);
            bg.KullaniciAdi = p.KullaniciAdi;
            bg.Mail = p.Mail;
            bg.Yorum = p.Yorum;
            c.SaveChanges();
            return RedirectToAction("YorumListesi");
        }
        public ActionResult iletisimListesi()
        {
            var iletisim = c.İletisims.ToList();
            return View(iletisim);
        }
        public ActionResult iletisimSil(int id)
        {
            var value = c.İletisims.Find(id);
            c.İletisims.Remove(value);
            c.SaveChanges();
            return RedirectToAction("iletisimListesi");
        }
        public ActionResult hakkımızda()
        {
            var hakkımızda = c.Abouts.ToList();
            return View(hakkımızda);
        }
        [HttpGet]
        public ActionResult Yenihakkımızda()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Yenihakkımızda(About p)
        {

            
            c.Abouts.Add(p);
            c.SaveChanges();
            return RedirectToAction("hakkımızda");

           
        }
        public ActionResult HakkımızdaSil(int id)
        {
            var value = c.Abouts.Find(id);
            c.Abouts.Remove(value);
            c.SaveChanges();
            return RedirectToAction("hakkımızda");
        }
        [HttpGet]
        public ActionResult HakkımızdaGetir(int id)
        {
            var value = c.Abouts.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult HakkımızdaGüncelle(About p)
        {
            var bg = c.Abouts.Find(p.ID);
            bg.FoyoUrl = p.FoyoUrl;
            bg.Aciklama = p.Aciklama;
            
            c.SaveChanges();
            return RedirectToAction("Hakkımızda");
        }
    }
}