using System;
using System.Collections.Generic;

namespace Tamanho4ComFor
{
    internal class Program
    {
        /*Criar uma lista de strings com tamanho 4 e use o comando FOR para mostrar os elementos na tela e as suas posições.*/
        static void Main(string[] args)
        {
            List<string> tamanho = new List<string>() {"Casa", "Boca", "Olho", "Mesa", "Gás" };
            Console.WriteLine("A lista contém: ");

            for(int i = 0; i < tamanho.Count; i++)

           Console.WriteLine("Na posição {0} é: {1}", i, tamanho[i]);
            
           Console.ReadKey();

            

        }
    }
}
