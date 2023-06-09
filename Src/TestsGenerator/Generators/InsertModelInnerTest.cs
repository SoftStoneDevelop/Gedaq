using System.Text;
using TestsGenerator.Enums;
using TestsGenerator.Model;

namespace TestsGenerator.Generators
{
    internal static class InsertModelInnerTest
    {
        public static void Generate(
            int order,
            StringBuilder stringBuilder,
            Model.ModelType model, 
            ModelValueStorage storage,
            Database database
            )
        {
            var testName = "InsertInnerModelTest";
            int i = 0;
            switch (database)
            {
                case Database.PostgreSQL:
                {
                    stringBuilder.AppendLine($@"
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
            methodName:""InsertModelInner"",
            queryMapType: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Private
            ), 
            Gedaq.Npgsql.Attributes.Parametr(parametrType: typeof({model.ModelInner.IdType}), position: 1, methodParametrName: ""{model.ModelInner.IdColumnName}"", dbType: {model.ModelInner.IdTypeInfo.SpecialDbTypeStr()}),
            Gedaq.Npgsql.Attributes.Parametr(parametrType: typeof({model.ModelInner.ValueType}), position: 2, methodParametrName: ""{model.ModelInner.ValueColumnName}"", dbType: {model.ModelInner.TypeInfo.SpecialDbTypeStr()}),
            Gedaq.Npgsql.Attributes.Parametr(parametrType: typeof({model.ModelInner.NullableValueType}), position: 3, methodParametrName: ""{model.ModelInner.NullableValueColumnName}"", dbType: {model.ModelInner.TypeInfo.SpecialDbTypeStr()})
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
                        if (value.InnerModel == null)
                        {
                            continue;
                        }

                        stringBuilder.AppendLine($@"
                InsertModelInner(connection, {value.InnerModel.Id}, {value.InnerModel.Value}, {value.InnerModel.NullableValue});
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
INSERT INTO public.{model.ModelInner.TableName}(
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
            methodName:""DbConnectionInsertModelInner"",
            queryMapType: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Private
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof({model.ModelInner.IdType}), parametrName: ""{model.ModelInner.IdColumnName}"", methodParametrName: ""{model.ModelInner.IdColumnName}"", dbType: {model.ModelInner.IdTypeInfo.DbTypeStr()}),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof({model.ModelInner.ValueType}), parametrName: ""{model.ModelInner.ValueColumnName}"", methodParametrName: ""{model.ModelInner.ValueColumnName}"", dbType: {model.ModelInner.TypeInfo.DbTypeStr()}),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof({model.ModelInner.NullableValueType}), parametrName: ""{model.ModelInner.NullableValueColumnName}"", methodParametrName: ""{model.ModelInner.NullableValueColumnName}"", dbType: {model.ModelInner.TypeInfo.DbTypeStr()}, nullable: true)
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
                if (value.InnerModel == null)
                {
                    continue;
                }

                stringBuilder.AppendLine($@"
                DbConnectionInsertModelInner(connection, {value.InnerModel.Id}, {value.InnerModel.Value}, {value.InnerModel.NullableValue});
");
            }
            stringBuilder.AppendLine($@"
            }}
        }}
");
        }
    }
}