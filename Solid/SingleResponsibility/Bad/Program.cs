using System;

namespace SingleResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            var allLogic = new AllTheLogic();
            allLogic.ReadAndWrite();
        }
    }
}
