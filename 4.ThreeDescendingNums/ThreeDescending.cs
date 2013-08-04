//Sort 3 real values in descending order using nested if statements.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.ThreeDescendingNums
{
    class ThreeDescending
    {
        static void Main()
        {
            Console.Write("type first number ");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.Write("type second number ");
            double secondNumber = double.Parse(Console.ReadLine());
            Console.Write("type third number ");
            double thirdNumber = double.Parse(Console.ReadLine());
            if ((firstNumber >= secondNumber && firstNumber >= thirdNumber))
            {
                Console.WriteLine("{0}, {1}, {2}", firstNumber, (secondNumber > thirdNumber ? secondNumber : thirdNumber), (secondNumber > thirdNumber ? thirdNumber:secondNumber));
            }
            else if (secondNumber >= firstNumber && secondNumber >= thirdNumber)
            {
                Console.WriteLine("{0}, {1}, {2}", secondNumber, (firstNumber > thirdNumber ? firstNumber : thirdNumber), (firstNumber > thirdNumber ? thirdNumber : firstNumber));
            }
            else
            {
                Console.WriteLine("{0}, {1}, {2}", thirdNumber, (secondNumber > firstNumber ? secondNumber : firstNumber), (secondNumber > firstNumber ? firstNumber : secondNumber));
            }

        }
    }
}
