using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class LeapYear
    {
        public void Read() //Reading input from user
        {
            Console.WriteLine("please enter the year : ");
            string input = Console.ReadLine();
            int year = Convert.ToInt32(input);    //Converts the value of string to an equivalent 32-bit signed int.
            leapYear(year);                       //calling method leapYear
        }
        private static void leapYear(int year)    //Check the Conditions of LeapYear by using ForLoop
        {                                         //if year is divisible by both 4 and 400 then its a LeapYear
            if ((year % 4 == 0) && (year % 400 != 0) || (year % 4 == 0 && (year % 100 == 0)))
            {
                Console.WriteLine(year + " is a leap year");
            }
            else
                Console.WriteLine(year + " is not a leap year");
        }
    }
}
