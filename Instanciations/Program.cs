using System;
namespace ClassesXObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            var Ops1 = new Feet();
            Ops1.num = Convert.ToSingle(Console.ReadLine());
            Ops1.Meter(Ops1.num);
            var Ops2 =new Celsius();
            Ops2.num = Convert.ToSingle(Console.ReadLine());
            Ops2.Farenheit(Ops2.num);
            var Ops3 =new Farenheit();
            Ops3.num = Convert.ToSingle(Console.ReadLine());
            Ops3.Celcius(Ops3.num);

        }
    }
}