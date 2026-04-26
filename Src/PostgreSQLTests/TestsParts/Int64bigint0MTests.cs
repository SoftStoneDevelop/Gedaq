

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
    Id = 7,
    Value = 3508054398489452615L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 13,
    Value = 919197622586262139L,
    ModelInner = new Int64bigint0MI
{
    Id = 7,
    Value = 8244848102852630590L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 18,
    Value = 7123731647334183899L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 20,
    Value = 5392512198133026064L,
    ModelInner = new Int64bigint0MI
{
    Id = 9,
    Value = 4825007257991968479L,
    NullableValue = null,
},
    NullableValue = 4169976237493395767L,
},
            new Int64bigint0M
{
    Id = 24,
    Value = 8046646120588157909L,
    ModelInner = null,
    NullableValue = 6889654932956617811L,
},
            new Int64bigint0M
{
    Id = 33,
    Value = 5067714111940478223L,
    ModelInner = new Int64bigint0MI
{
    Id = 15,
    Value = 684335498958863775L,
    NullableValue = 1705528992836069107L,
},
    NullableValue = 4567452269844096081L,
},
            new Int64bigint0M
{
    Id = 38,
    Value = 1773590971677865782L,
    ModelInner = null,
    NullableValue = 375553265277222053L,
},
            new Int64bigint0M
{
    Id = 41,
    Value = 1418976000572582465L,
    ModelInner = new Int64bigint0MI
{
    Id = 17,
    Value = 8092429303499103770L,
    NullableValue = null,
},
    NullableValue = 3743285478994601142L,
},
            new Int64bigint0M
{
    Id = 50,
    Value = 3105899272135669079L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 55,
    Value = 5095522798232129972L,
    ModelInner = new Int64bigint0MI
{
    Id = 20,
    Value = 663781773385297555L,
    NullableValue = null,
},
    NullableValue = 8489893924107488501L,
},
            new Int64bigint0M
{
    Id = 61,
    Value = 8363902941101586247L,
    ModelInner = null,
    NullableValue = 3943983061874207800L,
},
            new Int64bigint0M
{
    Id = 65,
    Value = 4436380771110504378L,
    ModelInner = new Int64bigint0MI
{
    Id = 29,
    Value = 6291922213335191059L,
    NullableValue = null,
},
    NullableValue = 6565669454259310946L,
},
            new Int64bigint0M
{
    Id = 72,
    Value = 7257467047617114635L,
    ModelInner = null,
    NullableValue = 5647894926251848508L,
},
            new Int64bigint0M
{
    Id = 77,
    Value = 92552646586655315L,
    ModelInner = new Int64bigint0MI
{
    Id = 35,
    Value = 3014309533243935309L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 84,
    Value = 1682220487171014835L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 86,
    Value = 7791986463648078751L,
    ModelInner = new Int64bigint0MI
{
    Id = 43,
    Value = 2840655313287382179L,
    NullableValue = null,
},
    NullableValue = 9116133802716249986L,
},
            new Int64bigint0M
{
    Id = 87,
    Value = 6332031193832966405L,
    ModelInner = null,
    NullableValue = 2336052062610504959L,
},
            new Int64bigint0M
{
    Id = 96,
    Value = 5611573552203123571L,
    ModelInner = new Int64bigint0MI
{
    Id = 45,
    Value = 7907313240600640859L,
    NullableValue = 6982837758264729414L,
},
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 101,
    Value = 4067613622070679551L,
    ModelInner = null,
    NullableValue = 5656672394860326442L,
},
            new Int64bigint0M
{
    Id = 109,
    Value = 1066741026061903282L,
    ModelInner = new Int64bigint0MI
{
    Id = 52,
    Value = 5282323172416904331L,
    NullableValue = 6752854514393386709L,
},
    NullableValue = 7982868038021363611L,
},
            new Int64bigint0M
{
    Id = 112,
    Value = 51715117290745773L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 118,
    Value = 6245130863381059001L,
    ModelInner = new Int64bigint0MI
{
    Id = 60,
    Value = 597250473179855459L,
    NullableValue = 6322307436654116313L,
},
    NullableValue = 4250280933518639131L,
},
            new Int64bigint0M
{
    Id = 126,
    Value = 8544741868266504603L,
    ModelInner = null,
    NullableValue = 8276440694447382617L,
},
            new Int64bigint0M
{
    Id = 133,
    Value = 2719522920332019877L,
    ModelInner = new Int64bigint0MI
{
    Id = 66,
    Value = 5331456923552624390L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 139,
    Value = 7876684413210066190L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 148,
    Value = 9052371220347703805L,
    ModelInner = new Int64bigint0MI
{
    Id = 69,
    Value = 1541406118480381095L,
    NullableValue = 3352452405094626807L,
},
    NullableValue = 8784341535984167665L,
},
            new Int64bigint0M
{
    Id = 150,
    Value = 8824378099771621280L,
    ModelInner = null,
    NullableValue = 1731673594570168350L,
},
            new Int64bigint0M
{
    Id = 159,
    Value = 5912977935437650218L,
    ModelInner = new Int64bigint0MI
{
    Id = 72,
    Value = 7487087190758513639L,
    NullableValue = 8410813515304152985L,
},
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 160,
    Value = 3660410975934757236L,
    ModelInner = null,
    NullableValue = 7706682643949887487L,
},
            new Int64bigint0M
{
    Id = 163,
    Value = 8414160178262056847L,
    ModelInner = new Int64bigint0MI
{
    Id = 76,
    Value = 3870717351592248611L,
    NullableValue = null,
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(6889654932956617811L));
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
                Assert.That(nullable, Is.EqualTo(4567452269844096081L));
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(375553265277222053L));
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
                Assert.That(nullable, Is.EqualTo(3743285478994601142L));
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
                Assert.That(nullable, Is.EqualTo(8489893924107488501L));
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
                Assert.That(nullable, Is.EqualTo(3943983061874207800L));
                nullable = await ((IInt64SingleTypebigint)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(6565669454259310946L));
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
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigint0M)],
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
LEFT JOIN public.int64bigint0mi mi ON mi.id = m.int64bigint0mi_id
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
LEFT JOIN public.int64bigint0mi mi ON mi.id = m.int64bigint0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models =  ((IInt64SingleTypebigint)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
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

                var models =  ((IInt64SingleTypebigint)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int64bigint0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigint0M)],
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
LEFT JOIN public.int64bigint0mi mi ON mi.id = m.int64bigint0mi_id
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
LEFT JOIN public.int64bigint0mi mi ON mi.id = m.int64bigint0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models =  ((IInt64SingleTypebigint)this).DynQuerySelectModel(connection,  query, 0);
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
                var models =  ((IInt64SingleTypebigint)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int64bigint0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigint0M)],
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
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
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
LEFT JOIN public.int64bigint0mi mi ON mi.id = m.int64bigint0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models = await ((IInt64SingleTypebigint)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigint0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 55;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 41;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int64bigint0m m
LEFT JOIN public.int64bigint0mi mi ON mi.id = m.int64bigint0mi_id
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
LEFT JOIN public.int64bigint0mi mi ON mi.id = m.int64bigint0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IInt64SingleTypebigint)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));
FlatInt64bigint0M.AssertModel(models[0],_testData[10], false);FlatInt64bigint0M.AssertModel(models[1],_testData[11], false);FlatInt64bigint0M.AssertModel(models[2],_testData[12], false);FlatInt64bigint0M.AssertModel(models[3],_testData[13], false);FlatInt64bigint0M.AssertModel(models[4],_testData[14], false);FlatInt64bigint0M.AssertModel(models[5],_testData[15], false);FlatInt64bigint0M.AssertModel(models[6],_testData[16], false);FlatInt64bigint0M.AssertModel(models[7],_testData[17], false);FlatInt64bigint0M.AssertModel(models[8],_testData[18], false);FlatInt64bigint0M.AssertModel(models[9],_testData[19], false);FlatInt64bigint0M.AssertModel(models[10],_testData[20], false);FlatInt64bigint0M.AssertModel(models[11],_testData[21], false);FlatInt64bigint0M.AssertModel(models[12],_testData[22], false);FlatInt64bigint0M.AssertModel(models[13],_testData[23], false);FlatInt64bigint0M.AssertModel(models[14],_testData[24], false);FlatInt64bigint0M.AssertModel(models[15],_testData[25], false);FlatInt64bigint0M.AssertModel(models[16],_testData[26], false);FlatInt64bigint0M.AssertModel(models[17],_testData[27], false);FlatInt64bigint0M.AssertModel(models[18],_testData[28], false);FlatInt64bigint0M.AssertModel(models[19],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));
FlatInt64bigint0M.AssertModel(models[0],_testData[8], false);FlatInt64bigint0M.AssertModel(models[1],_testData[9], false);FlatInt64bigint0M.AssertModel(models[2],_testData[10], false);FlatInt64bigint0M.AssertModel(models[3],_testData[11], false);FlatInt64bigint0M.AssertModel(models[4],_testData[12], false);FlatInt64bigint0M.AssertModel(models[5],_testData[13], false);FlatInt64bigint0M.AssertModel(models[6],_testData[14], false);FlatInt64bigint0M.AssertModel(models[7],_testData[15], false);FlatInt64bigint0M.AssertModel(models[8],_testData[16], false);FlatInt64bigint0M.AssertModel(models[9],_testData[17], false);FlatInt64bigint0M.AssertModel(models[10],_testData[18], false);FlatInt64bigint0M.AssertModel(models[11],_testData[19], false);FlatInt64bigint0M.AssertModel(models[12],_testData[20], false);FlatInt64bigint0M.AssertModel(models[13],_testData[21], false);FlatInt64bigint0M.AssertModel(models[14],_testData[22], false);FlatInt64bigint0M.AssertModel(models[15],_testData[23], false);FlatInt64bigint0M.AssertModel(models[16],_testData[24], false);FlatInt64bigint0M.AssertModel(models[17],_testData[25], false);FlatInt64bigint0M.AssertModel(models[18],_testData[26], false);FlatInt64bigint0M.AssertModel(models[19],_testData[27], false);FlatInt64bigint0M.AssertModel(models[20],_testData[28], false);FlatInt64bigint0M.AssertModel(models[21],_testData[29], false);
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
FROM public.int64bigint0m m
LEFT JOIN public.int64bigint0mi mi ON mi.id = m.int64bigint0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models =  ((IInt64SingleTypebigint)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigint0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 65;
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
FROM public.int64bigint0m m
LEFT JOIN public.int64bigint0mi mi ON mi.id = m.int64bigint0mi_id
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
LEFT JOIN public.int64bigint0mi mi ON mi.id = m.int64bigint0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IInt64SingleTypebigint)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));
FlatInt64bigint0M.AssertModel(models[0],_testData[12], false);FlatInt64bigint0M.AssertModel(models[1],_testData[13], false);FlatInt64bigint0M.AssertModel(models[2],_testData[14], false);FlatInt64bigint0M.AssertModel(models[3],_testData[15], false);FlatInt64bigint0M.AssertModel(models[4],_testData[16], false);FlatInt64bigint0M.AssertModel(models[5],_testData[17], false);FlatInt64bigint0M.AssertModel(models[6],_testData[18], false);FlatInt64bigint0M.AssertModel(models[7],_testData[19], false);FlatInt64bigint0M.AssertModel(models[8],_testData[20], false);FlatInt64bigint0M.AssertModel(models[9],_testData[21], false);FlatInt64bigint0M.AssertModel(models[10],_testData[22], false);FlatInt64bigint0M.AssertModel(models[11],_testData[23], false);FlatInt64bigint0M.AssertModel(models[12],_testData[24], false);FlatInt64bigint0M.AssertModel(models[13],_testData[25], false);FlatInt64bigint0M.AssertModel(models[14],_testData[26], false);FlatInt64bigint0M.AssertModel(models[15],_testData[27], false);FlatInt64bigint0M.AssertModel(models[16],_testData[28], false);FlatInt64bigint0M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));
FlatInt64bigint0M.AssertModel(models[0],_testData[21], false);FlatInt64bigint0M.AssertModel(models[1],_testData[22], false);FlatInt64bigint0M.AssertModel(models[2],_testData[23], false);FlatInt64bigint0M.AssertModel(models[3],_testData[24], false);FlatInt64bigint0M.AssertModel(models[4],_testData[25], false);FlatInt64bigint0M.AssertModel(models[5],_testData[26], false);FlatInt64bigint0M.AssertModel(models[6],_testData[27], false);FlatInt64bigint0M.AssertModel(models[7],_testData[28], false);FlatInt64bigint0M.AssertModel(models[8],_testData[29], false);
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
            batchName: "DbConnectionSelectModelDynParBatch",
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

                var models = await ((IInt64SingleTypebigint)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int64bigint0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 20;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 112;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((IInt64SingleTypebigint)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));
