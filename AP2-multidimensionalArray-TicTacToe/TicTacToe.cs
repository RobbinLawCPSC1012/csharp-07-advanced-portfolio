using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP2_multidimensionalArray_TicTacToe
{
    public class TicTacToe
    {
        private char[,] _board = new char[3, 3];

        public char[,] Board
        {
            get
            {
                return _board;
            }
            set
            {
                _board = value;
            }
        }

        public TicTacToe()
        {
            int count = 1;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Board[i, j] = count.ToString()[0];
                    count++;
                }
            }
        }

        public void Draw()
        {
            Console.WriteLine("\n-------------");
            Console.WriteLine($"| {Board[2, 0]} | {Board[2, 1]} | {Board[2, 2]} |");
            Console.WriteLine("-------------");
            Console.WriteLine($"| {Board[1, 0]} | {Board[1, 1]} | {Board[1, 2]} |");
            Console.WriteLine("-------------");
            Console.WriteLine($"| {Board[0, 0]} | {Board[0, 1]} | {Board[0, 2]} |");
            Console.WriteLine("-------------");
        }
    }
}