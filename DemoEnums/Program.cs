using System;
namespace Enums
{
    public enum AreaParameters
    {
        Radius,
        Length,
        Width

    }
    class DemoEnums
    {
        static void Main(string[]args)
        {
            var text = @"This program calculates the area of the following plane shapes
1. Circle
2. Square
3. Rectangle
Select an option : ";
            Console.Write(text);
            var opt = Convert.ToInt32(Console.ReadLine());
            switch(opt)
            {
                case 1:
                Console.Write("\nEnter the values for the following parameters of a circle:- \nRadius: ");
                AreaParameters.Radius = Convert.ToInt32(Console.ReadLine());
                var area = Math.PI*(AreaParameters.Radius*AreaParameters.Radius);
                Console.WriteLine($"Area = {area}");
                break;
            }
        }
        
    }
}