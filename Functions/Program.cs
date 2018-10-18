using System;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            IPrintFizzBuzz fizzBuzz = new FizzBuzzDivided();
            fizzBuzz.Execute();
        }
    }
}
