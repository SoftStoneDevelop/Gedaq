using Microsoft.Extensions.Configuration;
using Npgsql;
using NpgsqlTests.Helpers;
using NUnit.Framework;
using System;

namespace NpgsqlTests
{
    [TestFixture]
    internal partial class ReadFixture : BaseFixture
    {
        #region Init and destroy

        protected NpgsqlDataSource _dataSource;

        [SetUp]
        public void Init()
        {
            var dataSourceBuilder = new NpgsqlDataSourceBuilder(Settings.GetConnectionString("SqlConnection"));
            _dataSource = dataSourceBuilder.Build();
            var conn = _dataSource.OpenConnection();
            conn.DropTable("readfixtureperson");
            conn.DropTable("readfixtureidentification");
            conn.DropTable("readfixturecountry");

            using var cmd = conn.CreateCommand();
            DropFunction(cmd);

            CreateCountryTable(cmd);
            FillСountries(cmd);

            CreateIdentificationTable(cmd);
            FillIdentification(cmd);

            CreatePersonTable(cmd);
            FillPerson(cmd);

            CreateFunction(cmd);
        }

        private void CreateCountryTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE IF NOT EXISTS public.readfixturecountry
(
    id integer NOT NULL,
    name text COLLATE pg_catalog.""default"" NOT NULL,
    CONSTRAINT readfixturecountry_pkey PRIMARY KEY (id)
);
";
            cmd.ExecuteNonQuery();
        }

        private void CreateIdentificationTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE IF NOT EXISTS public.readfixtureidentification
(
    id integer NOT NULL,
    typename text COLLATE pg_catalog.""default"" NOT NULL,
    readfixturecountry_id integer,
    CONSTRAINT readfixtureidentification_pkey PRIMARY KEY (id),
    CONSTRAINT readfixturecountry_fk FOREIGN KEY (readfixturecountry_id)
        REFERENCES public.readfixturecountry (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            cmd.ExecuteNonQuery();
        }

        private void CreatePersonTable(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE TABLE IF NOT EXISTS public.readfixtureperson
(
    id integer NOT NULL,
    firstname text COLLATE pg_catalog.""default"" NOT NULL,
    middlename text COLLATE pg_catalog.""default"",
    lastname text COLLATE pg_catalog.""default"",
    readfixtureidentification_id integer,
    CONSTRAINT readfixtureperson_pkey PRIMARY KEY (id),
    CONSTRAINT readfixtureidentification_fk FOREIGN KEY (readfixtureidentification_id)
        REFERENCES public.readfixtureidentification (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
";
            cmd.ExecuteNonQuery();
        }

        private void FillPerson(NpgsqlCommand cmd)
        {
            cmd.Parameters.Clear();
            cmd.CommandText = @"
INSERT INTO public.readfixtureperson(
	id, firstname, middlename, lastname, readfixtureidentification_id)
	VALUES (
    $1, $2, $3, $4, $5
);
";
            var id = new NpgsqlParameter<int>();
            id.NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Integer;
            cmd.Parameters.Add(id);

            var firstname = new NpgsqlParameter<string>();
            firstname.NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Text;
            cmd.Parameters.Add(firstname);

            var middlename = new NpgsqlParameter<string>();
            middlename.NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Text;
            cmd.Parameters.Add(middlename);

            var lastname = new NpgsqlParameter<string>();
            lastname.NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Text;
            cmd.Parameters.Add(lastname);

            var identificationId = new NpgsqlParameter();
            identificationId.NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Integer;
            identificationId.IsNullable = true;
            cmd.Parameters.Add(identificationId);
            cmd.Prepare();

            for (int i = 0; i < 10; i++)
            {
                id.Value = i;
                firstname.Value = $"John{i}";
                middlename.Value = $"Сurly{i}";
                lastname.Value = $"Doe{i}";
                if (i > 0 && i < 6)
                {
                    identificationId.Value = i;
                }
                else
                {
                    identificationId.Value = DBNull.Value;
                }

                cmd.ExecuteNonQuery();
            }
        }

        private void FillСountries(NpgsqlCommand cmd)
        {
            cmd.Parameters.Clear();
            cmd.CommandText = @"
INSERT INTO public.readfixturecountry(
	id, name)
	VALUES (
    $1, $2
);
";
            var id = new NpgsqlParameter<int>();
            id.NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Integer;
            cmd.Parameters.Add(id);

            var typename = new NpgsqlParameter<string>();
            typename.NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Text;
            cmd.Parameters.Add(typename);
            cmd.Prepare();

            id.TypedValue = 1;
            typename.TypedValue = "Russia";
            cmd.ExecuteNonQuery();

            id.TypedValue = 2;
            typename.TypedValue = "China";
            cmd.ExecuteNonQuery();

            id.TypedValue = 3;
            typename.TypedValue = "Serbia";
            cmd.ExecuteNonQuery();

            id.TypedValue = 4;
            typename.TypedValue = "Belarus";
            cmd.ExecuteNonQuery();

            id.TypedValue = 5;
            typename.TypedValue = "Martian colony";
            cmd.ExecuteNonQuery();
        }

        private void FillIdentification(NpgsqlCommand cmd)
        {
            cmd.Parameters.Clear();
            cmd.CommandText = @"
INSERT INTO public.readfixtureidentification(
	id, typename, readfixturecountry_id)
	VALUES (
    $1, $2, $3
);
";
            var id = new NpgsqlParameter<int>();
            id.NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Integer;
            cmd.Parameters.Add(id);

            var typename = new NpgsqlParameter<string>();
            typename.NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Text;
            cmd.Parameters.Add(typename);

            var countryId = new NpgsqlParameter();
            countryId.NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Integer;
            countryId.IsNullable = true;
            cmd.Parameters.Add(countryId);
            cmd.Prepare();

            id.TypedValue = 1;
            typename.TypedValue = "sailor's passport";
            countryId.Value = 1;
            cmd.ExecuteNonQuery();

            id.TypedValue = 2;
            typename.TypedValue = "officer's certificate";
            countryId.Value = 2;
            cmd.ExecuteNonQuery();

            id.TypedValue = 3;
            typename.TypedValue = "driver license";
            countryId.Value = 3;
            cmd.ExecuteNonQuery();

            id.TypedValue = 4;
            typename.TypedValue = "citizen's passport";
            countryId.Value = DBNull.Value;
            cmd.ExecuteNonQuery();

            id.TypedValue = 5;
            typename.TypedValue = "party card";
            countryId.Value = 5;
            cmd.ExecuteNonQuery();
        }

        private void CreateFunction(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
CREATE FUNCTION readfixturefunc(in int, out out1 int, out out2 text)
    AS $$ SELECT $1, CAST($1 AS text) || ' is text' $$
    LANGUAGE SQL;
";
            cmd.ExecuteNonQuery();
        }

        private void DropFunction(NpgsqlCommand cmd)
        {
            cmd.CommandText = @"
DROP FUNCTION IF EXISTS readfixturefunc(in INT, out int, out text);
";
            cmd.ExecuteNonQuery();
        }

        [TearDown]
        public void Cleanup()
        {
            using (var connection = _dataSource.OpenConnection())
            {
                using var cmd = connection.CreateCommand();
                DropFunction(cmd);

                connection.DropTable("readfixtureperson");
                connection.DropTable("readfixtureidentification");
                connection.DropTable("readfixturecountry");
            }
            _dataSource?.Dispose();
        }

        #endregion
    }
}
