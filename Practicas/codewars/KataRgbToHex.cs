using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicas.codewars
{
    public class KataRgbToHex
    {
        public static string Rgb(int r, int g, int b)
        {
            //crear un array con los valores
            r = r < 255 ? r : 255;
            g = g < 255 ? g : 255;
            b = b < 255 ? b : 255;
            int[] colores = {r, g, b};
            string color_hex = String.Empty;
            //convertir a hexadecimal
            foreach (int rgb in colores)
            {
                string hex = string.Empty;
                int color_actual = rgb;
                while (color_actual > 0)
                {
                    switch (color_actual % 16) // este calculo es el residuo
                    {
                        case 10: hex += "A"; break;
                        case 11: hex += "B"; break;
                        case 12: hex += "C"; break;
                        case 13: hex += "D"; break;
                        case 14: hex += "E"; break;
                        case 15: hex += "F"; break;
                        default: hex += (color_actual % 16).ToString(); break;
                    }
                    color_actual /= 16;
                }
                //retornar hex
                if (hex.Length == 1)
                {
                    hex = ("0" + hex);
                }
                else if (hex.Length == 0)
                {
                    hex = "00";
                }
                else {
                    hex = hex[1].ToString() + hex[0].ToString();
                }
                color_hex += hex; 
            }

            return color_hex;

        }
        // este ejercicio fué copiado de codewar : las mejores practicas
        public static string RgbKata(int r, int g, int b)
        {
            r = Math.Max(Math.Min(255, r), 0);
            g = Math.Max(Math.Min(255, g), 0);
            b = Math.Max(Math.Min(255, b), 0);
            return String.Format("{0:X2}{1:X2}{2:X2}", r, g, b);
        }
    

    }
}
