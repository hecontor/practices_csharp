using System;
using System.Collections.Generic;
using System.Linq;

class MagicSquare
{
    // Funcion para verificar si una lista es un cuadrado magico
    static bool IsMagicSquare(List<List<int>> square)
    {
        int n = square.Count;
        int magicSum = CalculateMagicSum(square);

        // Verificar filas y columnas
        for (int i = 0; i < n; i++)
        {
            int rowSum = 0;
            int colSum = 0;
            for (int j = 0; j < n; j++)
            {
                rowSum += square[i][j];
                colSum += square[j][i];
            }
            if (rowSum != magicSum || colSum != magicSum)
                return false;
        }

        // Verificar diagonales
        int diagSum1 = 0;
        int diagSum2 = 0;
        for (int i = 0; i < n; i++)
        {
            diagSum1 += square[i][i];
            diagSum2 += square[i][n - i - 1];
        }
        if (diagSum1 != magicSum || diagSum2 != magicSum)
            return false;

        return true;
    }

    // Funcion para calcular la suma magica
    public static int CalculateMagicSum(List<List<int>> square)
    {
        // Suma de la primera fila para obtener la suma magica
        int magicSum = square[0].Sum();
        return magicSum;
    }

    // Funcion para calcular el costo de convertir la matriz dada en un cuadrado magico especifico
    static int CalculateConversionCost(List<List<int>> originalSquare, List<List<int>> magicSquare)
    {
        int cost = 0;
        int n = originalSquare.Count;

        // Calcular el costo de convertir cada numero en la matriz original al correspondiente en el cuadrado magico
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                cost += Math.Abs(originalSquare[i][j] - magicSquare[i][j]);
            }
        }

        return cost;
    }

    // Funcion para convertir una lista de numeros en un cuadrado magico
    static List<List<int>> ConvertToSquare(List<int> nums)
    {
        int n = (int) Math.Sqrt(nums.Count);
        List<List<int>> square = new List<List<int>>();
        for (int i = 0; i < n; i++)
        {
            List<int> row = nums.Skip(i * n).Take(n).ToList();
            square.Add(row);
        }
        return square;
    }

    // Funcion para encontrar el costo minimo de convertir la matriz original en un cuadrado magico
   public static int formingMagicSquare(List<List<int>> originalSquare)
    {
        int minCost = int.MaxValue;
        int n = originalSquare.Count;

        // Generar todas las permutaciones de numeros del 1 al n^2
        List<int> nums = Enumerable.Range(1, n * n).ToList();
        foreach (var permutation in Permute(nums))
        {
            // Convertir la permutacion en un cuadrado magico
            List<List<int>> magicSquare = ConvertToSquare(permutation);

            // Verificar si el cuadrado es magico
            if (IsMagicSquare(magicSquare))
            {
                // Calcular el costo de conversion y actualizar el costo minimo
                int cost = CalculateConversionCost(originalSquare, magicSquare);
                minCost = Math.Min(minCost, cost);
            }
        }

        return minCost;
    }

    // Funcion para generar todas las permutaciones de un arreglo de numeros
   public static IEnumerable<List<int>> Permute(List<int> nums)
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
                foreach (var perm in Permute(subNums))
                {
                    perm.Insert(0, num);
                    yield return perm;
                }
            }
        }
    }
    
}
