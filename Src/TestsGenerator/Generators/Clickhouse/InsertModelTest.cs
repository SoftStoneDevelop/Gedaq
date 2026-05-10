using TestsGenerator.Constants;
using TestsGenerator.Enums;
using TestsGenerator.Helpers;
using TestsGenerator.Model;
using TestsGenerator.TypeInfos;

namespace TestsGenerator.Generators.Clickhouse
{
    internal static class InsertModel
    {
        private const string _methodName = "InsertModel";

        public static void Generate(
            int order,
            StringBuilderArray.StringBuilderArray stringBuilder,
            Model.ModelType model,
            ModelValueStorage storage,
            string interfaceTypeName)
        {
            var index = 0;
            InsertModelDbConnectionConfig(
                stringBuilder, 
                model,
                interfaceTypeName);

            for (int i = 0; i < ValueConstants.BoolValues.Length; i++)
            {
                bool isAsync = ValueConstants.BoolValues[i];

                var isLastIter = i == ValueConstants.BoolValues.Length - 1;
                int endIndex;
                if (isLastIter)
                {
                    endIndex = storage.Values.Count - 1;
                    if (endIndex == index)
                    {
                        throw new System.ArgumentOutOfRangeException(nameof(index));
                    }
                }
                else
                {
                    endIndex = index + 2;
                }

                InsertModelDbConnectionTest(
                    order,
                    stringBuilder,
                    storage,
                    model,
                    ref index,
                    endIndex,
                    isAsync: isAsync,
                    interfaceTypeName);
            }
        }

        private static void InsertModelDbConnectionConfig(
            StringBuilderArray.StringBuilderArray stringBuilder,
            Model.ModelType model,
            string interfaceTypeName)
        {
            stringBuilder.Append($@"
[Gedaq.DbConnection.Attributes.Query(
            query: @""
INSERT INTO {Database.Clickhouse.ToDefaultSchema()}.{model.TableName}(
	m_{model.IdColumnName},
    m_{model.ValueColumnName},
    mi_{model.ModelInner.IdColumnName},
    mi_{model.ModelInner.ValueColumnName}
)
VALUES (
    {{m_{model.IdColumnName}:{((ClickhouseTypeInfo)model.IdTypeInfo).ClickHouseType}}},
    {{m_{model.ValueColumnName}:{((ClickhouseTypeInfo)model.TypeInfo).ClickHouseType}}}, 
    {{mi_{model.ModelInner.IdColumnName}:{((ClickhouseTypeInfo)model.ModelInner.IdTypeInfo).ClickHouseType}}},
    {{mi_{model.ModelInner.ValueColumnName}:{((ClickhouseTypeInfo)model.ModelInner.TypeInfo).ClickHouseType}}}
)
"",
            methodName:""{InsertMethodName()}"",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof({interfaceTypeName})),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof({model.IdTypeInfo.TypeFullName}), 
                parametrName: ""m_{model.IdColumnName}"", 
                methodParametrName: ""m_{model.IdName}""),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof({model.TypeInfo.TypeFullName}), 
                parametrName: ""m_{model.ValueColumnName}"", 
                methodParametrName: ""m_{model.ValueName}""),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof({model.ModelInner.IdTypeInfo.TypeFullName}), 
                parametrName: ""mi_{model.ModelInner.IdColumnName}"", 
                methodParametrName: ""mi_{model.ModelInner.IdName}""),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof({model.ModelInner.TypeInfo.TypeFullName}), 
                parametrName: ""mi_{model.ModelInner.ValueColumnName}"", 
                methodParametrName: ""mi_{model.ModelInner.ValueName}"")]
        public void {InsertMethodName()}Config()
        {{
        }}
");
        }

        private static string InsertMethodName()
        {
            return $"{_methodName}DbConnection";
        }

        private static void InsertModelDbConnectionTest(
            int order,
            StringBuilderArray.StringBuilderArray stringBuilder,
            ModelValueStorage storage,
            Model.ModelType model,
            ref int indexValue,
            int endIndex,
            bool isAsync,
            string interfaceTypeName)
        {
            System.ArgumentOutOfRangeException.ThrowIfGreaterThan(endIndex, storage.Values.Count);

            var await = isAsync ? "await" : string.Empty;
            var async = isAsync ? "Async" : string.Empty;
            stringBuilder.Append($@"
        [Test, Order({order})]
        public async Task {InsertMethodName()}Test{async}()
        {{
            await using (var connection = GlobalSetUp.GetConnection)
            {{
                await connection.OpenAsync();
                for (int i = {indexValue}; i < {endIndex + 1}; i++)
                {{
                    {await} {TypeHelper.ThisAsInterface(interfaceTypeName)}.{InsertMethodName()}{async}(
                        connection,
                        m_{model.IdName}: {TestsPart.TestDataArrayName}[i].{model.IdName},
                        m_{model.ValueName}: {TestsPart.TestDataArrayName}[i].{model.ValueName},
                        mi_{model.ModelInner.IdName}: {TestsPart.TestDataArrayName}[i].{model.ModelInnerName}.{model.ModelInner.IdName},
                        mi_{model.ModelInner.ValueName}: {TestsPart.TestDataArrayName}[i].{model.ModelInnerName}.{model.ModelInner.ValueName});
                }}
            }}
        }}
");
            indexValue = endIndex;
        }
    }
}