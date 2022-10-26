using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.Sınıflar
{
    public class Anasayfa
    {[Key]
        public int ID { get; set; }
        public string Baslik { get; set; }
        public string Foto { get; set; }
        public string Malzemeler { get; set; }
        public string Tarif { get; set; }
    }
}