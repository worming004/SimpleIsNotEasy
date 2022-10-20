using System.Data.SqlClient;

namespace DependencyInversion
{
    public class LocalOnlyRepository
    {
        private const string connectionString = "Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=aspnet-MvcMovie;Integrated Security=SSPI;";
        private SqlConnection conn = new SqlConnection(connectionString);

        public void Save(Person p)
        {
            // save
        }
    }
}