using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Filters.Models
{[Table("SiteUsers")]
    public class SiteUser
    {[Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required,StringLength(20),DisplayName("Ad")]
        public string Ad { get; set; }
        [Required, StringLength(20), DisplayName("Soyad")]
        public string Soyad { get; set; }
        [Required, StringLength(20), DisplayName("Kullanıcı Adı")]
        public string KullaniciAdi { get; set; }

        [Required, StringLength(16), DisplayName("Parola"),DataType(DataType.Password)]
        public string sifre { get; set; }

    }
}