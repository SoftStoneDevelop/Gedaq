using System.Text;
using TestsGenerator.Enums;
using TestsGenerator.Model;

namespace TestsGenerator.Generators
{
    internal static class InsertModelTest
    {
        public static void Generate(
            int order,
            StringBuilder stringBuilder,
            Model.ModelType model,
            ModelValueStorage storage,
            Database database
            )
        {
            var testName = "InsertModelTest";
            int i = 0;
            switch (database)
            {
                case Database.PostgreSQL:
                {
                    stringBuilder.AppendLine($@"
[Gedaq.Npgsql.Attributes.Query(
            query: @""
INSERT INTO public.{model.TableName}(
	{model.IdColumnName},
    {model.ValueColumnName},
    {model.NullableValueColumnName},
    {model.ModelInner.TableName}_id
)
VALUES (
    $1, 
    $2, 
    $3,
    $4
);
"",
            methodName:""InsertModel"",
            queryMapType: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Private
            ), 
            Gedaq.Npgsql.Attributes.Parametr(parametrType: typeof({model.ModelInner.IdType}), position: 1, methodParametrName: ""{model.ModelInner.IdColumnName}"", dbType: {model.IdTypeInfo.SpecialDbTypeStr()}),
            Gedaq.Npgsql.Attributes.Parametr(parametrType: typeof({model.ModelInner.ValueType}), position: 2, methodParametrName: ""{model.ModelInner.ValueColumnName}"", dbType: {model.TypeInfo.SpecialDbTypeStr()}),
            Gedaq.Npgsql.Attributes.Parametr(parametrType: typeof({model.ModelInner.NullableValueType}), position: 3, methodParametrName: ""{model.ModelInner.NullableValueColumnName}"", dbType: {model.TypeInfo.SpecialDbTypeStr()}),
            Gedaq.Npgsql.Attributes.Parametr(parametrType: typeof({model.ModelInner.IdType}?), position: 4, methodParametrName: ""{model.ModelInner.TableName}_id"", dbType: {model.ModelInner.IdTypeInfo.SpecialDbTypeStr()})
            ]
        [Test, Order({order})]
        public async Task {testName}()
        {{
            await using (var connection = GlobalSetUp.GetConnection)
            {{
                await connection.OpenAsync();
");
                    for (; i < 5; i++)
                    {
                        ModelValue value = storage.Values[i];
                        stringBuilder.AppendLine($@"
                InsertModel(connection, {value.Id}, {value.Value}, {value.NullableValue}, {(value.InnerModel == null? "null" : value.InnerModel.IdValue)});
");
                    }
                    stringBuilder.AppendLine($@"
            }}
        }}
");
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

            stringBuilder.AppendLine($@"
[Gedaq.DbConnection.Attributes.Query(
            query: @""
INSERT INTO public.{model.TableName}(
	{model.IdColumnName},
    {model.ValueColumnName},
    {model.NullableValueColumnName},
    {model.ModelInner.TableName}_id
)
VALUES (
    @{model.ModelInner.IdColumnName}, 
    @{model.ModelInner.ValueColumnName}, 
    @{model.ModelInner.NullableValueColumnName},
    @{model.ModelInner.TableName}_id
);
"",
            methodName:""DbConnectionInsertModel"",
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
                parametrName: ""{model.ModelInner.TableName}_id"", 
                methodParametrName: ""{model.ModelInner.TableName}_id"", 
                dbType: {model.ModelInner.IdTypeInfo.DbTypeStr()},
                nullable: true
            )
            ]
        [Test, Order({order})]
        public async Task DbConnection{testName}()
        {{
            await using (var connection = GlobalSetUp.GetDbConnection)
            {{
                await connection.OpenAsync();
");
            for (; i < storage.Values.Count; i++)
            {
                ModelValue value = storage.Values[i];
                stringBuilder.AppendLine($@"
                DbConnectionInsertModel(connection, {value.Id}, {value.Value}, {value.NullableValue}, {(value.InnerModel == null ? "null" : value.InnerModel.IdValue)});
");
            }
            stringBuilder.AppendLine($@"
            }}
        }}
");
        }
    }
}