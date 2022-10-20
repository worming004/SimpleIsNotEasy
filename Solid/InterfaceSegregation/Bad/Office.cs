namespace InterfaceSegregation
{
    public class Office
    {
        public IMegaPrinter megaPrinter;

        public Office(IMegaPrinter megaPrinter)
        {
            this.megaPrinter = megaPrinter;
        }
    }
}