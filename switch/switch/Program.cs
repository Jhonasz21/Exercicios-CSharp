using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @switch
{
    // Escreva o programa C # para ler qualquer número do mês em inteiro e exibir o nome
    // do mês.
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Informe o número do mês: ");
            int mes = Int32.Parse(Console.ReadLine());

            switch (mes)
            {
             case 1:
                    Console.WriteLine("O mês {0} Mês é Janeiro");
                    break;
                case 2:
                    Console.WriteLine("Mês é Fevereiro");
                    break;
                case 3:
                    Console.WriteLine("Mês é Março");
                    break;
                case 4:
                    Console.WriteLine("Mês é Abril");
                    break;
                case 5:
                    Console.WriteLine("Mês é Maio");
                    break;
                case 6:
                    Console.WriteLine("Mês é Junho");
                    break;
                case 7:
                    Console.WriteLine("Mês é Julho");
                    break;
                case 8:
                    Console.WriteLine("Mês é Agosto");
                    break;
                case 9:
                    Console.WriteLine("Mês é Setembro");
                    break;
                case 10:
                    Console.WriteLine("Mês é Outubro");
                    break;
                case 11:
                    Console.WriteLine("Mês é Novembro");
                    break;
                case 12:
                    Console.WriteLine("Mês é Dezembro");
                    break;
                default:
                    Console.WriteLine("O número do mês informado é invalido.");
                    break;

            }
            Console.ReadKey();

        }
         
       
        
    }
}
