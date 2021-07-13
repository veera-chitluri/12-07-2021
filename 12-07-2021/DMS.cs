using System;

namespace DMS
{
    class Program
    {
        private static int decdeg;
        private static object seconds;

        static void Main(string[] args)
        {
            Console.WriteLine("Enter tht decimal degree");
            var degree = double.Parse(Console.ReadLine());
            double min = (decdeg - Math.Truncate(decdeg)) * 60;

            double sec = (min - Math.Truncate(min)) * 60;
            
            Console.WriteLine($"the decimal degree of entred decimal = {degree}\00B0 {min}\' {sec}");


        }
    }
}
