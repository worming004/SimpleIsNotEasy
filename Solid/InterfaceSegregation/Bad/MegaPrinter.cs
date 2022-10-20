namespace InterfaceSegregation
{
    public class MegaOfficePrinter : IMegaPrinter
    {
        public void Print()
        {
            // Print
        }

        public byte[] Scan()
        {
            // Scan
            return new byte[] {};
        }
    }
}