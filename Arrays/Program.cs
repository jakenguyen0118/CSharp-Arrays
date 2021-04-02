using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // can use var instead of int[] to make it shorter
            var numbers = new int[3];
            numbers[0] = 1;

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);
            // integers are set to 0 as default

            var flags = new bool[3];
            flags[0] = true;

            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]);
            Console.WriteLine(flags[2]);
            // booleans are set to false as default

            var names = new string[3] { "Jack", "John", "Mary" };
        }
    }
}
