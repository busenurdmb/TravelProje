using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TravelTripProje.Models.Sınıflar;

namespace TravelTripProje.Models.Sınıflar
{
    public class BlogYorum
    {
        public IEnumerable<Blog> deger1 { get; set; }
        public IEnumerable<Blog> deger3 { get; set; }
        public IEnumerable<Yorumlar> deger2 { get; set; }

    }
}