using System;
using System.Collections.Generic;


namespace nome5Amigos
{
    internal class Program
    {
        /* Criar uma lista com o nome de 5 amigos e depois ordene-a em ordem alfabética.
         */
        static void Main(string[] args)
        {
            List<string> amigos = new List<string> { "Akita", "Smith", "Jackson", "Bacon", "Daniel" };

            Console.WriteLine("Nomes do amigos na lista:\n ", amigos);
            foreach(string nomes in amigos)
            {
                Console.WriteLine("{0}", nomes);
            }

            amigos.Sort();
            Console.WriteLine("Nomes em ordem alfabética:\n ");
            foreach(string nomes in amigos)
            {
                Console.WriteLine("{0}", nomes);
            }
            Console.ReadKey();
        }
    }
}
