namespace SingleResponsibility
{
    public class Writter : IWritter
    {
        public void Write(string text)
        {
            System.Console.WriteLine(text);
        }
    }
}
