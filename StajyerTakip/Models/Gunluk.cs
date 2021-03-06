﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StajyerTakip.Models
{
        public class Gunluk
        {
            public int ID { get; set; }
            public int OgrenciID { get; set; }
            public string Baslik { get; set; }
            public string Bilgiler { get; set; } //TODO : icerik seklinde degistirilecek ve gunluk ekle ona gore duzenlenecek
            public int OnayDurumu { get; set; }
            public DateTime Tarih { get; set; }
            public Stajyer Ogrenci { get; set; }
            public List<EkDosya> Ekler { get; set; }
        }
}
