using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserControl;
namespace UsekontrolKullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MineTextBox minetxt = new MineTextBox();
            minetxt._BosOlabilirmi = false;
            minetxt._FocusRengi = Color.Bisque;
            minetxt._VeriTuru = MineTextBox.TextTuru.tcNumarasi;
            this.Controls.Add(minetxt);
            TextBox txt = new TextBox();
            txt.Left = 120;
            this.Controls.Add(txt);
        }

       
    }
}
