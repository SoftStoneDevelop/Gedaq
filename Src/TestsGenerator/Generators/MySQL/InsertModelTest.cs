using TestsGenerator.Enums;
using TestsGenerator.Helpers;
using TestsGenerator.Model;

namespace TestsGenerator.Generators.MySQL
{
    internal static class InsertModel
    {
        private const string _testName = "InsertModel";

        public static void Generate(
            int order,
            StringBuilderArray.StringBuilderArray stringBuilder,
            Model.ModelType model,
            ModelValueStorage storage,
            string interfaceTypeName
            )
        {
            var index = 0;
            InsertModelConfig(
                stringBuilder, 
                model,
                interfaceTypeName
                );
            InsertModelTest(
                order, 
                stringBuilder, 
                storage, 
                ref index, 
                index + 2, 
                isAsync: false,
                interfaceTypeName
                );

            if (index + 2 >= storage.Values.Count)
            {
                throw new System.ArgumentOutOfRangeException(nameof(index));
            }

            InsertModelTest(
                order, 
                stringBuilder, 
                storage, 
                ref index, 
                index + 2, 
                isAsync: true,
                interfaceTypeName
                );

            DbConnection.InsertModel.Generate(
                order, 
                stringBuilder, 
                model, 
                storage, 
                Database.MySQL, 
                ref index, 
                interfaceTypeName,
                toEnd: true
                );
        }

        private static void InsertModelConfig(
            StringBuilderArray.StringBuilderArray stringBuilder,
            Model.ModelType model,
            string interfaceTypeName
            )
        {
            stringBuilder.Append($@"
[Gedaq.MySqlConnector.Attributes.Query(
            query: @""
INSERT INTO {Database.MySQL.ToDefaultSchema()}.{model.TableName}(
	{model.IdColumnName},
    {model.ValueColumnName},
    {model.NullableValueColumnName},
    {model.ModelInnerColumnName}
)
VALUES (
    @{model.ModelInner.IdColumnName}, 
    @{model.ModelInner.ValueColumnName}, 
    @{model.ModelInner.NullableValueColumnName},
    @{model.ModelInnerColumnName}
)
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
                dbType: {model.IdTypeInfo.SpecialDbTypeStr()}
            ),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof({model.ModelInner.ValueType}), 
                parametrName: ""{model.ModelInner.ValueColumnName}"", 
                methodParametrName: ""{model.ModelInner.ValueColumnName}"", 
                dbType: {model.TypeInfo.SpecialDbTypeStr()}
            ),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof({model.ModelInner.NullableValueType}), 
                parametrName: ""{model.ModelInner.NullableValueColumnName}"", 
                methodParametrName: ""{model.ModelInner.NullableValueColumnName}"", 
                dbType: {model.TypeInfo.SpecialDbTypeStr()},
                nullable: true
            ),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof({model.ModelInner.IdType}?), 
                parametrName: ""{model.ModelInnerColumnName}"", 
                methodParametrName: ""{model.ModelInnerColumnName}"", 
                dbType: {model.ModelInner.IdTypeInfo.SpecialDbTypeStr()},
                nullable: true
            )
            ]
        public void {_testName}Config()
        {{
        }}
");
        }

        private static void InsertModelTest(
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
                stringBuilder.Append($@"
                changedRows = {await} {TypeHelper.ThisAsInterface(interfaceTypeName)}.{_testName}{async}(connection, {value.Id}, {value.Value}, {value.NullableValue}, {(value.InnerModel == null ? "null" : value.InnerModel.IdValue)});
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