using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HOTELPRO.Models.Entity;

namespace HOTELPRO.Controllers
{
    public class ODAController : Controller
    {
        // GET: ODA
        HotelEntities2 db = new HotelEntities2();

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult TUMODALAR()
        {
            var degerler = db.TBLODA.ToList();
            return View(degerler);
        }
        public ActionResult BOSODALAR()
        {
            var bos = db.TBLODA.Where(m => m.odaDurum == "BOŞ").ToList();
            return View(bos);
        }
        public ActionResult DOLUODALAR()
        {
            var dolu = db.TBLODA.Where(m => m.odaDurum == "DOLU").ToList();
            return View(dolu);
        }
        public ActionResult Sil(int id)
        {
            
            var sil = db.TBLODA.Find(id);
            db.TBLODA.Remove(sil);
            db.SaveChanges();
            return RedirectToAction("TUMODALAR");
        }
        public ActionResult OdaGetir(int id)
        {
            var oda = db.TBLODA.Find(id);
            return View("OdaGetir", oda);
        }
        public ActionResult Guncelle(TBLODA p)
        {
            var oda = db.TBLODA.Find(p.odaId);
            oda.odaAd = p.odaAd;
            oda.odaKat = p.odaKat;
            oda.odaTur = p.odaTur;
            oda.odaFiyat = p.odaFiyat;
            oda.odaDurum = p.odaDurum;           
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        //Güncelle gelicek yarım kaldı
        [HttpGet]
        public ActionResult YeniKayit()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniKayit(TBLODA p1)
        {
            db.TBLODA.Add(p1);
            db.SaveChanges();
            return View();
        }

    }
}