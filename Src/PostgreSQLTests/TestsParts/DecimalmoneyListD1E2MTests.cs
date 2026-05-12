

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
    internal partial interface IDecimalListmoneyListD1
    {
    }
    
    internal partial class DecimalListmoneyListD1 : IDecimalListmoneyListD1
    {


#region TestData

        private readonly DecimalmoneyListD1E2M[] _testData = new DecimalmoneyListD1E2M[]
        {
            new DecimalmoneyListD1E2M
{
    Id = 5,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.85m,

0.64m,

0.73m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalmoneyListD1E2M
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.97m,

0.18m,

0.21m,

},
    ModelInner = new DecimalmoneyListD1E2MI
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.74m,

0.70m,

0.94m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.74m,

0.98m,

0.79m,

0.92m,

},
},
    NullableValue = null,
},
            new DecimalmoneyListD1E2M
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.10m,

0.98m,

0.98m,

0.13m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.18m,

0.49m,

0.30m,

},
},
            new DecimalmoneyListD1E2M
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.88m,

0.80m,

0.79m,

},
    ModelInner = new DecimalmoneyListD1E2MI
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.77m,

0.35m,

0.92m,

0.73m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.93m,

0.30m,

0.21m,

0.70m,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.15m,

0.72m,

0.55m,

},
},
            new DecimalmoneyListD1E2M
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.00m,

0.50m,

0.19m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.94m,

0.22m,

0.83m,

},
},
            new DecimalmoneyListD1E2M
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.49m,

0.03m,

0.49m,

0.62m,

},
    ModelInner = new DecimalmoneyListD1E2MI
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.41m,

0.33m,

0.80m,

0.73m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.96m,

0.99m,

0.50m,

0.34m,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.04m,

0.22m,

0.16m,

},
},
            new DecimalmoneyListD1E2M
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.12m,

0.82m,

0.41m,

0.85m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.52m,

0.38m,

0.33m,

},
},
            new DecimalmoneyListD1E2M
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.06m,

0.14m,

0.71m,

},
    ModelInner = new DecimalmoneyListD1E2MI
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.37m,

0.92m,

0.73m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.07m,

0.67m,

0.74m,

0.06m,

},
},
    NullableValue = null,
},
            new DecimalmoneyListD1E2M
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.56m,

0.62m,

0.62m,

0.02m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalmoneyListD1E2M
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.80m,

0.68m,

0.50m,

0.69m,

},
    ModelInner = new DecimalmoneyListD1E2MI
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.15m,

0.79m,

0.21m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.31m,

0.96m,

0.70m,

0.78m,

},
},
    NullableValue = null,
},
            new DecimalmoneyListD1E2M
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.76m,

0.52m,

0.99m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalmoneyListD1E2M
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.77m,

0.05m,

0.41m,

0.76m,

},
    ModelInner = new DecimalmoneyListD1E2MI
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.50m,

0.53m,

0.24m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.31m,

0.79m,

0.80m,

0.28m,

},
},
    NullableValue = null,
},
            new DecimalmoneyListD1E2M
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.89m,

0.31m,

0.33m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalmoneyListD1E2M
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.74m,

0.78m,

0.80m,

0.88m,

},
    ModelInner = new DecimalmoneyListD1E2MI
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.17m,

0.88m,

0.28m,

0.18m,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.25m,

0.17m,

0.74m,

},
},
            new DecimalmoneyListD1E2M
{
    Id = 73,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.94m,

0.53m,

0.68m,

0.27m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalmoneyListD1E2M
{
    Id = 79,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.50m,

0.99m,

0.87m,

0.33m,

},
    ModelInner = new DecimalmoneyListD1E2MI
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.36m,

0.42m,

0.96m,

0.18m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.82m,

0.50m,

0.03m,

0.43m,

},
},
    NullableValue = null,
},
            new DecimalmoneyListD1E2M
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.38m,

0.46m,

0.45m,

0.71m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalmoneyListD1E2M
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.16m,

0.67m,

0.48m,

},
    ModelInner = new DecimalmoneyListD1E2MI
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.44m,

0.50m,

0.55m,

0.28m,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.18m,

0.26m,

0.87m,

0.23m,

},
},
            new DecimalmoneyListD1E2M
{
    Id = 92,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.24m,

0.68m,

0.87m,

0.13m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.39m,

0.16m,

0.71m,

},
},
            new DecimalmoneyListD1E2M
{
    Id = 95,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.41m,

0.10m,

0.11m,

},
    ModelInner = new DecimalmoneyListD1E2MI
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.91m,

0.63m,

0.47m,

0.56m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.56m,

0.66m,

0.70m,

0.23m,

},
},
    NullableValue = null,
},
            new DecimalmoneyListD1E2M
{
    Id = 101,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.13m,

0.63m,

0.43m,

0.26m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalmoneyListD1E2M
{
    Id = 104,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.63m,

0.51m,

0.87m,

},
    ModelInner = new DecimalmoneyListD1E2MI
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.29m,

0.61m,

0.44m,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalmoneyListD1E2M
{
    Id = 107,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.17m,

0.84m,

0.41m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalmoneyListD1E2M
{
    Id = 114,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.86m,

0.49m,

0.78m,

0.41m,

},
    ModelInner = new DecimalmoneyListD1E2MI
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.95m,

0.90m,

0.67m,

0.27m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.95m,

0.76m,

0.01m,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.83m,

0.14m,

0.54m,

},
},
            new DecimalmoneyListD1E2M
{
    Id = 117,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.93m,

0.12m,

0.23m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalmoneyListD1E2M
{
    Id = 121,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.65m,

0.35m,

0.28m,

},
    ModelInner = new DecimalmoneyListD1E2MI
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.20m,

0.93m,

0.82m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.72m,

0.44m,

0.65m,

0.98m,

},
},
    NullableValue = null,
},
            new DecimalmoneyListD1E2M
{
    Id = 127,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.26m,

0.32m,

0.81m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalmoneyListD1E2M
{
    Id = 132,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.42m,

0.69m,

0.09m,

},
    ModelInner = new DecimalmoneyListD1E2MI
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.45m,

0.05m,

0.27m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.53m,

0.14m,

0.36m,

},
},
    NullableValue = null,
},
            new DecimalmoneyListD1E2M
{
    Id = 134,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.29m,

0.84m,

0.04m,

0.50m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalmoneyListD1E2M
{
    Id = 137,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.57m,

0.29m,

0.22m,

},
    ModelInner = new DecimalmoneyListD1E2MI
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.21m,

0.59m,

0.97m,

0.93m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.80m,

0.62m,

0.85m,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.12m,

0.55m,

0.44m,

},
},
            new DecimalmoneyListD1E2M
{
    Id = 143,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.13m,

0.70m,

0.75m,

0.68m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.71m,

0.71m,

0.87m,

0.60m,

},
},
            new DecimalmoneyListD1E2M
{
    Id = 148,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.82m,

0.72m,

0.71m,

},
    ModelInner = new DecimalmoneyListD1E2MI
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.54m,

