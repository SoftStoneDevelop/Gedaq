using TestsGenerator.Constants;
using TestsGenerator.Enums;
using TestsGenerator.Helpers;
using TestsGenerator.Model;

namespace TestsGenerator.Generators.PostgreSQL
{
    internal static class BinaryExportModelInnerTest
    {
        private const string _testName = "ExportModelInner";

        public static void Generate(
            int order,
            StringBuilderArray.StringBuilderArray stringBuilder,
            Model.ModelType model,
            ModelValueStorage storage,
            string interfaceTypeName)
        {
            foreach (var isDynamicQuery in ValueConstants.BoolValues)
            {
                ExportModelInnerConfig(
                    stringBuilder,
                    model,
                    interfaceTypeName,
                    isDynamicQuery: isDynamicQuery);

                foreach (var isAsync in ValueConstants.BoolValues)
                {
                    ExportModelInnerTest(
                        order,
                        model,
                        stringBuilder,
                        isAsync,
                        isDynamicQuery: isDynamicQuery,
                        interfaceTypeName);
                }
            }
        }

        private static void ExportModelInnerConfig(
            StringBuilderArray.StringBuilderArray stringBuilder,
            Model.ModelType model,
            string interfaceTypeName,
            bool isDynamicQuery)
        {
            var classWithAtr = isDynamicQuery;
            var query = isDynamicQuery ?
                ValueConstants.NullValue :
                ExportQuery(model, isDynamicQuery);

            stringBuilder.Append($@"
[Gedaq.Npgsql.Attributes.BinaryExport(
            query: {query},
            methodName:""{ExportMethodName(isDynamicQuery)}"",
            queryMapTypes: [typeof({model.ModelInner.ClassName(isDynamicQuery, classWithAtr)})],
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
        private void {ExportMethodName(isDynamicQuery)}Config()
        {{
        }}
");
        }

        private static string ExportMethodName(bool isDynamicQuery)
        {
            return $"{ValueConstants.DynamicQueryPrefix(isDynamicQuery)}{_testName}";
        }

        private static string ExportQuery(Model.ModelType model, bool isDynamicQuery)
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
) TO STDOUT (FORMAT BINARY)
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
) TO STDOUT (FORMAT BINARY)
""";
            }
        }

        private static void ExportModelInnerTest(
            int order,
            Model.ModelType model,
            StringBuilderArray.StringBuilderArray stringBuilder,
            bool isAsync,
            bool isDynamicQuery,
            string interfaceTypeName)
        {
            var classWithAtr = isDynamicQuery;

            var await = isAsync ? "await " : string.Empty;
            var async = isAsync ? "Async" : string.Empty;

            var query =
                isDynamicQuery ?
                $", {ExportQuery(model, isDynamicQuery)}" :
                string.Empty;

            stringBuilder.Append($@"
        [Test, Order({order})]
        public {async.ToLowerInvariant()} {(isAsync ? "Task" : "void")} {ExportMethodName(isDynamicQuery)}{async}Test()
        {{
            {await}using (var connection = GlobalSetUp.GetConnection)
            {{
                {await}connection.Open{async}();
                var models = {await}{TypeHelper.ThisAsInterface(interfaceTypeName)}.{ExportMethodName(isDynamicQuery)}{async}(connection{query}).ToList{async}();
                var expectCount = {TestsPart.TestDataArrayName}.Where(wh => wh.{model.ModelInnerName} != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {{
                    var model = models[modelIndex];
                    var expectedModel = {TestsPart.TestDataArrayName}.First(wh => wh.{model.ModelInnerName} != null && wh.{model.ModelInnerName}.{model.ModelInner.IdName} == model.{model.ModelInner.IdName}).{model.ModelInnerName};
                    {model.ModelInner.ClassName(isDynamicQuery, classWithAtr)}.{ModelGenerator.AssertMethodName}(model, expectedModel, false);
                }}
            }}
        }}
");
        }
    }
}