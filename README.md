# AVL Tree in C#

Repositório: https://github.com/ArlysonSilva/avl-tree-csharp

## Descrição
Este projeto é uma implementação acadêmica de uma **Árvore Binária de Busca Balanceada (AVL)** em C#. O programa lê comandos de um arquivo de texto para realizar operações como inserção, remoção e busca, garantindo a eficiência das operações através do auto-balanceamento.

## Uso
1. Clone o repositório:
git clone https://github.com/ArlysonSilva/avl-tree-csharp.git

2. Execute o programa:
dotnet run

## Comandos
| Comando | Descrição                      |
|---------|--------------------------------|
| I <x>   | Inserir valor x                |
| R <x>   | Remover valor x                |
| B <x>   | Buscar valor x                 |
| P       | Imprimir pré-ordem             |
| F       | Imprimir fator de balanceamento|
| H       | Mostrar altura da árvore       |

3. Crie um arquivo `entrada.txt` com comandos, por exemplo:
I 10
I 20
B 10
R 20
P
F
H


## Arquivos
- arvoreAVL.cs: Lógica da árvore AVL
- no.cs: Classe Nó
- program.cs: Programa principal
-entrada.txt: Exemplo de utilização

## Integrantes
- Kauan Melo - RA: 113471  
- Arlyson Silva - RA: 113627  
- Richard Nicholas Rocha - RA: 113760  
