﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Models
{
    internal class Board
    {

        public Mark[,] Marks = new Mark[3, 3];

        private List<((int, int), (int, int), (int, int))> _winnersPosition =
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




        public Mark[,] GetMarks()
        {
            return this.Marks;
        }

        public void SetMarkEmpty (int x, int y)
        {
            this.Marks[x, y] = Mark.Empty;
        }

        public Boolean IsFull()
        {
            Boolean isFull = true;
            int x = 0;
            int y = 0;

            while (isFull && x<3)
            {
                while (isFull && y<3)
                {
                    if (this.Marks[x,y] == Mark.Empty)
                    {
                        isFull = false;
                    }
                }
            }

            return isFull;
        }


        

    }
}
