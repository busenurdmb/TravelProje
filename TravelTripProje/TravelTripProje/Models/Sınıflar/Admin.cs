using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProje.Models.Sınıflar
{
    public class Admin
    {
        [Key]
        public int ID { get; set; }
        public String Kullanici { get; set; }
        public String Sifre { get; set; }
    }
}