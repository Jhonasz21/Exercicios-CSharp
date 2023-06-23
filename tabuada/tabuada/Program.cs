using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabuada
{
    // Construa a tabuada de adição ou multiplicação de um número informado pelo
    // usuário. Dica: Use a estrutura do...while e switch case, se quiser.
    internal class Program
    {
        static void Main(string[] args)
        {
           int num,soma,multi,opcao;

            Console.WriteLine("Digite um número: ");
            num = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual tabuada deseja?  \n 1 Soma \n 2 Multiplicação ");
            opcao = Int32.Parse(Console.ReadLine());


            switch (opcao) {
                case 1:
            for (int i = 0; i <= 10; i++)
            {
                soma = num + i;
                Console.WriteLine("{0} + {1} = {2}", num, i, soma);
            }
            break;

               case 2:
                    for (int i = 0; i <= 10; i++)
                    {
                        multi = num * i;
                        Console.WriteLine("{0} * {1} = {2}", num, i, multi);
                    }

                    break;
            }
            Console.ReadKey();

        }
    }
}
