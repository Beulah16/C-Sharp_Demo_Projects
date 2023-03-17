using System;

namespace IIFiles
{
    class IIFile
    {
        static void Main(string[]args)
        {
            //Calling a method/function
            
            /*1*/ Add(5);
            /*2*/ Subtract(19, 2);
            
            Console.WriteLine("Enter a number");
            int a = Convert.ToInt32(Console.ReadLine());
            /*3*/ Console.WriteLine(Square(a));
        } 

        //Creating a method/function 1
        static void Add(int x)
        {
            int num = 5;
            num = num + x;
            Console.WriteLine(num);
        }

        //Creating a method/function 2
        static void Subtract(int x, int y)
        {
            Console.WriteLine(x - y);
        }

        //Creating a method/function 3
        static int Square(int num)
        {
            int result;
            result = num * num;
            return result;
        }
    }
}