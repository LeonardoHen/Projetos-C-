using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lojaProdutos
{
    class Program
    {
        static void Main(string[] args)
        {
            Produtos p1 = new Produtos();
            categoria c1 = new categoria(p1);
            
            
            p1.display();
            c1.display();
            Console.WriteLine("informe a nova quantidade de produtos: ");
            int Novaqnt = Convert.ToInt32(Console.ReadLine());
            p1.setQuantidade(Novaqnt);

            Console.WriteLine("informe o novo preço do produto: ");
            double Novopreco = Convert.ToDouble(Console.ReadLine());
            p1.setPreco(Novopreco);

            Console.WriteLine("informe o novo preço promocional do produto: ");
            double Novoprecopro = Convert.ToDouble(Console.ReadLine());
            c1.setPrecopromocional(Novoprecopro);

            Console.Clear();

            p1.display();
            c1.display();



            Console.WriteLine("----- Pressione qualquer tecla para encerrar... ------ ");
            Console.ReadKey();
        }
    }
}
