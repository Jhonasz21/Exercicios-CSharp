using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcularMediaAvaliacoes
{
   /* Um aluno construiu um programa para calcular a média após realizar as suas avaliações.
      A sua ideia foi, ao criar esse programa, fazer com que a quantidade fosse informada na tela, 
      permitindo facilitar esse cálculo para qualquer quantidade de avaliações.
      Após isso, ele resolveu verificar quantas notas estão acima da média e qual é essa porcentagem. Seguindo esse raciocínio, construa o programa.*/
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite a quantidade de avaliações: ");
            int quantidadeAv = int.Parse(Console.ReadLine());

            double[] notas = new double[quantidadeAv];

            for(int i = 0; i < quantidadeAv; i++)
            {
                Console.Write($"Digite a nota {i + 1}: ");
                notas[i] = double.Parse(Console.ReadLine());
            }

            double soma = 0;
            foreach(double nota in notas)
            {
                soma += nota;
            }

            double media = soma / quantidadeAv;

            Console.WriteLine("A média das notas é: " + media);

            int contadorMedia = 0;
            foreach(double nota in notas)
            {
                if(nota > media)
                {
                    contadorMedia++;
                }
            }
            double porcentagemMedia = contadorMedia / quantidadeAv * 100;
            Console.WriteLine("Quantidade de notas acima da média: " + contadorMedia);
            Console.WriteLine("Porcetagem de notas acima da média: " + porcentagemMedia.ToString("F2") + "%");
            Console.ReadKey();  

        }
    }
}
