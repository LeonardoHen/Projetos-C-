using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dividir
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0, n2 = 0, res = 0;

            
            try
            {
                Console.WriteLine("Digite o primeiro valor: ");
                n1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite o segundo valor: ");
                n2 = Convert.ToInt32(Console.ReadLine());

                res = n1 / n2;
                Console.WriteLine("resultado de " + n1 + " / " + n2 + " = " + res);
            }
            catch (DivideByZeroException exp)
            {
                Console.WriteLine(exp.Message);
                
            }
            catch (Exception expGen)
            {
                Console.WriteLine("excessao generica, " + expGen.Message);
                
            }
            finally
            {
                
                
            
            }

            Console.ReadKey();
        }
    }
}
