using static System.Drawing.Color;
using System.Drawing;
using System;
using System.Windows.Forms;

namespace _07_02_DonguIleComboBox
{
 public partial class Form1 : Form
 {
  public Form1()
  {
   InitializeComponent();
  }

  private void Form1_Load(object sender, EventArgs e)
  {
   this.AutoSize = true;
   for (int i = 0; i < 7; i++)
   {
    ComboBox cmb = new ComboBox();
    cmb.Location = new Point(5, i * 35);
    cmb.BackColor = FromArgb(240, i * 30, i * 20);
    cmb.Items.Add(i * 40);
    this.Controls.Add(cmb);
   }
  }
 }
}
