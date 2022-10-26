using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace WebApplication1.Models.Sınıflar
{
    public class Context : DbContext
    {
        public DbSet<Anasayfa> Anasayfas { get; set; }
        public DbSet<ProjeHakkinda> ProjeHakkindas { get; set; }
    }
}