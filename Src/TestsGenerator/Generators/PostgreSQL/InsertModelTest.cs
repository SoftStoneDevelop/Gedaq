using System;
using TestsGenerator.Constants;
using TestsGenerator.Enums;
using TestsGenerator.Helpers;
using TestsGenerator.Model;
using TestsGenerator.TypeValueHelpers;

namespace TestsGenerator.Generators.PostgreSQL
{
    internal static class InsertModel
    {
        private const string _testName = "InsertModel";

        public static void Generate(
            int order,
            StringBuilderArray.StringBuilderArray stringBuilder,
            Model.ModelType model,
            ModelValueStorage storage,
            string interfaceTypeName)
        {
            var indexValue = 0;
            InsertModelConfig(
                stringBuilder, 
                model,
                interfaceTypeName);

            InsertModelTest(
                order, 
                stringBuilder,
                storage,
                model,
                ref indexValue, 
                indexValue + 2, 
                isAsync: false,
                interfaceTypeName);

            InsertModelTest(
                order, 
                stringBuilder, 
                storage,
                model,
                ref indexValue, 
                indexValue + 2,
                isAsync: true, 
                interfaceTypeName);

            Span<bool> dynamicParametrValues = [true, false];
            foreach (var dynamicParametrValue in dynamicParametrValues)
            {
                InsertModelReturningConfig(
                    stringBuilder,
                    model,
                    interfaceTypeName,
                    withDynamicParameter: dynamicParametrValue);

                if (DefaultTypeHelper.CanConvert(model.TypeInfo.ItemTypeFullName) &&
                    model.TypeInfo.EnumerableType != EnumerableType.List) // cannot implicity convert array to list
                {
                    InsertModelReturningScalarTest(
                        order,
                        stringBuilder,
                        storage,
                        model,
                        ref indexValue,
                        indexValue + 2,
                        isAsync: false,
                        interfaceTypeName,
                        withDynamicParameter: dynamicParametrValue);

                    InsertModelReturningScalarTest(
                        order,
                        stringBuilder,
                        storage,
                        model,
                        ref indexValue,
                        indexValue + 2,
                        isAsync: true,
                        interfaceTypeName,
                        withDynamicParameter: dynamicParametrValue);
                }
            }

            InsertModelReturningReadTest(
                order, 
                stringBuilder, 
                storage, 
                model, 
                ref indexValue, 
                indexValue + 4, 
                isAsync: false, 
                interfaceTypeName);

            var canDbConnection = model.TypeInfo.EnumerableType == EnumerableType.SingleType;
            int endIndex = !canDbConnection ? storage.Values.Count : indexValue + 4;
            InsertModelReturningReadTest(
                order, 
                stringBuilder, 
                storage, 
                model, 
                ref indexValue, 
                endIndex, 
                isAsync: true, 
                interfaceTypeName);

            if (canDbConnection)
            {
                DbConnection.InsertModel.Generate(
                    order,
                    stringBuilder,
                    model,
                    storage,
                    Database.PostgreSQL,
                    ref indexValue,
                    interfaceTypeName,
                    toEnd: true);
            }
        }

        private static void InsertModelConfig(
            StringBuilderArray.StringBuilderArray stringBuilder,
            Model.ModelType model,
            string interfaceTypeName)
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
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof({interfaceTypeName})), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof({model.ModelInner.IdType}), 
                position: 1,
                methodParametrName: ""{model.ModelInner.IdColumnName}"", 
                dbType: {model.IdTypeInfo.SpecialDbTypeStr()}),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof({model.ModelInner.ValueType}),
                position: 2,
                methodParametrName: ""{model.ModelInner.ValueColumnName}"",
                dbType: {model.TypeInfo.SpecialDbTypeStr()}),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof({model.ModelInner.NullableValueType}), 
                position: 3, 
                methodParametrName: ""{model.ModelInner.NullableValueColumnName}"", 
                dbType: {model.TypeInfo.SpecialDbTypeStr()}),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof({model.ModelInner.IdType}?), 
                position: 4, 
                methodParametrName: ""{model.ModelInnerColumnName}"", 
                dbType: {model.ModelInner.IdTypeInfo.SpecialDbTypeStr()})]
        public void {_testName}Config()
        {{
        }}
