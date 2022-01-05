using System;
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
            FirstPlayer.SetMark(MarkType.Cross);
            SecondPlayer.SetMark(MarkType.Circle);
            
            while ((Board.IsFull() == false) && (Board.HasWinner() == false)) {
                
                if (TurnFirstPlayer) {
                    Console.WriteLine("Turno Juagador 1:");
                    Console.WriteLine("Elija una fila");
                    int rowSelected;
                    rowSelected = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("Elija una columna");
                    int colSelected;
                    colSelected = Int32.Parse(Console.ReadLine());
                    
                    MarkPosition mark= new MarkPosition(rowSelected, colSelected);

                    try
                    {

                        SetMarkPosition(mark, MarkType.Cross);

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("debe elegir otra posicion, esa ya esta ocupada");
                    }

                    TurnFirstPlayer = false;

                }
                else
                {
                    Console.WriteLine("Turno Juagador 2:");
                    Console.WriteLine("Elija una fila");
                    int rowSelected;
                    rowSelected = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("Elija una columna");
                    int colSelected;
                    colSelected = Int32.Parse(Console.ReadLine());

                    MarkPosition mark = new MarkPosition(rowSelected, colSelected);
                    SetMarkPosition(mark, MarkType.Circle);
                    TurnFirstPlayer = true;
                }

            }
            /*aca salio del while
             3 opciones: 
                -se lleno el tablero y hay empate
                -hay un ganador
                -se lleno el tablero y a su vez hay ganador (gano con la ultima ficha)
             */
            obtenerResultado(Board.IsFull(), Board.HasWinner(), TurnFirstPlayer);

        }


        public void obtenerResultado(Boolean boardStatus, Boolean winnerStatus, Boolean turnFstPlayer)
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

        private void SetPlayers ()
        {
            var dicePlayer1 = Dice.Throw();
            var dicePlayer2 = Dice.Throw();

            while (true) { 

            if (dicePlayer1>dicePlayer2)
            {
                    this.FirstPlayer = _player1;
                    this.SecondPlayer = _player2;
                    break;

            } else if (dicePlayer2>dicePlayer1)
            {
                    this.FirstPlayer = _player2;
                    this.SecondPlayer = _player1;
                    break;

            } else
            {
                dicePlayer1 = Dice.Throw();
                dicePlayer2 = Dice.Throw();
            }

            }
        }

        public void SetMarkPosition(MarkPosition markPos, MarkType markType)
        {
            if (Board.Marks[markPos.X, markPos.Y] == MarkType.Empty)
            {
                Board.Marks[markPos.X, markPos.Y] = markType;
            }
            else
            {
                throw new Exception("esa posicion ya esta ocupada, debe elegir otra");
               
            }
        }

    }
}
