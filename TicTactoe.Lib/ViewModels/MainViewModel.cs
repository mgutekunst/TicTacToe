using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using TicTacToe.Lib.Models;

namespace TicTactoe.Lib.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private GameBoard _board = new GameBoard();

        public MainViewModel()
        {
            MoveMadeCommand = new Command(moveMade);
        }

        private void moveMade()
        {
            CurrentPlayer = CurrentPlayer == FieldState.O ? FieldState.X : FieldState.O;
        }

        public GameBoard Board
        {
            get { return _board; }
            set { _board = value; RaisePropertyChanged(); }
        }

        private FieldState _currentPlayer = FieldState.X;
        public FieldState CurrentPlayer
        {
            get { return _currentPlayer; }
            set { _currentPlayer = value; RaisePropertyChanged(); }
        }

        public ICommand MoveMadeCommand { get; set; }

        #region RaisePropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }

    public class Command : ICommand
    {
        private readonly Action _action;
        private readonly Func<bool> _canExecute;

        public Command(Action action, Func<bool> canExecute = null)
        {
            _action = action;
            _canExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            return _canExecute?.Invoke() ?? true;
        }

        public void Execute(object parameter)
        {
            _action();
        }

        public event EventHandler CanExecuteChanged;
    }
}