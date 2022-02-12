using System;

namespace Exercicio3.ConsoleApp
{
    internal class Program
    {
        /*
         Escreva um programa que contenha uma variável: horaAtual; Essa variável deverá conter a hora do dia e três mensagens 
        deverão ser impressas na tela de acordo com a hora: “Bom dia”, “Boa tarde” ou “Boa noite”. 
         */
        static void Main(string[] args)
        {
            var horaAtual = DateTime.Now.Hour;
            Console.WriteLine(horaAtual);

            if (horaAtual < 12)
            {
                Console.WriteLine("Bom dia!");
            }                
            else if (horaAtual < 18)
            {
                Console.WriteLine("Boa tarde!");
            }
            else
            {
                Console.WriteLine("Boa noite!");
            }

            Console.ReadLine();
        }
    }
}
