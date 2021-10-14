using System.Data.SqlClient;

namespace DependencyInversion
{
    public class AnySqlConnectionRepository
    {

        private SqlConnection connection;

        public AnySqlConnectionRepository(SqlConnection connection)
        {
            this.connection = connection;
        }

        public void Save(Person p)
        {
            // save
        }
    }
}