Int64bigint0M.AssertModel(models[0],_testData[4], false);Int64bigint0M.AssertModel(models[1],_testData[5], false);Int64bigint0M.AssertModel(models[2],_testData[6], false);Int64bigint0M.AssertModel(models[3],_testData[7], false);Int64bigint0M.AssertModel(models[4],_testData[8], false);Int64bigint0M.AssertModel(models[5],_testData[9], false);Int64bigint0M.AssertModel(models[6],_testData[10], false);Int64bigint0M.AssertModel(models[7],_testData[11], false);Int64bigint0M.AssertModel(models[8],_testData[12], false);Int64bigint0M.AssertModel(models[9],_testData[13], false);Int64bigint0M.AssertModel(models[10],_testData[14], false);Int64bigint0M.AssertModel(models[11],_testData[15], false);Int64bigint0M.AssertModel(models[12],_testData[16], false);Int64bigint0M.AssertModel(models[13],_testData[17], false);Int64bigint0M.AssertModel(models[14],_testData[18], false);Int64bigint0M.AssertModel(models[15],_testData[19], false);Int64bigint0M.AssertModel(models[16],_testData[20], false);Int64bigint0M.AssertModel(models[17],_testData[21], false);Int64bigint0M.AssertModel(models[18],_testData[22], false);Int64bigint0M.AssertModel(models[19],_testData[23], false);Int64bigint0M.AssertModel(models[20],_testData[24], false);Int64bigint0M.AssertModel(models[21],_testData[25], false);Int64bigint0M.AssertModel(models[22],_testData[26], false);Int64bigint0M.AssertModel(models[23],_testData[27], false);Int64bigint0M.AssertModel(models[24],_testData[28], false);Int64bigint0M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));
Int64bigint0M.AssertModel(models[0],_testData[21], false);Int64bigint0M.AssertModel(models[1],_testData[22], false);Int64bigint0M.AssertModel(models[2],_testData[23], false);Int64bigint0M.AssertModel(models[3],_testData[24], false);Int64bigint0M.AssertModel(models[4],_testData[25], false);Int64bigint0M.AssertModel(models[5],_testData[26], false);Int64bigint0M.AssertModel(models[6],_testData[27], false);Int64bigint0M.AssertModel(models[7],_testData[28], false);Int64bigint0M.AssertModel(models[8],_testData[29], false);
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

                var models =  ((IInt64SingleTypebigint)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int64bigint0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 118;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 41;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((IInt64SingleTypebigint)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));
