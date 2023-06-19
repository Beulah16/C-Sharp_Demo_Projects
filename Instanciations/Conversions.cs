namespace ClassesXObjects
{
    public class Feet
    {
        public Feet()
        {
            Console.WriteLine("Input a unit in feets");
        }
        public float num;
        public void Meter(float num)
        {
            var meter = 0.3048;
            var conv = num * meter;
            Console.WriteLine($"Value in meters = {conv}m");
        }
    }
    public class Celsius
    {
        public Celsius()
        {
            Console.WriteLine("\nInput a unit in celsius");
        }
        public float num;
        public void Farenheit(float num)
        {
            var conv = (num * 1.8) + 32;
            Console.WriteLine($"Value in fahrenheit = {conv}F");
        }
    }
    public class Farenheit
    {
        public Farenheit()
        {
            Console.WriteLine("\nInput a unit in farenheits");
        }
        public float num;
        public void Celcius(float num)
        {
            var conv = (num - 32) * 1.8;
            Console.WriteLine($"Value in celcius = {conv}C");
        }
    }
}
