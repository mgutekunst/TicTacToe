

using NUnit.Framework;
using TicTactoe.Lib.ViewModels;

namespace TicTacToe.Lib.Tests.ViewModels
{
    [TestFixture]
    public class MainViewModelTests
    {
        private MainViewModel _cut;

        [SetUp]
        public void SetUp()
        {
            // Setup for Test
            _cut = new MainViewModel();
        }

        [TearDown]
        public void TearDown()
        {
            _cut = null;
        }

        [Test]
        public void SwitchPlayer_PlayerIsChangedAfterAMoveIsMade()
        {
            var prevPlayer = _cut.CurrentPlayer;

            _cut.MoveMadeCommand.Execute(null);

            Assert.That(_cut.CurrentPlayer, Is.Not.EqualTo(prevPlayer));
        }
    }
}

