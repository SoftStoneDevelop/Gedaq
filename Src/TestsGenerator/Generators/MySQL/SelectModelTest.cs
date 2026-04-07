using System;
using System.Collections.Generic;
using System.Linq;
using TestsGenerator.Constants;
using TestsGenerator.Enums;
using TestsGenerator.Helpers;
using TestsGenerator.Model;

namespace TestsGenerator.Generators.MySQL
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

            Span<bool> dynamicParametrValues = [true, false];
            foreach (var dynamicParametrValue in dynamicParametrValues)
            {
                SelectTestConfig(
                    model,
                    stringBuilder,
                    interfaceTypeName,
                    dynamicParametrValue);
                SelectTest(
                    order,
                    orderedValues,
                    model,
                    stringBuilder,
                    false,
                    interfaceTypeName,
                    dynamicParametrValue);
                SelectTest(
                    order,
                    orderedValues,
                    model,
                    stringBuilder,
                    true,
                    interfaceTypeName,
                    dynamicParametrValue);
            }

            DbConnection.SelectModel.Generate(
                order, 
                stringBuilder, 
                model, 
                orderedValues, 
                Database.MySQL, 
                interfaceTypeName);
        }

        private static void SelectTestConfig(
            Model.ModelType model,
            StringBuilderArray.StringBuilderArray stringBuilder,
            string interfaceTypeName,
            bool dynamicParametr)
        {
            var query = $@"
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
FROM {Database.MySQL.ToDefaultSchema()}.{model.TableName} m
LEFT JOIN {Database.MySQL.ToDefaultSchema()}.{model.ModelInner.TableName} mi ON mi.{model.ModelInner.IdColumnName} = m.{model.ModelInnerColumnName}
WHERE 
    m.{model.IdColumnName} > @{model.IdColumnName}
ORDER BY
    m.{model.IdColumnName} ASC
""
";
            stringBuilder.Append($@"
[Gedaq.MySqlConnector.Attributes.Query(
            query: {query},
            sourceType: SourceType.MySqlConnection,
            methodName:""{_testName}{(dynamicParametr ? NameConstants.DynamicParametr : "")}"",
            queryMapTypes: [typeof({model.ClassName})],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof({interfaceTypeName})),");

            if (dynamicParametr)
            {
                stringBuilder.Append($@"
Gedaq.MySqlConnector.Attributes.DynamicParametr()");
            }
            else
            {
                stringBuilder.Append($@"
Gedaq.MySqlConnector.Attributes.Parametr(
            parametrType: typeof({model.IdType}),
            parametrName: ""{model.IdColumnName}"",
            methodParametrName: ""{model.IdColumnName}"",
            dbType: {model.IdTypeInfo.SpecialDbTypeStr()})");
            }

            stringBuilder.Append($@"]
        private void {_testName}{(dynamicParametr ? NameConstants.DynamicParametr : "")}Config()
        {{
        }}
");
        }

        private static void SelectTest(
            int order,
            List<ModelValue> orderedValues,
            Model.ModelType model,
            StringBuilderArray.StringBuilderArray stringBuilder,
            bool isAsync,
            string interfaceTypeName,
            bool dynamicParametr)
        {
            var await = isAsync ? "await" : string.Empty;
            var async = isAsync ? "Async" : string.Empty;

            stringBuilder.Append($@"
        [Test, Order({order})]
        public async Task {_testName}{(dynamicParametr ? NameConstants.DynamicParametr : "")}Test{async}()
        {{
            await using (var connection = GlobalSetUp.GetConnection)
            {{
                await connection.OpenAsync();");

            if (dynamicParametr)
            {
                stringBuilder.Append($@"
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = ""id"";

                var models = {await} {TypeHelper.ThisAsInterface(interfaceTypeName)}.{_testName}{(dynamicParametr ? NameConstants.DynamicParametr : "")}{async}(connection, [parametr1]);");
            }
            else
            {
                stringBuilder.Append($@"
                var models = {await} {TypeHelper.ThisAsInterface(interfaceTypeName)}.{_testName}{(dynamicParametr ? NameConstants.DynamicParametr : "")}{async}(connection, 0);");
            }

            stringBuilder.Append($@"
                Assert.That(models, Has.Count.EqualTo({orderedValues.Count}));
                for (int i = 0; i < {orderedValues.Count}; i++)
                {{
                    {model.ClassName}.{ModelGenerator.AssertMethodName}(models[i],{TestsPart.TestDataArrayName}[i], false);
                }}
            }}
        }}
");
        }
    }
}