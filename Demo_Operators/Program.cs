using System;

namespace Demo_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            //var a = 1;
            //var b = 2;
            //var c = 3;

            //console.writeline((a + b) * c);

            var a = 1;
            var b = 2;
            var c = 3;

            Console.WriteLine(a == b);
            Console.WriteLine(a != b);
            Console.WriteLine(c > a && c > b);
            Console.WriteLine(c > a || c > b);
            Console.WriteLine(!(c > a || c > b));
        }
    }
}
