using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace potencias
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nros = new int[2];
            int[] pot = new int[2];

            for(int i = 0; i < 2; i++)
            {
                Console.WriteLine("digite o" + (i + 1) + "º numero");
                nros[i] = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("digite a potencia do " + (i + 1) + "º numero");
                pot[i] = Convert.ToInt32(Console.ReadLine());

            }
            int res = 0;
            for(int i = 0; i < 2; i++) {

                for (int j = 1; j < pot[i]; j++)
                {
                    if (j == 1)
                    {
                        res = res + (nros[i] * nros[i]);
                    }
                    else
                    {
                        res = res * nros[i];
                    }
                    Console.WriteLine(res);
                }

                Console.ReadKey();
            }
        }
    }
}
