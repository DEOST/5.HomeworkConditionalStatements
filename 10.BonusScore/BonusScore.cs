﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.BonusScore
{
    class BonusScore
    {
        static void Main()
        {
            Console.Write("Type a score points [1..9]");
            int score = int.Parse(Console.ReadLine());

            switch (score)
            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine(score * 10);
                    break;
                case 4:
                case 5:
                case 6:
                    Console.WriteLine(score * 100);
                    break;
                case 7:
                case 8:
                case 9:
                    Console.WriteLine(score * 1000);
                    break;
                default:
                    Console.WriteLine("Error: Invalid score!");
                    break;
            }
        }
    }
}
