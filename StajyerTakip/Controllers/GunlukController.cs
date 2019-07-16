﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StajyerTakip.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StajyerTakip.Controllers
{
    public class GunlukController : Controller
    {
        private readonly Context db;
        public GunlukController(Context db)
        {
            this.db = db;
        }
        // GET: /<controller>/
        public IActionResult Ekle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Ekle(Models.Gunluk gunluk)
        {
            gunluk.OgrenciID = 1;
            db.Gunlukler.Add(gunluk);
            db.SaveChanges();
            return RedirectToAction("Ekle");


        }
        public IActionResult Duzenle(int id )
        {
            Models.Gunluk gunluk = db.Gunlukler.ToList().Find(x => x.ID == id);


            return View(gunluk);

        }
        [HttpPost]
        public IActionResult Duzenle(Models.Gunluk gunluk, int id)
        {
            Models.Gunluk anaveri = db.Gunlukler.Find(id);

            anaveri.Baslik = gunluk.Baslik;
            anaveri.Bilgiler = gunluk.Bilgiler;
            anaveri.Tarih = gunluk.Tarih;
            


            db.SaveChanges();
            return Redirect("~/Home/Index");
        }

        public ActionResult Listele(int id)
        {
            
            List<Models.Gunluk> gunlukler = db.Gunlukler.ToList().FindAll(x=>x.OgrenciID == id);
            
            return View(gunlukler);
        }
    }
}
