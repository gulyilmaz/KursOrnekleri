using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopAracGalerisi
{
    #region Enum Listelerimiz
    public enum Marka
    {
        FISAT, FORSD, RENOM, VOLKSWOGIN
    }

    public enum Model
    {
        DOSBLO, LONEA, POLIA,
        FIOSTA, FACUS, MASTUNG,
        CLIA, FLAENCA, KANGAA,
        GALF, PESSET, CABBY
    }

    public enum AracTuru
    { Binek, Ticari }

    public enum SanzimanTuru
    { Düz, Otomatik }

    public enum YakitTuru
    { Benzinli, Dizel, LPG }

    public enum KasaTipi
    {
        Kamyonet, Otobüs, Minibüs, Cityvan,
        Coupe, Sedan, MPV, Station
    }
    #endregion
   public class AracGalerisi
    {
        #region Enum Listesinden alınacaklar
        public Marka Markasi { get; set; }
        public Model Modeli { get; set; }
        public AracTuru AracinTuru { get; set; }
        public SanzimanTuru Sanzimani { get; set; }
        public YakitTuru YakitTipi { get; set; }
        public KasaTipi KasaTip { get; set; }
        #endregion

        #region Bir işleme tabi tutulmayacak olanlar
        public bool isGaranti { get; set; }
        public Color Renk { get; set; }
        public Image AracResmi { get; set; }
        #endregion

        #region Kontrol edilip atama yapılacak olanlar
        private int _modelYili;
        public int ModelYili
        {
            get { return _modelYili; }
            set
            {
                if (value < 2005)
                {
                    throw new Exception("2005 yılından küçük araç işlem görmemektedir.");
                }
                else
                {
                    _modelYili = value;
                }
            }
        }

        private int _motorGucu;
        public int MotorGucu
        {
            get { return _motorGucu; }
            set
            {
                if (value < 1000)
                {
                    throw new Exception("Motor gücü en az 1000 olabilir");
                }
                else
                {
                    _motorGucu = value;
                }

            }
        }
        #endregion

        #region Virtual ToString metodunun ezilmesi
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Markasi);
            sb.Append(" ");
            sb.Append(Modeli);
            sb.Append(" ");
            sb.Append(AracinTuru);
            sb.Append(" ");
            sb.Append(YakitTipi);
            return sb.ToString();
        }
        #endregion


        #region MyConstructor
        public AracGalerisi() { }

        public AracGalerisi(Marka marka, Model model)
        {
            this.Markasi = marka;
            this.Modeli = model;
        }

        public AracGalerisi(Color renk, int modelYili, Image AracResmi,
               AracTuru aracTuru = AracTuru.Ticari,
               Marka marka = Marka.VOLKSWOGIN,
               Model model = Model.CABBY,
               SanzimanTuru sanziman = SanzimanTuru.Otomatik,
               YakitTuru yakitTipi = YakitTuru.Dizel,
               KasaTipi kasaTipi = KasaTipi.Kamyonet,
               bool isGaranti = true)
        {
            this.Renk = renk;
            this.ModelYili = modelYili;
            this.AracResmi = AracResmi;
            this.AracinTuru = aracTuru;
            this.Markasi = marka;
            this.Modeli = model;
            this.Sanzimani = sanziman;
            this.YakitTipi = yakitTipi;
            this.KasaTip = kasaTipi;
            this.isGaranti = isGaranti;
        }
        #endregion
    }
}
