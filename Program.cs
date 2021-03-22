using System;

namespace _01._Convert_Meters_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal pound = decimal.Parse(Console.ReadLine());

            decimal dolars = pound*1.31m;
            Console.WriteLine($"{dolars:f3}");
        }
    }
}
