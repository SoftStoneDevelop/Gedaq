using DbConnectionTests.Helpers;
using DotNet.Testcontainers.Builders;
using Microsoft.Data.SqlClient;
using NUnit.Framework;
using System;
using System.Data.Common;
using System.Threading.Tasks;
using Testcontainers.MsSql;

namespace DbConnectionTests.MsSql
{
    [SetUpFixture]
    public class GlobalSetUp
    {
        public static SqlConnection GetConnection
        {
            get
            {
                var connection = (SqlConnection)SqlClientFactory.Instance.CreateConnection();
                connection.ConnectionString = _connectionString;
                return connection;
            }
        }

        public static DbConnection GetDbConnection => GetConnection;

        private MsSqlContainer _mssql;
        private static string _connectionString;

        [OneTimeSetUp]
        public async Task OneTimeSetUp()
        {
            _mssql =
                new MsSqlBuilder("mcr.microsoft.com/mssql/server:2025-CU4-ubuntu-22.04")
                .WithPortBinding(1433, true)
                .WithAutoRemove(true)
                .WithWaitStrategy(Wait.ForUnixContainer().UntilExternalTcpPortIsAvailable(1433))
                .Build();

            await _mssql.StartAsync();
            await _mssql.WaitContainerStateRunningAsync(TimeSpan.FromMinutes(1));
            await _mssql.WaitResponseAsync(TimeSpan.FromMinutes(1));

            var builder = new SqlConnectionStringBuilder(_mssql.GetConnectionString());
            builder.Encrypt = false;
            builder.TrustServerCertificate = false;
            builder.IntegratedSecurity = false;

            await using (var masterConnection = (SqlConnection)SqlClientFactory.Instance.CreateConnection())
            {
                masterConnection.ConnectionString = builder.ConnectionString;
                await masterConnection.OpenAsync();

                await using var createCmd = masterConnection.CreateCommand();
                createCmd.CommandText = $@"
IF NOT EXISTS (
   SELECT name
   FROM sys.databases
   WHERE name = N'gedaqtests'
)
CREATE DATABASE gedaqtests
;
";
                createCmd.ExecuteNonQuery();
            }

            builder = new SqlConnectionStringBuilder(_mssql.GetConnectionString());
            builder.Encrypt = false;
            builder.TrustServerCertificate = false;
            builder.IntegratedSecurity = false;
            builder.InitialCatalog = "gedaqtests";
            _connectionString = builder.ConnectionString;

            await using var connection = OpenConnection();
            await using var cmd = connection.CreateCommand();

            CreateCountryTable(cmd);
            Fill—ountries(cmd);

            CreateIdentificationTable(cmd);
            FillIdentification(cmd);

            CreatePersonTable(cmd);
            FillPerson(cmd);
        }

        public static SqlConnection OpenConnection()
        {
            var conn = GlobalSetUp.GetConnection;
            conn.Open();
            return (SqlConnection)conn;
        }

        [OneTimeTearDown]
        public async Task OneTimeTearDown()
        {
            if (_mssql != null)
            {
                await _mssql.DisposeAsync();
            }
        }

