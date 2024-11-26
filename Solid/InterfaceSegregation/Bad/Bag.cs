namespace InterfaceSegregation
{
    public class Bag
    {
        public IMegaPrinter scanner;

        public Bag(IMegaPrinter scanner)
        {
            this.scanner = scanner;
        }
    }
}
