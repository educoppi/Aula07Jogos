using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula07Jogos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random sorteador = new Random();

            int numero;
            int sorteio = sorteador.Next(1,11);
            //Console.WriteLine(sorteio);
            Console.WriteLine("Bem-vindo a Blaze");
            Console.WriteLine("Adivinhe o número entre 1 e 10");
            Console.Write("Digite o número: ");
            numero = int.Parse(Console.ReadLine());

            if((numero > 10) || (numero < 1))
            {
                Console.WriteLine("Digite um número válido!\n");
                Main(null);
                return;
            }

            if (numero == sorteio)
            {
                Console.WriteLine("Parabéns, você venceu o jogo!");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Você errou! Tente novamente\n ");
            Main(null);

            Console.ReadKey();
        }
    }
}
