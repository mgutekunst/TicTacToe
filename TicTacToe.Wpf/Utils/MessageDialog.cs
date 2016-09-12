using System.Windows;

namespace TicTacToe.Wpf.Utils
{
    public class MessageDialog : IMessageDialog
    {
        public void Show(string text)
        {
           MessageBox.Show(Application.Current.MainWindow,text); 
        }
    }
}