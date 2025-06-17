using System;
using System.IO;

namespace AVL_projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            arvoreAVL arvore = new arvoreAVL();

            string[] comandos = File.ReadAllLines("entrada.txt");

            foreach (var linha in comandos)
            {
                string[] partes = linha.Split(' ');
                string comando = partes[0];

                if (comando == "I" || comando == "i")
                {
                    int valor = int.Parse(partes[1]);
                    arvore.Inserir(valor);
                }
                else if (comando == "R" || comando == "r")
                {
                    int valor = int.Parse(partes[1]);
                    arvore.Remover(valor);
                }
                else if (comando == "B" || comando == "b")
                {
                    int valor = int.Parse(partes[1]);
                    Console.WriteLine(arvore.Buscar(valor) ? "O Valor encontrado" : "O valor não encontrado");
                }
                else if (comando == "P" || comando == "p")
                {
                    Console.Write("Árvore em pré-ordem: ");
                    arvore.PreOrdem();
                }
                else if (comando == "F" || comando == "f")
                {
                    Console.WriteLine("Fatores de balanceamento:");
                    arvore.ImprimirFB();
                }
                else if (comando == "H" || comando == "h")
                {
                    Console.WriteLine($"Altura da árvore: {arvore.Altura()}");
                }
            }
        }
    }
}