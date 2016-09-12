using System;
using System.Diagnostics;

namespace TicTacToe.Lib.Models
{
    public static class GameBoardExtensions
    {
        public static bool IsSolved(this GameBoard board, out FieldState winner)
        {
            winner = FieldState.Unchecked;

            return board.WinnerInRow(ref winner);
        }

        private static bool WinnerInRow(this GameBoard board, ref FieldState winner)
        {
            Debug.Assert(winner == FieldState.Unchecked);

            for (int i = 0; i < 3; i++)
            {

                if (board[i, 0].State != FieldState.Unchecked &&
                   (board[i, 0].State == board[i, 1].State) &&
                   (board[i, 1].State == board[i, 2].State))
                {
                    winner = board[i, 0].State;
                    return true;

                }
            }
            return false;
        }
    }
}