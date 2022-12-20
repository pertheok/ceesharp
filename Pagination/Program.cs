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
            Console.WriteLine(helper.page_count());
            // Should return 6
            Console.WriteLine(helper.item_count());
            // Should return 4
            Console.WriteLine(helper.page_item_count(0));
            // Should return 2
            Console.WriteLine(helper.page_item_count(1));
            // Should return -1
            Console.WriteLine(helper.page_item_count(2));
            // // Should return 1
            // Console.WriteLine(helper.page_index(5));
            // // Should return 0
            // Console.WriteLine(helper.page_index(2));
            // // Should return -1
            // Console.WriteLine(helper.page_index(20));
            // // Should return -1
            // Console.WriteLine(helper.page_index(-10));
        }
    }
}