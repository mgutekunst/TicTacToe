
namespace TicTacToe.Lib.Models
{
    public enum FieldState
    {
        Unchecked,
        X,
        O
    }
    public class GameField : NotifyBaseClass
    {
        private FieldState _state;
        public FieldState State
        {
            get { return _state; }
            private set { _state = value; RaisePropertyChanged(); }
        }

        public void SetState(FieldState fieldState)
        {
            if (State != FieldState.Unchecked)
                return;

            State = fieldState;
        }
    }
}