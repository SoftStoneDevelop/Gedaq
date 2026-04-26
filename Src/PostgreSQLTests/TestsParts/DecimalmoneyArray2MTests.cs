

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
    internal partial interface IDecimalListmoneyArray
    {
    }
    
    internal partial class DecimalListmoneyArray : IDecimalListmoneyArray
    {


#region TestData

        private readonly DecimalmoneyArray2M[] _testData = new DecimalmoneyArray2M[]
        {
            new DecimalmoneyArray2M
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.47m,

0.45m,

0.79m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.63m,

0.03m,

0.41m,

0.31m,

},
},
            new DecimalmoneyArray2M
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.23m,

0.12m,

0.57m,

},
    ModelInner = new DecimalmoneyArray2MI
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.66m,

0.88m,

0.40m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.88m,

0.06m,

0.86m,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.18m,

0.21m,

0.34m,

},
},
            new DecimalmoneyArray2M
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.76m,

0.63m,

0.09m,

0.09m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.67m,

0.22m,

0.92m,

0.22m,

},
},
            new DecimalmoneyArray2M
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.23m,

0.27m,

0.78m,

1.00m,

},
    ModelInner = new DecimalmoneyArray2MI
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.46m,

0.03m,

0.29m,

0.07m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.30m,

0.08m,

0.44m,

0.52m,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.65m,

0.57m,

0.64m,

},
},
            new DecimalmoneyArray2M
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.44m,

0.88m,

0.11m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalmoneyArray2M
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.79m,

0.22m,

0.90m,

0.37m,

},
    ModelInner = new DecimalmoneyArray2MI
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.74m,

0.98m,

0.55m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.16m,

0.91m,

0.69m,

0.92m,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.27m,

0.72m,

0.59m,

0.08m,

},
},
            new DecimalmoneyArray2M
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.54m,

0.83m,

0.30m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalmoneyArray2M
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.31m,

0.44m,

0.11m,

},
    ModelInner = new DecimalmoneyArray2MI
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.87m,

0.92m,

0.45m,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalmoneyArray2M
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.48m,

0.93m,

0.42m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalmoneyArray2M
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.89m,

0.00m,

0.87m,

},
    ModelInner = new DecimalmoneyArray2MI
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.51m,

0.77m,

0.84m,

0.91m,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.91m,

0.12m,

0.59m,

0.63m,

},
},
            new DecimalmoneyArray2M
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.46m,

0.51m,

0.60m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.45m,

0.06m,

0.32m,

0.65m,

},
},
            new DecimalmoneyArray2M
{
    Id = 73,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.11m,

0.11m,

0.42m,

},
    ModelInner = new DecimalmoneyArray2MI
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.65m,

0.15m,

0.91m,

0.48m,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.82m,

0.60m,

0.17m,

},
},
            new DecimalmoneyArray2M
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.88m,

0.69m,

0.95m,

0.39m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalmoneyArray2M
{
    Id = 83,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.59m,

0.43m,

0.62m,

0.49m,

},
    ModelInner = new DecimalmoneyArray2MI
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.50m,

0.78m,

0.33m,

0.68m,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalmoneyArray2M
{
    Id = 85,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.59m,

0.34m,

0.53m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalmoneyArray2M
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.22m,

0.07m,

0.65m,

},
    ModelInner = new DecimalmoneyArray2MI
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.98m,

0.18m,

0.62m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.97m,

0.47m,

0.25m,

0.87m,

},
},
    NullableValue = null,
},
            new DecimalmoneyArray2M
{
    Id = 95,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.59m,

0.31m,

0.24m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.49m,

0.18m,

0.73m,

0.92m,

},
},
            new DecimalmoneyArray2M
{
    Id = 96,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.61m,

0.21m,

0.54m,

},
    ModelInner = new DecimalmoneyArray2MI
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.95m,

0.60m,

0.22m,

0.27m,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.78m,

0.65m,

0.55m,

},
},
            new DecimalmoneyArray2M
{
    Id = 100,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.05m,

0.85m,

0.26m,

0.85m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalmoneyArray2M
{
    Id = 104,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.19m,

0.74m,

0.21m,

},
    ModelInner = new DecimalmoneyArray2MI
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.44m,

0.86m,

0.06m,

0.97m,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalmoneyArray2M
{
    Id = 112,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.51m,

0.50m,

0.71m,

0.87m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.40m,

0.48m,

0.01m,

},
},
            new DecimalmoneyArray2M
{
    Id = 114,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.51m,

0.10m,

0.58m,

},
    ModelInner = new DecimalmoneyArray2MI
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.26m,

0.37m,

0.00m,

0.73m,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalmoneyArray2M
{
    Id = 123,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.04m,

0.65m,

0.53m,

0.03m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.99m,

0.32m,

0.39m,

},
},
            new DecimalmoneyArray2M
{
    Id = 130,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.34m,

0.67m,

0.56m,

0.04m,

},
    ModelInner = new DecimalmoneyArray2MI
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.52m,

0.05m,

0.80m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.74m,

0.99m,

0.76m,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.11m,

1.00m,

0.41m,

