using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.Sınıflar
{
    public class ProjeHakkinda
    {[Key]
        public int ID { get; set; }
        public string Basliklar { get; set; }
        public string Icerik { get; set; }
    }
}