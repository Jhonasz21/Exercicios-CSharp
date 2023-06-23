using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numerosInteiro
{
    // Construa um algoritmo que faça a soma dos N primeiros números inteiros. Determine
    // que o usuário forneça a quantidade N
    internal class Program
    {
        static void Main(string[] args)
        {
            int N, soma;

            Console.WriteLine("Digite valor de N: ");
            N = Int32.Parse(Console.ReadLine());

            soma = (N * (N + 1)) / 2;
            Console.WriteLine("Soma dos {0} primeiros números é: {1}", N, soma);
            Console.ReadKey();
        }
    }
}