Int64bigint0M.AssertModel(models[0],_testData[22], false);Int64bigint0M.AssertModel(models[1],_testData[23], false);Int64bigint0M.AssertModel(models[2],_testData[24], false);Int64bigint0M.AssertModel(models[3],_testData[25], false);Int64bigint0M.AssertModel(models[4],_testData[26], false);Int64bigint0M.AssertModel(models[5],_testData[27], false);Int64bigint0M.AssertModel(models[6],_testData[28], false);Int64bigint0M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));
Int64bigint0M.AssertModel(models[0],_testData[8], false);Int64bigint0M.AssertModel(models[1],_testData[9], false);Int64bigint0M.AssertModel(models[2],_testData[10], false);Int64bigint0M.AssertModel(models[3],_testData[11], false);Int64bigint0M.AssertModel(models[4],_testData[12], false);Int64bigint0M.AssertModel(models[5],_testData[13], false);Int64bigint0M.AssertModel(models[6],_testData[14], false);Int64bigint0M.AssertModel(models[7],_testData[15], false);Int64bigint0M.AssertModel(models[8],_testData[16], false);Int64bigint0M.AssertModel(models[9],_testData[17], false);Int64bigint0M.AssertModel(models[10],_testData[18], false);Int64bigint0M.AssertModel(models[11],_testData[19], false);Int64bigint0M.AssertModel(models[12],_testData[20], false);Int64bigint0M.AssertModel(models[13],_testData[21], false);Int64bigint0M.AssertModel(models[14],_testData[22], false);Int64bigint0M.AssertModel(models[15],_testData[23], false);Int64bigint0M.AssertModel(models[16],_testData[24], false);Int64bigint0M.AssertModel(models[17],_testData[25], false);Int64bigint0M.AssertModel(models[18],_testData[26], false);Int64bigint0M.AssertModel(models[19],_testData[27], false);Int64bigint0M.AssertModel(models[20],_testData[28], false);Int64bigint0M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigint0M)],
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
            batchName: "DbConnectionDynQuerySelectModelBatch",
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
LEFT JOIN public.int64bigint0mi mi ON mi.id = m.int64bigint0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await ((IInt64SingleTypebigint)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigint0M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigint0m m
LEFT JOIN public.int64bigint0mi mi ON mi.id = m.int64bigint0mi_id
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
LEFT JOIN public.int64bigint0mi mi ON mi.id = m.int64bigint0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IInt64SingleTypebigint)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 118, query1, 50, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));
FlatInt64bigint0M.AssertModel(models[0],_testData[22], false);FlatInt64bigint0M.AssertModel(models[1],_testData[23], false);FlatInt64bigint0M.AssertModel(models[2],_testData[24], false);FlatInt64bigint0M.AssertModel(models[3],_testData[25], false);FlatInt64bigint0M.AssertModel(models[4],_testData[26], false);FlatInt64bigint0M.AssertModel(models[5],_testData[27], false);FlatInt64bigint0M.AssertModel(models[6],_testData[28], false);FlatInt64bigint0M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));
FlatInt64bigint0M.AssertModel(models[0],_testData[9], false);FlatInt64bigint0M.AssertModel(models[1],_testData[10], false);FlatInt64bigint0M.AssertModel(models[2],_testData[11], false);FlatInt64bigint0M.AssertModel(models[3],_testData[12], false);FlatInt64bigint0M.AssertModel(models[4],_testData[13], false);FlatInt64bigint0M.AssertModel(models[5],_testData[14], false);FlatInt64bigint0M.AssertModel(models[6],_testData[15], false);FlatInt64bigint0M.AssertModel(models[7],_testData[16], false);FlatInt64bigint0M.AssertModel(models[8],_testData[17], false);FlatInt64bigint0M.AssertModel(models[9],_testData[18], false);FlatInt64bigint0M.AssertModel(models[10],_testData[19], false);FlatInt64bigint0M.AssertModel(models[11],_testData[20], false);FlatInt64bigint0M.AssertModel(models[12],_testData[21], false);FlatInt64bigint0M.AssertModel(models[13],_testData[22], false);FlatInt64bigint0M.AssertModel(models[14],_testData[23], false);FlatInt64bigint0M.AssertModel(models[15],_testData[24], false);FlatInt64bigint0M.AssertModel(models[16],_testData[25], false);FlatInt64bigint0M.AssertModel(models[17],_testData[26], false);FlatInt64bigint0M.AssertModel(models[18],_testData[27], false);FlatInt64bigint0M.AssertModel(models[19],_testData[28], false);FlatInt64bigint0M.AssertModel(models[20],_testData[29], false);
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
FROM public.int64bigint0m m
LEFT JOIN public.int64bigint0mi mi ON mi.id = m.int64bigint0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models =  ((IInt64SingleTypebigint)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigint0M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigint0m m
LEFT JOIN public.int64bigint0mi mi ON mi.id = m.int64bigint0mi_id
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
LEFT JOIN public.int64bigint0mi mi ON mi.id = m.int64bigint0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IInt64SingleTypebigint)this).DbConnectionDynQuerySelectModelBatch(connection, 148, query1, 24, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));
FlatInt64bigint0M.AssertModel(models[0],_testData[26], false);FlatInt64bigint0M.AssertModel(models[1],_testData[27], false);FlatInt64bigint0M.AssertModel(models[2],_testData[28], false);FlatInt64bigint0M.AssertModel(models[3],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));
FlatInt64bigint0M.AssertModel(models[0],_testData[5], false);FlatInt64bigint0M.AssertModel(models[1],_testData[6], false);FlatInt64bigint0M.AssertModel(models[2],_testData[7], false);FlatInt64bigint0M.AssertModel(models[3],_testData[8], false);FlatInt64bigint0M.AssertModel(models[4],_testData[9], false);FlatInt64bigint0M.AssertModel(models[5],_testData[10], false);FlatInt64bigint0M.AssertModel(models[6],_testData[11], false);FlatInt64bigint0M.AssertModel(models[7],_testData[12], false);FlatInt64bigint0M.AssertModel(models[8],_testData[13], false);FlatInt64bigint0M.AssertModel(models[9],_testData[14], false);FlatInt64bigint0M.AssertModel(models[10],_testData[15], false);FlatInt64bigint0M.AssertModel(models[11],_testData[16], false);FlatInt64bigint0M.AssertModel(models[12],_testData[17], false);FlatInt64bigint0M.AssertModel(models[13],_testData[18], false);FlatInt64bigint0M.AssertModel(models[14],_testData[19], false);FlatInt64bigint0M.AssertModel(models[15],_testData[20], false);FlatInt64bigint0M.AssertModel(models[16],_testData[21], false);FlatInt64bigint0M.AssertModel(models[17],_testData[22], false);FlatInt64bigint0M.AssertModel(models[18],_testData[23], false);FlatInt64bigint0M.AssertModel(models[19],_testData[24], false);FlatInt64bigint0M.AssertModel(models[20],_testData[25], false);FlatInt64bigint0M.AssertModel(models[21],_testData[26], false);FlatInt64bigint0M.AssertModel(models[22],_testData[27], false);FlatInt64bigint0M.AssertModel(models[23],_testData[28], false);FlatInt64bigint0M.AssertModel(models[24],_testData[29], false);
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
            batchName: "DbConnectionSelectModelBatch",
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
        private void DbConnectionSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IInt64SingleTypebigint)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int64bigint0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IInt64SingleTypebigint)this).DbConnectionSelectModelBatchAsync(connection, 7, 159))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));
