using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace somaDoVetor
{
    /* Escreva um programa em C# para encontrar a soma de todos os elementos
     * de um vetor de tamanho 10 e que mostre esses elementos na tela..
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            int soma = 0;
            for (int i = 0; i < vetor.Length; i++)
            {
                soma += vetor[i];
            }

            Console.WriteLine("A soma do vetor é: " + soma);
            Console.ReadKey();
        }
    }
}
