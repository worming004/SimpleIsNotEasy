namespace InterfaceSegregation
{
    public class MegaOfficePrinter : IMegaPrinter
    {
        public void Print()
        {
            throw new System.NotImplementedException();
        }

        public byte[] Scan()
        {
            throw new System.NotImplementedException();
        }
    }

    public class ProgrammerOfficePrinter : IComposedPrinter
    {
        public void Print()
        {
            throw new System.NotImplementedException();
        }

        public byte[] Scan()
        {
            throw new System.NotImplementedException();
        }
    }

    public class PortableScanner : IScan
    {
        public byte[] Scan()
        {
            throw new System.NotImplementedException();
        }
    }

    public class CheapPrinter : IPrint
    {
        public void Print()
        {
            throw new System.NotImplementedException();
        }
    }
}