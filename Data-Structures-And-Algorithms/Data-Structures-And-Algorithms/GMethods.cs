using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_And_Algorithms
{
    public class GMethods
    {

        public int Factorial(int number)
        {
            if (number == 0 || number == 1)
            {
                return 1;
            }
            else
            {
                return (number * Factorial(number - 1));
            }
        }
    }
}
