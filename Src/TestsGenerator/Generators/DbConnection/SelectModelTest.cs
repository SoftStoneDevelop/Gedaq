using Microsoft.Data.SqlClient;
using MySqlConnector;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
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
            string interfaceTypeName)
        {
            foreach (var dynamicParametrValue in ValueConstants.BoolValues)
            {
                foreach (var isDynamicQuery in ValueConstants.BoolValues)
                {
                    foreach (var isMultiMap in ValueConstants.BoolValues)
                    {
                        SelectTestConfig(
                            model,
                            stringBuilder,
                            database,
                            interfaceTypeName,
                            dynamicParametrValue,
                            isDynamicQuery: isDynamicQuery,
                            isMultiMap: isMultiMap);

                        SelectBatchReadTestConfig(
                            stringBuilder,
                            database,
                            interfaceTypeName,
                            withDynamicParameters: dynamicParametrValue,
                            isDynamicQuery: isDynamicQuery,
                            isMultiMap: isMultiMap);

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
                                database: database,
                                isDynamicQuery: isDynamicQuery,
                                isMultiMap: isMultiMap);

                            SelectBatchReadTest(
                                order,
                                database,
                                orderedValues,
                                model,
                                stringBuilder,
                                isAsync,
                                interfaceTypeName,
                                withDynamicParameters: dynamicParametrValue,
                                isDynamicQuery: isDynamicQuery,
                                isMultiMap: isMultiMap);
                        }
                    }
                }
            }

            foreach (var isAsync in ValueConstants.BoolValues)
            {
                CommandSelectTest(
                    order,
                    orderedValues,
                    model,
                    stringBuilder,
                    isAsync,
                    interfaceTypeName);
            }

            var canObjArr = model.TypeInfo.EnumerableType == EnumerableType.SingleType;
            if (canObjArr && DefaultTypeHelper.CanConvert(model.TypeInfo.ItemTypeFullName))
            {
                SelectToObjArrTestConfig(
                    model, 
                    stringBuilder, 
                    database, 
                    interfaceTypeName);

                foreach (var isAsync in ValueConstants.BoolValues)
                {
                    SelectToObjArrTest(
                        order,
                        model,
                        orderedValues,
                        stringBuilder,
                        isAsync,
                        interfaceTypeName);
                }
            }
        }

        private static string SelectQueryText(
            Model.ModelType model,
            Database database,
            bool isDynamicQuery,
            bool isMultiMap)
        {
            if (isDynamicQuery)
            {
                if (isMultiMap)
                {
                    return $@"@""
SELECT
    m.{model.IdColumnName} AS item1{model.IdColumnName},
    m.{model.ValueColumnName} AS item1{model.ValueColumnName},
    m.{model.NullableValueColumnName} AS item1{model.NullableValueColumnName},
    m.{model.IdColumnName} AS item2{model.IdColumnName},
    m.{model.ValueColumnName} AS item2{model.ValueColumnName},
    m.{model.NullableValueColumnName} AS item2{model.NullableValueColumnName}
FROM {database.ToDefaultSchema()}.{model.TableName} m
WHERE
    m.{model.IdColumnName} > @{model.IdColumnName}
ORDER BY
    m.{model.IdColumnName} ASC
""";
                }
                else
                {
                    return $@"@""
SELECT
    m.{model.IdColumnName},
    m.{model.ValueColumnName},
    m.{model.NullableValueColumnName}
FROM {database.ToDefaultSchema()}.{model.TableName} m
WHERE
    m.{model.IdColumnName} > @{model.IdColumnName}
ORDER BY
    m.{model.IdColumnName} ASC
""";
                }
            }
            else
            {
                return $@"
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
""";
            }
        }

        private static void SelectTestConfig(
            Model.ModelType model,
            StringBuilderArray.StringBuilderArray stringBuilder,
            Database database,
            string interfaceTypeName,
            bool dynamicParametr,
            bool isDynamicQuery,
            bool isMultiMap)
        {
            if (IgnoreIfMultiMap(isDynamicQuery, isMultiMap))
            {
                return;
            }

            var query = isDynamicQuery ? ValueConstants.NullValue : $@"
{SelectQueryText(model, database, isDynamicQuery, isMultiMap)}
";
            var queryMapTypes = isMultiMap ?
                $"typeof({model.ClassName(isDynamicQuery)}), typeof({model.ClassName(isDynamicQuery)})" :
                $"typeof({model.ClassName(isDynamicQuery)})";

            var overrideAliasPrefixs = isMultiMap ?
                "[\"item1\", \"item2\"]" :
                "null";

            stringBuilder.Append($@"
[Gedaq.DbConnection.Attributes.Query(
            query: {query},
            methodName:""{SelectMethodName(isDynamicQuery, dynamicParametr, isMultiMap)}"",
            queryMapTypes: [{queryMapTypes}],
            overrideAliasPrefixs: {overrideAliasPrefixs},
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof({interfaceTypeName})),");

            if (dynamicParametr)
            {
                stringBuilder.Append($@"
Gedaq.DbConnection.Attributes.DynamicParametr()");
            }
            else
            {
                stringBuilder.Append($@"
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof({model.IdType}), 
            parametrName: ""{model.IdColumnName}"", 
            methodParametrName: ""{model.IdColumnName}"", 
            dbType: {model.IdTypeInfo.DbTypeStr()})");
            }

            stringBuilder.Append($@"]
        private void {SelectMethodName(isDynamicQuery, dynamicParametr, isMultiMap)}Config()
        {{
        }}
");
        }

        private static string SelectMethodName(
            bool isDynamicQuery,
            bool dynamicParametr,
            bool isMultiMap)
        {
            return $"DbConnection{ValueConstants.MultiMapQueryPrefix(isMultiMap)}" +
                $"{ValueConstants.DynamicQueryPrefix(isDynamicQuery)}" +
                $"{_testName}{(dynamicParametr ? NameConstants.DynamicParametr : "")}";
        }

        private static bool IgnoreIfMultiMap(
            bool isDynamicQuery,
            bool isMultiMap)
        {
            return isMultiMap && !isDynamicQuery;
        }

        private static void SelectTest(
            int order,
            List<ModelValue> orderedValues,
            Model.ModelType model,
            StringBuilderArray.StringBuilderArray stringBuilder,
            bool isAsync,
            string interfaceTypeName,
            bool dynamicParametr,
            Database database,
            bool isDynamicQuery,
            bool isMultiMap)
        {
            if (IgnoreIfMultiMap(isDynamicQuery, isMultiMap))
            {
                return;
            }

            var await = isAsync ? "await" : string.Empty;
            var async = isAsync ? "Async" : string.Empty;
            var queryParametr = isDynamicQuery ? " query, " : string.Empty;

            stringBuilder.Append($@"
        [Test, Order({order})]
        public async Task {SelectMethodName(isDynamicQuery, dynamicParametr, isMultiMap)}Test{async}()
        {{
            await using (var connection = GlobalSetUp.GetDbConnection)
            {{
                await connection.OpenAsync();");
            if (isDynamicQuery)
            {
                stringBuilder.Append($@"
                var query = {SelectQueryText(model, database, isDynamicQuery, isMultiMap)};");
            }

            string passParametrs;
            string delegateParametr = isMultiMap ? ", (item1, item2) => { models1.Add(item1); models2.Add(item2); }" : string.Empty;
            if (dynamicParametr)
            {
                stringBuilder.Append($@"
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = ""id"";");

                passParametrs = $"connection, {queryParametr}[parametr1]{delegateParametr}";
            }
            else
            {
                passParametrs = $"connection, {queryParametr}0{delegateParametr}";
            }

            if (isMultiMap)
            {
                stringBuilder.Append($@"
                var models1 = new List<{model.ClassName(isDynamicQuery)}>();
                var models2 = new List<{model.ClassName(isDynamicQuery)}>();
                {await}{TypeHelper.ThisAsInterface(interfaceTypeName)}.{SelectMethodName(isDynamicQuery, dynamicParametr, isMultiMap)}{async}({passParametrs});
                Assert.That(models1, Has.Count.EqualTo({orderedValues.Count}));
                Assert.That(models2, Has.Count.EqualTo({orderedValues.Count}));
                for (int i = 0; i < {orderedValues.Count}; i++)
                {{
                    {model.ClassName(isDynamicQuery)}.{ModelGenerator.AssertMethodName}(models1[i],{TestsPart.TestDataArrayName}[i], false);
                    {model.ClassName(isDynamicQuery)}.{ModelGenerator.AssertMethodName}(models2[i],{TestsPart.TestDataArrayName}[i], false);
                }}");
            }
            else
            {
                stringBuilder.Append($@"
                var models = {await}{TypeHelper.ThisAsInterface(interfaceTypeName)}.{SelectMethodName(isDynamicQuery, dynamicParametr, isMultiMap)}{async}({passParametrs});
                Assert.That(models, Has.Count.EqualTo({orderedValues.Count}));
                for (int i = 0; i < {orderedValues.Count}; i++)
                {{
                    {model.ClassName(isDynamicQuery)}.{ModelGenerator.AssertMethodName}(models[i],{TestsPart.TestDataArrayName}[i], false);
                }}");
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
            string interfaceTypeName)
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
                var models = {await} {TypeHelper.ThisAsInterface(interfaceTypeName)}.ExecuteDbConnection{_testName}Command{async}(cmd);
");
            valIndex++;
            stringBuilder.Append($@"
                Assert.That(models, Has.Count.EqualTo({orderedValues.Count - valIndex}));
");
            var index = 0;
            for (; valIndex < orderedValues.Count; valIndex++)
            {
                stringBuilder.Append(@$"
                {model.ClassName(false)}.{ModelGenerator.AssertMethodName}(models[{index}],{TestsPart.TestDataArrayName}[{valIndex}], false);");
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
            string interfaceTypeName)
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
            queryMapTypes: [typeof(object[])],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof({interfaceTypeName}))]
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
            string interfaceTypeName)
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
                var models = {await} {TypeHelper.ThisAsInterface(interfaceTypeName)}.DbConnection{_testName}ToObjArr{async}(connection);
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
            StringBuilderArray.StringBuilderArray stringBuilder)
        {
            stringBuilder.Append($@"
                Assert.That(model, Is.Not.Null);
                Assert.That(({model.IdTypeInfo.DefaultMapType})model[0], Is.EqualTo({DefaultTypeHelper.Convert(model.IdTypeInfo.ItemTypeFullName, model.IdTypeInfo.DefaultMapType, expectValue.Id)}));//Id
                Assert.That(({model.TypeInfo.DefaultMapType})model[1], Is.EqualTo({DefaultTypeHelper.Convert(model.TypeInfo.ItemTypeFullName, model.TypeInfo.DefaultMapType, expectValue.Value)}));//Value
");
            if (expectValue.InnerModel == null)
            {
                stringBuilder.Append($@"
                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue
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

        private static bool IsSupportBatch(
            Database database,
            bool isDynamicQuery,
            bool isMultiMap,
            bool isSameType)
        {
            if (!isDynamicQuery && (isMultiMap || !isSameType))
            {
                return false;
            }

            switch (database)
            {
                case Database.PostgreSQL:
                {
                    return NpgsqlFactory.Instance.CanCreateBatch;
                }

                case Database.MsSQL:
                {
                    return SqlClientFactory.Instance.CanCreateBatch;
                }

                case Database.MySQL:
                {
                    return MySqlConnectorFactory.Instance.CanCreateBatch;
                }

                default:
                {
                    return false;
                }
            }
        }

        private static string SelectBatchMethodName(
            bool isDynamicQuery,
            bool dynamicParametr,
            bool isMultiMap,
            bool sameType)
        {
            return $"DbConnection" +
                $"{(sameType ? "ST" : string.Empty)}" +
                $"{ValueConstants.MultiMapQueryPrefix(isMultiMap)}" +
                $"{ValueConstants.DynamicQueryPrefix(isDynamicQuery)}" +
                $"{_testName}" +
                $"{(dynamicParametr ? NameConstants.DynamicParametr : string.Empty)}" +
                $"Batch";
        }

        private static void SelectBatchReadTestConfig(
            StringBuilderArray.StringBuilderArray stringBuilder,
            Database database,
            string interfaceTypeName,
            bool withDynamicParameters,
            bool isDynamicQuery,
            bool isMultiMap)
        {
            foreach (var sameType in ValueConstants.BoolValues)
            {
                if (!IsSupportBatch(database, isDynamicQuery, isMultiMap, sameType))
                {
                    continue;
                }

                var query2IsMultiMap = sameType ? isMultiMap : !isMultiMap;

                stringBuilder.Append($@"
[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: ""{SelectBatchMethodName(isDynamicQuery, withDynamicParameters, isMultiMap, sameType)}"",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof({interfaceTypeName})),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: ""{SelectMethodName(isDynamicQuery, withDynamicParameters, isMultiMap)}"",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: ""{SelectMethodName(isDynamicQuery, withDynamicParameters, query2IsMultiMap)}"",
            position: 2)]
        private void {SelectBatchMethodName(isDynamicQuery, withDynamicParameters, isMultiMap, sameType)}Config()
        {{
        }}
");
            }
        }

        private static void SelectBatchReadTest(
            int order,
            Database database,
            List<ModelValue> orderedValues,
            Model.ModelType model,
            StringBuilderArray.StringBuilderArray stringBuilder,
            bool isAsync,
            string interfaceTypeName,
            bool withDynamicParameters,
            bool isDynamicQuery,
            bool isMultiMap)
        {
            var await = isAsync ? "await" : string.Empty;
            var async = isAsync ? "Async" : string.Empty;

            foreach (var sameType in ValueConstants.BoolValues)
            {
                if (!IsSupportBatch(database, isDynamicQuery, isMultiMap, sameType))
                {
                    continue;
                }

                var query2IsMultiMap = sameType ? isMultiMap : !isMultiMap;

                var firstBatchStart = Random.Shared.Next(0, orderedValues.Count - 2);
                var secondBatchStart = Random.Shared.Next(0, orderedValues.Count - 2);
                var methodPassParametrs = BatchMethodPassParametrs(
                    orderedValues,
                    withDynamicParameters,
                    isDynamicQuery,
                    firstBatchStart: firstBatchStart,
                    firstMultiMap: isMultiMap,
                    secondBatchStart: secondBatchStart,
                    secondMultiMap: query2IsMultiMap);

                stringBuilder.Append($@"
        [Test, Order({order})]
        public async Task {SelectBatchMethodName(isDynamicQuery, withDynamicParameters, isMultiMap, sameType)}Test{async}()
        {{
            await using (var connection = GlobalSetUp.GetDbConnection)
            {{
                await connection.OpenAsync();");
                if (withDynamicParameters)
                {
                    stringBuilder.Append($@"
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = {orderedValues[firstBatchStart].Id};
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = ""id"";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = {orderedValues[secondBatchStart].Id};
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = ""id"";");
                }

                if (isDynamicQuery)
                {
                    stringBuilder.Append($@"
                var query1 = {SelectQueryText(model, database, isDynamicQuery, isMultiMap)};
                var query2 = {SelectQueryText(model, database, isDynamicQuery, query2IsMultiMap)};");
                }

                firstBatchStart++;
                if (isMultiMap || query2IsMultiMap)
                {
                    MultiMapCheck();
                }
                else
                {
                    SameTypeCheck();
                }

                stringBuilder.Append($@"
            }}
        }}
");
                void MultiMapCheck()
                {
                    stringBuilder.Append($@"
                var firstItems1 = new List<{model.ClassName(isDynamicQuery)}>();");
                    if (isMultiMap)
                    {
                        stringBuilder.Append($@"
                var firstItems2 = new List<{model.ClassName(isDynamicQuery)}>();");
                    }

                    stringBuilder.Append($@"
                var secondItems1 = new List<{model.ClassName(isDynamicQuery)}>();");
                    if (query2IsMultiMap)
                    {
                        stringBuilder.Append($@"
                var secondItems2 = new List<{model.ClassName(isDynamicQuery)}>();");
                    }

                    stringBuilder.Append($@"
                {await} {TypeHelper.ThisAsInterface(interfaceTypeName)}.{SelectBatchMethodName(isDynamicQuery, withDynamicParameters, isMultiMap, sameType)}{async}({methodPassParametrs});
                Assert.That(firstItems1, Has.Count.EqualTo({orderedValues.Count - firstBatchStart}));");
                    if (isMultiMap)
                    {
                        stringBuilder.Append($@"
                Assert.That(firstItems2, Has.Count.EqualTo({orderedValues.Count - firstBatchStart}));");
                    }

                    var index = 0;
                    for (; firstBatchStart < orderedValues.Count; firstBatchStart++)
                    {
                        stringBuilder.Append(@$"
                        {model.ClassName(isDynamicQuery)}.{ModelGenerator.AssertMethodName}(firstItems1[{index}],{TestsPart.TestDataArrayName}[{firstBatchStart}], false);");
                        if (isMultiMap)
                        {
                            stringBuilder.Append(@$"
                        {model.ClassName(isDynamicQuery)}.{ModelGenerator.AssertMethodName}(firstItems2[{index}],{TestsPart.TestDataArrayName}[{firstBatchStart}], false);");
                        }

                        index++;
                    }

                    secondBatchStart++;
                    stringBuilder.Append($@"
                Assert.That(secondItems1, Has.Count.EqualTo({orderedValues.Count - secondBatchStart}));");
                    if (query2IsMultiMap)
                    {
                        stringBuilder.Append($@"
                Assert.That(secondItems2, Has.Count.EqualTo({orderedValues.Count - secondBatchStart}));");
                    }

                    index = 0;
                    for (; secondBatchStart < orderedValues.Count; secondBatchStart++)
                    {
                        stringBuilder.Append(@$"
                        {model.ClassName(isDynamicQuery)}.{ModelGenerator.AssertMethodName}(secondItems1[{index}],{TestsPart.TestDataArrayName}[{secondBatchStart}], false);");
                        if (query2IsMultiMap)
                        {
                            stringBuilder.Append(@$"
                        {model.ClassName(isDynamicQuery)}.{ModelGenerator.AssertMethodName}(secondItems2[{index}],{TestsPart.TestDataArrayName}[{secondBatchStart}], false);");
                        }
                        index++;
                    }
                }

                void SameTypeCheck()
                {
                    stringBuilder.Append($@"
                int resultIndex = 0;
                foreach(var batchResult in {await} {TypeHelper.ThisAsInterface(interfaceTypeName)}.{SelectBatchMethodName(isDynamicQuery, withDynamicParameters, isMultiMap, sameType)}{async}({methodPassParametrs}))
                {{
                    if(++resultIndex == 1)
                    {{
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo({orderedValues.Count - firstBatchStart}));
");
                    var index = 0;
                    for (; firstBatchStart < orderedValues.Count; firstBatchStart++)
                    {
                        stringBuilder.Append(@$"
                        {model.ClassName(isDynamicQuery)}.{ModelGenerator.AssertMethodName}(models[{index}],{TestsPart.TestDataArrayName}[{firstBatchStart}], false);");
                        index++;
                    }

                    secondBatchStart++;
                    stringBuilder.Append($@"
                        continue;
                    }}                    

                    if(resultIndex == 2)
                    {{
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo({orderedValues.Count - secondBatchStart}));
");
                    index = 0;
                    for (; secondBatchStart < orderedValues.Count; secondBatchStart++)
                    {
                        stringBuilder.Append(@$"
                        {model.ClassName(isDynamicQuery)}.{ModelGenerator.AssertMethodName}(models[{index}],{TestsPart.TestDataArrayName}[{secondBatchStart}], false);");
                        index++;
                    }
                    stringBuilder.Append($@"
                        continue;
                    }}
                    
                    Assert.Fail(""Unexpected batch count"");
                }}");
        }
    }
        }

        private static string BatchMethodPassParametrs(
            List<ModelValue> orderedValues,
            bool withDynamicParameters,
            bool isDynamicQuery,
            bool firstMultiMap,
            int firstBatchStart,
            bool secondMultiMap,
            int secondBatchStart)
        {
            var dynamicParametr1 = withDynamicParameters ? ", [parametr1]" : $", {orderedValues[firstBatchStart].Id}";
            var dynamicParametr2 = withDynamicParameters ? ", [parametr2]" : $", {orderedValues[secondBatchStart].Id}";

            var dynamicQuery1 = isDynamicQuery ? ", query1" : string.Empty;
            var dynamicQuery2 = isDynamicQuery ? ", query2" : string.Empty;

            string mapDelegates;
            if (!firstMultiMap && !secondMultiMap)
            {
                mapDelegates = string.Empty;
            }
            else
            {
                var builder = new DefaultInterpolatedStringHandler();
                if (firstMultiMap)
                {
                    builder.AppendLiteral(", (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }");
                }
                else
                {
                    builder.AppendLiteral(", (item1) => { firstItems1.Add(item1); }");
                }

                if (secondMultiMap)
                {
                    builder.AppendLiteral(", (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); }");
                }
                else
                {
                    builder.AppendLiteral(", (item1) => { secondItems1.Add(item1); }");
                }

                mapDelegates = builder.ToStringAndClear();
            }

            return $"connection{dynamicParametr1}{dynamicQuery1}{dynamicParametr2}{dynamicQuery2}{mapDelegates}";
        }
    }
}
