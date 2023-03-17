using System;

namespace BitsandBytesI
{
    class Binary
    {
        static void Main(string[]args)
        {
            var v = 10;
            var x = 8;
            Write(v + x);
        }

        static void Write(int value)
        {
            Console.WriteLine($"{Convert.ToString(value, 2).PadLeft(8, '0')}");
        }
    }
}