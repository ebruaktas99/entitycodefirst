using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EntityMvcProje.Models.Sınıflar
{
    public class Yetenekler
    {
        [Key]
        public int ID { get; set; }
        public string ACIKLAMA { get; set; }
        public byte DEGER { get; set; }
    }
}