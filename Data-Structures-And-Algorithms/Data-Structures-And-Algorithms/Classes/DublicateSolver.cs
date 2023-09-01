using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_And_Algorithms.Classes
{
    public class DublicateSolver
    {
        // This method takes an integer array as input and checks for duplicate elements within the array.
        // If there are duplicate elements in the array, it returns true; otherwise, it returns false.
        public bool isDuplicate(int[] Duplicate)
        {
            HashSet<int> DuplicateControl = new HashSet<int>(Duplicate);
            return Duplicate.Length != DuplicateControl.Count;
        }
    }
}
