using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matriz2D
{
    internal class Program
    {
        /* Escreva um programa em C# para uma matriz 2D de tamanho 3x3 e a imprima. */
        static void Main(string[] args)
        {
            int[,] matriz = new int[3, 3];

            for (int i = 0; i < matriz.GetLength(0); i++)
             {
                for(int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.WriteLine("Informe os elementos do vetor [{0},{1}]: ", i, j);
                    matriz[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.ReadKey();
            Console.WriteLine("Imprimindo a matriz ");
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                Console.Write("{0}" , matriz[i, j] + " ");
                }
                    Console.Write(" ");
            }

            Console.ReadKey();

        }
    }
}
