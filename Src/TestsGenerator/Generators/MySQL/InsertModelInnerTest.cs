using TestsGenerator.Enums;
using TestsGenerator.Helpers;
using TestsGenerator.Model;

namespace TestsGenerator.Generators.MySQL
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

            InsertModelInnerTest(
                order, 
                stringBuilder, 
                storage, 
                ref indexValue, 
                indexValue + 4,
                isAsync: false,
                interfaceTypeName
                );

            var canDbConnection = model.TypeInfo.EnumerableType == EnumerableType.SingleType;
            int endIndex = !canDbConnection ? storage.Values.Count : indexValue + 4;
            InsertModelInnerTest(
                order, 
                stringBuilder, 
                storage, 
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
                    Database.MySQL, 
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
[Gedaq.MySqlConnector.Attributes.Query(
            query: @""
INSERT INTO {Database.MySQL.ToDefaultSchema()}.{model.ModelInner.TableName}(
	{model.ModelInner.IdColumnName},
    {model.ModelInner.ValueColumnName},
    {model.ModelInner.NullableValueColumnName}
)
VALUES (
    @{model.ModelInner.IdColumnName}, 
    @{model.ModelInner.ValueColumnName}, 
    @{model.ModelInner.NullableValueColumnName}
);
"",
            methodName:""{_testName}"",
            sourceType: SourceType.MySqlConnection,
            queryMapType: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof({interfaceTypeName})
            ), 
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof({model.ModelInner.IdType}),
                parametrName: ""{model.ModelInner.IdColumnName}"",
                methodParametrName: ""{model.ModelInner.IdColumnName}"", 
                dbType: {model.ModelInner.IdTypeInfo.SpecialDbTypeStr()}
                ),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof({model.ModelInner.ValueType}),
                parametrName: ""{model.ModelInner.ValueColumnName}"",
                methodParametrName: ""{model.ModelInner.ValueColumnName}"",
                dbType: {model.ModelInner.TypeInfo.SpecialDbTypeStr()}
                ),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof({model.ModelInner.NullableValueType}), 
                parametrName: ""{model.ModelInner.NullableValueColumnName}"",
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
    }
}