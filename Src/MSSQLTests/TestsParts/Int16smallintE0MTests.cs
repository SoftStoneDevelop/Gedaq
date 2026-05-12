

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
    internal partial interface IInt16SingleTypesmallint
    {
    }
    
    internal partial class Int16SingleTypesmallint : IInt16SingleTypesmallint
    {


#region TestData

        private readonly Int16smallintE0M[] _testData = new Int16smallintE0M[]
        {
            new Int16smallintE0M
{
    Id = 3,
    Value = 13434,
    ModelInner = null,
    NullableValue = 8232,
},
            new Int16smallintE0M
{
    Id = 8,
    Value = 23863,
    ModelInner = new Int16smallintE0MI
{
    Id = 1,
    Value = 17682,
    NullableValue = 5310,
},
    NullableValue = null,
},
            new Int16smallintE0M
{
    Id = 15,
    Value = 11543,
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintE0M
{
    Id = 17,
    Value = 5928,
    ModelInner = new Int16smallintE0MI
{
    Id = 2,
    Value = 19238,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16smallintE0M
{
    Id = 18,
    Value = 7736,
    ModelInner = null,
    NullableValue = 15960,
},
            new Int16smallintE0M
{
    Id = 20,
    Value = 3233,
    ModelInner = new Int16smallintE0MI
{
    Id = 7,
    Value = 15628,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16smallintE0M
{
    Id = 21,
    Value = 4252,
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintE0M
{
    Id = 30,
    Value = 10074,
    ModelInner = new Int16smallintE0MI
{
    Id = 16,
    Value = 17904,
    NullableValue = 6772,
},
    NullableValue = 19501,
},
            new Int16smallintE0M
{
    Id = 38,
    Value = 4416,
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintE0M
{
    Id = 39,
    Value = 6907,
    ModelInner = new Int16smallintE0MI
{
    Id = 24,
    Value = 15607,
    NullableValue = 10714,
},
    NullableValue = null,
},
            new Int16smallintE0M
{
    Id = 40,
    Value = 26164,
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintE0M
{
    Id = 43,
    Value = 38,
    ModelInner = new Int16smallintE0MI
{
    Id = 31,
    Value = 27849,
    NullableValue = 6304,
},
    NullableValue = null,
},
            new Int16smallintE0M
{
    Id = 52,
    Value = 24369,
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintE0M
{
    Id = 59,
    Value = 23226,
    ModelInner = new Int16smallintE0MI
{
    Id = 40,
    Value = 15775,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16smallintE0M
{
    Id = 67,
    Value = 3256,
    ModelInner = null,
    NullableValue = 22022,
},
            new Int16smallintE0M
{
    Id = 76,
    Value = 11724,
    ModelInner = new Int16smallintE0MI
{
    Id = 47,
    Value = 26951,
    NullableValue = null,
},
    NullableValue = 19529,
},
            new Int16smallintE0M
{
    Id = 79,
    Value = 13714,
    ModelInner = null,
    NullableValue = 10176,
},
            new Int16smallintE0M
{
    Id = 81,
    Value = 8279,
    ModelInner = new Int16smallintE0MI
{
    Id = 49,
    Value = 10615,
    NullableValue = 17489,
},
    NullableValue = null,
},
            new Int16smallintE0M
{
    Id = 82,
    Value = 29030,
    ModelInner = null,
    NullableValue = 26014,
},
            new Int16smallintE0M
{
    Id = 89,
    Value = 4942,
    ModelInner = new Int16smallintE0MI
{
    Id = 54,
    Value = 14119,
    NullableValue = null,
},
    NullableValue = 10239,
},
            new Int16smallintE0M
{
    Id = 98,
    Value = 17640,
    ModelInner = null,
    NullableValue = 11031,
},
            new Int16smallintE0M
{
    Id = 107,
    Value = 21719,
    ModelInner = new Int16smallintE0MI
{
    Id = 61,
    Value = 8164,
    NullableValue = 27201,
},
    NullableValue = null,
},
            new Int16smallintE0M
{
    Id = 113,
    Value = 3601,
    ModelInner = null,
    NullableValue = 31248,
},
            new Int16smallintE0M
{
    Id = 119,
    Value = 28876,
    ModelInner = new Int16smallintE0MI
{
    Id = 67,
    Value = 28090,
    NullableValue = null,
},
    NullableValue = 17107,
},
            new Int16smallintE0M
{
    Id = 120,
    Value = 25481,
    ModelInner = null,
    NullableValue = 15991,
},
            new Int16smallintE0M
{
    Id = 124,
    Value = 17259,
    ModelInner = new Int16smallintE0MI
{
    Id = 74,
    Value = 31542,
    NullableValue = null,
},
    NullableValue = 15887,
},
            new Int16smallintE0M
{
    Id = 131,
    Value = 18265,
    ModelInner = null,
    NullableValue = 16730,
},
            new Int16smallintE0M
{
    Id = 133,
    Value = 16695,
    ModelInner = new Int16smallintE0MI
{
    Id = 79,
    Value = 13499,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16smallintE0M
{
    Id = 137,
    Value = 15812,
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintE0M
{
    Id = 146,
    Value = 4400,
    ModelInner = new Int16smallintE0MI
{
    Id = 86,
    Value = 17470,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16smallintE0M
{
    Id = 154,
    Value = 2690,
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintE0M
{
    Id = 161,
    Value = 24104,
    ModelInner = new Int16smallintE0MI
{
    Id = 91,
    Value = 28754,
    NullableValue = 17673,
},
    NullableValue = 5820,
},
            new Int16smallintE0M
{
    Id = 163,
    Value = 4949,
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintE0M
{
    Id = 164,
    Value = 6244,
    ModelInner = new Int16smallintE0MI
{
    Id = 98,
    Value = 6375,
    NullableValue = null,
},
    NullableValue = 10757,
},
            new Int16smallintE0M
{
    Id = 173,
    Value = 10238,
    ModelInner = null,
    NullableValue = 28222,
},
        };

#endregion

#region InsertModelInner

[Gedaq.SqlClient.Attributes.Query(
            query: @"
INSERT INTO dbo.int16smallinte0mi(
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
            asPartInterface: typeof(IInt16SingleTypesmallint)), 
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                parametrName: "id",
                methodParametrName: "id", 
                dbType: (System.Data.SqlDbType)(8)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int16),
                parametrName: "value",
                methodParametrName: "value",
                dbType: (System.Data.SqlDbType)(16)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int16?), 
                parametrName: "nullablevalue",
                methodParametrName: "nullablevalue",
                dbType: (System.Data.SqlDbType)(16))
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

                changedRows =  ((IInt16SingleTypesmallint)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IInt16SingleTypesmallint)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IInt16SingleTypesmallint)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO dbo.int16smallinte0mi(
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
            asPartInterface: typeof(IInt16SingleTypesmallint)), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)11),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int16), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)10),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int16?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)10, 
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

                changedRows =  ((IInt16SingleTypesmallint)this).DbConnectionInsertInnerModel(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
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

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertInnerModelAsync(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertInnerModelAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertInnerModelAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertInnerModelAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertInnerModelAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertInnerModelAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertInnerModelAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertInnerModelAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertInnerModelAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertInnerModelAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertInnerModelAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertInnerModelAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.SqlClient.Attributes.Query(
            query: @"
INSERT INTO dbo.int16smallinte0m(
	id,
    value,
    nullablevalue,
    int16smallinte0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @int16smallinte0mi_id
)
",
            methodName:"InsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                parametrName: "id",
                methodParametrName: "id",
                dbType: (System.Data.SqlDbType)(8)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int16), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.SqlDbType)(16)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int16?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.SqlDbType)(16),
                nullable: true),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "int16smallinte0mi_id", 
                methodParametrName: "int16smallinte0mi_id", 
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

                changedRows =  ((IInt16SingleTypesmallint)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IInt16SingleTypesmallint)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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

                changedRows = await ((IInt16SingleTypesmallint)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO dbo.int16smallinte0m(
	id,
    value,
    nullablevalue,
    int16smallinte0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @int16smallinte0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)11),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int16), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)10),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int16?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)10,
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "int16smallinte0mi_id", 
                methodParametrName: "int16smallinte0mi_id", 
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

                changedRows =  ((IInt16SingleTypesmallint)this).DbConnectionInsertModel(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IInt16SingleTypesmallint)this).DbConnectionInsertModel(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
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

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt16SingleTypesmallint)this).DbConnectionInsertModelAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt16smallintE0M), typeof(FlatInt16smallintE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint)),
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
FROM dbo.int16smallinte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt16smallintE0M>();
                var models2 = new List<FlatInt16smallintE0M>();
                await((IInt16SingleTypesmallint)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintE0M.AssertModel(models1[i],_testData[i], false);
                    FlatInt16smallintE0M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.int16smallinte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt16smallintE0M>();
                var models2 = new List<FlatInt16smallintE0M>();
                ((IInt16SingleTypesmallint)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintE0M.AssertModel(models1[i],_testData[i], false);
                    FlatInt16smallintE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt16smallintE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint)),
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
FROM dbo.int16smallinte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models = await((IInt16SingleTypesmallint)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintE0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.int16smallinte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models = ((IInt16SingleTypesmallint)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintE0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.int16smallinte0m m
LEFT JOIN dbo.int16smallinte0mi mi ON mi.id = m.int16smallinte0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Int16smallintE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint)),
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
                var models = await((IInt16SingleTypesmallint)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int16smallintE0M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IInt16SingleTypesmallint)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int16smallintE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt16smallintE0M), typeof(FlatInt16smallintE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint)),
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
FROM dbo.int16smallinte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt16smallintE0M>();
                var models2 = new List<FlatInt16smallintE0M>();
                await((IInt16SingleTypesmallint)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintE0M.AssertModel(models1[i],_testData[i], false);
                    FlatInt16smallintE0M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.int16smallinte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt16smallintE0M>();
                var models2 = new List<FlatInt16smallintE0M>();
                ((IInt16SingleTypesmallint)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintE0M.AssertModel(models1[i],_testData[i], false);
                    FlatInt16smallintE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt16smallintE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint)),
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
FROM dbo.int16smallinte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IInt16SingleTypesmallint)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintE0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.int16smallinte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IInt16SingleTypesmallint)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintE0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.int16smallinte0m m
LEFT JOIN dbo.int16smallinte0mi mi ON mi.id = m.int16smallinte0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Int16smallintE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint)),
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
                var models = await((IInt16SingleTypesmallint)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int16smallintE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IInt16SingleTypesmallint)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int16smallintE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt16smallintE0M), typeof(FlatInt16smallintE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint)),
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
            asPartInterface: typeof(IInt16SingleTypesmallint)),
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
FROM dbo.int16smallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt16smallintE0M>();
                var models2 = new List<FlatInt16smallintE0M>();
                await((IInt16SingleTypesmallint)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintE0M.AssertModel(models1[i],_testData[i], false);
                    FlatInt16smallintE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 154;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 20;
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
FROM dbo.int16smallinte0m m
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
FROM dbo.int16smallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintE0M>();
                var firstItems2 = new List<FlatInt16smallintE0M>();
                var secondItems1 = new List<FlatInt16smallintE0M>();
                var secondItems2 = new List<FlatInt16smallintE0M>();
                await ((IInt16SingleTypesmallint)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatInt16smallintE0M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatInt16smallintE0M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[28],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 79;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 131;
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
FROM dbo.int16smallinte0m m
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
FROM dbo.int16smallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintE0M>();
                var firstItems2 = new List<FlatInt16smallintE0M>();
                var secondItems1 = new List<FlatInt16smallintE0M>();
                await ((IInt16SingleTypesmallint)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatInt16smallintE0M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatInt16smallintE0M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[7],_testData[34], false);
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
FROM dbo.int16smallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt16smallintE0M>();
                var models2 = new List<FlatInt16smallintE0M>();
                ((IInt16SingleTypesmallint)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintE0M.AssertModel(models1[i],_testData[i], false);
                    FlatInt16smallintE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 79;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 20;
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
FROM dbo.int16smallinte0m m
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
FROM dbo.int16smallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintE0M>();
                var firstItems2 = new List<FlatInt16smallintE0M>();
                var secondItems1 = new List<FlatInt16smallintE0M>();
                var secondItems2 = new List<FlatInt16smallintE0M>();
                 ((IInt16SingleTypesmallint)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatInt16smallintE0M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatInt16smallintE0M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[28],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 39;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 30;
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
FROM dbo.int16smallinte0m m
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
FROM dbo.int16smallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintE0M>();
                var firstItems2 = new List<FlatInt16smallintE0M>();
                var secondItems1 = new List<FlatInt16smallintE0M>();
                 ((IInt16SingleTypesmallint)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatInt16smallintE0M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                        FlatInt16smallintE0M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[26],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt16smallintE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint)),
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
            asPartInterface: typeof(IInt16SingleTypesmallint)),
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
FROM dbo.int16smallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IInt16SingleTypesmallint)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 52;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 154;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.int16smallinte0m m
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
FROM dbo.int16smallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt16SingleTypesmallint)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatInt16smallintE0M.AssertModel(models[0],_testData[13], false);
                        FlatInt16smallintE0M.AssertModel(models[1],_testData[14], false);
                        FlatInt16smallintE0M.AssertModel(models[2],_testData[15], false);
                        FlatInt16smallintE0M.AssertModel(models[3],_testData[16], false);
                        FlatInt16smallintE0M.AssertModel(models[4],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(models[5],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(models[6],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(models[7],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(models[8],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(models[9],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(models[10],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(models[11],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(models[12],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(models[13],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(models[14],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(models[15],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(models[16],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(models[17],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(models[18],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(models[19],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(models[20],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatInt16smallintE0M.AssertModel(models[0],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(models[1],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(models[2],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(models[3],_testData[34], false);
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
                parametr1.Value = 163;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 98;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.int16smallinte0m m
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
FROM dbo.int16smallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintE0M>();
                var secondItems1 = new List<FlatInt16smallintE0M>();
                var secondItems2 = new List<FlatInt16smallintE0M>();
                await ((IInt16SingleTypesmallint)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatInt16smallintE0M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatInt16smallintE0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[13],_testData[34], false);
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
FROM dbo.int16smallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IInt16SingleTypesmallint)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 20;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 137;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.int16smallinte0m m
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
FROM dbo.int16smallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt16SingleTypesmallint)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatInt16smallintE0M.AssertModel(models[0],_testData[6], false);
                        FlatInt16smallintE0M.AssertModel(models[1],_testData[7], false);
                        FlatInt16smallintE0M.AssertModel(models[2],_testData[8], false);
                        FlatInt16smallintE0M.AssertModel(models[3],_testData[9], false);
                        FlatInt16smallintE0M.AssertModel(models[4],_testData[10], false);
                        FlatInt16smallintE0M.AssertModel(models[5],_testData[11], false);
                        FlatInt16smallintE0M.AssertModel(models[6],_testData[12], false);
                        FlatInt16smallintE0M.AssertModel(models[7],_testData[13], false);
                        FlatInt16smallintE0M.AssertModel(models[8],_testData[14], false);
                        FlatInt16smallintE0M.AssertModel(models[9],_testData[15], false);
                        FlatInt16smallintE0M.AssertModel(models[10],_testData[16], false);
                        FlatInt16smallintE0M.AssertModel(models[11],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(models[12],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(models[13],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(models[14],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(models[15],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(models[16],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(models[17],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(models[18],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(models[19],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(models[20],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(models[21],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(models[22],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(models[23],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(models[24],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(models[25],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(models[26],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(models[27],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatInt16smallintE0M.AssertModel(models[0],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(models[1],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(models[2],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(models[3],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(models[4],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(models[5],_testData[34], false);
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
                parametr1.Value = 21;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 20;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.int16smallinte0m m
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
FROM dbo.int16smallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintE0M>();
                var secondItems1 = new List<FlatInt16smallintE0M>();
                var secondItems2 = new List<FlatInt16smallintE0M>();
                 ((IInt16SingleTypesmallint)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatInt16smallintE0M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatInt16smallintE0M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[28],_testData[34], false);
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
FROM dbo.int16smallinte0m m
LEFT JOIN dbo.int16smallinte0mi mi ON mi.id = m.int16smallinte0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Int16smallintE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint)),
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
                var models = await((IInt16SingleTypesmallint)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int16smallintE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 52;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 89;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt16SingleTypesmallint)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        Int16smallintE0M.AssertModel(models[0],_testData[13], false);
                        Int16smallintE0M.AssertModel(models[1],_testData[14], false);
                        Int16smallintE0M.AssertModel(models[2],_testData[15], false);
                        Int16smallintE0M.AssertModel(models[3],_testData[16], false);
                        Int16smallintE0M.AssertModel(models[4],_testData[17], false);
                        Int16smallintE0M.AssertModel(models[5],_testData[18], false);
                        Int16smallintE0M.AssertModel(models[6],_testData[19], false);
                        Int16smallintE0M.AssertModel(models[7],_testData[20], false);
                        Int16smallintE0M.AssertModel(models[8],_testData[21], false);
                        Int16smallintE0M.AssertModel(models[9],_testData[22], false);
                        Int16smallintE0M.AssertModel(models[10],_testData[23], false);
                        Int16smallintE0M.AssertModel(models[11],_testData[24], false);
                        Int16smallintE0M.AssertModel(models[12],_testData[25], false);
                        Int16smallintE0M.AssertModel(models[13],_testData[26], false);
                        Int16smallintE0M.AssertModel(models[14],_testData[27], false);
                        Int16smallintE0M.AssertModel(models[15],_testData[28], false);
                        Int16smallintE0M.AssertModel(models[16],_testData[29], false);
                        Int16smallintE0M.AssertModel(models[17],_testData[30], false);
                        Int16smallintE0M.AssertModel(models[18],_testData[31], false);
                        Int16smallintE0M.AssertModel(models[19],_testData[32], false);
                        Int16smallintE0M.AssertModel(models[20],_testData[33], false);
                        Int16smallintE0M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        Int16smallintE0M.AssertModel(models[0],_testData[20], false);
                        Int16smallintE0M.AssertModel(models[1],_testData[21], false);
                        Int16smallintE0M.AssertModel(models[2],_testData[22], false);
                        Int16smallintE0M.AssertModel(models[3],_testData[23], false);
                        Int16smallintE0M.AssertModel(models[4],_testData[24], false);
                        Int16smallintE0M.AssertModel(models[5],_testData[25], false);
                        Int16smallintE0M.AssertModel(models[6],_testData[26], false);
                        Int16smallintE0M.AssertModel(models[7],_testData[27], false);
                        Int16smallintE0M.AssertModel(models[8],_testData[28], false);
                        Int16smallintE0M.AssertModel(models[9],_testData[29], false);
                        Int16smallintE0M.AssertModel(models[10],_testData[30], false);
                        Int16smallintE0M.AssertModel(models[11],_testData[31], false);
                        Int16smallintE0M.AssertModel(models[12],_testData[32], false);
                        Int16smallintE0M.AssertModel(models[13],_testData[33], false);
                        Int16smallintE0M.AssertModel(models[14],_testData[34], false);
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
                var models = ((IInt16SingleTypesmallint)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int16smallintE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 82;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 137;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt16SingleTypesmallint)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        Int16smallintE0M.AssertModel(models[0],_testData[19], false);
                        Int16smallintE0M.AssertModel(models[1],_testData[20], false);
                        Int16smallintE0M.AssertModel(models[2],_testData[21], false);
                        Int16smallintE0M.AssertModel(models[3],_testData[22], false);
                        Int16smallintE0M.AssertModel(models[4],_testData[23], false);
                        Int16smallintE0M.AssertModel(models[5],_testData[24], false);
                        Int16smallintE0M.AssertModel(models[6],_testData[25], false);
                        Int16smallintE0M.AssertModel(models[7],_testData[26], false);
                        Int16smallintE0M.AssertModel(models[8],_testData[27], false);
                        Int16smallintE0M.AssertModel(models[9],_testData[28], false);
                        Int16smallintE0M.AssertModel(models[10],_testData[29], false);
                        Int16smallintE0M.AssertModel(models[11],_testData[30], false);
                        Int16smallintE0M.AssertModel(models[12],_testData[31], false);
                        Int16smallintE0M.AssertModel(models[13],_testData[32], false);
                        Int16smallintE0M.AssertModel(models[14],_testData[33], false);
                        Int16smallintE0M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        Int16smallintE0M.AssertModel(models[0],_testData[29], false);
                        Int16smallintE0M.AssertModel(models[1],_testData[30], false);
                        Int16smallintE0M.AssertModel(models[2],_testData[31], false);
                        Int16smallintE0M.AssertModel(models[3],_testData[32], false);
                        Int16smallintE0M.AssertModel(models[4],_testData[33], false);
                        Int16smallintE0M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt16smallintE0M), typeof(FlatInt16smallintE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint)),
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
            asPartInterface: typeof(IInt16SingleTypesmallint)),
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
            asPartInterface: typeof(IInt16SingleTypesmallint)),
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
FROM dbo.int16smallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt16smallintE0M>();
                var models2 = new List<FlatInt16smallintE0M>();
                await((IInt16SingleTypesmallint)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintE0M.AssertModel(models1[i],_testData[i], false);
                    FlatInt16smallintE0M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.int16smallinte0m m
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
FROM dbo.int16smallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintE0M>();
                var firstItems2 = new List<FlatInt16smallintE0M>();
                var secondItems1 = new List<FlatInt16smallintE0M>();
                var secondItems2 = new List<FlatInt16smallintE0M>();
                await ((IInt16SingleTypesmallint)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 3, query1, 30, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatInt16smallintE0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatInt16smallintE0M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[26],_testData[34], false);
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
FROM dbo.int16smallinte0m m
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
FROM dbo.int16smallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintE0M>();
                var firstItems2 = new List<FlatInt16smallintE0M>();
                var secondItems1 = new List<FlatInt16smallintE0M>();
                await ((IInt16SingleTypesmallint)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 131, query1, 18, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatInt16smallintE0M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                        FlatInt16smallintE0M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[29],_testData[34], false);
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
FROM dbo.int16smallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt16smallintE0M>();
                var models2 = new List<FlatInt16smallintE0M>();
                ((IInt16SingleTypesmallint)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintE0M.AssertModel(models1[i],_testData[i], false);
                    FlatInt16smallintE0M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.int16smallinte0m m
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
FROM dbo.int16smallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintE0M>();
                var firstItems2 = new List<FlatInt16smallintE0M>();
                var secondItems1 = new List<FlatInt16smallintE0M>();
                var secondItems2 = new List<FlatInt16smallintE0M>();
                 ((IInt16SingleTypesmallint)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 79, query1, 20, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatInt16smallintE0M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatInt16smallintE0M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[28],_testData[34], false);
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
FROM dbo.int16smallinte0m m
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
FROM dbo.int16smallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintE0M>();
                var firstItems2 = new List<FlatInt16smallintE0M>();
                var secondItems1 = new List<FlatInt16smallintE0M>();
                 ((IInt16SingleTypesmallint)this).DbConnectionMMDynQuerySelectModelBatch(connection, 124, query1, 120, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatInt16smallintE0M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                        FlatInt16smallintE0M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[9],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt16smallintE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint)),
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
            asPartInterface: typeof(IInt16SingleTypesmallint)),
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
            asPartInterface: typeof(IInt16SingleTypesmallint)),
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
FROM dbo.int16smallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IInt16SingleTypesmallint)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintE0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.int16smallinte0m m
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
FROM dbo.int16smallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt16SingleTypesmallint)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 133, query1, 161, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatInt16smallintE0M.AssertModel(models[0],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(models[1],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(models[2],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(models[3],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(models[4],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(models[5],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatInt16smallintE0M.AssertModel(models[0],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(models[1],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(models[2],_testData[34], false);
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
FROM dbo.int16smallinte0m m
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
FROM dbo.int16smallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintE0M>();
                var secondItems1 = new List<FlatInt16smallintE0M>();
                var secondItems2 = new List<FlatInt16smallintE0M>();
                await ((IInt16SingleTypesmallint)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 81, query1, 82, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                        FlatInt16smallintE0M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatInt16smallintE0M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[15],_testData[34], false);
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
FROM dbo.int16smallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IInt16SingleTypesmallint)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintE0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.int16smallinte0m m
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
FROM dbo.int16smallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt16SingleTypesmallint)this).DbConnectionSTDynQuerySelectModelBatch(connection, 146, query1, 133, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatInt16smallintE0M.AssertModel(models[0],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(models[1],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(models[2],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(models[3],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatInt16smallintE0M.AssertModel(models[0],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(models[1],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(models[2],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(models[3],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(models[4],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(models[5],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(models[6],_testData[34], false);
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
FROM dbo.int16smallinte0m m
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
FROM dbo.int16smallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintE0M>();
                var secondItems1 = new List<FlatInt16smallintE0M>();
                var secondItems2 = new List<FlatInt16smallintE0M>();
                 ((IInt16SingleTypesmallint)this).DbConnectionDynQuerySelectModelBatch(connection, 3, query1, 40, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                        FlatInt16smallintE0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatInt16smallintE0M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[23],_testData[34], false);
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
FROM dbo.int16smallinte0m m
LEFT JOIN dbo.int16smallinte0mi mi ON mi.id = m.int16smallinte0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Int16smallintE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint)),
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
            asPartInterface: typeof(IInt16SingleTypesmallint)),
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
                var models = await((IInt16SingleTypesmallint)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int16smallintE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IInt16SingleTypesmallint)this).DbConnectionSTSelectModelBatchAsync(connection, 15, 40))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        Int16smallintE0M.AssertModel(models[0],_testData[3], false);
                        Int16smallintE0M.AssertModel(models[1],_testData[4], false);
                        Int16smallintE0M.AssertModel(models[2],_testData[5], false);
                        Int16smallintE0M.AssertModel(models[3],_testData[6], false);
                        Int16smallintE0M.AssertModel(models[4],_testData[7], false);
                        Int16smallintE0M.AssertModel(models[5],_testData[8], false);
                        Int16smallintE0M.AssertModel(models[6],_testData[9], false);
                        Int16smallintE0M.AssertModel(models[7],_testData[10], false);
                        Int16smallintE0M.AssertModel(models[8],_testData[11], false);
                        Int16smallintE0M.AssertModel(models[9],_testData[12], false);
                        Int16smallintE0M.AssertModel(models[10],_testData[13], false);
                        Int16smallintE0M.AssertModel(models[11],_testData[14], false);
                        Int16smallintE0M.AssertModel(models[12],_testData[15], false);
                        Int16smallintE0M.AssertModel(models[13],_testData[16], false);
                        Int16smallintE0M.AssertModel(models[14],_testData[17], false);
                        Int16smallintE0M.AssertModel(models[15],_testData[18], false);
                        Int16smallintE0M.AssertModel(models[16],_testData[19], false);
                        Int16smallintE0M.AssertModel(models[17],_testData[20], false);
                        Int16smallintE0M.AssertModel(models[18],_testData[21], false);
                        Int16smallintE0M.AssertModel(models[19],_testData[22], false);
                        Int16smallintE0M.AssertModel(models[20],_testData[23], false);
                        Int16smallintE0M.AssertModel(models[21],_testData[24], false);
                        Int16smallintE0M.AssertModel(models[22],_testData[25], false);
                        Int16smallintE0M.AssertModel(models[23],_testData[26], false);
                        Int16smallintE0M.AssertModel(models[24],_testData[27], false);
                        Int16smallintE0M.AssertModel(models[25],_testData[28], false);
                        Int16smallintE0M.AssertModel(models[26],_testData[29], false);
                        Int16smallintE0M.AssertModel(models[27],_testData[30], false);
                        Int16smallintE0M.AssertModel(models[28],_testData[31], false);
                        Int16smallintE0M.AssertModel(models[29],_testData[32], false);
                        Int16smallintE0M.AssertModel(models[30],_testData[33], false);
                        Int16smallintE0M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        Int16smallintE0M.AssertModel(models[0],_testData[11], false);
                        Int16smallintE0M.AssertModel(models[1],_testData[12], false);
                        Int16smallintE0M.AssertModel(models[2],_testData[13], false);
                        Int16smallintE0M.AssertModel(models[3],_testData[14], false);
                        Int16smallintE0M.AssertModel(models[4],_testData[15], false);
                        Int16smallintE0M.AssertModel(models[5],_testData[16], false);
                        Int16smallintE0M.AssertModel(models[6],_testData[17], false);
                        Int16smallintE0M.AssertModel(models[7],_testData[18], false);
                        Int16smallintE0M.AssertModel(models[8],_testData[19], false);
                        Int16smallintE0M.AssertModel(models[9],_testData[20], false);
                        Int16smallintE0M.AssertModel(models[10],_testData[21], false);
                        Int16smallintE0M.AssertModel(models[11],_testData[22], false);
                        Int16smallintE0M.AssertModel(models[12],_testData[23], false);
                        Int16smallintE0M.AssertModel(models[13],_testData[24], false);
                        Int16smallintE0M.AssertModel(models[14],_testData[25], false);
                        Int16smallintE0M.AssertModel(models[15],_testData[26], false);
                        Int16smallintE0M.AssertModel(models[16],_testData[27], false);
                        Int16smallintE0M.AssertModel(models[17],_testData[28], false);
                        Int16smallintE0M.AssertModel(models[18],_testData[29], false);
                        Int16smallintE0M.AssertModel(models[19],_testData[30], false);
                        Int16smallintE0M.AssertModel(models[20],_testData[31], false);
                        Int16smallintE0M.AssertModel(models[21],_testData[32], false);
                        Int16smallintE0M.AssertModel(models[22],_testData[33], false);
                        Int16smallintE0M.AssertModel(models[23],_testData[34], false);
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
                var models = ((IInt16SingleTypesmallint)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int16smallintE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IInt16SingleTypesmallint)this).DbConnectionSTSelectModelBatch(connection, 30, 89))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        Int16smallintE0M.AssertModel(models[0],_testData[8], false);
                        Int16smallintE0M.AssertModel(models[1],_testData[9], false);
                        Int16smallintE0M.AssertModel(models[2],_testData[10], false);
                        Int16smallintE0M.AssertModel(models[3],_testData[11], false);
                        Int16smallintE0M.AssertModel(models[4],_testData[12], false);
                        Int16smallintE0M.AssertModel(models[5],_testData[13], false);
                        Int16smallintE0M.AssertModel(models[6],_testData[14], false);
                        Int16smallintE0M.AssertModel(models[7],_testData[15], false);
                        Int16smallintE0M.AssertModel(models[8],_testData[16], false);
                        Int16smallintE0M.AssertModel(models[9],_testData[17], false);
                        Int16smallintE0M.AssertModel(models[10],_testData[18], false);
                        Int16smallintE0M.AssertModel(models[11],_testData[19], false);
                        Int16smallintE0M.AssertModel(models[12],_testData[20], false);
                        Int16smallintE0M.AssertModel(models[13],_testData[21], false);
                        Int16smallintE0M.AssertModel(models[14],_testData[22], false);
                        Int16smallintE0M.AssertModel(models[15],_testData[23], false);
                        Int16smallintE0M.AssertModel(models[16],_testData[24], false);
                        Int16smallintE0M.AssertModel(models[17],_testData[25], false);
                        Int16smallintE0M.AssertModel(models[18],_testData[26], false);
                        Int16smallintE0M.AssertModel(models[19],_testData[27], false);
                        Int16smallintE0M.AssertModel(models[20],_testData[28], false);
                        Int16smallintE0M.AssertModel(models[21],_testData[29], false);
                        Int16smallintE0M.AssertModel(models[22],_testData[30], false);
                        Int16smallintE0M.AssertModel(models[23],_testData[31], false);
                        Int16smallintE0M.AssertModel(models[24],_testData[32], false);
                        Int16smallintE0M.AssertModel(models[25],_testData[33], false);
                        Int16smallintE0M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        Int16smallintE0M.AssertModel(models[0],_testData[20], false);
                        Int16smallintE0M.AssertModel(models[1],_testData[21], false);
                        Int16smallintE0M.AssertModel(models[2],_testData[22], false);
                        Int16smallintE0M.AssertModel(models[3],_testData[23], false);
                        Int16smallintE0M.AssertModel(models[4],_testData[24], false);
                        Int16smallintE0M.AssertModel(models[5],_testData[25], false);
                        Int16smallintE0M.AssertModel(models[6],_testData[26], false);
                        Int16smallintE0M.AssertModel(models[7],_testData[27], false);
                        Int16smallintE0M.AssertModel(models[8],_testData[28], false);
                        Int16smallintE0M.AssertModel(models[9],_testData[29], false);
                        Int16smallintE0M.AssertModel(models[10],_testData[30], false);
                        Int16smallintE0M.AssertModel(models[11],_testData[31], false);
                        Int16smallintE0M.AssertModel(models[12],_testData[32], false);
                        Int16smallintE0M.AssertModel(models[13],_testData[33], false);
                        Int16smallintE0M.AssertModel(models[14],_testData[34], false);
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
                await using var cmd = await ((IInt16SingleTypesmallint)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IInt16SingleTypesmallint)this).SetDbConnectionSelectModelParametrs(cmd, 154);
                var models = await ((IInt16SingleTypesmallint)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(4));

                Int16smallintE0M.AssertModel(models[0],_testData[31], false);
                Int16smallintE0M.AssertModel(models[1],_testData[32], false);
                Int16smallintE0M.AssertModel(models[2],_testData[33], false);
                Int16smallintE0M.AssertModel(models[3],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt16SingleTypesmallint)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt16SingleTypesmallint)this).SetDbConnectionSelectModelParametrs(cmd, 119);
                var models =  ((IInt16SingleTypesmallint)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(11));

                Int16smallintE0M.AssertModel(models[0],_testData[24], false);
                Int16smallintE0M.AssertModel(models[1],_testData[25], false);
                Int16smallintE0M.AssertModel(models[2],_testData[26], false);
                Int16smallintE0M.AssertModel(models[3],_testData[27], false);
                Int16smallintE0M.AssertModel(models[4],_testData[28], false);
                Int16smallintE0M.AssertModel(models[5],_testData[29], false);
                Int16smallintE0M.AssertModel(models[6],_testData[30], false);
                Int16smallintE0M.AssertModel(models[7],_testData[31], false);
                Int16smallintE0M.AssertModel(models[8],_testData[32], false);
                Int16smallintE0M.AssertModel(models[9],_testData[33], false);
                Int16smallintE0M.AssertModel(models[10],_testData[34], false);
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
FROM dbo.int16smallinte0m m
LEFT JOIN dbo.int16smallinte0mi mi ON mi.id = m.int16smallinte0mi_id
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
            asPartInterface: typeof(IInt16SingleTypesmallint))]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IInt16SingleTypesmallint)this).DbConnectionSelectModelToObjArrAsync(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((3)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((13434)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((8232)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((23863)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((17682)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((5310)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((11543)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((5928)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((19238)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((7736)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((15960)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((3233)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((15628)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((4252)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((10074)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((17904)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((6772)));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((19501)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((4416)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((6907)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((15607)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((10714)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((26164)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((38)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((27849)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((6304)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((24369)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((23226)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((15775)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((3256)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((22022)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((11724)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((26951)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((19529)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((13714)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((10176)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((8279)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((10615)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((17489)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((29030)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((26014)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((4942)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((14119)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((10239)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((17640)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((11031)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((21719)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((8164)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((27201)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((3601)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((31248)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((28876)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((67)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((28090)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((17107)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((25481)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((15991)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((17259)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((74)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((31542)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((15887)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((18265)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((16730)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((16695)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((79)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((13499)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((15812)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((4400)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((86)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((17470)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((2690)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((161)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((24104)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((91)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((28754)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((17673)));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((5820)));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((163)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((4949)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((164)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((6244)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((98)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((6375)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((10757)));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((173)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((10238)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((28222)));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((IInt16SingleTypesmallint)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((3)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((13434)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((8232)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((23863)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((17682)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((5310)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((11543)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((5928)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((19238)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((7736)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((15960)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((3233)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((15628)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((4252)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((10074)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((17904)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((6772)));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((19501)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((4416)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((6907)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((15607)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((10714)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((26164)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((38)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((27849)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((6304)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((24369)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((23226)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((15775)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((3256)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((22022)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((11724)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((26951)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((19529)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((13714)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((10176)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((8279)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((10615)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((17489)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((29030)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((26014)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((4942)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((14119)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((10239)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((17640)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((11031)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((21719)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((8164)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((27201)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((3601)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((31248)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((28876)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((67)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((28090)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((17107)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((25481)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((15991)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((17259)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((74)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((31542)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((15887)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((18265)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((16730)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((16695)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((79)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((13499)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((15812)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((4400)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((86)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((17470)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((2690)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((161)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((24104)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((91)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((28754)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((17673)));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((5820)));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((163)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((4949)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((164)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((6244)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((98)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((6375)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((10757)));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((173)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((10238)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((28222)));

            }
        }

#endregion

    }
}

