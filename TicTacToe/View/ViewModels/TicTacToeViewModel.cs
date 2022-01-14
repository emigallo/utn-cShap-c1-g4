﻿using System;
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
            this.EnableButtons = true;
            this.Content = "";
        }

        public void PutMark(int x, int y)
        {
            MarkPosition mp = new MarkPosition(x, y);
            game.SetMarkPosition(mp, game.GetNextPlayer());
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

        private Boolean _enableButtons;
        public Boolean EnableButtons
        {
            get
            {
                return this._enableButtons;
            }
            set
            {
                this._enableButtons = value;
                OnPropertyChanged(nameof(EnableButtons));
            }
        }

        internal string GetNamePlayerOne()
        {
            return this.FirstPlayer.Name;
        }

        private string _content;
        public string Content
        {
            get { return this._content; }
            set { this._content = value; 
            OnPropertyChanged(nameof(Content));} 
        }

        internal string GetNamePlayerTwo()
        {
            return this.SecondPlayer.Name;
        }

        public void EndGame()
        {
            this.EnableButtons = false;
        }

        public void ResetGame()
        {
            game.Start();
            game.SetPlayers(FirstPlayer, SecondPlayer);
            this.EnableButtons = true;
            this._enableButtons = true;
        }
        
        public void SetNames(string[] names)
        {
            this.FirstPlayer.Name = names[0];
            this.SecondPlayer.Name = names[1];
        }


    }
}
