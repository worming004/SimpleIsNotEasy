using System;

namespace InterfaceSegregation
{
    class Program
    {
        static void Main(string[] args)
        {
            var megaPrinter = new MegaOfficePrinter();
            var portableScanner = new PortableScanner();
            var cheapPrinter = new CheapPrinter();
            var composedPrinter = new ProgrammerOfficePrinter();

            var office = new Office(megaPrinter);
            var programmerOffice = new ProgrammerOffice(composedPrinter);
            var bag = new Bag(portableScanner);
            var bigBag = new Bag(composedPrinter);
        }
    }
}
