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

            OneTimeSetUp(model, database);
            OneTimeTearDown(model, database);

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
    internal partial class Tests{model.TypeInfo.TypeName}
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
CREATE TABLE public.{model.ModelInner.TableName}
(
    {model.ModelInner.IdColumnName} {model.ModelInner.IdTypeInfo.DbSqlType} NOT NULL,
    {model.ModelInner.ValueColumnName} {model.ModelInner.TypeInfo.DbSqlType} NOT NULL,
    {model.ModelInner.NullableValueColumnName} {model.ModelInner.TypeInfo.DbSqlType},
    CONSTRAINT {model.ModelInner.TableName}_pkey PRIMARY KEY (id)
);
"";
            await cmd.ExecuteNonQueryAsync();
        }}
");
                    return;
                }
                case Database.MsSQL:
                {
                    return;
                }
                case Database.MySQL:
                {
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
DROP TABLE public.{model.ModelInner.TableName};
"";
            await cmd.ExecuteNonQueryAsync();
        }}
");
                    return;
                }
                case Database.MsSQL:
                {
                    return;
                }
                case Database.MySQL:
                {
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
CREATE TABLE public.{model.TableName}
(
    {model.IdColumnName} {model.IdTypeInfo.DbSqlType} NOT NULL,
    {model.ValueColumnName} {model.TypeInfo.DbSqlType} NOT NULL,
    {model.NullableValueColumnName} {model.TypeInfo.DbSqlType},
    {model.ModelInner.TableName}_id {model.ModelInner.IdTypeInfo.DbSqlType},
    CONSTRAINT {model.TableName}_pkey PRIMARY KEY (id),
    CONSTRAINT {model.TableName}_{model.ModelInner.TableName}_fk FOREIGN KEY ({model.ModelInner.TableName}_id)
        REFERENCES public.{model.ModelInner.TableName} ({model.ModelInner.IdColumnName}) MATCH SIMPLE
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
                    return;
                }
                case Database.MySQL:
                {
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
DROP TABLE public.{model.TableName};
"";
            await cmd.ExecuteNonQueryAsync();
        }}
");
                    return;
                }
                case Database.MsSQL:
                {
                    return;
                }
                case Database.MySQL:
                {
                    return;
                }
            }
        }

        private void OneTimeSetUp(Model.ModelType model, Database database)
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

        private void OneTimeTearDown(Model.ModelType model, Database database)
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