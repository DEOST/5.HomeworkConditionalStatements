//Write an if statement that examines two integer variables and exchanges their values if the first one is greater than the second one.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.IfGreaterOfTwo
{
    class GreaterOfTwo
    {
        static void Main()
        {
            Console.WriteLine("type first number");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("type second number");
            int secondNumber = int.Parse(Console.ReadLine());
            if (firstNumber > secondNumber)
            {
                int bufer = firstNumber;
                firstNumber = secondNumber;
                secondNumber = bufer;
            }
            Console.WriteLine("The first number is {0} and the second is {1}", firstNumber, secondNumber);
        }
    }
}
