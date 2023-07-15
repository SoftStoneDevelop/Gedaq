﻿using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestsGenerator.Enums;
using TestsGenerator.Helpers;
using TestsGenerator.Model;

namespace TestsGenerator.Generators.MsSQL
{
    internal static class SelectModelTest
    {
        private static readonly string _testName = "SelectModel";

        public static void Generate(
            int order,
            StringBuilderArray.StringBuilderArray stringBuilder,
            Model.ModelType model,
            ModelValueStorage storage
            )
        {
            var orderedValues = storage.Values.OrderBy(or => or.IdValue).ToList();

            SelectTestConfig(model, stringBuilder);
            SelectTest(order, orderedValues, model, stringBuilder, false);
            SelectTest(order, orderedValues, model, stringBuilder, true);

            DbConnection.SelectModel.Generate(order, stringBuilder, model, orderedValues, Database.MsSQL);
        }

        private static void SelectTestConfig(
            Model.ModelType model,
            StringBuilderArray.StringBuilderArray stringBuilder
            )
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
            methodName:""SelectModel"",
            queryMapType: typeof({model.ClassName}),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Private
            ),
Gedaq.SqlClient.Attributes.Parametr(
            parametrType: typeof({model.IdType}),
            parametrName: ""{model.IdColumnName}"",
            methodParametrName: ""{model.IdColumnName}"",
            sqlDbType: {model.IdTypeInfo.SpecialDbTypeStr()}
            )
            ]
        private void {_testName}Config()
        {{
        }}
");
        }

        private static void SelectTest(
            int order,
            List<ModelValue> orderedValues,
            Model.ModelType model,
            StringBuilderArray.StringBuilderArray stringBuilder,
            bool isAsync
            )
        {
            var await = isAsync ? "await" : string.Empty;
            var async = isAsync ? "Async" : string.Empty;

            stringBuilder.Append($@"
        [Test, Order({order})]
        public async Task {_testName}Test{async}()
        {{
            await using (var connection = GlobalSetUp.GetConnection)
            {{
                await connection.OpenAsync();
                var models = {await} {_testName}{async}(connection, 0).ToList{async}();
                Assert.That(models, Has.Count.EqualTo({orderedValues.Count}));
");
            for (int i = 0; i < orderedValues.Count; i++)
            {
                ModelValue value = orderedValues[i];
                if (i == 0)
                {
                    stringBuilder.Append($@"
                var model = models[{i}];
");
                }
                else
                {
                    stringBuilder.Append($@"
                model = models[{i}];
");
                }

                stringBuilder.Append(model.Assert("model", value));
            }
            stringBuilder.Append($@"
            }}
        }}
");
        }
    }
}
