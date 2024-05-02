using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicas.hackerrank
{
    internal class HRaVeryBigSum
    {
        public static long aVeryBigSum(List<long> ar)
        {
            long sum = 0;
            for (int i = 0; i < ar.Count; i++) { 
                sum += ar[i];
            }
            return sum;
        }
    }
}
