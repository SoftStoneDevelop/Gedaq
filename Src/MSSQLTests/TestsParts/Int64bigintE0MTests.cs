

using Microsoft.Data.SqlClient;
using Gedaq.Common.Enums;
using Gedaq.SqlClient.Attributes;
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
    Id = 5,
    Value = 265914000902444008L,
    ModelInner = null,
    NullableValue = 9212053083639669278L,
},
            new Int64bigintE0M
{
    Id = 11,
    Value = 3637463736201522467L,
    ModelInner = new Int64bigintE0MI
{
    Id = 1,
    Value = 5407576066878188036L,
    NullableValue = null,
},
    NullableValue = 4364958881764086390L,
},
            new Int64bigintE0M
{
    Id = 15,
    Value = 2422271735745887337L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 20,
    Value = 1938226039351292762L,
    ModelInner = new Int64bigintE0MI
{
    Id = 7,
    Value = 1251387953415652979L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 28,
    Value = 5311647584294953864L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 30,
    Value = 5514256407083545809L,
    ModelInner = new Int64bigintE0MI
{
    Id = 13,
    Value = 436598767908833937L,
    NullableValue = null,
},
    NullableValue = 5428249373296178858L,
},
            new Int64bigintE0M
{
    Id = 37,
    Value = 185351419456123095L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 45,
    Value = 8967629704437414498L,
    ModelInner = new Int64bigintE0MI
{
    Id = 19,
    Value = 3056540990195006776L,
    NullableValue = 2467143881712670799L,
},
    NullableValue = 3041056394017179773L,
},
            new Int64bigintE0M
{
    Id = 54,
    Value = 8666314229607983576L,
    ModelInner = null,
    NullableValue = 338998683773833880L,
},
            new Int64bigintE0M
{
    Id = 60,
    Value = 7711278091330891762L,
    ModelInner = new Int64bigintE0MI
{
    Id = 24,
    Value = 198640437327496606L,
    NullableValue = 7260641658873418950L,
},
    NullableValue = 3460789464413843384L,
},
            new Int64bigintE0M
{
    Id = 68,
    Value = 4291468842055729389L,
    ModelInner = null,
    NullableValue = 2926066886854794187L,
},
            new Int64bigintE0M
{
    Id = 77,
    Value = 5721806669328516876L,
    ModelInner = new Int64bigintE0MI
{
    Id = 26,
    Value = 162568886754469333L,
    NullableValue = 2102938840796740101L,
},
    NullableValue = 6485574357652587074L,
},
            new Int64bigintE0M
{
    Id = 81,
    Value = 1345522161848678044L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 82,
    Value = 4723682807842874029L,
    ModelInner = new Int64bigintE0MI
{
    Id = 32,
    Value = 5389613152128894816L,
    NullableValue = null,
},
    NullableValue = 7681701467878648084L,
},
            new Int64bigintE0M
{
    Id = 87,
    Value = 2390117072436365172L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 91,
    Value = 2457483422881439913L,
    ModelInner = new Int64bigintE0MI
{
    Id = 33,
    Value = 3364607950825969649L,
    NullableValue = null,
},
    NullableValue = 7652162639824898624L,
},
            new Int64bigintE0M
{
    Id = 100,
    Value = 6028940238833776482L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 109,
    Value = 7822713030227089583L,
    ModelInner = new Int64bigintE0MI
{
    Id = 37,
    Value = 8806719276878657718L,
    NullableValue = 5465851353480898955L,
},
    NullableValue = 874856935594664136L,
},
            new Int64bigintE0M
{
    Id = 113,
    Value = 8395423729912611734L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 121,
    Value = 8321141970469200328L,
    ModelInner = new Int64bigintE0MI
{
    Id = 40,
    Value = 5685455240184933440L,
    NullableValue = 7491051602110945096L,
},
    NullableValue = 7267772326530615784L,
},
            new Int64bigintE0M
{
    Id = 126,
    Value = 127332797252553624L,
    ModelInner = null,
    NullableValue = 158164052759431932L,
},
            new Int64bigintE0M
{
    Id = 132,
    Value = 8026938184029487496L,
    ModelInner = new Int64bigintE0MI
{
    Id = 46,
    Value = 3755449580869765488L,
    NullableValue = null,
},
    NullableValue = 3773622631738560134L,
},
            new Int64bigintE0M
{
    Id = 136,
    Value = 2919092959736654308L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 137,
    Value = 5162107507582312892L,
    ModelInner = new Int64bigintE0MI
{
    Id = 52,
    Value = 4101942058588724237L,
    NullableValue = 2284959990903228989L,
},
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 140,
    Value = 3509906363350572125L,
    ModelInner = null,
    NullableValue = 5868460787254392330L,
},
            new Int64bigintE0M
{
    Id = 145,
    Value = 2385033212714255381L,
    ModelInner = new Int64bigintE0MI
{
    Id = 59,
    Value = 8782035320494113011L,
    NullableValue = 6279135926036757724L,
},
    NullableValue = 3042715135916411443L,
},
            new Int64bigintE0M
{
    Id = 147,
    Value = 2705030207364670019L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 150,
    Value = 7815198039541154375L,
    ModelInner = new Int64bigintE0MI
{
    Id = 68,
    Value = 2420690269859880702L,
    NullableValue = 6170861911582519250L,
},
    NullableValue = 903021815634148108L,
},
            new Int64bigintE0M
{
    Id = 155,
    Value = 5368853671257893109L,
    ModelInner = null,
    NullableValue = 750688682461120036L,
},
            new Int64bigintE0M
{
    Id = 157,
    Value = 5540721446388493776L,
    ModelInner = new Int64bigintE0MI
{
    Id = 74,
    Value = 5859307537047112393L,
    NullableValue = null,
},
    NullableValue = 4325961261868456522L,
},
            new Int64bigintE0M
{
    Id = 160,
    Value = 7863717866398117903L,
    ModelInner = null,
    NullableValue = 8168342752265788119L,
},
            new Int64bigintE0M
{
    Id = 166,
    Value = 1440814248230224736L,
    ModelInner = new Int64bigintE0MI
{
    Id = 77,
    Value = 8059479790709750792L,
    NullableValue = 7907659802319267083L,
},
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 167,
    Value = 5502564015939597059L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 169,
    Value = 3896902241401746538L,
    ModelInner = new Int64bigintE0MI
{
    Id = 83,
    Value = 5172526630273105944L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 170,
    Value = 8114413755292912014L,
    ModelInner = null,
    NullableValue = 5116237175628460543L,
},
        };

#endregion

#region InsertModelInner

[Gedaq.SqlClient.Attributes.Query(
            query: @"
INSERT INTO dbo.int64biginte0mi(
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
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)), 
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                parametrName: "id",
                methodParametrName: "id", 
                dbType: (System.Data.SqlDbType)(8)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int64),
                parametrName: "value",
                methodParametrName: "value",
                dbType: (System.Data.SqlDbType)(0)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int64?), 
                parametrName: "nullablevalue",
                methodParametrName: "nullablevalue",
                dbType: (System.Data.SqlDbType)(0))
            ]
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
INSERT INTO dbo.int64biginte0mi(
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
                dbType: (System.Data.DbType)11),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int64), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)12),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int64?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)12, 
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

