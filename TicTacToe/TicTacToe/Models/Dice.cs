namespace TicTacToe
{
    public class Dice
    {

        public int Throw ()
        {
            return new Random().Next(1, 6);
        }


    }
}