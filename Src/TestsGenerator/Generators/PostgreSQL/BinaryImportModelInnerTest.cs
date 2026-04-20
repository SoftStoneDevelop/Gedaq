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
            string interfaceTypeName)
        {
            ImportModelInnerConfig(
                stringBuilder, 
                model,
                interfaceTypeName);

            SelectImportModelInnerConfig(
                model, 
                stringBuilder,
                interfaceTypeName);

            var ordered = 
                storage.Values
                .OrderBy(or => or.IdValue)
                .ToList();

            ImportModelInnerTest(
                order, 
                model, 
                stringBuilder, 
                ordered,
                interfaceTypeName);
        }

        private static void ImportModelInnerConfig(
            StringBuilderArray.StringBuilderArray stringBuilder,
            Model.ModelType model,
            string interfaceTypeName)
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
            queryMapTypes: [typeof({model.ModelInner.ClassName(false)})],
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
            asPartInterface: typeof({interfaceTypeName}))]
        private void {_testName}Config()
        {{
        }}
");
        }

        private static void SelectImportModelInnerConfig(
            Model.ModelType model,
            StringBuilderArray.StringBuilderArray stringBuilder,
            string interfaceTypeName)
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
            queryMapTypes: [typeof({model.ModelInner.ClassName(false)})],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof({interfaceTypeName}))]
        private void Select{_testName}Config()
        {{
        }}
");
        }

        private static void ImportModelInnerTest(
            int order,
            Model.ModelType model,
            StringBuilderArray.StringBuilderArray stringBuilder,
            List<ModelValue> storage,
            string interfaceTypeName)
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
                var importCollection = new List<{model.ModelInner.ClassName(false)}>({storage.Count / 2});
");
            var expectCount = FillCollection(storage.Count / 2);

            stringBuilder.Append($@"
                {TypeHelper.ThisAsInterface(interfaceTypeName)}.{_testName}(connection, importCollection);
                var models = {TypeHelper.ThisAsInterface(interfaceTypeName)}.Select{_testName}(connection);
                Assert.That(models, Has.Count.EqualTo({expectCount}));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {{
                    var actual = models[i];
                    var expect = {TestsPart.TestDataArrayName}.First(wh => wh.{model.ModelInnerName} != null && wh.{model.ModelInnerName}.{model.ModelInner.IdName} == actual.{model.ModelInner.IdName}).{model.ModelInnerName};
                    {model.ModelInner.ClassName(false)}.{ModelGenerator.AssertMethodName}(actual, expect, false);
                    Assert.That(set.Add(actual.{model.ModelInner.IdName}), Is.True);
                }}
                set.Clear();
                importCollection.Clear();
");
            var expectCount2 = FillCollection(storage.Count);

            stringBuilder.Append($@"
                await {TypeHelper.ThisAsInterface(interfaceTypeName)}.{_testName}Async(connection, importCollection);
                models = await {TypeHelper.ThisAsInterface(interfaceTypeName)}.Select{_testName}Async(connection);
                Assert.That(models, Has.Count.EqualTo({expectCount + expectCount2}));
                for (var i = 0; i < models.Count(); i++)
                {{
                    var actual = models[i];
                    var expect = {TestsPart.TestDataArrayName}.First(wh => wh.{model.ModelInnerName} != null && wh.{model.ModelInnerName}.{model.ModelInner.IdName} == actual.{model.ModelInner.IdName}).{model.ModelInnerName};
                    {model.ModelInner.ClassName(false)}.{ModelGenerator.AssertMethodName}(actual, expect, false);
                    Assert.That(set.Add(actual.{model.ModelInner.IdName}), Is.True);
                }}
                set.Clear();
            }}
        }}
");
            int FillCollection(int end)
            {
                int count = 0;
                for (; index < end; index++)
                {
                    ModelValue value = storage[index];
                    if (value.InnerModel == null)
                    {
                        continue;
                    }

                    count++;
                    stringBuilder.Append($@"
                importCollection.Add({TestsPart.TestDataArrayName}[{index}].{model.ModelInnerName});");
                }

                return count;
            }
        }
    }
}