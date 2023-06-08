using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Text;
using TestsGenegator.Enums;
using TestsGenegator.Helpers;

namespace TestsGenegator.Generators
{
    internal class TestOneTimePart
    {
        private readonly StringBuilder _stringBuilder = new StringBuilder();

        public void Generate(Model.Model model, Database database, SourceProductionContext context)
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

            context.AddSource($"{model.ClassName}TestOneTimePart.g.cs", _stringBuilder.ToString());
        }

        private void Start(Model.Model model, Database database)
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

        private void CreateModelInnerTable(Model.Model model, Database database)
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
    {model.ModelInner.IdColumnName} {model.ModelInner.IdDbType} NOT NULL,
    {model.ModelInner.ValueColumnName} {model.ModelInner.TypeInfo.DbType} NOT NULL,
    {model.ModelInner.NullableValueColumnName} {model.ModelInner.TypeInfo.DbType},
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

        private void DropModelInnerTable(Model.Model model, Database database)
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

        private void CreateModelTable(Model.Model model, Database database)
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
    {model.IdColumnName} {model.IdDbType} NOT NULL,
    {model.ValueColumnName} {model.TypeInfo.DbType} NOT NULL,
    {model.NullableValueColumnName} {model.TypeInfo.DbType},
    {model.ModelInner.TableName}_id {model.ModelInner.IdDbType},
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

        private void DropModelTable(Model.Model model, Database database)
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

        private void OneTimeSetUp(Model.Model model, Database database)
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

        private void OneTimeTearDown(Model.Model model, Database database)
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