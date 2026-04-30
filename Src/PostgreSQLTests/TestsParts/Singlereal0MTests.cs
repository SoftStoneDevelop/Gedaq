

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
    internal partial interface ISingleSingleTypereal
    {
    }
    
    internal partial class SingleSingleTypereal : ISingleSingleTypereal
    {


#region TestData

        private readonly Singlereal0M[] _testData = new Singlereal0M[]
        {
            new Singlereal0M
{
    Id = 8,
    Value = 0.92593175f,
    ModelInner = null,
    NullableValue = null,
},
            new Singlereal0M
{
    Id = 16,
    Value = 0.5674554f,
    ModelInner = new Singlereal0MI
{
    Id = 2,
    Value = 0.50622165f,
    NullableValue = 0.34884733f,
},
    NullableValue = null,
},
            new Singlereal0M
{
    Id = 25,
    Value = 0.18729293f,
    ModelInner = null,
    NullableValue = 0.21692157f,
},
            new Singlereal0M
{
    Id = 33,
    Value = 0.50074786f,
    ModelInner = new Singlereal0MI
{
    Id = 6,
    Value = 0.84440374f,
    NullableValue = null,
},
    NullableValue = 0.8219275f,
},
            new Singlereal0M
{
    Id = 37,
    Value = 0.81755304f,
    ModelInner = null,
    NullableValue = 0.062339187f,
},
            new Singlereal0M
{
    Id = 42,
    Value = 0.838715f,
    ModelInner = new Singlereal0MI
{
    Id = 12,
    Value = 0.31652254f,
    NullableValue = null,
},
    NullableValue = null,
},
            new Singlereal0M
{
    Id = 50,
    Value = 0.06992328f,
    ModelInner = null,
    NullableValue = null,
},
            new Singlereal0M
{
    Id = 57,
    Value = 0.55391103f,
    ModelInner = new Singlereal0MI
{
    Id = 18,
    Value = 0.2804547f,
    NullableValue = 0.7578817f,
},
    NullableValue = 0.49843246f,
},
            new Singlereal0M
{
    Id = 61,
    Value = 0.69169015f,
    ModelInner = null,
    NullableValue = 0.54758984f,
},
            new Singlereal0M
{
    Id = 66,
    Value = 0.58397114f,
    ModelInner = new Singlereal0MI
{
    Id = 19,
    Value = 0.52310765f,
    NullableValue = 0.13653517f,
},
    NullableValue = 0.90735304f,
},
            new Singlereal0M
{
    Id = 72,
    Value = 0.9242343f,
    ModelInner = null,
    NullableValue = null,
},
            new Singlereal0M
{
    Id = 73,
    Value = 0.5381929f,
    ModelInner = new Singlereal0MI
{
    Id = 26,
    Value = 0.7494592f,
    NullableValue = 0.38183767f,
},
    NullableValue = null,
},
            new Singlereal0M
{
    Id = 82,
    Value = 0.4897675f,
    ModelInner = null,
    NullableValue = 0.7066581f,
},
            new Singlereal0M
{
    Id = 88,
    Value = 0.40832514f,
    ModelInner = new Singlereal0MI
{
    Id = 33,
    Value = 0.37671918f,
    NullableValue = null,
},
    NullableValue = 0.5884552f,
},
            new Singlereal0M
{
    Id = 97,
    Value = 0.29344314f,
    ModelInner = null,
    NullableValue = null,
},
            new Singlereal0M
{
    Id = 106,
    Value = 0.7563124f,
    ModelInner = new Singlereal0MI
{
    Id = 42,
    Value = 0.4619661f,
    NullableValue = null,
},
    NullableValue = null,
},
            new Singlereal0M
{
    Id = 111,
    Value = 0.52889436f,
    ModelInner = null,
    NullableValue = 0.51756996f,
},
            new Singlereal0M
{
    Id = 119,
    Value = 0.8920347f,
    ModelInner = new Singlereal0MI
{
    Id = 48,
    Value = 0.9600592f,
    NullableValue = null,
},
    NullableValue = 0.9732332f,
},
            new Singlereal0M
{
    Id = 126,
    Value = 0.4519927f,
    ModelInner = null,
    NullableValue = null,
},
            new Singlereal0M
{
    Id = 129,
    Value = 0.23182392f,
    ModelInner = new Singlereal0MI
{
    Id = 56,
    Value = 0.52509004f,
    NullableValue = null,
},
    NullableValue = null,
},
            new Singlereal0M
{
    Id = 135,
    Value = 0.6496707f,
    ModelInner = null,
    NullableValue = 0.26577282f,
},
            new Singlereal0M
{
    Id = 144,
    Value = 0.08879095f,
    ModelInner = new Singlereal0MI
{
    Id = 65,
    Value = 0.6133566f,
    NullableValue = null,
},
    NullableValue = 0.5559577f,
},
            new Singlereal0M
{
    Id = 151,
    Value = 0.61646813f,
    ModelInner = null,
    NullableValue = null,
},
            new Singlereal0M
{
    Id = 160,
    Value = 0.56061465f,
    ModelInner = new Singlereal0MI
{
    Id = 70,
    Value = 0.4768721f,
    NullableValue = 0.6370988f,
},
    NullableValue = null,
},
            new Singlereal0M
{
    Id = 167,
    Value = 0.5580998f,
    ModelInner = null,
    NullableValue = 0.9849245f,
},
            new Singlereal0M
{
    Id = 168,
    Value = 0.9548218f,
    ModelInner = new Singlereal0MI
{
    Id = 76,
    Value = 0.6118525f,
    NullableValue = 0.09126228f,
},
    NullableValue = 0.5246711f,
},
            new Singlereal0M
{
    Id = 174,
    Value = 0.14525175f,
    ModelInner = null,
    NullableValue = 0.542351f,
},
            new Singlereal0M
{
    Id = 183,
    Value = 0.64399815f,
    ModelInner = new Singlereal0MI
{
    Id = 84,
    Value = 0.0023003817f,
    NullableValue = null,
},
    NullableValue = 0.48904634f,
},
            new Singlereal0M
{
    Id = 187,
    Value = 0.27757293f,
    ModelInner = null,
    NullableValue = 0.38518548f,
},
            new Singlereal0M
{
    Id = 191,
    Value = 0.72025f,
    ModelInner = new Singlereal0MI
{
    Id = 93,
    Value = 0.37507087f,
    NullableValue = 0.26557577f,
},
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.singlereal0mi(
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
            asPartInterface: typeof(ISingleSingleTypereal)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Single),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(17)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Single?), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(17))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.singlereal0mi(
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
            queryMapTypes: [typeof(Singlereal0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleSingleTypereal)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Single),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(17)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Single?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(17))]
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

                changedRows =  ((ISingleSingleTypereal)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((ISingleSingleTypereal)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((ISingleSingleTypereal)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypereal)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((ISingleSingleTypereal)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((ISingleSingleTypereal)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((ISingleSingleTypereal)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((ISingleSingleTypereal)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.singlereal0mi(
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
            asPartInterface: typeof(ISingleSingleTypereal)), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Single), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(15)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Single?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(15), 
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

                changedRows =  ((ISingleSingleTypereal)this).DbConnectionInsertInnerModel(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
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

                changedRows = await ((ISingleSingleTypereal)this).DbConnectionInsertInnerModelAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypereal)this).DbConnectionInsertInnerModelAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypereal)this).DbConnectionInsertInnerModelAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypereal)this).DbConnectionInsertInnerModelAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypereal)this).DbConnectionInsertInnerModelAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypereal)this).DbConnectionInsertInnerModelAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.singlereal0m(
	id,
    value,
    nullablevalue,
    singlereal0mi_id
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
            asPartInterface: typeof(ISingleSingleTypereal)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Single),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(17)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Single?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(17)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "singlereal0mi_id", 
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
                changedRows =  ((ISingleSingleTypereal)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((ISingleSingleTypereal)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((ISingleSingleTypereal)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((ISingleSingleTypereal)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.singlereal0m(
	id,
    value,
    nullablevalue,
    singlereal0mi_id
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
    singlereal0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(Singlereal0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleSingleTypereal)),
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
                System.Single? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<System.Single>();
                    ((NpgsqlParameter<System.Single>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(17);
                    ((NpgsqlParameter<System.Single>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(17);
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

                    nullable =  ((ISingleSingleTypereal)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(0.062339187f));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<System.Single>();
                    ((NpgsqlParameter<System.Single>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(17);
                    ((NpgsqlParameter<System.Single>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(17);
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

                    nullable =  ((ISingleSingleTypereal)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Single? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<System.Single>();
                    ((NpgsqlParameter<System.Single>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(17);
                    ((NpgsqlParameter<System.Single>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(17);
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

                    nullable = await ((ISingleSingleTypereal)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<System.Single>();
                    ((NpgsqlParameter<System.Single>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(17);
                    ((NpgsqlParameter<System.Single>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(17);
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

                    nullable = await ((ISingleSingleTypereal)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(0.49843246f));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.singlereal0m(
	id,
    value,
    nullablevalue,
    singlereal0mi_id
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
    singlereal0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(Singlereal0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleSingleTypereal)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Single),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(17)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Single?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(17)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "singlereal0mi_id", 
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
                System.Single? nullable = null;
                nullable =  ((ISingleSingleTypereal)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(0.54758984f));
                nullable =  ((ISingleSingleTypereal)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(0.90735304f));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Single? nullable = null;
                nullable = await ((ISingleSingleTypereal)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((ISingleSingleTypereal)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Singlereal0M> models = null;

                models =  ((ISingleSingleTypereal)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Singlereal0M.AssertModel(models[0],_testData[12], true);
                models =  ((ISingleSingleTypereal)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Singlereal0M.AssertModel(models[0],_testData[13], true);
                models =  ((ISingleSingleTypereal)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Singlereal0M.AssertModel(models[0],_testData[14], true);
                models =  ((ISingleSingleTypereal)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Singlereal0M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Singlereal0M> models = null;

                models = await ((ISingleSingleTypereal)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Singlereal0M.AssertModel(models[0],_testData[16], true);
                models = await ((ISingleSingleTypereal)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Singlereal0M.AssertModel(models[0],_testData[17], true);
                models = await ((ISingleSingleTypereal)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Singlereal0M.AssertModel(models[0],_testData[18], true);
                models = await ((ISingleSingleTypereal)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Singlereal0M.AssertModel(models[0],_testData[19], true);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.singlereal0m(
	id,
    value,
    nullablevalue,
    singlereal0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @singlereal0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleSingleTypereal)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Single), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(15)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Single?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(15),
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "singlereal0mi_id", 
                methodParametrName: "singlereal0mi_id", 
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

                changedRows =  ((ISingleSingleTypereal)this).DbConnectionInsertModel(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((ISingleSingleTypereal)this).DbConnectionInsertModel(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
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

                changedRows = await ((ISingleSingleTypereal)this).DbConnectionInsertModelAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypereal)this).DbConnectionInsertModelAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypereal)this).DbConnectionInsertModelAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypereal)this).DbConnectionInsertModelAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypereal)this).DbConnectionInsertModelAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypereal)this).DbConnectionInsertModelAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypereal)this).DbConnectionInsertModelAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((ISingleSingleTypereal)this).DbConnectionInsertModelAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatSinglereal0M), typeof(FlatSinglereal0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleSingleTypereal)),
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
FROM public.singlereal0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatSinglereal0M>();
                var models2 = new List<FlatSinglereal0M>();
                await ((ISingleSingleTypereal)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglereal0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglereal0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.singlereal0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatSinglereal0M>();
                var models2 = new List<FlatSinglereal0M>();
                ((ISingleSingleTypereal)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglereal0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglereal0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatSinglereal0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleSingleTypereal)),
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
FROM public.singlereal0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((ISingleSingleTypereal)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglereal0M.AssertModel(models[i],_testData[i], false);
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
FROM public.singlereal0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((ISingleSingleTypereal)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglereal0M.AssertModel(models[i],_testData[i], false);
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
FROM public.singlereal0m m
LEFT JOIN public.singlereal0mi mi ON mi.id = m.singlereal0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Singlereal0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleSingleTypereal)),
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
                var models = await ((ISingleSingleTypereal)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Singlereal0M.AssertModel(models[i],_testData[i], false);
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
                var models = ((ISingleSingleTypereal)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Singlereal0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatSinglereal0M), typeof(FlatSinglereal0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleSingleTypereal)),
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
FROM public.singlereal0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatSinglereal0M>();
                var models2 = new List<FlatSinglereal0M>();
                await ((ISingleSingleTypereal)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglereal0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglereal0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.singlereal0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatSinglereal0M>();
                var models2 = new List<FlatSinglereal0M>();
                ((ISingleSingleTypereal)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglereal0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglereal0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatSinglereal0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleSingleTypereal)),
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
FROM public.singlereal0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((ISingleSingleTypereal)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglereal0M.AssertModel(models[i],_testData[i], false);
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
FROM public.singlereal0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((ISingleSingleTypereal)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglereal0M.AssertModel(models[i],_testData[i], false);
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
FROM public.singlereal0m m
LEFT JOIN public.singlereal0mi mi ON mi.id = m.singlereal0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Singlereal0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleSingleTypereal)),
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
                var models = await ((ISingleSingleTypereal)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Singlereal0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((ISingleSingleTypereal)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Singlereal0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatSinglereal0M), typeof(FlatSinglereal0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleSingleTypereal)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleSingleTypereal)),
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
            asPartInterface: typeof(ISingleSingleTypereal)),
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
FROM public.singlereal0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatSinglereal0M>();
                var models2 = new List<FlatSinglereal0M>();
                await((ISingleSingleTypereal)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglereal0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglereal0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 119;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 135;
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
FROM public.singlereal0m m
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
FROM public.singlereal0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglereal0M>();
                var firstItems2 = new List<FlatSinglereal0M>();
                var secondItems1 = new List<FlatSinglereal0M>();
                var secondItems2 = new List<FlatSinglereal0M>();
                await ((ISingleSingleTypereal)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatSinglereal0M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatSinglereal0M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatSinglereal0M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatSinglereal0M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatSinglereal0M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatSinglereal0M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatSinglereal0M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatSinglereal0M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatSinglereal0M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatSinglereal0M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatSinglereal0M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatSinglereal0M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatSinglereal0M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatSinglereal0M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatSinglereal0M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatSinglereal0M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatSinglereal0M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatSinglereal0M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatSinglereal0M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatSinglereal0M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatSinglereal0M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatSinglereal0M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatSinglereal0M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatSinglereal0M.AssertModel(firstItems2[11],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatSinglereal0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatSinglereal0M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatSinglereal0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatSinglereal0M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatSinglereal0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatSinglereal0M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatSinglereal0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatSinglereal0M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatSinglereal0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatSinglereal0M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatSinglereal0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatSinglereal0M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatSinglereal0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatSinglereal0M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatSinglereal0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatSinglereal0M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatSinglereal0M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatSinglereal0M.AssertModel(secondItems2[8],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 160;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 144;
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
FROM public.singlereal0m m
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
FROM public.singlereal0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglereal0M>();
                var firstItems2 = new List<FlatSinglereal0M>();
                var secondItems1 = new List<FlatSinglereal0M>();
                await ((ISingleSingleTypereal)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatSinglereal0M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatSinglereal0M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatSinglereal0M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatSinglereal0M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatSinglereal0M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatSinglereal0M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatSinglereal0M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatSinglereal0M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatSinglereal0M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatSinglereal0M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatSinglereal0M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatSinglereal0M.AssertModel(firstItems2[5],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatSinglereal0M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatSinglereal0M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatSinglereal0M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatSinglereal0M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatSinglereal0M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatSinglereal0M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatSinglereal0M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatSinglereal0M.AssertModel(secondItems1[7],_testData[29], false);
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
FROM public.singlereal0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatSinglereal0M>();
                var models2 = new List<FlatSinglereal0M>();
                ((ISingleSingleTypereal)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglereal0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglereal0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 33;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 66;
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
FROM public.singlereal0m m
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
FROM public.singlereal0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglereal0M>();
                var firstItems2 = new List<FlatSinglereal0M>();
                var secondItems1 = new List<FlatSinglereal0M>();
                var secondItems2 = new List<FlatSinglereal0M>();
                 ((ISingleSingleTypereal)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatSinglereal0M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatSinglereal0M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatSinglereal0M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatSinglereal0M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatSinglereal0M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatSinglereal0M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatSinglereal0M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatSinglereal0M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatSinglereal0M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatSinglereal0M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatSinglereal0M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatSinglereal0M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatSinglereal0M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatSinglereal0M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatSinglereal0M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatSinglereal0M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatSinglereal0M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatSinglereal0M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatSinglereal0M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatSinglereal0M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatSinglereal0M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatSinglereal0M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatSinglereal0M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatSinglereal0M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatSinglereal0M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatSinglereal0M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatSinglereal0M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatSinglereal0M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatSinglereal0M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatSinglereal0M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatSinglereal0M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatSinglereal0M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatSinglereal0M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatSinglereal0M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatSinglereal0M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatSinglereal0M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatSinglereal0M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatSinglereal0M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatSinglereal0M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatSinglereal0M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatSinglereal0M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatSinglereal0M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatSinglereal0M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatSinglereal0M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatSinglereal0M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatSinglereal0M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatSinglereal0M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatSinglereal0M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatSinglereal0M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatSinglereal0M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatSinglereal0M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatSinglereal0M.AssertModel(firstItems2[25],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatSinglereal0M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatSinglereal0M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatSinglereal0M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatSinglereal0M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatSinglereal0M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatSinglereal0M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatSinglereal0M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatSinglereal0M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatSinglereal0M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatSinglereal0M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatSinglereal0M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatSinglereal0M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatSinglereal0M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatSinglereal0M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatSinglereal0M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatSinglereal0M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatSinglereal0M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatSinglereal0M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatSinglereal0M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatSinglereal0M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatSinglereal0M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatSinglereal0M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatSinglereal0M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatSinglereal0M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatSinglereal0M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatSinglereal0M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatSinglereal0M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatSinglereal0M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatSinglereal0M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatSinglereal0M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatSinglereal0M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatSinglereal0M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatSinglereal0M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatSinglereal0M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatSinglereal0M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatSinglereal0M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatSinglereal0M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatSinglereal0M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatSinglereal0M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatSinglereal0M.AssertModel(secondItems2[19],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 82;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 126;
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
FROM public.singlereal0m m
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
FROM public.singlereal0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglereal0M>();
                var firstItems2 = new List<FlatSinglereal0M>();
                var secondItems1 = new List<FlatSinglereal0M>();
                 ((ISingleSingleTypereal)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatSinglereal0M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatSinglereal0M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatSinglereal0M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatSinglereal0M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatSinglereal0M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatSinglereal0M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatSinglereal0M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatSinglereal0M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatSinglereal0M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatSinglereal0M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatSinglereal0M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatSinglereal0M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatSinglereal0M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatSinglereal0M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatSinglereal0M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatSinglereal0M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatSinglereal0M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatSinglereal0M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatSinglereal0M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatSinglereal0M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatSinglereal0M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatSinglereal0M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatSinglereal0M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatSinglereal0M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatSinglereal0M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatSinglereal0M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatSinglereal0M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatSinglereal0M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatSinglereal0M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatSinglereal0M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatSinglereal0M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatSinglereal0M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatSinglereal0M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatSinglereal0M.AssertModel(firstItems2[16],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatSinglereal0M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatSinglereal0M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatSinglereal0M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatSinglereal0M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatSinglereal0M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatSinglereal0M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatSinglereal0M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatSinglereal0M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatSinglereal0M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatSinglereal0M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatSinglereal0M.AssertModel(secondItems1[10],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatSinglereal0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleSingleTypereal)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleSingleTypereal)),
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
            asPartInterface: typeof(ISingleSingleTypereal)),
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
FROM public.singlereal0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((ISingleSingleTypereal)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglereal0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 160;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 82;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.singlereal0m m
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
FROM public.singlereal0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((ISingleSingleTypereal)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatSinglereal0M.AssertModel(models[0],_testData[24], false);
                        FlatSinglereal0M.AssertModel(models[1],_testData[25], false);
                        FlatSinglereal0M.AssertModel(models[2],_testData[26], false);
                        FlatSinglereal0M.AssertModel(models[3],_testData[27], false);
                        FlatSinglereal0M.AssertModel(models[4],_testData[28], false);
                        FlatSinglereal0M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatSinglereal0M.AssertModel(models[0],_testData[13], false);
                        FlatSinglereal0M.AssertModel(models[1],_testData[14], false);
                        FlatSinglereal0M.AssertModel(models[2],_testData[15], false);
                        FlatSinglereal0M.AssertModel(models[3],_testData[16], false);
                        FlatSinglereal0M.AssertModel(models[4],_testData[17], false);
                        FlatSinglereal0M.AssertModel(models[5],_testData[18], false);
                        FlatSinglereal0M.AssertModel(models[6],_testData[19], false);
                        FlatSinglereal0M.AssertModel(models[7],_testData[20], false);
                        FlatSinglereal0M.AssertModel(models[8],_testData[21], false);
                        FlatSinglereal0M.AssertModel(models[9],_testData[22], false);
                        FlatSinglereal0M.AssertModel(models[10],_testData[23], false);
                        FlatSinglereal0M.AssertModel(models[11],_testData[24], false);
                        FlatSinglereal0M.AssertModel(models[12],_testData[25], false);
                        FlatSinglereal0M.AssertModel(models[13],_testData[26], false);
                        FlatSinglereal0M.AssertModel(models[14],_testData[27], false);
                        FlatSinglereal0M.AssertModel(models[15],_testData[28], false);
                        FlatSinglereal0M.AssertModel(models[16],_testData[29], false);
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
                parametr1.Value = 25;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 126;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.singlereal0m m
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
FROM public.singlereal0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglereal0M>();
                var secondItems1 = new List<FlatSinglereal0M>();
                var secondItems2 = new List<FlatSinglereal0M>();
                await ((ISingleSingleTypereal)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatSinglereal0M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatSinglereal0M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatSinglereal0M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatSinglereal0M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatSinglereal0M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatSinglereal0M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatSinglereal0M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatSinglereal0M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatSinglereal0M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatSinglereal0M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatSinglereal0M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatSinglereal0M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatSinglereal0M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatSinglereal0M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatSinglereal0M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatSinglereal0M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatSinglereal0M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatSinglereal0M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatSinglereal0M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatSinglereal0M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatSinglereal0M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatSinglereal0M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatSinglereal0M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatSinglereal0M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatSinglereal0M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatSinglereal0M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatSinglereal0M.AssertModel(firstItems1[26],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatSinglereal0M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatSinglereal0M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatSinglereal0M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatSinglereal0M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatSinglereal0M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatSinglereal0M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatSinglereal0M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatSinglereal0M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatSinglereal0M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatSinglereal0M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatSinglereal0M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatSinglereal0M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatSinglereal0M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatSinglereal0M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatSinglereal0M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatSinglereal0M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatSinglereal0M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatSinglereal0M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatSinglereal0M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatSinglereal0M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatSinglereal0M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatSinglereal0M.AssertModel(secondItems2[10],_testData[29], false);
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
FROM public.singlereal0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((ISingleSingleTypereal)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglereal0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 151;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 119;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.singlereal0m m
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
FROM public.singlereal0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((ISingleSingleTypereal)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatSinglereal0M.AssertModel(models[0],_testData[23], false);
                        FlatSinglereal0M.AssertModel(models[1],_testData[24], false);
                        FlatSinglereal0M.AssertModel(models[2],_testData[25], false);
                        FlatSinglereal0M.AssertModel(models[3],_testData[26], false);
                        FlatSinglereal0M.AssertModel(models[4],_testData[27], false);
                        FlatSinglereal0M.AssertModel(models[5],_testData[28], false);
                        FlatSinglereal0M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatSinglereal0M.AssertModel(models[0],_testData[18], false);
                        FlatSinglereal0M.AssertModel(models[1],_testData[19], false);
                        FlatSinglereal0M.AssertModel(models[2],_testData[20], false);
                        FlatSinglereal0M.AssertModel(models[3],_testData[21], false);
                        FlatSinglereal0M.AssertModel(models[4],_testData[22], false);
                        FlatSinglereal0M.AssertModel(models[5],_testData[23], false);
                        FlatSinglereal0M.AssertModel(models[6],_testData[24], false);
                        FlatSinglereal0M.AssertModel(models[7],_testData[25], false);
                        FlatSinglereal0M.AssertModel(models[8],_testData[26], false);
                        FlatSinglereal0M.AssertModel(models[9],_testData[27], false);
                        FlatSinglereal0M.AssertModel(models[10],_testData[28], false);
                        FlatSinglereal0M.AssertModel(models[11],_testData[29], false);
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
                parametr1.Value = 16;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 66;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.singlereal0m m
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
FROM public.singlereal0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglereal0M>();
                var secondItems1 = new List<FlatSinglereal0M>();
                var secondItems2 = new List<FlatSinglereal0M>();
                 ((ISingleSingleTypereal)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatSinglereal0M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatSinglereal0M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatSinglereal0M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatSinglereal0M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatSinglereal0M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatSinglereal0M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatSinglereal0M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatSinglereal0M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatSinglereal0M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatSinglereal0M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatSinglereal0M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatSinglereal0M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatSinglereal0M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatSinglereal0M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatSinglereal0M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatSinglereal0M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatSinglereal0M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatSinglereal0M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatSinglereal0M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatSinglereal0M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatSinglereal0M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatSinglereal0M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatSinglereal0M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatSinglereal0M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatSinglereal0M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatSinglereal0M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatSinglereal0M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatSinglereal0M.AssertModel(firstItems1[27],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatSinglereal0M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatSinglereal0M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatSinglereal0M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatSinglereal0M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatSinglereal0M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatSinglereal0M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatSinglereal0M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatSinglereal0M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatSinglereal0M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatSinglereal0M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatSinglereal0M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatSinglereal0M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatSinglereal0M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatSinglereal0M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatSinglereal0M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatSinglereal0M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatSinglereal0M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatSinglereal0M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatSinglereal0M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatSinglereal0M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatSinglereal0M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatSinglereal0M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatSinglereal0M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatSinglereal0M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatSinglereal0M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatSinglereal0M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatSinglereal0M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatSinglereal0M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatSinglereal0M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatSinglereal0M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatSinglereal0M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatSinglereal0M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatSinglereal0M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatSinglereal0M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatSinglereal0M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatSinglereal0M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatSinglereal0M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatSinglereal0M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatSinglereal0M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatSinglereal0M.AssertModel(secondItems2[19],_testData[29], false);
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
FROM public.singlereal0m m
LEFT JOIN public.singlereal0mi mi ON mi.id = m.singlereal0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Singlereal0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleSingleTypereal)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleSingleTypereal)),
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
                var models = await((ISingleSingleTypereal)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Singlereal0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 72;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 126;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((ISingleSingleTypereal)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        Singlereal0M.AssertModel(models[0],_testData[11], false);
                        Singlereal0M.AssertModel(models[1],_testData[12], false);
                        Singlereal0M.AssertModel(models[2],_testData[13], false);
                        Singlereal0M.AssertModel(models[3],_testData[14], false);
                        Singlereal0M.AssertModel(models[4],_testData[15], false);
                        Singlereal0M.AssertModel(models[5],_testData[16], false);
                        Singlereal0M.AssertModel(models[6],_testData[17], false);
                        Singlereal0M.AssertModel(models[7],_testData[18], false);
                        Singlereal0M.AssertModel(models[8],_testData[19], false);
                        Singlereal0M.AssertModel(models[9],_testData[20], false);
                        Singlereal0M.AssertModel(models[10],_testData[21], false);
                        Singlereal0M.AssertModel(models[11],_testData[22], false);
                        Singlereal0M.AssertModel(models[12],_testData[23], false);
                        Singlereal0M.AssertModel(models[13],_testData[24], false);
                        Singlereal0M.AssertModel(models[14],_testData[25], false);
                        Singlereal0M.AssertModel(models[15],_testData[26], false);
                        Singlereal0M.AssertModel(models[16],_testData[27], false);
                        Singlereal0M.AssertModel(models[17],_testData[28], false);
                        Singlereal0M.AssertModel(models[18],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        Singlereal0M.AssertModel(models[0],_testData[19], false);
                        Singlereal0M.AssertModel(models[1],_testData[20], false);
                        Singlereal0M.AssertModel(models[2],_testData[21], false);
                        Singlereal0M.AssertModel(models[3],_testData[22], false);
                        Singlereal0M.AssertModel(models[4],_testData[23], false);
                        Singlereal0M.AssertModel(models[5],_testData[24], false);
                        Singlereal0M.AssertModel(models[6],_testData[25], false);
                        Singlereal0M.AssertModel(models[7],_testData[26], false);
                        Singlereal0M.AssertModel(models[8],_testData[27], false);
                        Singlereal0M.AssertModel(models[9],_testData[28], false);
                        Singlereal0M.AssertModel(models[10],_testData[29], false);
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
                var models = ((ISingleSingleTypereal)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Singlereal0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 66;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 25;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((ISingleSingleTypereal)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        Singlereal0M.AssertModel(models[0],_testData[10], false);
                        Singlereal0M.AssertModel(models[1],_testData[11], false);
                        Singlereal0M.AssertModel(models[2],_testData[12], false);
                        Singlereal0M.AssertModel(models[3],_testData[13], false);
                        Singlereal0M.AssertModel(models[4],_testData[14], false);
                        Singlereal0M.AssertModel(models[5],_testData[15], false);
                        Singlereal0M.AssertModel(models[6],_testData[16], false);
                        Singlereal0M.AssertModel(models[7],_testData[17], false);
                        Singlereal0M.AssertModel(models[8],_testData[18], false);
                        Singlereal0M.AssertModel(models[9],_testData[19], false);
                        Singlereal0M.AssertModel(models[10],_testData[20], false);
                        Singlereal0M.AssertModel(models[11],_testData[21], false);
                        Singlereal0M.AssertModel(models[12],_testData[22], false);
                        Singlereal0M.AssertModel(models[13],_testData[23], false);
                        Singlereal0M.AssertModel(models[14],_testData[24], false);
                        Singlereal0M.AssertModel(models[15],_testData[25], false);
                        Singlereal0M.AssertModel(models[16],_testData[26], false);
                        Singlereal0M.AssertModel(models[17],_testData[27], false);
                        Singlereal0M.AssertModel(models[18],_testData[28], false);
                        Singlereal0M.AssertModel(models[19],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        Singlereal0M.AssertModel(models[0],_testData[3], false);
                        Singlereal0M.AssertModel(models[1],_testData[4], false);
                        Singlereal0M.AssertModel(models[2],_testData[5], false);
                        Singlereal0M.AssertModel(models[3],_testData[6], false);
                        Singlereal0M.AssertModel(models[4],_testData[7], false);
                        Singlereal0M.AssertModel(models[5],_testData[8], false);
                        Singlereal0M.AssertModel(models[6],_testData[9], false);
                        Singlereal0M.AssertModel(models[7],_testData[10], false);
                        Singlereal0M.AssertModel(models[8],_testData[11], false);
                        Singlereal0M.AssertModel(models[9],_testData[12], false);
                        Singlereal0M.AssertModel(models[10],_testData[13], false);
                        Singlereal0M.AssertModel(models[11],_testData[14], false);
                        Singlereal0M.AssertModel(models[12],_testData[15], false);
                        Singlereal0M.AssertModel(models[13],_testData[16], false);
                        Singlereal0M.AssertModel(models[14],_testData[17], false);
                        Singlereal0M.AssertModel(models[15],_testData[18], false);
                        Singlereal0M.AssertModel(models[16],_testData[19], false);
                        Singlereal0M.AssertModel(models[17],_testData[20], false);
                        Singlereal0M.AssertModel(models[18],_testData[21], false);
                        Singlereal0M.AssertModel(models[19],_testData[22], false);
                        Singlereal0M.AssertModel(models[20],_testData[23], false);
                        Singlereal0M.AssertModel(models[21],_testData[24], false);
                        Singlereal0M.AssertModel(models[22],_testData[25], false);
                        Singlereal0M.AssertModel(models[23],_testData[26], false);
                        Singlereal0M.AssertModel(models[24],_testData[27], false);
                        Singlereal0M.AssertModel(models[25],_testData[28], false);
                        Singlereal0M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatSinglereal0M), typeof(FlatSinglereal0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleSingleTypereal)),
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
            asPartInterface: typeof(ISingleSingleTypereal)),
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
            asPartInterface: typeof(ISingleSingleTypereal)),
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
FROM public.singlereal0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatSinglereal0M>();
                var models2 = new List<FlatSinglereal0M>();
                await((ISingleSingleTypereal)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglereal0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglereal0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.singlereal0m m
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
FROM public.singlereal0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglereal0M>();
                var firstItems2 = new List<FlatSinglereal0M>();
                var secondItems1 = new List<FlatSinglereal0M>();
                var secondItems2 = new List<FlatSinglereal0M>();
                await ((ISingleSingleTypereal)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 97, query1, 61, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatSinglereal0M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatSinglereal0M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatSinglereal0M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatSinglereal0M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatSinglereal0M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatSinglereal0M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatSinglereal0M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatSinglereal0M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatSinglereal0M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatSinglereal0M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatSinglereal0M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatSinglereal0M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatSinglereal0M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatSinglereal0M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatSinglereal0M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatSinglereal0M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatSinglereal0M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatSinglereal0M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatSinglereal0M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatSinglereal0M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatSinglereal0M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatSinglereal0M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatSinglereal0M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatSinglereal0M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatSinglereal0M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatSinglereal0M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatSinglereal0M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatSinglereal0M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatSinglereal0M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatSinglereal0M.AssertModel(firstItems2[14],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatSinglereal0M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatSinglereal0M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatSinglereal0M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatSinglereal0M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatSinglereal0M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatSinglereal0M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatSinglereal0M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatSinglereal0M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatSinglereal0M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatSinglereal0M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatSinglereal0M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatSinglereal0M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatSinglereal0M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatSinglereal0M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatSinglereal0M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatSinglereal0M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatSinglereal0M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatSinglereal0M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatSinglereal0M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatSinglereal0M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatSinglereal0M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatSinglereal0M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatSinglereal0M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatSinglereal0M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatSinglereal0M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatSinglereal0M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatSinglereal0M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatSinglereal0M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatSinglereal0M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatSinglereal0M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatSinglereal0M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatSinglereal0M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatSinglereal0M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatSinglereal0M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatSinglereal0M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatSinglereal0M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatSinglereal0M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatSinglereal0M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatSinglereal0M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatSinglereal0M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatSinglereal0M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatSinglereal0M.AssertModel(secondItems2[20],_testData[29], false);
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
FROM public.singlereal0m m
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
FROM public.singlereal0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglereal0M>();
                var firstItems2 = new List<FlatSinglereal0M>();
                var secondItems1 = new List<FlatSinglereal0M>();
                await ((ISingleSingleTypereal)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 97, query1, 73, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatSinglereal0M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatSinglereal0M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatSinglereal0M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatSinglereal0M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatSinglereal0M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatSinglereal0M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatSinglereal0M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatSinglereal0M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatSinglereal0M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatSinglereal0M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatSinglereal0M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatSinglereal0M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatSinglereal0M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatSinglereal0M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatSinglereal0M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatSinglereal0M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatSinglereal0M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatSinglereal0M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatSinglereal0M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatSinglereal0M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatSinglereal0M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatSinglereal0M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatSinglereal0M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatSinglereal0M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatSinglereal0M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatSinglereal0M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatSinglereal0M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatSinglereal0M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatSinglereal0M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatSinglereal0M.AssertModel(firstItems2[14],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatSinglereal0M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatSinglereal0M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatSinglereal0M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatSinglereal0M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatSinglereal0M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatSinglereal0M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatSinglereal0M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatSinglereal0M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatSinglereal0M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatSinglereal0M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatSinglereal0M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatSinglereal0M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatSinglereal0M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatSinglereal0M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatSinglereal0M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatSinglereal0M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatSinglereal0M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatSinglereal0M.AssertModel(secondItems1[17],_testData[29], false);
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
FROM public.singlereal0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatSinglereal0M>();
                var models2 = new List<FlatSinglereal0M>();
                ((ISingleSingleTypereal)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglereal0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglereal0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.singlereal0m m
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
FROM public.singlereal0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglereal0M>();
                var firstItems2 = new List<FlatSinglereal0M>();
                var secondItems1 = new List<FlatSinglereal0M>();
                var secondItems2 = new List<FlatSinglereal0M>();
                 ((ISingleSingleTypereal)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 8, query1, 72, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatSinglereal0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatSinglereal0M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatSinglereal0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatSinglereal0M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatSinglereal0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatSinglereal0M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatSinglereal0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatSinglereal0M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatSinglereal0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatSinglereal0M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatSinglereal0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatSinglereal0M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatSinglereal0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatSinglereal0M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatSinglereal0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatSinglereal0M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatSinglereal0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatSinglereal0M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatSinglereal0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatSinglereal0M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatSinglereal0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatSinglereal0M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatSinglereal0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatSinglereal0M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatSinglereal0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatSinglereal0M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatSinglereal0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatSinglereal0M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatSinglereal0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatSinglereal0M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatSinglereal0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatSinglereal0M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatSinglereal0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatSinglereal0M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatSinglereal0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatSinglereal0M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatSinglereal0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatSinglereal0M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatSinglereal0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatSinglereal0M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatSinglereal0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatSinglereal0M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatSinglereal0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatSinglereal0M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatSinglereal0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatSinglereal0M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatSinglereal0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatSinglereal0M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatSinglereal0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatSinglereal0M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatSinglereal0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatSinglereal0M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatSinglereal0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatSinglereal0M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatSinglereal0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatSinglereal0M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatSinglereal0M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatSinglereal0M.AssertModel(firstItems2[28],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatSinglereal0M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatSinglereal0M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatSinglereal0M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatSinglereal0M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatSinglereal0M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatSinglereal0M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatSinglereal0M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatSinglereal0M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatSinglereal0M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatSinglereal0M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatSinglereal0M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatSinglereal0M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatSinglereal0M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatSinglereal0M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatSinglereal0M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatSinglereal0M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatSinglereal0M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatSinglereal0M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatSinglereal0M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatSinglereal0M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatSinglereal0M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatSinglereal0M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatSinglereal0M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatSinglereal0M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatSinglereal0M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatSinglereal0M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatSinglereal0M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatSinglereal0M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatSinglereal0M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatSinglereal0M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatSinglereal0M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatSinglereal0M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatSinglereal0M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatSinglereal0M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatSinglereal0M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatSinglereal0M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatSinglereal0M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatSinglereal0M.AssertModel(secondItems2[18],_testData[29], false);
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
FROM public.singlereal0m m
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
FROM public.singlereal0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglereal0M>();
                var firstItems2 = new List<FlatSinglereal0M>();
                var secondItems1 = new List<FlatSinglereal0M>();
                 ((ISingleSingleTypereal)this).DbConnectionMMDynQuerySelectModelBatch(connection, 66, query1, 160, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatSinglereal0M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatSinglereal0M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatSinglereal0M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatSinglereal0M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatSinglereal0M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatSinglereal0M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatSinglereal0M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatSinglereal0M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatSinglereal0M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatSinglereal0M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatSinglereal0M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatSinglereal0M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatSinglereal0M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatSinglereal0M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatSinglereal0M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatSinglereal0M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatSinglereal0M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatSinglereal0M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatSinglereal0M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatSinglereal0M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatSinglereal0M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatSinglereal0M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatSinglereal0M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatSinglereal0M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatSinglereal0M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatSinglereal0M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatSinglereal0M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatSinglereal0M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatSinglereal0M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatSinglereal0M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatSinglereal0M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatSinglereal0M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatSinglereal0M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatSinglereal0M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatSinglereal0M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatSinglereal0M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatSinglereal0M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatSinglereal0M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatSinglereal0M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatSinglereal0M.AssertModel(firstItems2[19],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatSinglereal0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatSinglereal0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatSinglereal0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatSinglereal0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatSinglereal0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatSinglereal0M.AssertModel(secondItems1[5],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatSinglereal0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleSingleTypereal)),
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
            asPartInterface: typeof(ISingleSingleTypereal)),
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
            asPartInterface: typeof(ISingleSingleTypereal)),
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
FROM public.singlereal0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((ISingleSingleTypereal)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglereal0M.AssertModel(models[i],_testData[i], false);
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
FROM public.singlereal0m m
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
FROM public.singlereal0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((ISingleSingleTypereal)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 106, query1, 16, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatSinglereal0M.AssertModel(models[0],_testData[16], false);
                        FlatSinglereal0M.AssertModel(models[1],_testData[17], false);
                        FlatSinglereal0M.AssertModel(models[2],_testData[18], false);
                        FlatSinglereal0M.AssertModel(models[3],_testData[19], false);
                        FlatSinglereal0M.AssertModel(models[4],_testData[20], false);
                        FlatSinglereal0M.AssertModel(models[5],_testData[21], false);
                        FlatSinglereal0M.AssertModel(models[6],_testData[22], false);
                        FlatSinglereal0M.AssertModel(models[7],_testData[23], false);
                        FlatSinglereal0M.AssertModel(models[8],_testData[24], false);
                        FlatSinglereal0M.AssertModel(models[9],_testData[25], false);
                        FlatSinglereal0M.AssertModel(models[10],_testData[26], false);
                        FlatSinglereal0M.AssertModel(models[11],_testData[27], false);
                        FlatSinglereal0M.AssertModel(models[12],_testData[28], false);
                        FlatSinglereal0M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatSinglereal0M.AssertModel(models[0],_testData[2], false);
                        FlatSinglereal0M.AssertModel(models[1],_testData[3], false);
                        FlatSinglereal0M.AssertModel(models[2],_testData[4], false);
                        FlatSinglereal0M.AssertModel(models[3],_testData[5], false);
                        FlatSinglereal0M.AssertModel(models[4],_testData[6], false);
                        FlatSinglereal0M.AssertModel(models[5],_testData[7], false);
                        FlatSinglereal0M.AssertModel(models[6],_testData[8], false);
                        FlatSinglereal0M.AssertModel(models[7],_testData[9], false);
                        FlatSinglereal0M.AssertModel(models[8],_testData[10], false);
                        FlatSinglereal0M.AssertModel(models[9],_testData[11], false);
                        FlatSinglereal0M.AssertModel(models[10],_testData[12], false);
                        FlatSinglereal0M.AssertModel(models[11],_testData[13], false);
                        FlatSinglereal0M.AssertModel(models[12],_testData[14], false);
                        FlatSinglereal0M.AssertModel(models[13],_testData[15], false);
                        FlatSinglereal0M.AssertModel(models[14],_testData[16], false);
                        FlatSinglereal0M.AssertModel(models[15],_testData[17], false);
                        FlatSinglereal0M.AssertModel(models[16],_testData[18], false);
                        FlatSinglereal0M.AssertModel(models[17],_testData[19], false);
                        FlatSinglereal0M.AssertModel(models[18],_testData[20], false);
                        FlatSinglereal0M.AssertModel(models[19],_testData[21], false);
                        FlatSinglereal0M.AssertModel(models[20],_testData[22], false);
                        FlatSinglereal0M.AssertModel(models[21],_testData[23], false);
                        FlatSinglereal0M.AssertModel(models[22],_testData[24], false);
                        FlatSinglereal0M.AssertModel(models[23],_testData[25], false);
                        FlatSinglereal0M.AssertModel(models[24],_testData[26], false);
                        FlatSinglereal0M.AssertModel(models[25],_testData[27], false);
                        FlatSinglereal0M.AssertModel(models[26],_testData[28], false);
                        FlatSinglereal0M.AssertModel(models[27],_testData[29], false);
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
FROM public.singlereal0m m
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
FROM public.singlereal0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglereal0M>();
                var secondItems1 = new List<FlatSinglereal0M>();
                var secondItems2 = new List<FlatSinglereal0M>();
                await ((ISingleSingleTypereal)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 129, query1, 25, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                        FlatSinglereal0M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatSinglereal0M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatSinglereal0M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatSinglereal0M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatSinglereal0M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatSinglereal0M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatSinglereal0M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatSinglereal0M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatSinglereal0M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatSinglereal0M.AssertModel(firstItems1[9],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatSinglereal0M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatSinglereal0M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatSinglereal0M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatSinglereal0M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatSinglereal0M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatSinglereal0M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatSinglereal0M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatSinglereal0M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatSinglereal0M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatSinglereal0M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatSinglereal0M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatSinglereal0M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatSinglereal0M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatSinglereal0M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatSinglereal0M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatSinglereal0M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatSinglereal0M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatSinglereal0M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatSinglereal0M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatSinglereal0M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatSinglereal0M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatSinglereal0M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatSinglereal0M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatSinglereal0M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatSinglereal0M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatSinglereal0M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatSinglereal0M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatSinglereal0M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatSinglereal0M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatSinglereal0M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatSinglereal0M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatSinglereal0M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatSinglereal0M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatSinglereal0M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatSinglereal0M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatSinglereal0M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatSinglereal0M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatSinglereal0M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatSinglereal0M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatSinglereal0M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatSinglereal0M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatSinglereal0M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatSinglereal0M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatSinglereal0M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatSinglereal0M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatSinglereal0M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatSinglereal0M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatSinglereal0M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatSinglereal0M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatSinglereal0M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatSinglereal0M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatSinglereal0M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatSinglereal0M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatSinglereal0M.AssertModel(secondItems2[26],_testData[29], false);
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
FROM public.singlereal0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((ISingleSingleTypereal)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatSinglereal0M.AssertModel(models[i],_testData[i], false);
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
FROM public.singlereal0m m
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
FROM public.singlereal0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((ISingleSingleTypereal)this).DbConnectionSTDynQuerySelectModelBatch(connection, 135, query1, 50, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatSinglereal0M.AssertModel(models[0],_testData[21], false);
                        FlatSinglereal0M.AssertModel(models[1],_testData[22], false);
                        FlatSinglereal0M.AssertModel(models[2],_testData[23], false);
                        FlatSinglereal0M.AssertModel(models[3],_testData[24], false);
                        FlatSinglereal0M.AssertModel(models[4],_testData[25], false);
                        FlatSinglereal0M.AssertModel(models[5],_testData[26], false);
                        FlatSinglereal0M.AssertModel(models[6],_testData[27], false);
                        FlatSinglereal0M.AssertModel(models[7],_testData[28], false);
                        FlatSinglereal0M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatSinglereal0M.AssertModel(models[0],_testData[7], false);
                        FlatSinglereal0M.AssertModel(models[1],_testData[8], false);
                        FlatSinglereal0M.AssertModel(models[2],_testData[9], false);
                        FlatSinglereal0M.AssertModel(models[3],_testData[10], false);
                        FlatSinglereal0M.AssertModel(models[4],_testData[11], false);
                        FlatSinglereal0M.AssertModel(models[5],_testData[12], false);
                        FlatSinglereal0M.AssertModel(models[6],_testData[13], false);
                        FlatSinglereal0M.AssertModel(models[7],_testData[14], false);
                        FlatSinglereal0M.AssertModel(models[8],_testData[15], false);
                        FlatSinglereal0M.AssertModel(models[9],_testData[16], false);
                        FlatSinglereal0M.AssertModel(models[10],_testData[17], false);
                        FlatSinglereal0M.AssertModel(models[11],_testData[18], false);
                        FlatSinglereal0M.AssertModel(models[12],_testData[19], false);
                        FlatSinglereal0M.AssertModel(models[13],_testData[20], false);
                        FlatSinglereal0M.AssertModel(models[14],_testData[21], false);
                        FlatSinglereal0M.AssertModel(models[15],_testData[22], false);
                        FlatSinglereal0M.AssertModel(models[16],_testData[23], false);
                        FlatSinglereal0M.AssertModel(models[17],_testData[24], false);
                        FlatSinglereal0M.AssertModel(models[18],_testData[25], false);
                        FlatSinglereal0M.AssertModel(models[19],_testData[26], false);
                        FlatSinglereal0M.AssertModel(models[20],_testData[27], false);
                        FlatSinglereal0M.AssertModel(models[21],_testData[28], false);
                        FlatSinglereal0M.AssertModel(models[22],_testData[29], false);
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
FROM public.singlereal0m m
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
FROM public.singlereal0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatSinglereal0M>();
                var secondItems1 = new List<FlatSinglereal0M>();
                var secondItems2 = new List<FlatSinglereal0M>();
                 ((ISingleSingleTypereal)this).DbConnectionDynQuerySelectModelBatch(connection, 25, query1, 33, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatSinglereal0M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatSinglereal0M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatSinglereal0M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatSinglereal0M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatSinglereal0M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatSinglereal0M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatSinglereal0M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatSinglereal0M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatSinglereal0M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatSinglereal0M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatSinglereal0M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatSinglereal0M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatSinglereal0M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatSinglereal0M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatSinglereal0M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatSinglereal0M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatSinglereal0M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatSinglereal0M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatSinglereal0M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatSinglereal0M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatSinglereal0M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatSinglereal0M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatSinglereal0M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatSinglereal0M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatSinglereal0M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatSinglereal0M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatSinglereal0M.AssertModel(firstItems1[26],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatSinglereal0M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatSinglereal0M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatSinglereal0M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatSinglereal0M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatSinglereal0M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatSinglereal0M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatSinglereal0M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatSinglereal0M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatSinglereal0M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatSinglereal0M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatSinglereal0M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatSinglereal0M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatSinglereal0M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatSinglereal0M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatSinglereal0M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatSinglereal0M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatSinglereal0M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatSinglereal0M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatSinglereal0M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatSinglereal0M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatSinglereal0M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatSinglereal0M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatSinglereal0M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatSinglereal0M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatSinglereal0M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatSinglereal0M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatSinglereal0M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatSinglereal0M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatSinglereal0M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatSinglereal0M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatSinglereal0M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatSinglereal0M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatSinglereal0M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatSinglereal0M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatSinglereal0M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatSinglereal0M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatSinglereal0M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatSinglereal0M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatSinglereal0M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatSinglereal0M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatSinglereal0M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatSinglereal0M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatSinglereal0M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatSinglereal0M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatSinglereal0M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatSinglereal0M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatSinglereal0M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatSinglereal0M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatSinglereal0M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatSinglereal0M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatSinglereal0M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatSinglereal0M.AssertModel(secondItems2[25],_testData[29], false);
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
FROM public.singlereal0m m
LEFT JOIN public.singlereal0mi mi ON mi.id = m.singlereal0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Singlereal0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleSingleTypereal)),
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
            asPartInterface: typeof(ISingleSingleTypereal)),
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
                var models = await((ISingleSingleTypereal)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Singlereal0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((ISingleSingleTypereal)this).DbConnectionSTSelectModelBatchAsync(connection, 106, 183))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        Singlereal0M.AssertModel(models[0],_testData[16], false);
                        Singlereal0M.AssertModel(models[1],_testData[17], false);
                        Singlereal0M.AssertModel(models[2],_testData[18], false);
                        Singlereal0M.AssertModel(models[3],_testData[19], false);
                        Singlereal0M.AssertModel(models[4],_testData[20], false);
                        Singlereal0M.AssertModel(models[5],_testData[21], false);
                        Singlereal0M.AssertModel(models[6],_testData[22], false);
                        Singlereal0M.AssertModel(models[7],_testData[23], false);
                        Singlereal0M.AssertModel(models[8],_testData[24], false);
                        Singlereal0M.AssertModel(models[9],_testData[25], false);
                        Singlereal0M.AssertModel(models[10],_testData[26], false);
                        Singlereal0M.AssertModel(models[11],_testData[27], false);
                        Singlereal0M.AssertModel(models[12],_testData[28], false);
                        Singlereal0M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        Singlereal0M.AssertModel(models[0],_testData[28], false);
                        Singlereal0M.AssertModel(models[1],_testData[29], false);
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
                var models = ((ISingleSingleTypereal)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Singlereal0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((ISingleSingleTypereal)this).DbConnectionSTSelectModelBatch(connection, 126, 174))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        Singlereal0M.AssertModel(models[0],_testData[19], false);
                        Singlereal0M.AssertModel(models[1],_testData[20], false);
                        Singlereal0M.AssertModel(models[2],_testData[21], false);
                        Singlereal0M.AssertModel(models[3],_testData[22], false);
                        Singlereal0M.AssertModel(models[4],_testData[23], false);
                        Singlereal0M.AssertModel(models[5],_testData[24], false);
                        Singlereal0M.AssertModel(models[6],_testData[25], false);
                        Singlereal0M.AssertModel(models[7],_testData[26], false);
                        Singlereal0M.AssertModel(models[8],_testData[27], false);
                        Singlereal0M.AssertModel(models[9],_testData[28], false);
                        Singlereal0M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        Singlereal0M.AssertModel(models[0],_testData[27], false);
                        Singlereal0M.AssertModel(models[1],_testData[28], false);
                        Singlereal0M.AssertModel(models[2],_testData[29], false);
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
                await using var cmd = await ((ISingleSingleTypereal)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((ISingleSingleTypereal)this).SetDbConnectionSelectModelParametrs(cmd, 183);
                var models = await ((ISingleSingleTypereal)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(2));
Singlereal0M.AssertModel(models[0],_testData[28], false);Singlereal0M.AssertModel(models[1],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((ISingleSingleTypereal)this).CreateDbConnectionSelectModelCommand(connection);
                ((ISingleSingleTypereal)this).SetDbConnectionSelectModelParametrs(cmd, 144);
                var models =  ((ISingleSingleTypereal)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(8));
Singlereal0M.AssertModel(models[0],_testData[22], false);Singlereal0M.AssertModel(models[1],_testData[23], false);Singlereal0M.AssertModel(models[2],_testData[24], false);Singlereal0M.AssertModel(models[3],_testData[25], false);Singlereal0M.AssertModel(models[4],_testData[26], false);Singlereal0M.AssertModel(models[5],_testData[27], false);Singlereal0M.AssertModel(models[6],_testData[28], false);Singlereal0M.AssertModel(models[7],_testData[29], false);
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
FROM public.singlereal0m m
LEFT JOIN public.singlereal0mi mi ON mi.id = m.singlereal0mi_id
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
            asPartInterface: typeof(ISingleSingleTypereal))]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((ISingleSingleTypereal)this).DbConnectionSelectModelToObjArrAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.92593175f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.5674554f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.50622165f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.34884733f)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.18729293f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.21692157f)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.50074786f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.84440374f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.8219275f)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.81755304f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.062339187f)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.838715f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.31652254f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.06992328f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.55391103f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.2804547f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.7578817f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.49843246f)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.69169015f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.54758984f)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.58397114f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.52310765f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.13653517f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.90735304f)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.9242343f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.5381929f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.7494592f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.38183767f)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.4897675f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.7066581f)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.40832514f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.37671918f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.5884552f)));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.29344314f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.7563124f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.4619661f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((111)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.52889436f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.51756996f)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.8920347f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.9600592f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.9732332f)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.4519927f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.23182392f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((56)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.52509004f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.6496707f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.26577282f)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.08879095f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.6133566f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.5559577f)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.61646813f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((160)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.56061465f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((70)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.4768721f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.6370988f)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((167)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.5580998f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.9849245f)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((168)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.9548218f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((76)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.6118525f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.09126228f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.5246711f)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((174)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.14525175f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.542351f)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((183)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.64399815f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((84)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.0023003817f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.48904634f)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((187)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.27757293f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.38518548f)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((191)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.72025f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((93)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.37507087f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.26557577f)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((ISingleSingleTypereal)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.92593175f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.5674554f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.50622165f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.34884733f)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.18729293f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.21692157f)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.50074786f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.84440374f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.8219275f)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.81755304f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.062339187f)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.838715f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.31652254f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.06992328f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.55391103f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.2804547f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.7578817f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.49843246f)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.69169015f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.54758984f)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.58397114f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.52310765f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.13653517f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.90735304f)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.9242343f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.5381929f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.7494592f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.38183767f)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.4897675f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.7066581f)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.40832514f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.37671918f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.5884552f)));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.29344314f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.7563124f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.4619661f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((111)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.52889436f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.51756996f)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.8920347f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.9600592f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.9732332f)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.4519927f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.23182392f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((56)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.52509004f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.6496707f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.26577282f)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.08879095f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.6133566f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.5559577f)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.61646813f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((160)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.56061465f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((70)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.4768721f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.6370988f)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((167)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.5580998f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.9849245f)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((168)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.9548218f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((76)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.6118525f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.09126228f)));//InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.5246711f)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((174)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.14525175f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.542351f)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((183)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.64399815f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((84)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.0023003817f)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Single?)model[5], Is.EqualTo((0.48904634f)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((187)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.27757293f)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Single?)model[5], Is.EqualTo((0.38518548f)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((191)));//Id
                Assert.That((System.Single)model[1], Is.EqualTo((0.72025f)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((93)));//InnerModel.Id
                Assert.That((System.Single)model[3], Is.EqualTo((0.37507087f)));//InnerModel.Value

                Assert.That((System.Single?)model[4], Is.EqualTo((0.26557577f)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

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
FROM public.binary_singlereal0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(Singlereal0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleSingleTypereal))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(Singlereal0MI),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(17),
                (NpgsqlTypes.NpgsqlDbType)(17)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleSingleTypereal))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<Singlereal0MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((ISingleSingleTypereal)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_singlereal0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((ISingleSingleTypereal)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Singlereal0MI.AssertModel(actual, expect, false);
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
                await ((ISingleSingleTypereal)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_singlereal0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
                models = await ((ISingleSingleTypereal)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Singlereal0MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_singlereal0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(Singlereal0MI),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(17),
                (NpgsqlTypes.NpgsqlDbType)(17)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleSingleTypereal))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<Singlereal0MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((ISingleSingleTypereal)this).ImportModelInner(connection, importCollection);
                var models = ((ISingleSingleTypereal)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Singlereal0MI.AssertModel(actual, expect, false);
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
                await ((ISingleSingleTypereal)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((ISingleSingleTypereal)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Singlereal0MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_singlereal0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
singlereal0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(Singlereal0M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(17),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(17)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleSingleTypereal))]
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
FROM public.binary_singlereal0m m
LEFT JOIN public.binary_singlereal0mi mi ON mi.id = m.singlereal0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(Singlereal0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleSingleTypereal))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<Singlereal0M>(15);

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
                ((ISingleSingleTypereal)this).ImportModel(connection, importCollection);
                var models = ((ISingleSingleTypereal)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                Singlereal0M.AssertModel(models[0],_testData[0], false);
                Singlereal0M.AssertModel(models[1],_testData[1], false);
                Singlereal0M.AssertModel(models[2],_testData[2], false);
                Singlereal0M.AssertModel(models[3],_testData[3], false);
                Singlereal0M.AssertModel(models[4],_testData[4], false);
                Singlereal0M.AssertModel(models[5],_testData[5], false);
                Singlereal0M.AssertModel(models[6],_testData[6], false);
                Singlereal0M.AssertModel(models[7],_testData[7], false);
                Singlereal0M.AssertModel(models[8],_testData[8], false);
                Singlereal0M.AssertModel(models[9],_testData[9], false);
                Singlereal0M.AssertModel(models[10],_testData[10], false);
                Singlereal0M.AssertModel(models[11],_testData[11], false);
                Singlereal0M.AssertModel(models[12],_testData[12], false);
                Singlereal0M.AssertModel(models[13],_testData[13], false);
                Singlereal0M.AssertModel(models[14],_testData[14], false);
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
                await ((ISingleSingleTypereal)this).ImportModelAsync(connection, importCollection);
                models = await ((ISingleSingleTypereal)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                Singlereal0M.AssertModel(models[0],_testData[0], false);
                Singlereal0M.AssertModel(models[1],_testData[1], false);
                Singlereal0M.AssertModel(models[2],_testData[2], false);
                Singlereal0M.AssertModel(models[3],_testData[3], false);
                Singlereal0M.AssertModel(models[4],_testData[4], false);
                Singlereal0M.AssertModel(models[5],_testData[5], false);
                Singlereal0M.AssertModel(models[6],_testData[6], false);
                Singlereal0M.AssertModel(models[7],_testData[7], false);
                Singlereal0M.AssertModel(models[8],_testData[8], false);
                Singlereal0M.AssertModel(models[9],_testData[9], false);
                Singlereal0M.AssertModel(models[10],_testData[10], false);
                Singlereal0M.AssertModel(models[11],_testData[11], false);
                Singlereal0M.AssertModel(models[12],_testData[12], false);
                Singlereal0M.AssertModel(models[13],_testData[13], false);
                Singlereal0M.AssertModel(models[14],_testData[14], false);
                Singlereal0M.AssertModel(models[15],_testData[15], false);
                Singlereal0M.AssertModel(models[16],_testData[16], false);
                Singlereal0M.AssertModel(models[17],_testData[17], false);
                Singlereal0M.AssertModel(models[18],_testData[18], false);
                Singlereal0M.AssertModel(models[19],_testData[19], false);
                Singlereal0M.AssertModel(models[20],_testData[20], false);
                Singlereal0M.AssertModel(models[21],_testData[21], false);
                Singlereal0M.AssertModel(models[22],_testData[22], false);
                Singlereal0M.AssertModel(models[23],_testData[23], false);
                Singlereal0M.AssertModel(models[24],_testData[24], false);
                Singlereal0M.AssertModel(models[25],_testData[25], false);
                Singlereal0M.AssertModel(models[26],_testData[26], false);
                Singlereal0M.AssertModel(models[27],_testData[27], false);
                Singlereal0M.AssertModel(models[28],_testData[28], false);
                Singlereal0M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_singlereal0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    singlereal0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(Singlereal0M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(17),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(17)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleSingleTypereal))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((ISingleSingleTypereal)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Singlereal0M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((ISingleSingleTypereal)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Singlereal0M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_singlereal0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(Singlereal0MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(17),
                (NpgsqlTypes.NpgsqlDbType)(17)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISingleSingleTypereal))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((ISingleSingleTypereal)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Singlereal0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((ISingleSingleTypereal)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Singlereal0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

