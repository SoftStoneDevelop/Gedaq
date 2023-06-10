using System.Text;
using TestsGenerator.Enums;
using TestsGenerator.Model;

namespace TestsGenerator.Generators
{
    internal static class InsertModelTest
    {
        private static string _testName = "InsertModel";

        public static void Generate(
            int order,
            StringBuilder stringBuilder,
            Model.ModelType model,
            ModelValueStorage storage,
            Database database
            )
        {
            int i = 0;
            switch (database)
            {
                case Database.PostgreSQL:
                {
                    PostgreSQL.InsertModelTest.Generate(order, stringBuilder, model, storage, ref i);
                    break;
                }
                case Database.MsSQL:
                {
                    break;
                }
                case Database.MySQL:
                {
                    break;
                }
            }

            DbConnectionInsertModelConfig(order, stringBuilder, model);
            DbConnectionInsertModelTest(order, stringBuilder, storage, ref i, i + 2, isAsync: false);

            if(i + 2 >= storage.Values.Count)
            {
                throw new System.ArgumentOutOfRangeException(nameof(i));
            }
            DbConnectionInsertModelTest(order, stringBuilder, storage, ref i, storage.Values.Count, isAsync: true);
        }

        private static void DbConnectionInsertModelConfig(
            int order,
            StringBuilder stringBuilder,
            Model.ModelType model
            )
        {
            stringBuilder.Append($@"
[Gedaq.DbConnection.Attributes.Query(
            query: @""
INSERT INTO public.{model.TableName}(
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
);
"",
            methodName:""DbConnection{_testName}"",
            queryMapType: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Private
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
        [Test, Order({order})]
        public void DbConnection{_testName}Config()
        {{
        }}
");
        }

        private static void DbConnectionInsertModelTest(
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
                changedRows = {await} DbConnection{_testName}{async}(connection, {value.Id}, {value.Value}, {value.NullableValue}, {(value.InnerModel == null ? "null" : value.InnerModel.IdValue)});
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