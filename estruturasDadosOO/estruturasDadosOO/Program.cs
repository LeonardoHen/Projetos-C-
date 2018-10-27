using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estruturasDadosOO
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList array = new ArrayList();

            array.Add("ola");
            array.Add("mundo");

            foreach(string obj in array)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("Existem " + array.Count + " objetos");

            Console.ReadKey();
        }
    }
}
