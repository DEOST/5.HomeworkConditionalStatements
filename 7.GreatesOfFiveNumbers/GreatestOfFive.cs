//Write a program that finds the greatest of given 5 variables.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.GreatesOfFiveNumbers
{
    class GreatestOfFive
    {
        static void Main()
        {
            int[] numberArray = new int[5];
            for (int index = 0; index < 5; index++)
            {
                Console.Write("Number {0}: ", index + 1);
                numberArray[index] = int.Parse(Console.ReadLine());
            }
            int greatestNumber = numberArray.Max();
            Console.WriteLine("The Greatest number is: {0}", greatestNumber);
        }
    }
}

      