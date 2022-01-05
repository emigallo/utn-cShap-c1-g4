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

        public void StartGame ()
        {
            Game game = new Game();
            game.Start();




        }




    }
}
