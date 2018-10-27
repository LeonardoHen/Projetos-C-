using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DGV_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnvalidar_Click(object sender, EventArgs e)
        {
            int linhas = dgv.Rows.Count;

            dgv.Rows.Add();

            dgv.Rows[linhas].Cells[0].Value = txtnome.Text;

        }
    }
}
