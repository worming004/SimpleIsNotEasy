using System;

namespace SingleResponsibility
{
    public class AllTheLogic : IReadAndWrite
    {
        public void ReadAndWrite()
        {
            var input = Console.ReadLine();
            Console.WriteLine(input);
        }
    }
}
