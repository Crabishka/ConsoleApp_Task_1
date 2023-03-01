using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Task_1
{
    class Program
    {
        static void Main(string[] args)
        {

            const int N = 5;
            int[][] matrix = new int[N][];
            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = new int[N];
            }
            FillMatrix(matrix, 0, 51);
            PrintMatrix(matrix);
            SortMatrixByFirstElem(matrix);
            Console.WriteLine("\n");
            PrintMatrix(matrix);
            Console.ReadKey();

        }


        public static int[][] FillMatrix(int[][] matrix, int min, int max)
        {
            Random random = new Random();
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    matrix[i][j] = random.Next(min, max);
                }
            }
            return matrix;
        }

        public static void PrintMatrix(int[][] matrix)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write($"{matrix[i][j]} \t");
                }
                Console.WriteLine();
            }
        }


        public static int[][] SortMatrixByFirstElem(int[][] matrix)
        {
            Array.Sort(matrix, new ArrayComparer());
            return matrix;
        }
    }

    class ArrayComparer : IComparer<int[]>
    {
        public int Compare(int[] x, int[] y)
        {
            if (x is null || y is null)
            {
                throw new Exception("Array is null");
            }
            else
            {
                return x[0].CompareTo(y[0]);
            }
        }
    }



}
