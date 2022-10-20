using System;

namespace InterfaceSegregation
{
    class Program
    {
        static void Main(string[] args)
        {
            var portableScanner = new PortableScanner();
            var cheapPrinter = new CheapPrinter();
            var composedPrinter = new PrinterCompose(cheapPrinter, portableScanner);

            var programmerOffice = new ProgrammerOffice(composedPrinter);
            var bag = new Bag(portableScanner);
            var bigBag = new Bag(composedPrinter);
        }
    }
}
