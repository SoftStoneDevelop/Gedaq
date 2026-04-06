using System.Collections.Generic;
using System.Linq;
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
            ExportModelInnerConfig(
                stringBuilder, 
                model,
                interfaceTypeName);

            var ordered = 
                storage.Values
                .OrderBy(or => or.IdValue)
                .ToList();

            ExportModelInnerTest(
                order, 
                model, 
                stringBuilder, 
                ordered, 
                false,
                interfaceTypeName);

            ExportModelInnerTest(
                order, 
                model, 
                stringBuilder, 
                ordered, 
                true, 
                interfaceTypeName);
        }

        private static void ExportModelInnerConfig(
            StringBuilderArray.StringBuilderArray stringBuilder,
            Model.ModelType model,
            string interfaceTypeName)
        {
            stringBuilder.Append($@"
[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @""
COPY {Database.PostgreSQL.ToDefaultSchema()}.binary_{model.ModelInner.TableName}
(
    {model.ModelInner.IdColumnName},
    {model.ModelInner.NullableValueColumnName},
    {model.ModelInner.ValueColumnName}
) TO STDOUT (FORMAT BINARY)
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
            asPartInterface: typeof({interfaceTypeName}))]
        private void {_testName}Config()
        {{
        }}
");
        }

        private static void ExportModelInnerTest(
            int order,
            Model.ModelType model,
            StringBuilderArray.StringBuilderArray stringBuilder,
            List<ModelValue> storage,
            bool isAsync,
            string interfaceTypeName)
        {
            if (storage.Count < 4)
            {
                throw new System.ArgumentOutOfRangeException(nameof(storage));
            }

            var await = isAsync ? "await" : string.Empty;
            var async = isAsync ? "Async" : string.Empty;

            stringBuilder.Append($@"
        [Test, Order({order})]
        public async Task {_testName}{async}Test()
        {{
            await using (var connection = GlobalSetUp.GetConnection)
            {{
                await connection.OpenAsync();
                var models = {await} {TypeHelper.ThisAsInterface(interfaceTypeName)}.{_testName}{async}(connection).ToList{async}();
                var expectCount = {TestsPart.TestDataArrayName}.Where(wh => wh.{model.ModelInnerName} != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {{
                    var model = models[modelIndex];
                    var expectedModel = {TestsPart.TestDataArrayName}.First(wh => wh.{model.ModelInnerName} != null && wh.{model.ModelInner.IdName} == model.{model.ModelInner.IdName}).{model.ModelInnerName};
                    {model.ModelInner.ClassName}.{ModelGenerator.AssertMethodName}(model, expectedModel, false);
                }}
            }}
        }}
");
        }
    }
}