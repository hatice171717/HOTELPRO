using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HOTELPRO.Models.Entity;

namespace HOTELPRO.Controllers
{
    public class SATISController : Controller
    {
        // GET: SATIS
        HotelEntities2 db = new HotelEntities2();
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(TBLSATIS p1)
        {
            db.TBLSATIS.Add(p1);
            db.SaveChanges();
            return View();
        }
     
       
        public ActionResult Listele()
        {
            var liste = db.TBLSATIS.ToList();
            return View(liste);

        }

    }
}