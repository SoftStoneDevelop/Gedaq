using System.Collections.Generic;
using System.Linq;
using TestsGenerator.Constants;
using TestsGenerator.Enums;
using TestsGenerator.Helpers;
using TestsGenerator.Model;

namespace TestsGenerator.Generators.PostgreSQL
{
    internal static class BinaryImportModelInnerTest
    {
        private const string _testName = "ImportModelInner";

        public static void Generate(
            ref int order,
            StringBuilderArray.StringBuilderArray stringBuilder,
            Model.ModelType model,
            ModelValueStorage storage,
            string interfaceTypeName)
        {
            var startIndex = 0;
            var ordered =
                storage.Values
                .OrderBy(or => or.IdValue)
                .ToList();

            var totalItemsInDb = 0;
            for (int i = 0; i < ValueConstants.BoolValues.Length; i++)
            {
                bool isDynamicQuery = ValueConstants.BoolValues[i];

                SelectImportModelInnerConfig(
                    model,
                    stringBuilder,
                    interfaceTypeName,
                    isDynamicQuery);

                ImportModelInnerConfig(
                    stringBuilder,
                    model,
                    interfaceTypeName,
                    isDynamicQuery: isDynamicQuery);

                var isDynamicQueryLastIteration = i == ValueConstants.BoolValues.Length - 1;
                for (int j = 0; j < ValueConstants.BoolValues.Length; j++)
                {
                    bool isAsync = ValueConstants.BoolValues[j];
                    var isAsyncLastIteration = j == ValueConstants.BoolValues.Length - 1;
                    ImportModelInnerTest(
                        order,
                        model,
                        stringBuilder,
                        ordered,
                        interfaceTypeName,
                        ref startIndex,
                        2,
                        ref totalItemsInDb,
                        isDynamicQueryLastIteration && isAsyncLastIteration,
                        isDynamicQuery: isDynamicQuery,
                        isAsync: isAsync);

                    order++;
                }
            }
        }

        private static void ImportModelInnerConfig(
            StringBuilderArray.StringBuilderArray stringBuilder,
            Model.ModelType model,
            string interfaceTypeName,
            bool isDynamicQuery)
        {
            var classWithAtr = isDynamicQuery;
            var query =
                isDynamicQuery ?
                ValueConstants.NullValue :
                ImportQuery(model, isDynamicQuery);

            stringBuilder.Append($@"
[Gedaq.Npgsql.Attributes.BinaryImport(
            query: {query},
            methodName:""{ImportMethodName(isDynamicQuery)}"",
            queryMapType: typeof({model.ModelInner.ClassName(isDynamicQuery, classWithAtr)}),
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
        private void {ImportMethodName(isDynamicQuery)}Config()
        {{
        }}
");
        }

        private static string ImportMethodName(bool isDynamicQuery)
        {
            return $"{ValueConstants.DynamicQueryPrefix(isDynamicQuery)}{_testName}";
        }

        private static string ImportQuery(Model.ModelType model, bool isDynamicQuery)
        {
            var classWithAtr = isDynamicQuery;
            if (classWithAtr)
            {
                return $@"@""
COPY {Database.PostgreSQL.ToDefaultSchema()}.binary_{model.ModelInner.TableName}
(
{model.ModelInner.IdColumnName},
{model.ModelInner.ValueColumnName},
{model.ModelInner.NullableValueColumnName}
) 
FROM STDIN (FORMAT BINARY)
""";
            }
            else
            {
                return $@"@""
COPY {Database.PostgreSQL.ToDefaultSchema()}.binary_{model.ModelInner.TableName}
(
{model.ModelInner.IdColumnName},
{model.ModelInner.NullableValueColumnName},
{model.ModelInner.ValueColumnName}
) 
FROM STDIN (FORMAT BINARY)
""";
            }
        }

        private static void SelectImportModelInnerConfig(
            Model.ModelType model,
            StringBuilderArray.StringBuilderArray stringBuilder,
            string interfaceTypeName,
            bool isDynamicQuery)
        {
            var classWithAtr = isDynamicQuery;
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
            methodName:""{BinarySelectMethodName(isDynamicQuery)}"",
            queryMapTypes: [typeof({model.ModelInner.ClassName(isDynamicQuery, classWithAtr)})],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof({interfaceTypeName}))]
        private void {BinarySelectMethodName(isDynamicQuery)}Config()
        {{
        }}
");
        }

        private static string BinarySelectMethodName(bool isDynamicQuery)
        {
            return $"{ValueConstants.DynamicQueryPrefix(isDynamicQuery)}Select{_testName}";
        }

        private static void ImportModelInnerTest(
            int order,
            Model.ModelType model,
            StringBuilderArray.StringBuilderArray stringBuilder,
            List<ModelValue> storage,
            string interfaceTypeName,
            ref int startIndex,
            int count,
            ref int totalCount,
            bool toEndStorage,
            bool isDynamicQuery,
            bool isAsync)
        {
            System.ArgumentOutOfRangeException.ThrowIfGreaterThan(startIndex + count, storage.Count);

            var classWithAtr = isDynamicQuery;
            var await = isAsync ? "await " : string.Empty;
            var async = isAsync ? "Async" : string.Empty;

            var query =
                isDynamicQuery ?
                $", {ImportQuery(model, isDynamicQuery)}" :
                string.Empty;

            var originStartIndex = startIndex;
            var addCount = 0;
            for (int i = startIndex; i < storage.Count; i++)
            {
                if (!toEndStorage && addCount == count)
                {
                    break;
                }

                startIndex++;
                ModelValue value = storage[i];
                if (value.InnerModel == null)
                {
                    continue;
                }
                else
                {
                    addCount++;
                }
            }

            var endIndex = startIndex;
            if (addCount < count)
            {
                throw new System.Exception("Storage note have enough items");
            }

            totalCount += addCount;
            stringBuilder.Append($@"
        [Test, Order({order})]
        public {async.ToLowerInvariant()} {(isAsync ? "Task" : "void")} {ImportMethodName(isDynamicQuery)}{async}Test()
        {{
            {await}using (var connection = GlobalSetUp.GetConnection)
            {{
                {await}connection.Open{async}();
                var importCollection = new List<{model.ModelInner.ClassName(isDynamicQuery, classWithAtr)}>({count});
                for (int i = {originStartIndex}; i < {endIndex}; i++)
                {{
                    var importModel = {TestsPart.TestDataArrayName}[i].{model.ModelInnerName};
                    if (importModel == null)
                    {{
                        continue;
                    }}

                    importCollection.Add({ModelGenerator.ConvertToWAOrSelf(model.ModelInner, "importModel", classWithAtr)});
                }}

                {await}{TypeHelper.ThisAsInterface(interfaceTypeName)}.{ImportMethodName(isDynamicQuery)}{async}(connection, importCollection{query});
                var models = {await}{TypeHelper.ThisAsInterface(interfaceTypeName)}.{BinarySelectMethodName(isDynamicQuery)}{async}(connection);
                Assert.That(models, Has.Count.EqualTo({totalCount}));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {{
                    var actual = models[i];
                    var expect = {TestsPart.TestDataArrayName}.First(wh => wh.{model.ModelInnerName} != null && wh.{model.ModelInnerName}.{model.ModelInner.IdName} == actual.{model.ModelInner.IdName}).{model.ModelInnerName};
                    {model.ModelInner.ClassName(isDynamicQuery, classWithAtr)}.{ModelGenerator.AssertMethodName}(actual, expect, false);
                    Assert.That(set.Add(actual.{model.ModelInner.IdName}), Is.True);
                }}
            }}
        }}
");
        }
    }
}