using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class countSort
    {
        class countSortClass
        {
            Stopwatch contaTempo = new Stopwatch();
            //Gera os valores do vetor e já imprime
            //int[] vetor = rotinasVetor.gerarVetorParametro(5000000, 1, 75);
            //rotinasVetor.imprimeVetor(vetor);
            //Ordenação por contagem
            //Conta quantas vezes esse valor aparece no vetor
            //Volta esses valores para o vetor original
            //Parâmetros - O proprio valor
            //.Max() pega o maior elemento do valor
            void countSort(int[] vetor)
            {
                int maiorValorVetor = vetor.Max();
                //Esse mais um é por causa do zero
                int[] vetorAuxiliar = new int[maiorValorVetor + 1];
                //Conta as ocorrencias
                // Conta o número de ocorrências de cada elemento no array de entrada e coloca os elementos no array ordenado na ordem correta.
                contaTempo.Start();

                for (int i = 0; i < vetor.Length; i++)
                {
                    //Conta a frequência
                    //O que acontece com o vetor nesse momento:
                    //// frequência
                    //[1,9,1,3,4,7,6,7]
                    //[2,0,1,1,0,1,2,0,1]
                    vetorAuxiliar[vetor[i] - 1]++;
                }
                for (int i = 1; i < vetorAuxiliar.Length; i++)
                {
                    //Cumulativa
                    //Vetor fica dessa forma
                    //[2,2,3,4,4,5,7,7,8]
                    vetorAuxiliar[i] += vetorAuxiliar[i - 1];
                }
                int[] vetorFinal = new int[vetor.Length];
                for (int i = vetor.Length - 1; i >= 0; i--)
                {
                    //Volta os valores para o vetor original começando de trás para frente
                    vetorFinal[vetorAuxiliar[vetor[i] - 1] - 1] = vetor[i];
                    vetorAuxiliar[vetor[i] - 1] -= 1;
                }
                contaTempo.Stop();
                //rotinasVetor.imprimeVetor(vetorFinal);
                Console.WriteLine("Tempo de execucao: " + contaTempo.ElapsedMilliseconds + "milisegudos");
                //Console.WriteLine("Vetor ordenado: ");
            }
            //500 - 0, 1000 - 0, 5000 - 0, 10000 - 0, 50000 - 1, 100000 - 2 e 5000000 - 94
           //countSort(vetor);
        }
    }
}
