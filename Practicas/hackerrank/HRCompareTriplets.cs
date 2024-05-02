using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicas.hackerrank
{
    internal class HRCompareTriplets
    {
        public static List<int> compareTriplets(List<int> a, List<int> b)
        {
            int c0 = 0, c1 = 0, count = 0;
            a.ForEach(x => {
                
                if (x > b[count]) c0 ++;
                    else if (b[count] > x) c1 ++;

                count++;
            });
            
            return new List<int>() { c0, c1};
        }

    }
}
