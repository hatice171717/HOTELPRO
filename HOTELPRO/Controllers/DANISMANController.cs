using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HOTELPRO.Models.Entity;

namespace HOTELPRO.Controllers
{
    public class DANISMANController : Controller
    {
        // GET: DANISMAN
        HotelEntities2 db = new HotelEntities2();
        public ActionResult Index()
        {
            var degerler = db.TBLDANISMAN.ToList();
            return View(degerler);
        }

        public ActionResult Sil(int id)
        {
            var sil = db.TBLDANISMAN.Find(id);
            db.TBLDANISMAN.Remove(sil);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DanismanGetir(int id)
        {
            var danısman = db.TBLDANISMAN.Find(id);
            return View("DanismanGetir", danısman);
        }

        public ActionResult Guncelle(TBLDANISMAN p)
        {
            var danısman = db.TBLDANISMAN.Find(p.danismanId);
            danısman.danismanTc = p.danismanTc;
            danısman.danismanAd = p.danismanAd;
            danısman.danismanSoyad = p.danismanSoyad;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult YeniKayit()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniKayit(TBLDANISMAN p1)
        {
            db.TBLDANISMAN.Add(p1);
            db.SaveChanges();
            return View();
        }



    }
}