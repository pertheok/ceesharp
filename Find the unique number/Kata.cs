using System;
using System.Collections.Generic;
using System.Linq;

namespace Unique
{
    public class Kata
    {
        public static int GetUnique(IEnumerable<int> numbers)
        {
            int startPointer = numbers.First();
            int endPointer = numbers.Last();
            // Below is an attempt to work the edge case where the unique item is either the first or the last in the array
            // if (startPointer != endPointer)
            // {
            //     foreach (int number in numbers)
            //     {
            //         if (endPointer == number)
            //         {
            //             return startPointer;
            //         }
            //         else
            //         {
            //             return endPointer;
            //         }
            //     }
            // }
            // else
            // {
                foreach (int number in numbers)
                {
                    if (startPointer == number)
                    {
                        continue;
                    }
                    else
                    {
                        startPointer = number;
                        return startPointer;
                    }
                }
            // }
            return startPointer;
        }
    }
}