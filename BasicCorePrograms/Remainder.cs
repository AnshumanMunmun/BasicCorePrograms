using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class Remainder
    {
        public void Read()
        {
            int divid, divisor, quot, remain;
            Console.WriteLine("Enter Any number for Dividend");
            divid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Any number for Divisor");
            divisor = Convert.ToInt32(Console.ReadLine());
            quot = divid / divisor;
            remain = divid % divisor;
            Console.WriteLine("Quotient = " + quot);
            Console.WriteLine("Remainder = " + remain);
        }
    }
}
