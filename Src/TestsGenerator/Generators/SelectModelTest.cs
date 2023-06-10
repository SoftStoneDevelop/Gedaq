using System.Linq;
using System.Text;
using TestsGenerator.Enums;
using TestsGenerator.Model;

namespace TestsGenerator.Generators
{
    internal static class SelectModelTest
    {
        public static void Generate(
            int order,
            StringBuilder stringBuilder,
            Model.ModelType model,
            ModelValueStorage storage,
            Database database
            )
        {
            var orderedValues = storage.Values.OrderBy(or => or.IdValue).ToList();
            var testName = "SelectModelTest";
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
FROM public.{model.TableName} m
LEFT JOIN {model.ModelInner.TableName} mi ON mi.{model.ModelInner.IdColumnName} = m.{model.ModelInnerColumnName}
ORDER BY
    m.{model.IdColumnName} ASC;
""
";
            switch (database)
            {
                case Database.PostgreSQL:
                {
                    stringBuilder.AppendLine($@"
[Gedaq.Npgsql.Attributes.Query(
            query: {query},
            methodName:""SelectModel"",
            queryMapType: typeof({model.ClassName}),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Private
            )
            ]
        [Test, Order({order})]
        public async Task {testName}()
        {{
            await using (var connection = GlobalSetUp.GetConnection)
            {{
                await connection.OpenAsync();
                var models = SelectModel(connection).ToList();
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

        [Test, Order({order})]
        public async Task {testName}Async()
        {{
            await using (var connection = GlobalSetUp.GetConnection)
            {{
                await connection.OpenAsync();
                var models = await SelectModelAsync(connection).ToListAsync();
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

            stringBuilder.AppendLine($@"
[Gedaq.DbConnection.Attributes.Query(
            query: {query},
            methodName:""DbConnectionSelectModel"",
            queryMapType: typeof({model.ClassName}),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Private
            )
            ]
        [Test, Order({order})]
        public async Task DbConnection{testName}()
        {{
            await using (var connection = GlobalSetUp.GetDbConnection)
            {{
                await connection.OpenAsync();
                var models = DbConnectionSelectModel(connection).ToList();
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

        [Test, Order({order})]
        public async Task DbConnection{testName}Async()
        {{
            await using (var connection = GlobalSetUp.GetDbConnection)
            {{
                await connection.OpenAsync();
                var models = await DbConnectionSelectModelAsync(connection).ToListAsync();
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