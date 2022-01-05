using System;
using TicTacToe;
using TicTacToe.Models;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Game game = new Game();
            game.Start();
            Console.ReadLine();
        }
    }
}