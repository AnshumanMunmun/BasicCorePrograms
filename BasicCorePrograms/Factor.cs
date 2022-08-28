using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class Factor
    {
        public void Read()
        {
            int x = 0, a, b;
            Console.WriteLine("enter any number");
            a = int.Parse(Console.ReadLine());
            for (b = 2; a > 1; b++)
            {
                if (a % b == 0)
                {
                    while (a % b == 0)
                    {
                        a /= b;
                        x++;
                    }
                    Console.WriteLine(b + " is a prime factor " + x + " times");
                }
            }
        }
    }
}