[Gedaq.SqlClient.Attributes.Query(
            query: @"
INSERT INTO dbo.int64biginte0m(
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
            methodName:"InsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                parametrName: "id",
                methodParametrName: "id",
                dbType: (System.Data.SqlDbType)(8)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int64), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.SqlDbType)(0)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int64?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.SqlDbType)(0),
                nullable: true),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "int64biginte0mi_id", 
                methodParametrName: "int64biginte0mi_id", 
                dbType: (System.Data.SqlDbType)(8),
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
INSERT INTO dbo.int64biginte0m(
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
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)11),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int64), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)12),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int64?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)12,
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "int64biginte0mi_id", 
                methodParametrName: "int64biginte0mi_id", 
                dbType: (System.Data.DbType)11,
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

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintE0M), typeof(FlatInt64bigintE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
Gedaq.SqlClient.Attributes.DynamicParametr()]
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
FROM dbo.int64biginte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
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
FROM dbo.int64biginte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
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

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
Gedaq.SqlClient.Attributes.DynamicParametr()]
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
FROM dbo.int64biginte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
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
FROM dbo.int64biginte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models = ((IInt64SingleTypebigint)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
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
FROM dbo.int64biginte0m m
LEFT JOIN dbo.int64biginte0mi mi ON mi.id = m.int64biginte0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Int64bigintE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
Gedaq.SqlClient.Attributes.DynamicParametr()]
        private void SelectModelDynParConfig()
        {
        }

        [Test, Order(2)]
        public async Task SelectModelDynParTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
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
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models = ((IInt64SingleTypebigint)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintE0M), typeof(FlatInt64bigintE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
Gedaq.SqlClient.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            parametrName: "id",
            methodParametrName: "id",
            dbType: (System.Data.SqlDbType)(8))]
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
FROM dbo.int64biginte0m m
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
FROM dbo.int64biginte0m m
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

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
Gedaq.SqlClient.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            parametrName: "id",
            methodParametrName: "id",
            dbType: (System.Data.SqlDbType)(8))]
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
FROM dbo.int64biginte0m m
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
FROM dbo.int64biginte0m m
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

