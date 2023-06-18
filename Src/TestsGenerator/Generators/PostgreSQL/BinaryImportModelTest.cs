using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestsGenerator.Constants;
using TestsGenerator.Enums;
using TestsGenerator.Helpers;
using TestsGenerator.Model;

namespace TestsGenerator.Generators.PostgreSQL
{
    internal static class BinaryImportModelTest
    {
        private static string _testName = "ImportModel";

        public static void Generate(
            int order,
            StringBuilder stringBuilder,
            Model.ModelType model,
            ModelValueStorage storage
            )
        {
            ImportModelConfig(stringBuilder, model);
            SelectImportModelConfig(model, stringBuilder);

            var ordered = storage.Values.OrderBy(or => or.IdValue).ToList();
            ImportModelTest(order, model, stringBuilder, ordered);
        }

        private static void ImportModelConfig(
            StringBuilder stringBuilder,
            Model.ModelType model
            )
        {
            stringBuilder.Append($@"
[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @""
COPY {Database.PostgreSQL.ToDefaultSchema()}.binary_{model.TableName}
(
{model.IdColumnName},
{model.ValueColumnName},
~StartInner::{model.ModelInnerName}:{model.ModelInner.IdName}~
    ~Reinterpret::{model.ModelInner.IdColumnName}~
{model.ModelInnerColumnName},
~EndInner::{model.ModelInnerName}~
{model.NullableValueColumnName}
) 
FROM STDIN (FORMAT BINARY)
"",
            methodName:""{_testName}"",
            queryMapType: typeof({model.ClassName}),
            dbTypes:
            new NpgsqlDbType[]
            {{
                {model.IdTypeInfo.SpecialDbTypeStr()},
                {model.TypeInfo.SpecialDbTypeStr()},
                {model.ModelInner.IdTypeInfo.SpecialDbTypeStr()},
                {model.TypeInfo.SpecialDbTypeStr()}
            }},
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Private
            )
            ]
        private void {_testName}Config()
        {{
        }}
");
        }

        private static void SelectImportModelConfig(
            Model.ModelType model,
            StringBuilder stringBuilder
            )
        {
            var query = $@"
@""
SELECT
    m.{model.IdColumnName},
    m.{model.ValueColumnName},
~StartInner::{model.ModelInnerName}:{model.ModelInner.IdName}~
    mi.{model.ModelInner.IdColumnName},
    mi.{model.ModelInner.ValueColumnName},
    mi.{model.ModelInner.NullableValueColumnName},
~EndInner::{model.ModelInnerName}~
    m.{model.NullableValueColumnName}
FROM {Database.PostgreSQL.ToDefaultSchema()}.binary_{model.TableName} m
LEFT JOIN {Database.PostgreSQL.ToDefaultSchema()}.binary_{model.ModelInner.TableName} mi ON mi.{model.ModelInner.IdColumnName} = m.{model.ModelInnerColumnName}
ORDER BY
    m.{model.IdColumnName} ASC
""
";

            stringBuilder.Append($@"
[Gedaq.DbConnection.Attributes.Query(
            query: {query},
            methodName:""Select{_testName}"",
            queryMapType: typeof({model.ClassName}),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Private
            )
            ]
        private void Select{_testName}Config()
        {{
        }}
");
        }

        private static void ImportModelTest(
            int order,
            Model.ModelType model,
            StringBuilder stringBuilder,
            List<ModelValue> storage
            )
        {
            if (storage.Count < 4)
            {
                throw new System.ArgumentOutOfRangeException(nameof(storage));
            }

            stringBuilder.Append($@"
        [Test, Order({order})]
        public async Task {_testName}Test()
        {{
            await using (var connection = GlobalSetUp.GetConnection)
            {{
                await connection.OpenAsync();
");
            var index = 0;
            stringBuilder.Append($@"
                var importCollection = new List<{model.ClassName}>({storage.Count / 2});
");
            FillCollection(storage.Count / 2);

            stringBuilder.Append($@"
                {_testName}(connection, importCollection);
                var models = Select{_testName}(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));
");
            var indexCollection = 0;
            for (; indexCollection < storage.Count / 2; indexCollection++)
            {
                ModelValue value = storage[indexCollection];
                if (indexCollection == 0)
                {
                    stringBuilder.Append($@"
                var model = models[{indexCollection}];
");
                }
                else
                {
                    stringBuilder.Append($@"
                model = models[{indexCollection}];
");
                }

                stringBuilder.Append(model.Assert("model", value));
            }

            stringBuilder.Append($@"
                importCollection.Clear();
");
            FillCollection(storage.Count);

            stringBuilder.Append($@"
                await {_testName}Async(connection, importCollection);
                models = await Select{_testName}Async(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo({storage.Count}));
");
            indexCollection = 0;
            for (; indexCollection < storage.Count; indexCollection++)
            {
                ModelValue value = storage[indexCollection];
                stringBuilder.Append($@"
                model = models[{indexCollection}];
{model.Assert("model", value)}
");
            }

            stringBuilder.Append($@"
            }}
        }}
");
            void FillCollection(int end)
            {
                for (; index < end; index++)
                {
                    ModelValue value = storage[index];
                    stringBuilder.Append($@"
                importCollection.Add(
                new {model.ClassName}
                {{
                    {model.IdName} = {value.IdValue},
                    {model.ValueName} = {value.Value},
                    {model.NullableValueName} = {value.NullableValue},
");
                    if (value.InnerModel == null)
                    {
                        stringBuilder.Append($@"
                    {model.ModelInnerName} = {ValueConstants.NullValue}
");
                    }
                    else
                    {
                        stringBuilder.Append($@"
                    {model.ModelInnerName} = new {model.ModelInner.ClassName} 
                    {{
                        {model.ModelInner.IdName} = {value.InnerModel.Id}
                    }}
");
                    }
                    stringBuilder.Append($@"
                }});
");
                }
            }
        }
    }
}