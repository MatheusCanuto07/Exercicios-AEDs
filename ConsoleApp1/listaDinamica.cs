//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    internal class listaDinamica
//    {
//        public static void Main(string[] args)
//        {
//            Console.WriteLine("Qual o tamanho da Lista que você deseja criar: ");
//            int tamanho = int.Parse(Console.ReadLine());

//            int[] Lista = new int[tamanho];
//            int posicao = 0;

//            void inserirElemento()
//            {
//                Console.WriteLine("Digite um número para ser inserido na lista: ");
//                int num = int.Parse(Console.ReadLine());

//                Lista[posicao] = num;
//                posicao++;
//            }

//            void removerElemento()
//            {
//                Console.WriteLine("Qual elemento você quer remover? ");
//                int num = int.Parse(Console.ReadLine());

//                for (int i = 0; i < posicao; i++)
//                {
//                    if (Lista[i] == num)
//                    {
//                        Lista[i] = 0;
//                    }
//                }
//            }

//            void removerLocalizacao()
//            {
//                Console.WriteLine("Qual localização você quer remover? ");
//                int num = int.Parse(Console.ReadLine());

//                if (num < posicao)
//                {
//                    Lista[num] = 0;
//                }
//                else
//                {
//                    Console.WriteLine("Digite uma localizacao válida!");
//                }
//            }

//            void verificarVazio()
//            {
//                if (posicao > 0)
//                    Console.WriteLine("A lista não está vazia");
//                else
//                    Console.WriteLine("A lista está vazia");
//            }

//            void lerElemento()
//            {
//                Console.WriteLine("Qual posição da lista você quer ler? ");
//                int num = int.Parse(Console.ReadLine());

//                if (num < posicao)
//                {
//                    Console.WriteLine(Lista[num]);
//                }
//                else
//                {
//                    Console.WriteLine("Digite uma localizacao válida!");
//                }
//            }

//            void concatenarListas()
//            {
//                int[] lista1 = new int[10];
//                int[] lista2 = new int[7];

//                int[] novaLista = new int[lista1.Length + lista2.Length];

//                for (int i = 0; i < lista1.Length; i++)
//                {
//                    novaLista[i] = lista1[i];
//                }

//                int j = 0;

//                for (int i = lista1.Length; i < lista1.Length + lista2.Length; i++)
//                {
//                    novaLista[i] = lista2[j];
//                    j++;
//                }
//            }

//            void percorrerLista()
//            {
//                for (int i = 0; i < Lista.Length; i++)
//                {
//                    Console.WriteLine(Lista[i]);
//                }
//            }

//            void localizarElemento()
//            {
//                Console.WriteLine("Qual elemento você quer localizar? ");
//                int num = int.Parse(Console.ReadLine());

//                int i = 0;
//                do
//                {
//                    if (Lista[i] == num)
//                    {
//                        Console.WriteLine("Elemento localizado na posição: " + i);
//                        i = tamanho;
//                    }
//                } while (i < tamanho);
//            }
//        }
//    }
//}
