using System.IO;
using System.Text;
using System.Threading.Tasks;
using TestsGenerator.Enums;
using TestsGenerator.Helpers;

namespace TestsGenerator.Generators
{
    internal class TestOneTimePart
    {
        private readonly StringBuilder _stringBuilder = new StringBuilder();

        public async Task Generate(Model.ModelType model, Database database, string destinationFolder)
        {
            _stringBuilder.Clear();
            Start(model, database);

            CreateModelInnerTable(model, database);
            DropModelInnerTable(model, database);

            CreateModelTable(model, database);
            DropModelTable(model, database);

            OneTimeSetUp();
            OneTimeTearDown();

            End();

            Directory.CreateDirectory($"{destinationFolder}/TestOneTimeParts/");
            await File.WriteAllTextAsync($"{destinationFolder}/TestOneTimeParts/{model.ClassName}TestOneTimePart.cs", _stringBuilder.ToString());
        }

        private void Start(Model.ModelType model, Database database)
        {
            _stringBuilder.AppendLine($@"
{database.ToUsings()}

using NUnit.Framework;
using System.Data.Common;
using System.Threading.Tasks;

namespace Tests
{{
    [TestFixture]
    [Parallelizable(ParallelScope.Self)]
    internal partial class Tests_{model.TypeInfo.TypeName}_{model.TypeInfo.DbSqlTypeWithoutSpace()}
    {{
");
        }

        private void End()
        {
            _stringBuilder.AppendLine($@"
    }}
}}
");
        }

        private void CreateModelInnerTable(Model.ModelType model, Database database)
        {
            switch (database)
            {
                case Database.PostgreSQL:
                {
                    _stringBuilder.AppendLine($@"
        private async Task CreateModelInnerTable(NpgsqlCommand cmd)
        {{
            cmd.CommandText = @""
CREATE TABLE {Database.PostgreSQL.ToDefaultSchema()}.{model.ModelInner.TableName}
(
    {model.ModelInner.IdColumnName} {model.ModelInner.IdTypeInfo.DbSqlType}{model.ModelInner.IdTypeInfo.DbSqlAfterType()} NOT NULL,
    {model.ModelInner.ValueColumnName} {model.ModelInner.TypeInfo.DbSqlType}{model.ModelInner.TypeInfo.DbSqlAfterType()} NOT NULL,
    {model.ModelInner.NullableValueColumnName} {model.ModelInner.TypeInfo.DbSqlType}{model.ModelInner.TypeInfo.DbSqlAfterType()},
    CONSTRAINT {model.ModelInner.TableName}_pkey PRIMARY KEY (id)
);
"";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @""
CREATE TABLE {Database.PostgreSQL.ToDefaultSchema()}.binary_{model.ModelInner.TableName}
(
    {model.ModelInner.IdColumnName} {model.ModelInner.IdTypeInfo.DbSqlType}{model.ModelInner.IdTypeInfo.DbSqlAfterType()} NOT NULL,
    {model.ModelInner.ValueColumnName} {model.ModelInner.TypeInfo.DbSqlType}{model.ModelInner.TypeInfo.DbSqlAfterType()} NOT NULL,
    {model.ModelInner.NullableValueColumnName} {model.ModelInner.TypeInfo.DbSqlType}{model.ModelInner.TypeInfo.DbSqlAfterType()},
    CONSTRAINT binary_{model.ModelInner.TableName}_pkey PRIMARY KEY (id)
);
"";
            await cmd.ExecuteNonQueryAsync();
        }}
");
                    return;
                }
                case Database.MsSQL:
                {
                    _stringBuilder.AppendLine($@"
        private async Task CreateModelInnerTable(SqlCommand cmd)
        {{
            cmd.CommandText = @""
CREATE TABLE {Database.MsSQL.ToDefaultSchema()}.{model.ModelInner.TableName}(
	{model.ModelInner.IdColumnName} {model.ModelInner.IdTypeInfo.DbSqlType}{model.ModelInner.IdTypeInfo.DbSqlAfterType()} NOT NULL,
	{model.ModelInner.ValueColumnName} {model.ModelInner.TypeInfo.DbSqlType}{model.ModelInner.TypeInfo.DbSqlAfterType()} NOT NULL,
	{model.ModelInner.NullableValueColumnName} {model.ModelInner.TypeInfo.DbSqlType}{model.ModelInner.TypeInfo.DbSqlAfterType()} NULL,
    CONSTRAINT PK_{model.ModelInner.TableName} PRIMARY KEY NONCLUSTERED ({model.ModelInner.IdColumnName})
)
"";
            await cmd.ExecuteNonQueryAsync();
        }}
");
                    return;
                }
                case Database.MySQL:
                {
                    _stringBuilder.AppendLine($@"
        private async Task CreateModelInnerTable(MySqlCommand cmd)
        {{
            cmd.CommandText = @""
CREATE TABLE {Database.MySQL.ToDefaultSchema()}.{model.ModelInner.TableName} (
    {model.ModelInner.IdColumnName} {model.ModelInner.IdTypeInfo.DbSqlType}{model.ModelInner.IdTypeInfo.DbSqlAfterType()}  NOT NULL,
    {model.ModelInner.ValueColumnName} {model.ModelInner.TypeInfo.DbSqlType}{model.ModelInner.TypeInfo.DbSqlAfterType()} NOT NULL,
	{model.ModelInner.NullableValueColumnName} {model.ModelInner.TypeInfo.DbSqlType}{model.ModelInner.TypeInfo.DbSqlAfterType()} NULL,
    PRIMARY KEY ({model.ModelInner.IdColumnName})
);
"";
            await cmd.ExecuteNonQueryAsync();
        }}
");
                    return;
                }
            }
        }

        private void DropModelInnerTable(Model.ModelType model, Database database)
        {
            switch (database)
            {
                case Database.PostgreSQL:
                {
                    _stringBuilder.AppendLine($@"
        private async Task DropModelInnerTable(NpgsqlCommand cmd)
        {{
            cmd.CommandText = @""
DROP TABLE {Database.PostgreSQL.ToDefaultSchema()}.{model.ModelInner.TableName};
"";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @""
DROP TABLE {Database.PostgreSQL.ToDefaultSchema()}.binary_{model.ModelInner.TableName};
"";
            await cmd.ExecuteNonQueryAsync();
        }}
");
                    return;
                }
                case Database.MsSQL:
                {
                    _stringBuilder.AppendLine($@"
        private async Task DropModelInnerTable(SqlCommand cmd)
        {{
            cmd.CommandText = @""
DROP TABLE {Database.MsSQL.ToDefaultSchema()}.{model.ModelInner.TableName}
"";
            await cmd.ExecuteNonQueryAsync();
        }}
");
                    return;
                }
                case Database.MySQL:
                {
                    _stringBuilder.AppendLine($@"
        private async Task DropModelInnerTable(MySqlCommand cmd)
        {{
            cmd.CommandText = @""
DROP TABLE IF EXISTS {Database.MySQL.ToDefaultSchema()}.{model.ModelInner.TableName}
"";
            await cmd.ExecuteNonQueryAsync();
        }}
");
                    return;
                }
            }
        }

        private void CreateModelTable(Model.ModelType model, Database database)
        {
            switch (database)
            {
                case Database.PostgreSQL:
                {
                    _stringBuilder.AppendLine($@"
        private async Task CreateModelTable(NpgsqlCommand cmd)
        {{
            cmd.CommandText = @""
CREATE TABLE {Database.PostgreSQL.ToDefaultSchema()}.{model.TableName}
(
    {model.IdColumnName} {model.IdTypeInfo.DbSqlType}{model.IdTypeInfo.DbSqlAfterType()} NOT NULL,
    {model.ValueColumnName} {model.TypeInfo.DbSqlType}{model.TypeInfo.DbSqlAfterType()} NOT NULL,
    {model.NullableValueColumnName} {model.TypeInfo.DbSqlType}{model.TypeInfo.DbSqlAfterType()},
    {model.ModelInnerColumnName} {model.ModelInner.IdTypeInfo.DbSqlType}{model.ModelInner.IdTypeInfo.DbSqlAfterType()},
    CONSTRAINT {model.TableName}_pkey PRIMARY KEY ({model.IdColumnName}),
    CONSTRAINT {model.TableName}_{model.ModelInner.TableName}_fk FOREIGN KEY ({model.ModelInnerColumnName})
        REFERENCES {Database.PostgreSQL.ToDefaultSchema()}.{model.ModelInner.TableName} ({model.ModelInner.IdColumnName}) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
"";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @""
CREATE TABLE {Database.PostgreSQL.ToDefaultSchema()}.binary_{model.TableName}
(
    {model.IdColumnName} {model.IdTypeInfo.DbSqlType}{model.IdTypeInfo.DbSqlAfterType()} NOT NULL,
    {model.ValueColumnName} {model.TypeInfo.DbSqlType}{model.TypeInfo.DbSqlAfterType()} NOT NULL,
    {model.NullableValueColumnName} {model.TypeInfo.DbSqlType}{model.TypeInfo.DbSqlAfterType()},
    {model.ModelInnerColumnName} {model.ModelInner.IdTypeInfo.DbSqlType}{model.ModelInner.IdTypeInfo.DbSqlAfterType()},
    CONSTRAINT binary_{model.TableName}_pkey PRIMARY KEY ({model.IdColumnName}),
    CONSTRAINT binary_{model.TableName}_{model.ModelInner.TableName}_fk FOREIGN KEY ({model.ModelInnerColumnName})
        REFERENCES {Database.PostgreSQL.ToDefaultSchema()}.binary_{model.ModelInner.TableName} ({model.ModelInner.IdColumnName}) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
"";
            await cmd.ExecuteNonQueryAsync();
        }}
");
                    return;
                }
                case Database.MsSQL:
                {
                    _stringBuilder.AppendLine($@"
        private async Task CreateModelTable(SqlCommand cmd)
        {{
            cmd.CommandText = @""
CREATE TABLE {Database.MsSQL.ToDefaultSchema()}.{model.TableName}(
	{model.IdColumnName} {model.IdTypeInfo.DbSqlType}{model.IdTypeInfo.DbSqlAfterType()} NOT NULL,
	{model.ValueColumnName} {model.TypeInfo.DbSqlType}{model.TypeInfo.DbSqlAfterType()} NOT NULL,
    {model.NullableValueColumnName} {model.TypeInfo.DbSqlType}{model.TypeInfo.DbSqlAfterType()} NULL,
	{model.ModelInnerColumnName} {model.ModelInner.IdTypeInfo.DbSqlType}{model.ModelInner.IdTypeInfo.DbSqlAfterType()} NULL,
    CONSTRAINT PK_{model.TableName} PRIMARY KEY NONCLUSTERED ({model.IdColumnName}),
    CONSTRAINT FK_{model.TableName}_{model.ModelInner.TableName} FOREIGN KEY ({model.ModelInnerColumnName})
        REFERENCES {Database.MsSQL.ToDefaultSchema()}.{model.ModelInner.TableName} ({model.ModelInner.IdColumnName})
        ON DELETE CASCADE
        ON UPDATE CASCADE
)
"";
            await cmd.ExecuteNonQueryAsync();
        }}
");
                    return;
                }
                case Database.MySQL:
                {
                    _stringBuilder.AppendLine($@"
        private async Task CreateModelTable(MySqlCommand cmd)
        {{
            cmd.CommandText = @""
CREATE TABLE {Database.MySQL.ToDefaultSchema()}.{model.TableName}
(
    {model.IdColumnName} {model.IdTypeInfo.DbSqlType}{model.IdTypeInfo.DbSqlAfterType()} NOT NULL,
    {model.ValueColumnName} {model.TypeInfo.DbSqlType}{model.TypeInfo.DbSqlAfterType()} NOT NULL,
    {model.NullableValueColumnName} {model.TypeInfo.DbSqlType}{model.TypeInfo.DbSqlAfterType()},
    {model.ModelInnerColumnName} {model.ModelInner.IdTypeInfo.DbSqlType}{model.ModelInner.IdTypeInfo.DbSqlAfterType()},
    PRIMARY KEY ({model.IdColumnName}),
    FOREIGN KEY ({model.ModelInnerColumnName})
        REFERENCES {Database.MySQL.ToDefaultSchema()}.{model.ModelInner.TableName} ({model.ModelInner.IdColumnName})
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);
"";
            await cmd.ExecuteNonQueryAsync();
        }}
");
                    return;
                }
            }
        }

        private void DropModelTable(Model.ModelType model, Database database)
        {
            switch (database)
            {
                case Database.PostgreSQL:
                {
                    _stringBuilder.AppendLine($@"
        private async Task DropModelTable(NpgsqlCommand cmd)
        {{
            cmd.CommandText = @""
DROP TABLE {Database.PostgreSQL.ToDefaultSchema()}.{model.TableName};
"";
            await cmd.ExecuteNonQueryAsync();

            cmd.CommandText = @""
DROP TABLE {Database.PostgreSQL.ToDefaultSchema()}.binary_{model.TableName};
"";
            await cmd.ExecuteNonQueryAsync();
        }}
");
                    return;
                }
                case Database.MsSQL:
                {
                    _stringBuilder.AppendLine($@"
        private async Task DropModelTable(SqlCommand cmd)
        {{
            cmd.CommandText = @""
DROP TABLE {Database.MsSQL.ToDefaultSchema()}.{model.TableName}
"";
            await cmd.ExecuteNonQueryAsync();
        }}
");
                    return;
                }
                case Database.MySQL:
                {
                    _stringBuilder.AppendLine($@"
        private async Task DropModelTable(MySqlCommand cmd)
        {{
            cmd.CommandText = @""
DROP TABLE IF EXISTS {Database.MySQL.ToDefaultSchema()}.{model.TableName};
"";
            await cmd.ExecuteNonQueryAsync();
        }}
");
                    return;
                }
            }
        }

        private void OneTimeSetUp()
        {
            _stringBuilder.AppendLine($@"
        [OneTimeSetUp]
        public async Task OneTimeSetUp()
        {{
            await using (var connection = GlobalSetUp.GetConnection)
            {{
                await connection.OpenAsync();
                await using var cmd = connection.CreateCommand();
                await CreateModelInnerTable(cmd);
                await CreateModelTable(cmd);
            }}
        }}
");
        }

        private void OneTimeTearDown()
        {
            _stringBuilder.AppendLine($@"
        [OneTimeTearDown]
        public async Task OneTimeTearDown()
        {{
            await using (var connection = GlobalSetUp.GetConnection)
            {{
                await connection.OpenAsync();
                await using var cmd = connection.CreateCommand();
                await DropModelTable(cmd);
                await DropModelInnerTable(cmd);
            }}
        }}
");
        }
    }
}