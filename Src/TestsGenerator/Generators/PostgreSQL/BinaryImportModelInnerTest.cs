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
                var isDynamicQueryLastIteration = i == ValueConstants.BoolValues.Length - 1;

                for (int k = 0; k < ValueConstants.BoolValues.Length; k++)
                {
                    bool isOverrideDbTypes = ValueConstants.BoolValues[k];
                    var isOverrideDbTypesLastIteration = k == ValueConstants.BoolValues.Length - 1;

                    SelectImportModelInnerConfig(
                        model,
                        stringBuilder,
                        interfaceTypeName,
                        isDynamicQuery,
                        isOverrideDbTypes: isOverrideDbTypes);

                    ImportModelInnerConfig(
                        stringBuilder,
                        model,
                        interfaceTypeName,
                        isDynamicQuery: isDynamicQuery,
                        isOverrideDbTypes: isOverrideDbTypes);

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
                            isDynamicQueryLastIteration && isAsyncLastIteration && isOverrideDbTypesLastIteration,
                            isDynamicQuery: isDynamicQuery,
                            isAsync: isAsync,
                            isOverrideDbTypes: isOverrideDbTypes);

                        order++;
                    }
                }
            }
        }

        private static void ImportModelInnerConfig(
            StringBuilderArray.StringBuilderArray stringBuilder,
            Model.ModelType model,
            string interfaceTypeName,
            bool isDynamicQuery,
            bool isOverrideDbTypes)
        {
            var classWithAtr = isDynamicQuery || !isOverrideDbTypes;
            var query =
                isDynamicQuery ?
                ValueConstants.NullValue :
                ImportQuery(model, isDynamicQuery, isOverrideDbTypes);

            var dbTypes =
                isOverrideDbTypes ?
                $@"
            new NpgsqlDbType[]
            {{
                {model.ModelInner.IdTypeInfo.SpecialDbTypeStr()},
                {model.ModelInner.TypeInfo.SpecialDbTypeStr()},
                {model.ModelInner.TypeInfo.SpecialDbTypeStr()}
            }}" :
            ValueConstants.NullValue;

            stringBuilder.Append($@"
[Gedaq.Npgsql.Attributes.BinaryImport(
            query: {query},
            methodName:""{ImportMethodName(isDynamicQuery, isOverrideDbTypes)}"",
            queryMapType: typeof({model.ModelInner.ClassName(isDynamicQuery, classWithAtr)}),
            dbTypes: {dbTypes},
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof({interfaceTypeName}))]
        private void {ImportMethodName(isDynamicQuery, isOverrideDbTypes)}Config()
        {{
        }}
");
        }

        private static string ImportMethodName(bool isDynamicQuery, bool isOverrideDbTypes)
        {
            return $"{ValueConstants.DynamicQueryPrefix(isDynamicQuery)}{ValueConstants.WithAttributePrefix(isOverrideDbTypes)}{_testName}";
        }

        private static string ImportQuery(
            Model.ModelType model,
            bool isDynamicQuery,
            bool isOverrideDbTypes)
        {
            var classWithAtr = isDynamicQuery || !isOverrideDbTypes;
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
            bool isDynamicQuery,
            bool isOverrideDbTypes)
        {
            var classWithAtr = isDynamicQuery || !isOverrideDbTypes;
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
            methodName:""{BinarySelectMethodName(isDynamicQuery, isOverrideDbTypes)}"",
            queryMapTypes: [typeof({model.ModelInner.ClassName(isDynamicQuery, classWithAtr)})],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof({interfaceTypeName}))]
        private void {BinarySelectMethodName(isDynamicQuery, isOverrideDbTypes)}Config()
        {{
        }}
");
        }

        private static string BinarySelectMethodName(bool isDynamicQuery, bool isOverrideDbTypes)
        {
            return $"{ValueConstants.DynamicQueryPrefix(isDynamicQuery)}{ValueConstants.WithAttributePrefix(isOverrideDbTypes)}Select{_testName}";
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
            bool isAsync,
            bool isOverrideDbTypes)
        {
            System.ArgumentOutOfRangeException.ThrowIfGreaterThan(startIndex + count, storage.Count);

            var classWithAtr = isDynamicQuery || !isOverrideDbTypes;
            var await = isAsync ? "await " : string.Empty;
            var async = isAsync ? "Async" : string.Empty;

            var query =
                isDynamicQuery ?
                $", {ImportQuery(model, isDynamicQuery, classWithAtr)}" :
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
        public {async.ToLowerInvariant()} {(isAsync ? "Task" : "void")} {ImportMethodName(isDynamicQuery, isOverrideDbTypes)}{async}Test()
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

                {await}{TypeHelper.ThisAsInterface(interfaceTypeName)}.{ImportMethodName(isDynamicQuery, isOverrideDbTypes)}{async}(connection, importCollection{query});
                var models = {await}{TypeHelper.ThisAsInterface(interfaceTypeName)}.{BinarySelectMethodName(isDynamicQuery, isOverrideDbTypes)}{async}(connection);
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