using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class ShapeMath
    {
        public static double GetArea(string shape = "",
            double length1 = 0,
            double length2 = 0)
        {
            if(String.Equals("rectangle", shape, StringComparison.OrdinalIgnoreCase))
            {
                return length1 * length2;
            }else if(String.Equals("triangle", shape, StringComparison.OrdinalIgnoreCase))
            {
                return length1 * (length2 / 2);
            }
            else if (String.Equals("circle", shape, StringComparison.OrdinalIgnoreCase))
            {
                return 3.14159 * Math.Pow(length1, 2);
            }
            else
            {
                return -1;
            }
        }
    }
}
