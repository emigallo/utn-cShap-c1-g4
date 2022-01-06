using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Models
{
    public class MarkPosition
    {
        public int X { get; }
        public int Y { get; }

        public MarkPosition(int x, int y)
        {
            if (x < 0 || x > 2) throw new InvalidMarkPositionException("debe elegir un numero entre 0 y 2");
            if (x < 0 || y > 2) throw new InvalidMarkPositionException("debe elegir un numero entre 0 y 2");
            X = x;
            Y = y;
        }
    }
}
