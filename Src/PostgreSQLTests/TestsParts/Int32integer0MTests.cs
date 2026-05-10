

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
    internal partial interface IInt32SingleTypeinteger
    {
    }
    
    internal partial class Int32SingleTypeinteger : IInt32SingleTypeinteger
    {


#region TestData

        private readonly Int32integer0M[] _testData = new Int32integer0M[]
        {
            new Int32integer0M
{
    Id = 5,
    Value = 863264306,
    ModelInner = null,
    NullableValue = 565132054,
},
            new Int32integer0M
{
    Id = 11,
    Value = 532599951,
    ModelInner = new Int32integer0MI
{
    Id = 9,
    Value = 733948815,
    NullableValue = 807789609,
},
    NullableValue = 732739339,
},
            new Int32integer0M
{
    Id = 15,
    Value = 1650497074,
    ModelInner = null,
    NullableValue = null,
},
            new Int32integer0M
{
    Id = 19,
    Value = 387354268,
    ModelInner = new Int32integer0MI
{
    Id = 15,
    Value = 284294551,
    NullableValue = null,
},
    NullableValue = 44252744,
},
            new Int32integer0M
{
    Id = 20,
    Value = 824633956,
    ModelInner = null,
    NullableValue = 492913314,
},
            new Int32integer0M
{
    Id = 25,
    Value = 1740007440,
    ModelInner = new Int32integer0MI
{
    Id = 23,
    Value = 1591693268,
    NullableValue = null,
},
    NullableValue = 1678376481,
},
            new Int32integer0M
{
    Id = 32,
    Value = 1388524369,
    ModelInner = null,
    NullableValue = null,
},
            new Int32integer0M
{
    Id = 36,
    Value = 1135803696,
    ModelInner = new Int32integer0MI
{
    Id = 28,
    Value = 1318090189,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32integer0M
{
    Id = 44,
    Value = 426145945,
    ModelInner = null,
    NullableValue = 93446614,
},
            new Int32integer0M
{
    Id = 47,
    Value = 655339140,
    ModelInner = new Int32integer0MI
{
    Id = 36,
    Value = 1851449971,
    NullableValue = 92788900,
},
    NullableValue = null,
},
            new Int32integer0M
{
    Id = 55,
    Value = 296973577,
    ModelInner = null,
    NullableValue = null,
},
            new Int32integer0M
{
    Id = 58,
    Value = 969691040,
    ModelInner = new Int32integer0MI
{
    Id = 39,
    Value = 1180267586,
    NullableValue = null,
},
    NullableValue = 352636132,
},
            new Int32integer0M
{
    Id = 64,
    Value = 1253204398,
    ModelInner = null,
    NullableValue = 474878944,
},
            new Int32integer0M
{
    Id = 70,
    Value = 1424838068,
    ModelInner = new Int32integer0MI
{
    Id = 43,
    Value = 547681241,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32integer0M
{
    Id = 72,
    Value = 1774055583,
    ModelInner = null,
    NullableValue = null,
},
            new Int32integer0M
{
    Id = 75,
    Value = 332076046,
    ModelInner = new Int32integer0MI
{
    Id = 46,
    Value = 2146180320,
    NullableValue = null,
},
    NullableValue = 2069314942,
},
            new Int32integer0M
{
    Id = 77,
    Value = 1746210490,
    ModelInner = null,
    NullableValue = 894013392,
},
            new Int32integer0M
{
    Id = 78,
    Value = 1380763957,
    ModelInner = new Int32integer0MI
{
    Id = 55,
    Value = 1894364893,
    NullableValue = null,
},
    NullableValue = 383136669,
},
            new Int32integer0M
{
    Id = 86,
    Value = 84530087,
    ModelInner = null,
    NullableValue = null,
},
            new Int32integer0M
{
    Id = 95,
    Value = 1588239328,
    ModelInner = new Int32integer0MI
{
    Id = 59,
    Value = 1298897226,
    NullableValue = 1545783407,
},
    NullableValue = null,
},
            new Int32integer0M
{
    Id = 98,
    Value = 1180191800,
    ModelInner = null,
    NullableValue = 1949465557,
},
            new Int32integer0M
{
    Id = 106,
    Value = 451530834,
    ModelInner = new Int32integer0MI
{
    Id = 62,
    Value = 209573302,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32integer0M
{
    Id = 113,
    Value = 55311352,
    ModelInner = null,
    NullableValue = null,
},
            new Int32integer0M
{
    Id = 115,
    Value = 451475929,
    ModelInner = new Int32integer0MI
{
    Id = 66,
    Value = 288871835,
    NullableValue = 543961138,
},
    NullableValue = 1594028355,
},
            new Int32integer0M
{
    Id = 116,
    Value = 540625818,
    ModelInner = null,
    NullableValue = null,
},
            new Int32integer0M
{
    Id = 124,
    Value = 1666630376,
    ModelInner = new Int32integer0MI
{
    Id = 71,
    Value = 1132163527,
    NullableValue = 1522410067,
},
    NullableValue = null,
},
            new Int32integer0M
{
    Id = 128,
    Value = 729227072,
    ModelInner = null,
    NullableValue = null,
},
            new Int32integer0M
{
    Id = 132,
    Value = 706871551,
    ModelInner = new Int32integer0MI
{
    Id = 77,
    Value = 2141511187,
    NullableValue = 1519108371,
},
    NullableValue = null,
},
            new Int32integer0M
{
    Id = 134,
    Value = 819623006,
    ModelInner = null,
    NullableValue = 256627897,
},
            new Int32integer0M
{
    Id = 138,
    Value = 759681742,
    ModelInner = new Int32integer0MI
{
    Id = 83,
    Value = 20604625,
    NullableValue = 330092012,
},
    NullableValue = 240957128,
},
            new Int32integer0M
{
    Id = 143,
    Value = 1671192237,
    ModelInner = null,
    NullableValue = null,
},
            new Int32integer0M
{
    Id = 152,
    Value = 96936614,
    ModelInner = new Int32integer0MI
{
    Id = 85,
    Value = 1807649167,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32integer0M
{
    Id = 159,
    Value = 904670973,
    ModelInner = null,
    NullableValue = 451216628,
},
            new Int32integer0M
{
    Id = 163,
    Value = 185615827,
    ModelInner = new Int32integer0MI
{
    Id = 86,
    Value = 542260815,
    NullableValue = 1272561774,
},
    NullableValue = null,
},
            new Int32integer0M
{
    Id = 172,
    Value = 1475081548,
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int32integer0mi(
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
            asPartInterface: typeof(IInt32SingleTypeinteger)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int32integer0mi(
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
            queryMapTypes: [typeof(Int32integer0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeinteger)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
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

                changedRows =  ((IInt32SingleTypeinteger)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IInt32SingleTypeinteger)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IInt32SingleTypeinteger)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeinteger)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IInt32SingleTypeinteger)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IInt32SingleTypeinteger)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IInt32SingleTypeinteger)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IInt32SingleTypeinteger)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.int32integer0mi(
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
            asPartInterface: typeof(IInt32SingleTypeinteger)), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(11), 
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

                changedRows =  ((IInt32SingleTypeinteger)this).DbConnectionInsertInnerModel(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
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

                changedRows = await ((IInt32SingleTypeinteger)this).DbConnectionInsertInnerModelAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeinteger)this).DbConnectionInsertInnerModelAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeinteger)this).DbConnectionInsertInnerModelAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeinteger)this).DbConnectionInsertInnerModelAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeinteger)this).DbConnectionInsertInnerModelAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeinteger)this).DbConnectionInsertInnerModelAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeinteger)this).DbConnectionInsertInnerModelAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeinteger)this).DbConnectionInsertInnerModelAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int32integer0m(
	id,
    value,
    nullablevalue,
    int32integer0mi_id
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
            asPartInterface: typeof(IInt32SingleTypeinteger)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "int32integer0mi_id", 
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
                changedRows =  ((IInt32SingleTypeinteger)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IInt32SingleTypeinteger)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IInt32SingleTypeinteger)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IInt32SingleTypeinteger)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int32integer0m(
	id,
    value,
    nullablevalue,
    int32integer0mi_id
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
    int32integer0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(Int32integer0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeinteger)),
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
                System.Int32? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
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

                    nullable =  ((IInt32SingleTypeinteger)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(492913314));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
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

                    nullable =  ((IInt32SingleTypeinteger)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(1678376481));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
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

                    nullable = await ((IInt32SingleTypeinteger)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
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

                    nullable = await ((IInt32SingleTypeinteger)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int32integer0m(
	id,
    value,
    nullablevalue,
    int32integer0mi_id
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
    int32integer0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(Int32integer0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeinteger)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "int32integer0mi_id", 
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
                System.Int32? nullable = null;
                nullable =  ((IInt32SingleTypeinteger)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(93446614));
                nullable =  ((IInt32SingleTypeinteger)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32? nullable = null;
                nullable = await ((IInt32SingleTypeinteger)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((IInt32SingleTypeinteger)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(352636132));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Int32integer0M> models = null;

                models =  ((IInt32SingleTypeinteger)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integer0M.AssertModel(models[0],_testData[12], true);
                models =  ((IInt32SingleTypeinteger)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integer0M.AssertModel(models[0],_testData[13], true);
                models =  ((IInt32SingleTypeinteger)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integer0M.AssertModel(models[0],_testData[14], true);
                models =  ((IInt32SingleTypeinteger)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integer0M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Int32integer0M> models = null;

                models = await ((IInt32SingleTypeinteger)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integer0M.AssertModel(models[0],_testData[16], true);
                models = await ((IInt32SingleTypeinteger)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integer0M.AssertModel(models[0],_testData[17], true);
                models = await ((IInt32SingleTypeinteger)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integer0M.AssertModel(models[0],_testData[18], true);
                models = await ((IInt32SingleTypeinteger)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int32integer0M.AssertModel(models[0],_testData[19], true);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.int32integer0m(
	id,
    value,
    nullablevalue,
    int32integer0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @int32integer0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeinteger)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(11),
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "int32integer0mi_id", 
                methodParametrName: "int32integer0mi_id", 
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

                changedRows =  ((IInt32SingleTypeinteger)this).DbConnectionInsertModel(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IInt32SingleTypeinteger)this).DbConnectionInsertModel(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
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

                changedRows = await ((IInt32SingleTypeinteger)this).DbConnectionInsertModelAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeinteger)this).DbConnectionInsertModelAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeinteger)this).DbConnectionInsertModelAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeinteger)this).DbConnectionInsertModelAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeinteger)this).DbConnectionInsertModelAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeinteger)this).DbConnectionInsertModelAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeinteger)this).DbConnectionInsertModelAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeinteger)this).DbConnectionInsertModelAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeinteger)this).DbConnectionInsertModelAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeinteger)this).DbConnectionInsertModelAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeinteger)this).DbConnectionInsertModelAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeinteger)this).DbConnectionInsertModelAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeinteger)this).DbConnectionInsertModelAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt32integer0M), typeof(FlatInt32integer0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeinteger)),
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
FROM public.int32integer0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatInt32integer0M>();
                var models2 = new List<FlatInt32integer0M>();
                await ((IInt32SingleTypeinteger)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integer0M.AssertModel(models1[i],_testData[i], false);
                    FlatInt32integer0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int32integer0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatInt32integer0M>();
                var models2 = new List<FlatInt32integer0M>();
                ((IInt32SingleTypeinteger)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integer0M.AssertModel(models1[i],_testData[i], false);
                    FlatInt32integer0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt32integer0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeinteger)),
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
FROM public.int32integer0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IInt32SingleTypeinteger)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integer0M.AssertModel(models[i],_testData[i], false);
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
FROM public.int32integer0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IInt32SingleTypeinteger)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integer0M.AssertModel(models[i],_testData[i], false);
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
FROM public.int32integer0m m
LEFT JOIN public.int32integer0mi mi ON mi.id = m.int32integer0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Int32integer0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeinteger)),
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
                var models = await ((IInt32SingleTypeinteger)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int32integer0M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IInt32SingleTypeinteger)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int32integer0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt32integer0M), typeof(FlatInt32integer0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeinteger)),
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
FROM public.int32integer0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt32integer0M>();
                var models2 = new List<FlatInt32integer0M>();
                await ((IInt32SingleTypeinteger)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integer0M.AssertModel(models1[i],_testData[i], false);
                    FlatInt32integer0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int32integer0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt32integer0M>();
                var models2 = new List<FlatInt32integer0M>();
                ((IInt32SingleTypeinteger)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integer0M.AssertModel(models1[i],_testData[i], false);
                    FlatInt32integer0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt32integer0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeinteger)),
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
FROM public.int32integer0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IInt32SingleTypeinteger)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integer0M.AssertModel(models[i],_testData[i], false);
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
FROM public.int32integer0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IInt32SingleTypeinteger)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integer0M.AssertModel(models[i],_testData[i], false);
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
FROM public.int32integer0m m
LEFT JOIN public.int32integer0mi mi ON mi.id = m.int32integer0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Int32integer0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeinteger)),
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
                var models = await ((IInt32SingleTypeinteger)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int32integer0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IInt32SingleTypeinteger)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int32integer0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt32integer0M), typeof(FlatInt32integer0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeinteger)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeinteger)),
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
            asPartInterface: typeof(IInt32SingleTypeinteger)),
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
FROM public.int32integer0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt32integer0M>();
                var models2 = new List<FlatInt32integer0M>();
                await((IInt32SingleTypeinteger)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integer0M.AssertModel(models1[i],_testData[i], false);
                    FlatInt32integer0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 15;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 70;
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
FROM public.int32integer0m m
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
FROM public.int32integer0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integer0M>();
                var firstItems2 = new List<FlatInt32integer0M>();
                var secondItems1 = new List<FlatInt32integer0M>();
                var secondItems2 = new List<FlatInt32integer0M>();
                await ((IInt32SingleTypeinteger)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatInt32integer0M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatInt32integer0M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatInt32integer0M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatInt32integer0M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatInt32integer0M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatInt32integer0M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatInt32integer0M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatInt32integer0M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatInt32integer0M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatInt32integer0M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatInt32integer0M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatInt32integer0M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatInt32integer0M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatInt32integer0M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatInt32integer0M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatInt32integer0M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatInt32integer0M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatInt32integer0M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatInt32integer0M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatInt32integer0M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatInt32integer0M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatInt32integer0M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatInt32integer0M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatInt32integer0M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatInt32integer0M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatInt32integer0M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatInt32integer0M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatInt32integer0M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatInt32integer0M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatInt32integer0M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatInt32integer0M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatInt32integer0M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatInt32integer0M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatInt32integer0M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatInt32integer0M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatInt32integer0M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatInt32integer0M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatInt32integer0M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatInt32integer0M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatInt32integer0M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatInt32integer0M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatInt32integer0M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatInt32integer0M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatInt32integer0M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatInt32integer0M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatInt32integer0M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatInt32integer0M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatInt32integer0M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatInt32integer0M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatInt32integer0M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatInt32integer0M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatInt32integer0M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatInt32integer0M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatInt32integer0M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatInt32integer0M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatInt32integer0M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatInt32integer0M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatInt32integer0M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatInt32integer0M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatInt32integer0M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatInt32integer0M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatInt32integer0M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatInt32integer0M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatInt32integer0M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatInt32integer0M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatInt32integer0M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatInt32integer0M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatInt32integer0M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatInt32integer0M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatInt32integer0M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatInt32integer0M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatInt32integer0M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatInt32integer0M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatInt32integer0M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatInt32integer0M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatInt32integer0M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatInt32integer0M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatInt32integer0M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatInt32integer0M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatInt32integer0M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatInt32integer0M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatInt32integer0M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatInt32integer0M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatInt32integer0M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatInt32integer0M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatInt32integer0M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatInt32integer0M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatInt32integer0M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatInt32integer0M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatInt32integer0M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatInt32integer0M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatInt32integer0M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatInt32integer0M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatInt32integer0M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatInt32integer0M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatInt32integer0M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatInt32integer0M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatInt32integer0M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatInt32integer0M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatInt32integer0M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatInt32integer0M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatInt32integer0M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatInt32integer0M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatInt32integer0M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatInt32integer0M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatInt32integer0M.AssertModel(secondItems2[20],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 132;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 72;
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
FROM public.int32integer0m m
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
FROM public.int32integer0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integer0M>();
                var firstItems2 = new List<FlatInt32integer0M>();
                var secondItems1 = new List<FlatInt32integer0M>();
                await ((IInt32SingleTypeinteger)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatInt32integer0M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatInt32integer0M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatInt32integer0M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatInt32integer0M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatInt32integer0M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatInt32integer0M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatInt32integer0M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatInt32integer0M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatInt32integer0M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatInt32integer0M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatInt32integer0M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatInt32integer0M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatInt32integer0M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatInt32integer0M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatInt32integer0M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatInt32integer0M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatInt32integer0M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatInt32integer0M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatInt32integer0M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatInt32integer0M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatInt32integer0M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatInt32integer0M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatInt32integer0M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatInt32integer0M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatInt32integer0M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatInt32integer0M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatInt32integer0M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatInt32integer0M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatInt32integer0M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatInt32integer0M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatInt32integer0M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatInt32integer0M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatInt32integer0M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatInt32integer0M.AssertModel(secondItems1[19],_testData[34], false);
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
FROM public.int32integer0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt32integer0M>();
                var models2 = new List<FlatInt32integer0M>();
                ((IInt32SingleTypeinteger)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integer0M.AssertModel(models1[i],_testData[i], false);
                    FlatInt32integer0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 128;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 159;
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
FROM public.int32integer0m m
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
FROM public.int32integer0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integer0M>();
                var firstItems2 = new List<FlatInt32integer0M>();
                var secondItems1 = new List<FlatInt32integer0M>();
                var secondItems2 = new List<FlatInt32integer0M>();
                 ((IInt32SingleTypeinteger)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatInt32integer0M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatInt32integer0M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatInt32integer0M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatInt32integer0M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatInt32integer0M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatInt32integer0M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatInt32integer0M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatInt32integer0M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatInt32integer0M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatInt32integer0M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatInt32integer0M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatInt32integer0M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatInt32integer0M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatInt32integer0M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatInt32integer0M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatInt32integer0M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatInt32integer0M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatInt32integer0M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatInt32integer0M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatInt32integer0M.AssertModel(secondItems2[1],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 47;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 143;
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
FROM public.int32integer0m m
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
FROM public.int32integer0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integer0M>();
                var firstItems2 = new List<FlatInt32integer0M>();
                var secondItems1 = new List<FlatInt32integer0M>();
                 ((IInt32SingleTypeinteger)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatInt32integer0M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatInt32integer0M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatInt32integer0M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatInt32integer0M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatInt32integer0M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatInt32integer0M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatInt32integer0M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatInt32integer0M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatInt32integer0M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatInt32integer0M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatInt32integer0M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatInt32integer0M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatInt32integer0M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatInt32integer0M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatInt32integer0M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatInt32integer0M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatInt32integer0M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatInt32integer0M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatInt32integer0M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatInt32integer0M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatInt32integer0M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatInt32integer0M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatInt32integer0M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatInt32integer0M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatInt32integer0M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatInt32integer0M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatInt32integer0M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatInt32integer0M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatInt32integer0M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatInt32integer0M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatInt32integer0M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatInt32integer0M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatInt32integer0M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatInt32integer0M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatInt32integer0M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatInt32integer0M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatInt32integer0M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatInt32integer0M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatInt32integer0M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatInt32integer0M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatInt32integer0M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatInt32integer0M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatInt32integer0M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatInt32integer0M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatInt32integer0M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatInt32integer0M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatInt32integer0M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatInt32integer0M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatInt32integer0M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatInt32integer0M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatInt32integer0M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatInt32integer0M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatInt32integer0M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatInt32integer0M.AssertModel(secondItems1[3],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt32integer0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeinteger)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeinteger)),
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
            asPartInterface: typeof(IInt32SingleTypeinteger)),
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
FROM public.int32integer0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IInt32SingleTypeinteger)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integer0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 159;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 70;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int32integer0m m
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
FROM public.int32integer0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt32SingleTypeinteger)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatInt32integer0M.AssertModel(models[0],_testData[33], false);
                        FlatInt32integer0M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatInt32integer0M.AssertModel(models[0],_testData[14], false);
                        FlatInt32integer0M.AssertModel(models[1],_testData[15], false);
                        FlatInt32integer0M.AssertModel(models[2],_testData[16], false);
                        FlatInt32integer0M.AssertModel(models[3],_testData[17], false);
                        FlatInt32integer0M.AssertModel(models[4],_testData[18], false);
                        FlatInt32integer0M.AssertModel(models[5],_testData[19], false);
                        FlatInt32integer0M.AssertModel(models[6],_testData[20], false);
                        FlatInt32integer0M.AssertModel(models[7],_testData[21], false);
                        FlatInt32integer0M.AssertModel(models[8],_testData[22], false);
                        FlatInt32integer0M.AssertModel(models[9],_testData[23], false);
                        FlatInt32integer0M.AssertModel(models[10],_testData[24], false);
                        FlatInt32integer0M.AssertModel(models[11],_testData[25], false);
                        FlatInt32integer0M.AssertModel(models[12],_testData[26], false);
                        FlatInt32integer0M.AssertModel(models[13],_testData[27], false);
                        FlatInt32integer0M.AssertModel(models[14],_testData[28], false);
                        FlatInt32integer0M.AssertModel(models[15],_testData[29], false);
                        FlatInt32integer0M.AssertModel(models[16],_testData[30], false);
                        FlatInt32integer0M.AssertModel(models[17],_testData[31], false);
                        FlatInt32integer0M.AssertModel(models[18],_testData[32], false);
                        FlatInt32integer0M.AssertModel(models[19],_testData[33], false);
                        FlatInt32integer0M.AssertModel(models[20],_testData[34], false);
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
                parametr1.Value = 138;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 44;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int32integer0m m
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
FROM public.int32integer0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integer0M>();
                var secondItems1 = new List<FlatInt32integer0M>();
                var secondItems2 = new List<FlatInt32integer0M>();
                await ((IInt32SingleTypeinteger)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatInt32integer0M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatInt32integer0M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatInt32integer0M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatInt32integer0M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatInt32integer0M.AssertModel(firstItems1[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatInt32integer0M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatInt32integer0M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatInt32integer0M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatInt32integer0M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatInt32integer0M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatInt32integer0M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatInt32integer0M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatInt32integer0M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatInt32integer0M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatInt32integer0M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatInt32integer0M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatInt32integer0M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatInt32integer0M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatInt32integer0M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatInt32integer0M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatInt32integer0M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatInt32integer0M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatInt32integer0M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatInt32integer0M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatInt32integer0M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatInt32integer0M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatInt32integer0M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatInt32integer0M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatInt32integer0M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatInt32integer0M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatInt32integer0M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatInt32integer0M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatInt32integer0M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatInt32integer0M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatInt32integer0M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatInt32integer0M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatInt32integer0M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatInt32integer0M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatInt32integer0M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatInt32integer0M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatInt32integer0M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatInt32integer0M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatInt32integer0M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatInt32integer0M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatInt32integer0M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatInt32integer0M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatInt32integer0M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatInt32integer0M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatInt32integer0M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatInt32integer0M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatInt32integer0M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatInt32integer0M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatInt32integer0M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatInt32integer0M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatInt32integer0M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatInt32integer0M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatInt32integer0M.AssertModel(secondItems2[25],_testData[34], false);
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
FROM public.int32integer0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IInt32SingleTypeinteger)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integer0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 138;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 106;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int32integer0m m
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
FROM public.int32integer0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt32SingleTypeinteger)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatInt32integer0M.AssertModel(models[0],_testData[30], false);
                        FlatInt32integer0M.AssertModel(models[1],_testData[31], false);
                        FlatInt32integer0M.AssertModel(models[2],_testData[32], false);
                        FlatInt32integer0M.AssertModel(models[3],_testData[33], false);
                        FlatInt32integer0M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatInt32integer0M.AssertModel(models[0],_testData[22], false);
                        FlatInt32integer0M.AssertModel(models[1],_testData[23], false);
                        FlatInt32integer0M.AssertModel(models[2],_testData[24], false);
                        FlatInt32integer0M.AssertModel(models[3],_testData[25], false);
                        FlatInt32integer0M.AssertModel(models[4],_testData[26], false);
                        FlatInt32integer0M.AssertModel(models[5],_testData[27], false);
                        FlatInt32integer0M.AssertModel(models[6],_testData[28], false);
                        FlatInt32integer0M.AssertModel(models[7],_testData[29], false);
                        FlatInt32integer0M.AssertModel(models[8],_testData[30], false);
                        FlatInt32integer0M.AssertModel(models[9],_testData[31], false);
                        FlatInt32integer0M.AssertModel(models[10],_testData[32], false);
                        FlatInt32integer0M.AssertModel(models[11],_testData[33], false);
                        FlatInt32integer0M.AssertModel(models[12],_testData[34], false);
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
                parametr1.Value = 32;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 11;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int32integer0m m
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
FROM public.int32integer0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integer0M>();
                var secondItems1 = new List<FlatInt32integer0M>();
                var secondItems2 = new List<FlatInt32integer0M>();
                 ((IInt32SingleTypeinteger)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatInt32integer0M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatInt32integer0M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatInt32integer0M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatInt32integer0M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatInt32integer0M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatInt32integer0M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatInt32integer0M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatInt32integer0M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatInt32integer0M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatInt32integer0M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatInt32integer0M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatInt32integer0M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatInt32integer0M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatInt32integer0M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatInt32integer0M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatInt32integer0M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatInt32integer0M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatInt32integer0M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatInt32integer0M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatInt32integer0M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatInt32integer0M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatInt32integer0M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatInt32integer0M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatInt32integer0M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatInt32integer0M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatInt32integer0M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatInt32integer0M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatInt32integer0M.AssertModel(firstItems1[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatInt32integer0M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatInt32integer0M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatInt32integer0M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatInt32integer0M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatInt32integer0M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatInt32integer0M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatInt32integer0M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatInt32integer0M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatInt32integer0M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatInt32integer0M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatInt32integer0M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatInt32integer0M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatInt32integer0M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatInt32integer0M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatInt32integer0M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatInt32integer0M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatInt32integer0M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatInt32integer0M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatInt32integer0M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatInt32integer0M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatInt32integer0M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatInt32integer0M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatInt32integer0M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatInt32integer0M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatInt32integer0M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatInt32integer0M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatInt32integer0M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatInt32integer0M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatInt32integer0M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatInt32integer0M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatInt32integer0M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatInt32integer0M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatInt32integer0M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatInt32integer0M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatInt32integer0M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatInt32integer0M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatInt32integer0M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatInt32integer0M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatInt32integer0M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatInt32integer0M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatInt32integer0M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatInt32integer0M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatInt32integer0M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatInt32integer0M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatInt32integer0M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatInt32integer0M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatInt32integer0M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatInt32integer0M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatInt32integer0M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatInt32integer0M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatInt32integer0M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatInt32integer0M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatInt32integer0M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatInt32integer0M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatInt32integer0M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatInt32integer0M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatInt32integer0M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatInt32integer0M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatInt32integer0M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatInt32integer0M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatInt32integer0M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatInt32integer0M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatInt32integer0M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatInt32integer0M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatInt32integer0M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatInt32integer0M.AssertModel(secondItems2[32],_testData[34], false);
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
FROM public.int32integer0m m
LEFT JOIN public.int32integer0mi mi ON mi.id = m.int32integer0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Int32integer0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeinteger)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeinteger)),
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
                var models = await((IInt32SingleTypeinteger)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int32integer0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 75;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 20;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt32SingleTypeinteger)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        Int32integer0M.AssertModel(models[0],_testData[16], false);
                        Int32integer0M.AssertModel(models[1],_testData[17], false);
                        Int32integer0M.AssertModel(models[2],_testData[18], false);
                        Int32integer0M.AssertModel(models[3],_testData[19], false);
                        Int32integer0M.AssertModel(models[4],_testData[20], false);
                        Int32integer0M.AssertModel(models[5],_testData[21], false);
                        Int32integer0M.AssertModel(models[6],_testData[22], false);
                        Int32integer0M.AssertModel(models[7],_testData[23], false);
                        Int32integer0M.AssertModel(models[8],_testData[24], false);
                        Int32integer0M.AssertModel(models[9],_testData[25], false);
                        Int32integer0M.AssertModel(models[10],_testData[26], false);
                        Int32integer0M.AssertModel(models[11],_testData[27], false);
                        Int32integer0M.AssertModel(models[12],_testData[28], false);
                        Int32integer0M.AssertModel(models[13],_testData[29], false);
                        Int32integer0M.AssertModel(models[14],_testData[30], false);
                        Int32integer0M.AssertModel(models[15],_testData[31], false);
                        Int32integer0M.AssertModel(models[16],_testData[32], false);
                        Int32integer0M.AssertModel(models[17],_testData[33], false);
                        Int32integer0M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        Int32integer0M.AssertModel(models[0],_testData[5], false);
                        Int32integer0M.AssertModel(models[1],_testData[6], false);
                        Int32integer0M.AssertModel(models[2],_testData[7], false);
                        Int32integer0M.AssertModel(models[3],_testData[8], false);
                        Int32integer0M.AssertModel(models[4],_testData[9], false);
                        Int32integer0M.AssertModel(models[5],_testData[10], false);
                        Int32integer0M.AssertModel(models[6],_testData[11], false);
                        Int32integer0M.AssertModel(models[7],_testData[12], false);
                        Int32integer0M.AssertModel(models[8],_testData[13], false);
                        Int32integer0M.AssertModel(models[9],_testData[14], false);
                        Int32integer0M.AssertModel(models[10],_testData[15], false);
                        Int32integer0M.AssertModel(models[11],_testData[16], false);
                        Int32integer0M.AssertModel(models[12],_testData[17], false);
                        Int32integer0M.AssertModel(models[13],_testData[18], false);
                        Int32integer0M.AssertModel(models[14],_testData[19], false);
                        Int32integer0M.AssertModel(models[15],_testData[20], false);
                        Int32integer0M.AssertModel(models[16],_testData[21], false);
                        Int32integer0M.AssertModel(models[17],_testData[22], false);
                        Int32integer0M.AssertModel(models[18],_testData[23], false);
                        Int32integer0M.AssertModel(models[19],_testData[24], false);
                        Int32integer0M.AssertModel(models[20],_testData[25], false);
                        Int32integer0M.AssertModel(models[21],_testData[26], false);
                        Int32integer0M.AssertModel(models[22],_testData[27], false);
                        Int32integer0M.AssertModel(models[23],_testData[28], false);
                        Int32integer0M.AssertModel(models[24],_testData[29], false);
                        Int32integer0M.AssertModel(models[25],_testData[30], false);
                        Int32integer0M.AssertModel(models[26],_testData[31], false);
                        Int32integer0M.AssertModel(models[27],_testData[32], false);
                        Int32integer0M.AssertModel(models[28],_testData[33], false);
                        Int32integer0M.AssertModel(models[29],_testData[34], false);
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
                var models = ((IInt32SingleTypeinteger)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int32integer0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 64;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 86;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt32SingleTypeinteger)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        Int32integer0M.AssertModel(models[0],_testData[13], false);
                        Int32integer0M.AssertModel(models[1],_testData[14], false);
                        Int32integer0M.AssertModel(models[2],_testData[15], false);
                        Int32integer0M.AssertModel(models[3],_testData[16], false);
                        Int32integer0M.AssertModel(models[4],_testData[17], false);
                        Int32integer0M.AssertModel(models[5],_testData[18], false);
                        Int32integer0M.AssertModel(models[6],_testData[19], false);
                        Int32integer0M.AssertModel(models[7],_testData[20], false);
                        Int32integer0M.AssertModel(models[8],_testData[21], false);
                        Int32integer0M.AssertModel(models[9],_testData[22], false);
                        Int32integer0M.AssertModel(models[10],_testData[23], false);
                        Int32integer0M.AssertModel(models[11],_testData[24], false);
                        Int32integer0M.AssertModel(models[12],_testData[25], false);
                        Int32integer0M.AssertModel(models[13],_testData[26], false);
                        Int32integer0M.AssertModel(models[14],_testData[27], false);
                        Int32integer0M.AssertModel(models[15],_testData[28], false);
                        Int32integer0M.AssertModel(models[16],_testData[29], false);
                        Int32integer0M.AssertModel(models[17],_testData[30], false);
                        Int32integer0M.AssertModel(models[18],_testData[31], false);
                        Int32integer0M.AssertModel(models[19],_testData[32], false);
                        Int32integer0M.AssertModel(models[20],_testData[33], false);
                        Int32integer0M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        Int32integer0M.AssertModel(models[0],_testData[19], false);
                        Int32integer0M.AssertModel(models[1],_testData[20], false);
                        Int32integer0M.AssertModel(models[2],_testData[21], false);
                        Int32integer0M.AssertModel(models[3],_testData[22], false);
                        Int32integer0M.AssertModel(models[4],_testData[23], false);
                        Int32integer0M.AssertModel(models[5],_testData[24], false);
                        Int32integer0M.AssertModel(models[6],_testData[25], false);
                        Int32integer0M.AssertModel(models[7],_testData[26], false);
                        Int32integer0M.AssertModel(models[8],_testData[27], false);
                        Int32integer0M.AssertModel(models[9],_testData[28], false);
                        Int32integer0M.AssertModel(models[10],_testData[29], false);
                        Int32integer0M.AssertModel(models[11],_testData[30], false);
                        Int32integer0M.AssertModel(models[12],_testData[31], false);
                        Int32integer0M.AssertModel(models[13],_testData[32], false);
                        Int32integer0M.AssertModel(models[14],_testData[33], false);
                        Int32integer0M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt32integer0M), typeof(FlatInt32integer0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeinteger)),
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
            asPartInterface: typeof(IInt32SingleTypeinteger)),
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
            asPartInterface: typeof(IInt32SingleTypeinteger)),
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
FROM public.int32integer0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt32integer0M>();
                var models2 = new List<FlatInt32integer0M>();
                await((IInt32SingleTypeinteger)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integer0M.AssertModel(models1[i],_testData[i], false);
                    FlatInt32integer0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int32integer0m m
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
FROM public.int32integer0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integer0M>();
                var firstItems2 = new List<FlatInt32integer0M>();
                var secondItems1 = new List<FlatInt32integer0M>();
                var secondItems2 = new List<FlatInt32integer0M>();
                await ((IInt32SingleTypeinteger)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 106, query1, 132, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatInt32integer0M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatInt32integer0M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatInt32integer0M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatInt32integer0M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatInt32integer0M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatInt32integer0M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatInt32integer0M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatInt32integer0M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatInt32integer0M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatInt32integer0M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatInt32integer0M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatInt32integer0M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatInt32integer0M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatInt32integer0M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatInt32integer0M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatInt32integer0M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatInt32integer0M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatInt32integer0M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatInt32integer0M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatInt32integer0M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatInt32integer0M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatInt32integer0M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatInt32integer0M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatInt32integer0M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatInt32integer0M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatInt32integer0M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatInt32integer0M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatInt32integer0M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatInt32integer0M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatInt32integer0M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatInt32integer0M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatInt32integer0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatInt32integer0M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatInt32integer0M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatInt32integer0M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatInt32integer0M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatInt32integer0M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatInt32integer0M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatInt32integer0M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatInt32integer0M.AssertModel(secondItems2[6],_testData[34], false);
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
FROM public.int32integer0m m
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
FROM public.int32integer0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integer0M>();
                var firstItems2 = new List<FlatInt32integer0M>();
                var secondItems1 = new List<FlatInt32integer0M>();
                await ((IInt32SingleTypeinteger)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 19, query1, 44, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatInt32integer0M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatInt32integer0M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatInt32integer0M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatInt32integer0M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatInt32integer0M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatInt32integer0M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatInt32integer0M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatInt32integer0M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatInt32integer0M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatInt32integer0M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatInt32integer0M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatInt32integer0M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatInt32integer0M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatInt32integer0M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatInt32integer0M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatInt32integer0M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatInt32integer0M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatInt32integer0M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatInt32integer0M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatInt32integer0M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatInt32integer0M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatInt32integer0M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatInt32integer0M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatInt32integer0M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatInt32integer0M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatInt32integer0M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatInt32integer0M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatInt32integer0M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatInt32integer0M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatInt32integer0M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatInt32integer0M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatInt32integer0M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatInt32integer0M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatInt32integer0M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatInt32integer0M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatInt32integer0M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatInt32integer0M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatInt32integer0M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatInt32integer0M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatInt32integer0M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatInt32integer0M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatInt32integer0M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatInt32integer0M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatInt32integer0M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatInt32integer0M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatInt32integer0M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatInt32integer0M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatInt32integer0M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatInt32integer0M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatInt32integer0M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatInt32integer0M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatInt32integer0M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatInt32integer0M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatInt32integer0M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatInt32integer0M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatInt32integer0M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatInt32integer0M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatInt32integer0M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatInt32integer0M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatInt32integer0M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatInt32integer0M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatInt32integer0M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                        FlatInt32integer0M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatInt32integer0M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatInt32integer0M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatInt32integer0M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatInt32integer0M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatInt32integer0M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatInt32integer0M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatInt32integer0M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatInt32integer0M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatInt32integer0M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatInt32integer0M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatInt32integer0M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatInt32integer0M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatInt32integer0M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatInt32integer0M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatInt32integer0M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatInt32integer0M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatInt32integer0M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatInt32integer0M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatInt32integer0M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatInt32integer0M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatInt32integer0M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatInt32integer0M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatInt32integer0M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatInt32integer0M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatInt32integer0M.AssertModel(secondItems1[25],_testData[34], false);
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
FROM public.int32integer0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt32integer0M>();
                var models2 = new List<FlatInt32integer0M>();
                ((IInt32SingleTypeinteger)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integer0M.AssertModel(models1[i],_testData[i], false);
                    FlatInt32integer0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int32integer0m m
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
FROM public.int32integer0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integer0M>();
                var firstItems2 = new List<FlatInt32integer0M>();
                var secondItems1 = new List<FlatInt32integer0M>();
                var secondItems2 = new List<FlatInt32integer0M>();
                 ((IInt32SingleTypeinteger)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 15, query1, 47, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatInt32integer0M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatInt32integer0M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatInt32integer0M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatInt32integer0M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatInt32integer0M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatInt32integer0M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatInt32integer0M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatInt32integer0M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatInt32integer0M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatInt32integer0M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatInt32integer0M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatInt32integer0M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatInt32integer0M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatInt32integer0M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatInt32integer0M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatInt32integer0M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatInt32integer0M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatInt32integer0M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatInt32integer0M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatInt32integer0M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatInt32integer0M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatInt32integer0M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatInt32integer0M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatInt32integer0M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatInt32integer0M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatInt32integer0M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatInt32integer0M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatInt32integer0M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatInt32integer0M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatInt32integer0M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatInt32integer0M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatInt32integer0M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatInt32integer0M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatInt32integer0M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatInt32integer0M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatInt32integer0M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatInt32integer0M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatInt32integer0M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatInt32integer0M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatInt32integer0M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatInt32integer0M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatInt32integer0M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatInt32integer0M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatInt32integer0M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatInt32integer0M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatInt32integer0M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatInt32integer0M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatInt32integer0M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatInt32integer0M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatInt32integer0M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatInt32integer0M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatInt32integer0M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatInt32integer0M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatInt32integer0M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatInt32integer0M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatInt32integer0M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatInt32integer0M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatInt32integer0M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatInt32integer0M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatInt32integer0M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatInt32integer0M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatInt32integer0M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatInt32integer0M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatInt32integer0M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatInt32integer0M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatInt32integer0M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatInt32integer0M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatInt32integer0M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatInt32integer0M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatInt32integer0M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatInt32integer0M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatInt32integer0M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatInt32integer0M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatInt32integer0M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatInt32integer0M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatInt32integer0M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatInt32integer0M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatInt32integer0M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatInt32integer0M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatInt32integer0M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatInt32integer0M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatInt32integer0M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatInt32integer0M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatInt32integer0M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatInt32integer0M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatInt32integer0M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatInt32integer0M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatInt32integer0M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatInt32integer0M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatInt32integer0M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatInt32integer0M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatInt32integer0M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatInt32integer0M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatInt32integer0M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatInt32integer0M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatInt32integer0M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatInt32integer0M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatInt32integer0M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatInt32integer0M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatInt32integer0M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatInt32integer0M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatInt32integer0M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatInt32integer0M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatInt32integer0M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatInt32integer0M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatInt32integer0M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatInt32integer0M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatInt32integer0M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatInt32integer0M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatInt32integer0M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatInt32integer0M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatInt32integer0M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatInt32integer0M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatInt32integer0M.AssertModel(secondItems2[24],_testData[34], false);
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
FROM public.int32integer0m m
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
FROM public.int32integer0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integer0M>();
                var firstItems2 = new List<FlatInt32integer0M>();
                var secondItems1 = new List<FlatInt32integer0M>();
                 ((IInt32SingleTypeinteger)this).DbConnectionMMDynQuerySelectModelBatch(connection, 116, query1, 72, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatInt32integer0M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatInt32integer0M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatInt32integer0M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatInt32integer0M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatInt32integer0M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatInt32integer0M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatInt32integer0M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatInt32integer0M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatInt32integer0M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatInt32integer0M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatInt32integer0M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatInt32integer0M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatInt32integer0M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatInt32integer0M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatInt32integer0M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatInt32integer0M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatInt32integer0M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatInt32integer0M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatInt32integer0M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatInt32integer0M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatInt32integer0M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatInt32integer0M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatInt32integer0M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatInt32integer0M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatInt32integer0M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatInt32integer0M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatInt32integer0M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatInt32integer0M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatInt32integer0M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatInt32integer0M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatInt32integer0M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatInt32integer0M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatInt32integer0M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatInt32integer0M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatInt32integer0M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatInt32integer0M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatInt32integer0M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatInt32integer0M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatInt32integer0M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatInt32integer0M.AssertModel(secondItems1[19],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt32integer0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeinteger)),
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
            asPartInterface: typeof(IInt32SingleTypeinteger)),
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
            asPartInterface: typeof(IInt32SingleTypeinteger)),
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
FROM public.int32integer0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IInt32SingleTypeinteger)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integer0M.AssertModel(models[i],_testData[i], false);
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
FROM public.int32integer0m m
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
FROM public.int32integer0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt32SingleTypeinteger)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 36, query1, 47, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatInt32integer0M.AssertModel(models[0],_testData[8], false);
                        FlatInt32integer0M.AssertModel(models[1],_testData[9], false);
                        FlatInt32integer0M.AssertModel(models[2],_testData[10], false);
                        FlatInt32integer0M.AssertModel(models[3],_testData[11], false);
                        FlatInt32integer0M.AssertModel(models[4],_testData[12], false);
                        FlatInt32integer0M.AssertModel(models[5],_testData[13], false);
                        FlatInt32integer0M.AssertModel(models[6],_testData[14], false);
                        FlatInt32integer0M.AssertModel(models[7],_testData[15], false);
                        FlatInt32integer0M.AssertModel(models[8],_testData[16], false);
                        FlatInt32integer0M.AssertModel(models[9],_testData[17], false);
                        FlatInt32integer0M.AssertModel(models[10],_testData[18], false);
                        FlatInt32integer0M.AssertModel(models[11],_testData[19], false);
                        FlatInt32integer0M.AssertModel(models[12],_testData[20], false);
                        FlatInt32integer0M.AssertModel(models[13],_testData[21], false);
                        FlatInt32integer0M.AssertModel(models[14],_testData[22], false);
                        FlatInt32integer0M.AssertModel(models[15],_testData[23], false);
                        FlatInt32integer0M.AssertModel(models[16],_testData[24], false);
                        FlatInt32integer0M.AssertModel(models[17],_testData[25], false);
                        FlatInt32integer0M.AssertModel(models[18],_testData[26], false);
                        FlatInt32integer0M.AssertModel(models[19],_testData[27], false);
                        FlatInt32integer0M.AssertModel(models[20],_testData[28], false);
                        FlatInt32integer0M.AssertModel(models[21],_testData[29], false);
                        FlatInt32integer0M.AssertModel(models[22],_testData[30], false);
                        FlatInt32integer0M.AssertModel(models[23],_testData[31], false);
                        FlatInt32integer0M.AssertModel(models[24],_testData[32], false);
                        FlatInt32integer0M.AssertModel(models[25],_testData[33], false);
                        FlatInt32integer0M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatInt32integer0M.AssertModel(models[0],_testData[10], false);
                        FlatInt32integer0M.AssertModel(models[1],_testData[11], false);
                        FlatInt32integer0M.AssertModel(models[2],_testData[12], false);
                        FlatInt32integer0M.AssertModel(models[3],_testData[13], false);
                        FlatInt32integer0M.AssertModel(models[4],_testData[14], false);
                        FlatInt32integer0M.AssertModel(models[5],_testData[15], false);
                        FlatInt32integer0M.AssertModel(models[6],_testData[16], false);
                        FlatInt32integer0M.AssertModel(models[7],_testData[17], false);
                        FlatInt32integer0M.AssertModel(models[8],_testData[18], false);
                        FlatInt32integer0M.AssertModel(models[9],_testData[19], false);
                        FlatInt32integer0M.AssertModel(models[10],_testData[20], false);
                        FlatInt32integer0M.AssertModel(models[11],_testData[21], false);
                        FlatInt32integer0M.AssertModel(models[12],_testData[22], false);
                        FlatInt32integer0M.AssertModel(models[13],_testData[23], false);
                        FlatInt32integer0M.AssertModel(models[14],_testData[24], false);
                        FlatInt32integer0M.AssertModel(models[15],_testData[25], false);
                        FlatInt32integer0M.AssertModel(models[16],_testData[26], false);
                        FlatInt32integer0M.AssertModel(models[17],_testData[27], false);
                        FlatInt32integer0M.AssertModel(models[18],_testData[28], false);
                        FlatInt32integer0M.AssertModel(models[19],_testData[29], false);
                        FlatInt32integer0M.AssertModel(models[20],_testData[30], false);
                        FlatInt32integer0M.AssertModel(models[21],_testData[31], false);
                        FlatInt32integer0M.AssertModel(models[22],_testData[32], false);
                        FlatInt32integer0M.AssertModel(models[23],_testData[33], false);
                        FlatInt32integer0M.AssertModel(models[24],_testData[34], false);
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
FROM public.int32integer0m m
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
FROM public.int32integer0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integer0M>();
                var secondItems1 = new List<FlatInt32integer0M>();
                var secondItems2 = new List<FlatInt32integer0M>();
                await ((IInt32SingleTypeinteger)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 58, query1, 159, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatInt32integer0M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatInt32integer0M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatInt32integer0M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatInt32integer0M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatInt32integer0M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatInt32integer0M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatInt32integer0M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatInt32integer0M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatInt32integer0M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatInt32integer0M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatInt32integer0M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatInt32integer0M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatInt32integer0M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatInt32integer0M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatInt32integer0M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatInt32integer0M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatInt32integer0M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatInt32integer0M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatInt32integer0M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatInt32integer0M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatInt32integer0M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatInt32integer0M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatInt32integer0M.AssertModel(firstItems1[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatInt32integer0M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatInt32integer0M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatInt32integer0M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatInt32integer0M.AssertModel(secondItems2[1],_testData[34], false);
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
FROM public.int32integer0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IInt32SingleTypeinteger)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32integer0M.AssertModel(models[i],_testData[i], false);
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
FROM public.int32integer0m m
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
FROM public.int32integer0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt32SingleTypeinteger)this).DbConnectionSTDynQuerySelectModelBatch(connection, 106, query1, 25, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatInt32integer0M.AssertModel(models[0],_testData[22], false);
                        FlatInt32integer0M.AssertModel(models[1],_testData[23], false);
                        FlatInt32integer0M.AssertModel(models[2],_testData[24], false);
                        FlatInt32integer0M.AssertModel(models[3],_testData[25], false);
                        FlatInt32integer0M.AssertModel(models[4],_testData[26], false);
                        FlatInt32integer0M.AssertModel(models[5],_testData[27], false);
                        FlatInt32integer0M.AssertModel(models[6],_testData[28], false);
                        FlatInt32integer0M.AssertModel(models[7],_testData[29], false);
                        FlatInt32integer0M.AssertModel(models[8],_testData[30], false);
                        FlatInt32integer0M.AssertModel(models[9],_testData[31], false);
                        FlatInt32integer0M.AssertModel(models[10],_testData[32], false);
                        FlatInt32integer0M.AssertModel(models[11],_testData[33], false);
                        FlatInt32integer0M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatInt32integer0M.AssertModel(models[0],_testData[6], false);
                        FlatInt32integer0M.AssertModel(models[1],_testData[7], false);
                        FlatInt32integer0M.AssertModel(models[2],_testData[8], false);
                        FlatInt32integer0M.AssertModel(models[3],_testData[9], false);
                        FlatInt32integer0M.AssertModel(models[4],_testData[10], false);
                        FlatInt32integer0M.AssertModel(models[5],_testData[11], false);
                        FlatInt32integer0M.AssertModel(models[6],_testData[12], false);
                        FlatInt32integer0M.AssertModel(models[7],_testData[13], false);
                        FlatInt32integer0M.AssertModel(models[8],_testData[14], false);
                        FlatInt32integer0M.AssertModel(models[9],_testData[15], false);
                        FlatInt32integer0M.AssertModel(models[10],_testData[16], false);
                        FlatInt32integer0M.AssertModel(models[11],_testData[17], false);
                        FlatInt32integer0M.AssertModel(models[12],_testData[18], false);
                        FlatInt32integer0M.AssertModel(models[13],_testData[19], false);
                        FlatInt32integer0M.AssertModel(models[14],_testData[20], false);
                        FlatInt32integer0M.AssertModel(models[15],_testData[21], false);
                        FlatInt32integer0M.AssertModel(models[16],_testData[22], false);
                        FlatInt32integer0M.AssertModel(models[17],_testData[23], false);
                        FlatInt32integer0M.AssertModel(models[18],_testData[24], false);
                        FlatInt32integer0M.AssertModel(models[19],_testData[25], false);
                        FlatInt32integer0M.AssertModel(models[20],_testData[26], false);
                        FlatInt32integer0M.AssertModel(models[21],_testData[27], false);
                        FlatInt32integer0M.AssertModel(models[22],_testData[28], false);
                        FlatInt32integer0M.AssertModel(models[23],_testData[29], false);
                        FlatInt32integer0M.AssertModel(models[24],_testData[30], false);
                        FlatInt32integer0M.AssertModel(models[25],_testData[31], false);
                        FlatInt32integer0M.AssertModel(models[26],_testData[32], false);
                        FlatInt32integer0M.AssertModel(models[27],_testData[33], false);
                        FlatInt32integer0M.AssertModel(models[28],_testData[34], false);
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
FROM public.int32integer0m m
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
FROM public.int32integer0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32integer0M>();
                var secondItems1 = new List<FlatInt32integer0M>();
                var secondItems2 = new List<FlatInt32integer0M>();
                 ((IInt32SingleTypeinteger)this).DbConnectionDynQuerySelectModelBatch(connection, 25, query1, 36, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatInt32integer0M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatInt32integer0M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatInt32integer0M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatInt32integer0M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatInt32integer0M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatInt32integer0M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatInt32integer0M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatInt32integer0M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatInt32integer0M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatInt32integer0M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatInt32integer0M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatInt32integer0M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatInt32integer0M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatInt32integer0M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatInt32integer0M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatInt32integer0M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatInt32integer0M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatInt32integer0M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatInt32integer0M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatInt32integer0M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatInt32integer0M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatInt32integer0M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatInt32integer0M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatInt32integer0M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatInt32integer0M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatInt32integer0M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatInt32integer0M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatInt32integer0M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatInt32integer0M.AssertModel(firstItems1[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatInt32integer0M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatInt32integer0M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatInt32integer0M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatInt32integer0M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatInt32integer0M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatInt32integer0M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatInt32integer0M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatInt32integer0M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatInt32integer0M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatInt32integer0M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatInt32integer0M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatInt32integer0M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatInt32integer0M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatInt32integer0M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatInt32integer0M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatInt32integer0M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatInt32integer0M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatInt32integer0M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatInt32integer0M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatInt32integer0M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatInt32integer0M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatInt32integer0M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatInt32integer0M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatInt32integer0M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatInt32integer0M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatInt32integer0M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatInt32integer0M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatInt32integer0M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatInt32integer0M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatInt32integer0M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatInt32integer0M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatInt32integer0M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatInt32integer0M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatInt32integer0M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatInt32integer0M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatInt32integer0M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatInt32integer0M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatInt32integer0M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatInt32integer0M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatInt32integer0M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatInt32integer0M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatInt32integer0M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatInt32integer0M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatInt32integer0M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatInt32integer0M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatInt32integer0M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatInt32integer0M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatInt32integer0M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatInt32integer0M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatInt32integer0M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatInt32integer0M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatInt32integer0M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatInt32integer0M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatInt32integer0M.AssertModel(secondItems2[26],_testData[34], false);
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
FROM public.int32integer0m m
LEFT JOIN public.int32integer0mi mi ON mi.id = m.int32integer0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Int32integer0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeinteger)),
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
            asPartInterface: typeof(IInt32SingleTypeinteger)),
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
                var models = await((IInt32SingleTypeinteger)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int32integer0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IInt32SingleTypeinteger)this).DbConnectionSTSelectModelBatchAsync(connection, 75, 55))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        Int32integer0M.AssertModel(models[0],_testData[16], false);
                        Int32integer0M.AssertModel(models[1],_testData[17], false);
                        Int32integer0M.AssertModel(models[2],_testData[18], false);
                        Int32integer0M.AssertModel(models[3],_testData[19], false);
                        Int32integer0M.AssertModel(models[4],_testData[20], false);
                        Int32integer0M.AssertModel(models[5],_testData[21], false);
                        Int32integer0M.AssertModel(models[6],_testData[22], false);
                        Int32integer0M.AssertModel(models[7],_testData[23], false);
                        Int32integer0M.AssertModel(models[8],_testData[24], false);
                        Int32integer0M.AssertModel(models[9],_testData[25], false);
                        Int32integer0M.AssertModel(models[10],_testData[26], false);
                        Int32integer0M.AssertModel(models[11],_testData[27], false);
                        Int32integer0M.AssertModel(models[12],_testData[28], false);
                        Int32integer0M.AssertModel(models[13],_testData[29], false);
                        Int32integer0M.AssertModel(models[14],_testData[30], false);
                        Int32integer0M.AssertModel(models[15],_testData[31], false);
                        Int32integer0M.AssertModel(models[16],_testData[32], false);
                        Int32integer0M.AssertModel(models[17],_testData[33], false);
                        Int32integer0M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        Int32integer0M.AssertModel(models[0],_testData[11], false);
                        Int32integer0M.AssertModel(models[1],_testData[12], false);
                        Int32integer0M.AssertModel(models[2],_testData[13], false);
                        Int32integer0M.AssertModel(models[3],_testData[14], false);
                        Int32integer0M.AssertModel(models[4],_testData[15], false);
                        Int32integer0M.AssertModel(models[5],_testData[16], false);
                        Int32integer0M.AssertModel(models[6],_testData[17], false);
                        Int32integer0M.AssertModel(models[7],_testData[18], false);
                        Int32integer0M.AssertModel(models[8],_testData[19], false);
                        Int32integer0M.AssertModel(models[9],_testData[20], false);
                        Int32integer0M.AssertModel(models[10],_testData[21], false);
                        Int32integer0M.AssertModel(models[11],_testData[22], false);
                        Int32integer0M.AssertModel(models[12],_testData[23], false);
                        Int32integer0M.AssertModel(models[13],_testData[24], false);
                        Int32integer0M.AssertModel(models[14],_testData[25], false);
                        Int32integer0M.AssertModel(models[15],_testData[26], false);
                        Int32integer0M.AssertModel(models[16],_testData[27], false);
                        Int32integer0M.AssertModel(models[17],_testData[28], false);
                        Int32integer0M.AssertModel(models[18],_testData[29], false);
                        Int32integer0M.AssertModel(models[19],_testData[30], false);
                        Int32integer0M.AssertModel(models[20],_testData[31], false);
                        Int32integer0M.AssertModel(models[21],_testData[32], false);
                        Int32integer0M.AssertModel(models[22],_testData[33], false);
                        Int32integer0M.AssertModel(models[23],_testData[34], false);
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
                var models = ((IInt32SingleTypeinteger)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int32integer0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IInt32SingleTypeinteger)this).DbConnectionSTSelectModelBatch(connection, 113, 95))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        Int32integer0M.AssertModel(models[0],_testData[23], false);
                        Int32integer0M.AssertModel(models[1],_testData[24], false);
                        Int32integer0M.AssertModel(models[2],_testData[25], false);
                        Int32integer0M.AssertModel(models[3],_testData[26], false);
                        Int32integer0M.AssertModel(models[4],_testData[27], false);
                        Int32integer0M.AssertModel(models[5],_testData[28], false);
                        Int32integer0M.AssertModel(models[6],_testData[29], false);
                        Int32integer0M.AssertModel(models[7],_testData[30], false);
                        Int32integer0M.AssertModel(models[8],_testData[31], false);
                        Int32integer0M.AssertModel(models[9],_testData[32], false);
                        Int32integer0M.AssertModel(models[10],_testData[33], false);
                        Int32integer0M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        Int32integer0M.AssertModel(models[0],_testData[20], false);
                        Int32integer0M.AssertModel(models[1],_testData[21], false);
                        Int32integer0M.AssertModel(models[2],_testData[22], false);
                        Int32integer0M.AssertModel(models[3],_testData[23], false);
                        Int32integer0M.AssertModel(models[4],_testData[24], false);
                        Int32integer0M.AssertModel(models[5],_testData[25], false);
                        Int32integer0M.AssertModel(models[6],_testData[26], false);
                        Int32integer0M.AssertModel(models[7],_testData[27], false);
                        Int32integer0M.AssertModel(models[8],_testData[28], false);
                        Int32integer0M.AssertModel(models[9],_testData[29], false);
                        Int32integer0M.AssertModel(models[10],_testData[30], false);
                        Int32integer0M.AssertModel(models[11],_testData[31], false);
                        Int32integer0M.AssertModel(models[12],_testData[32], false);
                        Int32integer0M.AssertModel(models[13],_testData[33], false);
                        Int32integer0M.AssertModel(models[14],_testData[34], false);
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
                await using var cmd = await ((IInt32SingleTypeinteger)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IInt32SingleTypeinteger)this).SetDbConnectionSelectModelParametrs(cmd, 124);
                var models = await ((IInt32SingleTypeinteger)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(9));

                Int32integer0M.AssertModel(models[0],_testData[26], false);
                Int32integer0M.AssertModel(models[1],_testData[27], false);
                Int32integer0M.AssertModel(models[2],_testData[28], false);
                Int32integer0M.AssertModel(models[3],_testData[29], false);
                Int32integer0M.AssertModel(models[4],_testData[30], false);
                Int32integer0M.AssertModel(models[5],_testData[31], false);
                Int32integer0M.AssertModel(models[6],_testData[32], false);
                Int32integer0M.AssertModel(models[7],_testData[33], false);
                Int32integer0M.AssertModel(models[8],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt32SingleTypeinteger)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt32SingleTypeinteger)this).SetDbConnectionSelectModelParametrs(cmd, 77);
                var models =  ((IInt32SingleTypeinteger)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(18));

                Int32integer0M.AssertModel(models[0],_testData[17], false);
                Int32integer0M.AssertModel(models[1],_testData[18], false);
                Int32integer0M.AssertModel(models[2],_testData[19], false);
                Int32integer0M.AssertModel(models[3],_testData[20], false);
                Int32integer0M.AssertModel(models[4],_testData[21], false);
                Int32integer0M.AssertModel(models[5],_testData[22], false);
                Int32integer0M.AssertModel(models[6],_testData[23], false);
                Int32integer0M.AssertModel(models[7],_testData[24], false);
                Int32integer0M.AssertModel(models[8],_testData[25], false);
                Int32integer0M.AssertModel(models[9],_testData[26], false);
                Int32integer0M.AssertModel(models[10],_testData[27], false);
                Int32integer0M.AssertModel(models[11],_testData[28], false);
                Int32integer0M.AssertModel(models[12],_testData[29], false);
                Int32integer0M.AssertModel(models[13],_testData[30], false);
                Int32integer0M.AssertModel(models[14],_testData[31], false);
                Int32integer0M.AssertModel(models[15],_testData[32], false);
                Int32integer0M.AssertModel(models[16],_testData[33], false);
                Int32integer0M.AssertModel(models[17],_testData[34], false);
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
FROM public.int32integer0m m
LEFT JOIN public.int32integer0mi mi ON mi.id = m.int32integer0mi_id
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
            asPartInterface: typeof(IInt32SingleTypeinteger))]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IInt32SingleTypeinteger)this).DbConnectionSelectModelToObjArrAsync(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((5)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((863264306)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((565132054)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((11)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((532599951)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((733948815)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((807789609)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((732739339)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1650497074)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((387354268)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((284294551)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((44252744)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((824633956)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((492913314)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1740007440)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1591693268)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((1678376481)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((32)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1388524369)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1135803696)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1318090189)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((426145945)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((93446614)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((655339140)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1851449971)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((92788900)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((296973577)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((969691040)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1180267586)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((352636132)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1253204398)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((474878944)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1424838068)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((547681241)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1774055583)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((75)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((332076046)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((2146180320)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((2069314942)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1746210490)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((894013392)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((78)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1380763957)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1894364893)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((383136669)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((84530087)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1588239328)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1298897226)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1545783407)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1180191800)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1949465557)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((451530834)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((62)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((209573302)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((55311352)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((451475929)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((288871835)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((543961138)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1594028355)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((116)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((540625818)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1666630376)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1132163527)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1522410067)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((729227072)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((706871551)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((77)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((2141511187)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1519108371)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((134)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((819623006)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((256627897)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((759681742)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((83)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((20604625)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((330092012)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((240957128)));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1671192237)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((152)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((96936614)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((85)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1807649167)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((159)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((904670973)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((451216628)));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((163)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((185615827)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((86)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((542260815)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1272561774)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((172)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1475081548)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((IInt32SingleTypeinteger)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((5)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((863264306)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((565132054)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((11)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((532599951)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((733948815)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((807789609)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((732739339)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1650497074)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((387354268)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((284294551)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((44252744)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((824633956)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((492913314)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1740007440)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1591693268)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((1678376481)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((32)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1388524369)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1135803696)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1318090189)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((426145945)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((93446614)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((655339140)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1851449971)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((92788900)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((296973577)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((969691040)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1180267586)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((352636132)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1253204398)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((474878944)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1424838068)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((547681241)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1774055583)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((75)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((332076046)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((2146180320)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((2069314942)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1746210490)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((894013392)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((78)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1380763957)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1894364893)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((383136669)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((84530087)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1588239328)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1298897226)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1545783407)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1180191800)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1949465557)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((451530834)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((62)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((209573302)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((55311352)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((451475929)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((288871835)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((543961138)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1594028355)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((116)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((540625818)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1666630376)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1132163527)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1522410067)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((729227072)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((706871551)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((77)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((2141511187)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1519108371)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((134)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((819623006)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((256627897)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((759681742)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((83)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((20604625)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((330092012)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((240957128)));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1671192237)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((152)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((96936614)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((85)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1807649167)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((159)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((904670973)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((451216628)));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((163)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((185615827)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((86)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((542260815)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1272561774)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((172)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1475081548)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

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
FROM public.binary_int32integer0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(Int32integer0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeinteger))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(Int32integer0MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(9)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeinteger))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int32integer0MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int32integer0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt32SingleTypeinteger)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_int32integer0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IInt32SingleTypeinteger)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int32integer0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int32integer0MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int32integer0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt32SingleTypeinteger)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_int32integer0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IInt32SingleTypeinteger)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int32integer0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_int32integer0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(Int32integer0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeinteger))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(Int32integer0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeinteger))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int32integer0MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int32integer0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt32SingleTypeinteger)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_int32integer0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IInt32SingleTypeinteger)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int32integer0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int32integer0MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int32integer0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt32SingleTypeinteger)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_int32integer0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IInt32SingleTypeinteger)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int32integer0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_int32integer0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(Int32integer0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeinteger))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int32integer0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(Int32integer0MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(9)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeinteger))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int32integer0MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IInt32SingleTypeinteger)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IInt32SingleTypeinteger)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int32integer0MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int32integer0MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IInt32SingleTypeinteger)this).WAImportModelInner(connection, importCollection);
                var models = ((IInt32SingleTypeinteger)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int32integer0MI.AssertModel(actual, expect, false);
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
FROM public.binary_int32integer0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(Int32integer0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeinteger))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int32integer0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(Int32integer0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeinteger))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int32integer0MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int32integer0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt32SingleTypeinteger)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IInt32SingleTypeinteger)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int32integer0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int32integer0MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int32integer0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt32SingleTypeinteger)this).ImportModelInner(connection, importCollection);
                var models = ((IInt32SingleTypeinteger)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int32integer0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int32integer0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
int32integer0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(Int32integer0M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(9)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeinteger))]
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
FROM public.binary_int32integer0m m
LEFT JOIN public.binary_int32integer0mi mi ON mi.id = m.int32integer0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(Int32integer0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeinteger))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int32integer0M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IInt32SingleTypeinteger)this).ImportModelAsync(connection, importCollection);
                var models = await ((IInt32SingleTypeinteger)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Int32integer0M.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int32integer0M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IInt32SingleTypeinteger)this).ImportModel(connection, importCollection);
                var models = ((IInt32SingleTypeinteger)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Int32integer0M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int32integer0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    int32integer0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(Int32integer0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeinteger)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(9)
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
                var models =  ((IInt32SingleTypeinteger)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Int32integer0M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IInt32SingleTypeinteger)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Int32integer0M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(Int32integer0MIWA), typeof(Int32integer0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeinteger)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(9)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(9)
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
                var models1 = new List<Int32integer0MIWA>();
                var models2 = new List<Int32integer0MIWA>();
                await ((IInt32SingleTypeinteger)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int32integer0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int32integer0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int32integer0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int32integer0MIWA>();
                var models2 = new List<Int32integer0MIWA>();
                ((IInt32SingleTypeinteger)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int32integer0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int32integer0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int32integer0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(Int32integer0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeinteger)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(9)
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
                var models = await ((IInt32SingleTypeinteger)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_int32integer0mi
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
                    Int32integer0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IInt32SingleTypeinteger)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_int32integer0mi
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
                    Int32integer0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(Int32integer0MIWA), typeof(Int32integer0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeinteger))]
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
                var models1 = new List<Int32integer0MIWA>();
                var models2 = new List<Int32integer0MIWA>();
                await ((IInt32SingleTypeinteger)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int32integer0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int32integer0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int32integer0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int32integer0MIWA>();
                var models2 = new List<Int32integer0MIWA>();
                ((IInt32SingleTypeinteger)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int32integer0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int32integer0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int32integer0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(Int32integer0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeinteger))]
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
                var models = await ((IInt32SingleTypeinteger)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_int32integer0mi
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
                    Int32integer0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IInt32SingleTypeinteger)this).DynQueryExportModelInner(connection, @"
COPY public.binary_int32integer0mi
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
                    Int32integer0MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_int32integer0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(Int32integer0MI), typeof(Int32integer0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeinteger)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(9)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(9)
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
                var models1 = new List<Int32integer0MI>();
                var models2 = new List<Int32integer0MI>();
                await ((IInt32SingleTypeinteger)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int32integer0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int32integer0MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int32integer0MI>();
                var models2 = new List<Int32integer0MI>();
                ((IInt32SingleTypeinteger)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int32integer0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int32integer0MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int32integer0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(Int32integer0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeinteger)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(9)
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
                var models = await ((IInt32SingleTypeinteger)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int32integer0MI.AssertModel(model, expectedModel, false);
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
                var models = ((IInt32SingleTypeinteger)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int32integer0MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_int32integer0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(Int32integer0MIWA), typeof(Int32integer0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeinteger))]
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
                var models1 = new List<Int32integer0MIWA>();
                var models2 = new List<Int32integer0MIWA>();
                await ((IInt32SingleTypeinteger)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int32integer0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int32integer0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int32integer0MIWA>();
                var models2 = new List<Int32integer0MIWA>();
                ((IInt32SingleTypeinteger)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int32integer0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int32integer0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int32integer0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(Int32integer0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeinteger))]
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
                var models = await ((IInt32SingleTypeinteger)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int32integer0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IInt32SingleTypeinteger)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int32integer0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

