﻿using System.Text;
using TestsGenerator.Model;

namespace TestsGenerator.Generators.PostgreSQL
{
    internal static class InsertModelTest
    {
        private static string _testName = "InsertModel";

        public static void Generate(
            int order,
            StringBuilder stringBuilder,
            Model.ModelType model,
            ModelValueStorage storage,
            ref int indexValue
            )
        {
            InsertModelConfig(stringBuilder, model);
            InsertModelTests(order, stringBuilder, storage, ref indexValue, indexValue + 2, isAsync: false);
            InsertModelTests(order, stringBuilder, storage, ref indexValue, indexValue + 2, isAsync: true);

            InsertModelReturningReadConfig(stringBuilder, model);
            InsertModelReturningReadTests(order, stringBuilder, storage, model, ref indexValue, indexValue + 2, isAsync: false);
            InsertModelReturningReadTests(order, stringBuilder, storage, model, ref indexValue, indexValue + 2, isAsync: true);
        }

        private static void InsertModelConfig(
            StringBuilder stringBuilder,
            Model.ModelType model
            )
        {
            stringBuilder.Append($@"
[Gedaq.Npgsql.Attributes.Query(
            query: @""
INSERT INTO public.{model.TableName}(
	{model.IdColumnName},
    {model.ValueColumnName},
    {model.NullableValueColumnName},
    {model.ModelInnerColumnName}
)
VALUES (
    $1, 
    $2, 
    $3,
    $4
);
"",
            methodName:""{_testName}"",
            queryMapType: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Private
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof({model.ModelInner.IdType}), 
                position: 1,
                methodParametrName: ""{model.ModelInner.IdColumnName}"", 
                dbType: {model.IdTypeInfo.SpecialDbTypeStr()}
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof({model.ModelInner.ValueType}),
                position: 2,
                methodParametrName: ""{model.ModelInner.ValueColumnName}"",
                dbType: {model.TypeInfo.SpecialDbTypeStr()}
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof({model.ModelInner.NullableValueType}), 
                position: 3, 
                methodParametrName: ""{model.ModelInner.NullableValueColumnName}"", 
                dbType: {model.TypeInfo.SpecialDbTypeStr()}
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof({model.ModelInner.IdType}?), 
                position: 4, 
                methodParametrName: ""{model.ModelInnerColumnName}"", 
                dbType: {model.ModelInner.IdTypeInfo.SpecialDbTypeStr()}
                )
            ]
        public void {_testName}Config()
        {{
        }}
");
        }

        private static void InsertModelTests(
            int order,
            StringBuilder stringBuilder,
            ModelValueStorage storage,
            ref int indexValue,
            int endIndex,
            bool isAsync
            )
        {
            if (endIndex > storage.Values.Count)
            {
                throw new System.ArgumentOutOfRangeException(nameof(endIndex));
            }

            var await = isAsync ? "await" : string.Empty;
            var async = isAsync ? "Async" : string.Empty;
            stringBuilder.Append($@"
        [Test, Order({order})]
        public async Task {_testName}Test{async}()
        {{
            await using (var connection = GlobalSetUp.GetConnection)
            {{
                await connection.OpenAsync();
                int changedRows = 0;
");
            for (; indexValue < endIndex; indexValue++)
            {
                ModelValue value = storage.Values[indexValue];
                stringBuilder.Append($@"
                changedRows = {await} {_testName}{async}(connection, {value.Id}, {value.Value}, {value.NullableValue}, {(value.InnerModel == null ? "null" : value.InnerModel.IdValue)});
                Assert.That(changedRows, Is.EqualTo(1));
");
            }
            stringBuilder.Append($@"
            }}
        }}
");
        }

        private static void InsertModelReturningReadConfig(
            StringBuilder stringBuilder,
            Model.ModelType model
            )
        {
            stringBuilder.Append($@"
[Gedaq.Npgsql.Attributes.Query(
            query: @""
INSERT INTO public.{model.TableName}(
	{model.IdColumnName},
    {model.ValueColumnName},
    {model.NullableValueColumnName},
    {model.ModelInnerColumnName}
)
VALUES (
    $1, 
    $2, 
    $3,
    $4
)
RETURNING
    {model.IdColumnName},
    {model.ValueColumnName},
~StartInner::{model.ModelInnerName}:{model.ModelInner.IdName}~
~Reinterpret::{model.ModelInner.IdName}~
    {model.ModelInnerColumnName},
~EndInner::{model.ModelInnerName}~
    {model.NullableValueColumnName}
;
"",
            methodName:""{_testName}ReturningRead"",
            queryMapType: typeof({model.ClassName}),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Private
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof({model.ModelInner.IdType}), 
                position: 1,
                methodParametrName: ""{model.ModelInner.IdColumnName}"", 
                dbType: {model.IdTypeInfo.SpecialDbTypeStr()}
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof({model.ModelInner.ValueType}),
                position: 2,
                methodParametrName: ""{model.ModelInner.ValueColumnName}"",
                dbType: {model.TypeInfo.SpecialDbTypeStr()}
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof({model.ModelInner.NullableValueType}), 
                position: 3, 
                methodParametrName: ""{model.ModelInner.NullableValueColumnName}"", 
                dbType: {model.TypeInfo.SpecialDbTypeStr()}
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof({model.ModelInner.IdType}?), 
                position: 4, 
                methodParametrName: ""{model.ModelInnerColumnName}"", 
                dbType: {model.ModelInner.IdTypeInfo.SpecialDbTypeStr()}
                )
            ]
        public void {_testName}ReturningConfig()
        {{
        }}
");
        }

        private static void InsertModelReturningReadTests(
            int order,
            StringBuilder stringBuilder,
            ModelValueStorage storage,
            Model.ModelType model,
            ref int indexValue,
            int endIndex,
            bool isAsync
            )
        {
            if (endIndex > storage.Values.Count)
            {
                throw new System.ArgumentOutOfRangeException(nameof(endIndex));
            }

            var await = isAsync ? "await" : string.Empty;
            var async = isAsync ? "Async" : string.Empty;
            stringBuilder.Append($@"
        [Test, Order({order})]
        public async Task {_testName}TestReturningRead{async}()
        {{
            await using (var connection = GlobalSetUp.GetConnection)
            {{
                await connection.OpenAsync();
                List<{model.ClassName}> models = null;
                {model.ClassName} model = null;
");
            for (; indexValue < endIndex; indexValue++)
            {
                ModelValue value = storage.Values[indexValue];
                stringBuilder.Append($@"
                models = {await} {_testName}ReturningRead{async}(connection, {value.Id}, {value.Value}, {value.NullableValue}, {(value.InnerModel == null ? "null" : value.InnerModel.IdValue)}).ToList{async}();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];
");
                stringBuilder.Append(model.Assert(value, innerHaveOnlyId: true));
            }
            stringBuilder.Append($@"
            }}
        }}
");
        }
    }
}