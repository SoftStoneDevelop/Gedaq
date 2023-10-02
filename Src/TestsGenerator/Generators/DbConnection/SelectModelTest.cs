using Microsoft.Data.SqlClient;
using MySqlConnector;
using Npgsql;
using System;
using System.Collections.Generic;
using TestsGenerator.Constants;
using TestsGenerator.Enums;
using TestsGenerator.Helpers;
using TestsGenerator.Model;

namespace TestsGenerator.Generators.DbConnection
{
    internal static class SelectModel
    {
        private const string _testName = "SelectModel";

        public static void Generate(
            int order,
            StringBuilderArray.StringBuilderArray stringBuilder,
            Model.ModelType model,
            List<ModelValue> orderedValues,
            Database database,
            string interfaceTypeName
            )
        {
            SelectTestConfig(
                model, 
                stringBuilder, 
                database,
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

            CommandSelectTest(
                order, 
                orderedValues, 
                model, 
                stringBuilder, 
                false,
                interfaceTypeName
                );
            CommandSelectTest(
                order, 
                orderedValues, 
                model, 
                stringBuilder, 
                true,
                interfaceTypeName
                );

            BatchTests(
                order, 
                orderedValues, 
                model, 
                stringBuilder, 
                database, 
                interfaceTypeName
                );

            var canObjArr = model.TypeInfo.EnumerableType == EnumerableType.SingleType;
            if (canObjArr && DefaultTypeHelper.CanConvert(model.TypeInfo.ItemTypeFullName))
            {
                SelectToObjArrTestConfig(
                    model, 
                    stringBuilder, 
                    database, 
                    interfaceTypeName
                    );
                SelectToObjArrTest(
                    order, 
                    model, 
                    orderedValues, 
                    stringBuilder, 
                    false, 
                    interfaceTypeName
                    );
                SelectToObjArrTest(
                    order, 
                    model, 
                    orderedValues, 
                    stringBuilder, 
                    true, 
                    interfaceTypeName
                    );
            }
        }

        private static void SelectTestConfig(
            Model.ModelType model,
            StringBuilderArray.StringBuilderArray stringBuilder,
            Database database,
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
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof({interfaceTypeName})
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
            StringBuilderArray.StringBuilderArray stringBuilder,
            bool isAsync,
            string interfaceTypeName
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
                var models = {await} {TypeHelper.ThisAsInterface(interfaceTypeName)}.DbConnection{_testName}{async}(connection, 0).ToList{async}();
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

        private static void CommandSelectTest(
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

            var valIndex = Random.Shared.Next(0, orderedValues.Count - 2);
            stringBuilder.Append($@"
        [Test, Order({order})]
        public async Task DbConnectionCommand{_testName}Test{async}()
        {{
            await using (var connection = GlobalSetUp.GetDbConnection)
            {{
                await connection.OpenAsync();
                {await} using var cmd = {await} {TypeHelper.ThisAsInterface(interfaceTypeName)}.CreateDbConnection{_testName}Command{async}(connection);
                {TypeHelper.ThisAsInterface(interfaceTypeName)}.SetDbConnection{_testName}Parametrs(cmd, {orderedValues[valIndex].Id});
                var models = {await} {TypeHelper.ThisAsInterface(interfaceTypeName)}.ExecuteDbConnection{_testName}Command{async}(cmd).ToList{async}();
");
            valIndex++;
            stringBuilder.Append($@"
                Assert.That(models, Has.Count.EqualTo({orderedValues.Count - valIndex}));
");
            var index = 0;
            for (; valIndex < orderedValues.Count; valIndex++)
            {
                ModelValue value = orderedValues[valIndex];
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

                stringBuilder.Append(model.Assert("model", value));
                index++;
            }
            stringBuilder.Append($@"
            }}
        }}
");
        }

        private static void SelectToObjArrTestConfig(
            Model.ModelType model,
            StringBuilderArray.StringBuilderArray stringBuilder,
            Database database,
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
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof({interfaceTypeName})
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
            StringBuilderArray.StringBuilderArray stringBuilder,
            bool isAsync,
            string interfaceTypeName
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
                var models = {await} {TypeHelper.ThisAsInterface(interfaceTypeName)}.DbConnection{_testName}ToObjArr{async}(connection).ToList{async}();
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
            StringBuilderArray.StringBuilderArray stringBuilder
            )
        {
            stringBuilder.Append($@"
                Assert.That(model, Is.Not.Null);
                Assert.That(({model.IdTypeInfo.DefaultMapType})model[0], Is.EqualTo({DefaultTypeHelper.Convert(model.IdTypeInfo.ItemTypeFullName, model.IdTypeInfo.DefaultMapType, expectValue.Id)}));//Id
                Assert.That(({model.TypeInfo.DefaultMapType})model[1], Is.EqualTo({DefaultTypeHelper.Convert(model.TypeInfo.ItemTypeFullName, model.TypeInfo.DefaultMapType, expectValue.Value)}));//Value
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
                Assert.That(({model.ModelInner.IdTypeInfo.DefaultMapType})model[2], Is.EqualTo({DefaultTypeHelper.Convert(model.ModelInner.IdTypeInfo.ItemTypeFullName, model.ModelInner.IdTypeInfo.DefaultMapType, expectValue.InnerModel.Id)}));//InnerModel.Id
                Assert.That(({model.ModelInner.TypeInfo.DefaultMapType})model[3], Is.EqualTo({DefaultTypeHelper.Convert(model.ModelInner.TypeInfo.ItemTypeFullName, model.ModelInner.TypeInfo.DefaultMapType, expectValue.InnerModel.Value)}));//InnerModel.Value
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
                Assert.That(({model.ModelInner.TypeInfo.DefaultMapTypeNullable})model[4], Is.EqualTo({DefaultTypeHelper.Convert(model.ModelInner.TypeInfo.ItemTypeFullName, model.ModelInner.TypeInfo.DefaultMapType, expectValue.InnerModel.NullableValue)}));//InnerModel.NullableValue
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
                Assert.That(({model.TypeInfo.DefaultMapTypeNullable})model[5], Is.EqualTo({DefaultTypeHelper.Convert(model.TypeInfo.ItemTypeFullName, model.TypeInfo.DefaultMapType, expectValue.NullableValue)}));
");
            }
        }

        private static void BatchTests(
            int order,
            List<ModelValue> orderedValues,
            Model.ModelType model,
            StringBuilderArray.StringBuilderArray stringBuilder,
            Database database,
            string interfaceTypeName
            )
        {
            switch (database)
            {
                case Database.PostgreSQL:
                {
                    if (!NpgsqlFactory.Instance.CanCreateBatch)
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

            SelectBatchReadTestConfig(stringBuilder, interfaceTypeName);
            SelectBatchReadTest(order, orderedValues, model, stringBuilder, false, interfaceTypeName);
            SelectBatchReadTest(order, orderedValues, model, stringBuilder, true, interfaceTypeName);
        }

        private static void SelectBatchReadTestConfig(
            StringBuilderArray.StringBuilderArray stringBuilder,
            string interfaceTypeName
            )
        {
            stringBuilder.Append($@"
[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: ""DbConnection{_testName}Batch"",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof({interfaceTypeName})
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
            StringBuilderArray.StringBuilderArray stringBuilder,
            bool isAsync,
            string interfaceTypeName
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
                {await} foreach(var batchResult in {TypeHelper.ThisAsInterface(interfaceTypeName)}.DbConnection{_testName}Batch{async}(connection, {orderedValues[firstBatchStart].Id}, {orderedValues[secondBatchStart].Id}))
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

                stringBuilder.Append($@"    {model.Assert("model", value)}");
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
                stringBuilder.Append($@"    {model.Assert("model", value)}");
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
