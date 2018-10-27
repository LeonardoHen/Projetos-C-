using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estruturasOO
{
    class Pessoa
    {
        public string nome;
        public string cpf;
        public string email;

        public Pessoa()
        {
            Console.WriteLine("Informe o nome");
            nome = Console.ReadLine();
            Console.WriteLine("Informe o cpf");
            cpf = Console.ReadLine();
            Console.WriteLine("Informe o e-mail");
            email = Console.ReadLine();
        }

       public void imprimir()
        {
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("cpf: " + cpf);
            Console.WriteLine("e-mail: " + email);
        }

    }
}
