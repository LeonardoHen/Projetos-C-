using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace query_inicial
{
    class Program
    {
        static void Main(string[] args)
        {
            string palavra;
            string query;
            bool igual= true;

            Console.WriteLine("informe a palavra desejada");
            palavra = Console.ReadLine();

            Console.WriteLine("informe a palavra");
            query = Console.ReadLine();
            int aux, aux2;
            if(palavra.Length > query.Length)
            {
                for(int i = 0; i < query.Length; i++)
                {
                    aux = palavra[i];
                    aux2 = query[i];
                    if (aux2 != aux)
                    {
                        igual = false;
                    }
                    else
                    {
                        igual = true;
                    }

                }
                
                Console.WriteLine(igual);

                Console.ReadKey();
            }
            else
            {
                Console.WriteLine(" nao é possivel comparar a palavra: ");
            }
        }
    }
}
