using System.Globalization;
using System.IO;
using System.Diagnostics;
using System;
using System.Runtime.ConstrainedExecution;

namespace ConsoleApp1
{
    internal class Program
    {
        class rotinasVetor
        {
            public static int [] gerarVetor(int tamanho)
            {
                int[] vetor = new int[tamanho];
                for (int i = 0; i < tamanho; i++)
                {
                    vetor[i] = new Random().Next(1, 10);
                }
                 
                return vetor;
            }
            public static int[] gerarVetorParametro(int tamanho, int numInicial, int numFinal)
            {
                int[] vetor = new int[tamanho];
                for (int i = 0; i < tamanho; i++)
                {
                    vetor[i] = new Random().Next(numInicial, numFinal);
                }
                return vetor;
            }
            public static void imprimeVetor(int[] vetor)
            {
                for(int i = 0;i < vetor.Length;i++)
                {
                    Console.WriteLine("Elemento número " + i + " = " + vetor[i]);
                }
            }
        }
        class AlgoritmosDeOrdenacao
        {
            public static void bubbleSort(int[] vetor)
            {
                //Metodo de bolha
                //Esse metodo tem esse nome porque acontece muitas trocas(borbulhas de trocas)
                //Metodo mais ineficiente

                for (int i = 0; i < vetor.Length; i++)
                {
                    for (int j = i + 1; j < vetor.Length; j++)
                    {
                        if (vetor[i] > vetor[j])
                        {
                            int aux = vetor[i];
                            vetor[i] = vetor[j];
                            vetor[j] = aux;
                        }
                    }
                }

                //Tempo em milisegundos
                //5 - 0, 10 - 0, 50 - 0, 100 - 0, 500 - 0, 1000 - 3, 5000 - 99, 10000 - 399, 50000 - 6761, 100000 - 24733  e 5000000 - Coloquei para fazer fiquei 3 minutos no instagram e não terminou.
            }
            public static void selectionSort(int[] vetor)
            {
                //Metodo selection short
                //A ideia central desse metodo é selecionar o menor elemento e coloca-lo na primeira posição
                //Um for que passa por todos os elementos do array
                //Lógica do selecion short, define o item como menor, vê se tem algum menor do que ele e depois faz a troca
                for (int i = 0; i < vetor.Length; i++)
                {
                    //2- Definir que a posição i do vetor é a menor e fazer mais um for que vai ter as comparações, a ideia do selection short é definir o primeiro elemento como o menor e caminhar pelo vetor
                    int menorPosicao = i;
                    for (int j = i; j < vetor.Length; j++)
                    {
                        if (vetor[j] < vetor[menorPosicao])
                        {
                            menorPosicao = j;
                        }
                    }
                    int aux = vetor[i];
                    vetor[i] = vetor[menorPosicao];
                    vetor[menorPosicao] = aux;
                }
                //Tempo em milisegundos
                //5 - 0, 10 - 0, 50 - 0, 100 - 0, 500 - 0, 1000 - 10, 5000 - 64, 10000 - 282, 50000 - 5623, 100000 - 22620  e 5000000 - Coloquei para fazer fiquei 3 minutos no instagram e não terminou.
            }
            public static void insertionSort(int[] vetor)
            {
                //Metodo Insertion Sort
                //Insertion Sort ou ordenação por inserção é o método que percorre um vetor de elementos da esquerda para a
                //direita e à medida que avança vai ordenando os elementos à esquerda
                for (int i = 0; i < vetor.Length; i++)
                {
                    int aux = vetor[i];
                    int j = i - 1;

                    while (j >= 0 && vetor[j] > aux)
                    {
                        vetor[j + 1] = vetor[j];
                        j = j - 1;
                    }

                    vetor[j + 1] = aux;
                }
                //O metodo de bolha é caro porque no seu melhor caso ele vai percorrer o vetor inteiro fazendo comparações - O(n^2)
                //O metodo selection short é caro porque no seu pior caso ele vai percorrer o vetor inteiro fazendo comparações, a diferença dele para o metodo de bolha
                //está na lógica, ao invez dele ir "varrendo" o vetor ele define que aquela posição representa o menor valor e vai tentando fazer trocas
                //O metodo  Insertion Sort aplica várias vezes a inserção ordenada para ordenar uma sequência. Possui O(n^2)
            }
            public static void mergeSort(int[] vetor, int ini, int fim)
            {
                //Metodo merge
                //Dividir e conquistar
                //Melhor, médio e pior caso: n log² n
                //Uso extra de memória por causa da funcao recursiva
                //1- Chamadas recursivas para obter um vetor pequeno
                //2- Juntar esse elementos que estão ordenados
                //Na hora de chamar a função esse fim deve ser o length do vetor - 1
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
            }
            public static void mergeSortRecursivo(int[] vetor, int inicio, int fim)
            {
                if (inicio < fim)
                {
                    Console.WriteLine(inicio);
                    int meio = (inicio + fim) / 2;
                    //mergeSortFinal(vetor, inicio, meio);
                    //mergeSortFinal(vetor, meio + 1, fim);
                    //O melhor metodo para ordenar o vetor´é o insertion por que ele não vai percorrer o vetor inteiro novamente
                    insertionSort(vetor);
                }
            }
            public static void shellSort(int[] lista, int tamanho)
            {
                int i, j, aux;
                //Determinação de k de acordo com o metodo cientifico explicado no vídeo: https://www.youtube.com/watch?v=N5flk53THTo
                double k = Math.Log(tamanho + 1) / Math.Log(3);
                k = Math.Round(k);
                int h = Convert.ToInt32((Math.Pow(3, k) - 1) / 2);
                while (h > 0)
                {
                    for (i = 0; i < tamanho - h; i++)
                    {
                        if (lista[i] > lista[i + h])
                        {
                            aux = lista[i + h];
                            lista[i + h] = lista[i];
                            lista[i] = aux;
                            j = i - h;
                            while (j >= 0)
                            {
                                if (aux < lista[j])
                                {
                                    lista[j + h] = lista[j];
                                    lista[j] = aux;
                                }
                                else
                                {
                                    break;
                                }
                                j = j - h;
                            }
                        }
                    }
                    h = (h - 1) / 3;
                }
            }
            public static void countSort(int[] vetor)
            {
                int maiorValorVetor = vetor.Max();
                //Esse mais um é por causa do zero
                int[] vetorAuxiliar = new int[maiorValorVetor + 1];
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
                //500 - 0, 1000 - 0, 5000 - 0, 10000 - 0, 50000 - 1, 100000 - 2 e 5000000 - 94
            }
        }
        public void atividadeNivelamento01()
        {
            #region Atividades Nivelamento 1
            void atividade_1()
            {
                int[] idade = new int[5];
                int soma = 0;
                for (int i = 0; i < idade.Length; i++)
                {
                    Console.WriteLine("Digite a idade do aluno ");
                    idade[i] = int.Parse(Console.ReadLine());
                    soma += idade[i];
                }
                soma = soma / 5;
                Console.WriteLine(soma);
            }
            void atividade_2()
            {
                int num;
                Console.WriteLine("Digite um número");
                num = int.Parse(Console.ReadLine());
                Console.WriteLine(num % 2 == 0 ? "É par!" : "É impar!");
            }
            void atividade_3()
            {
                //Faça um algoritmo que exiba quantas pessoas possuem mais de 18 anos. O algoritmo deverá ler a idade de 10 pessoas.
                int[] idades = new int[5];
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Digite a idade da pessoa " + i);
                    idades[i] = int.Parse(Console.ReadLine());
                }
            }
            void atividade_4()
            {
                //Faça um algoritmo que leia a altura e a matricula de dez aluno. Mostre a matricula do aluno mais alto e do aluno mais baixo.
                Double[] altura = new Double[10];
                int[] matricula = new int[10];

                int maisBaixo = 0;
                int maisAlto = 0;

                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Digite a altura da " + i + "º pessoa!");
                    altura[i] = Double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite a matricula da pessoa " + i + "° pessoa!");
                    matricula[i] = int.Parse(Console.ReadLine());

                    if (maisBaixo < altura[i])
                    {
                        maisBaixo = i;
                    }

                    if (maisAlto > altura[i])
                    {
                        maisAlto = i;
                    }
                }
                Console.WriteLine("A matrícula do aluno mais alto é: " + matricula[maisAlto]);
                Console.WriteLine("A matrícula do aluno mais baixo é: " + matricula[maisBaixo]);
            }
            void atividade_5()
            {
                Double resul = 0.0;

                Console.WriteLine("Digite um número: ");
                Double num1 = Double.Parse(Console.ReadLine());

                Console.WriteLine("Digite um número: ");
                Double num2 = Double.Parse(Console.ReadLine());

                Console.WriteLine("Digite qual operação você deseja fazer: (x,/,+,-)");
                string ope = Console.ReadLine();

                switch (ope)
                {
                    case "*":
                        resul = num1 * num2;
                        Console.WriteLine(resul);
                        break;
                    case "/":
                        resul = num1 / num2;
                        Console.WriteLine(resul);
                        break;
                    case "+":
                        resul = num1 + num2;
                        Console.WriteLine(resul);
                        break;
                    case "-":
                        resul = num1 - num2;
                        Console.WriteLine(resul);
                        break;
                    default:
                        Console.WriteLine("Digite uma operação válida!");
                        break;
                }
            }
            void atividade_6()
            {
                int idade = 0;
                Console.WriteLine("Digite a sua idade");
                idade = int.Parse(Console.ReadLine());

                if (idade < 18)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Você não tem permissão!");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Você tem permissão!");
                }
            }
            void atividade_7()
            {
                Console.WriteLine("Digite uma frase qualquer");
                string frase = Console.ReadLine();

                for (int i = 0; i < frase.Length; i++)
                {
                    //Console.WriteLine("Essa é a "+ (i + 1 ) + "° do seu nome: "+ frase[i]);
                    if ((frase[i] == 'a') || (frase[i] == 'A'))
                    {
                        //String é imutável
                        frase = frase.Remove(i, 1).Insert(i, "&");
                    }
                }
                Console.WriteLine(frase);
            }
            void atividade_8()
            {
                Console.WriteLine("Digite o seu salário: ");
                double salario = Double.Parse(Console.ReadLine());

                if (salario < 1700.00)
                {
                    salario += 300.00;
                }
                else
                {
                    salario += 200.00;
                }

                Console.WriteLine("Esse é o seu novo salário: " + salario);
            }
            void atividade_9()
            {
                Console.WriteLine("Digite o seu nome: ");
                string nome = Console.ReadLine();

                Console.WriteLine("Digite o seu e-mail: ");
                string email = Console.ReadLine();

                Console.WriteLine("Digite o seu telefone: ");
                string telefone = Console.ReadLine();

                StreamWriter arquivo = new StreamWriter(@"C:\Users\1380848\Desktop\Exercicios AEDs\Exercicios-AEDs\ConsoleApp1\banco.txt");
                arquivo.WriteLine(nome + ";");
                arquivo.WriteLine(email + ";");
                arquivo.WriteLine(telefone);
                arquivo.Close();
            }
            void atividade_10()
            {
                string res = "";
                while (res != "0")
                {
                    Console.WriteLine("Digite a operação: ");
                    Console.WriteLine("0- Sair");
                    Console.WriteLine("1- Gravar uma nova pessoa");
                    Console.WriteLine("2- Consultar pessoas registradas");
                    res = Console.ReadLine();
                    if (res == "1")
                    {
                        StreamWriter gravar = new StreamWriter("C:\\Users\\Matheus Canuto\\source\\repos\\ConsoleApp1\\ConsoleApp1\\banco1.txt", true);
                        Console.WriteLine("Digite o nome para gravar: ");
                        String nome = Console.ReadLine();
                        Console.WriteLine("Digite sua idade: ");
                        int idade = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite seu peso: ");
                        double peso = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite sua altura (ex: 1,77): ");
                        double altura = double.Parse(Console.ReadLine());

                        double IMC = (peso / (altura * altura));

                        gravar.WriteLine(nome + ";");
                        gravar.WriteLine(idade + ";");
                        gravar.WriteLine(peso + ";");
                        gravar.WriteLine(altura + ";");
                        gravar.WriteLine(IMC + ";");

                        gravar.Close();

                        Console.WriteLine("Salvo com sucesso! " + nome + " ; " + idade + " ; " + peso + " ; " + altura + ";" + IMC + ";");
                        Console.ReadKey();
                    }
                    else if (res == "2")
                    {
                        StreamReader ler = new StreamReader("C:\\Users\\Matheus Canuto\\source\\repos\\ConsoleApp1\\ConsoleApp1\\banco1.txt");
                        string dados = "";
                        while ((dados = ler.ReadLine()) != null)
                        {
                            Console.WriteLine(dados);
                        }
                    }
                }
            }
            #endregion
        }
        public void atividadeNivelamento02()
        {
            void ativ1()
            {
                int cont = 0;

                for (int i = 1000; i <= 9999; i++)
                {
                    int primeiNum = (int)i / 100;
                    int segundoNum = i % 100;
                    Console.WriteLine(segundoNum);

                    if (Math.Pow(primeiNum + segundoNum, 2) == i)
                    {
                        cont++;
                    }
                }

                Console.WriteLine(cont);
            }
            void nInteiro()
            {
                int num = 0;
                int cont = 0;
                int cont2 = 0;
                int contaNPerfeito = 0;

                Console.WriteLine("Digite um número: ");
                num = int.Parse(Console.ReadLine());

                for (int i = num - 1; i > 1; i--)
                {
                    if (num % i == 0)
                    {
                        cont++;
                    }
                }

                if (cont != 0)
                    Console.WriteLine("Não é primo");
                else
                    Console.WriteLine("É primo");

                for (int j = 1000; j > 1; j--)
                {
                    int contNPerfeito = 0;
                    for (int i = j - 1; i > 1; i--)
                    {
                        if (j % i == 0)
                        {
                            contNPerfeito += i;
                        }
                    }
                    if (j == contNPerfeito + 1)
                    {
                        cont2++;
                        Console.WriteLine($"O número {j} é perfeito.");
                    }

                }

                Console.WriteLine(cont2);

            }
            void operacoesComVetor()
            {
                int[] a = new int[5];
                int[] b = new int[5];

                for (int i = 0; i < a.Length; i++)
                {
                    Console.WriteLine("Digite um número: ");
                    a[i] = int.Parse(Console.ReadLine());
                }

                for (int i = 0; i < b.Length; i++)
                {
                    Console.WriteLine("Digite um número: ");
                    b[i] = int.Parse(Console.ReadLine());
                }

                int[] c = new int[5];
                int aux = 0;

                int[] d = new int[5];
                int aux2 = 0;

                bool flag = false;
                for (int i = 0; i < c.Length; i++)
                {
                    for (int j = 0; j < c.Length; j++)
                    {
                        if (a[i] == b[j])
                        {
                            c[aux] = a[i];
                            aux++;
                            flag = true;
                        }
                        if (flag == true)
                        {
                            d[aux2] = a[i];
                            aux2++;
                        }
                    }
                }

            }
            void matriz()
            {
                int[,] matrix = new int[3, 5];
                int aux1 = 0;
                int aux2 = 0;

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        aux1 += matrix[i, j];
                    }
                    aux2 += aux1;
                }
            }
            void calculaFatorial()
            {
                Console.WriteLine("Digite  um número: ");
                int num = int.Parse(Console.ReadLine());

                int resul = 1;

                for (int i = num; i > 1; i--)
                {
                    resul *= i;
                }

                Console.WriteLine(resul);
            }
            int potencia(int n1, int n2, ref int resulta)
            {
                for (int i = 0; i < n2; i++)
                {
                    resulta *= n1;
                }

                return resulta;
            }
        }
        public void atividadeRecursividade()
        {
            #region Atividades Fatorial
            int fatorial(int res)
            {
                if (res == 1)
                    return 1;
                return res * fatorial(res - 1);

            }
            //Função fibonatti
            //Console.WriteLine("Digite um número para o algoritmo determinar qual o seu valor no fibonatti");
            //int num = int.Parse(Console.ReadLine());
            //Fibonatti começa a contar do 1
            //A lógica é a mesma do fatorial, ele tenta resolver as contas e não consegue e por isso ele vai chamando funções diferentes
            int fibonatti(int num)
            {
                //1, 1, 2, 3, 5, 8, 13, 21
                if (num == 0 || num == 1)
                    return num;
                return fibonatti(num - 1) + fibonatti(num - 2);
            }
            #region Mostrar numeros fibonatti
            //int a = 0;
            //int b = 1;
            //int c = 0;
            //for (int i = 0; i <= 8; i++)
            //{
            //if (i == 0)
            //{
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //}
            //c = a + b;
            //a = b;
            //b = c;
            //Console.WriteLine(c);
            //}
            //int num = fibonatti(5);
            //Console.WriteLine(num);
            #endregion
            int somarVetor(int[] vetor, int aux)
            {
                if (aux == vetor.Length)
                    return 0;
                return vetor[aux] + somarVetor(vetor, aux + 1);
            }
            int somarComRecursividade(int a, int b)
            {
                if (b == 0)
                    return 0;
                return a + somarComRecursividade(a, b - 1);
            }
            int achaInteiro(int[] vetor, int aux)
            {
                //Os paramêtros são o vetor e uma variavel auxiliadora
                //Na hora de chamar essa função o segundo parametro vai ser o indice do vetor
                //Esse primeiro trecho monta toda a estrutura da recursividade
                //Dessa forma o vetor roda de cima para baixo
                if (vetor[aux] < 0)
                    return -1;
                if (aux == 0)
                    return aux;
                return achaInteiro(vetor, aux - 1);
            }
            int[] vetor = new int[4];
            //vetor[0] = 20;
            //vetor[1] = 20;
            //vetor[2] = 20;
            //vetor[3] = 20;
            //int teste = achaInteiro(vetor, vetor.Length - 1);
            //Console.WriteLine(teste); 
            int potenciaComRecursividade(int a, int b)
            {
                if (b == 0)
                    return 1;
                return a * potenciaComRecursividade(a, b - 1);
            }
            int quantLetraNaFrasereduzido(int pos, string cadeia, char letra)
            {
                if (pos == cadeia.Length)
                    return 0;
                if (cadeia[pos] == letra)
                    return 1 + quantLetraNaFrasereduzido(pos + 1, cadeia, letra);
                else
                    return 0 + quantLetraNaFrasereduzido(pos + 1, cadeia, letra);
            }
            int quantLetraNaFrase(string frase, char letra, int contador, int conta)
            {
                if (letra == frase[contador])
                    conta = conta + 1;
                if (contador == 0)
                    return conta;
                return quantLetraNaFrase(frase, letra, contador - 1, conta);
            }
            char a = 'o';
            string nome = "Leonardo";
            //int fun = quantLetraNaFrasereduzido(0,nome, a);
            //Console.WriteLine(fun);

            //Escreva um método recursivo que calcule a soma dos elementos de valor par de um vetor de
            //números inteiros positivos.
            int calculaSomaValorPar(int[] vetor, int aux, int soma)
            {
                if (vetor[aux] % 2 == 0)
                    soma = soma + vetor[aux];
                if (aux == 0)
                    return soma;
                return calculaSomaValorPar(vetor, aux - 1, soma);
            }
            //vetor[0] = 50;
            //vetor[1] = 90;
            //vetor[2] = 20;
            //vetor[3] = 20;
            //int teste = calculaSomaValorPar(vetor, vetor.Length - 1, 0);
            //Console.WriteLine(teste);
            string tiraVocal(string frase, int i, string novaFrase)
            {
                //Substituir switch case por if e else if
                switch (frase[i])
                {
                    case 'a':
                        novaFrase += " ";
                        break;
                    case 'e':
                        novaFrase += " ";
                        break;
                    case 'i':
                        novaFrase += " ";
                        break;
                    case 'o':
                        novaFrase += " ";
                        break;
                    case 'u':
                        novaFrase += " ";
                        break;
                    default:
                        novaFrase += frase[i];
                        break;
                }

                if (i == frase.Length - 1)
                    return novaFrase;

                return tiraVocal(frase, i + 1, novaFrase);
            }
            //string frase = "O Matheus é o cara";
            //string montaFrase = tiraVocal(frase, 0, "");
            //Console.Write(montaFrase);
            //Escreva um método recursivo que converta um número em binário.
            string converteBinario(int num, string binario, int i)
            {
                if (i == 0)
                    return binario;
                if (num % 2 == 0)
                    binario = "0" + binario;
                else
                    binario += "1" + binario;

                return converteBinario(num / 2, binario, i + 1);
            }
            #endregion
            #region Fatorial com um parametro
            int fatorialComUmParametro(int[] vetor)
            {
                if (vetor.Length == 0)
                    return vetor[0];

                return vetor[0] + fatorialComUmParametro(vetor);
            }
            #endregion

        }
        static void Main(string[] args)
        {

        }
    }
}