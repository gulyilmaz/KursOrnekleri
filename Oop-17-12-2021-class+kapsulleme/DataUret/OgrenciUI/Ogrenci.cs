using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciUI
{
  public  class Ogrenci
    {
        public int  Id{ get; set; }
        public string Ad  { get; set; }
        public string Soyad  { get; set; }
        public string  DogumYeri{ get; set; }
        public DateTime DogumTarih { get; set; }
        public DateTime KursBitisTarih { get; set; }
    }
}
