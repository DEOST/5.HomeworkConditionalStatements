//We are given 5 integer numbers. Write a program that checks if the sum of some subset of them is 0. Example: 3, -2, 1, 1, 8  1+1-2=0.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.SumSubsetOfFiveIsZero
{
    class SumSubset
    {
        static void Main()
        {
            int[] numberArray = new int[5];
            for (int index = 0; index < 5; index++)
            {
                Console.Write("Number {0}: ", index + 1);
                numberArray[index] = int.Parse(Console.ReadLine());
            }
            int sum = 0;
            int subsetCount = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = i + 1; j < 5; j++)
                {
                    sum = numberArray[i] + numberArray[j];
                    if (sum == 0)
                    {
                        subsetCount++;
                    }
                    Console.WriteLine("{0} + {1} = {2}", numberArray[i], numberArray[j], sum);
                    for (int k = j + 1; k < 5; k++)
                    {
                        sum = sum + numberArray[k];
                        if (sum == 0)
                        {
                            subsetCount++;
                        }
                        Console.WriteLine("{0} + {1} + {2} = {3}", numberArray[i], numberArray[j], numberArray[k], sum);
                        for (int l = k + 1; l < 5; l++)
                        {
                            sum = sum + numberArray[l];
                            if (sum == 0)
                            {
                                subsetCount++;
                            }
                            Console.WriteLine("{0} + {1} + {2} + {3} = {4}", numberArray[i], numberArray[j], numberArray[k], numberArray[l], sum);
                            for (int m = l + 1; m < 5; m++)
                            {
                                sum = sum + numberArray[m];
                                if (sum == 0)
                                {
                                    subsetCount++;
                                }
                                Console.WriteLine("{0} + {1} + {2} + {3} + {4} = {5}", numberArray[i], numberArray[j], numberArray[k], numberArray[l], numberArray[m], sum);
                            }
                        }
                    }
                }
            }
            Console.WriteLine("There are {0} sums of subsets that are equal to Zero!", subsetCount);
        }
    }
}
