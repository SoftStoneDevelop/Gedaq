

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
    internal partial interface IInt64SingleTypebigint
    {
    }
    
    internal partial class Int64SingleTypebigint : IInt64SingleTypebigint
    {


#region TestData

        private readonly Int64bigint0M[] _testData = new Int64bigint0M[]
        {
            new Int64bigint0M
{
    Id = 8,
    Value = 6798322344769649655L,
    ModelInner = null,
    NullableValue = 632795822962478660L,
},
            new Int64bigint0M
{
    Id = 10,
    Value = 5306146733827659773L,
    ModelInner = new Int64bigint0MI
{
    Id = 4,
    Value = 3158073392357726781L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 16,
    Value = 4344993566030571278L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 23,
    Value = 7041629593476922601L,
    ModelInner = new Int64bigint0MI
{
    Id = 7,
    Value = 4397206160597103528L,
    NullableValue = 4452131160383558893L,
},
    NullableValue = 3787466667685100262L,
},
            new Int64bigint0M
{
    Id = 28,
    Value = 6465605584076258761L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 37,
    Value = 7375460516371604349L,
    ModelInner = new Int64bigint0MI
{
    Id = 13,
    Value = 8700386034037465503L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 43,
    Value = 3540578770837774527L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 51,
    Value = 1713961902381755984L,
    ModelInner = new Int64bigint0MI
{
    Id = 16,
    Value = 1888939219388885653L,
    NullableValue = null,
},
    NullableValue = 4357763193870799791L,
},
            new Int64bigint0M
{
    Id = 52,
    Value = 1482745311884553191L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 54,
    Value = 1890223918028944069L,
    ModelInner = new Int64bigint0MI
{
    Id = 21,
    Value = 8778509366659508342L,
    NullableValue = 3542642406831486852L,
},
    NullableValue = 8346900728317718719L,
},
            new Int64bigint0M
{
    Id = 55,
    Value = 7438606325194743701L,
    ModelInner = null,
    NullableValue = 3216964745834966283L,
},
            new Int64bigint0M
{
    Id = 59,
    Value = 7241627111377859926L,
    ModelInner = new Int64bigint0MI
{
    Id = 29,
    Value = 1697415512400118949L,
    NullableValue = 9213282357112621841L,
},
    NullableValue = 6225832718911468481L,
},
            new Int64bigint0M
{
    Id = 66,
    Value = 1829109777139918875L,
    ModelInner = null,
    NullableValue = 6615039133336963309L,
},
            new Int64bigint0M
{
    Id = 69,
    Value = 4600455565256176541L,
    ModelInner = new Int64bigint0MI
{
    Id = 35,
    Value = 6853779127200822163L,
    NullableValue = 4081876219416962242L,
},
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 72,
    Value = 8108841509015169371L,
    ModelInner = null,
    NullableValue = 8659626892557673168L,
},
            new Int64bigint0M
{
    Id = 78,
    Value = 1030420230544448033L,
    ModelInner = new Int64bigint0MI
{
    Id = 43,
    Value = 6728091903133428139L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 86,
    Value = 8997056299818704983L,
    ModelInner = null,
    NullableValue = 7515568810987762739L,
},
            new Int64bigint0M
{
    Id = 91,
    Value = 1403490187531775810L,
    ModelInner = new Int64bigint0MI
{
    Id = 52,
    Value = 7216286564698010112L,
    NullableValue = null,
},
    NullableValue = 9162485551301471057L,
},
            new Int64bigint0M
{
    Id = 100,
    Value = 1102090383858717828L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 108,
    Value = 4899070459745693850L,
    ModelInner = new Int64bigint0MI
{
    Id = 54,
    Value = 9006191913369920225L,
    NullableValue = 5373429963348358804L,
},
    NullableValue = 5268792208833150329L,
},
            new Int64bigint0M
{
    Id = 115,
    Value = 1992588398631330514L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 118,
    Value = 1336903713037108065L,
    ModelInner = new Int64bigint0MI
{
    Id = 63,
    Value = 5984120123337118091L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 125,
    Value = 8961382193959673043L,
    ModelInner = null,
    NullableValue = 7615008126700595651L,
},
            new Int64bigint0M
{
    Id = 133,
    Value = 1426218941776251795L,
    ModelInner = new Int64bigint0MI
{
    Id = 68,
    Value = 115521750413267216L,
    NullableValue = 2132979575741541577L,
},
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 142,
    Value = 323295232662348328L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 150,
    Value = 3460676226831706229L,
    ModelInner = new Int64bigint0MI
{
    Id = 73,
    Value = 1633329610596154546L,
    NullableValue = 5211400944278270072L,
},
    NullableValue = 649803137039493994L,
},
            new Int64bigint0M
{
    Id = 155,
    Value = 3010463507450501471L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 162,
    Value = 8388931397428983385L,
    ModelInner = new Int64bigint0MI
{
    Id = 82,
    Value = 7928705549234037397L,
    NullableValue = 2372619966588608892L,
},
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 171,
    Value = 3797827887922407177L,
    ModelInner = null,
    NullableValue = 2556461333270963943L,
},
            new Int64bigint0M
{
    Id = 176,
    Value = 2984413037827647748L,
    ModelInner = new Int64bigint0MI
{
    Id = 84,
    Value = 7205264235423721589L,
    NullableValue = 7987833131073443466L,
},
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigint0mi(
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
            asPartInterface: typeof(IInt64SingleTypebigint)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64?), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(1))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigint0mi(
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
            queryMapTypes: [typeof(Int64bigint0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(1))]
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

                changedRows =  ((IInt64SingleTypebigint)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IInt64SingleTypebigint)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IInt64SingleTypebigint)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IInt64SingleTypebigint)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IInt64SingleTypebigint)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IInt64SingleTypebigint)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IInt64SingleTypebigint)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.int64bigint0mi(
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
            asPartInterface: typeof(IInt64SingleTypebigint)), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int64), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(12)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int64?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(12), 
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

                changedRows =  ((IInt64SingleTypebigint)this).DbConnectionInsertInnerModel(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
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

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertInnerModelAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertInnerModelAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertInnerModelAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertInnerModelAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertInnerModelAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertInnerModelAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigint0m(
	id,
    value,
    nullablevalue,
    int64bigint0mi_id
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
            asPartInterface: typeof(IInt64SingleTypebigint)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "int64bigint0mi_id", 
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
                changedRows =  ((IInt64SingleTypebigint)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IInt64SingleTypebigint)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IInt64SingleTypebigint)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IInt64SingleTypebigint)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigint0m(
	id,
    value,
    nullablevalue,
    int64bigint0mi_id
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
    int64bigint0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(Int64bigint0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
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
                System.Int64? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<System.Int64>();
                    ((NpgsqlParameter<System.Int64>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(1);
                    ((NpgsqlParameter<System.Int64>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(1);
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

                    nullable =  ((IInt64SingleTypebigint)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<System.Int64>();
                    ((NpgsqlParameter<System.Int64>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(1);
                    ((NpgsqlParameter<System.Int64>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(1);
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

                    nullable =  ((IInt64SingleTypebigint)this).ScalarInsertModelDynParReturning(connection, parameters);
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
                System.Int64? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<System.Int64>();
                    ((NpgsqlParameter<System.Int64>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(1);
                    ((NpgsqlParameter<System.Int64>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(1);
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

                    nullable = await ((IInt64SingleTypebigint)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<System.Int64>();
                    ((NpgsqlParameter<System.Int64>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(1);
                    ((NpgsqlParameter<System.Int64>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(1);
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

                    nullable = await ((IInt64SingleTypebigint)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(4357763193870799791L));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigint0m(
	id,
    value,
    nullablevalue,
    int64bigint0mi_id
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
    int64bigint0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(Int64bigint0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "int64bigint0mi_id", 
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
                System.Int64? nullable = null;
                nullable =  ((IInt64SingleTypebigint)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((IInt64SingleTypebigint)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(8346900728317718719L));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int64? nullable = null;
                nullable = await ((IInt64SingleTypebigint)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(3216964745834966283L));
                nullable = await ((IInt64SingleTypebigint)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(6225832718911468481L));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Int64bigint0M> models = null;

                models =  ((IInt64SingleTypebigint)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigint0M.AssertModel(models[0],_testData[12], true);
                models =  ((IInt64SingleTypebigint)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigint0M.AssertModel(models[0],_testData[13], true);
                models =  ((IInt64SingleTypebigint)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigint0M.AssertModel(models[0],_testData[14], true);
                models =  ((IInt64SingleTypebigint)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigint0M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Int64bigint0M> models = null;

                models = await ((IInt64SingleTypebigint)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigint0M.AssertModel(models[0],_testData[16], true);
                models = await ((IInt64SingleTypebigint)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigint0M.AssertModel(models[0],_testData[17], true);
                models = await ((IInt64SingleTypebigint)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigint0M.AssertModel(models[0],_testData[18], true);
                models = await ((IInt64SingleTypebigint)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigint0M.AssertModel(models[0],_testData[19], true);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.int64bigint0m(
	id,
    value,
    nullablevalue,
    int64bigint0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @int64bigint0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int64), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(12)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int64?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(12),
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "int64bigint0mi_id", 
                methodParametrName: "int64bigint0mi_id", 
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

                changedRows =  ((IInt64SingleTypebigint)this).DbConnectionInsertModel(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IInt64SingleTypebigint)this).DbConnectionInsertModel(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
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

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigint0M), typeof(FlatInt64bigint0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
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
FROM public.int64bigint0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatInt64bigint0M>();
                var models2 = new List<FlatInt64bigint0M>();
                await ((IInt64SingleTypebigint)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigint0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int64bigint0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatInt64bigint0M>();
                var models2 = new List<FlatInt64bigint0M>();
                ((IInt64SingleTypebigint)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigint0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigint0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
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
FROM public.int64bigint0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IInt64SingleTypebigint)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigint0M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigint0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IInt64SingleTypebigint)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigint0M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigint0m m
LEFT JOIN public.int64bigint0mi mi ON mi.id = m.int64bigint0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Int64bigint0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
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
                var models = await ((IInt64SingleTypebigint)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int64bigint0M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IInt64SingleTypebigint)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int64bigint0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigint0M), typeof(FlatInt64bigint0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
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
FROM public.int64bigint0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigint0M>();
                var models2 = new List<FlatInt64bigint0M>();
                await ((IInt64SingleTypebigint)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigint0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int64bigint0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigint0M>();
                var models2 = new List<FlatInt64bigint0M>();
                ((IInt64SingleTypebigint)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigint0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigint0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
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
FROM public.int64bigint0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IInt64SingleTypebigint)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigint0M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigint0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IInt64SingleTypebigint)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigint0M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigint0m m
LEFT JOIN public.int64bigint0mi mi ON mi.id = m.int64bigint0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Int64bigint0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
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
                var models = await ((IInt64SingleTypebigint)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int64bigint0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IInt64SingleTypebigint)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int64bigint0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigint0M), typeof(FlatInt64bigint0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
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
            asPartInterface: typeof(IInt64SingleTypebigint)),
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
FROM public.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt64bigint0M>();
                var models2 = new List<FlatInt64bigint0M>();
                await((IInt64SingleTypebigint)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigint0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 37;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 55;
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
FROM public.int64bigint0m m
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
FROM public.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigint0M>();
                var firstItems2 = new List<FlatInt64bigint0M>();
                var secondItems1 = new List<FlatInt64bigint0M>();
                var secondItems2 = new List<FlatInt64bigint0M>();
                await ((IInt64SingleTypebigint)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatInt64bigint0M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[23],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[18],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 115;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 133;
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
FROM public.int64bigint0m m
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
FROM public.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigint0M>();
                var firstItems2 = new List<FlatInt64bigint0M>();
                var secondItems1 = new List<FlatInt64bigint0M>();
                await ((IInt64SingleTypebigint)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatInt64bigint0M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[8],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[5],_testData[29], false);
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
FROM public.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt64bigint0M>();
                var models2 = new List<FlatInt64bigint0M>();
                ((IInt64SingleTypebigint)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigint0M.AssertModel(models2[i],_testData[i], false);
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
                parametr2.Value = 125;
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
FROM public.int64bigint0m m
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
FROM public.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigint0M>();
                var firstItems2 = new List<FlatInt64bigint0M>();
                var secondItems1 = new List<FlatInt64bigint0M>();
                var secondItems2 = new List<FlatInt64bigint0M>();
                 ((IInt64SingleTypebigint)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatInt64bigint0M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[17],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[6],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 28;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 162;
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
FROM public.int64bigint0m m
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
FROM public.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigint0M>();
                var firstItems2 = new List<FlatInt64bigint0M>();
                var secondItems1 = new List<FlatInt64bigint0M>();
                 ((IInt64SingleTypebigint)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatInt64bigint0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[24],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigint0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
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
            asPartInterface: typeof(IInt64SingleTypebigint)),
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
FROM public.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IInt64SingleTypebigint)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigint0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 150;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 162;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int64bigint0m m
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
FROM public.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64SingleTypebigint)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatInt64bigint0M.AssertModel(models[0],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(models[1],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(models[2],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(models[3],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatInt64bigint0M.AssertModel(models[0],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(models[1],_testData[29], false);
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
                parametr1.Value = 78;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 162;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int64bigint0m m
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
FROM public.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigint0M>();
                var secondItems1 = new List<FlatInt64bigint0M>();
                var secondItems2 = new List<FlatInt64bigint0M>();
                await ((IInt64SingleTypebigint)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                        FlatInt64bigint0M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[13],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[1],_testData[29], false);
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
FROM public.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IInt64SingleTypebigint)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigint0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 155;
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
FROM public.int64bigint0m m
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
FROM public.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64SingleTypebigint)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatInt64bigint0M.AssertModel(models[0],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(models[1],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatInt64bigint0M.AssertModel(models[0],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(models[1],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(models[2],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(models[3],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(models[4],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(models[5],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(models[6],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(models[7],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(models[8],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(models[9],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(models[10],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(models[11],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(models[12],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(models[13],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(models[14],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(models[15],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(models[16],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(models[17],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(models[18],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(models[19],_testData[29], false);
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
                parametr2.Value = 66;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int64bigint0m m
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
FROM public.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigint0M>();
                var secondItems1 = new List<FlatInt64bigint0M>();
                var secondItems2 = new List<FlatInt64bigint0M>();
                 ((IInt64SingleTypebigint)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatInt64bigint0M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[12],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[16],_testData[29], false);
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
FROM public.int64bigint0m m
LEFT JOIN public.int64bigint0mi mi ON mi.id = m.int64bigint0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Int64bigint0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
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
                var models = await((IInt64SingleTypebigint)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int64bigint0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 100;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 86;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64SingleTypebigint)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        Int64bigint0M.AssertModel(models[0],_testData[19], false);
                        Int64bigint0M.AssertModel(models[1],_testData[20], false);
                        Int64bigint0M.AssertModel(models[2],_testData[21], false);
                        Int64bigint0M.AssertModel(models[3],_testData[22], false);
                        Int64bigint0M.AssertModel(models[4],_testData[23], false);
                        Int64bigint0M.AssertModel(models[5],_testData[24], false);
                        Int64bigint0M.AssertModel(models[6],_testData[25], false);
                        Int64bigint0M.AssertModel(models[7],_testData[26], false);
                        Int64bigint0M.AssertModel(models[8],_testData[27], false);
                        Int64bigint0M.AssertModel(models[9],_testData[28], false);
                        Int64bigint0M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        Int64bigint0M.AssertModel(models[0],_testData[17], false);
                        Int64bigint0M.AssertModel(models[1],_testData[18], false);
                        Int64bigint0M.AssertModel(models[2],_testData[19], false);
                        Int64bigint0M.AssertModel(models[3],_testData[20], false);
                        Int64bigint0M.AssertModel(models[4],_testData[21], false);
                        Int64bigint0M.AssertModel(models[5],_testData[22], false);
                        Int64bigint0M.AssertModel(models[6],_testData[23], false);
                        Int64bigint0M.AssertModel(models[7],_testData[24], false);
                        Int64bigint0M.AssertModel(models[8],_testData[25], false);
                        Int64bigint0M.AssertModel(models[9],_testData[26], false);
                        Int64bigint0M.AssertModel(models[10],_testData[27], false);
                        Int64bigint0M.AssertModel(models[11],_testData[28], false);
                        Int64bigint0M.AssertModel(models[12],_testData[29], false);
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
                var models = ((IInt64SingleTypebigint)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int64bigint0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 155;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 155;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64SingleTypebigint)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        Int64bigint0M.AssertModel(models[0],_testData[27], false);
                        Int64bigint0M.AssertModel(models[1],_testData[28], false);
                        Int64bigint0M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        Int64bigint0M.AssertModel(models[0],_testData[27], false);
                        Int64bigint0M.AssertModel(models[1],_testData[28], false);
                        Int64bigint0M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigint0M), typeof(FlatInt64bigint0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
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
            asPartInterface: typeof(IInt64SingleTypebigint)),
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
            asPartInterface: typeof(IInt64SingleTypebigint)),
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
FROM public.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigint0M>();
                var models2 = new List<FlatInt64bigint0M>();
                await((IInt64SingleTypebigint)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigint0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int64bigint0m m
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
FROM public.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigint0M>();
                var firstItems2 = new List<FlatInt64bigint0M>();
                var secondItems1 = new List<FlatInt64bigint0M>();
                var secondItems2 = new List<FlatInt64bigint0M>();
                await ((IInt64SingleTypebigint)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 162, query1, 72, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatInt64bigint0M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[1],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[14],_testData[29], false);
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
FROM public.int64bigint0m m
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
FROM public.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigint0M>();
                var firstItems2 = new List<FlatInt64bigint0M>();
                var secondItems1 = new List<FlatInt64bigint0M>();
                await ((IInt64SingleTypebigint)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 125, query1, 43, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatInt64bigint0M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[6],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[22],_testData[29], false);
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
FROM public.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigint0M>();
                var models2 = new List<FlatInt64bigint0M>();
                ((IInt64SingleTypebigint)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigint0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int64bigint0m m
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
FROM public.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigint0M>();
                var firstItems2 = new List<FlatInt64bigint0M>();
                var secondItems1 = new List<FlatInt64bigint0M>();
                var secondItems2 = new List<FlatInt64bigint0M>();
                 ((IInt64SingleTypebigint)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 37, query1, 72, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatInt64bigint0M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[23],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[14],_testData[29], false);
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
FROM public.int64bigint0m m
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
FROM public.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigint0M>();
                var firstItems2 = new List<FlatInt64bigint0M>();
                var secondItems1 = new List<FlatInt64bigint0M>();
                 ((IInt64SingleTypebigint)this).DbConnectionMMDynQuerySelectModelBatch(connection, 69, query1, 16, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatInt64bigint0M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[15],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[26],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigint0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
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
            asPartInterface: typeof(IInt64SingleTypebigint)),
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
            asPartInterface: typeof(IInt64SingleTypebigint)),
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
FROM public.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IInt64SingleTypebigint)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigint0M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigint0m m
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
FROM public.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64SingleTypebigint)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 162, query1, 100, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatInt64bigint0M.AssertModel(models[0],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatInt64bigint0M.AssertModel(models[0],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(models[1],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(models[2],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(models[3],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(models[4],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(models[5],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(models[6],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(models[7],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(models[8],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(models[9],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(models[10],_testData[29], false);
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
FROM public.int64bigint0m m
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
FROM public.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigint0M>();
                var secondItems1 = new List<FlatInt64bigint0M>();
                var secondItems2 = new List<FlatInt64bigint0M>();
                await ((IInt64SingleTypebigint)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 66, query1, 51, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                        FlatInt64bigint0M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[16],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[21],_testData[29], false);
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
FROM public.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IInt64SingleTypebigint)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigint0M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigint0m m
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
FROM public.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64SingleTypebigint)this).DbConnectionSTDynQuerySelectModelBatch(connection, 133, query1, 118, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatInt64bigint0M.AssertModel(models[0],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(models[1],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(models[2],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(models[3],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(models[4],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatInt64bigint0M.AssertModel(models[0],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(models[1],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(models[2],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(models[3],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(models[4],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(models[5],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(models[6],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(models[7],_testData[29], false);
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
FROM public.int64bigint0m m
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
FROM public.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigint0M>();
                var secondItems1 = new List<FlatInt64bigint0M>();
                var secondItems2 = new List<FlatInt64bigint0M>();
                 ((IInt64SingleTypebigint)this).DbConnectionDynQuerySelectModelBatch(connection, 8, query1, 28, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatInt64bigint0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[28],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[24],_testData[29], false);
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
FROM public.int64bigint0m m
LEFT JOIN public.int64bigint0mi mi ON mi.id = m.int64bigint0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Int64bigint0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
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
            asPartInterface: typeof(IInt64SingleTypebigint)),
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
                var models = await((IInt64SingleTypebigint)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int64bigint0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IInt64SingleTypebigint)this).DbConnectionSTSelectModelBatchAsync(connection, 66, 155))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        Int64bigint0M.AssertModel(models[0],_testData[13], false);
                        Int64bigint0M.AssertModel(models[1],_testData[14], false);
                        Int64bigint0M.AssertModel(models[2],_testData[15], false);
                        Int64bigint0M.AssertModel(models[3],_testData[16], false);
                        Int64bigint0M.AssertModel(models[4],_testData[17], false);
                        Int64bigint0M.AssertModel(models[5],_testData[18], false);
                        Int64bigint0M.AssertModel(models[6],_testData[19], false);
                        Int64bigint0M.AssertModel(models[7],_testData[20], false);
                        Int64bigint0M.AssertModel(models[8],_testData[21], false);
                        Int64bigint0M.AssertModel(models[9],_testData[22], false);
                        Int64bigint0M.AssertModel(models[10],_testData[23], false);
                        Int64bigint0M.AssertModel(models[11],_testData[24], false);
                        Int64bigint0M.AssertModel(models[12],_testData[25], false);
                        Int64bigint0M.AssertModel(models[13],_testData[26], false);
                        Int64bigint0M.AssertModel(models[14],_testData[27], false);
                        Int64bigint0M.AssertModel(models[15],_testData[28], false);
                        Int64bigint0M.AssertModel(models[16],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        Int64bigint0M.AssertModel(models[0],_testData[27], false);
                        Int64bigint0M.AssertModel(models[1],_testData[28], false);
                        Int64bigint0M.AssertModel(models[2],_testData[29], false);
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
                var models = ((IInt64SingleTypebigint)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int64bigint0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IInt64SingleTypebigint)this).DbConnectionSTSelectModelBatch(connection, 8, 69))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        Int64bigint0M.AssertModel(models[0],_testData[1], false);
                        Int64bigint0M.AssertModel(models[1],_testData[2], false);
                        Int64bigint0M.AssertModel(models[2],_testData[3], false);
                        Int64bigint0M.AssertModel(models[3],_testData[4], false);
                        Int64bigint0M.AssertModel(models[4],_testData[5], false);
                        Int64bigint0M.AssertModel(models[5],_testData[6], false);
                        Int64bigint0M.AssertModel(models[6],_testData[7], false);
                        Int64bigint0M.AssertModel(models[7],_testData[8], false);
                        Int64bigint0M.AssertModel(models[8],_testData[9], false);
                        Int64bigint0M.AssertModel(models[9],_testData[10], false);
                        Int64bigint0M.AssertModel(models[10],_testData[11], false);
                        Int64bigint0M.AssertModel(models[11],_testData[12], false);
                        Int64bigint0M.AssertModel(models[12],_testData[13], false);
                        Int64bigint0M.AssertModel(models[13],_testData[14], false);
                        Int64bigint0M.AssertModel(models[14],_testData[15], false);
                        Int64bigint0M.AssertModel(models[15],_testData[16], false);
                        Int64bigint0M.AssertModel(models[16],_testData[17], false);
                        Int64bigint0M.AssertModel(models[17],_testData[18], false);
                        Int64bigint0M.AssertModel(models[18],_testData[19], false);
                        Int64bigint0M.AssertModel(models[19],_testData[20], false);
                        Int64bigint0M.AssertModel(models[20],_testData[21], false);
                        Int64bigint0M.AssertModel(models[21],_testData[22], false);
                        Int64bigint0M.AssertModel(models[22],_testData[23], false);
                        Int64bigint0M.AssertModel(models[23],_testData[24], false);
                        Int64bigint0M.AssertModel(models[24],_testData[25], false);
                        Int64bigint0M.AssertModel(models[25],_testData[26], false);
                        Int64bigint0M.AssertModel(models[26],_testData[27], false);
                        Int64bigint0M.AssertModel(models[27],_testData[28], false);
                        Int64bigint0M.AssertModel(models[28],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        Int64bigint0M.AssertModel(models[0],_testData[14], false);
                        Int64bigint0M.AssertModel(models[1],_testData[15], false);
                        Int64bigint0M.AssertModel(models[2],_testData[16], false);
                        Int64bigint0M.AssertModel(models[3],_testData[17], false);
                        Int64bigint0M.AssertModel(models[4],_testData[18], false);
                        Int64bigint0M.AssertModel(models[5],_testData[19], false);
                        Int64bigint0M.AssertModel(models[6],_testData[20], false);
                        Int64bigint0M.AssertModel(models[7],_testData[21], false);
                        Int64bigint0M.AssertModel(models[8],_testData[22], false);
                        Int64bigint0M.AssertModel(models[9],_testData[23], false);
                        Int64bigint0M.AssertModel(models[10],_testData[24], false);
                        Int64bigint0M.AssertModel(models[11],_testData[25], false);
                        Int64bigint0M.AssertModel(models[12],_testData[26], false);
                        Int64bigint0M.AssertModel(models[13],_testData[27], false);
                        Int64bigint0M.AssertModel(models[14],_testData[28], false);
                        Int64bigint0M.AssertModel(models[15],_testData[29], false);
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
                await using var cmd = await ((IInt64SingleTypebigint)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IInt64SingleTypebigint)this).SetDbConnectionSelectModelParametrs(cmd, 16);
                var models = await ((IInt64SingleTypebigint)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(27));
Int64bigint0M.AssertModel(models[0],_testData[3], false);Int64bigint0M.AssertModel(models[1],_testData[4], false);Int64bigint0M.AssertModel(models[2],_testData[5], false);Int64bigint0M.AssertModel(models[3],_testData[6], false);Int64bigint0M.AssertModel(models[4],_testData[7], false);Int64bigint0M.AssertModel(models[5],_testData[8], false);Int64bigint0M.AssertModel(models[6],_testData[9], false);Int64bigint0M.AssertModel(models[7],_testData[10], false);Int64bigint0M.AssertModel(models[8],_testData[11], false);Int64bigint0M.AssertModel(models[9],_testData[12], false);Int64bigint0M.AssertModel(models[10],_testData[13], false);Int64bigint0M.AssertModel(models[11],_testData[14], false);Int64bigint0M.AssertModel(models[12],_testData[15], false);Int64bigint0M.AssertModel(models[13],_testData[16], false);Int64bigint0M.AssertModel(models[14],_testData[17], false);Int64bigint0M.AssertModel(models[15],_testData[18], false);Int64bigint0M.AssertModel(models[16],_testData[19], false);Int64bigint0M.AssertModel(models[17],_testData[20], false);Int64bigint0M.AssertModel(models[18],_testData[21], false);Int64bigint0M.AssertModel(models[19],_testData[22], false);Int64bigint0M.AssertModel(models[20],_testData[23], false);Int64bigint0M.AssertModel(models[21],_testData[24], false);Int64bigint0M.AssertModel(models[22],_testData[25], false);Int64bigint0M.AssertModel(models[23],_testData[26], false);Int64bigint0M.AssertModel(models[24],_testData[27], false);Int64bigint0M.AssertModel(models[25],_testData[28], false);Int64bigint0M.AssertModel(models[26],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt64SingleTypebigint)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt64SingleTypebigint)this).SetDbConnectionSelectModelParametrs(cmd, 43);
                var models =  ((IInt64SingleTypebigint)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(23));
Int64bigint0M.AssertModel(models[0],_testData[7], false);Int64bigint0M.AssertModel(models[1],_testData[8], false);Int64bigint0M.AssertModel(models[2],_testData[9], false);Int64bigint0M.AssertModel(models[3],_testData[10], false);Int64bigint0M.AssertModel(models[4],_testData[11], false);Int64bigint0M.AssertModel(models[5],_testData[12], false);Int64bigint0M.AssertModel(models[6],_testData[13], false);Int64bigint0M.AssertModel(models[7],_testData[14], false);Int64bigint0M.AssertModel(models[8],_testData[15], false);Int64bigint0M.AssertModel(models[9],_testData[16], false);Int64bigint0M.AssertModel(models[10],_testData[17], false);Int64bigint0M.AssertModel(models[11],_testData[18], false);Int64bigint0M.AssertModel(models[12],_testData[19], false);Int64bigint0M.AssertModel(models[13],_testData[20], false);Int64bigint0M.AssertModel(models[14],_testData[21], false);Int64bigint0M.AssertModel(models[15],_testData[22], false);Int64bigint0M.AssertModel(models[16],_testData[23], false);Int64bigint0M.AssertModel(models[17],_testData[24], false);Int64bigint0M.AssertModel(models[18],_testData[25], false);Int64bigint0M.AssertModel(models[19],_testData[26], false);Int64bigint0M.AssertModel(models[20],_testData[27], false);Int64bigint0M.AssertModel(models[21],_testData[28], false);Int64bigint0M.AssertModel(models[22],_testData[29], false);
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
FROM public.int64bigint0m m
LEFT JOIN public.int64bigint0mi mi ON mi.id = m.int64bigint0mi_id
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
            asPartInterface: typeof(IInt64SingleTypebigint))]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IInt64SingleTypebigint)this).DbConnectionSelectModelToObjArrAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6798322344769649655L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((632795822962478660L)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5306146733827659773L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((4)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((3158073392357726781L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4344993566030571278L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7041629593476922601L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((4397206160597103528L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((4452131160383558893L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((3787466667685100262L)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6465605584076258761L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7375460516371604349L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((8700386034037465503L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3540578770837774527L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1713961902381755984L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((1888939219388885653L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((4357763193870799791L)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1482745311884553191L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1890223918028944069L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((21)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((8778509366659508342L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((3542642406831486852L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((8346900728317718719L)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7438606325194743701L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((3216964745834966283L)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7241627111377859926L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((1697415512400118949L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((9213282357112621841L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((6225832718911468481L)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1829109777139918875L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((6615039133336963309L)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4600455565256176541L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((6853779127200822163L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((4081876219416962242L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8108841509015169371L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((8659626892557673168L)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((78)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1030420230544448033L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((6728091903133428139L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8997056299818704983L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((7515568810987762739L)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1403490187531775810L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((7216286564698010112L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((9162485551301471057L)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1102090383858717828L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4899070459745693850L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((9006191913369920225L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((5373429963348358804L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((5268792208833150329L)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1992588398631330514L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1336903713037108065L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((5984120123337118091L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8961382193959673043L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((7615008126700595651L)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1426218941776251795L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((68)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((115521750413267216L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((2132979575741541577L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((142)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((323295232662348328L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3460676226831706229L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((73)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((1633329610596154546L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((5211400944278270072L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((649803137039493994L)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3010463507450501471L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((162)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8388931397428983385L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((82)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((7928705549234037397L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((2372619966588608892L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((171)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3797827887922407177L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((2556461333270963943L)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((176)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2984413037827647748L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((84)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((7205264235423721589L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((7987833131073443466L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((IInt64SingleTypebigint)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6798322344769649655L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((632795822962478660L)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5306146733827659773L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((4)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((3158073392357726781L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4344993566030571278L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7041629593476922601L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((4397206160597103528L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((4452131160383558893L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((3787466667685100262L)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6465605584076258761L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7375460516371604349L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((8700386034037465503L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3540578770837774527L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1713961902381755984L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((1888939219388885653L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((4357763193870799791L)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1482745311884553191L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1890223918028944069L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((21)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((8778509366659508342L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((3542642406831486852L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((8346900728317718719L)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7438606325194743701L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((3216964745834966283L)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7241627111377859926L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((1697415512400118949L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((9213282357112621841L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((6225832718911468481L)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1829109777139918875L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((6615039133336963309L)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4600455565256176541L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((6853779127200822163L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((4081876219416962242L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8108841509015169371L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((8659626892557673168L)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((78)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1030420230544448033L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((6728091903133428139L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8997056299818704983L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((7515568810987762739L)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1403490187531775810L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((7216286564698010112L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((9162485551301471057L)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1102090383858717828L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4899070459745693850L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((9006191913369920225L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((5373429963348358804L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((5268792208833150329L)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1992588398631330514L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1336903713037108065L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((5984120123337118091L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8961382193959673043L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((7615008126700595651L)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1426218941776251795L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((68)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((115521750413267216L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((2132979575741541577L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((142)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((323295232662348328L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3460676226831706229L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((73)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((1633329610596154546L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((5211400944278270072L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((649803137039493994L)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3010463507450501471L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((162)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8388931397428983385L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((82)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((7928705549234037397L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((2372619966588608892L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((171)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3797827887922407177L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((2556461333270963943L)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((176)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2984413037827647748L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((84)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((7205264235423721589L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((7987833131073443466L)));//InnerModel.NullableValue

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
FROM public.binary_int64bigint0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(Int64bigint0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(Int64bigint0MIWA),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(1),
                (NpgsqlTypes.NpgsqlDbType)(1)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigint0MIWA>(2);
                for (int i = 0; i < 6; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigint0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt64SingleTypebigint)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_int64bigint0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IInt64SingleTypebigint)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigint0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(0)]
        public  void DynQueryImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<Int64bigint0MIWA>(2);
                for (int i = 4; i < 10; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigint0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt64SingleTypebigint)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_int64bigint0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IInt64SingleTypebigint)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigint0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_int64bigint0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(Int64bigint0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int64bigint0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(Int64bigint0MI),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(1),
                (NpgsqlTypes.NpgsqlDbType)(1)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigint0MI>(2);
                for (int i = 8; i < 14; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IInt64SingleTypebigint)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IInt64SingleTypebigint)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigint0MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(0)]
        public  void ImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<Int64bigint0MI>(2);
                for (int i = 12; i < 18; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IInt64SingleTypebigint)this).ImportModelInner(connection, importCollection);
                var models = ((IInt64SingleTypebigint)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigint0MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int64bigint0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
int64bigint0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(Int64bigint0M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(1),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(1)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint))]
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
FROM public.binary_int64bigint0m m
LEFT JOIN public.binary_int64bigint0mi mi ON mi.id = m.int64bigint0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(Int64bigint0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<Int64bigint0M>(15);

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
                ((IInt64SingleTypebigint)this).ImportModel(connection, importCollection);
                var models = ((IInt64SingleTypebigint)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                Int64bigint0M.AssertModel(models[0],_testData[0], false);
                Int64bigint0M.AssertModel(models[1],_testData[1], false);
                Int64bigint0M.AssertModel(models[2],_testData[2], false);
                Int64bigint0M.AssertModel(models[3],_testData[3], false);
                Int64bigint0M.AssertModel(models[4],_testData[4], false);
                Int64bigint0M.AssertModel(models[5],_testData[5], false);
                Int64bigint0M.AssertModel(models[6],_testData[6], false);
                Int64bigint0M.AssertModel(models[7],_testData[7], false);
                Int64bigint0M.AssertModel(models[8],_testData[8], false);
                Int64bigint0M.AssertModel(models[9],_testData[9], false);
                Int64bigint0M.AssertModel(models[10],_testData[10], false);
                Int64bigint0M.AssertModel(models[11],_testData[11], false);
                Int64bigint0M.AssertModel(models[12],_testData[12], false);
                Int64bigint0M.AssertModel(models[13],_testData[13], false);
                Int64bigint0M.AssertModel(models[14],_testData[14], false);
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
                await ((IInt64SingleTypebigint)this).ImportModelAsync(connection, importCollection);
                models = await ((IInt64SingleTypebigint)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                Int64bigint0M.AssertModel(models[0],_testData[0], false);
                Int64bigint0M.AssertModel(models[1],_testData[1], false);
                Int64bigint0M.AssertModel(models[2],_testData[2], false);
                Int64bigint0M.AssertModel(models[3],_testData[3], false);
                Int64bigint0M.AssertModel(models[4],_testData[4], false);
                Int64bigint0M.AssertModel(models[5],_testData[5], false);
                Int64bigint0M.AssertModel(models[6],_testData[6], false);
                Int64bigint0M.AssertModel(models[7],_testData[7], false);
                Int64bigint0M.AssertModel(models[8],_testData[8], false);
                Int64bigint0M.AssertModel(models[9],_testData[9], false);
                Int64bigint0M.AssertModel(models[10],_testData[10], false);
                Int64bigint0M.AssertModel(models[11],_testData[11], false);
                Int64bigint0M.AssertModel(models[12],_testData[12], false);
                Int64bigint0M.AssertModel(models[13],_testData[13], false);
                Int64bigint0M.AssertModel(models[14],_testData[14], false);
                Int64bigint0M.AssertModel(models[15],_testData[15], false);
                Int64bigint0M.AssertModel(models[16],_testData[16], false);
                Int64bigint0M.AssertModel(models[17],_testData[17], false);
                Int64bigint0M.AssertModel(models[18],_testData[18], false);
                Int64bigint0M.AssertModel(models[19],_testData[19], false);
                Int64bigint0M.AssertModel(models[20],_testData[20], false);
                Int64bigint0M.AssertModel(models[21],_testData[21], false);
                Int64bigint0M.AssertModel(models[22],_testData[22], false);
                Int64bigint0M.AssertModel(models[23],_testData[23], false);
                Int64bigint0M.AssertModel(models[24],_testData[24], false);
                Int64bigint0M.AssertModel(models[25],_testData[25], false);
                Int64bigint0M.AssertModel(models[26],_testData[26], false);
                Int64bigint0M.AssertModel(models[27],_testData[27], false);
                Int64bigint0M.AssertModel(models[28],_testData[28], false);
                Int64bigint0M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int64bigint0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    int64bigint0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(Int64bigint0M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(1),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(1)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IInt64SingleTypebigint)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Int64bigint0M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IInt64SingleTypebigint)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Int64bigint0M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int64bigint0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(Int64bigint0MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(1),
                (NpgsqlTypes.NpgsqlDbType)(1)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IInt64SingleTypebigint)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigint0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IInt64SingleTypebigint)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigint0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

