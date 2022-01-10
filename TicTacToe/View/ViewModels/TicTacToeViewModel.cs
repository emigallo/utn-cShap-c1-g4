using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Models;

namespace View.ViewModels
{
    class TicTacToeViewModel : INotifyPropertyChanged
    {
        Game game = new Game();
        Player FirstPlayer = new Player();
        Player SecondPlayer = new Player();

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion INotifyPropertyChanged

        public void StartGame ()
        {
            game.Start();
            game.SetPlayers(FirstPlayer, SecondPlayer);
            this.Buttons = true;
            this.Content = "";
        }

        public void PutMark(int x, int y)
        {
            MarkPosition mp = new MarkPosition(x, y);
            game.SetMarkPosition(mp, game.GetNextPlayer());
        }

        public void Play ()
        {
            while (!game.IsFull() && !game.HasWinner())
            {
                Player CurrentPlayer = game.GetNextPlayer();
                int x = 0;
                int y = 0;

                game.SetMarkPosition(new MarkPosition(x, y), CurrentPlayer);

            }

            //return game.GetWinner() || imprimir el game.GetWinner()
        }

        public Boolean GameEnded()
        {
            return (game.IsFull() || game.HasWinner());
        }
     
        public String GetMarkCurrentPlayer()
        {
            if (game.GetNextPlayer().Mark == MarkType.Cross)
            {
                return "X";
            } else
            {
                return "O";
            }
        }

        public MarkType CheckWinner()
        {
            return game.ObtenerResultado();
        }

        private Boolean _buttons;
        public Boolean Buttons
        {
            get
            {
                return this._buttons;
            }
            set
            {
                this._buttons = value;
                OnPropertyChanged(nameof(Buttons));
            }
        }

        private string _content;
        public string Content
        {
            get { return this._content; }
            set { this._content = value; 
            OnPropertyChanged(nameof(Content));} 
        }

        public void EndGame()
        {
            this.Buttons = false;
        }

        public void ResetGame()
        {
            game.Start();
            game.SetPlayers(FirstPlayer, SecondPlayer);
            this.Buttons = true;
            this._buttons = true;
        }
        public void ChangeContent(string mark)
        {
            this.Content = mark;
            this._content = mark;
        }

        public void ResetButton ()
        {
            this.Buttons = true;
        }
    }
}
