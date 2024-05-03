using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace Practicas.hackerrank
{
    internal class Recursividad
    {
        public static void extraLongFactorials(int n)
        {
            Console.WriteLine(Factorizar(n));
        }
        public static BigInteger Factorizar(int n)
        {

            BigInteger r = BigInteger.Zero;

            //Caso inductivo
            if (n > 1)
                r = n * Factorizar(n - 1);
            //Caso base
            if (n == 1)
                r = 1;

            return r;
        }

        public static IEnumerable<List<int>> Permutar(List<int> nums)
        {
            if (nums.Count == 1)
                yield return nums;
            else
            {
                for (int i = 0; i < nums.Count; i++)
                {
                    int num = nums[i];
                    List<int> subNums = new List<int>(nums);
                    subNums.RemoveAt(i);
                    foreach (var perm in Permutar(subNums))
                    {
                        perm.Insert(0, num);
                        yield return perm;
                    }
                }
            }
        }
    }
}
