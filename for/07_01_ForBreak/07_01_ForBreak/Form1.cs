using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07_01_ForBreak
{
 public partial class Form1 : Form
 {
  public Form1()
  {
   InitializeComponent();
  }

  private void Form1_Load(object sender, EventArgs e)
  {
   for (int i = 0; i < 10; i++)
   {
    MessageBox.Show(i + " . mesaj");
    if (i == 5) break;
   }
  }
 }
}
