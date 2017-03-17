using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.System.Collections
{
    class SortedListEx
    {
        
        SortedList _sortedList = new SortedList();
        Dictionary<string, object> _currentSortValues = new Dictionary<string, object>();
        
        public void AddToList()
        {
            _currentSortValues.Add("QueryMe", "ABC");
            _currentSortValues.Add("QueryMe2", "DEF");
            Dictionary<string, object> sortValues = new Dictionary<string, object>(_currentSortValues);
            Dictionary<string, object> sortValues1 = new Dictionary<string, object>(_currentSortValues);
            try
            {
                _sortedList.Add(sortValues, "ABC");
                _sortedList.Add(sortValues1, "DEF");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                throw ex;

            }
        }

    }
}
