

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
    internal partial interface IInt32SingleTypeint
    {
    }
    
    internal partial class Int32SingleTypeint : IInt32SingleTypeint
    {


#region TestData

        private readonly Int32intE0M[] _testData = new Int32intE0M[]
        {
            new Int32intE0M
{
    Id = 2,
    Value = 719150243,
    ModelInner = null,
    NullableValue = null,
},
            new Int32intE0M
{
    Id = 10,
    Value = 303509118,
    ModelInner = new Int32intE0MI
{
    Id = 3,
    Value = 573190036,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32intE0M
{
    Id = 14,
    Value = 420950529,
    ModelInner = null,
    NullableValue = null,
},
            new Int32intE0M
{
    Id = 23,
    Value = 2036489993,
    ModelInner = new Int32intE0MI
{
    Id = 8,
    Value = 768127498,
    NullableValue = 1597465149,
},
    NullableValue = null,
},
            new Int32intE0M
{
    Id = 26,
    Value = 2129290910,
    ModelInner = null,
    NullableValue = null,
},
            new Int32intE0M
{
    Id = 27,
    Value = 1165786626,
    ModelInner = new Int32intE0MI
{
    Id = 16,
    Value = 2095205264,
    NullableValue = 1276842482,
},
    NullableValue = 1324172017,
},
            new Int32intE0M
{
    Id = 34,
    Value = 723564208,
    ModelInner = null,
    NullableValue = 589883435,
},
            new Int32intE0M
{
    Id = 36,
    Value = 1249455325,
    ModelInner = new Int32intE0MI
{
    Id = 17,
    Value = 520819189,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32intE0M
{
    Id = 40,
    Value = 491078166,
    ModelInner = null,
    NullableValue = 1698777299,
},
            new Int32intE0M
{
    Id = 46,
    Value = 706605139,
    ModelInner = new Int32intE0MI
{
    Id = 19,
    Value = 550611412,
    NullableValue = 1229263837,
},
    NullableValue = 1090182551,
},
            new Int32intE0M
{
    Id = 50,
    Value = 1308369497,
    ModelInner = null,
    NullableValue = null,
},
            new Int32intE0M
{
    Id = 58,
    Value = 130691753,
    ModelInner = new Int32intE0MI
{
    Id = 25,
    Value = 132604720,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32intE0M
{
    Id = 62,
    Value = 1739704719,
    ModelInner = null,
    NullableValue = 981362441,
},
            new Int32intE0M
{
    Id = 65,
    Value = 993984800,
    ModelInner = new Int32intE0MI
{
    Id = 29,
    Value = 195485386,
    NullableValue = 374950154,
},
    NullableValue = 488546354,
},
            new Int32intE0M
{
    Id = 71,
    Value = 277772918,
    ModelInner = null,
    NullableValue = null,
},
            new Int32intE0M
{
    Id = 73,
    Value = 1513065227,
    ModelInner = new Int32intE0MI
{
    Id = 30,
    Value = 1143511043,
    NullableValue = 1162614639,
},
    NullableValue = 1496529403,
},
            new Int32intE0M
{
    Id = 77,
    Value = 2064957534,
    ModelInner = null,
    NullableValue = null,
},
            new Int32intE0M
{
    Id = 85,
    Value = 1390645179,
    ModelInner = new Int32intE0MI
{
    Id = 37,
    Value = 1237135860,
    NullableValue = null,
},
    NullableValue = 130124278,
},
            new Int32intE0M
{
    Id = 88,
    Value = 1558530789,
    ModelInner = null,
    NullableValue = 1185575187,
},
            new Int32intE0M
{
    Id = 97,
    Value = 1413510094,
    ModelInner = new Int32intE0MI
{
    Id = 45,
    Value = 331556728,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32intE0M
{
    Id = 99,
    Value = 1487790993,
    ModelInner = null,
    NullableValue = 759248369,
},
            new Int32intE0M
{
    Id = 107,
    Value = 1462760731,
    ModelInner = new Int32intE0MI
{
    Id = 46,
    Value = 1696866865,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32intE0M
{
    Id = 116,
    Value = 1528556853,
    ModelInner = null,
    NullableValue = null,
},
            new Int32intE0M
{
    Id = 119,
    Value = 1044218674,
    ModelInner = new Int32intE0MI
{
    Id = 49,
    Value = 559448963,
    NullableValue = 1772227013,
},
    NullableValue = null,
},
            new Int32intE0M
{
    Id = 123,
    Value = 285914905,
    ModelInner = null,
    NullableValue = null,
},
            new Int32intE0M
{
    Id = 126,
    Value = 855986033,
    ModelInner = new Int32intE0MI
{
    Id = 52,
    Value = 134426636,
    NullableValue = 1043444408,
},
    NullableValue = 1250878271,
},
            new Int32intE0M
{
    Id = 127,
    Value = 1701945614,
    ModelInner = null,
    NullableValue = null,
},
            new Int32intE0M
{
    Id = 133,
    Value = 1377650041,
    ModelInner = new Int32intE0MI
{
    Id = 61,
    Value = 1952323630,
    NullableValue = null,
},
    NullableValue = 1404127039,
},
            new Int32intE0M
{
    Id = 136,
    Value = 1840789304,
    ModelInner = null,
    NullableValue = null,
},
            new Int32intE0M
{
    Id = 140,
    Value = 125476680,
    ModelInner = new Int32intE0MI
{
    Id = 63,
    Value = 373143405,
    NullableValue = 533754524,
},
    NullableValue = null,
},
            new Int32intE0M
{
    Id = 144,
    Value = 1974429463,
    ModelInner = null,
    NullableValue = null,
},
            new Int32intE0M
{
    Id = 152,
    Value = 1866558549,
    ModelInner = new Int32intE0MI
{
    Id = 65,
    Value = 595426780,
    NullableValue = null,
},
    NullableValue = 342419282,
},
            new Int32intE0M
{
    Id = 161,
    Value = 703397451,
    ModelInner = null,
    NullableValue = null,
},
            new Int32intE0M
{
    Id = 167,
    Value = 134209846,
    ModelInner = new Int32intE0MI
{
    Id = 74,
    Value = 1234461172,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32intE0M
{
    Id = 170,
    Value = 536061333,
    ModelInner = null,
    NullableValue = 37227228,
},
        };

#endregion

#region InsertModelInner

[Gedaq.SqlClient.Attributes.Query(
            query: @"
INSERT INTO dbo.int32inte0mi(
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
            asPartInterface: typeof(IInt32SingleTypeint)), 
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                parametrName: "id",
                methodParametrName: "id", 
                dbType: (System.Data.SqlDbType)(8)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                parametrName: "value",
                methodParametrName: "value",
                dbType: (System.Data.SqlDbType)(8)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "nullablevalue",
                methodParametrName: "nullablevalue",
                dbType: (System.Data.SqlDbType)(8))
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

                changedRows =  ((IInt32SingleTypeint)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IInt32SingleTypeint)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IInt32SingleTypeint)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO dbo.int32inte0mi(
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
            asPartInterface: typeof(IInt32SingleTypeint)), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)11),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)11),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)11, 
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

                changedRows =  ((IInt32SingleTypeint)this).DbConnectionInsertInnerModel(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
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

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertInnerModelAsync(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertInnerModelAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertInnerModelAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertInnerModelAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertInnerModelAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertInnerModelAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertInnerModelAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertInnerModelAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertInnerModelAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertInnerModelAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertInnerModelAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertInnerModelAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.SqlClient.Attributes.Query(
            query: @"
INSERT INTO dbo.int32inte0m(
	id,
    value,
    nullablevalue,
    int32inte0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @int32inte0mi_id
)
",
            methodName:"InsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeint)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                parametrName: "id",
                methodParametrName: "id",
                dbType: (System.Data.SqlDbType)(8)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.SqlDbType)(8)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.SqlDbType)(8),
                nullable: true),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "int32inte0mi_id", 
                methodParametrName: "int32inte0mi_id", 
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

                changedRows =  ((IInt32SingleTypeint)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IInt32SingleTypeint)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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

                changedRows = await ((IInt32SingleTypeint)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO dbo.int32inte0m(
	id,
    value,
    nullablevalue,
    int32inte0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @int32inte0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeint)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)11),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)11),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)11,
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "int32inte0mi_id", 
                methodParametrName: "int32inte0mi_id", 
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

                changedRows =  ((IInt32SingleTypeint)this).DbConnectionInsertModel(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IInt32SingleTypeint)this).DbConnectionInsertModel(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
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

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt32SingleTypeint)this).DbConnectionInsertModelAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt32intE0M), typeof(FlatInt32intE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeint)),
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
FROM dbo.int32inte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt32intE0M>();
                var models2 = new List<FlatInt32intE0M>();
                await((IInt32SingleTypeint)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32intE0M.AssertModel(models1[i],_testData[i], false);
                    FlatInt32intE0M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.int32inte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt32intE0M>();
                var models2 = new List<FlatInt32intE0M>();
                ((IInt32SingleTypeint)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32intE0M.AssertModel(models1[i],_testData[i], false);
                    FlatInt32intE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt32intE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeint)),
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
FROM dbo.int32inte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models = await((IInt32SingleTypeint)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32intE0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.int32inte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models = ((IInt32SingleTypeint)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32intE0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.int32inte0m m
LEFT JOIN dbo.int32inte0mi mi ON mi.id = m.int32inte0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Int32intE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeint)),
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
                var models = await((IInt32SingleTypeint)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int32intE0M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IInt32SingleTypeint)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int32intE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt32intE0M), typeof(FlatInt32intE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeint)),
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
FROM dbo.int32inte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt32intE0M>();
                var models2 = new List<FlatInt32intE0M>();
                await((IInt32SingleTypeint)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32intE0M.AssertModel(models1[i],_testData[i], false);
                    FlatInt32intE0M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.int32inte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt32intE0M>();
                var models2 = new List<FlatInt32intE0M>();
                ((IInt32SingleTypeint)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32intE0M.AssertModel(models1[i],_testData[i], false);
                    FlatInt32intE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt32intE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeint)),
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
FROM dbo.int32inte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IInt32SingleTypeint)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32intE0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.int32inte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IInt32SingleTypeint)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32intE0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.int32inte0m m
LEFT JOIN dbo.int32inte0mi mi ON mi.id = m.int32inte0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Int32intE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeint)),
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
                var models = await((IInt32SingleTypeint)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int32intE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IInt32SingleTypeint)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int32intE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt32intE0M), typeof(FlatInt32intE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeint)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeint)),
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
            asPartInterface: typeof(IInt32SingleTypeint)),
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
FROM dbo.int32inte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt32intE0M>();
                var models2 = new List<FlatInt32intE0M>();
                await((IInt32SingleTypeint)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32intE0M.AssertModel(models1[i],_testData[i], false);
                    FlatInt32intE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 26;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 127;
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
FROM dbo.int32inte0m m
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
FROM dbo.int32inte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32intE0M>();
                var firstItems2 = new List<FlatInt32intE0M>();
                var secondItems1 = new List<FlatInt32intE0M>();
                var secondItems2 = new List<FlatInt32intE0M>();
                await ((IInt32SingleTypeint)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatInt32intE0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatInt32intE0M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatInt32intE0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatInt32intE0M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatInt32intE0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatInt32intE0M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatInt32intE0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatInt32intE0M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatInt32intE0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatInt32intE0M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatInt32intE0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatInt32intE0M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatInt32intE0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatInt32intE0M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatInt32intE0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatInt32intE0M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatInt32intE0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatInt32intE0M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatInt32intE0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatInt32intE0M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatInt32intE0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatInt32intE0M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatInt32intE0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatInt32intE0M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatInt32intE0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatInt32intE0M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatInt32intE0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatInt32intE0M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatInt32intE0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatInt32intE0M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatInt32intE0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatInt32intE0M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatInt32intE0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatInt32intE0M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatInt32intE0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatInt32intE0M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatInt32intE0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatInt32intE0M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatInt32intE0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatInt32intE0M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatInt32intE0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatInt32intE0M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatInt32intE0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatInt32intE0M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatInt32intE0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatInt32intE0M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatInt32intE0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatInt32intE0M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatInt32intE0M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatInt32intE0M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatInt32intE0M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatInt32intE0M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatInt32intE0M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatInt32intE0M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatInt32intE0M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatInt32intE0M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatInt32intE0M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatInt32intE0M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatInt32intE0M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatInt32intE0M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatInt32intE0M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatInt32intE0M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatInt32intE0M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatInt32intE0M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatInt32intE0M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatInt32intE0M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatInt32intE0M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatInt32intE0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatInt32intE0M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatInt32intE0M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatInt32intE0M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatInt32intE0M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatInt32intE0M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatInt32intE0M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatInt32intE0M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatInt32intE0M.AssertModel(secondItems2[7],_testData[34], false);
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
                parametr2.Value = 34;
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
FROM dbo.int32inte0m m
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
FROM dbo.int32inte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32intE0M>();
                var firstItems2 = new List<FlatInt32intE0M>();
                var secondItems1 = new List<FlatInt32intE0M>();
                await ((IInt32SingleTypeint)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatInt32intE0M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatInt32intE0M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatInt32intE0M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatInt32intE0M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatInt32intE0M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatInt32intE0M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatInt32intE0M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatInt32intE0M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatInt32intE0M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatInt32intE0M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatInt32intE0M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatInt32intE0M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatInt32intE0M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatInt32intE0M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatInt32intE0M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatInt32intE0M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatInt32intE0M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatInt32intE0M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatInt32intE0M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatInt32intE0M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatInt32intE0M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatInt32intE0M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatInt32intE0M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatInt32intE0M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatInt32intE0M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatInt32intE0M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatInt32intE0M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatInt32intE0M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatInt32intE0M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatInt32intE0M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatInt32intE0M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatInt32intE0M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatInt32intE0M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatInt32intE0M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatInt32intE0M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatInt32intE0M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatInt32intE0M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatInt32intE0M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatInt32intE0M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatInt32intE0M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatInt32intE0M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatInt32intE0M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatInt32intE0M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatInt32intE0M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatInt32intE0M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatInt32intE0M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatInt32intE0M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatInt32intE0M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatInt32intE0M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatInt32intE0M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatInt32intE0M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatInt32intE0M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatInt32intE0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatInt32intE0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatInt32intE0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatInt32intE0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatInt32intE0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatInt32intE0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatInt32intE0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatInt32intE0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatInt32intE0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatInt32intE0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatInt32intE0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatInt32intE0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatInt32intE0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatInt32intE0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatInt32intE0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatInt32intE0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatInt32intE0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatInt32intE0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatInt32intE0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatInt32intE0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatInt32intE0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatInt32intE0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatInt32intE0M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatInt32intE0M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatInt32intE0M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatInt32intE0M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatInt32intE0M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatInt32intE0M.AssertModel(secondItems1[27],_testData[34], false);
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
FROM dbo.int32inte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt32intE0M>();
                var models2 = new List<FlatInt32intE0M>();
                ((IInt32SingleTypeint)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32intE0M.AssertModel(models1[i],_testData[i], false);
                    FlatInt32intE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 73;
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
FROM dbo.int32inte0m m
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
FROM dbo.int32inte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32intE0M>();
                var firstItems2 = new List<FlatInt32intE0M>();
                var secondItems1 = new List<FlatInt32intE0M>();
                var secondItems2 = new List<FlatInt32intE0M>();
                 ((IInt32SingleTypeint)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatInt32intE0M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatInt32intE0M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatInt32intE0M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatInt32intE0M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatInt32intE0M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatInt32intE0M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatInt32intE0M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatInt32intE0M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatInt32intE0M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatInt32intE0M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatInt32intE0M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatInt32intE0M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatInt32intE0M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatInt32intE0M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatInt32intE0M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatInt32intE0M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatInt32intE0M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatInt32intE0M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatInt32intE0M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatInt32intE0M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatInt32intE0M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatInt32intE0M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatInt32intE0M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatInt32intE0M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatInt32intE0M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatInt32intE0M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatInt32intE0M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatInt32intE0M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatInt32intE0M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatInt32intE0M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatInt32intE0M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatInt32intE0M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatInt32intE0M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatInt32intE0M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatInt32intE0M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatInt32intE0M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatInt32intE0M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatInt32intE0M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatInt32intE0M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatInt32intE0M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatInt32intE0M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatInt32intE0M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatInt32intE0M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatInt32intE0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatInt32intE0M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatInt32intE0M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatInt32intE0M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatInt32intE0M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatInt32intE0M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatInt32intE0M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatInt32intE0M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatInt32intE0M.AssertModel(secondItems2[6],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 26;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 2;
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
FROM dbo.int32inte0m m
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
FROM dbo.int32inte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32intE0M>();
                var firstItems2 = new List<FlatInt32intE0M>();
                var secondItems1 = new List<FlatInt32intE0M>();
                 ((IInt32SingleTypeint)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatInt32intE0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatInt32intE0M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatInt32intE0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatInt32intE0M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatInt32intE0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatInt32intE0M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatInt32intE0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatInt32intE0M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatInt32intE0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatInt32intE0M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatInt32intE0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatInt32intE0M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatInt32intE0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatInt32intE0M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatInt32intE0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatInt32intE0M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatInt32intE0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatInt32intE0M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatInt32intE0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatInt32intE0M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatInt32intE0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatInt32intE0M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatInt32intE0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatInt32intE0M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatInt32intE0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatInt32intE0M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatInt32intE0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatInt32intE0M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatInt32intE0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatInt32intE0M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatInt32intE0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatInt32intE0M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatInt32intE0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatInt32intE0M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatInt32intE0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatInt32intE0M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatInt32intE0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatInt32intE0M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatInt32intE0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatInt32intE0M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatInt32intE0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatInt32intE0M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatInt32intE0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatInt32intE0M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatInt32intE0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatInt32intE0M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatInt32intE0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatInt32intE0M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatInt32intE0M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatInt32intE0M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatInt32intE0M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatInt32intE0M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatInt32intE0M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatInt32intE0M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatInt32intE0M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatInt32intE0M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatInt32intE0M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatInt32intE0M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatInt32intE0M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatInt32intE0M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                        FlatInt32intE0M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatInt32intE0M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatInt32intE0M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatInt32intE0M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatInt32intE0M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatInt32intE0M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatInt32intE0M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatInt32intE0M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatInt32intE0M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatInt32intE0M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatInt32intE0M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatInt32intE0M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatInt32intE0M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatInt32intE0M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatInt32intE0M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatInt32intE0M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatInt32intE0M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatInt32intE0M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatInt32intE0M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatInt32intE0M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatInt32intE0M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatInt32intE0M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatInt32intE0M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatInt32intE0M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatInt32intE0M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatInt32intE0M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatInt32intE0M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatInt32intE0M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatInt32intE0M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatInt32intE0M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatInt32intE0M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatInt32intE0M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatInt32intE0M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatInt32intE0M.AssertModel(secondItems1[33],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt32intE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeint)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeint)),
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
            asPartInterface: typeof(IInt32SingleTypeint)),
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
FROM dbo.int32inte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IInt32SingleTypeint)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32intE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 107;
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
FROM dbo.int32inte0m m
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
FROM dbo.int32inte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt32SingleTypeint)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatInt32intE0M.AssertModel(models[0],_testData[22], false);
                        FlatInt32intE0M.AssertModel(models[1],_testData[23], false);
                        FlatInt32intE0M.AssertModel(models[2],_testData[24], false);
                        FlatInt32intE0M.AssertModel(models[3],_testData[25], false);
                        FlatInt32intE0M.AssertModel(models[4],_testData[26], false);
                        FlatInt32intE0M.AssertModel(models[5],_testData[27], false);
                        FlatInt32intE0M.AssertModel(models[6],_testData[28], false);
                        FlatInt32intE0M.AssertModel(models[7],_testData[29], false);
                        FlatInt32intE0M.AssertModel(models[8],_testData[30], false);
                        FlatInt32intE0M.AssertModel(models[9],_testData[31], false);
                        FlatInt32intE0M.AssertModel(models[10],_testData[32], false);
                        FlatInt32intE0M.AssertModel(models[11],_testData[33], false);
                        FlatInt32intE0M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatInt32intE0M.AssertModel(models[0],_testData[3], false);
                        FlatInt32intE0M.AssertModel(models[1],_testData[4], false);
                        FlatInt32intE0M.AssertModel(models[2],_testData[5], false);
                        FlatInt32intE0M.AssertModel(models[3],_testData[6], false);
                        FlatInt32intE0M.AssertModel(models[4],_testData[7], false);
                        FlatInt32intE0M.AssertModel(models[5],_testData[8], false);
                        FlatInt32intE0M.AssertModel(models[6],_testData[9], false);
                        FlatInt32intE0M.AssertModel(models[7],_testData[10], false);
                        FlatInt32intE0M.AssertModel(models[8],_testData[11], false);
                        FlatInt32intE0M.AssertModel(models[9],_testData[12], false);
                        FlatInt32intE0M.AssertModel(models[10],_testData[13], false);
                        FlatInt32intE0M.AssertModel(models[11],_testData[14], false);
                        FlatInt32intE0M.AssertModel(models[12],_testData[15], false);
                        FlatInt32intE0M.AssertModel(models[13],_testData[16], false);
                        FlatInt32intE0M.AssertModel(models[14],_testData[17], false);
                        FlatInt32intE0M.AssertModel(models[15],_testData[18], false);
                        FlatInt32intE0M.AssertModel(models[16],_testData[19], false);
                        FlatInt32intE0M.AssertModel(models[17],_testData[20], false);
                        FlatInt32intE0M.AssertModel(models[18],_testData[21], false);
                        FlatInt32intE0M.AssertModel(models[19],_testData[22], false);
                        FlatInt32intE0M.AssertModel(models[20],_testData[23], false);
                        FlatInt32intE0M.AssertModel(models[21],_testData[24], false);
                        FlatInt32intE0M.AssertModel(models[22],_testData[25], false);
                        FlatInt32intE0M.AssertModel(models[23],_testData[26], false);
                        FlatInt32intE0M.AssertModel(models[24],_testData[27], false);
                        FlatInt32intE0M.AssertModel(models[25],_testData[28], false);
                        FlatInt32intE0M.AssertModel(models[26],_testData[29], false);
                        FlatInt32intE0M.AssertModel(models[27],_testData[30], false);
                        FlatInt32intE0M.AssertModel(models[28],_testData[31], false);
                        FlatInt32intE0M.AssertModel(models[29],_testData[32], false);
                        FlatInt32intE0M.AssertModel(models[30],_testData[33], false);
                        FlatInt32intE0M.AssertModel(models[31],_testData[34], false);
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
                parametr1.Value = 36;
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
FROM dbo.int32inte0m m
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
FROM dbo.int32inte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32intE0M>();
                var secondItems1 = new List<FlatInt32intE0M>();
                var secondItems2 = new List<FlatInt32intE0M>();
                await ((IInt32SingleTypeint)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatInt32intE0M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatInt32intE0M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatInt32intE0M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatInt32intE0M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatInt32intE0M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatInt32intE0M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatInt32intE0M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatInt32intE0M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatInt32intE0M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatInt32intE0M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatInt32intE0M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatInt32intE0M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatInt32intE0M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatInt32intE0M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatInt32intE0M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatInt32intE0M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatInt32intE0M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatInt32intE0M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatInt32intE0M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatInt32intE0M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatInt32intE0M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatInt32intE0M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatInt32intE0M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatInt32intE0M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatInt32intE0M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatInt32intE0M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatInt32intE0M.AssertModel(firstItems1[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatInt32intE0M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatInt32intE0M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatInt32intE0M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatInt32intE0M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatInt32intE0M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatInt32intE0M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatInt32intE0M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatInt32intE0M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatInt32intE0M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatInt32intE0M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatInt32intE0M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatInt32intE0M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatInt32intE0M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatInt32intE0M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatInt32intE0M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatInt32intE0M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatInt32intE0M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatInt32intE0M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatInt32intE0M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatInt32intE0M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatInt32intE0M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatInt32intE0M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatInt32intE0M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatInt32intE0M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatInt32intE0M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatInt32intE0M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatInt32intE0M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatInt32intE0M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatInt32intE0M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatInt32intE0M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatInt32intE0M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatInt32intE0M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatInt32intE0M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatInt32intE0M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatInt32intE0M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatInt32intE0M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatInt32intE0M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatInt32intE0M.AssertModel(secondItems2[18],_testData[34], false);
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
FROM dbo.int32inte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IInt32SingleTypeint)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32intE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 107;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 116;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.int32inte0m m
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
FROM dbo.int32inte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt32SingleTypeint)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatInt32intE0M.AssertModel(models[0],_testData[22], false);
                        FlatInt32intE0M.AssertModel(models[1],_testData[23], false);
                        FlatInt32intE0M.AssertModel(models[2],_testData[24], false);
                        FlatInt32intE0M.AssertModel(models[3],_testData[25], false);
                        FlatInt32intE0M.AssertModel(models[4],_testData[26], false);
                        FlatInt32intE0M.AssertModel(models[5],_testData[27], false);
                        FlatInt32intE0M.AssertModel(models[6],_testData[28], false);
                        FlatInt32intE0M.AssertModel(models[7],_testData[29], false);
                        FlatInt32intE0M.AssertModel(models[8],_testData[30], false);
                        FlatInt32intE0M.AssertModel(models[9],_testData[31], false);
                        FlatInt32intE0M.AssertModel(models[10],_testData[32], false);
                        FlatInt32intE0M.AssertModel(models[11],_testData[33], false);
                        FlatInt32intE0M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatInt32intE0M.AssertModel(models[0],_testData[23], false);
                        FlatInt32intE0M.AssertModel(models[1],_testData[24], false);
                        FlatInt32intE0M.AssertModel(models[2],_testData[25], false);
                        FlatInt32intE0M.AssertModel(models[3],_testData[26], false);
                        FlatInt32intE0M.AssertModel(models[4],_testData[27], false);
                        FlatInt32intE0M.AssertModel(models[5],_testData[28], false);
                        FlatInt32intE0M.AssertModel(models[6],_testData[29], false);
                        FlatInt32intE0M.AssertModel(models[7],_testData[30], false);
                        FlatInt32intE0M.AssertModel(models[8],_testData[31], false);
                        FlatInt32intE0M.AssertModel(models[9],_testData[32], false);
                        FlatInt32intE0M.AssertModel(models[10],_testData[33], false);
                        FlatInt32intE0M.AssertModel(models[11],_testData[34], false);
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
                parametr1.Value = 119;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 34;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.int32inte0m m
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
FROM dbo.int32inte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32intE0M>();
                var secondItems1 = new List<FlatInt32intE0M>();
                var secondItems2 = new List<FlatInt32intE0M>();
                 ((IInt32SingleTypeint)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatInt32intE0M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatInt32intE0M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatInt32intE0M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatInt32intE0M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatInt32intE0M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatInt32intE0M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatInt32intE0M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatInt32intE0M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatInt32intE0M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatInt32intE0M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatInt32intE0M.AssertModel(firstItems1[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatInt32intE0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatInt32intE0M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatInt32intE0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatInt32intE0M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatInt32intE0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatInt32intE0M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatInt32intE0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatInt32intE0M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatInt32intE0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatInt32intE0M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatInt32intE0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatInt32intE0M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatInt32intE0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatInt32intE0M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatInt32intE0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatInt32intE0M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatInt32intE0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatInt32intE0M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatInt32intE0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatInt32intE0M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatInt32intE0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatInt32intE0M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatInt32intE0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatInt32intE0M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatInt32intE0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatInt32intE0M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatInt32intE0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatInt32intE0M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatInt32intE0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatInt32intE0M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatInt32intE0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatInt32intE0M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatInt32intE0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatInt32intE0M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatInt32intE0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatInt32intE0M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatInt32intE0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatInt32intE0M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatInt32intE0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatInt32intE0M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatInt32intE0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatInt32intE0M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatInt32intE0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatInt32intE0M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatInt32intE0M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatInt32intE0M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatInt32intE0M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatInt32intE0M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatInt32intE0M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatInt32intE0M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatInt32intE0M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatInt32intE0M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatInt32intE0M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatInt32intE0M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatInt32intE0M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatInt32intE0M.AssertModel(secondItems2[27],_testData[34], false);
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
FROM dbo.int32inte0m m
LEFT JOIN dbo.int32inte0mi mi ON mi.id = m.int32inte0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Int32intE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeint)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeint)),
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
                var models = await((IInt32SingleTypeint)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int32intE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 73;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 10;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt32SingleTypeint)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        Int32intE0M.AssertModel(models[0],_testData[16], false);
                        Int32intE0M.AssertModel(models[1],_testData[17], false);
                        Int32intE0M.AssertModel(models[2],_testData[18], false);
                        Int32intE0M.AssertModel(models[3],_testData[19], false);
                        Int32intE0M.AssertModel(models[4],_testData[20], false);
                        Int32intE0M.AssertModel(models[5],_testData[21], false);
                        Int32intE0M.AssertModel(models[6],_testData[22], false);
                        Int32intE0M.AssertModel(models[7],_testData[23], false);
                        Int32intE0M.AssertModel(models[8],_testData[24], false);
                        Int32intE0M.AssertModel(models[9],_testData[25], false);
                        Int32intE0M.AssertModel(models[10],_testData[26], false);
                        Int32intE0M.AssertModel(models[11],_testData[27], false);
                        Int32intE0M.AssertModel(models[12],_testData[28], false);
                        Int32intE0M.AssertModel(models[13],_testData[29], false);
                        Int32intE0M.AssertModel(models[14],_testData[30], false);
                        Int32intE0M.AssertModel(models[15],_testData[31], false);
                        Int32intE0M.AssertModel(models[16],_testData[32], false);
                        Int32intE0M.AssertModel(models[17],_testData[33], false);
                        Int32intE0M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        Int32intE0M.AssertModel(models[0],_testData[2], false);
                        Int32intE0M.AssertModel(models[1],_testData[3], false);
                        Int32intE0M.AssertModel(models[2],_testData[4], false);
                        Int32intE0M.AssertModel(models[3],_testData[5], false);
                        Int32intE0M.AssertModel(models[4],_testData[6], false);
                        Int32intE0M.AssertModel(models[5],_testData[7], false);
                        Int32intE0M.AssertModel(models[6],_testData[8], false);
                        Int32intE0M.AssertModel(models[7],_testData[9], false);
                        Int32intE0M.AssertModel(models[8],_testData[10], false);
                        Int32intE0M.AssertModel(models[9],_testData[11], false);
                        Int32intE0M.AssertModel(models[10],_testData[12], false);
                        Int32intE0M.AssertModel(models[11],_testData[13], false);
                        Int32intE0M.AssertModel(models[12],_testData[14], false);
                        Int32intE0M.AssertModel(models[13],_testData[15], false);
                        Int32intE0M.AssertModel(models[14],_testData[16], false);
                        Int32intE0M.AssertModel(models[15],_testData[17], false);
                        Int32intE0M.AssertModel(models[16],_testData[18], false);
                        Int32intE0M.AssertModel(models[17],_testData[19], false);
                        Int32intE0M.AssertModel(models[18],_testData[20], false);
                        Int32intE0M.AssertModel(models[19],_testData[21], false);
                        Int32intE0M.AssertModel(models[20],_testData[22], false);
                        Int32intE0M.AssertModel(models[21],_testData[23], false);
                        Int32intE0M.AssertModel(models[22],_testData[24], false);
                        Int32intE0M.AssertModel(models[23],_testData[25], false);
                        Int32intE0M.AssertModel(models[24],_testData[26], false);
                        Int32intE0M.AssertModel(models[25],_testData[27], false);
                        Int32intE0M.AssertModel(models[26],_testData[28], false);
                        Int32intE0M.AssertModel(models[27],_testData[29], false);
                        Int32intE0M.AssertModel(models[28],_testData[30], false);
                        Int32intE0M.AssertModel(models[29],_testData[31], false);
                        Int32intE0M.AssertModel(models[30],_testData[32], false);
                        Int32intE0M.AssertModel(models[31],_testData[33], false);
                        Int32intE0M.AssertModel(models[32],_testData[34], false);
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
                var models = ((IInt32SingleTypeint)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int32intE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 73;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 136;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt32SingleTypeint)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        Int32intE0M.AssertModel(models[0],_testData[16], false);
                        Int32intE0M.AssertModel(models[1],_testData[17], false);
                        Int32intE0M.AssertModel(models[2],_testData[18], false);
                        Int32intE0M.AssertModel(models[3],_testData[19], false);
                        Int32intE0M.AssertModel(models[4],_testData[20], false);
                        Int32intE0M.AssertModel(models[5],_testData[21], false);
                        Int32intE0M.AssertModel(models[6],_testData[22], false);
                        Int32intE0M.AssertModel(models[7],_testData[23], false);
                        Int32intE0M.AssertModel(models[8],_testData[24], false);
                        Int32intE0M.AssertModel(models[9],_testData[25], false);
                        Int32intE0M.AssertModel(models[10],_testData[26], false);
                        Int32intE0M.AssertModel(models[11],_testData[27], false);
                        Int32intE0M.AssertModel(models[12],_testData[28], false);
                        Int32intE0M.AssertModel(models[13],_testData[29], false);
                        Int32intE0M.AssertModel(models[14],_testData[30], false);
                        Int32intE0M.AssertModel(models[15],_testData[31], false);
                        Int32intE0M.AssertModel(models[16],_testData[32], false);
                        Int32intE0M.AssertModel(models[17],_testData[33], false);
                        Int32intE0M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        Int32intE0M.AssertModel(models[0],_testData[29], false);
                        Int32intE0M.AssertModel(models[1],_testData[30], false);
                        Int32intE0M.AssertModel(models[2],_testData[31], false);
                        Int32intE0M.AssertModel(models[3],_testData[32], false);
                        Int32intE0M.AssertModel(models[4],_testData[33], false);
                        Int32intE0M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt32intE0M), typeof(FlatInt32intE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeint)),
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
            asPartInterface: typeof(IInt32SingleTypeint)),
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
            asPartInterface: typeof(IInt32SingleTypeint)),
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
FROM dbo.int32inte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt32intE0M>();
                var models2 = new List<FlatInt32intE0M>();
                await((IInt32SingleTypeint)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32intE0M.AssertModel(models1[i],_testData[i], false);
                    FlatInt32intE0M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.int32inte0m m
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
FROM dbo.int32inte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32intE0M>();
                var firstItems2 = new List<FlatInt32intE0M>();
                var secondItems1 = new List<FlatInt32intE0M>();
                var secondItems2 = new List<FlatInt32intE0M>();
                await ((IInt32SingleTypeint)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 36, query1, 27, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatInt32intE0M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatInt32intE0M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatInt32intE0M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatInt32intE0M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatInt32intE0M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatInt32intE0M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatInt32intE0M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatInt32intE0M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatInt32intE0M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatInt32intE0M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatInt32intE0M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatInt32intE0M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatInt32intE0M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatInt32intE0M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatInt32intE0M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatInt32intE0M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatInt32intE0M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatInt32intE0M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatInt32intE0M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatInt32intE0M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatInt32intE0M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatInt32intE0M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatInt32intE0M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatInt32intE0M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatInt32intE0M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatInt32intE0M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatInt32intE0M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatInt32intE0M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatInt32intE0M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatInt32intE0M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatInt32intE0M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatInt32intE0M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatInt32intE0M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatInt32intE0M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatInt32intE0M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatInt32intE0M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatInt32intE0M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatInt32intE0M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatInt32intE0M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatInt32intE0M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatInt32intE0M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatInt32intE0M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatInt32intE0M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatInt32intE0M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatInt32intE0M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatInt32intE0M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatInt32intE0M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatInt32intE0M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatInt32intE0M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatInt32intE0M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatInt32intE0M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatInt32intE0M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatInt32intE0M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatInt32intE0M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatInt32intE0M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatInt32intE0M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatInt32intE0M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatInt32intE0M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatInt32intE0M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatInt32intE0M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatInt32intE0M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatInt32intE0M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatInt32intE0M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatInt32intE0M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatInt32intE0M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatInt32intE0M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatInt32intE0M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatInt32intE0M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatInt32intE0M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatInt32intE0M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatInt32intE0M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatInt32intE0M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatInt32intE0M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatInt32intE0M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatInt32intE0M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatInt32intE0M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatInt32intE0M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatInt32intE0M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatInt32intE0M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatInt32intE0M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatInt32intE0M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatInt32intE0M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatInt32intE0M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatInt32intE0M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatInt32intE0M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatInt32intE0M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatInt32intE0M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatInt32intE0M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatInt32intE0M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatInt32intE0M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatInt32intE0M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatInt32intE0M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatInt32intE0M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatInt32intE0M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatInt32intE0M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatInt32intE0M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatInt32intE0M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatInt32intE0M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatInt32intE0M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatInt32intE0M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatInt32intE0M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatInt32intE0M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatInt32intE0M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatInt32intE0M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatInt32intE0M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatInt32intE0M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatInt32intE0M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatInt32intE0M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatInt32intE0M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatInt32intE0M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatInt32intE0M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatInt32intE0M.AssertModel(secondItems2[28],_testData[34], false);
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
FROM dbo.int32inte0m m
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
FROM dbo.int32inte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32intE0M>();
                var firstItems2 = new List<FlatInt32intE0M>();
                var secondItems1 = new List<FlatInt32intE0M>();
                await ((IInt32SingleTypeint)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 62, query1, 99, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatInt32intE0M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatInt32intE0M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatInt32intE0M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatInt32intE0M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatInt32intE0M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatInt32intE0M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatInt32intE0M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatInt32intE0M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatInt32intE0M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatInt32intE0M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatInt32intE0M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatInt32intE0M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatInt32intE0M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatInt32intE0M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatInt32intE0M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatInt32intE0M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatInt32intE0M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatInt32intE0M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatInt32intE0M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatInt32intE0M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatInt32intE0M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatInt32intE0M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatInt32intE0M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatInt32intE0M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatInt32intE0M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatInt32intE0M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatInt32intE0M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatInt32intE0M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatInt32intE0M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatInt32intE0M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatInt32intE0M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatInt32intE0M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatInt32intE0M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatInt32intE0M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatInt32intE0M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatInt32intE0M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatInt32intE0M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatInt32intE0M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatInt32intE0M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatInt32intE0M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatInt32intE0M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatInt32intE0M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatInt32intE0M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatInt32intE0M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                        FlatInt32intE0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatInt32intE0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatInt32intE0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatInt32intE0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatInt32intE0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatInt32intE0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatInt32intE0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatInt32intE0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatInt32intE0M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatInt32intE0M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatInt32intE0M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatInt32intE0M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatInt32intE0M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatInt32intE0M.AssertModel(secondItems1[13],_testData[34], false);
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
FROM dbo.int32inte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt32intE0M>();
                var models2 = new List<FlatInt32intE0M>();
                ((IInt32SingleTypeint)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32intE0M.AssertModel(models1[i],_testData[i], false);
                    FlatInt32intE0M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.int32inte0m m
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
FROM dbo.int32inte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32intE0M>();
                var firstItems2 = new List<FlatInt32intE0M>();
                var secondItems1 = new List<FlatInt32intE0M>();
                var secondItems2 = new List<FlatInt32intE0M>();
                 ((IInt32SingleTypeint)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 107, query1, 99, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatInt32intE0M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatInt32intE0M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatInt32intE0M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatInt32intE0M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatInt32intE0M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatInt32intE0M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatInt32intE0M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatInt32intE0M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatInt32intE0M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatInt32intE0M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatInt32intE0M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatInt32intE0M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatInt32intE0M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatInt32intE0M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatInt32intE0M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatInt32intE0M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatInt32intE0M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatInt32intE0M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatInt32intE0M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatInt32intE0M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatInt32intE0M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatInt32intE0M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatInt32intE0M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatInt32intE0M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatInt32intE0M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatInt32intE0M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatInt32intE0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatInt32intE0M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatInt32intE0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatInt32intE0M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatInt32intE0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatInt32intE0M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatInt32intE0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatInt32intE0M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatInt32intE0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatInt32intE0M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatInt32intE0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatInt32intE0M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatInt32intE0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatInt32intE0M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatInt32intE0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatInt32intE0M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatInt32intE0M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatInt32intE0M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatInt32intE0M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatInt32intE0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatInt32intE0M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatInt32intE0M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatInt32intE0M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatInt32intE0M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatInt32intE0M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatInt32intE0M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatInt32intE0M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatInt32intE0M.AssertModel(secondItems2[13],_testData[34], false);
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
FROM dbo.int32inte0m m
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
FROM dbo.int32inte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32intE0M>();
                var firstItems2 = new List<FlatInt32intE0M>();
                var secondItems1 = new List<FlatInt32intE0M>();
                 ((IInt32SingleTypeint)this).DbConnectionMMDynQuerySelectModelBatch(connection, 127, query1, 23, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatInt32intE0M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatInt32intE0M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatInt32intE0M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatInt32intE0M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatInt32intE0M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatInt32intE0M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatInt32intE0M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatInt32intE0M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatInt32intE0M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatInt32intE0M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatInt32intE0M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatInt32intE0M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatInt32intE0M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatInt32intE0M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatInt32intE0M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatInt32intE0M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                        FlatInt32intE0M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatInt32intE0M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatInt32intE0M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatInt32intE0M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatInt32intE0M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatInt32intE0M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatInt32intE0M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatInt32intE0M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatInt32intE0M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatInt32intE0M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatInt32intE0M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatInt32intE0M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatInt32intE0M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatInt32intE0M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatInt32intE0M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatInt32intE0M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatInt32intE0M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatInt32intE0M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatInt32intE0M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatInt32intE0M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatInt32intE0M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatInt32intE0M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatInt32intE0M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatInt32intE0M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatInt32intE0M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatInt32intE0M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatInt32intE0M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatInt32intE0M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatInt32intE0M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatInt32intE0M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatInt32intE0M.AssertModel(secondItems1[30],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt32intE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeint)),
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
            asPartInterface: typeof(IInt32SingleTypeint)),
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
            asPartInterface: typeof(IInt32SingleTypeint)),
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
FROM dbo.int32inte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IInt32SingleTypeint)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32intE0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.int32inte0m m
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
FROM dbo.int32inte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt32SingleTypeint)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 23, query1, 119, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatInt32intE0M.AssertModel(models[0],_testData[4], false);
                        FlatInt32intE0M.AssertModel(models[1],_testData[5], false);
                        FlatInt32intE0M.AssertModel(models[2],_testData[6], false);
                        FlatInt32intE0M.AssertModel(models[3],_testData[7], false);
                        FlatInt32intE0M.AssertModel(models[4],_testData[8], false);
                        FlatInt32intE0M.AssertModel(models[5],_testData[9], false);
                        FlatInt32intE0M.AssertModel(models[6],_testData[10], false);
                        FlatInt32intE0M.AssertModel(models[7],_testData[11], false);
                        FlatInt32intE0M.AssertModel(models[8],_testData[12], false);
                        FlatInt32intE0M.AssertModel(models[9],_testData[13], false);
                        FlatInt32intE0M.AssertModel(models[10],_testData[14], false);
                        FlatInt32intE0M.AssertModel(models[11],_testData[15], false);
                        FlatInt32intE0M.AssertModel(models[12],_testData[16], false);
                        FlatInt32intE0M.AssertModel(models[13],_testData[17], false);
                        FlatInt32intE0M.AssertModel(models[14],_testData[18], false);
                        FlatInt32intE0M.AssertModel(models[15],_testData[19], false);
                        FlatInt32intE0M.AssertModel(models[16],_testData[20], false);
                        FlatInt32intE0M.AssertModel(models[17],_testData[21], false);
                        FlatInt32intE0M.AssertModel(models[18],_testData[22], false);
                        FlatInt32intE0M.AssertModel(models[19],_testData[23], false);
                        FlatInt32intE0M.AssertModel(models[20],_testData[24], false);
                        FlatInt32intE0M.AssertModel(models[21],_testData[25], false);
                        FlatInt32intE0M.AssertModel(models[22],_testData[26], false);
                        FlatInt32intE0M.AssertModel(models[23],_testData[27], false);
                        FlatInt32intE0M.AssertModel(models[24],_testData[28], false);
                        FlatInt32intE0M.AssertModel(models[25],_testData[29], false);
                        FlatInt32intE0M.AssertModel(models[26],_testData[30], false);
                        FlatInt32intE0M.AssertModel(models[27],_testData[31], false);
                        FlatInt32intE0M.AssertModel(models[28],_testData[32], false);
                        FlatInt32intE0M.AssertModel(models[29],_testData[33], false);
                        FlatInt32intE0M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatInt32intE0M.AssertModel(models[0],_testData[24], false);
                        FlatInt32intE0M.AssertModel(models[1],_testData[25], false);
                        FlatInt32intE0M.AssertModel(models[2],_testData[26], false);
                        FlatInt32intE0M.AssertModel(models[3],_testData[27], false);
                        FlatInt32intE0M.AssertModel(models[4],_testData[28], false);
                        FlatInt32intE0M.AssertModel(models[5],_testData[29], false);
                        FlatInt32intE0M.AssertModel(models[6],_testData[30], false);
                        FlatInt32intE0M.AssertModel(models[7],_testData[31], false);
                        FlatInt32intE0M.AssertModel(models[8],_testData[32], false);
                        FlatInt32intE0M.AssertModel(models[9],_testData[33], false);
                        FlatInt32intE0M.AssertModel(models[10],_testData[34], false);
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
FROM dbo.int32inte0m m
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
FROM dbo.int32inte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32intE0M>();
                var secondItems1 = new List<FlatInt32intE0M>();
                var secondItems2 = new List<FlatInt32intE0M>();
                await ((IInt32SingleTypeint)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 97, query1, 26, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatInt32intE0M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatInt32intE0M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatInt32intE0M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatInt32intE0M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatInt32intE0M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatInt32intE0M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatInt32intE0M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatInt32intE0M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatInt32intE0M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatInt32intE0M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatInt32intE0M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatInt32intE0M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatInt32intE0M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatInt32intE0M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatInt32intE0M.AssertModel(firstItems1[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatInt32intE0M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatInt32intE0M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatInt32intE0M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatInt32intE0M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatInt32intE0M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatInt32intE0M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatInt32intE0M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatInt32intE0M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatInt32intE0M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatInt32intE0M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatInt32intE0M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatInt32intE0M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatInt32intE0M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatInt32intE0M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatInt32intE0M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatInt32intE0M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatInt32intE0M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatInt32intE0M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatInt32intE0M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatInt32intE0M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatInt32intE0M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatInt32intE0M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatInt32intE0M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatInt32intE0M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatInt32intE0M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatInt32intE0M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatInt32intE0M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatInt32intE0M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatInt32intE0M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatInt32intE0M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatInt32intE0M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatInt32intE0M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatInt32intE0M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatInt32intE0M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatInt32intE0M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatInt32intE0M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatInt32intE0M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatInt32intE0M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatInt32intE0M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatInt32intE0M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatInt32intE0M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatInt32intE0M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatInt32intE0M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatInt32intE0M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatInt32intE0M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatInt32intE0M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatInt32intE0M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatInt32intE0M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatInt32intE0M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatInt32intE0M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatInt32intE0M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatInt32intE0M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatInt32intE0M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatInt32intE0M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatInt32intE0M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatInt32intE0M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatInt32intE0M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatInt32intE0M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatInt32intE0M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatInt32intE0M.AssertModel(secondItems2[29],_testData[34], false);
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
FROM dbo.int32inte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IInt32SingleTypeint)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32intE0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.int32inte0m m
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
FROM dbo.int32inte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt32SingleTypeint)this).DbConnectionSTDynQuerySelectModelBatch(connection, 65, query1, 126, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatInt32intE0M.AssertModel(models[0],_testData[14], false);
                        FlatInt32intE0M.AssertModel(models[1],_testData[15], false);
                        FlatInt32intE0M.AssertModel(models[2],_testData[16], false);
                        FlatInt32intE0M.AssertModel(models[3],_testData[17], false);
                        FlatInt32intE0M.AssertModel(models[4],_testData[18], false);
                        FlatInt32intE0M.AssertModel(models[5],_testData[19], false);
                        FlatInt32intE0M.AssertModel(models[6],_testData[20], false);
                        FlatInt32intE0M.AssertModel(models[7],_testData[21], false);
                        FlatInt32intE0M.AssertModel(models[8],_testData[22], false);
                        FlatInt32intE0M.AssertModel(models[9],_testData[23], false);
                        FlatInt32intE0M.AssertModel(models[10],_testData[24], false);
                        FlatInt32intE0M.AssertModel(models[11],_testData[25], false);
                        FlatInt32intE0M.AssertModel(models[12],_testData[26], false);
                        FlatInt32intE0M.AssertModel(models[13],_testData[27], false);
                        FlatInt32intE0M.AssertModel(models[14],_testData[28], false);
                        FlatInt32intE0M.AssertModel(models[15],_testData[29], false);
                        FlatInt32intE0M.AssertModel(models[16],_testData[30], false);
                        FlatInt32intE0M.AssertModel(models[17],_testData[31], false);
                        FlatInt32intE0M.AssertModel(models[18],_testData[32], false);
                        FlatInt32intE0M.AssertModel(models[19],_testData[33], false);
                        FlatInt32intE0M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatInt32intE0M.AssertModel(models[0],_testData[26], false);
                        FlatInt32intE0M.AssertModel(models[1],_testData[27], false);
                        FlatInt32intE0M.AssertModel(models[2],_testData[28], false);
                        FlatInt32intE0M.AssertModel(models[3],_testData[29], false);
                        FlatInt32intE0M.AssertModel(models[4],_testData[30], false);
                        FlatInt32intE0M.AssertModel(models[5],_testData[31], false);
                        FlatInt32intE0M.AssertModel(models[6],_testData[32], false);
                        FlatInt32intE0M.AssertModel(models[7],_testData[33], false);
                        FlatInt32intE0M.AssertModel(models[8],_testData[34], false);
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
FROM dbo.int32inte0m m
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
FROM dbo.int32inte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32intE0M>();
                var secondItems1 = new List<FlatInt32intE0M>();
                var secondItems2 = new List<FlatInt32intE0M>();
                 ((IInt32SingleTypeint)this).DbConnectionDynQuerySelectModelBatch(connection, 127, query1, 140, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatInt32intE0M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatInt32intE0M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatInt32intE0M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatInt32intE0M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatInt32intE0M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatInt32intE0M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatInt32intE0M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatInt32intE0M.AssertModel(firstItems1[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatInt32intE0M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatInt32intE0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatInt32intE0M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatInt32intE0M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatInt32intE0M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatInt32intE0M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatInt32intE0M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatInt32intE0M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatInt32intE0M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatInt32intE0M.AssertModel(secondItems2[4],_testData[34], false);
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
FROM dbo.int32inte0m m
LEFT JOIN dbo.int32inte0mi mi ON mi.id = m.int32inte0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Int32intE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeint)),
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
            asPartInterface: typeof(IInt32SingleTypeint)),
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
                var models = await((IInt32SingleTypeint)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int32intE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IInt32SingleTypeint)this).DbConnectionSTSelectModelBatchAsync(connection, 62, 36))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        Int32intE0M.AssertModel(models[0],_testData[13], false);
                        Int32intE0M.AssertModel(models[1],_testData[14], false);
                        Int32intE0M.AssertModel(models[2],_testData[15], false);
                        Int32intE0M.AssertModel(models[3],_testData[16], false);
                        Int32intE0M.AssertModel(models[4],_testData[17], false);
                        Int32intE0M.AssertModel(models[5],_testData[18], false);
                        Int32intE0M.AssertModel(models[6],_testData[19], false);
                        Int32intE0M.AssertModel(models[7],_testData[20], false);
                        Int32intE0M.AssertModel(models[8],_testData[21], false);
                        Int32intE0M.AssertModel(models[9],_testData[22], false);
                        Int32intE0M.AssertModel(models[10],_testData[23], false);
                        Int32intE0M.AssertModel(models[11],_testData[24], false);
                        Int32intE0M.AssertModel(models[12],_testData[25], false);
                        Int32intE0M.AssertModel(models[13],_testData[26], false);
                        Int32intE0M.AssertModel(models[14],_testData[27], false);
                        Int32intE0M.AssertModel(models[15],_testData[28], false);
                        Int32intE0M.AssertModel(models[16],_testData[29], false);
                        Int32intE0M.AssertModel(models[17],_testData[30], false);
                        Int32intE0M.AssertModel(models[18],_testData[31], false);
                        Int32intE0M.AssertModel(models[19],_testData[32], false);
                        Int32intE0M.AssertModel(models[20],_testData[33], false);
                        Int32intE0M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        Int32intE0M.AssertModel(models[0],_testData[8], false);
                        Int32intE0M.AssertModel(models[1],_testData[9], false);
                        Int32intE0M.AssertModel(models[2],_testData[10], false);
                        Int32intE0M.AssertModel(models[3],_testData[11], false);
                        Int32intE0M.AssertModel(models[4],_testData[12], false);
                        Int32intE0M.AssertModel(models[5],_testData[13], false);
                        Int32intE0M.AssertModel(models[6],_testData[14], false);
                        Int32intE0M.AssertModel(models[7],_testData[15], false);
                        Int32intE0M.AssertModel(models[8],_testData[16], false);
                        Int32intE0M.AssertModel(models[9],_testData[17], false);
                        Int32intE0M.AssertModel(models[10],_testData[18], false);
                        Int32intE0M.AssertModel(models[11],_testData[19], false);
                        Int32intE0M.AssertModel(models[12],_testData[20], false);
                        Int32intE0M.AssertModel(models[13],_testData[21], false);
                        Int32intE0M.AssertModel(models[14],_testData[22], false);
                        Int32intE0M.AssertModel(models[15],_testData[23], false);
                        Int32intE0M.AssertModel(models[16],_testData[24], false);
                        Int32intE0M.AssertModel(models[17],_testData[25], false);
                        Int32intE0M.AssertModel(models[18],_testData[26], false);
                        Int32intE0M.AssertModel(models[19],_testData[27], false);
                        Int32intE0M.AssertModel(models[20],_testData[28], false);
                        Int32intE0M.AssertModel(models[21],_testData[29], false);
                        Int32intE0M.AssertModel(models[22],_testData[30], false);
                        Int32intE0M.AssertModel(models[23],_testData[31], false);
                        Int32intE0M.AssertModel(models[24],_testData[32], false);
                        Int32intE0M.AssertModel(models[25],_testData[33], false);
                        Int32intE0M.AssertModel(models[26],_testData[34], false);
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
                var models = ((IInt32SingleTypeint)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int32intE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IInt32SingleTypeint)this).DbConnectionSTSelectModelBatch(connection, 62, 123))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        Int32intE0M.AssertModel(models[0],_testData[13], false);
                        Int32intE0M.AssertModel(models[1],_testData[14], false);
                        Int32intE0M.AssertModel(models[2],_testData[15], false);
                        Int32intE0M.AssertModel(models[3],_testData[16], false);
                        Int32intE0M.AssertModel(models[4],_testData[17], false);
                        Int32intE0M.AssertModel(models[5],_testData[18], false);
                        Int32intE0M.AssertModel(models[6],_testData[19], false);
                        Int32intE0M.AssertModel(models[7],_testData[20], false);
                        Int32intE0M.AssertModel(models[8],_testData[21], false);
                        Int32intE0M.AssertModel(models[9],_testData[22], false);
                        Int32intE0M.AssertModel(models[10],_testData[23], false);
                        Int32intE0M.AssertModel(models[11],_testData[24], false);
                        Int32intE0M.AssertModel(models[12],_testData[25], false);
                        Int32intE0M.AssertModel(models[13],_testData[26], false);
                        Int32intE0M.AssertModel(models[14],_testData[27], false);
                        Int32intE0M.AssertModel(models[15],_testData[28], false);
                        Int32intE0M.AssertModel(models[16],_testData[29], false);
                        Int32intE0M.AssertModel(models[17],_testData[30], false);
                        Int32intE0M.AssertModel(models[18],_testData[31], false);
                        Int32intE0M.AssertModel(models[19],_testData[32], false);
                        Int32intE0M.AssertModel(models[20],_testData[33], false);
                        Int32intE0M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        Int32intE0M.AssertModel(models[0],_testData[25], false);
                        Int32intE0M.AssertModel(models[1],_testData[26], false);
                        Int32intE0M.AssertModel(models[2],_testData[27], false);
                        Int32intE0M.AssertModel(models[3],_testData[28], false);
                        Int32intE0M.AssertModel(models[4],_testData[29], false);
                        Int32intE0M.AssertModel(models[5],_testData[30], false);
                        Int32intE0M.AssertModel(models[6],_testData[31], false);
                        Int32intE0M.AssertModel(models[7],_testData[32], false);
                        Int32intE0M.AssertModel(models[8],_testData[33], false);
                        Int32intE0M.AssertModel(models[9],_testData[34], false);
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
                await using var cmd = await ((IInt32SingleTypeint)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IInt32SingleTypeint)this).SetDbConnectionSelectModelParametrs(cmd, 40);
                var models = await ((IInt32SingleTypeint)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(26));

                Int32intE0M.AssertModel(models[0],_testData[9], false);
                Int32intE0M.AssertModel(models[1],_testData[10], false);
                Int32intE0M.AssertModel(models[2],_testData[11], false);
                Int32intE0M.AssertModel(models[3],_testData[12], false);
                Int32intE0M.AssertModel(models[4],_testData[13], false);
                Int32intE0M.AssertModel(models[5],_testData[14], false);
                Int32intE0M.AssertModel(models[6],_testData[15], false);
                Int32intE0M.AssertModel(models[7],_testData[16], false);
                Int32intE0M.AssertModel(models[8],_testData[17], false);
                Int32intE0M.AssertModel(models[9],_testData[18], false);
                Int32intE0M.AssertModel(models[10],_testData[19], false);
                Int32intE0M.AssertModel(models[11],_testData[20], false);
                Int32intE0M.AssertModel(models[12],_testData[21], false);
                Int32intE0M.AssertModel(models[13],_testData[22], false);
                Int32intE0M.AssertModel(models[14],_testData[23], false);
                Int32intE0M.AssertModel(models[15],_testData[24], false);
                Int32intE0M.AssertModel(models[16],_testData[25], false);
                Int32intE0M.AssertModel(models[17],_testData[26], false);
                Int32intE0M.AssertModel(models[18],_testData[27], false);
                Int32intE0M.AssertModel(models[19],_testData[28], false);
                Int32intE0M.AssertModel(models[20],_testData[29], false);
                Int32intE0M.AssertModel(models[21],_testData[30], false);
                Int32intE0M.AssertModel(models[22],_testData[31], false);
                Int32intE0M.AssertModel(models[23],_testData[32], false);
                Int32intE0M.AssertModel(models[24],_testData[33], false);
                Int32intE0M.AssertModel(models[25],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt32SingleTypeint)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt32SingleTypeint)this).SetDbConnectionSelectModelParametrs(cmd, 144);
                var models =  ((IInt32SingleTypeint)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(4));

                Int32intE0M.AssertModel(models[0],_testData[31], false);
                Int32intE0M.AssertModel(models[1],_testData[32], false);
                Int32intE0M.AssertModel(models[2],_testData[33], false);
                Int32intE0M.AssertModel(models[3],_testData[34], false);
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
FROM dbo.int32inte0m m
LEFT JOIN dbo.int32inte0mi mi ON mi.id = m.int32inte0mi_id
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
            asPartInterface: typeof(IInt32SingleTypeint))]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IInt32SingleTypeint)this).DbConnectionSelectModelToObjArrAsync(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((719150243)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((303509118)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((3)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((573190036)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((420950529)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((2036489993)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((768127498)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1597465149)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((2129290910)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1165786626)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((2095205264)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1276842482)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1324172017)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((723564208)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((589883435)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1249455325)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((520819189)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((491078166)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1698777299)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((706605139)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((550611412)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1229263837)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1090182551)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1308369497)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((130691753)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((132604720)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1739704719)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((981362441)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((993984800)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((195485386)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((374950154)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((488546354)));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((277772918)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1513065227)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1143511043)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1162614639)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1496529403)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((2064957534)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1390645179)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1237135860)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((130124278)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1558530789)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1185575187)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1413510094)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((331556728)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1487790993)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((759248369)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1462760731)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1696866865)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((116)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1528556853)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1044218674)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((559448963)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1772227013)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((285914905)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((855986033)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((134426636)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1043444408)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1250878271)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1701945614)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1377650041)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1952323630)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((1404127039)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1840789304)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((125476680)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((373143405)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((533754524)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1974429463)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((152)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1866558549)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((595426780)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((342419282)));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((161)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((703397451)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((167)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((134209846)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((74)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1234461172)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((170)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((536061333)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((37227228)));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((IInt32SingleTypeint)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((719150243)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((303509118)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((3)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((573190036)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((420950529)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((2036489993)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((768127498)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1597465149)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((2129290910)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1165786626)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((2095205264)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1276842482)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1324172017)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((723564208)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((589883435)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1249455325)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((520819189)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((491078166)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1698777299)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((706605139)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((550611412)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1229263837)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1090182551)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1308369497)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((130691753)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((132604720)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1739704719)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((981362441)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((993984800)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((195485386)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((374950154)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((488546354)));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((277772918)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1513065227)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1143511043)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1162614639)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1496529403)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((2064957534)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1390645179)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1237135860)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((130124278)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1558530789)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1185575187)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1413510094)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((331556728)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1487790993)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((759248369)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1462760731)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1696866865)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((116)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1528556853)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1044218674)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((559448963)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1772227013)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((285914905)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((855986033)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((134426636)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1043444408)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1250878271)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1701945614)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1377650041)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1952323630)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((1404127039)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1840789304)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((125476680)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((373143405)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((533754524)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1974429463)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((152)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1866558549)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((595426780)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((342419282)));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((161)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((703397451)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((167)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((134209846)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((74)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1234461172)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((170)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((536061333)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((37227228)));

            }
        }

#endregion

    }
}

