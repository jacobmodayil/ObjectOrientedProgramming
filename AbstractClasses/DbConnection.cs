using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; }

        public DbConnection(string connectionString)
        {
            if(connectionString == null || connectionString.Equals(string.Empty))
                throw new ArgumentNullException(nameof(connectionString));
            ConnectionString = connectionString;
        }

        public abstract void OpenConnection();
        public abstract void CloseConnection();
    }
}
