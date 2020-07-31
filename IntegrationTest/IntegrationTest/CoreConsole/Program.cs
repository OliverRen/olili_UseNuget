using System;

namespace CoreConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine(MyMath.Math.Plus(1, 2));
            Console.WriteLine(MyMath.Math.Minus(1, 2));
            Console.WriteLine(MyMath.Math.Multiply(1, 2));
            Console.WriteLine(MyMath.Math.Division(1, 2));
        }
    }
}
