using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using TicTacToe.Lib.Models;

namespace TicTacToe.Wpf
{
    /// <summary>
    /// Interaction logic for FieldControl.xaml
    /// </summary>
    public partial class FieldControl : UserControl
    {

        public static readonly DependencyProperty GameFieldProperty = DependencyProperty.Register("GameField", typeof(GameField), typeof(FieldControl),
            new PropertyMetadata(default(GameField)));

        public GameField GameField
        {
            get { return (GameField) GetValue(GameFieldProperty); }
            set { SetValue(GameFieldProperty, value); }
        }

        public FieldControl()
        {
            InitializeComponent();
        }

        private void FieldControl_OnMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            GameField.SetState(FieldState.X);
        }
    }
}
