using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicas.codewars
{
    public class KataMysteryFunction
    {
        public static long Mystery(long n)
        {
            string codigo = Convert.ToString(n, 2);
            string binario = "";
            binario += codigo[0];

            for (int i = 1; i < codigo.Length; i++)
            {
                binario += Convert.ToString(Convert.ToInt32(codigo[i - 1].ToString()) ^ Convert.ToInt32(codigo[i].ToString()));
            }

            long num_decimal = Convert.ToInt64(binario, 2);
            return num_decimal; // retornar el valor en decimal de binario (por parametro debe entrar un codigo gray)

        }

        public static long MysteryInv(long n)
        {

            string binario = Convert.ToString(n, 2);
            string codigo_gray = "";
            codigo_gray += binario[0];

            // Iterate through remaining binary digits, applying XOR with previous Gray code digit
            for (int i = 1; i < binario.Length; i++)
            {
                char currentBinaryDigit = binario[i];
                char previousGrayDigit = codigo_gray[i - 1];
                codigo_gray += currentBinaryDigit ^ previousGrayDigit;
            }
            long num_decimal = Convert.ToInt64(codigo_gray, 2);
            return num_decimal; //retornar el valor en decimal del codigo gray (por parametro debe entrar un binario)

        }

        public static string NameOfMystery()
        {
            return "reflected binary code";
        }

    }
}
