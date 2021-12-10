using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormlarArasıParametreGecisi
{
    public partial class GelenForm : Form
    {
        public GelenForm(string txt)
        {
            InitializeComponent();
            label1.Text = txt;
        }
    }
}
