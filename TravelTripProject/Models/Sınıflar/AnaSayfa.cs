﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProject.Models.Sınıflar
{
    public class AnaSayfa
    {
        [Key]  //Birincil Anahtar yaptık
        public int ID { get; set; }
        public string Baslik { get; set; }
        public string Aciklama { get; set; }

    }
}