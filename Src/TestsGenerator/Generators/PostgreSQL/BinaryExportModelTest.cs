using System.Collections.Generic;
using System.Linq;
using TestsGenerator.Enums;
using TestsGenerator.Helpers;
using TestsGenerator.Model;

namespace TestsGenerator.Generators.PostgreSQL
{
    internal static class BinaryExportModelTest
    {
        private const string _testName = "ExportModel";

        public static void Generate(
            int order,
            StringBuilderArray.StringBuilderArray stringBuilder,
            Model.ModelType model,
            ModelValueStorage storage,
            string interfaceTypeName)
        {
            ExportModelConfig(
                stringBuilder, 
                model,
                interfaceTypeName);

            var ordered = 
                storage.Values
                .OrderBy(or => or.IdValue)
                .ToList();

            ExportModelTest(
                order, 
                model, 
                stringBuilder, 
                ordered, 
                false,
                interfaceTypeName);

            ExportModelTest(
                order, 
                model, 
                stringBuilder, 
                ordered, 
                true,
                interfaceTypeName);
        }

        private static void ExportModelConfig(
            StringBuilderArray.StringBuilderArray stringBuilder,
            Model.ModelType model,
            string interfaceTypeName)
        {
            var dbTypeOverride = $@",
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {{
                {model.IdTypeInfo.SpecialDbTypeStr()},
                {model.ModelInner.TypeInfo.SpecialDbTypeStr()},
                {model.ModelInner.IdTypeInfo.SpecialDbTypeStr()},
                {model.ModelInner.TypeInfo.SpecialDbTypeStr()}
            }})";

            stringBuilder.Append($@"
[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @""
COPY {Database.PostgreSQL.ToDefaultSchema()}.binary_{model.TableName}
(
    {model.IdColumnName},
    {model.NullableValueColumnName},
~StartInner::{model.ModelInnerName}:{model.ModelInner.IdName}~
    ~Reinterpret::{model.ModelInner.IdName}~
    {model.ModelInnerColumnName},
~EndInner::{model.ModelInnerName}~
    {model.ValueColumnName}
) TO STDOUT (FORMAT BINARY)
"",
            methodName:""{_testName}"",
            queryMapTypes: [typeof({model.ClassName(false)})],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof({interfaceTypeName})){dbTypeOverride}]
        private void {_testName}Config()
        {{
        }}
");
        }

        private static void ExportModelTest(
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
                Assert.That(models, Has.Count.EqualTo({TestsPart.TestDataArrayName}.Count()));
                for(int modelIndex = 0; modelIndex < {TestsPart.TestDataArrayName}.Count(); modelIndex++)
                {{
                    var model = models[modelIndex];
                    var expectedModel = {TestsPart.TestDataArrayName}.First(wh => wh.{model.IdName} == model.{model.IdName});
                    {model.ClassName(false)}.{ModelGenerator.AssertMethodName}(model, expectedModel, true);
                }}
            }}
        }}
");
        }
    }
}