using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Globalization;

namespace UserControl
{
  
    public class MineTextBox : TextBox
    {
        public enum TextTuru
        {
            sadeceRakam, sadeceHarf, sadeceMail,
            buyukHarf, yazimDuzeni, tcNumarasi
        }

        public TextTuru _VeriTuru { get; set; }
        public Color _FocusRengi { get; set; }//textboxa odaklanınca rengi değiştircek
        public bool _BosOlabilirmi { get; set; }
        protected override void OnEnter(EventArgs e)
        {
            BackColor = _FocusRengi;
        }
        protected override void OnLeave(EventArgs e)
        {
            BackColor = Color.White;
            if (_BosOlabilirmi == false && string.IsNullOrWhiteSpace(Text))
            {
                Select();///kullanıcı textboxı boş bırakırsa dolu olana kadar geri döndürecek
                throw new Exception("Bu TextBox Boş geçilemez");
            }
            switch (_VeriTuru)
            {
                case TextTuru.sadeceMail:
                    //Regular Expressions(düzenli ifadeler;  Herhangi bir metni eşleştirmenize, bulmanıza ya da yönetmenize yardımcı olacak desenler yaratmanıza izin veren birçok karakter ve sembollerin bir araya gelmesiyle oluşan metin dizesidir.
                    Regex mail = new Regex(@"^\w+[\w-\.]*\@\w+((-\w+)|(\w*))\.[a-z]{2,3}$");
                    if (!mail.IsMatch(Text))
                    {
                        Select();
                        throw new Exception("Mail adresinizi doğru giriniz.");
                    }
                    break;
                case TextTuru.buyukHarf:
                   this. Text = this.Text.ToUpper();
                    break;
                case TextTuru.yazimDuzeni:
                  this.  Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(this.Text);//sadece ilk harfler büyük olsun
                    break;
                case TextTuru.tcNumarasi:
                           StringBuilder sb = new StringBuilder();
                    int tenNumber, elevenNumber;
                    bool dogrumu = isTc(this.Text, out tenNumber, out elevenNumber);
             
                    if(!dogrumu && tenNumber+elevenNumber!=0)
                    {
                        sb.Append("tc nin 10.hanesi şu olabilir:");
                        sb.AppendLine(tenNumber.ToString());
                        sb.Append("tcnin 11.hanesi şu olabilir");
                        sb.Append(elevenNumber.ToString());
                        MessageBox.Show(sb.ToString());
                        this.Select();
                        throw new Exception("Tc nizi doğru girmediniz");
                    }
                    break;
                default:
                    break;
            }

        }
        private bool isTc(string TcNo, out int tenNumber, out int elevenNumber)
        {
            /*
             
             ilk 9 basamak arasında kurulan bir algoritma bize 10. basamağı, ilk 10 basamak arasında kurulan algoritma ise bize 11. basamağı verir.

+ ilk hane 0 olamaz.
* t.c. kimlik numaralarımızın 1. 3. 5. 7. ve 9. hanelerinin toplamının 7 katından, 2. 4. 6. ve 8. hanelerinin toplamı çıkartıldığında, elde edilen sonucun 10'a bölümünden kalan, yani mod10'u bize 10. haneyi verir.

* 1. 2. 3. 4. 5. 6. 7. 8. 9. ve 10. hanelerin toplamından elde edilen sonucun 10'a bölümünden kalan, yani mod10'u bize 11. haneyi verir.

örneğin 10. rakamı bulalım:
10562272296 bu numaraya uygulayalım.
1+5+2+7+2=17 17*7=119 119-10=109 109'u 10'a böldüğümüzde kalan 9 çıkar ve bu da 10. rakamı bize doğrular. 10562272296

şimdi geldik 11. rakama:
1+0+5+6+2+2+7+2+2+9=36 36'nın 10'a bölümünden kalan 6'dır. bu da bize son rakamı doğrular. 10562272296
             */
            if (TcNo.Length != 11 || !isNumeric(TcNo) || int.Parse(TcNo.Substring(0, 1)) == 0)
            {
                tenNumber = 0;
                elevenNumber = 0;
                throw new Exception("Tc 11 hane girmediniz");
                return false;
            }
            else
            {
                int Sum2468 = 0;
                int Sum13579 = 0;
                string SubStrNineNumer = TcNo.Substring(0, 9);
                Sum13579 = int.Parse(TcNo.Substring(0, 1)) +
                           int.Parse(TcNo.Substring(2, 1)) +
                           int.Parse(TcNo.Substring(4, 1)) +
                           int.Parse(TcNo.Substring(6, 1)) +
                           int.Parse(TcNo.Substring(8, 1));
                Sum2468 = int.Parse(TcNo.Substring(1, 1)) +
                           int.Parse(TcNo.Substring(3, 1)) +
                           int.Parse(TcNo.Substring(5, 1)) +
                           int.Parse(TcNo.Substring(7, 1));

                tenNumber = (((7 * Sum13579) - Sum2468) % 10);


                //(10 - (((3 * Sum13579) + Sum2468) % 10)) % 10;
                elevenNumber = (tenNumber + Sum2468 + Sum13579) % 10;

                //(10 - (((3 * Sum2468 + tenNumber)) + Sum13579) % 10) % 10;
                return TcNo == SubStrNineNumer + tenNumber + elevenNumber;
            }
        }
        private bool isNumeric(string Rakam)
        {
            double rakamMi = 0;
            return double.TryParse(Rakam, out rakamMi);
        }
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            switch (_VeriTuru)
            {
                case TextTuru.sadeceRakam:
                    e.Handled = !(char.IsDigit(e.KeyChar)
                             || e.KeyChar == ','
                             || e.KeyChar == (char)Keys.Back);
                    break;
                case TextTuru.sadeceHarf:
                    e.Handled = !(char.IsLetter(e.KeyChar)
                        || e.KeyChar == (char)Keys.Back);
                    break;
            }

        }
    }
}
