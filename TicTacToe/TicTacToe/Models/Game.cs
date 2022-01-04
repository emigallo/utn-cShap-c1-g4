using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Models
{
    internal class Game
    {
        public Board Board { get; set; }
        public Dice Dice { get; set; }

        public Player FirstPlayer { get; set; }
        public Player SecondPlayer { get; set; }

        private Player _player1 { get; set; }
        private Player _player2 { get; set; }

        public Boolean TurnFirstPlayer = true;

        public void Start()
        {
            FillMatrix();
            SetPlayers();
            FirstPlayer.SetMark(Mark.Cross);
            SecondPlayer.SetMark(Mark.Circle);

            while(!Board.IsFull() && !Board.HasWinner()) {

                if (TurnFirstPlayer) {

                    //MarkPosition mark= FirstPlayer.ChoosePosition
                    //SetMarkPosition(MarkPosition mark, Mark.Cross)
                    TurnFirstPlayer = false;

                }
                else
                {
                    //MarkPosition mark= SecondPlayer.ChoosePosition
                    //SetMarkPosition(MarkPosition mark, Mark.Circle)
                    TurnFirstPlayer = true;
                }

            }
        }

        private void FillMatrix ()
        {
            for (int x = 0; x < 3; x++ )
            {
                for (int y = 0; y < 3; y++ )
                {
                    this.Board.SetMarkEmpty(x, y);
                }
            }
        }

        private void SetPlayers ()
        {
            var dicePlayer1 = Dice.Throw();
            var dicePlayer2 = Dice.Throw();

            while (true) { 

            if (dicePlayer1>dicePlayer2)
            {
                    FirstPlayer = _player1;
                    SecondPlayer = _player2;
                    break;

            } else if (dicePlayer2>dicePlayer1)
            {
                    FirstPlayer = _player2;
                    SecondPlayer = _player1;
                    break;

            } else
            {
                dicePlayer1 = Dice.Throw();
                dicePlayer2 = Dice.Throw();
            }

            }
        }

        public void SetMarkPosition(MarkPosition markPos, Mark markType)
        {
            if (Board.Marks[markPos.X, markPos.Y] == Mark.Empty)
            {
                Board.Marks[markPos.X, markPos.Y] = markType;
            }
            else
            {
                //TODO: lanzar excepcion de que esa posicion ya esta ocupada
            }
        }

    }
}
