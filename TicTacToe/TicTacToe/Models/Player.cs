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


        public  void SetMark(MarkType mark)
        {
            this.Mark = mark;
        }

        public MarkPosition Play ()
        {
            Console.WriteLine("Elija una fila");
            int rowSelected = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Elija una columna");
            int colSelected = Int32.Parse(Console.ReadLine());

            MarkPosition markPosition = new MarkPosition(rowSelected, colSelected);

            return markPosition;
        }
    }
}
