

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
    Id = 6,
    Value = 9168033128013798401L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 7,
    Value = 4776982191584172262L,
    ModelInner = new Int64bigintE0MI
{
    Id = 7,
    Value = 2451030625986320151L,
    NullableValue = null,
},
    NullableValue = 4580334701692211708L,
},
            new Int64bigintE0M
{
    Id = 16,
    Value = 8522455145631334929L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 22,
    Value = 6432455251559701791L,
    ModelInner = new Int64bigintE0MI
{
    Id = 13,
    Value = 8632258050670227221L,
    NullableValue = null,
},
    NullableValue = 9093943337912343411L,
},
            new Int64bigintE0M
{
    Id = 27,
    Value = 263389698665566776L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 30,
    Value = 1552615402957255397L,
    ModelInner = new Int64bigintE0MI
{
    Id = 17,
    Value = 1258696228049127692L,
    NullableValue = null,
},
    NullableValue = 6026911199747795075L,
},
            new Int64bigintE0M
{
    Id = 36,
    Value = 459020380373574921L,
    ModelInner = null,
    NullableValue = 6542823578134098484L,
},
            new Int64bigintE0M
{
    Id = 45,
    Value = 4558789187038228228L,
    ModelInner = new Int64bigintE0MI
{
    Id = 24,
    Value = 6376395798502692103L,
    NullableValue = 4318951402685568508L,
},
    NullableValue = 1943268482611415960L,
},
            new Int64bigintE0M
{
    Id = 52,
    Value = 2687555024400159546L,
    ModelInner = null,
    NullableValue = 8169533634479901838L,
},
            new Int64bigintE0M
{
    Id = 60,
    Value = 8798548063023338687L,
    ModelInner = new Int64bigintE0MI
{
    Id = 32,
    Value = 5346230113319668401L,
    NullableValue = 3832020142388007623L,
},
    NullableValue = 400936528312374597L,
},
            new Int64bigintE0M
{
    Id = 66,
    Value = 6063623660752596197L,
    ModelInner = null,
    NullableValue = 4714792809316460781L,
},
            new Int64bigintE0M
{
    Id = 73,
    Value = 4871328731466844355L,
    ModelInner = new Int64bigintE0MI
{
    Id = 34,
    Value = 9082743382393351705L,
    NullableValue = 2537403937902911986L,
},
    NullableValue = 3298859007639432296L,
},
            new Int64bigintE0M
{
    Id = 77,
    Value = 6870984265221927151L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 83,
    Value = 3205666839026480593L,
    ModelInner = new Int64bigintE0MI
{
    Id = 40,
    Value = 3646552759691299048L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 85,
    Value = 7454028566851864808L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 88,
    Value = 121235513107567854L,
    ModelInner = new Int64bigintE0MI
{
    Id = 47,
    Value = 7060529856719526137L,
    NullableValue = 4112137520793959894L,
},
    NullableValue = 3920092295681594700L,
},
            new Int64bigintE0M
{
    Id = 91,
    Value = 1231642649011880001L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 98,
    Value = 5754748852889879686L,
    ModelInner = new Int64bigintE0MI
{
    Id = 49,
    Value = 7257765725027100176L,
    NullableValue = 6093397336799905568L,
},
    NullableValue = 3222776753752745525L,
},
            new Int64bigintE0M
{
    Id = 103,
    Value = 8908178496690254550L,
    ModelInner = null,
    NullableValue = 8207812165260520969L,
},
            new Int64bigintE0M
{
    Id = 112,
    Value = 597471544952454478L,
    ModelInner = new Int64bigintE0MI
{
    Id = 52,
    Value = 4630876740921371982L,
    NullableValue = 6760376619999170556L,
},
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 118,
    Value = 2681343868438656889L,
    ModelInner = null,
    NullableValue = 8376997987362163552L,
},
            new Int64bigintE0M
{
    Id = 122,
    Value = 7301116322904741396L,
    ModelInner = new Int64bigintE0MI
{
    Id = 59,
    Value = 3936049631089826385L,
    NullableValue = 5854348403770982898L,
},
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 129,
    Value = 3247382193468811327L,
    ModelInner = null,
    NullableValue = 3130990662999463662L,
},
            new Int64bigintE0M
{
    Id = 135,
    Value = 1750877852213578174L,
    ModelInner = new Int64bigintE0MI
{
    Id = 66,
    Value = 7738981331836035806L,
    NullableValue = null,
},
    NullableValue = 7232604482141186845L,
},
            new Int64bigintE0M
{
    Id = 141,
    Value = 8988087371692216361L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 147,
    Value = 255227687347993503L,
    ModelInner = new Int64bigintE0MI
{
    Id = 72,
    Value = 7429313573576165903L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 148,
    Value = 3860721089091058472L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 153,
    Value = 5511495385643559583L,
    ModelInner = new Int64bigintE0MI
{
    Id = 79,
    Value = 3770699703774662251L,
    NullableValue = null,
},
    NullableValue = 958345928445890201L,
},
            new Int64bigintE0M
{
    Id = 158,
    Value = 59784186417240731L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 161,
    Value = 7143512181722467934L,
    ModelInner = new Int64bigintE0MI
{
    Id = 88,
    Value = 6980260775405428656L,
    NullableValue = 8947641534933894331L,
},
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 165,
    Value = 8250623682477203018L,
    ModelInner = null,
    NullableValue = 4792398813389523009L,
},
            new Int64bigintE0M
{
    Id = 171,
    Value = 8135731532991771004L,
    ModelInner = new Int64bigintE0MI
{
    Id = 92,
    Value = 6534671027302319693L,
    NullableValue = 8549969432222430670L,
},
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 175,
    Value = 6323967977149143169L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 184,
    Value = 4818698877165278570L,
    ModelInner = new Int64bigintE0MI
{
    Id = 101,
    Value = 1701920234215152093L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 189,
    Value = 7664249585086112162L,
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.MySqlConnector.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.int64biginte0mi(
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
INSERT INTO gedaqtests.int64biginte0mi(
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
                parametrName: "int64biginte0mi_id", 
                methodParametrName: "int64biginte0mi_id", 
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
LEFT JOIN gedaqtests.int64biginte0mi mi ON mi.id = m.int64biginte0mi_id
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
LEFT JOIN gedaqtests.int64biginte0mi mi ON mi.id = m.int64biginte0mi_id
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
                parametr1.Value = 85;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 141;
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
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatInt64bigintE0M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatInt64bigintE0M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[9],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 45;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 161;
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
                parametr1.Value = 45;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 98;
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
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatInt64bigintE0M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[16],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 88;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 45;
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
                parametr1.Value = 66;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 60;
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
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatInt64bigintE0M.AssertModel(models[0],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(models[1],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(models[2],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(models[3],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(models[4],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(models[5],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(models[6],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(models[7],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(models[8],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(models[9],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(models[10],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(models[11],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(models[12],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(models[13],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(models[14],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(models[15],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(models[16],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(models[17],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(models[18],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(models[19],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(models[20],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(models[21],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(models[22],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatInt64bigintE0M.AssertModel(models[0],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(models[1],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(models[2],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(models[3],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(models[4],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(models[5],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(models[6],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(models[7],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(models[8],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(models[9],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(models[10],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(models[11],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(models[12],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(models[13],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(models[14],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(models[15],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(models[16],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(models[17],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(models[18],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(models[19],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(models[20],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(models[21],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(models[22],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(models[23],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(models[24],_testData[34], false);
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
                parametr1.Value = 66;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 91;
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
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatInt64bigintE0M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatInt64bigintE0M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[17],_testData[34], false);
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
                parametr1.Value = 45;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 6;
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
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatInt64bigintE0M.AssertModel(models[0],_testData[8], false);
                        FlatInt64bigintE0M.AssertModel(models[1],_testData[9], false);
                        FlatInt64bigintE0M.AssertModel(models[2],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(models[3],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(models[4],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(models[5],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(models[6],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(models[7],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(models[8],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(models[9],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(models[10],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(models[11],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(models[12],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(models[13],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(models[14],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(models[15],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(models[16],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(models[17],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(models[18],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(models[19],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(models[20],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(models[21],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(models[22],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(models[23],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(models[24],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(models[25],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                parametr1.Value = 98;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 103;
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
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                        FlatInt64bigintE0M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[16],_testData[34], false);
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
LEFT JOIN gedaqtests.int64biginte0mi mi ON mi.id = m.int64biginte0mi_id
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
                parametr1.Value = 171;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 175;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64SingleTypebigint)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        Int64bigintE0M.AssertModel(models[0],_testData[32], false);
                        Int64bigintE0M.AssertModel(models[1],_testData[33], false);
                        Int64bigintE0M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        Int64bigintE0M.AssertModel(models[0],_testData[33], false);
                        Int64bigintE0M.AssertModel(models[1],_testData[34], false);
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
                parametr1.Value = 141;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 98;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64SingleTypebigint)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        Int64bigintE0M.AssertModel(models[0],_testData[18], false);
                        Int64bigintE0M.AssertModel(models[1],_testData[19], false);
                        Int64bigintE0M.AssertModel(models[2],_testData[20], false);
                        Int64bigintE0M.AssertModel(models[3],_testData[21], false);
                        Int64bigintE0M.AssertModel(models[4],_testData[22], false);
                        Int64bigintE0M.AssertModel(models[5],_testData[23], false);
                        Int64bigintE0M.AssertModel(models[6],_testData[24], false);
                        Int64bigintE0M.AssertModel(models[7],_testData[25], false);
                        Int64bigintE0M.AssertModel(models[8],_testData[26], false);
                        Int64bigintE0M.AssertModel(models[9],_testData[27], false);
                        Int64bigintE0M.AssertModel(models[10],_testData[28], false);
                        Int64bigintE0M.AssertModel(models[11],_testData[29], false);
                        Int64bigintE0M.AssertModel(models[12],_testData[30], false);
                        Int64bigintE0M.AssertModel(models[13],_testData[31], false);
                        Int64bigintE0M.AssertModel(models[14],_testData[32], false);
                        Int64bigintE0M.AssertModel(models[15],_testData[33], false);
                        Int64bigintE0M.AssertModel(models[16],_testData[34], false);
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
                await ((IInt64SingleTypebigint)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 141, query1, 77, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                await ((IInt64SingleTypebigint)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 22, query1, 66, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatInt64bigintE0M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[30],_testData[34], false);
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
                 ((IInt64SingleTypebigint)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 175, query1, 175, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatInt64bigintE0M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[1],_testData[34], false);
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
                 ((IInt64SingleTypebigint)this).DbConnectionMMDynQuerySelectModelBatch(connection, 161, query1, 85, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatInt64bigintE0M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[19],_testData[34], false);
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
                foreach(var batchResult in await ((IInt64SingleTypebigint)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 98, query1, 85, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatInt64bigintE0M.AssertModel(models[0],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(models[1],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(models[2],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(models[3],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(models[4],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(models[5],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(models[6],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(models[7],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(models[8],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(models[9],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(models[10],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(models[11],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(models[12],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(models[13],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(models[14],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(models[15],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(models[16],_testData[34], false);
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
                await ((IInt64SingleTypebigint)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 30, query1, 153, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatInt64bigintE0M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[28],_testData[34], false);
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
                foreach(var batchResult in  ((IInt64SingleTypebigint)this).DbConnectionSTDynQuerySelectModelBatch(connection, 112, query1, 85, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatInt64bigintE0M.AssertModel(models[0],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(models[1],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(models[2],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(models[3],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(models[4],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(models[5],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(models[6],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(models[7],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(models[8],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(models[9],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(models[10],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(models[11],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(models[12],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(models[13],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(models[14],_testData[34], false);
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
                 ((IInt64SingleTypebigint)this).DbConnectionDynQuerySelectModelBatch(connection, 88, query1, 85, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatInt64bigintE0M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatInt64bigintE0M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[19],_testData[34], false);
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
LEFT JOIN gedaqtests.int64biginte0mi mi ON mi.id = m.int64biginte0mi_id
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
                foreach(var batchResult in await ((IInt64SingleTypebigint)this).DbConnectionSTSelectModelBatchAsync(connection, 83, 175))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        Int64bigintE0M.AssertModel(models[0],_testData[14], false);
                        Int64bigintE0M.AssertModel(models[1],_testData[15], false);
                        Int64bigintE0M.AssertModel(models[2],_testData[16], false);
                        Int64bigintE0M.AssertModel(models[3],_testData[17], false);
                        Int64bigintE0M.AssertModel(models[4],_testData[18], false);
                        Int64bigintE0M.AssertModel(models[5],_testData[19], false);
                        Int64bigintE0M.AssertModel(models[6],_testData[20], false);
                        Int64bigintE0M.AssertModel(models[7],_testData[21], false);
                        Int64bigintE0M.AssertModel(models[8],_testData[22], false);
                        Int64bigintE0M.AssertModel(models[9],_testData[23], false);
                        Int64bigintE0M.AssertModel(models[10],_testData[24], false);
                        Int64bigintE0M.AssertModel(models[11],_testData[25], false);
                        Int64bigintE0M.AssertModel(models[12],_testData[26], false);
                        Int64bigintE0M.AssertModel(models[13],_testData[27], false);
                        Int64bigintE0M.AssertModel(models[14],_testData[28], false);
                        Int64bigintE0M.AssertModel(models[15],_testData[29], false);
                        Int64bigintE0M.AssertModel(models[16],_testData[30], false);
                        Int64bigintE0M.AssertModel(models[17],_testData[31], false);
                        Int64bigintE0M.AssertModel(models[18],_testData[32], false);
                        Int64bigintE0M.AssertModel(models[19],_testData[33], false);
                        Int64bigintE0M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        Int64bigintE0M.AssertModel(models[0],_testData[33], false);
                        Int64bigintE0M.AssertModel(models[1],_testData[34], false);
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
                foreach(var batchResult in  ((IInt64SingleTypebigint)this).DbConnectionSTSelectModelBatch(connection, 73, 27))
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
                        Assert.That(models, Has.Count.EqualTo(30));

                        Int64bigintE0M.AssertModel(models[0],_testData[5], false);
                        Int64bigintE0M.AssertModel(models[1],_testData[6], false);
                        Int64bigintE0M.AssertModel(models[2],_testData[7], false);
                        Int64bigintE0M.AssertModel(models[3],_testData[8], false);
                        Int64bigintE0M.AssertModel(models[4],_testData[9], false);
                        Int64bigintE0M.AssertModel(models[5],_testData[10], false);
                        Int64bigintE0M.AssertModel(models[6],_testData[11], false);
                        Int64bigintE0M.AssertModel(models[7],_testData[12], false);
                        Int64bigintE0M.AssertModel(models[8],_testData[13], false);
                        Int64bigintE0M.AssertModel(models[9],_testData[14], false);
                        Int64bigintE0M.AssertModel(models[10],_testData[15], false);
                        Int64bigintE0M.AssertModel(models[11],_testData[16], false);
                        Int64bigintE0M.AssertModel(models[12],_testData[17], false);
                        Int64bigintE0M.AssertModel(models[13],_testData[18], false);
                        Int64bigintE0M.AssertModel(models[14],_testData[19], false);
                        Int64bigintE0M.AssertModel(models[15],_testData[20], false);
                        Int64bigintE0M.AssertModel(models[16],_testData[21], false);
                        Int64bigintE0M.AssertModel(models[17],_testData[22], false);
                        Int64bigintE0M.AssertModel(models[18],_testData[23], false);
                        Int64bigintE0M.AssertModel(models[19],_testData[24], false);
                        Int64bigintE0M.AssertModel(models[20],_testData[25], false);
                        Int64bigintE0M.AssertModel(models[21],_testData[26], false);
                        Int64bigintE0M.AssertModel(models[22],_testData[27], false);
                        Int64bigintE0M.AssertModel(models[23],_testData[28], false);
                        Int64bigintE0M.AssertModel(models[24],_testData[29], false);
                        Int64bigintE0M.AssertModel(models[25],_testData[30], false);
                        Int64bigintE0M.AssertModel(models[26],_testData[31], false);
                        Int64bigintE0M.AssertModel(models[27],_testData[32], false);
                        Int64bigintE0M.AssertModel(models[28],_testData[33], false);
                        Int64bigintE0M.AssertModel(models[29],_testData[34], false);
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
                ((IInt64SingleTypebigint)this).SetDbConnectionSelectModelParametrs(cmd, 36);
                var models = await ((IInt64SingleTypebigint)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

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
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt64SingleTypebigint)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt64SingleTypebigint)this).SetDbConnectionSelectModelParametrs(cmd, 73);
                var models =  ((IInt64SingleTypebigint)this).ExecuteDbConnectionSelectModelCommand(cmd);

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
LEFT JOIN gedaqtests.int64biginte0mi mi ON mi.id = m.int64biginte0mi_id
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
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((9168033128013798401L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4776982191584172262L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((2451030625986320151L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((4580334701692211708L)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8522455145631334929L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6432455251559701791L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((8632258050670227221L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((9093943337912343411L)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((263389698665566776L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1552615402957255397L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((1258696228049127692L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((6026911199747795075L)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((459020380373574921L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((6542823578134098484L)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((45)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4558789187038228228L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((6376395798502692103L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((4318951402685568508L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((1943268482611415960L)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2687555024400159546L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((8169533634479901838L)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8798548063023338687L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((5346230113319668401L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((3832020142388007623L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((400936528312374597L)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6063623660752596197L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((4714792809316460781L)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4871328731466844355L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((9082743382393351705L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((2537403937902911986L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((3298859007639432296L)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6870984265221927151L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((83)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3205666839026480593L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((3646552759691299048L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7454028566851864808L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((121235513107567854L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((7060529856719526137L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((4112137520793959894L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((3920092295681594700L)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1231642649011880001L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5754748852889879686L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((7257765725027100176L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((6093397336799905568L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((3222776753752745525L)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8908178496690254550L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((8207812165260520969L)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((597471544952454478L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((4630876740921371982L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((6760376619999170556L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2681343868438656889L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((8376997987362163552L)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7301116322904741396L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((3936049631089826385L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((5854348403770982898L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3247382193468811327L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((3130990662999463662L)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1750877852213578174L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((7738981331836035806L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((7232604482141186845L)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8988087371692216361L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((255227687347993503L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((7429313573576165903L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3860721089091058472L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((153)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5511495385643559583L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((79)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((3770699703774662251L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((958345928445890201L)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((158)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((59784186417240731L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((161)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7143512181722467934L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((88)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((6980260775405428656L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((8947641534933894331L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((165)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8250623682477203018L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((4792398813389523009L)));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((171)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8135731532991771004L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((92)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((6534671027302319693L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((8549969432222430670L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((175)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6323967977149143169L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((184)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4818698877165278570L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((101)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((1701920234215152093L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((189)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7664249585086112162L)));//Value

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
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((9168033128013798401L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4776982191584172262L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((2451030625986320151L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((4580334701692211708L)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8522455145631334929L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6432455251559701791L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((8632258050670227221L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((9093943337912343411L)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((263389698665566776L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1552615402957255397L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((1258696228049127692L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((6026911199747795075L)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((459020380373574921L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((6542823578134098484L)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((45)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4558789187038228228L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((6376395798502692103L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((4318951402685568508L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((1943268482611415960L)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2687555024400159546L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((8169533634479901838L)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8798548063023338687L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((5346230113319668401L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((3832020142388007623L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((400936528312374597L)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6063623660752596197L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((4714792809316460781L)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4871328731466844355L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((9082743382393351705L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((2537403937902911986L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((3298859007639432296L)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6870984265221927151L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((83)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3205666839026480593L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((3646552759691299048L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7454028566851864808L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((121235513107567854L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((7060529856719526137L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((4112137520793959894L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((3920092295681594700L)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1231642649011880001L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5754748852889879686L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((7257765725027100176L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((6093397336799905568L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((3222776753752745525L)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8908178496690254550L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((8207812165260520969L)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((597471544952454478L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((4630876740921371982L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((6760376619999170556L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2681343868438656889L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((8376997987362163552L)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7301116322904741396L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((3936049631089826385L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((5854348403770982898L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3247382193468811327L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((3130990662999463662L)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1750877852213578174L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((7738981331836035806L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((7232604482141186845L)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8988087371692216361L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((255227687347993503L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((7429313573576165903L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3860721089091058472L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((153)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5511495385643559583L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((79)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((3770699703774662251L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((958345928445890201L)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((158)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((59784186417240731L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((161)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7143512181722467934L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((88)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((6980260775405428656L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((8947641534933894331L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((165)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8250623682477203018L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((4792398813389523009L)));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((171)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8135731532991771004L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((92)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((6534671027302319693L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((8549969432222430670L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((175)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6323967977149143169L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((184)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4818698877165278570L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((101)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((1701920234215152093L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((189)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7664249585086112162L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

#endregion

    }
}

