using System;

namespace Gamblinguc3
{
    class Program
    {
        public static int stake = 100;
        public static int bet = 1;
        public static int loose = 0;
        public static int win = 0;
        public static int flag = 0;

        Random random = new Random();
        public void winOrLoss()
        {

            int check = random.Next(0, 2);
            if (check == 1)
            {
                win++;
                stake++;
                Console.WriteLine("Player Win the game");
            }
            else
            {
                loose++;
                stake--;
                Console.WriteLine("Player loss the game");

            }
        }
        public void winOrLossForADay()
        {
            int looseStake = stake / 2;
            int winStake = (stake + 50);
            while (stake != looseStake || stake != winStake)
            {
                int checkVal = random.Next(0, 2);
                if (checkVal == 1)
                {
                    win++;
                    stake++;
                }
                else
                {
                    loose++;
                    stake--;

                }
                if (stake == looseStake)
                {
                    flag = 1;
                    break;
                }
                if (stake == winStake)
                {
                    flag = 2;
                    break;
                }
            }



        }

        static void Main(string[] args)
        {
            Program obj = new Program();
            //obj.winOrLoss();
            obj.winOrLossForADay();
            if (flag == 1)
            {
                Console.WriteLine("Player win the game" + stake);
            }
            else
            {
                Console.WriteLine("Player loss the game " + stake);

            }
        }
    }
}