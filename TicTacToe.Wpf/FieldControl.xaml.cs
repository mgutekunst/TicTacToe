using System;
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

        public event EventHandler<EventArgs> FieldChanged;

        public static readonly DependencyProperty GameFieldProperty = DependencyProperty.Register("GameField", typeof(GameField), typeof(FieldControl),
            new PropertyMetadata(default(GameField)));

        public GameField GameField
        {
            get { return (GameField) GetValue(GameFieldProperty); }
            set { SetValue(GameFieldProperty, value); }
        }

        public static readonly DependencyProperty CurStateProperty = DependencyProperty.Register("CurState", typeof(FieldState), typeof(FieldControl),
            new PropertyMetadata(default(FieldState)));

        public FieldState CurState
        {
            get { return (FieldState) GetValue(CurStateProperty); }
            set { SetValue(CurStateProperty, value); }
        }


        public FieldControl()
        {
            InitializeComponent();
        }

        private void FieldControl_OnMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            GameField.SetState(CurState);
            FieldChanged?.Invoke(this, new EventArgs());
        }
    }
}
