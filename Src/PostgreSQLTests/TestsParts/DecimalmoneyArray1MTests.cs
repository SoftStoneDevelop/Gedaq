

using Npgsql;
using NpgsqlTypes;
using Gedaq.Common.Enums;
using Gedaq.Npgsql.Attributes;
using Gedaq.Npgsql.Enums;
using System;


using System.Linq;
using NUnit.Framework;
using System.Data.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tests
{
    internal partial interface IDecimalArraymoneyArray
    {
    }
    
    internal partial class DecimalArraymoneyArray : IDecimalArraymoneyArray
    {


#region TestData

        private readonly DecimalmoneyArray1M[] _testData = new DecimalmoneyArray1M[]
        {
            new DecimalmoneyArray1M
{
    Id = 8,
    Value = 
new System.Decimal[4]
{
0.05m,
0.87m,
0.41m,
0.01m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[4]
{
0.66m,
0.84m,
0.23m,
0.12m,
},
},
            new DecimalmoneyArray1M
{
    Id = 13,
    Value = 
new System.Decimal[4]
{
0.11m,
0.25m,
0.33m,
0.71m,
},
    ModelInner = new DecimalmoneyArray1MI
{
    Id = 9,
    Value = 
new System.Decimal[3]
{
0.49m,
0.26m,
0.80m,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalmoneyArray1M
{
    Id = 17,
    Value = 
new System.Decimal[4]
{
0.32m,
0.34m,
0.15m,
0.60m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalmoneyArray1M
{
    Id = 24,
    Value = 
new System.Decimal[3]
{
0.56m,
0.55m,
0.86m,
},
    ModelInner = new DecimalmoneyArray1MI
{
    Id = 10,
    Value = 
new System.Decimal[3]
{
0.22m,
0.19m,
0.61m,
},
    NullableValue = 
new System.Decimal[3]
{
0.22m,
0.97m,
0.48m,
},
},
    NullableValue = null,
},
            new DecimalmoneyArray1M
{
    Id = 28,
    Value = 
new System.Decimal[4]
{
0.40m,
0.40m,
0.19m,
0.26m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[4]
{
0.16m,
0.13m,
0.10m,
0.02m,
},
},
            new DecimalmoneyArray1M
{
    Id = 32,
    Value = 
new System.Decimal[3]
{
0.86m,
0.33m,
0.97m,
},
    ModelInner = new DecimalmoneyArray1MI
{
    Id = 16,
    Value = 
new System.Decimal[4]
{
0.43m,
0.21m,
0.26m,
0.69m,
},
    NullableValue = 
new System.Decimal[3]
{
0.95m,
0.09m,
0.43m,
},
},
    NullableValue = 
new System.Decimal[4]
{
0.61m,
0.79m,
0.61m,
0.49m,
},
},
            new DecimalmoneyArray1M
{
    Id = 40,
    Value = 
new System.Decimal[3]
{
0.68m,
0.75m,
0.11m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalmoneyArray1M
{
    Id = 43,
    Value = 
new System.Decimal[3]
{
0.55m,
0.55m,
0.12m,
},
    ModelInner = new DecimalmoneyArray1MI
{
    Id = 17,
    Value = 
new System.Decimal[3]
{
0.39m,
0.28m,
0.07m,
},
    NullableValue = 
new System.Decimal[4]
{
0.79m,
0.06m,
0.54m,
0.81m,
},
},
    NullableValue = 
new System.Decimal[4]
{
0.93m,
0.05m,
0.22m,
0.77m,
},
},
            new DecimalmoneyArray1M
{
    Id = 52,
    Value = 
new System.Decimal[3]
{
0.76m,
0.89m,
0.20m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[4]
{
0.13m,
0.59m,
0.59m,
0.80m,
},
},
            new DecimalmoneyArray1M
{
    Id = 53,
    Value = 
new System.Decimal[3]
{
0.92m,
0.50m,
0.56m,
},
    ModelInner = new DecimalmoneyArray1MI
{
    Id = 26,
    Value = 
new System.Decimal[4]
{
0.05m,
0.69m,
0.51m,
0.80m,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalmoneyArray1M
{
    Id = 54,
    Value = 
new System.Decimal[3]
{
0.91m,
0.47m,
0.19m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalmoneyArray1M
{
    Id = 62,
    Value = 
new System.Decimal[4]
{
0.85m,
0.69m,
0.43m,
0.57m,
},
    ModelInner = new DecimalmoneyArray1MI
{
    Id = 35,
    Value = 
new System.Decimal[4]
{
0.24m,
0.08m,
0.98m,
0.43m,
},
    NullableValue = 
new System.Decimal[3]
{
0.45m,
0.07m,
0.21m,
},
},
    NullableValue = null,
},
            new DecimalmoneyArray1M
{
    Id = 70,
    Value = 
new System.Decimal[4]
{
0.31m,
0.66m,
0.04m,
0.86m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalmoneyArray1M
{
    Id = 73,
    Value = 
new System.Decimal[3]
{
0.32m,
0.36m,
0.60m,
},
    ModelInner = new DecimalmoneyArray1MI
{
    Id = 37,
    Value = 
new System.Decimal[3]
{
0.23m,
0.66m,
0.07m,
},
    NullableValue = 
new System.Decimal[4]
{
0.38m,
0.47m,
0.06m,
0.18m,
},
},
    NullableValue = 
new System.Decimal[3]
{
0.26m,
0.25m,
0.66m,
},
},
            new DecimalmoneyArray1M
{
    Id = 77,
    Value = 
new System.Decimal[3]
{
0.95m,
0.66m,
0.92m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[3]
{
0.82m,
0.90m,
0.82m,
},
},
            new DecimalmoneyArray1M
{
    Id = 85,
    Value = 
new System.Decimal[4]
{
0.59m,
0.04m,
0.70m,
0.25m,
},
    ModelInner = new DecimalmoneyArray1MI
{
    Id = 43,
    Value = 
new System.Decimal[3]
{
0.77m,
0.34m,
0.71m,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalmoneyArray1M
{
    Id = 87,
    Value = 
new System.Decimal[3]
{
0.50m,
0.43m,
0.48m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalmoneyArray1M
{
    Id = 94,
    Value = 
new System.Decimal[4]
{
0.62m,
0.66m,
0.72m,
0.94m,
},
    ModelInner = new DecimalmoneyArray1MI
{
    Id = 49,
    Value = 
new System.Decimal[4]
{
0.07m,
0.32m,
0.60m,
0.82m,
},
    NullableValue = 
new System.Decimal[3]
{
0.45m,
0.63m,
0.58m,
},
},
    NullableValue = 
new System.Decimal[3]
{
0.93m,
0.46m,
0.65m,
},
},
            new DecimalmoneyArray1M
{
    Id = 103,
    Value = 
new System.Decimal[3]
{
0.82m,
0.26m,
0.77m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalmoneyArray1M
{
    Id = 104,
    Value = 
new System.Decimal[3]
{
0.13m,
0.75m,
0.94m,
},
    ModelInner = new DecimalmoneyArray1MI
{
    Id = 56,
    Value = 
new System.Decimal[3]
{
0.84m,
0.04m,
0.92m,
},
    NullableValue = 
new System.Decimal[4]
{
0.05m,
0.51m,
0.87m,
0.83m,
},
},
    NullableValue = 
new System.Decimal[3]
{
0.28m,
0.36m,
0.12m,
},
},
            new DecimalmoneyArray1M
{
    Id = 112,
    Value = 
new System.Decimal[3]
{
0.98m,
0.35m,
0.69m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalmoneyArray1M
{
    Id = 120,
    Value = 
new System.Decimal[4]
{
0.96m,
0.68m,
0.49m,
0.04m,
},
    ModelInner = new DecimalmoneyArray1MI
{
    Id = 60,
    Value = 
new System.Decimal[4]
{
0.55m,
0.11m,
0.49m,
0.59m,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalmoneyArray1M
{
    Id = 122,
    Value = 
new System.Decimal[3]
{
0.09m,
0.68m,
0.09m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[4]
{
0.10m,
0.40m,
0.14m,
0.15m,
},
},
            new DecimalmoneyArray1M
{
    Id = 125,
    Value = 
new System.Decimal[4]
{
0.59m,
0.01m,
0.47m,
0.92m,
},
    ModelInner = new DecimalmoneyArray1MI
{
    Id = 65,
    Value = 
new System.Decimal[4]
{
0.70m,
0.09m,
0.52m,
0.86m,
},
    NullableValue = 
new System.Decimal[4]
{
0.17m,
0.08m,
0.02m,
0.77m,
},
},
    NullableValue = 
new System.Decimal[3]
{
0.15m,
0.10m,
0.60m,
},
},
            new DecimalmoneyArray1M
{
    Id = 130,
    Value = 
new System.Decimal[4]
{
0.95m,
0.72m,
0.36m,
0.48m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[4]
{
0.37m,
0.17m,
0.92m,
0.02m,
},
},
            new DecimalmoneyArray1M
{
    Id = 134,
    Value = 
new System.Decimal[3]
{
0.95m,
0.09m,
0.73m,
},
    ModelInner = new DecimalmoneyArray1MI
{
    Id = 71,
    Value = 
new System.Decimal[3]
{
0.92m,
0.31m,
0.98m,
},
    NullableValue = null,
},
    NullableValue = 
new System.Decimal[4]
{
0.38m,
0.51m,
0.32m,
0.57m,
},
},
            new DecimalmoneyArray1M
{
    Id = 141,
    Value = 
new System.Decimal[4]
{
0.36m,
0.80m,
0.58m,
0.24m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalmoneyArray1M
{
    Id = 147,
    Value = 
new System.Decimal[4]
{
0.02m,
0.66m,
0.54m,
0.81m,
},
    ModelInner = new DecimalmoneyArray1MI
{
    Id = 76,
    Value = 
new System.Decimal[3]
{
0.49m,
0.72m,
0.88m,
},
    NullableValue = null,
},
    NullableValue = 
new System.Decimal[4]
{
0.83m,
0.73m,
0.79m,
0.70m,
},
},
            new DecimalmoneyArray1M
{
    Id = 150,
    Value = 
new System.Decimal[3]
{
0.82m,
0.35m,
0.58m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalmoneyArray1M
{
    Id = 157,
    Value = 
new System.Decimal[4]
{
0.71m,
0.86m,
0.82m,
0.28m,
},
    ModelInner = new DecimalmoneyArray1MI
{
    Id = 84,
    Value = 
new System.Decimal[4]
{
0.58m,
0.19m,
0.34m,
0.42m,
},
    NullableValue = 
new System.Decimal[3]
{
0.32m,
0.51m,
0.67m,
},
},
    NullableValue = 
new System.Decimal[3]
{
0.04m,
0.17m,
0.70m,
},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalmoneyarray1mi(
	id,
    value,
    nullablevalue
)
VALUES (
    $1, 
    $2, 
    $3
);
",
            methodName:"InsertModelInner",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraymoneyArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483636)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483636))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalmoneyarray1mi(
	id,
    value,
    nullablevalue
)
VALUES (
    $1, 
    $2, 
    $3
)
RETURNING
    id,
    value,
    nullablevalue
;
",
            methodName:"InsertModelInnerReturning",
            queryMapTypes: [typeof(DecimalmoneyArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraymoneyArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483636)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483636))]
        public void InsertModelInnerReturningConfig()
        {
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows =  ((IDecimalArraymoneyArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDecimalArraymoneyArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows = await ((IDecimalArraymoneyArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalArraymoneyArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTestReturningScalar()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32 id = default;

                id =  ((IDecimalArraymoneyArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IDecimalArraymoneyArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[11].ModelInner.Id));

            }
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32 id = default;

                id = await ((IDecimalArraymoneyArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IDecimalArraymoneyArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IDecimalArraymoneyArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IDecimalArraymoneyArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IDecimalArraymoneyArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IDecimalArraymoneyArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IDecimalArraymoneyArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IDecimalArraymoneyArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IDecimalArraymoneyArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalmoneyarray1m(
	id,
    value,
    nullablevalue,
    decimalmoneyarray1mi_id
)
VALUES (
    $1, 
    $2, 
    $3,
    $4
);
",
            methodName:"InsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraymoneyArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483636)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483636)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "decimalmoneyarray1mi_id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        public void InsertModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;
                changedRows =  ((IDecimalArraymoneyArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IDecimalArraymoneyArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;
                changedRows = await ((IDecimalArraymoneyArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IDecimalArraymoneyArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalmoneyarray1m(
	id,
    value,
    nullablevalue,
    decimalmoneyarray1mi_id
)
VALUES (
    $1, 
    $2, 
    $3,
    $4
)
RETURNING
    nullablevalue,
    value,
~StartInner::ModelInner:Id~
~Reinterpret::Id~
    decimalmoneyarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(DecimalmoneyArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraymoneyArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalar()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Decimal[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<System.Decimal[]>();
                    ((NpgsqlParameter<System.Decimal[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483636);
                    ((NpgsqlParameter<System.Decimal[]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483636);
                    if (_testData[4].NullableValue != null)
                    {
                        parameters[2].Value = _testData[4].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[4].ModelInner != null)
                    {
                        parameters[3].Value = _testData[4].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable =  ((IDecimalArraymoneyArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Decimal[4]
{
0.16m,
0.13m,
0.10m,
0.02m,
}));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<System.Decimal[]>();
                    ((NpgsqlParameter<System.Decimal[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483636);
                    ((NpgsqlParameter<System.Decimal[]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483636);
                    if (_testData[5].NullableValue != null)
                    {
                        parameters[2].Value = _testData[5].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[5].ModelInner != null)
                    {
                        parameters[3].Value = _testData[5].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable =  ((IDecimalArraymoneyArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Decimal[4]
{
0.61m,
0.79m,
0.61m,
0.49m,
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Decimal[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<System.Decimal[]>();
                    ((NpgsqlParameter<System.Decimal[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483636);
                    ((NpgsqlParameter<System.Decimal[]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483636);
                    if (_testData[6].NullableValue != null)
                    {
                        parameters[2].Value = _testData[6].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[6].ModelInner != null)
                    {
                        parameters[3].Value = _testData[6].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable = await ((IDecimalArraymoneyArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<System.Decimal[]>();
                    ((NpgsqlParameter<System.Decimal[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483636);
                    ((NpgsqlParameter<System.Decimal[]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483636);
                    if (_testData[7].NullableValue != null)
                    {
                        parameters[2].Value = _testData[7].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[7].ModelInner != null)
                    {
                        parameters[3].Value = _testData[7].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable = await ((IDecimalArraymoneyArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Decimal[4]
{
0.93m,
0.05m,
0.22m,
0.77m,
}));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalmoneyarray1m(
	id,
    value,
    nullablevalue,
    decimalmoneyarray1mi_id
)
VALUES (
    $1, 
    $2, 
    $3,
    $4
)
RETURNING
    nullablevalue,
    value,
~StartInner::ModelInner:Id~
~Reinterpret::Id~
    decimalmoneyarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(DecimalmoneyArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraymoneyArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483636)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483636)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "decimalmoneyarray1mi_id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        public void InsertModelReturningConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalar()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Decimal[] nullable = null;
                nullable =  ((IDecimalArraymoneyArray)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Decimal[4]
{
0.13m,
0.59m,
0.59m,
0.80m,
}));
                nullable =  ((IDecimalArraymoneyArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Decimal[] nullable = null;
                nullable = await ((IDecimalArraymoneyArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((IDecimalArraymoneyArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<DecimalmoneyArray1M> models = null;

                models =  ((IDecimalArraymoneyArray)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalmoneyArray1M.AssertModel(models[0],_testData[12], true);
                models =  ((IDecimalArraymoneyArray)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalmoneyArray1M.AssertModel(models[0],_testData[13], true);
                models =  ((IDecimalArraymoneyArray)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalmoneyArray1M.AssertModel(models[0],_testData[14], true);
                models =  ((IDecimalArraymoneyArray)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalmoneyArray1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<DecimalmoneyArray1M> models = null;

                models = await ((IDecimalArraymoneyArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalmoneyArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((IDecimalArraymoneyArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalmoneyArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((IDecimalArraymoneyArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalmoneyArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((IDecimalArraymoneyArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalmoneyArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((IDecimalArraymoneyArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalmoneyArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((IDecimalArraymoneyArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalmoneyArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((IDecimalArraymoneyArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalmoneyArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((IDecimalArraymoneyArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalmoneyArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((IDecimalArraymoneyArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalmoneyArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((IDecimalArraymoneyArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalmoneyArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((IDecimalArraymoneyArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalmoneyArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((IDecimalArraymoneyArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalmoneyArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((IDecimalArraymoneyArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalmoneyArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((IDecimalArraymoneyArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalmoneyArray1M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalmoneyArray1M), typeof(FlatDecimalmoneyArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraymoneyArray)),
Gedaq.Npgsql.Attributes.DynamicParametr()]
        private void MMDynQuerySelectModelDynParConfig()
        {
        }

        [Test, Order(2)]
        public async Task MMDynQuerySelectModelDynParTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.decimalmoneyarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDecimalmoneyArray1M>();
                var models2 = new List<FlatDecimalmoneyArray1M>();
                await ((IDecimalArraymoneyArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalmoneyArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalmoneyArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task MMDynQuerySelectModelDynParTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.decimalmoneyarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDecimalmoneyArray1M>();
                var models2 = new List<FlatDecimalmoneyArray1M>();
                ((IDecimalArraymoneyArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalmoneyArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalmoneyArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalmoneyArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraymoneyArray)),
Gedaq.Npgsql.Attributes.DynamicParametr()]
        private void DynQuerySelectModelDynParConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQuerySelectModelDynParTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalmoneyarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IDecimalArraymoneyArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalmoneyArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DynQuerySelectModelDynParTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalmoneyarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IDecimalArraymoneyArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalmoneyArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: 
@"
SELECT
    m.id,
    m.value,
~StartInner::ModelInner:Id~
    mi.id,
    mi.value,
    mi.nullablevalue,
~EndInner::ModelInner~
    m.nullablevalue
FROM public.decimalmoneyarray1m m
LEFT JOIN public.decimalmoneyarray1mi mi ON mi.id = m.decimalmoneyarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(DecimalmoneyArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraymoneyArray)),
Gedaq.Npgsql.Attributes.DynamicParametr()]
        private void SelectModelDynParConfig()
        {
        }

        [Test, Order(2)]
        public async Task SelectModelDynParTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IDecimalArraymoneyArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DecimalmoneyArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelDynParTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IDecimalArraymoneyArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DecimalmoneyArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalmoneyArray1M), typeof(FlatDecimalmoneyArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraymoneyArray)),
Gedaq.Npgsql.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            position: 1,
            methodParametrName: "id",
            dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        private void MMDynQuerySelectModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task MMDynQuerySelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.decimalmoneyarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalmoneyArray1M>();
                var models2 = new List<FlatDecimalmoneyArray1M>();
                await ((IDecimalArraymoneyArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalmoneyArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalmoneyArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task MMDynQuerySelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.decimalmoneyarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalmoneyArray1M>();
                var models2 = new List<FlatDecimalmoneyArray1M>();
                ((IDecimalArraymoneyArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalmoneyArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalmoneyArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalmoneyArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraymoneyArray)),
Gedaq.Npgsql.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            position: 1,
            methodParametrName: "id",
            dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        private void DynQuerySelectModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQuerySelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalmoneyarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IDecimalArraymoneyArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalmoneyArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DynQuerySelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalmoneyarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IDecimalArraymoneyArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalmoneyArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: 
@"
SELECT
    m.id,
    m.value,
~StartInner::ModelInner:Id~
    mi.id,
    mi.value,
    mi.nullablevalue,
~EndInner::ModelInner~
    m.nullablevalue
FROM public.decimalmoneyarray1m m
LEFT JOIN public.decimalmoneyarray1mi mi ON mi.id = m.decimalmoneyarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(DecimalmoneyArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraymoneyArray)),
Gedaq.Npgsql.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            position: 1,
            methodParametrName: "id",
            dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        private void SelectModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task SelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDecimalArraymoneyArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DecimalmoneyArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IDecimalArraymoneyArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DecimalmoneyArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalmoneyArray1M), typeof(FlatDecimalmoneyArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraymoneyArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.decimalmoneyarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDecimalmoneyArray1M>();
                var models2 = new List<FlatDecimalmoneyArray1M>();
                await((IDecimalArraymoneyArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalmoneyArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalmoneyArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.decimalmoneyarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDecimalmoneyArray1M>();
                var models2 = new List<FlatDecimalmoneyArray1M>();
                ((IDecimalArraymoneyArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalmoneyArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalmoneyArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalmoneyArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraymoneyArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraymoneyArray)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModelDynPar",
            position: 2)]
        private void DbConnectionDynQuerySelectModelDynParBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelDynParTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalmoneyarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IDecimalArraymoneyArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalmoneyArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 43;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 13;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalmoneyarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalmoneyarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IDecimalArraymoneyArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));
FlatDecimalmoneyArray1M.AssertModel(models[0],_testData[8], false);FlatDecimalmoneyArray1M.AssertModel(models[1],_testData[9], false);FlatDecimalmoneyArray1M.AssertModel(models[2],_testData[10], false);FlatDecimalmoneyArray1M.AssertModel(models[3],_testData[11], false);FlatDecimalmoneyArray1M.AssertModel(models[4],_testData[12], false);FlatDecimalmoneyArray1M.AssertModel(models[5],_testData[13], false);FlatDecimalmoneyArray1M.AssertModel(models[6],_testData[14], false);FlatDecimalmoneyArray1M.AssertModel(models[7],_testData[15], false);FlatDecimalmoneyArray1M.AssertModel(models[8],_testData[16], false);FlatDecimalmoneyArray1M.AssertModel(models[9],_testData[17], false);FlatDecimalmoneyArray1M.AssertModel(models[10],_testData[18], false);FlatDecimalmoneyArray1M.AssertModel(models[11],_testData[19], false);FlatDecimalmoneyArray1M.AssertModel(models[12],_testData[20], false);FlatDecimalmoneyArray1M.AssertModel(models[13],_testData[21], false);FlatDecimalmoneyArray1M.AssertModel(models[14],_testData[22], false);FlatDecimalmoneyArray1M.AssertModel(models[15],_testData[23], false);FlatDecimalmoneyArray1M.AssertModel(models[16],_testData[24], false);FlatDecimalmoneyArray1M.AssertModel(models[17],_testData[25], false);FlatDecimalmoneyArray1M.AssertModel(models[18],_testData[26], false);FlatDecimalmoneyArray1M.AssertModel(models[19],_testData[27], false);FlatDecimalmoneyArray1M.AssertModel(models[20],_testData[28], false);FlatDecimalmoneyArray1M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));
FlatDecimalmoneyArray1M.AssertModel(models[0],_testData[2], false);FlatDecimalmoneyArray1M.AssertModel(models[1],_testData[3], false);FlatDecimalmoneyArray1M.AssertModel(models[2],_testData[4], false);FlatDecimalmoneyArray1M.AssertModel(models[3],_testData[5], false);FlatDecimalmoneyArray1M.AssertModel(models[4],_testData[6], false);FlatDecimalmoneyArray1M.AssertModel(models[5],_testData[7], false);FlatDecimalmoneyArray1M.AssertModel(models[6],_testData[8], false);FlatDecimalmoneyArray1M.AssertModel(models[7],_testData[9], false);FlatDecimalmoneyArray1M.AssertModel(models[8],_testData[10], false);FlatDecimalmoneyArray1M.AssertModel(models[9],_testData[11], false);FlatDecimalmoneyArray1M.AssertModel(models[10],_testData[12], false);FlatDecimalmoneyArray1M.AssertModel(models[11],_testData[13], false);FlatDecimalmoneyArray1M.AssertModel(models[12],_testData[14], false);FlatDecimalmoneyArray1M.AssertModel(models[13],_testData[15], false);FlatDecimalmoneyArray1M.AssertModel(models[14],_testData[16], false);FlatDecimalmoneyArray1M.AssertModel(models[15],_testData[17], false);FlatDecimalmoneyArray1M.AssertModel(models[16],_testData[18], false);FlatDecimalmoneyArray1M.AssertModel(models[17],_testData[19], false);FlatDecimalmoneyArray1M.AssertModel(models[18],_testData[20], false);FlatDecimalmoneyArray1M.AssertModel(models[19],_testData[21], false);FlatDecimalmoneyArray1M.AssertModel(models[20],_testData[22], false);FlatDecimalmoneyArray1M.AssertModel(models[21],_testData[23], false);FlatDecimalmoneyArray1M.AssertModel(models[22],_testData[24], false);FlatDecimalmoneyArray1M.AssertModel(models[23],_testData[25], false);FlatDecimalmoneyArray1M.AssertModel(models[24],_testData[26], false);FlatDecimalmoneyArray1M.AssertModel(models[25],_testData[27], false);FlatDecimalmoneyArray1M.AssertModel(models[26],_testData[28], false);FlatDecimalmoneyArray1M.AssertModel(models[27],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelDynParTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalmoneyarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IDecimalArraymoneyArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalmoneyArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 17;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 112;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalmoneyarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalmoneyarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IDecimalArraymoneyArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));
FlatDecimalmoneyArray1M.AssertModel(models[0],_testData[3], false);FlatDecimalmoneyArray1M.AssertModel(models[1],_testData[4], false);FlatDecimalmoneyArray1M.AssertModel(models[2],_testData[5], false);FlatDecimalmoneyArray1M.AssertModel(models[3],_testData[6], false);FlatDecimalmoneyArray1M.AssertModel(models[4],_testData[7], false);FlatDecimalmoneyArray1M.AssertModel(models[5],_testData[8], false);FlatDecimalmoneyArray1M.AssertModel(models[6],_testData[9], false);FlatDecimalmoneyArray1M.AssertModel(models[7],_testData[10], false);FlatDecimalmoneyArray1M.AssertModel(models[8],_testData[11], false);FlatDecimalmoneyArray1M.AssertModel(models[9],_testData[12], false);FlatDecimalmoneyArray1M.AssertModel(models[10],_testData[13], false);FlatDecimalmoneyArray1M.AssertModel(models[11],_testData[14], false);FlatDecimalmoneyArray1M.AssertModel(models[12],_testData[15], false);FlatDecimalmoneyArray1M.AssertModel(models[13],_testData[16], false);FlatDecimalmoneyArray1M.AssertModel(models[14],_testData[17], false);FlatDecimalmoneyArray1M.AssertModel(models[15],_testData[18], false);FlatDecimalmoneyArray1M.AssertModel(models[16],_testData[19], false);FlatDecimalmoneyArray1M.AssertModel(models[17],_testData[20], false);FlatDecimalmoneyArray1M.AssertModel(models[18],_testData[21], false);FlatDecimalmoneyArray1M.AssertModel(models[19],_testData[22], false);FlatDecimalmoneyArray1M.AssertModel(models[20],_testData[23], false);FlatDecimalmoneyArray1M.AssertModel(models[21],_testData[24], false);FlatDecimalmoneyArray1M.AssertModel(models[22],_testData[25], false);FlatDecimalmoneyArray1M.AssertModel(models[23],_testData[26], false);FlatDecimalmoneyArray1M.AssertModel(models[24],_testData[27], false);FlatDecimalmoneyArray1M.AssertModel(models[25],_testData[28], false);FlatDecimalmoneyArray1M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));
FlatDecimalmoneyArray1M.AssertModel(models[0],_testData[21], false);FlatDecimalmoneyArray1M.AssertModel(models[1],_testData[22], false);FlatDecimalmoneyArray1M.AssertModel(models[2],_testData[23], false);FlatDecimalmoneyArray1M.AssertModel(models[3],_testData[24], false);FlatDecimalmoneyArray1M.AssertModel(models[4],_testData[25], false);FlatDecimalmoneyArray1M.AssertModel(models[5],_testData[26], false);FlatDecimalmoneyArray1M.AssertModel(models[6],_testData[27], false);FlatDecimalmoneyArray1M.AssertModel(models[7],_testData[28], false);FlatDecimalmoneyArray1M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: 

@"
SELECT
    m.id,
    m.value,
~StartInner::ModelInner:Id~
    mi.id,
    mi.value,
    mi.nullablevalue,
~EndInner::ModelInner~
    m.nullablevalue
FROM public.decimalmoneyarray1m m
LEFT JOIN public.decimalmoneyarray1mi mi ON mi.id = m.decimalmoneyarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(DecimalmoneyArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraymoneyArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraymoneyArray)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModelDynPar",
            position: 2)]
        private void DbConnectionSelectModelDynParBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelDynParTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IDecimalArraymoneyArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DecimalmoneyArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 85;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 94;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((IDecimalArraymoneyArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));
DecimalmoneyArray1M.AssertModel(models[0],_testData[16], false);DecimalmoneyArray1M.AssertModel(models[1],_testData[17], false);DecimalmoneyArray1M.AssertModel(models[2],_testData[18], false);DecimalmoneyArray1M.AssertModel(models[3],_testData[19], false);DecimalmoneyArray1M.AssertModel(models[4],_testData[20], false);DecimalmoneyArray1M.AssertModel(models[5],_testData[21], false);DecimalmoneyArray1M.AssertModel(models[6],_testData[22], false);DecimalmoneyArray1M.AssertModel(models[7],_testData[23], false);DecimalmoneyArray1M.AssertModel(models[8],_testData[24], false);DecimalmoneyArray1M.AssertModel(models[9],_testData[25], false);DecimalmoneyArray1M.AssertModel(models[10],_testData[26], false);DecimalmoneyArray1M.AssertModel(models[11],_testData[27], false);DecimalmoneyArray1M.AssertModel(models[12],_testData[28], false);DecimalmoneyArray1M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));
DecimalmoneyArray1M.AssertModel(models[0],_testData[18], false);DecimalmoneyArray1M.AssertModel(models[1],_testData[19], false);DecimalmoneyArray1M.AssertModel(models[2],_testData[20], false);DecimalmoneyArray1M.AssertModel(models[3],_testData[21], false);DecimalmoneyArray1M.AssertModel(models[4],_testData[22], false);DecimalmoneyArray1M.AssertModel(models[5],_testData[23], false);DecimalmoneyArray1M.AssertModel(models[6],_testData[24], false);DecimalmoneyArray1M.AssertModel(models[7],_testData[25], false);DecimalmoneyArray1M.AssertModel(models[8],_testData[26], false);DecimalmoneyArray1M.AssertModel(models[9],_testData[27], false);DecimalmoneyArray1M.AssertModel(models[10],_testData[28], false);DecimalmoneyArray1M.AssertModel(models[11],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelDynParTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IDecimalArraymoneyArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DecimalmoneyArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 70;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 130;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((IDecimalArraymoneyArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));
DecimalmoneyArray1M.AssertModel(models[0],_testData[13], false);DecimalmoneyArray1M.AssertModel(models[1],_testData[14], false);DecimalmoneyArray1M.AssertModel(models[2],_testData[15], false);DecimalmoneyArray1M.AssertModel(models[3],_testData[16], false);DecimalmoneyArray1M.AssertModel(models[4],_testData[17], false);DecimalmoneyArray1M.AssertModel(models[5],_testData[18], false);DecimalmoneyArray1M.AssertModel(models[6],_testData[19], false);DecimalmoneyArray1M.AssertModel(models[7],_testData[20], false);DecimalmoneyArray1M.AssertModel(models[8],_testData[21], false);DecimalmoneyArray1M.AssertModel(models[9],_testData[22], false);DecimalmoneyArray1M.AssertModel(models[10],_testData[23], false);DecimalmoneyArray1M.AssertModel(models[11],_testData[24], false);DecimalmoneyArray1M.AssertModel(models[12],_testData[25], false);DecimalmoneyArray1M.AssertModel(models[13],_testData[26], false);DecimalmoneyArray1M.AssertModel(models[14],_testData[27], false);DecimalmoneyArray1M.AssertModel(models[15],_testData[28], false);DecimalmoneyArray1M.AssertModel(models[16],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));
DecimalmoneyArray1M.AssertModel(models[0],_testData[25], false);DecimalmoneyArray1M.AssertModel(models[1],_testData[26], false);DecimalmoneyArray1M.AssertModel(models[2],_testData[27], false);DecimalmoneyArray1M.AssertModel(models[3],_testData[28], false);DecimalmoneyArray1M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalmoneyArray1M), typeof(FlatDecimalmoneyArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraymoneyArray)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)(11))]
        private void DbConnectionMMDynQuerySelectModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.decimalmoneyarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalmoneyArray1M>();
                var models2 = new List<FlatDecimalmoneyArray1M>();
                await((IDecimalArraymoneyArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalmoneyArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalmoneyArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.decimalmoneyarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalmoneyArray1M>();
                var models2 = new List<FlatDecimalmoneyArray1M>();
                ((IDecimalArraymoneyArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalmoneyArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalmoneyArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalmoneyArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraymoneyArray)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)(11))]
        private void DbConnectionDynQuerySelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraymoneyArray)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModel",
            position: 2)]
        private void DbConnectionDynQuerySelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalmoneyarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IDecimalArraymoneyArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalmoneyArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalmoneyarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalmoneyarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IDecimalArraymoneyArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 53, query1, 28, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));
FlatDecimalmoneyArray1M.AssertModel(models[0],_testData[10], false);FlatDecimalmoneyArray1M.AssertModel(models[1],_testData[11], false);FlatDecimalmoneyArray1M.AssertModel(models[2],_testData[12], false);FlatDecimalmoneyArray1M.AssertModel(models[3],_testData[13], false);FlatDecimalmoneyArray1M.AssertModel(models[4],_testData[14], false);FlatDecimalmoneyArray1M.AssertModel(models[5],_testData[15], false);FlatDecimalmoneyArray1M.AssertModel(models[6],_testData[16], false);FlatDecimalmoneyArray1M.AssertModel(models[7],_testData[17], false);FlatDecimalmoneyArray1M.AssertModel(models[8],_testData[18], false);FlatDecimalmoneyArray1M.AssertModel(models[9],_testData[19], false);FlatDecimalmoneyArray1M.AssertModel(models[10],_testData[20], false);FlatDecimalmoneyArray1M.AssertModel(models[11],_testData[21], false);FlatDecimalmoneyArray1M.AssertModel(models[12],_testData[22], false);FlatDecimalmoneyArray1M.AssertModel(models[13],_testData[23], false);FlatDecimalmoneyArray1M.AssertModel(models[14],_testData[24], false);FlatDecimalmoneyArray1M.AssertModel(models[15],_testData[25], false);FlatDecimalmoneyArray1M.AssertModel(models[16],_testData[26], false);FlatDecimalmoneyArray1M.AssertModel(models[17],_testData[27], false);FlatDecimalmoneyArray1M.AssertModel(models[18],_testData[28], false);FlatDecimalmoneyArray1M.AssertModel(models[19],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));
FlatDecimalmoneyArray1M.AssertModel(models[0],_testData[5], false);FlatDecimalmoneyArray1M.AssertModel(models[1],_testData[6], false);FlatDecimalmoneyArray1M.AssertModel(models[2],_testData[7], false);FlatDecimalmoneyArray1M.AssertModel(models[3],_testData[8], false);FlatDecimalmoneyArray1M.AssertModel(models[4],_testData[9], false);FlatDecimalmoneyArray1M.AssertModel(models[5],_testData[10], false);FlatDecimalmoneyArray1M.AssertModel(models[6],_testData[11], false);FlatDecimalmoneyArray1M.AssertModel(models[7],_testData[12], false);FlatDecimalmoneyArray1M.AssertModel(models[8],_testData[13], false);FlatDecimalmoneyArray1M.AssertModel(models[9],_testData[14], false);FlatDecimalmoneyArray1M.AssertModel(models[10],_testData[15], false);FlatDecimalmoneyArray1M.AssertModel(models[11],_testData[16], false);FlatDecimalmoneyArray1M.AssertModel(models[12],_testData[17], false);FlatDecimalmoneyArray1M.AssertModel(models[13],_testData[18], false);FlatDecimalmoneyArray1M.AssertModel(models[14],_testData[19], false);FlatDecimalmoneyArray1M.AssertModel(models[15],_testData[20], false);FlatDecimalmoneyArray1M.AssertModel(models[16],_testData[21], false);FlatDecimalmoneyArray1M.AssertModel(models[17],_testData[22], false);FlatDecimalmoneyArray1M.AssertModel(models[18],_testData[23], false);FlatDecimalmoneyArray1M.AssertModel(models[19],_testData[24], false);FlatDecimalmoneyArray1M.AssertModel(models[20],_testData[25], false);FlatDecimalmoneyArray1M.AssertModel(models[21],_testData[26], false);FlatDecimalmoneyArray1M.AssertModel(models[22],_testData[27], false);FlatDecimalmoneyArray1M.AssertModel(models[23],_testData[28], false);FlatDecimalmoneyArray1M.AssertModel(models[24],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalmoneyarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IDecimalArraymoneyArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalmoneyArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalmoneyarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalmoneyarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IDecimalArraymoneyArray)this).DbConnectionDynQuerySelectModelBatch(connection, 62, query1, 70, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));
FlatDecimalmoneyArray1M.AssertModel(models[0],_testData[12], false);FlatDecimalmoneyArray1M.AssertModel(models[1],_testData[13], false);FlatDecimalmoneyArray1M.AssertModel(models[2],_testData[14], false);FlatDecimalmoneyArray1M.AssertModel(models[3],_testData[15], false);FlatDecimalmoneyArray1M.AssertModel(models[4],_testData[16], false);FlatDecimalmoneyArray1M.AssertModel(models[5],_testData[17], false);FlatDecimalmoneyArray1M.AssertModel(models[6],_testData[18], false);FlatDecimalmoneyArray1M.AssertModel(models[7],_testData[19], false);FlatDecimalmoneyArray1M.AssertModel(models[8],_testData[20], false);FlatDecimalmoneyArray1M.AssertModel(models[9],_testData[21], false);FlatDecimalmoneyArray1M.AssertModel(models[10],_testData[22], false);FlatDecimalmoneyArray1M.AssertModel(models[11],_testData[23], false);FlatDecimalmoneyArray1M.AssertModel(models[12],_testData[24], false);FlatDecimalmoneyArray1M.AssertModel(models[13],_testData[25], false);FlatDecimalmoneyArray1M.AssertModel(models[14],_testData[26], false);FlatDecimalmoneyArray1M.AssertModel(models[15],_testData[27], false);FlatDecimalmoneyArray1M.AssertModel(models[16],_testData[28], false);FlatDecimalmoneyArray1M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));
FlatDecimalmoneyArray1M.AssertModel(models[0],_testData[13], false);FlatDecimalmoneyArray1M.AssertModel(models[1],_testData[14], false);FlatDecimalmoneyArray1M.AssertModel(models[2],_testData[15], false);FlatDecimalmoneyArray1M.AssertModel(models[3],_testData[16], false);FlatDecimalmoneyArray1M.AssertModel(models[4],_testData[17], false);FlatDecimalmoneyArray1M.AssertModel(models[5],_testData[18], false);FlatDecimalmoneyArray1M.AssertModel(models[6],_testData[19], false);FlatDecimalmoneyArray1M.AssertModel(models[7],_testData[20], false);FlatDecimalmoneyArray1M.AssertModel(models[8],_testData[21], false);FlatDecimalmoneyArray1M.AssertModel(models[9],_testData[22], false);FlatDecimalmoneyArray1M.AssertModel(models[10],_testData[23], false);FlatDecimalmoneyArray1M.AssertModel(models[11],_testData[24], false);FlatDecimalmoneyArray1M.AssertModel(models[12],_testData[25], false);FlatDecimalmoneyArray1M.AssertModel(models[13],_testData[26], false);FlatDecimalmoneyArray1M.AssertModel(models[14],_testData[27], false);FlatDecimalmoneyArray1M.AssertModel(models[15],_testData[28], false);FlatDecimalmoneyArray1M.AssertModel(models[16],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: 

@"
SELECT
    m.id,
    m.value,
~StartInner::ModelInner:Id~
    mi.id,
    mi.value,
    mi.nullablevalue,
~EndInner::ModelInner~
    m.nullablevalue
FROM public.decimalmoneyarray1m m
LEFT JOIN public.decimalmoneyarray1mi mi ON mi.id = m.decimalmoneyarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(DecimalmoneyArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraymoneyArray)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)(11))]
        private void DbConnectionSelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraymoneyArray)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModel",
            position: 2)]
        private void DbConnectionSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await((IDecimalArraymoneyArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DecimalmoneyArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalArraymoneyArray)this).DbConnectionSelectModelBatchAsync(connection, 73, 73))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));
DecimalmoneyArray1M.AssertModel(models[0],_testData[14], false);DecimalmoneyArray1M.AssertModel(models[1],_testData[15], false);DecimalmoneyArray1M.AssertModel(models[2],_testData[16], false);DecimalmoneyArray1M.AssertModel(models[3],_testData[17], false);DecimalmoneyArray1M.AssertModel(models[4],_testData[18], false);DecimalmoneyArray1M.AssertModel(models[5],_testData[19], false);DecimalmoneyArray1M.AssertModel(models[6],_testData[20], false);DecimalmoneyArray1M.AssertModel(models[7],_testData[21], false);DecimalmoneyArray1M.AssertModel(models[8],_testData[22], false);DecimalmoneyArray1M.AssertModel(models[9],_testData[23], false);DecimalmoneyArray1M.AssertModel(models[10],_testData[24], false);DecimalmoneyArray1M.AssertModel(models[11],_testData[25], false);DecimalmoneyArray1M.AssertModel(models[12],_testData[26], false);DecimalmoneyArray1M.AssertModel(models[13],_testData[27], false);DecimalmoneyArray1M.AssertModel(models[14],_testData[28], false);DecimalmoneyArray1M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));
DecimalmoneyArray1M.AssertModel(models[0],_testData[14], false);DecimalmoneyArray1M.AssertModel(models[1],_testData[15], false);DecimalmoneyArray1M.AssertModel(models[2],_testData[16], false);DecimalmoneyArray1M.AssertModel(models[3],_testData[17], false);DecimalmoneyArray1M.AssertModel(models[4],_testData[18], false);DecimalmoneyArray1M.AssertModel(models[5],_testData[19], false);DecimalmoneyArray1M.AssertModel(models[6],_testData[20], false);DecimalmoneyArray1M.AssertModel(models[7],_testData[21], false);DecimalmoneyArray1M.AssertModel(models[8],_testData[22], false);DecimalmoneyArray1M.AssertModel(models[9],_testData[23], false);DecimalmoneyArray1M.AssertModel(models[10],_testData[24], false);DecimalmoneyArray1M.AssertModel(models[11],_testData[25], false);DecimalmoneyArray1M.AssertModel(models[12],_testData[26], false);DecimalmoneyArray1M.AssertModel(models[13],_testData[27], false);DecimalmoneyArray1M.AssertModel(models[14],_testData[28], false);DecimalmoneyArray1M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = ((IDecimalArraymoneyArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DecimalmoneyArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalArraymoneyArray)this).DbConnectionSelectModelBatch(connection, 122, 62))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));
DecimalmoneyArray1M.AssertModel(models[0],_testData[23], false);DecimalmoneyArray1M.AssertModel(models[1],_testData[24], false);DecimalmoneyArray1M.AssertModel(models[2],_testData[25], false);DecimalmoneyArray1M.AssertModel(models[3],_testData[26], false);DecimalmoneyArray1M.AssertModel(models[4],_testData[27], false);DecimalmoneyArray1M.AssertModel(models[5],_testData[28], false);DecimalmoneyArray1M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));
DecimalmoneyArray1M.AssertModel(models[0],_testData[12], false);DecimalmoneyArray1M.AssertModel(models[1],_testData[13], false);DecimalmoneyArray1M.AssertModel(models[2],_testData[14], false);DecimalmoneyArray1M.AssertModel(models[3],_testData[15], false);DecimalmoneyArray1M.AssertModel(models[4],_testData[16], false);DecimalmoneyArray1M.AssertModel(models[5],_testData[17], false);DecimalmoneyArray1M.AssertModel(models[6],_testData[18], false);DecimalmoneyArray1M.AssertModel(models[7],_testData[19], false);DecimalmoneyArray1M.AssertModel(models[8],_testData[20], false);DecimalmoneyArray1M.AssertModel(models[9],_testData[21], false);DecimalmoneyArray1M.AssertModel(models[10],_testData[22], false);DecimalmoneyArray1M.AssertModel(models[11],_testData[23], false);DecimalmoneyArray1M.AssertModel(models[12],_testData[24], false);DecimalmoneyArray1M.AssertModel(models[13],_testData[25], false);DecimalmoneyArray1M.AssertModel(models[14],_testData[26], false);DecimalmoneyArray1M.AssertModel(models[15],_testData[27], false);DecimalmoneyArray1M.AssertModel(models[16],_testData[28], false);DecimalmoneyArray1M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                await using var cmd = await ((IDecimalArraymoneyArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IDecimalArraymoneyArray)this).SetDbConnectionSelectModelParametrs(cmd, 103);
                var models = await ((IDecimalArraymoneyArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(11));
DecimalmoneyArray1M.AssertModel(models[0],_testData[19], false);DecimalmoneyArray1M.AssertModel(models[1],_testData[20], false);DecimalmoneyArray1M.AssertModel(models[2],_testData[21], false);DecimalmoneyArray1M.AssertModel(models[3],_testData[22], false);DecimalmoneyArray1M.AssertModel(models[4],_testData[23], false);DecimalmoneyArray1M.AssertModel(models[5],_testData[24], false);DecimalmoneyArray1M.AssertModel(models[6],_testData[25], false);DecimalmoneyArray1M.AssertModel(models[7],_testData[26], false);DecimalmoneyArray1M.AssertModel(models[8],_testData[27], false);DecimalmoneyArray1M.AssertModel(models[9],_testData[28], false);DecimalmoneyArray1M.AssertModel(models[10],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDecimalArraymoneyArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDecimalArraymoneyArray)this).SetDbConnectionSelectModelParametrs(cmd, 70);
                var models =  ((IDecimalArraymoneyArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(17));
DecimalmoneyArray1M.AssertModel(models[0],_testData[13], false);DecimalmoneyArray1M.AssertModel(models[1],_testData[14], false);DecimalmoneyArray1M.AssertModel(models[2],_testData[15], false);DecimalmoneyArray1M.AssertModel(models[3],_testData[16], false);DecimalmoneyArray1M.AssertModel(models[4],_testData[17], false);DecimalmoneyArray1M.AssertModel(models[5],_testData[18], false);DecimalmoneyArray1M.AssertModel(models[6],_testData[19], false);DecimalmoneyArray1M.AssertModel(models[7],_testData[20], false);DecimalmoneyArray1M.AssertModel(models[8],_testData[21], false);DecimalmoneyArray1M.AssertModel(models[9],_testData[22], false);DecimalmoneyArray1M.AssertModel(models[10],_testData[23], false);DecimalmoneyArray1M.AssertModel(models[11],_testData[24], false);DecimalmoneyArray1M.AssertModel(models[12],_testData[25], false);DecimalmoneyArray1M.AssertModel(models[13],_testData[26], false);DecimalmoneyArray1M.AssertModel(models[14],_testData[27], false);DecimalmoneyArray1M.AssertModel(models[15],_testData[28], false);DecimalmoneyArray1M.AssertModel(models[16],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_decimalmoneyarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(DecimalmoneyArray1MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483636),
                (NpgsqlTypes.NpgsqlDbType)(-2147483636)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraymoneyArray))]
        private void ImportModelInnerConfig()
        {
        }

[Gedaq.DbConnection.Attributes.Query(
            query: 
@"
SELECT
    mi.nullablevalue,
    mi.id,
    mi.value
FROM public.binary_decimalmoneyarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(DecimalmoneyArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraymoneyArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<DecimalmoneyArray1MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((IDecimalArraymoneyArray)this).ImportModelInner(connection, importCollection);
                var models = ((IDecimalArraymoneyArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalmoneyArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
                importCollection.Clear();

                importCollection.Add(_testData[15].ModelInner);
                importCollection.Add(_testData[17].ModelInner);
                importCollection.Add(_testData[19].ModelInner);
                importCollection.Add(_testData[21].ModelInner);
                importCollection.Add(_testData[23].ModelInner);
                importCollection.Add(_testData[25].ModelInner);
                importCollection.Add(_testData[27].ModelInner);
                importCollection.Add(_testData[29].ModelInner);
                await ((IDecimalArraymoneyArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((IDecimalArraymoneyArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalmoneyArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_decimalmoneyarray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
decimalmoneyarray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapTypes: [typeof(DecimalmoneyArray1M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483636),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483636)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraymoneyArray))]
        private void ImportModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.Query(
            query: 
@"
SELECT
    m.id,
    m.value,
~StartInner::ModelInner:Id~
    mi.id,
    mi.value,
    mi.nullablevalue,
~EndInner::ModelInner~
    m.nullablevalue
FROM public.binary_decimalmoneyarray1m m
LEFT JOIN public.binary_decimalmoneyarray1mi mi ON mi.id = m.decimalmoneyarray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(DecimalmoneyArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraymoneyArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<DecimalmoneyArray1M>(15);

                    importCollection.Add(_testData[0]);
                    importCollection.Add(_testData[1]);
                    importCollection.Add(_testData[2]);
                    importCollection.Add(_testData[3]);
                    importCollection.Add(_testData[4]);
                    importCollection.Add(_testData[5]);
                    importCollection.Add(_testData[6]);
                    importCollection.Add(_testData[7]);
                    importCollection.Add(_testData[8]);
                    importCollection.Add(_testData[9]);
                    importCollection.Add(_testData[10]);
                    importCollection.Add(_testData[11]);
                    importCollection.Add(_testData[12]);
                    importCollection.Add(_testData[13]);
                    importCollection.Add(_testData[14]);
                ((IDecimalArraymoneyArray)this).ImportModel(connection, importCollection);
                var models = ((IDecimalArraymoneyArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                DecimalmoneyArray1M.AssertModel(models[0],_testData[0], false);
                DecimalmoneyArray1M.AssertModel(models[1],_testData[1], false);
                DecimalmoneyArray1M.AssertModel(models[2],_testData[2], false);
                DecimalmoneyArray1M.AssertModel(models[3],_testData[3], false);
                DecimalmoneyArray1M.AssertModel(models[4],_testData[4], false);
                DecimalmoneyArray1M.AssertModel(models[5],_testData[5], false);
                DecimalmoneyArray1M.AssertModel(models[6],_testData[6], false);
                DecimalmoneyArray1M.AssertModel(models[7],_testData[7], false);
                DecimalmoneyArray1M.AssertModel(models[8],_testData[8], false);
                DecimalmoneyArray1M.AssertModel(models[9],_testData[9], false);
                DecimalmoneyArray1M.AssertModel(models[10],_testData[10], false);
                DecimalmoneyArray1M.AssertModel(models[11],_testData[11], false);
                DecimalmoneyArray1M.AssertModel(models[12],_testData[12], false);
                DecimalmoneyArray1M.AssertModel(models[13],_testData[13], false);
                DecimalmoneyArray1M.AssertModel(models[14],_testData[14], false);
                importCollection.Clear();

                    importCollection.Add(_testData[15]);
                    importCollection.Add(_testData[16]);
                    importCollection.Add(_testData[17]);
                    importCollection.Add(_testData[18]);
                    importCollection.Add(_testData[19]);
                    importCollection.Add(_testData[20]);
                    importCollection.Add(_testData[21]);
                    importCollection.Add(_testData[22]);
                    importCollection.Add(_testData[23]);
                    importCollection.Add(_testData[24]);
                    importCollection.Add(_testData[25]);
                    importCollection.Add(_testData[26]);
                    importCollection.Add(_testData[27]);
                    importCollection.Add(_testData[28]);
                    importCollection.Add(_testData[29]);
                await ((IDecimalArraymoneyArray)this).ImportModelAsync(connection, importCollection);
                models = await ((IDecimalArraymoneyArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                DecimalmoneyArray1M.AssertModel(models[0],_testData[0], false);
                DecimalmoneyArray1M.AssertModel(models[1],_testData[1], false);
                DecimalmoneyArray1M.AssertModel(models[2],_testData[2], false);
                DecimalmoneyArray1M.AssertModel(models[3],_testData[3], false);
                DecimalmoneyArray1M.AssertModel(models[4],_testData[4], false);
                DecimalmoneyArray1M.AssertModel(models[5],_testData[5], false);
                DecimalmoneyArray1M.AssertModel(models[6],_testData[6], false);
                DecimalmoneyArray1M.AssertModel(models[7],_testData[7], false);
                DecimalmoneyArray1M.AssertModel(models[8],_testData[8], false);
                DecimalmoneyArray1M.AssertModel(models[9],_testData[9], false);
                DecimalmoneyArray1M.AssertModel(models[10],_testData[10], false);
                DecimalmoneyArray1M.AssertModel(models[11],_testData[11], false);
                DecimalmoneyArray1M.AssertModel(models[12],_testData[12], false);
                DecimalmoneyArray1M.AssertModel(models[13],_testData[13], false);
                DecimalmoneyArray1M.AssertModel(models[14],_testData[14], false);
                DecimalmoneyArray1M.AssertModel(models[15],_testData[15], false);
                DecimalmoneyArray1M.AssertModel(models[16],_testData[16], false);
                DecimalmoneyArray1M.AssertModel(models[17],_testData[17], false);
                DecimalmoneyArray1M.AssertModel(models[18],_testData[18], false);
                DecimalmoneyArray1M.AssertModel(models[19],_testData[19], false);
                DecimalmoneyArray1M.AssertModel(models[20],_testData[20], false);
                DecimalmoneyArray1M.AssertModel(models[21],_testData[21], false);
                DecimalmoneyArray1M.AssertModel(models[22],_testData[22], false);
                DecimalmoneyArray1M.AssertModel(models[23],_testData[23], false);
                DecimalmoneyArray1M.AssertModel(models[24],_testData[24], false);
                DecimalmoneyArray1M.AssertModel(models[25],_testData[25], false);
                DecimalmoneyArray1M.AssertModel(models[26],_testData[26], false);
                DecimalmoneyArray1M.AssertModel(models[27],_testData[27], false);
                DecimalmoneyArray1M.AssertModel(models[28],_testData[28], false);
                DecimalmoneyArray1M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_decimalmoneyarray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    decimalmoneyarray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(DecimalmoneyArray1M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483636),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483636)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraymoneyArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IDecimalArraymoneyArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    DecimalmoneyArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDecimalArraymoneyArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    DecimalmoneyArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_decimalmoneyarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(DecimalmoneyArray1MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483636),
                (NpgsqlTypes.NpgsqlDbType)(-2147483636)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraymoneyArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IDecimalArraymoneyArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalmoneyArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDecimalArraymoneyArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalmoneyArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

