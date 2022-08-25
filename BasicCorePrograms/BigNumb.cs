using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class BigNumb
    {
        public void Read()
        {
            Console.WriteLine("Enter First Number" );
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Third Number");
            int c = int.Parse(Console.ReadLine());
            if (a >= b)
            {
                if (a >= c)
                    Console.WriteLine(a + " is the largest number.");
                else
                    Console.WriteLine(c + " is the largest number.");
            }
            else
            {
                if (b >= c)
                    Console.WriteLine(b + " is the largest number.");
                else
                    Console.WriteLine(c + " is the largest number.");
            }
        }
    }
}
