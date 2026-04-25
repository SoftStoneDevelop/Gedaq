using System.Collections.Generic;
using System.Linq;
using TestsGenerator.Constants;
using TestsGenerator.Enums;
using TestsGenerator.Helpers;
using TestsGenerator.Model;

namespace TestsGenerator.Generators.MsSQL
{
    internal static class SelectModelTest
    {
        private const string _testName = "SelectModel";

        public static void Generate(
            int order,
            StringBuilderArray.StringBuilderArray stringBuilder,
            Model.ModelType model,
            ModelValueStorage storage,
            string interfaceTypeName)
        {
            var orderedValues = storage.Values.OrderBy(or => or.IdValue).ToList();

            foreach (var dynamicParametrValue in ValueConstants.BoolValues)
            {
                foreach (var isDynamicQuery in ValueConstants.BoolValues)
                {
                    SelectTestConfig(
                        model,
                        stringBuilder,
                        interfaceTypeName,
                        dynamicParametrValue,
                        isDynamicQuery: isDynamicQuery);

                    foreach (var isAsync in ValueConstants.BoolValues)
                    {
                        SelectTest(
                            order,
                            orderedValues,
                            model,
                            stringBuilder,
                            isAsync,
                            interfaceTypeName,
                            dynamicParametrValue,
                            isDynamicQuery: isDynamicQuery);
                    }
                }
            }

            DbConnection.SelectModel.Generate(
                order, 
                stringBuilder, 
                model, 
                orderedValues, 
                Database.MsSQL, 
                interfaceTypeName);
        }

        private static void SelectTestConfig(
            Model.ModelType model,
            StringBuilderArray.StringBuilderArray stringBuilder,
            string interfaceTypeName,
            bool dynamicParametr,
            bool isDynamicQuery)
        {
            var query = isDynamicQuery ? ValueConstants.NullValue : $@"
@""
SELECT
    m.{model.IdColumnName},
    m.{model.ValueColumnName},
~StartInner::{model.ModelInnerName}:{model.ModelInner.IdName}~
    mi.{model.ModelInner.IdColumnName},
    mi.{model.ModelInner.ValueColumnName},
    mi.{model.ModelInner.NullableValueColumnName},
~EndInner::{model.ModelInnerName}~
    m.{model.NullableValueColumnName}
FROM {Database.MsSQL.ToDefaultSchema()}.{model.TableName} m
LEFT JOIN {Database.MsSQL.ToDefaultSchema()}.{model.ModelInner.TableName} mi ON mi.{model.ModelInner.IdColumnName} = m.{model.ModelInnerColumnName}
WHERE 
    m.{model.IdColumnName} > @{model.IdColumnName}
ORDER BY
    m.{model.IdColumnName} ASC
""
";
            stringBuilder.Append($@"
[Gedaq.SqlClient.Attributes.Query(
            query: {query},
            methodName:""{SelectMethodName(isDynamicQuery, dynamicParametr)}"",
            queryMapTypes: [typeof({model.ClassName(isDynamicQuery)})],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof({interfaceTypeName})),");

            if (dynamicParametr)
            {
                stringBuilder.Append($@"
Gedaq.SqlClient.Attributes.DynamicParametr()");
            }
            else
            {
                stringBuilder.Append($@"
Gedaq.SqlClient.Attributes.Parametr(
            parametrType: typeof({model.IdType}),
            parametrName: ""{model.IdColumnName}"",
            methodParametrName: ""{model.IdColumnName}"",
            sqlDbType: {model.IdTypeInfo.SpecialDbTypeStr()})");
            }

            stringBuilder.Append($@"]
        private void {SelectMethodName(isDynamicQuery, dynamicParametr)}Config()
        {{
        }}
");
        }

        private static string SelectMethodName(bool isDynamicQuery, bool dynamicParametr)
        {
            return $"{ValueConstants.DynamicQueryPrefix(isDynamicQuery)}{_testName}{(dynamicParametr ? NameConstants.DynamicParametr : "")}";
        }

        private static void SelectTest(
            int order,
            List<ModelValue> orderedValues,
            Model.ModelType model,
            StringBuilderArray.StringBuilderArray stringBuilder,
            bool isAsync,
            string interfaceTypeName,
            bool dynamicParametr,
            bool isDynamicQuery)
        {
            var await = isAsync ? "await" : string.Empty;
            var async = isAsync ? "Async" : string.Empty;
            var queryParametr = isDynamicQuery ? " query, " : string.Empty;

            stringBuilder.Append($@"
        [Test, Order({order})]
        public async Task {SelectMethodName(isDynamicQuery, dynamicParametr)}Test{async}()
        {{
            await using (var connection = GlobalSetUp.GetConnection)
            {{
                await connection.OpenAsync();");
            if (isDynamicQuery)
            {
                stringBuilder.Append($@"
                var query = @""
SELECT
    m.{model.IdColumnName},
    m.{model.ValueColumnName},
    m.{model.NullableValueColumnName}
FROM {Database.MsSQL.ToDefaultSchema()}.{model.TableName} m
LEFT JOIN {Database.MsSQL.ToDefaultSchema()}.{model.ModelInner.TableName} mi ON mi.{model.ModelInner.IdColumnName} = m.{model.ModelInnerColumnName}
WHERE 
    m.{model.IdColumnName} > @{model.IdColumnName}
ORDER BY
    m.{model.IdColumnName} ASC
"";");
            }

            if (dynamicParametr)
            {
                stringBuilder.Append($@"
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = ""id"";

                var models = {await} {TypeHelper.ThisAsInterface(interfaceTypeName)}.{SelectMethodName(isDynamicQuery, dynamicParametr)}{async}(connection, {queryParametr}[parametr1]);");
            }
            else
            {
                stringBuilder.Append($@"
                var models = {await} {TypeHelper.ThisAsInterface(interfaceTypeName)}.{SelectMethodName(isDynamicQuery, dynamicParametr)}{async}(connection, {queryParametr}0);");
            }

            stringBuilder.Append($@"
                Assert.That(models, Has.Count.EqualTo({orderedValues.Count}));
                for (int i = 0; i < {orderedValues.Count}; i++)
                {{
                    {model.ClassName(isDynamicQuery)}.{ModelGenerator.AssertMethodName}(models[i],{TestsPart.TestDataArrayName}[i], false);
                }}
            }}
        }}
");
        }
    }
}