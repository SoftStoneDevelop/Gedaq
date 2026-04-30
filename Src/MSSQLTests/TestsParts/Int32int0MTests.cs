

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
    Id = 3,
    Value = 716271588,
    ModelInner = null,
    NullableValue = null,
},
            new Int32int0M
{
    Id = 9,
    Value = 583685369,
    ModelInner = new Int32int0MI
{
    Id = 1,
    Value = 2116191564,
    NullableValue = null,
},
    NullableValue = 1097358167,
},
            new Int32int0M
{
    Id = 13,
    Value = 861775482,
    ModelInner = null,
    NullableValue = null,
},
            new Int32int0M
{
    Id = 22,
    Value = 69498423,
    ModelInner = new Int32int0MI
{
    Id = 2,
    Value = 892477991,
    NullableValue = 223756786,
},
    NullableValue = null,
},
            new Int32int0M
{
    Id = 25,
    Value = 437175393,
    ModelInner = null,
    NullableValue = null,
},
            new Int32int0M
{
    Id = 34,
    Value = 2025659838,
    ModelInner = new Int32int0MI
{
    Id = 11,
    Value = 571132301,
    NullableValue = 392770916,
},
    NullableValue = null,
},
            new Int32int0M
{
    Id = 42,
    Value = 1981863262,
    ModelInner = null,
    NullableValue = 718574933,
},
            new Int32int0M
{
    Id = 44,
    Value = 1796528473,
    ModelInner = new Int32int0MI
{
    Id = 19,
    Value = 1484339592,
    NullableValue = 26629291,
},
    NullableValue = null,
},
            new Int32int0M
{
    Id = 51,
    Value = 951073114,
    ModelInner = null,
    NullableValue = 1783275553,
},
            new Int32int0M
{
    Id = 56,
    Value = 1635046932,
    ModelInner = new Int32int0MI
{
    Id = 23,
    Value = 840209881,
    NullableValue = 428744029,
},
    NullableValue = null,
},
            new Int32int0M
{
    Id = 57,
    Value = 154214244,
    ModelInner = null,
    NullableValue = 1176342837,
},
            new Int32int0M
{
    Id = 63,
    Value = 1521979201,
    ModelInner = new Int32int0MI
{
    Id = 30,
    Value = 995980449,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32int0M
{
    Id = 69,
    Value = 1622274827,
    ModelInner = null,
    NullableValue = null,
},
            new Int32int0M
{
    Id = 75,
    Value = 1362477146,
    ModelInner = new Int32int0MI
{
    Id = 39,
    Value = 1588355356,
    NullableValue = null,
},
    NullableValue = 294970434,
},
            new Int32int0M
{
    Id = 77,
    Value = 1293429623,
    ModelInner = null,
    NullableValue = 1087699101,
},
            new Int32int0M
{
    Id = 80,
    Value = 2019223912,
    ModelInner = new Int32int0MI
{
    Id = 40,
    Value = 952062337,
    NullableValue = 1764587516,
},
    NullableValue = 968250647,
},
            new Int32int0M
{
    Id = 81,
    Value = 1843886392,
    ModelInner = null,
    NullableValue = 344099153,
},
            new Int32int0M
{
    Id = 90,
    Value = 770469166,
    ModelInner = new Int32int0MI
{
    Id = 43,
    Value = 1704665951,
    NullableValue = 276024868,
},
    NullableValue = 764238122,
},
            new Int32int0M
{
    Id = 96,
    Value = 1860943510,
    ModelInner = null,
    NullableValue = null,
},
            new Int32int0M
{
    Id = 99,
    Value = 788338774,
    ModelInner = new Int32int0MI
{
    Id = 49,
    Value = 992245704,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32int0M
{
    Id = 107,
    Value = 1347901472,
    ModelInner = null,
    NullableValue = 1261267883,
},
            new Int32int0M
{
    Id = 110,
    Value = 827624951,
    ModelInner = new Int32int0MI
{
    Id = 57,
    Value = 1055736757,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32int0M
{
    Id = 116,
    Value = 1818242915,
    ModelInner = null,
    NullableValue = 1116258508,
},
            new Int32int0M
{
    Id = 122,
    Value = 464250652,
    ModelInner = new Int32int0MI
{
    Id = 65,
    Value = 1073458391,
    NullableValue = 2005453768,
},
    NullableValue = null,
},
            new Int32int0M
{
    Id = 127,
    Value = 432257840,
    ModelInner = null,
    NullableValue = 2085059849,
},
            new Int32int0M
{
    Id = 131,
    Value = 1051787896,
    ModelInner = new Int32int0MI
{
    Id = 74,
    Value = 1381202618,
    NullableValue = 431885456,
},
    NullableValue = 279910159,
},
            new Int32int0M
{
    Id = 135,
    Value = 1518068248,
    ModelInner = null,
    NullableValue = null,
},
            new Int32int0M
{
    Id = 139,
    Value = 167197284,
    ModelInner = new Int32int0MI
{
    Id = 78,
    Value = 2003242643,
    NullableValue = 1756670113,
},
    NullableValue = null,
},
            new Int32int0M
{
    Id = 146,
    Value = 3034605,
    ModelInner = null,
    NullableValue = 400841652,
},
            new Int32int0M
{
    Id = 148,
    Value = 1175387270,
    ModelInner = new Int32int0MI
{
    Id = 79,
    Value = 1802942784,
    NullableValue = null,
},
    NullableValue = 1881835808,
},
            new Int32int0M
{
    Id = 150,
    Value = 1142685976,
    ModelInner = null,
    NullableValue = null,
},
            new Int32int0M
{
    Id = 155,
    Value = 1764291327,
    ModelInner = new Int32int0MI
{
    Id = 86,
    Value = 1288944826,
    NullableValue = null,
},
    NullableValue = 1746989487,
},
            new Int32int0M
{
    Id = 163,
    Value = 2117885877,
    ModelInner = null,
    NullableValue = null,
},
            new Int32int0M
{
    Id = 170,
    Value = 934267235,
    ModelInner = new Int32int0MI
{
    Id = 88,
    Value = 1655735660,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32int0M
{
    Id = 171,
    Value = 1175770669,
    ModelInner = null,
    NullableValue = 1785444604,
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
                parametrName: "int32int0mi_id", 
                methodParametrName: "int32int0mi_id", 
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32int0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32int0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
FROM dbo.int32int0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt32int0M>();
                var models2 = new List<FlatInt32int0M>();
                await((IInt32SingleTypeint)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32int0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32int0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
FROM dbo.int32int0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IInt32SingleTypeint)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32int0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 51;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 150;
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
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatInt32int0M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatInt32int0M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatInt32int0M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatInt32int0M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatInt32int0M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatInt32int0M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatInt32int0M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatInt32int0M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatInt32int0M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatInt32int0M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatInt32int0M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatInt32int0M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatInt32int0M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatInt32int0M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatInt32int0M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatInt32int0M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatInt32int0M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatInt32int0M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatInt32int0M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatInt32int0M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatInt32int0M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatInt32int0M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatInt32int0M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatInt32int0M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatInt32int0M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatInt32int0M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatInt32int0M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatInt32int0M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatInt32int0M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatInt32int0M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatInt32int0M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatInt32int0M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatInt32int0M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatInt32int0M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatInt32int0M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatInt32int0M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatInt32int0M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatInt32int0M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatInt32int0M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatInt32int0M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatInt32int0M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatInt32int0M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatInt32int0M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatInt32int0M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatInt32int0M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatInt32int0M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatInt32int0M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatInt32int0M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatInt32int0M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatInt32int0M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatInt32int0M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatInt32int0M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatInt32int0M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatInt32int0M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatInt32int0M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatInt32int0M.AssertModel(secondItems2[3],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 42;
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
                await ((IInt32SingleTypeint)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
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
                        FlatInt32int0M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatInt32int0M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatInt32int0M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatInt32int0M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatInt32int0M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatInt32int0M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatInt32int0M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatInt32int0M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatInt32int0M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatInt32int0M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
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
                        FlatInt32int0M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatInt32int0M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatInt32int0M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatInt32int0M.AssertModel(secondItems1[19],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32int0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 44;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 44;
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
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatInt32int0M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatInt32int0M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatInt32int0M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatInt32int0M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatInt32int0M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatInt32int0M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatInt32int0M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatInt32int0M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatInt32int0M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatInt32int0M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatInt32int0M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatInt32int0M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatInt32int0M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatInt32int0M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatInt32int0M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatInt32int0M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatInt32int0M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatInt32int0M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatInt32int0M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatInt32int0M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatInt32int0M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatInt32int0M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatInt32int0M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatInt32int0M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatInt32int0M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatInt32int0M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatInt32int0M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatInt32int0M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatInt32int0M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatInt32int0M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatInt32int0M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatInt32int0M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatInt32int0M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatInt32int0M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatInt32int0M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatInt32int0M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatInt32int0M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatInt32int0M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatInt32int0M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatInt32int0M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatInt32int0M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatInt32int0M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatInt32int0M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatInt32int0M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatInt32int0M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatInt32int0M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatInt32int0M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatInt32int0M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatInt32int0M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatInt32int0M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatInt32int0M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatInt32int0M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatInt32int0M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatInt32int0M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatInt32int0M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatInt32int0M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatInt32int0M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatInt32int0M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatInt32int0M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatInt32int0M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatInt32int0M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatInt32int0M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatInt32int0M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatInt32int0M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatInt32int0M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatInt32int0M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatInt32int0M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatInt32int0M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatInt32int0M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatInt32int0M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatInt32int0M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatInt32int0M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatInt32int0M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatInt32int0M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatInt32int0M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatInt32int0M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatInt32int0M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatInt32int0M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatInt32int0M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatInt32int0M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatInt32int0M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatInt32int0M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatInt32int0M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatInt32int0M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatInt32int0M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatInt32int0M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatInt32int0M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatInt32int0M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatInt32int0M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatInt32int0M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatInt32int0M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatInt32int0M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatInt32int0M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatInt32int0M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatInt32int0M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatInt32int0M.AssertModel(secondItems2[26],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 34;
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
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
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
                        FlatInt32int0M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatInt32int0M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatInt32int0M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatInt32int0M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatInt32int0M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatInt32int0M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatInt32int0M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatInt32int0M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatInt32int0M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatInt32int0M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
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
                        FlatInt32int0M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatInt32int0M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatInt32int0M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatInt32int0M.AssertModel(secondItems1[19],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 42;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 13;
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
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt32SingleTypeint)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatInt32int0M.AssertModel(models[0],_testData[7], false);
                        FlatInt32int0M.AssertModel(models[1],_testData[8], false);
                        FlatInt32int0M.AssertModel(models[2],_testData[9], false);
                        FlatInt32int0M.AssertModel(models[3],_testData[10], false);
                        FlatInt32int0M.AssertModel(models[4],_testData[11], false);
                        FlatInt32int0M.AssertModel(models[5],_testData[12], false);
                        FlatInt32int0M.AssertModel(models[6],_testData[13], false);
                        FlatInt32int0M.AssertModel(models[7],_testData[14], false);
                        FlatInt32int0M.AssertModel(models[8],_testData[15], false);
                        FlatInt32int0M.AssertModel(models[9],_testData[16], false);
                        FlatInt32int0M.AssertModel(models[10],_testData[17], false);
                        FlatInt32int0M.AssertModel(models[11],_testData[18], false);
                        FlatInt32int0M.AssertModel(models[12],_testData[19], false);
                        FlatInt32int0M.AssertModel(models[13],_testData[20], false);
                        FlatInt32int0M.AssertModel(models[14],_testData[21], false);
                        FlatInt32int0M.AssertModel(models[15],_testData[22], false);
                        FlatInt32int0M.AssertModel(models[16],_testData[23], false);
                        FlatInt32int0M.AssertModel(models[17],_testData[24], false);
                        FlatInt32int0M.AssertModel(models[18],_testData[25], false);
                        FlatInt32int0M.AssertModel(models[19],_testData[26], false);
                        FlatInt32int0M.AssertModel(models[20],_testData[27], false);
                        FlatInt32int0M.AssertModel(models[21],_testData[28], false);
                        FlatInt32int0M.AssertModel(models[22],_testData[29], false);
                        FlatInt32int0M.AssertModel(models[23],_testData[30], false);
                        FlatInt32int0M.AssertModel(models[24],_testData[31], false);
                        FlatInt32int0M.AssertModel(models[25],_testData[32], false);
                        FlatInt32int0M.AssertModel(models[26],_testData[33], false);
                        FlatInt32int0M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

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
                        FlatInt32int0M.AssertModel(models[27],_testData[30], false);
                        FlatInt32int0M.AssertModel(models[28],_testData[31], false);
                        FlatInt32int0M.AssertModel(models[29],_testData[32], false);
                        FlatInt32int0M.AssertModel(models[30],_testData[33], false);
                        FlatInt32int0M.AssertModel(models[31],_testData[34], false);
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
                parametr1.Value = 13;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 80;
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
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                        FlatInt32int0M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatInt32int0M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatInt32int0M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatInt32int0M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatInt32int0M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatInt32int0M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatInt32int0M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatInt32int0M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatInt32int0M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatInt32int0M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatInt32int0M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatInt32int0M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatInt32int0M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatInt32int0M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatInt32int0M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatInt32int0M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatInt32int0M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatInt32int0M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatInt32int0M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatInt32int0M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatInt32int0M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatInt32int0M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatInt32int0M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatInt32int0M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatInt32int0M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatInt32int0M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatInt32int0M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatInt32int0M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatInt32int0M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatInt32int0M.AssertModel(firstItems1[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatInt32int0M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatInt32int0M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatInt32int0M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatInt32int0M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatInt32int0M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatInt32int0M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatInt32int0M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatInt32int0M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatInt32int0M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatInt32int0M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatInt32int0M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatInt32int0M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatInt32int0M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatInt32int0M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatInt32int0M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatInt32int0M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatInt32int0M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatInt32int0M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatInt32int0M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatInt32int0M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatInt32int0M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatInt32int0M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatInt32int0M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatInt32int0M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatInt32int0M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatInt32int0M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatInt32int0M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatInt32int0M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatInt32int0M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatInt32int0M.AssertModel(secondItems2[18],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 81;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 44;
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
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt32SingleTypeint)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatInt32int0M.AssertModel(models[0],_testData[17], false);
                        FlatInt32int0M.AssertModel(models[1],_testData[18], false);
                        FlatInt32int0M.AssertModel(models[2],_testData[19], false);
                        FlatInt32int0M.AssertModel(models[3],_testData[20], false);
                        FlatInt32int0M.AssertModel(models[4],_testData[21], false);
                        FlatInt32int0M.AssertModel(models[5],_testData[22], false);
                        FlatInt32int0M.AssertModel(models[6],_testData[23], false);
                        FlatInt32int0M.AssertModel(models[7],_testData[24], false);
                        FlatInt32int0M.AssertModel(models[8],_testData[25], false);
                        FlatInt32int0M.AssertModel(models[9],_testData[26], false);
                        FlatInt32int0M.AssertModel(models[10],_testData[27], false);
                        FlatInt32int0M.AssertModel(models[11],_testData[28], false);
                        FlatInt32int0M.AssertModel(models[12],_testData[29], false);
                        FlatInt32int0M.AssertModel(models[13],_testData[30], false);
                        FlatInt32int0M.AssertModel(models[14],_testData[31], false);
                        FlatInt32int0M.AssertModel(models[15],_testData[32], false);
                        FlatInt32int0M.AssertModel(models[16],_testData[33], false);
                        FlatInt32int0M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatInt32int0M.AssertModel(models[0],_testData[8], false);
                        FlatInt32int0M.AssertModel(models[1],_testData[9], false);
                        FlatInt32int0M.AssertModel(models[2],_testData[10], false);
                        FlatInt32int0M.AssertModel(models[3],_testData[11], false);
                        FlatInt32int0M.AssertModel(models[4],_testData[12], false);
                        FlatInt32int0M.AssertModel(models[5],_testData[13], false);
                        FlatInt32int0M.AssertModel(models[6],_testData[14], false);
                        FlatInt32int0M.AssertModel(models[7],_testData[15], false);
                        FlatInt32int0M.AssertModel(models[8],_testData[16], false);
                        FlatInt32int0M.AssertModel(models[9],_testData[17], false);
                        FlatInt32int0M.AssertModel(models[10],_testData[18], false);
                        FlatInt32int0M.AssertModel(models[11],_testData[19], false);
                        FlatInt32int0M.AssertModel(models[12],_testData[20], false);
                        FlatInt32int0M.AssertModel(models[13],_testData[21], false);
                        FlatInt32int0M.AssertModel(models[14],_testData[22], false);
                        FlatInt32int0M.AssertModel(models[15],_testData[23], false);
                        FlatInt32int0M.AssertModel(models[16],_testData[24], false);
                        FlatInt32int0M.AssertModel(models[17],_testData[25], false);
                        FlatInt32int0M.AssertModel(models[18],_testData[26], false);
                        FlatInt32int0M.AssertModel(models[19],_testData[27], false);
                        FlatInt32int0M.AssertModel(models[20],_testData[28], false);
                        FlatInt32int0M.AssertModel(models[21],_testData[29], false);
                        FlatInt32int0M.AssertModel(models[22],_testData[30], false);
                        FlatInt32int0M.AssertModel(models[23],_testData[31], false);
                        FlatInt32int0M.AssertModel(models[24],_testData[32], false);
                        FlatInt32int0M.AssertModel(models[25],_testData[33], false);
                        FlatInt32int0M.AssertModel(models[26],_testData[34], false);
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
                parametr1.Value = 75;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 107;
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
                Assert.That(firstItems1, Has.Count.EqualTo(21));
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
                        FlatInt32int0M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatInt32int0M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatInt32int0M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatInt32int0M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatInt32int0M.AssertModel(firstItems1[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatInt32int0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatInt32int0M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatInt32int0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatInt32int0M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatInt32int0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatInt32int0M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatInt32int0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatInt32int0M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatInt32int0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatInt32int0M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatInt32int0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatInt32int0M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatInt32int0M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatInt32int0M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatInt32int0M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatInt32int0M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatInt32int0M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatInt32int0M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatInt32int0M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatInt32int0M.AssertModel(secondItems2[13],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 155;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 75;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt32SingleTypeint)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        Int32int0M.AssertModel(models[0],_testData[32], false);
                        Int32int0M.AssertModel(models[1],_testData[33], false);
                        Int32int0M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        Int32int0M.AssertModel(models[0],_testData[14], false);
                        Int32int0M.AssertModel(models[1],_testData[15], false);
                        Int32int0M.AssertModel(models[2],_testData[16], false);
                        Int32int0M.AssertModel(models[3],_testData[17], false);
                        Int32int0M.AssertModel(models[4],_testData[18], false);
                        Int32int0M.AssertModel(models[5],_testData[19], false);
                        Int32int0M.AssertModel(models[6],_testData[20], false);
                        Int32int0M.AssertModel(models[7],_testData[21], false);
                        Int32int0M.AssertModel(models[8],_testData[22], false);
                        Int32int0M.AssertModel(models[9],_testData[23], false);
                        Int32int0M.AssertModel(models[10],_testData[24], false);
                        Int32int0M.AssertModel(models[11],_testData[25], false);
                        Int32int0M.AssertModel(models[12],_testData[26], false);
                        Int32int0M.AssertModel(models[13],_testData[27], false);
                        Int32int0M.AssertModel(models[14],_testData[28], false);
                        Int32int0M.AssertModel(models[15],_testData[29], false);
                        Int32int0M.AssertModel(models[16],_testData[30], false);
                        Int32int0M.AssertModel(models[17],_testData[31], false);
                        Int32int0M.AssertModel(models[18],_testData[32], false);
                        Int32int0M.AssertModel(models[19],_testData[33], false);
                        Int32int0M.AssertModel(models[20],_testData[34], false);
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 127;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 155;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt32SingleTypeint)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        Int32int0M.AssertModel(models[0],_testData[25], false);
                        Int32int0M.AssertModel(models[1],_testData[26], false);
                        Int32int0M.AssertModel(models[2],_testData[27], false);
                        Int32int0M.AssertModel(models[3],_testData[28], false);
                        Int32int0M.AssertModel(models[4],_testData[29], false);
                        Int32int0M.AssertModel(models[5],_testData[30], false);
                        Int32int0M.AssertModel(models[6],_testData[31], false);
                        Int32int0M.AssertModel(models[7],_testData[32], false);
                        Int32int0M.AssertModel(models[8],_testData[33], false);
                        Int32int0M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        Int32int0M.AssertModel(models[0],_testData[32], false);
                        Int32int0M.AssertModel(models[1],_testData[33], false);
                        Int32int0M.AssertModel(models[2],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32int0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                await ((IInt32SingleTypeint)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 56, query1, 42, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
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
                        FlatInt32int0M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatInt32int0M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatInt32int0M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatInt32int0M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatInt32int0M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatInt32int0M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatInt32int0M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatInt32int0M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatInt32int0M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatInt32int0M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatInt32int0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatInt32int0M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatInt32int0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatInt32int0M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatInt32int0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatInt32int0M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatInt32int0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatInt32int0M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatInt32int0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatInt32int0M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatInt32int0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatInt32int0M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatInt32int0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatInt32int0M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatInt32int0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatInt32int0M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatInt32int0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatInt32int0M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatInt32int0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatInt32int0M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatInt32int0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatInt32int0M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatInt32int0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatInt32int0M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatInt32int0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatInt32int0M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatInt32int0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatInt32int0M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatInt32int0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatInt32int0M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatInt32int0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatInt32int0M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatInt32int0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatInt32int0M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatInt32int0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatInt32int0M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatInt32int0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatInt32int0M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatInt32int0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatInt32int0M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatInt32int0M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatInt32int0M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatInt32int0M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatInt32int0M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatInt32int0M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatInt32int0M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatInt32int0M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatInt32int0M.AssertModel(secondItems2[27],_testData[34], false);
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
                await ((IInt32SingleTypeint)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 110, query1, 13, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
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
                        FlatInt32int0M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatInt32int0M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatInt32int0M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatInt32int0M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatInt32int0M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatInt32int0M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatInt32int0M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatInt32int0M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatInt32int0M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatInt32int0M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                        FlatInt32int0M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatInt32int0M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatInt32int0M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatInt32int0M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatInt32int0M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatInt32int0M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatInt32int0M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatInt32int0M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatInt32int0M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatInt32int0M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatInt32int0M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatInt32int0M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatInt32int0M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatInt32int0M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatInt32int0M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatInt32int0M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatInt32int0M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatInt32int0M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatInt32int0M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatInt32int0M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatInt32int0M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatInt32int0M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatInt32int0M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatInt32int0M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatInt32int0M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatInt32int0M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatInt32int0M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatInt32int0M.AssertModel(secondItems1[31],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt32int0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                 ((IInt32SingleTypeint)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 122, query1, 57, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
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
                        FlatInt32int0M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatInt32int0M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatInt32int0M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatInt32int0M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatInt32int0M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatInt32int0M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatInt32int0M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatInt32int0M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatInt32int0M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatInt32int0M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatInt32int0M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatInt32int0M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatInt32int0M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatInt32int0M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatInt32int0M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatInt32int0M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatInt32int0M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatInt32int0M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatInt32int0M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatInt32int0M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatInt32int0M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatInt32int0M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatInt32int0M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatInt32int0M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatInt32int0M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatInt32int0M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatInt32int0M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatInt32int0M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatInt32int0M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatInt32int0M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatInt32int0M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatInt32int0M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatInt32int0M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatInt32int0M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatInt32int0M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatInt32int0M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatInt32int0M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatInt32int0M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatInt32int0M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatInt32int0M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatInt32int0M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatInt32int0M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatInt32int0M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatInt32int0M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatInt32int0M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatInt32int0M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatInt32int0M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatInt32int0M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatInt32int0M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatInt32int0M.AssertModel(secondItems2[23],_testData[34], false);
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
                 ((IInt32SingleTypeint)this).DbConnectionMMDynQuerySelectModelBatch(connection, 44, query1, 63, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatInt32int0M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatInt32int0M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatInt32int0M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatInt32int0M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatInt32int0M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatInt32int0M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatInt32int0M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatInt32int0M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatInt32int0M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatInt32int0M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatInt32int0M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatInt32int0M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatInt32int0M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatInt32int0M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatInt32int0M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatInt32int0M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatInt32int0M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatInt32int0M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatInt32int0M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatInt32int0M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatInt32int0M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatInt32int0M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatInt32int0M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatInt32int0M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatInt32int0M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatInt32int0M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatInt32int0M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatInt32int0M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatInt32int0M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatInt32int0M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatInt32int0M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatInt32int0M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatInt32int0M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatInt32int0M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatInt32int0M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatInt32int0M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatInt32int0M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatInt32int0M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatInt32int0M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatInt32int0M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatInt32int0M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatInt32int0M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatInt32int0M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatInt32int0M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatInt32int0M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatInt32int0M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatInt32int0M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatInt32int0M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatInt32int0M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatInt32int0M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatInt32int0M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatInt32int0M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatInt32int0M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatInt32int0M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatInt32int0M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatInt32int0M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatInt32int0M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatInt32int0M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatInt32int0M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatInt32int0M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatInt32int0M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatInt32int0M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatInt32int0M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatInt32int0M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatInt32int0M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatInt32int0M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatInt32int0M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatInt32int0M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatInt32int0M.AssertModel(secondItems1[22],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt32SingleTypeint)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 116, query1, 110, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatInt32int0M.AssertModel(models[0],_testData[23], false);
                        FlatInt32int0M.AssertModel(models[1],_testData[24], false);
                        FlatInt32int0M.AssertModel(models[2],_testData[25], false);
                        FlatInt32int0M.AssertModel(models[3],_testData[26], false);
                        FlatInt32int0M.AssertModel(models[4],_testData[27], false);
                        FlatInt32int0M.AssertModel(models[5],_testData[28], false);
                        FlatInt32int0M.AssertModel(models[6],_testData[29], false);
                        FlatInt32int0M.AssertModel(models[7],_testData[30], false);
                        FlatInt32int0M.AssertModel(models[8],_testData[31], false);
                        FlatInt32int0M.AssertModel(models[9],_testData[32], false);
                        FlatInt32int0M.AssertModel(models[10],_testData[33], false);
                        FlatInt32int0M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatInt32int0M.AssertModel(models[0],_testData[22], false);
                        FlatInt32int0M.AssertModel(models[1],_testData[23], false);
                        FlatInt32int0M.AssertModel(models[2],_testData[24], false);
                        FlatInt32int0M.AssertModel(models[3],_testData[25], false);
                        FlatInt32int0M.AssertModel(models[4],_testData[26], false);
                        FlatInt32int0M.AssertModel(models[5],_testData[27], false);
                        FlatInt32int0M.AssertModel(models[6],_testData[28], false);
                        FlatInt32int0M.AssertModel(models[7],_testData[29], false);
                        FlatInt32int0M.AssertModel(models[8],_testData[30], false);
                        FlatInt32int0M.AssertModel(models[9],_testData[31], false);
                        FlatInt32int0M.AssertModel(models[10],_testData[32], false);
                        FlatInt32int0M.AssertModel(models[11],_testData[33], false);
                        FlatInt32int0M.AssertModel(models[12],_testData[34], false);
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
                await ((IInt32SingleTypeint)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 44, query1, 81, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatInt32int0M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatInt32int0M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatInt32int0M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatInt32int0M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatInt32int0M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatInt32int0M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatInt32int0M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatInt32int0M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatInt32int0M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatInt32int0M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatInt32int0M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatInt32int0M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatInt32int0M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatInt32int0M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatInt32int0M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatInt32int0M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatInt32int0M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatInt32int0M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatInt32int0M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatInt32int0M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatInt32int0M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatInt32int0M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatInt32int0M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatInt32int0M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatInt32int0M.AssertModel(firstItems1[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatInt32int0M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatInt32int0M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatInt32int0M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatInt32int0M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatInt32int0M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatInt32int0M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatInt32int0M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatInt32int0M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatInt32int0M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatInt32int0M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatInt32int0M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatInt32int0M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatInt32int0M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatInt32int0M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatInt32int0M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatInt32int0M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatInt32int0M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatInt32int0M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatInt32int0M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatInt32int0M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatInt32int0M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatInt32int0M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatInt32int0M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatInt32int0M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatInt32int0M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatInt32int0M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatInt32int0M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatInt32int0M.AssertModel(secondItems2[17],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt32SingleTypeint)this).DbConnectionSTDynQuerySelectModelBatch(connection, 131, query1, 57, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatInt32int0M.AssertModel(models[0],_testData[26], false);
                        FlatInt32int0M.AssertModel(models[1],_testData[27], false);
                        FlatInt32int0M.AssertModel(models[2],_testData[28], false);
                        FlatInt32int0M.AssertModel(models[3],_testData[29], false);
                        FlatInt32int0M.AssertModel(models[4],_testData[30], false);
                        FlatInt32int0M.AssertModel(models[5],_testData[31], false);
                        FlatInt32int0M.AssertModel(models[6],_testData[32], false);
                        FlatInt32int0M.AssertModel(models[7],_testData[33], false);
                        FlatInt32int0M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

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
                        FlatInt32int0M.AssertModel(models[19],_testData[30], false);
                        FlatInt32int0M.AssertModel(models[20],_testData[31], false);
                        FlatInt32int0M.AssertModel(models[21],_testData[32], false);
                        FlatInt32int0M.AssertModel(models[22],_testData[33], false);
                        FlatInt32int0M.AssertModel(models[23],_testData[34], false);
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
                 ((IInt32SingleTypeint)this).DbConnectionDynQuerySelectModelBatch(connection, 80, query1, 81, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatInt32int0M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatInt32int0M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatInt32int0M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatInt32int0M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatInt32int0M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatInt32int0M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatInt32int0M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatInt32int0M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatInt32int0M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatInt32int0M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatInt32int0M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatInt32int0M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatInt32int0M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatInt32int0M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatInt32int0M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatInt32int0M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatInt32int0M.AssertModel(firstItems1[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatInt32int0M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatInt32int0M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatInt32int0M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatInt32int0M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatInt32int0M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatInt32int0M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatInt32int0M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatInt32int0M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatInt32int0M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatInt32int0M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatInt32int0M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatInt32int0M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatInt32int0M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatInt32int0M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatInt32int0M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatInt32int0M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatInt32int0M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatInt32int0M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatInt32int0M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatInt32int0M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatInt32int0M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatInt32int0M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatInt32int0M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatInt32int0M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatInt32int0M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatInt32int0M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatInt32int0M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatInt32int0M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatInt32int0M.AssertModel(secondItems2[17],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in await ((IInt32SingleTypeint)this).DbConnectionSTSelectModelBatchAsync(connection, 107, 148))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        Int32int0M.AssertModel(models[0],_testData[21], false);
                        Int32int0M.AssertModel(models[1],_testData[22], false);
                        Int32int0M.AssertModel(models[2],_testData[23], false);
                        Int32int0M.AssertModel(models[3],_testData[24], false);
                        Int32int0M.AssertModel(models[4],_testData[25], false);
                        Int32int0M.AssertModel(models[5],_testData[26], false);
                        Int32int0M.AssertModel(models[6],_testData[27], false);
                        Int32int0M.AssertModel(models[7],_testData[28], false);
                        Int32int0M.AssertModel(models[8],_testData[29], false);
                        Int32int0M.AssertModel(models[9],_testData[30], false);
                        Int32int0M.AssertModel(models[10],_testData[31], false);
                        Int32int0M.AssertModel(models[11],_testData[32], false);
                        Int32int0M.AssertModel(models[12],_testData[33], false);
                        Int32int0M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        Int32int0M.AssertModel(models[0],_testData[30], false);
                        Int32int0M.AssertModel(models[1],_testData[31], false);
                        Int32int0M.AssertModel(models[2],_testData[32], false);
                        Int32int0M.AssertModel(models[3],_testData[33], false);
                        Int32int0M.AssertModel(models[4],_testData[34], false);
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
                foreach(var batchResult in  ((IInt32SingleTypeint)this).DbConnectionSTSelectModelBatch(connection, 116, 51))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        Int32int0M.AssertModel(models[0],_testData[23], false);
                        Int32int0M.AssertModel(models[1],_testData[24], false);
                        Int32int0M.AssertModel(models[2],_testData[25], false);
                        Int32int0M.AssertModel(models[3],_testData[26], false);
                        Int32int0M.AssertModel(models[4],_testData[27], false);
                        Int32int0M.AssertModel(models[5],_testData[28], false);
                        Int32int0M.AssertModel(models[6],_testData[29], false);
                        Int32int0M.AssertModel(models[7],_testData[30], false);
                        Int32int0M.AssertModel(models[8],_testData[31], false);
                        Int32int0M.AssertModel(models[9],_testData[32], false);
                        Int32int0M.AssertModel(models[10],_testData[33], false);
                        Int32int0M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        Int32int0M.AssertModel(models[0],_testData[9], false);
                        Int32int0M.AssertModel(models[1],_testData[10], false);
                        Int32int0M.AssertModel(models[2],_testData[11], false);
                        Int32int0M.AssertModel(models[3],_testData[12], false);
                        Int32int0M.AssertModel(models[4],_testData[13], false);
                        Int32int0M.AssertModel(models[5],_testData[14], false);
                        Int32int0M.AssertModel(models[6],_testData[15], false);
                        Int32int0M.AssertModel(models[7],_testData[16], false);
                        Int32int0M.AssertModel(models[8],_testData[17], false);
                        Int32int0M.AssertModel(models[9],_testData[18], false);
                        Int32int0M.AssertModel(models[10],_testData[19], false);
                        Int32int0M.AssertModel(models[11],_testData[20], false);
                        Int32int0M.AssertModel(models[12],_testData[21], false);
                        Int32int0M.AssertModel(models[13],_testData[22], false);
                        Int32int0M.AssertModel(models[14],_testData[23], false);
                        Int32int0M.AssertModel(models[15],_testData[24], false);
                        Int32int0M.AssertModel(models[16],_testData[25], false);
                        Int32int0M.AssertModel(models[17],_testData[26], false);
                        Int32int0M.AssertModel(models[18],_testData[27], false);
                        Int32int0M.AssertModel(models[19],_testData[28], false);
                        Int32int0M.AssertModel(models[20],_testData[29], false);
                        Int32int0M.AssertModel(models[21],_testData[30], false);
                        Int32int0M.AssertModel(models[22],_testData[31], false);
                        Int32int0M.AssertModel(models[23],_testData[32], false);
                        Int32int0M.AssertModel(models[24],_testData[33], false);
                        Int32int0M.AssertModel(models[25],_testData[34], false);
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
                ((IInt32SingleTypeint)this).SetDbConnectionSelectModelParametrs(cmd, 99);
                var models = await ((IInt32SingleTypeint)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(15));
Int32int0M.AssertModel(models[0],_testData[20], false);Int32int0M.AssertModel(models[1],_testData[21], false);Int32int0M.AssertModel(models[2],_testData[22], false);Int32int0M.AssertModel(models[3],_testData[23], false);Int32int0M.AssertModel(models[4],_testData[24], false);Int32int0M.AssertModel(models[5],_testData[25], false);Int32int0M.AssertModel(models[6],_testData[26], false);Int32int0M.AssertModel(models[7],_testData[27], false);Int32int0M.AssertModel(models[8],_testData[28], false);Int32int0M.AssertModel(models[9],_testData[29], false);Int32int0M.AssertModel(models[10],_testData[30], false);Int32int0M.AssertModel(models[11],_testData[31], false);Int32int0M.AssertModel(models[12],_testData[32], false);Int32int0M.AssertModel(models[13],_testData[33], false);Int32int0M.AssertModel(models[14],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt32SingleTypeint)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt32SingleTypeint)this).SetDbConnectionSelectModelParametrs(cmd, 110);
                var models =  ((IInt32SingleTypeint)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(13));
Int32int0M.AssertModel(models[0],_testData[22], false);Int32int0M.AssertModel(models[1],_testData[23], false);Int32int0M.AssertModel(models[2],_testData[24], false);Int32int0M.AssertModel(models[3],_testData[25], false);Int32int0M.AssertModel(models[4],_testData[26], false);Int32int0M.AssertModel(models[5],_testData[27], false);Int32int0M.AssertModel(models[6],_testData[28], false);Int32int0M.AssertModel(models[7],_testData[29], false);Int32int0M.AssertModel(models[8],_testData[30], false);Int32int0M.AssertModel(models[9],_testData[31], false);Int32int0M.AssertModel(models[10],_testData[32], false);Int32int0M.AssertModel(models[11],_testData[33], false);Int32int0M.AssertModel(models[12],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((3)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((716271588)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((583685369)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((2116191564)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((1097358167)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((861775482)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((69498423)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((892477991)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((223756786)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((437175393)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((2025659838)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((11)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((571132301)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((392770916)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1981863262)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((718574933)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1796528473)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1484339592)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((26629291)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((951073114)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1783275553)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1635046932)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((840209881)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((428744029)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((154214244)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1176342837)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1521979201)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((995980449)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1622274827)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((75)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1362477146)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1588355356)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((294970434)));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1293429623)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1087699101)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((2019223912)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((952062337)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1764587516)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((968250647)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1843886392)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((344099153)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((770469166)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1704665951)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((276024868)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((764238122)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((96)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1860943510)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((788338774)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((992245704)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1347901472)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1261267883)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((827624951)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1055736757)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((116)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1818242915)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1116258508)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((464250652)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1073458391)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((2005453768)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((432257840)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((2085059849)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1051787896)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((74)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1381202618)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((431885456)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((279910159)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1518068248)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((167197284)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((78)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((2003242643)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1756670113)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((3034605)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((400841652)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1175387270)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((79)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1802942784)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((1881835808)));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1142685976)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1764291327)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((86)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1288944826)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((1746989487)));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((163)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((2117885877)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((170)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((934267235)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((88)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1655735660)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((171)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1175770669)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1785444604)));

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
                Assert.That((System.Int32)model[0], Is.EqualTo((3)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((716271588)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((583685369)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((2116191564)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((1097358167)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((861775482)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((69498423)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((892477991)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((223756786)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((437175393)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((2025659838)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((11)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((571132301)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((392770916)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1981863262)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((718574933)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1796528473)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1484339592)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((26629291)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((951073114)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1783275553)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1635046932)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((840209881)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((428744029)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((154214244)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1176342837)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1521979201)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((995980449)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1622274827)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((75)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1362477146)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1588355356)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((294970434)));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1293429623)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1087699101)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((2019223912)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((952062337)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1764587516)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((968250647)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1843886392)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((344099153)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((770469166)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1704665951)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((276024868)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((764238122)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((96)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1860943510)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((788338774)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((992245704)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1347901472)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1261267883)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((827624951)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1055736757)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((116)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1818242915)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1116258508)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((464250652)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1073458391)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((2005453768)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((432257840)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((2085059849)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1051787896)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((74)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1381202618)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((431885456)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((279910159)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1518068248)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((167197284)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((78)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((2003242643)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1756670113)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((3034605)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((400841652)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1175387270)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((79)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1802942784)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((1881835808)));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1142685976)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1764291327)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((86)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1288944826)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((1746989487)));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((163)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((2117885877)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((170)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((934267235)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((88)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1655735660)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((171)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1175770669)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1785444604)));

            }
        }

#endregion

    }
}

