using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vet1 = new int[10];
            int i = 0;

            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("digite o valor: ");
                vet1[i] = Convert.ToInt32(Console.ReadLine());

            }

            for (i = 0; i < 9; i++)
            {
                Console.WriteLine(vet1[i] + vet1[i + 1]);

            }
            Console.ReadKey();

        }
    }
}
