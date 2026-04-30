

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
    internal partial interface IDoubleSingleTypedouble_precision
    {
    }
    
    internal partial class DoubleSingleTypedouble_precision : IDoubleSingleTypedouble_precision
    {


#region TestData

        private readonly Doubledouble_precision0M[] _testData = new Doubledouble_precision0M[]
        {
            new Doubledouble_precision0M
{
    Id = 7,
    Value = 0.9448213404941678d,
    ModelInner = null,
    NullableValue = 0.7524548310805063d,
},
            new Doubledouble_precision0M
{
    Id = 12,
    Value = 0.16320087545451112d,
    ModelInner = new Doubledouble_precision0MI
{
    Id = 3,
    Value = 0.6397495834374819d,
    NullableValue = 0.7700091605734821d,
},
    NullableValue = null,
},
            new Doubledouble_precision0M
{
    Id = 19,
    Value = 0.534171449068471d,
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precision0M
{
    Id = 20,
    Value = 0.8796841115014437d,
    ModelInner = new Doubledouble_precision0MI
{
    Id = 5,
    Value = 0.06658139298578059d,
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precision0M
{
    Id = 21,
    Value = 0.6817651562235054d,
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precision0M
{
    Id = 23,
    Value = 0.6263981917224904d,
    ModelInner = new Doubledouble_precision0MI
{
    Id = 12,
    Value = 0.8626922947963109d,
    NullableValue = 0.8712883908090345d,
},
    NullableValue = null,
},
            new Doubledouble_precision0M
{
    Id = 32,
    Value = 0.7565381568484054d,
    ModelInner = null,
    NullableValue = 0.7013721430012196d,
},
            new Doubledouble_precision0M
{
    Id = 37,
    Value = 0.4082115393276263d,
    ModelInner = new Doubledouble_precision0MI
{
    Id = 13,
    Value = 0.11583987805789964d,
    NullableValue = null,
},
    NullableValue = 0.19972460347875876d,
},
            new Doubledouble_precision0M
{
    Id = 41,
    Value = 0.8192818512693733d,
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precision0M
{
    Id = 47,
    Value = 0.8802867154648053d,
    ModelInner = new Doubledouble_precision0MI
{
    Id = 14,
    Value = 0.11095272122395716d,
    NullableValue = 0.1957071466827779d,
},
    NullableValue = null,
},
            new Doubledouble_precision0M
{
    Id = 48,
    Value = 0.45885488381840256d,
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precision0M
{
    Id = 52,
    Value = 0.47600665796760067d,
    ModelInner = new Doubledouble_precision0MI
{
    Id = 19,
    Value = 0.09207947538631933d,
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precision0M
{
    Id = 59,
    Value = 0.29527725208689004d,
    ModelInner = null,
    NullableValue = 0.008893695219337472d,
},
            new Doubledouble_precision0M
{
    Id = 63,
    Value = 0.06598940328316649d,
    ModelInner = new Doubledouble_precision0MI
{
    Id = 24,
    Value = 0.40517435013691483d,
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precision0M
{
    Id = 65,
    Value = 0.4978707456059619d,
    ModelInner = null,
    NullableValue = 0.7970815468658342d,
},
            new Doubledouble_precision0M
{
    Id = 73,
    Value = 0.6445929468374544d,
    ModelInner = new Doubledouble_precision0MI
{
    Id = 27,
    Value = 0.7791318365143978d,
    NullableValue = null,
},
    NullableValue = 0.29776630027131423d,
},
            new Doubledouble_precision0M
{
    Id = 77,
    Value = 0.8644279727712072d,
    ModelInner = null,
    NullableValue = 0.8755785372266581d,
},
            new Doubledouble_precision0M
{
    Id = 81,
    Value = 0.5955049640208139d,
    ModelInner = new Doubledouble_precision0MI
{
    Id = 28,
    Value = 0.9229399001906534d,
    NullableValue = null,
},
    NullableValue = 0.22163651330331047d,
},
            new Doubledouble_precision0M
{
    Id = 86,
    Value = 0.8492826203446507d,
    ModelInner = null,
    NullableValue = 0.07892175508353216d,
},
            new Doubledouble_precision0M
{
    Id = 87,
    Value = 0.46004646778861946d,
    ModelInner = new Doubledouble_precision0MI
{
    Id = 31,
    Value = 0.9935737117982478d,
    NullableValue = 0.13583235128978233d,
},
    NullableValue = null,
},
            new Doubledouble_precision0M
{
    Id = 93,
    Value = 0.5517982083907524d,
    ModelInner = null,
    NullableValue = 0.0339800925022955d,
},
            new Doubledouble_precision0M
{
    Id = 98,
    Value = 0.11044753138209873d,
    ModelInner = new Doubledouble_precision0MI
{
    Id = 34,
    Value = 0.1721300757792732d,
    NullableValue = null,
},
    NullableValue = 0.034818103772162656d,
},
            new Doubledouble_precision0M
{
    Id = 99,
    Value = 0.523532457375127d,
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precision0M
{
    Id = 108,
    Value = 0.46200699749605945d,
    ModelInner = new Doubledouble_precision0MI
{
    Id = 43,
    Value = 0.2039487917699837d,
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precision0M
{
    Id = 112,
    Value = 0.6059877836088715d,
    ModelInner = null,
    NullableValue = 0.1724907633929581d,
},
            new Doubledouble_precision0M
{
    Id = 113,
    Value = 0.6196248296554085d,
    ModelInner = new Doubledouble_precision0MI
{
    Id = 46,
    Value = 0.39035787005162215d,
    NullableValue = 0.7563764796072651d,
},
    NullableValue = null,
},
            new Doubledouble_precision0M
{
    Id = 117,
    Value = 0.11267666377487728d,
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precision0M
{
    Id = 123,
    Value = 0.665686749099487d,
    ModelInner = new Doubledouble_precision0MI
{
    Id = 51,
    Value = 0.5473658434337078d,
    NullableValue = null,
},
    NullableValue = 0.06656276062374167d,
},
            new Doubledouble_precision0M
{
    Id = 126,
    Value = 0.22267401881480053d,
    ModelInner = null,
    NullableValue = 0.8522674344747551d,
},
            new Doubledouble_precision0M
{
    Id = 128,
    Value = 0.579873836713809d,
    ModelInner = new Doubledouble_precision0MI
{
    Id = 58,
    Value = 0.4208223817334248d,
    NullableValue = 0.3379525110322612d,
},
    NullableValue = 0.6421703219302842d,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precision0mi(
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
            asPartInterface: typeof(IDoubleSingleTypedouble_precision)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(8)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double?), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(8))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precision0mi(
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
            queryMapTypes: [typeof(Doubledouble_precision0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble_precision)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(8)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(8))]
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

                changedRows =  ((IDoubleSingleTypedouble_precision)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDoubleSingleTypedouble_precision)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IDoubleSingleTypedouble_precision)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble_precision)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IDoubleSingleTypedouble_precision)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IDoubleSingleTypedouble_precision)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IDoubleSingleTypedouble_precision)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IDoubleSingleTypedouble_precision)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precision0mi(
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
            asPartInterface: typeof(IDoubleSingleTypedouble_precision)), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Double), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(8)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Double?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(8), 
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

                changedRows =  ((IDoubleSingleTypedouble_precision)this).DbConnectionInsertInnerModel(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
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

                changedRows = await ((IDoubleSingleTypedouble_precision)this).DbConnectionInsertInnerModelAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble_precision)this).DbConnectionInsertInnerModelAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble_precision)this).DbConnectionInsertInnerModelAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble_precision)this).DbConnectionInsertInnerModelAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble_precision)this).DbConnectionInsertInnerModelAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble_precision)this).DbConnectionInsertInnerModelAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precision0m(
	id,
    value,
    nullablevalue,
    doubledouble_precision0mi_id
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
            asPartInterface: typeof(IDoubleSingleTypedouble_precision)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(8)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(8)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "doubledouble_precision0mi_id", 
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
                changedRows =  ((IDoubleSingleTypedouble_precision)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IDoubleSingleTypedouble_precision)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IDoubleSingleTypedouble_precision)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IDoubleSingleTypedouble_precision)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precision0m(
	id,
    value,
    nullablevalue,
    doubledouble_precision0mi_id
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
    doubledouble_precision0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(Doubledouble_precision0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble_precision)),
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
                System.Double? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<System.Double>();
                    ((NpgsqlParameter<System.Double>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(8);
                    ((NpgsqlParameter<System.Double>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(8);
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

                    nullable =  ((IDoubleSingleTypedouble_precision)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<System.Double>();
                    ((NpgsqlParameter<System.Double>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(8);
                    ((NpgsqlParameter<System.Double>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(8);
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

                    nullable =  ((IDoubleSingleTypedouble_precision)this).ScalarInsertModelDynParReturning(connection, parameters);
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
                System.Double? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<System.Double>();
                    ((NpgsqlParameter<System.Double>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(8);
                    ((NpgsqlParameter<System.Double>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(8);
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

                    nullable = await ((IDoubleSingleTypedouble_precision)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(0.7013721430012196d));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<System.Double>();
                    ((NpgsqlParameter<System.Double>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(8);
                    ((NpgsqlParameter<System.Double>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(8);
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

                    nullable = await ((IDoubleSingleTypedouble_precision)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(0.19972460347875876d));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precision0m(
	id,
    value,
    nullablevalue,
    doubledouble_precision0mi_id
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
    doubledouble_precision0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(Doubledouble_precision0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble_precision)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(8)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(8)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "doubledouble_precision0mi_id", 
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
                System.Double? nullable = null;
                nullable =  ((IDoubleSingleTypedouble_precision)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((IDoubleSingleTypedouble_precision)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Double? nullable = null;
                nullable = await ((IDoubleSingleTypedouble_precision)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((IDoubleSingleTypedouble_precision)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Doubledouble_precision0M> models = null;

                models =  ((IDoubleSingleTypedouble_precision)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precision0M.AssertModel(models[0],_testData[12], true);
                models =  ((IDoubleSingleTypedouble_precision)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precision0M.AssertModel(models[0],_testData[13], true);
                models =  ((IDoubleSingleTypedouble_precision)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precision0M.AssertModel(models[0],_testData[14], true);
                models =  ((IDoubleSingleTypedouble_precision)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precision0M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Doubledouble_precision0M> models = null;

                models = await ((IDoubleSingleTypedouble_precision)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precision0M.AssertModel(models[0],_testData[16], true);
                models = await ((IDoubleSingleTypedouble_precision)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precision0M.AssertModel(models[0],_testData[17], true);
                models = await ((IDoubleSingleTypedouble_precision)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precision0M.AssertModel(models[0],_testData[18], true);
                models = await ((IDoubleSingleTypedouble_precision)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precision0M.AssertModel(models[0],_testData[19], true);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precision0m(
	id,
    value,
    nullablevalue,
    doubledouble_precision0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @doubledouble_precision0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble_precision)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Double), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(8)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Double?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(8),
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "doubledouble_precision0mi_id", 
                methodParametrName: "doubledouble_precision0mi_id", 
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

                changedRows =  ((IDoubleSingleTypedouble_precision)this).DbConnectionInsertModel(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDoubleSingleTypedouble_precision)this).DbConnectionInsertModel(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
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

                changedRows = await ((IDoubleSingleTypedouble_precision)this).DbConnectionInsertModelAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble_precision)this).DbConnectionInsertModelAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble_precision)this).DbConnectionInsertModelAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble_precision)this).DbConnectionInsertModelAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble_precision)this).DbConnectionInsertModelAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble_precision)this).DbConnectionInsertModelAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble_precision)this).DbConnectionInsertModelAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleSingleTypedouble_precision)this).DbConnectionInsertModelAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precision0M), typeof(FlatDoubledouble_precision0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble_precision)),
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
FROM public.doubledouble_precision0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDoubledouble_precision0M>();
                var models2 = new List<FlatDoubledouble_precision0M>();
                await ((IDoubleSingleTypedouble_precision)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precision0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precision0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.doubledouble_precision0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDoubledouble_precision0M>();
                var models2 = new List<FlatDoubledouble_precision0M>();
                ((IDoubleSingleTypedouble_precision)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precision0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precision0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precision0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble_precision)),
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
FROM public.doubledouble_precision0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IDoubleSingleTypedouble_precision)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precision0M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precision0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IDoubleSingleTypedouble_precision)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precision0M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precision0m m
LEFT JOIN public.doubledouble_precision0mi mi ON mi.id = m.doubledouble_precision0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Doubledouble_precision0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble_precision)),
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
                var models = await ((IDoubleSingleTypedouble_precision)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Doubledouble_precision0M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IDoubleSingleTypedouble_precision)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Doubledouble_precision0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precision0M), typeof(FlatDoubledouble_precision0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble_precision)),
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
FROM public.doubledouble_precision0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precision0M>();
                var models2 = new List<FlatDoubledouble_precision0M>();
                await ((IDoubleSingleTypedouble_precision)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precision0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precision0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.doubledouble_precision0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precision0M>();
                var models2 = new List<FlatDoubledouble_precision0M>();
                ((IDoubleSingleTypedouble_precision)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precision0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precision0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precision0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble_precision)),
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
FROM public.doubledouble_precision0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IDoubleSingleTypedouble_precision)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precision0M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precision0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IDoubleSingleTypedouble_precision)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precision0M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precision0m m
LEFT JOIN public.doubledouble_precision0mi mi ON mi.id = m.doubledouble_precision0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Doubledouble_precision0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble_precision)),
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
                var models = await ((IDoubleSingleTypedouble_precision)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Doubledouble_precision0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IDoubleSingleTypedouble_precision)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Doubledouble_precision0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precision0M), typeof(FlatDoubledouble_precision0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble_precision)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble_precision)),
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
            asPartInterface: typeof(IDoubleSingleTypedouble_precision)),
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
FROM public.doubledouble_precision0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDoubledouble_precision0M>();
                var models2 = new List<FlatDoubledouble_precision0M>();
                await((IDoubleSingleTypedouble_precision)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precision0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precision0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 19;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 93;
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
FROM public.doubledouble_precision0m m
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
FROM public.doubledouble_precision0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precision0M>();
                var firstItems2 = new List<FlatDoubledouble_precision0M>();
                var secondItems1 = new List<FlatDoubledouble_precision0M>();
                var secondItems2 = new List<FlatDoubledouble_precision0M>();
                await ((IDoubleSingleTypedouble_precision)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[26],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[8],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 52;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 59;
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
FROM public.doubledouble_precision0m m
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
FROM public.doubledouble_precision0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precision0M>();
                var firstItems2 = new List<FlatDoubledouble_precision0M>();
                var secondItems1 = new List<FlatDoubledouble_precision0M>();
                await ((IDoubleSingleTypedouble_precision)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[17],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[16],_testData[29], false);
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
FROM public.doubledouble_precision0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDoubledouble_precision0M>();
                var models2 = new List<FlatDoubledouble_precision0M>();
                ((IDoubleSingleTypedouble_precision)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precision0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precision0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 77;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 112;
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
FROM public.doubledouble_precision0m m
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
FROM public.doubledouble_precision0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precision0M>();
                var firstItems2 = new List<FlatDoubledouble_precision0M>();
                var secondItems1 = new List<FlatDoubledouble_precision0M>();
                var secondItems2 = new List<FlatDoubledouble_precision0M>();
                 ((IDoubleSingleTypedouble_precision)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[12],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[4],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 59;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 59;
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
FROM public.doubledouble_precision0m m
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
FROM public.doubledouble_precision0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precision0M>();
                var firstItems2 = new List<FlatDoubledouble_precision0M>();
                var secondItems1 = new List<FlatDoubledouble_precision0M>();
                 ((IDoubleSingleTypedouble_precision)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[16],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[16],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precision0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble_precision)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble_precision)),
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
            asPartInterface: typeof(IDoubleSingleTypedouble_precision)),
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
FROM public.doubledouble_precision0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IDoubleSingleTypedouble_precision)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precision0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 12;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 99;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precision0m m
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
FROM public.doubledouble_precision0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleSingleTypedouble_precision)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatDoubledouble_precision0M.AssertModel(models[0],_testData[2], false);
                        FlatDoubledouble_precision0M.AssertModel(models[1],_testData[3], false);
                        FlatDoubledouble_precision0M.AssertModel(models[2],_testData[4], false);
                        FlatDoubledouble_precision0M.AssertModel(models[3],_testData[5], false);
                        FlatDoubledouble_precision0M.AssertModel(models[4],_testData[6], false);
                        FlatDoubledouble_precision0M.AssertModel(models[5],_testData[7], false);
                        FlatDoubledouble_precision0M.AssertModel(models[6],_testData[8], false);
                        FlatDoubledouble_precision0M.AssertModel(models[7],_testData[9], false);
                        FlatDoubledouble_precision0M.AssertModel(models[8],_testData[10], false);
                        FlatDoubledouble_precision0M.AssertModel(models[9],_testData[11], false);
                        FlatDoubledouble_precision0M.AssertModel(models[10],_testData[12], false);
                        FlatDoubledouble_precision0M.AssertModel(models[11],_testData[13], false);
                        FlatDoubledouble_precision0M.AssertModel(models[12],_testData[14], false);
                        FlatDoubledouble_precision0M.AssertModel(models[13],_testData[15], false);
                        FlatDoubledouble_precision0M.AssertModel(models[14],_testData[16], false);
                        FlatDoubledouble_precision0M.AssertModel(models[15],_testData[17], false);
                        FlatDoubledouble_precision0M.AssertModel(models[16],_testData[18], false);
                        FlatDoubledouble_precision0M.AssertModel(models[17],_testData[19], false);
                        FlatDoubledouble_precision0M.AssertModel(models[18],_testData[20], false);
                        FlatDoubledouble_precision0M.AssertModel(models[19],_testData[21], false);
                        FlatDoubledouble_precision0M.AssertModel(models[20],_testData[22], false);
                        FlatDoubledouble_precision0M.AssertModel(models[21],_testData[23], false);
                        FlatDoubledouble_precision0M.AssertModel(models[22],_testData[24], false);
                        FlatDoubledouble_precision0M.AssertModel(models[23],_testData[25], false);
                        FlatDoubledouble_precision0M.AssertModel(models[24],_testData[26], false);
                        FlatDoubledouble_precision0M.AssertModel(models[25],_testData[27], false);
                        FlatDoubledouble_precision0M.AssertModel(models[26],_testData[28], false);
                        FlatDoubledouble_precision0M.AssertModel(models[27],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatDoubledouble_precision0M.AssertModel(models[0],_testData[23], false);
                        FlatDoubledouble_precision0M.AssertModel(models[1],_testData[24], false);
                        FlatDoubledouble_precision0M.AssertModel(models[2],_testData[25], false);
                        FlatDoubledouble_precision0M.AssertModel(models[3],_testData[26], false);
                        FlatDoubledouble_precision0M.AssertModel(models[4],_testData[27], false);
                        FlatDoubledouble_precision0M.AssertModel(models[5],_testData[28], false);
                        FlatDoubledouble_precision0M.AssertModel(models[6],_testData[29], false);
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
                parametr1.Value = 87;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 86;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precision0m m
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
FROM public.doubledouble_precision0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precision0M>();
                var secondItems1 = new List<FlatDoubledouble_precision0M>();
                var secondItems2 = new List<FlatDoubledouble_precision0M>();
                await ((IDoubleSingleTypedouble_precision)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[9],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[10],_testData[29], false);
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
FROM public.doubledouble_precision0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IDoubleSingleTypedouble_precision)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precision0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 21;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 48;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precision0m m
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
FROM public.doubledouble_precision0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleSingleTypedouble_precision)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatDoubledouble_precision0M.AssertModel(models[0],_testData[5], false);
                        FlatDoubledouble_precision0M.AssertModel(models[1],_testData[6], false);
                        FlatDoubledouble_precision0M.AssertModel(models[2],_testData[7], false);
                        FlatDoubledouble_precision0M.AssertModel(models[3],_testData[8], false);
                        FlatDoubledouble_precision0M.AssertModel(models[4],_testData[9], false);
                        FlatDoubledouble_precision0M.AssertModel(models[5],_testData[10], false);
                        FlatDoubledouble_precision0M.AssertModel(models[6],_testData[11], false);
                        FlatDoubledouble_precision0M.AssertModel(models[7],_testData[12], false);
                        FlatDoubledouble_precision0M.AssertModel(models[8],_testData[13], false);
                        FlatDoubledouble_precision0M.AssertModel(models[9],_testData[14], false);
                        FlatDoubledouble_precision0M.AssertModel(models[10],_testData[15], false);
                        FlatDoubledouble_precision0M.AssertModel(models[11],_testData[16], false);
                        FlatDoubledouble_precision0M.AssertModel(models[12],_testData[17], false);
                        FlatDoubledouble_precision0M.AssertModel(models[13],_testData[18], false);
                        FlatDoubledouble_precision0M.AssertModel(models[14],_testData[19], false);
                        FlatDoubledouble_precision0M.AssertModel(models[15],_testData[20], false);
                        FlatDoubledouble_precision0M.AssertModel(models[16],_testData[21], false);
                        FlatDoubledouble_precision0M.AssertModel(models[17],_testData[22], false);
                        FlatDoubledouble_precision0M.AssertModel(models[18],_testData[23], false);
                        FlatDoubledouble_precision0M.AssertModel(models[19],_testData[24], false);
                        FlatDoubledouble_precision0M.AssertModel(models[20],_testData[25], false);
                        FlatDoubledouble_precision0M.AssertModel(models[21],_testData[26], false);
                        FlatDoubledouble_precision0M.AssertModel(models[22],_testData[27], false);
                        FlatDoubledouble_precision0M.AssertModel(models[23],_testData[28], false);
                        FlatDoubledouble_precision0M.AssertModel(models[24],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatDoubledouble_precision0M.AssertModel(models[0],_testData[11], false);
                        FlatDoubledouble_precision0M.AssertModel(models[1],_testData[12], false);
                        FlatDoubledouble_precision0M.AssertModel(models[2],_testData[13], false);
                        FlatDoubledouble_precision0M.AssertModel(models[3],_testData[14], false);
                        FlatDoubledouble_precision0M.AssertModel(models[4],_testData[15], false);
                        FlatDoubledouble_precision0M.AssertModel(models[5],_testData[16], false);
                        FlatDoubledouble_precision0M.AssertModel(models[6],_testData[17], false);
                        FlatDoubledouble_precision0M.AssertModel(models[7],_testData[18], false);
                        FlatDoubledouble_precision0M.AssertModel(models[8],_testData[19], false);
                        FlatDoubledouble_precision0M.AssertModel(models[9],_testData[20], false);
                        FlatDoubledouble_precision0M.AssertModel(models[10],_testData[21], false);
                        FlatDoubledouble_precision0M.AssertModel(models[11],_testData[22], false);
                        FlatDoubledouble_precision0M.AssertModel(models[12],_testData[23], false);
                        FlatDoubledouble_precision0M.AssertModel(models[13],_testData[24], false);
                        FlatDoubledouble_precision0M.AssertModel(models[14],_testData[25], false);
                        FlatDoubledouble_precision0M.AssertModel(models[15],_testData[26], false);
                        FlatDoubledouble_precision0M.AssertModel(models[16],_testData[27], false);
                        FlatDoubledouble_precision0M.AssertModel(models[17],_testData[28], false);
                        FlatDoubledouble_precision0M.AssertModel(models[18],_testData[29], false);
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
                parametr1.Value = 86;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 21;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precision0m m
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
FROM public.doubledouble_precision0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precision0M>();
                var secondItems1 = new List<FlatDoubledouble_precision0M>();
                var secondItems2 = new List<FlatDoubledouble_precision0M>();
                 ((IDoubleSingleTypedouble_precision)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[10],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[24],_testData[29], false);
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
FROM public.doubledouble_precision0m m
LEFT JOIN public.doubledouble_precision0mi mi ON mi.id = m.doubledouble_precision0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Doubledouble_precision0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble_precision)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble_precision)),
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
                var models = await((IDoubleSingleTypedouble_precision)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Doubledouble_precision0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 86;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 86;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleSingleTypedouble_precision)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        Doubledouble_precision0M.AssertModel(models[0],_testData[19], false);
                        Doubledouble_precision0M.AssertModel(models[1],_testData[20], false);
                        Doubledouble_precision0M.AssertModel(models[2],_testData[21], false);
                        Doubledouble_precision0M.AssertModel(models[3],_testData[22], false);
                        Doubledouble_precision0M.AssertModel(models[4],_testData[23], false);
                        Doubledouble_precision0M.AssertModel(models[5],_testData[24], false);
                        Doubledouble_precision0M.AssertModel(models[6],_testData[25], false);
                        Doubledouble_precision0M.AssertModel(models[7],_testData[26], false);
                        Doubledouble_precision0M.AssertModel(models[8],_testData[27], false);
                        Doubledouble_precision0M.AssertModel(models[9],_testData[28], false);
                        Doubledouble_precision0M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        Doubledouble_precision0M.AssertModel(models[0],_testData[19], false);
                        Doubledouble_precision0M.AssertModel(models[1],_testData[20], false);
                        Doubledouble_precision0M.AssertModel(models[2],_testData[21], false);
                        Doubledouble_precision0M.AssertModel(models[3],_testData[22], false);
                        Doubledouble_precision0M.AssertModel(models[4],_testData[23], false);
                        Doubledouble_precision0M.AssertModel(models[5],_testData[24], false);
                        Doubledouble_precision0M.AssertModel(models[6],_testData[25], false);
                        Doubledouble_precision0M.AssertModel(models[7],_testData[26], false);
                        Doubledouble_precision0M.AssertModel(models[8],_testData[27], false);
                        Doubledouble_precision0M.AssertModel(models[9],_testData[28], false);
                        Doubledouble_precision0M.AssertModel(models[10],_testData[29], false);
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
                var models = ((IDoubleSingleTypedouble_precision)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Doubledouble_precision0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 59;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 98;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleSingleTypedouble_precision)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        Doubledouble_precision0M.AssertModel(models[0],_testData[13], false);
                        Doubledouble_precision0M.AssertModel(models[1],_testData[14], false);
                        Doubledouble_precision0M.AssertModel(models[2],_testData[15], false);
                        Doubledouble_precision0M.AssertModel(models[3],_testData[16], false);
                        Doubledouble_precision0M.AssertModel(models[4],_testData[17], false);
                        Doubledouble_precision0M.AssertModel(models[5],_testData[18], false);
                        Doubledouble_precision0M.AssertModel(models[6],_testData[19], false);
                        Doubledouble_precision0M.AssertModel(models[7],_testData[20], false);
                        Doubledouble_precision0M.AssertModel(models[8],_testData[21], false);
                        Doubledouble_precision0M.AssertModel(models[9],_testData[22], false);
                        Doubledouble_precision0M.AssertModel(models[10],_testData[23], false);
                        Doubledouble_precision0M.AssertModel(models[11],_testData[24], false);
                        Doubledouble_precision0M.AssertModel(models[12],_testData[25], false);
                        Doubledouble_precision0M.AssertModel(models[13],_testData[26], false);
                        Doubledouble_precision0M.AssertModel(models[14],_testData[27], false);
                        Doubledouble_precision0M.AssertModel(models[15],_testData[28], false);
                        Doubledouble_precision0M.AssertModel(models[16],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        Doubledouble_precision0M.AssertModel(models[0],_testData[22], false);
                        Doubledouble_precision0M.AssertModel(models[1],_testData[23], false);
                        Doubledouble_precision0M.AssertModel(models[2],_testData[24], false);
                        Doubledouble_precision0M.AssertModel(models[3],_testData[25], false);
                        Doubledouble_precision0M.AssertModel(models[4],_testData[26], false);
                        Doubledouble_precision0M.AssertModel(models[5],_testData[27], false);
                        Doubledouble_precision0M.AssertModel(models[6],_testData[28], false);
                        Doubledouble_precision0M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precision0M), typeof(FlatDoubledouble_precision0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble_precision)),
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
            asPartInterface: typeof(IDoubleSingleTypedouble_precision)),
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
            asPartInterface: typeof(IDoubleSingleTypedouble_precision)),
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
FROM public.doubledouble_precision0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precision0M>();
                var models2 = new List<FlatDoubledouble_precision0M>();
                await((IDoubleSingleTypedouble_precision)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precision0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precision0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.doubledouble_precision0m m
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
FROM public.doubledouble_precision0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precision0M>();
                var firstItems2 = new List<FlatDoubledouble_precision0M>();
                var secondItems1 = new List<FlatDoubledouble_precision0M>();
                var secondItems2 = new List<FlatDoubledouble_precision0M>();
                await ((IDoubleSingleTypedouble_precision)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 98, query1, 63, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[7],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[15],_testData[29], false);
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
FROM public.doubledouble_precision0m m
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
FROM public.doubledouble_precision0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precision0M>();
                var firstItems2 = new List<FlatDoubledouble_precision0M>();
                var secondItems1 = new List<FlatDoubledouble_precision0M>();
                await ((IDoubleSingleTypedouble_precision)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 37, query1, 108, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[21],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[5],_testData[29], false);
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
FROM public.doubledouble_precision0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precision0M>();
                var models2 = new List<FlatDoubledouble_precision0M>();
                ((IDoubleSingleTypedouble_precision)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precision0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precision0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.doubledouble_precision0m m
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
FROM public.doubledouble_precision0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precision0M>();
                var firstItems2 = new List<FlatDoubledouble_precision0M>();
                var secondItems1 = new List<FlatDoubledouble_precision0M>();
                var secondItems2 = new List<FlatDoubledouble_precision0M>();
                 ((IDoubleSingleTypedouble_precision)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 117, query1, 59, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[2],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[16],_testData[29], false);
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
FROM public.doubledouble_precision0m m
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
FROM public.doubledouble_precision0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precision0M>();
                var firstItems2 = new List<FlatDoubledouble_precision0M>();
                var secondItems1 = new List<FlatDoubledouble_precision0M>();
                 ((IDoubleSingleTypedouble_precision)this).DbConnectionMMDynQuerySelectModelBatch(connection, 123, query1, 77, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems2[1],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[12],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precision0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble_precision)),
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
            asPartInterface: typeof(IDoubleSingleTypedouble_precision)),
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
            asPartInterface: typeof(IDoubleSingleTypedouble_precision)),
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
FROM public.doubledouble_precision0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IDoubleSingleTypedouble_precision)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precision0M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precision0m m
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
FROM public.doubledouble_precision0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleSingleTypedouble_precision)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 52, query1, 113, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatDoubledouble_precision0M.AssertModel(models[0],_testData[12], false);
                        FlatDoubledouble_precision0M.AssertModel(models[1],_testData[13], false);
                        FlatDoubledouble_precision0M.AssertModel(models[2],_testData[14], false);
                        FlatDoubledouble_precision0M.AssertModel(models[3],_testData[15], false);
                        FlatDoubledouble_precision0M.AssertModel(models[4],_testData[16], false);
                        FlatDoubledouble_precision0M.AssertModel(models[5],_testData[17], false);
                        FlatDoubledouble_precision0M.AssertModel(models[6],_testData[18], false);
                        FlatDoubledouble_precision0M.AssertModel(models[7],_testData[19], false);
                        FlatDoubledouble_precision0M.AssertModel(models[8],_testData[20], false);
                        FlatDoubledouble_precision0M.AssertModel(models[9],_testData[21], false);
                        FlatDoubledouble_precision0M.AssertModel(models[10],_testData[22], false);
                        FlatDoubledouble_precision0M.AssertModel(models[11],_testData[23], false);
                        FlatDoubledouble_precision0M.AssertModel(models[12],_testData[24], false);
                        FlatDoubledouble_precision0M.AssertModel(models[13],_testData[25], false);
                        FlatDoubledouble_precision0M.AssertModel(models[14],_testData[26], false);
                        FlatDoubledouble_precision0M.AssertModel(models[15],_testData[27], false);
                        FlatDoubledouble_precision0M.AssertModel(models[16],_testData[28], false);
                        FlatDoubledouble_precision0M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatDoubledouble_precision0M.AssertModel(models[0],_testData[26], false);
                        FlatDoubledouble_precision0M.AssertModel(models[1],_testData[27], false);
                        FlatDoubledouble_precision0M.AssertModel(models[2],_testData[28], false);
                        FlatDoubledouble_precision0M.AssertModel(models[3],_testData[29], false);
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
FROM public.doubledouble_precision0m m
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
FROM public.doubledouble_precision0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precision0M>();
                var secondItems1 = new List<FlatDoubledouble_precision0M>();
                var secondItems2 = new List<FlatDoubledouble_precision0M>();
                await ((IDoubleSingleTypedouble_precision)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 108, query1, 19, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[5],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[26],_testData[29], false);
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
FROM public.doubledouble_precision0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IDoubleSingleTypedouble_precision)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precision0M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precision0m m
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
FROM public.doubledouble_precision0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleSingleTypedouble_precision)this).DbConnectionSTDynQuerySelectModelBatch(connection, 47, query1, 52, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatDoubledouble_precision0M.AssertModel(models[0],_testData[10], false);
                        FlatDoubledouble_precision0M.AssertModel(models[1],_testData[11], false);
                        FlatDoubledouble_precision0M.AssertModel(models[2],_testData[12], false);
                        FlatDoubledouble_precision0M.AssertModel(models[3],_testData[13], false);
                        FlatDoubledouble_precision0M.AssertModel(models[4],_testData[14], false);
                        FlatDoubledouble_precision0M.AssertModel(models[5],_testData[15], false);
                        FlatDoubledouble_precision0M.AssertModel(models[6],_testData[16], false);
                        FlatDoubledouble_precision0M.AssertModel(models[7],_testData[17], false);
                        FlatDoubledouble_precision0M.AssertModel(models[8],_testData[18], false);
                        FlatDoubledouble_precision0M.AssertModel(models[9],_testData[19], false);
                        FlatDoubledouble_precision0M.AssertModel(models[10],_testData[20], false);
                        FlatDoubledouble_precision0M.AssertModel(models[11],_testData[21], false);
                        FlatDoubledouble_precision0M.AssertModel(models[12],_testData[22], false);
                        FlatDoubledouble_precision0M.AssertModel(models[13],_testData[23], false);
                        FlatDoubledouble_precision0M.AssertModel(models[14],_testData[24], false);
                        FlatDoubledouble_precision0M.AssertModel(models[15],_testData[25], false);
                        FlatDoubledouble_precision0M.AssertModel(models[16],_testData[26], false);
                        FlatDoubledouble_precision0M.AssertModel(models[17],_testData[27], false);
                        FlatDoubledouble_precision0M.AssertModel(models[18],_testData[28], false);
                        FlatDoubledouble_precision0M.AssertModel(models[19],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatDoubledouble_precision0M.AssertModel(models[0],_testData[12], false);
                        FlatDoubledouble_precision0M.AssertModel(models[1],_testData[13], false);
                        FlatDoubledouble_precision0M.AssertModel(models[2],_testData[14], false);
                        FlatDoubledouble_precision0M.AssertModel(models[3],_testData[15], false);
                        FlatDoubledouble_precision0M.AssertModel(models[4],_testData[16], false);
                        FlatDoubledouble_precision0M.AssertModel(models[5],_testData[17], false);
                        FlatDoubledouble_precision0M.AssertModel(models[6],_testData[18], false);
                        FlatDoubledouble_precision0M.AssertModel(models[7],_testData[19], false);
                        FlatDoubledouble_precision0M.AssertModel(models[8],_testData[20], false);
                        FlatDoubledouble_precision0M.AssertModel(models[9],_testData[21], false);
                        FlatDoubledouble_precision0M.AssertModel(models[10],_testData[22], false);
                        FlatDoubledouble_precision0M.AssertModel(models[11],_testData[23], false);
                        FlatDoubledouble_precision0M.AssertModel(models[12],_testData[24], false);
                        FlatDoubledouble_precision0M.AssertModel(models[13],_testData[25], false);
                        FlatDoubledouble_precision0M.AssertModel(models[14],_testData[26], false);
                        FlatDoubledouble_precision0M.AssertModel(models[15],_testData[27], false);
                        FlatDoubledouble_precision0M.AssertModel(models[16],_testData[28], false);
                        FlatDoubledouble_precision0M.AssertModel(models[17],_testData[29], false);
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
FROM public.doubledouble_precision0m m
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
FROM public.doubledouble_precision0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precision0M>();
                var secondItems1 = new List<FlatDoubledouble_precision0M>();
                var secondItems2 = new List<FlatDoubledouble_precision0M>();
                 ((IDoubleSingleTypedouble_precision)this).DbConnectionDynQuerySelectModelBatch(connection, 47, query1, 117, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatDoubledouble_precision0M.AssertModel(firstItems1[19],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatDoubledouble_precision0M.AssertModel(secondItems2[2],_testData[29], false);
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
FROM public.doubledouble_precision0m m
LEFT JOIN public.doubledouble_precision0mi mi ON mi.id = m.doubledouble_precision0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Doubledouble_precision0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble_precision)),
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
            asPartInterface: typeof(IDoubleSingleTypedouble_precision)),
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
                var models = await((IDoubleSingleTypedouble_precision)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Doubledouble_precision0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IDoubleSingleTypedouble_precision)this).DbConnectionSTSelectModelBatchAsync(connection, 108, 81))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        Doubledouble_precision0M.AssertModel(models[0],_testData[24], false);
                        Doubledouble_precision0M.AssertModel(models[1],_testData[25], false);
                        Doubledouble_precision0M.AssertModel(models[2],_testData[26], false);
                        Doubledouble_precision0M.AssertModel(models[3],_testData[27], false);
                        Doubledouble_precision0M.AssertModel(models[4],_testData[28], false);
                        Doubledouble_precision0M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        Doubledouble_precision0M.AssertModel(models[0],_testData[18], false);
                        Doubledouble_precision0M.AssertModel(models[1],_testData[19], false);
                        Doubledouble_precision0M.AssertModel(models[2],_testData[20], false);
                        Doubledouble_precision0M.AssertModel(models[3],_testData[21], false);
                        Doubledouble_precision0M.AssertModel(models[4],_testData[22], false);
                        Doubledouble_precision0M.AssertModel(models[5],_testData[23], false);
                        Doubledouble_precision0M.AssertModel(models[6],_testData[24], false);
                        Doubledouble_precision0M.AssertModel(models[7],_testData[25], false);
                        Doubledouble_precision0M.AssertModel(models[8],_testData[26], false);
                        Doubledouble_precision0M.AssertModel(models[9],_testData[27], false);
                        Doubledouble_precision0M.AssertModel(models[10],_testData[28], false);
                        Doubledouble_precision0M.AssertModel(models[11],_testData[29], false);
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
                var models = ((IDoubleSingleTypedouble_precision)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Doubledouble_precision0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IDoubleSingleTypedouble_precision)this).DbConnectionSTSelectModelBatch(connection, 99, 7))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        Doubledouble_precision0M.AssertModel(models[0],_testData[23], false);
                        Doubledouble_precision0M.AssertModel(models[1],_testData[24], false);
                        Doubledouble_precision0M.AssertModel(models[2],_testData[25], false);
                        Doubledouble_precision0M.AssertModel(models[3],_testData[26], false);
                        Doubledouble_precision0M.AssertModel(models[4],_testData[27], false);
                        Doubledouble_precision0M.AssertModel(models[5],_testData[28], false);
                        Doubledouble_precision0M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        Doubledouble_precision0M.AssertModel(models[0],_testData[1], false);
                        Doubledouble_precision0M.AssertModel(models[1],_testData[2], false);
                        Doubledouble_precision0M.AssertModel(models[2],_testData[3], false);
                        Doubledouble_precision0M.AssertModel(models[3],_testData[4], false);
                        Doubledouble_precision0M.AssertModel(models[4],_testData[5], false);
                        Doubledouble_precision0M.AssertModel(models[5],_testData[6], false);
                        Doubledouble_precision0M.AssertModel(models[6],_testData[7], false);
                        Doubledouble_precision0M.AssertModel(models[7],_testData[8], false);
                        Doubledouble_precision0M.AssertModel(models[8],_testData[9], false);
                        Doubledouble_precision0M.AssertModel(models[9],_testData[10], false);
                        Doubledouble_precision0M.AssertModel(models[10],_testData[11], false);
                        Doubledouble_precision0M.AssertModel(models[11],_testData[12], false);
                        Doubledouble_precision0M.AssertModel(models[12],_testData[13], false);
                        Doubledouble_precision0M.AssertModel(models[13],_testData[14], false);
                        Doubledouble_precision0M.AssertModel(models[14],_testData[15], false);
                        Doubledouble_precision0M.AssertModel(models[15],_testData[16], false);
                        Doubledouble_precision0M.AssertModel(models[16],_testData[17], false);
                        Doubledouble_precision0M.AssertModel(models[17],_testData[18], false);
                        Doubledouble_precision0M.AssertModel(models[18],_testData[19], false);
                        Doubledouble_precision0M.AssertModel(models[19],_testData[20], false);
                        Doubledouble_precision0M.AssertModel(models[20],_testData[21], false);
                        Doubledouble_precision0M.AssertModel(models[21],_testData[22], false);
                        Doubledouble_precision0M.AssertModel(models[22],_testData[23], false);
                        Doubledouble_precision0M.AssertModel(models[23],_testData[24], false);
                        Doubledouble_precision0M.AssertModel(models[24],_testData[25], false);
                        Doubledouble_precision0M.AssertModel(models[25],_testData[26], false);
                        Doubledouble_precision0M.AssertModel(models[26],_testData[27], false);
                        Doubledouble_precision0M.AssertModel(models[27],_testData[28], false);
                        Doubledouble_precision0M.AssertModel(models[28],_testData[29], false);
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
                await using var cmd = await ((IDoubleSingleTypedouble_precision)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IDoubleSingleTypedouble_precision)this).SetDbConnectionSelectModelParametrs(cmd, 32);
                var models = await ((IDoubleSingleTypedouble_precision)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(23));
