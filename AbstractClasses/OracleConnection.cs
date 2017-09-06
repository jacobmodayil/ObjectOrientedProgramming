using System;

namespace AbstractClasses
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString) : base(connectionString)
        {
        }

        public override void OpenConnection()
        {
            Console.WriteLine("Oracle Connection opened with connection string - " + ConnectionString);
        }

        public override void CloseConnection()
        {
            Console.WriteLine("Oracle Connection closed");
        }
    }
}