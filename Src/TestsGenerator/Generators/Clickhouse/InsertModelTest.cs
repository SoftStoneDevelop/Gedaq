using TestsGenerator.Constants;
using TestsGenerator.Enums;
using TestsGenerator.Helpers;
using TestsGenerator.Model;

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

                InsertModelTest(
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
    @m_{model.IdColumnName},
    @m_{model.ValueColumnName}, 
    @mi_{model.ModelInner.IdColumnName},
    @mi_{model.ModelInner.ValueColumnName}
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
                methodParametrName: ""m_{model.IdName}"", 
                dbType: {model.IdTypeInfo.DbTypeStr()}),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof({model.TypeInfo.TypeFullName}), 
                parametrName: ""m_{model.ValueColumnName}"", 
                methodParametrName: ""m_{model.ValueName}"", 
                dbType: {model.TypeInfo.DbTypeStr()}),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof({model.ModelInner.IdTypeInfo.TypeFullName}), 
                parametrName: ""mi_{model.ModelInner.IdColumnName}"", 
                methodParametrName: ""mi_{model.ModelInner.IdName}"", 
                dbType: {model.ModelInner.IdTypeInfo.DbTypeStr()}),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof({model.ModelInner.TypeInfo.TypeFullName}), 
                parametrName: ""mi_{model.ModelInner.ValueName}"", 
                methodParametrName: ""mi_{model.ModelInner.ValueName}"", 
                dbType: {model.ModelInner.TypeInfo.DbTypeStr()})]
        public void {InsertMethodName()}Config()
        {{
        }}
");
        }

        private static string InsertMethodName()
        {
            return $"{_methodName}DbConnection";
        }

        private static void InsertModelTest(
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
                for (int i = {indexValue}; i < {endIndex}; i++)
                {{
                    {await} {TypeHelper.ThisAsInterface(interfaceTypeName)}.{InsertMethodName()}{async}(
                        connection,
                        m_{model.IdName}: {TestsPart.TestDataArrayName}[{indexValue}].{model.IdName},
                        m_{model.ValueName}: {TestsPart.TestDataArrayName}[{indexValue}].{model.ValueName},
                        mi_{model.ModelInner.IdName}: {TestsPart.TestDataArrayName}[{indexValue}].{model.ModelInnerName}.{model.ModelInner.IdName},
                        mi_{model.ModelInner.ValueName}: {TestsPart.TestDataArrayName}[{indexValue}].{model.ModelInnerName}.{model.ModelInner.ValueName});
                }}
            }}
        }}
");
            indexValue = endIndex;
        }
    }
}