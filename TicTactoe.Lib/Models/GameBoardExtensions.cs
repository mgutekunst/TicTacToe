using System;
using System.Diagnostics;

namespace TicTacToe.Lib.Models
{
    public static class GameBoardExtensions
    {
        public static bool IsSolved(this GameBoard board, out FieldState winner)
        {
            winner = FieldState.Unchecked;

            return board.WinnerInRow(ref winner) || 
                board.WinnerInColumn(ref winner) ||
                board.WinnerIsDiagonalLeftToRight(ref winner) ||
                board.WinnerIsDiagonalRightToLeft(ref winner);
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

        private static bool WinnerInColumn(this GameBoard board, ref FieldState winner)
        {
            Debug.Assert(winner == FieldState.Unchecked);

            for (int j = 0; j < 3; j++)
            {
                if (board[0,j].State != FieldState.Unchecked &&
                   (board[0,j].State == board[1,j].State) &&
                   (board[1,j].State == board[2,j].State))
                {
                    winner = board[0, j].State;
                    return true;

                }
            }
            return false;
        }

        private static bool WinnerIsDiagonalLeftToRight(this GameBoard board, ref FieldState winner)
        {
            Debug.Assert(winner == FieldState.Unchecked);

            if (board[0, 0].State != FieldState.Unchecked &&
                (board[0, 0].State == board[1, 1].State) &&
                (board[1, 1].State == board[2, 2].State))
            {
                winner = board[0, 0].State;
                return true;
            }

            return false;
        }

        private static bool WinnerIsDiagonalRightToLeft(this GameBoard board, ref FieldState winner)
        {
            Debug.Assert(winner == FieldState.Unchecked);

            if (board[0, 2].State != FieldState.Unchecked &&
                (board[0, 2].State == board[1, 1].State) &&
                (board[1, 1].State == board[2, 0].State))
            {
                winner = board[0, 2].State;
                return true;
            }

            return false;
        }
    }
}