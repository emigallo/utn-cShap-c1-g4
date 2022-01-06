using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GUI.Views;
using System.Windows;
using System.Windows.Controls;
using View.ViewModels;

namespace GUI.Views
{
    public partial class TicTacToeView : Window
    {
        private TicTacToeViewModel _vm;

        public TicTacToeView()
        {
            InitializeComponent();
            this._vm = new TicTacToeViewModel();
            DataContext = this._vm;

        }
        public void NewGameButton_Click(object sender, RoutedEventArgs e)
        {
            this._vm.StartGame();
        }

        public void MarkButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            int x = 0;
            int y = 0;
            _vm.PutMark(x, y);
        }

        
    }

   
}

