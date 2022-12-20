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
        public int page_count()
        {
            // If there is no remainder, page count is simply a result of the division, otherwise an additional page is added to house whatever elements form the remainder
            return _values.Length % _items == 0 ? _values.Length / _items : (_values.Length / _items) + 1;
            // if (_values.Length % _items == 0)
            // {
            //     return _values.Length / _items;
            // }
            // else
            // {
            //     return (_values.Length / _items) + 1;
            // }
        }

        // Method that indicates the total number of provided items
        public int item_count()
        {
            return _values.Length;
        }

        // Method that indicates how many items are on the provided page number (zero based index)
        public int page_item_count(int page)
        {
            // Returns -1 if the provided page number is out of range
            // OR Checks if there was no remainder of the page_count() function, i.e. if there's an equal amount of items throughout all pages 
            // OR if the given page is not the last one (with page numbers being zero based indexed), which is the page with the item count different than the rest of the pages if there was a division remainder
            // Otherwise returns the division remainder itself, which would be the item count for the last page
            return page < 0 | page > page_count() -1 ? -1 : _values.Length % _items == 0 | page != page_count() -1 ? _items : _values.Length % _items;

            // if (page < 0 | page > page_count() - 1)
            // {
            //     return -1;
            // }
            // else
            // {
            //     
            //     if (_values.Length % _items == 0 | page != page_count() - 1)
            //     {
            //         return _items;
            //     }
            //     else
            //     {
            //         return _values.Length % _items;
            //     }
            // }
        }

        // Method that indicates the page the given item index can be found on (zero based index)
        // public int page_index(int item)
        // {
        //     // Returns -1 if the provided item index is invalid
        //     if (item < 0 | item > _values.Length)
        //     {
        //         return -1;
        //     }
        //     else
        //     {

        //     }
        // }
    }
}
