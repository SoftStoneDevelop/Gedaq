

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

        private readonly Int64bigintE0M[] _testData = new Int64bigintE0M[]
        {
            new Int64bigintE0M
{
    Id = 4,
    Value = 4933596622656682382L,
    ModelInner = null,
    NullableValue = 4911028507241803263L,
},
            new Int64bigintE0M
{
    Id = 10,
    Value = 4813327208736373252L,
    ModelInner = new Int64bigintE0MI
{
    Id = 2,
    Value = 506329569205901931L,
    NullableValue = 4122758695914387464L,
},
    NullableValue = 1912411823155190128L,
},
            new Int64bigintE0M
{
    Id = 12,
    Value = 1737487294272085637L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 18,
    Value = 7083346615299695367L,
    ModelInner = new Int64bigintE0MI
{
    Id = 8,
    Value = 7630433456297196957L,
    NullableValue = 1134771083904969099L,
},
    NullableValue = 5900868356166113703L,
},
            new Int64bigintE0M
{
    Id = 20,
    Value = 7206367247674660933L,
    ModelInner = null,
    NullableValue = 5195081262390099812L,
},
            new Int64bigintE0M
{
    Id = 21,
    Value = 8476540902105274734L,
    ModelInner = new Int64bigintE0MI
{
    Id = 13,
    Value = 8063502764034315596L,
    NullableValue = null,
},
    NullableValue = 6258465222123175835L,
},
            new Int64bigintE0M
{
    Id = 30,
    Value = 986938147097281394L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 31,
    Value = 4549134988976443731L,
    ModelInner = new Int64bigintE0MI
{
    Id = 20,
    Value = 2613157699981700800L,
    NullableValue = 6148015129450876108L,
},
    NullableValue = 1649285097797272827L,
},
            new Int64bigintE0M
{
    Id = 32,
    Value = 7917748063732538400L,
    ModelInner = null,
    NullableValue = 7395119039400024361L,
},
            new Int64bigintE0M
{
    Id = 35,
    Value = 5018566695486493891L,
    ModelInner = new Int64bigintE0MI
{
    Id = 26,
    Value = 7673289421717070592L,
    NullableValue = null,
},
    NullableValue = 593836135702075797L,
},
            new Int64bigintE0M
{
    Id = 43,
    Value = 8530068297181240459L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 49,
    Value = 2951447050053363676L,
    ModelInner = new Int64bigintE0MI
{
    Id = 28,
    Value = 5861445517497648245L,
    NullableValue = 8112228227698371454L,
},
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 57,
    Value = 2552001097497746233L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 58,
    Value = 9144481475083777181L,
    ModelInner = new Int64bigintE0MI
{
    Id = 31,
    Value = 2355795421494698400L,
    NullableValue = null,
},
    NullableValue = 881607019408505477L,
},
            new Int64bigintE0M
{
    Id = 61,
    Value = 2362205882415777461L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 68,
    Value = 5786648553967745115L,
    ModelInner = new Int64bigintE0MI
{
    Id = 38,
    Value = 4628831464939434613L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 73,
    Value = 6086613596421669193L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 76,
    Value = 5111162194215126653L,
    ModelInner = new Int64bigintE0MI
{
    Id = 44,
    Value = 5540325015965056601L,
    NullableValue = 2491166209936121444L,
},
    NullableValue = 6066575168310678090L,
},
            new Int64bigintE0M
{
    Id = 83,
    Value = 1109757874684991516L,
    ModelInner = null,
    NullableValue = 4742011096612834229L,
},
            new Int64bigintE0M
{
    Id = 88,
    Value = 8695127631809600834L,
    ModelInner = new Int64bigintE0MI
{
    Id = 47,
    Value = 8371529655410228008L,
    NullableValue = 6864366873750363279L,
},
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 95,
    Value = 973406988489345501L,
    ModelInner = null,
    NullableValue = 8349251636740995943L,
},
            new Int64bigintE0M
{
    Id = 99,
    Value = 7294327036402654639L,
    ModelInner = new Int64bigintE0MI
{
    Id = 56,
    Value = 3230809757050222397L,
    NullableValue = 296662331195066999L,
},
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 106,
    Value = 3378672446288055871L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 110,
    Value = 4545076382754071924L,
    ModelInner = new Int64bigintE0MI
{
    Id = 62,
    Value = 4352114607063110557L,
    NullableValue = null,
},
    NullableValue = 5991157460675483738L,
},
            new Int64bigintE0M
{
    Id = 118,
    Value = 3596710191565440784L,
    ModelInner = null,
    NullableValue = 3378084041254613382L,
},
            new Int64bigintE0M
{
    Id = 123,
    Value = 6233210481297614486L,
    ModelInner = new Int64bigintE0MI
{
    Id = 69,
    Value = 419459235580127058L,
    NullableValue = 483921679299795385L,
},
    NullableValue = 3014990807518897300L,
},
            new Int64bigintE0M
{
    Id = 125,
    Value = 5675593150067921499L,
    ModelInner = null,
    NullableValue = 4807543984957355746L,
},
            new Int64bigintE0M
{
    Id = 130,
    Value = 7690960467628390248L,
    ModelInner = new Int64bigintE0MI
{
    Id = 70,
    Value = 275969259820366959L,
    NullableValue = 6575581530964200640L,
},
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 136,
    Value = 1106731485706638813L,
    ModelInner = null,
    NullableValue = 7973564393722798475L,
},
            new Int64bigintE0M
{
    Id = 140,
    Value = 1664728664419103108L,
    ModelInner = new Int64bigintE0MI
{
    Id = 73,
    Value = 7998657443214779703L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 142,
    Value = 1455085934196456714L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 149,
    Value = 8933957611288357051L,
    ModelInner = new Int64bigintE0MI
{
    Id = 81,
    Value = 9016523819152269734L,
    NullableValue = null,
},
    NullableValue = 727436375004891789L,
},
            new Int64bigintE0M
{
    Id = 150,
    Value = 2298667278162754645L,
    ModelInner = null,
    NullableValue = 1797138079970302908L,
},
            new Int64bigintE0M
{
    Id = 156,
    Value = 6639569916009108765L,
    ModelInner = new Int64bigintE0MI
{
    Id = 90,
    Value = 7949682886046236602L,
    NullableValue = null,
},
    NullableValue = 7496642566015300767L,
},
            new Int64bigintE0M
{
    Id = 157,
    Value = 2628142620243143543L,
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64biginte0mi(
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
INSERT INTO public.int64biginte0mi(
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
            queryMapTypes: [typeof(Int64bigintE0MI)],
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
INSERT INTO public.int64biginte0mi(
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

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertInnerModelAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertInnerModelAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64biginte0m(
	id,
    value,
    nullablevalue,
    int64biginte0mi_id
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
                methodParametrName: "int64biginte0mi_id", 
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
INSERT INTO public.int64biginte0m(
	id,
    value,
    nullablevalue,
    int64biginte0mi_id
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
    int64biginte0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(Int64bigintE0M)],
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(5195081262390099812L));
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(6258465222123175835L));
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
                Assert.That(nullable, Is.EqualTo(1649285097797272827L));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64biginte0m(
	id,
    value,
    nullablevalue,
    int64biginte0mi_id
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
    int64biginte0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(Int64bigintE0M)],
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
                methodParametrName: "int64biginte0mi_id", 
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(7395119039400024361L));
                nullable =  ((IInt64SingleTypebigint)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(593836135702075797L));
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
                Assert.That(nullable, Is.Null);
                nullable = await ((IInt64SingleTypebigint)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Int64bigintE0M> models = null;

                models =  ((IInt64SingleTypebigint)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintE0M.AssertModel(models[0],_testData[12], true);
                models =  ((IInt64SingleTypebigint)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintE0M.AssertModel(models[0],_testData[13], true);
                models =  ((IInt64SingleTypebigint)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintE0M.AssertModel(models[0],_testData[14], true);
                models =  ((IInt64SingleTypebigint)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintE0M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Int64bigintE0M> models = null;

                models = await ((IInt64SingleTypebigint)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintE0M.AssertModel(models[0],_testData[16], true);
                models = await ((IInt64SingleTypebigint)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintE0M.AssertModel(models[0],_testData[17], true);
                models = await ((IInt64SingleTypebigint)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintE0M.AssertModel(models[0],_testData[18], true);
                models = await ((IInt64SingleTypebigint)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintE0M.AssertModel(models[0],_testData[19], true);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.int64biginte0m(
	id,
    value,
    nullablevalue,
    int64biginte0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @int64biginte0mi_id
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
                parametrName: "int64biginte0mi_id", 
                methodParametrName: "int64biginte0mi_id", 
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

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintE0M), typeof(FlatInt64bigintE0M)],
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
FROM public.int64biginte0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatInt64bigintE0M>();
                var models2 = new List<FlatInt64bigintE0M>();
                await ((IInt64SingleTypebigint)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintE0M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int64biginte0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatInt64bigintE0M>();
                var models2 = new List<FlatInt64bigintE0M>();
                ((IInt64SingleTypebigint)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintE0M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintE0M)],
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
FROM public.int64biginte0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IInt64SingleTypebigint)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64biginte0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IInt64SingleTypebigint)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64biginte0m m
LEFT JOIN public.int64biginte0mi mi ON mi.id = m.int64biginte0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Int64bigintE0M)],
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintE0M.AssertModel(models[i],_testData[i], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintE0M), typeof(FlatInt64bigintE0M)],
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
FROM public.int64biginte0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigintE0M>();
                var models2 = new List<FlatInt64bigintE0M>();
                await ((IInt64SingleTypebigint)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintE0M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int64biginte0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigintE0M>();
                var models2 = new List<FlatInt64bigintE0M>();
                ((IInt64SingleTypebigint)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintE0M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintE0M)],
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
FROM public.int64biginte0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IInt64SingleTypebigint)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64biginte0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IInt64SingleTypebigint)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64biginte0m m
LEFT JOIN public.int64biginte0mi mi ON mi.id = m.int64biginte0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Int64bigintE0M)],
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintE0M.AssertModel(models[i],_testData[i], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintE0M), typeof(FlatInt64bigintE0M)],
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
FROM public.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt64bigintE0M>();
                var models2 = new List<FlatInt64bigintE0M>();
                await((IInt64SingleTypebigint)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintE0M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 149;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 21;
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
FROM public.int64biginte0m m
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
FROM public.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintE0M>();
                var firstItems2 = new List<FlatInt64bigintE0M>();
                var secondItems1 = new List<FlatInt64bigintE0M>();
                var secondItems2 = new List<FlatInt64bigintE0M>();
                await ((IInt64SingleTypebigint)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatInt64bigintE0M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatInt64bigintE0M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[28],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 88;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 140;
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
FROM public.int64biginte0m m
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
FROM public.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintE0M>();
                var firstItems2 = new List<FlatInt64bigintE0M>();
                var secondItems1 = new List<FlatInt64bigintE0M>();
                await ((IInt64SingleTypebigint)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatInt64bigintE0M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                        FlatInt64bigintE0M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[4],_testData[34], false);
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
FROM public.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt64bigintE0M>();
                var models2 = new List<FlatInt64bigintE0M>();
                ((IInt64SingleTypebigint)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintE0M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 76;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 49;
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
FROM public.int64biginte0m m
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
FROM public.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintE0M>();
                var firstItems2 = new List<FlatInt64bigintE0M>();
                var secondItems1 = new List<FlatInt64bigintE0M>();
                var secondItems2 = new List<FlatInt64bigintE0M>();
                 ((IInt64SingleTypebigint)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatInt64bigintE0M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatInt64bigintE0M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[22],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 123;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 31;
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
FROM public.int64biginte0m m
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
FROM public.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintE0M>();
                var firstItems2 = new List<FlatInt64bigintE0M>();
                var secondItems1 = new List<FlatInt64bigintE0M>();
                 ((IInt64SingleTypebigint)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatInt64bigintE0M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                        FlatInt64bigintE0M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[26],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintE0M)],
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
FROM public.int64biginte0m m
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 10;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 57;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int64biginte0m m
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
FROM public.int64biginte0m m
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
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatInt64bigintE0M.AssertModel(models[0],_testData[2], false);
                        FlatInt64bigintE0M.AssertModel(models[1],_testData[3], false);
                        FlatInt64bigintE0M.AssertModel(models[2],_testData[4], false);
                        FlatInt64bigintE0M.AssertModel(models[3],_testData[5], false);
                        FlatInt64bigintE0M.AssertModel(models[4],_testData[6], false);
                        FlatInt64bigintE0M.AssertModel(models[5],_testData[7], false);
                        FlatInt64bigintE0M.AssertModel(models[6],_testData[8], false);
                        FlatInt64bigintE0M.AssertModel(models[7],_testData[9], false);
                        FlatInt64bigintE0M.AssertModel(models[8],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(models[9],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(models[10],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(models[11],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(models[12],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(models[13],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(models[14],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(models[15],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(models[16],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(models[17],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(models[18],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(models[19],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(models[20],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(models[21],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(models[22],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(models[23],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(models[24],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(models[25],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(models[26],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(models[27],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(models[28],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(models[29],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(models[30],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(models[31],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatInt64bigintE0M.AssertModel(models[0],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(models[1],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(models[2],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(models[3],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(models[4],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(models[5],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(models[6],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(models[7],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(models[8],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(models[9],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(models[10],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(models[11],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(models[12],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(models[13],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(models[14],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(models[15],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(models[16],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(models[17],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(models[18],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(models[19],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(models[20],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(models[21],_testData[34], false);
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
                parametr1.Value = 61;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 125;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int64biginte0m m
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
FROM public.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintE0M>();
                var secondItems1 = new List<FlatInt64bigintE0M>();
                var secondItems2 = new List<FlatInt64bigintE0M>();
                await ((IInt64SingleTypebigint)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                        FlatInt64bigintE0M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatInt64bigintE0M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[7],_testData[34], false);
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
FROM public.int64biginte0m m
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 10;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 73;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int64biginte0m m
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
FROM public.int64biginte0m m
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
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatInt64bigintE0M.AssertModel(models[0],_testData[2], false);
                        FlatInt64bigintE0M.AssertModel(models[1],_testData[3], false);
                        FlatInt64bigintE0M.AssertModel(models[2],_testData[4], false);
                        FlatInt64bigintE0M.AssertModel(models[3],_testData[5], false);
                        FlatInt64bigintE0M.AssertModel(models[4],_testData[6], false);
                        FlatInt64bigintE0M.AssertModel(models[5],_testData[7], false);
                        FlatInt64bigintE0M.AssertModel(models[6],_testData[8], false);
                        FlatInt64bigintE0M.AssertModel(models[7],_testData[9], false);
                        FlatInt64bigintE0M.AssertModel(models[8],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(models[9],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(models[10],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(models[11],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(models[12],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(models[13],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(models[14],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(models[15],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(models[16],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(models[17],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(models[18],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(models[19],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(models[20],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(models[21],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(models[22],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(models[23],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(models[24],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(models[25],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(models[26],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(models[27],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(models[28],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(models[29],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(models[30],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(models[31],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatInt64bigintE0M.AssertModel(models[0],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(models[1],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(models[2],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(models[3],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(models[4],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(models[5],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(models[6],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(models[7],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(models[8],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(models[9],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(models[10],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(models[11],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(models[12],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(models[13],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(models[14],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(models[15],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(models[16],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(models[17],_testData[34], false);
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
                parametr1.Value = 150;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 88;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int64biginte0m m
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
FROM public.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintE0M>();
                var secondItems1 = new List<FlatInt64bigintE0M>();
                var secondItems2 = new List<FlatInt64bigintE0M>();
                 ((IInt64SingleTypebigint)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatInt64bigintE0M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatInt64bigintE0M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[14],_testData[34], false);
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
FROM public.int64biginte0m m
LEFT JOIN public.int64biginte0mi mi ON mi.id = m.int64biginte0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Int64bigintE0M)],
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 49;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 142;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64SingleTypebigint)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        Int64bigintE0M.AssertModel(models[0],_testData[12], false);
                        Int64bigintE0M.AssertModel(models[1],_testData[13], false);
                        Int64bigintE0M.AssertModel(models[2],_testData[14], false);
                        Int64bigintE0M.AssertModel(models[3],_testData[15], false);
                        Int64bigintE0M.AssertModel(models[4],_testData[16], false);
                        Int64bigintE0M.AssertModel(models[5],_testData[17], false);
                        Int64bigintE0M.AssertModel(models[6],_testData[18], false);
                        Int64bigintE0M.AssertModel(models[7],_testData[19], false);
                        Int64bigintE0M.AssertModel(models[8],_testData[20], false);
                        Int64bigintE0M.AssertModel(models[9],_testData[21], false);
                        Int64bigintE0M.AssertModel(models[10],_testData[22], false);
                        Int64bigintE0M.AssertModel(models[11],_testData[23], false);
                        Int64bigintE0M.AssertModel(models[12],_testData[24], false);
                        Int64bigintE0M.AssertModel(models[13],_testData[25], false);
                        Int64bigintE0M.AssertModel(models[14],_testData[26], false);
                        Int64bigintE0M.AssertModel(models[15],_testData[27], false);
                        Int64bigintE0M.AssertModel(models[16],_testData[28], false);
                        Int64bigintE0M.AssertModel(models[17],_testData[29], false);
                        Int64bigintE0M.AssertModel(models[18],_testData[30], false);
                        Int64bigintE0M.AssertModel(models[19],_testData[31], false);
                        Int64bigintE0M.AssertModel(models[20],_testData[32], false);
                        Int64bigintE0M.AssertModel(models[21],_testData[33], false);
                        Int64bigintE0M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        Int64bigintE0M.AssertModel(models[0],_testData[31], false);
                        Int64bigintE0M.AssertModel(models[1],_testData[32], false);
                        Int64bigintE0M.AssertModel(models[2],_testData[33], false);
                        Int64bigintE0M.AssertModel(models[3],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 4;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 125;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64SingleTypebigint)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        Int64bigintE0M.AssertModel(models[0],_testData[1], false);
                        Int64bigintE0M.AssertModel(models[1],_testData[2], false);
                        Int64bigintE0M.AssertModel(models[2],_testData[3], false);
                        Int64bigintE0M.AssertModel(models[3],_testData[4], false);
                        Int64bigintE0M.AssertModel(models[4],_testData[5], false);
                        Int64bigintE0M.AssertModel(models[5],_testData[6], false);
                        Int64bigintE0M.AssertModel(models[6],_testData[7], false);
                        Int64bigintE0M.AssertModel(models[7],_testData[8], false);
                        Int64bigintE0M.AssertModel(models[8],_testData[9], false);
                        Int64bigintE0M.AssertModel(models[9],_testData[10], false);
                        Int64bigintE0M.AssertModel(models[10],_testData[11], false);
                        Int64bigintE0M.AssertModel(models[11],_testData[12], false);
                        Int64bigintE0M.AssertModel(models[12],_testData[13], false);
                        Int64bigintE0M.AssertModel(models[13],_testData[14], false);
                        Int64bigintE0M.AssertModel(models[14],_testData[15], false);
                        Int64bigintE0M.AssertModel(models[15],_testData[16], false);
                        Int64bigintE0M.AssertModel(models[16],_testData[17], false);
                        Int64bigintE0M.AssertModel(models[17],_testData[18], false);
                        Int64bigintE0M.AssertModel(models[18],_testData[19], false);
                        Int64bigintE0M.AssertModel(models[19],_testData[20], false);
                        Int64bigintE0M.AssertModel(models[20],_testData[21], false);
                        Int64bigintE0M.AssertModel(models[21],_testData[22], false);
                        Int64bigintE0M.AssertModel(models[22],_testData[23], false);
                        Int64bigintE0M.AssertModel(models[23],_testData[24], false);
                        Int64bigintE0M.AssertModel(models[24],_testData[25], false);
                        Int64bigintE0M.AssertModel(models[25],_testData[26], false);
                        Int64bigintE0M.AssertModel(models[26],_testData[27], false);
                        Int64bigintE0M.AssertModel(models[27],_testData[28], false);
                        Int64bigintE0M.AssertModel(models[28],_testData[29], false);
                        Int64bigintE0M.AssertModel(models[29],_testData[30], false);
                        Int64bigintE0M.AssertModel(models[30],_testData[31], false);
                        Int64bigintE0M.AssertModel(models[31],_testData[32], false);
                        Int64bigintE0M.AssertModel(models[32],_testData[33], false);
                        Int64bigintE0M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        Int64bigintE0M.AssertModel(models[0],_testData[27], false);
                        Int64bigintE0M.AssertModel(models[1],_testData[28], false);
                        Int64bigintE0M.AssertModel(models[2],_testData[29], false);
                        Int64bigintE0M.AssertModel(models[3],_testData[30], false);
                        Int64bigintE0M.AssertModel(models[4],_testData[31], false);
                        Int64bigintE0M.AssertModel(models[5],_testData[32], false);
                        Int64bigintE0M.AssertModel(models[6],_testData[33], false);
                        Int64bigintE0M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintE0M), typeof(FlatInt64bigintE0M)],
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
FROM public.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigintE0M>();
                var models2 = new List<FlatInt64bigintE0M>();
                await((IInt64SingleTypebigint)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintE0M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int64biginte0m m
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
FROM public.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintE0M>();
                var firstItems2 = new List<FlatInt64bigintE0M>();
                var secondItems1 = new List<FlatInt64bigintE0M>();
                var secondItems2 = new List<FlatInt64bigintE0M>();
                await ((IInt64SingleTypebigint)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 88, query1, 99, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatInt64bigintE0M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatInt64bigintE0M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[12],_testData[34], false);
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
FROM public.int64biginte0m m
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
FROM public.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintE0M>();
                var firstItems2 = new List<FlatInt64bigintE0M>();
                var secondItems1 = new List<FlatInt64bigintE0M>();
                await ((IInt64SingleTypebigint)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 49, query1, 68, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatInt64bigintE0M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatInt64bigintE0M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[18],_testData[34], false);
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
FROM public.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigintE0M>();
                var models2 = new List<FlatInt64bigintE0M>();
                ((IInt64SingleTypebigint)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintE0M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int64biginte0m m
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
FROM public.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintE0M>();
                var firstItems2 = new List<FlatInt64bigintE0M>();
                var secondItems1 = new List<FlatInt64bigintE0M>();
                var secondItems2 = new List<FlatInt64bigintE0M>();
                 ((IInt64SingleTypebigint)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 140, query1, 123, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatInt64bigintE0M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatInt64bigintE0M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[8],_testData[34], false);
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
FROM public.int64biginte0m m
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
FROM public.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintE0M>();
                var firstItems2 = new List<FlatInt64bigintE0M>();
                var secondItems1 = new List<FlatInt64bigintE0M>();
                 ((IInt64SingleTypebigint)this).DbConnectionMMDynQuerySelectModelBatch(connection, 95, query1, 49, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatInt64bigintE0M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatInt64bigintE0M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[22],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintE0M)],
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
FROM public.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IInt64SingleTypebigint)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64biginte0m m
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
FROM public.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64SingleTypebigint)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 142, query1, 73, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatInt64bigintE0M.AssertModel(models[0],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(models[1],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(models[2],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatInt64bigintE0M.AssertModel(models[0],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(models[1],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(models[2],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(models[3],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(models[4],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(models[5],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(models[6],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(models[7],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(models[8],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(models[9],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(models[10],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(models[11],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(models[12],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(models[13],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(models[14],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(models[15],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(models[16],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(models[17],_testData[34], false);
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
FROM public.int64biginte0m m
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
FROM public.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintE0M>();
                var secondItems1 = new List<FlatInt64bigintE0M>();
                var secondItems2 = new List<FlatInt64bigintE0M>();
                await ((IInt64SingleTypebigint)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 130, query1, 32, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatInt64bigintE0M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatInt64bigintE0M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[25],_testData[34], false);
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
FROM public.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IInt64SingleTypebigint)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64biginte0m m
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
FROM public.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64SingleTypebigint)this).DbConnectionSTDynQuerySelectModelBatch(connection, 142, query1, 10, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatInt64bigintE0M.AssertModel(models[0],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(models[1],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(models[2],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatInt64bigintE0M.AssertModel(models[0],_testData[2], false);
                        FlatInt64bigintE0M.AssertModel(models[1],_testData[3], false);
                        FlatInt64bigintE0M.AssertModel(models[2],_testData[4], false);
                        FlatInt64bigintE0M.AssertModel(models[3],_testData[5], false);
                        FlatInt64bigintE0M.AssertModel(models[4],_testData[6], false);
                        FlatInt64bigintE0M.AssertModel(models[5],_testData[7], false);
                        FlatInt64bigintE0M.AssertModel(models[6],_testData[8], false);
                        FlatInt64bigintE0M.AssertModel(models[7],_testData[9], false);
                        FlatInt64bigintE0M.AssertModel(models[8],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(models[9],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(models[10],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(models[11],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(models[12],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(models[13],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(models[14],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(models[15],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(models[16],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(models[17],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(models[18],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(models[19],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(models[20],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(models[21],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(models[22],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(models[23],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(models[24],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(models[25],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(models[26],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(models[27],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(models[28],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(models[29],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(models[30],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(models[31],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(models[32],_testData[34], false);
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
FROM public.int64biginte0m m
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
FROM public.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintE0M>();
                var secondItems1 = new List<FlatInt64bigintE0M>();
                var secondItems2 = new List<FlatInt64bigintE0M>();
                 ((IInt64SingleTypebigint)this).DbConnectionDynQuerySelectModelBatch(connection, 99, query1, 18, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatInt64bigintE0M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatInt64bigintE0M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[30],_testData[34], false);
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
FROM public.int64biginte0m m
LEFT JOIN public.int64biginte0mi mi ON mi.id = m.int64biginte0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Int64bigintE0M)],
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IInt64SingleTypebigint)this).DbConnectionSTSelectModelBatchAsync(connection, 142, 73))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        Int64bigintE0M.AssertModel(models[0],_testData[31], false);
                        Int64bigintE0M.AssertModel(models[1],_testData[32], false);
                        Int64bigintE0M.AssertModel(models[2],_testData[33], false);
                        Int64bigintE0M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        Int64bigintE0M.AssertModel(models[0],_testData[17], false);
                        Int64bigintE0M.AssertModel(models[1],_testData[18], false);
                        Int64bigintE0M.AssertModel(models[2],_testData[19], false);
                        Int64bigintE0M.AssertModel(models[3],_testData[20], false);
                        Int64bigintE0M.AssertModel(models[4],_testData[21], false);
                        Int64bigintE0M.AssertModel(models[5],_testData[22], false);
                        Int64bigintE0M.AssertModel(models[6],_testData[23], false);
                        Int64bigintE0M.AssertModel(models[7],_testData[24], false);
                        Int64bigintE0M.AssertModel(models[8],_testData[25], false);
                        Int64bigintE0M.AssertModel(models[9],_testData[26], false);
                        Int64bigintE0M.AssertModel(models[10],_testData[27], false);
                        Int64bigintE0M.AssertModel(models[11],_testData[28], false);
                        Int64bigintE0M.AssertModel(models[12],_testData[29], false);
                        Int64bigintE0M.AssertModel(models[13],_testData[30], false);
                        Int64bigintE0M.AssertModel(models[14],_testData[31], false);
                        Int64bigintE0M.AssertModel(models[15],_testData[32], false);
                        Int64bigintE0M.AssertModel(models[16],_testData[33], false);
                        Int64bigintE0M.AssertModel(models[17],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IInt64SingleTypebigint)this).DbConnectionSTSelectModelBatch(connection, 30, 10))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        Int64bigintE0M.AssertModel(models[0],_testData[7], false);
                        Int64bigintE0M.AssertModel(models[1],_testData[8], false);
                        Int64bigintE0M.AssertModel(models[2],_testData[9], false);
                        Int64bigintE0M.AssertModel(models[3],_testData[10], false);
                        Int64bigintE0M.AssertModel(models[4],_testData[11], false);
                        Int64bigintE0M.AssertModel(models[5],_testData[12], false);
                        Int64bigintE0M.AssertModel(models[6],_testData[13], false);
                        Int64bigintE0M.AssertModel(models[7],_testData[14], false);
                        Int64bigintE0M.AssertModel(models[8],_testData[15], false);
                        Int64bigintE0M.AssertModel(models[9],_testData[16], false);
                        Int64bigintE0M.AssertModel(models[10],_testData[17], false);
                        Int64bigintE0M.AssertModel(models[11],_testData[18], false);
                        Int64bigintE0M.AssertModel(models[12],_testData[19], false);
                        Int64bigintE0M.AssertModel(models[13],_testData[20], false);
                        Int64bigintE0M.AssertModel(models[14],_testData[21], false);
                        Int64bigintE0M.AssertModel(models[15],_testData[22], false);
                        Int64bigintE0M.AssertModel(models[16],_testData[23], false);
                        Int64bigintE0M.AssertModel(models[17],_testData[24], false);
                        Int64bigintE0M.AssertModel(models[18],_testData[25], false);
                        Int64bigintE0M.AssertModel(models[19],_testData[26], false);
                        Int64bigintE0M.AssertModel(models[20],_testData[27], false);
                        Int64bigintE0M.AssertModel(models[21],_testData[28], false);
                        Int64bigintE0M.AssertModel(models[22],_testData[29], false);
                        Int64bigintE0M.AssertModel(models[23],_testData[30], false);
                        Int64bigintE0M.AssertModel(models[24],_testData[31], false);
                        Int64bigintE0M.AssertModel(models[25],_testData[32], false);
                        Int64bigintE0M.AssertModel(models[26],_testData[33], false);
                        Int64bigintE0M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        Int64bigintE0M.AssertModel(models[0],_testData[2], false);
                        Int64bigintE0M.AssertModel(models[1],_testData[3], false);
                        Int64bigintE0M.AssertModel(models[2],_testData[4], false);
                        Int64bigintE0M.AssertModel(models[3],_testData[5], false);
                        Int64bigintE0M.AssertModel(models[4],_testData[6], false);
                        Int64bigintE0M.AssertModel(models[5],_testData[7], false);
                        Int64bigintE0M.AssertModel(models[6],_testData[8], false);
                        Int64bigintE0M.AssertModel(models[7],_testData[9], false);
                        Int64bigintE0M.AssertModel(models[8],_testData[10], false);
                        Int64bigintE0M.AssertModel(models[9],_testData[11], false);
                        Int64bigintE0M.AssertModel(models[10],_testData[12], false);
                        Int64bigintE0M.AssertModel(models[11],_testData[13], false);
                        Int64bigintE0M.AssertModel(models[12],_testData[14], false);
                        Int64bigintE0M.AssertModel(models[13],_testData[15], false);
                        Int64bigintE0M.AssertModel(models[14],_testData[16], false);
                        Int64bigintE0M.AssertModel(models[15],_testData[17], false);
                        Int64bigintE0M.AssertModel(models[16],_testData[18], false);
                        Int64bigintE0M.AssertModel(models[17],_testData[19], false);
                        Int64bigintE0M.AssertModel(models[18],_testData[20], false);
                        Int64bigintE0M.AssertModel(models[19],_testData[21], false);
                        Int64bigintE0M.AssertModel(models[20],_testData[22], false);
                        Int64bigintE0M.AssertModel(models[21],_testData[23], false);
                        Int64bigintE0M.AssertModel(models[22],_testData[24], false);
                        Int64bigintE0M.AssertModel(models[23],_testData[25], false);
                        Int64bigintE0M.AssertModel(models[24],_testData[26], false);
                        Int64bigintE0M.AssertModel(models[25],_testData[27], false);
                        Int64bigintE0M.AssertModel(models[26],_testData[28], false);
                        Int64bigintE0M.AssertModel(models[27],_testData[29], false);
                        Int64bigintE0M.AssertModel(models[28],_testData[30], false);
                        Int64bigintE0M.AssertModel(models[29],_testData[31], false);
                        Int64bigintE0M.AssertModel(models[30],_testData[32], false);
                        Int64bigintE0M.AssertModel(models[31],_testData[33], false);
                        Int64bigintE0M.AssertModel(models[32],_testData[34], false);
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
                ((IInt64SingleTypebigint)this).SetDbConnectionSelectModelParametrs(cmd, 150);
                var models = await ((IInt64SingleTypebigint)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(2));

                Int64bigintE0M.AssertModel(models[0],_testData[33], false);
                Int64bigintE0M.AssertModel(models[1],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt64SingleTypebigint)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt64SingleTypebigint)this).SetDbConnectionSelectModelParametrs(cmd, 12);
                var models =  ((IInt64SingleTypebigint)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(32));

                Int64bigintE0M.AssertModel(models[0],_testData[3], false);
                Int64bigintE0M.AssertModel(models[1],_testData[4], false);
                Int64bigintE0M.AssertModel(models[2],_testData[5], false);
                Int64bigintE0M.AssertModel(models[3],_testData[6], false);
                Int64bigintE0M.AssertModel(models[4],_testData[7], false);
                Int64bigintE0M.AssertModel(models[5],_testData[8], false);
                Int64bigintE0M.AssertModel(models[6],_testData[9], false);
                Int64bigintE0M.AssertModel(models[7],_testData[10], false);
                Int64bigintE0M.AssertModel(models[8],_testData[11], false);
                Int64bigintE0M.AssertModel(models[9],_testData[12], false);
                Int64bigintE0M.AssertModel(models[10],_testData[13], false);
                Int64bigintE0M.AssertModel(models[11],_testData[14], false);
                Int64bigintE0M.AssertModel(models[12],_testData[15], false);
                Int64bigintE0M.AssertModel(models[13],_testData[16], false);
                Int64bigintE0M.AssertModel(models[14],_testData[17], false);
                Int64bigintE0M.AssertModel(models[15],_testData[18], false);
                Int64bigintE0M.AssertModel(models[16],_testData[19], false);
                Int64bigintE0M.AssertModel(models[17],_testData[20], false);
                Int64bigintE0M.AssertModel(models[18],_testData[21], false);
                Int64bigintE0M.AssertModel(models[19],_testData[22], false);
                Int64bigintE0M.AssertModel(models[20],_testData[23], false);
                Int64bigintE0M.AssertModel(models[21],_testData[24], false);
                Int64bigintE0M.AssertModel(models[22],_testData[25], false);
                Int64bigintE0M.AssertModel(models[23],_testData[26], false);
                Int64bigintE0M.AssertModel(models[24],_testData[27], false);
                Int64bigintE0M.AssertModel(models[25],_testData[28], false);
                Int64bigintE0M.AssertModel(models[26],_testData[29], false);
                Int64bigintE0M.AssertModel(models[27],_testData[30], false);
                Int64bigintE0M.AssertModel(models[28],_testData[31], false);
                Int64bigintE0M.AssertModel(models[29],_testData[32], false);
                Int64bigintE0M.AssertModel(models[30],_testData[33], false);
                Int64bigintE0M.AssertModel(models[31],_testData[34], false);
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
FROM public.int64biginte0m m
LEFT JOIN public.int64biginte0mi mi ON mi.id = m.int64biginte0mi_id
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
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((4)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4933596622656682382L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((4911028507241803263L)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4813327208736373252L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((506329569205901931L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((4122758695914387464L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((1912411823155190128L)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1737487294272085637L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7083346615299695367L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((7630433456297196957L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((1134771083904969099L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((5900868356166113703L)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7206367247674660933L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((5195081262390099812L)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8476540902105274734L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((8063502764034315596L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((6258465222123175835L)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((986938147097281394L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4549134988976443731L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((2613157699981700800L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((6148015129450876108L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((1649285097797272827L)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((32)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7917748063732538400L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((7395119039400024361L)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5018566695486493891L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((7673289421717070592L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((593836135702075797L)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8530068297181240459L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((49)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2951447050053363676L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((5861445517497648245L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((8112228227698371454L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2552001097497746233L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((9144481475083777181L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((2355795421494698400L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((881607019408505477L)));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2362205882415777461L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5786648553967745115L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((38)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((4628831464939434613L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6086613596421669193L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5111162194215126653L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((5540325015965056601L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((2491166209936121444L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((6066575168310678090L)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((83)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1109757874684991516L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((4742011096612834229L)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8695127631809600834L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((8371529655410228008L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((6864366873750363279L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((973406988489345501L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((8349251636740995943L)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7294327036402654639L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((56)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((3230809757050222397L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((296662331195066999L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3378672446288055871L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4545076382754071924L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((62)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((4352114607063110557L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((5991157460675483738L)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3596710191565440784L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((3378084041254613382L)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6233210481297614486L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((419459235580127058L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((483921679299795385L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((3014990807518897300L)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5675593150067921499L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((4807543984957355746L)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7690960467628390248L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((70)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((275969259820366959L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((6575581530964200640L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1106731485706638813L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((7973564393722798475L)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1664728664419103108L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((73)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((7998657443214779703L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((142)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1455085934196456714L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((149)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8933957611288357051L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((81)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((9016523819152269734L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((727436375004891789L)));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2298667278162754645L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((1797138079970302908L)));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((156)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6639569916009108765L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((90)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((7949682886046236602L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((7496642566015300767L)));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((157)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2628142620243143543L)));//Value

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
                var models =  ((IInt64SingleTypebigint)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((4)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4933596622656682382L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((4911028507241803263L)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4813327208736373252L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((506329569205901931L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((4122758695914387464L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((1912411823155190128L)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1737487294272085637L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7083346615299695367L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((7630433456297196957L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((1134771083904969099L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((5900868356166113703L)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7206367247674660933L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((5195081262390099812L)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8476540902105274734L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((8063502764034315596L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((6258465222123175835L)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((986938147097281394L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4549134988976443731L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((2613157699981700800L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((6148015129450876108L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((1649285097797272827L)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((32)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7917748063732538400L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((7395119039400024361L)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5018566695486493891L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((7673289421717070592L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((593836135702075797L)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8530068297181240459L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((49)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2951447050053363676L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((5861445517497648245L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((8112228227698371454L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2552001097497746233L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((9144481475083777181L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((2355795421494698400L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((881607019408505477L)));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2362205882415777461L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5786648553967745115L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((38)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((4628831464939434613L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6086613596421669193L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5111162194215126653L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((5540325015965056601L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((2491166209936121444L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((6066575168310678090L)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((83)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1109757874684991516L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((4742011096612834229L)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8695127631809600834L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((8371529655410228008L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((6864366873750363279L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((973406988489345501L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((8349251636740995943L)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7294327036402654639L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((56)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((3230809757050222397L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((296662331195066999L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3378672446288055871L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4545076382754071924L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((62)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((4352114607063110557L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((5991157460675483738L)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3596710191565440784L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((3378084041254613382L)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6233210481297614486L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((419459235580127058L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((483921679299795385L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((3014990807518897300L)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5675593150067921499L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((4807543984957355746L)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7690960467628390248L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((70)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((275969259820366959L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((6575581530964200640L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1106731485706638813L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((7973564393722798475L)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1664728664419103108L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((73)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((7998657443214779703L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((142)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1455085934196456714L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((149)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8933957611288357051L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((81)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((9016523819152269734L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((727436375004891789L)));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2298667278162754645L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((1797138079970302908L)));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((156)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6639569916009108765L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((90)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((7949682886046236602L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((7496642566015300767L)));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((157)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2628142620243143543L)));//Value

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
FROM public.binary_int64biginte0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(Int64bigintE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(Int64bigintE0MIWA),
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
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintE0MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt64SingleTypebigint)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_int64biginte0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IInt64SingleTypebigint)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintE0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintE0MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt64SingleTypebigint)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_int64biginte0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IInt64SingleTypebigint)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintE0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_int64biginte0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(Int64bigintE0MIWA)],
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
            queryMapType: typeof(Int64bigintE0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintE0MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt64SingleTypebigint)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_int64biginte0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IInt64SingleTypebigint)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintE0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintE0MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt64SingleTypebigint)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_int64biginte0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IInt64SingleTypebigint)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintE0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_int64biginte0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(Int64bigintE0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int64biginte0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(Int64bigintE0MI),
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
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintE0MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IInt64SingleTypebigint)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IInt64SingleTypebigint)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintE0MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintE0MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IInt64SingleTypebigint)this).WAImportModelInner(connection, importCollection);
                var models = ((IInt64SingleTypebigint)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintE0MI.AssertModel(actual, expect, false);
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
FROM public.binary_int64biginte0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(Int64bigintE0MIWA)],
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
COPY public.binary_int64biginte0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(Int64bigintE0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintE0MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt64SingleTypebigint)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IInt64SingleTypebigint)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintE0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintE0MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt64SingleTypebigint)this).ImportModelInner(connection, importCollection);
                var models = ((IInt64SingleTypebigint)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintE0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int64biginte0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
int64biginte0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(Int64bigintE0M),
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
FROM public.binary_int64biginte0m m
LEFT JOIN public.binary_int64biginte0mi mi ON mi.id = m.int64biginte0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(Int64bigintE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintE0M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IInt64SingleTypebigint)this).ImportModelAsync(connection, importCollection);
                var models = await ((IInt64SingleTypebigint)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Int64bigintE0M.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintE0M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IInt64SingleTypebigint)this).ImportModel(connection, importCollection);
                var models = ((IInt64SingleTypebigint)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Int64bigintE0M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int64biginte0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    int64biginte0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(Int64bigintE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(1),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(1)
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
                var models =  ((IInt64SingleTypebigint)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Int64bigintE0M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
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
                    Int64bigintE0M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(Int64bigintE0MIWA), typeof(Int64bigintE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(1),
                (NpgsqlTypes.NpgsqlDbType)(1)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(1),
                (NpgsqlTypes.NpgsqlDbType)(1)
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
                var models1 = new List<Int64bigintE0MIWA>();
                var models2 = new List<Int64bigintE0MIWA>();
                await ((IInt64SingleTypebigint)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int64biginte0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintE0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int64bigintE0MIWA>();
                var models2 = new List<Int64bigintE0MIWA>();
                ((IInt64SingleTypebigint)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int64biginte0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(Int64bigintE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(1),
                (NpgsqlTypes.NpgsqlDbType)(1)
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
                var models = await ((IInt64SingleTypebigint)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_int64biginte0mi
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
                    Int64bigintE0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IInt64SingleTypebigint)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_int64biginte0mi
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
                    Int64bigintE0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(Int64bigintE0MIWA), typeof(Int64bigintE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint))]
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
                var models1 = new List<Int64bigintE0MIWA>();
                var models2 = new List<Int64bigintE0MIWA>();
                await ((IInt64SingleTypebigint)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int64biginte0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintE0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int64bigintE0MIWA>();
                var models2 = new List<Int64bigintE0MIWA>();
                ((IInt64SingleTypebigint)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int64biginte0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(Int64bigintE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint))]
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
                var models = await ((IInt64SingleTypebigint)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_int64biginte0mi
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
                    Int64bigintE0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IInt64SingleTypebigint)this).DynQueryExportModelInner(connection, @"
COPY public.binary_int64biginte0mi
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
                    Int64bigintE0MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_int64biginte0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(Int64bigintE0MI), typeof(Int64bigintE0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(1),
                (NpgsqlTypes.NpgsqlDbType)(1)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(1),
                (NpgsqlTypes.NpgsqlDbType)(1)
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
                var models1 = new List<Int64bigintE0MI>();
                var models2 = new List<Int64bigintE0MI>();
                await ((IInt64SingleTypebigint)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintE0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintE0MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int64bigintE0MI>();
                var models2 = new List<Int64bigintE0MI>();
                ((IInt64SingleTypebigint)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintE0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintE0MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int64biginte0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(Int64bigintE0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(1),
                (NpgsqlTypes.NpgsqlDbType)(1)
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
                var models = await ((IInt64SingleTypebigint)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigintE0MI.AssertModel(model, expectedModel, false);
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
                var models = ((IInt64SingleTypebigint)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigintE0MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_int64biginte0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(Int64bigintE0MIWA), typeof(Int64bigintE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint))]
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
                var models1 = new List<Int64bigintE0MIWA>();
                var models2 = new List<Int64bigintE0MIWA>();
                await ((IInt64SingleTypebigint)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintE0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int64bigintE0MIWA>();
                var models2 = new List<Int64bigintE0MIWA>();
                ((IInt64SingleTypebigint)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int64biginte0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(Int64bigintE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint))]
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
                var models = await ((IInt64SingleTypebigint)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigintE0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IInt64SingleTypebigint)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigintE0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

