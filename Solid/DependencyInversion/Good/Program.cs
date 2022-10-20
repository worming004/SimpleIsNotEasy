using System.Data.SqlClient;

namespace DependencyInversion
{
    class Program
    {
        static void Main(string[] args)
        {
            var distantConnectionString = new SqlConnection("Data Source=powned.com\\MSSQLLocalDB;Initial Catalog=aspnet-MvcMovie;Integrated Security=SSPI;");
            var anySqlDatabase = new AnySqlConnectionRepository(distantConnectionString);
            anySqlDatabase.Save(new Person());
        }
    }
}
