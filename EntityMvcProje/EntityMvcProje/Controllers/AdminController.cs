using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity; //Bu iki kütüphaneyi listeleme yapabilmek için ekledik.
using EntityMvcProje.Models.Sınıflar;

namespace EntityMvcProje.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context c = new Context();
        public ActionResult Index()
        {
            var degerler = c.Yeteneklers.ToList();
            return View(degerler);
        }

        [HttpGet]
        public ActionResult YeniYetenek()
        {
            return View();
        }


        [HttpPost]
        public ActionResult YeniYetenek(Yetenekler y) //Yeni yetenek eklemeyi y nesnesi aracılığıyla tutarak yapıyoruz.
        {
            c.Yeteneklers.Add(y);
            c.SaveChanges();
            return View();
        }

        public ActionResult YetenekSil( int id)
        {
            //Burada id değişkeni silmek istediğimiz yeteneğin idsini tutar.
            var deger = c.Yeteneklers.Find(id);
            c.Yeteneklers.Remove(deger);
            c.SaveChanges();

            return RedirectToAction("Index");

        }

        [HttpGet]
        public ActionResult YetenekGuncelle(int id)
        {
            //Burada id değişkeni güncellemek istediğimiz yeteneğin idsini tutar.
            var deger = c.Yeteneklers.Find(id);
           
            return View("YetenekGuncelle", deger);

        }

        [HttpPost]
        public ActionResult YetenekGuncelle(Yetenekler y)
        {
            //Burada id değişkeni güncellemek istediğimiz yeteneğin idsini tutar.
            var x = c.Yeteneklers.Find(y.ID);

            x.ACIKLAMA = y.ACIKLAMA;
            x.DEGER = y.DEGER;

            c.SaveChanges();

           return RedirectToAction("Index");

        }
    }
}