using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Models
{
    public class Board
    {

        public MarkType[,] Marks = new MarkType[3, 3];

        private List<((int, int), (int, int), (int, int))> _winnerPositions =
             new List<((int, int), (int, int), (int, int))>
         {
                ((0,0),(0,1),(0,2)), //Ganador 1era fila
                ((1,0),(1,1),(1,2)), //Ganador 2da fila
                ((2,0),(2,1),(2,2)), //Ganador 3ra fila
                ((0,0),(1,0),(2,0)), //Ganador 1era columna
                ((0,1),(1,1),(2,1)), //Ganador 2da columna
                ((0,2),(1,2),(2,2)), //Ganador 3ra columna
                ((0,0),(1,1),(2,2)), //Ganador diagonal 1
                ((2,0),(1,1),(0,2)), //Ganador diagonal 2
         };

        public void SetMarkEmpty (int x, int y)
        {
            this.Marks[x, y] = MarkType.Empty;
        }

        public Boolean IsFull()
        {
            Boolean isFull = true;
           

            for(int x = 0; x<3; x++)
            {
                for(int y = 0; y<3; y++)
                {
                    if (this.Marks[x, y] == MarkType.Empty)
                    {
                        isFull = false;

                    }
                }
            }

            return isFull;
        }


        public bool HasWinner()
        {
            return _winnerPositions.Any(x => Marks[x.Item1.Item1, x.Item1.Item2] == Marks[x.Item2.Item1, x.Item2.Item2]
                                             &&
                                             Marks[x.Item2.Item1, x.Item2.Item2] == Marks[x.Item3.Item1, x.Item3.Item2]
                                             && this.Marks[x.Item1.Item1, x.Item1.Item2] != MarkType.Empty);
        }

    }
}
