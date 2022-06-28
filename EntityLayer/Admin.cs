using CoreLayer.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Admin : IEntity
    {
        [Key]
        public int Id { get; set; }


        [StringLength(20)]
        public string KullaniciAdi { get; set; }


        [StringLength(20)]
        public string Sifre { get; set; }


        [StringLength(1)]
        public string AdminRol { get; set; }
    }
}
