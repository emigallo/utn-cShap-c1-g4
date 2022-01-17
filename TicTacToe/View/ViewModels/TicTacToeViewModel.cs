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
            EnableAllButtons();
            ResetContentButtons();
        }

        public void ResetContentButtons()
        {
            this.Content1 = "";
            this.Content2 = "";
            this.Content3 = "";
            this.Content4 = "";
            this.Content5 = "";
            this.Content6 = "";
            this.Content7 = "";
            this.Content8 = "";
            this.Content9 = "";
        }


        public void EnableAllButtons()
        {
            this.Button1 = true;
            this.Button2 = true;
            this.Button3 = true;
            this.Button4 = true;
            this.Button5 = true;
            this.Button6 = true;
            this.Button7 = true;
            this.Button8 = true;
            this.Button9 = true;

        }

        public void DisableAllButtons()
        {
            this.Button1 = false;
            this.Button2 = false;
            this.Button3 = false;
            this.Button4 = false;
            this.Button5 = false;
            this.Button6 = false;
            this.Button7 = false;
            this.Button8 = false;
            this.Button9 = false;

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

        public void ChangeContent(string tag)
        {
            switch (tag)
            {
                case "0,0":
                    this.Content1 = GetMarkCurrentPlayer();
                    this.Button1 = false;
                    break;

                case "0,1":
                    this.Content2 = GetMarkCurrentPlayer();
                    this.Button2 = false;
                    break;

                case "0,2":
                    this.Content3 = GetMarkCurrentPlayer();
                    this.Button3 = false;
                    break;

                case "1,0":
                    this.Content4 = GetMarkCurrentPlayer();
                    this.Button4 = false;
                    break;

                case "1,1":
                    this.Content5 = GetMarkCurrentPlayer();
                    this.Button5 = false;
                    break;

                case "1,2":
                    this.Content6 = GetMarkCurrentPlayer();
                    this.Button6 = false;
                    break;

                case "2,0":
                    this.Content7 = GetMarkCurrentPlayer();
                    this.Button7 = false;
                    break;

                case "2,1":
                    this.Content8 = GetMarkCurrentPlayer();
                    this.Button8 = false;
                    break;

                case "2,2":
                    this.Content9 = GetMarkCurrentPlayer();
                    this.Button9 = false;
                    break;

            }
        }

        public MarkType CheckWinner()
        {
            return game.ObtenerResultado();
        }


        internal string GetNamePlayerOne()
        {
            return this.FirstPlayer.Name;
        }

        private string _content1;
        private string _content2;
        private string _content3;
        private string _content4;
        private string _content5;
        private string _content6;
        private string _content7;
        private string _content8;
        private string _content9;

        private bool _button1;
        private bool _button2;
        private bool _button3;
        private bool _button4;
        private bool _button5;
        private bool _button6;
        private bool _button7;
        private bool _button8;
        private bool _button9;

        public bool Button1
        {
            get { return this._button1; }
            set
            {
                this._button1 = value;
                OnPropertyChanged(nameof(Button1));
            }
        }

        public bool Button2
        {
            get { return this._button2; }
            set
            {
                this._button2 = value;
                OnPropertyChanged(nameof(Button2));
            }
        }

        public bool Button3
        {
            get { return this._button3; }
            set
            {
                this._button3 = value;
                OnPropertyChanged(nameof(Button3));
            }
        }

        public bool Button4
        {
            get { return this._button4; }
            set
            {
                this._button4 = value;
                OnPropertyChanged(nameof(Button4));
            }
        }

        public bool Button5
        {
            get { return this._button5; }
            set
            {
                this._button5 = value;
                OnPropertyChanged(nameof(Button5));
            }
        }

        public bool Button6
        {
            get { return this._button6; }
            set
            {
                this._button6 = value;
                OnPropertyChanged(nameof(Button6));
            }
        }

        public bool Button7
        {
            get { return this._button7; }
            set
            {
                this._button7 = value;
                OnPropertyChanged(nameof(Button7));
            }
        }

        public bool Button8
        {
            get { return this._button8; }
            set
            {
                this._button8 = value;
                OnPropertyChanged(nameof(Button8));
            }
        }

        public bool Button9
        {
            get { return this._button9; }
            set
            {
                this._button9 = value;
                OnPropertyChanged(nameof(Button9));
            }
        }


        public string Content1
        {
            get { return this._content1; }
            set { this._content1 = value; 
            OnPropertyChanged(nameof(Content1));} 
        }

        public string Content2
        {
            get { return this._content2; }
            set
            {
                this._content2 = value;
                OnPropertyChanged(nameof(Content2));
            }
        }

        public string Content3
        {
            get { return this._content3; }
            set
            {
                this._content3 = value;
                OnPropertyChanged(nameof(Content3));
            }
        }

        public string Content4
        {
            get { return this._content4; }
            set
            {
                this._content4 = value;
                OnPropertyChanged(nameof(Content4));
            }
        }

        public string Content5
        {
            get { return this._content5; }
            set
            {
                this._content5 = value;
                OnPropertyChanged(nameof(Content5));
            }
        }

        public string Content6
        {
            get { return this._content6; }
            set
            {
                this._content6 = value;
                OnPropertyChanged(nameof(Content6));
            }
        }

        public string Content7
        {
            get { return this._content7; }
            set
            {
                this._content7 = value;
                OnPropertyChanged(nameof(Content7));
            }
        }

        public string Content8
        {
            get { return this._content8; }
            set
            {
                this._content8 = value;
                OnPropertyChanged(nameof(Content8));
            }
        }

        public string Content9
        {
            get { return this._content9; }
            set
            {
                this._content9 = value;
                OnPropertyChanged(nameof(Content9));
            }
        }

        internal string GetNamePlayerTwo()
        {
            return this.SecondPlayer.Name;
        }

        public void EndGame()
        {
            DisableAllButtons();
        }

        public void ResetGame()
        {
            game.Start();
            game.SetPlayers(FirstPlayer, SecondPlayer);
            ResetContentButtons();
            EnableAllButtons();
        }
        
        public void SetNames(string[] names)
        {
            this.FirstPlayer.Name = names[0];
            this.SecondPlayer.Name = names[1];
        }


    }
}
