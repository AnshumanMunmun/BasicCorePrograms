using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class FlipCoin
    {
        public void Read() //Reading input from user
        {
            Console.WriteLine("please enter number of times to flip coin : ");
            string input = Console.ReadLine();
            int times = Convert.ToInt32(input);    //Converts the value of string to an equivalent 32-bit signed int.
            Flip(times);                           //calling method flip
        }
        private static void Flip(int times)
        {   //variables
            int heads = 0; int tails = 0;       
            Random random = new Random();
            for (int i = 1; i <= times; i++)
            {                                   //using random to get random value between 0 to 1
                if (random.NextDouble() < 0.5)
                {
                    heads++;
                }
                else
                    tails++;
            }
            double headperc = (double)heads / times * 100; //Implementing percentage formula 
            double tailperc = (double)tails / times * 100;
            Console.WriteLine("Number of Heads count" + "=" + heads + "\npercentage " + "=" + headperc);
            Console.WriteLine("Number of Tails count" + "=" + tails + "\npercentage " + "=" + tailperc);
            
        }
    }
}
       