0.18m,

},
},
            new DecimalmoneyArray2M
{
    Id = 137,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.20m,

0.35m,

0.84m,

0.92m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalmoneyArray2M
{
    Id = 139,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.91m,

0.19m,

0.29m,

0.45m,

},
    ModelInner = new DecimalmoneyArray2MI
{
    Id = 79,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.74m,

0.48m,

0.96m,

0.55m,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalmoneyArray2M
{
    Id = 144,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.28m,

0.81m,

0.53m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalmoneyArray2M
{
    Id = 153,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.53m,

0.53m,

0.57m,

0.59m,

},
    ModelInner = new DecimalmoneyArray2MI
{
    Id = 86,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.32m,

0.44m,

0.01m,

0.98m,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.44m,

0.93m,

0.77m,

},
},
            new DecimalmoneyArray2M
{
    Id = 158,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.34m,

0.53m,

0.59m,

0.62m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.71m,

0.85m,

0.16m,

},
},
            new DecimalmoneyArray2M
{
    Id = 162,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.10m,

0.76m,

0.02m,

0.66m,

},
    ModelInner = new DecimalmoneyArray2MI
{
    Id = 94,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.57m,

0.52m,

0.26m,

},
    NullableValue = null,
},
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalmoneyarray2mi(
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
            asPartInterface: typeof(IDecimalListmoneyArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Decimal>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483636)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Decimal>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483636))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalmoneyarray2mi(
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
            queryMapTypes: [typeof(DecimalmoneyArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListmoneyArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Decimal>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483636)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Decimal>), 
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

                changedRows =  ((IDecimalListmoneyArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDecimalListmoneyArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IDecimalListmoneyArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalListmoneyArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IDecimalListmoneyArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IDecimalListmoneyArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IDecimalListmoneyArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IDecimalListmoneyArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IDecimalListmoneyArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IDecimalListmoneyArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IDecimalListmoneyArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IDecimalListmoneyArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IDecimalListmoneyArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IDecimalListmoneyArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IDecimalListmoneyArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalmoneyarray2m(
	id,
    value,
    nullablevalue,
    decimalmoneyarray2mi_id
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
            asPartInterface: typeof(IDecimalListmoneyArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Decimal>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483636)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Decimal>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483636)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "decimalmoneyarray2mi_id", 
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
                changedRows =  ((IDecimalListmoneyArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IDecimalListmoneyArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IDecimalListmoneyArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IDecimalListmoneyArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalmoneyarray2m(
	id,
    value,
    nullablevalue,
    decimalmoneyarray2mi_id
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
    decimalmoneyarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(DecimalmoneyArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListmoneyArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalmoneyarray2m(
	id,
    value,
    nullablevalue,
    decimalmoneyarray2mi_id
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
    decimalmoneyarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(DecimalmoneyArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListmoneyArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Decimal>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483636)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Decimal>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483636)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "decimalmoneyarray2mi_id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        public void InsertModelReturningConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<DecimalmoneyArray2M> models = null;

                models =  ((IDecimalListmoneyArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalmoneyArray2M.AssertModel(models[0],_testData[4], true);
                models =  ((IDecimalListmoneyArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalmoneyArray2M.AssertModel(models[0],_testData[5], true);
                models =  ((IDecimalListmoneyArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalmoneyArray2M.AssertModel(models[0],_testData[6], true);
                models =  ((IDecimalListmoneyArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalmoneyArray2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<DecimalmoneyArray2M> models = null;

                models = await ((IDecimalListmoneyArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalmoneyArray2M.AssertModel(models[0],_testData[8], true);
                models = await ((IDecimalListmoneyArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalmoneyArray2M.AssertModel(models[0],_testData[9], true);
                models = await ((IDecimalListmoneyArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalmoneyArray2M.AssertModel(models[0],_testData[10], true);
                models = await ((IDecimalListmoneyArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalmoneyArray2M.AssertModel(models[0],_testData[11], true);
                models = await ((IDecimalListmoneyArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalmoneyArray2M.AssertModel(models[0],_testData[12], true);
                models = await ((IDecimalListmoneyArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalmoneyArray2M.AssertModel(models[0],_testData[13], true);
                models = await ((IDecimalListmoneyArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalmoneyArray2M.AssertModel(models[0],_testData[14], true);
                models = await ((IDecimalListmoneyArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalmoneyArray2M.AssertModel(models[0],_testData[15], true);
                models = await ((IDecimalListmoneyArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalmoneyArray2M.AssertModel(models[0],_testData[16], true);
                models = await ((IDecimalListmoneyArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalmoneyArray2M.AssertModel(models[0],_testData[17], true);
                models = await ((IDecimalListmoneyArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalmoneyArray2M.AssertModel(models[0],_testData[18], true);
                models = await ((IDecimalListmoneyArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalmoneyArray2M.AssertModel(models[0],_testData[19], true);
                models = await ((IDecimalListmoneyArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalmoneyArray2M.AssertModel(models[0],_testData[20], true);
                models = await ((IDecimalListmoneyArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalmoneyArray2M.AssertModel(models[0],_testData[21], true);
                models = await ((IDecimalListmoneyArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalmoneyArray2M.AssertModel(models[0],_testData[22], true);
                models = await ((IDecimalListmoneyArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalmoneyArray2M.AssertModel(models[0],_testData[23], true);
                models = await ((IDecimalListmoneyArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalmoneyArray2M.AssertModel(models[0],_testData[24], true);
                models = await ((IDecimalListmoneyArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalmoneyArray2M.AssertModel(models[0],_testData[25], true);
                models = await ((IDecimalListmoneyArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalmoneyArray2M.AssertModel(models[0],_testData[26], true);
                models = await ((IDecimalListmoneyArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalmoneyArray2M.AssertModel(models[0],_testData[27], true);
                models = await ((IDecimalListmoneyArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalmoneyArray2M.AssertModel(models[0],_testData[28], true);
                models = await ((IDecimalListmoneyArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalmoneyArray2M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalmoneyArray2M), typeof(FlatDecimalmoneyArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListmoneyArray)),
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
FROM public.decimalmoneyarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDecimalmoneyArray2M>();
                var models2 = new List<FlatDecimalmoneyArray2M>();
                await ((IDecimalListmoneyArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalmoneyArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalmoneyArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.decimalmoneyarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDecimalmoneyArray2M>();
                var models2 = new List<FlatDecimalmoneyArray2M>();
                ((IDecimalListmoneyArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalmoneyArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalmoneyArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalmoneyArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListmoneyArray)),
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
FROM public.decimalmoneyarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IDecimalListmoneyArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalmoneyArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalmoneyarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IDecimalListmoneyArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalmoneyArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalmoneyarray2m m
LEFT JOIN public.decimalmoneyarray2mi mi ON mi.id = m.decimalmoneyarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(DecimalmoneyArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListmoneyArray)),
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
                var models = await ((IDecimalListmoneyArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DecimalmoneyArray2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IDecimalListmoneyArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DecimalmoneyArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalmoneyArray2M), typeof(FlatDecimalmoneyArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListmoneyArray)),
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
FROM public.decimalmoneyarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalmoneyArray2M>();
                var models2 = new List<FlatDecimalmoneyArray2M>();
                await ((IDecimalListmoneyArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalmoneyArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalmoneyArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.decimalmoneyarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalmoneyArray2M>();
                var models2 = new List<FlatDecimalmoneyArray2M>();
                ((IDecimalListmoneyArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalmoneyArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalmoneyArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalmoneyArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListmoneyArray)),
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
FROM public.decimalmoneyarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IDecimalListmoneyArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalmoneyArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalmoneyarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IDecimalListmoneyArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalmoneyArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalmoneyarray2m m
LEFT JOIN public.decimalmoneyarray2mi mi ON mi.id = m.decimalmoneyarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(DecimalmoneyArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListmoneyArray)),
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
                var models = await ((IDecimalListmoneyArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DecimalmoneyArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IDecimalListmoneyArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DecimalmoneyArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalmoneyArray2M), typeof(FlatDecimalmoneyArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListmoneyArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListmoneyArray)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModelDynPar",
            position: 2)]
        private void DbConnectionSTMMDynQuerySelectModelDynParBatchConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListmoneyArray)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModelDynPar",
            position: 2)]
        private void DbConnectionMMDynQuerySelectModelDynParBatchConfig()
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
FROM public.decimalmoneyarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDecimalmoneyArray2M>();
                var models2 = new List<FlatDecimalmoneyArray2M>();
                await((IDecimalListmoneyArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalmoneyArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalmoneyArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 139;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 123;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.decimalmoneyarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.decimalmoneyarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalmoneyArray2M>();
                var firstItems2 = new List<FlatDecimalmoneyArray2M>();
                var secondItems1 = new List<FlatDecimalmoneyArray2M>();
                var secondItems2 = new List<FlatDecimalmoneyArray2M>();
                await ((IDecimalListmoneyArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[3],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[6],_testData[30], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 53;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 37;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.decimalmoneyarray2m m
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
FROM public.decimalmoneyarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalmoneyArray2M>();
                var firstItems2 = new List<FlatDecimalmoneyArray2M>();
                var secondItems1 = new List<FlatDecimalmoneyArray2M>();
                await ((IDecimalListmoneyArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[22],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[24],_testData[29], false);
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
FROM public.decimalmoneyarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDecimalmoneyArray2M>();
                var models2 = new List<FlatDecimalmoneyArray2M>();
                ((IDecimalListmoneyArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalmoneyArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalmoneyArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 83;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 71;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.decimalmoneyarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.decimalmoneyarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalmoneyArray2M>();
                var firstItems2 = new List<FlatDecimalmoneyArray2M>();
                var secondItems1 = new List<FlatDecimalmoneyArray2M>();
                var secondItems2 = new List<FlatDecimalmoneyArray2M>();
                 ((IDecimalListmoneyArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[15],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[18],_testData[30], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 112;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 139;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.decimalmoneyarray2m m
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
FROM public.decimalmoneyarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalmoneyArray2M>();
                var firstItems2 = new List<FlatDecimalmoneyArray2M>();
                var secondItems1 = new List<FlatDecimalmoneyArray2M>();
                 ((IDecimalListmoneyArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[8],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[3],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalmoneyArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListmoneyArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListmoneyArray)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModelDynPar",
            position: 2)]
        private void DbConnectionSTDynQuerySelectModelDynParBatchConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListmoneyArray)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModelDynPar",
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
FROM public.decimalmoneyarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IDecimalListmoneyArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalmoneyArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 130;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 53;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalmoneyarray2m m
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
FROM public.decimalmoneyarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IDecimalListmoneyArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatDecimalmoneyArray2M.AssertModel(models[0],_testData[24], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[1],_testData[25], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[2],_testData[26], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[3],_testData[27], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[4],_testData[28], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatDecimalmoneyArray2M.AssertModel(models[0],_testData[7], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[1],_testData[8], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[2],_testData[9], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[3],_testData[10], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[4],_testData[11], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[5],_testData[12], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[6],_testData[13], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[7],_testData[14], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[8],_testData[15], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[9],_testData[16], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[10],_testData[17], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[11],_testData[18], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[12],_testData[19], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[13],_testData[20], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[14],_testData[21], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[15],_testData[22], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[16],_testData[23], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[17],_testData[24], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[18],_testData[25], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[19],_testData[26], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[20],_testData[27], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[21],_testData[28], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
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
                parametr1.Value = 139;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 54;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalmoneyarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.decimalmoneyarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalmoneyArray2M>();
                var secondItems1 = new List<FlatDecimalmoneyArray2M>();
                var secondItems2 = new List<FlatDecimalmoneyArray2M>();
                await ((IDecimalListmoneyArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[3],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[21],_testData[30], false);
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
FROM public.decimalmoneyarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IDecimalListmoneyArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalmoneyArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 53;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 144;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalmoneyarray2m m
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
FROM public.decimalmoneyarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IDecimalListmoneyArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatDecimalmoneyArray2M.AssertModel(models[0],_testData[7], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[1],_testData[8], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[2],_testData[9], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[3],_testData[10], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[4],_testData[11], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[5],_testData[12], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[6],_testData[13], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[7],_testData[14], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[8],_testData[15], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[9],_testData[16], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[10],_testData[17], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[11],_testData[18], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[12],_testData[19], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[13],_testData[20], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[14],_testData[21], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[15],_testData[22], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[16],_testData[23], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[17],_testData[24], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[18],_testData[25], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[19],_testData[26], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[20],_testData[27], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[21],_testData[28], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatDecimalmoneyArray2M.AssertModel(models[0],_testData[27], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[1],_testData[28], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
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
                parametr1.Value = 100;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 9;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalmoneyarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.decimalmoneyarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalmoneyArray2M>();
                var secondItems1 = new List<FlatDecimalmoneyArray2M>();
                var secondItems2 = new List<FlatDecimalmoneyArray2M>();
                 ((IDecimalListmoneyArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[10],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[28],_testData[30], false);
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
FROM public.decimalmoneyarray2m m
LEFT JOIN public.decimalmoneyarray2mi mi ON mi.id = m.decimalmoneyarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(DecimalmoneyArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListmoneyArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListmoneyArray)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModelDynPar",
            position: 2)]
        private void DbConnectionSTSelectModelDynParBatchConfig()
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
                var models = await((IDecimalListmoneyArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DecimalmoneyArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTSelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 64;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 71;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((IDecimalListmoneyArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        DecimalmoneyArray2M.AssertModel(models[0],_testData[10], false);
                        DecimalmoneyArray2M.AssertModel(models[1],_testData[11], false);
                        DecimalmoneyArray2M.AssertModel(models[2],_testData[12], false);
                        DecimalmoneyArray2M.AssertModel(models[3],_testData[13], false);
                        DecimalmoneyArray2M.AssertModel(models[4],_testData[14], false);
                        DecimalmoneyArray2M.AssertModel(models[5],_testData[15], false);
                        DecimalmoneyArray2M.AssertModel(models[6],_testData[16], false);
                        DecimalmoneyArray2M.AssertModel(models[7],_testData[17], false);
                        DecimalmoneyArray2M.AssertModel(models[8],_testData[18], false);
                        DecimalmoneyArray2M.AssertModel(models[9],_testData[19], false);
                        DecimalmoneyArray2M.AssertModel(models[10],_testData[20], false);
                        DecimalmoneyArray2M.AssertModel(models[11],_testData[21], false);
                        DecimalmoneyArray2M.AssertModel(models[12],_testData[22], false);
                        DecimalmoneyArray2M.AssertModel(models[13],_testData[23], false);
                        DecimalmoneyArray2M.AssertModel(models[14],_testData[24], false);
                        DecimalmoneyArray2M.AssertModel(models[15],_testData[25], false);
                        DecimalmoneyArray2M.AssertModel(models[16],_testData[26], false);
                        DecimalmoneyArray2M.AssertModel(models[17],_testData[27], false);
                        DecimalmoneyArray2M.AssertModel(models[18],_testData[28], false);
                        DecimalmoneyArray2M.AssertModel(models[19],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        DecimalmoneyArray2M.AssertModel(models[0],_testData[11], false);
                        DecimalmoneyArray2M.AssertModel(models[1],_testData[12], false);
                        DecimalmoneyArray2M.AssertModel(models[2],_testData[13], false);
                        DecimalmoneyArray2M.AssertModel(models[3],_testData[14], false);
                        DecimalmoneyArray2M.AssertModel(models[4],_testData[15], false);
                        DecimalmoneyArray2M.AssertModel(models[5],_testData[16], false);
                        DecimalmoneyArray2M.AssertModel(models[6],_testData[17], false);
                        DecimalmoneyArray2M.AssertModel(models[7],_testData[18], false);
                        DecimalmoneyArray2M.AssertModel(models[8],_testData[19], false);
                        DecimalmoneyArray2M.AssertModel(models[9],_testData[20], false);
                        DecimalmoneyArray2M.AssertModel(models[10],_testData[21], false);
                        DecimalmoneyArray2M.AssertModel(models[11],_testData[22], false);
                        DecimalmoneyArray2M.AssertModel(models[12],_testData[23], false);
                        DecimalmoneyArray2M.AssertModel(models[13],_testData[24], false);
                        DecimalmoneyArray2M.AssertModel(models[14],_testData[25], false);
                        DecimalmoneyArray2M.AssertModel(models[15],_testData[26], false);
                        DecimalmoneyArray2M.AssertModel(models[16],_testData[27], false);
                        DecimalmoneyArray2M.AssertModel(models[17],_testData[28], false);
                        DecimalmoneyArray2M.AssertModel(models[18],_testData[29], false);
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
                var models = ((IDecimalListmoneyArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DecimalmoneyArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTSelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 100;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 53;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((IDecimalListmoneyArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        DecimalmoneyArray2M.AssertModel(models[0],_testData[19], false);
                        DecimalmoneyArray2M.AssertModel(models[1],_testData[20], false);
                        DecimalmoneyArray2M.AssertModel(models[2],_testData[21], false);
                        DecimalmoneyArray2M.AssertModel(models[3],_testData[22], false);
                        DecimalmoneyArray2M.AssertModel(models[4],_testData[23], false);
                        DecimalmoneyArray2M.AssertModel(models[5],_testData[24], false);
                        DecimalmoneyArray2M.AssertModel(models[6],_testData[25], false);
                        DecimalmoneyArray2M.AssertModel(models[7],_testData[26], false);
                        DecimalmoneyArray2M.AssertModel(models[8],_testData[27], false);
                        DecimalmoneyArray2M.AssertModel(models[9],_testData[28], false);
                        DecimalmoneyArray2M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        DecimalmoneyArray2M.AssertModel(models[0],_testData[7], false);
                        DecimalmoneyArray2M.AssertModel(models[1],_testData[8], false);
                        DecimalmoneyArray2M.AssertModel(models[2],_testData[9], false);
                        DecimalmoneyArray2M.AssertModel(models[3],_testData[10], false);
                        DecimalmoneyArray2M.AssertModel(models[4],_testData[11], false);
                        DecimalmoneyArray2M.AssertModel(models[5],_testData[12], false);
                        DecimalmoneyArray2M.AssertModel(models[6],_testData[13], false);
                        DecimalmoneyArray2M.AssertModel(models[7],_testData[14], false);
                        DecimalmoneyArray2M.AssertModel(models[8],_testData[15], false);
                        DecimalmoneyArray2M.AssertModel(models[9],_testData[16], false);
                        DecimalmoneyArray2M.AssertModel(models[10],_testData[17], false);
                        DecimalmoneyArray2M.AssertModel(models[11],_testData[18], false);
                        DecimalmoneyArray2M.AssertModel(models[12],_testData[19], false);
                        DecimalmoneyArray2M.AssertModel(models[13],_testData[20], false);
                        DecimalmoneyArray2M.AssertModel(models[14],_testData[21], false);
                        DecimalmoneyArray2M.AssertModel(models[15],_testData[22], false);
                        DecimalmoneyArray2M.AssertModel(models[16],_testData[23], false);
                        DecimalmoneyArray2M.AssertModel(models[17],_testData[24], false);
                        DecimalmoneyArray2M.AssertModel(models[18],_testData[25], false);
                        DecimalmoneyArray2M.AssertModel(models[19],_testData[26], false);
                        DecimalmoneyArray2M.AssertModel(models[20],_testData[27], false);
                        DecimalmoneyArray2M.AssertModel(models[21],_testData[28], false);
                        DecimalmoneyArray2M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalmoneyArray2M), typeof(FlatDecimalmoneyArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListmoneyArray)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)(11))]
        private void DbConnectionMMDynQuerySelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListmoneyArray)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModel",
            position: 2)]
        private void DbConnectionSTMMDynQuerySelectModelBatchConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionMMDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListmoneyArray)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModel",
            position: 2)]
        private void DbConnectionMMDynQuerySelectModelBatchConfig()
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
FROM public.decimalmoneyarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalmoneyArray2M>();
                var models2 = new List<FlatDecimalmoneyArray2M>();
                await((IDecimalListmoneyArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalmoneyArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalmoneyArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.decimalmoneyarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.decimalmoneyarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalmoneyArray2M>();
                var firstItems2 = new List<FlatDecimalmoneyArray2M>();
                var secondItems1 = new List<FlatDecimalmoneyArray2M>();
                var secondItems2 = new List<FlatDecimalmoneyArray2M>();
                await ((IDecimalListmoneyArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 100, query1, 130, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[10],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[5],_testData[30], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.decimalmoneyarray2m m
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
FROM public.decimalmoneyarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalmoneyArray2M>();
                var firstItems2 = new List<FlatDecimalmoneyArray2M>();
                var secondItems1 = new List<FlatDecimalmoneyArray2M>();
                await ((IDecimalListmoneyArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 71, query1, 137, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[18],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[4],_testData[29], false);
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
FROM public.decimalmoneyarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalmoneyArray2M>();
                var models2 = new List<FlatDecimalmoneyArray2M>();
                ((IDecimalListmoneyArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalmoneyArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalmoneyArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.decimalmoneyarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.decimalmoneyarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalmoneyArray2M>();
                var firstItems2 = new List<FlatDecimalmoneyArray2M>();
                var secondItems1 = new List<FlatDecimalmoneyArray2M>();
                var secondItems2 = new List<FlatDecimalmoneyArray2M>();
                 ((IDecimalListmoneyArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 53, query1, 35, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[22],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[25],_testData[30], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.decimalmoneyarray2m m
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
FROM public.decimalmoneyarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalmoneyArray2M>();
                var firstItems2 = new List<FlatDecimalmoneyArray2M>();
                var secondItems1 = new List<FlatDecimalmoneyArray2M>();
                 ((IDecimalListmoneyArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 18, query1, 54, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems2[27],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[21],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalmoneyArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListmoneyArray)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)(11))]
        private void DbConnectionDynQuerySelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListmoneyArray)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModel",
            position: 2)]
        private void DbConnectionSTDynQuerySelectModelBatchConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListmoneyArray)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModel",
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
FROM public.decimalmoneyarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IDecimalListmoneyArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalmoneyArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelBatchTestAsync()
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
FROM public.decimalmoneyarray2m m
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
FROM public.decimalmoneyarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IDecimalListmoneyArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 27, query1, 9, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatDecimalmoneyArray2M.AssertModel(models[0],_testData[3], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[1],_testData[4], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[2],_testData[5], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[3],_testData[6], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[4],_testData[7], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[5],_testData[8], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[6],_testData[9], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[7],_testData[10], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[8],_testData[11], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[9],_testData[12], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[10],_testData[13], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[11],_testData[14], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[12],_testData[15], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[13],_testData[16], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[14],_testData[17], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[15],_testData[18], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[16],_testData[19], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[17],_testData[20], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[18],_testData[21], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[19],_testData[22], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[20],_testData[23], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[21],_testData[24], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[22],_testData[25], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[23],_testData[26], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[24],_testData[27], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[25],_testData[28], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatDecimalmoneyArray2M.AssertModel(models[0],_testData[1], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[1],_testData[2], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[2],_testData[3], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[3],_testData[4], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[4],_testData[5], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[5],_testData[6], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[6],_testData[7], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[7],_testData[8], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[8],_testData[9], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[9],_testData[10], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[10],_testData[11], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[11],_testData[12], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[12],_testData[13], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[13],_testData[14], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[14],_testData[15], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[15],_testData[16], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[16],_testData[17], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[17],_testData[18], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[18],_testData[19], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[19],_testData[20], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[20],_testData[21], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[21],_testData[22], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[22],_testData[23], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[23],_testData[24], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[24],_testData[25], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[25],_testData[26], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[26],_testData[27], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[27],_testData[28], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[28],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
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
FROM public.decimalmoneyarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.decimalmoneyarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalmoneyArray2M>();
                var secondItems1 = new List<FlatDecimalmoneyArray2M>();
                var secondItems2 = new List<FlatDecimalmoneyArray2M>();
                await ((IDecimalListmoneyArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 71, query1, 85, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[18],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[14],_testData[30], false);
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
FROM public.decimalmoneyarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IDecimalListmoneyArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalmoneyArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelBatchTest()
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
FROM public.decimalmoneyarray2m m
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
FROM public.decimalmoneyarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IDecimalListmoneyArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 96, query1, 73, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatDecimalmoneyArray2M.AssertModel(models[0],_testData[18], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[1],_testData[19], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[2],_testData[20], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[3],_testData[21], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[4],_testData[22], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[5],_testData[23], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[6],_testData[24], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[7],_testData[25], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[8],_testData[26], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[9],_testData[27], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[10],_testData[28], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[11],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatDecimalmoneyArray2M.AssertModel(models[0],_testData[12], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[1],_testData[13], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[2],_testData[14], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[3],_testData[15], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[4],_testData[16], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[5],_testData[17], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[6],_testData[18], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[7],_testData[19], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[8],_testData[20], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[9],_testData[21], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[10],_testData[22], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[11],_testData[23], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[12],_testData[24], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[13],_testData[25], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[14],_testData[26], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[15],_testData[27], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[16],_testData[28], false);
                        FlatDecimalmoneyArray2M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
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
FROM public.decimalmoneyarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.decimalmoneyarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalmoneyArray2M>();
                var secondItems1 = new List<FlatDecimalmoneyArray2M>();
                var secondItems2 = new List<FlatDecimalmoneyArray2M>();
                 ((IDecimalListmoneyArray)this).DbConnectionDynQuerySelectModelBatch(connection, 139, query1, 35, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatDecimalmoneyArray2M.AssertModel(firstItems1[3],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatDecimalmoneyArray2M.AssertModel(secondItems2[25],_testData[30], false);
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
FROM public.decimalmoneyarray2m m
LEFT JOIN public.decimalmoneyarray2mi mi ON mi.id = m.decimalmoneyarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(DecimalmoneyArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListmoneyArray)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)(11))]
        private void DbConnectionSelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListmoneyArray)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModel",
            position: 2)]
        private void DbConnectionSTSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await((IDecimalListmoneyArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DecimalmoneyArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTSelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalListmoneyArray)this).DbConnectionSTSelectModelBatchAsync(connection, 139, 95))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        DecimalmoneyArray2M.AssertModel(models[0],_testData[26], false);
                        DecimalmoneyArray2M.AssertModel(models[1],_testData[27], false);
                        DecimalmoneyArray2M.AssertModel(models[2],_testData[28], false);
                        DecimalmoneyArray2M.AssertModel(models[3],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        DecimalmoneyArray2M.AssertModel(models[0],_testData[17], false);
                        DecimalmoneyArray2M.AssertModel(models[1],_testData[18], false);
                        DecimalmoneyArray2M.AssertModel(models[2],_testData[19], false);
                        DecimalmoneyArray2M.AssertModel(models[3],_testData[20], false);
                        DecimalmoneyArray2M.AssertModel(models[4],_testData[21], false);
                        DecimalmoneyArray2M.AssertModel(models[5],_testData[22], false);
                        DecimalmoneyArray2M.AssertModel(models[6],_testData[23], false);
                        DecimalmoneyArray2M.AssertModel(models[7],_testData[24], false);
                        DecimalmoneyArray2M.AssertModel(models[8],_testData[25], false);
                        DecimalmoneyArray2M.AssertModel(models[9],_testData[26], false);
                        DecimalmoneyArray2M.AssertModel(models[10],_testData[27], false);
                        DecimalmoneyArray2M.AssertModel(models[11],_testData[28], false);
                        DecimalmoneyArray2M.AssertModel(models[12],_testData[29], false);
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
                var models = ((IDecimalListmoneyArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DecimalmoneyArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTSelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalListmoneyArray)this).DbConnectionSTSelectModelBatch(connection, 112, 53))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        DecimalmoneyArray2M.AssertModel(models[0],_testData[21], false);
                        DecimalmoneyArray2M.AssertModel(models[1],_testData[22], false);
                        DecimalmoneyArray2M.AssertModel(models[2],_testData[23], false);
                        DecimalmoneyArray2M.AssertModel(models[3],_testData[24], false);
                        DecimalmoneyArray2M.AssertModel(models[4],_testData[25], false);
                        DecimalmoneyArray2M.AssertModel(models[5],_testData[26], false);
                        DecimalmoneyArray2M.AssertModel(models[6],_testData[27], false);
                        DecimalmoneyArray2M.AssertModel(models[7],_testData[28], false);
                        DecimalmoneyArray2M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        DecimalmoneyArray2M.AssertModel(models[0],_testData[7], false);
                        DecimalmoneyArray2M.AssertModel(models[1],_testData[8], false);
                        DecimalmoneyArray2M.AssertModel(models[2],_testData[9], false);
                        DecimalmoneyArray2M.AssertModel(models[3],_testData[10], false);
                        DecimalmoneyArray2M.AssertModel(models[4],_testData[11], false);
                        DecimalmoneyArray2M.AssertModel(models[5],_testData[12], false);
                        DecimalmoneyArray2M.AssertModel(models[6],_testData[13], false);
                        DecimalmoneyArray2M.AssertModel(models[7],_testData[14], false);
                        DecimalmoneyArray2M.AssertModel(models[8],_testData[15], false);
                        DecimalmoneyArray2M.AssertModel(models[9],_testData[16], false);
                        DecimalmoneyArray2M.AssertModel(models[10],_testData[17], false);
                        DecimalmoneyArray2M.AssertModel(models[11],_testData[18], false);
                        DecimalmoneyArray2M.AssertModel(models[12],_testData[19], false);
                        DecimalmoneyArray2M.AssertModel(models[13],_testData[20], false);
                        DecimalmoneyArray2M.AssertModel(models[14],_testData[21], false);
                        DecimalmoneyArray2M.AssertModel(models[15],_testData[22], false);
                        DecimalmoneyArray2M.AssertModel(models[16],_testData[23], false);
                        DecimalmoneyArray2M.AssertModel(models[17],_testData[24], false);
                        DecimalmoneyArray2M.AssertModel(models[18],_testData[25], false);
                        DecimalmoneyArray2M.AssertModel(models[19],_testData[26], false);
                        DecimalmoneyArray2M.AssertModel(models[20],_testData[27], false);
                        DecimalmoneyArray2M.AssertModel(models[21],_testData[28], false);
                        DecimalmoneyArray2M.AssertModel(models[22],_testData[29], false);
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
                await using var cmd = await ((IDecimalListmoneyArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IDecimalListmoneyArray)this).SetDbConnectionSelectModelParametrs(cmd, 35);
                var models = await ((IDecimalListmoneyArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(26));
DecimalmoneyArray2M.AssertModel(models[0],_testData[4], false);DecimalmoneyArray2M.AssertModel(models[1],_testData[5], false);DecimalmoneyArray2M.AssertModel(models[2],_testData[6], false);DecimalmoneyArray2M.AssertModel(models[3],_testData[7], false);DecimalmoneyArray2M.AssertModel(models[4],_testData[8], false);DecimalmoneyArray2M.AssertModel(models[5],_testData[9], false);DecimalmoneyArray2M.AssertModel(models[6],_testData[10], false);DecimalmoneyArray2M.AssertModel(models[7],_testData[11], false);DecimalmoneyArray2M.AssertModel(models[8],_testData[12], false);DecimalmoneyArray2M.AssertModel(models[9],_testData[13], false);DecimalmoneyArray2M.AssertModel(models[10],_testData[14], false);DecimalmoneyArray2M.AssertModel(models[11],_testData[15], false);DecimalmoneyArray2M.AssertModel(models[12],_testData[16], false);DecimalmoneyArray2M.AssertModel(models[13],_testData[17], false);DecimalmoneyArray2M.AssertModel(models[14],_testData[18], false);DecimalmoneyArray2M.AssertModel(models[15],_testData[19], false);DecimalmoneyArray2M.AssertModel(models[16],_testData[20], false);DecimalmoneyArray2M.AssertModel(models[17],_testData[21], false);DecimalmoneyArray2M.AssertModel(models[18],_testData[22], false);DecimalmoneyArray2M.AssertModel(models[19],_testData[23], false);DecimalmoneyArray2M.AssertModel(models[20],_testData[24], false);DecimalmoneyArray2M.AssertModel(models[21],_testData[25], false);DecimalmoneyArray2M.AssertModel(models[22],_testData[26], false);DecimalmoneyArray2M.AssertModel(models[23],_testData[27], false);DecimalmoneyArray2M.AssertModel(models[24],_testData[28], false);DecimalmoneyArray2M.AssertModel(models[25],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDecimalListmoneyArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDecimalListmoneyArray)this).SetDbConnectionSelectModelParametrs(cmd, 35);
                var models =  ((IDecimalListmoneyArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(26));
DecimalmoneyArray2M.AssertModel(models[0],_testData[4], false);DecimalmoneyArray2M.AssertModel(models[1],_testData[5], false);DecimalmoneyArray2M.AssertModel(models[2],_testData[6], false);DecimalmoneyArray2M.AssertModel(models[3],_testData[7], false);DecimalmoneyArray2M.AssertModel(models[4],_testData[8], false);DecimalmoneyArray2M.AssertModel(models[5],_testData[9], false);DecimalmoneyArray2M.AssertModel(models[6],_testData[10], false);DecimalmoneyArray2M.AssertModel(models[7],_testData[11], false);DecimalmoneyArray2M.AssertModel(models[8],_testData[12], false);DecimalmoneyArray2M.AssertModel(models[9],_testData[13], false);DecimalmoneyArray2M.AssertModel(models[10],_testData[14], false);DecimalmoneyArray2M.AssertModel(models[11],_testData[15], false);DecimalmoneyArray2M.AssertModel(models[12],_testData[16], false);DecimalmoneyArray2M.AssertModel(models[13],_testData[17], false);DecimalmoneyArray2M.AssertModel(models[14],_testData[18], false);DecimalmoneyArray2M.AssertModel(models[15],_testData[19], false);DecimalmoneyArray2M.AssertModel(models[16],_testData[20], false);DecimalmoneyArray2M.AssertModel(models[17],_testData[21], false);DecimalmoneyArray2M.AssertModel(models[18],_testData[22], false);DecimalmoneyArray2M.AssertModel(models[19],_testData[23], false);DecimalmoneyArray2M.AssertModel(models[20],_testData[24], false);DecimalmoneyArray2M.AssertModel(models[21],_testData[25], false);DecimalmoneyArray2M.AssertModel(models[22],_testData[26], false);DecimalmoneyArray2M.AssertModel(models[23],_testData[27], false);DecimalmoneyArray2M.AssertModel(models[24],_testData[28], false);DecimalmoneyArray2M.AssertModel(models[25],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_decimalmoneyarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(DecimalmoneyArray2MI)],
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
            asPartInterface: typeof(IDecimalListmoneyArray))]
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
FROM public.binary_decimalmoneyarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(DecimalmoneyArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListmoneyArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<DecimalmoneyArray2MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((IDecimalListmoneyArray)this).ImportModelInner(connection, importCollection);
                var models = ((IDecimalListmoneyArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalmoneyArray2MI.AssertModel(actual, expect, false);
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
                await ((IDecimalListmoneyArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((IDecimalListmoneyArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalmoneyArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_decimalmoneyarray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
decimalmoneyarray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapTypes: [typeof(DecimalmoneyArray2M)],
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
            asPartInterface: typeof(IDecimalListmoneyArray))]
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
FROM public.binary_decimalmoneyarray2m m
LEFT JOIN public.binary_decimalmoneyarray2mi mi ON mi.id = m.decimalmoneyarray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(DecimalmoneyArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListmoneyArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<DecimalmoneyArray2M>(15);

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
                ((IDecimalListmoneyArray)this).ImportModel(connection, importCollection);
                var models = ((IDecimalListmoneyArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                DecimalmoneyArray2M.AssertModel(models[0],_testData[0], false);
                DecimalmoneyArray2M.AssertModel(models[1],_testData[1], false);
                DecimalmoneyArray2M.AssertModel(models[2],_testData[2], false);
                DecimalmoneyArray2M.AssertModel(models[3],_testData[3], false);
                DecimalmoneyArray2M.AssertModel(models[4],_testData[4], false);
                DecimalmoneyArray2M.AssertModel(models[5],_testData[5], false);
                DecimalmoneyArray2M.AssertModel(models[6],_testData[6], false);
                DecimalmoneyArray2M.AssertModel(models[7],_testData[7], false);
                DecimalmoneyArray2M.AssertModel(models[8],_testData[8], false);
                DecimalmoneyArray2M.AssertModel(models[9],_testData[9], false);
                DecimalmoneyArray2M.AssertModel(models[10],_testData[10], false);
                DecimalmoneyArray2M.AssertModel(models[11],_testData[11], false);
                DecimalmoneyArray2M.AssertModel(models[12],_testData[12], false);
                DecimalmoneyArray2M.AssertModel(models[13],_testData[13], false);
                DecimalmoneyArray2M.AssertModel(models[14],_testData[14], false);
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
                await ((IDecimalListmoneyArray)this).ImportModelAsync(connection, importCollection);
                models = await ((IDecimalListmoneyArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                DecimalmoneyArray2M.AssertModel(models[0],_testData[0], false);
                DecimalmoneyArray2M.AssertModel(models[1],_testData[1], false);
                DecimalmoneyArray2M.AssertModel(models[2],_testData[2], false);
                DecimalmoneyArray2M.AssertModel(models[3],_testData[3], false);
                DecimalmoneyArray2M.AssertModel(models[4],_testData[4], false);
                DecimalmoneyArray2M.AssertModel(models[5],_testData[5], false);
                DecimalmoneyArray2M.AssertModel(models[6],_testData[6], false);
                DecimalmoneyArray2M.AssertModel(models[7],_testData[7], false);
                DecimalmoneyArray2M.AssertModel(models[8],_testData[8], false);
                DecimalmoneyArray2M.AssertModel(models[9],_testData[9], false);
                DecimalmoneyArray2M.AssertModel(models[10],_testData[10], false);
                DecimalmoneyArray2M.AssertModel(models[11],_testData[11], false);
                DecimalmoneyArray2M.AssertModel(models[12],_testData[12], false);
                DecimalmoneyArray2M.AssertModel(models[13],_testData[13], false);
                DecimalmoneyArray2M.AssertModel(models[14],_testData[14], false);
                DecimalmoneyArray2M.AssertModel(models[15],_testData[15], false);
                DecimalmoneyArray2M.AssertModel(models[16],_testData[16], false);
                DecimalmoneyArray2M.AssertModel(models[17],_testData[17], false);
                DecimalmoneyArray2M.AssertModel(models[18],_testData[18], false);
                DecimalmoneyArray2M.AssertModel(models[19],_testData[19], false);
                DecimalmoneyArray2M.AssertModel(models[20],_testData[20], false);
                DecimalmoneyArray2M.AssertModel(models[21],_testData[21], false);
                DecimalmoneyArray2M.AssertModel(models[22],_testData[22], false);
                DecimalmoneyArray2M.AssertModel(models[23],_testData[23], false);
                DecimalmoneyArray2M.AssertModel(models[24],_testData[24], false);
                DecimalmoneyArray2M.AssertModel(models[25],_testData[25], false);
                DecimalmoneyArray2M.AssertModel(models[26],_testData[26], false);
                DecimalmoneyArray2M.AssertModel(models[27],_testData[27], false);
                DecimalmoneyArray2M.AssertModel(models[28],_testData[28], false);
                DecimalmoneyArray2M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_decimalmoneyarray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    decimalmoneyarray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(DecimalmoneyArray2M)],
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
            asPartInterface: typeof(IDecimalListmoneyArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IDecimalListmoneyArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    DecimalmoneyArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDecimalListmoneyArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    DecimalmoneyArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_decimalmoneyarray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(DecimalmoneyArray2MI)],
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
            asPartInterface: typeof(IDecimalListmoneyArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IDecimalListmoneyArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalmoneyArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDecimalListmoneyArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalmoneyArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

