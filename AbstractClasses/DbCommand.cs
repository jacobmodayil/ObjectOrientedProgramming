using System;

namespace AbstractClasses
{
    public class DbCommand
    {
        public DbConnection DbConnection { get; }
        public string Query { get; }

        public DbCommand(DbConnection dbConnection, string sql)
        {
            if(dbConnection == null || sql == String.Empty || sql == null)
                throw new ArgumentNullException(nameof(dbConnection));

            DbConnection = dbConnection;
            Query = sql;
        }

        public void Execute()
        {
            DbConnection.OpenConnection();
            RunQuery();
            DbConnection.CloseConnection();
        }

        private void RunQuery()
        {
            Console.WriteLine("Executing {0} aginst Db", Query);
        }
    }
}