Int64bigint0M.AssertModel(models[0],_testData[1], false);Int64bigint0M.AssertModel(models[1],_testData[2], false);Int64bigint0M.AssertModel(models[2],_testData[3], false);Int64bigint0M.AssertModel(models[3],_testData[4], false);Int64bigint0M.AssertModel(models[4],_testData[5], false);Int64bigint0M.AssertModel(models[5],_testData[6], false);Int64bigint0M.AssertModel(models[6],_testData[7], false);Int64bigint0M.AssertModel(models[7],_testData[8], false);Int64bigint0M.AssertModel(models[8],_testData[9], false);Int64bigint0M.AssertModel(models[9],_testData[10], false);Int64bigint0M.AssertModel(models[10],_testData[11], false);Int64bigint0M.AssertModel(models[11],_testData[12], false);Int64bigint0M.AssertModel(models[12],_testData[13], false);Int64bigint0M.AssertModel(models[13],_testData[14], false);Int64bigint0M.AssertModel(models[14],_testData[15], false);Int64bigint0M.AssertModel(models[15],_testData[16], false);Int64bigint0M.AssertModel(models[16],_testData[17], false);Int64bigint0M.AssertModel(models[17],_testData[18], false);Int64bigint0M.AssertModel(models[18],_testData[19], false);Int64bigint0M.AssertModel(models[19],_testData[20], false);Int64bigint0M.AssertModel(models[20],_testData[21], false);Int64bigint0M.AssertModel(models[21],_testData[22], false);Int64bigint0M.AssertModel(models[22],_testData[23], false);Int64bigint0M.AssertModel(models[23],_testData[24], false);Int64bigint0M.AssertModel(models[24],_testData[25], false);Int64bigint0M.AssertModel(models[25],_testData[26], false);Int64bigint0M.AssertModel(models[26],_testData[27], false);Int64bigint0M.AssertModel(models[27],_testData[28], false);Int64bigint0M.AssertModel(models[28],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));
Int64bigint0M.AssertModel(models[0],_testData[28], false);Int64bigint0M.AssertModel(models[1],_testData[29], false);
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
                var models =  ((IInt64SingleTypebigint)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int64bigint0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IInt64SingleTypebigint)this).DbConnectionSelectModelBatch(connection, 13, 65))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));
