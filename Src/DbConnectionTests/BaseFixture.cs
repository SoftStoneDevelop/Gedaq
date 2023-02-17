using Microsoft.Extensions.Configuration;
using System.IO;

namespace DbConnectionTests
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

        public string GetNpgsqlSqlConnectionString()
        {
            return Settings.GetConnectionString("NpgsqlSqlConnection");
        }
    }
}