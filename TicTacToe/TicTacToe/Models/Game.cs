using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Models
{
    public class Game
    {

        private Board Board =new Board();
        private Dice Dice = new Dice();

        private Player FirstPlayer;
        private Player SecondPlayer;

        //private Player _player1 =new Player();
        //private Player _player2 =new Player();

        private Boolean TurnFirstPlayer = true;

        public Game ()
        {

        }

        public void Start()
        {
            
            FillMatrix();
            //SetPlayers();
            //Play();
            //ObtenerResultado(Board.IsFull(), Board.HasWinner(), TurnFirstPlayer);

        }

        public void Play()
        {
            while (!Board.IsFull() && !Board.HasWinner())
            {
                if (TurnFirstPlayer)
                {
                    Console.WriteLine("Turno Jugador 1");
                    SetMarkPosition(FirstPlayer.Play(), FirstPlayer);
                    
                } else
                {
                    Console.WriteLine("Turno Jugador 2");
                    SetMarkPosition(SecondPlayer.Play(), SecondPlayer);
                }
            }
        }





        public MarkType ObtenerResultado()
        {
            if (!Board.HasWinner())
            {
                return MarkType.Empty;
            } else
            {
                if (TurnFirstPlayer)
                {
                    return FirstPlayer.Mark;
                } else
                {
                    return SecondPlayer.Mark;
                }
            }
        }

        public void FillMatrix ()
        {
            for (int x = 0; x < 3; x++ )
            {
                for (int y = 0; y < 3; y++ )
                {
                    this.Board.SetMarkEmpty(x, y);
                }
            }
        }

        public void SetPlayers(Player _player1, Player _player2) 
        {
            var dicePlayer1 = Dice.Throw();
            var dicePlayer2 = Dice.Throw();
            Boolean hasWinner = true;

            while (hasWinner)
            {

                if (dicePlayer1 > dicePlayer2)
                {
                    FirstPlayer = _player1;
                    SecondPlayer = _player2;
                    hasWinner = false;

                }
                else
                {
                    if (dicePlayer2 > dicePlayer1)
                    {
                        FirstPlayer = _player2;
                        SecondPlayer = _player1;
                        hasWinner = false;

                    }
                    else
                    {
                        dicePlayer1 = Dice.Throw();
                        dicePlayer2 = Dice.Throw();
                    }

                }
            }
            FirstPlayer.SetMark(MarkType.Cross);
            SecondPlayer.SetMark(MarkType.Circle);
        }

        public void SetMarkPosition(MarkPosition markPos, Player player)
        {

            Boolean Assigned = false;

            while (!Assigned) { 

                if (Board.Marks[markPos.X, markPos.Y] == MarkType.Empty)
                {
                    Board.Marks[markPos.X, markPos.Y] = player.Mark;
                    Assigned = true;
                    TurnFirstPlayer = !TurnFirstPlayer;
                }
                else
                {
                    /*Console.WriteLine("Error! Esa celda ya está ocupada."); //tirar pop up
                    markPos = player.Play();*/
                    throw new Exception("Ya estaba ocupada");
               
                }
            }
        }

        public Player GetNextPlayer()
        {
            if (TurnFirstPlayer)
            {
                return FirstPlayer;
            }
            else
            {
                return SecondPlayer;
            }
        }


        public Boolean IsFull ()
        {
            return this.Board.IsFull();
        }

        public Boolean HasWinner()
        {
            return this.Board.HasWinner();
        }
    }
}
