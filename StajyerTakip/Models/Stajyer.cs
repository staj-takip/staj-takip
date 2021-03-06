﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StajyerTakip.Models
{


    public class Stajyer
    {
        public int ID { get; set; }
        public int ProfilID { get; set; }
        public string Okul { get; set; }
        public string Bolum { get; set; }
        public int GunSayisi { get; set; }
        public Profil Profil { get; set; }
        public DateTime EklenmeTarihi { get; set; }
        public DateTime BaslangicTarihi { get; set; }
        public DateTime BitisTarihi { get; set; }

        public List<Gunluk> Gunlukler { get; set; }
        public List<BirimveStajyer> Birimler { get; set; }
        public List<Devamsizlik> Devamsizliklar { get; set; }
        public List<StajyerProje> Projeler { get; set; }


        public List<Yorum> Yorumlar { get; set; }

    }
}
