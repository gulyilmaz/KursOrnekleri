using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Filters.Models
{
    [Table("Logs")]
    public class Log
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required,DisplayName("İşlem Tarihi")]
        public DateTime Tarih { get; set; }
        [Required,StringLength(20),DisplayName("Kullanıcı Adı")]
        public string KullaniciAdi { get; set; }
        [ StringLength(100), DisplayName("Action")]
        public string ActionName { get; set; }

        [StringLength(100), DisplayName("Controller")]
        public string ControllerName { get; set; }

        [StringLength(250), DisplayName("Bilgi")]
        public string Bilgi { get; set; }

    }
}