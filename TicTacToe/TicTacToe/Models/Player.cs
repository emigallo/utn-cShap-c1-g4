using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Models
{
    public class Player
    {
        public Mark Mark { get; private set; }
        

        public void SetMark (Mark _mark)
        {
            this.Mark = _mark;
        }

        
    }
}
