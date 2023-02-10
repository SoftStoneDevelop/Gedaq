using Microsoft.Extensions.Configuration;
using Npgsql;
using System.IO;

namespace NpgsqlTests
{
    public abstract class BaseFixture
    {
        public IConfigurationRoot Settings
        {
            get
            {
                if(_root == null)
                {
                    var builder = new ConfigurationBuilder()
                        .SetBasePath(Directory.GetCurrentDirectory())
                        .AddJsonFile("testsettings.json", optional: false);

                    _root = builder.Build();
                }

                return _root;
            }
        }
        private IConfigurationRoot _root;

        public NpgsqlConnection GetOpenConnection() 
        {
            var connection = new NpgsqlConnection(Settings.GetConnectionString("SqlConnection"));
            connection.Open();
            if(connection.State != System.Data.ConnectionState.Open)
            {
                throw new System.Exception("Connection must be open");
            }

            return connection;
        }
    }
}