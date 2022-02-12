using System;

namespace Exercicio1.ConsoleApp
{
    internal class Program
    {
        /*
        1 - Desenhe um retângulo com asteriscos, considere que o primeiro input é a largura e o segundo input é a altura. 
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
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}