using Microsoft.Data.SqlClient;
using MySqlConnector;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestsGenerator.Constants;
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

            BatchTests(order, orderedValues, model, stringBuilder, database);

            SelectToObjArrTestConfig(model, stringBuilder, database);
            SelectToObjArrTest(order, model, orderedValues, stringBuilder, false);
            SelectToObjArrTest(order, model, orderedValues, stringBuilder, true);
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
                Assert.That(({model.IdTypeInfo.DefaultMapType})model[0], Is.EqualTo({DefaultTypeHelper.Convert(model.IdTypeInfo.TypeFullName, model.IdTypeInfo.DefaultMapType, expectValue.Id)}));//Id
                Assert.That(({model.TypeInfo.DefaultMapType})model[1], Is.EqualTo({DefaultTypeHelper.Convert(model.TypeInfo.TypeFullName, model.TypeInfo.DefaultMapType, expectValue.Value)}));//Value
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
                Assert.That(({model.ModelInner.IdTypeInfo.DefaultMapType})model[2], Is.EqualTo({DefaultTypeHelper.Convert(model.ModelInner.IdTypeInfo.TypeFullName, model.ModelInner.IdTypeInfo.DefaultMapType, expectValue.InnerModel.Id)}));//InnerModel.Id
                Assert.That(({model.ModelInner.TypeInfo.DefaultMapType})model[3], Is.EqualTo({DefaultTypeHelper.Convert(model.ModelInner.TypeInfo.TypeFullName, model.ModelInner.TypeInfo.DefaultMapType, expectValue.InnerModel.Value)}));//InnerModel.Value
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
                Assert.That(({model.ModelInner.TypeInfo.DefaultMapTypeNullable})model[4], Is.EqualTo({DefaultTypeHelper.Convert(model.ModelInner.TypeInfo.TypeFullName, model.ModelInner.TypeInfo.DefaultMapType, expectValue.InnerModel.NullableValue)}));//InnerModel.NullableValue
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
                Assert.That(({model.TypeInfo.DefaultMapTypeNullable})model[5], Is.EqualTo({DefaultTypeHelper.Convert(model.TypeInfo.TypeFullName, model.TypeInfo.DefaultMapType, expectValue.NullableValue)}));
");
            }
        }

        private static void BatchTests(
            int order,
            List<ModelValue> orderedValues,
            Model.ModelType model,
            StringBuilder stringBuilder,
            Database database
            )
        {
            switch (database)
            {
                case Database.PostgreSQL:
                {
                    if(!NpgsqlFactory.Instance.CanCreateBatch)
                    {
                        return;
                    }
                    break;
                }
                case Database.MsSQL:
                {
                    if (!SqlClientFactory.Instance.CanCreateBatch)
                    {
                        return;
                    }
                    break;
                }
                case Database.MySQL:
                {
                    if (!MySqlConnectorFactory.Instance.CanCreateBatch)
                    {
                        return;
                    }

                    break;
                }
            }

            SelectBatchReadTestConfig(stringBuilder);
            SelectBatchReadTest(order, orderedValues, model, stringBuilder, false);
            SelectBatchReadTest(order, orderedValues, model, stringBuilder, true);
        }

        private static void SelectBatchReadTestConfig(
            StringBuilder stringBuilder
            )
        {
            stringBuilder.Append($@"
[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: ""DbConnection{_testName}Batch"",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Private
            ),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: ""DbConnection{_testName}"",
            position: 1
            ),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: ""DbConnection{_testName}"",
            position: 2
            )
            ]
        private void DbConnection{_testName}BatchConfig()
        {{
        }}
");
        }

        private static void SelectBatchReadTest(
            int order,
            List<ModelValue> orderedValues,
            Model.ModelType model,
            StringBuilder stringBuilder,
            bool isAsync
            )
        {
            var await = isAsync ? "await" : string.Empty;
            var async = isAsync ? "Async" : string.Empty;

            var firstBatchStart = Random.Shared.Next(0, orderedValues.Count - 2);
            var secondBatchStart = Random.Shared.Next(0, orderedValues.Count - 2);
            stringBuilder.Append($@"
        [Test, Order({order})]
        public async Task DbConnection{_testName}BatchTest{async}()
        {{
            await using (var connection = GlobalSetUp.GetDbConnection)
            {{
                await connection.OpenAsync();
                int resultIndex = 0;
                {await} foreach(var batchResult in DbConnection{_testName}Batch{async}(connection, {orderedValues[firstBatchStart].Id}, {orderedValues[secondBatchStart].Id}))
                {{
                    if(++resultIndex == 1)
                    {{
                        var models = {await} batchResult.ToList{async}();
");
            firstBatchStart++;
            stringBuilder.Append($@"
                        Assert.That(models, Has.Count.EqualTo({orderedValues.Count - firstBatchStart}));
");
            var index = 0;
            for (; firstBatchStart < orderedValues.Count; firstBatchStart++)
            {
                ModelValue value = orderedValues[firstBatchStart];
                if (index == 0)
                {
                    stringBuilder.Append($@"
                        var model = models[{index}];
");
                }
                else
                {
                    stringBuilder.Append($@"
                        model = models[{index}];
");
                }

                stringBuilder.Append($@"    {model.Assert(value)}");
                index++;
            }

            secondBatchStart++;
            stringBuilder.Append($@"
                        continue;
                    }}                    

                    if(resultIndex == 2)
                    {{
                        var models = {await} batchResult.ToList{async}();
                        Assert.That(models, Has.Count.EqualTo({orderedValues.Count - secondBatchStart}));
");
            index = 0;
            for (; secondBatchStart < orderedValues.Count; secondBatchStart++)
            {
                ModelValue value = orderedValues[secondBatchStart];
                if (index == 0)
                {
                    stringBuilder.Append($@"
                        var model = models[{index}];
");
                }
                else
                {
                    stringBuilder.Append($@"
                        model = models[{index}];
");
                }
                stringBuilder.Append($@"    {model.Assert(value)}");
                index++;
            }
            stringBuilder.Append($@"
                        continue;
                    }}
                    
                    //todo return false
                }}
            }}
        }}
");
        }
    }
}