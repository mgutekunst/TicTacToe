using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TicTactoe.Lib
{
    public abstract class NotifyBaseClass : INotifyPropertyChanged
    {
        public virtual event PropertyChangedEventHandler PropertyChanged;

        protected virtual void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}