using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicas.codewars
{
    public class KataFirstNonRepeatingLettercs
    {
        public static string FirstNonRepeatingLetter(string s) {
            string fnrp = string.Empty; 
            foreach (var c in s.ToCharArray())
            {
                if (s.ToLower().Split(c.ToString().ToLower()).Length > 2) fnrp = "";
                else return c.ToString();  
            }
            return fnrp;
        }
    }
}