Doubledouble_precision0M.AssertModel(models[0],_testData[7], false);Doubledouble_precision0M.AssertModel(models[1],_testData[8], false);Doubledouble_precision0M.AssertModel(models[2],_testData[9], false);Doubledouble_precision0M.AssertModel(models[3],_testData[10], false);Doubledouble_precision0M.AssertModel(models[4],_testData[11], false);Doubledouble_precision0M.AssertModel(models[5],_testData[12], false);Doubledouble_precision0M.AssertModel(models[6],_testData[13], false);Doubledouble_precision0M.AssertModel(models[7],_testData[14], false);Doubledouble_precision0M.AssertModel(models[8],_testData[15], false);Doubledouble_precision0M.AssertModel(models[9],_testData[16], false);Doubledouble_precision0M.AssertModel(models[10],_testData[17], false);Doubledouble_precision0M.AssertModel(models[11],_testData[18], false);Doubledouble_precision0M.AssertModel(models[12],_testData[19], false);Doubledouble_precision0M.AssertModel(models[13],_testData[20], false);Doubledouble_precision0M.AssertModel(models[14],_testData[21], false);Doubledouble_precision0M.AssertModel(models[15],_testData[22], false);Doubledouble_precision0M.AssertModel(models[16],_testData[23], false);Doubledouble_precision0M.AssertModel(models[17],_testData[24], false);Doubledouble_precision0M.AssertModel(models[18],_testData[25], false);Doubledouble_precision0M.AssertModel(models[19],_testData[26], false);Doubledouble_precision0M.AssertModel(models[20],_testData[27], false);Doubledouble_precision0M.AssertModel(models[21],_testData[28], false);Doubledouble_precision0M.AssertModel(models[22],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDoubleSingleTypedouble_precision)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDoubleSingleTypedouble_precision)this).SetDbConnectionSelectModelParametrs(cmd, 81);
                var models =  ((IDoubleSingleTypedouble_precision)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(12));
