

using MySqlConnector;
using System;
using Gedaq.Common.Enums;
using Gedaq.MySqlConnector.Attributes;
using Gedaq.MySqlConnector.Enums;


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
    Id = 7,
    Value = 3983765199643509471L,
    ModelInner = null,
    NullableValue = 5801987086351438589L,
},
            new Int64bigintE0M
{
    Id = 12,
    Value = 7686042652671994489L,
    ModelInner = new Int64bigint0MI
{
    Id = 7,
    Value = 1352924275559734196L,
    NullableValue = 4005576914691605632L,
},
    NullableValue = 7017010975639648052L,
},
            new Int64bigintE0M
{
    Id = 19,
    Value = 5088685696844049267L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 23,
    Value = 1454313183870181295L,
    ModelInner = new Int64bigint0MI
{
    Id = 9,
    Value = 2629587646910981666L,
    NullableValue = 8550704035343143994L,
},
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 27,
    Value = 648893604106672188L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 35,
    Value = 8706075128481973011L,
    ModelInner = new Int64bigint0MI
{
    Id = 16,
    Value = 3485397051010203387L,
    NullableValue = null,
},
    NullableValue = 1314183442217581848L,
},
            new Int64bigintE0M
{
    Id = 40,
    Value = 443836946488590623L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 47,
    Value = 5998972216521197564L,
    ModelInner = new Int64bigint0MI
{
    Id = 22,
    Value = 8164162254246874723L,
    NullableValue = 8677301972797730246L,
},
    NullableValue = 2414691135252297322L,
},
            new Int64bigintE0M
{
    Id = 56,
    Value = 5427932202219494747L,
    ModelInner = null,
    NullableValue = 1393152616880191285L,
},
            new Int64bigintE0M
{
    Id = 59,
    Value = 6265755769433776278L,
    ModelInner = new Int64bigint0MI
{
    Id = 29,
    Value = 5511436292802620608L,
    NullableValue = 2933719072496906364L,
},
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 61,
    Value = 8042977191518111060L,
    ModelInner = null,
    NullableValue = 8396467863979867688L,
},
            new Int64bigintE0M
{
    Id = 64,
    Value = 4705176345021312784L,
    ModelInner = new Int64bigint0MI
{
    Id = 35,
    Value = 5130046379073567934L,
    NullableValue = 7080719232976782761L,
},
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 67,
    Value = 6083085449772470450L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 73,
    Value = 92309942685774197L,
    ModelInner = new Int64bigint0MI
{
    Id = 38,
    Value = 5130158776437686967L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 74,
    Value = 1779393608894550107L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 76,
    Value = 2232778158237150558L,
    ModelInner = new Int64bigint0MI
{
    Id = 40,
    Value = 3907023508115680675L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 78,
    Value = 6817059459550013179L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 86,
    Value = 2993257108331721880L,
    ModelInner = new Int64bigint0MI
{
    Id = 43,
    Value = 2046844924613247676L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 87,
    Value = 1799812121965997998L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 88,
    Value = 3418438036155252741L,
    ModelInner = new Int64bigint0MI
{
    Id = 46,
    Value = 7006653173332399946L,
    NullableValue = 4820793817178993164L,
},
    NullableValue = 4086567262746624635L,
},
            new Int64bigintE0M
{
    Id = 91,
    Value = 3926276758459441223L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 97,
    Value = 9217306888055261170L,
    ModelInner = new Int64bigint0MI
{
    Id = 53,
    Value = 3813149013513881082L,
    NullableValue = 8062145088970535954L,
},
    NullableValue = 6428567978714570878L,
},
            new Int64bigintE0M
{
    Id = 101,
    Value = 9018911593741207693L,
    ModelInner = null,
    NullableValue = 510352308768671032L,
},
            new Int64bigintE0M
{
    Id = 102,
    Value = 4059947343363499743L,
    ModelInner = new Int64bigint0MI
{
    Id = 60,
    Value = 2388538382912864411L,
    NullableValue = 3579570350232047189L,
},
    NullableValue = 5001782942094315551L,
},
            new Int64bigintE0M
{
    Id = 105,
    Value = 7532662960307817188L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 112,
    Value = 2743935710047640975L,
    ModelInner = new Int64bigint0MI
{
    Id = 69,
    Value = 4182627191549302768L,
    NullableValue = 3967097968315150391L,
},
    NullableValue = 7225148486152636339L,
},
            new Int64bigintE0M
{
    Id = 117,
    Value = 4609599083762700181L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 121,
    Value = 6903213719038711785L,
    ModelInner = new Int64bigint0MI
{
    Id = 71,
    Value = 9098815185933107463L,
    NullableValue = 1330369141081765640L,
},
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 123,
    Value = 6188146194982989741L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 131,
    Value = 8872526421770528106L,
    ModelInner = new Int64bigint0MI
{
    Id = 77,
    Value = 1260228388161586485L,
    NullableValue = null,
},
    NullableValue = 2740933659259375644L,
},
            new Int64bigintE0M
{
    Id = 137,
    Value = 930534258193745304L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 138,
    Value = 5452109039898786163L,
    ModelInner = new Int64bigint0MI
{
    Id = 78,
    Value = 2407241578978158721L,
    NullableValue = null,
},
    NullableValue = 3249305762334388391L,
},
            new Int64bigintE0M
{
    Id = 139,
    Value = 1503733464003809217L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 144,
    Value = 151073102342592062L,
    ModelInner = new Int64bigint0MI
{
    Id = 86,
    Value = 8888014898211702711L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 148,
    Value = 8309711562322904669L,
    ModelInner = null,
    NullableValue = 2209504896410133189L,
},
        };

#endregion

#region InsertModelInner

[Gedaq.MySqlConnector.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.int64bigint0mi(
	id,
    value,
    nullablevalue
)
VALUES (
    @id, 
    @value, 
    @nullablevalue
);
",
            methodName:"InsertModelInner",
            sourceType: SourceType.MySqlConnection,
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                parametrName: "id",
                methodParametrName: "id", 
                dbType: (MySqlConnector.MySqlDbType)(3)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int64),
                parametrName: "value",
                methodParametrName: "value",
                dbType: (MySqlConnector.MySqlDbType)(8)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int64?), 
                parametrName: "nullablevalue",
                methodParametrName: "nullablevalue",
                dbType: (MySqlConnector.MySqlDbType)(8))]
        public void InsertModelInnerConfig()
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

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.int64bigint0mi(
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

                changedRows =  ((IInt64SingleTypebigint)this).DbConnectionInsertInnerModel(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
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

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertInnerModelAsync(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertInnerModelAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertInnerModelAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertInnerModelAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

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

[Gedaq.MySqlConnector.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.int64biginte0m(
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
            methodName:"InsertModel",
            sourceType: SourceType.MySqlConnection,
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (MySqlConnector.MySqlDbType)(3)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int64), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (MySqlConnector.MySqlDbType)(8)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int64?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (MySqlConnector.MySqlDbType)(8),
                nullable: true),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "int64bigint0mi_id", 
                methodParametrName: "int64bigint0mi_id", 
                dbType: (MySqlConnector.MySqlDbType)(3),
                nullable: true)]
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

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.int64biginte0m(
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

                changedRows =  ((IInt64SingleTypebigint)this).DbConnectionInsertModel(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IInt64SingleTypebigint)this).DbConnectionInsertModel(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
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

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

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

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintE0M), typeof(FlatInt64bigintE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
Gedaq.MySqlConnector.Attributes.DynamicParametr()]
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
FROM gedaqtests.int64biginte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt64bigintE0M>();
                var models2 = new List<FlatInt64bigintE0M>();
                await((IInt64SingleTypebigint)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
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
FROM gedaqtests.int64biginte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
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

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
Gedaq.MySqlConnector.Attributes.DynamicParametr()]
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
FROM gedaqtests.int64biginte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
                var models = await((IInt64SingleTypebigint)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
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
FROM gedaqtests.int64biginte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
                var models = ((IInt64SingleTypebigint)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.MySqlConnector.Attributes.Query(
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
FROM gedaqtests.int64biginte0m m
LEFT JOIN gedaqtests.int64bigint0mi mi ON mi.id = m.int64bigint0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            sourceType: SourceType.MySqlConnection,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Int64bigintE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
Gedaq.MySqlConnector.Attributes.DynamicParametr()]
        private void SelectModelDynParConfig()
        {
        }

        [Test, Order(2)]
        public async Task SelectModelDynParTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
                var models = await((IInt64SingleTypebigint)this).SelectModelDynParAsync(connection, [parametr1]);
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
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
                var models = ((IInt64SingleTypebigint)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintE0M), typeof(FlatInt64bigintE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
Gedaq.MySqlConnector.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            parametrName: "id",
            methodParametrName: "id",
            dbType: (MySqlConnector.MySqlDbType)(3))]
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
FROM gedaqtests.int64biginte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigintE0M>();
                var models2 = new List<FlatInt64bigintE0M>();
                await((IInt64SingleTypebigint)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
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
FROM gedaqtests.int64biginte0m m
WHERE 
    m.id > @id
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

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
Gedaq.MySqlConnector.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            parametrName: "id",
            methodParametrName: "id",
            dbType: (MySqlConnector.MySqlDbType)(3))]
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
FROM gedaqtests.int64biginte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IInt64SingleTypebigint)this).DynQuerySelectModelAsync(connection,  query, 0);
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
FROM gedaqtests.int64biginte0m m
WHERE 
    m.id > @id
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

