

using NUnit.Framework;
using TicTacToe.Lib.Models;

namespace TicTacToe.Lib.Tests.Models
{
    [TestFixture]
    public class GameBoardExtensionsTests
    {
        [Test]
        public void IsSolved_BoardIsEmpty_falseAndUnknown()
        {
            var board = new GameBoard();
            FieldState winner;

            var result = board.IsSolved(out winner);

            Assert.That(result,Is.False);
            Assert.That(winner,Is.EqualTo(FieldState.Unchecked));
        }

        [Test]
        public void IsSolved_NoWinner_falseAndUnknown()
        {
            var board = new GameBoard();
            board[0].SetState(FieldState.O);
            board[1].SetState(FieldState.X);
            board[2].SetState(FieldState.O);
            FieldState winner;

            var result = board.IsSolved(out winner);

            Assert.That(result,Is.False);
            Assert.That(winner,Is.EqualTo(FieldState.Unchecked));
        }

        [TestCase(0,FieldState.X)]
        [TestCase(1,FieldState.X)]
        [TestCase(2,FieldState.X)]
        [TestCase(0,FieldState.O)]
        [TestCase(1,FieldState.O)]
        [TestCase(2,FieldState.O)]
        public void IsSolved_WinnerInRow_trueAndX(int r, FieldState winningPlayer)
        {
            var board = new GameBoard();
            board[r,0].SetState(winningPlayer);
            board[r,1].SetState(winningPlayer);
            board[r,2].SetState(winningPlayer);
            FieldState winner;

            var result = board.IsSolved(out winner);

            Assert.That(result,Is.True);
            Assert.That(winner,Is.EqualTo(winningPlayer));
        }

        [TestCase(0,FieldState.X)]
        [TestCase(1,FieldState.X)]
        [TestCase(2,FieldState.X)]
        [TestCase(0,FieldState.O)]
        [TestCase(1,FieldState.O)]
        [TestCase(2,FieldState.O)]
        public void IsSolved_WinnerInColumn_trueAndX(int c, FieldState winningPlayer)
        {
            var board = new GameBoard();
            board[0,c].SetState(winningPlayer);
            board[1,c].SetState(winningPlayer);
            board[1,c].SetState(winningPlayer);
            FieldState winner;

            var result = board.IsSolved(out winner);

            Assert.That(result,Is.True);
            Assert.That(winner,Is.EqualTo(winningPlayer));
        }
    }
}

