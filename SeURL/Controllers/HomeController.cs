using SeURL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SeURL.Controllers
{
    public class HomeController : Controller
    {
        MakaleContext db = new MakaleContext();  
        
        [Route("")]
        public ActionResult Index()
        {
            return View(db.Makale.ToList());
        }
        [Route("makale/{baslik}-{id:int}")]
        public ActionResult Detay(int id)
        {
            var makale = db.Makale.Where(m => m.Id == id).SingleOrDefault();
            return View(makale);
        }
    }


}