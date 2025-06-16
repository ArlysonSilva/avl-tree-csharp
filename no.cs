
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVL_projeto
{
    public class No
    {
        public int Valor;
        public No Esquerda;
        public No Direita;
        public int Altura;

        public No(int valor)
        {
            Valor = valor;
            Altura = 1;
        }
    }
}