Int64bigint0M.AssertModel(models[0],_testData[2], false);Int64bigint0M.AssertModel(models[1],_testData[3], false);Int64bigint0M.AssertModel(models[2],_testData[4], false);Int64bigint0M.AssertModel(models[3],_testData[5], false);Int64bigint0M.AssertModel(models[4],_testData[6], false);Int64bigint0M.AssertModel(models[5],_testData[7], false);Int64bigint0M.AssertModel(models[6],_testData[8], false);Int64bigint0M.AssertModel(models[7],_testData[9], false);Int64bigint0M.AssertModel(models[8],_testData[10], false);Int64bigint0M.AssertModel(models[9],_testData[11], false);Int64bigint0M.AssertModel(models[10],_testData[12], false);Int64bigint0M.AssertModel(models[11],_testData[13], false);Int64bigint0M.AssertModel(models[12],_testData[14], false);Int64bigint0M.AssertModel(models[13],_testData[15], false);Int64bigint0M.AssertModel(models[14],_testData[16], false);Int64bigint0M.AssertModel(models[15],_testData[17], false);Int64bigint0M.AssertModel(models[16],_testData[18], false);Int64bigint0M.AssertModel(models[17],_testData[19], false);Int64bigint0M.AssertModel(models[18],_testData[20], false);Int64bigint0M.AssertModel(models[19],_testData[21], false);Int64bigint0M.AssertModel(models[20],_testData[22], false);Int64bigint0M.AssertModel(models[21],_testData[23], false);Int64bigint0M.AssertModel(models[22],_testData[24], false);Int64bigint0M.AssertModel(models[23],_testData[25], false);Int64bigint0M.AssertModel(models[24],_testData[26], false);Int64bigint0M.AssertModel(models[25],_testData[27], false);Int64bigint0M.AssertModel(models[26],_testData[28], false);Int64bigint0M.AssertModel(models[27],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));
Int64bigint0M.AssertModel(models[0],_testData[12], false);Int64bigint0M.AssertModel(models[1],_testData[13], false);Int64bigint0M.AssertModel(models[2],_testData[14], false);Int64bigint0M.AssertModel(models[3],_testData[15], false);Int64bigint0M.AssertModel(models[4],_testData[16], false);Int64bigint0M.AssertModel(models[5],_testData[17], false);Int64bigint0M.AssertModel(models[6],_testData[18], false);Int64bigint0M.AssertModel(models[7],_testData[19], false);Int64bigint0M.AssertModel(models[8],_testData[20], false);Int64bigint0M.AssertModel(models[9],_testData[21], false);Int64bigint0M.AssertModel(models[10],_testData[22], false);Int64bigint0M.AssertModel(models[11],_testData[23], false);Int64bigint0M.AssertModel(models[12],_testData[24], false);Int64bigint0M.AssertModel(models[13],_testData[25], false);Int64bigint0M.AssertModel(models[14],_testData[26], false);Int64bigint0M.AssertModel(models[15],_testData[27], false);Int64bigint0M.AssertModel(models[16],_testData[28], false);Int64bigint0M.AssertModel(models[17],_testData[29], false);
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
                ((IInt64SingleTypebigint)this).SetDbConnectionSelectModelParametrs(cmd, 7);
                var models = await ((IInt64SingleTypebigint)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(29));
