using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestsGenerator.Enums;
using TestsGenerator.Helpers;
using TestsGenerator.Model;
using TestsGenerator.TypeValueHelpers;

namespace TestsGenerator.Generators.PostgreSQL
{
    internal static class BinaryExportModelInnerTest
    {
        private static string _testName = "ExportModelInner";

        public static void Generate(
            int order,
            StringBuilder stringBuilder,
            Model.ModelType model,
            ModelValueStorage storage
            )
        {
            if (model.ValueStorage is CharValueHelper)
            {
                return;
            }

            ExportModelInnerConfig(stringBuilder, model);

            var ordered = 
                storage.Values
                .Where(wh => wh.InnerModel != null)
                .Select(sel => sel.InnerModel)
                .OrderBy(or => or.IdValue)
                .ToList()
                ;

            ExportModelInnerTest(order, model, stringBuilder, ordered, false);
            ExportModelInnerTest(order, model, stringBuilder, ordered, true);
        }

        private static void ExportModelInnerConfig(
            StringBuilder stringBuilder,
            Model.ModelType model
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
            accessModifier: AccessModifier.Private
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
            StringBuilder stringBuilder,
            List<InnerModelValue> storage,
            bool isAsync
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
                var models = {await} {_testName}{async}(connection).ToList{async}();
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