using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapEvi_Models.Models
{
   public class KitapDetay
    {
        public int KitapDetayID { get; set; }
        [Required]
        public int BolumSayisi { get; set; }
        public int KitapSayfasi { get; set; }
        public int Agirlik { get; set; }
        [ForeignKey("Kitap")]
        public int KitapID { get; set; }
        public Kitap Kitap { get; set; }
    }
}
