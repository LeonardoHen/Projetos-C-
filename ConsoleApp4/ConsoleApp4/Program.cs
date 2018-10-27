using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lojas = new string[8];
            string[] produtos = new string[4];
            double[,] precos = new double[8, 4];

            for(int i=0; i < 8; i++)
            {
                Console.WriteLine("informe a loja: " + (i + 1));
                lojas[i] = Console.ReadLine();
            }

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("informe o produto: " + (i + 1));
                produtos[i] = Console.ReadLine();
            }

            for (int i = 0; i < 8; i++)
            {
               for(int j = 0; j < 4; j++)
                {
                    Console.WriteLine("informe o produto: "+produtos[j]+" e a loja: "+lojas[i]);
                    precos[i, j] = Convert.ToDouble(Console.ReadLine());
                }
            }

            for(int i = 0; i < 8; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    if (precos[i, j]>120.0){
                        Console.WriteLine(" Produto: " +produtos[j]+" Lojas: "+lojas[i]);
                    }
                }
            }

        }
    }
}
