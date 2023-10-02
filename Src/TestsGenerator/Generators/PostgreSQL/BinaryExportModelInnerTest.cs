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
            string interfaceTypeName
            )
        {
            ExportModelInnerConfig(
                stringBuilder, 
                model,
                interfaceTypeName
                );

            var ordered = 
                storage.Values
                .Where(wh => wh.InnerModel != null)
                .Select(sel => sel.InnerModel)
                .OrderBy(or => or.IdValue)
                .ToList()
                ;

            ExportModelInnerTest(
                order, 
                model, 
                stringBuilder, 
                ordered, 
                false,
                interfaceTypeName
                );
            ExportModelInnerTest(
                order, 
                model, 
                stringBuilder, 
                ordered, 
                true, 
                interfaceTypeName
                );
        }

        private static void ExportModelInnerConfig(
            StringBuilderArray.StringBuilderArray stringBuilder,
            Model.ModelType model,
            string interfaceTypeName
            )
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
            asPartInterface: typeof({interfaceTypeName})
            )
            ]
        private void {_testName}Config()
        {{
        }}
");
        }

        private static void ExportModelInnerTest(
            int order,
            Model.ModelType model,
            StringBuilderArray.StringBuilderArray stringBuilder,
            List<InnerModelValue> storage,
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
                var expected = new Dictionary<{model.ModelInner.IdTypeInfo.ItemTypeFullName},{model.ModelInner.ClassName}>({storage.Count});
");
            for (; index < storage.Count; index++)
            {
                InnerModelValue value = storage[index];
                stringBuilder.Append($@"
                expected.Add(
                    {value.IdValue},
                    new {model.ModelInner.ClassName}
                    {{
                        {model.ModelInner.IdName} = {value.IdValue},
                        {model.ModelInner.ValueName} = {value.Value},
                        {model.ModelInner.NullableValueName} = {value.NullableValue}
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
{model.ModelInner.Assert("model", "expectedModel")}
");
            stringBuilder.Append($@"
                }}
            }}
        }}
");
        }
    }
}