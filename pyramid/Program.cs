using System;
using System.Linq;

namespace pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            var height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Enumerable.Range(2, height).Aggregate("*", (s, i) => s + Environment.NewLine + new string('*', i)));
        }
    }
}
