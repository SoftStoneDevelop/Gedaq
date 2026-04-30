using TestsGenerator.Constants;
using TestsGenerator.Enums;
using TestsGenerator.Helpers;

namespace TestsGenerator.Generators.PostgreSQL
{
    internal static class BinaryExportModelInnerTest
    {
        private const string _testName = "ExportModelInner";

        public static void Generate(
            int order,
            StringBuilderArray.StringBuilderArray stringBuilder,
            Model.ModelType model,
            string interfaceTypeName)
        {
            foreach (var isDynamicQuery in ValueConstants.BoolValues)
            {
                foreach (var isOverrideDbTypes in ValueConstants.BoolValues)
                {
                    foreach (var isMultiMap in ValueConstants.BoolValues)
                    {
                        ExportModelInnerConfig(
                            stringBuilder,
                            model,
                            interfaceTypeName,
                            isDynamicQuery: isDynamicQuery,
                            isMultiMap: isMultiMap,
                            isOverrideDbTypes: isOverrideDbTypes);

                        foreach (var isAsync in ValueConstants.BoolValues)
                        {
                            ExportModelInnerTest(
                                order,
                                model,
                                stringBuilder,
                                isAsync,
                                isDynamicQuery: isDynamicQuery,
                                interfaceTypeName,
                                isMultiMap: isMultiMap,
                                isOverrideDbTypes: isOverrideDbTypes);
                        }
                    }
                }
            }
        }

