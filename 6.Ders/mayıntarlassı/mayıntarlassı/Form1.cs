using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mayıntarlassı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int mayin1, mayin2, mayin3;
            Random rnd = new Random();
            mayin1 = rnd.Next(1, 20);
            mayin2 = rnd.Next(21, 40);
            mayin3 = rnd.Next(41, 50);
            for (int i = 1; i <=50; i++)
            {
                Button btn = new Button();
                btn.Name = "btn" + i.ToString();
                btn.Text = i.ToString();
                if(mayin1==i||mayin2==i||mayin3==i)
                {
                    btn.Tag = true;
                }
                else
                {
                    btn.Tag = false;
                }
                btn.Click += btn_Click;
                flowLayoutPanel1.Controls.Add(btn);

            }

        }
        int skor = 0;
        private void btn_Click(object sender,EventArgs e)
        {
            Button basilan =((Button)sender);
            bool mayinbulundumu =(bool) basilan.Tag;
            if(mayinbulundumu)
            {
                MessageBox.Show("Mayını buldunuz tebrikler");
                basilan.BackColor = Color.Red;
               
            }
            else
            {
                basilan.BackColor = Color.Green;
                skor++;
                labelskor.Text = skor.ToString();
            }


        }
    }
}
