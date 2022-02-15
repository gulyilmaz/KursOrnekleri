using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapEvi_Models.Models
{[Table("tb_Yazar")]
   public class Yazar
    {
        public int YazarID { get; set; }
        [Required]
        public string YazarAd { get; set; }
        [Required]
        public string YazarSoyad { get; set; }
        [Required]
        public string Lokasyon { get; set; }
        public DateTime Dogumtarihi { get; set; }
        [NotMapped]
        public string AdSoyad { get { return $"{YazarAd}  {YazarSoyad}"; } }
    }
}
