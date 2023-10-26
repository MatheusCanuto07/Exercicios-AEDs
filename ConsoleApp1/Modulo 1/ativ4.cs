using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ativ4 { 
        static void Main2(string[] args)
        {
            int n = 5000000;

            int[] vetor2 = new int[n];
            Random alea = new Random();
            for (int i = 0; i < n; i++)
            {
                vetor2[i] = alea.Next(1, 100);
            }
            Stopwatch contaTempo = new Stopwatch();
            //Metodo de bolha
            //Esse metodo tem esse nome porque acontece muitas trocas(borbulhas de trocas)
            //Metodo mais ineficiente
            
            for (int i = 0; i < vetor2.Length; i++)
            {
                for (int j = i + 1; j < vetor2.Length; j++)
                {
                    if (vetor2[i] > vetor2[j])
                    {
                        int aux = vetor2[i];
                        vetor2[i] = vetor2[j];
                        vetor2[j] = aux;
                    }
                }
            }
            
            //Tempo em milisegundos
            //5 - 0, 10 - 0, 50 - 0, 100 - 0, 500 - 0, 1000 - 3, 5000 - 99, 10000 - 399, 50000 - 6761, 100000 - 24733  e 5000000 - Coloquei para fazer fiquei 3 minutos no instagram e não terminou.


            //Metodo selection short
            //A ideia central desse metodo é selecionar o menor elemento e coloca-lo na primeira posição
            //Um for que passa por todos os elementos do array
            //Lógica do selecion short, define o item como menor, vê se tem algum menor do que ele e depois faz a troca
            contaTempo.Start();
            for (int i = 0; i < vetor2.Length; i++)
            {
                //2- Definir que a posição i do vetor é a menor e fazer mais um for que vai ter as comparações, a ideia do selection short é definir o primeiro elemento como o menor e caminhar pelo vetor
                int menorPosicao = i;
                for (int j = i; j < vetor2.Length; j++)
                {
                    if (vetor2[j] < vetor2[menorPosicao])
                    {
                        menorPosicao = j;
                    }
                }
                int aux = vetor2[i];
                vetor2[i] = vetor2[menorPosicao];
                vetor2[menorPosicao] = aux;
            }
            contaTempo.Stop();
            Console.WriteLine("Tempo de execucao: " + contaTempo.ElapsedMilliseconds + "milisegudos");
            //Tempo em milisegundos
            //5 - 0, 10 - 0, 50 - 0, 100 - 0, 500 - 0, 1000 - 10, 5000 - 64, 10000 - 282, 50000 - 5623, 100000 - 22620  e 5000000 - Coloquei para fazer fiquei 3 minutos no instagram e não terminou.


            //Metodo Insertion Sort
            //Insertion Sort ou ordenação por inserção é o método que percorre um vetor de elementos da esquerda para a
            //direita e à medida que avança vai ordenando os elementos à esquerda
            //for (int i = 0; i < vetor2.Length; i++)
            //{
            //    int aux = vetor2[i];
            //    int j = i - 1;

            //    while (j >= 0 && vetor2[j] > aux)
            //    {
            //        vetor2[j + 1] = vetor2[j];
            //        j = j - 1;
            //    }

            //    vetor2[j + 1] = aux;
            //}
            //5 - 0, 10 - 0, 50 - 0, 100 - 0, 500 - 0, 1000 - 0, 5000 - 48, 10000 - 250, 50000 - 5501, 100000 - 20254  e 5000000 - Coloquei para fazer fiquei 3 minutos no instagram e não terminou.



            //O metodo de bolha é caro porque no seu melhor caso ele vai percorrer o vetor inteiro fazendo comparações - O(n^2)
            //O metodo selection short é caro porque no seu pior caso ele vai percorrer o vetor inteiro fazendo comparações, a diferença dele para o metodo de bolha
            //está na lógica, ao invez dele ir "varrendo" o vetor ele define que aquela posição representa o menor valor e vai tentando fazer trocas
            //O metodo  Insertion Sort aplica várias vezes a inserção ordenada para ordenar uma sequência. Possui O(n^2)

            //Console.WriteLine("Vetor ordenado");
            //for (int i = 0; i < vetor2.Length; i++)
            //{
            //    Console.WriteLine(vetor2[i]);
            //}

        }
    }
}
