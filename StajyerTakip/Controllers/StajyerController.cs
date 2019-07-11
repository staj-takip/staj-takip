﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StajyerTakip.Models;

namespace StajyerTakip.Controllers
{
    public class StajyerController : Controller
    {

        private readonly Context db;

        public StajyerController(Context db)
        {
            this.db = db;
        }
        public IActionResult Ekle()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Ekle(Stajyer stajyer)
        {
            db.Hesaplar.Add(stajyer.Profil);
            db.Stajyerler.Add(stajyer);
            db.SaveChanges();
            return RedirectToAction("Ekle");

        }
    }
}