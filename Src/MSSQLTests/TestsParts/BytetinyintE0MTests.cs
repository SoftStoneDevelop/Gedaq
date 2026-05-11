

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
    Id = 1,
    Value = 235,
    ModelInner = null,
    NullableValue = 88,
},
            new BytetinyintE0M
{
    Id = 4,
    Value = 21,
    ModelInner = new BytetinyintE0MI
{
    Id = 2,
    Value = 169,
    NullableValue = 224,
},
    NullableValue = 152,
},
            new BytetinyintE0M
{
    Id = 7,
    Value = 62,
    ModelInner = null,
    NullableValue = null,
},
            new BytetinyintE0M
{
    Id = 14,
    Value = 159,
    ModelInner = new BytetinyintE0MI
{
    Id = 8,
    Value = 48,
    NullableValue = null,
},
    NullableValue = 232,
},
            new BytetinyintE0M
{
    Id = 22,
    Value = 138,
    ModelInner = null,
    NullableValue = 195,
},
            new BytetinyintE0M
{
    Id = 27,
    Value = 91,
    ModelInner = new BytetinyintE0MI
{
    Id = 15,
    Value = 135,
    NullableValue = null,
},
    NullableValue = null,
},
            new BytetinyintE0M
{
    Id = 34,
    Value = 1,
    ModelInner = null,
    NullableValue = null,
},
            new BytetinyintE0M
{
    Id = 40,
    Value = 227,
    ModelInner = new BytetinyintE0MI
{
    Id = 16,
    Value = 164,
    NullableValue = null,
},
    NullableValue = null,
},
            new BytetinyintE0M
{
    Id = 47,
    Value = 157,
    ModelInner = null,
    NullableValue = 185,
},
            new BytetinyintE0M
{
    Id = 56,
    Value = 118,
    ModelInner = new BytetinyintE0MI
{
    Id = 21,
    Value = 91,
    NullableValue = 24,
},
    NullableValue = null,
},
            new BytetinyintE0M
{
    Id = 60,
    Value = 3,
    ModelInner = null,
    NullableValue = 217,
},
            new BytetinyintE0M
{
    Id = 62,
    Value = 51,
    ModelInner = new BytetinyintE0MI
{
    Id = 29,
    Value = 20,
    NullableValue = null,
},
    NullableValue = 69,
},
            new BytetinyintE0M
{
    Id = 70,
    Value = 230,
    ModelInner = null,
    NullableValue = 85,
},
            new BytetinyintE0M
{
    Id = 79,
    Value = 109,
    ModelInner = new BytetinyintE0MI
{
    Id = 34,
    Value = 181,
    NullableValue = null,
},
    NullableValue = null,
},
            new BytetinyintE0M
{
    Id = 84,
    Value = 122,
    ModelInner = null,
    NullableValue = null,
},
            new BytetinyintE0M
{
    Id = 90,
    Value = 149,
    ModelInner = new BytetinyintE0MI
{
    Id = 37,
    Value = 130,
    NullableValue = null,
},
    NullableValue = null,
},
            new BytetinyintE0M
{
    Id = 92,
    Value = 153,
    ModelInner = null,
    NullableValue = 207,
},
            new BytetinyintE0M
{
    Id = 97,
    Value = 193,
    ModelInner = new BytetinyintE0MI
{
    Id = 44,
    Value = 48,
    NullableValue = null,
},
    NullableValue = 219,
},
            new BytetinyintE0M
{
    Id = 105,
    Value = 57,
    ModelInner = null,
    NullableValue = 246,
},
            new BytetinyintE0M
{
    Id = 107,
    Value = 4,
    ModelInner = new BytetinyintE0MI
{
    Id = 49,
    Value = 18,
    NullableValue = 31,
},
    NullableValue = 242,
},
            new BytetinyintE0M
{
    Id = 109,
    Value = 220,
    ModelInner = null,
    NullableValue = null,
},
            new BytetinyintE0M
{
    Id = 111,
    Value = 174,
    ModelInner = new BytetinyintE0MI
{
    Id = 57,
    Value = 103,
    NullableValue = null,
},
    NullableValue = 1,
},
            new BytetinyintE0M
{
    Id = 115,
    Value = 203,
    ModelInner = null,
    NullableValue = 228,
},
            new BytetinyintE0M
{
    Id = 117,
    Value = 48,
    ModelInner = new BytetinyintE0MI
{
    Id = 65,
    Value = 23,
    NullableValue = null,
},
    NullableValue = 191,
},
            new BytetinyintE0M
{
    Id = 123,
    Value = 158,
    ModelInner = null,
    NullableValue = null,
},
            new BytetinyintE0M
{
    Id = 129,
    Value = 24,
    ModelInner = new BytetinyintE0MI
{
    Id = 66,
    Value = 11,
    NullableValue = null,
},
    NullableValue = null,
},
            new BytetinyintE0M
{
    Id = 135,
    Value = 191,
    ModelInner = null,
    NullableValue = 247,
},
            new BytetinyintE0M
{
    Id = 141,
    Value = 173,
    ModelInner = new BytetinyintE0MI
{
    Id = 74,
    Value = 165,
    NullableValue = null,
},
    NullableValue = null,
},
            new BytetinyintE0M
{
    Id = 148,
    Value = 153,
    ModelInner = null,
    NullableValue = 13,
},
            new BytetinyintE0M
{
    Id = 152,
    Value = 121,
    ModelInner = new BytetinyintE0MI
{
    Id = 76,
    Value = 15,
    NullableValue = 115,
},
    NullableValue = null,
},
            new BytetinyintE0M
{
    Id = 158,
    Value = 42,
    ModelInner = null,
    NullableValue = null,
},
            new BytetinyintE0M
{
    Id = 159,
    Value = 87,
    ModelInner = new BytetinyintE0MI
{
    Id = 82,
    Value = 241,
    NullableValue = 181,
},
    NullableValue = 148,
},
            new BytetinyintE0M
{
    Id = 167,
    Value = 98,
    ModelInner = null,
    NullableValue = 7,
},
            new BytetinyintE0M
{
    Id = 173,
    Value = 230,
    ModelInner = new BytetinyintE0MI
{
    Id = 88,
    Value = 215,
    NullableValue = null,
},
    NullableValue = null,
},
            new BytetinyintE0M
{
    Id = 176,
    Value = 192,
    ModelInner = null,
    NullableValue = 252,
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
                parametr1.Value = 97;
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
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatBytetinyintE0M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatBytetinyintE0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[13],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 60;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 90;
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
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatBytetinyintE0M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[18],_testData[34], false);
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
                parametr1.Value = 97;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 107;
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
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatBytetinyintE0M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatBytetinyintE0M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[14],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 7;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 79;
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
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatBytetinyintE0M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                        FlatBytetinyintE0M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[20],_testData[34], false);
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
                parametr1.Value = 117;
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
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatBytetinyintE0M.AssertModel(models[0],_testData[24], false);
                        FlatBytetinyintE0M.AssertModel(models[1],_testData[25], false);
                        FlatBytetinyintE0M.AssertModel(models[2],_testData[26], false);
                        FlatBytetinyintE0M.AssertModel(models[3],_testData[27], false);
                        FlatBytetinyintE0M.AssertModel(models[4],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(models[5],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(models[6],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(models[7],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(models[8],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(models[9],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatBytetinyintE0M.AssertModel(models[0],_testData[18], false);
                        FlatBytetinyintE0M.AssertModel(models[1],_testData[19], false);
                        FlatBytetinyintE0M.AssertModel(models[2],_testData[20], false);
                        FlatBytetinyintE0M.AssertModel(models[3],_testData[21], false);
                        FlatBytetinyintE0M.AssertModel(models[4],_testData[22], false);
                        FlatBytetinyintE0M.AssertModel(models[5],_testData[23], false);
                        FlatBytetinyintE0M.AssertModel(models[6],_testData[24], false);
                        FlatBytetinyintE0M.AssertModel(models[7],_testData[25], false);
                        FlatBytetinyintE0M.AssertModel(models[8],_testData[26], false);
                        FlatBytetinyintE0M.AssertModel(models[9],_testData[27], false);
                        FlatBytetinyintE0M.AssertModel(models[10],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(models[11],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(models[12],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(models[13],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(models[14],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(models[15],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(models[16],_testData[34], false);
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
                parametr1.Value = 47;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 4;
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
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                        FlatBytetinyintE0M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatBytetinyintE0M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[32],_testData[34], false);
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
                parametr1.Value = 47;
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
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatBytetinyintE0M.AssertModel(models[0],_testData[9], false);
                        FlatBytetinyintE0M.AssertModel(models[1],_testData[10], false);
                        FlatBytetinyintE0M.AssertModel(models[2],_testData[11], false);
                        FlatBytetinyintE0M.AssertModel(models[3],_testData[12], false);
                        FlatBytetinyintE0M.AssertModel(models[4],_testData[13], false);
                        FlatBytetinyintE0M.AssertModel(models[5],_testData[14], false);
                        FlatBytetinyintE0M.AssertModel(models[6],_testData[15], false);
                        FlatBytetinyintE0M.AssertModel(models[7],_testData[16], false);
                        FlatBytetinyintE0M.AssertModel(models[8],_testData[17], false);
                        FlatBytetinyintE0M.AssertModel(models[9],_testData[18], false);
                        FlatBytetinyintE0M.AssertModel(models[10],_testData[19], false);
                        FlatBytetinyintE0M.AssertModel(models[11],_testData[20], false);
                        FlatBytetinyintE0M.AssertModel(models[12],_testData[21], false);
                        FlatBytetinyintE0M.AssertModel(models[13],_testData[22], false);
                        FlatBytetinyintE0M.AssertModel(models[14],_testData[23], false);
                        FlatBytetinyintE0M.AssertModel(models[15],_testData[24], false);
                        FlatBytetinyintE0M.AssertModel(models[16],_testData[25], false);
                        FlatBytetinyintE0M.AssertModel(models[17],_testData[26], false);
                        FlatBytetinyintE0M.AssertModel(models[18],_testData[27], false);
                        FlatBytetinyintE0M.AssertModel(models[19],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(models[20],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(models[21],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(models[22],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(models[23],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(models[24],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatBytetinyintE0M.AssertModel(models[0],_testData[20], false);
                        FlatBytetinyintE0M.AssertModel(models[1],_testData[21], false);
                        FlatBytetinyintE0M.AssertModel(models[2],_testData[22], false);
                        FlatBytetinyintE0M.AssertModel(models[3],_testData[23], false);
                        FlatBytetinyintE0M.AssertModel(models[4],_testData[24], false);
                        FlatBytetinyintE0M.AssertModel(models[5],_testData[25], false);
                        FlatBytetinyintE0M.AssertModel(models[6],_testData[26], false);
                        FlatBytetinyintE0M.AssertModel(models[7],_testData[27], false);
                        FlatBytetinyintE0M.AssertModel(models[8],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(models[9],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(models[10],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(models[11],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(models[12],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(models[13],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(models[14],_testData[34], false);
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
                parametr1.Value = 109;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 1;
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
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                        FlatBytetinyintE0M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[13],_testData[34], false);
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
                parametr1.Value = 109;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 34;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IByteSingleTypetinyint)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        BytetinyintE0M.AssertModel(models[0],_testData[21], false);
                        BytetinyintE0M.AssertModel(models[1],_testData[22], false);
                        BytetinyintE0M.AssertModel(models[2],_testData[23], false);
                        BytetinyintE0M.AssertModel(models[3],_testData[24], false);
                        BytetinyintE0M.AssertModel(models[4],_testData[25], false);
                        BytetinyintE0M.AssertModel(models[5],_testData[26], false);
                        BytetinyintE0M.AssertModel(models[6],_testData[27], false);
                        BytetinyintE0M.AssertModel(models[7],_testData[28], false);
                        BytetinyintE0M.AssertModel(models[8],_testData[29], false);
                        BytetinyintE0M.AssertModel(models[9],_testData[30], false);
                        BytetinyintE0M.AssertModel(models[10],_testData[31], false);
                        BytetinyintE0M.AssertModel(models[11],_testData[32], false);
                        BytetinyintE0M.AssertModel(models[12],_testData[33], false);
                        BytetinyintE0M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                parametr1.Value = 62;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 7;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IByteSingleTypetinyint)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        BytetinyintE0M.AssertModel(models[0],_testData[12], false);
                        BytetinyintE0M.AssertModel(models[1],_testData[13], false);
                        BytetinyintE0M.AssertModel(models[2],_testData[14], false);
                        BytetinyintE0M.AssertModel(models[3],_testData[15], false);
                        BytetinyintE0M.AssertModel(models[4],_testData[16], false);
                        BytetinyintE0M.AssertModel(models[5],_testData[17], false);
                        BytetinyintE0M.AssertModel(models[6],_testData[18], false);
                        BytetinyintE0M.AssertModel(models[7],_testData[19], false);
                        BytetinyintE0M.AssertModel(models[8],_testData[20], false);
                        BytetinyintE0M.AssertModel(models[9],_testData[21], false);
                        BytetinyintE0M.AssertModel(models[10],_testData[22], false);
                        BytetinyintE0M.AssertModel(models[11],_testData[23], false);
                        BytetinyintE0M.AssertModel(models[12],_testData[24], false);
                        BytetinyintE0M.AssertModel(models[13],_testData[25], false);
                        BytetinyintE0M.AssertModel(models[14],_testData[26], false);
                        BytetinyintE0M.AssertModel(models[15],_testData[27], false);
                        BytetinyintE0M.AssertModel(models[16],_testData[28], false);
                        BytetinyintE0M.AssertModel(models[17],_testData[29], false);
                        BytetinyintE0M.AssertModel(models[18],_testData[30], false);
                        BytetinyintE0M.AssertModel(models[19],_testData[31], false);
                        BytetinyintE0M.AssertModel(models[20],_testData[32], false);
                        BytetinyintE0M.AssertModel(models[21],_testData[33], false);
                        BytetinyintE0M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        BytetinyintE0M.AssertModel(models[0],_testData[3], false);
                        BytetinyintE0M.AssertModel(models[1],_testData[4], false);
                        BytetinyintE0M.AssertModel(models[2],_testData[5], false);
                        BytetinyintE0M.AssertModel(models[3],_testData[6], false);
                        BytetinyintE0M.AssertModel(models[4],_testData[7], false);
                        BytetinyintE0M.AssertModel(models[5],_testData[8], false);
                        BytetinyintE0M.AssertModel(models[6],_testData[9], false);
                        BytetinyintE0M.AssertModel(models[7],_testData[10], false);
                        BytetinyintE0M.AssertModel(models[8],_testData[11], false);
                        BytetinyintE0M.AssertModel(models[9],_testData[12], false);
                        BytetinyintE0M.AssertModel(models[10],_testData[13], false);
                        BytetinyintE0M.AssertModel(models[11],_testData[14], false);
                        BytetinyintE0M.AssertModel(models[12],_testData[15], false);
                        BytetinyintE0M.AssertModel(models[13],_testData[16], false);
                        BytetinyintE0M.AssertModel(models[14],_testData[17], false);
                        BytetinyintE0M.AssertModel(models[15],_testData[18], false);
                        BytetinyintE0M.AssertModel(models[16],_testData[19], false);
                        BytetinyintE0M.AssertModel(models[17],_testData[20], false);
                        BytetinyintE0M.AssertModel(models[18],_testData[21], false);
                        BytetinyintE0M.AssertModel(models[19],_testData[22], false);
                        BytetinyintE0M.AssertModel(models[20],_testData[23], false);
                        BytetinyintE0M.AssertModel(models[21],_testData[24], false);
                        BytetinyintE0M.AssertModel(models[22],_testData[25], false);
                        BytetinyintE0M.AssertModel(models[23],_testData[26], false);
                        BytetinyintE0M.AssertModel(models[24],_testData[27], false);
                        BytetinyintE0M.AssertModel(models[25],_testData[28], false);
                        BytetinyintE0M.AssertModel(models[26],_testData[29], false);
                        BytetinyintE0M.AssertModel(models[27],_testData[30], false);
                        BytetinyintE0M.AssertModel(models[28],_testData[31], false);
                        BytetinyintE0M.AssertModel(models[29],_testData[32], false);
                        BytetinyintE0M.AssertModel(models[30],_testData[33], false);
                        BytetinyintE0M.AssertModel(models[31],_testData[34], false);
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
                await ((IByteSingleTypetinyint)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 92, query1, 148, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatBytetinyintE0M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatBytetinyintE0M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[5],_testData[34], false);
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
                await ((IByteSingleTypetinyint)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 92, query1, 27, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatBytetinyintE0M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatBytetinyintE0M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[28],_testData[34], false);
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
                 ((IByteSingleTypetinyint)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 1, query1, 158, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatBytetinyintE0M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[3],_testData[34], false);
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
                 ((IByteSingleTypetinyint)this).DbConnectionMMDynQuerySelectModelBatch(connection, 84, query1, 117, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatBytetinyintE0M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatBytetinyintE0M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatBytetinyintE0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[10],_testData[34], false);
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
                foreach(var batchResult in await ((IByteSingleTypetinyint)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 111, query1, 79, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatBytetinyintE0M.AssertModel(models[0],_testData[22], false);
                        FlatBytetinyintE0M.AssertModel(models[1],_testData[23], false);
                        FlatBytetinyintE0M.AssertModel(models[2],_testData[24], false);
                        FlatBytetinyintE0M.AssertModel(models[3],_testData[25], false);
                        FlatBytetinyintE0M.AssertModel(models[4],_testData[26], false);
                        FlatBytetinyintE0M.AssertModel(models[5],_testData[27], false);
                        FlatBytetinyintE0M.AssertModel(models[6],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(models[7],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(models[8],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(models[9],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(models[10],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(models[11],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatBytetinyintE0M.AssertModel(models[0],_testData[14], false);
                        FlatBytetinyintE0M.AssertModel(models[1],_testData[15], false);
                        FlatBytetinyintE0M.AssertModel(models[2],_testData[16], false);
                        FlatBytetinyintE0M.AssertModel(models[3],_testData[17], false);
                        FlatBytetinyintE0M.AssertModel(models[4],_testData[18], false);
                        FlatBytetinyintE0M.AssertModel(models[5],_testData[19], false);
                        FlatBytetinyintE0M.AssertModel(models[6],_testData[20], false);
                        FlatBytetinyintE0M.AssertModel(models[7],_testData[21], false);
                        FlatBytetinyintE0M.AssertModel(models[8],_testData[22], false);
                        FlatBytetinyintE0M.AssertModel(models[9],_testData[23], false);
                        FlatBytetinyintE0M.AssertModel(models[10],_testData[24], false);
                        FlatBytetinyintE0M.AssertModel(models[11],_testData[25], false);
                        FlatBytetinyintE0M.AssertModel(models[12],_testData[26], false);
                        FlatBytetinyintE0M.AssertModel(models[13],_testData[27], false);
                        FlatBytetinyintE0M.AssertModel(models[14],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(models[15],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(models[16],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(models[17],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(models[18],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(models[19],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(models[20],_testData[34], false);
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
                await ((IByteSingleTypetinyint)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 105, query1, 22, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatBytetinyintE0M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[29],_testData[34], false);
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
                foreach(var batchResult in  ((IByteSingleTypetinyint)this).DbConnectionSTDynQuerySelectModelBatch(connection, 90, query1, 70, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatBytetinyintE0M.AssertModel(models[0],_testData[16], false);
                        FlatBytetinyintE0M.AssertModel(models[1],_testData[17], false);
                        FlatBytetinyintE0M.AssertModel(models[2],_testData[18], false);
                        FlatBytetinyintE0M.AssertModel(models[3],_testData[19], false);
                        FlatBytetinyintE0M.AssertModel(models[4],_testData[20], false);
                        FlatBytetinyintE0M.AssertModel(models[5],_testData[21], false);
                        FlatBytetinyintE0M.AssertModel(models[6],_testData[22], false);
                        FlatBytetinyintE0M.AssertModel(models[7],_testData[23], false);
                        FlatBytetinyintE0M.AssertModel(models[8],_testData[24], false);
                        FlatBytetinyintE0M.AssertModel(models[9],_testData[25], false);
                        FlatBytetinyintE0M.AssertModel(models[10],_testData[26], false);
                        FlatBytetinyintE0M.AssertModel(models[11],_testData[27], false);
                        FlatBytetinyintE0M.AssertModel(models[12],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(models[13],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(models[14],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(models[15],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(models[16],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(models[17],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatBytetinyintE0M.AssertModel(models[0],_testData[13], false);
                        FlatBytetinyintE0M.AssertModel(models[1],_testData[14], false);
                        FlatBytetinyintE0M.AssertModel(models[2],_testData[15], false);
                        FlatBytetinyintE0M.AssertModel(models[3],_testData[16], false);
                        FlatBytetinyintE0M.AssertModel(models[4],_testData[17], false);
                        FlatBytetinyintE0M.AssertModel(models[5],_testData[18], false);
                        FlatBytetinyintE0M.AssertModel(models[6],_testData[19], false);
                        FlatBytetinyintE0M.AssertModel(models[7],_testData[20], false);
                        FlatBytetinyintE0M.AssertModel(models[8],_testData[21], false);
                        FlatBytetinyintE0M.AssertModel(models[9],_testData[22], false);
                        FlatBytetinyintE0M.AssertModel(models[10],_testData[23], false);
                        FlatBytetinyintE0M.AssertModel(models[11],_testData[24], false);
                        FlatBytetinyintE0M.AssertModel(models[12],_testData[25], false);
                        FlatBytetinyintE0M.AssertModel(models[13],_testData[26], false);
                        FlatBytetinyintE0M.AssertModel(models[14],_testData[27], false);
                        FlatBytetinyintE0M.AssertModel(models[15],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(models[16],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(models[17],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(models[18],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(models[19],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(models[20],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(models[21],_testData[34], false);
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
                 ((IByteSingleTypetinyint)this).DbConnectionDynQuerySelectModelBatch(connection, 141, query1, 34, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatBytetinyintE0M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(firstItems1[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatBytetinyintE0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatBytetinyintE0M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatBytetinyintE0M.AssertModel(secondItems2[27],_testData[34], false);
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
                foreach(var batchResult in await ((IByteSingleTypetinyint)this).DbConnectionSTSelectModelBatchAsync(connection, 47, 135))
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
                foreach(var batchResult in  ((IByteSingleTypetinyint)this).DbConnectionSTSelectModelBatch(connection, 34, 1))
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
                        Assert.That(models, Has.Count.EqualTo(34));

                        BytetinyintE0M.AssertModel(models[0],_testData[1], false);
                        BytetinyintE0M.AssertModel(models[1],_testData[2], false);
                        BytetinyintE0M.AssertModel(models[2],_testData[3], false);
                        BytetinyintE0M.AssertModel(models[3],_testData[4], false);
                        BytetinyintE0M.AssertModel(models[4],_testData[5], false);
                        BytetinyintE0M.AssertModel(models[5],_testData[6], false);
                        BytetinyintE0M.AssertModel(models[6],_testData[7], false);
                        BytetinyintE0M.AssertModel(models[7],_testData[8], false);
                        BytetinyintE0M.AssertModel(models[8],_testData[9], false);
                        BytetinyintE0M.AssertModel(models[9],_testData[10], false);
                        BytetinyintE0M.AssertModel(models[10],_testData[11], false);
                        BytetinyintE0M.AssertModel(models[11],_testData[12], false);
                        BytetinyintE0M.AssertModel(models[12],_testData[13], false);
                        BytetinyintE0M.AssertModel(models[13],_testData[14], false);
                        BytetinyintE0M.AssertModel(models[14],_testData[15], false);
                        BytetinyintE0M.AssertModel(models[15],_testData[16], false);
                        BytetinyintE0M.AssertModel(models[16],_testData[17], false);
                        BytetinyintE0M.AssertModel(models[17],_testData[18], false);
                        BytetinyintE0M.AssertModel(models[18],_testData[19], false);
                        BytetinyintE0M.AssertModel(models[19],_testData[20], false);
                        BytetinyintE0M.AssertModel(models[20],_testData[21], false);
                        BytetinyintE0M.AssertModel(models[21],_testData[22], false);
                        BytetinyintE0M.AssertModel(models[22],_testData[23], false);
                        BytetinyintE0M.AssertModel(models[23],_testData[24], false);
                        BytetinyintE0M.AssertModel(models[24],_testData[25], false);
                        BytetinyintE0M.AssertModel(models[25],_testData[26], false);
                        BytetinyintE0M.AssertModel(models[26],_testData[27], false);
                        BytetinyintE0M.AssertModel(models[27],_testData[28], false);
                        BytetinyintE0M.AssertModel(models[28],_testData[29], false);
                        BytetinyintE0M.AssertModel(models[29],_testData[30], false);
                        BytetinyintE0M.AssertModel(models[30],_testData[31], false);
                        BytetinyintE0M.AssertModel(models[31],_testData[32], false);
                        BytetinyintE0M.AssertModel(models[32],_testData[33], false);
                        BytetinyintE0M.AssertModel(models[33],_testData[34], false);
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
                ((IByteSingleTypetinyint)this).SetDbConnectionSelectModelParametrs(cmd, 56);
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
                ((IByteSingleTypetinyint)this).SetDbConnectionSelectModelParametrs(cmd, 62);
                var models =  ((IByteSingleTypetinyint)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(23));

                BytetinyintE0M.AssertModel(models[0],_testData[12], false);
                BytetinyintE0M.AssertModel(models[1],_testData[13], false);
                BytetinyintE0M.AssertModel(models[2],_testData[14], false);
                BytetinyintE0M.AssertModel(models[3],_testData[15], false);
                BytetinyintE0M.AssertModel(models[4],_testData[16], false);
                BytetinyintE0M.AssertModel(models[5],_testData[17], false);
                BytetinyintE0M.AssertModel(models[6],_testData[18], false);
                BytetinyintE0M.AssertModel(models[7],_testData[19], false);
                BytetinyintE0M.AssertModel(models[8],_testData[20], false);
                BytetinyintE0M.AssertModel(models[9],_testData[21], false);
                BytetinyintE0M.AssertModel(models[10],_testData[22], false);
                BytetinyintE0M.AssertModel(models[11],_testData[23], false);
                BytetinyintE0M.AssertModel(models[12],_testData[24], false);
                BytetinyintE0M.AssertModel(models[13],_testData[25], false);
                BytetinyintE0M.AssertModel(models[14],_testData[26], false);
                BytetinyintE0M.AssertModel(models[15],_testData[27], false);
                BytetinyintE0M.AssertModel(models[16],_testData[28], false);
                BytetinyintE0M.AssertModel(models[17],_testData[29], false);
                BytetinyintE0M.AssertModel(models[18],_testData[30], false);
                BytetinyintE0M.AssertModel(models[19],_testData[31], false);
                BytetinyintE0M.AssertModel(models[20],_testData[32], false);
                BytetinyintE0M.AssertModel(models[21],_testData[33], false);
                BytetinyintE0M.AssertModel(models[22],_testData[34], false);
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
                Assert.That((System.Int32)model[0], Is.EqualTo((1)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((235)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((88)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((4)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((21)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((169)));//InnerModel.Value

                Assert.That((System.Byte?)model[4], Is.EqualTo((224)));//InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((152)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((62)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((159)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((48)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Byte?)model[5], Is.EqualTo((232)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((138)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((195)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((91)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((135)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((1)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((227)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((164)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((157)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((185)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((118)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((21)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((91)));//InnerModel.Value

                Assert.That((System.Byte?)model[4], Is.EqualTo((24)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((3)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((217)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((51)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((20)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Byte?)model[5], Is.EqualTo((69)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((230)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((85)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((109)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((181)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((122)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((149)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((130)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((153)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((207)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((193)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((48)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Byte?)model[5], Is.EqualTo((219)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((57)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((246)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((4)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((18)));//InnerModel.Value

                Assert.That((System.Byte?)model[4], Is.EqualTo((31)));//InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((242)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((220)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((111)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((174)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((103)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Byte?)model[5], Is.EqualTo((1)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((203)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((228)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((48)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((23)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Byte?)model[5], Is.EqualTo((191)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((158)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((24)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((11)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((191)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((247)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((173)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((74)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((165)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((153)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((13)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((152)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((121)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((76)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((15)));//InnerModel.Value

                Assert.That((System.Byte?)model[4], Is.EqualTo((115)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((158)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((42)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((159)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((87)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((82)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((241)));//InnerModel.Value

                Assert.That((System.Byte?)model[4], Is.EqualTo((181)));//InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((148)));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((167)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((98)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((7)));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((173)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((230)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((88)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((215)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((176)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((192)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((252)));

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
                Assert.That((System.Int32)model[0], Is.EqualTo((1)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((235)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((88)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((4)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((21)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((169)));//InnerModel.Value

                Assert.That((System.Byte?)model[4], Is.EqualTo((224)));//InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((152)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((62)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((159)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((48)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Byte?)model[5], Is.EqualTo((232)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((138)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((195)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((91)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((135)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((1)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((227)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((164)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((157)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((185)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((118)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((21)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((91)));//InnerModel.Value

                Assert.That((System.Byte?)model[4], Is.EqualTo((24)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((3)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((217)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((51)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((20)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Byte?)model[5], Is.EqualTo((69)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((230)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((85)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((109)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((181)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((122)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((149)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((130)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((153)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((207)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((193)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((48)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Byte?)model[5], Is.EqualTo((219)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((57)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((246)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((4)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((18)));//InnerModel.Value

                Assert.That((System.Byte?)model[4], Is.EqualTo((31)));//InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((242)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((220)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((111)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((174)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((103)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Byte?)model[5], Is.EqualTo((1)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((203)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((228)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((48)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((23)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Byte?)model[5], Is.EqualTo((191)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((158)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((24)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((11)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((191)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((247)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((173)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((74)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((165)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((153)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((13)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((152)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((121)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((76)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((15)));//InnerModel.Value

                Assert.That((System.Byte?)model[4], Is.EqualTo((115)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((158)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((42)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((159)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((87)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((82)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((241)));//InnerModel.Value

                Assert.That((System.Byte?)model[4], Is.EqualTo((181)));//InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((148)));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((167)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((98)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((7)));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((173)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((230)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((88)));//InnerModel.Id
                Assert.That((System.Byte)model[3], Is.EqualTo((215)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((176)));//Id
                Assert.That((System.Byte)model[1], Is.EqualTo((192)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Byte?)model[5], Is.EqualTo((252)));

            }
        }

#endregion

    }
}

