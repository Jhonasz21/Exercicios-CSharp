using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista6Elementos
{
    /* Criar uma lista de strings com 6 elementos e apresentar na tela. 
       Depois fazer a verificação informando se algum elemento está contido nela.
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> vetor = new List<string> { "Casa", "Rua", "Cidade", "Estado", "Carro", "Bicicleta" };
           
                Console.WriteLine("Aqui estão os objetos:");
                foreach (string item in vetor)
                {
                    Console.WriteLine("{0}", item);
                }

                Console.WriteLine("\nDigite o elemento a procurar!");
                string EncontraString = Console.ReadLine();

                if (vetor.Contains(EncontraString))
                {
                    Console.WriteLine("Elemento contém no vetor");
                }
                else
                {
                    Console.WriteLine("Elemento não contém no vetor");
                }

                Console.ReadKey();

        }
    }
}
