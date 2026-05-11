

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
    internal partial interface IDecimalSingleTypemoney
    {
    }
    
    internal partial class DecimalSingleTypemoney : IDecimalSingleTypemoney
    {


#region TestData

        private readonly DecimalmoneyE0M[] _testData = new DecimalmoneyE0M[]
        {
            new DecimalmoneyE0M
{
    Id = 3,
    Value = 0.32m,
    ModelInner = null,
    NullableValue = null,
},
            new DecimalmoneyE0M
{
    Id = 11,
    Value = 0.08m,
    ModelInner = new DecimalmoneyE0MI
{
    Id = 2,
    Value = 0.97m,
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalmoneyE0M
{
    Id = 12,
    Value = 0.02m,
    ModelInner = null,
    NullableValue = null,
},
            new DecimalmoneyE0M
{
    Id = 21,
    Value = 0.48m,
    ModelInner = new DecimalmoneyE0MI
{
    Id = 6,
    Value = 0.26m,
    NullableValue = 0.85m,
},
    NullableValue = null,
},
            new DecimalmoneyE0M
{
    Id = 26,
    Value = 0.44m,
    ModelInner = null,
    NullableValue = null,
},
            new DecimalmoneyE0M
{
    Id = 28,
    Value = 0.18m,
    ModelInner = new DecimalmoneyE0MI
{
    Id = 8,
    Value = 0.72m,
    NullableValue = 0.55m,
},
    NullableValue = 0.28m,
},
            new DecimalmoneyE0M
{
    Id = 29,
    Value = 0.20m,
    ModelInner = null,
    NullableValue = null,
},
            new DecimalmoneyE0M
{
    Id = 34,
    Value = 0.73m,
    ModelInner = new DecimalmoneyE0MI
{
    Id = 13,
    Value = 0.56m,
    NullableValue = 0.65m,
},
    NullableValue = null,
},
            new DecimalmoneyE0M
{
    Id = 38,
    Value = 0.47m,
    ModelInner = null,
    NullableValue = 0.52m,
},
            new DecimalmoneyE0M
{
    Id = 40,
    Value = 0.75m,
    ModelInner = new DecimalmoneyE0MI
{
    Id = 21,
    Value = 0.77m,
    NullableValue = null,
},
    NullableValue = 0.05m,
},
            new DecimalmoneyE0M
{
    Id = 44,
    Value = 0.57m,
    ModelInner = null,
    NullableValue = 0.27m,
},
            new DecimalmoneyE0M
{
    Id = 53,
    Value = 0.55m,
    ModelInner = new DecimalmoneyE0MI
{
    Id = 25,
    Value = 0.21m,
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalmoneyE0M
{
    Id = 59,
    Value = 0.70m,
    ModelInner = null,
    NullableValue = null,
},
            new DecimalmoneyE0M
{
    Id = 62,
    Value = 0.87m,
    ModelInner = new DecimalmoneyE0MI
{
    Id = 33,
    Value = 0.58m,
    NullableValue = null,
},
    NullableValue = 0.88m,
},
            new DecimalmoneyE0M
{
    Id = 65,
    Value = 0.43m,
    ModelInner = null,
    NullableValue = null,
},
            new DecimalmoneyE0M
{
    Id = 73,
    Value = 0.58m,
    ModelInner = new DecimalmoneyE0MI
{
    Id = 39,
    Value = 0.23m,
    NullableValue = null,
},
    NullableValue = 0.81m,
},
            new DecimalmoneyE0M
{
    Id = 76,
    Value = 0.24m,
    ModelInner = null,
    NullableValue = null,
},
            new DecimalmoneyE0M
{
    Id = 85,
    Value = 0.88m,
    ModelInner = new DecimalmoneyE0MI
{
    Id = 43,
    Value = 0.85m,
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalmoneyE0M
{
    Id = 90,
    Value = 0.93m,
    ModelInner = null,
    NullableValue = 0.85m,
},
            new DecimalmoneyE0M
{
    Id = 96,
    Value = 0.69m,
    ModelInner = new DecimalmoneyE0MI
{
    Id = 44,
    Value = 0.36m,
    NullableValue = 0.83m,
},
    NullableValue = null,
},
            new DecimalmoneyE0M
{
    Id = 100,
    Value = 0.34m,
    ModelInner = null,
    NullableValue = 0.86m,
},
            new DecimalmoneyE0M
{
    Id = 107,
    Value = 0.53m,
    ModelInner = new DecimalmoneyE0MI
{
    Id = 50,
    Value = 0.85m,
    NullableValue = null,
},
    NullableValue = 0.25m,
},
            new DecimalmoneyE0M
{
    Id = 111,
    Value = 0.70m,
    ModelInner = null,
    NullableValue = null,
},
            new DecimalmoneyE0M
{
    Id = 117,
    Value = 0.09m,
    ModelInner = new DecimalmoneyE0MI
{
    Id = 58,
    Value = 0.64m,
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalmoneyE0M
{
    Id = 121,
    Value = 0.86m,
    ModelInner = null,
    NullableValue = null,
},
            new DecimalmoneyE0M
{
    Id = 129,
    Value = 0.81m,
    ModelInner = new DecimalmoneyE0MI
{
    Id = 61,
    Value = 0.21m,
    NullableValue = 0.64m,
},
    NullableValue = 0.35m,
},
            new DecimalmoneyE0M
{
    Id = 136,
    Value = 0.15m,
    ModelInner = null,
    NullableValue = null,
},
            new DecimalmoneyE0M
{
    Id = 140,
    Value = 0.44m,
    ModelInner = new DecimalmoneyE0MI
{
    Id = 70,
    Value = 0.54m,
    NullableValue = null,
},
    NullableValue = 0.78m,
},
            new DecimalmoneyE0M
{
    Id = 141,
    Value = 0.40m,
    ModelInner = null,
    NullableValue = 0.77m,
},
            new DecimalmoneyE0M
{
    Id = 144,
    Value = 0.99m,
    ModelInner = new DecimalmoneyE0MI
{
    Id = 78,
    Value = 0.74m,
    NullableValue = 0.74m,
},
    NullableValue = null,
},
            new DecimalmoneyE0M
{
    Id = 152,
    Value = 0.35m,
    ModelInner = null,
    NullableValue = null,
},
            new DecimalmoneyE0M
{
    Id = 153,
    Value = 0.65m,
    ModelInner = new DecimalmoneyE0MI
{
    Id = 86,
    Value = 0.28m,
    NullableValue = null,
},
    NullableValue = 0.58m,
},
            new DecimalmoneyE0M
{
    Id = 160,
    Value = 0.79m,
    ModelInner = null,
    NullableValue = 0.04m,
},
            new DecimalmoneyE0M
{
    Id = 169,
    Value = 0.62m,
    ModelInner = new DecimalmoneyE0MI
{
    Id = 91,
    Value = 0.75m,
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalmoneyE0M
{
    Id = 174,
    Value = 0.62m,
    ModelInner = null,
    NullableValue = 0.56m,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalmoneye0mi(
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
            asPartInterface: typeof(IDecimalSingleTypemoney)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(12)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal?), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(12))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalmoneye0mi(
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
            queryMapTypes: [typeof(DecimalmoneyE0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypemoney)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(12)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(12))]
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

                changedRows =  ((IDecimalSingleTypemoney)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDecimalSingleTypemoney)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IDecimalSingleTypemoney)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypemoney)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IDecimalSingleTypemoney)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IDecimalSingleTypemoney)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IDecimalSingleTypemoney)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IDecimalSingleTypemoney)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.decimalmoneye0mi(
	id,
    value,
    nullablevalue
)
VALUES (
    @id,
    @value, 
    @nullablevalue
)
",
            methodName:"DbConnectionInsertInnerModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypemoney)), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Decimal), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(4)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Decimal?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(4), 
                nullable: true)]
        public void DbConnectionInsertInnerModelConfig()
        {
        }

        [Test, Order(0)]
        public async Task DbConnectionInsertInnerModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows =  ((IDecimalSingleTypemoney)this).DbConnectionInsertInnerModel(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(0)]
        public async Task DbConnectionInsertInnerModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows = await ((IDecimalSingleTypemoney)this).DbConnectionInsertInnerModelAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypemoney)this).DbConnectionInsertInnerModelAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypemoney)this).DbConnectionInsertInnerModelAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypemoney)this).DbConnectionInsertInnerModelAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypemoney)this).DbConnectionInsertInnerModelAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypemoney)this).DbConnectionInsertInnerModelAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypemoney)this).DbConnectionInsertInnerModelAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypemoney)this).DbConnectionInsertInnerModelAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalmoneye0m(
	id,
    value,
    nullablevalue,
    decimalmoneye0mi_id
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
            asPartInterface: typeof(IDecimalSingleTypemoney)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(12)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(12)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "decimalmoneye0mi_id", 
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
                changedRows =  ((IDecimalSingleTypemoney)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IDecimalSingleTypemoney)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IDecimalSingleTypemoney)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IDecimalSingleTypemoney)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalmoneye0m(
	id,
    value,
    nullablevalue,
    decimalmoneye0mi_id
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
    decimalmoneye0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(DecimalmoneyE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypemoney)),
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
                System.Decimal? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<System.Decimal>();
                    ((NpgsqlParameter<System.Decimal>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(12);
                    ((NpgsqlParameter<System.Decimal>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(12);
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

                    nullable =  ((IDecimalSingleTypemoney)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<System.Decimal>();
                    ((NpgsqlParameter<System.Decimal>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(12);
                    ((NpgsqlParameter<System.Decimal>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(12);
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

                    nullable =  ((IDecimalSingleTypemoney)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(0.28m));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Decimal? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<System.Decimal>();
                    ((NpgsqlParameter<System.Decimal>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(12);
                    ((NpgsqlParameter<System.Decimal>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(12);
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

                    nullable = await ((IDecimalSingleTypemoney)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<System.Decimal>();
                    ((NpgsqlParameter<System.Decimal>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(12);
                    ((NpgsqlParameter<System.Decimal>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(12);
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

                    nullable = await ((IDecimalSingleTypemoney)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalmoneye0m(
	id,
    value,
    nullablevalue,
    decimalmoneye0mi_id
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
    decimalmoneye0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(DecimalmoneyE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypemoney)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(12)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(12)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "decimalmoneye0mi_id", 
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
                System.Decimal? nullable = null;
                nullable =  ((IDecimalSingleTypemoney)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(0.52m));
                nullable =  ((IDecimalSingleTypemoney)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(0.05m));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Decimal? nullable = null;
                nullable = await ((IDecimalSingleTypemoney)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(0.27m));
                nullable = await ((IDecimalSingleTypemoney)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<DecimalmoneyE0M> models = null;

                models =  ((IDecimalSingleTypemoney)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalmoneyE0M.AssertModel(models[0],_testData[12], true);
                models =  ((IDecimalSingleTypemoney)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalmoneyE0M.AssertModel(models[0],_testData[13], true);
                models =  ((IDecimalSingleTypemoney)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalmoneyE0M.AssertModel(models[0],_testData[14], true);
                models =  ((IDecimalSingleTypemoney)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalmoneyE0M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<DecimalmoneyE0M> models = null;

                models = await ((IDecimalSingleTypemoney)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalmoneyE0M.AssertModel(models[0],_testData[16], true);
                models = await ((IDecimalSingleTypemoney)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalmoneyE0M.AssertModel(models[0],_testData[17], true);
                models = await ((IDecimalSingleTypemoney)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalmoneyE0M.AssertModel(models[0],_testData[18], true);
                models = await ((IDecimalSingleTypemoney)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalmoneyE0M.AssertModel(models[0],_testData[19], true);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.decimalmoneye0m(
	id,
    value,
    nullablevalue,
    decimalmoneye0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @decimalmoneye0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypemoney)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Decimal), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(4)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Decimal?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(4),
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "decimalmoneye0mi_id", 
                methodParametrName: "decimalmoneye0mi_id", 
                dbType: (System.Data.DbType)(11),
                nullable: true)]
        public void DbConnectionInsertModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task DbConnectionInsertModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows =  ((IDecimalSingleTypemoney)this).DbConnectionInsertModel(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDecimalSingleTypemoney)this).DbConnectionInsertModel(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(1)]
        public async Task DbConnectionInsertModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows = await ((IDecimalSingleTypemoney)this).DbConnectionInsertModelAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypemoney)this).DbConnectionInsertModelAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypemoney)this).DbConnectionInsertModelAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypemoney)this).DbConnectionInsertModelAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypemoney)this).DbConnectionInsertModelAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypemoney)this).DbConnectionInsertModelAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypemoney)this).DbConnectionInsertModelAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypemoney)this).DbConnectionInsertModelAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypemoney)this).DbConnectionInsertModelAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypemoney)this).DbConnectionInsertModelAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypemoney)this).DbConnectionInsertModelAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypemoney)this).DbConnectionInsertModelAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalSingleTypemoney)this).DbConnectionInsertModelAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalmoneyE0M), typeof(FlatDecimalmoneyE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypemoney)),
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
FROM public.decimalmoneye0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDecimalmoneyE0M>();
                var models2 = new List<FlatDecimalmoneyE0M>();
                await ((IDecimalSingleTypemoney)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalmoneyE0M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalmoneyE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.decimalmoneye0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDecimalmoneyE0M>();
                var models2 = new List<FlatDecimalmoneyE0M>();
                ((IDecimalSingleTypemoney)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalmoneyE0M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalmoneyE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalmoneyE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypemoney)),
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
FROM public.decimalmoneye0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IDecimalSingleTypemoney)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalmoneyE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalmoneye0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IDecimalSingleTypemoney)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalmoneyE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalmoneye0m m
LEFT JOIN public.decimalmoneye0mi mi ON mi.id = m.decimalmoneye0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(DecimalmoneyE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypemoney)),
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
                var models = await ((IDecimalSingleTypemoney)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalmoneyE0M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IDecimalSingleTypemoney)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalmoneyE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalmoneyE0M), typeof(FlatDecimalmoneyE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypemoney)),
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
FROM public.decimalmoneye0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalmoneyE0M>();
                var models2 = new List<FlatDecimalmoneyE0M>();
                await ((IDecimalSingleTypemoney)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalmoneyE0M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalmoneyE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.decimalmoneye0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalmoneyE0M>();
                var models2 = new List<FlatDecimalmoneyE0M>();
                ((IDecimalSingleTypemoney)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalmoneyE0M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalmoneyE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalmoneyE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypemoney)),
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
FROM public.decimalmoneye0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IDecimalSingleTypemoney)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalmoneyE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalmoneye0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IDecimalSingleTypemoney)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalmoneyE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalmoneye0m m
LEFT JOIN public.decimalmoneye0mi mi ON mi.id = m.decimalmoneye0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(DecimalmoneyE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypemoney)),
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
                var models = await ((IDecimalSingleTypemoney)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalmoneyE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IDecimalSingleTypemoney)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalmoneyE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalmoneyE0M), typeof(FlatDecimalmoneyE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypemoney)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypemoney)),
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
            asPartInterface: typeof(IDecimalSingleTypemoney)),
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
FROM public.decimalmoneye0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDecimalmoneyE0M>();
                var models2 = new List<FlatDecimalmoneyE0M>();
                await((IDecimalSingleTypemoney)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalmoneyE0M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalmoneyE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 29;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 100;
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
FROM public.decimalmoneye0m m
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
FROM public.decimalmoneye0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalmoneyE0M>();
                var firstItems2 = new List<FlatDecimalmoneyE0M>();
                var secondItems1 = new List<FlatDecimalmoneyE0M>();
                var secondItems2 = new List<FlatDecimalmoneyE0M>();
                await ((IDecimalSingleTypemoney)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[13],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 121;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 26;
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
FROM public.decimalmoneye0m m
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
FROM public.decimalmoneye0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalmoneyE0M>();
                var firstItems2 = new List<FlatDecimalmoneyE0M>();
                var secondItems1 = new List<FlatDecimalmoneyE0M>();
                await ((IDecimalSingleTypemoney)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[29],_testData[34], false);
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
FROM public.decimalmoneye0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDecimalmoneyE0M>();
                var models2 = new List<FlatDecimalmoneyE0M>();
                ((IDecimalSingleTypemoney)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalmoneyE0M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalmoneyE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr2.Value = 40;
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
FROM public.decimalmoneye0m m
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
FROM public.decimalmoneye0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalmoneyE0M>();
                var firstItems2 = new List<FlatDecimalmoneyE0M>();
                var secondItems1 = new List<FlatDecimalmoneyE0M>();
                var secondItems2 = new List<FlatDecimalmoneyE0M>();
                 ((IDecimalSingleTypemoney)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[24],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 111;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 38;
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
FROM public.decimalmoneye0m m
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
FROM public.decimalmoneye0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalmoneyE0M>();
                var firstItems2 = new List<FlatDecimalmoneyE0M>();
                var secondItems1 = new List<FlatDecimalmoneyE0M>();
                 ((IDecimalSingleTypemoney)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[25],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalmoneyE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypemoney)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypemoney)),
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
            asPartInterface: typeof(IDecimalSingleTypemoney)),
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
FROM public.decimalmoneye0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IDecimalSingleTypemoney)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalmoneyE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 59;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 152;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalmoneye0m m
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
FROM public.decimalmoneye0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalSingleTypemoney)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatDecimalmoneyE0M.AssertModel(models[0],_testData[13], false);
                        FlatDecimalmoneyE0M.AssertModel(models[1],_testData[14], false);
                        FlatDecimalmoneyE0M.AssertModel(models[2],_testData[15], false);
                        FlatDecimalmoneyE0M.AssertModel(models[3],_testData[16], false);
                        FlatDecimalmoneyE0M.AssertModel(models[4],_testData[17], false);
                        FlatDecimalmoneyE0M.AssertModel(models[5],_testData[18], false);
                        FlatDecimalmoneyE0M.AssertModel(models[6],_testData[19], false);
                        FlatDecimalmoneyE0M.AssertModel(models[7],_testData[20], false);
                        FlatDecimalmoneyE0M.AssertModel(models[8],_testData[21], false);
                        FlatDecimalmoneyE0M.AssertModel(models[9],_testData[22], false);
                        FlatDecimalmoneyE0M.AssertModel(models[10],_testData[23], false);
                        FlatDecimalmoneyE0M.AssertModel(models[11],_testData[24], false);
                        FlatDecimalmoneyE0M.AssertModel(models[12],_testData[25], false);
                        FlatDecimalmoneyE0M.AssertModel(models[13],_testData[26], false);
                        FlatDecimalmoneyE0M.AssertModel(models[14],_testData[27], false);
                        FlatDecimalmoneyE0M.AssertModel(models[15],_testData[28], false);
                        FlatDecimalmoneyE0M.AssertModel(models[16],_testData[29], false);
                        FlatDecimalmoneyE0M.AssertModel(models[17],_testData[30], false);
                        FlatDecimalmoneyE0M.AssertModel(models[18],_testData[31], false);
                        FlatDecimalmoneyE0M.AssertModel(models[19],_testData[32], false);
                        FlatDecimalmoneyE0M.AssertModel(models[20],_testData[33], false);
                        FlatDecimalmoneyE0M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatDecimalmoneyE0M.AssertModel(models[0],_testData[31], false);
                        FlatDecimalmoneyE0M.AssertModel(models[1],_testData[32], false);
                        FlatDecimalmoneyE0M.AssertModel(models[2],_testData[33], false);
                        FlatDecimalmoneyE0M.AssertModel(models[3],_testData[34], false);
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
                parametr1.Value = 129;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 38;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalmoneye0m m
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
FROM public.decimalmoneye0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalmoneyE0M>();
                var secondItems1 = new List<FlatDecimalmoneyE0M>();
                var secondItems2 = new List<FlatDecimalmoneyE0M>();
                await ((IDecimalSingleTypemoney)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[25],_testData[34], false);
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
FROM public.decimalmoneye0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IDecimalSingleTypemoney)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalmoneyE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 107;
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
FROM public.decimalmoneye0m m
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
FROM public.decimalmoneye0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalSingleTypemoney)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatDecimalmoneyE0M.AssertModel(models[0],_testData[22], false);
                        FlatDecimalmoneyE0M.AssertModel(models[1],_testData[23], false);
                        FlatDecimalmoneyE0M.AssertModel(models[2],_testData[24], false);
                        FlatDecimalmoneyE0M.AssertModel(models[3],_testData[25], false);
                        FlatDecimalmoneyE0M.AssertModel(models[4],_testData[26], false);
                        FlatDecimalmoneyE0M.AssertModel(models[5],_testData[27], false);
                        FlatDecimalmoneyE0M.AssertModel(models[6],_testData[28], false);
                        FlatDecimalmoneyE0M.AssertModel(models[7],_testData[29], false);
                        FlatDecimalmoneyE0M.AssertModel(models[8],_testData[30], false);
                        FlatDecimalmoneyE0M.AssertModel(models[9],_testData[31], false);
                        FlatDecimalmoneyE0M.AssertModel(models[10],_testData[32], false);
                        FlatDecimalmoneyE0M.AssertModel(models[11],_testData[33], false);
                        FlatDecimalmoneyE0M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatDecimalmoneyE0M.AssertModel(models[0],_testData[24], false);
                        FlatDecimalmoneyE0M.AssertModel(models[1],_testData[25], false);
                        FlatDecimalmoneyE0M.AssertModel(models[2],_testData[26], false);
                        FlatDecimalmoneyE0M.AssertModel(models[3],_testData[27], false);
                        FlatDecimalmoneyE0M.AssertModel(models[4],_testData[28], false);
                        FlatDecimalmoneyE0M.AssertModel(models[5],_testData[29], false);
                        FlatDecimalmoneyE0M.AssertModel(models[6],_testData[30], false);
                        FlatDecimalmoneyE0M.AssertModel(models[7],_testData[31], false);
                        FlatDecimalmoneyE0M.AssertModel(models[8],_testData[32], false);
                        FlatDecimalmoneyE0M.AssertModel(models[9],_testData[33], false);
                        FlatDecimalmoneyE0M.AssertModel(models[10],_testData[34], false);
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
                parametr1.Value = 59;
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
FROM public.decimalmoneye0m m
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
FROM public.decimalmoneye0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalmoneyE0M>();
                var secondItems1 = new List<FlatDecimalmoneyE0M>();
                var secondItems2 = new List<FlatDecimalmoneyE0M>();
                 ((IDecimalSingleTypemoney)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[22],_testData[34], false);
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
FROM public.decimalmoneye0m m
LEFT JOIN public.decimalmoneye0mi mi ON mi.id = m.decimalmoneye0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(DecimalmoneyE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypemoney)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypemoney)),
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
                var models = await((IDecimalSingleTypemoney)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalmoneyE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 28;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 28;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalSingleTypemoney)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        DecimalmoneyE0M.AssertModel(models[0],_testData[6], false);
                        DecimalmoneyE0M.AssertModel(models[1],_testData[7], false);
                        DecimalmoneyE0M.AssertModel(models[2],_testData[8], false);
                        DecimalmoneyE0M.AssertModel(models[3],_testData[9], false);
                        DecimalmoneyE0M.AssertModel(models[4],_testData[10], false);
                        DecimalmoneyE0M.AssertModel(models[5],_testData[11], false);
                        DecimalmoneyE0M.AssertModel(models[6],_testData[12], false);
                        DecimalmoneyE0M.AssertModel(models[7],_testData[13], false);
                        DecimalmoneyE0M.AssertModel(models[8],_testData[14], false);
                        DecimalmoneyE0M.AssertModel(models[9],_testData[15], false);
                        DecimalmoneyE0M.AssertModel(models[10],_testData[16], false);
                        DecimalmoneyE0M.AssertModel(models[11],_testData[17], false);
                        DecimalmoneyE0M.AssertModel(models[12],_testData[18], false);
                        DecimalmoneyE0M.AssertModel(models[13],_testData[19], false);
                        DecimalmoneyE0M.AssertModel(models[14],_testData[20], false);
                        DecimalmoneyE0M.AssertModel(models[15],_testData[21], false);
                        DecimalmoneyE0M.AssertModel(models[16],_testData[22], false);
                        DecimalmoneyE0M.AssertModel(models[17],_testData[23], false);
                        DecimalmoneyE0M.AssertModel(models[18],_testData[24], false);
                        DecimalmoneyE0M.AssertModel(models[19],_testData[25], false);
                        DecimalmoneyE0M.AssertModel(models[20],_testData[26], false);
                        DecimalmoneyE0M.AssertModel(models[21],_testData[27], false);
                        DecimalmoneyE0M.AssertModel(models[22],_testData[28], false);
                        DecimalmoneyE0M.AssertModel(models[23],_testData[29], false);
                        DecimalmoneyE0M.AssertModel(models[24],_testData[30], false);
                        DecimalmoneyE0M.AssertModel(models[25],_testData[31], false);
                        DecimalmoneyE0M.AssertModel(models[26],_testData[32], false);
                        DecimalmoneyE0M.AssertModel(models[27],_testData[33], false);
                        DecimalmoneyE0M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        DecimalmoneyE0M.AssertModel(models[0],_testData[6], false);
                        DecimalmoneyE0M.AssertModel(models[1],_testData[7], false);
                        DecimalmoneyE0M.AssertModel(models[2],_testData[8], false);
                        DecimalmoneyE0M.AssertModel(models[3],_testData[9], false);
                        DecimalmoneyE0M.AssertModel(models[4],_testData[10], false);
                        DecimalmoneyE0M.AssertModel(models[5],_testData[11], false);
                        DecimalmoneyE0M.AssertModel(models[6],_testData[12], false);
                        DecimalmoneyE0M.AssertModel(models[7],_testData[13], false);
                        DecimalmoneyE0M.AssertModel(models[8],_testData[14], false);
                        DecimalmoneyE0M.AssertModel(models[9],_testData[15], false);
                        DecimalmoneyE0M.AssertModel(models[10],_testData[16], false);
                        DecimalmoneyE0M.AssertModel(models[11],_testData[17], false);
                        DecimalmoneyE0M.AssertModel(models[12],_testData[18], false);
                        DecimalmoneyE0M.AssertModel(models[13],_testData[19], false);
                        DecimalmoneyE0M.AssertModel(models[14],_testData[20], false);
                        DecimalmoneyE0M.AssertModel(models[15],_testData[21], false);
                        DecimalmoneyE0M.AssertModel(models[16],_testData[22], false);
                        DecimalmoneyE0M.AssertModel(models[17],_testData[23], false);
                        DecimalmoneyE0M.AssertModel(models[18],_testData[24], false);
                        DecimalmoneyE0M.AssertModel(models[19],_testData[25], false);
                        DecimalmoneyE0M.AssertModel(models[20],_testData[26], false);
                        DecimalmoneyE0M.AssertModel(models[21],_testData[27], false);
                        DecimalmoneyE0M.AssertModel(models[22],_testData[28], false);
                        DecimalmoneyE0M.AssertModel(models[23],_testData[29], false);
                        DecimalmoneyE0M.AssertModel(models[24],_testData[30], false);
                        DecimalmoneyE0M.AssertModel(models[25],_testData[31], false);
                        DecimalmoneyE0M.AssertModel(models[26],_testData[32], false);
                        DecimalmoneyE0M.AssertModel(models[27],_testData[33], false);
                        DecimalmoneyE0M.AssertModel(models[28],_testData[34], false);
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
                var models = ((IDecimalSingleTypemoney)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalmoneyE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 62;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 136;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalSingleTypemoney)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        DecimalmoneyE0M.AssertModel(models[0],_testData[14], false);
                        DecimalmoneyE0M.AssertModel(models[1],_testData[15], false);
                        DecimalmoneyE0M.AssertModel(models[2],_testData[16], false);
                        DecimalmoneyE0M.AssertModel(models[3],_testData[17], false);
                        DecimalmoneyE0M.AssertModel(models[4],_testData[18], false);
                        DecimalmoneyE0M.AssertModel(models[5],_testData[19], false);
                        DecimalmoneyE0M.AssertModel(models[6],_testData[20], false);
                        DecimalmoneyE0M.AssertModel(models[7],_testData[21], false);
                        DecimalmoneyE0M.AssertModel(models[8],_testData[22], false);
                        DecimalmoneyE0M.AssertModel(models[9],_testData[23], false);
                        DecimalmoneyE0M.AssertModel(models[10],_testData[24], false);
                        DecimalmoneyE0M.AssertModel(models[11],_testData[25], false);
                        DecimalmoneyE0M.AssertModel(models[12],_testData[26], false);
                        DecimalmoneyE0M.AssertModel(models[13],_testData[27], false);
                        DecimalmoneyE0M.AssertModel(models[14],_testData[28], false);
                        DecimalmoneyE0M.AssertModel(models[15],_testData[29], false);
                        DecimalmoneyE0M.AssertModel(models[16],_testData[30], false);
                        DecimalmoneyE0M.AssertModel(models[17],_testData[31], false);
                        DecimalmoneyE0M.AssertModel(models[18],_testData[32], false);
                        DecimalmoneyE0M.AssertModel(models[19],_testData[33], false);
                        DecimalmoneyE0M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        DecimalmoneyE0M.AssertModel(models[0],_testData[27], false);
                        DecimalmoneyE0M.AssertModel(models[1],_testData[28], false);
                        DecimalmoneyE0M.AssertModel(models[2],_testData[29], false);
                        DecimalmoneyE0M.AssertModel(models[3],_testData[30], false);
                        DecimalmoneyE0M.AssertModel(models[4],_testData[31], false);
                        DecimalmoneyE0M.AssertModel(models[5],_testData[32], false);
                        DecimalmoneyE0M.AssertModel(models[6],_testData[33], false);
                        DecimalmoneyE0M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalmoneyE0M), typeof(FlatDecimalmoneyE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypemoney)),
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
            asPartInterface: typeof(IDecimalSingleTypemoney)),
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
            asPartInterface: typeof(IDecimalSingleTypemoney)),
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
FROM public.decimalmoneye0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalmoneyE0M>();
                var models2 = new List<FlatDecimalmoneyE0M>();
                await((IDecimalSingleTypemoney)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalmoneyE0M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalmoneyE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.decimalmoneye0m m
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
FROM public.decimalmoneye0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalmoneyE0M>();
                var firstItems2 = new List<FlatDecimalmoneyE0M>();
                var secondItems1 = new List<FlatDecimalmoneyE0M>();
                var secondItems2 = new List<FlatDecimalmoneyE0M>();
                await ((IDecimalSingleTypemoney)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 62, query1, 11, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[32],_testData[34], false);
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
FROM public.decimalmoneye0m m
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
FROM public.decimalmoneye0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalmoneyE0M>();
                var firstItems2 = new List<FlatDecimalmoneyE0M>();
                var secondItems1 = new List<FlatDecimalmoneyE0M>();
                await ((IDecimalSingleTypemoney)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 100, query1, 153, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[2],_testData[34], false);
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
FROM public.decimalmoneye0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalmoneyE0M>();
                var models2 = new List<FlatDecimalmoneyE0M>();
                ((IDecimalSingleTypemoney)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalmoneyE0M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalmoneyE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.decimalmoneye0m m
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
FROM public.decimalmoneye0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalmoneyE0M>();
                var firstItems2 = new List<FlatDecimalmoneyE0M>();
                var secondItems1 = new List<FlatDecimalmoneyE0M>();
                var secondItems2 = new List<FlatDecimalmoneyE0M>();
                 ((IDecimalSingleTypemoney)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 73, query1, 12, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[31],_testData[34], false);
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
FROM public.decimalmoneye0m m
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
FROM public.decimalmoneye0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalmoneyE0M>();
                var firstItems2 = new List<FlatDecimalmoneyE0M>();
                var secondItems1 = new List<FlatDecimalmoneyE0M>();
                 ((IDecimalSingleTypemoney)this).DbConnectionMMDynQuerySelectModelBatch(connection, 38, query1, 26, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[29],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalmoneyE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypemoney)),
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
            asPartInterface: typeof(IDecimalSingleTypemoney)),
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
            asPartInterface: typeof(IDecimalSingleTypemoney)),
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
FROM public.decimalmoneye0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IDecimalSingleTypemoney)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalmoneyE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalmoneye0m m
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
FROM public.decimalmoneye0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalSingleTypemoney)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 144, query1, 21, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatDecimalmoneyE0M.AssertModel(models[0],_testData[30], false);
                        FlatDecimalmoneyE0M.AssertModel(models[1],_testData[31], false);
                        FlatDecimalmoneyE0M.AssertModel(models[2],_testData[32], false);
                        FlatDecimalmoneyE0M.AssertModel(models[3],_testData[33], false);
                        FlatDecimalmoneyE0M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatDecimalmoneyE0M.AssertModel(models[0],_testData[4], false);
                        FlatDecimalmoneyE0M.AssertModel(models[1],_testData[5], false);
                        FlatDecimalmoneyE0M.AssertModel(models[2],_testData[6], false);
                        FlatDecimalmoneyE0M.AssertModel(models[3],_testData[7], false);
                        FlatDecimalmoneyE0M.AssertModel(models[4],_testData[8], false);
                        FlatDecimalmoneyE0M.AssertModel(models[5],_testData[9], false);
                        FlatDecimalmoneyE0M.AssertModel(models[6],_testData[10], false);
                        FlatDecimalmoneyE0M.AssertModel(models[7],_testData[11], false);
                        FlatDecimalmoneyE0M.AssertModel(models[8],_testData[12], false);
                        FlatDecimalmoneyE0M.AssertModel(models[9],_testData[13], false);
                        FlatDecimalmoneyE0M.AssertModel(models[10],_testData[14], false);
                        FlatDecimalmoneyE0M.AssertModel(models[11],_testData[15], false);
                        FlatDecimalmoneyE0M.AssertModel(models[12],_testData[16], false);
                        FlatDecimalmoneyE0M.AssertModel(models[13],_testData[17], false);
                        FlatDecimalmoneyE0M.AssertModel(models[14],_testData[18], false);
                        FlatDecimalmoneyE0M.AssertModel(models[15],_testData[19], false);
                        FlatDecimalmoneyE0M.AssertModel(models[16],_testData[20], false);
                        FlatDecimalmoneyE0M.AssertModel(models[17],_testData[21], false);
                        FlatDecimalmoneyE0M.AssertModel(models[18],_testData[22], false);
                        FlatDecimalmoneyE0M.AssertModel(models[19],_testData[23], false);
                        FlatDecimalmoneyE0M.AssertModel(models[20],_testData[24], false);
                        FlatDecimalmoneyE0M.AssertModel(models[21],_testData[25], false);
                        FlatDecimalmoneyE0M.AssertModel(models[22],_testData[26], false);
                        FlatDecimalmoneyE0M.AssertModel(models[23],_testData[27], false);
                        FlatDecimalmoneyE0M.AssertModel(models[24],_testData[28], false);
                        FlatDecimalmoneyE0M.AssertModel(models[25],_testData[29], false);
                        FlatDecimalmoneyE0M.AssertModel(models[26],_testData[30], false);
                        FlatDecimalmoneyE0M.AssertModel(models[27],_testData[31], false);
                        FlatDecimalmoneyE0M.AssertModel(models[28],_testData[32], false);
                        FlatDecimalmoneyE0M.AssertModel(models[29],_testData[33], false);
                        FlatDecimalmoneyE0M.AssertModel(models[30],_testData[34], false);
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
FROM public.decimalmoneye0m m
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
FROM public.decimalmoneye0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalmoneyE0M>();
                var secondItems1 = new List<FlatDecimalmoneyE0M>();
                var secondItems2 = new List<FlatDecimalmoneyE0M>();
                await ((IDecimalSingleTypemoney)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 121, query1, 152, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[3],_testData[34], false);
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
FROM public.decimalmoneye0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IDecimalSingleTypemoney)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalmoneyE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalmoneye0m m
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
FROM public.decimalmoneye0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalSingleTypemoney)this).DbConnectionSTDynQuerySelectModelBatch(connection, 136, query1, 144, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatDecimalmoneyE0M.AssertModel(models[0],_testData[27], false);
                        FlatDecimalmoneyE0M.AssertModel(models[1],_testData[28], false);
                        FlatDecimalmoneyE0M.AssertModel(models[2],_testData[29], false);
                        FlatDecimalmoneyE0M.AssertModel(models[3],_testData[30], false);
                        FlatDecimalmoneyE0M.AssertModel(models[4],_testData[31], false);
                        FlatDecimalmoneyE0M.AssertModel(models[5],_testData[32], false);
                        FlatDecimalmoneyE0M.AssertModel(models[6],_testData[33], false);
                        FlatDecimalmoneyE0M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatDecimalmoneyE0M.AssertModel(models[0],_testData[30], false);
                        FlatDecimalmoneyE0M.AssertModel(models[1],_testData[31], false);
                        FlatDecimalmoneyE0M.AssertModel(models[2],_testData[32], false);
                        FlatDecimalmoneyE0M.AssertModel(models[3],_testData[33], false);
                        FlatDecimalmoneyE0M.AssertModel(models[4],_testData[34], false);
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
FROM public.decimalmoneye0m m
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
FROM public.decimalmoneye0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalmoneyE0M>();
                var secondItems1 = new List<FlatDecimalmoneyE0M>();
                var secondItems2 = new List<FlatDecimalmoneyE0M>();
                 ((IDecimalSingleTypemoney)this).DbConnectionDynQuerySelectModelBatch(connection, 26, query1, 44, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatDecimalmoneyE0M.AssertModel(firstItems1[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatDecimalmoneyE0M.AssertModel(secondItems2[23],_testData[34], false);
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
FROM public.decimalmoneye0m m
LEFT JOIN public.decimalmoneye0mi mi ON mi.id = m.decimalmoneye0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(DecimalmoneyE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypemoney)),
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
            asPartInterface: typeof(IDecimalSingleTypemoney)),
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
                var models = await((IDecimalSingleTypemoney)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalmoneyE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IDecimalSingleTypemoney)this).DbConnectionSTSelectModelBatchAsync(connection, 76, 153))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        DecimalmoneyE0M.AssertModel(models[0],_testData[17], false);
                        DecimalmoneyE0M.AssertModel(models[1],_testData[18], false);
                        DecimalmoneyE0M.AssertModel(models[2],_testData[19], false);
                        DecimalmoneyE0M.AssertModel(models[3],_testData[20], false);
                        DecimalmoneyE0M.AssertModel(models[4],_testData[21], false);
                        DecimalmoneyE0M.AssertModel(models[5],_testData[22], false);
                        DecimalmoneyE0M.AssertModel(models[6],_testData[23], false);
                        DecimalmoneyE0M.AssertModel(models[7],_testData[24], false);
                        DecimalmoneyE0M.AssertModel(models[8],_testData[25], false);
                        DecimalmoneyE0M.AssertModel(models[9],_testData[26], false);
                        DecimalmoneyE0M.AssertModel(models[10],_testData[27], false);
                        DecimalmoneyE0M.AssertModel(models[11],_testData[28], false);
                        DecimalmoneyE0M.AssertModel(models[12],_testData[29], false);
                        DecimalmoneyE0M.AssertModel(models[13],_testData[30], false);
                        DecimalmoneyE0M.AssertModel(models[14],_testData[31], false);
                        DecimalmoneyE0M.AssertModel(models[15],_testData[32], false);
                        DecimalmoneyE0M.AssertModel(models[16],_testData[33], false);
                        DecimalmoneyE0M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        DecimalmoneyE0M.AssertModel(models[0],_testData[32], false);
                        DecimalmoneyE0M.AssertModel(models[1],_testData[33], false);
                        DecimalmoneyE0M.AssertModel(models[2],_testData[34], false);
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
                var models = ((IDecimalSingleTypemoney)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalmoneyE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IDecimalSingleTypemoney)this).DbConnectionSTSelectModelBatch(connection, 144, 96))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        DecimalmoneyE0M.AssertModel(models[0],_testData[30], false);
                        DecimalmoneyE0M.AssertModel(models[1],_testData[31], false);
                        DecimalmoneyE0M.AssertModel(models[2],_testData[32], false);
                        DecimalmoneyE0M.AssertModel(models[3],_testData[33], false);
                        DecimalmoneyE0M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        DecimalmoneyE0M.AssertModel(models[0],_testData[20], false);
                        DecimalmoneyE0M.AssertModel(models[1],_testData[21], false);
                        DecimalmoneyE0M.AssertModel(models[2],_testData[22], false);
                        DecimalmoneyE0M.AssertModel(models[3],_testData[23], false);
                        DecimalmoneyE0M.AssertModel(models[4],_testData[24], false);
                        DecimalmoneyE0M.AssertModel(models[5],_testData[25], false);
                        DecimalmoneyE0M.AssertModel(models[6],_testData[26], false);
                        DecimalmoneyE0M.AssertModel(models[7],_testData[27], false);
                        DecimalmoneyE0M.AssertModel(models[8],_testData[28], false);
                        DecimalmoneyE0M.AssertModel(models[9],_testData[29], false);
                        DecimalmoneyE0M.AssertModel(models[10],_testData[30], false);
                        DecimalmoneyE0M.AssertModel(models[11],_testData[31], false);
                        DecimalmoneyE0M.AssertModel(models[12],_testData[32], false);
                        DecimalmoneyE0M.AssertModel(models[13],_testData[33], false);
                        DecimalmoneyE0M.AssertModel(models[14],_testData[34], false);
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
                await using var cmd = await ((IDecimalSingleTypemoney)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IDecimalSingleTypemoney)this).SetDbConnectionSelectModelParametrs(cmd, 62);
                var models = await ((IDecimalSingleTypemoney)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(21));

                DecimalmoneyE0M.AssertModel(models[0],_testData[14], false);
                DecimalmoneyE0M.AssertModel(models[1],_testData[15], false);
                DecimalmoneyE0M.AssertModel(models[2],_testData[16], false);
                DecimalmoneyE0M.AssertModel(models[3],_testData[17], false);
                DecimalmoneyE0M.AssertModel(models[4],_testData[18], false);
                DecimalmoneyE0M.AssertModel(models[5],_testData[19], false);
                DecimalmoneyE0M.AssertModel(models[6],_testData[20], false);
                DecimalmoneyE0M.AssertModel(models[7],_testData[21], false);
                DecimalmoneyE0M.AssertModel(models[8],_testData[22], false);
                DecimalmoneyE0M.AssertModel(models[9],_testData[23], false);
                DecimalmoneyE0M.AssertModel(models[10],_testData[24], false);
                DecimalmoneyE0M.AssertModel(models[11],_testData[25], false);
                DecimalmoneyE0M.AssertModel(models[12],_testData[26], false);
                DecimalmoneyE0M.AssertModel(models[13],_testData[27], false);
                DecimalmoneyE0M.AssertModel(models[14],_testData[28], false);
                DecimalmoneyE0M.AssertModel(models[15],_testData[29], false);
                DecimalmoneyE0M.AssertModel(models[16],_testData[30], false);
                DecimalmoneyE0M.AssertModel(models[17],_testData[31], false);
                DecimalmoneyE0M.AssertModel(models[18],_testData[32], false);
                DecimalmoneyE0M.AssertModel(models[19],_testData[33], false);
                DecimalmoneyE0M.AssertModel(models[20],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDecimalSingleTypemoney)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDecimalSingleTypemoney)this).SetDbConnectionSelectModelParametrs(cmd, 153);
                var models =  ((IDecimalSingleTypemoney)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(3));

                DecimalmoneyE0M.AssertModel(models[0],_testData[32], false);
                DecimalmoneyE0M.AssertModel(models[1],_testData[33], false);
                DecimalmoneyE0M.AssertModel(models[2],_testData[34], false);
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
FROM public.decimalmoneye0m m
LEFT JOIN public.decimalmoneye0mi mi ON mi.id = m.decimalmoneye0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelToObjArr",
            queryMapTypes: [typeof(object[])],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypemoney))]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDecimalSingleTypemoney)this).DbConnectionSelectModelToObjArrAsync(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((3)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.32m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((11)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.08m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.97m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.02m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.48m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.26m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.85m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.44m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.18m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.72m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.55m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.28m)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.20m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.73m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.56m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.65m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.47m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.52m)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.75m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((21)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.77m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.05m)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.57m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.27m)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((53)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.55m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.21m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.70m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.87m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.58m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.88m)));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.43m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.58m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.23m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.81m)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.24m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.88m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.85m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.93m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.85m)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((96)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.69m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.36m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.83m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.34m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.86m)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.53m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((50)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.85m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.25m)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((111)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.70m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.09m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.64m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.86m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.81m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.21m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.64m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.35m)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.15m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.44m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((70)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.54m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.78m)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.40m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.77m)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.99m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((78)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.74m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.74m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((152)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.35m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((153)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.65m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((86)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.28m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.58m)));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((160)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.79m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.04m)));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((169)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.62m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((91)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.75m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((174)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.62m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.56m)));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((IDecimalSingleTypemoney)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((3)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.32m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((11)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.08m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.97m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.02m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.48m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.26m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.85m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.44m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.18m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.72m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.55m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.28m)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.20m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.73m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.56m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.65m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.47m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.52m)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.75m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((21)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.77m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.05m)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.57m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.27m)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((53)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.55m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.21m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.70m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.87m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.58m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.88m)));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.43m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.58m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.23m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.81m)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.24m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.88m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.85m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.93m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.85m)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((96)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.69m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.36m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.83m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.34m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.86m)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.53m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((50)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.85m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.25m)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((111)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.70m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.09m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.64m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.86m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.81m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.21m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.64m)));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.35m)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.15m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.44m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((70)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.54m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.78m)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.40m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.77m)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.99m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((78)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.74m)));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo((0.74m)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((152)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.35m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((153)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.65m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((86)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.28m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.58m)));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((160)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.79m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.04m)));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((169)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.62m)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((91)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo((0.75m)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((174)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo((0.62m)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo((0.56m)));

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
FROM public.binary_decimalmoneye0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(DecimalmoneyE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypemoney))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(DecimalmoneyE0MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(12),
                (NpgsqlTypes.NpgsqlDbType)(12)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypemoney))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalmoneyE0MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalmoneyE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDecimalSingleTypemoney)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_decimalmoneye0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDecimalSingleTypemoney)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalmoneyE0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalmoneyE0MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalmoneyE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDecimalSingleTypemoney)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_decimalmoneye0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDecimalSingleTypemoney)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalmoneyE0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_decimalmoneye0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(DecimalmoneyE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypemoney))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(DecimalmoneyE0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypemoney))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalmoneyE0MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalmoneyE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDecimalSingleTypemoney)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_decimalmoneye0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDecimalSingleTypemoney)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalmoneyE0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalmoneyE0MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalmoneyE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDecimalSingleTypemoney)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_decimalmoneye0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDecimalSingleTypemoney)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalmoneyE0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_decimalmoneye0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(DecimalmoneyE0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypemoney))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_decimalmoneye0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(DecimalmoneyE0MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(12),
                (NpgsqlTypes.NpgsqlDbType)(12)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypemoney))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalmoneyE0MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IDecimalSingleTypemoney)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IDecimalSingleTypemoney)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalmoneyE0MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalmoneyE0MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IDecimalSingleTypemoney)this).WAImportModelInner(connection, importCollection);
                var models = ((IDecimalSingleTypemoney)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalmoneyE0MI.AssertModel(actual, expect, false);
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
FROM public.binary_decimalmoneye0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(DecimalmoneyE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypemoney))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_decimalmoneye0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(DecimalmoneyE0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypemoney))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalmoneyE0MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalmoneyE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDecimalSingleTypemoney)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IDecimalSingleTypemoney)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalmoneyE0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalmoneyE0MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalmoneyE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDecimalSingleTypemoney)this).ImportModelInner(connection, importCollection);
                var models = ((IDecimalSingleTypemoney)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalmoneyE0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_decimalmoneye0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
decimalmoneye0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(DecimalmoneyE0M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(12),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(12)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypemoney))]
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
FROM public.binary_decimalmoneye0m m
LEFT JOIN public.binary_decimalmoneye0mi mi ON mi.id = m.decimalmoneye0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(DecimalmoneyE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypemoney))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalmoneyE0M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IDecimalSingleTypemoney)this).ImportModelAsync(connection, importCollection);
                var models = await ((IDecimalSingleTypemoney)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    DecimalmoneyE0M.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalmoneyE0M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IDecimalSingleTypemoney)this).ImportModel(connection, importCollection);
                var models = ((IDecimalSingleTypemoney)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    DecimalmoneyE0M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_decimalmoneye0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    decimalmoneye0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(DecimalmoneyE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypemoney)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(12),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(12)
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
                var models =  ((IDecimalSingleTypemoney)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    DecimalmoneyE0M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDecimalSingleTypemoney)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    DecimalmoneyE0M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(DecimalmoneyE0MIWA), typeof(DecimalmoneyE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypemoney)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(12),
                (NpgsqlTypes.NpgsqlDbType)(12)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(12),
                (NpgsqlTypes.NpgsqlDbType)(12)
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
                var models1 = new List<DecimalmoneyE0MIWA>();
                var models2 = new List<DecimalmoneyE0MIWA>();
                await ((IDecimalSingleTypemoney)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_decimalmoneye0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalmoneyE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalmoneyE0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DecimalmoneyE0MIWA>();
                var models2 = new List<DecimalmoneyE0MIWA>();
                ((IDecimalSingleTypemoney)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_decimalmoneye0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalmoneyE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalmoneyE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(DecimalmoneyE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypemoney)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(12),
                (NpgsqlTypes.NpgsqlDbType)(12)
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
                var models = await ((IDecimalSingleTypemoney)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_decimalmoneye0mi
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
                    DecimalmoneyE0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDecimalSingleTypemoney)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_decimalmoneye0mi
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
                    DecimalmoneyE0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(DecimalmoneyE0MIWA), typeof(DecimalmoneyE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypemoney))]
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
                var models1 = new List<DecimalmoneyE0MIWA>();
                var models2 = new List<DecimalmoneyE0MIWA>();
                await ((IDecimalSingleTypemoney)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_decimalmoneye0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalmoneyE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalmoneyE0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DecimalmoneyE0MIWA>();
                var models2 = new List<DecimalmoneyE0MIWA>();
                ((IDecimalSingleTypemoney)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_decimalmoneye0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalmoneyE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalmoneyE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(DecimalmoneyE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypemoney))]
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
                var models = await ((IDecimalSingleTypemoney)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_decimalmoneye0mi
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
                    DecimalmoneyE0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDecimalSingleTypemoney)this).DynQueryExportModelInner(connection, @"
COPY public.binary_decimalmoneye0mi
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
                    DecimalmoneyE0MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_decimalmoneye0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(DecimalmoneyE0MI), typeof(DecimalmoneyE0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypemoney)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(12),
                (NpgsqlTypes.NpgsqlDbType)(12)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(12),
                (NpgsqlTypes.NpgsqlDbType)(12)
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
                var models1 = new List<DecimalmoneyE0MI>();
                var models2 = new List<DecimalmoneyE0MI>();
                await ((IDecimalSingleTypemoney)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalmoneyE0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalmoneyE0MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DecimalmoneyE0MI>();
                var models2 = new List<DecimalmoneyE0MI>();
                ((IDecimalSingleTypemoney)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalmoneyE0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalmoneyE0MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_decimalmoneye0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(DecimalmoneyE0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypemoney)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(12),
                (NpgsqlTypes.NpgsqlDbType)(12)
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
                var models = await ((IDecimalSingleTypemoney)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalmoneyE0MI.AssertModel(model, expectedModel, false);
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
                var models = ((IDecimalSingleTypemoney)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalmoneyE0MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_decimalmoneye0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(DecimalmoneyE0MIWA), typeof(DecimalmoneyE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypemoney))]
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
                var models1 = new List<DecimalmoneyE0MIWA>();
                var models2 = new List<DecimalmoneyE0MIWA>();
                await ((IDecimalSingleTypemoney)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalmoneyE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalmoneyE0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DecimalmoneyE0MIWA>();
                var models2 = new List<DecimalmoneyE0MIWA>();
                ((IDecimalSingleTypemoney)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalmoneyE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalmoneyE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_decimalmoneye0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(DecimalmoneyE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalSingleTypemoney))]
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
                var models = await ((IDecimalSingleTypemoney)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalmoneyE0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDecimalSingleTypemoney)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalmoneyE0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

