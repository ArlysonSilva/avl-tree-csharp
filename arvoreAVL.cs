using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AVL_projeto
{
    public class arvoreAVL
    {
        public No Raiz;

        public void Inserir(int valor)
        {
            Raiz = Inserir(Raiz, valor);
        }
        private No Inserir(No no, int valor)
        {
            if (no == null)
            {
                return new No(valor);
            }
            if (valor < no.Valor)
            {
                no.Esquerda = Inserir(no.Esquerda, valor);
            }
            else if (valor > no.Valor)
            {
                no.Direita = Inserir(no.Direita, valor);
            }
            else
            {
                return no;
            }
            AtualizarAltura(no);
            return Balancear(no);
        }

        public void Remover(int valor)
        {
            Raiz = Remover(Raiz, valor);
        }

        private No Remover(No no, int valor)
        {
            if (no == null)
                return null;
            if (valor < no.Valor)
            {
                no.Esquerda = Remover(no.Esquerda, valor);
            }
            else if (valor > no.Valor)
            {
                no.Direita = Remover(no.Direita, valor);
            }
            else
            {
                if (no.Esquerda == null || no.Direita == null)
                {
                    if (no.Esquerda != null)
                        no = no.Esquerda;
                    else if (no.Direita != null)
                        no = no.Direita;
                    else
                        no = null;
                }
                else
                {
                    No sucessor = BuscarMinimo(no.Direita);
                    no.Valor = sucessor.Valor;
                    no.Direita = Remover(no.Direita, sucessor.Valor);
                }
            }
            AtualizarAltura(no);
            return Balancear(no);
        }

        public bool Buscar(int valor)
        {
            return Buscar(Raiz, valor);
        }

        public bool Buscar(No no, int valor)
        {
            if (no == null)
                return false;
            if (valor == no.Valor)
                return true;
            else if (valor > no.Valor)
                return Buscar(no.Direita, valor);
            else
                return Buscar(no.Esquerda, valor);
        }

        public void PreOrdem()
        {
            PreOrdem(Raiz);
            Console.WriteLine();
        }
        private void PreOrdem(No no)
        {
            if (no == null)
                return;
            Console.Write(no.Valor + " ");
            PreOrdem(no.Esquerda);
            PreOrdem(no.Direita);
        }

        public void ImprimirFB()
        {
            ImprimirFB(Raiz);
        }

        private void ImprimirFB(No no)
        {
            if (no != null)
            {
                Console.WriteLine($"Nó: {no.Valor}, Fator de Balanceamento: {FatorBalanceamento(no)}");
                ImprimirFB(no.Esquerda);
                ImprimirFB(no.Direita);
            }
        }

        public int Altura()
        {
            return Altura(Raiz);
        }

        public int Altura(No no)
        {
            if (no == null)
                return 0;
            else
                return no.Altura;
        }
        private void AtualizarAltura(No no)
        {
            if (no == null)
                return;

            int alturaEsquerda = Altura(no.Esquerda);
            int alturaDireita = Altura(no.Direita);

            no.Altura = Math.Max(alturaEsquerda, alturaDireita) + 1;
        }
        private int FatorBalanceamento(No no)
        {
            if (no == null)
                return 0;
            return Altura(no.Esquerda) - Altura(no.Direita);
        }

        private No Balancear(No no)
        {
            int fb = FatorBalanceamento(no);
            if (fb > 1)
            {
                if (FatorBalanceamento(no.Esquerda) < 0)
                    no.Esquerda = RotacionarEsquerda(no.Esquerda);
                return RotacionarDireita(no);
            }
            if (fb < -1)
            {
                if (FatorBalanceamento(no.Direita) > 0)
                    no.Direita = RotacionarDireita(no.Direita);
                return RotacionarEsquerda(no);
            }
            return no;
        }
        private No RotacionarEsquerda(No no)
        {
            No novaRaiz = no.Direita;
            no.Direita = novaRaiz.Esquerda;
            novaRaiz.Esquerda = no;
            AtualizarAltura(no);
            AtualizarAltura(novaRaiz);
            return novaRaiz;
        }

        private No RotacionarDireita(No no)
        {
            No novaRaiz = no.Esquerda;
            no.Esquerda = novaRaiz.Direita;
            novaRaiz.Direita = no;
            AtualizarAltura(no);
            AtualizarAltura(novaRaiz);
            return novaRaiz;
        }

        private No BuscarMinimo(No no)
        {
            while (no.Esquerda != null)
            {
                no = no.Esquerda;
            }
            return no;
        }
    }
}