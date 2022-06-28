using CoreLayer.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Personel :IEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(120)]
        public string Ad { get; set; }
        [Required]
        [MaxLength(120)]
        public string Soyad { get; set; }
        [Required]
        public int BirimId { get; set; }
        [ForeignKey("BirimId")]
        public virtual Birim Birim { get; set; }
    }
}
