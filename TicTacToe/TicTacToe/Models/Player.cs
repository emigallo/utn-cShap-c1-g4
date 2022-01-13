using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Models
{
    public class Player
    {
        public MarkType Mark { get; private set; }
        public string Name { get; set; }


        public  void SetMark(MarkType mark)
        {
            this.Mark = mark;
        }

    }
}