0.35m,

0.85m,

0.94m,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalmoneyListD1E2M
{
    Id = 155,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.81m,

0.37m,

0.46m,

0.41m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.49m,

0.14m,

0.52m,

},
},
            new DecimalmoneyListD1E2M
{
    Id = 156,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.03m,

0.99m,

0.20m,

},
    ModelInner = new DecimalmoneyListD1E2MI
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.09m,

0.15m,

0.21m,

0.82m,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalmoneyListD1E2M
{
    Id = 158,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.63m,

0.24m,

0.67m,

},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalmoneylistd1e2mi(
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
            asPartInterface: typeof(IDecimalListmoneyListD1)),
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
INSERT INTO public.decimalmoneylistd1e2mi(
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
            queryMapTypes: [typeof(DecimalmoneyListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListmoneyListD1)),
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

                changedRows =  ((IDecimalListmoneyListD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDecimalListmoneyListD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IDecimalListmoneyListD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalListmoneyListD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IDecimalListmoneyListD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IDecimalListmoneyListD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IDecimalListmoneyListD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IDecimalListmoneyListD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IDecimalListmoneyListD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IDecimalListmoneyListD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IDecimalListmoneyListD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IDecimalListmoneyListD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IDecimalListmoneyListD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IDecimalListmoneyListD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IDecimalListmoneyListD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IDecimalListmoneyListD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IDecimalListmoneyListD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalmoneylistd1e2m(
	id,
    value,
    nullablevalue,
    decimalmoneylistd1e2mi_id
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
            asPartInterface: typeof(IDecimalListmoneyListD1)), 
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
                methodParametrName: "decimalmoneylistd1e2mi_id", 
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
                changedRows =  ((IDecimalListmoneyListD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IDecimalListmoneyListD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IDecimalListmoneyListD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IDecimalListmoneyListD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalmoneylistd1e2m(
	id,
    value,
    nullablevalue,
    decimalmoneylistd1e2mi_id
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
    decimalmoneylistd1e2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(DecimalmoneyListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListmoneyListD1)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalmoneylistd1e2m(
	id,
    value,
    nullablevalue,
    decimalmoneylistd1e2mi_id
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
    decimalmoneylistd1e2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(DecimalmoneyListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListmoneyListD1)),
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
                methodParametrName: "decimalmoneylistd1e2mi_id", 
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
                List<DecimalmoneyListD1E2M> models = null;

                models =  ((IDecimalListmoneyListD1)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalmoneyListD1E2M.AssertModel(models[0],_testData[4], true);
                models =  ((IDecimalListmoneyListD1)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalmoneyListD1E2M.AssertModel(models[0],_testData[5], true);
                models =  ((IDecimalListmoneyListD1)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalmoneyListD1E2M.AssertModel(models[0],_testData[6], true);
                models =  ((IDecimalListmoneyListD1)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalmoneyListD1E2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<DecimalmoneyListD1E2M> models = null;

                models = await ((IDecimalListmoneyListD1)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalmoneyListD1E2M.AssertModel(models[0],_testData[8], true);
                models = await ((IDecimalListmoneyListD1)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalmoneyListD1E2M.AssertModel(models[0],_testData[9], true);
                models = await ((IDecimalListmoneyListD1)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalmoneyListD1E2M.AssertModel(models[0],_testData[10], true);
                models = await ((IDecimalListmoneyListD1)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalmoneyListD1E2M.AssertModel(models[0],_testData[11], true);
                models = await ((IDecimalListmoneyListD1)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalmoneyListD1E2M.AssertModel(models[0],_testData[12], true);
                models = await ((IDecimalListmoneyListD1)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalmoneyListD1E2M.AssertModel(models[0],_testData[13], true);
                models = await ((IDecimalListmoneyListD1)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalmoneyListD1E2M.AssertModel(models[0],_testData[14], true);
                models = await ((IDecimalListmoneyListD1)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalmoneyListD1E2M.AssertModel(models[0],_testData[15], true);
                models = await ((IDecimalListmoneyListD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalmoneyListD1E2M.AssertModel(models[0],_testData[16], true);
                models = await ((IDecimalListmoneyListD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalmoneyListD1E2M.AssertModel(models[0],_testData[17], true);
                models = await ((IDecimalListmoneyListD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalmoneyListD1E2M.AssertModel(models[0],_testData[18], true);
                models = await ((IDecimalListmoneyListD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalmoneyListD1E2M.AssertModel(models[0],_testData[19], true);
                models = await ((IDecimalListmoneyListD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalmoneyListD1E2M.AssertModel(models[0],_testData[20], true);
                models = await ((IDecimalListmoneyListD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalmoneyListD1E2M.AssertModel(models[0],_testData[21], true);
                models = await ((IDecimalListmoneyListD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalmoneyListD1E2M.AssertModel(models[0],_testData[22], true);
                models = await ((IDecimalListmoneyListD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalmoneyListD1E2M.AssertModel(models[0],_testData[23], true);
                models = await ((IDecimalListmoneyListD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalmoneyListD1E2M.AssertModel(models[0],_testData[24], true);
                models = await ((IDecimalListmoneyListD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalmoneyListD1E2M.AssertModel(models[0],_testData[25], true);
                models = await ((IDecimalListmoneyListD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalmoneyListD1E2M.AssertModel(models[0],_testData[26], true);
                models = await ((IDecimalListmoneyListD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalmoneyListD1E2M.AssertModel(models[0],_testData[27], true);
                models = await ((IDecimalListmoneyListD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalmoneyListD1E2M.AssertModel(models[0],_testData[28], true);
                models = await ((IDecimalListmoneyListD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalmoneyListD1E2M.AssertModel(models[0],_testData[29], true);
                models = await ((IDecimalListmoneyListD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalmoneyListD1E2M.AssertModel(models[0],_testData[30], true);
                models = await ((IDecimalListmoneyListD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalmoneyListD1E2M.AssertModel(models[0],_testData[31], true);
                models = await ((IDecimalListmoneyListD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalmoneyListD1E2M.AssertModel(models[0],_testData[32], true);
                models = await ((IDecimalListmoneyListD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalmoneyListD1E2M.AssertModel(models[0],_testData[33], true);
                models = await ((IDecimalListmoneyListD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalmoneyListD1E2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalmoneyListD1E2M), typeof(FlatDecimalmoneyListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListmoneyListD1)),
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
FROM public.decimalmoneylistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDecimalmoneyListD1E2M>();
                var models2 = new List<FlatDecimalmoneyListD1E2M>();
                await ((IDecimalListmoneyListD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalmoneyListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalmoneyListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.decimalmoneylistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDecimalmoneyListD1E2M>();
                var models2 = new List<FlatDecimalmoneyListD1E2M>();
                ((IDecimalListmoneyListD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalmoneyListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalmoneyListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalmoneyListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListmoneyListD1)),
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
FROM public.decimalmoneylistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IDecimalListmoneyListD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalmoneyListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalmoneylistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IDecimalListmoneyListD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalmoneyListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalmoneylistd1e2m m
LEFT JOIN public.decimalmoneylistd1e2mi mi ON mi.id = m.decimalmoneylistd1e2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(DecimalmoneyListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListmoneyListD1)),
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
                var models = await ((IDecimalListmoneyListD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalmoneyListD1E2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IDecimalListmoneyListD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalmoneyListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalmoneyListD1E2M), typeof(FlatDecimalmoneyListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListmoneyListD1)),
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
FROM public.decimalmoneylistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalmoneyListD1E2M>();
                var models2 = new List<FlatDecimalmoneyListD1E2M>();
                await ((IDecimalListmoneyListD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalmoneyListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalmoneyListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.decimalmoneylistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalmoneyListD1E2M>();
                var models2 = new List<FlatDecimalmoneyListD1E2M>();
                ((IDecimalListmoneyListD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalmoneyListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalmoneyListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalmoneyListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListmoneyListD1)),
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
FROM public.decimalmoneylistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IDecimalListmoneyListD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalmoneyListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalmoneylistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IDecimalListmoneyListD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalmoneyListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalmoneylistd1e2m m
LEFT JOIN public.decimalmoneylistd1e2mi mi ON mi.id = m.decimalmoneylistd1e2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(DecimalmoneyListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListmoneyListD1)),
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
                var models = await ((IDecimalListmoneyListD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalmoneyListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IDecimalListmoneyListD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalmoneyListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalmoneyListD1E2M), typeof(FlatDecimalmoneyListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListmoneyListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListmoneyListD1)),
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
            asPartInterface: typeof(IDecimalListmoneyListD1)),
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
FROM public.decimalmoneylistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDecimalmoneyListD1E2M>();
                var models2 = new List<FlatDecimalmoneyListD1E2M>();
                await((IDecimalListmoneyListD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalmoneyListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalmoneyListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 101;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 36;
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
FROM public.decimalmoneylistd1e2m m
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
FROM public.decimalmoneylistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalmoneyListD1E2M>();
                var firstItems2 = new List<FlatDecimalmoneyListD1E2M>();
                var secondItems1 = new List<FlatDecimalmoneyListD1E2M>();
                var secondItems2 = new List<FlatDecimalmoneyListD1E2M>();
                await ((IDecimalListmoneyListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[27],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 13;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 121;
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
FROM public.decimalmoneylistd1e2m m
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
FROM public.decimalmoneylistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalmoneyListD1E2M>();
                var firstItems2 = new List<FlatDecimalmoneyListD1E2M>();
                var secondItems1 = new List<FlatDecimalmoneyListD1E2M>();
                await ((IDecimalListmoneyListD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[8],_testData[34], false);
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
FROM public.decimalmoneylistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDecimalmoneyListD1E2M>();
                var models2 = new List<FlatDecimalmoneyListD1E2M>();
                ((IDecimalListmoneyListD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalmoneyListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalmoneyListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 59;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 104;
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
FROM public.decimalmoneylistd1e2m m
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
FROM public.decimalmoneylistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalmoneyListD1E2M>();
                var firstItems2 = new List<FlatDecimalmoneyListD1E2M>();
                var secondItems1 = new List<FlatDecimalmoneyListD1E2M>();
                var secondItems2 = new List<FlatDecimalmoneyListD1E2M>();
                 ((IDecimalListmoneyListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[12],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 121;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 81;
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
FROM public.decimalmoneylistd1e2m m
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
FROM public.decimalmoneylistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalmoneyListD1E2M>();
                var firstItems2 = new List<FlatDecimalmoneyListD1E2M>();
                var secondItems1 = new List<FlatDecimalmoneyListD1E2M>();
                 ((IDecimalListmoneyListD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[17],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalmoneyListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListmoneyListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListmoneyListD1)),
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
            asPartInterface: typeof(IDecimalListmoneyListD1)),
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
FROM public.decimalmoneylistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IDecimalListmoneyListD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalmoneyListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 13;
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
FROM public.decimalmoneylistd1e2m m
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
FROM public.decimalmoneylistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalListmoneyListD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatDecimalmoneyListD1E2M.AssertModel(models[0],_testData[2], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[1],_testData[3], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[2],_testData[4], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[3],_testData[5], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[4],_testData[6], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[5],_testData[7], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[6],_testData[8], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[7],_testData[9], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[8],_testData[10], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[9],_testData[11], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[10],_testData[12], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[11],_testData[13], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[12],_testData[14], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[13],_testData[15], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[14],_testData[16], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[15],_testData[17], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[16],_testData[18], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[17],_testData[19], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[18],_testData[20], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[19],_testData[21], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[20],_testData[22], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[21],_testData[23], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[22],_testData[24], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[23],_testData[25], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[24],_testData[26], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[25],_testData[27], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[26],_testData[28], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[27],_testData[29], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[28],_testData[30], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[29],_testData[31], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[30],_testData[32], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[31],_testData[33], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatDecimalmoneyListD1E2M.AssertModel(models[0],_testData[2], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[1],_testData[3], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[2],_testData[4], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[3],_testData[5], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[4],_testData[6], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[5],_testData[7], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[6],_testData[8], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[7],_testData[9], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[8],_testData[10], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[9],_testData[11], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[10],_testData[12], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[11],_testData[13], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[12],_testData[14], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[13],_testData[15], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[14],_testData[16], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[15],_testData[17], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[16],_testData[18], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[17],_testData[19], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[18],_testData[20], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[19],_testData[21], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[20],_testData[22], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[21],_testData[23], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[22],_testData[24], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[23],_testData[25], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[24],_testData[26], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[25],_testData[27], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[26],_testData[28], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[27],_testData[29], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[28],_testData[30], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[29],_testData[31], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[30],_testData[32], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[31],_testData[33], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[32],_testData[34], false);
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 127;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 137;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalmoneylistd1e2m m
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
FROM public.decimalmoneylistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalmoneyListD1E2M>();
                var secondItems1 = new List<FlatDecimalmoneyListD1E2M>();
                var secondItems2 = new List<FlatDecimalmoneyListD1E2M>();
                await ((IDecimalListmoneyListD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[4],_testData[34], false);
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
FROM public.decimalmoneylistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IDecimalListmoneyListD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalmoneyListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 104;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 117;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalmoneylistd1e2m m
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
FROM public.decimalmoneylistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalListmoneyListD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatDecimalmoneyListD1E2M.AssertModel(models[0],_testData[22], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[1],_testData[23], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[2],_testData[24], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[3],_testData[25], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[4],_testData[26], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[5],_testData[27], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[6],_testData[28], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[7],_testData[29], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[8],_testData[30], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[9],_testData[31], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[10],_testData[32], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[11],_testData[33], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatDecimalmoneyListD1E2M.AssertModel(models[0],_testData[25], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[1],_testData[26], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[2],_testData[27], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[3],_testData[28], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[4],_testData[29], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[5],_testData[30], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[6],_testData[31], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[7],_testData[32], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[8],_testData[33], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[9],_testData[34], false);
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 73;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 23;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalmoneylistd1e2m m
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
FROM public.decimalmoneylistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalmoneyListD1E2M>();
                var secondItems1 = new List<FlatDecimalmoneyListD1E2M>();
                var secondItems2 = new List<FlatDecimalmoneyListD1E2M>();
                 ((IDecimalListmoneyListD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[30],_testData[34], false);
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
FROM public.decimalmoneylistd1e2m m
LEFT JOIN public.decimalmoneylistd1e2mi mi ON mi.id = m.decimalmoneylistd1e2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(DecimalmoneyListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListmoneyListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListmoneyListD1)),
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
                var models = await((IDecimalListmoneyListD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalmoneyListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTSelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 107;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 59;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalListmoneyListD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        DecimalmoneyListD1E2M.AssertModel(models[0],_testData[23], false);
                        DecimalmoneyListD1E2M.AssertModel(models[1],_testData[24], false);
                        DecimalmoneyListD1E2M.AssertModel(models[2],_testData[25], false);
                        DecimalmoneyListD1E2M.AssertModel(models[3],_testData[26], false);
                        DecimalmoneyListD1E2M.AssertModel(models[4],_testData[27], false);
                        DecimalmoneyListD1E2M.AssertModel(models[5],_testData[28], false);
                        DecimalmoneyListD1E2M.AssertModel(models[6],_testData[29], false);
                        DecimalmoneyListD1E2M.AssertModel(models[7],_testData[30], false);
                        DecimalmoneyListD1E2M.AssertModel(models[8],_testData[31], false);
                        DecimalmoneyListD1E2M.AssertModel(models[9],_testData[32], false);
                        DecimalmoneyListD1E2M.AssertModel(models[10],_testData[33], false);
                        DecimalmoneyListD1E2M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        DecimalmoneyListD1E2M.AssertModel(models[0],_testData[12], false);
                        DecimalmoneyListD1E2M.AssertModel(models[1],_testData[13], false);
                        DecimalmoneyListD1E2M.AssertModel(models[2],_testData[14], false);
                        DecimalmoneyListD1E2M.AssertModel(models[3],_testData[15], false);
                        DecimalmoneyListD1E2M.AssertModel(models[4],_testData[16], false);
                        DecimalmoneyListD1E2M.AssertModel(models[5],_testData[17], false);
                        DecimalmoneyListD1E2M.AssertModel(models[6],_testData[18], false);
                        DecimalmoneyListD1E2M.AssertModel(models[7],_testData[19], false);
                        DecimalmoneyListD1E2M.AssertModel(models[8],_testData[20], false);
                        DecimalmoneyListD1E2M.AssertModel(models[9],_testData[21], false);
                        DecimalmoneyListD1E2M.AssertModel(models[10],_testData[22], false);
                        DecimalmoneyListD1E2M.AssertModel(models[11],_testData[23], false);
                        DecimalmoneyListD1E2M.AssertModel(models[12],_testData[24], false);
                        DecimalmoneyListD1E2M.AssertModel(models[13],_testData[25], false);
                        DecimalmoneyListD1E2M.AssertModel(models[14],_testData[26], false);
                        DecimalmoneyListD1E2M.AssertModel(models[15],_testData[27], false);
                        DecimalmoneyListD1E2M.AssertModel(models[16],_testData[28], false);
                        DecimalmoneyListD1E2M.AssertModel(models[17],_testData[29], false);
                        DecimalmoneyListD1E2M.AssertModel(models[18],_testData[30], false);
                        DecimalmoneyListD1E2M.AssertModel(models[19],_testData[31], false);
                        DecimalmoneyListD1E2M.AssertModel(models[20],_testData[32], false);
                        DecimalmoneyListD1E2M.AssertModel(models[21],_testData[33], false);
                        DecimalmoneyListD1E2M.AssertModel(models[22],_testData[34], false);
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
                var models = ((IDecimalListmoneyListD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalmoneyListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTSelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 137;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 127;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalListmoneyListD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        DecimalmoneyListD1E2M.AssertModel(models[0],_testData[30], false);
                        DecimalmoneyListD1E2M.AssertModel(models[1],_testData[31], false);
                        DecimalmoneyListD1E2M.AssertModel(models[2],_testData[32], false);
                        DecimalmoneyListD1E2M.AssertModel(models[3],_testData[33], false);
                        DecimalmoneyListD1E2M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        DecimalmoneyListD1E2M.AssertModel(models[0],_testData[27], false);
                        DecimalmoneyListD1E2M.AssertModel(models[1],_testData[28], false);
                        DecimalmoneyListD1E2M.AssertModel(models[2],_testData[29], false);
                        DecimalmoneyListD1E2M.AssertModel(models[3],_testData[30], false);
                        DecimalmoneyListD1E2M.AssertModel(models[4],_testData[31], false);
                        DecimalmoneyListD1E2M.AssertModel(models[5],_testData[32], false);
                        DecimalmoneyListD1E2M.AssertModel(models[6],_testData[33], false);
                        DecimalmoneyListD1E2M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalmoneyListD1E2M), typeof(FlatDecimalmoneyListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListmoneyListD1)),
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
            asPartInterface: typeof(IDecimalListmoneyListD1)),
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
            asPartInterface: typeof(IDecimalListmoneyListD1)),
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
FROM public.decimalmoneylistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalmoneyListD1E2M>();
                var models2 = new List<FlatDecimalmoneyListD1E2M>();
                await((IDecimalListmoneyListD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalmoneyListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalmoneyListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.decimalmoneylistd1e2m m
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
FROM public.decimalmoneylistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalmoneyListD1E2M>();
                var firstItems2 = new List<FlatDecimalmoneyListD1E2M>();
                var secondItems1 = new List<FlatDecimalmoneyListD1E2M>();
                var secondItems2 = new List<FlatDecimalmoneyListD1E2M>();
                await ((IDecimalListmoneyListD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 132, query1, 114, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[10],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.decimalmoneylistd1e2m m
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
FROM public.decimalmoneylistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalmoneyListD1E2M>();
                var firstItems2 = new List<FlatDecimalmoneyListD1E2M>();
                var secondItems1 = new List<FlatDecimalmoneyListD1E2M>();
                await ((IDecimalListmoneyListD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 33, query1, 92, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[15],_testData[34], false);
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
FROM public.decimalmoneylistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalmoneyListD1E2M>();
                var models2 = new List<FlatDecimalmoneyListD1E2M>();
                ((IDecimalListmoneyListD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalmoneyListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalmoneyListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.decimalmoneylistd1e2m m
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
FROM public.decimalmoneylistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalmoneyListD1E2M>();
                var firstItems2 = new List<FlatDecimalmoneyListD1E2M>();
                var secondItems1 = new List<FlatDecimalmoneyListD1E2M>();
                var secondItems2 = new List<FlatDecimalmoneyListD1E2M>();
                 ((IDecimalListmoneyListD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 137, query1, 65, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[21],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.decimalmoneylistd1e2m m
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
FROM public.decimalmoneylistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalmoneyListD1E2M>();
                var firstItems2 = new List<FlatDecimalmoneyListD1E2M>();
                var secondItems1 = new List<FlatDecimalmoneyListD1E2M>();
                 ((IDecimalListmoneyListD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 101, query1, 5, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[33],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalmoneyListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListmoneyListD1)),
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
            asPartInterface: typeof(IDecimalListmoneyListD1)),
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
            asPartInterface: typeof(IDecimalListmoneyListD1)),
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
FROM public.decimalmoneylistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IDecimalListmoneyListD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalmoneyListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalmoneylistd1e2m m
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
FROM public.decimalmoneylistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalListmoneyListD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 33, query1, 33, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatDecimalmoneyListD1E2M.AssertModel(models[0],_testData[6], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[1],_testData[7], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[2],_testData[8], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[3],_testData[9], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[4],_testData[10], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[5],_testData[11], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[6],_testData[12], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[7],_testData[13], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[8],_testData[14], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[9],_testData[15], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[10],_testData[16], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[11],_testData[17], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[12],_testData[18], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[13],_testData[19], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[14],_testData[20], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[15],_testData[21], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[16],_testData[22], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[17],_testData[23], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[18],_testData[24], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[19],_testData[25], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[20],_testData[26], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[21],_testData[27], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[22],_testData[28], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[23],_testData[29], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[24],_testData[30], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[25],_testData[31], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[26],_testData[32], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[27],_testData[33], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatDecimalmoneyListD1E2M.AssertModel(models[0],_testData[6], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[1],_testData[7], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[2],_testData[8], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[3],_testData[9], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[4],_testData[10], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[5],_testData[11], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[6],_testData[12], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[7],_testData[13], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[8],_testData[14], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[9],_testData[15], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[10],_testData[16], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[11],_testData[17], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[12],_testData[18], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[13],_testData[19], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[14],_testData[20], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[15],_testData[21], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[16],_testData[22], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[17],_testData[23], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[18],_testData[24], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[19],_testData[25], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[20],_testData[26], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[21],_testData[27], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[22],_testData[28], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[23],_testData[29], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[24],_testData[30], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[25],_testData[31], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[26],_testData[32], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[27],_testData[33], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[28],_testData[34], false);
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
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalmoneylistd1e2m m
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
FROM public.decimalmoneylistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalmoneyListD1E2M>();
                var secondItems1 = new List<FlatDecimalmoneyListD1E2M>();
                var secondItems2 = new List<FlatDecimalmoneyListD1E2M>();
                await ((IDecimalListmoneyListD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 117, query1, 73, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[19],_testData[34], false);
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
FROM public.decimalmoneylistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IDecimalListmoneyListD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalmoneyListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalmoneylistd1e2m m
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
FROM public.decimalmoneylistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalListmoneyListD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 104, query1, 121, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatDecimalmoneyListD1E2M.AssertModel(models[0],_testData[22], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[1],_testData[23], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[2],_testData[24], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[3],_testData[25], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[4],_testData[26], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[5],_testData[27], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[6],_testData[28], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[7],_testData[29], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[8],_testData[30], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[9],_testData[31], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[10],_testData[32], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[11],_testData[33], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatDecimalmoneyListD1E2M.AssertModel(models[0],_testData[26], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[1],_testData[27], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[2],_testData[28], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[3],_testData[29], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[4],_testData[30], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[5],_testData[31], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[6],_testData[32], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[7],_testData[33], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(models[8],_testData[34], false);
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
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalmoneylistd1e2m m
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
FROM public.decimalmoneylistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalmoneyListD1E2M>();
                var secondItems1 = new List<FlatDecimalmoneyListD1E2M>();
                var secondItems2 = new List<FlatDecimalmoneyListD1E2M>();
                 ((IDecimalListmoneyListD1)this).DbConnectionDynQuerySelectModelBatch(connection, 104, query1, 50, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(firstItems1[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatDecimalmoneyListD1E2M.AssertModel(secondItems2[24],_testData[34], false);
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
FROM public.decimalmoneylistd1e2m m
LEFT JOIN public.decimalmoneylistd1e2mi mi ON mi.id = m.decimalmoneylistd1e2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(DecimalmoneyListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListmoneyListD1)),
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
            asPartInterface: typeof(IDecimalListmoneyListD1)),
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
                var models = await((IDecimalListmoneyListD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalmoneyListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IDecimalListmoneyListD1)this).DbConnectionSTSelectModelBatchAsync(connection, 101, 33))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        DecimalmoneyListD1E2M.AssertModel(models[0],_testData[21], false);
                        DecimalmoneyListD1E2M.AssertModel(models[1],_testData[22], false);
                        DecimalmoneyListD1E2M.AssertModel(models[2],_testData[23], false);
                        DecimalmoneyListD1E2M.AssertModel(models[3],_testData[24], false);
                        DecimalmoneyListD1E2M.AssertModel(models[4],_testData[25], false);
                        DecimalmoneyListD1E2M.AssertModel(models[5],_testData[26], false);
                        DecimalmoneyListD1E2M.AssertModel(models[6],_testData[27], false);
                        DecimalmoneyListD1E2M.AssertModel(models[7],_testData[28], false);
                        DecimalmoneyListD1E2M.AssertModel(models[8],_testData[29], false);
                        DecimalmoneyListD1E2M.AssertModel(models[9],_testData[30], false);
                        DecimalmoneyListD1E2M.AssertModel(models[10],_testData[31], false);
                        DecimalmoneyListD1E2M.AssertModel(models[11],_testData[32], false);
                        DecimalmoneyListD1E2M.AssertModel(models[12],_testData[33], false);
                        DecimalmoneyListD1E2M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        DecimalmoneyListD1E2M.AssertModel(models[0],_testData[6], false);
                        DecimalmoneyListD1E2M.AssertModel(models[1],_testData[7], false);
                        DecimalmoneyListD1E2M.AssertModel(models[2],_testData[8], false);
                        DecimalmoneyListD1E2M.AssertModel(models[3],_testData[9], false);
                        DecimalmoneyListD1E2M.AssertModel(models[4],_testData[10], false);
                        DecimalmoneyListD1E2M.AssertModel(models[5],_testData[11], false);
                        DecimalmoneyListD1E2M.AssertModel(models[6],_testData[12], false);
                        DecimalmoneyListD1E2M.AssertModel(models[7],_testData[13], false);
                        DecimalmoneyListD1E2M.AssertModel(models[8],_testData[14], false);
                        DecimalmoneyListD1E2M.AssertModel(models[9],_testData[15], false);
                        DecimalmoneyListD1E2M.AssertModel(models[10],_testData[16], false);
                        DecimalmoneyListD1E2M.AssertModel(models[11],_testData[17], false);
                        DecimalmoneyListD1E2M.AssertModel(models[12],_testData[18], false);
                        DecimalmoneyListD1E2M.AssertModel(models[13],_testData[19], false);
                        DecimalmoneyListD1E2M.AssertModel(models[14],_testData[20], false);
                        DecimalmoneyListD1E2M.AssertModel(models[15],_testData[21], false);
                        DecimalmoneyListD1E2M.AssertModel(models[16],_testData[22], false);
                        DecimalmoneyListD1E2M.AssertModel(models[17],_testData[23], false);
                        DecimalmoneyListD1E2M.AssertModel(models[18],_testData[24], false);
                        DecimalmoneyListD1E2M.AssertModel(models[19],_testData[25], false);
                        DecimalmoneyListD1E2M.AssertModel(models[20],_testData[26], false);
                        DecimalmoneyListD1E2M.AssertModel(models[21],_testData[27], false);
                        DecimalmoneyListD1E2M.AssertModel(models[22],_testData[28], false);
                        DecimalmoneyListD1E2M.AssertModel(models[23],_testData[29], false);
                        DecimalmoneyListD1E2M.AssertModel(models[24],_testData[30], false);
                        DecimalmoneyListD1E2M.AssertModel(models[25],_testData[31], false);
                        DecimalmoneyListD1E2M.AssertModel(models[26],_testData[32], false);
                        DecimalmoneyListD1E2M.AssertModel(models[27],_testData[33], false);
                        DecimalmoneyListD1E2M.AssertModel(models[28],_testData[34], false);
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
                var models = ((IDecimalListmoneyListD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalmoneyListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IDecimalListmoneyListD1)this).DbConnectionSTSelectModelBatch(connection, 65, 73))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        DecimalmoneyListD1E2M.AssertModel(models[0],_testData[13], false);
                        DecimalmoneyListD1E2M.AssertModel(models[1],_testData[14], false);
                        DecimalmoneyListD1E2M.AssertModel(models[2],_testData[15], false);
                        DecimalmoneyListD1E2M.AssertModel(models[3],_testData[16], false);
                        DecimalmoneyListD1E2M.AssertModel(models[4],_testData[17], false);
                        DecimalmoneyListD1E2M.AssertModel(models[5],_testData[18], false);
                        DecimalmoneyListD1E2M.AssertModel(models[6],_testData[19], false);
                        DecimalmoneyListD1E2M.AssertModel(models[7],_testData[20], false);
                        DecimalmoneyListD1E2M.AssertModel(models[8],_testData[21], false);
                        DecimalmoneyListD1E2M.AssertModel(models[9],_testData[22], false);
                        DecimalmoneyListD1E2M.AssertModel(models[10],_testData[23], false);
                        DecimalmoneyListD1E2M.AssertModel(models[11],_testData[24], false);
                        DecimalmoneyListD1E2M.AssertModel(models[12],_testData[25], false);
                        DecimalmoneyListD1E2M.AssertModel(models[13],_testData[26], false);
                        DecimalmoneyListD1E2M.AssertModel(models[14],_testData[27], false);
                        DecimalmoneyListD1E2M.AssertModel(models[15],_testData[28], false);
                        DecimalmoneyListD1E2M.AssertModel(models[16],_testData[29], false);
                        DecimalmoneyListD1E2M.AssertModel(models[17],_testData[30], false);
                        DecimalmoneyListD1E2M.AssertModel(models[18],_testData[31], false);
                        DecimalmoneyListD1E2M.AssertModel(models[19],_testData[32], false);
                        DecimalmoneyListD1E2M.AssertModel(models[20],_testData[33], false);
                        DecimalmoneyListD1E2M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        DecimalmoneyListD1E2M.AssertModel(models[0],_testData[15], false);
                        DecimalmoneyListD1E2M.AssertModel(models[1],_testData[16], false);
                        DecimalmoneyListD1E2M.AssertModel(models[2],_testData[17], false);
                        DecimalmoneyListD1E2M.AssertModel(models[3],_testData[18], false);
                        DecimalmoneyListD1E2M.AssertModel(models[4],_testData[19], false);
                        DecimalmoneyListD1E2M.AssertModel(models[5],_testData[20], false);
                        DecimalmoneyListD1E2M.AssertModel(models[6],_testData[21], false);
                        DecimalmoneyListD1E2M.AssertModel(models[7],_testData[22], false);
                        DecimalmoneyListD1E2M.AssertModel(models[8],_testData[23], false);
                        DecimalmoneyListD1E2M.AssertModel(models[9],_testData[24], false);
                        DecimalmoneyListD1E2M.AssertModel(models[10],_testData[25], false);
                        DecimalmoneyListD1E2M.AssertModel(models[11],_testData[26], false);
                        DecimalmoneyListD1E2M.AssertModel(models[12],_testData[27], false);
                        DecimalmoneyListD1E2M.AssertModel(models[13],_testData[28], false);
                        DecimalmoneyListD1E2M.AssertModel(models[14],_testData[29], false);
                        DecimalmoneyListD1E2M.AssertModel(models[15],_testData[30], false);
                        DecimalmoneyListD1E2M.AssertModel(models[16],_testData[31], false);
                        DecimalmoneyListD1E2M.AssertModel(models[17],_testData[32], false);
                        DecimalmoneyListD1E2M.AssertModel(models[18],_testData[33], false);
                        DecimalmoneyListD1E2M.AssertModel(models[19],_testData[34], false);
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
                await using var cmd = await ((IDecimalListmoneyListD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IDecimalListmoneyListD1)this).SetDbConnectionSelectModelParametrs(cmd, 36);
                var models = await ((IDecimalListmoneyListD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(28));

                DecimalmoneyListD1E2M.AssertModel(models[0],_testData[7], false);
                DecimalmoneyListD1E2M.AssertModel(models[1],_testData[8], false);
                DecimalmoneyListD1E2M.AssertModel(models[2],_testData[9], false);
                DecimalmoneyListD1E2M.AssertModel(models[3],_testData[10], false);
                DecimalmoneyListD1E2M.AssertModel(models[4],_testData[11], false);
                DecimalmoneyListD1E2M.AssertModel(models[5],_testData[12], false);
                DecimalmoneyListD1E2M.AssertModel(models[6],_testData[13], false);
                DecimalmoneyListD1E2M.AssertModel(models[7],_testData[14], false);
                DecimalmoneyListD1E2M.AssertModel(models[8],_testData[15], false);
                DecimalmoneyListD1E2M.AssertModel(models[9],_testData[16], false);
                DecimalmoneyListD1E2M.AssertModel(models[10],_testData[17], false);
                DecimalmoneyListD1E2M.AssertModel(models[11],_testData[18], false);
                DecimalmoneyListD1E2M.AssertModel(models[12],_testData[19], false);
                DecimalmoneyListD1E2M.AssertModel(models[13],_testData[20], false);
                DecimalmoneyListD1E2M.AssertModel(models[14],_testData[21], false);
                DecimalmoneyListD1E2M.AssertModel(models[15],_testData[22], false);
                DecimalmoneyListD1E2M.AssertModel(models[16],_testData[23], false);
                DecimalmoneyListD1E2M.AssertModel(models[17],_testData[24], false);
                DecimalmoneyListD1E2M.AssertModel(models[18],_testData[25], false);
                DecimalmoneyListD1E2M.AssertModel(models[19],_testData[26], false);
                DecimalmoneyListD1E2M.AssertModel(models[20],_testData[27], false);
                DecimalmoneyListD1E2M.AssertModel(models[21],_testData[28], false);
                DecimalmoneyListD1E2M.AssertModel(models[22],_testData[29], false);
                DecimalmoneyListD1E2M.AssertModel(models[23],_testData[30], false);
                DecimalmoneyListD1E2M.AssertModel(models[24],_testData[31], false);
                DecimalmoneyListD1E2M.AssertModel(models[25],_testData[32], false);
                DecimalmoneyListD1E2M.AssertModel(models[26],_testData[33], false);
                DecimalmoneyListD1E2M.AssertModel(models[27],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDecimalListmoneyListD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDecimalListmoneyListD1)this).SetDbConnectionSelectModelParametrs(cmd, 67);
                var models =  ((IDecimalListmoneyListD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(21));

                DecimalmoneyListD1E2M.AssertModel(models[0],_testData[14], false);
                DecimalmoneyListD1E2M.AssertModel(models[1],_testData[15], false);
                DecimalmoneyListD1E2M.AssertModel(models[2],_testData[16], false);
                DecimalmoneyListD1E2M.AssertModel(models[3],_testData[17], false);
                DecimalmoneyListD1E2M.AssertModel(models[4],_testData[18], false);
                DecimalmoneyListD1E2M.AssertModel(models[5],_testData[19], false);
                DecimalmoneyListD1E2M.AssertModel(models[6],_testData[20], false);
                DecimalmoneyListD1E2M.AssertModel(models[7],_testData[21], false);
                DecimalmoneyListD1E2M.AssertModel(models[8],_testData[22], false);
                DecimalmoneyListD1E2M.AssertModel(models[9],_testData[23], false);
                DecimalmoneyListD1E2M.AssertModel(models[10],_testData[24], false);
                DecimalmoneyListD1E2M.AssertModel(models[11],_testData[25], false);
                DecimalmoneyListD1E2M.AssertModel(models[12],_testData[26], false);
                DecimalmoneyListD1E2M.AssertModel(models[13],_testData[27], false);
                DecimalmoneyListD1E2M.AssertModel(models[14],_testData[28], false);
                DecimalmoneyListD1E2M.AssertModel(models[15],_testData[29], false);
                DecimalmoneyListD1E2M.AssertModel(models[16],_testData[30], false);
                DecimalmoneyListD1E2M.AssertModel(models[17],_testData[31], false);
                DecimalmoneyListD1E2M.AssertModel(models[18],_testData[32], false);
                DecimalmoneyListD1E2M.AssertModel(models[19],_testData[33], false);
                DecimalmoneyListD1E2M.AssertModel(models[20],_testData[34], false);
            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.DbConnection.Attributes.Query(
            query: 
@"
SELECT
    mi.nullablevalue,
    mi.id,
    mi.value
FROM public.binary_decimalmoneylistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(DecimalmoneyListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListmoneyListD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(DecimalmoneyListD1E2MIWA),
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
            asPartInterface: typeof(IDecimalListmoneyListD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalmoneyListD1E2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalmoneyListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDecimalListmoneyListD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_decimalmoneylistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDecimalListmoneyListD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalmoneyListD1E2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(1)]
        public  void DynQueryWAImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<DecimalmoneyListD1E2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalmoneyListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDecimalListmoneyListD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_decimalmoneylistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDecimalListmoneyListD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalmoneyListD1E2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: 
@"
SELECT
    mi.nullablevalue,
    mi.id,
    mi.value
FROM public.binary_decimalmoneylistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(DecimalmoneyListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListmoneyListD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(DecimalmoneyListD1E2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListmoneyListD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalmoneyListD1E2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalmoneyListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDecimalListmoneyListD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_decimalmoneylistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDecimalListmoneyListD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalmoneyListD1E2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(3)]
        public  void DynQueryImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<DecimalmoneyListD1E2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalmoneyListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDecimalListmoneyListD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_decimalmoneylistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDecimalListmoneyListD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalmoneyListD1E2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: 
@"
SELECT
    mi.nullablevalue,
    mi.id,
    mi.value
FROM public.binary_decimalmoneylistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(DecimalmoneyListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListmoneyListD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_decimalmoneylistd1e2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(DecimalmoneyListD1E2MI),
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
            asPartInterface: typeof(IDecimalListmoneyListD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalmoneyListD1E2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IDecimalListmoneyListD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IDecimalListmoneyListD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalmoneyListD1E2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(5)]
        public  void WAImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<DecimalmoneyListD1E2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IDecimalListmoneyListD1)this).WAImportModelInner(connection, importCollection);
                var models = ((IDecimalListmoneyListD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalmoneyListD1E2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: 
@"
SELECT
    mi.nullablevalue,
    mi.id,
    mi.value
FROM public.binary_decimalmoneylistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(DecimalmoneyListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListmoneyListD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_decimalmoneylistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(DecimalmoneyListD1E2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListmoneyListD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalmoneyListD1E2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalmoneyListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDecimalListmoneyListD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IDecimalListmoneyListD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalmoneyListD1E2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(7)]
        public  void ImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<DecimalmoneyListD1E2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalmoneyListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDecimalListmoneyListD1)this).ImportModelInner(connection, importCollection);
                var models = ((IDecimalListmoneyListD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalmoneyListD1E2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_decimalmoneylistd1e2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
decimalmoneylistd1e2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(DecimalmoneyListD1E2M),
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
            asPartInterface: typeof(IDecimalListmoneyListD1))]
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
FROM public.binary_decimalmoneylistd1e2m m
LEFT JOIN public.binary_decimalmoneylistd1e2mi mi ON mi.id = m.decimalmoneylistd1e2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(DecimalmoneyListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListmoneyListD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalmoneyListD1E2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IDecimalListmoneyListD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((IDecimalListmoneyListD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    DecimalmoneyListD1E2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(10)]
        public  void ImportModelTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<DecimalmoneyListD1E2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IDecimalListmoneyListD1)this).ImportModel(connection, importCollection);
                var models = ((IDecimalListmoneyListD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    DecimalmoneyListD1E2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_decimalmoneylistd1e2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    decimalmoneylistd1e2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(DecimalmoneyListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListmoneyListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483636),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483636)
            })]
        private void ExportModelConfig()
        {
        }

        [Test, Order(13)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IDecimalListmoneyListD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    DecimalmoneyListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDecimalListmoneyListD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    DecimalmoneyListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(DecimalmoneyListD1E2MIWA), typeof(DecimalmoneyListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListmoneyListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483636),
                (NpgsqlTypes.NpgsqlDbType)(-2147483636)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483636),
                (NpgsqlTypes.NpgsqlDbType)(-2147483636)
            })]
        private void MMDynQueryWAExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task MMDynQueryWAExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<DecimalmoneyListD1E2MIWA>();
                var models2 = new List<DecimalmoneyListD1E2MIWA>();
                await ((IDecimalListmoneyListD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_decimalmoneylistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalmoneyListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalmoneyListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void MMDynQueryWAExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<DecimalmoneyListD1E2MIWA>();
                var models2 = new List<DecimalmoneyListD1E2MIWA>();
                ((IDecimalListmoneyListD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_decimalmoneylistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalmoneyListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalmoneyListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(DecimalmoneyListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListmoneyListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483636),
                (NpgsqlTypes.NpgsqlDbType)(-2147483636)
            })]
        private void DynQueryWAExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task DynQueryWAExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = await ((IDecimalListmoneyListD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_decimalmoneylistd1e2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalmoneyListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void DynQueryWAExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = ((IDecimalListmoneyListD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_decimalmoneylistd1e2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalmoneyListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(DecimalmoneyListD1E2MIWA), typeof(DecimalmoneyListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListmoneyListD1))]
        private void MMDynQueryExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task MMDynQueryExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<DecimalmoneyListD1E2MIWA>();
                var models2 = new List<DecimalmoneyListD1E2MIWA>();
                await ((IDecimalListmoneyListD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_decimalmoneylistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalmoneyListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalmoneyListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void MMDynQueryExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<DecimalmoneyListD1E2MIWA>();
                var models2 = new List<DecimalmoneyListD1E2MIWA>();
                ((IDecimalListmoneyListD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_decimalmoneylistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalmoneyListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalmoneyListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(DecimalmoneyListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListmoneyListD1))]
        private void DynQueryExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task DynQueryExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = await ((IDecimalListmoneyListD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_decimalmoneylistd1e2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalmoneyListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void DynQueryExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = ((IDecimalListmoneyListD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_decimalmoneylistd1e2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalmoneyListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_decimalmoneylistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(DecimalmoneyListD1E2MI), typeof(DecimalmoneyListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListmoneyListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483636),
                (NpgsqlTypes.NpgsqlDbType)(-2147483636)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483636),
                (NpgsqlTypes.NpgsqlDbType)(-2147483636)
            })]
        private void MMWAExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task MMWAExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<DecimalmoneyListD1E2MI>();
                var models2 = new List<DecimalmoneyListD1E2MI>();
                await ((IDecimalListmoneyListD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalmoneyListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalmoneyListD1E2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void MMWAExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<DecimalmoneyListD1E2MI>();
                var models2 = new List<DecimalmoneyListD1E2MI>();
                ((IDecimalListmoneyListD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalmoneyListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalmoneyListD1E2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_decimalmoneylistd1e2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(DecimalmoneyListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListmoneyListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483636),
                (NpgsqlTypes.NpgsqlDbType)(-2147483636)
            })]
        private void WAExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task WAExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = await ((IDecimalListmoneyListD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalmoneyListD1E2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void WAExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = ((IDecimalListmoneyListD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalmoneyListD1E2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_decimalmoneylistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(DecimalmoneyListD1E2MIWA), typeof(DecimalmoneyListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListmoneyListD1))]
        private void MMExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task MMExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<DecimalmoneyListD1E2MIWA>();
                var models2 = new List<DecimalmoneyListD1E2MIWA>();
                await ((IDecimalListmoneyListD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalmoneyListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalmoneyListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void MMExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<DecimalmoneyListD1E2MIWA>();
                var models2 = new List<DecimalmoneyListD1E2MIWA>();
                ((IDecimalListmoneyListD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalmoneyListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalmoneyListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_decimalmoneylistd1e2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(DecimalmoneyListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListmoneyListD1))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = await ((IDecimalListmoneyListD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalmoneyListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void ExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = ((IDecimalListmoneyListD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalmoneyListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

