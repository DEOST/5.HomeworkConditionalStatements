//Write a program that finds the biggest of three integers using nested if statements.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.BiggestOfThree
{
    class BiggestOfThree
    {
        static void Main()
        {
            Console.Write("type first number ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("type second number ");
            int secondNumber = int.Parse(Console.ReadLine());
            Console.Write("type third number ");
            int thirdNumber = int.Parse(Console.ReadLine());
            if ((firstNumber >= secondNumber && firstNumber >= thirdNumber))
            {
                Console.WriteLine("{0} is the biggest integer.", firstNumber);
            }
            else if (secondNumber >= firstNumber && secondNumber >= thirdNumber)
            {
                Console.WriteLine("{0} is the biggest integer.", secondNumber);
            }
            else
            {
                Console.WriteLine("{0} is the biggest integer.", thirdNumber);
            }
        }
    }
}
