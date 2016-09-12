using System.Windows;
using TicTactoe.Lib.ViewModels;
using TicTacToe.Wpf.Utils;

namespace TicTacToe.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            DataContext = new MainViewModel(new MessageDialog());
            InitializeComponent();
        }
    }
}