        private static void ExportModelInnerConfig(
            StringBuilderArray.StringBuilderArray stringBuilder,
            Model.ModelType model,
            string interfaceTypeName,
            bool isDynamicQuery,
            bool isMultiMap,
            bool isOverrideDbTypes)
        {
            var classWithAtr = isDynamicQuery || !isOverrideDbTypes;
            var query = isDynamicQuery ?
                ValueConstants.NullValue :
                ExportQuery(model, isDynamicQuery, isOverrideDbTypes, isMultiMap);

            var queryMapTypes = isMultiMap ?
                $"typeof({model.ModelInner.ClassName(isDynamicQuery, classWithAtr)}), typeof({model.ModelInner.ClassName(isDynamicQuery, classWithAtr)})" :
                $"typeof({model.ModelInner.ClassName(isDynamicQuery, classWithAtr)})";

            var dbTypeOverride = string.Empty;
            if (isOverrideDbTypes)
            {
                if (isMultiMap)
                {
                    dbTypeOverride = $@",
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {{
                {model.ModelInner.IdTypeInfo.SpecialDbTypeStr()},
                {model.ModelInner.TypeInfo.SpecialDbTypeStr()},
                {model.ModelInner.TypeInfo.SpecialDbTypeStr()}
            }}),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {{
                {model.ModelInner.IdTypeInfo.SpecialDbTypeStr()},
                {model.ModelInner.TypeInfo.SpecialDbTypeStr()},
                {model.ModelInner.TypeInfo.SpecialDbTypeStr()}
            }})";
                }
                else
                {
                    dbTypeOverride = $@",
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {{
                {model.ModelInner.IdTypeInfo.SpecialDbTypeStr()},
                {model.ModelInner.TypeInfo.SpecialDbTypeStr()},
                {model.ModelInner.TypeInfo.SpecialDbTypeStr()}
            }})";
                }
            }

            string dbTypes;
            if  (isOverrideDbTypes)
            {
                dbTypes = $@"new NpgsqlDbType[]
            {{
                {model.ModelInner.IdTypeInfo.SpecialDbTypeStr()},
                {model.ModelInner.TypeInfo.SpecialDbTypeStr()},
                {model.ModelInner.TypeInfo.SpecialDbTypeStr()}
            }}";
            }
            else
            {
                dbTypes = ValueConstants.NullValue;
            }

            stringBuilder.Append($@"
[Gedaq.Npgsql.Attributes.BinaryExport(
            query: {query},
            methodName:""{ExportMethodName(isDynamicQuery, isMultiMap, isOverrideDbTypes)}"",
            queryMapTypes: [{queryMapTypes}],
            dbTypes: {dbTypes},
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof({interfaceTypeName})){dbTypeOverride}]
        private void {ExportMethodName(isDynamicQuery, isMultiMap, isOverrideDbTypes)}Config()
        {{
        }}
");
        }

        private static string ExportMethodName(
            bool isDynamicQuery,
            bool isMultiMap,
            bool isOverrideDbTypes)
        {
            return $"{ValueConstants.MultiMapQueryPrefix(isMultiMap)}" +
                $"{ValueConstants.DynamicQueryPrefix(isDynamicQuery)}" +
                $"{ValueConstants.WithAttributePrefix(isOverrideDbTypes)}" +
                $"{_testName}";
        }

        private static string ExportQuery(
            Model.ModelType model,
            bool isDynamicQuery,
            bool isOverrideDbTypes,
            bool isMultiMap)
        {
            var classWithAtr = isDynamicQuery || !isOverrideDbTypes;
            if (isMultiMap)
            {
                return $@"@""
COPY
(
    SELECT
        {model.ModelInner.IdColumnName},
        {model.ModelInner.ValueColumnName},
        {model.ModelInner.NullableValueColumnName},
        
        {model.ModelInner.IdColumnName},
        {model.ModelInner.ValueColumnName},
        {model.ModelInner.NullableValueColumnName}
    FROM {Database.PostgreSQL.ToDefaultSchema()}.binary_{model.ModelInner.TableName}
) TO STDOUT (FORMAT BINARY)
""";
            }
            else if (classWithAtr)
            {
                return $@"@""
COPY {Database.PostgreSQL.ToDefaultSchema()}.binary_{model.ModelInner.TableName}
(
    {model.ModelInner.IdColumnName},
    {model.ModelInner.ValueColumnName},
    {model.ModelInner.NullableValueColumnName}
) TO STDOUT (FORMAT BINARY)
""";
            }
            else
            {
                return $@"@""
COPY {Database.PostgreSQL.ToDefaultSchema()}.binary_{model.ModelInner.TableName}
(
    {model.ModelInner.IdColumnName},
    {model.ModelInner.NullableValueColumnName},
    {model.ModelInner.ValueColumnName}
) TO STDOUT (FORMAT BINARY)
""";
            }
        }

        private static void ExportModelInnerTest(
            int order,
            Model.ModelType model,
            StringBuilderArray.StringBuilderArray stringBuilder,
            bool isAsync,
            bool isDynamicQuery,
            string interfaceTypeName,
            bool isMultiMap,
            bool isOverrideDbTypes)
        {
            var classWithAtr = isDynamicQuery || !isOverrideDbTypes;

            var await = isAsync ? "await " : string.Empty;
            var async = isAsync ? "Async" : string.Empty;

            var query =
                isDynamicQuery ?
                $", {ExportQuery(model, isDynamicQuery, isOverrideDbTypes, isMultiMap)}" :
                string.Empty;

            stringBuilder.Append($@"
        [Test, Order({order})]
        public {async.ToLowerInvariant()} {(isAsync ? "Task" : "void")} {ExportMethodName(isDynamicQuery, isMultiMap, isOverrideDbTypes)}{async}Test()
        {{
            {await}using (var connection = GlobalSetUp.GetConnection)
            {{
                {await}connection.Open{async}();
                var expectCount = {TestsPart.TestDataArrayName}.Where(wh => wh.{model.ModelInnerName} != null).Count();");

            if (isMultiMap)
            {
                stringBuilder.Append($@"
                var models1 = new List<{model.ModelInner.ClassName(isDynamicQuery, classWithAtr)}>();
                var models2 = new List<{model.ModelInner.ClassName(isDynamicQuery, classWithAtr)}>();
                {await}{TypeHelper.ThisAsInterface(interfaceTypeName)}.{ExportMethodName(isDynamicQuery, isMultiMap, isOverrideDbTypes)}{async}(connection{query}, (item1, item2) => {{ models1.Add(item1); models2.Add(item2); }});
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {{
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = {TestsPart.TestDataArrayName}.First(wh => wh.{model.ModelInnerName} != null && wh.{model.ModelInnerName}.{model.ModelInner.IdName} == model1.{model.ModelInner.IdName}).{model.ModelInnerName};
                    {model.ModelInner.ClassName(isDynamicQuery, classWithAtr)}.{ModelGenerator.AssertMethodName}(model1, expectedModel, false);

                    expectedModel = {TestsPart.TestDataArrayName}.First(wh => wh.{model.ModelInnerName} != null && wh.{model.ModelInnerName}.{model.ModelInner.IdName} == model2.{model.ModelInner.IdName}).{model.ModelInnerName};
                    {model.ModelInner.ClassName(isDynamicQuery, classWithAtr)}.{ModelGenerator.AssertMethodName}(model2, expectedModel, false);
                }}");
            }
            else
            {
                stringBuilder.Append($@"
                var models = {await}{TypeHelper.ThisAsInterface(interfaceTypeName)}.{ExportMethodName(isDynamicQuery, isMultiMap, isOverrideDbTypes)}{async}(connection{query}).ToList{async}();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {{
                    var model = models[modelIndex];
                    var expectedModel = {TestsPart.TestDataArrayName}.First(wh => wh.{model.ModelInnerName} != null && wh.{model.ModelInnerName}.{model.ModelInner.IdName} == model.{model.ModelInner.IdName}).{model.ModelInnerName};
                    {model.ModelInner.ClassName(isDynamicQuery, classWithAtr)}.{ModelGenerator.AssertMethodName}(model, expectedModel, false);
                }}");
            }

            stringBuilder.Append($@"
            }}
        }}
");
        }
    }
}