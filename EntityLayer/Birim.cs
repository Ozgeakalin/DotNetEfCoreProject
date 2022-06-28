using CoreLayer.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Birim : IEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string BirimAd { get; set; }
        public virtual ICollection<Personel> Personels { get; set; }
    }
}
