﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Models
{
    public class Game
    {

        public Board Board =new Board();
        public Dice Dice = new Dice();

        public Player FirstPlayer = new Player();
        public Player SecondPlayer = new Player();

        private Player _player1 =new Player();
        private Player _player2 =new Player();

        public Boolean TurnFirstPlayer = true;

        public void Start()
        {
            
            FillMatrix();
            SetPlayers();
            Play();
            
            ObtenerResultado(Board.IsFull(), Board.HasWinner(), TurnFirstPlayer);

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





        public void ObtenerResultado(Boolean boardStatus, Boolean winnerStatus, Boolean turnFstPlayer)
        {
            if (winnerStatus) {
                
                if (turnFstPlayer) //despues de jugar se cambia el turn, por lo tanto si el jugador 2 gano, despues de poner la ficha cambio el turno y quedo true para el 1
                {
                    Console.WriteLine("Gano el jugador 2");
                }
                else
                {
                    Console.WriteLine("Gano el jugador 1");
                }
            }
            else {
                
                Console.WriteLine("Hubo empate");

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

        private void SetPlayers() //poner un booleano por fuera
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
                    Console.WriteLine("Error! Esa celda ya está ocupada.");
                    markPos = player.Play();
               
                }
            }
        }
    }
}
