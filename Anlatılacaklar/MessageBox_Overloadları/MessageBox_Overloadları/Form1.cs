using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageBox_Overloadları
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1.Overload bu");
            MessageBox.Show("3.Overload bu", "Buraya başlık yazılıyor");
            
            MessageBox.Show("5.overload", "Merhaba", MessageBoxButtons.YesNoCancel);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("7.Overload", "Merhaba", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            MessageBox.Show("7.Overload", "Merhaba", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            MessageBox.Show("7.Overload", "Error", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error);
            MessageBox.Show("7.Overload", "warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            MessageBox.Show("7.Overload", "Exclamation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
            MessageBox.Show("7.Overload", "Hand", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Hand);
            MessageBox.Show("7.Overload", "Merhaba", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Asterisk);

        }

        private void button3_Click(object sender, EventArgs e)
        {//Ctrl+shift+space ile tekrar paramerte penceresini açabiliriz
         //DialogResult basilan=   MessageBox.Show("9.Overload", "Burası başlık", MessageBoxButtons.YesNoCancel,MessageBoxIcon.Warning,MessageBoxDefaultButton.Button1);
           DialogResult basilan= MessageBox.Show(Environment.MachineName, "başlık", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            string mesaj = string.Empty;
            switch (basilan)
            {
                

                case DialogResult.Cancel:
                    mesaj = "İptal";
                    break;
                case DialogResult.No:
                    mesaj = "hayır";
                    break;
                case DialogResult.OK:
                    mesaj = "Tamam";
                    break;

                case DialogResult.Yes:
                    mesaj = "Evet";
                    break;

                default:
                    break;
            }
            MessageBox.Show(mesaj + " Butonuna bastınız");
        }
    }
}
