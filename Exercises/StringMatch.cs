using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects.Exercises
{
    class StringMatch
    {
        public bool MatchString()
        {
            Console.WriteLine("Enter the first string");
            String FirstString = Console.ReadLine();

            Char[] chFirstString = FirstString.ToCharArray();
            Array.Reverse(chFirstString);

            Console.WriteLine("Enter the second string");
            String SecondString = Console.ReadLine();
            char[] chSecondString = SecondString.ToCharArray();
            Array.Reverse(chSecondString);
          
            int counter = 0;

            for (int i = 0; i < chSecondString.Length; i++)
            {
                if (chSecondString[i] == chFirstString[i])
                {
                    counter++;
                }
            }

            if (counter == chSecondString.Length)
            {
                return true;
            }
            return false;      
        }

        public static bool CheckEnding(string str1, string str2)
        {
            if (str1.Substring(str1.Length - str2.Length, str2.Length) == str2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
