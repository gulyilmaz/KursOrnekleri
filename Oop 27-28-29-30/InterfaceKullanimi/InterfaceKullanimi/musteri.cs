using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceKullanimi
{
    public class musteri : Imusteri,Ideneme
    {
        private int _id;
        private string _isim;
        private string _soyisim;
        public int Id { get { return _id; } set {_id=value; } }
        public string isim { get { return _isim; } set { _isim = value; } }
        public string soyisim { get { return _soyisim; } set { _soyisim=value; } }

        public int denemeno { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int deneme()
        {
            throw new NotImplementedException();
        }

        public int kayitduzenle(int id, string isim, string soyisim)
        {
            Console.WriteLine("kayıt duzenlendi");
            return 1;
        }

        public int yenikayit(string isim, string soyisim)
        {
            Console.WriteLine("kayıt eklendi");
            return 1;
        }
    }
}
