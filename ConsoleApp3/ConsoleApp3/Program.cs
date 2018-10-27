using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vet1 = new int [8];
            int[] vep = new int[8];
            int[] ven = new int[8];
            int i = 0;
            int auxpos = 0, auxneg = 0;

            for(i=0; i < 8; i++)
            {
                Console.WriteLine("informe o valor ");
                vet1[i] = Convert.ToInt32(Console.ReadLine());
                for (i = 0; i < 8; i++) { 
                if (vet1[i] < 0)
                {
                        ven[auxneg] = vet1[i];
                        auxneg++;
                }
                else
                {
                        vep[auxpos] = vet1;
                        auxpos++;
                }
               
            }
            for (i = 0; i <auxneg ; i++)
            {
                Console.WriteLine(" negativos: " + ven[i]);
            }
                for (i = 0; i < auxpos; i++)
                {
                    Console.WriteLine(" positivos: " + vep[i]);
                }
           
            Console.ReadKey();
        }
    }
}
