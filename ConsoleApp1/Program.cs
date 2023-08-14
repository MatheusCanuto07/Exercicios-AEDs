namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
                Console.ReadKey();
            }
            void atividade_9()
            {
                Console.WriteLine("Digite o seu nome: ");
                string nome = Console.ReadLine();

                Console.WriteLine("Digite o seu e-mail: ");
                string email = Console.ReadLine();

                Console.WriteLine("Digite o seu telefone: ");
                string telefone = Console.ReadLine();
            }
            atividade_8();
        }
    }
}