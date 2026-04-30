using System.Collections.Generic;
using System.Linq;
using TestsGenerator.Constants;
using TestsGenerator.Enums;
using TestsGenerator.Helpers;
using TestsGenerator.Model;

namespace TestsGenerator.Generators.PostgreSQL
{
    internal static class BinaryImportModelTest
    {
        private const string _testName = "ImportModel";

        public static void Generate(
            ref int order,
            StringBuilderArray.StringBuilderArray stringBuilder,
            Model.ModelType model,
            ModelValueStorage storage,
            string interfaceTypeName)
        {
            ImportModelConfig(
                stringBuilder, 
                model,
                interfaceTypeName);

            SelectImportModelConfig(
                model, 
                stringBuilder,
                interfaceTypeName);

            var startIndex = 0;
            var ordered = storage.Values.OrderBy(or => or.IdValue).ToList();

            var totalItemsInDb = 0;
            for (int j = 0; j < ValueConstants.BoolValues.Length; j++)
            {
                bool isAsync = ValueConstants.BoolValues[j];
                var isAsyncLastIteration = j == ValueConstants.BoolValues.Length - 1;

                ImportModelTest(
                    order,
                    model,
                    stringBuilder,
                    ordered,
                    interfaceTypeName,
                    isAsync: isAsync,
                    startIndex: ref startIndex,
                    count: 10,
                    totalCount: ref totalItemsInDb,
                    toEndStorage: isAsyncLastIteration);

                order++;
            }
        }

        private static void ImportModelConfig(
            StringBuilderArray.StringBuilderArray stringBuilder,
            Model.ModelType model,
            string interfaceTypeName)
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
            queryMapType: typeof({model.ClassName(false)}),
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
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof({interfaceTypeName}))]
        private void {_testName}Config()
        {{
        }}
");
        }

        private static void SelectImportModelConfig(
            Model.ModelType model,
            StringBuilderArray.StringBuilderArray stringBuilder,
            string interfaceTypeName)
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
            queryMapTypes: [typeof({model.ClassName(false)})],
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

        private static void ImportModelTest(
            int order,
            Model.ModelType model,
            StringBuilderArray.StringBuilderArray stringBuilder,
            List<ModelValue> storage,
            string interfaceTypeName,
            bool isAsync,
            ref int startIndex,
            int count,
            ref int totalCount,
            bool toEndStorage)
        {
            System.ArgumentOutOfRangeException.ThrowIfGreaterThan(startIndex + count, storage.Count);

            var await = isAsync ? "await " : string.Empty;
            var async = isAsync ? "Async" : string.Empty;

            var originStartIndex = startIndex;
            var addCount = 0;
            for (int i = startIndex; i < storage.Count; i++)
            {
                if (!toEndStorage && addCount == count)
                {
                    break;
                }

                startIndex++;
                addCount++;
            }

            var endIndex = startIndex;
            if (addCount < count)
            {
                throw new System.Exception("Storage note have enough items");
            }

            totalCount += addCount;
            stringBuilder.Append($@"
        [Test, Order({order})]
        public {async.ToLowerInvariant()} {(isAsync ? "Task" : "void")} {_testName}{async}Test()
        {{
            {await}using (var connection = GlobalSetUp.GetConnection)
            {{
                {await}connection.Open{async}();
                var importCollection = new List<{model.ClassName(false)}>();
                for (int i = {originStartIndex}; i < {endIndex}; i++)
                {{
                    var importModel = {TestsPart.TestDataArrayName}[i];
                    importCollection.Add(importModel);
                }}

                {await}{TypeHelper.ThisAsInterface(interfaceTypeName)}.{_testName}{async}(connection, importCollection);
                var models = {await}{TypeHelper.ThisAsInterface(interfaceTypeName)}.Select{_testName}{async}(connection);
                Assert.That(models, Has.Count.EqualTo({totalCount}));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {{
                    var actual = models[i];
                    var expect = {TestsPart.TestDataArrayName}.First(wh => wh.{model.IdName} == actual.{model.IdName});
                    {model.ClassName(false)}.{ModelGenerator.AssertMethodName}(actual, expect, false);
                    Assert.That(set.Add(actual.{model.ModelInner.IdName}), Is.True);
                }}
            }}
        }}
");
        }
    }
}