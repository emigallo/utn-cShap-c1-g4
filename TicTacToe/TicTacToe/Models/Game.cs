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
            
            while ((Board.IsFull() == false) && (Board.HasWinner() == false)) { //no entra al while
                
                if (TurnFirstPlayer) {

                    Console.WriteLine("Elija una fila");
                    int rowSelected;
                    rowSelected = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("Elija una columna");
                    int colSelected;
                    colSelected = Int32.Parse(Console.ReadLine());
                    
                    MarkPosition mark= new MarkPosition(rowSelected, colSelected);
                    SetMarkPosition(mark, MarkType.Cross);
                    TurnFirstPlayer = false;

                }
                else
                {
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
