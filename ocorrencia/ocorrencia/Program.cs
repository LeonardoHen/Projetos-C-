using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ocorrencia
{
    class Program
    {
        static void Main(string[] args)
        {
            string palavra;
            int aux=0;
            bool flag=true;
            Console.WriteLine("digite uma palavra: ");
            palavra = Console.ReadLine();
            
            for(int i = 0; i < palavra.Length; i++)
            {
                if (palavra[i] == 'c')
                {
                    aux = i;
                    flag = true;
                    break;
                }
                else
                {
                    flag = false;
                }
            }
            if (flag == true)
            {
                Console.WriteLine("o indice do c é " + aux);
            }
            else
            {
                Console.WriteLine("a palavra: "+palavra+"nao possui letra c");
            }

            Console.ReadKey();
        }
    }
}
