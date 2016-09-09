using NUnit.Framework;
using TicTacToe.Lib.Models;

namespace TicTacToe.Lib.Tests.Models
{
    [TestFixture]
    public class GameFieldTests
    {
        [Test]
        public void Ctor_StateIsUnecked()
        {
            var field = new GameField();

            Assert.That(field.State,Is.EqualTo(FieldState.Unchecked));
        }


        [TestCase(FieldState.O)]
        [TestCase(FieldState.X)]
        public void SetState_StateIsChanged(FieldState state)
        {
            var field = new GameField();

            field.SetState(state);

            Assert.That(field.State, Is.EqualTo(state));
        }

        [TestCase(FieldState.O,FieldState.X)]
        [TestCase(FieldState.X,FieldState.O)]
        public void SetState_StateAlreadyChanged_CannotChangeStateTwice(FieldState first, FieldState second)
        {
            var field = new GameField();

            field.SetState(first);
            field.SetState(second);

            Assert.That(field.State, Is.EqualTo(first));
        }
    }
}