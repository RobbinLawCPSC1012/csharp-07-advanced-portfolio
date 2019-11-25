using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP2_multidimensionalArray_TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********************");
            Console.WriteLine("* Tic-Tac-Toe Game *");
            Console.WriteLine("********************");
            var game = new TicTacToe();

            Console.WriteLine("The cell numbers for the game are shown below.");
            game.Draw();
            Play(game);
        }

        static void Play(TicTacToe game)
        {
            Console.WriteLine($"This feature is not yet implemented");
        }
    }
}
