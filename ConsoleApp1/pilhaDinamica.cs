using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class pilhaDinamica
    {
        static void main(string[] args)
        {
            Console.WriteLine("Qual o tamanho da Pilha que você deseja criar: ");
            int tamanho = int.Parse(Console.ReadLine());

            int[] pilha = new int[tamanho];
            int posicao = 0;

            void inseriPilha()
            {
                if (posicao == tamanho)
                    Console.WriteLine("Pilha cheia, remova um elemento");
                else
                {
                    Console.WriteLine("Digite o valor a ser inserido");
                    int num = int.Parse(Console.ReadLine());
                    pilha[posicao] = num;
                    posicao++;
                }
            }

            void remove()
            {
                if (posicao != 0)
                {
                    posicao--;
                    pilha[posicao] = 0;
                    Console.WriteLine("Item removido com sucesso");
                }
                else
                {
                    Console.WriteLine("A lista está vazia!");
                }
            }

            void verificarVazio()
            {
                if (posicao == 0)
                    Console.WriteLine("A lista está vazia! ");
                else
                    Console.WriteLine("A lista não está vazia!");
            }

            void ler()
            {
                Console.WriteLine("A lista tem " + posicao + " elementos");
                for (int i = 0; i < posicao; i++)
                {
                    Console.WriteLine($"Elemento número {i + 1} da lista = {pilha[i]}");
                }
            }
            int flag = 0;


            do
            {
                Console.WriteLine("Menu - Pilha inteligente");
                Console.WriteLine("1- Inserir na Pilha");
                Console.WriteLine("2- Remover na Pilha");
                Console.WriteLine("3- Verificar se a Pilha está vazia");
                Console.WriteLine("4- Ler a Pilha");
                Console.WriteLine("0- Sair");
                flag = int.Parse(Console.ReadLine());
                switch (flag)
                {
                    case 1:
                        inseriPilha();
                        break;
                    case 2:
                        remove();
                        break;
                    case 3:
                        verificarVazio();
                        break;
                    case 4:
                        ler();
                        break;
                    default:
                        Console.WriteLine("Tchau!");
                        break;
                }

            } while (flag != 0);
        }
    }
}
