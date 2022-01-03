using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Models
{
    internal class Board
    {

        public Mark[,] Marks = new Mark[3, 3];


        public Mark[,] GetMarks()
        {
            return this.Marks;
        }

        public void SetMarkEmpty (int x, int y)
        {
            this.Marks[x, y] = Mark.Empty;
        }

    }
}
