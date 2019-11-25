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
        private char _currentPlayer = 'X';

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

        public char CurrentPlayer
        {
            get => _currentPlayer;
            set
            {
                char c = Char.ToUpper(value);
                if (c == 'X' || c == 'O')
                    _currentPlayer = c;
                else
                    throw new Exception("Current Player must be an 'X' or an 'O'");
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
    }
}