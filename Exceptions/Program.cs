using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var arg in args)
            {
                try
                {
                    var argAsInt = int.Parse(arg);
                    System.Console.WriteLine(argAsInt % 3);

                    // bad solution
                    // int argAsInt2;
                    // if(int.TryParse(arg, out argAsInt2))
                    // {
                    //     System.Console.WriteLine(argAsInt % 3);
                    // }
                    // else
                    // {
                    //     Console.WriteLine($"Unhandled exception for {arg}");
                    // }
                }
                catch(FormatException)
                {
                    Console.WriteLine($"value {arg} is not a number");
                }
                catch(Exception)
                {
                    Console.WriteLine($"Unhandled exception for {arg}");
                }
            }
        }
    }
}
