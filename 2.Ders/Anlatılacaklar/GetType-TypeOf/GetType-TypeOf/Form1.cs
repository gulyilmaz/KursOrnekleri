using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetType_TypeOf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            System.Type tip = sender.GetType();
            MessageBox.Show($"Tipi: {tip}");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool butonMu = sender.GetType() == typeof(Button);
            MessageBox.Show($"Buton mu: {butonMu}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool butonMu = sender is Button;
            MessageBox.Show(butonMu.ToString());
        }
    }
}
