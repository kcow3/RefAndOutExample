using System;

namespace RefAndOutExample
{
    class Program
    {
        public static void ThisIsRefAndOutInOneMethod(ref int left, ref int right, out int ans, out string test)
        {
            ans = left + right; // out
            left = 0;           // ref
            right = 0;          // ref

            // in order to use "out", value needs to be init before method ends
            test = "This is a test string passed using OUT";
        }

        static void Main(string[] args)
        {
            // in order to use "ref", value needs to be init first
            int l = 1;
            int r = 2;

            Console.WriteLine($"{l} {r}");

            ThisIsRefAndOutInOneMethod(ref l, ref r, out var res, out var test);

            Console.WriteLine($"{l} {r} {res} {test}");

            Console.WriteLine();
        }
    }
}