Doubledouble_precision0M.AssertModel(models[0],_testData[18], false);Doubledouble_precision0M.AssertModel(models[1],_testData[19], false);Doubledouble_precision0M.AssertModel(models[2],_testData[20], false);Doubledouble_precision0M.AssertModel(models[3],_testData[21], false);Doubledouble_precision0M.AssertModel(models[4],_testData[22], false);Doubledouble_precision0M.AssertModel(models[5],_testData[23], false);Doubledouble_precision0M.AssertModel(models[6],_testData[24], false);Doubledouble_precision0M.AssertModel(models[7],_testData[25], false);Doubledouble_precision0M.AssertModel(models[8],_testData[26], false);Doubledouble_precision0M.AssertModel(models[9],_testData[27], false);Doubledouble_precision0M.AssertModel(models[10],_testData[28], false);Doubledouble_precision0M.AssertModel(models[11],_testData[29], false);
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
FROM public.doubledouble_precision0m m
LEFT JOIN public.doubledouble_precision0mi mi ON mi.id = m.doubledouble_precision0mi_id
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
            asPartInterface: typeof(IDoubleSingleTypedouble_precision))]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDoubleSingleTypedouble_precision)this).DbConnectionSelectModelToObjArrAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9448213404941678d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.7524548310805063d)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.16320087545451112d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((3)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.6397495834374819d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.7700091605734821d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.534171449068471d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8796841115014437d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((5)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.06658139298578059d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6817651562235054d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6263981917224904d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.8626922947963109d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.8712883908090345d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((32)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7565381568484054d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.7013721430012196d)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.4082115393276263d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.11583987805789964d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.19972460347875876d)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8192818512693733d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8802867154648053d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.11095272122395716d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.1957071466827779d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.45885488381840256d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.47600665796760067d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.09207947538631933d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.29527725208689004d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.008893695219337472d)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.06598940328316649d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.40517435013691483d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.4978707456059619d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.7970815468658342d)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6445929468374544d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.7791318365143978d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.29776630027131423d)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8644279727712072d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.8755785372266581d)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5955049640208139d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.9229399001906534d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.22163651330331047d)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8492826203446507d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.07892175508353216d)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.46004646778861946d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.9935737117982478d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.13583235128978233d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5517982083907524d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.0339800925022955d)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.11044753138209873d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.1721300757792732d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.034818103772162656d)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.523532457375127d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.46200699749605945d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.2039487917699837d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6059877836088715d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.1724907633929581d)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6196248296554085d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.39035787005162215d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.7563764796072651d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.11267666377487728d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.665686749099487d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.5473658434337078d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.06656276062374167d)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.22267401881480053d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.8522674344747551d)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.579873836713809d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.4208223817334248d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.3379525110322612d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.6421703219302842d)));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((IDoubleSingleTypedouble_precision)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.9448213404941678d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.7524548310805063d)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.16320087545451112d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((3)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.6397495834374819d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.7700091605734821d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.534171449068471d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8796841115014437d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((5)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.06658139298578059d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6817651562235054d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6263981917224904d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.8626922947963109d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.8712883908090345d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((32)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.7565381568484054d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.7013721430012196d)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.4082115393276263d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.11583987805789964d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.19972460347875876d)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8192818512693733d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8802867154648053d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.11095272122395716d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.1957071466827779d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.45885488381840256d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.47600665796760067d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.09207947538631933d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.29527725208689004d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.008893695219337472d)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.06598940328316649d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.40517435013691483d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.4978707456059619d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.7970815468658342d)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6445929468374544d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.7791318365143978d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.29776630027131423d)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8644279727712072d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.8755785372266581d)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5955049640208139d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.9229399001906534d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.22163651330331047d)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.8492826203446507d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.07892175508353216d)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.46004646778861946d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.9935737117982478d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.13583235128978233d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.5517982083907524d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.0339800925022955d)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.11044753138209873d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.1721300757792732d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.034818103772162656d)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.523532457375127d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.46200699749605945d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.2039487917699837d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6059877836088715d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.1724907633929581d)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.6196248296554085d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.39035787005162215d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.7563764796072651d)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.11267666377487728d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.665686749099487d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.5473658434337078d)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Double?)model[5], Is.EqualTo((0.06656276062374167d)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.22267401881480053d)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.8522674344747551d)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((System.Double)model[1], Is.EqualTo((0.579873836713809d)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((System.Double)model[3], Is.EqualTo((0.4208223817334248d)));//InnerModel.Value

                Assert.That((System.Double?)model[4], Is.EqualTo((0.3379525110322612d)));//InnerModel.NullableValue

                Assert.That((System.Double?)model[5], Is.EqualTo((0.6421703219302842d)));

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
FROM public.binary_doubledouble_precision0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precision0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble_precision))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(Doubledouble_precision0MI),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(8),
                (NpgsqlTypes.NpgsqlDbType)(8)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble_precision))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<Doubledouble_precision0MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((IDoubleSingleTypedouble_precision)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_doubledouble_precision0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDoubleSingleTypedouble_precision)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precision0MI.AssertModel(actual, expect, false);
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
                await ((IDoubleSingleTypedouble_precision)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_doubledouble_precision0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
                models = await ((IDoubleSingleTypedouble_precision)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precision0MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_doubledouble_precision0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(Doubledouble_precision0MI),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(8),
                (NpgsqlTypes.NpgsqlDbType)(8)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble_precision))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<Doubledouble_precision0MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((IDoubleSingleTypedouble_precision)this).ImportModelInner(connection, importCollection);
                var models = ((IDoubleSingleTypedouble_precision)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precision0MI.AssertModel(actual, expect, false);
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
                await ((IDoubleSingleTypedouble_precision)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((IDoubleSingleTypedouble_precision)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precision0MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_doubledouble_precision0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
doubledouble_precision0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(Doubledouble_precision0M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(8),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(8)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble_precision))]
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
FROM public.binary_doubledouble_precision0m m
LEFT JOIN public.binary_doubledouble_precision0mi mi ON mi.id = m.doubledouble_precision0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(Doubledouble_precision0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble_precision))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<Doubledouble_precision0M>(15);

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
                ((IDoubleSingleTypedouble_precision)this).ImportModel(connection, importCollection);
                var models = ((IDoubleSingleTypedouble_precision)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                Doubledouble_precision0M.AssertModel(models[0],_testData[0], false);
                Doubledouble_precision0M.AssertModel(models[1],_testData[1], false);
                Doubledouble_precision0M.AssertModel(models[2],_testData[2], false);
                Doubledouble_precision0M.AssertModel(models[3],_testData[3], false);
                Doubledouble_precision0M.AssertModel(models[4],_testData[4], false);
                Doubledouble_precision0M.AssertModel(models[5],_testData[5], false);
                Doubledouble_precision0M.AssertModel(models[6],_testData[6], false);
                Doubledouble_precision0M.AssertModel(models[7],_testData[7], false);
                Doubledouble_precision0M.AssertModel(models[8],_testData[8], false);
                Doubledouble_precision0M.AssertModel(models[9],_testData[9], false);
                Doubledouble_precision0M.AssertModel(models[10],_testData[10], false);
                Doubledouble_precision0M.AssertModel(models[11],_testData[11], false);
                Doubledouble_precision0M.AssertModel(models[12],_testData[12], false);
                Doubledouble_precision0M.AssertModel(models[13],_testData[13], false);
                Doubledouble_precision0M.AssertModel(models[14],_testData[14], false);
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
                await ((IDoubleSingleTypedouble_precision)this).ImportModelAsync(connection, importCollection);
                models = await ((IDoubleSingleTypedouble_precision)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                Doubledouble_precision0M.AssertModel(models[0],_testData[0], false);
                Doubledouble_precision0M.AssertModel(models[1],_testData[1], false);
                Doubledouble_precision0M.AssertModel(models[2],_testData[2], false);
                Doubledouble_precision0M.AssertModel(models[3],_testData[3], false);
                Doubledouble_precision0M.AssertModel(models[4],_testData[4], false);
                Doubledouble_precision0M.AssertModel(models[5],_testData[5], false);
                Doubledouble_precision0M.AssertModel(models[6],_testData[6], false);
                Doubledouble_precision0M.AssertModel(models[7],_testData[7], false);
                Doubledouble_precision0M.AssertModel(models[8],_testData[8], false);
                Doubledouble_precision0M.AssertModel(models[9],_testData[9], false);
                Doubledouble_precision0M.AssertModel(models[10],_testData[10], false);
                Doubledouble_precision0M.AssertModel(models[11],_testData[11], false);
                Doubledouble_precision0M.AssertModel(models[12],_testData[12], false);
                Doubledouble_precision0M.AssertModel(models[13],_testData[13], false);
                Doubledouble_precision0M.AssertModel(models[14],_testData[14], false);
                Doubledouble_precision0M.AssertModel(models[15],_testData[15], false);
                Doubledouble_precision0M.AssertModel(models[16],_testData[16], false);
                Doubledouble_precision0M.AssertModel(models[17],_testData[17], false);
                Doubledouble_precision0M.AssertModel(models[18],_testData[18], false);
                Doubledouble_precision0M.AssertModel(models[19],_testData[19], false);
                Doubledouble_precision0M.AssertModel(models[20],_testData[20], false);
                Doubledouble_precision0M.AssertModel(models[21],_testData[21], false);
                Doubledouble_precision0M.AssertModel(models[22],_testData[22], false);
                Doubledouble_precision0M.AssertModel(models[23],_testData[23], false);
                Doubledouble_precision0M.AssertModel(models[24],_testData[24], false);
                Doubledouble_precision0M.AssertModel(models[25],_testData[25], false);
                Doubledouble_precision0M.AssertModel(models[26],_testData[26], false);
                Doubledouble_precision0M.AssertModel(models[27],_testData[27], false);
                Doubledouble_precision0M.AssertModel(models[28],_testData[28], false);
                Doubledouble_precision0M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_doubledouble_precision0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    doubledouble_precision0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(Doubledouble_precision0M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(8),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(8)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble_precision))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IDoubleSingleTypedouble_precision)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Doubledouble_precision0M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDoubleSingleTypedouble_precision)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Doubledouble_precision0M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_doubledouble_precision0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precision0MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(8),
                (NpgsqlTypes.NpgsqlDbType)(8)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleSingleTypedouble_precision))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IDoubleSingleTypedouble_precision)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precision0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDoubleSingleTypedouble_precision)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precision0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

