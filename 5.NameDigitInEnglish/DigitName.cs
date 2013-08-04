using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.NameDigitInEnglish
{
    class DigitName
    {
        static void Main()
        {
            Console.WriteLine("type a digit");
            byte digit = byte.Parse(Console.ReadLine());
            string digitName = "";
        switch (digit)
        {
            case 0: digitName = "Zero"; break;
            case 1: digitName = "One"; break;
            case 2: digitName = "Two"; break;
            case 3: digitName = "Three"; break;
            case 4: digitName = "Four"; break;
            case 5: digitName = "Five"; break;
            case 6: digitName = "Six"; break;
            case 7: digitName = "Seven"; break;
            case 8: digitName = "Eight"; break;
            case 9: digitName = "Nine"; break;
            default: Console.WriteLine("Please type a digit 0-9");
                break;
        }
        Console.WriteLine("The digit you have entered is {0}({1})", digitName, digit);
        }
    }
}