");
        }

        private static void InsertModelTest(
            int order,
            StringBuilderArray.StringBuilderArray stringBuilder,
            ModelValueStorage storage,
            Model.ModelType model,
            ref int indexValue,
            int endIndex,
            bool isAsync,
            string interfaceTypeName)
        {
            System.ArgumentOutOfRangeException.ThrowIfGreaterThan(endIndex, storage.Values.Count);

            var await = isAsync ? "await" : string.Empty;
            var async = isAsync ? "Async" : string.Empty;
            stringBuilder.Append($@"
        [Test, Order({order})]
        public async Task {_testName}Test{async}()
        {{
            await using (var connection = GlobalSetUp.GetConnection)
            {{
                await connection.OpenAsync();
                int changedRows = 0;");
            for (; indexValue < endIndex; indexValue++)
            {
                stringBuilder.Append($@"
                changedRows = {await} {TypeHelper.ThisAsInterface(interfaceTypeName)}.{_testName}{async}(connection, {TestsPart.TestDataArrayName}[{indexValue}].{model.IdName}, {TestsPart.TestDataArrayName}[{indexValue}].{model.ValueName}, {TestsPart.TestDataArrayName}[{indexValue}].{model.NullableValueName}, {TestsPart.TestDataArrayName}[{indexValue}].{model.ModelInnerName} == null ? {ValueConstants.NullValue} : {TestsPart.TestDataArrayName}[{indexValue}].{model.ModelInnerName}.{model.ModelInner.IdName});
                Assert.That(changedRows, Is.EqualTo(1));");
            }
            stringBuilder.Append($@"
            }}
        }}
");
        }

        private static void InsertModelReturningConfig(
            StringBuilderArray.StringBuilderArray stringBuilder,
            Model.ModelType model,
            string interfaceTypeName,
            bool withDynamicParameter)
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
            methodName:""{_testName}{(withDynamicParameter ? NameConstants.DynamicParametr : "")}Returning"",
            queryMapTypes: [typeof({model.ClassName})],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof({interfaceTypeName})),");

            if (withDynamicParameter)
            {
                stringBuilder.Append($@"
            Gedaq.Npgsql.Attributes.DynamicParametr()");
            }
            else
            {
                stringBuilder.Append($@"
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof({model.ModelInner.IdType}), 
                position: 1,
                methodParametrName: ""{model.ModelInner.IdColumnName}"", 
                dbType: {model.IdTypeInfo.SpecialDbTypeStr()}),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof({model.ModelInner.ValueType}),
                position: 2,
                methodParametrName: ""{model.ModelInner.ValueColumnName}"",
                dbType: {model.TypeInfo.SpecialDbTypeStr()}),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof({model.ModelInner.NullableValueType}), 
                position: 3, 
                methodParametrName: ""{model.ModelInner.NullableValueColumnName}"", 
                dbType: {model.TypeInfo.SpecialDbTypeStr()}),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof({model.ModelInner.IdType}?), 
                position: 4, 
                methodParametrName: ""{model.ModelInnerColumnName}"", 
                dbType: {model.ModelInner.IdTypeInfo.SpecialDbTypeStr()})");
            }

            stringBuilder.Append($@"]
        public void {_testName}{(withDynamicParameter ? NameConstants.DynamicParametr : "")}ReturningConfig()
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
            bool isAsync,
            string interfaceTypeName)
        {
            System.ArgumentOutOfRangeException.ThrowIfGreaterThan(endIndex, storage.Values.Count);

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
");
            for (; indexValue < endIndex; indexValue++)
            {
                stringBuilder.Append($@"
                models = {await} {TypeHelper.ThisAsInterface(interfaceTypeName)}.{_testName}Returning{async}(connection, {TestsPart.TestDataArrayName}[{indexValue}].{model.IdName}, {TestsPart.TestDataArrayName}[{indexValue}].{model.ValueName}, {TestsPart.TestDataArrayName}[{indexValue}].{model.NullableValueName}, {TestsPart.TestDataArrayName}[{indexValue}].{model.ModelInnerName} == null ? {ValueConstants.NullValue} : {TestsPart.TestDataArrayName}[{indexValue}].{model.ModelInnerName}.{model.ModelInner.IdName});
                Assert.That(models, Has.Count.EqualTo(1));
                {model.ClassName}.{ModelGenerator.AssertMethodName}(models[0],{TestsPart.TestDataArrayName}[{indexValue}], true, ignoreInner: false);");
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
            bool isAsync,
            string interfaceTypeName,
            bool withDynamicParameter)
        {
            System.ArgumentOutOfRangeException.ThrowIfGreaterThan(endIndex, storage.Values.Count);

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
        public async Task {_testName}{(withDynamicParameter ? NameConstants.DynamicParametr : "")}TestReturningScalar{async}()
        {{
        }}
");
                return;
            }

            stringBuilder.Append($@"
        [Test, Order({order})]
        public async Task {_testName}{(withDynamicParameter ? NameConstants.DynamicParametr : "")}TestReturningScalar{async}()
        {{
            await using (var connection = GlobalSetUp.GetConnection)
            {{
                await connection.OpenAsync();
                {model.NullableValueType} nullable = null;");

            for (; indexValue < endIndex; indexValue++)
            {
                ModelValue value = storage.Values[indexValue];
                if (withDynamicParameter)
                {
                    stringBuilder.Append($@"
                {{
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<{model.IdType}>();
                    ((NpgsqlParameter<{model.IdType}>)parameters[0]).NpgsqlDbType = {model.IdTypeInfo.SpecialDbTypeStr()};
                    ((NpgsqlParameter<{model.IdType}>)parameters[0]).TypedValue = {TestsPart.TestDataArrayName}[{indexValue}].{model.IdName};

                    parameters[1] = new NpgsqlParameter<{model.ValueType}>();
                    ((NpgsqlParameter<{model.ValueType}>)parameters[1]).NpgsqlDbType = {model.TypeInfo.SpecialDbTypeStr()};
                    ((NpgsqlParameter<{model.ValueType}>)parameters[1]).TypedValue = {TestsPart.TestDataArrayName}[{indexValue}].{model.ValueName};

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = {model.TypeInfo.SpecialDbTypeStr()};
                    if ({TestsPart.TestDataArrayName}[{indexValue}].{model.NullableValueName} != null)
                    {{
                        parameters[2].Value = {TestsPart.TestDataArrayName}[{indexValue}].{model.NullableValueName};
                    }}
                    else
                    {{
                        parameters[2].Value = System.DBNull.Value;
                    }}

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = {model.ModelInner.IdTypeInfo.SpecialDbTypeStr()};
                    if ({TestsPart.TestDataArrayName}[{indexValue}].{model.ModelInnerName} != null)
                    {{
                        parameters[3].Value = {TestsPart.TestDataArrayName}[{indexValue}].{model.ModelInnerName}.{model.ModelInner.IdName};
                    }}
                    else
                    {{
                        parameters[3].Value = System.DBNull.Value;
                    }}

                    nullable = {await} {TypeHelper.ThisAsInterface(interfaceTypeName)}.Scalar{_testName}{(withDynamicParameter ? NameConstants.DynamicParametr : "")}Returning{async}(connection, parameters);
                }}");
                }
                else
                {
                    stringBuilder.Append($@"
                nullable = {await} {TypeHelper.ThisAsInterface(interfaceTypeName)}.Scalar{_testName}{(withDynamicParameter ? NameConstants.DynamicParametr : "")}Returning{async}(connection, {TestsPart.TestDataArrayName}[{indexValue}].{model.IdName}, {TestsPart.TestDataArrayName}[{indexValue}].{model.ValueName}, {TestsPart.TestDataArrayName}[{indexValue}].{model.NullableValueName}, {TestsPart.TestDataArrayName}[{indexValue}].{model.ModelInnerName} == null ? {ValueConstants.NullValue} : {TestsPart.TestDataArrayName}[{indexValue}].{model.ModelInnerName}.{model.ModelInner.IdName});");
                }

                if(value.NullableValue == ValueConstants.NullValue)
                {
                    stringBuilder.Append($@"
                Assert.That(nullable, Is.Null);");
                }
                else
                {
                    stringBuilder.Append($@"
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo({value.NullableValue}));");
                }
            }
            stringBuilder.Append($@"
            }}
        }}
");
        }
    }
}
