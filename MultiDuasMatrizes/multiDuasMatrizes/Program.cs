using System;


namespace MultiDuasMatrizes
{
    /* Escreva um programa em C# para multiplicação de duas matrizes em que a 
     * ordem delas seja fornecida pelo usuário. Mostre cada matriz na tela.*/
    internal class Program
    {
        static void Main(string[] args)
        {

            int linhaA, colunaA, linhaB, colunaB;
            Console.Write(" Informe o número de linhas da matriz A: ");
            linhaA = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Informe o número de colunas da matriz A: ");
            colunaA = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Informe o número de linhas da matriz B: ");
            linhaB = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Informe o número de colunas da matriz B: ");
            colunaB = Convert.ToInt32(Console.ReadLine());
            
           
            int[,] matrizA = new int[linhaA, colunaA];
            Console.WriteLine(" Digite os elementos da matriz A");
           
            for (int i = 0; i < matrizA.GetLength(0); i++)
            {
                for (int j = 0; j < matrizA.GetLength(1); j++)
                {
                    matrizA[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine(" A saída da matriz A será ");
           
            for (int i = 0; i < linhaA; i++)
            {
                for (int j = 0; j < colunaA; j++)
                {
                    Console.Write(" Posição [{0},{1}]: {2}", i, j, matrizA[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
            
          
            int[,] matrizB = new int[linhaB, colunaB];
            Console.WriteLine("\n Digite os elementos da matriz B");
            
            for (int i = 0; i < matrizB.GetLength(0); i++)
            {
                for (int j = 0; j < matrizB.GetLength(1); j++)
                {
                    matrizB[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine(" \n A saída da matriz B será ");
            
            for (int i = 0; i < linhaB; i++)
            {
                for (int j = 0; j < colunaB; j++)
                {
                    Console.Write(" Posição[{0},{1}]: {2}", i, j, matrizB[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
            
            
            if (colunaA != linhaB)
            {
                Console.WriteLine("\n Não é possível o número de colunas da matriz A é diferente do número de linhas da matriz B");
            }
            else
            {
                Console.WriteLine(" \n A saída da matriz C será ");
                int[,] matrizC = new int[colunaA, linhaB];
                for (int i = 0; i < colunaA; i++)
                {
                    for (int j = 0; j < linhaB; j++)
                    {
                        matrizC[i, j] = 0;
                        for (int x = 0; x < colunaA; x++)
                        {
                            matrizC[i, j] += matrizA[i, x] * matrizB[x, j];
                        }
                        Console.Write("\n Posição[{0},{1}]: {2}", i, j, matrizC[i, j]);
                    }
                    Console.WriteLine();
                }
            }
            Console.ReadKey();


        }
    }
}
