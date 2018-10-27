using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estruturasOO
{
    class EstruturaArraylist
    {
        private ArrayList estrutura;

        public EstruturaArraylist()
        {
            estrutura = new ArrayList();
        }
        
        public int getQuantidadeElementos()
        {
            return estrutura.Count;
        }
        public void inserirElemento(object valor)
        {
            estrutura.Add(valor);
        }

        public void imprimirElementos()
        {
            foreach(var elemento  in estrutura)
            {
                Console.WriteLine(elemento.ToString());
            }
        }

        public int procurarElemento(object valor)
        {
            return estrutura.IndexOf(valor);
        }
    }
}
