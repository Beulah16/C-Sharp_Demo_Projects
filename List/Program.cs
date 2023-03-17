using System;
using System.Collections.Generic;
class List
{
    static void Main(string[]args)
    {
        var states = new List<string>();
        states.Add(Console.ReadLine());
        states.Add("Enugu");
        states.Add("Lagos");
        states.Add("Abuja");
        states.Add("Ebonyi");
        foreach (var state in states)
        {
            Console.WriteLine(state);
        }
    }
}