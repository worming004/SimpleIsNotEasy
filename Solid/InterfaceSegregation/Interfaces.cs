namespace InterfaceSegregation
{
    public interface IMegaPrinter
    {
        void Print();
        byte[] Scan();
    }

    // new with interface segregation
    public interface IPrint
    {
        void Print();
    }
    public interface IScan
    {
        byte[] Scan();
    }
    public interface IComposedPrinter : IPrint, IScan { }
}