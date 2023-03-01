using System;

namespace Pagination
{
    public class PaginationHelper
    {
        // --- User provided data ---

        // Array containing items to be distributed throughout the pages
        char[] _values;
        // Maximum number of items each page can hold
        int _items;

        // --- Constructor ---

        public PaginationHelper(char[] values, int items)
        {
            _values = values;
            _items = items;
        }

        // --- Methods ---

        // Method that indicates the amount of pages provided items are distributed between 
        public int PageCount()
        {
            // If there is no remainder, page count is simply a result of the division, otherwise an additional page is added to house whatever elements form the remainder

            return ItemCount() % _items == 0 ? 
                ItemCount() / _items : 
                (ItemCount() / _items) + 1;
        }

        // Method that indicates the total number of provided items
        public int ItemCount()
        {
            return _values.Length;
        }

        // Method that indicates how many items are on the provided page number, return value is a zero based index (if valid)
        public int PageItemCount(int page)
        {
            // Returns -1 if the provided page number is out of range
            // If not, checks if there is no remainder when dividing the total number of provided items by the maximum number of items each page can hold
            // OR checks if the page being checked is not the last one, which would hold the amount of items equal to the remainder
            // OTHERWISE returns the division remainder itself, which would be the item count for the last page

            return page < 0 | page > PageCount() - 1 ? 
            -1 : 
            ItemCount() % _items == 0 | page != PageCount() - 1 ? 
            _items : 
            ItemCount() % _items;
        }

        // Method that indicates the page the given item index can be found on (zero based index)
        public int PageIndex(int item)
        {
            // Returns -1 if the provided item index is invalid
            // OR returns the page
            return item < 0 | item >= ItemCount() ? 
            -1 : 
            item / _items;
        }
    }
}
