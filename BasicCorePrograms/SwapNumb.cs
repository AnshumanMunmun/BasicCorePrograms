using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class SwapNumb
    {
        public void Read()
        { 
            int a, b, swap;
            Console.WriteLine("Enter the First Number");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second Number");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Number before the swapping " + a + "," + b);
            swap = a;
            a = b;
            b = swap;
            Console.WriteLine("Number after the swapping " + a + "," + b);
            Console.ReadKey();
        }
    }
}
