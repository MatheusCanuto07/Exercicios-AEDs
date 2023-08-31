using System.Globalization;
using System.IO;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
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
                Console.WriteLine(num % 2 == 0 ? "É par!": "É impar!");  
            }
            void atividade_3()
            {
                
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
            #endregion
            #region Atividades Nivelamento 2
            #endregion
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
            int [] vetor = new int[4];
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
            int fun = quantLetraNaFrasereduzido(0,nome, a);
            Console.WriteLine(fun);

            //Escreva um método recursivo que calcule a soma dos elementos de valor par de um vetor de números inteiros positivos.
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
                switch (frase[i]){
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
                if(num % 2 == 0)
                    binario = "0" + binario;
                else
                    binario += "1" + binario;

                return converteBinario(num / 2, binario, i + 1);
            }
            string resultado = converteBinario(64, "", 0);
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
    }
}