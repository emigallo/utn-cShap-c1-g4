using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GUI.Views;
using System.Windows;
using System.Windows.Controls;
using View.ViewModels;
using TicTacToe.Models;
using System.Windows.Media;

namespace GUI.Views
{
    public partial class TicTacToeView : Window
    {
        private TicTacToeViewModel _vm;
        private List<Button> buttons = new List<Button>();



        public TicTacToeView()
        {
            InitializeComponent();
            this._vm = new TicTacToeViewModel();
            DataContext = this._vm;
        }
        public void NewGameButton_Click(object sender, RoutedEventArgs e)
        {
            //habilitar los botones
            this._vm.StartGame();
        }


        public void MarkButton_Click(object sender, RoutedEventArgs e)
        {
            //GameButton button = sender as GameButton;
            Button button = sender as Button;
            this.buttons.Add(button);


            var coords = button.Tag.ToString();
            char[] charArr = coords.ToCharArray();

            char coordX = charArr[0];
            char coordY = charArr[2];

            int x = coordX - '0';
            int y = coordY - '0';


            _vm.PutMark(x, y);

            button.Content = _vm.GetMarkCurrentPlayer();            
            button.IsEnabled = false;

            if (_vm.GameEnded())
            {
                var markWinner = _vm.CheckWinner();

                if (markWinner == MarkType.Empty)
                {
                    Winner.Content = "Hubo empate";
                    _vm.EndGame();
                } else if (markWinner == MarkType.Cross)
                {
                    Winner.Content = "Ganó X";
                    _vm.EndGame();
                } else
                    {
                    Winner.Content = "Ganó O";
                    _vm.EndGame();
                }
                }                
            }
        public void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            foreach(var button in buttons)
            {
                button.Content = "";
                button.IsEnabled = true;
            }
            Winner.Content = "";

            this._vm.ResetGame();


        }

    }
}

   


