using System;
using System.Collections;
using System.Linq;

namespace TicTacToe.Lib.Models
{
    public class GameBoard : IEnumerable
    {
        private GameField[,] _fields;
        public GameBoard()
        {
            _fields = new GameField[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    _fields[i,j] = new GameField();
                }
            }
        }
        public IEnumerator GetEnumerator() => _fields.GetEnumerator();

        public object this[int index] =>  _fields[(index/3), index%3]; 

        public object this[int i, int j] => _fields[i, j];
    }
}