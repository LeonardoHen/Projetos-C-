using System;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estruturasOO
{
    class Program
    {
        static void Main(string[] args)
        {
            EstruturaArraylist al = new EstruturaArraylist();

            bool continuar = true;
            
            

            do
            {
                Console.Clear();
                Console.WriteLine("[1] - Inserir");
                Console.WriteLine("[2] - Recuperar a quantidade ");
                Console.WriteLine("[3] - Imprimir");
                Console.WriteLine("[4] - Procurar");
                Console.WriteLine("Informe a opcao desejada.");
                int opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("informe o valor a ser inserido: ");
                        string valor = Console.ReadLine();
                        al.inserirElemento(valor);
                        break;
                    case 2:
                        Console.WriteLine("Existem " + al.getQuantidadeElementos() + " Elementos");
                        break;
                    case 3:
                        al.imprimirElementos();
                        break;
                    case 4:
                        Console.WriteLine("Informe o valor a ser localizado: ");
                        string busca = Console.ReadLine();
                        int posicao = al.procurarElemento(busca);
                        Console.WriteLine("O elemento foi encontrado na posicao " + posicao);
                        break;
                    default:
                        continuar = false;
                        break;
                }

                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();

            } while (continuar);


        }
    }
}
