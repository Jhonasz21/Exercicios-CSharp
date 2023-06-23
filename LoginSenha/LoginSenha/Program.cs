
using System .Globalization;
namespace exercicio1 {
    class Program { 
        static void Main(string[] args) {

          int senha = int.Parse(Console.ReadLine());

            while (senha != 2002)
            {
                Console.WriteLine("Senha Invalida");
                senha = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso permitido");

    }
  }
}
