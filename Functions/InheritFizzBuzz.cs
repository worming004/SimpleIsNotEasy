namespace Functions
{
    public class InheritFizzBuzz : FizzBuzzDivided, IPrintFizzBuzz
    {
        protected override void writeInConsole(string text)
        {
            /// écrire dans un fichier
        }
    }
}