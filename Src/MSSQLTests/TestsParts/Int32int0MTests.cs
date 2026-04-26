

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
    Id = 4,
    Value = 1552288114,
    ModelInner = null,
    NullableValue = 1693150787,
},
            new Int32int0M
{
    Id = 7,
    Value = 1751177486,
    ModelInner = new Int32int0MI
{
    Id = 2,
    Value = 1955250173,
    NullableValue = null,
},
    NullableValue = 1797490035,
},
            new Int32int0M
{
    Id = 9,
    Value = 250536789,
    ModelInner = null,
    NullableValue = null,
},
            new Int32int0M
{
    Id = 16,
    Value = 541581376,
    ModelInner = new Int32int0MI
{
    Id = 8,
    Value = 1123836238,
    NullableValue = null,
},
    NullableValue = 1230509271,
},
            new Int32int0M
{
    Id = 22,
    Value = 771989806,
    ModelInner = null,
    NullableValue = 1818662976,
},
            new Int32int0M
{
    Id = 29,
    Value = 257124714,
    ModelInner = new Int32int0MI
{
    Id = 10,
    Value = 1229226695,
    NullableValue = 2141466752,
},
    NullableValue = null,
},
            new Int32int0M
{
    Id = 34,
    Value = 1652924321,
    ModelInner = null,
    NullableValue = null,
},
            new Int32int0M
{
    Id = 40,
    Value = 539903893,
    ModelInner = new Int32int0MI
{
    Id = 12,
    Value = 594846827,
    NullableValue = 1299587395,
},
    NullableValue = null,
},
            new Int32int0M
{
    Id = 43,
    Value = 1903311802,
    ModelInner = null,
    NullableValue = 2036255603,
},
            new Int32int0M
{
    Id = 46,
    Value = 2048459809,
    ModelInner = new Int32int0MI
{
    Id = 15,
    Value = 1174472074,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32int0M
{
    Id = 50,
    Value = 15322339,
    ModelInner = null,
    NullableValue = 171968221,
},
            new Int32int0M
{
    Id = 53,
    Value = 1814467887,
    ModelInner = new Int32int0MI
{
    Id = 17,
    Value = 1250236051,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32int0M
{
    Id = 55,
    Value = 540766199,
    ModelInner = null,
    NullableValue = 1230705110,
},
            new Int32int0M
{
    Id = 61,
    Value = 1349419214,
    ModelInner = new Int32int0MI
{
    Id = 18,
    Value = 756348508,
    NullableValue = 82821717,
},
    NullableValue = null,
},
            new Int32int0M
{
    Id = 67,
    Value = 1899209285,
    ModelInner = null,
    NullableValue = 2073794618,
},
            new Int32int0M
{
    Id = 76,
    Value = 429479077,
    ModelInner = new Int32int0MI
{
    Id = 26,
    Value = 1959858189,
    NullableValue = 2132633688,
},
    NullableValue = 500633297,
},
            new Int32int0M
{
    Id = 77,
    Value = 825665851,
    ModelInner = null,
    NullableValue = 503695054,
},
            new Int32int0M
{
    Id = 84,
    Value = 1037966837,
    ModelInner = new Int32int0MI
{
    Id = 32,
    Value = 733053129,
    NullableValue = 874184323,
},
    NullableValue = 1603573740,
},
            new Int32int0M
{
    Id = 93,
    Value = 2122707172,
    ModelInner = null,
    NullableValue = 2060898756,
},
            new Int32int0M
{
    Id = 102,
    Value = 2031723280,
    ModelInner = new Int32int0MI
{
    Id = 37,
    Value = 1129515384,
    NullableValue = 963848984,
},
    NullableValue = 1892577285,
},
            new Int32int0M
{
    Id = 110,
    Value = 1259047912,
    ModelInner = null,
    NullableValue = 1482052626,
},
            new Int32int0M
{
    Id = 112,
    Value = 2013209211,
    ModelInner = new Int32int0MI
{
    Id = 46,
    Value = 525090146,
    NullableValue = null,
},
    NullableValue = 150892362,
},
            new Int32int0M
{
    Id = 120,
    Value = 195906930,
    ModelInner = null,
    NullableValue = 1298377003,
},
            new Int32int0M
{
    Id = 129,
    Value = 116316023,
    ModelInner = new Int32int0MI
{
    Id = 51,
    Value = 656695283,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32int0M
{
    Id = 136,
    Value = 1771946562,
    ModelInner = null,
    NullableValue = null,
},
            new Int32int0M
{
    Id = 139,
    Value = 558471047,
    ModelInner = new Int32int0MI
{
    Id = 58,
    Value = 1184476596,
    NullableValue = 1708055080,
},
    NullableValue = null,
},
            new Int32int0M
{
    Id = 140,
    Value = 972170740,
    ModelInner = null,
    NullableValue = 164250285,
},
            new Int32int0M
{
    Id = 149,
    Value = 2092884616,
    ModelInner = new Int32int0MI
{
    Id = 63,
    Value = 1652447718,
    NullableValue = 1771535135,
},
    NullableValue = 1738615032,
},
            new Int32int0M
{
    Id = 158,
    Value = 2010826778,
    ModelInner = null,
    NullableValue = null,
},
            new Int32int0M
{
    Id = 167,
    Value = 1987002881,
    ModelInner = new Int32int0MI
{
    Id = 67,
    Value = 743767923,
    NullableValue = 1812447650,
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
                parametr1.Value = 149;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 55;
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
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatInt32int0M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatInt32int0M.AssertModel(firstItems2[1],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatInt32int0M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatInt32int0M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatInt32int0M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatInt32int0M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatInt32int0M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatInt32int0M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatInt32int0M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatInt32int0M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatInt32int0M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatInt32int0M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatInt32int0M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatInt32int0M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatInt32int0M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatInt32int0M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatInt32int0M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatInt32int0M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatInt32int0M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatInt32int0M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatInt32int0M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatInt32int0M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatInt32int0M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatInt32int0M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatInt32int0M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatInt32int0M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatInt32int0M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatInt32int0M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatInt32int0M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatInt32int0M.AssertModel(secondItems2[16],_testData[29], false);
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
                parametr1.Value = 129;
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
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatInt32int0M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatInt32int0M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatInt32int0M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatInt32int0M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatInt32int0M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatInt32int0M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatInt32int0M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatInt32int0M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatInt32int0M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatInt32int0M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems1[12],_testData[29], false);
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
                parametr1.Value = 129;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 46;
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
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatInt32int0M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatInt32int0M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatInt32int0M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatInt32int0M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatInt32int0M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatInt32int0M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatInt32int0M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatInt32int0M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatInt32int0M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatInt32int0M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatInt32int0M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatInt32int0M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatInt32int0M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatInt32int0M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatInt32int0M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatInt32int0M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatInt32int0M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatInt32int0M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatInt32int0M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatInt32int0M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatInt32int0M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatInt32int0M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatInt32int0M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatInt32int0M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatInt32int0M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatInt32int0M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatInt32int0M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatInt32int0M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatInt32int0M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatInt32int0M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatInt32int0M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatInt32int0M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatInt32int0M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatInt32int0M.AssertModel(secondItems2[19],_testData[29], false);
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
                parametr1.Value = 50;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 67;
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
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatInt32int0M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatInt32int0M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatInt32int0M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatInt32int0M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatInt32int0M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatInt32int0M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatInt32int0M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatInt32int0M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatInt32int0M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatInt32int0M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatInt32int0M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatInt32int0M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatInt32int0M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatInt32int0M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatInt32int0M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatInt32int0M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatInt32int0M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatInt32int0M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatInt32int0M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatInt32int0M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatInt32int0M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatInt32int0M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatInt32int0M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatInt32int0M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatInt32int0M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatInt32int0M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatInt32int0M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatInt32int0M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatInt32int0M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatInt32int0M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatInt32int0M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatInt32int0M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatInt32int0M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatInt32int0M.AssertModel(firstItems2[18],_testData[29], false);
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
                parametr1.Value = 120;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 110;
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
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatInt32int0M.AssertModel(models[0],_testData[23], false);
                        FlatInt32int0M.AssertModel(models[1],_testData[24], false);
                        FlatInt32int0M.AssertModel(models[2],_testData[25], false);
                        FlatInt32int0M.AssertModel(models[3],_testData[26], false);
                        FlatInt32int0M.AssertModel(models[4],_testData[27], false);
                        FlatInt32int0M.AssertModel(models[5],_testData[28], false);
                        FlatInt32int0M.AssertModel(models[6],_testData[29], false);
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
        public async Task DbConnectionDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 4;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 102;
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
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatInt32int0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatInt32int0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatInt32int0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatInt32int0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatInt32int0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatInt32int0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatInt32int0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatInt32int0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatInt32int0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatInt32int0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatInt32int0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatInt32int0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatInt32int0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatInt32int0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatInt32int0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatInt32int0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatInt32int0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatInt32int0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatInt32int0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatInt32int0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatInt32int0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatInt32int0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatInt32int0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatInt32int0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatInt32int0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatInt32int0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatInt32int0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems1[28],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatInt32int0M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatInt32int0M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatInt32int0M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatInt32int0M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatInt32int0M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatInt32int0M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatInt32int0M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatInt32int0M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatInt32int0M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatInt32int0M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatInt32int0M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatInt32int0M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatInt32int0M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatInt32int0M.AssertModel(secondItems2[9],_testData[29], false);
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
                parametr1.Value = 43;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 16;
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatInt32int0M.AssertModel(models[0],_testData[4], false);
                        FlatInt32int0M.AssertModel(models[1],_testData[5], false);
                        FlatInt32int0M.AssertModel(models[2],_testData[6], false);
                        FlatInt32int0M.AssertModel(models[3],_testData[7], false);
                        FlatInt32int0M.AssertModel(models[4],_testData[8], false);
                        FlatInt32int0M.AssertModel(models[5],_testData[9], false);
                        FlatInt32int0M.AssertModel(models[6],_testData[10], false);
                        FlatInt32int0M.AssertModel(models[7],_testData[11], false);
                        FlatInt32int0M.AssertModel(models[8],_testData[12], false);
                        FlatInt32int0M.AssertModel(models[9],_testData[13], false);
                        FlatInt32int0M.AssertModel(models[10],_testData[14], false);
                        FlatInt32int0M.AssertModel(models[11],_testData[15], false);
                        FlatInt32int0M.AssertModel(models[12],_testData[16], false);
                        FlatInt32int0M.AssertModel(models[13],_testData[17], false);
                        FlatInt32int0M.AssertModel(models[14],_testData[18], false);
                        FlatInt32int0M.AssertModel(models[15],_testData[19], false);
                        FlatInt32int0M.AssertModel(models[16],_testData[20], false);
                        FlatInt32int0M.AssertModel(models[17],_testData[21], false);
                        FlatInt32int0M.AssertModel(models[18],_testData[22], false);
                        FlatInt32int0M.AssertModel(models[19],_testData[23], false);
                        FlatInt32int0M.AssertModel(models[20],_testData[24], false);
                        FlatInt32int0M.AssertModel(models[21],_testData[25], false);
                        FlatInt32int0M.AssertModel(models[22],_testData[26], false);
                        FlatInt32int0M.AssertModel(models[23],_testData[27], false);
                        FlatInt32int0M.AssertModel(models[24],_testData[28], false);
                        FlatInt32int0M.AssertModel(models[25],_testData[29], false);
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
                parametr2.Value = 77;
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
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
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
                parametr1.Value = 77;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 40;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((IInt32SingleTypeint)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        Int32int0M.AssertModel(models[0],_testData[8], false);
                        Int32int0M.AssertModel(models[1],_testData[9], false);
                        Int32int0M.AssertModel(models[2],_testData[10], false);
                        Int32int0M.AssertModel(models[3],_testData[11], false);
                        Int32int0M.AssertModel(models[4],_testData[12], false);
                        Int32int0M.AssertModel(models[5],_testData[13], false);
                        Int32int0M.AssertModel(models[6],_testData[14], false);
                        Int32int0M.AssertModel(models[7],_testData[15], false);
                        Int32int0M.AssertModel(models[8],_testData[16], false);
                        Int32int0M.AssertModel(models[9],_testData[17], false);
                        Int32int0M.AssertModel(models[10],_testData[18], false);
                        Int32int0M.AssertModel(models[11],_testData[19], false);
                        Int32int0M.AssertModel(models[12],_testData[20], false);
                        Int32int0M.AssertModel(models[13],_testData[21], false);
                        Int32int0M.AssertModel(models[14],_testData[22], false);
                        Int32int0M.AssertModel(models[15],_testData[23], false);
                        Int32int0M.AssertModel(models[16],_testData[24], false);
                        Int32int0M.AssertModel(models[17],_testData[25], false);
                        Int32int0M.AssertModel(models[18],_testData[26], false);
                        Int32int0M.AssertModel(models[19],_testData[27], false);
                        Int32int0M.AssertModel(models[20],_testData[28], false);
                        Int32int0M.AssertModel(models[21],_testData[29], false);
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
                parametr1.Value = 129;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 34;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((IInt32SingleTypeint)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
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
                await ((IInt32SingleTypeint)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 22, query1, 34, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatInt32int0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatInt32int0M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatInt32int0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatInt32int0M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatInt32int0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatInt32int0M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatInt32int0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatInt32int0M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatInt32int0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatInt32int0M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatInt32int0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatInt32int0M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatInt32int0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatInt32int0M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatInt32int0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatInt32int0M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatInt32int0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatInt32int0M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatInt32int0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatInt32int0M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatInt32int0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatInt32int0M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatInt32int0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatInt32int0M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatInt32int0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatInt32int0M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatInt32int0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatInt32int0M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatInt32int0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatInt32int0M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatInt32int0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatInt32int0M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatInt32int0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatInt32int0M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatInt32int0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatInt32int0M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatInt32int0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatInt32int0M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatInt32int0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatInt32int0M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatInt32int0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatInt32int0M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatInt32int0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatInt32int0M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatInt32int0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatInt32int0M.AssertModel(firstItems2[24],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
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
                await ((IInt32SingleTypeint)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 34, query1, 93, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatInt32int0M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatInt32int0M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatInt32int0M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatInt32int0M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatInt32int0M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatInt32int0M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatInt32int0M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatInt32int0M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems1[10],_testData[29], false);
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
                 ((IInt32SingleTypeint)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 140, query1, 76, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatInt32int0M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatInt32int0M.AssertModel(firstItems2[2],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
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
                 ((IInt32SingleTypeint)this).DbConnectionMMDynQuerySelectModelBatch(connection, 50, query1, 139, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatInt32int0M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatInt32int0M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatInt32int0M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatInt32int0M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatInt32int0M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatInt32int0M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatInt32int0M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatInt32int0M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatInt32int0M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatInt32int0M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatInt32int0M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatInt32int0M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatInt32int0M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatInt32int0M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatInt32int0M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatInt32int0M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatInt32int0M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatInt32int0M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatInt32int0M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatInt32int0M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatInt32int0M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatInt32int0M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatInt32int0M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatInt32int0M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatInt32int0M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatInt32int0M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatInt32int0M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatInt32int0M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatInt32int0M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatInt32int0M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatInt32int0M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatInt32int0M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatInt32int0M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatInt32int0M.AssertModel(firstItems2[18],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatInt32int0M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems1[3],_testData[29], false);
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
                foreach(var batchResult in await ((IInt32SingleTypeint)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 149, query1, 84, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatInt32int0M.AssertModel(models[0],_testData[28], false);
                        FlatInt32int0M.AssertModel(models[1],_testData[29], false);
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
                await ((IInt32SingleTypeint)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 16, query1, 53, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                        FlatInt32int0M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatInt32int0M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatInt32int0M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatInt32int0M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatInt32int0M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatInt32int0M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatInt32int0M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatInt32int0M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatInt32int0M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatInt32int0M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatInt32int0M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatInt32int0M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatInt32int0M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatInt32int0M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatInt32int0M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatInt32int0M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatInt32int0M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatInt32int0M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatInt32int0M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatInt32int0M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatInt32int0M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatInt32int0M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatInt32int0M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatInt32int0M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems1[25],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatInt32int0M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatInt32int0M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatInt32int0M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatInt32int0M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatInt32int0M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatInt32int0M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatInt32int0M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatInt32int0M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatInt32int0M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatInt32int0M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatInt32int0M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatInt32int0M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatInt32int0M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatInt32int0M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatInt32int0M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatInt32int0M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatInt32int0M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatInt32int0M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatInt32int0M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatInt32int0M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatInt32int0M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatInt32int0M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatInt32int0M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatInt32int0M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatInt32int0M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatInt32int0M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatInt32int0M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatInt32int0M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatInt32int0M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatInt32int0M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatInt32int0M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatInt32int0M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatInt32int0M.AssertModel(secondItems2[17],_testData[29], false);
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
                foreach(var batchResult in  ((IInt32SingleTypeint)this).DbConnectionSTDynQuerySelectModelBatch(connection, 149, query1, 120, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatInt32int0M.AssertModel(models[0],_testData[28], false);
                        FlatInt32int0M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatInt32int0M.AssertModel(models[0],_testData[23], false);
                        FlatInt32int0M.AssertModel(models[1],_testData[24], false);
                        FlatInt32int0M.AssertModel(models[2],_testData[25], false);
                        FlatInt32int0M.AssertModel(models[3],_testData[26], false);
                        FlatInt32int0M.AssertModel(models[4],_testData[27], false);
                        FlatInt32int0M.AssertModel(models[5],_testData[28], false);
                        FlatInt32int0M.AssertModel(models[6],_testData[29], false);
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
                 ((IInt32SingleTypeint)this).DbConnectionDynQuerySelectModelBatch(connection, 53, query1, 34, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                        FlatInt32int0M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatInt32int0M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatInt32int0M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatInt32int0M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatInt32int0M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatInt32int0M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatInt32int0M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatInt32int0M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatInt32int0M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatInt32int0M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatInt32int0M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatInt32int0M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatInt32int0M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatInt32int0M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatInt32int0M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatInt32int0M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatInt32int0M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatInt32int0M.AssertModel(firstItems1[17],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
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
                foreach(var batchResult in await ((IInt32SingleTypeint)this).DbConnectionSTSelectModelBatchAsync(connection, 112, 4))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        Int32int0M.AssertModel(models[0],_testData[1], false);
                        Int32int0M.AssertModel(models[1],_testData[2], false);
                        Int32int0M.AssertModel(models[2],_testData[3], false);
                        Int32int0M.AssertModel(models[3],_testData[4], false);
                        Int32int0M.AssertModel(models[4],_testData[5], false);
                        Int32int0M.AssertModel(models[5],_testData[6], false);
                        Int32int0M.AssertModel(models[6],_testData[7], false);
                        Int32int0M.AssertModel(models[7],_testData[8], false);
                        Int32int0M.AssertModel(models[8],_testData[9], false);
                        Int32int0M.AssertModel(models[9],_testData[10], false);
                        Int32int0M.AssertModel(models[10],_testData[11], false);
                        Int32int0M.AssertModel(models[11],_testData[12], false);
                        Int32int0M.AssertModel(models[12],_testData[13], false);
                        Int32int0M.AssertModel(models[13],_testData[14], false);
                        Int32int0M.AssertModel(models[14],_testData[15], false);
                        Int32int0M.AssertModel(models[15],_testData[16], false);
                        Int32int0M.AssertModel(models[16],_testData[17], false);
                        Int32int0M.AssertModel(models[17],_testData[18], false);
                        Int32int0M.AssertModel(models[18],_testData[19], false);
                        Int32int0M.AssertModel(models[19],_testData[20], false);
                        Int32int0M.AssertModel(models[20],_testData[21], false);
                        Int32int0M.AssertModel(models[21],_testData[22], false);
                        Int32int0M.AssertModel(models[22],_testData[23], false);
                        Int32int0M.AssertModel(models[23],_testData[24], false);
                        Int32int0M.AssertModel(models[24],_testData[25], false);
                        Int32int0M.AssertModel(models[25],_testData[26], false);
                        Int32int0M.AssertModel(models[26],_testData[27], false);
                        Int32int0M.AssertModel(models[27],_testData[28], false);
                        Int32int0M.AssertModel(models[28],_testData[29], false);
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
                foreach(var batchResult in  ((IInt32SingleTypeint)this).DbConnectionSTSelectModelBatch(connection, 55, 46))
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
                ((IInt32SingleTypeint)this).SetDbConnectionSelectModelParametrs(cmd, 43);
                var models = await ((IInt32SingleTypeint)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(21));
Int32int0M.AssertModel(models[0],_testData[9], false);Int32int0M.AssertModel(models[1],_testData[10], false);Int32int0M.AssertModel(models[2],_testData[11], false);Int32int0M.AssertModel(models[3],_testData[12], false);Int32int0M.AssertModel(models[4],_testData[13], false);Int32int0M.AssertModel(models[5],_testData[14], false);Int32int0M.AssertModel(models[6],_testData[15], false);Int32int0M.AssertModel(models[7],_testData[16], false);Int32int0M.AssertModel(models[8],_testData[17], false);Int32int0M.AssertModel(models[9],_testData[18], false);Int32int0M.AssertModel(models[10],_testData[19], false);Int32int0M.AssertModel(models[11],_testData[20], false);Int32int0M.AssertModel(models[12],_testData[21], false);Int32int0M.AssertModel(models[13],_testData[22], false);Int32int0M.AssertModel(models[14],_testData[23], false);Int32int0M.AssertModel(models[15],_testData[24], false);Int32int0M.AssertModel(models[16],_testData[25], false);Int32int0M.AssertModel(models[17],_testData[26], false);Int32int0M.AssertModel(models[18],_testData[27], false);Int32int0M.AssertModel(models[19],_testData[28], false);Int32int0M.AssertModel(models[20],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt32SingleTypeint)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt32SingleTypeint)this).SetDbConnectionSelectModelParametrs(cmd, 139);
                var models =  ((IInt32SingleTypeint)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(4));
Int32int0M.AssertModel(models[0],_testData[26], false);Int32int0M.AssertModel(models[1],_testData[27], false);Int32int0M.AssertModel(models[2],_testData[28], false);Int32int0M.AssertModel(models[3],_testData[29], false);
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
                Assert.That((System.Int32)model[0], Is.EqualTo((4)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1552288114)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1693150787)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1751177486)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1955250173)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((1797490035)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((250536789)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((541581376)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1123836238)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((1230509271)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((771989806)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1818662976)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((257124714)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1229226695)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((2141466752)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1652924321)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((539903893)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((594846827)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1299587395)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1903311802)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((2036255603)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((2048459809)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1174472074)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((15322339)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((171968221)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((53)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1814467887)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1250236051)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((540766199)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1230705110)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1349419214)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((756348508)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((82821717)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1899209285)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((2073794618)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((429479077)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1959858189)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((2132633688)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((500633297)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((825665851)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((503695054)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1037966837)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((733053129)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((874184323)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1603573740)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((2122707172)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((2060898756)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((2031723280)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1129515384)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((963848984)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1892577285)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1259047912)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1482052626)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((2013209211)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((525090146)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((150892362)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((195906930)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1298377003)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((116316023)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((656695283)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1771946562)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((558471047)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1184476596)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1708055080)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((972170740)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((164250285)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((149)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((2092884616)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1652447718)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1771535135)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1738615032)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((158)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((2010826778)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((167)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1987002881)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((67)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((743767923)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1812447650)));//InnerModel.NullableValue

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
                Assert.That((System.Int32)model[0], Is.EqualTo((4)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1552288114)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1693150787)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1751177486)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1955250173)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((1797490035)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((250536789)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((541581376)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1123836238)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((1230509271)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((771989806)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1818662976)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((257124714)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1229226695)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((2141466752)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1652924321)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((539903893)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((594846827)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1299587395)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1903311802)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((2036255603)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((2048459809)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1174472074)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((15322339)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((171968221)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((53)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1814467887)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1250236051)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((540766199)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1230705110)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1349419214)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((756348508)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((82821717)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1899209285)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((2073794618)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((429479077)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1959858189)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((2132633688)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((500633297)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((825665851)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((503695054)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1037966837)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((733053129)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((874184323)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1603573740)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((2122707172)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((2060898756)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((2031723280)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1129515384)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((963848984)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1892577285)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1259047912)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1482052626)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((2013209211)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((525090146)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int32?)model[5], Is.EqualTo((150892362)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((195906930)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1298377003)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((116316023)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((656695283)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1771946562)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((558471047)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1184476596)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1708055080)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((972170740)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((164250285)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((149)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((2092884616)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((1652447718)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1771535135)));//InnerModel.NullableValue

                Assert.That((System.Int32?)model[5], Is.EqualTo((1738615032)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((158)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((2010826778)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((167)));//Id
                Assert.That((System.Int32)model[1], Is.EqualTo((1987002881)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((67)));//InnerModel.Id
                Assert.That((System.Int32)model[3], Is.EqualTo((743767923)));//InnerModel.Value

                Assert.That((System.Int32?)model[4], Is.EqualTo((1812447650)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

#endregion

    }
}

