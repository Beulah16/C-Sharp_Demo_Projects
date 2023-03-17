using System;

namespace ArraysI
{
    class ArrayI
    {
        static void Main(string[]args)
        {
          //Question 1
          //Write a program in C# to store elements in an array and print it.

          int[] evenNum = {2, 4, 6, 8, 1, 14, 16, 18, 20};

          for (int i = 0; i < evenNum.Length; i++)
          {
            Console.WriteLine(evenNum[i]);
          }

          //Question 2
          //Write a C# program to declare, initialize, input elements in array and print array.
          
          int size;
          Console.WriteLine("Enter size of array");
          size = Convert.ToInt32(Console.ReadLine());

          int[] oddNum = new int[size];
          Console.WriteLine($"Enter {size} elements");

          for(int j = 0; j < oddNum.Length; j++)
          {
            int elements = Convert.ToInt32(Console.ReadLine());
            oddNum[j] = elements;
          }
          Console.WriteLine("Elements in array are : ");
          Console.WriteLine(string.Join("\n", oddNum));
        }
    }
}