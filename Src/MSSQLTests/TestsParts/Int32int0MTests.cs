

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
    Id = 9,
    Value = 467654204,
    ModelInner = null,
    NullableValue = null,
},
            new Int32int0M
{
    Id = 11,
    Value = 1739035972,
    ModelInner = new Int32int0MI
{
    Id = 8,
    Value = 1461607093,
    NullableValue = null,
},
    NullableValue = 878805142,
},
            new Int32int0M
{
    Id = 15,
    Value = 1550800100,
    ModelInner = null,
    NullableValue = null,
},
            new Int32int0M
{
    Id = 22,
    Value = 152586448,
    ModelInner = new Int32int0MI
{
    Id = 14,
    Value = 886814724,
    NullableValue = 648729718,
},
    NullableValue = null,
},
            new Int32int0M
{
    Id = 24,
    Value = 873382320,
    ModelInner = null,
    NullableValue = null,
},
            new Int32int0M
{
    Id = 26,
    Value = 1173810368,
    ModelInner = new Int32int0MI
{
    Id = 18,
    Value = 367576006,
    NullableValue = 666120377,
},
    NullableValue = 1495108020,
},
            new Int32int0M
{
    Id = 34,
    Value = 1072312774,
    ModelInner = null,
    NullableValue = null,
},
            new Int32int0M
{
    Id = 41,
    Value = 687484546,
    ModelInner = new Int32int0MI
{
    Id = 25,
    Value = 241568507,
    NullableValue = 1565904883,
},
    NullableValue = 801978647,
},
            new Int32int0M
{
    Id = 47,
    Value = 370952263,
    ModelInner = null,
    NullableValue = null,
},
            new Int32int0M
{
    Id = 49,
    Value = 1733549513,
    ModelInner = new Int32int0MI
{
    Id = 27,
    Value = 561658686,
    NullableValue = 1136383614,
},
    NullableValue = 91659346,
},
            new Int32int0M
{
    Id = 51,
    Value = 17892843,
    ModelInner = null,
    NullableValue = null,
},
            new Int32int0M
{
    Id = 52,
    Value = 537425491,
    ModelInner = new Int32int0MI
{
    Id = 31,
    Value = 1777715855,
    NullableValue = 147754468,
},
    NullableValue = 1092838160,
},
            new Int32int0M
{
    Id = 59,
    Value = 1711261854,
    ModelInner = null,
    NullableValue = null,
},
            new Int32int0M
{
    Id = 62,
    Value = 1614484281,
    ModelInner = new Int32int0MI
{
    Id = 39,
    Value = 279328503,
    NullableValue = 1750251158,
},
    NullableValue = null,
},
            new Int32int0M
{
    Id = 68,
    Value = 1978615293,
    ModelInner = null,
    NullableValue = 596437216,
},
            new Int32int0M
{
    Id = 72,
    Value = 944971132,
    ModelInner = new Int32int0MI
{
    Id = 47,
    Value = 246113071,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32int0M
{
    Id = 74,
    Value = 1265424205,
    ModelInner = null,
    NullableValue = 1379701195,
},
            new Int32int0M
{
    Id = 81,
    Value = 862242178,
    ModelInner = new Int32int0MI
{
    Id = 51,
    Value = 453458817,
    NullableValue = 738713936,
},
    NullableValue = 461714525,
},
            new Int32int0M
{
    Id = 86,
    Value = 1223962085,
    ModelInner = null,
    NullableValue = null,
},
            new Int32int0M
{
    Id = 88,
    Value = 1627940797,
    ModelInner = new Int32int0MI
{
    Id = 58,
    Value = 152786678,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32int0M
{
    Id = 96,
    Value = 541260433,
    ModelInner = null,
    NullableValue = null,
},
            new Int32int0M
{
    Id = 102,
    Value = 814311867,
    ModelInner = new Int32int0MI
{
    Id = 67,
    Value = 727988798,
    NullableValue = null,
},
    NullableValue = 1923562666,
},
            new Int32int0M
{
    Id = 109,
    Value = 790583663,
    ModelInner = null,
    NullableValue = null,
},
            new Int32int0M
{
    Id = 117,
    Value = 25998998,
    ModelInner = new Int32int0MI
{
    Id = 68,
    Value = 1173027477,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32int0M
{
    Id = 118,
    Value = 644090635,
    ModelInner = null,
    NullableValue = null,
},
            new Int32int0M
{
    Id = 119,
    Value = 258177962,
    ModelInner = new Int32int0MI
{
    Id = 71,
    Value = 549772745,
    NullableValue = 1271183795,
},
    NullableValue = null,
},
            new Int32int0M
{
    Id = 127,
    Value = 293897505,
    ModelInner = null,
    NullableValue = 1898468707,
},
            new Int32int0M
{
    Id = 132,
    Value = 1113648918,
    ModelInner = new Int32int0MI
{
    Id = 78,
    Value = 2023758258,
    NullableValue = 1299866922,
},
    NullableValue = null,
},
            new Int32int0M
{
    Id = 137,
    Value = 480218628,
    ModelInner = null,
    NullableValue = 1802299722,
},
            new Int32int0M
{
    Id = 145,
    Value = 741980604,
    ModelInner = new Int32int0MI
{
    Id = 87,
    Value = 148701006,
    NullableValue = null,
},
    NullableValue = null,
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 72;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 109;
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
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatInt32int0M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatInt32int0M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatInt32int0M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatInt32int0M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatInt32int0M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatInt32int0M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatInt32int0M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatInt32int0M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatInt32int0M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatInt32int0M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatInt32int0M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatInt32int0M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatInt32int0M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatInt32int0M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatInt32int0M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatInt32int0M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatInt32int0M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatInt32int0M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatInt32int0M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatInt32int0M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatInt32int0M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatInt32int0M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatInt32int0M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatInt32int0M.AssertModel(firstItems2[13],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatInt32int0M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatInt32int0M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatInt32int0M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatInt32int0M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatInt32int0M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatInt32int0M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatInt32int0M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatInt32int0M.AssertModel(secondItems2[6],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 132;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 26;
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
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatInt32int0M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatInt32int0M.AssertModel(firstItems2[1],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatInt32int0M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatInt32int0M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatInt32int0M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatInt32int0M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatInt32int0M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatInt32int0M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatInt32int0M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatInt32int0M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatInt32int0M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatInt32int0M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatInt32int0M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatInt32int0M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatInt32int0M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatInt32int0M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatInt32int0M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatInt32int0M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatInt32int0M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatInt32int0M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatInt32int0M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatInt32int0M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatInt32int0M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems1[23],_testData[29], false);
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 132;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 9;
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
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatInt32int0M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatInt32int0M.AssertModel(firstItems2[1],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatInt32int0M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatInt32int0M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatInt32int0M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatInt32int0M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatInt32int0M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatInt32int0M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatInt32int0M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatInt32int0M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatInt32int0M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatInt32int0M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatInt32int0M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatInt32int0M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatInt32int0M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatInt32int0M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatInt32int0M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatInt32int0M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatInt32int0M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatInt32int0M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatInt32int0M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatInt32int0M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatInt32int0M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatInt32int0M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatInt32int0M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatInt32int0M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatInt32int0M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatInt32int0M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatInt32int0M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatInt32int0M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatInt32int0M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatInt32int0M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatInt32int0M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatInt32int0M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatInt32int0M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatInt32int0M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatInt32int0M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatInt32int0M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatInt32int0M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatInt32int0M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatInt32int0M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatInt32int0M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatInt32int0M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatInt32int0M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatInt32int0M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatInt32int0M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatInt32int0M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatInt32int0M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatInt32int0M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatInt32int0M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatInt32int0M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatInt32int0M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatInt32int0M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatInt32int0M.AssertModel(secondItems2[28],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 117;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 68;
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 74;
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
                        Assert.That(models, Has.Count.EqualTo(13));

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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatInt32int0M.AssertModel(models[0],_testData[18], false);
                        FlatInt32int0M.AssertModel(models[1],_testData[19], false);
                        FlatInt32int0M.AssertModel(models[2],_testData[20], false);
                        FlatInt32int0M.AssertModel(models[3],_testData[21], false);
                        FlatInt32int0M.AssertModel(models[4],_testData[22], false);
                        FlatInt32int0M.AssertModel(models[5],_testData[23], false);
                        FlatInt32int0M.AssertModel(models[6],_testData[24], false);
                        FlatInt32int0M.AssertModel(models[7],_testData[25], false);
                        FlatInt32int0M.AssertModel(models[8],_testData[26], false);
                        FlatInt32int0M.AssertModel(models[9],_testData[27], false);
                        FlatInt32int0M.AssertModel(models[10],_testData[28], false);
                        FlatInt32int0M.AssertModel(models[11],_testData[29], false);
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
                parametr1.Value = 88;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 119;
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
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                        FlatInt32int0M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatInt32int0M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatInt32int0M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatInt32int0M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatInt32int0M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatInt32int0M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatInt32int0M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatInt32int0M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems1[9],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatInt32int0M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatInt32int0M.AssertModel(secondItems2[3],_testData[29], false);
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 81;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 132;
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
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatInt32int0M.AssertModel(models[0],_testData[18], false);
                        FlatInt32int0M.AssertModel(models[1],_testData[19], false);
                        FlatInt32int0M.AssertModel(models[2],_testData[20], false);
                        FlatInt32int0M.AssertModel(models[3],_testData[21], false);
                        FlatInt32int0M.AssertModel(models[4],_testData[22], false);
                        FlatInt32int0M.AssertModel(models[5],_testData[23], false);
                        FlatInt32int0M.AssertModel(models[6],_testData[24], false);
                        FlatInt32int0M.AssertModel(models[7],_testData[25], false);
                        FlatInt32int0M.AssertModel(models[8],_testData[26], false);
                        FlatInt32int0M.AssertModel(models[9],_testData[27], false);
                        FlatInt32int0M.AssertModel(models[10],_testData[28], false);
                        FlatInt32int0M.AssertModel(models[11],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatInt32int0M.AssertModel(models[0],_testData[28], false);
                        FlatInt32int0M.AssertModel(models[1],_testData[29], false);
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
                parametr1.Value = 72;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 47;
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
                Assert.That(firstItems1, Has.Count.EqualTo(14));
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
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatInt32int0M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatInt32int0M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatInt32int0M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatInt32int0M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatInt32int0M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatInt32int0M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatInt32int0M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatInt32int0M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatInt32int0M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatInt32int0M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatInt32int0M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatInt32int0M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatInt32int0M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatInt32int0M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatInt32int0M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatInt32int0M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatInt32int0M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatInt32int0M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatInt32int0M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatInt32int0M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatInt32int0M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatInt32int0M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatInt32int0M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatInt32int0M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatInt32int0M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatInt32int0M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatInt32int0M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatInt32int0M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatInt32int0M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatInt32int0M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatInt32int0M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatInt32int0M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatInt32int0M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatInt32int0M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatInt32int0M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatInt32int0M.AssertModel(secondItems2[20],_testData[29], false);
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 15;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 52;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 59;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 34;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt32SingleTypeint)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
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
                        Assert.That(models, Has.Count.EqualTo(23));

                        Int32int0M.AssertModel(models[0],_testData[7], false);
                        Int32int0M.AssertModel(models[1],_testData[8], false);
                        Int32int0M.AssertModel(models[2],_testData[9], false);
                        Int32int0M.AssertModel(models[3],_testData[10], false);
                        Int32int0M.AssertModel(models[4],_testData[11], false);
                        Int32int0M.AssertModel(models[5],_testData[12], false);
                        Int32int0M.AssertModel(models[6],_testData[13], false);
                        Int32int0M.AssertModel(models[7],_testData[14], false);
                        Int32int0M.AssertModel(models[8],_testData[15], false);
                        Int32int0M.AssertModel(models[9],_testData[16], false);
                        Int32int0M.AssertModel(models[10],_testData[17], false);
                        Int32int0M.AssertModel(models[11],_testData[18], false);
                        Int32int0M.AssertModel(models[12],_testData[19], false);
                        Int32int0M.AssertModel(models[13],_testData[20], false);
                        Int32int0M.AssertModel(models[14],_testData[21], false);
                        Int32int0M.AssertModel(models[15],_testData[22], false);
                        Int32int0M.AssertModel(models[16],_testData[23], false);
                        Int32int0M.AssertModel(models[17],_testData[24], false);
                        Int32int0M.AssertModel(models[18],_testData[25], false);
                        Int32int0M.AssertModel(models[19],_testData[26], false);
                        Int32int0M.AssertModel(models[20],_testData[27], false);
                        Int32int0M.AssertModel(models[21],_testData[28], false);
                        Int32int0M.AssertModel(models[22],_testData[29], false);
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
                await ((IInt32SingleTypeint)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 22, query1, 24, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatInt32int0M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatInt32int0M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatInt32int0M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatInt32int0M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatInt32int0M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatInt32int0M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatInt32int0M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatInt32int0M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatInt32int0M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatInt32int0M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatInt32int0M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatInt32int0M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatInt32int0M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatInt32int0M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatInt32int0M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatInt32int0M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatInt32int0M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatInt32int0M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatInt32int0M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatInt32int0M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatInt32int0M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatInt32int0M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatInt32int0M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatInt32int0M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatInt32int0M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatInt32int0M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatInt32int0M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatInt32int0M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatInt32int0M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatInt32int0M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatInt32int0M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatInt32int0M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatInt32int0M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatInt32int0M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatInt32int0M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatInt32int0M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatInt32int0M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatInt32int0M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatInt32int0M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatInt32int0M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatInt32int0M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatInt32int0M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatInt32int0M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatInt32int0M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatInt32int0M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatInt32int0M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatInt32int0M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatInt32int0M.AssertModel(firstItems2[25],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatInt32int0M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatInt32int0M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatInt32int0M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatInt32int0M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatInt32int0M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatInt32int0M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatInt32int0M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatInt32int0M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatInt32int0M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatInt32int0M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatInt32int0M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatInt32int0M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatInt32int0M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatInt32int0M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatInt32int0M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatInt32int0M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatInt32int0M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatInt32int0M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatInt32int0M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatInt32int0M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatInt32int0M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatInt32int0M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatInt32int0M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatInt32int0M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatInt32int0M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatInt32int0M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatInt32int0M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatInt32int0M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatInt32int0M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatInt32int0M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatInt32int0M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatInt32int0M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatInt32int0M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatInt32int0M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatInt32int0M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatInt32int0M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatInt32int0M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatInt32int0M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatInt32int0M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatInt32int0M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatInt32int0M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatInt32int0M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatInt32int0M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatInt32int0M.AssertModel(secondItems2[24],_testData[29], false);
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
                await ((IInt32SingleTypeint)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 72, query1, 117, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatInt32int0M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatInt32int0M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatInt32int0M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatInt32int0M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatInt32int0M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatInt32int0M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatInt32int0M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatInt32int0M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatInt32int0M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatInt32int0M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatInt32int0M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatInt32int0M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatInt32int0M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatInt32int0M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatInt32int0M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatInt32int0M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatInt32int0M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatInt32int0M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatInt32int0M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatInt32int0M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatInt32int0M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatInt32int0M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatInt32int0M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatInt32int0M.AssertModel(firstItems2[13],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatInt32int0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatInt32int0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatInt32int0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems1[5],_testData[29], false);
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
                 ((IInt32SingleTypeint)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 52, query1, 22, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatInt32int0M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatInt32int0M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatInt32int0M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatInt32int0M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatInt32int0M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatInt32int0M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatInt32int0M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatInt32int0M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatInt32int0M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatInt32int0M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatInt32int0M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatInt32int0M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatInt32int0M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatInt32int0M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatInt32int0M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatInt32int0M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatInt32int0M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatInt32int0M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatInt32int0M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatInt32int0M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatInt32int0M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatInt32int0M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatInt32int0M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatInt32int0M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatInt32int0M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatInt32int0M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatInt32int0M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatInt32int0M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatInt32int0M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatInt32int0M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatInt32int0M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatInt32int0M.AssertModel(firstItems2[17],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatInt32int0M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatInt32int0M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatInt32int0M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatInt32int0M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatInt32int0M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatInt32int0M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatInt32int0M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatInt32int0M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatInt32int0M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatInt32int0M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatInt32int0M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatInt32int0M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatInt32int0M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatInt32int0M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatInt32int0M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatInt32int0M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatInt32int0M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatInt32int0M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatInt32int0M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatInt32int0M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatInt32int0M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatInt32int0M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatInt32int0M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatInt32int0M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatInt32int0M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatInt32int0M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatInt32int0M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatInt32int0M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatInt32int0M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatInt32int0M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatInt32int0M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatInt32int0M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatInt32int0M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatInt32int0M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatInt32int0M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatInt32int0M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatInt32int0M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatInt32int0M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatInt32int0M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatInt32int0M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatInt32int0M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatInt32int0M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatInt32int0M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatInt32int0M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatInt32int0M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatInt32int0M.AssertModel(secondItems2[25],_testData[29], false);
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
                 ((IInt32SingleTypeint)this).DbConnectionMMDynQuerySelectModelBatch(connection, 47, query1, 127, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
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
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatInt32int0M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems1[2],_testData[29], false);
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
                foreach(var batchResult in await ((IInt32SingleTypeint)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 62, query1, 119, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatInt32int0M.AssertModel(models[0],_testData[14], false);
                        FlatInt32int0M.AssertModel(models[1],_testData[15], false);
                        FlatInt32int0M.AssertModel(models[2],_testData[16], false);
                        FlatInt32int0M.AssertModel(models[3],_testData[17], false);
                        FlatInt32int0M.AssertModel(models[4],_testData[18], false);
                        FlatInt32int0M.AssertModel(models[5],_testData[19], false);
                        FlatInt32int0M.AssertModel(models[6],_testData[20], false);
                        FlatInt32int0M.AssertModel(models[7],_testData[21], false);
                        FlatInt32int0M.AssertModel(models[8],_testData[22], false);
                        FlatInt32int0M.AssertModel(models[9],_testData[23], false);
                        FlatInt32int0M.AssertModel(models[10],_testData[24], false);
                        FlatInt32int0M.AssertModel(models[11],_testData[25], false);
                        FlatInt32int0M.AssertModel(models[12],_testData[26], false);
                        FlatInt32int0M.AssertModel(models[13],_testData[27], false);
                        FlatInt32int0M.AssertModel(models[14],_testData[28], false);
                        FlatInt32int0M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatInt32int0M.AssertModel(models[0],_testData[26], false);
                        FlatInt32int0M.AssertModel(models[1],_testData[27], false);
                        FlatInt32int0M.AssertModel(models[2],_testData[28], false);
                        FlatInt32int0M.AssertModel(models[3],_testData[29], false);
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
                await ((IInt32SingleTypeint)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 118, query1, 127, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatInt32int0M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatInt32int0M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatInt32int0M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems1[4],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatInt32int0M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatInt32int0M.AssertModel(secondItems2[2],_testData[29], false);
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
                foreach(var batchResult in  ((IInt32SingleTypeint)this).DbConnectionSTDynQuerySelectModelBatch(connection, 52, query1, 59, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatInt32int0M.AssertModel(models[0],_testData[12], false);
                        FlatInt32int0M.AssertModel(models[1],_testData[13], false);
                        FlatInt32int0M.AssertModel(models[2],_testData[14], false);
                        FlatInt32int0M.AssertModel(models[3],_testData[15], false);
                        FlatInt32int0M.AssertModel(models[4],_testData[16], false);
                        FlatInt32int0M.AssertModel(models[5],_testData[17], false);
                        FlatInt32int0M.AssertModel(models[6],_testData[18], false);
                        FlatInt32int0M.AssertModel(models[7],_testData[19], false);
                        FlatInt32int0M.AssertModel(models[8],_testData[20], false);
                        FlatInt32int0M.AssertModel(models[9],_testData[21], false);
                        FlatInt32int0M.AssertModel(models[10],_testData[22], false);
                        FlatInt32int0M.AssertModel(models[11],_testData[23], false);
                        FlatInt32int0M.AssertModel(models[12],_testData[24], false);
                        FlatInt32int0M.AssertModel(models[13],_testData[25], false);
                        FlatInt32int0M.AssertModel(models[14],_testData[26], false);
                        FlatInt32int0M.AssertModel(models[15],_testData[27], false);
                        FlatInt32int0M.AssertModel(models[16],_testData[28], false);
                        FlatInt32int0M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatInt32int0M.AssertModel(models[0],_testData[13], false);
                        FlatInt32int0M.AssertModel(models[1],_testData[14], false);
                        FlatInt32int0M.AssertModel(models[2],_testData[15], false);
                        FlatInt32int0M.AssertModel(models[3],_testData[16], false);
                        FlatInt32int0M.AssertModel(models[4],_testData[17], false);
                        FlatInt32int0M.AssertModel(models[5],_testData[18], false);
                        FlatInt32int0M.AssertModel(models[6],_testData[19], false);
                        FlatInt32int0M.AssertModel(models[7],_testData[20], false);
                        FlatInt32int0M.AssertModel(models[8],_testData[21], false);
                        FlatInt32int0M.AssertModel(models[9],_testData[22], false);
                        FlatInt32int0M.AssertModel(models[10],_testData[23], false);
                        FlatInt32int0M.AssertModel(models[11],_testData[24], false);
                        FlatInt32int0M.AssertModel(models[12],_testData[25], false);
                        FlatInt32int0M.AssertModel(models[13],_testData[26], false);
                        FlatInt32int0M.AssertModel(models[14],_testData[27], false);
                        FlatInt32int0M.AssertModel(models[15],_testData[28], false);
                        FlatInt32int0M.AssertModel(models[16],_testData[29], false);
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
                 ((IInt32SingleTypeint)this).DbConnectionDynQuerySelectModelBatch(connection, 86, query1, 15, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatInt32int0M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatInt32int0M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatInt32int0M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatInt32int0M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatInt32int0M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatInt32int0M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatInt32int0M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatInt32int0M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatInt32int0M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems1[10],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatInt32int0M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatInt32int0M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatInt32int0M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatInt32int0M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatInt32int0M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatInt32int0M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatInt32int0M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatInt32int0M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatInt32int0M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatInt32int0M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatInt32int0M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatInt32int0M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatInt32int0M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatInt32int0M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatInt32int0M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatInt32int0M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatInt32int0M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatInt32int0M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatInt32int0M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatInt32int0M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatInt32int0M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatInt32int0M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatInt32int0M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatInt32int0M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatInt32int0M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatInt32int0M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatInt32int0M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatInt32int0M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatInt32int0M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatInt32int0M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatInt32int0M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatInt32int0M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatInt32int0M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatInt32int0M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatInt32int0M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatInt32int0M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatInt32int0M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatInt32int0M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatInt32int0M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatInt32int0M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatInt32int0M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatInt32int0M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatInt32int0M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatInt32int0M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatInt32int0M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatInt32int0M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatInt32int0M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatInt32int0M.AssertModel(secondItems2[26],_testData[29], false);
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
                foreach(var batchResult in await ((IInt32SingleTypeint)this).DbConnectionSTSelectModelBatchAsync(connection, 117, 96))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        Int32int0M.AssertModel(models[0],_testData[24], false);
                        Int32int0M.AssertModel(models[1],_testData[25], false);
                        Int32int0M.AssertModel(models[2],_testData[26], false);
                        Int32int0M.AssertModel(models[3],_testData[27], false);
                        Int32int0M.AssertModel(models[4],_testData[28], false);
                        Int32int0M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        Int32int0M.AssertModel(models[0],_testData[21], false);
                        Int32int0M.AssertModel(models[1],_testData[22], false);
                        Int32int0M.AssertModel(models[2],_testData[23], false);
                        Int32int0M.AssertModel(models[3],_testData[24], false);
                        Int32int0M.AssertModel(models[4],_testData[25], false);
                        Int32int0M.AssertModel(models[5],_testData[26], false);
                        Int32int0M.AssertModel(models[6],_testData[27], false);
                        Int32int0M.AssertModel(models[7],_testData[28], false);
                        Int32int0M.AssertModel(models[8],_testData[29], false);
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
                foreach(var batchResult in  ((IInt32SingleTypeint)this).DbConnectionSTSelectModelBatch(connection, 132, 102))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        Int32int0M.AssertModel(models[0],_testData[28], false);
                        Int32int0M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        Int32int0M.AssertModel(models[0],_testData[22], false);
                        Int32int0M.AssertModel(models[1],_testData[23], false);
                        Int32int0M.AssertModel(models[2],_testData[24], false);
                        Int32int0M.AssertModel(models[3],_testData[25], false);
                        Int32int0M.AssertModel(models[4],_testData[26], false);
                        Int32int0M.AssertModel(models[5],_testData[27], false);
                        Int32int0M.AssertModel(models[6],_testData[28], false);
                        Int32int0M.AssertModel(models[7],_testData[29], false);
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
                ((IInt32SingleTypeint)this).SetDbConnectionSelectModelParametrs(cmd, 9);
                var models = await ((IInt32SingleTypeint)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(29));
Int32int0M.AssertModel(models[0],_testData[1], false);Int32int0M.AssertModel(models[1],_testData[2], false);Int32int0M.AssertModel(models[2],_testData[3], false);Int32int0M.AssertModel(models[3],_testData[4], false);Int32int0M.AssertModel(models[4],_testData[5], false);Int32int0M.AssertModel(models[5],_testData[6], false);Int32int0M.AssertModel(models[6],_testData[7], false);Int32int0M.AssertModel(models[7],_testData[8], false);Int32int0M.AssertModel(models[8],_testData[9], false);Int32int0M.AssertModel(models[9],_testData[10], false);Int32int0M.AssertModel(models[10],_testData[11], false);Int32int0M.AssertModel(models[11],_testData[12], false);Int32int0M.AssertModel(models[12],_testData[13], false);Int32int0M.AssertModel(models[13],_testData[14], false);Int32int0M.AssertModel(models[14],_testData[15], false);Int32int0M.AssertModel(models[15],_testData[16], false);Int32int0M.AssertModel(models[16],_testData[17], false);Int32int0M.AssertModel(models[17],_testData[18], false);Int32int0M.AssertModel(models[18],_testData[19], false);Int32int0M.AssertModel(models[19],_testData[20], false);Int32int0M.AssertModel(models[20],_testData[21], false);Int32int0M.AssertModel(models[21],_testData[22], false);Int32int0M.AssertModel(models[22],_testData[23], false);Int32int0M.AssertModel(models[23],_testData[24], false);Int32int0M.AssertModel(models[24],_testData[25], false);Int32int0M.AssertModel(models[25],_testData[26], false);Int32int0M.AssertModel(models[26],_testData[27], false);Int32int0M.AssertModel(models[27],_testData[28], false);Int32int0M.AssertModel(models[28],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt32SingleTypeint)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt32SingleTypeint)this).SetDbConnectionSelectModelParametrs(cmd, 88);
                var models =  ((IInt32SingleTypeint)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(10));
Int32int0M.AssertModel(models[0],_testData[20], false);Int32int0M.AssertModel(models[1],_testData[21], false);Int32int0M.AssertModel(models[2],_testData[22], false);Int32int0M.AssertModel(models[3],_testData[23], false);Int32int0M.AssertModel(models[4],_testData[24], false);Int32int0M.AssertModel(models[5],_testData[25], false);Int32int0M.AssertModel(models[6],_testData[26], false);Int32int0M.AssertModel(models[7],_testData[27], false);Int32int0M.AssertModel(models[8],_testData[28], false);Int32int0M.AssertModel(models[9],_testData[29], false);
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
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((467654204)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((11)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1739035972)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1461607093)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((878805142)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1550800100)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((152586448)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((886814724)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((648729718)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((873382320)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1173810368)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((367576006)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((666120377)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1495108020)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1072312774)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((687484546)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((241568507)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1565904883)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((801978647)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((370952263)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((49)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1733549513)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((561658686)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1136383614)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((91659346)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((17892843)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((537425491)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1777715855)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((147754468)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1092838160)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1711261854)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1614484281)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((279328503)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1750251158)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1978615293)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((596437216)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((944971132)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((246113071)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((74)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1265424205)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1379701195)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((862242178)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((453458817)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((738713936)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((461714525)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1223962085)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1627940797)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((152786678)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((96)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((541260433)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((814311867)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((67)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((727988798)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((1923562666)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((790583663)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((25998998)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((68)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1173027477)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((644090635)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((258177962)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((549772745)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1271183795)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((293897505)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1898468707)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1113648918)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((78)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((2023758258)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1299866922)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((480218628)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1802299722)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((145)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((741980604)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((87)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((148701006)));//InnerModel.Value

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
                var models =  ((IInt32SingleTypeint)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((467654204)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((11)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1739035972)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1461607093)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((878805142)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1550800100)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((152586448)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((886814724)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((648729718)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((873382320)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1173810368)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((367576006)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((666120377)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1495108020)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1072312774)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((687484546)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((241568507)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1565904883)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((801978647)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((370952263)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((49)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1733549513)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((561658686)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1136383614)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((91659346)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((17892843)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((537425491)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1777715855)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((147754468)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1092838160)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1711261854)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1614484281)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((279328503)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1750251158)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1978615293)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((596437216)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((944971132)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((246113071)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((74)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1265424205)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1379701195)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((862242178)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((453458817)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((738713936)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((461714525)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1223962085)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1627940797)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((152786678)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((96)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((541260433)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((814311867)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((67)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((727988798)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((1923562666)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((790583663)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((25998998)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((68)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1173027477)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((644090635)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((258177962)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((549772745)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1271183795)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((293897505)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1898468707)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1113648918)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((78)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((2023758258)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1299866922)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((480218628)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1802299722)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((145)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((741980604)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((87)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((148701006)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

#endregion

    }
}

