using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cubo
{
    //1. Escreva um programa em C# para exibir o cubo do número inteiro. O usuário deve
    //informar a quantidade de inteiros que deve ser calculado.
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\n Informe a quantidades de inteiros: ");
            int n = Int32.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                double resultado = Math.Pow(i, 3);
                Console.WriteLine("O cubo do número {0} é: {1}", i, resultado);
            }
            Console.ReadKey();
        }
    }
}