[Gedaq.SqlClient.Attributes.Query(
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
FROM dbo.int64biginte0m m
LEFT JOIN dbo.int64biginte0mi mi ON mi.id = m.int64biginte0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Int64bigintE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
Gedaq.SqlClient.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            parametrName: "id",
            methodParametrName: "id",
            dbType: (System.Data.SqlDbType)(8))]
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
FROM dbo.int64biginte0m m
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
                parametr1.Value = 54;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 15;
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
FROM dbo.int64biginte0m m
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
FROM dbo.int64biginte0m m
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
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatInt64bigintE0M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatInt64bigintE0M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[31],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 109;
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
FROM dbo.int64biginte0m m
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
FROM dbo.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintE0M>();
                var firstItems2 = new List<FlatInt64bigintE0M>();
                var secondItems1 = new List<FlatInt64bigintE0M>();
                await ((IInt64SingleTypebigint)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatInt64bigintE0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[27],_testData[34], false);
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
FROM dbo.int64biginte0m m
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
                parametr1.Value = 11;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 167;
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
FROM dbo.int64biginte0m m
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
FROM dbo.int64biginte0m m
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
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatInt64bigintE0M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatInt64bigintE0M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[1],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 77;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 145;
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
FROM dbo.int64biginte0m m
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
FROM dbo.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintE0M>();
                var firstItems2 = new List<FlatInt64bigintE0M>();
                var secondItems1 = new List<FlatInt64bigintE0M>();
                 ((IInt64SingleTypebigint)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatInt64bigintE0M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[8],_testData[34], false);
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
FROM dbo.int64biginte0m m
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
                parametr1.Value = 5;
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
FROM dbo.int64biginte0m m
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
FROM dbo.int64biginte0m m
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
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatInt64bigintE0M.AssertModel(models[0],_testData[1], false);
                        FlatInt64bigintE0M.AssertModel(models[1],_testData[2], false);
                        FlatInt64bigintE0M.AssertModel(models[2],_testData[3], false);
                        FlatInt64bigintE0M.AssertModel(models[3],_testData[4], false);
                        FlatInt64bigintE0M.AssertModel(models[4],_testData[5], false);
                        FlatInt64bigintE0M.AssertModel(models[5],_testData[6], false);
                        FlatInt64bigintE0M.AssertModel(models[6],_testData[7], false);
                        FlatInt64bigintE0M.AssertModel(models[7],_testData[8], false);
                        FlatInt64bigintE0M.AssertModel(models[8],_testData[9], false);
                        FlatInt64bigintE0M.AssertModel(models[9],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(models[10],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(models[11],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(models[12],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(models[13],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(models[14],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(models[15],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(models[16],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(models[17],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(models[18],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(models[19],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(models[20],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(models[21],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(models[22],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(models[23],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(models[24],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(models[25],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(models[26],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(models[27],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(models[28],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(models[29],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(models[30],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(models[31],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(models[32],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatInt64bigintE0M.AssertModel(models[0],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(models[1],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(models[2],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(models[3],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(models[4],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(models[5],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(models[6],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(models[7],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(models[8],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(models[9],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(models[10],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(models[11],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(models[12],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(models[13],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(models[14],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(models[15],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(models[16],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(models[17],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(models[18],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(models[19],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(models[20],_testData[34], false);
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
                parametr1.Value = 167;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 81;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.int64biginte0m m
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
FROM dbo.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintE0M>();
                var secondItems1 = new List<FlatInt64bigintE0M>();
                var secondItems2 = new List<FlatInt64bigintE0M>();
                await ((IInt64SingleTypebigint)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatInt64bigintE0M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatInt64bigintE0M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[21],_testData[34], false);
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
FROM dbo.int64biginte0m m
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
                parametr1.Value = 132;
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
FROM dbo.int64biginte0m m
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
FROM dbo.int64biginte0m m
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
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatInt64bigintE0M.AssertModel(models[0],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(models[1],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(models[2],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(models[3],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(models[4],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(models[5],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(models[6],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(models[7],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(models[8],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(models[9],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(models[10],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(models[11],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatInt64bigintE0M.AssertModel(models[0],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(models[1],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(models[2],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(models[3],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(models[4],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(models[5],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(models[6],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(models[7],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(models[8],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(models[9],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(models[10],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(models[11],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(models[12],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(models[13],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(models[14],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(models[15],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(models[16],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(models[17],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(models[18],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(models[19],_testData[34], false);
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
                parametr1.Value = 155;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 5;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.int64biginte0m m
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
FROM dbo.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintE0M>();
                var secondItems1 = new List<FlatInt64bigintE0M>();
                var secondItems2 = new List<FlatInt64bigintE0M>();
                 ((IInt64SingleTypebigint)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatInt64bigintE0M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatInt64bigintE0M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[33],_testData[34], false);
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
FROM dbo.int64biginte0m m
LEFT JOIN dbo.int64biginte0mi mi ON mi.id = m.int64biginte0mi_id
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
                parametr1.Value = 136;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 113;
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
                        Assert.That(models, Has.Count.EqualTo(16));

                        Int64bigintE0M.AssertModel(models[0],_testData[19], false);
                        Int64bigintE0M.AssertModel(models[1],_testData[20], false);
                        Int64bigintE0M.AssertModel(models[2],_testData[21], false);
                        Int64bigintE0M.AssertModel(models[3],_testData[22], false);
                        Int64bigintE0M.AssertModel(models[4],_testData[23], false);
                        Int64bigintE0M.AssertModel(models[5],_testData[24], false);
                        Int64bigintE0M.AssertModel(models[6],_testData[25], false);
                        Int64bigintE0M.AssertModel(models[7],_testData[26], false);
                        Int64bigintE0M.AssertModel(models[8],_testData[27], false);
                        Int64bigintE0M.AssertModel(models[9],_testData[28], false);
                        Int64bigintE0M.AssertModel(models[10],_testData[29], false);
                        Int64bigintE0M.AssertModel(models[11],_testData[30], false);
                        Int64bigintE0M.AssertModel(models[12],_testData[31], false);
                        Int64bigintE0M.AssertModel(models[13],_testData[32], false);
                        Int64bigintE0M.AssertModel(models[14],_testData[33], false);
                        Int64bigintE0M.AssertModel(models[15],_testData[34], false);
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
                parametr1.Value = 11;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 45;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64SingleTypebigint)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
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
            dbType: (System.Data.DbType)11)]
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
FROM dbo.int64biginte0m m
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
FROM dbo.int64biginte0m m
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
FROM dbo.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintE0M>();
                var firstItems2 = new List<FlatInt64bigintE0M>();
                var secondItems1 = new List<FlatInt64bigintE0M>();
                var secondItems2 = new List<FlatInt64bigintE0M>();
                await ((IInt64SingleTypebigint)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 147, query1, 60, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatInt64bigintE0M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatInt64bigintE0M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[24],_testData[34], false);
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
FROM dbo.int64biginte0m m
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
FROM dbo.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintE0M>();
                var firstItems2 = new List<FlatInt64bigintE0M>();
                var secondItems1 = new List<FlatInt64bigintE0M>();
                await ((IInt64SingleTypebigint)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 11, query1, 77, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatInt64bigintE0M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[32],_testData[34], false);
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
FROM dbo.int64biginte0m m
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
FROM dbo.int64biginte0m m
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
FROM dbo.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintE0M>();
                var firstItems2 = new List<FlatInt64bigintE0M>();
                var secondItems1 = new List<FlatInt64bigintE0M>();
                var secondItems2 = new List<FlatInt64bigintE0M>();
                 ((IInt64SingleTypebigint)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 68, query1, 167, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatInt64bigintE0M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatInt64bigintE0M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[1],_testData[34], false);
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
FROM dbo.int64biginte0m m
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
FROM dbo.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintE0M>();
                var firstItems2 = new List<FlatInt64bigintE0M>();
                var secondItems1 = new List<FlatInt64bigintE0M>();
                 ((IInt64SingleTypebigint)this).DbConnectionMMDynQuerySelectModelBatch(connection, 54, query1, 147, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatInt64bigintE0M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatInt64bigintE0M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[7],_testData[34], false);
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
            dbType: (System.Data.DbType)11)]
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
FROM dbo.int64biginte0m m
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
FROM dbo.int64biginte0m m
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
FROM dbo.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64SingleTypebigint)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 20, query1, 28, query2))
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
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatInt64bigintE0M.AssertModel(models[0],_testData[5], false);
                        FlatInt64bigintE0M.AssertModel(models[1],_testData[6], false);
                        FlatInt64bigintE0M.AssertModel(models[2],_testData[7], false);
                        FlatInt64bigintE0M.AssertModel(models[3],_testData[8], false);
                        FlatInt64bigintE0M.AssertModel(models[4],_testData[9], false);
                        FlatInt64bigintE0M.AssertModel(models[5],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(models[6],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(models[7],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(models[8],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(models[9],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(models[10],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(models[11],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(models[12],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(models[13],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(models[14],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(models[15],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(models[16],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(models[17],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(models[18],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(models[19],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(models[20],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(models[21],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(models[22],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(models[23],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(models[24],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(models[25],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(models[26],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(models[27],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(models[28],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(models[29],_testData[34], false);
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
FROM dbo.int64biginte0m m
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
FROM dbo.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintE0M>();
                var secondItems1 = new List<FlatInt64bigintE0M>();
                var secondItems2 = new List<FlatInt64bigintE0M>();
                await ((IInt64SingleTypebigint)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 155, query1, 145, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatInt64bigintE0M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[5],_testData[34], false);
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
FROM dbo.int64biginte0m m
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
FROM dbo.int64biginte0m m
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
FROM dbo.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64SingleTypebigint)this).DbConnectionSTDynQuerySelectModelBatch(connection, 54, query1, 54, query2))
                {
                    if(++resultIndex == 1)
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
FROM dbo.int64biginte0m m
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
FROM dbo.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintE0M>();
                var secondItems1 = new List<FlatInt64bigintE0M>();
                var secondItems2 = new List<FlatInt64bigintE0M>();
                 ((IInt64SingleTypebigint)this).DbConnectionDynQuerySelectModelBatch(connection, 126, query1, 28, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                        FlatInt64bigintE0M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[13],_testData[34], false);
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
FROM dbo.int64biginte0m m
LEFT JOIN dbo.int64biginte0mi mi ON mi.id = m.int64biginte0mi_id
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
            dbType: (System.Data.DbType)11)]
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
                foreach(var batchResult in await ((IInt64SingleTypebigint)this).DbConnectionSTSelectModelBatchAsync(connection, 155, 140))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        Int64bigintE0M.AssertModel(models[0],_testData[29], false);
                        Int64bigintE0M.AssertModel(models[1],_testData[30], false);
                        Int64bigintE0M.AssertModel(models[2],_testData[31], false);
                        Int64bigintE0M.AssertModel(models[3],_testData[32], false);
                        Int64bigintE0M.AssertModel(models[4],_testData[33], false);
                        Int64bigintE0M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        Int64bigintE0M.AssertModel(models[0],_testData[25], false);
                        Int64bigintE0M.AssertModel(models[1],_testData[26], false);
                        Int64bigintE0M.AssertModel(models[2],_testData[27], false);
                        Int64bigintE0M.AssertModel(models[3],_testData[28], false);
                        Int64bigintE0M.AssertModel(models[4],_testData[29], false);
                        Int64bigintE0M.AssertModel(models[5],_testData[30], false);
                        Int64bigintE0M.AssertModel(models[6],_testData[31], false);
                        Int64bigintE0M.AssertModel(models[7],_testData[32], false);
                        Int64bigintE0M.AssertModel(models[8],_testData[33], false);
                        Int64bigintE0M.AssertModel(models[9],_testData[34], false);
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
                foreach(var batchResult in  ((IInt64SingleTypebigint)this).DbConnectionSTSelectModelBatch(connection, 132, 145))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        Int64bigintE0M.AssertModel(models[0],_testData[22], false);
                        Int64bigintE0M.AssertModel(models[1],_testData[23], false);
                        Int64bigintE0M.AssertModel(models[2],_testData[24], false);
                        Int64bigintE0M.AssertModel(models[3],_testData[25], false);
                        Int64bigintE0M.AssertModel(models[4],_testData[26], false);
                        Int64bigintE0M.AssertModel(models[5],_testData[27], false);
                        Int64bigintE0M.AssertModel(models[6],_testData[28], false);
                        Int64bigintE0M.AssertModel(models[7],_testData[29], false);
                        Int64bigintE0M.AssertModel(models[8],_testData[30], false);
                        Int64bigintE0M.AssertModel(models[9],_testData[31], false);
                        Int64bigintE0M.AssertModel(models[10],_testData[32], false);
                        Int64bigintE0M.AssertModel(models[11],_testData[33], false);
                        Int64bigintE0M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        Int64bigintE0M.AssertModel(models[0],_testData[26], false);
                        Int64bigintE0M.AssertModel(models[1],_testData[27], false);
                        Int64bigintE0M.AssertModel(models[2],_testData[28], false);
                        Int64bigintE0M.AssertModel(models[3],_testData[29], false);
                        Int64bigintE0M.AssertModel(models[4],_testData[30], false);
                        Int64bigintE0M.AssertModel(models[5],_testData[31], false);
                        Int64bigintE0M.AssertModel(models[6],_testData[32], false);
                        Int64bigintE0M.AssertModel(models[7],_testData[33], false);
                        Int64bigintE0M.AssertModel(models[8],_testData[34], false);
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
                ((IInt64SingleTypebigint)this).SetDbConnectionSelectModelParametrs(cmd, 91);
                var models = await ((IInt64SingleTypebigint)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

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
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt64SingleTypebigint)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt64SingleTypebigint)this).SetDbConnectionSelectModelParametrs(cmd, 30);
                var models =  ((IInt64SingleTypebigint)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(29));

                Int64bigintE0M.AssertModel(models[0],_testData[6], false);
                Int64bigintE0M.AssertModel(models[1],_testData[7], false);
                Int64bigintE0M.AssertModel(models[2],_testData[8], false);
                Int64bigintE0M.AssertModel(models[3],_testData[9], false);
                Int64bigintE0M.AssertModel(models[4],_testData[10], false);
                Int64bigintE0M.AssertModel(models[5],_testData[11], false);
                Int64bigintE0M.AssertModel(models[6],_testData[12], false);
                Int64bigintE0M.AssertModel(models[7],_testData[13], false);
                Int64bigintE0M.AssertModel(models[8],_testData[14], false);
                Int64bigintE0M.AssertModel(models[9],_testData[15], false);
                Int64bigintE0M.AssertModel(models[10],_testData[16], false);
                Int64bigintE0M.AssertModel(models[11],_testData[17], false);
                Int64bigintE0M.AssertModel(models[12],_testData[18], false);
                Int64bigintE0M.AssertModel(models[13],_testData[19], false);
                Int64bigintE0M.AssertModel(models[14],_testData[20], false);
                Int64bigintE0M.AssertModel(models[15],_testData[21], false);
                Int64bigintE0M.AssertModel(models[16],_testData[22], false);
                Int64bigintE0M.AssertModel(models[17],_testData[23], false);
                Int64bigintE0M.AssertModel(models[18],_testData[24], false);
                Int64bigintE0M.AssertModel(models[19],_testData[25], false);
                Int64bigintE0M.AssertModel(models[20],_testData[26], false);
                Int64bigintE0M.AssertModel(models[21],_testData[27], false);
                Int64bigintE0M.AssertModel(models[22],_testData[28], false);
                Int64bigintE0M.AssertModel(models[23],_testData[29], false);
                Int64bigintE0M.AssertModel(models[24],_testData[30], false);
                Int64bigintE0M.AssertModel(models[25],_testData[31], false);
                Int64bigintE0M.AssertModel(models[26],_testData[32], false);
                Int64bigintE0M.AssertModel(models[27],_testData[33], false);
                Int64bigintE0M.AssertModel(models[28],_testData[34], false);
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
FROM dbo.int64biginte0m m
LEFT JOIN dbo.int64biginte0mi mi ON mi.id = m.int64biginte0mi_id
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
                Assert.That((System.Int32)model[0], Is.EqualTo((5)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((265914000902444008L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((9212053083639669278L)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((11)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3637463736201522467L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((5407576066878188036L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((4364958881764086390L)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2422271735745887337L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1938226039351292762L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((1251387953415652979L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5311647584294953864L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5514256407083545809L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((436598767908833937L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((5428249373296178858L)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((185351419456123095L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((45)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8967629704437414498L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((3056540990195006776L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((2467143881712670799L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((3041056394017179773L)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8666314229607983576L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((338998683773833880L)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7711278091330891762L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((198640437327496606L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((7260641658873418950L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((3460789464413843384L)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4291468842055729389L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((2926066886854794187L)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5721806669328516876L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((162568886754469333L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((2102938840796740101L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((6485574357652587074L)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1345522161848678044L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4723682807842874029L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((5389613152128894816L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((7681701467878648084L)));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2390117072436365172L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2457483422881439913L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((3364607950825969649L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((7652162639824898624L)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6028940238833776482L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7822713030227089583L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((8806719276878657718L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((5465851353480898955L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((874856935594664136L)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8395423729912611734L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8321141970469200328L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((5685455240184933440L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((7491051602110945096L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((7267772326530615784L)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((127332797252553624L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((158164052759431932L)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8026938184029487496L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((3755449580869765488L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((3773622631738560134L)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2919092959736654308L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5162107507582312892L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((4101942058588724237L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((2284959990903228989L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3509906363350572125L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((5868460787254392330L)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((145)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2385033212714255381L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((8782035320494113011L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((6279135926036757724L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((3042715135916411443L)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2705030207364670019L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7815198039541154375L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((68)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((2420690269859880702L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((6170861911582519250L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((903021815634148108L)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5368853671257893109L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((750688682461120036L)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((157)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5540721446388493776L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((74)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((5859307537047112393L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((4325961261868456522L)));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((160)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7863717866398117903L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((8168342752265788119L)));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((166)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1440814248230224736L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((77)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((8059479790709750792L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((7907659802319267083L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((167)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5502564015939597059L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((169)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3896902241401746538L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((83)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((5172526630273105944L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((170)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8114413755292912014L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((5116237175628460543L)));

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
                Assert.That((System.Int32)model[0], Is.EqualTo((5)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((265914000902444008L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((9212053083639669278L)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((11)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3637463736201522467L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((5407576066878188036L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((4364958881764086390L)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2422271735745887337L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1938226039351292762L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((1251387953415652979L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5311647584294953864L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5514256407083545809L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((436598767908833937L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((5428249373296178858L)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((185351419456123095L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((45)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8967629704437414498L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((3056540990195006776L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((2467143881712670799L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((3041056394017179773L)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8666314229607983576L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((338998683773833880L)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7711278091330891762L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((198640437327496606L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((7260641658873418950L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((3460789464413843384L)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4291468842055729389L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((2926066886854794187L)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5721806669328516876L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((162568886754469333L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((2102938840796740101L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((6485574357652587074L)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1345522161848678044L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4723682807842874029L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((5389613152128894816L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((7681701467878648084L)));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2390117072436365172L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2457483422881439913L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((3364607950825969649L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((7652162639824898624L)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6028940238833776482L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7822713030227089583L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((8806719276878657718L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((5465851353480898955L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((874856935594664136L)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8395423729912611734L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8321141970469200328L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((5685455240184933440L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((7491051602110945096L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((7267772326530615784L)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((127332797252553624L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((158164052759431932L)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8026938184029487496L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((3755449580869765488L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((3773622631738560134L)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2919092959736654308L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5162107507582312892L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((4101942058588724237L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((2284959990903228989L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3509906363350572125L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((5868460787254392330L)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((145)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2385033212714255381L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((8782035320494113011L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((6279135926036757724L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((3042715135916411443L)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2705030207364670019L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7815198039541154375L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((68)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((2420690269859880702L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((6170861911582519250L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((903021815634148108L)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5368853671257893109L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((750688682461120036L)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((157)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5540721446388493776L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((74)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((5859307537047112393L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((4325961261868456522L)));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((160)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7863717866398117903L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((8168342752265788119L)));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((166)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1440814248230224736L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((77)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((8059479790709750792L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((7907659802319267083L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((167)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5502564015939597059L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((169)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3896902241401746538L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((83)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((5172526630273105944L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((170)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8114413755292912014L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((5116237175628460543L)));

            }
        }

#endregion

    }
}

