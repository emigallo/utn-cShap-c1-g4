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
        

        public void PutMark (Mark _mark)
        {
            this.Mark = _mark;
        }

        //public void Play (Board board)
        //{
        //}

        //public void SetMark (Mark mark)
        //{
        //    this.Mark = mark;
        //}



    }
}
