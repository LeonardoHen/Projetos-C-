using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estruturasOO
{
    class EstruturaDataTable
    {
        DataTable dt;

        public EstruturaDataTable()
        {
            dt = new DataTable();
            dt.Columns.Add("Nome", typeof(string));
            dt.Columns.Add("Email", typeof(string));
            dt.Columns.Add("idade", typeof(int));
            dt.Columns.Add("Salario", typeof(double));
        }
        public void adicionarDados()
        {
            Console.WriteLine("informe o nome");
            string nome = Console.ReadLine();
            Console.WriteLine("informe o e-mail");
            string email = Console.ReadLine();
            Console.WriteLine("informe a idade");
            int idade =Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("informe o salario");
            double salario = Convert.ToInt32(Console.ReadLine());

            DataRow dr = dt.NewRow();
            dr[0] = nome;
            dr[1] = email;
            dr[2] = idade;
            dr[3] = salario;

            dt.Rows.Add(dr);
        }

        public void imprimirDataTable()
        {
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                Console.Write(dt.Rows[i].ItemArray[0] + " - ");
                Console.Write(dt.Rows[i].ItemArray[1] + " - ");
                Console.Write(dt.Rows[i].ItemArray[2] + " - ");
                Console.Write(dt.Rows[i].ItemArray[3] + " - ");
            }
        }
    }
}
