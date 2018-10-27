using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextBox1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtbox1_TextChanged(object sender, EventArgs e)
        {
           txtbox1.Text=txtbox1.Text.ToUpper();
            
        }
    }
}
