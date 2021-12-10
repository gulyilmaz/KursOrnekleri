using System;
using static System.Drawing.Color;
using System.Windows.Forms;

namespace _07_03_GunlerComboList
{
 public partial class Form1 : Form
 {
  public Form1()
  {
   InitializeComponent();
  }
  private void btnDoldur_Click(object sender, EventArgs e)
  {
   string[] HaftaninGunleri = { "Pazartesi", "Salı",
    "Çarşamba", "Perşembe", "Cuma", "Cumartesi", "Pazar" };

   foreach (string degisken in HaftaninGunleri)
   {
    cmbGunler.Items.Add(degisken);
                
   }
            string[] aylar = { "ocak", "şubat" };
   lstGunler.Items.AddRange(aylar);

   foreach (Control ctr in Controls)
   {
    ctr.BackColor = CornflowerBlue;
    ctr.ForeColor = Bisque;
   }
  }
 }
}
