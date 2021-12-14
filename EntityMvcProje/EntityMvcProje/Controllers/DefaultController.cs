using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity; //unutma
using EntityMvcProje.Models.Sınıflar;


namespace EntityMvcProje.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            Context c = new Context();
            var degerler = c.Yeteneklers.ToList(); //yetenekler liste olarak gelsin
            return View(degerler);
        }

    }
}