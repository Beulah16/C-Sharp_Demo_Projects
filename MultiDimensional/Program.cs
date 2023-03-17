using System;
namespace Arrays
{
    class MultiDimensional
    {
        static void Main(string[]args)
        {
            //This is a program that converts a 2D array into a 1D
            int[,] evod = { {1, 3, 5, 7, 9, 11}, {2, 4, 6, 8, 10, 12} };
            for (int i = 0; i < evod.GetLength(0); i++)
            {
                for (int j = 0; j < evod.GetLength(1); j++)
                {
                    Console.Write($" {evod[i, j]} ");
                    
                }
                Console.WriteLine();
            }
        }
    }
}