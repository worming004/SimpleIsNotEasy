using System;
using System.Data.SqlClient;

namespace DependencyInversion
{
    class Program
    {
        static void Main(string[] args)
        {
            var localOnlyDb = new LocalOnlyRepository();

            var distantConnectionString = new SqlConnection("Data Source=powned.com\\MSSQLLocalDB;Initial Catalog=aspnet-MvcMovie;Integrated Security=SSPI;");
            var pownedComDb = new AnySqlConnectionRepository(distantConnectionString);
        }
    }
}
