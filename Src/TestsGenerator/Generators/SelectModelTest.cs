﻿using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestsGenerator.Enums;
using TestsGenerator.Helpers;
using TestsGenerator.Model;

namespace TestsGenerator.Generators
{
    internal static class SelectModelTest
    {
        private readonly static string _testName = "SelectModel";

        public static void Generate(
            int order,
            StringBuilder stringBuilder,
            Model.ModelType model,
            ModelValueStorage storage,
            Database database
            )
        {
            var orderedValues = storage.Values.OrderBy(or => or.IdValue).ToList();
            
            switch (database)
            {
                case Database.PostgreSQL:
                {
                    PostgreSQL.SelectModelTest.Generate(order, stringBuilder, model, storage);
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

            SelectTestConfig(model, stringBuilder, database);
            SelectTest(order, orderedValues, model, stringBuilder, false);
            SelectTest(order, orderedValues, model, stringBuilder, true);
        }

        private static void SelectTestConfig(
            Model.ModelType model,
            StringBuilder stringBuilder,
            Database database
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
FROM {database.ToDefaultSchema()}.{model.TableName} m
LEFT JOIN {database.ToDefaultSchema()}.{model.ModelInner.TableName} mi ON mi.{model.ModelInner.IdColumnName} = m.{model.ModelInnerColumnName}
WHERE
    m.{model.IdColumnName} > @{model.IdColumnName}
ORDER BY
    m.{model.IdColumnName} ASC
""
";

            stringBuilder.AppendLine($@"
[Gedaq.DbConnection.Attributes.Query(
            query: {query},
            methodName:""DbConnection{_testName}"",
            queryMapType: typeof({model.ClassName}),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Private
            ),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof({model.IdType}), 
            parametrName: ""{model.IdColumnName}"", 
            methodParametrName: ""{model.IdColumnName}"", 
            dbType: {model.IdTypeInfo.DbTypeStr()}
                )
            ]
        private void DbConnection{_testName}Config()
        {{
        }}
");
        }

        private static void SelectTest(
            int order,
            List<ModelValue> orderedValues,
            Model.ModelType model,
            StringBuilder stringBuilder,
            bool isAsync
            )
        {
            var await = isAsync ? "await" : string.Empty;
            var async = isAsync ? "Async" : string.Empty;

            stringBuilder.AppendLine($@"
        [Test, Order({order})]
        public async Task DbConnection{_testName}Test{async}()
        {{
            await using (var connection = GlobalSetUp.GetDbConnection)
            {{
                await connection.OpenAsync();
                var models = {await} DbConnection{_testName}{async}(connection, 0).ToList{async}();
");
            for (int i = 0; i < orderedValues.Count; i++)
            {
                ModelValue value = orderedValues[i];
                if (i == 0)
                {
                    stringBuilder.AppendLine($@"
                var model = models[{i}];
");
                }
                else
                {
                    stringBuilder.AppendLine($@"
                model = models[{i}];
");
                }

                stringBuilder.AppendLine(model.Assert(value));
            }
            stringBuilder.AppendLine($@"
            }}
        }}
");
        }
    }
}