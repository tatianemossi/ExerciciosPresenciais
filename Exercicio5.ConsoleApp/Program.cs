using System;

namespace Exercicio5.ConsoleApp
{
    internal class Program
    {
        /*
         Criar um jogo simplificado onde dois jogadores podem jogar dados;
        Regras:
        • O jogo deverá solicitar o nome dos dois jogadores;
        O jogo terá 3 rodadas;
        O jogador que tirar o maior número nos dados nessas 3 rodadas vence;
        • Em caso de empate (onde os dois tiram o mesmo número), nenhum jogador pontuará;
        • Os números permitidos vão de 0 a 6.
        A aplicação informará qual dos jogadores tirou o maior número.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o nome do primeiro jogador? ");
            var jogador1 = Console.ReadLine();

            Console.WriteLine("Qual o nome do segundo jogador? ");
            var jogador2 = Console.ReadLine();
            Random randNum = new Random();
            var contadorPontosJogador1 = 0;
            var contadorPontosJogador2 = 0;

            while (true)
            {
                for (int i = 0; i < 3; i++)
                {
                    var valorDadoJogador1 = randNum.Next(6);
                    Console.WriteLine($"{jogador1} tirou {valorDadoJogador1}");

                    var valorDadoJogador2 = randNum.Next(6);
                    Console.WriteLine($"{jogador2} tirou {valorDadoJogador2}");


                    if (valorDadoJogador1 > valorDadoJogador2)
                    {
                        contadorPontosJogador1++;
                        Console.WriteLine($"{jogador1} tirou {valorDadoJogador1} e venceu a {i + 1} rodada");
                    }
                    else if (valorDadoJogador2 > valorDadoJogador1)
                    {
                        contadorPontosJogador2++;
                        Console.WriteLine($"{jogador2} tirou {valorDadoJogador2} e venceu a {i + 1} rodada");
                    }
                    else if (valorDadoJogador1 == valorDadoJogador2)
                    {
                        Console.WriteLine("Empate!");
                    }
                    Console.WriteLine();
                }

                if (contadorPontosJogador1 > contadorPontosJogador2)
                {
                    Console.WriteLine($"{jogador1} venceu a partida com {contadorPontosJogador1} pontos!");
                    break;
                }
                else if (contadorPontosJogador2 > contadorPontosJogador1)
                {
                    Console.WriteLine($"{jogador2} venceu a partida com {contadorPontosJogador2} pontos!");
                    break;
                }
                else if (contadorPontosJogador1 == contadorPontosJogador2)
                {
                    Console.WriteLine("Houve um Empate definitivo, tentem novamente! ");
                    Console.ReadLine();
                }
            }
            Console.ReadLine();
        }
    }
}
