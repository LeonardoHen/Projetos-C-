using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace query_final
{
    class Program
    {
        static void Main(string[] args)
        {
            string query, palavra;
            bool igual = true;

            Console.WriteLine("digite a palavra: ");
            palavra = Console.ReadLine();

            Console.WriteLine("digite a comparaçao: ");
            query = Console.ReadLine();

            for(int i= palavra.Length - 1; i > query.Length; i--)
            {
                if(palavra[i] != query[i-query.Length-1])
                {
                    igual = false;
                    break;
                }
            }
            
        }
    }
}
