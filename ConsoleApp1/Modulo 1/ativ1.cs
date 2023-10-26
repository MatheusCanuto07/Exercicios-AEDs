using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ativ1
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
}
