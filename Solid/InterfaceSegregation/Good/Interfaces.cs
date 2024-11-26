namespace InterfaceSegregation
{
    public interface IPrint
    {
        void Print();
    }
    public interface IScan
    {
        byte[] Scan();
    }
    public interface IMegaPrinter : IPrint, IScan { }
}
