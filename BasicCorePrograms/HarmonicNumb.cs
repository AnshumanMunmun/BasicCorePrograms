using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class HarmonicNumb
    {
        public void Read()
        {
            int num, i;
            double result = 1.0;
            Console.WriteLine("Enter the Number");
            num = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= num; i++)
            {
                result += (double)1 / num;
                num--;
                Console.WriteLine("The value of harmonic number " + num + " is: " + result);
            }
        }
    }
}
