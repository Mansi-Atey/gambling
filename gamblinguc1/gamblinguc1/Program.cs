using System;

namespace gamblinguc1
{
    class Program
    {
        public int stake = 100;
        public int bet = 1;
        static void Main(string[] args)
        {

            Random random = new Random();
            int checkVal = Random.Next(0, 2);
            if (checkVal == 1)
            {
                Console.WriteLine("player won");
            }
            else
            {
                Console.WriteLine("player loose");

            }

        }
    }
}