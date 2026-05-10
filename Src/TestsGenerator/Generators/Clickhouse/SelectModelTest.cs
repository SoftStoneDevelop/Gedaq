using TestsGenerator.Constants;
using TestsGenerator.Enums;
using TestsGenerator.Helpers;
using TestsGenerator.TypeInfos;

namespace TestsGenerator.Generators.Clickhouse
{
    internal static class SelectModelTest
    {
        private const string _methodName = "SelectModel";

        public static void Generate(
            int order,
            StringBuilderArray.StringBuilderArray stringBuilder,
            Model.ModelType model,
            string interfaceTypeName)
        {
            SelectModelDbConnectionConfig(
                stringBuilder, 
                model,
                interfaceTypeName);

            for (int i = 0; i < ValueConstants.BoolValues.Length; i++)
            {
                bool isAsync = ValueConstants.BoolValues[i];

                SelectDbConnectionTest(
                    order,
                    stringBuilder,
                    model,
                    isAsync: isAsync,
                    interfaceTypeName);
            }
        }

        private static void SelectModelDbConnectionConfig(
            StringBuilderArray.StringBuilderArray stringBuilder,
            Model.ModelType model,
            string interfaceTypeName)
        {
            stringBuilder.Append($@"
[Gedaq.DbConnection.Attributes.Query(
            query: @""
SELECT INTO {Database.Clickhouse.ToDefaultSchema()}.{model.TableName}(
	m_{model.IdColumnName} AS {model.IdColumnName},
    m_{model.ValueColumnName} AS {model.ValueColumnName},
~StartInner::{model.ModelInnerName}:{model.ModelInner.IdColumnName}~
~Reinterpret::{model.ModelInner.IdColumnName}~
    mi_{model.ModelInner.IdColumnName},
~Reinterpret::{model.ModelInner.ValueColumnName}~
    mi_{model.ModelInner.ValueColumnName}
~EndInner::{model.ModelInnerName}~
FROM {Database.Clickhouse.ToDefaultSchema()}.{model.TableName}
WHERE
    m_{model.IdColumnName} = @m_{model.IdColumnName}:{((ClickhouseTypeInfo)model.IdTypeInfo).ClickHouseType}
"",
            methodName:""{SelectMethodName()}"",
            queryMapTypes: [typeof({model.ClassName(false, false)})],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof({interfaceTypeName})),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof({model.IdTypeInfo.TypeFullName}), 
                parametrName: ""m_{model.IdColumnName}"", 
                methodParametrName: ""m_{model.IdColumnName}"")]
        public void {SelectMethodName()}Config()
        {{
        }}
");
        }

        private static string SelectMethodName()
        {
            return $"{_methodName}DbConnection";
        }

        private static void SelectDbConnectionTest(
            int order,
            StringBuilderArray.StringBuilderArray stringBuilder,
            Model.ModelType model,
            bool isAsync,
            string interfaceTypeName)
        {
            var await = isAsync ? "await" : string.Empty;
            var async = isAsync ? "Async" : string.Empty;
            stringBuilder.Append($@"
        [Test, Order({order})]
        public async Task {SelectMethodName()}Test{async}()
        {{
            await using (var connection = GlobalSetUp.GetConnection)
            {{
                await connection.OpenAsync();
                for (int i = 0; i < {TestsPart.TestDataArrayName}.Length; i++)
                {{
                    var models = {await} {TypeHelper.ThisAsInterface(interfaceTypeName)}.{SelectMethodName()}{async}(
                        connection,
                        m_{model.IdColumnName}: {TestsPart.TestDataArrayName}[i].{model.IdName});
                    Assert.That(models, Has.Count.EqualTo(1));
                    {model.ClassName(false, false)}.{ModelGenerator.AssertMethodName}(models[0],{TestsPart.TestDataArrayName}[i], false);
                }}
            }}
        }}
");
        }
    }
}