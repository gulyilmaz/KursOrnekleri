using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAraba
{
    public class ArabaSinifi : IAraba, Inumara
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        private int _Modelyili;
        public int Modelyili { get {return _Modelyili; }
            set
            {
                if (value < 2005)
                {
                    _Modelyili = 2005;
                }
                else
                {
                    _Modelyili = value;
                }


                ; } }
        public string sanziman { get ; set ; }
    private int _yildiz;

        public int yildiz { get{return _yildiz ; }

        set {_yildiz=value>5?5:value ; }
    }

        public void OzellikOku()
        {
        Console.WriteLine("Arac Özelliklerimiz Markası : "+ Marka+ " Şanzıman Türü : "+ sanziman+" ModelYili: "+_Modelyili+ "Puanı"+ _yildiz);
        }
    }
}
