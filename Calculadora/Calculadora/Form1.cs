using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btadicao_Click(object sender, EventArgs e)
        {
            double valor1, valor2, resultado;

            if (txtValor1.Text == null && txtValor2.Text == null){ 
            
                MessageBox.Show("informe um valor");
            }
            else
            {

            
            valor1 = Convert.ToDouble(txtValor1.Text);
            valor2 = Convert.ToDouble(txtValor2.Text);

            resultado = valor1 + valor2;
            lblresultado.Text = resultado.ToString();

            }
        }

        private void frmCalculadora_Load(object sender, EventArgs e)
        {

        }

        private void btsubtracao_Click(object sender, EventArgs e)
        {
            double valor1, valor2, resultado;

            if (txtValor1.Text == null && txtValor2.Text == null)
            {

                MessageBox.Show("informe um valor");
            }
            else
            {


                valor1 = Convert.ToDouble(txtValor1.Text);
                valor2 = Convert.ToDouble(txtValor2.Text);

                resultado = valor1 - valor2;
                lblresultado.Text = resultado.ToString();

            }
        }

        private void btmultiplicacao_Click(object sender, EventArgs e)
        {
            double valor1, valor2, resultado;

            if (txtValor1.Text == null && txtValor2.Text == null)
            {

                MessageBox.Show("informe um valor");
            }
            else
            {


                valor1 = Convert.ToDouble(txtValor1.Text);
                valor2 = Convert.ToDouble(txtValor2.Text);

                resultado = valor1 * valor2;
                lblresultado.Text = resultado.ToString();

            }
        }

        private void btdivisao_Click(object sender, EventArgs e)
        {
            double valor1, valor2, resultado;

            if (txtValor1.Text == null && txtValor2.Text == null)
            {

                MessageBox.Show("informe um valor");
            }
            else
            {


                valor1 = Convert.ToDouble(txtValor1.Text);
                valor2 = Convert.ToDouble(txtValor2.Text);

                resultado = valor1 / valor2;
                lblresultado.Text = resultado.ToString();

            }
        }
    }
}
