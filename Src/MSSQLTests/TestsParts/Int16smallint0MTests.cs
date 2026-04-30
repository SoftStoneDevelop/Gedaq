

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

        private readonly Int16smallint0M[] _testData = new Int16smallint0M[]
        {
            new Int16smallint0M
{
    Id = 5,
    Value = 29627,
    ModelInner = null,
    NullableValue = 25297,
},
            new Int16smallint0M
{
    Id = 10,
    Value = 14515,
    ModelInner = new Int16smallint0MI
{
    Id = 9,
    Value = 27567,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16smallint0M
{
    Id = 19,
    Value = 13606,
    ModelInner = null,
    NullableValue = 14236,
},
            new Int16smallint0M
{
    Id = 27,
    Value = 24797,
    ModelInner = new Int16smallint0MI
{
    Id = 15,
    Value = 18191,
    NullableValue = null,
},
    NullableValue = 19349,
},
            new Int16smallint0M
{
    Id = 35,
    Value = 9964,
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallint0M
{
    Id = 40,
    Value = 16335,
    ModelInner = new Int16smallint0MI
{
    Id = 23,
    Value = 24145,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16smallint0M
{
    Id = 46,
    Value = 24316,
    ModelInner = null,
    NullableValue = 12740,
},
            new Int16smallint0M
{
    Id = 54,
    Value = 19822,
    ModelInner = new Int16smallint0MI
{
    Id = 31,
    Value = 21707,
    NullableValue = null,
},
    NullableValue = 28249,
},
            new Int16smallint0M
{
    Id = 55,
    Value = 2262,
    ModelInner = null,
    NullableValue = 3586,
},
            new Int16smallint0M
{
    Id = 62,
    Value = 19006,
    ModelInner = new Int16smallint0MI
{
    Id = 36,
    Value = 15527,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16smallint0M
{
    Id = 70,
    Value = 26691,
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallint0M
{
    Id = 78,
    Value = 5787,
    ModelInner = new Int16smallint0MI
{
    Id = 42,
    Value = 28639,
    NullableValue = null,
},
    NullableValue = 9505,
},
            new Int16smallint0M
{
    Id = 81,
    Value = 7171,
    ModelInner = null,
    NullableValue = 8574,
},
            new Int16smallint0M
{
    Id = 82,
    Value = 27405,
    ModelInner = new Int16smallint0MI
{
    Id = 44,
    Value = 7192,
    NullableValue = 4047,
},
    NullableValue = 4217,
},
            new Int16smallint0M
{
    Id = 90,
    Value = 601,
    ModelInner = null,
    NullableValue = 926,
},
            new Int16smallint0M
{
    Id = 95,
    Value = 15557,
    ModelInner = new Int16smallint0MI
{
    Id = 45,
    Value = 28294,
    NullableValue = 15675,
},
    NullableValue = 2691,
},
            new Int16smallint0M
{
    Id = 103,
    Value = 6266,
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallint0M
{
    Id = 104,
    Value = 13834,
    ModelInner = new Int16smallint0MI
{
    Id = 49,
    Value = 10009,
    NullableValue = null,
},
    NullableValue = 17843,
},
            new Int16smallint0M
{
    Id = 113,
    Value = 22462,
    ModelInner = null,
    NullableValue = 616,
},
            new Int16smallint0M
{
    Id = 114,
    Value = 21934,
    ModelInner = new Int16smallint0MI
{
    Id = 50,
    Value = 13771,
    NullableValue = null,
},
    NullableValue = 16112,
},
            new Int16smallint0M
{
    Id = 115,
    Value = 31915,
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallint0M
{
    Id = 119,
    Value = 17482,
    ModelInner = new Int16smallint0MI
{
    Id = 59,
    Value = 28068,
    NullableValue = 2167,
},
    NullableValue = null,
},
            new Int16smallint0M
{
    Id = 127,
    Value = 17305,
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallint0M
{
    Id = 130,
    Value = 32153,
    ModelInner = new Int16smallint0MI
{
    Id = 66,
    Value = 28175,
    NullableValue = 2771,
},
    NullableValue = null,
},
            new Int16smallint0M
{
    Id = 133,
    Value = 8650,
    ModelInner = null,
    NullableValue = 8955,
},
            new Int16smallint0M
{
    Id = 135,
    Value = 1621,
    ModelInner = new Int16smallint0MI
{
    Id = 73,
    Value = 16649,
    NullableValue = 1394,
},
    NullableValue = 9905,
},
            new Int16smallint0M
{
    Id = 137,
    Value = 21204,
    ModelInner = null,
    NullableValue = 19785,
},
            new Int16smallint0M
{
    Id = 144,
    Value = 1309,
    ModelInner = new Int16smallint0MI
{
    Id = 80,
    Value = 19694,
    NullableValue = 22659,
},
    NullableValue = null,
},
            new Int16smallint0M
{
    Id = 152,
    Value = 20651,
    ModelInner = null,
    NullableValue = 29124,
},
            new Int16smallint0M
{
    Id = 159,
    Value = 26009,
    ModelInner = new Int16smallint0MI
{
    Id = 85,
    Value = 2174,
    NullableValue = null,
},
    NullableValue = 882,
},
        };

#endregion

#region InsertModelInner

[Gedaq.SqlClient.Attributes.Query(
            query: @"
INSERT INTO dbo.int16smallint0mi(
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
INSERT INTO dbo.int16smallint0mi(
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

            }
        }

#endregion

#region InsertModel

[Gedaq.SqlClient.Attributes.Query(
            query: @"
INSERT INTO dbo.int16smallint0m(
	id,
    value,
    nullablevalue,
    int16smallint0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @int16smallint0mi_id
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
                parametrName: "int16smallint0mi_id", 
                methodParametrName: "int16smallint0mi_id", 
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
INSERT INTO dbo.int16smallint0m(
	id,
    value,
    nullablevalue,
    int16smallint0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @int16smallint0mi_id
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
                parametrName: "int16smallint0mi_id", 
                methodParametrName: "int16smallint0mi_id", 
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

            }
        }

#endregion

#region Select Models

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt16smallint0M), typeof(FlatInt16smallint0M)],
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
FROM dbo.int16smallint0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt16smallint0M>();
                var models2 = new List<FlatInt16smallint0M>();
                await((IInt16SingleTypesmallint)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt16smallint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt16smallint0M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.int16smallint0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt16smallint0M>();
                var models2 = new List<FlatInt16smallint0M>();
                ((IInt16SingleTypesmallint)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt16smallint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt16smallint0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt16smallint0M)],
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
FROM dbo.int16smallint0m m
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt16smallint0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.int16smallint0m m
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt16smallint0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.int16smallint0m m
LEFT JOIN dbo.int16smallint0mi mi ON mi.id = m.int16smallint0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Int16smallint0M)],
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int16smallint0M.AssertModel(models[i],_testData[i], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int16smallint0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt16smallint0M), typeof(FlatInt16smallint0M)],
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
FROM dbo.int16smallint0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt16smallint0M>();
                var models2 = new List<FlatInt16smallint0M>();
                await((IInt16SingleTypesmallint)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt16smallint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt16smallint0M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.int16smallint0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt16smallint0M>();
                var models2 = new List<FlatInt16smallint0M>();
                ((IInt16SingleTypesmallint)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt16smallint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt16smallint0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt16smallint0M)],
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
FROM dbo.int16smallint0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IInt16SingleTypesmallint)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt16smallint0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.int16smallint0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IInt16SingleTypesmallint)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt16smallint0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.int16smallint0m m
LEFT JOIN dbo.int16smallint0mi mi ON mi.id = m.int16smallint0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Int16smallint0M)],
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int16smallint0M.AssertModel(models[i],_testData[i], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int16smallint0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt16smallint0M), typeof(FlatInt16smallint0M)],
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
FROM dbo.int16smallint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt16smallint0M>();
                var models2 = new List<FlatInt16smallint0M>();
                await((IInt16SingleTypesmallint)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt16smallint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt16smallint0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 130;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 135;
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
FROM dbo.int16smallint0m m
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
FROM dbo.int16smallint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallint0M>();
                var firstItems2 = new List<FlatInt16smallint0M>();
                var secondItems1 = new List<FlatInt16smallint0M>();
                var secondItems2 = new List<FlatInt16smallint0M>();
                await ((IInt16SingleTypesmallint)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatInt16smallint0M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[5],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatInt16smallint0M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[3],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 62;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 135;
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
FROM dbo.int16smallint0m m
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
FROM dbo.int16smallint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallint0M>();
                var firstItems2 = new List<FlatInt16smallint0M>();
                var secondItems1 = new List<FlatInt16smallint0M>();
                await ((IInt16SingleTypesmallint)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatInt16smallint0M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[19],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatInt16smallint0M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[3],_testData[29], false);
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
FROM dbo.int16smallint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt16smallint0M>();
                var models2 = new List<FlatInt16smallint0M>();
                ((IInt16SingleTypesmallint)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt16smallint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt16smallint0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 82;
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
FROM dbo.int16smallint0m m
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
FROM dbo.int16smallint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallint0M>();
                var firstItems2 = new List<FlatInt16smallint0M>();
                var secondItems1 = new List<FlatInt16smallint0M>();
                var secondItems2 = new List<FlatInt16smallint0M>();
                 ((IInt16SingleTypesmallint)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatInt16smallint0M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[15],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatInt16smallint0M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[20],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 104;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 103;
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
FROM dbo.int16smallint0m m
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
FROM dbo.int16smallint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallint0M>();
                var firstItems2 = new List<FlatInt16smallint0M>();
                var secondItems1 = new List<FlatInt16smallint0M>();
                 ((IInt16SingleTypesmallint)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatInt16smallint0M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[11],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatInt16smallint0M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[12],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt16smallint0M)],
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
FROM dbo.int16smallint0m m
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt16smallint0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 103;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 27;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.int16smallint0m m
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
FROM dbo.int16smallint0m m
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
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatInt16smallint0M.AssertModel(models[0],_testData[17], false);
                        FlatInt16smallint0M.AssertModel(models[1],_testData[18], false);
                        FlatInt16smallint0M.AssertModel(models[2],_testData[19], false);
                        FlatInt16smallint0M.AssertModel(models[3],_testData[20], false);
                        FlatInt16smallint0M.AssertModel(models[4],_testData[21], false);
                        FlatInt16smallint0M.AssertModel(models[5],_testData[22], false);
                        FlatInt16smallint0M.AssertModel(models[6],_testData[23], false);
                        FlatInt16smallint0M.AssertModel(models[7],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(models[8],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(models[9],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(models[10],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(models[11],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(models[12],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatInt16smallint0M.AssertModel(models[0],_testData[4], false);
                        FlatInt16smallint0M.AssertModel(models[1],_testData[5], false);
                        FlatInt16smallint0M.AssertModel(models[2],_testData[6], false);
                        FlatInt16smallint0M.AssertModel(models[3],_testData[7], false);
                        FlatInt16smallint0M.AssertModel(models[4],_testData[8], false);
                        FlatInt16smallint0M.AssertModel(models[5],_testData[9], false);
                        FlatInt16smallint0M.AssertModel(models[6],_testData[10], false);
                        FlatInt16smallint0M.AssertModel(models[7],_testData[11], false);
                        FlatInt16smallint0M.AssertModel(models[8],_testData[12], false);
                        FlatInt16smallint0M.AssertModel(models[9],_testData[13], false);
                        FlatInt16smallint0M.AssertModel(models[10],_testData[14], false);
                        FlatInt16smallint0M.AssertModel(models[11],_testData[15], false);
                        FlatInt16smallint0M.AssertModel(models[12],_testData[16], false);
                        FlatInt16smallint0M.AssertModel(models[13],_testData[17], false);
                        FlatInt16smallint0M.AssertModel(models[14],_testData[18], false);
                        FlatInt16smallint0M.AssertModel(models[15],_testData[19], false);
                        FlatInt16smallint0M.AssertModel(models[16],_testData[20], false);
                        FlatInt16smallint0M.AssertModel(models[17],_testData[21], false);
                        FlatInt16smallint0M.AssertModel(models[18],_testData[22], false);
                        FlatInt16smallint0M.AssertModel(models[19],_testData[23], false);
                        FlatInt16smallint0M.AssertModel(models[20],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(models[21],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(models[22],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(models[23],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(models[24],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(models[25],_testData[29], false);
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
                parametr1.Value = 62;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 70;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.int16smallint0m m
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
FROM dbo.int16smallint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallint0M>();
                var secondItems1 = new List<FlatInt16smallint0M>();
                var secondItems2 = new List<FlatInt16smallint0M>();
                await ((IInt16SingleTypesmallint)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                        FlatInt16smallint0M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[19],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatInt16smallint0M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[18],_testData[29], false);
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
FROM dbo.int16smallint0m m
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt16smallint0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 82;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 70;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.int16smallint0m m
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
FROM dbo.int16smallint0m m
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
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatInt16smallint0M.AssertModel(models[0],_testData[14], false);
                        FlatInt16smallint0M.AssertModel(models[1],_testData[15], false);
                        FlatInt16smallint0M.AssertModel(models[2],_testData[16], false);
                        FlatInt16smallint0M.AssertModel(models[3],_testData[17], false);
                        FlatInt16smallint0M.AssertModel(models[4],_testData[18], false);
                        FlatInt16smallint0M.AssertModel(models[5],_testData[19], false);
                        FlatInt16smallint0M.AssertModel(models[6],_testData[20], false);
                        FlatInt16smallint0M.AssertModel(models[7],_testData[21], false);
                        FlatInt16smallint0M.AssertModel(models[8],_testData[22], false);
                        FlatInt16smallint0M.AssertModel(models[9],_testData[23], false);
                        FlatInt16smallint0M.AssertModel(models[10],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(models[11],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(models[12],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(models[13],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(models[14],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatInt16smallint0M.AssertModel(models[0],_testData[11], false);
                        FlatInt16smallint0M.AssertModel(models[1],_testData[12], false);
                        FlatInt16smallint0M.AssertModel(models[2],_testData[13], false);
                        FlatInt16smallint0M.AssertModel(models[3],_testData[14], false);
                        FlatInt16smallint0M.AssertModel(models[4],_testData[15], false);
                        FlatInt16smallint0M.AssertModel(models[5],_testData[16], false);
                        FlatInt16smallint0M.AssertModel(models[6],_testData[17], false);
                        FlatInt16smallint0M.AssertModel(models[7],_testData[18], false);
                        FlatInt16smallint0M.AssertModel(models[8],_testData[19], false);
                        FlatInt16smallint0M.AssertModel(models[9],_testData[20], false);
                        FlatInt16smallint0M.AssertModel(models[10],_testData[21], false);
                        FlatInt16smallint0M.AssertModel(models[11],_testData[22], false);
                        FlatInt16smallint0M.AssertModel(models[12],_testData[23], false);
                        FlatInt16smallint0M.AssertModel(models[13],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(models[14],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(models[15],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(models[16],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(models[17],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(models[18],_testData[29], false);
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
                parametr1.Value = 104;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 55;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.int16smallint0m m
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
FROM dbo.int16smallint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallint0M>();
                var secondItems1 = new List<FlatInt16smallint0M>();
                var secondItems2 = new List<FlatInt16smallint0M>();
                 ((IInt16SingleTypesmallint)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatInt16smallint0M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[11],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatInt16smallint0M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[20],_testData[29], false);
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
FROM dbo.int16smallint0m m
LEFT JOIN dbo.int16smallint0mi mi ON mi.id = m.int16smallint0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Int16smallint0M)],
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int16smallint0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 70;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 144;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt16SingleTypesmallint)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        Int16smallint0M.AssertModel(models[0],_testData[11], false);
                        Int16smallint0M.AssertModel(models[1],_testData[12], false);
                        Int16smallint0M.AssertModel(models[2],_testData[13], false);
                        Int16smallint0M.AssertModel(models[3],_testData[14], false);
                        Int16smallint0M.AssertModel(models[4],_testData[15], false);
                        Int16smallint0M.AssertModel(models[5],_testData[16], false);
                        Int16smallint0M.AssertModel(models[6],_testData[17], false);
                        Int16smallint0M.AssertModel(models[7],_testData[18], false);
                        Int16smallint0M.AssertModel(models[8],_testData[19], false);
                        Int16smallint0M.AssertModel(models[9],_testData[20], false);
                        Int16smallint0M.AssertModel(models[10],_testData[21], false);
                        Int16smallint0M.AssertModel(models[11],_testData[22], false);
                        Int16smallint0M.AssertModel(models[12],_testData[23], false);
                        Int16smallint0M.AssertModel(models[13],_testData[24], false);
                        Int16smallint0M.AssertModel(models[14],_testData[25], false);
                        Int16smallint0M.AssertModel(models[15],_testData[26], false);
                        Int16smallint0M.AssertModel(models[16],_testData[27], false);
                        Int16smallint0M.AssertModel(models[17],_testData[28], false);
                        Int16smallint0M.AssertModel(models[18],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        Int16smallint0M.AssertModel(models[0],_testData[28], false);
                        Int16smallint0M.AssertModel(models[1],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int16smallint0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 35;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 35;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt16SingleTypesmallint)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        Int16smallint0M.AssertModel(models[0],_testData[5], false);
                        Int16smallint0M.AssertModel(models[1],_testData[6], false);
                        Int16smallint0M.AssertModel(models[2],_testData[7], false);
                        Int16smallint0M.AssertModel(models[3],_testData[8], false);
                        Int16smallint0M.AssertModel(models[4],_testData[9], false);
                        Int16smallint0M.AssertModel(models[5],_testData[10], false);
                        Int16smallint0M.AssertModel(models[6],_testData[11], false);
                        Int16smallint0M.AssertModel(models[7],_testData[12], false);
                        Int16smallint0M.AssertModel(models[8],_testData[13], false);
                        Int16smallint0M.AssertModel(models[9],_testData[14], false);
                        Int16smallint0M.AssertModel(models[10],_testData[15], false);
                        Int16smallint0M.AssertModel(models[11],_testData[16], false);
                        Int16smallint0M.AssertModel(models[12],_testData[17], false);
                        Int16smallint0M.AssertModel(models[13],_testData[18], false);
                        Int16smallint0M.AssertModel(models[14],_testData[19], false);
                        Int16smallint0M.AssertModel(models[15],_testData[20], false);
                        Int16smallint0M.AssertModel(models[16],_testData[21], false);
                        Int16smallint0M.AssertModel(models[17],_testData[22], false);
                        Int16smallint0M.AssertModel(models[18],_testData[23], false);
                        Int16smallint0M.AssertModel(models[19],_testData[24], false);
                        Int16smallint0M.AssertModel(models[20],_testData[25], false);
                        Int16smallint0M.AssertModel(models[21],_testData[26], false);
                        Int16smallint0M.AssertModel(models[22],_testData[27], false);
                        Int16smallint0M.AssertModel(models[23],_testData[28], false);
                        Int16smallint0M.AssertModel(models[24],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        Int16smallint0M.AssertModel(models[0],_testData[5], false);
                        Int16smallint0M.AssertModel(models[1],_testData[6], false);
                        Int16smallint0M.AssertModel(models[2],_testData[7], false);
                        Int16smallint0M.AssertModel(models[3],_testData[8], false);
                        Int16smallint0M.AssertModel(models[4],_testData[9], false);
                        Int16smallint0M.AssertModel(models[5],_testData[10], false);
                        Int16smallint0M.AssertModel(models[6],_testData[11], false);
                        Int16smallint0M.AssertModel(models[7],_testData[12], false);
                        Int16smallint0M.AssertModel(models[8],_testData[13], false);
                        Int16smallint0M.AssertModel(models[9],_testData[14], false);
                        Int16smallint0M.AssertModel(models[10],_testData[15], false);
                        Int16smallint0M.AssertModel(models[11],_testData[16], false);
                        Int16smallint0M.AssertModel(models[12],_testData[17], false);
                        Int16smallint0M.AssertModel(models[13],_testData[18], false);
                        Int16smallint0M.AssertModel(models[14],_testData[19], false);
                        Int16smallint0M.AssertModel(models[15],_testData[20], false);
                        Int16smallint0M.AssertModel(models[16],_testData[21], false);
                        Int16smallint0M.AssertModel(models[17],_testData[22], false);
                        Int16smallint0M.AssertModel(models[18],_testData[23], false);
                        Int16smallint0M.AssertModel(models[19],_testData[24], false);
                        Int16smallint0M.AssertModel(models[20],_testData[25], false);
                        Int16smallint0M.AssertModel(models[21],_testData[26], false);
                        Int16smallint0M.AssertModel(models[22],_testData[27], false);
                        Int16smallint0M.AssertModel(models[23],_testData[28], false);
                        Int16smallint0M.AssertModel(models[24],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt16smallint0M), typeof(FlatInt16smallint0M)],
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
FROM dbo.int16smallint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt16smallint0M>();
                var models2 = new List<FlatInt16smallint0M>();
                await((IInt16SingleTypesmallint)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt16smallint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt16smallint0M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.int16smallint0m m
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
FROM dbo.int16smallint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallint0M>();
                var firstItems2 = new List<FlatInt16smallint0M>();
                var secondItems1 = new List<FlatInt16smallint0M>();
                var secondItems2 = new List<FlatInt16smallint0M>();
                await ((IInt16SingleTypesmallint)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 55, query1, 54, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatInt16smallint0M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[20],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatInt16smallint0M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[21],_testData[29], false);
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
FROM dbo.int16smallint0m m
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
FROM dbo.int16smallint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallint0M>();
                var firstItems2 = new List<FlatInt16smallint0M>();
                var secondItems1 = new List<FlatInt16smallint0M>();
                await ((IInt16SingleTypesmallint)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 103, query1, 127, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatInt16smallint0M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[12],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatInt16smallint0M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[6],_testData[29], false);
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
FROM dbo.int16smallint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt16smallint0M>();
                var models2 = new List<FlatInt16smallint0M>();
                ((IInt16SingleTypesmallint)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt16smallint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt16smallint0M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.int16smallint0m m
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
FROM dbo.int16smallint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallint0M>();
                var firstItems2 = new List<FlatInt16smallint0M>();
                var secondItems1 = new List<FlatInt16smallint0M>();
                var secondItems2 = new List<FlatInt16smallint0M>();
                 ((IInt16SingleTypesmallint)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 104, query1, 119, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatInt16smallint0M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[11],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatInt16smallint0M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[7],_testData[29], false);
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
FROM dbo.int16smallint0m m
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
FROM dbo.int16smallint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallint0M>();
                var firstItems2 = new List<FlatInt16smallint0M>();
                var secondItems1 = new List<FlatInt16smallint0M>();
                 ((IInt16SingleTypesmallint)this).DbConnectionMMDynQuerySelectModelBatch(connection, 82, query1, 55, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatInt16smallint0M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatInt16smallint0M.AssertModel(firstItems2[15],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                        FlatInt16smallint0M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[20],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt16smallint0M)],
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
FROM dbo.int16smallint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IInt16SingleTypesmallint)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt16smallint0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.int16smallint0m m
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
FROM dbo.int16smallint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt16SingleTypesmallint)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 46, query1, 54, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatInt16smallint0M.AssertModel(models[0],_testData[7], false);
                        FlatInt16smallint0M.AssertModel(models[1],_testData[8], false);
                        FlatInt16smallint0M.AssertModel(models[2],_testData[9], false);
                        FlatInt16smallint0M.AssertModel(models[3],_testData[10], false);
                        FlatInt16smallint0M.AssertModel(models[4],_testData[11], false);
                        FlatInt16smallint0M.AssertModel(models[5],_testData[12], false);
                        FlatInt16smallint0M.AssertModel(models[6],_testData[13], false);
                        FlatInt16smallint0M.AssertModel(models[7],_testData[14], false);
                        FlatInt16smallint0M.AssertModel(models[8],_testData[15], false);
                        FlatInt16smallint0M.AssertModel(models[9],_testData[16], false);
                        FlatInt16smallint0M.AssertModel(models[10],_testData[17], false);
                        FlatInt16smallint0M.AssertModel(models[11],_testData[18], false);
                        FlatInt16smallint0M.AssertModel(models[12],_testData[19], false);
                        FlatInt16smallint0M.AssertModel(models[13],_testData[20], false);
                        FlatInt16smallint0M.AssertModel(models[14],_testData[21], false);
                        FlatInt16smallint0M.AssertModel(models[15],_testData[22], false);
                        FlatInt16smallint0M.AssertModel(models[16],_testData[23], false);
                        FlatInt16smallint0M.AssertModel(models[17],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(models[18],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(models[19],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(models[20],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(models[21],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatInt16smallint0M.AssertModel(models[0],_testData[8], false);
                        FlatInt16smallint0M.AssertModel(models[1],_testData[9], false);
                        FlatInt16smallint0M.AssertModel(models[2],_testData[10], false);
                        FlatInt16smallint0M.AssertModel(models[3],_testData[11], false);
                        FlatInt16smallint0M.AssertModel(models[4],_testData[12], false);
                        FlatInt16smallint0M.AssertModel(models[5],_testData[13], false);
                        FlatInt16smallint0M.AssertModel(models[6],_testData[14], false);
                        FlatInt16smallint0M.AssertModel(models[7],_testData[15], false);
                        FlatInt16smallint0M.AssertModel(models[8],_testData[16], false);
                        FlatInt16smallint0M.AssertModel(models[9],_testData[17], false);
                        FlatInt16smallint0M.AssertModel(models[10],_testData[18], false);
                        FlatInt16smallint0M.AssertModel(models[11],_testData[19], false);
                        FlatInt16smallint0M.AssertModel(models[12],_testData[20], false);
                        FlatInt16smallint0M.AssertModel(models[13],_testData[21], false);
                        FlatInt16smallint0M.AssertModel(models[14],_testData[22], false);
                        FlatInt16smallint0M.AssertModel(models[15],_testData[23], false);
                        FlatInt16smallint0M.AssertModel(models[16],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(models[17],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(models[18],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(models[19],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(models[20],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(models[21],_testData[29], false);
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
FROM dbo.int16smallint0m m
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
FROM dbo.int16smallint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallint0M>();
                var secondItems1 = new List<FlatInt16smallint0M>();
                var secondItems2 = new List<FlatInt16smallint0M>();
                await ((IInt16SingleTypesmallint)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 35, query1, 82, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatInt16smallint0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[24],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatInt16smallint0M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[15],_testData[29], false);
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
FROM dbo.int16smallint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IInt16SingleTypesmallint)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt16smallint0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.int16smallint0m m
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
FROM dbo.int16smallint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt16SingleTypesmallint)this).DbConnectionSTDynQuerySelectModelBatch(connection, 19, query1, 82, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatInt16smallint0M.AssertModel(models[0],_testData[3], false);
                        FlatInt16smallint0M.AssertModel(models[1],_testData[4], false);
                        FlatInt16smallint0M.AssertModel(models[2],_testData[5], false);
                        FlatInt16smallint0M.AssertModel(models[3],_testData[6], false);
                        FlatInt16smallint0M.AssertModel(models[4],_testData[7], false);
                        FlatInt16smallint0M.AssertModel(models[5],_testData[8], false);
                        FlatInt16smallint0M.AssertModel(models[6],_testData[9], false);
                        FlatInt16smallint0M.AssertModel(models[7],_testData[10], false);
                        FlatInt16smallint0M.AssertModel(models[8],_testData[11], false);
                        FlatInt16smallint0M.AssertModel(models[9],_testData[12], false);
                        FlatInt16smallint0M.AssertModel(models[10],_testData[13], false);
                        FlatInt16smallint0M.AssertModel(models[11],_testData[14], false);
                        FlatInt16smallint0M.AssertModel(models[12],_testData[15], false);
                        FlatInt16smallint0M.AssertModel(models[13],_testData[16], false);
                        FlatInt16smallint0M.AssertModel(models[14],_testData[17], false);
                        FlatInt16smallint0M.AssertModel(models[15],_testData[18], false);
                        FlatInt16smallint0M.AssertModel(models[16],_testData[19], false);
                        FlatInt16smallint0M.AssertModel(models[17],_testData[20], false);
                        FlatInt16smallint0M.AssertModel(models[18],_testData[21], false);
                        FlatInt16smallint0M.AssertModel(models[19],_testData[22], false);
                        FlatInt16smallint0M.AssertModel(models[20],_testData[23], false);
                        FlatInt16smallint0M.AssertModel(models[21],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(models[22],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(models[23],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(models[24],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(models[25],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatInt16smallint0M.AssertModel(models[0],_testData[14], false);
                        FlatInt16smallint0M.AssertModel(models[1],_testData[15], false);
                        FlatInt16smallint0M.AssertModel(models[2],_testData[16], false);
                        FlatInt16smallint0M.AssertModel(models[3],_testData[17], false);
                        FlatInt16smallint0M.AssertModel(models[4],_testData[18], false);
                        FlatInt16smallint0M.AssertModel(models[5],_testData[19], false);
                        FlatInt16smallint0M.AssertModel(models[6],_testData[20], false);
                        FlatInt16smallint0M.AssertModel(models[7],_testData[21], false);
                        FlatInt16smallint0M.AssertModel(models[8],_testData[22], false);
                        FlatInt16smallint0M.AssertModel(models[9],_testData[23], false);
                        FlatInt16smallint0M.AssertModel(models[10],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(models[11],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(models[12],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(models[13],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(models[14],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(models[15],_testData[29], false);
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
FROM dbo.int16smallint0m m
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
FROM dbo.int16smallint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallint0M>();
                var secondItems1 = new List<FlatInt16smallint0M>();
                var secondItems2 = new List<FlatInt16smallint0M>();
                 ((IInt16SingleTypesmallint)this).DbConnectionDynQuerySelectModelBatch(connection, 90, query1, 103, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatInt16smallint0M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(firstItems1[14],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatInt16smallint0M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatInt16smallint0M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatInt16smallint0M.AssertModel(secondItems2[12],_testData[29], false);
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
FROM dbo.int16smallint0m m
LEFT JOIN dbo.int16smallint0mi mi ON mi.id = m.int16smallint0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Int16smallint0M)],
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int16smallint0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IInt16SingleTypesmallint)this).DbConnectionSTSelectModelBatchAsync(connection, 113, 103))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        Int16smallint0M.AssertModel(models[0],_testData[19], false);
                        Int16smallint0M.AssertModel(models[1],_testData[20], false);
                        Int16smallint0M.AssertModel(models[2],_testData[21], false);
                        Int16smallint0M.AssertModel(models[3],_testData[22], false);
                        Int16smallint0M.AssertModel(models[4],_testData[23], false);
                        Int16smallint0M.AssertModel(models[5],_testData[24], false);
                        Int16smallint0M.AssertModel(models[6],_testData[25], false);
                        Int16smallint0M.AssertModel(models[7],_testData[26], false);
                        Int16smallint0M.AssertModel(models[8],_testData[27], false);
                        Int16smallint0M.AssertModel(models[9],_testData[28], false);
                        Int16smallint0M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        Int16smallint0M.AssertModel(models[0],_testData[17], false);
                        Int16smallint0M.AssertModel(models[1],_testData[18], false);
                        Int16smallint0M.AssertModel(models[2],_testData[19], false);
                        Int16smallint0M.AssertModel(models[3],_testData[20], false);
                        Int16smallint0M.AssertModel(models[4],_testData[21], false);
                        Int16smallint0M.AssertModel(models[5],_testData[22], false);
                        Int16smallint0M.AssertModel(models[6],_testData[23], false);
                        Int16smallint0M.AssertModel(models[7],_testData[24], false);
                        Int16smallint0M.AssertModel(models[8],_testData[25], false);
                        Int16smallint0M.AssertModel(models[9],_testData[26], false);
                        Int16smallint0M.AssertModel(models[10],_testData[27], false);
                        Int16smallint0M.AssertModel(models[11],_testData[28], false);
                        Int16smallint0M.AssertModel(models[12],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int16smallint0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IInt16SingleTypesmallint)this).DbConnectionSTSelectModelBatch(connection, 113, 54))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        Int16smallint0M.AssertModel(models[0],_testData[19], false);
                        Int16smallint0M.AssertModel(models[1],_testData[20], false);
                        Int16smallint0M.AssertModel(models[2],_testData[21], false);
                        Int16smallint0M.AssertModel(models[3],_testData[22], false);
                        Int16smallint0M.AssertModel(models[4],_testData[23], false);
                        Int16smallint0M.AssertModel(models[5],_testData[24], false);
                        Int16smallint0M.AssertModel(models[6],_testData[25], false);
                        Int16smallint0M.AssertModel(models[7],_testData[26], false);
                        Int16smallint0M.AssertModel(models[8],_testData[27], false);
                        Int16smallint0M.AssertModel(models[9],_testData[28], false);
                        Int16smallint0M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        Int16smallint0M.AssertModel(models[0],_testData[8], false);
                        Int16smallint0M.AssertModel(models[1],_testData[9], false);
                        Int16smallint0M.AssertModel(models[2],_testData[10], false);
                        Int16smallint0M.AssertModel(models[3],_testData[11], false);
                        Int16smallint0M.AssertModel(models[4],_testData[12], false);
                        Int16smallint0M.AssertModel(models[5],_testData[13], false);
                        Int16smallint0M.AssertModel(models[6],_testData[14], false);
                        Int16smallint0M.AssertModel(models[7],_testData[15], false);
                        Int16smallint0M.AssertModel(models[8],_testData[16], false);
                        Int16smallint0M.AssertModel(models[9],_testData[17], false);
                        Int16smallint0M.AssertModel(models[10],_testData[18], false);
                        Int16smallint0M.AssertModel(models[11],_testData[19], false);
                        Int16smallint0M.AssertModel(models[12],_testData[20], false);
                        Int16smallint0M.AssertModel(models[13],_testData[21], false);
                        Int16smallint0M.AssertModel(models[14],_testData[22], false);
                        Int16smallint0M.AssertModel(models[15],_testData[23], false);
                        Int16smallint0M.AssertModel(models[16],_testData[24], false);
                        Int16smallint0M.AssertModel(models[17],_testData[25], false);
                        Int16smallint0M.AssertModel(models[18],_testData[26], false);
                        Int16smallint0M.AssertModel(models[19],_testData[27], false);
                        Int16smallint0M.AssertModel(models[20],_testData[28], false);
                        Int16smallint0M.AssertModel(models[21],_testData[29], false);
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
                ((IInt16SingleTypesmallint)this).SetDbConnectionSelectModelParametrs(cmd, 5);
                var models = await ((IInt16SingleTypesmallint)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(29));
Int16smallint0M.AssertModel(models[0],_testData[1], false);Int16smallint0M.AssertModel(models[1],_testData[2], false);Int16smallint0M.AssertModel(models[2],_testData[3], false);Int16smallint0M.AssertModel(models[3],_testData[4], false);Int16smallint0M.AssertModel(models[4],_testData[5], false);Int16smallint0M.AssertModel(models[5],_testData[6], false);Int16smallint0M.AssertModel(models[6],_testData[7], false);Int16smallint0M.AssertModel(models[7],_testData[8], false);Int16smallint0M.AssertModel(models[8],_testData[9], false);Int16smallint0M.AssertModel(models[9],_testData[10], false);Int16smallint0M.AssertModel(models[10],_testData[11], false);Int16smallint0M.AssertModel(models[11],_testData[12], false);Int16smallint0M.AssertModel(models[12],_testData[13], false);Int16smallint0M.AssertModel(models[13],_testData[14], false);Int16smallint0M.AssertModel(models[14],_testData[15], false);Int16smallint0M.AssertModel(models[15],_testData[16], false);Int16smallint0M.AssertModel(models[16],_testData[17], false);Int16smallint0M.AssertModel(models[17],_testData[18], false);Int16smallint0M.AssertModel(models[18],_testData[19], false);Int16smallint0M.AssertModel(models[19],_testData[20], false);Int16smallint0M.AssertModel(models[20],_testData[21], false);Int16smallint0M.AssertModel(models[21],_testData[22], false);Int16smallint0M.AssertModel(models[22],_testData[23], false);Int16smallint0M.AssertModel(models[23],_testData[24], false);Int16smallint0M.AssertModel(models[24],_testData[25], false);Int16smallint0M.AssertModel(models[25],_testData[26], false);Int16smallint0M.AssertModel(models[26],_testData[27], false);Int16smallint0M.AssertModel(models[27],_testData[28], false);Int16smallint0M.AssertModel(models[28],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt16SingleTypesmallint)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt16SingleTypesmallint)this).SetDbConnectionSelectModelParametrs(cmd, 95);
                var models =  ((IInt16SingleTypesmallint)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(14));
Int16smallint0M.AssertModel(models[0],_testData[16], false);Int16smallint0M.AssertModel(models[1],_testData[17], false);Int16smallint0M.AssertModel(models[2],_testData[18], false);Int16smallint0M.AssertModel(models[3],_testData[19], false);Int16smallint0M.AssertModel(models[4],_testData[20], false);Int16smallint0M.AssertModel(models[5],_testData[21], false);Int16smallint0M.AssertModel(models[6],_testData[22], false);Int16smallint0M.AssertModel(models[7],_testData[23], false);Int16smallint0M.AssertModel(models[8],_testData[24], false);Int16smallint0M.AssertModel(models[9],_testData[25], false);Int16smallint0M.AssertModel(models[10],_testData[26], false);Int16smallint0M.AssertModel(models[11],_testData[27], false);Int16smallint0M.AssertModel(models[12],_testData[28], false);Int16smallint0M.AssertModel(models[13],_testData[29], false);
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
FROM dbo.int16smallint0m m
LEFT JOIN dbo.int16smallint0mi mi ON mi.id = m.int16smallint0mi_id
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
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((5)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((29627)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((25297)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((14515)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((27567)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((13606)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((14236)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((24797)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((18191)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((19349)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((9964)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((16335)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((24145)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((24316)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((12740)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((19822)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((21707)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((28249)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((2262)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((3586)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((19006)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((15527)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((26691)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((78)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((5787)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((28639)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((9505)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((7171)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((8574)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((27405)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((7192)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((4047)));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((4217)));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((601)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((926)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((15557)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((28294)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((15675)));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((2691)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((6266)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((13834)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((10009)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((17843)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((22462)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((616)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((21934)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((50)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((13771)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((16112)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((31915)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((17482)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((28068)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((2167)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((17305)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((32153)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((28175)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((2771)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((8650)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((8955)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((1621)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((73)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((16649)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((1394)));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((9905)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((21204)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((19785)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((1309)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((80)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((19694)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((22659)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((152)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((20651)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((29124)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((159)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((26009)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((85)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((2174)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((882)));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((IInt16SingleTypesmallint)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((5)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((29627)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((25297)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((14515)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((27567)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((13606)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((14236)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((24797)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((18191)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((19349)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((9964)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((16335)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((24145)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((24316)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((12740)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((19822)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((21707)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((28249)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((2262)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((3586)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((19006)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((15527)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((26691)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((78)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((5787)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((28639)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((9505)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((7171)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((8574)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((27405)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((7192)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((4047)));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((4217)));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((601)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((926)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((15557)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((28294)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((15675)));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((2691)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((6266)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((13834)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((10009)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((17843)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((22462)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((616)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((21934)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((50)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((13771)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((16112)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((31915)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((17482)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((28068)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((2167)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((17305)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((32153)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((28175)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((2771)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((8650)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((8955)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((1621)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((73)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((16649)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((1394)));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((9905)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((21204)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((19785)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((1309)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((80)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((19694)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((22659)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((152)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((20651)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((29124)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((159)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((26009)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((85)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((2174)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((882)));

            }
        }

#endregion

    }
}

