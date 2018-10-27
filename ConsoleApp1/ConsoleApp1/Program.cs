using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int op=0;
            int n1 = 0, n2 = 0, res=0;

            
            Console.WriteLine("escolha alguma opção:\n 1 somar \n 2 multiplicar \n 3 dividir \n  ");
            op = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("informe o primeiro valor :");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("informe o segundo valor :");
            n2 = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case 1:
                    res = n1 + n2;
                    Console.WriteLine("o resultado é:" + res);
                    break;
                case 2:
                    res = n1 * n2;
                    Console.WriteLine("o resultado é:" + res);
                    break;
                case 3:
                    if (n2 != 0)
                    {
                        res = n1 / n2;
                        Console.WriteLine("o resultado é:" + res);
                    }
                    else
                        Console.WriteLine("impossivel dividir por zero ");
                    break;
                default:
                    Console.WriteLine("opçao invalida ");
                    break;
            }
            Console.ReadKey();
        }
    }
}
