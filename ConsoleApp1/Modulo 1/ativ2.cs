using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ativ2
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
}
