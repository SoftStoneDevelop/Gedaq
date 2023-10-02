using System.Collections.Generic;
using System.Linq;
using TestsGenerator.Constants;
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
            string interfaceTypeName
            )
        {
            ExportModelConfig(
                stringBuilder, 
                model,
                interfaceTypeName
                );

            var ordered = 
                storage.Values
                .OrderBy(or => or.IdValue)
                .ToList()
                ;

            ExportModelTest(
                order, 
                model, 
                stringBuilder, 
                ordered, 
                false,
                interfaceTypeName
                );
            ExportModelTest(
                order, 
                model, 
                stringBuilder, 
                ordered, 
                true,
                interfaceTypeName
                );
        }

        private static void ExportModelConfig(
            StringBuilderArray.StringBuilderArray stringBuilder,
            Model.ModelType model,
            string interfaceTypeName
            )
        {
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
            queryMapType: typeof({model.ClassName}),
            dbTypes:
            new NpgsqlDbType[]
            {{
                {model.IdTypeInfo.SpecialDbTypeStr()},
                {model.ModelInner.TypeInfo.SpecialDbTypeStr()},
                {model.ModelInner.IdTypeInfo.SpecialDbTypeStr()},
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

        private static void ExportModelTest(
            int order,
            Model.ModelType model,
            StringBuilderArray.StringBuilderArray stringBuilder,
            List<ModelValue> storage,
            bool isAsync,
            string interfaceTypeName
            )
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
");
            var index = 0;
            stringBuilder.Append($@"
                var expected = new Dictionary<{model.IdTypeInfo.ItemTypeFullName},{model.ClassName}>({storage.Count});
");
            for (; index < storage.Count; index++)
            {
                ModelValue value = storage[index];
                stringBuilder.Append($@"
                expected.Add(
                    {value.IdValue},
                    new {model.ClassName}
                    {{
                        {model.IdName} = {value.IdValue},
                        {model.ValueName} = {value.Value},
                        {model.NullableValueName} = {value.NullableValue},
");
                if(value.InnerModel == null)
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
                            {model.ModelInner.IdName} = {value.InnerModel.IdValue},
                            {model.ModelInner.ValueName} = {value.InnerModel.Value},
                            {model.ModelInner.NullableValueName} = {value.InnerModel.NullableValue}
                        }}
");
                }
                stringBuilder.Append($@"
                    }}
                );
");
            }
            stringBuilder.Append($@"
                var models = {await} {TypeHelper.ThisAsInterface(interfaceTypeName)}.{_testName}{async}(connection).ToList{async}();
                Assert.That(models, Has.Count.EqualTo(expected.Count));
                for(int modelIndex = 0; modelIndex < models.Count; modelIndex++)
                {{
                    var model = models[modelIndex];
                    var expectedModel = expected[model.{model.ModelInner.IdName}];
{model.Assert("model", "expectedModel", true)}
");
            stringBuilder.Append($@"
                }}
            }}
        }}
");
        }
    }
}