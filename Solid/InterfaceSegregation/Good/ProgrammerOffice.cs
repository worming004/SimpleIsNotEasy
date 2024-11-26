namespace InterfaceSegregation
{
    public class ProgrammerOffice
    {
        private IMegaPrinter printer;

        public ProgrammerOffice(IMegaPrinter printer)
        {
            this.printer = printer;
        }
    }
}
