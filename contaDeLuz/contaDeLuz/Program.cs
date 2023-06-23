using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contaDeLuz
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Informe seu nome: ");
            String nome = Console.ReadLine();

            Console.WriteLine("Energia consumida foi de: ");
            double consumo =  Int32.Parse(Console.ReadLine());

            double taxa = (consumo / 100) * 15.0;
            double valor02 = consumo * 1.20;
            double valor03 = consumo * 1.50;
            double valor04 = consumo * 1.80;
            double valor05 = consumo * 2.00;


            if (consumo <= 199)
            {
                
                Console.WriteLine("Nome do cliente é " + nome + ", seu consumo foi de: " + valor02);
            }
            else if (consumo >= 200 && consumo < 400)
            {

                Console.WriteLine("Nome do cliente é " + nome + ", seu consumo foi de: " + valor03);
            }
            else if (consumo >= 400 && consumo < 600)
            {
              double  consumoTotal = valor04 + taxa;
                Console.WriteLine("Nome do cliente é " + nome + ", seu valor a pagar é incluso taxa: " + consumoTotal + " multa acrescido no valor consulmido foi de: " + taxa);
            }
            else if (consumo >= 600)
            {
               double consumoTotal=valor05 + taxa;
                Console.WriteLine("Nome do cliente é " + nome + ", seu valor a pagar é incluso taxa: " + consumoTotal + "multa acrecido no valor consulmido foi de: " + taxa);

            }
            Console.ReadKey();
        }
    }
}
