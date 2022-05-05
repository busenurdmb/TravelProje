using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProje.Models.Sınıflar
{
    public class About
    {
        [Key]
        public int ID { get; set; }
        public String FoyoUrl { get; set; }
        public String Aciklama { get; set; }
    }
}