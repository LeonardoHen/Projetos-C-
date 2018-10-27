using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Label
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void botao1_Click(object sender, EventArgs e)
        {
            lbltext.Text = "O botao 1 esta sendo apertado";
            apagar.Visible = true;
            botao2.Enabled = true;
            botao1.Enabled = false;
            lbltext.Visible = true;


        }

        private void botao2_Click(object sender, EventArgs e)
        {
            lbltext.Text = "O botao 2 esta sendo apertado";
            apagar.Visible = true;
            botao1.Enabled = true;
            botao2.Enabled = false;
            lbltext.Visible = true;
        }

        private void apagar_Click(object sender, EventArgs e)
        {
            lbltext.Text= "     ";
            botao1.Enabled = true;
            botao2.Enabled = true;
            apagar.Visible = false;
            lbltext.Visible = false;

        }
    }
}
