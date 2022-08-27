using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class Alphabet
    {
        public void Read()
        {
            char check;
            Console.Write("Enter The Any Alphabet to check it's Vowel or Consonant : ");
            check = Convert.ToChar(Console.Read());
            if (check == 'a' || check == 'e' || check == 'i' || check == 'o' || check == 'u' || check == 'A' || check == 'E' || check == 'I' || check == 'O' || check == 'U')
            {
                Console.WriteLine("Alphabet " + check + " is Vowel.");
            }
            else
            {
                Console.WriteLine("Alphabet " + check + " is Consonant.");
            }
        }
    }
}
