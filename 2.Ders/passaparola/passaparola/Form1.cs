using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace passaparola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        int soruno = 0, dogru = 0, yanlis = 0;
        string cevap=null;
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            cevap = textBox1.Text.ToUpper();
            if (e.KeyCode == Keys.Enter)
            {
                textBox1.Enabled = false;


                switch (soruno)
                {
                    case 1:

                        if (cevap == "AKDENİZ")
                        {
                            button1.BackColor = Color.Green;
                            dogruarttır();
                        


                        }
                        else
                        {
                            button1.BackColor = Color.Red;
                            yanlisarttır();
                            

                        }
                        break;
                    case 2:

                        if (cevap == "BURSA")
                        {
                            button2.BackColor = Color.Green;
                            dogruarttır();
                        }
                        else
                        {
                            button2.BackColor = Color.Red;
                            yanlisarttır();
                        }
                        break;

                    case 3:

                        if (cevap == "CUMA")
                        {
                            button3.BackColor = Color.Green;
                            dogruarttır();
                        }
                        else
                        {
                            button3.BackColor = Color.Red;
                            yanlisarttır();
                        }
                        break;
                    case 4:

                        if (cevap == "DİYARBAKIR")
                        {
                            button4.BackColor = Color.Green;
                            dogruarttır();
                        }
                        else
                        {
                            button4.BackColor = Color.Red;
                            yanlisarttır();
                        }
                        break;
                    case 5:

                        if (cevap == "ESKİ")
                        {
                            button5.BackColor = Color.Green;
                            dogruarttır();
                        }
                        else
                        {
                            button5.BackColor = Color.Red;
                            yanlisarttır();
                        }
                        break;
                    case 6:

                        if (cevap == "FERMAN")
                        {
                            button6.BackColor = Color.Green;
                            dogruarttır();
                        }
                        else
                        {
                            button6.BackColor = Color.Red;
                            yanlisarttır();
                        }
                        break;
                    case 7:

                        if (cevap == "GÜNEŞ")
                        {
                            button7.BackColor = Color.Green;
                            dogruarttır();
                        }
                        else
                        {
                            button7.BackColor = Color.Red;
                            yanlisarttır();
                        }
                        break;
                    case 8:

                        if (cevap == "HALI")
                        {
                            button8.BackColor = Color.Green;
                            dogruarttır();
                        }
                        else
                        {
                            button8.BackColor = Color.Red;
                            yanlisarttır();
                        }
                        break;
                    case 9:

                        if (cevap == "ISPARTA")
                        {
                            button9.BackColor = Color.Green;
                            dogruarttır();
                        }
                        else
                        {
                            button9.BackColor = Color.Red;
                            yanlisarttır();
                        }
                        break;
                    case 10:

                        if (cevap == "JANDARMA")
                        {
                            button10.BackColor = Color.Green;
                            dogruarttır();
                        }
                        else
                        {
                            button10.BackColor = Color.Red;
                            yanlisarttır();
                        }
                        break;
                    case 11:

                        if (cevap == "KAYISI")
                        {
                            button11.BackColor = Color.Green;
                            dogruarttır();
                        }
                        else
                        {
                            button11.BackColor = Color.Red;
                            yanlisarttır();
                        }
                        break;
                    case 12:

                        if (cevap == "LALE")
                        {
                            button12.BackColor = Color.Green;
                            dogruarttır();
                        }
                        else
                        {
                            button12.BackColor = Color.Red;
                            yanlisarttır();
                        }
                        break;
                    case 13:

                        if (cevap == "MART")
                        {
                            button13.BackColor = Color.Green;
                            dogruarttır();
                        }
                        else
                        {
                            button13.BackColor = Color.Red;
                            yanlisarttır();
                        }
                        break;
                    case 14:

                        if (cevap == "NEY")
                        {
                            button14.BackColor = Color.Green;
                            dogruarttır();
                        }
                        else
                        {
                            button14.BackColor = Color.Red;
                            yanlisarttır();
                        }
                        break;
                    case 15:

                        if (cevap == "OZAN")
                        {
                            button15.BackColor = Color.Green;
                            dogruarttır();
                        }
                        else
                        {
                            button15.BackColor = Color.Red;
                            yanlisarttır();
                        }
                        break;
                    case 16:

                        if (cevap == "PIRASA")
                        {
                            button16.BackColor = Color.Green;
                            dogruarttır();
                        }
                        else
                        {
                            button16.BackColor = Color.Red;
                            yanlisarttır();
                        }
                        break;
                    case 17:

                        if (cevap == "RAMAZAN")
                        {
                            button17.BackColor = Color.Green;
                            dogruarttır();
                        }
                        else
                        {
                            button17.BackColor = Color.Red;
                            yanlisarttır();
                        }
                        break;
                    case 18:

                        if (cevap == "SNAKE")
                        {
                            button18.BackColor = Color.Green;
                            dogruarttır();
                        }
                        else
                        {
                            button18.BackColor = Color.Red;
                            yanlisarttır();
                        }
                        break;
                    case 19:

                        if (cevap == "TARKAN")
                        {
                            button19.BackColor = Color.Green;
                            dogruarttır();
                        }
                        else
                        {
                            button19.BackColor = Color.Red;
                            yanlisarttır();
                        }
                        break;
                    case 20:

                        if (cevap == "UMUT")
                        {
                            button20.BackColor = Color.Green;
                            dogruarttır();
                        }
                        else
                        {
                            button20.BackColor = Color.Red;
                            yanlisarttır();
                        }
                        break;
                    case 21:

                        if (cevap == "VAN")
                        {
                            button21.BackColor = Color.Green;
                            dogruarttır();
                        }
                        else
                        {
                            button21.BackColor = Color.Red;
                            yanlisarttır();
                        }
                        break;
                    case 22:

                        if (cevap == "YILDIRIM")
                        {
                            button22.BackColor = Color.Green;
                            dogruarttır();
                        }
                        else
                        {
                            button22.BackColor = Color.Red;
                            yanlisarttır();
                        }
                        break;

                    default:
                        break;
                }
            }
        }

        private void dogruarttır()
        {
            dogru++;
            label2.Text = dogru.ToString();
        }

       

        private void yanlisarttır()
        {
            yanlis++;
            label4.Text = yanlis.ToString();
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.Text = "SONRAKİ";
            soruno++;
            textBox1.Text = "";
            textBox1.Enabled = true;
            this.Text = soruno.ToString();
            if (soruno == 1)
            {
                richTextBox1.Text = "Ülkemizin güney kısmındaki kıyı bölgesi?";
                button1.BackColor = Color.Yellow;
                harf.Text = button1.Text;
            }
            else if (soruno == 2)
            {
                richTextBox1.Text = "Yeşilliğiyle ünlü Marmara ilimiz";
                button2.BackColor = Color.Yellow;
                harf.Text = button2.Text;
            }
            else if (soruno == 3)
            {
                richTextBox1.Text = "Müslümanların kutsal günü?";
                button3.BackColor = Color.Yellow;
                harf.Text = button3.Text;
            }
            else if (soruno == 4)
            {
                richTextBox1.Text = "Karpuzuyla ünlü ilimiz?";
                button4.BackColor = Color.Yellow;
                harf.Text = button4.Text;
            }
            else if (soruno == 5)
            {
                richTextBox1.Text = "Yeni kelimesinin zıt anlamlısı?";
                button5.BackColor = Color.Yellow;
                harf.Text = button5.Text;
            }
            else if (soruno == 6)
            {
                richTextBox1.Text = "Padişahın emirlerinin yazılı hali?";
                button6.BackColor = Color.Yellow;
                harf.Text = button6.Text;
            }
            else if (soruno == 7)
            {
                richTextBox1.Text = "Dünyanın ısı kaynağı?";
                button7.BackColor = Color.Yellow;
                harf.Text = button7.Text;
            }
            else if (soruno == 8)
            {
                richTextBox1.Text = "Öğrencilerin kötü karne getirince bakıitığı halı?";
                button8.BackColor = Color.Yellow;
                harf.Text = button8.Text;
            }
            else if (soruno == 9)
            {
                richTextBox1.Text = "Gülüyle ünlü ilimiz?";
                button9.BackColor = Color.Yellow;
                harf.Text = button9.Text;
            }
            else if (soruno == 10)
            {
                richTextBox1.Text = "Askeri bir topluluk?";
                button10.BackColor = Color.Yellow;
                harf.Text = button10.Text;
            }
            else if (soruno == 11)
            {
                richTextBox1.Text = "Malatyanın meşhur meyvesi?";
                button11.BackColor = Color.Yellow;
                harf.Text = button11.Text;
            }
            else if (soruno == 12)
            {
                richTextBox1.Text = "Her yıl bahar aylarında düzenlenen çiçek festivali?";
                button12.BackColor = Color.Yellow;
                harf.Text = button12.Text;
            }
            else if (soruno == 13)
            {
                richTextBox1.Text = "Yılın 3.ayı?";
                button13.BackColor = Color.Yellow;
                harf.Text = button13.Text;
            }
           
            else if (soruno == 14)
            {
                richTextBox1.Text = "Üflemeli bir müzik aleti?";
                button14.BackColor = Color.Yellow;
                harf.Text = button14.Text;
            }
            else if (soruno == 15)
            {
                richTextBox1.Text = "Halk şairi?";
                button15.BackColor = Color.Yellow;
                harf.Text = button15.Text;
            }
            else if (soruno == 16)
            {
                richTextBox1.Text = "Çocukların pek sevmediği pirinç havuç gibi sebzelerle yapılan yemek?";
                button16.BackColor = Color.Yellow;
                harf.Text = button16.Text;
            }
            else if (soruno == 17)
            {
                richTextBox1.Text = "11 ayın sultanı?";
                button17.BackColor = Color.Yellow;
                harf.Text = button17.Text;
            }
            else if (soruno == 18)
            {
                richTextBox1.Text = "İngilizcede yılan?";
                button18.BackColor = Color.Yellow;
                harf.Text = button18.Text;
            }
           
            else if (soruno == 19)
            {
                richTextBox1.Text = "Türkiyenin megastarı?";
                button19.BackColor = Color.Yellow;
                harf.Text = button19.Text;
            }
            else if (soruno == 20)
            {
                richTextBox1.Text = "Ümit kelimesinin eş anlamlısı?";
                button20.BackColor = Color.Yellow;
                harf.Text = button20.Text;
            }
            else if (soruno == 21)
            {
                richTextBox1.Text = "Kahvaltısı ile ünlü ilimiz?";
                button21.BackColor = Color.Yellow;
                harf.Text = button21.Text;
            }
            else if (soruno == 22)
            {
                richTextBox1.Text = "Şimşek kelimesinin eş anlamlısı?";
                button22.BackColor = Color.Yellow;
                harf.Text = button22.Text;
            }
        }
    }
}
