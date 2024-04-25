using System.Collections.Generic;
using System.Linq;

namespace codewars{
    public class KataNextBiggerNumber{

        public long NextBiggerNumber(long numero) {
            //obtener los valores
            string[] valoresString = ObtenerCombinaciones(numero.ToString()).ToArray();

            //reducir los valores y combertir a long
            var valoresReducidos = valoresString.Distinct();

            int n = valoresReducidos.ToArray().Length;
            
            long[] valoresLongReducidos = new long[n]; 
            
            int c = 0;

            foreach (var item in valoresReducidos)
            {
                valoresLongReducidos[c] = long.Parse(item);
                c++;
                //valoresLongReducidos.Add(long.Parse( item ));
            }
            //Ordenar los valores
            Array.Sort(valoresLongReducidos);
            //valoresLongReducidos.Sort();
            //obtener indice del numero inical
            int indice = Array.IndexOf(valoresLongReducidos,numero);

            Console.WriteLine("indice : " + indice);
            Console.WriteLine("tamaño array : " + valoresLongReducidos.Length);
            if (indice >= valoresLongReducidos.Length-1) {
                return -1;
            } else { 
                 return valoresLongReducidos[indice + 1];
                }
        }
        public List<string> ObtenerCombinaciones(string palabra) {
            List<string> combinaciones = new List<string>();
            
            // Caso base: si la palabra es vacía, agregar una cadena vacía a las combinaciones y regresar
            if (string.IsNullOrEmpty(palabra))
            {
                combinaciones.Add("");
                return combinaciones;
            }

            // Recorrer la palabra
            for (int i = 0; i < palabra.Length; i++)
            {

                // Obtener el primer carácter y el resto de la palabra
                char primerCaracter = palabra[i];
                string other1 = palabra.Substring(0, i);
                string restoPalabra = palabra.Substring(0, i) + palabra.Substring(i + 1);
                // Obtener las combinaciones del resto de la palabra
                List<string> combinacionesRestantes = ObtenerCombinaciones(restoPalabra);

                // Agregar el primer carácter a cada combinación y agregarlas a la lista de combinaciones
                foreach (string combinacion in combinacionesRestantes)
                {
                    combinaciones.Add(primerCaracter + combinacion);
                }
            }
            return combinaciones;
        }
        //solucion chat gpt
        public long NextBiggerNumberChatGpt(long numero)
        {
            // Convertir el número en una matriz de dígitos
            char[] digitos = numero.ToString().ToCharArray();

            // Encontrar el índice del primer dígito que es menor que el siguiente
            int i;
            for (i = digitos.Length - 1; i > 0; i--)
            {
                if (digitos[i] > digitos[i - 1])
                    break;
            }

            // Si no hay ningún dígito que sea menor que el siguiente, no hay número más grande
            if (i == 0)
                return -1;

            // Encontrar el dígito más pequeño a la derecha del dígito en el índice i - 1 que es mayor que el dígito en el índice i - 1
            char digitoActual = digitos[i - 1];
            int indiceMinimo = i;
            for (int j = i + 1; j < digitos.Length; j++)
            {
                if (digitos[j] > digitoActual && digitos[j] < digitos[indiceMinimo])
                    indiceMinimo = j;
            }

            // Intercambiar el dígito en el índice i - 1 con el dígito más pequeño a su derecha que es mayor que él
            char temp = digitos[i - 1];
            digitos[i - 1] = digitos[indiceMinimo];
            digitos[indiceMinimo] = temp;

            // Ordenar los dígitos a la derecha del índice i - 1 en orden ascendente
            Array.Sort(digitos, i, digitos.Length - i);

            // Convertir la matriz de dígitos nuevamente a un número y devolverlo
            return long.Parse(new string(digitos));
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