Int64bigint0M.AssertModel(models[0],_testData[1], false);Int64bigint0M.AssertModel(models[1],_testData[2], false);Int64bigint0M.AssertModel(models[2],_testData[3], false);Int64bigint0M.AssertModel(models[3],_testData[4], false);Int64bigint0M.AssertModel(models[4],_testData[5], false);Int64bigint0M.AssertModel(models[5],_testData[6], false);Int64bigint0M.AssertModel(models[6],_testData[7], false);Int64bigint0M.AssertModel(models[7],_testData[8], false);Int64bigint0M.AssertModel(models[8],_testData[9], false);Int64bigint0M.AssertModel(models[9],_testData[10], false);Int64bigint0M.AssertModel(models[10],_testData[11], false);Int64bigint0M.AssertModel(models[11],_testData[12], false);Int64bigint0M.AssertModel(models[12],_testData[13], false);Int64bigint0M.AssertModel(models[13],_testData[14], false);Int64bigint0M.AssertModel(models[14],_testData[15], false);Int64bigint0M.AssertModel(models[15],_testData[16], false);Int64bigint0M.AssertModel(models[16],_testData[17], false);Int64bigint0M.AssertModel(models[17],_testData[18], false);Int64bigint0M.AssertModel(models[18],_testData[19], false);Int64bigint0M.AssertModel(models[19],_testData[20], false);Int64bigint0M.AssertModel(models[20],_testData[21], false);Int64bigint0M.AssertModel(models[21],_testData[22], false);Int64bigint0M.AssertModel(models[22],_testData[23], false);Int64bigint0M.AssertModel(models[23],_testData[24], false);Int64bigint0M.AssertModel(models[24],_testData[25], false);Int64bigint0M.AssertModel(models[25],_testData[26], false);Int64bigint0M.AssertModel(models[26],_testData[27], false);Int64bigint0M.AssertModel(models[27],_testData[28], false);Int64bigint0M.AssertModel(models[28],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt64SingleTypebigint)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt64SingleTypebigint)this).SetDbConnectionSelectModelParametrs(cmd, 72);
                var models =  ((IInt64SingleTypebigint)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(17));
