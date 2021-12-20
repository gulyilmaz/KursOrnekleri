using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kapsulleme_ders
{
    public class Musteri
    {
        public Musteri()
        {
            IdAtama();
        }
        private int _id;
        public int id { get { return _id; } private set {; } }
        public string isim { get; set; }
        private string _soyisim;
        public string soyisim
        {
            get { return _soyisim; }
            set
            {
                _soyisim = value;
                _email = string.Format("{0}.{1}@gmail.com", isim, _soyisim);


                ;
            }
        }

        private string _email;
        public string email { get { return _email; } set { _email = value; } }
        private string _tckimlik;
        
        public string tckimlik
        {
            get
            {
                string tc = "";

                
                    int sayi = (_tckimlik.Substring(3)).Length;
                 

                    for (int i = 0; i < sayi; i++)
                    {
                        tc = tc + "*";
                    }
                
                    return _tckimlik.Substring(0, 3) + tc;
                
                

            }



            set
            {
                if (value.Length == 11)
                {
                    bool kontrol = false;

                    for (int i = 0; i < value.Length; i++)
                    {
                        bool karakterkontrol = char.IsNumber(value[i]);
                        if (karakterkontrol)
                        {
                            //sayısal demek
                        }
                        else
                        {
                            kontrol = true;
                            break;
                        }
                    }
                    if (kontrol)
                    {
                        Console.WriteLine("tc sayı olmalı");
                    }
                    else
                    {
                        _tckimlik = value;
                    }


                }
                else
                {
                    _tckimlik="";
                }

                ;

            }
        }

                private int IdAtama()
                {
                    Random rnd = new Random();
                    _id = rnd.Next(1000, 9000);
                    return _id;

                }


    }
  }
    
