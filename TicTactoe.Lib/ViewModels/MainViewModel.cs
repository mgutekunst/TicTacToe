using System.ComponentModel;
using System.Runtime.CompilerServices;
using TicTacToe.Lib.Models;

namespace TicTactoe.Lib.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private GameField[,] _board = new GameField[3,3];
        public GameField[,] Board
        {
            get { return _board; }
            set { _board = value; RaisePropertyChanged(); }
        }
        
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}