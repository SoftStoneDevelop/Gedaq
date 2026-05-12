

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
    internal partial interface IByteSingleTypetinyint
    {
    }
    
    internal partial class ByteSingleTypetinyint : IByteSingleTypetinyint
    {


#region TestData

        private readonly BytetinyintE0M[] _testData = new BytetinyintE0M[]
        {
            new BytetinyintE0M
{
    Id = 7,
    Value = 210,
    ModelInner = null,
    NullableValue = null,
},
            new BytetinyintE0M
{
    Id = 10,
    Value = 218,
    ModelInner = new BytetinyintE0MI
{
    Id = 3,
    Value = 160,
    NullableValue = 0,
},
    NullableValue = 223,
},
            new BytetinyintE0M
{
    Id = 17,
    Value = 83,
    ModelInner = null,
    NullableValue = 152,
},
            new BytetinyintE0M
{
    Id = 21,
    Value = 219,
    ModelInner = new BytetinyintE0MI
{
    Id = 6,
    Value = 139,
    NullableValue = 23,
},
    NullableValue = null,
},
            new BytetinyintE0M
{
    Id = 30,
    Value = 217,
    ModelInner = null,
    NullableValue = 65,
},
            new BytetinyintE0M
{
    Id = 39,
    Value = 242,
    ModelInner = new BytetinyintE0MI
{
    Id = 11,
    Value = 166,
    NullableValue = 54,
},
    NullableValue = null,
},
            new BytetinyintE0M
{
    Id = 46,
    Value = 175,
    ModelInner = null,
    NullableValue = null,
},
            new BytetinyintE0M
{
    Id = 48,
    Value = 90,
    ModelInner = new BytetinyintE0MI
{
    Id = 17,
    Value = 127,
    NullableValue = 132,
},
    NullableValue = 196,
},
            new BytetinyintE0M
{
    Id = 57,
    Value = 91,
    ModelInner = null,
    NullableValue = null,
},
            new BytetinyintE0M
{
    Id = 63,
    Value = 142,
    ModelInner = new BytetinyintE0MI
{
    Id = 24,
    Value = 7,
    NullableValue = 199,
},
    NullableValue = 124,
},
            new BytetinyintE0M
{
    Id = 69,
    Value = 224,
    ModelInner = null,
    NullableValue = 123,
},
            new BytetinyintE0M
{
    Id = 76,
    Value = 188,
    ModelInner = new BytetinyintE0MI
{
    Id = 30,
    Value = 58,
    NullableValue = null,
},
    NullableValue = null,
},
            new BytetinyintE0M
{
    Id = 79,
    Value = 198,
    ModelInner = null,
    NullableValue = null,
},
            new BytetinyintE0M
{
    Id = 84,
    Value = 50,
    ModelInner = new BytetinyintE0MI
{
    Id = 38,
    Value = 134,
    NullableValue = null,
},
    NullableValue = 178,
},
            new BytetinyintE0M
{
    Id = 89,
    Value = 83,
    ModelInner = null,
    NullableValue = null,
},
            new BytetinyintE0M
{
    Id = 97,
    Value = 161,
    ModelInner = new BytetinyintE0MI
{
    Id = 40,
    Value = 3,
    NullableValue = 146,
},
    NullableValue = null,
},
            new BytetinyintE0M
{
    Id = 98,
    Value = 105,
    ModelInner = null,
    NullableValue = null,
},
            new BytetinyintE0M
{
    Id = 106,
    Value = 96,
    ModelInner = new BytetinyintE0MI
{
    Id = 43,
    Value = 140,
    NullableValue = null,
},
    NullableValue = 149,
},
            new BytetinyintE0M
{
    Id = 115,
    Value = 58,
    ModelInner = null,
    NullableValue = 196,
},
            new BytetinyintE0M
{
    Id = 119,
    Value = 206,
    ModelInner = new BytetinyintE0MI
{
    Id = 49,
    Value = 161,
    NullableValue = null,
},
    NullableValue = null,
},
            new BytetinyintE0M
{
    Id = 124,
    Value = 149,
    ModelInner = null,
    NullableValue = null,
},
            new BytetinyintE0M
{
    Id = 133,
    Value = 203,
    ModelInner = new BytetinyintE0MI
{
    Id = 55,
    Value = 141,
    NullableValue = 22,
},
    NullableValue = null,
},
            new BytetinyintE0M
{
    Id = 141,
    Value = 207,
    ModelInner = null,
    NullableValue = null,
},
            new BytetinyintE0M
{
    Id = 149,
    Value = 109,
    ModelInner = new BytetinyintE0MI
{
    Id = 61,
    Value = 102,
    NullableValue = 125,
},
    NullableValue = 2,
},
            new BytetinyintE0M
{
    Id = 157,
    Value = 215,
    ModelInner = null,
    NullableValue = 2,
},
            new BytetinyintE0M
{
    Id = 161,
    Value = 97,
    ModelInner = new BytetinyintE0MI
{
    Id = 70,
    Value = 194,
    NullableValue = 185,
},
    NullableValue = 150,
},
            new BytetinyintE0M
{
    Id = 165,
    Value = 101,
    ModelInner = null,
    NullableValue = null,
},
            new BytetinyintE0M
{
    Id = 167,
    Value = 106,
    ModelInner = new BytetinyintE0MI
{
    Id = 74,
    Value = 176,
    NullableValue = 241,
},
    NullableValue = null,
},
            new BytetinyintE0M
{
    Id = 174,
    Value = 30,
    ModelInner = null,
    NullableValue = 16,
},
            new BytetinyintE0M
{
    Id = 178,
    Value = 204,
    ModelInner = new BytetinyintE0MI
{
    Id = 81,
    Value = 192,
    NullableValue = null,
},
    NullableValue = 145,
},
            new BytetinyintE0M
{
    Id = 183,
    Value = 55,
    ModelInner = null,
    NullableValue = 88,
},
            new BytetinyintE0M
{
    Id = 192,
    Value = 251,
    ModelInner = new BytetinyintE0MI
{
    Id = 84,
    Value = 252,
    NullableValue = 155,
},
    NullableValue = 96,
},
            new BytetinyintE0M
{
    Id = 200,
    Value = 115,
    ModelInner = null,
    NullableValue = null,
},
            new BytetinyintE0M
{
    Id = 206,
    Value = 222,
    ModelInner = new BytetinyintE0MI
{
    Id = 93,
    Value = 90,
    NullableValue = 170,
},
    NullableValue = null,
},
            new BytetinyintE0M
{
    Id = 209,
    Value = 230,
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.SqlClient.Attributes.Query(
            query: @"
INSERT INTO dbo.bytetinyinte0mi(
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
            asPartInterface: typeof(IByteSingleTypetinyint)), 
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                parametrName: "id",
                methodParametrName: "id", 
                dbType: (System.Data.SqlDbType)(8)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Byte),
                parametrName: "value",
                methodParametrName: "value",
                dbType: (System.Data.SqlDbType)(20)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Byte?), 
                parametrName: "nullablevalue",
                methodParametrName: "nullablevalue",
                dbType: (System.Data.SqlDbType)(20))
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

                changedRows =  ((IByteSingleTypetinyint)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IByteSingleTypetinyint)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IByteSingleTypetinyint)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO dbo.bytetinyinte0mi(
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
            asPartInterface: typeof(IByteSingleTypetinyint)), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)11),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Byte), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)2),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Byte?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)2, 
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

                changedRows =  ((IByteSingleTypetinyint)this).DbConnectionInsertInnerModel(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
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

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertInnerModelAsync(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertInnerModelAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertInnerModelAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertInnerModelAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertInnerModelAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertInnerModelAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertInnerModelAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertInnerModelAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertInnerModelAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertInnerModelAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertInnerModelAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertInnerModelAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.SqlClient.Attributes.Query(
            query: @"
INSERT INTO dbo.bytetinyinte0m(
	id,
    value,
    nullablevalue,
    bytetinyinte0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @bytetinyinte0mi_id
)
",
            methodName:"InsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteSingleTypetinyint)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                parametrName: "id",
                methodParametrName: "id",
                dbType: (System.Data.SqlDbType)(8)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Byte), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.SqlDbType)(20)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Byte?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.SqlDbType)(20),
                nullable: true),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "bytetinyinte0mi_id", 
                methodParametrName: "bytetinyinte0mi_id", 
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

                changedRows =  ((IByteSingleTypetinyint)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IByteSingleTypetinyint)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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

                changedRows = await ((IByteSingleTypetinyint)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO dbo.bytetinyinte0m(
	id,
    value,
    nullablevalue,
    bytetinyinte0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @bytetinyinte0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteSingleTypetinyint)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)11),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Byte), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)2),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Byte?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)2,
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "bytetinyinte0mi_id", 
                methodParametrName: "bytetinyinte0mi_id", 
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

                changedRows =  ((IByteSingleTypetinyint)this).DbConnectionInsertModel(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IByteSingleTypetinyint)this).DbConnectionInsertModel(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
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

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertModelAsync(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertModelAsync(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertModelAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertModelAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertModelAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertModelAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertModelAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertModelAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertModelAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertModelAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertModelAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertModelAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertModelAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertModelAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertModelAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertModelAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertModelAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertModelAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertModelAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertModelAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertModelAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertModelAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertModelAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertModelAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertModelAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertModelAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertModelAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertModelAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IByteSingleTypetinyint)this).DbConnectionInsertModelAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBytetinyintE0M), typeof(FlatBytetinyintE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteSingleTypetinyint)),
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
FROM dbo.bytetinyinte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models1 = new List<FlatBytetinyintE0M>();
                var models2 = new List<FlatBytetinyintE0M>();
                await((IByteSingleTypetinyint)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytetinyintE0M.AssertModel(models1[i],_testData[i], false);
                    FlatBytetinyintE0M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.bytetinyinte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models1 = new List<FlatBytetinyintE0M>();
                var models2 = new List<FlatBytetinyintE0M>();
                ((IByteSingleTypetinyint)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytetinyintE0M.AssertModel(models1[i],_testData[i], false);
                    FlatBytetinyintE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBytetinyintE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteSingleTypetinyint)),
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
FROM dbo.bytetinyinte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models = await((IByteSingleTypetinyint)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytetinyintE0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.bytetinyinte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models = ((IByteSingleTypetinyint)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytetinyintE0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.bytetinyinte0m m
LEFT JOIN dbo.bytetinyinte0mi mi ON mi.id = m.bytetinyinte0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(BytetinyintE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteSingleTypetinyint)),
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
                var models = await((IByteSingleTypetinyint)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BytetinyintE0M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IByteSingleTypetinyint)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BytetinyintE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBytetinyintE0M), typeof(FlatBytetinyintE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteSingleTypetinyint)),
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
FROM dbo.bytetinyinte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBytetinyintE0M>();
                var models2 = new List<FlatBytetinyintE0M>();
                await((IByteSingleTypetinyint)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytetinyintE0M.AssertModel(models1[i],_testData[i], false);
                    FlatBytetinyintE0M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.bytetinyinte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBytetinyintE0M>();
                var models2 = new List<FlatBytetinyintE0M>();
                ((IByteSingleTypetinyint)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytetinyintE0M.AssertModel(models1[i],_testData[i], false);
                    FlatBytetinyintE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatBytetinyintE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteSingleTypetinyint)),
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
FROM dbo.bytetinyinte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IByteSingleTypetinyint)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytetinyintE0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.bytetinyinte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IByteSingleTypetinyint)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytetinyintE0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.bytetinyinte0m m
LEFT JOIN dbo.bytetinyinte0mi mi ON mi.id = m.bytetinyinte0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(BytetinyintE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteSingleTypetinyint)),
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
                var models = await((IByteSingleTypetinyint)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BytetinyintE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IByteSingleTypetinyint)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BytetinyintE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBytetinyintE0M), typeof(FlatBytetinyintE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteSingleTypetinyint)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteSingleTypetinyint)),
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
            asPartInterface: typeof(IByteSingleTypetinyint)),
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
FROM dbo.bytetinyinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatBytetinyintE0M>();
                var models2 = new List<FlatBytetinyintE0M>();
                await((IByteSingleTypetinyint)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytetinyintE0M.AssertModel(models1[i],_testData[i], false);
                    FlatBytetinyintE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 119;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 97;
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
FROM dbo.bytetinyinte0m m
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
FROM dbo.bytetinyinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytetinyintE0M>();
                var firstItems2 = new List<FlatBytetinyintE0M>();
                var secondItems1 = new List<FlatBytetinyintE0M>();
                var secondItems2 = new List<FlatBytetinyintE0M>();
                await ((IByteSingleTypetinyint)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatBytetinyintE0M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatBytetinyintE0M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[18],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 39;
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
FROM dbo.bytetinyinte0m m
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
FROM dbo.bytetinyinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytetinyintE0M>();
                var firstItems2 = new List<FlatBytetinyintE0M>();
                var secondItems1 = new List<FlatBytetinyintE0M>();
                await ((IByteSingleTypetinyint)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatBytetinyintE0M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatBytetinyintE0M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[19],_testData[34], false);
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
FROM dbo.bytetinyinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatBytetinyintE0M>();
                var models2 = new List<FlatBytetinyintE0M>();
                ((IByteSingleTypetinyint)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytetinyintE0M.AssertModel(models1[i],_testData[i], false);
                    FlatBytetinyintE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 7;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 21;
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
FROM dbo.bytetinyinte0m m
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
FROM dbo.bytetinyinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytetinyintE0M>();
                var firstItems2 = new List<FlatBytetinyintE0M>();
                var secondItems1 = new List<FlatBytetinyintE0M>();
                var secondItems2 = new List<FlatBytetinyintE0M>();
                 ((IByteSingleTypetinyint)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatBytetinyintE0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatBytetinyintE0M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[30],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 124;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 119;
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
FROM dbo.bytetinyinte0m m
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
FROM dbo.bytetinyinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytetinyintE0M>();
                var firstItems2 = new List<FlatBytetinyintE0M>();
                var secondItems1 = new List<FlatBytetinyintE0M>();
                 ((IByteSingleTypetinyint)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatBytetinyintE0M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatBytetinyintE0M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[14],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBytetinyintE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteSingleTypetinyint)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteSingleTypetinyint)),
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
            asPartInterface: typeof(IByteSingleTypetinyint)),
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
FROM dbo.bytetinyinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IByteSingleTypetinyint)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytetinyintE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 89;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 39;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.bytetinyinte0m m
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
FROM dbo.bytetinyinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IByteSingleTypetinyint)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatBytetinyintE0M.AssertModel(models[0],_testData[15], false);
                        FlatBytetinyintE0M.AssertModel(models[1],_testData[16], false);
                        FlatBytetinyintE0M.AssertModel(models[2],_testData[17], false);
                        FlatBytetinyintE0M.AssertModel(models[3],_testData[18], false);
                        FlatBytetinyintE0M.AssertModel(models[4],_testData[19], false);
                        FlatBytetinyintE0M.AssertModel(models[5],_testData[20], false);
                        FlatBytetinyintE0M.AssertModel(models[6],_testData[21], false);
                        FlatBytetinyintE0M.AssertModel(models[7],_testData[22], false);
                        FlatBytetinyintE0M.AssertModel(models[8],_testData[23], false);
                        FlatBytetinyintE0M.AssertModel(models[9],_testData[24], false);
                        FlatBytetinyintE0M.AssertModel(models[10],_testData[25], false);
                        FlatBytetinyintE0M.AssertModel(models[11],_testData[26], false);
                        FlatBytetinyintE0M.AssertModel(models[12],_testData[27], false);
                        FlatBytetinyintE0M.AssertModel(models[13],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(models[14],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(models[15],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(models[16],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(models[17],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(models[18],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatBytetinyintE0M.AssertModel(models[0],_testData[6], false);
                        FlatBytetinyintE0M.AssertModel(models[1],_testData[7], false);
                        FlatBytetinyintE0M.AssertModel(models[2],_testData[8], false);
                        FlatBytetinyintE0M.AssertModel(models[3],_testData[9], false);
                        FlatBytetinyintE0M.AssertModel(models[4],_testData[10], false);
                        FlatBytetinyintE0M.AssertModel(models[5],_testData[11], false);
                        FlatBytetinyintE0M.AssertModel(models[6],_testData[12], false);
                        FlatBytetinyintE0M.AssertModel(models[7],_testData[13], false);
                        FlatBytetinyintE0M.AssertModel(models[8],_testData[14], false);
                        FlatBytetinyintE0M.AssertModel(models[9],_testData[15], false);
                        FlatBytetinyintE0M.AssertModel(models[10],_testData[16], false);
                        FlatBytetinyintE0M.AssertModel(models[11],_testData[17], false);
                        FlatBytetinyintE0M.AssertModel(models[12],_testData[18], false);
                        FlatBytetinyintE0M.AssertModel(models[13],_testData[19], false);
                        FlatBytetinyintE0M.AssertModel(models[14],_testData[20], false);
                        FlatBytetinyintE0M.AssertModel(models[15],_testData[21], false);
                        FlatBytetinyintE0M.AssertModel(models[16],_testData[22], false);
                        FlatBytetinyintE0M.AssertModel(models[17],_testData[23], false);
                        FlatBytetinyintE0M.AssertModel(models[18],_testData[24], false);
                        FlatBytetinyintE0M.AssertModel(models[19],_testData[25], false);
                        FlatBytetinyintE0M.AssertModel(models[20],_testData[26], false);
                        FlatBytetinyintE0M.AssertModel(models[21],_testData[27], false);
                        FlatBytetinyintE0M.AssertModel(models[22],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(models[23],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(models[24],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(models[25],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(models[26],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(models[27],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(models[28],_testData[34], false);
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
                parametr1.Value = 133;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 200;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.bytetinyinte0m m
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
FROM dbo.bytetinyinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytetinyintE0M>();
                var secondItems1 = new List<FlatBytetinyintE0M>();
                var secondItems2 = new List<FlatBytetinyintE0M>();
                await ((IByteSingleTypetinyint)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatBytetinyintE0M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatBytetinyintE0M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[1],_testData[34], false);
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
FROM dbo.bytetinyinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IByteSingleTypetinyint)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytetinyintE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 48;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 89;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.bytetinyinte0m m
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
FROM dbo.bytetinyinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IByteSingleTypetinyint)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatBytetinyintE0M.AssertModel(models[0],_testData[8], false);
                        FlatBytetinyintE0M.AssertModel(models[1],_testData[9], false);
                        FlatBytetinyintE0M.AssertModel(models[2],_testData[10], false);
                        FlatBytetinyintE0M.AssertModel(models[3],_testData[11], false);
                        FlatBytetinyintE0M.AssertModel(models[4],_testData[12], false);
                        FlatBytetinyintE0M.AssertModel(models[5],_testData[13], false);
                        FlatBytetinyintE0M.AssertModel(models[6],_testData[14], false);
                        FlatBytetinyintE0M.AssertModel(models[7],_testData[15], false);
                        FlatBytetinyintE0M.AssertModel(models[8],_testData[16], false);
                        FlatBytetinyintE0M.AssertModel(models[9],_testData[17], false);
                        FlatBytetinyintE0M.AssertModel(models[10],_testData[18], false);
                        FlatBytetinyintE0M.AssertModel(models[11],_testData[19], false);
                        FlatBytetinyintE0M.AssertModel(models[12],_testData[20], false);
                        FlatBytetinyintE0M.AssertModel(models[13],_testData[21], false);
                        FlatBytetinyintE0M.AssertModel(models[14],_testData[22], false);
                        FlatBytetinyintE0M.AssertModel(models[15],_testData[23], false);
                        FlatBytetinyintE0M.AssertModel(models[16],_testData[24], false);
                        FlatBytetinyintE0M.AssertModel(models[17],_testData[25], false);
                        FlatBytetinyintE0M.AssertModel(models[18],_testData[26], false);
                        FlatBytetinyintE0M.AssertModel(models[19],_testData[27], false);
                        FlatBytetinyintE0M.AssertModel(models[20],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(models[21],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(models[22],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(models[23],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(models[24],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(models[25],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatBytetinyintE0M.AssertModel(models[0],_testData[15], false);
                        FlatBytetinyintE0M.AssertModel(models[1],_testData[16], false);
                        FlatBytetinyintE0M.AssertModel(models[2],_testData[17], false);
                        FlatBytetinyintE0M.AssertModel(models[3],_testData[18], false);
                        FlatBytetinyintE0M.AssertModel(models[4],_testData[19], false);
                        FlatBytetinyintE0M.AssertModel(models[5],_testData[20], false);
                        FlatBytetinyintE0M.AssertModel(models[6],_testData[21], false);
                        FlatBytetinyintE0M.AssertModel(models[7],_testData[22], false);
                        FlatBytetinyintE0M.AssertModel(models[8],_testData[23], false);
                        FlatBytetinyintE0M.AssertModel(models[9],_testData[24], false);
                        FlatBytetinyintE0M.AssertModel(models[10],_testData[25], false);
                        FlatBytetinyintE0M.AssertModel(models[11],_testData[26], false);
                        FlatBytetinyintE0M.AssertModel(models[12],_testData[27], false);
                        FlatBytetinyintE0M.AssertModel(models[13],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(models[14],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(models[15],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(models[16],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(models[17],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(models[18],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(models[19],_testData[34], false);
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
                parametr1.Value = 115;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 39;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.bytetinyinte0m m
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
FROM dbo.bytetinyinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytetinyintE0M>();
                var secondItems1 = new List<FlatBytetinyintE0M>();
                var secondItems2 = new List<FlatBytetinyintE0M>();
                 ((IByteSingleTypetinyint)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatBytetinyintE0M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatBytetinyintE0M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[28],_testData[34], false);
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
FROM dbo.bytetinyinte0m m
LEFT JOIN dbo.bytetinyinte0mi mi ON mi.id = m.bytetinyinte0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(BytetinyintE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteSingleTypetinyint)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteSingleTypetinyint)),
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
                var models = await((IByteSingleTypetinyint)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BytetinyintE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 57;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 48;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IByteSingleTypetinyint)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        BytetinyintE0M.AssertModel(models[0],_testData[9], false);
                        BytetinyintE0M.AssertModel(models[1],_testData[10], false);
                        BytetinyintE0M.AssertModel(models[2],_testData[11], false);
                        BytetinyintE0M.AssertModel(models[3],_testData[12], false);
                        BytetinyintE0M.AssertModel(models[4],_testData[13], false);
                        BytetinyintE0M.AssertModel(models[5],_testData[14], false);
                        BytetinyintE0M.AssertModel(models[6],_testData[15], false);
                        BytetinyintE0M.AssertModel(models[7],_testData[16], false);
                        BytetinyintE0M.AssertModel(models[8],_testData[17], false);
                        BytetinyintE0M.AssertModel(models[9],_testData[18], false);
                        BytetinyintE0M.AssertModel(models[10],_testData[19], false);
                        BytetinyintE0M.AssertModel(models[11],_testData[20], false);
                        BytetinyintE0M.AssertModel(models[12],_testData[21], false);
                        BytetinyintE0M.AssertModel(models[13],_testData[22], false);
                        BytetinyintE0M.AssertModel(models[14],_testData[23], false);
                        BytetinyintE0M.AssertModel(models[15],_testData[24], false);
                        BytetinyintE0M.AssertModel(models[16],_testData[25], false);
                        BytetinyintE0M.AssertModel(models[17],_testData[26], false);
                        BytetinyintE0M.AssertModel(models[18],_testData[27], false);
                        BytetinyintE0M.AssertModel(models[19],_testData[28], false);
                        BytetinyintE0M.AssertModel(models[20],_testData[29], false);
                        BytetinyintE0M.AssertModel(models[21],_testData[30], false);
                        BytetinyintE0M.AssertModel(models[22],_testData[31], false);
                        BytetinyintE0M.AssertModel(models[23],_testData[32], false);
                        BytetinyintE0M.AssertModel(models[24],_testData[33], false);
                        BytetinyintE0M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        BytetinyintE0M.AssertModel(models[0],_testData[8], false);
                        BytetinyintE0M.AssertModel(models[1],_testData[9], false);
                        BytetinyintE0M.AssertModel(models[2],_testData[10], false);
                        BytetinyintE0M.AssertModel(models[3],_testData[11], false);
                        BytetinyintE0M.AssertModel(models[4],_testData[12], false);
                        BytetinyintE0M.AssertModel(models[5],_testData[13], false);
                        BytetinyintE0M.AssertModel(models[6],_testData[14], false);
                        BytetinyintE0M.AssertModel(models[7],_testData[15], false);
                        BytetinyintE0M.AssertModel(models[8],_testData[16], false);
                        BytetinyintE0M.AssertModel(models[9],_testData[17], false);
                        BytetinyintE0M.AssertModel(models[10],_testData[18], false);
                        BytetinyintE0M.AssertModel(models[11],_testData[19], false);
                        BytetinyintE0M.AssertModel(models[12],_testData[20], false);
                        BytetinyintE0M.AssertModel(models[13],_testData[21], false);
                        BytetinyintE0M.AssertModel(models[14],_testData[22], false);
                        BytetinyintE0M.AssertModel(models[15],_testData[23], false);
                        BytetinyintE0M.AssertModel(models[16],_testData[24], false);
                        BytetinyintE0M.AssertModel(models[17],_testData[25], false);
                        BytetinyintE0M.AssertModel(models[18],_testData[26], false);
                        BytetinyintE0M.AssertModel(models[19],_testData[27], false);
                        BytetinyintE0M.AssertModel(models[20],_testData[28], false);
                        BytetinyintE0M.AssertModel(models[21],_testData[29], false);
                        BytetinyintE0M.AssertModel(models[22],_testData[30], false);
                        BytetinyintE0M.AssertModel(models[23],_testData[31], false);
                        BytetinyintE0M.AssertModel(models[24],_testData[32], false);
                        BytetinyintE0M.AssertModel(models[25],_testData[33], false);
                        BytetinyintE0M.AssertModel(models[26],_testData[34], false);
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
                var models = ((IByteSingleTypetinyint)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BytetinyintE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 161;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 165;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IByteSingleTypetinyint)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        BytetinyintE0M.AssertModel(models[0],_testData[26], false);
                        BytetinyintE0M.AssertModel(models[1],_testData[27], false);
                        BytetinyintE0M.AssertModel(models[2],_testData[28], false);
                        BytetinyintE0M.AssertModel(models[3],_testData[29], false);
                        BytetinyintE0M.AssertModel(models[4],_testData[30], false);
                        BytetinyintE0M.AssertModel(models[5],_testData[31], false);
                        BytetinyintE0M.AssertModel(models[6],_testData[32], false);
                        BytetinyintE0M.AssertModel(models[7],_testData[33], false);
                        BytetinyintE0M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        BytetinyintE0M.AssertModel(models[0],_testData[27], false);
                        BytetinyintE0M.AssertModel(models[1],_testData[28], false);
                        BytetinyintE0M.AssertModel(models[2],_testData[29], false);
                        BytetinyintE0M.AssertModel(models[3],_testData[30], false);
                        BytetinyintE0M.AssertModel(models[4],_testData[31], false);
                        BytetinyintE0M.AssertModel(models[5],_testData[32], false);
                        BytetinyintE0M.AssertModel(models[6],_testData[33], false);
                        BytetinyintE0M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBytetinyintE0M), typeof(FlatBytetinyintE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteSingleTypetinyint)),
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
            asPartInterface: typeof(IByteSingleTypetinyint)),
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
            asPartInterface: typeof(IByteSingleTypetinyint)),
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
FROM dbo.bytetinyinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBytetinyintE0M>();
                var models2 = new List<FlatBytetinyintE0M>();
                await((IByteSingleTypetinyint)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytetinyintE0M.AssertModel(models1[i],_testData[i], false);
                    FlatBytetinyintE0M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.bytetinyinte0m m
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
FROM dbo.bytetinyinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytetinyintE0M>();
                var firstItems2 = new List<FlatBytetinyintE0M>();
                var secondItems1 = new List<FlatBytetinyintE0M>();
                var secondItems2 = new List<FlatBytetinyintE0M>();
                await ((IByteSingleTypetinyint)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 192, query1, 39, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatBytetinyintE0M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatBytetinyintE0M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[28],_testData[34], false);
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
FROM dbo.bytetinyinte0m m
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
FROM dbo.bytetinyinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytetinyintE0M>();
                var firstItems2 = new List<FlatBytetinyintE0M>();
                var secondItems1 = new List<FlatBytetinyintE0M>();
                await ((IByteSingleTypetinyint)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 133, query1, 57, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatBytetinyintE0M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                        FlatBytetinyintE0M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[25],_testData[34], false);
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
FROM dbo.bytetinyinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBytetinyintE0M>();
                var models2 = new List<FlatBytetinyintE0M>();
                ((IByteSingleTypetinyint)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytetinyintE0M.AssertModel(models1[i],_testData[i], false);
                    FlatBytetinyintE0M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.bytetinyinte0m m
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
FROM dbo.bytetinyinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytetinyintE0M>();
                var firstItems2 = new List<FlatBytetinyintE0M>();
                var secondItems1 = new List<FlatBytetinyintE0M>();
                var secondItems2 = new List<FlatBytetinyintE0M>();
                 ((IByteSingleTypetinyint)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 124, query1, 141, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatBytetinyintE0M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatBytetinyintE0M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[11],_testData[34], false);
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
FROM dbo.bytetinyinte0m m
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
FROM dbo.bytetinyinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytetinyintE0M>();
                var firstItems2 = new List<FlatBytetinyintE0M>();
                var secondItems1 = new List<FlatBytetinyintE0M>();
                 ((IByteSingleTypetinyint)this).DbConnectionMMDynQuerySelectModelBatch(connection, 69, query1, 21, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatBytetinyintE0M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                        FlatBytetinyintE0M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[30],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBytetinyintE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteSingleTypetinyint)),
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
            asPartInterface: typeof(IByteSingleTypetinyint)),
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
            asPartInterface: typeof(IByteSingleTypetinyint)),
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
FROM dbo.bytetinyinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IByteSingleTypetinyint)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytetinyintE0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.bytetinyinte0m m
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
FROM dbo.bytetinyinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IByteSingleTypetinyint)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 69, query1, 46, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatBytetinyintE0M.AssertModel(models[0],_testData[11], false);
                        FlatBytetinyintE0M.AssertModel(models[1],_testData[12], false);
                        FlatBytetinyintE0M.AssertModel(models[2],_testData[13], false);
                        FlatBytetinyintE0M.AssertModel(models[3],_testData[14], false);
                        FlatBytetinyintE0M.AssertModel(models[4],_testData[15], false);
                        FlatBytetinyintE0M.AssertModel(models[5],_testData[16], false);
                        FlatBytetinyintE0M.AssertModel(models[6],_testData[17], false);
                        FlatBytetinyintE0M.AssertModel(models[7],_testData[18], false);
                        FlatBytetinyintE0M.AssertModel(models[8],_testData[19], false);
                        FlatBytetinyintE0M.AssertModel(models[9],_testData[20], false);
                        FlatBytetinyintE0M.AssertModel(models[10],_testData[21], false);
                        FlatBytetinyintE0M.AssertModel(models[11],_testData[22], false);
                        FlatBytetinyintE0M.AssertModel(models[12],_testData[23], false);
                        FlatBytetinyintE0M.AssertModel(models[13],_testData[24], false);
                        FlatBytetinyintE0M.AssertModel(models[14],_testData[25], false);
                        FlatBytetinyintE0M.AssertModel(models[15],_testData[26], false);
                        FlatBytetinyintE0M.AssertModel(models[16],_testData[27], false);
                        FlatBytetinyintE0M.AssertModel(models[17],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(models[18],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(models[19],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(models[20],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(models[21],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(models[22],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatBytetinyintE0M.AssertModel(models[0],_testData[7], false);
                        FlatBytetinyintE0M.AssertModel(models[1],_testData[8], false);
                        FlatBytetinyintE0M.AssertModel(models[2],_testData[9], false);
                        FlatBytetinyintE0M.AssertModel(models[3],_testData[10], false);
                        FlatBytetinyintE0M.AssertModel(models[4],_testData[11], false);
                        FlatBytetinyintE0M.AssertModel(models[5],_testData[12], false);
                        FlatBytetinyintE0M.AssertModel(models[6],_testData[13], false);
                        FlatBytetinyintE0M.AssertModel(models[7],_testData[14], false);
                        FlatBytetinyintE0M.AssertModel(models[8],_testData[15], false);
                        FlatBytetinyintE0M.AssertModel(models[9],_testData[16], false);
                        FlatBytetinyintE0M.AssertModel(models[10],_testData[17], false);
                        FlatBytetinyintE0M.AssertModel(models[11],_testData[18], false);
                        FlatBytetinyintE0M.AssertModel(models[12],_testData[19], false);
                        FlatBytetinyintE0M.AssertModel(models[13],_testData[20], false);
                        FlatBytetinyintE0M.AssertModel(models[14],_testData[21], false);
                        FlatBytetinyintE0M.AssertModel(models[15],_testData[22], false);
                        FlatBytetinyintE0M.AssertModel(models[16],_testData[23], false);
                        FlatBytetinyintE0M.AssertModel(models[17],_testData[24], false);
                        FlatBytetinyintE0M.AssertModel(models[18],_testData[25], false);
                        FlatBytetinyintE0M.AssertModel(models[19],_testData[26], false);
                        FlatBytetinyintE0M.AssertModel(models[20],_testData[27], false);
                        FlatBytetinyintE0M.AssertModel(models[21],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(models[22],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(models[23],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(models[24],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(models[25],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(models[26],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(models[27],_testData[34], false);
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
FROM dbo.bytetinyinte0m m
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
FROM dbo.bytetinyinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytetinyintE0M>();
                var secondItems1 = new List<FlatBytetinyintE0M>();
                var secondItems2 = new List<FlatBytetinyintE0M>();
                await ((IByteSingleTypetinyint)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 192, query1, 7, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatBytetinyintE0M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatBytetinyintE0M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[33],_testData[34], false);
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
FROM dbo.bytetinyinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IByteSingleTypetinyint)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBytetinyintE0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.bytetinyinte0m m
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
FROM dbo.bytetinyinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IByteSingleTypetinyint)this).DbConnectionSTDynQuerySelectModelBatch(connection, 17, query1, 124, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatBytetinyintE0M.AssertModel(models[0],_testData[3], false);
                        FlatBytetinyintE0M.AssertModel(models[1],_testData[4], false);
                        FlatBytetinyintE0M.AssertModel(models[2],_testData[5], false);
                        FlatBytetinyintE0M.AssertModel(models[3],_testData[6], false);
                        FlatBytetinyintE0M.AssertModel(models[4],_testData[7], false);
                        FlatBytetinyintE0M.AssertModel(models[5],_testData[8], false);
                        FlatBytetinyintE0M.AssertModel(models[6],_testData[9], false);
                        FlatBytetinyintE0M.AssertModel(models[7],_testData[10], false);
                        FlatBytetinyintE0M.AssertModel(models[8],_testData[11], false);
                        FlatBytetinyintE0M.AssertModel(models[9],_testData[12], false);
                        FlatBytetinyintE0M.AssertModel(models[10],_testData[13], false);
                        FlatBytetinyintE0M.AssertModel(models[11],_testData[14], false);
                        FlatBytetinyintE0M.AssertModel(models[12],_testData[15], false);
                        FlatBytetinyintE0M.AssertModel(models[13],_testData[16], false);
                        FlatBytetinyintE0M.AssertModel(models[14],_testData[17], false);
                        FlatBytetinyintE0M.AssertModel(models[15],_testData[18], false);
                        FlatBytetinyintE0M.AssertModel(models[16],_testData[19], false);
                        FlatBytetinyintE0M.AssertModel(models[17],_testData[20], false);
                        FlatBytetinyintE0M.AssertModel(models[18],_testData[21], false);
                        FlatBytetinyintE0M.AssertModel(models[19],_testData[22], false);
                        FlatBytetinyintE0M.AssertModel(models[20],_testData[23], false);
                        FlatBytetinyintE0M.AssertModel(models[21],_testData[24], false);
                        FlatBytetinyintE0M.AssertModel(models[22],_testData[25], false);
                        FlatBytetinyintE0M.AssertModel(models[23],_testData[26], false);
                        FlatBytetinyintE0M.AssertModel(models[24],_testData[27], false);
                        FlatBytetinyintE0M.AssertModel(models[25],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(models[26],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(models[27],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(models[28],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(models[29],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(models[30],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatBytetinyintE0M.AssertModel(models[0],_testData[21], false);
                        FlatBytetinyintE0M.AssertModel(models[1],_testData[22], false);
                        FlatBytetinyintE0M.AssertModel(models[2],_testData[23], false);
                        FlatBytetinyintE0M.AssertModel(models[3],_testData[24], false);
                        FlatBytetinyintE0M.AssertModel(models[4],_testData[25], false);
                        FlatBytetinyintE0M.AssertModel(models[5],_testData[26], false);
                        FlatBytetinyintE0M.AssertModel(models[6],_testData[27], false);
                        FlatBytetinyintE0M.AssertModel(models[7],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(models[8],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(models[9],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(models[10],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(models[11],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(models[12],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(models[13],_testData[34], false);
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
FROM dbo.bytetinyinte0m m
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
FROM dbo.bytetinyinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBytetinyintE0M>();
                var secondItems1 = new List<FlatBytetinyintE0M>();
                var secondItems2 = new List<FlatBytetinyintE0M>();
                 ((IByteSingleTypetinyint)this).DbConnectionDynQuerySelectModelBatch(connection, 149, query1, 17, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatBytetinyintE0M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatBytetinyintE0M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[31],_testData[34], false);
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
FROM dbo.bytetinyinte0m m
LEFT JOIN dbo.bytetinyinte0mi mi ON mi.id = m.bytetinyinte0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(BytetinyintE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteSingleTypetinyint)),
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
            asPartInterface: typeof(IByteSingleTypetinyint)),
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
                var models = await((IByteSingleTypetinyint)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BytetinyintE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IByteSingleTypetinyint)this).DbConnectionSTSelectModelBatchAsync(connection, 46, 183))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        BytetinyintE0M.AssertModel(models[0],_testData[7], false);
                        BytetinyintE0M.AssertModel(models[1],_testData[8], false);
                        BytetinyintE0M.AssertModel(models[2],_testData[9], false);
                        BytetinyintE0M.AssertModel(models[3],_testData[10], false);
                        BytetinyintE0M.AssertModel(models[4],_testData[11], false);
                        BytetinyintE0M.AssertModel(models[5],_testData[12], false);
                        BytetinyintE0M.AssertModel(models[6],_testData[13], false);
                        BytetinyintE0M.AssertModel(models[7],_testData[14], false);
                        BytetinyintE0M.AssertModel(models[8],_testData[15], false);
                        BytetinyintE0M.AssertModel(models[9],_testData[16], false);
                        BytetinyintE0M.AssertModel(models[10],_testData[17], false);
                        BytetinyintE0M.AssertModel(models[11],_testData[18], false);
                        BytetinyintE0M.AssertModel(models[12],_testData[19], false);
                        BytetinyintE0M.AssertModel(models[13],_testData[20], false);
                        BytetinyintE0M.AssertModel(models[14],_testData[21], false);
                        BytetinyintE0M.AssertModel(models[15],_testData[22], false);
                        BytetinyintE0M.AssertModel(models[16],_testData[23], false);
                        BytetinyintE0M.AssertModel(models[17],_testData[24], false);
                        BytetinyintE0M.AssertModel(models[18],_testData[25], false);
                        BytetinyintE0M.AssertModel(models[19],_testData[26], false);
                        BytetinyintE0M.AssertModel(models[20],_testData[27], false);
                        BytetinyintE0M.AssertModel(models[21],_testData[28], false);
                        BytetinyintE0M.AssertModel(models[22],_testData[29], false);
                        BytetinyintE0M.AssertModel(models[23],_testData[30], false);
                        BytetinyintE0M.AssertModel(models[24],_testData[31], false);
                        BytetinyintE0M.AssertModel(models[25],_testData[32], false);
                        BytetinyintE0M.AssertModel(models[26],_testData[33], false);
                        BytetinyintE0M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        BytetinyintE0M.AssertModel(models[0],_testData[31], false);
                        BytetinyintE0M.AssertModel(models[1],_testData[32], false);
                        BytetinyintE0M.AssertModel(models[2],_testData[33], false);
                        BytetinyintE0M.AssertModel(models[3],_testData[34], false);
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
                var models = ((IByteSingleTypetinyint)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BytetinyintE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IByteSingleTypetinyint)this).DbConnectionSTSelectModelBatch(connection, 98, 183))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        BytetinyintE0M.AssertModel(models[0],_testData[17], false);
                        BytetinyintE0M.AssertModel(models[1],_testData[18], false);
                        BytetinyintE0M.AssertModel(models[2],_testData[19], false);
                        BytetinyintE0M.AssertModel(models[3],_testData[20], false);
                        BytetinyintE0M.AssertModel(models[4],_testData[21], false);
                        BytetinyintE0M.AssertModel(models[5],_testData[22], false);
                        BytetinyintE0M.AssertModel(models[6],_testData[23], false);
                        BytetinyintE0M.AssertModel(models[7],_testData[24], false);
                        BytetinyintE0M.AssertModel(models[8],_testData[25], false);
                        BytetinyintE0M.AssertModel(models[9],_testData[26], false);
                        BytetinyintE0M.AssertModel(models[10],_testData[27], false);
                        BytetinyintE0M.AssertModel(models[11],_testData[28], false);
                        BytetinyintE0M.AssertModel(models[12],_testData[29], false);
                        BytetinyintE0M.AssertModel(models[13],_testData[30], false);
                        BytetinyintE0M.AssertModel(models[14],_testData[31], false);
                        BytetinyintE0M.AssertModel(models[15],_testData[32], false);
                        BytetinyintE0M.AssertModel(models[16],_testData[33], false);
                        BytetinyintE0M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        BytetinyintE0M.AssertModel(models[0],_testData[31], false);
                        BytetinyintE0M.AssertModel(models[1],_testData[32], false);
                        BytetinyintE0M.AssertModel(models[2],_testData[33], false);
                        BytetinyintE0M.AssertModel(models[3],_testData[34], false);
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
                await using var cmd = await ((IByteSingleTypetinyint)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IByteSingleTypetinyint)this).SetDbConnectionSelectModelParametrs(cmd, 63);
                var models = await ((IByteSingleTypetinyint)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(25));

                BytetinyintE0M.AssertModel(models[0],_testData[10], false);
                BytetinyintE0M.AssertModel(models[1],_testData[11], false);
                BytetinyintE0M.AssertModel(models[2],_testData[12], false);
                BytetinyintE0M.AssertModel(models[3],_testData[13], false);
                BytetinyintE0M.AssertModel(models[4],_testData[14], false);
                BytetinyintE0M.AssertModel(models[5],_testData[15], false);
                BytetinyintE0M.AssertModel(models[6],_testData[16], false);
                BytetinyintE0M.AssertModel(models[7],_testData[17], false);
                BytetinyintE0M.AssertModel(models[8],_testData[18], false);
                BytetinyintE0M.AssertModel(models[9],_testData[19], false);
                BytetinyintE0M.AssertModel(models[10],_testData[20], false);
                BytetinyintE0M.AssertModel(models[11],_testData[21], false);
                BytetinyintE0M.AssertModel(models[12],_testData[22], false);
                BytetinyintE0M.AssertModel(models[13],_testData[23], false);
                BytetinyintE0M.AssertModel(models[14],_testData[24], false);
                BytetinyintE0M.AssertModel(models[15],_testData[25], false);
                BytetinyintE0M.AssertModel(models[16],_testData[26], false);
                BytetinyintE0M.AssertModel(models[17],_testData[27], false);
                BytetinyintE0M.AssertModel(models[18],_testData[28], false);
                BytetinyintE0M.AssertModel(models[19],_testData[29], false);
                BytetinyintE0M.AssertModel(models[20],_testData[30], false);
                BytetinyintE0M.AssertModel(models[21],_testData[31], false);
                BytetinyintE0M.AssertModel(models[22],_testData[32], false);
                BytetinyintE0M.AssertModel(models[23],_testData[33], false);
                BytetinyintE0M.AssertModel(models[24],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IByteSingleTypetinyint)this).CreateDbConnectionSelectModelCommand(connection);
                ((IByteSingleTypetinyint)this).SetDbConnectionSelectModelParametrs(cmd, 165);
                var models =  ((IByteSingleTypetinyint)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(8));

                BytetinyintE0M.AssertModel(models[0],_testData[27], false);
                BytetinyintE0M.AssertModel(models[1],_testData[28], false);
                BytetinyintE0M.AssertModel(models[2],_testData[29], false);
                BytetinyintE0M.AssertModel(models[3],_testData[30], false);
                BytetinyintE0M.AssertModel(models[4],_testData[31], false);
                BytetinyintE0M.AssertModel(models[5],_testData[32], false);
                BytetinyintE0M.AssertModel(models[6],_testData[33], false);
                BytetinyintE0M.AssertModel(models[7],_testData[34], false);
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
FROM dbo.bytetinyinte0m m
LEFT JOIN dbo.bytetinyinte0mi mi ON mi.id = m.bytetinyinte0mi_id
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
            asPartInterface: typeof(IByteSingleTypetinyint))]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IByteSingleTypetinyint)this).DbConnectionSelectModelToObjArrAsync(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((210)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((218)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((3)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((160)));//InnerModel.Value

                Assert.That((System.Byte?)model[4], Is.EqualTo((0)));//InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((223)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((83)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((152)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((219)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((139)));//InnerModel.Value

                Assert.That((System.Byte?)model[4], Is.EqualTo((23)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((217)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((65)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((242)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((11)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((166)));//InnerModel.Value

                Assert.That((System.Byte?)model[4], Is.EqualTo((54)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((175)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((90)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((127)));//InnerModel.Value

                Assert.That((System.Byte?)model[4], Is.EqualTo((132)));//InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((196)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((91)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((142)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((7)));//InnerModel.Value

                Assert.That((System.Byte?)model[4], Is.EqualTo((199)));//InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((124)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((224)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((123)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((188)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((58)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((198)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((50)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((38)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((134)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Byte?)model[5], Is.EqualTo((178)));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((83)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((161)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((3)));//InnerModel.Value

                Assert.That((System.Byte?)model[4], Is.EqualTo((146)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((105)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((96)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((140)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Byte?)model[5], Is.EqualTo((149)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((58)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((196)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((206)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((161)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((149)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((203)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((141)));//InnerModel.Value

                Assert.That((System.Byte?)model[4], Is.EqualTo((22)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((207)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((149)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((109)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((102)));//InnerModel.Value

                Assert.That((System.Byte?)model[4], Is.EqualTo((125)));//InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((2)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((157)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((215)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((2)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((161)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((97)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((70)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((194)));//InnerModel.Value

                Assert.That((System.Byte?)model[4], Is.EqualTo((185)));//InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((150)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((165)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((101)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((167)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((106)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((74)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((176)));//InnerModel.Value

                Assert.That((System.Byte?)model[4], Is.EqualTo((241)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((174)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((30)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((16)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((178)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((204)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((81)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((192)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Byte?)model[5], Is.EqualTo((145)));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((183)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((55)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((88)));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((192)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((251)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((84)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((252)));//InnerModel.Value

                Assert.That((System.Byte?)model[4], Is.EqualTo((155)));//InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((96)));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((200)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((115)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((206)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((222)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((93)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((90)));//InnerModel.Value

                Assert.That((System.Byte?)model[4], Is.EqualTo((170)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((209)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((230)));//Value

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
                var models =  ((IByteSingleTypetinyint)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((210)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((218)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((3)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((160)));//InnerModel.Value

                Assert.That((System.Byte?)model[4], Is.EqualTo((0)));//InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((223)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((83)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((152)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((219)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((139)));//InnerModel.Value

                Assert.That((System.Byte?)model[4], Is.EqualTo((23)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((217)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((65)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((242)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((11)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((166)));//InnerModel.Value

                Assert.That((System.Byte?)model[4], Is.EqualTo((54)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((175)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((90)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((127)));//InnerModel.Value

                Assert.That((System.Byte?)model[4], Is.EqualTo((132)));//InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((196)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((91)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((142)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((7)));//InnerModel.Value

                Assert.That((System.Byte?)model[4], Is.EqualTo((199)));//InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((124)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((224)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((123)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((188)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((58)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((198)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((50)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((38)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((134)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Byte?)model[5], Is.EqualTo((178)));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((83)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((161)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((3)));//InnerModel.Value

                Assert.That((System.Byte?)model[4], Is.EqualTo((146)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((105)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((96)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((140)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Byte?)model[5], Is.EqualTo((149)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((58)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((196)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((206)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((161)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((149)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((203)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((141)));//InnerModel.Value

                Assert.That((System.Byte?)model[4], Is.EqualTo((22)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((207)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((149)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((109)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((102)));//InnerModel.Value

                Assert.That((System.Byte?)model[4], Is.EqualTo((125)));//InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((2)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((157)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((215)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((2)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((161)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((97)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((70)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((194)));//InnerModel.Value

                Assert.That((System.Byte?)model[4], Is.EqualTo((185)));//InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((150)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((165)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((101)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((167)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((106)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((74)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((176)));//InnerModel.Value

                Assert.That((System.Byte?)model[4], Is.EqualTo((241)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((174)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((30)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((16)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((178)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((204)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((81)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((192)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Byte?)model[5], Is.EqualTo((145)));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((183)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((55)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((88)));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((192)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((251)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((84)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((252)));//InnerModel.Value

                Assert.That((System.Byte?)model[4], Is.EqualTo((155)));//InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((96)));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((200)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((115)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((206)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((222)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((93)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((90)));//InnerModel.Value

                Assert.That((System.Byte?)model[4], Is.EqualTo((170)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((209)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((230)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

#endregion

    }
}

