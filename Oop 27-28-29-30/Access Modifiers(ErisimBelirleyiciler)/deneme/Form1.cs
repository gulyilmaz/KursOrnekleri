using Access_Modifiers_ErisimBelirleyiciler_;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deneme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Kisi k = new Kisi();
            Ogrenci o = new Ogrenci();
            deneme d = new deneme();
            
            
        }
    }
}
