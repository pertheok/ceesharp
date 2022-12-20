using System;

namespace Pagination
{
    class Program
    {
        static void Main(string[] args)
        {   
            // Input array
            char[] input = {'a','b','c','d','e','f'};

            // Initialise a new object of the PaginationHelper class
            PaginationHelper helper = new PaginationHelper(input, 4);

            // --- Test methods ---
            // Should return 2
            Console.WriteLine(helper.PageCount());
            // Should return 6
            Console.WriteLine(helper.ItemCount());
            // Should return 4
            Console.WriteLine(helper.PageItemCount(0));
            // Should return 2
            Console.WriteLine(helper.PageItemCount(1));
            // Should return -1
            Console.WriteLine(helper.PageItemCount(2));
            // Should return 1
            Console.WriteLine(helper.PageIndex(5));
            // Should return 0
            Console.WriteLine(helper.PageIndex(2));
            // Should return -1
            Console.WriteLine(helper.PageIndex(20));
            // Should return -1
            Console.WriteLine(helper.PageIndex(-10));
        }
    }
}