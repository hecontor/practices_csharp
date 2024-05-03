using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicas.hackerrank
{
    class HRDiagonalDifference
    {
        public static int diagonalDifference(List<List<int>> arr)
        {
            int d1 = 0, d2 = 0;
            for (int i = 0; i < arr.Count; i++)
            {
               int a = arr[i].Count - 1 ;
               d1 += arr[i][i];
               d2 += arr[a - i][i];
            }
            return Math.Abs(d1 - d2);
        }

        public static void plusMinus(List<int> arr)
        {
            string formato = "0.";
            arr.ForEach(i => { formato += "0"; }); //establecer formato
            decimal divisor = arr.Count;
            decimal p = (arr.Where(x => x > 0).ToList().Count() / divisor);
            decimal n = (arr.Where(x => x < 0).ToList().Count() / divisor);
            decimal c = (arr.Where(x => x == 0).ToList().Count() / divisor);

            Console.WriteLine(
                p.ToString(formato) + '\n' +
                n.ToString(formato) + '\n' +
                c.ToString(formato) );
            
        }
    }
}
