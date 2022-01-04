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
        { //validar que ingrese numeros validos
            X = x;
            Y = y;
        }
    }
}
