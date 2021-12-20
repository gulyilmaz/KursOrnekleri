using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banka
{
    public class musteri
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        private string _KrediKart;
     
        public string KrediKart
        {
            get => getkredikart();

            set => _KrediKart = value;
            
        }
        public string getkredikart()
        {
            String gecici = _KrediKart;
            gecici = "********" + gecici.Substring(gecici.Length-2);
            return gecici;

        }
        
    }
}
