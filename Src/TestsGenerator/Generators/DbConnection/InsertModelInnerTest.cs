using TestsGenerator.Enums;
using TestsGenerator.Helpers;
using TestsGenerator.Model;

namespace TestsGenerator.Generators.DbConnection
{
    internal static class InsertModelInner
    {
        private const string _testName = "InsertInnerModel";

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
            DbConnectionInsertModelInnerConfig(
                stringBuilder, 
                model, 
                database, 
                interfaceTypeName
                );
            DbConnectionInsertModelInnerTest(
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
            DbConnectionInsertModelInnerTest(
                order, 
                stringBuilder, 
                storage, 
                ref index, 
                endIndex, 
                isAsync: true,
                interfaceTypeName
                );
        }

        private static void DbConnectionInsertModelInnerConfig(
            StringBuilderArray.StringBuilderArray stringBuilder,
            Model.ModelType model,
            Database database,
            string interfaceTypeName
            )
        {
            stringBuilder.Append($@"
[Gedaq.DbConnection.Attributes.Query(
            query: @""
INSERT INTO {database.ToDefaultSchema()}.{model.ModelInner.TableName}(
	{model.ModelInner.IdColumnName},
    {model.ModelInner.ValueColumnName},
    {model.ModelInner.NullableValueColumnName}
)
VALUES (
    @{model.ModelInner.IdColumnName},
    @{model.ModelInner.ValueColumnName}, 
    @{model.ModelInner.NullableValueColumnName}
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
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof({model.ModelInner.IdType}), 
                parametrName: ""{model.ModelInner.IdColumnName}"", 
                methodParametrName: ""{model.ModelInner.IdColumnName}"", 
                dbType: {model.ModelInner.IdTypeInfo.DbTypeStr()}
                ),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof({model.ModelInner.ValueType}), 
                parametrName: ""{model.ModelInner.ValueColumnName}"", 
                methodParametrName: ""{model.ModelInner.ValueColumnName}"", 
                dbType: {model.ModelInner.TypeInfo.DbTypeStr()}
                ),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof({model.ModelInner.NullableValueType}), 
                parametrName: ""{model.ModelInner.NullableValueColumnName}"", 
                methodParametrName: ""{model.ModelInner.NullableValueColumnName}"", 
                dbType: {model.ModelInner.TypeInfo.DbTypeStr()}, 
                nullable: true
                )
            ]
        public void DbConnection{_testName}Config()
        {{
        }}
");
        }

        private static void DbConnectionInsertModelInnerTest(
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
                if (value.InnerModel == null)
                {
                    continue;
                }

                stringBuilder.Append($@"
                changedRows = {await} {TypeHelper.ThisAsInterface(interfaceTypeName)}.DbConnection{_testName}{async}(connection, {value.InnerModel.Id}, {value.InnerModel.Value}, {value.InnerModel.NullableValue});
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