

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

        private readonly Int32int0M[] _testData = new Int32int0M[]
        {
            new Int32int0M
{
    Id = 7,
    Value = 1438155459,
    ModelInner = null,
    NullableValue = null,
},
            new Int32int0M
{
    Id = 16,
    Value = 703745606,
    ModelInner = new Int32int0MI
{
    Id = 5,
    Value = 465509334,
    NullableValue = 1384898795,
},
    NullableValue = 710957639,
},
            new Int32int0M
{
    Id = 18,
    Value = 922870820,
    ModelInner = null,
    NullableValue = 1539973062,
},
            new Int32int0M
{
    Id = 20,
    Value = 1730495979,
    ModelInner = new Int32int0MI
{
    Id = 11,
    Value = 607712875,
    NullableValue = 1339696504,
},
    NullableValue = null,
},
            new Int32int0M
{
    Id = 27,
    Value = 2117822981,
    ModelInner = null,
    NullableValue = 1537934673,
},
            new Int32int0M
{
    Id = 36,
    Value = 1597073144,
    ModelInner = new Int32int0MI
{
    Id = 19,
    Value = 1949751521,
    NullableValue = 1799006396,
},
    NullableValue = null,
},
            new Int32int0M
{
    Id = 42,
    Value = 247225562,
    ModelInner = null,
    NullableValue = null,
},
            new Int32int0M
{
    Id = 43,
    Value = 1431049280,
    ModelInner = new Int32int0MI
{
    Id = 23,
    Value = 31308490,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32int0M
{
    Id = 46,
    Value = 1223536258,
    ModelInner = null,
    NullableValue = 382763915,
},
            new Int32int0M
{
    Id = 48,
    Value = 1273005214,
    ModelInner = new Int32int0MI
{
    Id = 30,
    Value = 2144319172,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32int0M
{
    Id = 54,
    Value = 2002309570,
    ModelInner = null,
    NullableValue = 1406879360,
},
            new Int32int0M
{
    Id = 62,
    Value = 1950522664,
    ModelInner = new Int32int0MI
{
    Id = 35,
    Value = 1784462623,
    NullableValue = 2006967979,
},
    NullableValue = null,
},
            new Int32int0M
{
    Id = 71,
    Value = 1116538288,
    ModelInner = null,
    NullableValue = 865871632,
},
            new Int32int0M
{
    Id = 76,
    Value = 823536462,
    ModelInner = new Int32int0MI
{
    Id = 38,
    Value = 1389232903,
    NullableValue = 271632001,
},
    NullableValue = null,
},
            new Int32int0M
{
    Id = 77,
    Value = 767724220,
    ModelInner = null,
    NullableValue = null,
},
            new Int32int0M
{
    Id = 82,
    Value = 1840530816,
    ModelInner = new Int32int0MI
{
    Id = 43,
    Value = 337771262,
    NullableValue = 804095443,
},
    NullableValue = 870770914,
},
            new Int32int0M
{
    Id = 89,
    Value = 423667269,
    ModelInner = null,
    NullableValue = 304593696,
},
            new Int32int0M
{
    Id = 95,
    Value = 847132268,
    ModelInner = new Int32int0MI
{
    Id = 51,
    Value = 1442035954,
    NullableValue = 289586503,
},
    NullableValue = null,
},
            new Int32int0M
{
    Id = 97,
    Value = 128238631,
    ModelInner = null,
    NullableValue = 2059319682,
},
            new Int32int0M
{
    Id = 103,
    Value = 1898400395,
    ModelInner = new Int32int0MI
{
    Id = 55,
    Value = 1253822058,
    NullableValue = 1241862579,
},
    NullableValue = null,
},
            new Int32int0M
{
    Id = 106,
    Value = 1133426553,
    ModelInner = null,
    NullableValue = 2099394159,
},
            new Int32int0M
{
    Id = 112,
    Value = 2109070659,
    ModelInner = new Int32int0MI
{
    Id = 60,
    Value = 2101124675,
    NullableValue = 2012227804,
},
    NullableValue = 706530223,
},
            new Int32int0M
{
    Id = 121,
    Value = 1997871467,
    ModelInner = null,
    NullableValue = null,
},
            new Int32int0M
{
    Id = 122,
    Value = 774050500,
    ModelInner = new Int32int0MI
{
    Id = 69,
    Value = 391638192,
    NullableValue = 892379636,
},
    NullableValue = 1710080532,
},
            new Int32int0M
{
    Id = 123,
    Value = 1620204130,
    ModelInner = null,
    NullableValue = null,
},
            new Int32int0M
{
    Id = 127,
    Value = 598516052,
    ModelInner = new Int32int0MI
{
    Id = 72,
    Value = 2009315258,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32int0M
{
    Id = 136,
    Value = 991340432,
    ModelInner = null,
    NullableValue = null,
},
            new Int32int0M
{
    Id = 144,
    Value = 1439065354,
    ModelInner = new Int32int0MI
{
    Id = 81,
    Value = 275894967,
    NullableValue = 710071243,
},
    NullableValue = 1231741419,
},
            new Int32int0M
{
    Id = 150,
    Value = 829622001,
    ModelInner = null,
    NullableValue = 2001902990,
},
            new Int32int0M
{
    Id = 158,
    Value = 183105393,
    ModelInner = new Int32int0MI
{
    Id = 86,
    Value = 1011249899,
    NullableValue = 2277405,
},
    NullableValue = 174749878,
},
        };

#endregion

#region InsertModelInner

[Gedaq.SqlClient.Attributes.Query(
            query: @"
INSERT INTO dbo.int32int0mi(
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
                sqlDbType: (System.Data.SqlDbType)(8)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                parametrName: "value",
                methodParametrName: "value",
                sqlDbType: (System.Data.SqlDbType)(8)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "nullablevalue",
                methodParametrName: "nullablevalue",
                sqlDbType: (System.Data.SqlDbType)(8))
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
INSERT INTO dbo.int32int0mi(
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

            }
        }

#endregion

#region InsertModel

[Gedaq.SqlClient.Attributes.Query(
            query: @"
INSERT INTO dbo.int32int0m(
	id,
    value,
    nullablevalue,
    int32int0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @int32int0mi_id
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
                sqlDbType: (System.Data.SqlDbType)(8)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "value", 
                methodParametrName: "value", 
                sqlDbType: (System.Data.SqlDbType)(8)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                sqlDbType: (System.Data.SqlDbType)(8),
                nullable: true),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "int32int0mi_id", 
                methodParametrName: "int32int0mi_id", 
                sqlDbType: (System.Data.SqlDbType)(8),
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
INSERT INTO dbo.int32int0m(
	id,
    value,
    nullablevalue,
    int32int0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @int32int0mi_id
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
                parametrName: "int32int0mi_id", 
                methodParametrName: "int32int0mi_id", 
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

            }
        }

#endregion

#region Select Models

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt32int0M), typeof(FlatInt32int0M)],
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
FROM dbo.int32int0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt32int0M>();
                var models2 = new List<FlatInt32int0M>();
                await((IInt32SingleTypeint)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32int0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32int0M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.int32int0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt32int0M>();
                var models2 = new List<FlatInt32int0M>();
                ((IInt32SingleTypeint)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32int0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32int0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt32int0M)],
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
FROM dbo.int32int0m m
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32int0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.int32int0m m
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32int0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.int32int0m m
LEFT JOIN dbo.int32int0mi mi ON mi.id = m.int32int0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Int32int0M)],
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int32int0M.AssertModel(models[i],_testData[i], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int32int0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt32int0M), typeof(FlatInt32int0M)],
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
            sqlDbType: (System.Data.SqlDbType)(8))]
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
FROM dbo.int32int0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt32int0M>();
                var models2 = new List<FlatInt32int0M>();
                await((IInt32SingleTypeint)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32int0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32int0M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.int32int0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt32int0M>();
                var models2 = new List<FlatInt32int0M>();
                ((IInt32SingleTypeint)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32int0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32int0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt32int0M)],
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
            sqlDbType: (System.Data.SqlDbType)(8))]
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
FROM dbo.int32int0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IInt32SingleTypeint)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32int0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.int32int0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IInt32SingleTypeint)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32int0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.int32int0m m
LEFT JOIN dbo.int32int0mi mi ON mi.id = m.int32int0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Int32int0M)],
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
            sqlDbType: (System.Data.SqlDbType)(8))]
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int32int0M.AssertModel(models[i],_testData[i], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int32int0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt32int0M), typeof(FlatInt32int0M)],
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
FROM dbo.int32int0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt32int0M>();
                var models2 = new List<FlatInt32int0M>();
                await((IInt32SingleTypeint)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32int0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32int0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 42;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 122;
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
FROM dbo.int32int0m m
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
FROM dbo.int32int0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32int0M>();
                var firstItems2 = new List<FlatInt32int0M>();
                var secondItems1 = new List<FlatInt32int0M>();
                var secondItems2 = new List<FlatInt32int0M>();
                await ((IInt32SingleTypeint)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatInt32int0M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatInt32int0M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatInt32int0M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatInt32int0M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatInt32int0M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatInt32int0M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatInt32int0M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatInt32int0M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatInt32int0M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatInt32int0M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatInt32int0M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatInt32int0M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatInt32int0M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatInt32int0M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatInt32int0M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatInt32int0M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatInt32int0M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatInt32int0M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatInt32int0M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatInt32int0M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatInt32int0M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatInt32int0M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatInt32int0M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatInt32int0M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatInt32int0M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatInt32int0M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatInt32int0M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatInt32int0M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatInt32int0M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatInt32int0M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatInt32int0M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatInt32int0M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatInt32int0M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatInt32int0M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatInt32int0M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatInt32int0M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatInt32int0M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatInt32int0M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatInt32int0M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatInt32int0M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatInt32int0M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatInt32int0M.AssertModel(firstItems2[22],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatInt32int0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatInt32int0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatInt32int0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatInt32int0M.AssertModel(secondItems2[5],_testData[30], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 71;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 123;
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
FROM dbo.int32int0m m
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
FROM dbo.int32int0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32int0M>();
                var firstItems2 = new List<FlatInt32int0M>();
                var secondItems1 = new List<FlatInt32int0M>();
                await ((IInt32SingleTypeint)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatInt32int0M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatInt32int0M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatInt32int0M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatInt32int0M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatInt32int0M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatInt32int0M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatInt32int0M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatInt32int0M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatInt32int0M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatInt32int0M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatInt32int0M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatInt32int0M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatInt32int0M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatInt32int0M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatInt32int0M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatInt32int0M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatInt32int0M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatInt32int0M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatInt32int0M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatInt32int0M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatInt32int0M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatInt32int0M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatInt32int0M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatInt32int0M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatInt32int0M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatInt32int0M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatInt32int0M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatInt32int0M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatInt32int0M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatInt32int0M.AssertModel(firstItems2[16],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                        FlatInt32int0M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatInt32int0M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems1[4],_testData[29], false);
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
FROM dbo.int32int0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt32int0M>();
                var models2 = new List<FlatInt32int0M>();
                ((IInt32SingleTypeint)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32int0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32int0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 95;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 89;
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
FROM dbo.int32int0m m
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
FROM dbo.int32int0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32int0M>();
                var firstItems2 = new List<FlatInt32int0M>();
                var secondItems1 = new List<FlatInt32int0M>();
                var secondItems2 = new List<FlatInt32int0M>();
                 ((IInt32SingleTypeint)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatInt32int0M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatInt32int0M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatInt32int0M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatInt32int0M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatInt32int0M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatInt32int0M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatInt32int0M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatInt32int0M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatInt32int0M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatInt32int0M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatInt32int0M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatInt32int0M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatInt32int0M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatInt32int0M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatInt32int0M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatInt32int0M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatInt32int0M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatInt32int0M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatInt32int0M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatInt32int0M.AssertModel(firstItems2[11],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatInt32int0M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatInt32int0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatInt32int0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatInt32int0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatInt32int0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatInt32int0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatInt32int0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatInt32int0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatInt32int0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatInt32int0M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatInt32int0M.AssertModel(secondItems2[12],_testData[30], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 112;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 77;
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
FROM dbo.int32int0m m
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
FROM dbo.int32int0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32int0M>();
                var firstItems2 = new List<FlatInt32int0M>();
                var secondItems1 = new List<FlatInt32int0M>();
                 ((IInt32SingleTypeint)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatInt32int0M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatInt32int0M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatInt32int0M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatInt32int0M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatInt32int0M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatInt32int0M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatInt32int0M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatInt32int0M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatInt32int0M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatInt32int0M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatInt32int0M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatInt32int0M.AssertModel(firstItems2[7],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatInt32int0M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatInt32int0M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatInt32int0M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatInt32int0M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatInt32int0M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatInt32int0M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatInt32int0M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatInt32int0M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatInt32int0M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatInt32int0M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatInt32int0M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatInt32int0M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems1[14],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt32int0M)],
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
FROM dbo.int32int0m m
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32int0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 54;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 46;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.int32int0m m
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
FROM dbo.int32int0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IInt32SingleTypeint)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatInt32int0M.AssertModel(models[0],_testData[11], false);
                        FlatInt32int0M.AssertModel(models[1],_testData[12], false);
                        FlatInt32int0M.AssertModel(models[2],_testData[13], false);
                        FlatInt32int0M.AssertModel(models[3],_testData[14], false);
                        FlatInt32int0M.AssertModel(models[4],_testData[15], false);
                        FlatInt32int0M.AssertModel(models[5],_testData[16], false);
                        FlatInt32int0M.AssertModel(models[6],_testData[17], false);
                        FlatInt32int0M.AssertModel(models[7],_testData[18], false);
                        FlatInt32int0M.AssertModel(models[8],_testData[19], false);
                        FlatInt32int0M.AssertModel(models[9],_testData[20], false);
                        FlatInt32int0M.AssertModel(models[10],_testData[21], false);
                        FlatInt32int0M.AssertModel(models[11],_testData[22], false);
                        FlatInt32int0M.AssertModel(models[12],_testData[23], false);
                        FlatInt32int0M.AssertModel(models[13],_testData[24], false);
                        FlatInt32int0M.AssertModel(models[14],_testData[25], false);
                        FlatInt32int0M.AssertModel(models[15],_testData[26], false);
                        FlatInt32int0M.AssertModel(models[16],_testData[27], false);
                        FlatInt32int0M.AssertModel(models[17],_testData[28], false);
                        FlatInt32int0M.AssertModel(models[18],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatInt32int0M.AssertModel(models[0],_testData[9], false);
                        FlatInt32int0M.AssertModel(models[1],_testData[10], false);
                        FlatInt32int0M.AssertModel(models[2],_testData[11], false);
                        FlatInt32int0M.AssertModel(models[3],_testData[12], false);
                        FlatInt32int0M.AssertModel(models[4],_testData[13], false);
                        FlatInt32int0M.AssertModel(models[5],_testData[14], false);
                        FlatInt32int0M.AssertModel(models[6],_testData[15], false);
                        FlatInt32int0M.AssertModel(models[7],_testData[16], false);
                        FlatInt32int0M.AssertModel(models[8],_testData[17], false);
                        FlatInt32int0M.AssertModel(models[9],_testData[18], false);
                        FlatInt32int0M.AssertModel(models[10],_testData[19], false);
                        FlatInt32int0M.AssertModel(models[11],_testData[20], false);
                        FlatInt32int0M.AssertModel(models[12],_testData[21], false);
                        FlatInt32int0M.AssertModel(models[13],_testData[22], false);
                        FlatInt32int0M.AssertModel(models[14],_testData[23], false);
                        FlatInt32int0M.AssertModel(models[15],_testData[24], false);
                        FlatInt32int0M.AssertModel(models[16],_testData[25], false);
                        FlatInt32int0M.AssertModel(models[17],_testData[26], false);
                        FlatInt32int0M.AssertModel(models[18],_testData[27], false);
                        FlatInt32int0M.AssertModel(models[19],_testData[28], false);
                        FlatInt32int0M.AssertModel(models[20],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 112;
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
FROM dbo.int32int0m m
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
FROM dbo.int32int0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32int0M>();
                var secondItems1 = new List<FlatInt32int0M>();
                var secondItems2 = new List<FlatInt32int0M>();
                await ((IInt32SingleTypeint)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatInt32int0M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatInt32int0M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatInt32int0M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatInt32int0M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatInt32int0M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatInt32int0M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems1[7],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatInt32int0M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatInt32int0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatInt32int0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatInt32int0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatInt32int0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatInt32int0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatInt32int0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatInt32int0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatInt32int0M.AssertModel(secondItems2[10],_testData[30], false);
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
FROM dbo.int32int0m m
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32int0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 122;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 46;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.int32int0m m
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
FROM dbo.int32int0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IInt32SingleTypeint)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatInt32int0M.AssertModel(models[0],_testData[24], false);
                        FlatInt32int0M.AssertModel(models[1],_testData[25], false);
                        FlatInt32int0M.AssertModel(models[2],_testData[26], false);
                        FlatInt32int0M.AssertModel(models[3],_testData[27], false);
                        FlatInt32int0M.AssertModel(models[4],_testData[28], false);
                        FlatInt32int0M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatInt32int0M.AssertModel(models[0],_testData[9], false);
                        FlatInt32int0M.AssertModel(models[1],_testData[10], false);
                        FlatInt32int0M.AssertModel(models[2],_testData[11], false);
                        FlatInt32int0M.AssertModel(models[3],_testData[12], false);
                        FlatInt32int0M.AssertModel(models[4],_testData[13], false);
                        FlatInt32int0M.AssertModel(models[5],_testData[14], false);
                        FlatInt32int0M.AssertModel(models[6],_testData[15], false);
                        FlatInt32int0M.AssertModel(models[7],_testData[16], false);
                        FlatInt32int0M.AssertModel(models[8],_testData[17], false);
                        FlatInt32int0M.AssertModel(models[9],_testData[18], false);
                        FlatInt32int0M.AssertModel(models[10],_testData[19], false);
                        FlatInt32int0M.AssertModel(models[11],_testData[20], false);
                        FlatInt32int0M.AssertModel(models[12],_testData[21], false);
                        FlatInt32int0M.AssertModel(models[13],_testData[22], false);
                        FlatInt32int0M.AssertModel(models[14],_testData[23], false);
                        FlatInt32int0M.AssertModel(models[15],_testData[24], false);
                        FlatInt32int0M.AssertModel(models[16],_testData[25], false);
                        FlatInt32int0M.AssertModel(models[17],_testData[26], false);
                        FlatInt32int0M.AssertModel(models[18],_testData[27], false);
                        FlatInt32int0M.AssertModel(models[19],_testData[28], false);
                        FlatInt32int0M.AssertModel(models[20],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 76;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 122;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.int32int0m m
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
FROM dbo.int32int0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32int0M>();
                var secondItems1 = new List<FlatInt32int0M>();
                var secondItems2 = new List<FlatInt32int0M>();
                 ((IInt32SingleTypeint)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatInt32int0M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatInt32int0M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatInt32int0M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatInt32int0M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatInt32int0M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatInt32int0M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatInt32int0M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatInt32int0M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatInt32int0M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatInt32int0M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatInt32int0M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatInt32int0M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatInt32int0M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatInt32int0M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems1[15],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatInt32int0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatInt32int0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatInt32int0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatInt32int0M.AssertModel(secondItems2[5],_testData[30], false);
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
FROM dbo.int32int0m m
LEFT JOIN dbo.int32int0mi mi ON mi.id = m.int32int0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Int32int0M)],
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int32int0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTSelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 18;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 127;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((IInt32SingleTypeint)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        Int32int0M.AssertModel(models[0],_testData[3], false);
                        Int32int0M.AssertModel(models[1],_testData[4], false);
                        Int32int0M.AssertModel(models[2],_testData[5], false);
                        Int32int0M.AssertModel(models[3],_testData[6], false);
                        Int32int0M.AssertModel(models[4],_testData[7], false);
                        Int32int0M.AssertModel(models[5],_testData[8], false);
                        Int32int0M.AssertModel(models[6],_testData[9], false);
                        Int32int0M.AssertModel(models[7],_testData[10], false);
                        Int32int0M.AssertModel(models[8],_testData[11], false);
                        Int32int0M.AssertModel(models[9],_testData[12], false);
                        Int32int0M.AssertModel(models[10],_testData[13], false);
                        Int32int0M.AssertModel(models[11],_testData[14], false);
                        Int32int0M.AssertModel(models[12],_testData[15], false);
                        Int32int0M.AssertModel(models[13],_testData[16], false);
                        Int32int0M.AssertModel(models[14],_testData[17], false);
                        Int32int0M.AssertModel(models[15],_testData[18], false);
                        Int32int0M.AssertModel(models[16],_testData[19], false);
                        Int32int0M.AssertModel(models[17],_testData[20], false);
                        Int32int0M.AssertModel(models[18],_testData[21], false);
                        Int32int0M.AssertModel(models[19],_testData[22], false);
                        Int32int0M.AssertModel(models[20],_testData[23], false);
                        Int32int0M.AssertModel(models[21],_testData[24], false);
                        Int32int0M.AssertModel(models[22],_testData[25], false);
                        Int32int0M.AssertModel(models[23],_testData[26], false);
                        Int32int0M.AssertModel(models[24],_testData[27], false);
                        Int32int0M.AssertModel(models[25],_testData[28], false);
                        Int32int0M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        Int32int0M.AssertModel(models[0],_testData[26], false);
                        Int32int0M.AssertModel(models[1],_testData[27], false);
                        Int32int0M.AssertModel(models[2],_testData[28], false);
                        Int32int0M.AssertModel(models[3],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int32int0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTSelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 62;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 77;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((IInt32SingleTypeint)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        Int32int0M.AssertModel(models[0],_testData[12], false);
                        Int32int0M.AssertModel(models[1],_testData[13], false);
                        Int32int0M.AssertModel(models[2],_testData[14], false);
                        Int32int0M.AssertModel(models[3],_testData[15], false);
                        Int32int0M.AssertModel(models[4],_testData[16], false);
                        Int32int0M.AssertModel(models[5],_testData[17], false);
                        Int32int0M.AssertModel(models[6],_testData[18], false);
                        Int32int0M.AssertModel(models[7],_testData[19], false);
                        Int32int0M.AssertModel(models[8],_testData[20], false);
                        Int32int0M.AssertModel(models[9],_testData[21], false);
                        Int32int0M.AssertModel(models[10],_testData[22], false);
                        Int32int0M.AssertModel(models[11],_testData[23], false);
                        Int32int0M.AssertModel(models[12],_testData[24], false);
                        Int32int0M.AssertModel(models[13],_testData[25], false);
                        Int32int0M.AssertModel(models[14],_testData[26], false);
                        Int32int0M.AssertModel(models[15],_testData[27], false);
                        Int32int0M.AssertModel(models[16],_testData[28], false);
                        Int32int0M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        Int32int0M.AssertModel(models[0],_testData[15], false);
                        Int32int0M.AssertModel(models[1],_testData[16], false);
                        Int32int0M.AssertModel(models[2],_testData[17], false);
                        Int32int0M.AssertModel(models[3],_testData[18], false);
                        Int32int0M.AssertModel(models[4],_testData[19], false);
                        Int32int0M.AssertModel(models[5],_testData[20], false);
                        Int32int0M.AssertModel(models[6],_testData[21], false);
                        Int32int0M.AssertModel(models[7],_testData[22], false);
                        Int32int0M.AssertModel(models[8],_testData[23], false);
                        Int32int0M.AssertModel(models[9],_testData[24], false);
                        Int32int0M.AssertModel(models[10],_testData[25], false);
                        Int32int0M.AssertModel(models[11],_testData[26], false);
                        Int32int0M.AssertModel(models[12],_testData[27], false);
                        Int32int0M.AssertModel(models[13],_testData[28], false);
                        Int32int0M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt32int0M), typeof(FlatInt32int0M)],
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
FROM dbo.int32int0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt32int0M>();
                var models2 = new List<FlatInt32int0M>();
                await((IInt32SingleTypeint)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32int0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32int0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM dbo.int32int0m m
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
FROM dbo.int32int0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32int0M>();
                var firstItems2 = new List<FlatInt32int0M>();
                var secondItems1 = new List<FlatInt32int0M>();
                var secondItems2 = new List<FlatInt32int0M>();
                await ((IInt32SingleTypeint)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 36, query1, 82, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatInt32int0M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatInt32int0M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatInt32int0M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatInt32int0M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatInt32int0M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatInt32int0M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatInt32int0M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatInt32int0M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatInt32int0M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatInt32int0M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatInt32int0M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatInt32int0M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatInt32int0M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatInt32int0M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatInt32int0M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatInt32int0M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatInt32int0M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatInt32int0M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatInt32int0M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatInt32int0M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatInt32int0M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatInt32int0M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatInt32int0M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatInt32int0M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatInt32int0M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatInt32int0M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatInt32int0M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatInt32int0M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatInt32int0M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatInt32int0M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatInt32int0M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatInt32int0M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatInt32int0M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatInt32int0M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatInt32int0M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatInt32int0M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatInt32int0M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatInt32int0M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatInt32int0M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatInt32int0M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatInt32int0M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatInt32int0M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatInt32int0M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatInt32int0M.AssertModel(firstItems2[23],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatInt32int0M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatInt32int0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatInt32int0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatInt32int0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatInt32int0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatInt32int0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatInt32int0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatInt32int0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatInt32int0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatInt32int0M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatInt32int0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatInt32int0M.AssertModel(secondItems2[13],_testData[30], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM dbo.int32int0m m
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
FROM dbo.int32int0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32int0M>();
                var firstItems2 = new List<FlatInt32int0M>();
                var secondItems1 = new List<FlatInt32int0M>();
                await ((IInt32SingleTypeint)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 122, query1, 42, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatInt32int0M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatInt32int0M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatInt32int0M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatInt32int0M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatInt32int0M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatInt32int0M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatInt32int0M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatInt32int0M.AssertModel(firstItems2[5],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatInt32int0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatInt32int0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatInt32int0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatInt32int0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatInt32int0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatInt32int0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatInt32int0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatInt32int0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatInt32int0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatInt32int0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatInt32int0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatInt32int0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatInt32int0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatInt32int0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatInt32int0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatInt32int0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatInt32int0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatInt32int0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatInt32int0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatInt32int0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems1[22],_testData[29], false);
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
FROM dbo.int32int0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt32int0M>();
                var models2 = new List<FlatInt32int0M>();
                ((IInt32SingleTypeint)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32int0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32int0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM dbo.int32int0m m
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
FROM dbo.int32int0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32int0M>();
                var firstItems2 = new List<FlatInt32int0M>();
                var secondItems1 = new List<FlatInt32int0M>();
                var secondItems2 = new List<FlatInt32int0M>();
                 ((IInt32SingleTypeint)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 48, query1, 121, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatInt32int0M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatInt32int0M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatInt32int0M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatInt32int0M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatInt32int0M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatInt32int0M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatInt32int0M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatInt32int0M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatInt32int0M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatInt32int0M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatInt32int0M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatInt32int0M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatInt32int0M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatInt32int0M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatInt32int0M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatInt32int0M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatInt32int0M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatInt32int0M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatInt32int0M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatInt32int0M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatInt32int0M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatInt32int0M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatInt32int0M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatInt32int0M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatInt32int0M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatInt32int0M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatInt32int0M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatInt32int0M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatInt32int0M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatInt32int0M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatInt32int0M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatInt32int0M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatInt32int0M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatInt32int0M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatInt32int0M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatInt32int0M.AssertModel(firstItems2[19],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatInt32int0M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatInt32int0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatInt32int0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatInt32int0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatInt32int0M.AssertModel(secondItems2[6],_testData[30], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM dbo.int32int0m m
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
FROM dbo.int32int0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32int0M>();
                var firstItems2 = new List<FlatInt32int0M>();
                var secondItems1 = new List<FlatInt32int0M>();
                 ((IInt32SingleTypeint)this).DbConnectionMMDynQuerySelectModelBatch(connection, 144, query1, 103, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatInt32int0M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatInt32int0M.AssertModel(firstItems2[1],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                        FlatInt32int0M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatInt32int0M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatInt32int0M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatInt32int0M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatInt32int0M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatInt32int0M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatInt32int0M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems1[9],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt32int0M)],
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
FROM dbo.int32int0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IInt32SingleTypeint)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32int0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelBatchTestAsync()
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
FROM dbo.int32int0m m
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
FROM dbo.int32int0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IInt32SingleTypeint)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 77, query1, 16, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatInt32int0M.AssertModel(models[0],_testData[15], false);
                        FlatInt32int0M.AssertModel(models[1],_testData[16], false);
                        FlatInt32int0M.AssertModel(models[2],_testData[17], false);
                        FlatInt32int0M.AssertModel(models[3],_testData[18], false);
                        FlatInt32int0M.AssertModel(models[4],_testData[19], false);
                        FlatInt32int0M.AssertModel(models[5],_testData[20], false);
                        FlatInt32int0M.AssertModel(models[6],_testData[21], false);
                        FlatInt32int0M.AssertModel(models[7],_testData[22], false);
                        FlatInt32int0M.AssertModel(models[8],_testData[23], false);
                        FlatInt32int0M.AssertModel(models[9],_testData[24], false);
                        FlatInt32int0M.AssertModel(models[10],_testData[25], false);
                        FlatInt32int0M.AssertModel(models[11],_testData[26], false);
                        FlatInt32int0M.AssertModel(models[12],_testData[27], false);
                        FlatInt32int0M.AssertModel(models[13],_testData[28], false);
                        FlatInt32int0M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatInt32int0M.AssertModel(models[0],_testData[2], false);
                        FlatInt32int0M.AssertModel(models[1],_testData[3], false);
                        FlatInt32int0M.AssertModel(models[2],_testData[4], false);
                        FlatInt32int0M.AssertModel(models[3],_testData[5], false);
                        FlatInt32int0M.AssertModel(models[4],_testData[6], false);
                        FlatInt32int0M.AssertModel(models[5],_testData[7], false);
                        FlatInt32int0M.AssertModel(models[6],_testData[8], false);
                        FlatInt32int0M.AssertModel(models[7],_testData[9], false);
                        FlatInt32int0M.AssertModel(models[8],_testData[10], false);
                        FlatInt32int0M.AssertModel(models[9],_testData[11], false);
                        FlatInt32int0M.AssertModel(models[10],_testData[12], false);
                        FlatInt32int0M.AssertModel(models[11],_testData[13], false);
                        FlatInt32int0M.AssertModel(models[12],_testData[14], false);
                        FlatInt32int0M.AssertModel(models[13],_testData[15], false);
                        FlatInt32int0M.AssertModel(models[14],_testData[16], false);
                        FlatInt32int0M.AssertModel(models[15],_testData[17], false);
                        FlatInt32int0M.AssertModel(models[16],_testData[18], false);
                        FlatInt32int0M.AssertModel(models[17],_testData[19], false);
                        FlatInt32int0M.AssertModel(models[18],_testData[20], false);
                        FlatInt32int0M.AssertModel(models[19],_testData[21], false);
                        FlatInt32int0M.AssertModel(models[20],_testData[22], false);
                        FlatInt32int0M.AssertModel(models[21],_testData[23], false);
                        FlatInt32int0M.AssertModel(models[22],_testData[24], false);
                        FlatInt32int0M.AssertModel(models[23],_testData[25], false);
                        FlatInt32int0M.AssertModel(models[24],_testData[26], false);
                        FlatInt32int0M.AssertModel(models[25],_testData[27], false);
                        FlatInt32int0M.AssertModel(models[26],_testData[28], false);
                        FlatInt32int0M.AssertModel(models[27],_testData[29], false);
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
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.int32int0m m
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
FROM dbo.int32int0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32int0M>();
                var secondItems1 = new List<FlatInt32int0M>();
                var secondItems2 = new List<FlatInt32int0M>();
                await ((IInt32SingleTypeint)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 95, query1, 136, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatInt32int0M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatInt32int0M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatInt32int0M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatInt32int0M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatInt32int0M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatInt32int0M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatInt32int0M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatInt32int0M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatInt32int0M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatInt32int0M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems1[11],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatInt32int0M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatInt32int0M.AssertModel(secondItems2[2],_testData[30], false);
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
FROM dbo.int32int0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IInt32SingleTypeint)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt32int0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelBatchTest()
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
FROM dbo.int32int0m m
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
FROM dbo.int32int0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IInt32SingleTypeint)this).DbConnectionSTDynQuerySelectModelBatch(connection, 18, query1, 106, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatInt32int0M.AssertModel(models[0],_testData[3], false);
                        FlatInt32int0M.AssertModel(models[1],_testData[4], false);
                        FlatInt32int0M.AssertModel(models[2],_testData[5], false);
                        FlatInt32int0M.AssertModel(models[3],_testData[6], false);
                        FlatInt32int0M.AssertModel(models[4],_testData[7], false);
                        FlatInt32int0M.AssertModel(models[5],_testData[8], false);
                        FlatInt32int0M.AssertModel(models[6],_testData[9], false);
                        FlatInt32int0M.AssertModel(models[7],_testData[10], false);
                        FlatInt32int0M.AssertModel(models[8],_testData[11], false);
                        FlatInt32int0M.AssertModel(models[9],_testData[12], false);
                        FlatInt32int0M.AssertModel(models[10],_testData[13], false);
                        FlatInt32int0M.AssertModel(models[11],_testData[14], false);
                        FlatInt32int0M.AssertModel(models[12],_testData[15], false);
                        FlatInt32int0M.AssertModel(models[13],_testData[16], false);
                        FlatInt32int0M.AssertModel(models[14],_testData[17], false);
                        FlatInt32int0M.AssertModel(models[15],_testData[18], false);
                        FlatInt32int0M.AssertModel(models[16],_testData[19], false);
                        FlatInt32int0M.AssertModel(models[17],_testData[20], false);
                        FlatInt32int0M.AssertModel(models[18],_testData[21], false);
                        FlatInt32int0M.AssertModel(models[19],_testData[22], false);
                        FlatInt32int0M.AssertModel(models[20],_testData[23], false);
                        FlatInt32int0M.AssertModel(models[21],_testData[24], false);
                        FlatInt32int0M.AssertModel(models[22],_testData[25], false);
                        FlatInt32int0M.AssertModel(models[23],_testData[26], false);
                        FlatInt32int0M.AssertModel(models[24],_testData[27], false);
                        FlatInt32int0M.AssertModel(models[25],_testData[28], false);
                        FlatInt32int0M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatInt32int0M.AssertModel(models[0],_testData[21], false);
                        FlatInt32int0M.AssertModel(models[1],_testData[22], false);
                        FlatInt32int0M.AssertModel(models[2],_testData[23], false);
                        FlatInt32int0M.AssertModel(models[3],_testData[24], false);
                        FlatInt32int0M.AssertModel(models[4],_testData[25], false);
                        FlatInt32int0M.AssertModel(models[5],_testData[26], false);
                        FlatInt32int0M.AssertModel(models[6],_testData[27], false);
                        FlatInt32int0M.AssertModel(models[7],_testData[28], false);
                        FlatInt32int0M.AssertModel(models[8],_testData[29], false);
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
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.int32int0m m
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
FROM dbo.int32int0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt32int0M>();
                var secondItems1 = new List<FlatInt32int0M>();
                var secondItems2 = new List<FlatInt32int0M>();
                 ((IInt32SingleTypeint)this).DbConnectionDynQuerySelectModelBatch(connection, 77, query1, 42, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatInt32int0M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatInt32int0M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatInt32int0M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatInt32int0M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatInt32int0M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatInt32int0M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatInt32int0M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatInt32int0M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatInt32int0M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatInt32int0M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatInt32int0M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatInt32int0M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatInt32int0M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems1[14],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatInt32int0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatInt32int0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatInt32int0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatInt32int0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatInt32int0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatInt32int0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatInt32int0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatInt32int0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatInt32int0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatInt32int0M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatInt32int0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatInt32int0M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatInt32int0M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatInt32int0M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatInt32int0M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatInt32int0M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatInt32int0M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatInt32int0M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatInt32int0M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatInt32int0M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatInt32int0M.AssertModel(secondItems2[22],_testData[30], false);
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
FROM dbo.int32int0m m
LEFT JOIN dbo.int32int0mi mi ON mi.id = m.int32int0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Int32int0M)],
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int32int0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IInt32SingleTypeint)this).DbConnectionSTSelectModelBatchAsync(connection, 71, 89))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        Int32int0M.AssertModel(models[0],_testData[13], false);
                        Int32int0M.AssertModel(models[1],_testData[14], false);
                        Int32int0M.AssertModel(models[2],_testData[15], false);
                        Int32int0M.AssertModel(models[3],_testData[16], false);
                        Int32int0M.AssertModel(models[4],_testData[17], false);
                        Int32int0M.AssertModel(models[5],_testData[18], false);
                        Int32int0M.AssertModel(models[6],_testData[19], false);
                        Int32int0M.AssertModel(models[7],_testData[20], false);
                        Int32int0M.AssertModel(models[8],_testData[21], false);
                        Int32int0M.AssertModel(models[9],_testData[22], false);
                        Int32int0M.AssertModel(models[10],_testData[23], false);
                        Int32int0M.AssertModel(models[11],_testData[24], false);
                        Int32int0M.AssertModel(models[12],_testData[25], false);
                        Int32int0M.AssertModel(models[13],_testData[26], false);
                        Int32int0M.AssertModel(models[14],_testData[27], false);
                        Int32int0M.AssertModel(models[15],_testData[28], false);
                        Int32int0M.AssertModel(models[16],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        Int32int0M.AssertModel(models[0],_testData[17], false);
                        Int32int0M.AssertModel(models[1],_testData[18], false);
                        Int32int0M.AssertModel(models[2],_testData[19], false);
                        Int32int0M.AssertModel(models[3],_testData[20], false);
                        Int32int0M.AssertModel(models[4],_testData[21], false);
                        Int32int0M.AssertModel(models[5],_testData[22], false);
                        Int32int0M.AssertModel(models[6],_testData[23], false);
                        Int32int0M.AssertModel(models[7],_testData[24], false);
                        Int32int0M.AssertModel(models[8],_testData[25], false);
                        Int32int0M.AssertModel(models[9],_testData[26], false);
                        Int32int0M.AssertModel(models[10],_testData[27], false);
                        Int32int0M.AssertModel(models[11],_testData[28], false);
                        Int32int0M.AssertModel(models[12],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int32int0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IInt32SingleTypeint)this).DbConnectionSTSelectModelBatch(connection, 48, 89))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        Int32int0M.AssertModel(models[0],_testData[10], false);
                        Int32int0M.AssertModel(models[1],_testData[11], false);
                        Int32int0M.AssertModel(models[2],_testData[12], false);
                        Int32int0M.AssertModel(models[3],_testData[13], false);
                        Int32int0M.AssertModel(models[4],_testData[14], false);
                        Int32int0M.AssertModel(models[5],_testData[15], false);
                        Int32int0M.AssertModel(models[6],_testData[16], false);
                        Int32int0M.AssertModel(models[7],_testData[17], false);
                        Int32int0M.AssertModel(models[8],_testData[18], false);
                        Int32int0M.AssertModel(models[9],_testData[19], false);
                        Int32int0M.AssertModel(models[10],_testData[20], false);
                        Int32int0M.AssertModel(models[11],_testData[21], false);
                        Int32int0M.AssertModel(models[12],_testData[22], false);
                        Int32int0M.AssertModel(models[13],_testData[23], false);
                        Int32int0M.AssertModel(models[14],_testData[24], false);
                        Int32int0M.AssertModel(models[15],_testData[25], false);
                        Int32int0M.AssertModel(models[16],_testData[26], false);
                        Int32int0M.AssertModel(models[17],_testData[27], false);
                        Int32int0M.AssertModel(models[18],_testData[28], false);
                        Int32int0M.AssertModel(models[19],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        Int32int0M.AssertModel(models[0],_testData[17], false);
                        Int32int0M.AssertModel(models[1],_testData[18], false);
                        Int32int0M.AssertModel(models[2],_testData[19], false);
                        Int32int0M.AssertModel(models[3],_testData[20], false);
                        Int32int0M.AssertModel(models[4],_testData[21], false);
                        Int32int0M.AssertModel(models[5],_testData[22], false);
                        Int32int0M.AssertModel(models[6],_testData[23], false);
                        Int32int0M.AssertModel(models[7],_testData[24], false);
                        Int32int0M.AssertModel(models[8],_testData[25], false);
                        Int32int0M.AssertModel(models[9],_testData[26], false);
                        Int32int0M.AssertModel(models[10],_testData[27], false);
                        Int32int0M.AssertModel(models[11],_testData[28], false);
                        Int32int0M.AssertModel(models[12],_testData[29], false);
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
                ((IInt32SingleTypeint)this).SetDbConnectionSelectModelParametrs(cmd, 123);
                var models = await ((IInt32SingleTypeint)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(5));
Int32int0M.AssertModel(models[0],_testData[25], false);Int32int0M.AssertModel(models[1],_testData[26], false);Int32int0M.AssertModel(models[2],_testData[27], false);Int32int0M.AssertModel(models[3],_testData[28], false);Int32int0M.AssertModel(models[4],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt32SingleTypeint)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt32SingleTypeint)this).SetDbConnectionSelectModelParametrs(cmd, 76);
                var models =  ((IInt32SingleTypeint)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(16));
Int32int0M.AssertModel(models[0],_testData[14], false);Int32int0M.AssertModel(models[1],_testData[15], false);Int32int0M.AssertModel(models[2],_testData[16], false);Int32int0M.AssertModel(models[3],_testData[17], false);Int32int0M.AssertModel(models[4],_testData[18], false);Int32int0M.AssertModel(models[5],_testData[19], false);Int32int0M.AssertModel(models[6],_testData[20], false);Int32int0M.AssertModel(models[7],_testData[21], false);Int32int0M.AssertModel(models[8],_testData[22], false);Int32int0M.AssertModel(models[9],_testData[23], false);Int32int0M.AssertModel(models[10],_testData[24], false);Int32int0M.AssertModel(models[11],_testData[25], false);Int32int0M.AssertModel(models[12],_testData[26], false);Int32int0M.AssertModel(models[13],_testData[27], false);Int32int0M.AssertModel(models[14],_testData[28], false);Int32int0M.AssertModel(models[15],_testData[29], false);
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
FROM dbo.int32int0m m
LEFT JOIN dbo.int32int0mi mi ON mi.id = m.int32int0mi_id
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
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1438155459)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((703745606)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((5)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((465509334)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1384898795)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((710957639)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((922870820)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1539973062)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1730495979)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((11)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((607712875)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1339696504)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((2117822981)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1537934673)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1597073144)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1949751521)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1799006396)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((247225562)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1431049280)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((31308490)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1223536258)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((382763915)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1273005214)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((2144319172)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((2002309570)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1406879360)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1950522664)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1784462623)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((2006967979)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1116538288)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((865871632)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((823536462)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((38)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1389232903)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((271632001)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((767724220)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1840530816)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((337771262)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((804095443)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((870770914)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((423667269)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((304593696)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((847132268)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1442035954)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((289586503)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((128238631)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((2059319682)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1898400395)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1253822058)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1241862579)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1133426553)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((2099394159)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((2109070659)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((2101124675)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((2012227804)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((706530223)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1997871467)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((774050500)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((391638192)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((892379636)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1710080532)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1620204130)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((598516052)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((2009315258)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((991340432)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1439065354)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((81)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((275894967)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((710071243)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1231741419)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((829622001)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((2001902990)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((158)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((183105393)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((86)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1011249899)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((2277405)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((174749878)));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((IInt32SingleTypeint)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1438155459)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((703745606)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((5)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((465509334)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1384898795)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((710957639)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((922870820)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1539973062)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1730495979)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((11)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((607712875)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1339696504)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((2117822981)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1537934673)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1597073144)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1949751521)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1799006396)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((247225562)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1431049280)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((31308490)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1223536258)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((382763915)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1273005214)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((2144319172)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((2002309570)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1406879360)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1950522664)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1784462623)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((2006967979)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1116538288)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((865871632)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((823536462)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((38)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1389232903)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((271632001)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((767724220)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1840530816)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((337771262)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((804095443)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((870770914)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((423667269)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((304593696)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((847132268)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1442035954)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((289586503)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((128238631)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((2059319682)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1898400395)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1253822058)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1241862579)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1133426553)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((2099394159)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((2109070659)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((2101124675)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((2012227804)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((706530223)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1997871467)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((774050500)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((391638192)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((892379636)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1710080532)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1620204130)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((598516052)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((2009315258)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((991340432)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1439065354)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((81)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((275894967)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((710071243)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1231741419)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((829622001)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((2001902990)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((158)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((183105393)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((86)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1011249899)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((2277405)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((174749878)));

            }
        }

#endregion

    }
}

