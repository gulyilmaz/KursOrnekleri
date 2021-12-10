using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DragAndDrop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {           if (textBox1.Text != "")             lstboxgonderen.Items.Add(textBox1.Text);
        }
        private void Form1_Load(object sender, EventArgs e)
        {//1
            lstboxalan.AllowDrop = true;
        }
        private void lstboxgonderen_MouseDown(object sender, MouseEventArgs e)
        {//2
            lstboxgonderen.DoDragDrop(lstboxgonderen.SelectedItem, DragDropEffects.Move);
        }
        private void lstboxalan_DragEnter(object sender, DragEventArgs e)
        {//3
            e.Effect = DragDropEffects.Move;
        }
        private void lstboxalan_DragDrop(object sender, DragEventArgs e)
        {//4
            lstboxalan.Items.Add(e.Data.GetData(DataFormats.StringFormat));
            lstboxgonderen.Items.Remove(e.Data.GetData(DataFormats.StringFormat));
        }
    }
}
