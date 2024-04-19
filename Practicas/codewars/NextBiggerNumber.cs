using System.Dynamic;
using System.Reflection.Metadata;

namespace codewars{
    public class KataNextBiggerNumber{
        public int NextBiggerNumber(string [] srr2){
            // string num_str = number.ToString().Split();
            // string [] arr_num_str = num_str.Split();
            string [] srr1 = {"1","2","3"};
            // string [] srr2 = {"1","2","3"};
           ;
            int a =  srr1.Distinct().Equals(srr2.Distinct()) ? 1 : 0;
            return a;
        }
    }
}

// Create a function that takes a positive integer and returns the next bigger number that can be formed by rearranging its digits. For example:

//   12 ==> 21
//  513 ==> 531
// 2017 ==> 2071

// If the digits can't be rearranged to form a bigger number, return -1 (or nil in Swift, None in Rust):

//   9 ==> -1
// 111 ==> -1
// 531 ==> -1