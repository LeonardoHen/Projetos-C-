using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace retornoOcorrencia
{
    class Program
    {
        static void Main(string[] args)
        {
            string palavra;
            int aux=0;
            bool flag = true;

            Console.WriteLine("Digite alguma palavra: ");
            palavra = Console.ReadLine();

            for(int i = 0; i < palavra.Length; i++)
            {
                
                if (palavra[i]=='d'&&palavra[i+1]=='e'&&palavra[i+2]=='r')
                { 
                    aux = i;
                    flag= true;
                    break;
                }
                else
                {
                    flag = false;
                }

            }
            if (flag == true)
            {
                Console.WriteLine("o indice da palavra: "+palavra+" é: "+aux);
            }
            else
            {
                Console.WriteLine("a palavra: "+palavra+"nao possui 'der' ");
            }
            Console.ReadKey();

        }
    }
}
