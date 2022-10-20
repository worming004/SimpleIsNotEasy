namespace InterfaceSegregation
{
    public class ProgrammerOffice
    {
        private IComposedPrinter printer;

        public ProgrammerOffice(IComposedPrinter printer)
        {
            this.printer = printer;
        }
    }
}