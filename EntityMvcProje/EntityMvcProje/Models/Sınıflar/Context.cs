using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity; //unutma

namespace EntityMvcProje.Models.Sınıflar
{
    public class Context :DbContext //unutma
    {
        //web.config'de veritabanı bağlantısını sağla.
        //enable-Migrations ekle
        //update-database
        public DbSet<Yetenekler> Yeteneklers { get; set; } //yeteneklers veritabanındaki tablo adı
    }
}