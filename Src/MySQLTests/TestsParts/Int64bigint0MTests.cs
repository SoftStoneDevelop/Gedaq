

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

        private readonly Int64bigint0M[] _testData = new Int64bigint0M[]
        {
            new Int64bigint0M
{
    Id = 8,
    Value = 4972313500075450560L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 11,
    Value = 6666654772290215571L,
    ModelInner = new Int64bigint0MI
{
    Id = 8,
    Value = 1240884968222372339L,
    NullableValue = null,
},
    NullableValue = 4567124389901396409L,
},
            new Int64bigint0M
{
    Id = 14,
    Value = 4356197669659031351L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 22,
    Value = 841905055167283482L,
    ModelInner = new Int64bigint0MI
{
    Id = 13,
    Value = 2367586801719941918L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 29,
    Value = 5056866039267675976L,
    ModelInner = null,
    NullableValue = 5827460520253756291L,
},
            new Int64bigint0M
{
    Id = 36,
    Value = 870597339562081513L,
    ModelInner = new Int64bigint0MI
{
    Id = 15,
    Value = 7950045472194947465L,
    NullableValue = 6267300254692747267L,
},
    NullableValue = 4586366442338638523L,
},
            new Int64bigint0M
{
    Id = 40,
    Value = 2945027354002966360L,
    ModelInner = null,
    NullableValue = 6421621965141008179L,
},
            new Int64bigint0M
{
    Id = 47,
    Value = 734298845822741527L,
    ModelInner = new Int64bigint0MI
{
    Id = 16,
    Value = 2039689531558659426L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 52,
    Value = 3164888003207929395L,
    ModelInner = null,
    NullableValue = 3054248561932269055L,
},
            new Int64bigint0M
{
    Id = 53,
    Value = 6816789828542407053L,
    ModelInner = new Int64bigint0MI
{
    Id = 20,
    Value = 2185978054120978505L,
    NullableValue = null,
},
    NullableValue = 5948636990667373346L,
},
            new Int64bigint0M
{
    Id = 54,
    Value = 6241116610016513902L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 63,
    Value = 9133396721788350828L,
    ModelInner = new Int64bigint0MI
{
    Id = 24,
    Value = 8374934533858541575L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 64,
    Value = 8729525454551793302L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 66,
    Value = 9173933805152321289L,
    ModelInner = new Int64bigint0MI
{
    Id = 32,
    Value = 6704028217081510764L,
    NullableValue = 3363082833372114626L,
},
    NullableValue = 4313168298678253380L,
},
            new Int64bigint0M
{
    Id = 73,
    Value = 986318209472250130L,
    ModelInner = null,
    NullableValue = 5323358229551851134L,
},
            new Int64bigint0M
{
    Id = 74,
    Value = 4656862249319469314L,
    ModelInner = new Int64bigint0MI
{
    Id = 37,
    Value = 7575946564056889212L,
    NullableValue = 986258941677249351L,
},
    NullableValue = 5753618330851400725L,
},
            new Int64bigint0M
{
    Id = 79,
    Value = 869418664031595381L,
    ModelInner = null,
    NullableValue = 6067869062474140625L,
},
            new Int64bigint0M
{
    Id = 87,
    Value = 1572334289737477795L,
    ModelInner = new Int64bigint0MI
{
    Id = 43,
    Value = 3585255476980650930L,
    NullableValue = null,
},
    NullableValue = 6504749881066833586L,
},
            new Int64bigint0M
{
    Id = 94,
    Value = 931946907063678650L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 102,
    Value = 6926490183447720007L,
    ModelInner = new Int64bigint0MI
{
    Id = 51,
    Value = 7644206024989959789L,
    NullableValue = 572303897625122873L,
},
    NullableValue = 6667538739236198046L,
},
            new Int64bigint0M
{
    Id = 109,
    Value = 3423493735852846971L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 117,
    Value = 1045680700183161258L,
    ModelInner = new Int64bigint0MI
{
    Id = 52,
    Value = 3490768850627684566L,
    NullableValue = null,
},
    NullableValue = 608888734911819852L,
},
            new Int64bigint0M
{
    Id = 126,
    Value = 6498595646446239368L,
    ModelInner = null,
    NullableValue = 749740367450327363L,
},
            new Int64bigint0M
{
    Id = 129,
    Value = 6445377152273837344L,
    ModelInner = new Int64bigint0MI
{
    Id = 55,
    Value = 4747088631809440352L,
    NullableValue = 3452351782744942128L,
},
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 133,
    Value = 7707588377482534669L,
    ModelInner = null,
    NullableValue = 5400586825343768864L,
},
            new Int64bigint0M
{
    Id = 135,
    Value = 4686869952917894089L,
    ModelInner = new Int64bigint0MI
{
    Id = 61,
    Value = 7925872597637608904L,
    NullableValue = null,
},
    NullableValue = 7912144799739496368L,
},
            new Int64bigint0M
{
    Id = 139,
    Value = 8248223865234070929L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 147,
    Value = 2124040618274820274L,
    ModelInner = new Int64bigint0MI
{
    Id = 63,
    Value = 5628469177315164935L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 152,
    Value = 682401655479119082L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 154,
    Value = 8896934996051131514L,
    ModelInner = new Int64bigint0MI
{
    Id = 72,
    Value = 3016138741570862099L,
    NullableValue = 1734275031042981999L,
},
    NullableValue = null,
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

            }
        }

#endregion

#region InsertModel

[Gedaq.MySqlConnector.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.int64bigint0m(
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
INSERT INTO gedaqtests.int64bigint0m(
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

            }
        }

#endregion

#region Select Models

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigint0M), typeof(FlatInt64bigint0M)],
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
FROM gedaqtests.int64bigint0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt64bigint0M>();
                var models2 = new List<FlatInt64bigint0M>();
                await((IInt64SingleTypebigint)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
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
FROM gedaqtests.int64bigint0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
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

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigint0M)],
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
FROM gedaqtests.int64bigint0m m
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
FROM gedaqtests.int64bigint0m m
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigint0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.int64bigint0m m
LEFT JOIN gedaqtests.int64bigint0mi mi ON mi.id = m.int64bigint0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            sourceType: SourceType.MySqlConnection,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Int64bigint0M)],
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
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
                var models = ((IInt64SingleTypebigint)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int64bigint0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigint0M), typeof(FlatInt64bigint0M)],
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
FROM gedaqtests.int64bigint0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigint0M>();
                var models2 = new List<FlatInt64bigint0M>();
                await((IInt64SingleTypebigint)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
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
FROM gedaqtests.int64bigint0m m
WHERE 
    m.id > @id
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

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigint0M)],
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
FROM gedaqtests.int64bigint0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IInt64SingleTypebigint)this).DynQuerySelectModelAsync(connection,  query, 0);
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
FROM gedaqtests.int64bigint0m m
WHERE 
    m.id > @id
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
FROM gedaqtests.int64bigint0m m
LEFT JOIN gedaqtests.int64bigint0mi mi ON mi.id = m.int64bigint0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            sourceType: SourceType.MySqlConnection,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Int64bigint0M)],
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
FROM gedaqtests.int64bigint0m m
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
                parametr1.Value = 133;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 11;
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
FROM gedaqtests.int64bigint0m m
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
FROM gedaqtests.int64bigint0m m
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
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatInt64bigint0M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[4],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[27],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 40;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 8;
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
FROM gedaqtests.int64bigint0m m
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
FROM gedaqtests.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigint0M>();
                var firstItems2 = new List<FlatInt64bigint0M>();
                var secondItems1 = new List<FlatInt64bigint0M>();
                await ((IInt64SingleTypebigint)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatInt64bigint0M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[22],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[28],_testData[29], false);
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
FROM gedaqtests.int64bigint0m m
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
                parametr1.Value = 94;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 117;
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
FROM gedaqtests.int64bigint0m m
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
FROM gedaqtests.int64bigint0m m
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
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatInt64bigint0M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[10],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[7],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 109;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 73;
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
FROM gedaqtests.int64bigint0m m
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
FROM gedaqtests.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigint0M>();
                var firstItems2 = new List<FlatInt64bigint0M>();
                var secondItems1 = new List<FlatInt64bigint0M>();
                 ((IInt64SingleTypebigint)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[14],_testData[29], false);
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
FROM gedaqtests.int64bigint0m m
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
                parametr1.Value = 36;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 14;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.int64bigint0m m
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
FROM gedaqtests.int64bigint0m m
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

                        FlatInt64bigint0M.AssertModel(models[0],_testData[6], false);
                        FlatInt64bigint0M.AssertModel(models[1],_testData[7], false);
                        FlatInt64bigint0M.AssertModel(models[2],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(models[3],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(models[4],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(models[5],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(models[6],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(models[7],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(models[8],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(models[9],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(models[10],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(models[11],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(models[12],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(models[13],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(models[14],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(models[15],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(models[16],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(models[17],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(models[18],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(models[19],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(models[20],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(models[21],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(models[22],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatInt64bigint0M.AssertModel(models[0],_testData[3], false);
                        FlatInt64bigint0M.AssertModel(models[1],_testData[4], false);
                        FlatInt64bigint0M.AssertModel(models[2],_testData[5], false);
                        FlatInt64bigint0M.AssertModel(models[3],_testData[6], false);
                        FlatInt64bigint0M.AssertModel(models[4],_testData[7], false);
                        FlatInt64bigint0M.AssertModel(models[5],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(models[6],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(models[7],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(models[8],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(models[9],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(models[10],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(models[11],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(models[12],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(models[13],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(models[14],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(models[15],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(models[16],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(models[17],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(models[18],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(models[19],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(models[20],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(models[21],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(models[22],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(models[23],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(models[24],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(models[25],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(models[26],_testData[29], false);
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
                parametr1.Value = 73;
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
FROM gedaqtests.int64bigint0m m
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
FROM gedaqtests.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigint0M>();
                var secondItems1 = new List<FlatInt64bigint0M>();
                var secondItems2 = new List<FlatInt64bigint0M>();
                await ((IInt64SingleTypebigint)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatInt64bigint0M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[14],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[7],_testData[29], false);
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
FROM gedaqtests.int64bigint0m m
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
                parametr1.Value = 74;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 22;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.int64bigint0m m
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
FROM gedaqtests.int64bigint0m m
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
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatInt64bigint0M.AssertModel(models[0],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(models[1],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(models[2],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(models[3],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(models[4],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(models[5],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(models[6],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(models[7],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(models[8],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(models[9],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(models[10],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(models[11],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(models[12],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatInt64bigint0M.AssertModel(models[0],_testData[4], false);
                        FlatInt64bigint0M.AssertModel(models[1],_testData[5], false);
                        FlatInt64bigint0M.AssertModel(models[2],_testData[6], false);
                        FlatInt64bigint0M.AssertModel(models[3],_testData[7], false);
                        FlatInt64bigint0M.AssertModel(models[4],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(models[5],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(models[6],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(models[7],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(models[8],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(models[9],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(models[10],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(models[11],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(models[12],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(models[13],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(models[14],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(models[15],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(models[16],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(models[17],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(models[18],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(models[19],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(models[20],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(models[21],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(models[22],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(models[23],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(models[24],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(models[25],_testData[29], false);
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
                parametr1.Value = 29;
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
FROM gedaqtests.int64bigint0m m
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
FROM gedaqtests.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigint0M>();
                var secondItems1 = new List<FlatInt64bigint0M>();
                var secondItems2 = new List<FlatInt64bigint0M>();
                 ((IInt64SingleTypebigint)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatInt64bigint0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[24],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[11],_testData[29], false);
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
FROM gedaqtests.int64bigint0m m
LEFT JOIN gedaqtests.int64bigint0mi mi ON mi.id = m.int64bigint0mi_id
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
                parametr1.Value = 102;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 64;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64SingleTypebigint)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        Int64bigint0M.AssertModel(models[0],_testData[20], false);
                        Int64bigint0M.AssertModel(models[1],_testData[21], false);
                        Int64bigint0M.AssertModel(models[2],_testData[22], false);
                        Int64bigint0M.AssertModel(models[3],_testData[23], false);
                        Int64bigint0M.AssertModel(models[4],_testData[24], false);
                        Int64bigint0M.AssertModel(models[5],_testData[25], false);
                        Int64bigint0M.AssertModel(models[6],_testData[26], false);
                        Int64bigint0M.AssertModel(models[7],_testData[27], false);
                        Int64bigint0M.AssertModel(models[8],_testData[28], false);
                        Int64bigint0M.AssertModel(models[9],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                parametr1.Value = 135;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 8;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64SingleTypebigint)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        Int64bigint0M.AssertModel(models[0],_testData[26], false);
                        Int64bigint0M.AssertModel(models[1],_testData[27], false);
                        Int64bigint0M.AssertModel(models[2],_testData[28], false);
                        Int64bigint0M.AssertModel(models[3],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
FROM gedaqtests.int64bigint0m m
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
FROM gedaqtests.int64bigint0m m
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
FROM gedaqtests.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigint0M>();
                var firstItems2 = new List<FlatInt64bigint0M>();
                var secondItems1 = new List<FlatInt64bigint0M>();
                var secondItems2 = new List<FlatInt64bigint0M>();
                await ((IInt64SingleTypebigint)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 40, query1, 8, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatInt64bigint0M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[22],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[28],_testData[29], false);
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
FROM gedaqtests.int64bigint0m m
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
FROM gedaqtests.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigint0M>();
                var firstItems2 = new List<FlatInt64bigint0M>();
                var secondItems1 = new List<FlatInt64bigint0M>();
                await ((IInt64SingleTypebigint)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 53, query1, 52, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatInt64bigint0M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[19],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[20],_testData[29], false);
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
FROM gedaqtests.int64bigint0m m
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
FROM gedaqtests.int64bigint0m m
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
FROM gedaqtests.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigint0M>();
                var firstItems2 = new List<FlatInt64bigint0M>();
                var secondItems1 = new List<FlatInt64bigint0M>();
                var secondItems2 = new List<FlatInt64bigint0M>();
                 ((IInt64SingleTypebigint)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 102, query1, 117, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatInt64bigint0M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[9],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[7],_testData[29], false);
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
FROM gedaqtests.int64bigint0m m
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
FROM gedaqtests.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigint0M>();
                var firstItems2 = new List<FlatInt64bigint0M>();
                var secondItems1 = new List<FlatInt64bigint0M>();
                 ((IInt64SingleTypebigint)this).DbConnectionMMDynQuerySelectModelBatch(connection, 109, query1, 53, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[19],_testData[29], false);
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
FROM gedaqtests.int64bigint0m m
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
FROM gedaqtests.int64bigint0m m
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
FROM gedaqtests.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64SingleTypebigint)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 8, query1, 129, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatInt64bigint0M.AssertModel(models[0],_testData[1], false);
                        FlatInt64bigint0M.AssertModel(models[1],_testData[2], false);
                        FlatInt64bigint0M.AssertModel(models[2],_testData[3], false);
                        FlatInt64bigint0M.AssertModel(models[3],_testData[4], false);
                        FlatInt64bigint0M.AssertModel(models[4],_testData[5], false);
                        FlatInt64bigint0M.AssertModel(models[5],_testData[6], false);
                        FlatInt64bigint0M.AssertModel(models[6],_testData[7], false);
                        FlatInt64bigint0M.AssertModel(models[7],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(models[8],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(models[9],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(models[10],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(models[11],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(models[12],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(models[13],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(models[14],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(models[15],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(models[16],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(models[17],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(models[18],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(models[19],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(models[20],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(models[21],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(models[22],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(models[23],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(models[24],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(models[25],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(models[26],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(models[27],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(models[28],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
FROM gedaqtests.int64bigint0m m
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
FROM gedaqtests.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigint0M>();
                var secondItems1 = new List<FlatInt64bigint0M>();
                var secondItems2 = new List<FlatInt64bigint0M>();
                await ((IInt64SingleTypebigint)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 36, query1, 79, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatInt64bigint0M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[23],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[12],_testData[29], false);
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
FROM gedaqtests.int64bigint0m m
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
FROM gedaqtests.int64bigint0m m
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
FROM gedaqtests.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64SingleTypebigint)this).DbConnectionSTDynQuerySelectModelBatch(connection, 11, query1, 117, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatInt64bigint0M.AssertModel(models[0],_testData[2], false);
                        FlatInt64bigint0M.AssertModel(models[1],_testData[3], false);
                        FlatInt64bigint0M.AssertModel(models[2],_testData[4], false);
                        FlatInt64bigint0M.AssertModel(models[3],_testData[5], false);
                        FlatInt64bigint0M.AssertModel(models[4],_testData[6], false);
                        FlatInt64bigint0M.AssertModel(models[5],_testData[7], false);
                        FlatInt64bigint0M.AssertModel(models[6],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(models[7],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(models[8],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(models[9],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(models[10],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(models[11],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(models[12],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(models[13],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(models[14],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(models[15],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(models[16],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(models[17],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(models[18],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(models[19],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(models[20],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(models[21],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(models[22],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(models[23],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(models[24],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(models[25],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(models[26],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(models[27],_testData[29], false);
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
FROM gedaqtests.int64bigint0m m
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
FROM gedaqtests.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigint0M>();
                var secondItems1 = new List<FlatInt64bigint0M>();
                var secondItems2 = new List<FlatInt64bigint0M>();
                 ((IInt64SingleTypebigint)this).DbConnectionDynQuerySelectModelBatch(connection, 102, query1, 87, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                        FlatInt64bigint0M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[9],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[11],_testData[29], false);
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
FROM gedaqtests.int64bigint0m m
LEFT JOIN gedaqtests.int64bigint0mi mi ON mi.id = m.int64bigint0mi_id
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
                foreach(var batchResult in await ((IInt64SingleTypebigint)this).DbConnectionSTSelectModelBatchAsync(connection, 117, 74))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        Int64bigint0M.AssertModel(models[0],_testData[22], false);
                        Int64bigint0M.AssertModel(models[1],_testData[23], false);
                        Int64bigint0M.AssertModel(models[2],_testData[24], false);
                        Int64bigint0M.AssertModel(models[3],_testData[25], false);
                        Int64bigint0M.AssertModel(models[4],_testData[26], false);
                        Int64bigint0M.AssertModel(models[5],_testData[27], false);
                        Int64bigint0M.AssertModel(models[6],_testData[28], false);
                        Int64bigint0M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        Int64bigint0M.AssertModel(models[0],_testData[16], false);
                        Int64bigint0M.AssertModel(models[1],_testData[17], false);
                        Int64bigint0M.AssertModel(models[2],_testData[18], false);
                        Int64bigint0M.AssertModel(models[3],_testData[19], false);
                        Int64bigint0M.AssertModel(models[4],_testData[20], false);
                        Int64bigint0M.AssertModel(models[5],_testData[21], false);
                        Int64bigint0M.AssertModel(models[6],_testData[22], false);
                        Int64bigint0M.AssertModel(models[7],_testData[23], false);
                        Int64bigint0M.AssertModel(models[8],_testData[24], false);
                        Int64bigint0M.AssertModel(models[9],_testData[25], false);
                        Int64bigint0M.AssertModel(models[10],_testData[26], false);
                        Int64bigint0M.AssertModel(models[11],_testData[27], false);
                        Int64bigint0M.AssertModel(models[12],_testData[28], false);
                        Int64bigint0M.AssertModel(models[13],_testData[29], false);
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
                foreach(var batchResult in  ((IInt64SingleTypebigint)this).DbConnectionSTSelectModelBatch(connection, 63, 87))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        Int64bigint0M.AssertModel(models[0],_testData[12], false);
                        Int64bigint0M.AssertModel(models[1],_testData[13], false);
                        Int64bigint0M.AssertModel(models[2],_testData[14], false);
                        Int64bigint0M.AssertModel(models[3],_testData[15], false);
                        Int64bigint0M.AssertModel(models[4],_testData[16], false);
                        Int64bigint0M.AssertModel(models[5],_testData[17], false);
                        Int64bigint0M.AssertModel(models[6],_testData[18], false);
                        Int64bigint0M.AssertModel(models[7],_testData[19], false);
                        Int64bigint0M.AssertModel(models[8],_testData[20], false);
                        Int64bigint0M.AssertModel(models[9],_testData[21], false);
                        Int64bigint0M.AssertModel(models[10],_testData[22], false);
                        Int64bigint0M.AssertModel(models[11],_testData[23], false);
                        Int64bigint0M.AssertModel(models[12],_testData[24], false);
                        Int64bigint0M.AssertModel(models[13],_testData[25], false);
                        Int64bigint0M.AssertModel(models[14],_testData[26], false);
                        Int64bigint0M.AssertModel(models[15],_testData[27], false);
                        Int64bigint0M.AssertModel(models[16],_testData[28], false);
                        Int64bigint0M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        Int64bigint0M.AssertModel(models[0],_testData[18], false);
                        Int64bigint0M.AssertModel(models[1],_testData[19], false);
                        Int64bigint0M.AssertModel(models[2],_testData[20], false);
                        Int64bigint0M.AssertModel(models[3],_testData[21], false);
                        Int64bigint0M.AssertModel(models[4],_testData[22], false);
                        Int64bigint0M.AssertModel(models[5],_testData[23], false);
                        Int64bigint0M.AssertModel(models[6],_testData[24], false);
                        Int64bigint0M.AssertModel(models[7],_testData[25], false);
                        Int64bigint0M.AssertModel(models[8],_testData[26], false);
                        Int64bigint0M.AssertModel(models[9],_testData[27], false);
                        Int64bigint0M.AssertModel(models[10],_testData[28], false);
                        Int64bigint0M.AssertModel(models[11],_testData[29], false);
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
                ((IInt64SingleTypebigint)this).SetDbConnectionSelectModelParametrs(cmd, 79);
                var models = await ((IInt64SingleTypebigint)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(13));
Int64bigint0M.AssertModel(models[0],_testData[17], false);Int64bigint0M.AssertModel(models[1],_testData[18], false);Int64bigint0M.AssertModel(models[2],_testData[19], false);Int64bigint0M.AssertModel(models[3],_testData[20], false);Int64bigint0M.AssertModel(models[4],_testData[21], false);Int64bigint0M.AssertModel(models[5],_testData[22], false);Int64bigint0M.AssertModel(models[6],_testData[23], false);Int64bigint0M.AssertModel(models[7],_testData[24], false);Int64bigint0M.AssertModel(models[8],_testData[25], false);Int64bigint0M.AssertModel(models[9],_testData[26], false);Int64bigint0M.AssertModel(models[10],_testData[27], false);Int64bigint0M.AssertModel(models[11],_testData[28], false);Int64bigint0M.AssertModel(models[12],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt64SingleTypebigint)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt64SingleTypebigint)this).SetDbConnectionSelectModelParametrs(cmd, 139);
                var models =  ((IInt64SingleTypebigint)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(3));
Int64bigint0M.AssertModel(models[0],_testData[27], false);Int64bigint0M.AssertModel(models[1],_testData[28], false);Int64bigint0M.AssertModel(models[2],_testData[29], false);
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
FROM gedaqtests.int64bigint0m m
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
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4972313500075450560L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((11)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6666654772290215571L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((1240884968222372339L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((4567124389901396409L)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4356197669659031351L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((841905055167283482L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((2367586801719941918L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5056866039267675976L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((5827460520253756291L)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((870597339562081513L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((7950045472194947465L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((6267300254692747267L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((4586366442338638523L)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2945027354002966360L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((6421621965141008179L)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((734298845822741527L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((2039689531558659426L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3164888003207929395L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((3054248561932269055L)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((53)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6816789828542407053L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((2185978054120978505L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((5948636990667373346L)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6241116610016513902L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((9133396721788350828L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((8374934533858541575L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8729525454551793302L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((9173933805152321289L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((6704028217081510764L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((3363082833372114626L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((4313168298678253380L)));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((986318209472250130L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((5323358229551851134L)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((74)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4656862249319469314L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((7575946564056889212L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((986258941677249351L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((5753618330851400725L)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((869418664031595381L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((6067869062474140625L)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1572334289737477795L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((3585255476980650930L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((6504749881066833586L)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((931946907063678650L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6926490183447720007L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((7644206024989959789L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((572303897625122873L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((6667538739236198046L)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3423493735852846971L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1045680700183161258L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((3490768850627684566L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((608888734911819852L)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6498595646446239368L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((749740367450327363L)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6445377152273837344L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((4747088631809440352L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((3452351782744942128L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7707588377482534669L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((5400586825343768864L)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4686869952917894089L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((7925872597637608904L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((7912144799739496368L)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8248223865234070929L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2124040618274820274L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((5628469177315164935L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((152)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((682401655479119082L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8896934996051131514L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((3016138741570862099L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((1734275031042981999L)));//InnerModel.NullableValue

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
                Assert.That((System.Int64)model[1], Is.EqualTo((4972313500075450560L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((11)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6666654772290215571L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((1240884968222372339L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((4567124389901396409L)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4356197669659031351L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((841905055167283482L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((2367586801719941918L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5056866039267675976L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((5827460520253756291L)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((870597339562081513L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((7950045472194947465L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((6267300254692747267L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((4586366442338638523L)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2945027354002966360L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((6421621965141008179L)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((734298845822741527L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((2039689531558659426L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3164888003207929395L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((3054248561932269055L)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((53)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6816789828542407053L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((2185978054120978505L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((5948636990667373346L)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6241116610016513902L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((9133396721788350828L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((8374934533858541575L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8729525454551793302L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((9173933805152321289L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((6704028217081510764L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((3363082833372114626L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((4313168298678253380L)));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((986318209472250130L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((5323358229551851134L)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((74)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4656862249319469314L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((7575946564056889212L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((986258941677249351L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((5753618330851400725L)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((869418664031595381L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((6067869062474140625L)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1572334289737477795L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((3585255476980650930L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((6504749881066833586L)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((931946907063678650L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6926490183447720007L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((7644206024989959789L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((572303897625122873L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((6667538739236198046L)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3423493735852846971L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1045680700183161258L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((3490768850627684566L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((608888734911819852L)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6498595646446239368L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((749740367450327363L)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6445377152273837344L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((4747088631809440352L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((3452351782744942128L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7707588377482534669L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((5400586825343768864L)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4686869952917894089L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((7925872597637608904L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((7912144799739496368L)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8248223865234070929L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2124040618274820274L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((5628469177315164935L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((152)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((682401655479119082L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8896934996051131514L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((3016138741570862099L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((1734275031042981999L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

#endregion

    }
}

