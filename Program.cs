using System;

namespace AtividadeDeAEDs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Essa é a formula que define um fatorial de um número
            //n! = n * (n - 1)!
            //Fatorando essa função
            //n! = n * (n - 1) * (n-2) * (n-3) ... * 1
            int fatorialComFuncao(int n)
            {   
                //Define o ponto de parada da recursividade
                if(n == 0)
                    return 1;
                //n! = n * (n-1) * (n-2) * (n-3) ... * 1
                else
                    return n * fatorialComFuncao(n - 1);
            }
            int fat = fatorialComFuncao(5);

            int Fibonacci(int n)
            {
                int f = 1;
                //F = Fn-1 + fn-2 ...
                for(int i = 0; i < n; i++)
                {
                   f = f(i - 1);   
                }
            }
            void fatorialComFor()
            {
                Console.WriteLine("Digite o número que você deseja um fatorial: ");
                int num = int.Parse(Console.ReadLine());

                Console.WriteLine(num);
                int aux = 1;
                for (int i = 1; i < num; i++)
                {
                    aux += i * aux;
                }

                Console.WriteLine("Esse é o valor do fatorial: " + aux);
                Console.ReadKey();
            }
        }
    }
}
