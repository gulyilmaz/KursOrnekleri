using System;

namespace BisikletClass
{
    public enum FrenTipi
    {
        Hidrolik, Mekanik, Kontra
    }

    public enum KadroTipi
    {
        Alüminyum, Çelik
    }

    public class Bisiklet
    {
        public FrenTipi Fren { get; set; }
        public KadroTipi Kadro { get; set; }

        private int _modelYili;
        public int ModelYili
        {
            get
            {
                return _modelYili;
            }
            set
            {
                int yil = DateTime.Today.Year;
                if (value < 1990 || value > yil)
                {
                    throw new Exception("Yıl ifadesi 1990 ile " + yil + " arasında olabilir.");
                }
                else
                {
                    _modelYili = value;
                }
            }
        }

        public int Yasi
        {
            get { return DateTime.Today.Year - this._modelYili + 1; }
        }

        public override string ToString()
        {
            return $"Bisikletin Freni: {this.Fren} - Kadrosu:{this.Kadro} - Yaşı:{this.Yasi}";
        }
    }
}