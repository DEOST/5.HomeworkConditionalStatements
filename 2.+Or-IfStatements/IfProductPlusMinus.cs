//Write a program that shows the sign (+ or -) of the product of three real numbers without calculating it. Use a sequence of if statements.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._Or_IfStatements
{
    class IfProductPlusMinus
    {
        static void Main()
        {
            Console.Write("type first number ");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.Write("type second number ");
            double secondNumber = double.Parse(Console.ReadLine());
            Console.Write("type third number ");
            double thirdNumber = double.Parse(Console.ReadLine());
            if ((firstNumber == 0) || (secondNumber == 0) || (thirdNumber == 0))
            {
                Console.WriteLine("The result is 0");
            }

            else if ((firstNumber < 0) ^ (secondNumber < 0))
            {
                if (thirdNumber < 0)
                {
                    Console.WriteLine("the product of three is +");
                }
                else Console.WriteLine("the product of three is -");
            }
            else
                if (thirdNumber < 0)
                {
                    Console.WriteLine("the product of three is -");
                }
                else Console.WriteLine("the product of three is +");
        }
    }
}
