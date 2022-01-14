using System;
using MyUtilities;

namespace MyFirstProgramb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var res= MyUtilities.WeatherUtilities.FahrenheitToCelsius(1f);
            Console.WriteLine(res);
        }
    }
}
