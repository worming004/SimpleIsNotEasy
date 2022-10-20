namespace DependencyInversion
{
    class Program
    {
        static void Main(string[] args)
        {
            var localOnlyDb = new LocalOnlyRepository();
            localOnlyDb.Save(new Person());
        }
    }
}
