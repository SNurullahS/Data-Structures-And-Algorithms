using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_And_Algorithms.Classes
{
    public class SingleNumber
    {
        public int FindUniqueNumber(int[] NewArray)
        {
            Array.Sort(NewArray);
            int x= NewArray[0];
            int y= NewArray[1];
            int a = 1;

            if(x!=y)
            {
                return x;
            }
            else  {

                while (x == y)
                {
                    a++;
                    x = y;
                    y = NewArray[a];
                }

            }

            return y;
        }
    }
}
