using TestsGenerator.Enums;
using TestsGenerator.Helpers;
using TestsGenerator.Model;

namespace TestsGenerator.Generators.DbConnection
{
    internal static class InsertModel
    {
        private const string _testName = "InsertModel";

        public static void Generate(
            int order,
            StringBuilderArray.StringBuilderArray stringBuilder,
            Model.ModelType model,
            ModelValueStorage storage,
            Database database,
            ref int index,
            string interfaceTypeName,
            bool toEnd = false
            )
        {
            DbConnectionInsertModelConfig(
                stringBuilder, 
                model, 
                database,
                interfaceTypeName
                );
            DbConnectionInsertModelTest(
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

            var endIndex = toEnd ? storage.Values.Count : index + 2;
            DbConnectionInsertModelTest(
                order, 
                stringBuilder, 
                storage, 
                ref index, 
                endIndex, 
                isAsync: true,
                interfaceTypeName
                );
        }

        private static void DbConnectionInsertModelConfig(
            StringBuilderArray.StringBuilderArray stringBuilder,
            Model.ModelType model,
            Database database,
            string interfaceTypeName
            )
        {
            stringBuilder.Append($@"
[Gedaq.DbConnection.Attributes.Query(
            query: @""
INSERT INTO {database.ToDefaultSchema()}.{model.TableName}(
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
            methodName:""DbConnection{_testName}"",
            queryMapType: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof({interfaceTypeName})
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof({model.ModelInner.IdType}), parametrName: ""{model.ModelInner.IdColumnName}"", methodParametrName: ""{model.ModelInner.IdColumnName}"", dbType: {model.IdTypeInfo.DbTypeStr()}),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof({model.ModelInner.ValueType}), parametrName: ""{model.ModelInner.ValueColumnName}"", methodParametrName: ""{model.ModelInner.ValueColumnName}"", dbType: {model.TypeInfo.DbTypeStr()}),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof({model.ModelInner.NullableValueType}), 
                parametrName: ""{model.ModelInner.NullableValueColumnName}"", 
                methodParametrName: ""{model.ModelInner.NullableValueColumnName}"", 
                dbType: {model.TypeInfo.DbTypeStr()},
                nullable: true
),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof({model.ModelInner.IdType}?), 
                parametrName: ""{model.ModelInnerColumnName}"", 
                methodParametrName: ""{model.ModelInnerColumnName}"", 
                dbType: {model.ModelInner.IdTypeInfo.DbTypeStr()},
                nullable: true
            )
            ]
        public void DbConnection{_testName}Config()
        {{
        }}
");
        }

        private static void DbConnectionInsertModelTest(
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
        public async Task DbConnection{_testName}Test{async}()
        {{
            await using (var connection = GlobalSetUp.GetDbConnection)
            {{
                await connection.OpenAsync();
                int changedRows = 0;
");
            for (; indexValue < endIndex; indexValue++)
            {
                ModelValue value = storage.Values[indexValue];
                stringBuilder.Append($@"
                changedRows = {await} {TypeHelper.ThisAsInterface(interfaceTypeName)}.DbConnection{_testName}{async}(connection, {value.Id}, {value.Value}, {value.NullableValue}, {(value.InnerModel == null ? "null" : value.InnerModel.IdValue)});
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