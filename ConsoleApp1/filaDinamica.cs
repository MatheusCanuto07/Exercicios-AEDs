using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class filaDinamica
    {
        static void main(string[] args)
        {
            Console.WriteLine("Qual o tamanho da Fila que você deseja criar: ");
            int tamanho = int.Parse(Console.ReadLine());

            int[] Fila = new int[tamanho];
            int posicao = 0;

            void inseriFila()
            {
                if (posicao == tamanho)
                    Console.WriteLine("Fila cheia, remova um elemento");
                else
                {
                    if (posicao == tamanho)
                        Console.WriteLine("Fila cheia, remova um elemento");
                    else
                    {
                        Console.WriteLine("Digite o valor a ser inserido");
                        int num = int.Parse(Console.ReadLine());
                        Fila[posicao] = num;
                        posicao++;
                    }
                }
            }

            void remove()
            {
                if (posicao != 0)
                {
                    for (int i = 0; i < posicao - 1; i++)
                    {
                        int aux = Fila[i];
                        Fila[i] = Fila[i + 1];
                        Fila[i + 1] = aux;
                    }
                    posicao--;
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
                    Console.WriteLine($"Elemento número {i + 1} da lista = {Fila[i]}");
                }
            }
            int flag = 0;


            do
            {
                Console.WriteLine("Menu - Fila inteligente");
                Console.WriteLine("1- Inserir na Fila");
                Console.WriteLine("2- Remover na Fila");
                Console.WriteLine("3- Verificar se a Fila está vazia");
                Console.WriteLine("4- Ler a Fila");
                Console.WriteLine("0- Sair");
                flag = int.Parse(Console.ReadLine());
                switch (flag)
                {
                    case 1:
                        inseriFila();
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
