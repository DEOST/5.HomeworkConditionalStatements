﻿//Write a program that, depending on the user's choice inputs int, double or string variable. If the variable is integer or double, increases it with 1. If the variable is string, appends "*" at its end. The program must show the value of that variable as a console output. Use switch statement.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.InputUserType
{
    class InputUserType
    {
        static void Main()
        {
            Console.WriteLine("type int, double or string");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "int":
                    Console.WriteLine("Type integer number: ");
                    int intChoice = int.Parse(Console.ReadLine());
                    Console.WriteLine(intChoice + 1);
                    break;
                case "double":
                    Console.WriteLine("Type double number: ");
                    double doubleChoice = double.Parse(Console.ReadLine());
                    Console.WriteLine(doubleChoice + 1);
                    break;
                case "string":
                    Console.WriteLine("Type string: ");
                    string stringChoice = Console.ReadLine();
                    Console.WriteLine(stringChoice + "*");
                    break;
                default: Console.WriteLine("Invalid input!");
                    break;
            }
        }
    }
}
