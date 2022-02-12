using System;

namespace Exercicio2.ConsoleApp
{
    internal class Program
    {
        /*
         2 - Desenhe um retângulo com asteriscos, onde forem linhas pares escreva "A" e as linhas ímpares escreva "B".
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a largura do retângulo:");
            var larguraRetangulo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a altura do retângulo:");
            var alturaRetangulo = Convert.ToInt32(Console.ReadLine());

            for (int x = 0; x < alturaRetangulo; x++)
            {
                for (int y = 0; y < larguraRetangulo; y++)
                {
                    if (x % 2 == 0)
                    {
                        Console.Write("B");
                    }
                    else 
                    {
                        Console.Write("A");
                    }
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
