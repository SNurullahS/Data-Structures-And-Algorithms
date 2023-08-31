using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_And_Algorithms.Classes
{
    public class DublicateSolver
    {

       public bool isDuplicate(int[]Duplicate)
        {
            HashSet<int> DupblicateControl = new HashSet<int>(Duplicate);
             return Duplicate.Length != DupblicateControl.Count;
        }


    }
}
