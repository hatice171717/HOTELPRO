using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HOTELPRO.Models.Entity;

namespace HOTELPRO.Controllers
{
    public class MUSTERIController : Controller
    {
        // GET: MUSTERI
        HotelEntities2 db = new HotelEntities2();

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult TUMMUSTERILER()
        {
            var degerler = db.TBLMUSTERI.ToList();
            return View(degerler);
        }
        public ActionResult AKTİFMUSTERİLER()
        {
            var aktif = db.TBLMUSTERI.Where(m => m.musteriDurum == "AKTİF").ToList();
            return View(aktif);
        }
        public ActionResult PASİFMUSTERİLER()
        {
            var pasif = db.TBLMUSTERI.Where(m => m.musteriDurum == "PASİF").ToList();
            return View(pasif);
        }
        public ActionResult Sil(int id)
        {
            var sil = db.TBLMUSTERI.Find(id);
            db.TBLMUSTERI.Remove(sil);
            db.SaveChanges();
            return RedirectToAction("TUMMUSTERILER");
        }
        public ActionResult MusteriGetir(int id)
        {
            var musteri = db.TBLMUSTERI.Find(id);
            return View("MusteriGetir", musteri);
        }

        public ActionResult Guncelle(TBLMUSTERI p)
        {
            var musteri = db.TBLMUSTERI.Find(p.musteriId);
            musteri.musteriKimlik = p.musteriKimlik;
            musteri.musteriAd = p.musteriAd;
            musteri.musteriSoyad = p.musteriSoyad;
            musteri.musteriUlke = p.musteriUlke;
            musteri.musteriDurum = p.musteriDurum;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult YeniKayit()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniKayit(TBLMUSTERI p1)
        {
            db.TBLMUSTERI.Add(p1);
            db.SaveChanges();
            return View();
        }

    }
}