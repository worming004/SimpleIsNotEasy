namespace SingleResponsibility
{
    public class Reader : IReader
    {
        public string Read()
        {
            return System.Console.ReadLine();
        }
    }
}
