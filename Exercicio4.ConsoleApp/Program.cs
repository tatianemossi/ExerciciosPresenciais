using System;

namespace Exercicio4.ConsoleApp
{
    internal class Program
    {
        /*
         Desenvolver um algoritmo que leia 5 valores inteiros e calcule e escreva a média aritmética dos valores lidos, a 
        quantidade de valores positivos e a quantidade de valores negativos. 
         */
        static void Main(string[] args)
        {
            var listaNumerosDigitados = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Digite o número:");
                listaNumerosDigitados[i] = Convert.ToInt32(Console.ReadLine());
            }

            var somatorio = 0;
            var contadorPositivo = 0;
            var contadorNegativo = 0;

            for (int i = 0; i < listaNumerosDigitados.Length; i++)
            {
                int numeroDaLista = listaNumerosDigitados[i];

                somatorio = somatorio + numeroDaLista;

                if (numeroDaLista < 0)
                {
                    contadorNegativo++;
                }
                else
                {
                    contadorPositivo++;
                }
            }

            decimal media = Convert.ToDecimal(somatorio) / Convert.ToDecimal(listaNumerosDigitados.Length);

            Console.WriteLine($"Média aritmética: {media.ToString("F")}");
            Console.WriteLine($"Números positivos: {contadorPositivo}");
            Console.WriteLine($"Números negativos: {contadorNegativo}");

            Console.ReadLine();
        }
    }
}
