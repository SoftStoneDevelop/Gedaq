using System.Text;
using TestsGenerator.Model;

namespace TestsGenerator.Generators.PostgreSQL
{
    internal static class InsertModelInner
    {
        private static string _testName = "InsertModelInner";

        public static void Generate(
            int order,
            StringBuilder stringBuilder,
            Model.ModelType model,
            ModelValueStorage storage,
            ref int indexValue
            )
        {
            InsertModelInnerConfig(stringBuilder, model);
            InsertModelInnerTest(order, stringBuilder, storage, ref indexValue, indexValue + 4, isAsync: false);
            InsertModelInnerTest(order, stringBuilder, storage, ref indexValue, indexValue + 4, isAsync: true);

            InsertModelInnerReturningConfig(stringBuilder, model);
            InsertModelInnerReturningTest(order, stringBuilder, storage, model, ref indexValue, indexValue + 4, isAsync: false);
            InsertModelInnerReturningTest(order, stringBuilder, storage, model, ref indexValue, indexValue + 4, isAsync: true);
        }

        private static void InsertModelInnerConfig(
            StringBuilder stringBuilder,
            Model.ModelType model
            )
        {
            stringBuilder.Append($@"
[Gedaq.Npgsql.Attributes.Query(
            query: @""
INSERT INTO public.{model.ModelInner.TableName}(
	{model.ModelInner.IdColumnName},
    {model.ModelInner.ValueColumnName},
    {model.ModelInner.NullableValueColumnName}
)
VALUES (
    $1, 
    $2, 
    $3
);
"",
            methodName:""{_testName}"",
            queryMapType: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Private
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof({model.ModelInner.IdType}),
                position: 1,
                methodParametrName: ""{model.ModelInner.IdColumnName}"", 
                dbType: {model.ModelInner.IdTypeInfo.SpecialDbTypeStr()}
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof({model.ModelInner.ValueType}),
                position: 2,
                methodParametrName: ""{model.ModelInner.ValueColumnName}"",
                dbType: {model.ModelInner.TypeInfo.SpecialDbTypeStr()}
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof({model.ModelInner.NullableValueType}), 
                position: 3,
                methodParametrName: ""{model.ModelInner.NullableValueColumnName}"",
                dbType: {model.ModelInner.TypeInfo.SpecialDbTypeStr()}
                )
            ]
        public void {_testName}Config()
        {{
        }}
");
        }

        private static void InsertModelInnerTest(
            int order,
            StringBuilder stringBuilder,
            ModelValueStorage storage,
            ref int indexValue,
            int endIndex,
            bool isAsync
            )
        {
            if (endIndex > storage.Values.Count)
            {
                throw new System.ArgumentOutOfRangeException(nameof(endIndex));
            }

            var await = isAsync ? "await" : string.Empty;
            var async = isAsync ? "Async" : string.Empty;
            stringBuilder.Append($@"
        [Test, Order({order})]
        public async Task {_testName}Test{async}()
        {{
            await using (var connection = GlobalSetUp.GetConnection)
            {{
                await connection.OpenAsync();
                int changedRows = 0;
");
            for (; indexValue < endIndex; indexValue++)
            {
                ModelValue value = storage.Values[indexValue];
                if (value.InnerModel == null)
                {
                    continue;
                }

                stringBuilder.Append($@"
                changedRows = {await} {_testName}{async}(connection, {value.InnerModel.Id}, {value.InnerModel.Value}, {value.InnerModel.NullableValue});
                Assert.That(changedRows, Is.EqualTo(1));
");
            }
            stringBuilder.Append($@"
            }}
        }}
");
        }

        private static void InsertModelInnerReturningConfig(
            StringBuilder stringBuilder,
            Model.ModelType model
            )
        {
            stringBuilder.Append($@"
[Gedaq.Npgsql.Attributes.Query(
            query: @""
INSERT INTO public.{model.ModelInner.TableName}(
	{model.ModelInner.IdColumnName},
    {model.ModelInner.ValueColumnName},
    {model.ModelInner.NullableValueColumnName}
)
VALUES (
    $1, 
    $2, 
    $3
)
RETURNING
    {model.ModelInner.IdColumnName},
    {model.ModelInner.ValueColumnName},
    {model.ModelInner.NullableValueColumnName}
;
"",
            methodName:""{_testName}Returning"",
            queryMapType: typeof({model.ModelInner.ClassName}),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Private
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof({model.ModelInner.IdType}), 
                position: 1,
                methodParametrName: ""{model.ModelInner.IdColumnName}"", 
                dbType: {model.ModelInner.IdTypeInfo.SpecialDbTypeStr()}
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof({model.ModelInner.ValueType}),
                position: 2,
                methodParametrName: ""{model.ModelInner.ValueColumnName}"",
                dbType: {model.ModelInner.TypeInfo.SpecialDbTypeStr()}
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof({model.ModelInner.NullableValueType}), 
                position: 3, 
                methodParametrName: ""{model.ModelInner.NullableValueColumnName}"", 
                dbType: {model.ModelInner.TypeInfo.SpecialDbTypeStr()}
                )
            ]
        public void {_testName}ReturningConfig()
        {{
        }}
");
        }

        private static void InsertModelInnerReturningTest(
            int order,
            StringBuilder stringBuilder,
            ModelValueStorage storage,
            Model.ModelType model,
            ref int indexValue,
            int endIndex,
            bool isAsync
            )
        {
            if (endIndex > storage.Values.Count)
            {
                throw new System.ArgumentOutOfRangeException(nameof(endIndex));
            }

            var await = isAsync ? "await" : string.Empty;
            var async = isAsync ? "Async" : string.Empty;
            stringBuilder.Append($@"
        [Test, Order({order})]
        public async Task {_testName}TestReturning{async}()
        {{
            await using (var connection = GlobalSetUp.GetConnection)
            {{
                await connection.OpenAsync();
                {model.ModelInner.IdType} id = default;
");
            for (; indexValue < endIndex; indexValue++)
            {
                ModelValue value = storage.Values[indexValue];
                if (value.InnerModel == null)
                {
                    continue;
                }

                stringBuilder.Append($@"
                id = {await} {_testName}Returning{async}(connection, {value.InnerModel.Id}, {value.InnerModel.Value}, {value.InnerModel.NullableValue});
                Assert.That(id, Is.EqualTo({value.InnerModel.Id}));
");
            }
            stringBuilder.Append($@"
            }}
        }}
");
        }
    }
}