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



        public TicTacToeView()
        {
            InitializeComponent();
            this._vm = new TicTacToeViewModel();
            DataContext = this._vm;
        }
        public void NewGameButton_Click(object sender, RoutedEventArgs e)
        {
            Window1 win = new Window1();
            win.ShowDialog();
            if (win.FormAccepted) 
            {
              this._vm.SetNames(win.GetNames());
              this._vm.StartGame();
              Button button = (Button)sender;
              button.IsEnabled = false;
            }
        }


        public void MarkButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;

            var coords = GetCoordinates(button.Tag.ToString().ToCharArray());

            _vm.PutMark(coords[0], coords[1]);
            _vm.ChangeContent(button.Tag.ToString());
            button.Foreground = GetColorByMark(button.Content.ToString());

            if (_vm.GameEnded())
            {
                var markWinner = _vm.CheckWinner();

                if (markWinner == MarkType.Empty)
                {
                    Winner.Content = "Hubo empate";
                    _vm.EndGame();
                } else if (markWinner == MarkType.Cross)
                {
                    Winner.Content = "Ganó "+this._vm.GetNamePlayerOne();
                    _vm.EndGame();
                } else
                    {
                    Winner.Content = "Ganó "+this._vm.GetNamePlayerTwo();
                    _vm.EndGame();
                }
                }                
            }
        public void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            
            Winner.Content = "";

            this._vm.ResetGame();


        }

        public void ExitGame_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        public Brush GetColorByMark(string mark)
        {

            var converter = new BrushConverter();
            var brushViolet = (Brush)converter.ConvertFromString("#8E44AD");
            var brushYellow = (Brush)converter.ConvertFromString("#E67E22");

            if (mark == "X")
            {
                return brushViolet;
            } else
            {
                return brushYellow;
            }
        }

        private int[] GetCoordinates (char[] charArr)
        {
            char coordX = charArr[0];
            char coordY = charArr[2];

            int x = coordX - '0';
            int y = coordY - '0';

            int[] coords = new int[2];
            coords[0] = x;
            coords[1] = y;

            return coords;

        }


    }
}

   


