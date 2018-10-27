using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vetorCrescente
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int aux = 0, i = 0 ,n=0;
            
            Console.WriteLine("digite o numero de vezes desejado, para achar o maior valor");
            n = Convert.ToInt32(Console.ReadLine());

            int[] vet = new int[n];

            for (i = 0; i < n; i++)
            {
                
                Console.WriteLine("informe o valor " + (i + 1) + " :");
                vet[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            for (i = 0; i < n; i++)
            {
                
                if (vet[i]>aux)
                    {
                    
                    aux=vet[i];
                    
                    }
                }

            Console.Clear();

            Console.WriteLine(aux);

            Console.ReadKey();
            }
        }
    }

