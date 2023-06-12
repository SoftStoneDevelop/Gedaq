using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using TestsGenerator.Constants;
using TestsGenerator.Enums;
using TestsGenerator.Helpers;
using TestsGenerator.Model;
using TestsGenerator.TypeValueHelpers;

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

            if(CanPassToObjArrCorrect(model, database))
            {
                SelectToObjArrTestConfig(model, stringBuilder, database);
                SelectToObjArrTest(order, model, orderedValues, stringBuilder, false);
                SelectToObjArrTest(order, model, orderedValues, stringBuilder, true);
            }
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

            stringBuilder.Append($@"
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

            stringBuilder.Append($@"
        [Test, Order({order})]
        public async Task DbConnection{_testName}Test{async}()
        {{
            await using (var connection = GlobalSetUp.GetDbConnection)
            {{
                await connection.OpenAsync();
                var models = {await} DbConnection{_testName}{async}(connection, 0).ToList{async}();
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

                stringBuilder.Append(model.Assert(value));
            }
            stringBuilder.Append($@"
            }}
        }}
");
        }

        private static bool CanPassToObjArrCorrect(
            Model.ModelType model,
            Database database
            )
        {
            switch(database)
            {
                case Database.PostgreSQL:
                {
                    return
                        model.ValueStorage is not CharValueHelper &&
                        model.ValueStorage is not ByteValueHelper &&
                        model.ValueStorage is not SByteValueHelper &&
                        model.ValueStorage is not TimeOnlyValueHelper &&
                        model.ValueStorage is not DateOnlyValueHelper;
                }

                case Database.MsSQL:
                {
                    return
                        model.ValueStorage is not DateOnlyValueHelper;
                }

                case Database.MySQL:
                {
                    return
                        model.ValueStorage is not DateOnlyValueHelper;
                }

                default:
                { 
                    return true; 
                }
            }
        }

        private static void SelectToObjArrTestConfig(
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
ORDER BY
    m.{model.IdColumnName} ASC
""
";

            stringBuilder.Append($@"
[Gedaq.DbConnection.Attributes.Query(
            query: {query},
            methodName:""DbConnection{_testName}ToObjArr"",
            queryMapType: typeof(object[]),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Private
            )
            ]
        private void DbConnection{_testName}ToObjArrConfig()
        {{
        }}
");
        }

        private static void SelectToObjArrTest(
            int order,
            Model.ModelType model,
            List<ModelValue> orderedValues,
            StringBuilder stringBuilder,
            bool isAsync
            )
        {
            var await = isAsync ? "await" : string.Empty;
            var async = isAsync ? "Async" : string.Empty;

            stringBuilder.Append($@"
        [Test, Order({order})]
        public async Task DbConnection{_testName}ToObjArrTest{async}()
        {{
            await using (var connection = GlobalSetUp.GetDbConnection)
            {{
                await connection.OpenAsync();
                var models = {await} DbConnection{_testName}ToObjArr{async}(connection).ToList{async}();
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

                stringBuilder.Append($@"
                Assert.That(model, Has.Length.EqualTo(6));
");
                ToObjArrAssert(model, value, stringBuilder);
            }
            stringBuilder.Append($@"
            }}
        }}
");
        }

        private static void ToObjArrAssert(
            Model.ModelType model,
            ModelValue expectValue,
            StringBuilder stringBuilder
            )
        {
            stringBuilder.Append($@"
                Assert.That(model, Is.Not.Null);
                Assert.That(({model.IdType})model[0], Is.EqualTo({expectValue.Id}));//Id
                Assert.That(({model.ValueType})model[1], Is.EqualTo({expectValue.Value}));//Value
");
            if (expectValue.InnerModel == null)
            {
                stringBuilder.Append($@"
                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue
");
            }
            else
            {
                stringBuilder.Append($@"
                Assert.That(({model.ModelInner.IdType})model[2], Is.EqualTo({expectValue.InnerModel.Id}));//InnerModel.Id
                Assert.That(({model.ModelInner.ValueType})model[3], Is.EqualTo({expectValue.InnerModel.Value}));//InnerModel.Value
");
                if (expectValue.InnerModel.NullableValue == ValueConstants.NullValue)
                {
                    stringBuilder.Append($@"
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value
");
                }
                else
                {
                    stringBuilder.Append($@"
                Assert.That(({model.ModelInner.NullableValueType})model[4], Is.EqualTo({expectValue.InnerModel.NullableValue}));//InnerModel.NullableValue
");
                }
            }
            if (expectValue.NullableValue == ValueConstants.NullValue)
            {
                stringBuilder.Append($@"
                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue
");
            }
            else
            {
                stringBuilder.Append($@"
                Assert.That(({model.NullableValueType})model[5], Is.EqualTo({expectValue.NullableValue}));
");
            }
        }
    }
}