﻿/*Write a program that enters the coefficients a, b and c of a quadratic equation
		a*x2 + b*x + c = 0
		and calculates and prints its real roots. Note that quadratic equations may have 0, 1 or 2 real roots.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.QuadraticEquation
{
    class QuadraticEquation
    {
        static void Main()
        {
            Console.WriteLine("The Equation ax^2 + bx + c = 0");
            Console.Write("Type a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Type b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Type c: ");
            double c = double.Parse(Console.ReadLine());
            double discr = (b * b) - (4 * a * c);
            if (discr > 0)
            {
                double x1 = (-b + Math.Sqrt(discr)) / (2 * a);
                double x2 = (-b - Math.Sqrt(discr)) / (2 * a);
                Console.WriteLine("The roots are: X1: {0}; X2: {1}", x1, x2);
            }
            else if (discr == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine("There is only one root: {0}", x);
            }
            else if (discr < 0)
            {
                Console.WriteLine("There is no solution!");
            }
        }
    }
}