[Gedaq.MySqlConnector.Attributes.Query(
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
FROM gedaqtests.int64biginte0m m
LEFT JOIN gedaqtests.int64bigint0mi mi ON mi.id = m.int64bigint0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            sourceType: SourceType.MySqlConnection,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Int64bigintE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
Gedaq.MySqlConnector.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            parametrName: "id",
            methodParametrName: "id",
            dbType: (MySqlConnector.MySqlDbType)(3))]
        private void SelectModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task SelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await((IInt64SingleTypebigint)this).SelectModelAsync(connection, 0);
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
FROM gedaqtests.int64biginte0m m
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
                parametr1.Value = 59;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 91;
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
FROM gedaqtests.int64biginte0m m
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
FROM gedaqtests.int64biginte0m m
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
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatInt64bigintE0M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatInt64bigintE0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[13],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 102;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 64;
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
FROM gedaqtests.int64biginte0m m
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
FROM gedaqtests.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintE0M>();
                var firstItems2 = new List<FlatInt64bigintE0M>();
                var secondItems1 = new List<FlatInt64bigintE0M>();
                await ((IInt64SingleTypebigint)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatInt64bigintE0M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[10],_testData[34], false);
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
FROM gedaqtests.int64biginte0m m
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
                parametr1.Value = 102;
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
FROM gedaqtests.int64biginte0m m
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
FROM gedaqtests.int64biginte0m m
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
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatInt64bigintE0M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatInt64bigintE0M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[6],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 112;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 61;
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
FROM gedaqtests.int64biginte0m m
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
FROM gedaqtests.int64biginte0m m
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
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatInt64bigintE0M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[23],_testData[34], false);
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
FROM gedaqtests.int64biginte0m m
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
                parametr1.Value = 121;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 56;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.int64biginte0m m
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
FROM gedaqtests.int64biginte0m m
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
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatInt64bigintE0M.AssertModel(models[0],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(models[1],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(models[2],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(models[3],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(models[4],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(models[5],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatInt64bigintE0M.AssertModel(models[0],_testData[9], false);
                        FlatInt64bigintE0M.AssertModel(models[1],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(models[2],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(models[3],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(models[4],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(models[5],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(models[6],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(models[7],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(models[8],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(models[9],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(models[10],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(models[11],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(models[12],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(models[13],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(models[14],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(models[15],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(models[16],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(models[17],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(models[18],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(models[19],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(models[20],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(models[21],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(models[22],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(models[23],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(models[24],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(models[25],_testData[34], false);
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
                parametr1.Value = 23;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 87;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.int64biginte0m m
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
FROM gedaqtests.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintE0M>();
                var secondItems1 = new List<FlatInt64bigintE0M>();
                var secondItems2 = new List<FlatInt64bigintE0M>();
                await ((IInt64SingleTypebigint)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                        FlatInt64bigintE0M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatInt64bigintE0M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[15],_testData[34], false);
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
FROM gedaqtests.int64biginte0m m
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
                parametr1.Value = 137;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 12;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.int64biginte0m m
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
FROM gedaqtests.int64biginte0m m
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
                parametr2.Value = 97;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.int64biginte0m m
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
FROM gedaqtests.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintE0M>();
                var secondItems1 = new List<FlatInt64bigintE0M>();
                var secondItems2 = new List<FlatInt64bigintE0M>();
                 ((IInt64SingleTypebigint)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatInt64bigintE0M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[24],_testData[34], false);
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
FROM gedaqtests.int64biginte0m m
LEFT JOIN gedaqtests.int64bigint0mi mi ON mi.id = m.int64bigint0mi_id
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
                parametr1.Value = 101;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 138;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64SingleTypebigint)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        Int64bigintE0M.AssertModel(models[0],_testData[23], false);
                        Int64bigintE0M.AssertModel(models[1],_testData[24], false);
                        Int64bigintE0M.AssertModel(models[2],_testData[25], false);
                        Int64bigintE0M.AssertModel(models[3],_testData[26], false);
                        Int64bigintE0M.AssertModel(models[4],_testData[27], false);
                        Int64bigintE0M.AssertModel(models[5],_testData[28], false);
                        Int64bigintE0M.AssertModel(models[6],_testData[29], false);
                        Int64bigintE0M.AssertModel(models[7],_testData[30], false);
                        Int64bigintE0M.AssertModel(models[8],_testData[31], false);
                        Int64bigintE0M.AssertModel(models[9],_testData[32], false);
                        Int64bigintE0M.AssertModel(models[10],_testData[33], false);
                        Int64bigintE0M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        Int64bigintE0M.AssertModel(models[0],_testData[32], false);
                        Int64bigintE0M.AssertModel(models[1],_testData[33], false);
                        Int64bigintE0M.AssertModel(models[2],_testData[34], false);
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
                parametr1.Value = 7;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 64;
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
FROM gedaqtests.int64biginte0m m
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
FROM gedaqtests.int64biginte0m m
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
FROM gedaqtests.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintE0M>();
                var firstItems2 = new List<FlatInt64bigintE0M>();
                var secondItems1 = new List<FlatInt64bigintE0M>();
                var secondItems2 = new List<FlatInt64bigintE0M>();
                await ((IInt64SingleTypebigint)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 105, query1, 47, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatInt64bigintE0M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatInt64bigintE0M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[26],_testData[34], false);
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
FROM gedaqtests.int64biginte0m m
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
FROM gedaqtests.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintE0M>();
                var firstItems2 = new List<FlatInt64bigintE0M>();
                var secondItems1 = new List<FlatInt64bigintE0M>();
                await ((IInt64SingleTypebigint)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 86, query1, 102, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatInt64bigintE0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[10],_testData[34], false);
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
FROM gedaqtests.int64biginte0m m
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
FROM gedaqtests.int64biginte0m m
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
FROM gedaqtests.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintE0M>();
                var firstItems2 = new List<FlatInt64bigintE0M>();
                var secondItems1 = new List<FlatInt64bigintE0M>();
                var secondItems2 = new List<FlatInt64bigintE0M>();
                 ((IInt64SingleTypebigint)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 76, query1, 138, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatInt64bigintE0M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatInt64bigintE0M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[2],_testData[34], false);
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
FROM gedaqtests.int64biginte0m m
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
FROM gedaqtests.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintE0M>();
                var firstItems2 = new List<FlatInt64bigintE0M>();
                var secondItems1 = new List<FlatInt64bigintE0M>();
                 ((IInt64SingleTypebigint)this).DbConnectionMMDynQuerySelectModelBatch(connection, 47, query1, 97, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatInt64bigintE0M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatInt64bigintE0M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[12],_testData[34], false);
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
FROM gedaqtests.int64biginte0m m
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
FROM gedaqtests.int64biginte0m m
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
FROM gedaqtests.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64SingleTypebigint)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 23, query1, 131, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatInt64bigintE0M.AssertModel(models[0],_testData[4], false);
                        FlatInt64bigintE0M.AssertModel(models[1],_testData[5], false);
                        FlatInt64bigintE0M.AssertModel(models[2],_testData[6], false);
                        FlatInt64bigintE0M.AssertModel(models[3],_testData[7], false);
                        FlatInt64bigintE0M.AssertModel(models[4],_testData[8], false);
                        FlatInt64bigintE0M.AssertModel(models[5],_testData[9], false);
                        FlatInt64bigintE0M.AssertModel(models[6],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(models[7],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(models[8],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(models[9],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(models[10],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(models[11],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(models[12],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(models[13],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(models[14],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(models[15],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(models[16],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(models[17],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(models[18],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(models[19],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(models[20],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(models[21],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(models[22],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(models[23],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(models[24],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(models[25],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(models[26],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(models[27],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(models[28],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(models[29],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatInt64bigintE0M.AssertModel(models[0],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(models[1],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(models[2],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(models[3],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(models[4],_testData[34], false);
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
FROM gedaqtests.int64biginte0m m
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
FROM gedaqtests.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintE0M>();
                var secondItems1 = new List<FlatInt64bigintE0M>();
                var secondItems2 = new List<FlatInt64bigintE0M>();
                await ((IInt64SingleTypebigint)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 12, query1, 123, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                        FlatInt64bigintE0M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatInt64bigintE0M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[5],_testData[34], false);
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
FROM gedaqtests.int64biginte0m m
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
FROM gedaqtests.int64biginte0m m
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
FROM gedaqtests.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64SingleTypebigint)this).DbConnectionSTDynQuerySelectModelBatch(connection, 131, query1, 12, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatInt64bigintE0M.AssertModel(models[0],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(models[1],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(models[2],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(models[3],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(models[4],_testData[34], false);
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
FROM gedaqtests.int64biginte0m m
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
FROM gedaqtests.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintE0M>();
                var secondItems1 = new List<FlatInt64bigintE0M>();
                var secondItems2 = new List<FlatInt64bigintE0M>();
                 ((IInt64SingleTypebigint)this).DbConnectionDynQuerySelectModelBatch(connection, 12, query1, 27, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                        FlatInt64bigintE0M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatInt64bigintE0M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[29],_testData[34], false);
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
FROM gedaqtests.int64biginte0m m
LEFT JOIN gedaqtests.int64bigint0mi mi ON mi.id = m.int64bigint0mi_id
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
                foreach(var batchResult in await ((IInt64SingleTypebigint)this).DbConnectionSTSelectModelBatchAsync(connection, 23, 47))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        Int64bigintE0M.AssertModel(models[0],_testData[4], false);
                        Int64bigintE0M.AssertModel(models[1],_testData[5], false);
                        Int64bigintE0M.AssertModel(models[2],_testData[6], false);
                        Int64bigintE0M.AssertModel(models[3],_testData[7], false);
                        Int64bigintE0M.AssertModel(models[4],_testData[8], false);
                        Int64bigintE0M.AssertModel(models[5],_testData[9], false);
                        Int64bigintE0M.AssertModel(models[6],_testData[10], false);
                        Int64bigintE0M.AssertModel(models[7],_testData[11], false);
                        Int64bigintE0M.AssertModel(models[8],_testData[12], false);
                        Int64bigintE0M.AssertModel(models[9],_testData[13], false);
                        Int64bigintE0M.AssertModel(models[10],_testData[14], false);
                        Int64bigintE0M.AssertModel(models[11],_testData[15], false);
                        Int64bigintE0M.AssertModel(models[12],_testData[16], false);
                        Int64bigintE0M.AssertModel(models[13],_testData[17], false);
                        Int64bigintE0M.AssertModel(models[14],_testData[18], false);
                        Int64bigintE0M.AssertModel(models[15],_testData[19], false);
                        Int64bigintE0M.AssertModel(models[16],_testData[20], false);
                        Int64bigintE0M.AssertModel(models[17],_testData[21], false);
                        Int64bigintE0M.AssertModel(models[18],_testData[22], false);
                        Int64bigintE0M.AssertModel(models[19],_testData[23], false);
                        Int64bigintE0M.AssertModel(models[20],_testData[24], false);
                        Int64bigintE0M.AssertModel(models[21],_testData[25], false);
                        Int64bigintE0M.AssertModel(models[22],_testData[26], false);
                        Int64bigintE0M.AssertModel(models[23],_testData[27], false);
                        Int64bigintE0M.AssertModel(models[24],_testData[28], false);
                        Int64bigintE0M.AssertModel(models[25],_testData[29], false);
                        Int64bigintE0M.AssertModel(models[26],_testData[30], false);
                        Int64bigintE0M.AssertModel(models[27],_testData[31], false);
                        Int64bigintE0M.AssertModel(models[28],_testData[32], false);
                        Int64bigintE0M.AssertModel(models[29],_testData[33], false);
                        Int64bigintE0M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        Int64bigintE0M.AssertModel(models[0],_testData[8], false);
                        Int64bigintE0M.AssertModel(models[1],_testData[9], false);
                        Int64bigintE0M.AssertModel(models[2],_testData[10], false);
                        Int64bigintE0M.AssertModel(models[3],_testData[11], false);
                        Int64bigintE0M.AssertModel(models[4],_testData[12], false);
                        Int64bigintE0M.AssertModel(models[5],_testData[13], false);
                        Int64bigintE0M.AssertModel(models[6],_testData[14], false);
                        Int64bigintE0M.AssertModel(models[7],_testData[15], false);
                        Int64bigintE0M.AssertModel(models[8],_testData[16], false);
                        Int64bigintE0M.AssertModel(models[9],_testData[17], false);
                        Int64bigintE0M.AssertModel(models[10],_testData[18], false);
                        Int64bigintE0M.AssertModel(models[11],_testData[19], false);
                        Int64bigintE0M.AssertModel(models[12],_testData[20], false);
                        Int64bigintE0M.AssertModel(models[13],_testData[21], false);
                        Int64bigintE0M.AssertModel(models[14],_testData[22], false);
                        Int64bigintE0M.AssertModel(models[15],_testData[23], false);
                        Int64bigintE0M.AssertModel(models[16],_testData[24], false);
                        Int64bigintE0M.AssertModel(models[17],_testData[25], false);
                        Int64bigintE0M.AssertModel(models[18],_testData[26], false);
                        Int64bigintE0M.AssertModel(models[19],_testData[27], false);
                        Int64bigintE0M.AssertModel(models[20],_testData[28], false);
                        Int64bigintE0M.AssertModel(models[21],_testData[29], false);
                        Int64bigintE0M.AssertModel(models[22],_testData[30], false);
                        Int64bigintE0M.AssertModel(models[23],_testData[31], false);
                        Int64bigintE0M.AssertModel(models[24],_testData[32], false);
                        Int64bigintE0M.AssertModel(models[25],_testData[33], false);
                        Int64bigintE0M.AssertModel(models[26],_testData[34], false);
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
                foreach(var batchResult in  ((IInt64SingleTypebigint)this).DbConnectionSTSelectModelBatch(connection, 64, 76))
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
                        Assert.That(models, Has.Count.EqualTo(19));

                        Int64bigintE0M.AssertModel(models[0],_testData[16], false);
                        Int64bigintE0M.AssertModel(models[1],_testData[17], false);
                        Int64bigintE0M.AssertModel(models[2],_testData[18], false);
                        Int64bigintE0M.AssertModel(models[3],_testData[19], false);
                        Int64bigintE0M.AssertModel(models[4],_testData[20], false);
                        Int64bigintE0M.AssertModel(models[5],_testData[21], false);
                        Int64bigintE0M.AssertModel(models[6],_testData[22], false);
                        Int64bigintE0M.AssertModel(models[7],_testData[23], false);
                        Int64bigintE0M.AssertModel(models[8],_testData[24], false);
                        Int64bigintE0M.AssertModel(models[9],_testData[25], false);
                        Int64bigintE0M.AssertModel(models[10],_testData[26], false);
                        Int64bigintE0M.AssertModel(models[11],_testData[27], false);
                        Int64bigintE0M.AssertModel(models[12],_testData[28], false);
                        Int64bigintE0M.AssertModel(models[13],_testData[29], false);
                        Int64bigintE0M.AssertModel(models[14],_testData[30], false);
                        Int64bigintE0M.AssertModel(models[15],_testData[31], false);
                        Int64bigintE0M.AssertModel(models[16],_testData[32], false);
                        Int64bigintE0M.AssertModel(models[17],_testData[33], false);
                        Int64bigintE0M.AssertModel(models[18],_testData[34], false);
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
                ((IInt64SingleTypebigint)this).SetDbConnectionSelectModelParametrs(cmd, 56);
                var models = await ((IInt64SingleTypebigint)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(26));

                Int64bigintE0M.AssertModel(models[0],_testData[9], false);
                Int64bigintE0M.AssertModel(models[1],_testData[10], false);
                Int64bigintE0M.AssertModel(models[2],_testData[11], false);
                Int64bigintE0M.AssertModel(models[3],_testData[12], false);
                Int64bigintE0M.AssertModel(models[4],_testData[13], false);
                Int64bigintE0M.AssertModel(models[5],_testData[14], false);
                Int64bigintE0M.AssertModel(models[6],_testData[15], false);
                Int64bigintE0M.AssertModel(models[7],_testData[16], false);
                Int64bigintE0M.AssertModel(models[8],_testData[17], false);
                Int64bigintE0M.AssertModel(models[9],_testData[18], false);
                Int64bigintE0M.AssertModel(models[10],_testData[19], false);
                Int64bigintE0M.AssertModel(models[11],_testData[20], false);
                Int64bigintE0M.AssertModel(models[12],_testData[21], false);
                Int64bigintE0M.AssertModel(models[13],_testData[22], false);
                Int64bigintE0M.AssertModel(models[14],_testData[23], false);
                Int64bigintE0M.AssertModel(models[15],_testData[24], false);
                Int64bigintE0M.AssertModel(models[16],_testData[25], false);
                Int64bigintE0M.AssertModel(models[17],_testData[26], false);
                Int64bigintE0M.AssertModel(models[18],_testData[27], false);
                Int64bigintE0M.AssertModel(models[19],_testData[28], false);
                Int64bigintE0M.AssertModel(models[20],_testData[29], false);
                Int64bigintE0M.AssertModel(models[21],_testData[30], false);
                Int64bigintE0M.AssertModel(models[22],_testData[31], false);
                Int64bigintE0M.AssertModel(models[23],_testData[32], false);
                Int64bigintE0M.AssertModel(models[24],_testData[33], false);
                Int64bigintE0M.AssertModel(models[25],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt64SingleTypebigint)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt64SingleTypebigint)this).SetDbConnectionSelectModelParametrs(cmd, 117);
                var models =  ((IInt64SingleTypebigint)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(8));

                Int64bigintE0M.AssertModel(models[0],_testData[27], false);
                Int64bigintE0M.AssertModel(models[1],_testData[28], false);
                Int64bigintE0M.AssertModel(models[2],_testData[29], false);
                Int64bigintE0M.AssertModel(models[3],_testData[30], false);
                Int64bigintE0M.AssertModel(models[4],_testData[31], false);
                Int64bigintE0M.AssertModel(models[5],_testData[32], false);
                Int64bigintE0M.AssertModel(models[6],_testData[33], false);
                Int64bigintE0M.AssertModel(models[7],_testData[34], false);
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
FROM gedaqtests.int64biginte0m m
LEFT JOIN gedaqtests.int64bigint0mi mi ON mi.id = m.int64bigint0mi_id
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
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3983765199643509471L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((5801987086351438589L)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7686042652671994489L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((1352924275559734196L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((4005576914691605632L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((7017010975639648052L)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5088685696844049267L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1454313183870181295L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((2629587646910981666L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((8550704035343143994L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((648893604106672188L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8706075128481973011L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((3485397051010203387L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((1314183442217581848L)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((443836946488590623L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5998972216521197564L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((8164162254246874723L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((8677301972797730246L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((2414691135252297322L)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5427932202219494747L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((1393152616880191285L)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6265755769433776278L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((5511436292802620608L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((2933719072496906364L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8042977191518111060L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((8396467863979867688L)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4705176345021312784L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((5130046379073567934L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((7080719232976782761L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6083085449772470450L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((92309942685774197L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((38)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((5130158776437686967L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((74)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1779393608894550107L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2232778158237150558L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((3907023508115680675L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((78)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6817059459550013179L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2993257108331721880L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((2046844924613247676L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1799812121965997998L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3418438036155252741L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((7006653173332399946L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((4820793817178993164L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((4086567262746624635L)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3926276758459441223L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((9217306888055261170L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((3813149013513881082L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((8062145088970535954L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((6428567978714570878L)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((9018911593741207693L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((510352308768671032L)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4059947343363499743L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((2388538382912864411L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((3579570350232047189L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((5001782942094315551L)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7532662960307817188L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2743935710047640975L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((4182627191549302768L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((3967097968315150391L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((7225148486152636339L)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4609599083762700181L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6903213719038711785L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((9098815185933107463L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((1330369141081765640L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6188146194982989741L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8872526421770528106L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((77)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((1260228388161586485L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((2740933659259375644L)));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((930534258193745304L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5452109039898786163L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((78)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((2407241578978158721L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((3249305762334388391L)));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1503733464003809217L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((151073102342592062L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((86)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((8888014898211702711L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8309711562322904669L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((2209504896410133189L)));

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
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3983765199643509471L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((5801987086351438589L)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7686042652671994489L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((1352924275559734196L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((4005576914691605632L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((7017010975639648052L)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5088685696844049267L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1454313183870181295L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((2629587646910981666L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((8550704035343143994L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((648893604106672188L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8706075128481973011L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((3485397051010203387L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((1314183442217581848L)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((443836946488590623L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5998972216521197564L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((8164162254246874723L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((8677301972797730246L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((2414691135252297322L)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5427932202219494747L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((1393152616880191285L)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6265755769433776278L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((5511436292802620608L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((2933719072496906364L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8042977191518111060L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((8396467863979867688L)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4705176345021312784L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((5130046379073567934L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((7080719232976782761L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6083085449772470450L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((92309942685774197L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((38)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((5130158776437686967L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((74)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1779393608894550107L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2232778158237150558L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((3907023508115680675L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((78)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6817059459550013179L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2993257108331721880L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((2046844924613247676L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1799812121965997998L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3418438036155252741L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((7006653173332399946L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((4820793817178993164L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((4086567262746624635L)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3926276758459441223L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((9217306888055261170L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((3813149013513881082L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((8062145088970535954L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((6428567978714570878L)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((9018911593741207693L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((510352308768671032L)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4059947343363499743L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((2388538382912864411L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((3579570350232047189L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((5001782942094315551L)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7532662960307817188L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2743935710047640975L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((4182627191549302768L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((3967097968315150391L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((7225148486152636339L)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4609599083762700181L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6903213719038711785L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((9098815185933107463L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((1330369141081765640L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6188146194982989741L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8872526421770528106L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((77)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((1260228388161586485L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((2740933659259375644L)));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((930534258193745304L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5452109039898786163L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((78)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((2407241578978158721L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((3249305762334388391L)));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1503733464003809217L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((151073102342592062L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((86)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((8888014898211702711L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8309711562322904669L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((2209504896410133189L)));

            }
        }

#endregion

    }
}

