using System;

namespace AbstractClasses
{
    public class SqlConnection : DbConnection
    {

        public SqlConnection(string connectionString) : base(connectionString)
        {

        }

        public override void OpenConnection()
        {
            Console.WriteLine("Sql Connection opened with connection string - " + ConnectionString);
        }

        public override void CloseConnection()
        {
            Console.WriteLine("Sql Connection closed");
        }
    }
}