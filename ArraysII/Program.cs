using System;

namespace ArraysII
{
    class ArrayII
    {
        static void Main(string[]args)
        {
            //Question 1
            //Write a program in C# to find the sum of all elements of the array

            int[] randomNum = new int[3] {2, 5, 8};

            int sum = 0;
            foreach(int element in randomNum)
            {
                sum += element;
            }
            Console.WriteLine($"Sum of all elements stored in the array is: {sum}");

            //Question 2
            //Write a program in C# to copy the elementsof one array into another array

            int[] firstArray = new int[3] {15, 10, 12};
            Console.WriteLine("\nThe elements stored in the first array are:");
            Console.WriteLine(string.Join(", ", firstArray));

            int[] secondArray = new int[3];
            for(int i = 0; i < secondArray.Length; i++)
            {
                secondArray[i] = firstArray[i];
            }
            Console.WriteLine("\nThe elements stored in the second array are:");
            Console.WriteLine(string.Join(", ", secondArray));
        }
    }
}