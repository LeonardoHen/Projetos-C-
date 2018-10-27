using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraFaculdade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtn1.Text = "";
            txtn2.Text = "";
            txtresultado.Text = "";

        }

        private void adicao_Click(object sender, EventArgs e)
        {
            double res;

            res = Convert.ToDouble(txtn1.Text) + Convert.ToDouble(txtn2.Text);
            txtresultado.Text = Convert.ToString(res);
            

        }

        private void subtracao_Click(object sender, EventArgs e)
        {
            double res;

            res = Convert.ToDouble(txtn1.Text) - Convert.ToDouble(txtn2.Text);
            txtresultado.Text = Convert.ToString(res);
        }

        private void mutiplicacao_Click(object sender, EventArgs e)
        {
            double res;

            res = Convert.ToDouble(txtn1.Text) * Convert.ToDouble(txtn2.Text);
            txtresultado.Text = Convert.ToString(res);
        }

        private void divisao_Click(object sender, EventArgs e)
        {
            double res;

            res = Convert.ToDouble(txtn1.Text) / Convert.ToDouble(txtn2.Text);
            txtresultado.Text = Convert.ToString(res);

            try
            {
               

                res = Convert.ToDouble(txtn1.Text) / Convert.ToDouble(txtn2.Text);
                txtresultado.Text = Convert.ToString(res);
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("nao e possivel divisao por 0");
                throw;
            }
        }
    }
}
