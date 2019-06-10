using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects.Exercises
{
    class Palindrome
    {
        public static void palindrome()
        {           
                Console.WriteLine("Enter first String: ");
                String FirstString = Console.ReadLine();

            char[] ReverseString = FirstString.ToCharArray();
            Array.Reverse(ReverseString);

            String RS = new String(ReverseString);

            Console.WriteLine(RS);

            if (FirstString == RS)
            {
                Console.WriteLine("Entered string is a palindrome");
            }
            else
            {
                Console.WriteLine("Entered string is not a palindrome");
            }
        }
    }
}
