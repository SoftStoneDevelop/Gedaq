using TestsGenerator.Enums;
using TestsGenerator.Helpers;
using TestsGenerator.Model;

namespace TestsGenerator.Generators.PostgreSQL
{
    internal static class InsertModelInner
    {
        private const string _testName = "InsertModelInner";

        public static void Generate(
            int order,
            StringBuilderArray.StringBuilderArray stringBuilder,
            Model.ModelType model,
            ModelValueStorage storage,
            string interfaceTypeName
            )
        {
            var indexValue = 0;
            InsertModelInnerConfig(
                stringBuilder, 
                model,
                interfaceTypeName
                );
            InsertModelInnerReturningConfig(
                stringBuilder, 
                model,
                interfaceTypeName
                );

            InsertModelInnerTest(
                order, 
                stringBuilder, 
                storage, 
                ref indexValue, 
                indexValue + 4, 
                isAsync: false,
                interfaceTypeName
                );
            InsertModelInnerTest(
                order, 
                stringBuilder, 
                storage, 
                ref indexValue, 
                indexValue + 4, 
                isAsync: true, 
                interfaceTypeName
                );

            InsertModelInnerReturningTest(
                order, 
                stringBuilder, 
                storage, 
                model, 
                ref indexValue, 
                indexValue + 4, 
                isAsync: false, 
                interfaceTypeName
                );
            var canDbConnection = model.TypeInfo.EnumerableType == EnumerableType.SingleType;
            int endIndex = !canDbConnection ? storage.Values.Count : indexValue + 4;
            InsertModelInnerReturningTest(
                order, 
                stringBuilder, 
                storage, 
                model, 
                ref indexValue, 
                endIndex, 
                isAsync: true, 
                interfaceTypeName
                );

            if (canDbConnection)
                DbConnection.InsertModelInner.Generate(
                    order, 
                    stringBuilder, 
                    model, 
                    storage, 
                    Database.PostgreSQL, 
                    ref indexValue, 
                    interfaceTypeName,
                    toEnd: true
                    );
        }

        private static void InsertModelInnerConfig(
            StringBuilderArray.StringBuilderArray stringBuilder,
            Model.ModelType model,
            string interfaceTypeName
            )
        {
            stringBuilder.Append($@"
[Gedaq.Npgsql.Attributes.Query(
            query: @""
INSERT INTO {Database.PostgreSQL.ToDefaultSchema()}.{model.ModelInner.TableName}(
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
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof({interfaceTypeName})
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
            StringBuilderArray.StringBuilderArray stringBuilder,
            ModelValueStorage storage,
            ref int indexValue,
            int endIndex,
            bool isAsync,
            string interfaceTypeName
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
                changedRows = {await} {TypeHelper.ThisAsInterface(interfaceTypeName)}.{_testName}{async}(connection, {value.InnerModel.Id}, {value.InnerModel.Value}, {value.InnerModel.NullableValue});
                Assert.That(changedRows, Is.EqualTo(1));
");
            }
            stringBuilder.Append($@"
            }}
        }}
");
        }

        private static void InsertModelInnerReturningConfig(
            StringBuilderArray.StringBuilderArray stringBuilder,
            Model.ModelType model,
            string interfaceTypeName
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
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof({interfaceTypeName})
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
            StringBuilderArray.StringBuilderArray stringBuilder,
            ModelValueStorage storage,
            Model.ModelType model,
            ref int indexValue,
            int endIndex,
            bool isAsync,
            string interfaceTypeName
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
                id = {await} {TypeHelper.ThisAsInterface(interfaceTypeName)}.{_testName}Returning{async}(connection, {value.InnerModel.Id}, {value.InnerModel.Value}, {value.InnerModel.NullableValue});
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