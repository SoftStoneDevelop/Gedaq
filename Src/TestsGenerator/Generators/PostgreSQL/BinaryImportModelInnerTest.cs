using System.Collections.Generic;
using System.Linq;
using TestsGenerator.Enums;
using TestsGenerator.Helpers;
using TestsGenerator.Model;

namespace TestsGenerator.Generators.PostgreSQL
{
    internal static class BinaryImportModelInnerTest
    {
        private const string _testName = "ImportModelInner";

        public static void Generate(
            int order,
            StringBuilderArray.StringBuilderArray stringBuilder,
            Model.ModelType model,
            ModelValueStorage storage,
            string interfaceTypeName
            )
        {
            ImportModelInnerConfig(
                stringBuilder, 
                model,
                interfaceTypeName
                );
            SelectImportModelInnerConfig(
                model, 
                stringBuilder,
                interfaceTypeName
                );

            var ordered = 
                storage.Values
                .Where(wh => wh.InnerModel != null)
                .Select(sel => sel.InnerModel)
                .OrderBy(or => or.IdValue)
                .ToList()
                ;
            ImportModelInnerTest(
                order, 
                model, 
                stringBuilder, 
                ordered,
                interfaceTypeName
                );
        }

        private static void ImportModelInnerConfig(
            StringBuilderArray.StringBuilderArray stringBuilder,
            Model.ModelType model,
            string interfaceTypeName
            )
        {
            stringBuilder.Append($@"
[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @""
COPY {Database.PostgreSQL.ToDefaultSchema()}.binary_{model.ModelInner.TableName}
(
{model.ModelInner.IdColumnName},
{model.ModelInner.NullableValueColumnName},
{model.ModelInner.ValueColumnName}
) 
FROM STDIN (FORMAT BINARY)
"",
            methodName:""{_testName}"",
            queryMapType: typeof({model.ModelInner.ClassName}),
            dbTypes:
            new NpgsqlDbType[]
            {{
                {model.ModelInner.IdTypeInfo.SpecialDbTypeStr()},
                {model.ModelInner.TypeInfo.SpecialDbTypeStr()},
                {model.ModelInner.TypeInfo.SpecialDbTypeStr()}
            }},
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof({interfaceTypeName})
            )
            ]
        private void {_testName}Config()
        {{
        }}
");
        }

        private static void SelectImportModelInnerConfig(
            Model.ModelType model,
            StringBuilderArray.StringBuilderArray stringBuilder,
            string interfaceTypeName
            )
        {
            var query = $@"
@""
SELECT
    mi.{model.ModelInner.NullableValueColumnName},
    mi.{model.ModelInner.IdColumnName},
    mi.{model.ModelInner.ValueColumnName}
FROM {Database.PostgreSQL.ToDefaultSchema()}.binary_{model.ModelInner.TableName} mi
ORDER BY
    mi.{model.ModelInner.IdColumnName} ASC
""
";

            stringBuilder.Append($@"
[Gedaq.DbConnection.Attributes.Query(
            query: {query},
            methodName:""Select{_testName}"",
            queryMapType: typeof({model.ModelInner.ClassName}),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof({interfaceTypeName})
            )
            ]
        private void Select{_testName}Config()
        {{
        }}
");
        }

        private static void ImportModelInnerTest(
            int order,
            Model.ModelType model,
            StringBuilderArray.StringBuilderArray stringBuilder,
            List<InnerModelValue> storage,
            string interfaceTypeName
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
                var importCollection = new List<{model.ModelInner.ClassName}>({storage.Count / 2});
");
            FillCollection(storage.Count / 2);

            stringBuilder.Append($@"
                {TypeHelper.ThisAsInterface(interfaceTypeName)}.{_testName}(connection, importCollection);
                var models = {TypeHelper.ThisAsInterface(interfaceTypeName)}.Select{_testName}(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));
");
            var indexCollection = 0;
            for (; indexCollection < storage.Count / 2; indexCollection++)
            {
                InnerModelValue value = storage[indexCollection];
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

                stringBuilder.Append(model.ModelInner.Assert("model", value));
            }

            stringBuilder.Append($@"
                importCollection.Clear();
");
            FillCollection(storage.Count);

            stringBuilder.Append($@"
                await {TypeHelper.ThisAsInterface(interfaceTypeName)}.{_testName}Async(connection, importCollection);
                models = await {TypeHelper.ThisAsInterface(interfaceTypeName)}.Select{_testName}Async(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo({storage.Count}));
");
            indexCollection = 0;
            for (; indexCollection < storage.Count; indexCollection++)
            {
                InnerModelValue value = storage[indexCollection];
                stringBuilder.Append($@"
                model = models[{indexCollection}];
{model.ModelInner.Assert("model", value)}
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
                    InnerModelValue value = storage[index];
                    stringBuilder.Append($@"
                importCollection.Add(
                new {model.ModelInner.ClassName}
                {{
                    {model.ModelInner.IdName} = {value.IdValue},
                    {model.ModelInner.ValueName} = {value.Value},
                    {model.ModelInner.NullableValueName} = {value.NullableValue}
                }});
");
                }
            }
        }
    }
}