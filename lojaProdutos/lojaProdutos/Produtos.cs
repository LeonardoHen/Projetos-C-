using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lojaProdutos
{
    class Produtos
    {
        //atributos
        private double Preco;
        private string Nome;
        private int Quantidade;
        private string Validade;
        private string NumeroProduto;
       
        public Produtos()
        {

            
            Console.WriteLine("Informe o nome do produto: ");
            Nome = Console.ReadLine();
            Console.WriteLine("Informe o preço do produto: ");
            Preco = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe a quantidade do produto: ");
            Quantidade =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe a validade do produto: ");
            Validade = Console.ReadLine();
            Console.WriteLine("Informe o numero de cadastro do produto: ");
            NumeroProduto =Console.ReadLine();

            
        }
        //acessores
        public string getNome()
        {
            return Nome.ToUpper();
        }
        public double getPreco()
        {
            return Preco;
        }
        public string getValidade()
        {
            return Validade;
        }
        public string getNumeroProduto()
        {
            return NumeroProduto;
        }
        //modificadores
        public void setQuantidade(int Quantidade)
        { 
            this.Quantidade = Quantidade;
        }
        public void setPreco(double Preco)
        {
            
            this.Preco = Preco;

        }
        public void display()
        {
            Console.WriteLine("Nome do produto: "+Nome);
            Console.WriteLine("Quantidade do produto: " + Quantidade);
            Console.WriteLine("Preço do produto: " + Preco);
            Console.WriteLine("Validade do produto: " + Validade);
            Console.WriteLine("Numero de cadastro: " + NumeroProduto);
           
            
        }
        
    }
}
