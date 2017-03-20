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
        Comparer objComparer = new Comparer();
        SortedList _sortedList;
        Dictionary<string, object> _currentSortValues = new Dictionary<string, object>();

        public void AddToList()
        {
            _sortedList = new SortedList(objComparer);
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

        public void Entry()
        {
            _sortedList = new SortedList(objComparer);
            _sortedList.Add("a", "Manu");
            _sortedList.Add("S", "shre");
            _sortedList.Add("T", "tara");
            _sortedList.Add(1, "shree");

            foreach (var item in _sortedList.Values)
            {
                Console.WriteLine(item.ToString());
            }
        }

    }

    class Comparer : IComparer
    {

        public int Compare(object x, object y)
        {
            IComparable xValue = x as IComparable;
            IComparable yValue = y as IComparable;

            //x < y return -1
            //x = y return 0
            //x > y return 1
            if(xValue!=null && yValue!=null)
            {
                int value=xValue.CompareTo(yValue);
                return value;
            }
            else if (xValue == null)
            {
                return -1;
            }
            else if (yValue == null)
            {
                return 0;
            }
            return 0;
        }
    }
}
