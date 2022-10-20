namespace InterfaceSegregation
{
    public class Bag
    {
        public IScan scanner;
        public Bag(IScan scanner)
        {
            this.scanner = scanner;
        }
    }
}