Int64bigint0M.AssertModel(models[0],_testData[13], false);Int64bigint0M.AssertModel(models[1],_testData[14], false);Int64bigint0M.AssertModel(models[2],_testData[15], false);Int64bigint0M.AssertModel(models[3],_testData[16], false);Int64bigint0M.AssertModel(models[4],_testData[17], false);Int64bigint0M.AssertModel(models[5],_testData[18], false);Int64bigint0M.AssertModel(models[6],_testData[19], false);Int64bigint0M.AssertModel(models[7],_testData[20], false);Int64bigint0M.AssertModel(models[8],_testData[21], false);Int64bigint0M.AssertModel(models[9],_testData[22], false);Int64bigint0M.AssertModel(models[10],_testData[23], false);Int64bigint0M.AssertModel(models[11],_testData[24], false);Int64bigint0M.AssertModel(models[12],_testData[25], false);Int64bigint0M.AssertModel(models[13],_testData[26], false);Int64bigint0M.AssertModel(models[14],_testData[27], false);Int64bigint0M.AssertModel(models[15],_testData[28], false);Int64bigint0M.AssertModel(models[16],_testData[29], false);
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
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3508054398489452615L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((919197622586262139L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((8244848102852630590L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7123731647334183899L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5392512198133026064L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((4825007257991968479L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((4169976237493395767L)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8046646120588157909L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((6889654932956617811L)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5067714111940478223L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((684335498958863775L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((1705528992836069107L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((4567452269844096081L)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1773590971677865782L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((375553265277222053L)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1418976000572582465L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((8092429303499103770L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((3743285478994601142L)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3105899272135669079L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5095522798232129972L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((663781773385297555L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((8489893924107488501L)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8363902941101586247L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((3943983061874207800L)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4436380771110504378L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((6291922213335191059L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((6565669454259310946L)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7257467047617114635L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((5647894926251848508L)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((92552646586655315L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((3014309533243935309L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1682220487171014835L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7791986463648078751L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((2840655313287382179L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((9116133802716249986L)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6332031193832966405L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((2336052062610504959L)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((96)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5611573552203123571L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((7907313240600640859L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((6982837758264729414L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4067613622070679551L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((5656672394860326442L)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1066741026061903282L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((5282323172416904331L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((6752854514393386709L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((7982868038021363611L)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((51715117290745773L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6245130863381059001L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((597250473179855459L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((6322307436654116313L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((4250280933518639131L)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8544741868266504603L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((8276440694447382617L)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2719522920332019877L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((5331456923552624390L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7876684413210066190L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((9052371220347703805L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((1541406118480381095L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((3352452405094626807L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((8784341535984167665L)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8824378099771621280L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((1731673594570168350L)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((159)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5912977935437650218L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((7487087190758513639L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((8410813515304152985L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((160)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3660410975934757236L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((7706682643949887487L)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((163)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8414160178262056847L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((76)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((3870717351592248611L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

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
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3508054398489452615L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((919197622586262139L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((8244848102852630590L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7123731647334183899L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5392512198133026064L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((4825007257991968479L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((4169976237493395767L)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8046646120588157909L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((6889654932956617811L)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5067714111940478223L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((684335498958863775L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((1705528992836069107L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((4567452269844096081L)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1773590971677865782L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((375553265277222053L)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1418976000572582465L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((8092429303499103770L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((3743285478994601142L)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3105899272135669079L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5095522798232129972L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((663781773385297555L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((8489893924107488501L)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8363902941101586247L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((3943983061874207800L)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4436380771110504378L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((6291922213335191059L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((6565669454259310946L)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7257467047617114635L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((5647894926251848508L)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((92552646586655315L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((3014309533243935309L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1682220487171014835L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7791986463648078751L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((2840655313287382179L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((9116133802716249986L)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6332031193832966405L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((2336052062610504959L)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((96)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5611573552203123571L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((7907313240600640859L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((6982837758264729414L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4067613622070679551L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((5656672394860326442L)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1066741026061903282L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((5282323172416904331L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((6752854514393386709L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((7982868038021363611L)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((51715117290745773L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6245130863381059001L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((597250473179855459L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((6322307436654116313L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((4250280933518639131L)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8544741868266504603L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((8276440694447382617L)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2719522920332019877L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((5331456923552624390L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7876684413210066190L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((9052371220347703805L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((1541406118480381095L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((3352452405094626807L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((8784341535984167665L)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8824378099771621280L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((1731673594570168350L)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((159)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5912977935437650218L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((7487087190758513639L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((8410813515304152985L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((160)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3660410975934757236L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((7706682643949887487L)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((163)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8414160178262056847L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((76)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((3870717351592248611L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

#endregion

#region BinaryImportModelInner

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

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<Int64bigint0MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((IInt64SingleTypebigint)this).ImportModelInner(connection, importCollection);
                var models = ((IInt64SingleTypebigint)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigint0MI.AssertModel(actual, expect, false);
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
                await ((IInt64SingleTypebigint)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((IInt64SingleTypebigint)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigint0MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
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

