using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RB_teste
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTeste_Click(object sender, EventArgs e)
        {
            if (rdb1.Checked == true || rdb3.Checked == true || rdb2.Checked == true)
            {
                MessageBox.Show("Voce errou");
            }
            else if (rdb4.Checked == true)
            {
                MessageBox.Show("Parabens , voce acertou");
            }
            else if (rdb1.Checked == false || rdb3.Checked == false || rdb2.Checked == false || rdb4.Checked == false)
            {
                MessageBox.Show("selecione uma opção");

            }
        }

        private void verificar2_Click(object sender, EventArgs e)
        {
            if (rdbA.Checked == true || rdbC.Checked == true || rdbD.Checked == true)
            {
                MessageBox.Show("Voce errou");
            }
            else if (rdbB.Checked == true)
            {
                MessageBox.Show("Parabens , voce acertou");
            }
            else
            {
                MessageBox.Show("selecione uma opção");

            }

        }

        private void verificar3_Click(object sender, EventArgs e)
        {
            if (rdb22.Checked == true || rdb23.Checked == true || rdb25.Checked == true)
            {
                MessageBox.Show("Voce errou");
            }
            else if (rdb24.Checked == true)
            {
                MessageBox.Show("Parabens , voce acertou");
            }
            else
            {
                MessageBox.Show("selecione uma opção");

            }
        }

        private void verificar4_Click(object sender, EventArgs e)
        {
            if (rdb255.Checked == true || rdb266.Checked == true || rdb259.Checked == true)
            {
                MessageBox.Show("Voce errou");
            }
            else if (rdb256.Checked == true)
            {
                MessageBox.Show("Parabens , voce acertou");
            }
            else
            {
                MessageBox.Show("selecione uma opção");

            }
        }

        private void verificar5_Click(object sender, EventArgs e)
        {
            if (rdb6.Checked == true || rdb7.Checked == true || rdb5.Checked == true)
            {
                MessageBox.Show("Voce errou");
            }
            else if (rdb8.Checked == true)
            {
                MessageBox.Show("Parabens , voce acertou");
            }
            else
            {
                MessageBox.Show("selecione uma opção");

            }
        }
    }
}
