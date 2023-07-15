using System.Text;
using TestsGenerator.Constants;
using TestsGenerator.Enums;
using TestsGenerator.Helpers;
using TestsGenerator.Model;
using TestsGenerator.TypeValueHelpers;

namespace TestsGenerator.Generators.PostgreSQL
{
    internal static class InsertModel
    {
        private static string _testName = "InsertModel";

        public static void Generate(
            int order,
            StringBuilderArray.StringBuilderArray stringBuilder,
            Model.ModelType model,
            ModelValueStorage storage
            )
        {
            var indexValue = 0;
            InsertModelConfig(stringBuilder, model);
            InsertModelTest(order, stringBuilder, storage, ref indexValue, indexValue + 2, isAsync: false);
            InsertModelTest(order, stringBuilder, storage, ref indexValue, indexValue + 2, isAsync: true);

            if(DefaultTypeHelper.CanConvert(model.TypeInfo.ItemTypeFullName) &&
                model.TypeInfo.EnumerableType != EnumerableType.List//cannot implicity convert array to list
                )
            {
                InsertModelReturningScalarTest(order, stringBuilder, storage, model, ref indexValue, indexValue + 2, isAsync: false);
                InsertModelReturningScalarTest(order, stringBuilder, storage, model, ref indexValue, indexValue + 2, isAsync: true);
            }

            InsertModelReturningConfig(stringBuilder, model);
            InsertModelReturningReadTest(order, stringBuilder, storage, model, ref indexValue, indexValue + 4, isAsync: false);
            var canDbConnection = model.TypeInfo.EnumerableType == EnumerableType.SingleType;
            int endIndex = !canDbConnection ? storage.Values.Count : indexValue + 4;
            InsertModelReturningReadTest(order, stringBuilder, storage, model, ref indexValue, endIndex, isAsync: true);

            if(canDbConnection)
                DbConnection.InsertModel.Generate(order, stringBuilder, model, storage, Database.PostgreSQL, ref indexValue, toEnd: true);
        }

        private static void InsertModelConfig(
            StringBuilderArray.StringBuilderArray stringBuilder,
            Model.ModelType model
            )
        {
            stringBuilder.Append($@"
[Gedaq.Npgsql.Attributes.Query(
            query: @""
INSERT INTO {Database.PostgreSQL.ToDefaultSchema()}.{model.TableName}(
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

        private static void InsertModelTest(
            int order,
            StringBuilderArray.StringBuilderArray stringBuilder,
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

        private static void InsertModelReturningConfig(
            StringBuilderArray.StringBuilderArray stringBuilder,
            Model.ModelType model
            )
        {
            stringBuilder.Append($@"
[Gedaq.Npgsql.Attributes.Query(
            query: @""
INSERT INTO {Database.PostgreSQL.ToDefaultSchema()}.{model.TableName}(
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
    {model.NullableValueColumnName},
    {model.ValueColumnName},
~StartInner::{model.ModelInnerName}:{model.ModelInner.IdName}~
~Reinterpret::{model.ModelInner.IdName}~
    {model.ModelInnerColumnName},
~EndInner::{model.ModelInnerName}~
    {model.IdColumnName}
;
"",
            methodName:""{_testName}Returning"",
            queryMapType: typeof({model.ClassName}),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
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

        private static void InsertModelReturningReadTest(
            int order,
            StringBuilderArray.StringBuilderArray stringBuilder,
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
                models = {await} {_testName}Returning{async}(connection, {value.Id}, {value.Value}, {value.NullableValue}, {(value.InnerModel == null ? "null" : value.InnerModel.IdValue)}).ToList{async}();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];
");
                stringBuilder.Append(model.Assert("model", value, innerHaveOnlyId: true));
            }
            stringBuilder.Append($@"
            }}
        }}
");
        }

        private static void InsertModelReturningScalarTest(
            int order,
            StringBuilderArray.StringBuilderArray stringBuilder,
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

            if (model.ValueStorage is CharValueHelper ||
                model.ValueStorage is ByteValueHelper || 
                model.ValueStorage is SByteValueHelper ||
                model.ValueStorage is TimeOnlyValueHelper ||
                model.ValueStorage is DateOnlyValueHelper ||
                model.ValueStorage is BigIntegerValueHelper)
            {
                stringBuilder.Append($@"
        [Ignore(""Invalid cast, ExecuteScalar provider return wrong type"")]
        [Test, Order({order})]
        public async Task {_testName}TestReturningScalar{async}()
        {{
            
        }}
");
                return;
            }

            stringBuilder.Append($@"
        [Test, Order({order})]
        public async Task {_testName}TestReturningScalar{async}()
        {{
            await using (var connection = GlobalSetUp.GetConnection)
            {{
                await connection.OpenAsync();
                {model.NullableValueType} nullable = null;
");
            for (; indexValue < endIndex; indexValue++)
            {
                ModelValue value = storage.Values[indexValue];
                stringBuilder.Append($@"
                nullable = {await} Scalar{_testName}Returning{async}(connection, {value.Id}, {value.Value}, {value.NullableValue}, {(value.InnerModel == null ? "null" : value.InnerModel.IdValue)});
");
                if(value.NullableValue == ValueConstants.NullValue)
                {
                    stringBuilder.Append($@"
                Assert.That(nullable, Is.Null);
");
                }
                else
                {
                    stringBuilder.Append($@"
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo({value.NullableValue}));
");
                }
            }
            stringBuilder.Append($@"
            }}
        }}
");
        }
    }
}
