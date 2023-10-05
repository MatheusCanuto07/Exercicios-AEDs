using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class AtivMergeSort
    {
        public AtivMergeSort() {
            //Gera valores aleatórios para o vetor
            int n = 10;
            //5 - 0, 10 - 0, 50 - 0, 100 - 0, 500 - 10, 1000 - 11, 5000 - 310, 10000 - 1479, 50000 - 27121, 100000 - Não finalizou  e 5000000 - Não finalizou.

            int[] vetor2 = new int[n];
            Random alea = new Random();

            Console.WriteLine("Vetor antes de ser ordenado");
            for (int i = 0; i < n; i++)
            {
                vetor2[i] = alea.Next(1, 100);
                //Console.WriteLine("Item número " + i + " - " + vetor2[i]);
            }

            //Metodo merge
            //Dividir e conquistar
            //Melhor, médio e pior caso: n log² n
            //Uso extra de memória por causa da funcao recursiva
            //1- Chamadas recursivas para obter um vetor pequeno
            //2- Juntar esse elementos que estão ordenados
            //Na hora de chamar a função esse fim deve ser o length do vetor - 1
            int[] mergeSort(int[] vetor, int ini, int fim)
            {
                int i, j, k;
                int[] vetAux = new int[vetor.Length];
                //O objetivo é dividir o vetor até ele ter apenas um elementos
                if (ini < fim)
                {
                    //Difinir o meio do vetor | Lembrando que vão acontecer chamadas recursivas
                    int meio = (ini + fim) / 2;
                    //Chamada recursiva para a primeira metade do vetor
                    mergeSort(vetor, ini, meio);
                    //Chamada recursiva para a segunda metade do vetor
                    mergeSort(vetor, meio + 1, fim);
                    //Juntar os elementos de forma ordenada
                    //Variaveis auxiliadoras
                    i = ini;
                    j = meio + 1;
                    k = ini;
                    //Comparar os elementos do primeiro vetor com os elementos do segundo
                    //Essas atribuições vão garantir que o que está sendo colocado dentro do vetor original está ordenado
                    //Logo a parte que sobra também está ordenada
                    while (i <= meio && j <= fim)
                    {
                        //Compara os elementos do "primeiro" vetor com os elementos do "segundo"
                        if (vetor[i] < vetor[j])
                        {
                            vetAux[k] = vetor[i];
                            i++;
                        }
                        else
                        {
                            vetAux[k] = vetor[j];
                            j++;
                        }
                        k++;
                    }
                    //2 whiles que vão o vetor auxiliar fique completo
                    //Esses dois whiles não vão ser na mesma execução
                    //Vamos supor que todos os elementos do segundo vetor passaram para a posição inicial do vetor auxiliar
                    //Desse forma o vetor auxiliar não tem a segunda parte do vetor que está ordenada, logo é necessário adicionar
                    //Essa segunda parte no vetor auxiliar

                    //Preenche a primeira parte do vetor caso seja nela que falte item
                    while (i <= meio)
                    {
                        vetAux[k] = vetor[i];
                        i++;
                        k++;
                    }

                    //Preenche a segunda parte do vetor caso seja nela que falte algum item
                    while (j <= fim)
                    {
                        vetAux[k] = vetor[j];
                        j++;
                        k++;
                    }

                }
                return vetAux;
            }

            Stopwatch contaTempo = new Stopwatch();
            contaTempo.Start();

            static void insertionSort(int[] arr)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    int key = arr[i];
                    int j = i - 1;

                    while (j >= 0 && arr[j] > key)
                    {
                        arr[j + 1] = arr[j];
                        j = j - 1;
                    }

                    arr[j + 1] = key;
                }
            }
            static void mergeSortFinal(int[] vetor, int inicio, int fim)
            {
                if (inicio < fim)
                {
                    Console.WriteLine(inicio);
                    int meio = (inicio + fim) / 2;
                    mergeSortFinal(vetor, inicio, meio);
                    mergeSortFinal(vetor, meio + 1, fim);
                    //O melhor metodo para ordenar o vetor´é o insertion por que ele não vai percorrer o vetor inteiro novamente
                    insertionSort(vetor);
                }
            }
            mergeSortFinal(vetor2, 0, vetor2.Length);

            contaTempo.Stop();

            Console.WriteLine("Vetor depois de ser ordenado");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Item número " + i + " - " + vetor2[i]);
            }

            Console.WriteLine("Tempo de execucao: " + contaTempo.ElapsedMilliseconds + "milisegudos");
        }
    }
}
