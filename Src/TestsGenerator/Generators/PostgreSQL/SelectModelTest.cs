using System.Collections.Generic;
using System.Linq;
using TestsGenerator.Enums;
using TestsGenerator.Helpers;
using TestsGenerator.Model;

namespace TestsGenerator.Generators.PostgreSQL
{
    internal static class SelectModelTest
    {
        private const string _testName = "SelectModel";

        public static void Generate(
            int order,
            StringBuilderArray.StringBuilderArray stringBuilder,
            Model.ModelType model,
            ModelValueStorage storage,
            string interfaceTypeName
            )
        {
            var orderedValues = storage.Values.OrderBy(or => or.IdValue).ToList();

            SelectTestConfig(
                model, 
                stringBuilder,
                interfaceTypeName
                );
            SelectTest(
                order, 
                orderedValues, 
                model, 
                stringBuilder, 
                false, 
                interfaceTypeName
                );
            SelectTest(
                order, 
                orderedValues, 
                model, 
                stringBuilder, 
                true, 
                interfaceTypeName
                );

            DbConnection.SelectModel.Generate(
                order, 
                stringBuilder, 
                model, 
                orderedValues, 
                Database.PostgreSQL, 
                interfaceTypeName
                );
        }

        private static void SelectTestConfig(
            Model.ModelType model,
            StringBuilderArray.StringBuilderArray stringBuilder,
            string interfaceTypeName
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
FROM {Database.PostgreSQL.ToDefaultSchema()}.{model.TableName} m
LEFT JOIN {Database.PostgreSQL.ToDefaultSchema()}.{model.ModelInner.TableName} mi ON mi.{model.ModelInner.IdColumnName} = m.{model.ModelInnerColumnName}
WHERE 
    m.{model.IdColumnName} > $1
ORDER BY
    m.{model.IdColumnName} ASC
""
";
            stringBuilder.Append($@"
[Gedaq.Npgsql.Attributes.Query(
            query: {query},
            methodName:""SelectModel"",
            queryMapType: typeof({model.ClassName}),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof({interfaceTypeName})
            ),
Gedaq.Npgsql.Attributes.Parametr(
            parametrType: typeof({model.IdType}),
            position: 1,
            methodParametrName: ""{model.IdColumnName}"",
            dbType: {model.IdTypeInfo.SpecialDbTypeStr()}
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
            bool isAsync,
            string interfaceTypeName
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
                var models = {await} {TypeHelper.ThisAsInterface(interfaceTypeName)}.{_testName}{async}(connection, 0).ToList{async}();
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