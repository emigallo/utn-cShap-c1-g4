using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Models;

namespace View.ViewModels
{
    internal class TicTacToeViewModel
    {
        Game game = new Game();
        Player FirstPlayer = new Player();
        Player SecondPlayer = new Player();

        public void StartGame ()
        {
            game.Start();
            game.SetPlayers(FirstPlayer, SecondPlayer);
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
     

    }
}
