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
            //game.SetMarkPosition();
        }
     

    }
}
