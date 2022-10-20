namespace InterfaceSegregation
{
    public class PrinterCompose : IComposedPrinter
    {
        private IPrint _printer;
        private IScan _scanner;

        public PrinterCompose(IPrint printer, IScan scanner)
        {
            _printer = printer;
            _scanner = scanner;
        }

        public void Print()
        {
            // Print
        }

        public byte[] Scan()
        {
            // Scan
            return new byte[]{};
        }
    }

    public class CheapPrinter : IPrint
    {
        public void Print()
        {
            // Print
        }
    }

    public class PortableScanner : IScan
    {
        public byte[] Scan()
        {
            // Scan
            return new byte[]{};
        }
    }
}