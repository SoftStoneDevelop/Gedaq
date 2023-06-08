using System.Text;
using TestsGenegator.Enums;

namespace TestsGenegator.Generators
{
    internal static class InsertModelInnerTest
    {
        public static void Generate(
            int order,
            StringBuilder stringBuilder,
            Model.Model model, 
            Database database
            )
        {
            switch (database)
            {
                case Database.PostgreSQL:
                {
                    stringBuilder.AppendLine($@"
[Query(
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
            methodName:""Insert"",
            queryMapType: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Private
            ), 
            Parametr(typeof({model.ModelInner.IdType}), position: 1, methodParametrName: ""{model.ModelInner.IdColumnName}""),
            Parametr(typeof({model.ModelInner.ValueType}), position: 2, methodParametrName: ""{model.ModelInner.ValueColumnName}""),
            Parametr(typeof({model.ModelInner.NullableValueType}), position: 3, methodParametrName: ""{model.ModelInner.NullableValueColumnName}"")
            ]
        [Test, Order({order})]
        public async Task InsertModelInnerTest()
        {{
            await using (var connection = GlobalSetUp.GetConnection)
            {{
                await connection.OpenAsync();
                //Insert(connection, 1, 1, null);
            }}
        }}
");
                    return;
                }
                case Database.MsSQL:
                {
                    return;
                }
                case Database.MySQL:
                {
                    return;
                }
            }
        }
    }
}