        private void CreatePersonTable(SqlCommand cmd)
        {
            cmd.Parameters.Clear();
            cmd.CommandText = @"
CREATE TABLE [dbo].[person](
	[id] [int] NOT NULL,
	[firstname] [text] NULL,
	[middlename] [text] NULL,
	[lastname] [text] NULL,
	[identification_id] [int] NULL,
 CONSTRAINT [PK_person] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
;

ALTER TABLE [dbo].[person]  WITH CHECK ADD  CONSTRAINT [identification_fk] FOREIGN KEY([identification_id])
REFERENCES [dbo].[identification] ([id])
;

ALTER TABLE [dbo].[person] CHECK CONSTRAINT [identification_fk]
;
";
            cmd.ExecuteNonQuery();
        }

        private void FillPerson(SqlCommand cmd)
        {
            cmd.Parameters.Clear();
            cmd.CommandText = @"
INSERT INTO person(
	id, firstname, middlename, lastname, identification_id)
	VALUES (
    @id, @firstname, @middlename, @lastname, @identification_id
);
";
            var id = new SqlParameter();
            id.SqlDbType = System.Data.SqlDbType.Int;
            id.ParameterName = "id";
            cmd.Parameters.Add(id);

            var firstname = new SqlParameter();
            firstname.SqlDbType = System.Data.SqlDbType.Text;
            firstname.Size = 4000;
            firstname.IsNullable = true;
            firstname.ParameterName = "firstname";
            cmd.Parameters.Add(firstname);

            var middlename = new SqlParameter();
            middlename.SqlDbType = System.Data.SqlDbType.Text;
            middlename.Size = 4000;
            middlename.IsNullable = true;
            middlename.ParameterName = "middlename";
            cmd.Parameters.Add(middlename);

            var lastname = new SqlParameter();
            lastname.SqlDbType = System.Data.SqlDbType.Text;
            lastname.Size = 4000;
            lastname.IsNullable = true;
            lastname.ParameterName = "lastname";
            cmd.Parameters.Add(lastname);

            var identificationId = new SqlParameter();
            identificationId.SqlDbType = System.Data.SqlDbType.Int;
            identificationId.ParameterName = "identification_id";
            identificationId.IsNullable = true;
            cmd.Parameters.Add(identificationId);
            cmd.Prepare();

            for (int i = 0; i < 10; i++)
            {
                id.Value = i;
                if (i > 0 && i < 6)
                {
                    firstname.Value = $"John{i}";
                    middlename.Value = $"Curly{i}";
                    lastname.Value = $"Doe{i}";
                    identificationId.Value = i;
                }
                else
                {
                    firstname.Value = DBNull.Value;
                    middlename.Value = DBNull.Value;
                    lastname.Value = DBNull.Value;
                    identificationId.Value = DBNull.Value;
                }

                cmd.ExecuteNonQuery();
            }
        }

        private void CreateCountryTable(SqlCommand cmd)
        {
            cmd.Parameters.Clear();
            cmd.CommandText = @"
CREATE TABLE [dbo].[country](
	[id] [int] NOT NULL,
	[name] [text] NOT NULL,
 CONSTRAINT [PK_country] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
;
";
            cmd.ExecuteNonQuery();
        }

        private void Fill—ountries(SqlCommand cmd)
        {
            cmd.Parameters.Clear();
            cmd.CommandText = @"
INSERT INTO country(
	id, name)
	VALUES (
    @id, @name
);
";
            var id = new SqlParameter();
            id.SqlDbType = System.Data.SqlDbType.Int;
            id.ParameterName = "id";
            cmd.Parameters.Add(id);

            var name = new SqlParameter();
            name.SqlDbType = System.Data.SqlDbType.Text;
            name.ParameterName = "name";
            name.Size = 4000;
            cmd.Parameters.Add(name);
            cmd.Prepare();

            id.Value = 1;
            name.Value = "Russia";
            cmd.ExecuteNonQuery();

            id.Value = 2;
            name.Value = "China";
            cmd.ExecuteNonQuery();

            id.Value = 3;
            name.Value = "Serbia";
            cmd.ExecuteNonQuery();

            id.Value = 4;
            name.Value = "Belarus";
            cmd.ExecuteNonQuery();

            id.Value = 5;
            name.Value = "Martian colony";
            cmd.ExecuteNonQuery();
        }

        private void CreateIdentificationTable(SqlCommand cmd)
        {
            cmd.Parameters.Clear();
            cmd.CommandText = @"
CREATE TABLE [dbo].[identification](
	[id] [int] NOT NULL,
	[typename] [text] NOT NULL,
	[country_id] [int] NULL,
 CONSTRAINT [PK_identification] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
;

ALTER TABLE [dbo].[identification]  WITH CHECK ADD  CONSTRAINT [country_fk] FOREIGN KEY([country_id])
REFERENCES [dbo].[country] ([id])
;

ALTER TABLE [dbo].[identification] CHECK CONSTRAINT [country_fk]
;
";
            cmd.ExecuteNonQuery();
        }

        private void FillIdentification(SqlCommand cmd)
        {
            cmd.Parameters.Clear();
            cmd.CommandText = @"
INSERT INTO identification(
	id, typename, country_id)
	VALUES (
    @id, @typename, @country_id
);
";
            var id = new SqlParameter();
            id.SqlDbType = System.Data.SqlDbType.Int;
            id.ParameterName = "id";
            cmd.Parameters.Add(id);

            var typename = new SqlParameter();
            typename.SqlDbType = System.Data.SqlDbType.Text;
            typename.Size = 4000;
            typename.ParameterName = "typename";
            cmd.Parameters.Add(typename);

            var countryId = new SqlParameter();
            countryId.SqlDbType = System.Data.SqlDbType.Int;
            countryId.ParameterName = "country_id";
            countryId.IsNullable = true;
            cmd.Parameters.Add(countryId);
            cmd.Prepare();

            id.Value = 1;
            typename.Value = "sailor's passport";
            countryId.Value = 1;
            cmd.ExecuteNonQuery();

            id.Value = 2;
            typename.Value = "officer's certificate";
            countryId.Value = 2;
            cmd.ExecuteNonQuery();

            id.Value = 3;
            typename.Value = "driver license";
            countryId.Value = 3;
            cmd.ExecuteNonQuery();

            id.Value = 4;
            typename.Value = "citizen's passport";
            countryId.Value = DBNull.Value;
            cmd.ExecuteNonQuery();

            id.Value = 5;
            typename.Value = "party card";
            countryId.Value = 5;
            cmd.ExecuteNonQuery();
        }
    }
}