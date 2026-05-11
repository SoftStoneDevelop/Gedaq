

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
    Id = 4,
    Value = 26674,
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintE0M
{
    Id = 7,
    Value = 23457,
    ModelInner = new Int16smallintE0MI
{
    Id = 1,
    Value = 5668,
    NullableValue = 8039,
},
    NullableValue = null,
},
            new Int16smallintE0M
{
    Id = 10,
    Value = 27663,
    ModelInner = null,
    NullableValue = 6907,
},
            new Int16smallintE0M
{
    Id = 14,
    Value = 17761,
    ModelInner = new Int16smallintE0MI
{
    Id = 6,
    Value = 1728,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16smallintE0M
{
    Id = 16,
    Value = 9668,
    ModelInner = null,
    NullableValue = 4446,
},
            new Int16smallintE0M
{
    Id = 23,
    Value = 18157,
    ModelInner = new Int16smallintE0MI
{
    Id = 7,
    Value = 13359,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16smallintE0M
{
    Id = 30,
    Value = 23359,
    ModelInner = null,
    NullableValue = 19677,
},
            new Int16smallintE0M
{
    Id = 37,
    Value = 26037,
    ModelInner = new Int16smallintE0MI
{
    Id = 14,
    Value = 6889,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16smallintE0M
{
    Id = 39,
    Value = 8611,
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintE0M
{
    Id = 48,
    Value = 20375,
    ModelInner = new Int16smallintE0MI
{
    Id = 16,
    Value = 8869,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16smallintE0M
{
    Id = 55,
    Value = 20570,
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintE0M
{
    Id = 64,
    Value = 14896,
    ModelInner = new Int16smallintE0MI
{
    Id = 21,
    Value = 27912,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16smallintE0M
{
    Id = 69,
    Value = 9756,
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintE0M
{
    Id = 71,
    Value = 20334,
    ModelInner = new Int16smallintE0MI
{
    Id = 25,
    Value = 25039,
    NullableValue = 15310,
},
    NullableValue = null,
},
            new Int16smallintE0M
{
    Id = 77,
    Value = 9844,
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintE0M
{
    Id = 80,
    Value = 24995,
    ModelInner = new Int16smallintE0MI
{
    Id = 29,
    Value = 24118,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16smallintE0M
{
    Id = 86,
    Value = 23497,
    ModelInner = null,
    NullableValue = 17500,
},
            new Int16smallintE0M
{
    Id = 91,
    Value = 4862,
    ModelInner = new Int16smallintE0MI
{
    Id = 37,
    Value = 12173,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16smallintE0M
{
    Id = 98,
    Value = 15404,
    ModelInner = null,
    NullableValue = 25702,
},
            new Int16smallintE0M
{
    Id = 106,
    Value = 20502,
    ModelInner = new Int16smallintE0MI
{
    Id = 38,
    Value = 32410,
    NullableValue = null,
},
    NullableValue = 18061,
},
            new Int16smallintE0M
{
    Id = 113,
    Value = 15037,
    ModelInner = null,
    NullableValue = 24014,
},
            new Int16smallintE0M
{
    Id = 114,
    Value = 31317,
    ModelInner = new Int16smallintE0MI
{
    Id = 47,
    Value = 19113,
    NullableValue = 31556,
},
    NullableValue = null,
},
            new Int16smallintE0M
{
    Id = 122,
    Value = 25164,
    ModelInner = null,
    NullableValue = 6766,
},
            new Int16smallintE0M
{
    Id = 129,
    Value = 10118,
    ModelInner = new Int16smallintE0MI
{
    Id = 53,
    Value = 28295,
    NullableValue = 14930,
},
    NullableValue = null,
},
            new Int16smallintE0M
{
    Id = 135,
    Value = 28172,
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintE0M
{
    Id = 140,
    Value = 20827,
    ModelInner = new Int16smallintE0MI
{
    Id = 62,
    Value = 4316,
    NullableValue = 20660,
},
    NullableValue = 3730,
},
            new Int16smallintE0M
{
    Id = 146,
    Value = 14359,
    ModelInner = null,
    NullableValue = 22701,
},
            new Int16smallintE0M
{
    Id = 151,
    Value = 28045,
    ModelInner = new Int16smallintE0MI
{
    Id = 65,
    Value = 24024,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16smallintE0M
{
    Id = 154,
    Value = 7448,
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintE0M
{
    Id = 159,
    Value = 27292,
    ModelInner = new Int16smallintE0MI
{
    Id = 66,
    Value = 2070,
    NullableValue = 5151,
},
    NullableValue = null,
},
            new Int16smallintE0M
{
    Id = 162,
    Value = 31868,
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintE0M
{
    Id = 168,
    Value = 8056,
    ModelInner = new Int16smallintE0MI
{
    Id = 75,
    Value = 13858,
    NullableValue = 14385,
},
    NullableValue = null,
},
            new Int16smallintE0M
{
    Id = 175,
    Value = 27432,
    ModelInner = null,
    NullableValue = null,
},
            new Int16smallintE0M
{
    Id = 178,
    Value = 11429,
    ModelInner = new Int16smallintE0MI
{
    Id = 83,
    Value = 25994,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16smallintE0M
{
    Id = 181,
    Value = 29940,
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.MySqlConnector.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.int16smallinte0mi(
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
            asPartInterface: typeof(IInt16SingleTypesmallint)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                parametrName: "id",
                methodParametrName: "id", 
                dbType: (MySqlConnector.MySqlDbType)(3)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int16),
                parametrName: "value",
                methodParametrName: "value",
                dbType: (MySqlConnector.MySqlDbType)(2)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int16?), 
                parametrName: "nullablevalue",
                methodParametrName: "nullablevalue",
                dbType: (MySqlConnector.MySqlDbType)(2))]
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
INSERT INTO gedaqtests.int16smallinte0mi(
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
                dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int16), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(10)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int16?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(10), 
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

[Gedaq.MySqlConnector.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.int16smallinte0m(
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
            sourceType: SourceType.MySqlConnection,
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (MySqlConnector.MySqlDbType)(3)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int16), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (MySqlConnector.MySqlDbType)(2)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int16?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (MySqlConnector.MySqlDbType)(2),
                nullable: true),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "int16smallinte0mi_id", 
                methodParametrName: "int16smallinte0mi_id", 
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
INSERT INTO gedaqtests.int16smallinte0m(
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
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int16), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(10)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int16?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(10),
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "int16smallinte0mi_id", 
                methodParametrName: "int16smallinte0mi_id", 
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

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt16smallintE0M), typeof(FlatInt16smallintE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint)),
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
FROM gedaqtests.int16smallinte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
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
FROM gedaqtests.int16smallinte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
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

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt16smallintE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint)),
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
FROM gedaqtests.int16smallinte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
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
FROM gedaqtests.int16smallinte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
                var models = ((IInt16SingleTypesmallint)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt16smallintE0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.int16smallinte0m m
LEFT JOIN gedaqtests.int16smallinte0mi mi ON mi.id = m.int16smallinte0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            sourceType: SourceType.MySqlConnection,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Int16smallintE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint)),
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
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
                var models = ((IInt16SingleTypesmallint)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int16smallintE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt16smallintE0M), typeof(FlatInt16smallintE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint)),
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
FROM gedaqtests.int16smallinte0m m
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
FROM gedaqtests.int16smallinte0m m
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

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt16smallintE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint)),
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
FROM gedaqtests.int16smallinte0m m
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
FROM gedaqtests.int16smallinte0m m
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
FROM gedaqtests.int16smallinte0m m
LEFT JOIN gedaqtests.int16smallinte0mi mi ON mi.id = m.int16smallinte0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            sourceType: SourceType.MySqlConnection,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Int16smallintE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypesmallint)),
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
FROM gedaqtests.int16smallinte0m m
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
                parametr1.Value = 175;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 7;
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
FROM gedaqtests.int16smallinte0m m
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
FROM gedaqtests.int16smallinte0m m
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
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatInt16smallintE0M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatInt16smallintE0M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[32],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 7;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 106;
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
FROM gedaqtests.int16smallinte0m m
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
FROM gedaqtests.int16smallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintE0M>();
                var firstItems2 = new List<FlatInt16smallintE0M>();
                var secondItems1 = new List<FlatInt16smallintE0M>();
                await ((IInt16SingleTypesmallint)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatInt16smallintE0M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatInt16smallintE0M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[14],_testData[34], false);
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
FROM gedaqtests.int16smallinte0m m
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
                parametr1.Value = 154;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 86;
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
FROM gedaqtests.int16smallinte0m m
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
FROM gedaqtests.int16smallinte0m m
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
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatInt16smallintE0M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatInt16smallintE0M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[17],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 91;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 146;
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
FROM gedaqtests.int16smallinte0m m
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
FROM gedaqtests.int16smallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintE0M>();
                var firstItems2 = new List<FlatInt16smallintE0M>();
                var secondItems1 = new List<FlatInt16smallintE0M>();
                 ((IInt16SingleTypesmallint)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatInt16smallintE0M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[16],_testData[34], false);
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
FROM gedaqtests.int16smallinte0m m
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
                parametr1.Value = 10;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 146;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.int16smallinte0m m
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
FROM gedaqtests.int16smallinte0m m
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
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatInt16smallintE0M.AssertModel(models[0],_testData[3], false);
                        FlatInt16smallintE0M.AssertModel(models[1],_testData[4], false);
                        FlatInt16smallintE0M.AssertModel(models[2],_testData[5], false);
                        FlatInt16smallintE0M.AssertModel(models[3],_testData[6], false);
                        FlatInt16smallintE0M.AssertModel(models[4],_testData[7], false);
                        FlatInt16smallintE0M.AssertModel(models[5],_testData[8], false);
                        FlatInt16smallintE0M.AssertModel(models[6],_testData[9], false);
                        FlatInt16smallintE0M.AssertModel(models[7],_testData[10], false);
                        FlatInt16smallintE0M.AssertModel(models[8],_testData[11], false);
                        FlatInt16smallintE0M.AssertModel(models[9],_testData[12], false);
                        FlatInt16smallintE0M.AssertModel(models[10],_testData[13], false);
                        FlatInt16smallintE0M.AssertModel(models[11],_testData[14], false);
                        FlatInt16smallintE0M.AssertModel(models[12],_testData[15], false);
                        FlatInt16smallintE0M.AssertModel(models[13],_testData[16], false);
                        FlatInt16smallintE0M.AssertModel(models[14],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(models[15],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(models[16],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(models[17],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(models[18],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(models[19],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(models[20],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(models[21],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(models[22],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(models[23],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(models[24],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(models[25],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(models[26],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(models[27],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(models[28],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(models[29],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(models[30],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatInt16smallintE0M.AssertModel(models[0],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(models[1],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(models[2],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(models[3],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(models[4],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(models[5],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(models[6],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(models[7],_testData[34], false);
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
                parametr1.Value = 91;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 135;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.int16smallinte0m m
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
FROM gedaqtests.int16smallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintE0M>();
                var secondItems1 = new List<FlatInt16smallintE0M>();
                var secondItems2 = new List<FlatInt16smallintE0M>();
                await ((IInt16SingleTypesmallint)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatInt16smallintE0M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[9],_testData[34], false);
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
FROM gedaqtests.int16smallinte0m m
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
                parametr1.Value = 71;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 23;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.int16smallinte0m m
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
FROM gedaqtests.int16smallinte0m m
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
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatInt16smallintE0M.AssertModel(models[0],_testData[14], false);
                        FlatInt16smallintE0M.AssertModel(models[1],_testData[15], false);
                        FlatInt16smallintE0M.AssertModel(models[2],_testData[16], false);
                        FlatInt16smallintE0M.AssertModel(models[3],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(models[4],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(models[5],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(models[6],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(models[7],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(models[8],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(models[9],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(models[10],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(models[11],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(models[12],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(models[13],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(models[14],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(models[15],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(models[16],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(models[17],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(models[18],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(models[19],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                parametr1.Value = 71;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 114;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.int16smallinte0m m
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
FROM gedaqtests.int16smallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintE0M>();
                var secondItems1 = new List<FlatInt16smallintE0M>();
                var secondItems2 = new List<FlatInt16smallintE0M>();
                 ((IInt16SingleTypesmallint)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                        FlatInt16smallintE0M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatInt16smallintE0M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[12],_testData[34], false);
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
FROM gedaqtests.int16smallinte0m m
LEFT JOIN gedaqtests.int16smallinte0mi mi ON mi.id = m.int16smallinte0mi_id
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
                parametr1.Value = 48;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 23;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt16SingleTypesmallint)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        Int16smallintE0M.AssertModel(models[0],_testData[10], false);
                        Int16smallintE0M.AssertModel(models[1],_testData[11], false);
                        Int16smallintE0M.AssertModel(models[2],_testData[12], false);
                        Int16smallintE0M.AssertModel(models[3],_testData[13], false);
                        Int16smallintE0M.AssertModel(models[4],_testData[14], false);
                        Int16smallintE0M.AssertModel(models[5],_testData[15], false);
                        Int16smallintE0M.AssertModel(models[6],_testData[16], false);
                        Int16smallintE0M.AssertModel(models[7],_testData[17], false);
                        Int16smallintE0M.AssertModel(models[8],_testData[18], false);
                        Int16smallintE0M.AssertModel(models[9],_testData[19], false);
                        Int16smallintE0M.AssertModel(models[10],_testData[20], false);
                        Int16smallintE0M.AssertModel(models[11],_testData[21], false);
                        Int16smallintE0M.AssertModel(models[12],_testData[22], false);
                        Int16smallintE0M.AssertModel(models[13],_testData[23], false);
                        Int16smallintE0M.AssertModel(models[14],_testData[24], false);
                        Int16smallintE0M.AssertModel(models[15],_testData[25], false);
                        Int16smallintE0M.AssertModel(models[16],_testData[26], false);
                        Int16smallintE0M.AssertModel(models[17],_testData[27], false);
                        Int16smallintE0M.AssertModel(models[18],_testData[28], false);
                        Int16smallintE0M.AssertModel(models[19],_testData[29], false);
                        Int16smallintE0M.AssertModel(models[20],_testData[30], false);
                        Int16smallintE0M.AssertModel(models[21],_testData[31], false);
                        Int16smallintE0M.AssertModel(models[22],_testData[32], false);
                        Int16smallintE0M.AssertModel(models[23],_testData[33], false);
                        Int16smallintE0M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        Int16smallintE0M.AssertModel(models[0],_testData[6], false);
                        Int16smallintE0M.AssertModel(models[1],_testData[7], false);
                        Int16smallintE0M.AssertModel(models[2],_testData[8], false);
                        Int16smallintE0M.AssertModel(models[3],_testData[9], false);
                        Int16smallintE0M.AssertModel(models[4],_testData[10], false);
                        Int16smallintE0M.AssertModel(models[5],_testData[11], false);
                        Int16smallintE0M.AssertModel(models[6],_testData[12], false);
                        Int16smallintE0M.AssertModel(models[7],_testData[13], false);
                        Int16smallintE0M.AssertModel(models[8],_testData[14], false);
                        Int16smallintE0M.AssertModel(models[9],_testData[15], false);
                        Int16smallintE0M.AssertModel(models[10],_testData[16], false);
                        Int16smallintE0M.AssertModel(models[11],_testData[17], false);
                        Int16smallintE0M.AssertModel(models[12],_testData[18], false);
                        Int16smallintE0M.AssertModel(models[13],_testData[19], false);
                        Int16smallintE0M.AssertModel(models[14],_testData[20], false);
                        Int16smallintE0M.AssertModel(models[15],_testData[21], false);
                        Int16smallintE0M.AssertModel(models[16],_testData[22], false);
                        Int16smallintE0M.AssertModel(models[17],_testData[23], false);
                        Int16smallintE0M.AssertModel(models[18],_testData[24], false);
                        Int16smallintE0M.AssertModel(models[19],_testData[25], false);
                        Int16smallintE0M.AssertModel(models[20],_testData[26], false);
                        Int16smallintE0M.AssertModel(models[21],_testData[27], false);
                        Int16smallintE0M.AssertModel(models[22],_testData[28], false);
                        Int16smallintE0M.AssertModel(models[23],_testData[29], false);
                        Int16smallintE0M.AssertModel(models[24],_testData[30], false);
                        Int16smallintE0M.AssertModel(models[25],_testData[31], false);
                        Int16smallintE0M.AssertModel(models[26],_testData[32], false);
                        Int16smallintE0M.AssertModel(models[27],_testData[33], false);
                        Int16smallintE0M.AssertModel(models[28],_testData[34], false);
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
                parametr1.Value = 14;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 175;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt16SingleTypesmallint)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        Int16smallintE0M.AssertModel(models[0],_testData[4], false);
                        Int16smallintE0M.AssertModel(models[1],_testData[5], false);
                        Int16smallintE0M.AssertModel(models[2],_testData[6], false);
                        Int16smallintE0M.AssertModel(models[3],_testData[7], false);
                        Int16smallintE0M.AssertModel(models[4],_testData[8], false);
                        Int16smallintE0M.AssertModel(models[5],_testData[9], false);
                        Int16smallintE0M.AssertModel(models[6],_testData[10], false);
                        Int16smallintE0M.AssertModel(models[7],_testData[11], false);
                        Int16smallintE0M.AssertModel(models[8],_testData[12], false);
                        Int16smallintE0M.AssertModel(models[9],_testData[13], false);
                        Int16smallintE0M.AssertModel(models[10],_testData[14], false);
                        Int16smallintE0M.AssertModel(models[11],_testData[15], false);
                        Int16smallintE0M.AssertModel(models[12],_testData[16], false);
                        Int16smallintE0M.AssertModel(models[13],_testData[17], false);
                        Int16smallintE0M.AssertModel(models[14],_testData[18], false);
                        Int16smallintE0M.AssertModel(models[15],_testData[19], false);
                        Int16smallintE0M.AssertModel(models[16],_testData[20], false);
                        Int16smallintE0M.AssertModel(models[17],_testData[21], false);
                        Int16smallintE0M.AssertModel(models[18],_testData[22], false);
                        Int16smallintE0M.AssertModel(models[19],_testData[23], false);
                        Int16smallintE0M.AssertModel(models[20],_testData[24], false);
                        Int16smallintE0M.AssertModel(models[21],_testData[25], false);
                        Int16smallintE0M.AssertModel(models[22],_testData[26], false);
                        Int16smallintE0M.AssertModel(models[23],_testData[27], false);
                        Int16smallintE0M.AssertModel(models[24],_testData[28], false);
                        Int16smallintE0M.AssertModel(models[25],_testData[29], false);
                        Int16smallintE0M.AssertModel(models[26],_testData[30], false);
                        Int16smallintE0M.AssertModel(models[27],_testData[31], false);
                        Int16smallintE0M.AssertModel(models[28],_testData[32], false);
                        Int16smallintE0M.AssertModel(models[29],_testData[33], false);
                        Int16smallintE0M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        Int16smallintE0M.AssertModel(models[0],_testData[33], false);
                        Int16smallintE0M.AssertModel(models[1],_testData[34], false);
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
            dbType: (System.Data.DbType)(11))]
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
FROM gedaqtests.int16smallinte0m m
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
FROM gedaqtests.int16smallinte0m m
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
FROM gedaqtests.int16smallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintE0M>();
                var firstItems2 = new List<FlatInt16smallintE0M>();
                var secondItems1 = new List<FlatInt16smallintE0M>();
                var secondItems2 = new List<FlatInt16smallintE0M>();
                await ((IInt16SingleTypesmallint)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 175, query1, 114, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatInt16smallintE0M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatInt16smallintE0M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[12],_testData[34], false);
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
FROM gedaqtests.int16smallinte0m m
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
FROM gedaqtests.int16smallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintE0M>();
                var firstItems2 = new List<FlatInt16smallintE0M>();
                var secondItems1 = new List<FlatInt16smallintE0M>();
                await ((IInt16SingleTypesmallint)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 16, query1, 23, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatInt16smallintE0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatInt16smallintE0M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[28],_testData[34], false);
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
FROM gedaqtests.int16smallinte0m m
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
FROM gedaqtests.int16smallinte0m m
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
FROM gedaqtests.int16smallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintE0M>();
                var firstItems2 = new List<FlatInt16smallintE0M>();
                var secondItems1 = new List<FlatInt16smallintE0M>();
                var secondItems2 = new List<FlatInt16smallintE0M>();
                 ((IInt16SingleTypesmallint)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 114, query1, 91, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatInt16smallintE0M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatInt16smallintE0M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[16],_testData[34], false);
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
FROM gedaqtests.int16smallinte0m m
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
FROM gedaqtests.int16smallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintE0M>();
                var firstItems2 = new List<FlatInt16smallintE0M>();
                var secondItems1 = new List<FlatInt16smallintE0M>();
                 ((IInt16SingleTypesmallint)this).DbConnectionMMDynQuerySelectModelBatch(connection, 7, query1, 77, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatInt16smallintE0M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatInt16smallintE0M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatInt16smallintE0M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[19],_testData[34], false);
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
            dbType: (System.Data.DbType)(11))]
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
FROM gedaqtests.int16smallinte0m m
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
FROM gedaqtests.int16smallinte0m m
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
FROM gedaqtests.int16smallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt16SingleTypesmallint)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 162, query1, 23, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatInt16smallintE0M.AssertModel(models[0],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(models[1],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(models[2],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
FROM gedaqtests.int16smallinte0m m
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
FROM gedaqtests.int16smallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintE0M>();
                var secondItems1 = new List<FlatInt16smallintE0M>();
                var secondItems2 = new List<FlatInt16smallintE0M>();
                await ((IInt16SingleTypesmallint)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 48, query1, 10, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatInt16smallintE0M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatInt16smallintE0M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[31],_testData[34], false);
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
FROM gedaqtests.int16smallinte0m m
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
FROM gedaqtests.int16smallinte0m m
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
FROM gedaqtests.int16smallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt16SingleTypesmallint)this).DbConnectionSTDynQuerySelectModelBatch(connection, 140, query1, 4, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatInt16smallintE0M.AssertModel(models[0],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(models[1],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(models[2],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(models[3],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(models[4],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(models[5],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(models[6],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(models[7],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatInt16smallintE0M.AssertModel(models[0],_testData[1], false);
                        FlatInt16smallintE0M.AssertModel(models[1],_testData[2], false);
                        FlatInt16smallintE0M.AssertModel(models[2],_testData[3], false);
                        FlatInt16smallintE0M.AssertModel(models[3],_testData[4], false);
                        FlatInt16smallintE0M.AssertModel(models[4],_testData[5], false);
                        FlatInt16smallintE0M.AssertModel(models[5],_testData[6], false);
                        FlatInt16smallintE0M.AssertModel(models[6],_testData[7], false);
                        FlatInt16smallintE0M.AssertModel(models[7],_testData[8], false);
                        FlatInt16smallintE0M.AssertModel(models[8],_testData[9], false);
                        FlatInt16smallintE0M.AssertModel(models[9],_testData[10], false);
                        FlatInt16smallintE0M.AssertModel(models[10],_testData[11], false);
                        FlatInt16smallintE0M.AssertModel(models[11],_testData[12], false);
                        FlatInt16smallintE0M.AssertModel(models[12],_testData[13], false);
                        FlatInt16smallintE0M.AssertModel(models[13],_testData[14], false);
                        FlatInt16smallintE0M.AssertModel(models[14],_testData[15], false);
                        FlatInt16smallintE0M.AssertModel(models[15],_testData[16], false);
                        FlatInt16smallintE0M.AssertModel(models[16],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(models[17],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(models[18],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(models[19],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(models[20],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(models[21],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(models[22],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(models[23],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(models[24],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(models[25],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(models[26],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(models[27],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(models[28],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(models[29],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(models[30],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(models[31],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(models[32],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(models[33],_testData[34], false);
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
FROM gedaqtests.int16smallinte0m m
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
FROM gedaqtests.int16smallinte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt16smallintE0M>();
                var secondItems1 = new List<FlatInt16smallintE0M>();
                var secondItems2 = new List<FlatInt16smallintE0M>();
                 ((IInt16SingleTypesmallint)this).DbConnectionDynQuerySelectModelBatch(connection, 23, query1, 114, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatInt16smallintE0M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(firstItems1[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatInt16smallintE0M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatInt16smallintE0M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatInt16smallintE0M.AssertModel(secondItems2[12],_testData[34], false);
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
FROM gedaqtests.int16smallinte0m m
LEFT JOIN gedaqtests.int16smallinte0mi mi ON mi.id = m.int16smallinte0mi_id
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
            dbType: (System.Data.DbType)(11))]
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
                foreach(var batchResult in await ((IInt16SingleTypesmallint)this).DbConnectionSTSelectModelBatchAsync(connection, 69, 175))
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
                        Assert.That(models, Has.Count.EqualTo(2));

                        Int16smallintE0M.AssertModel(models[0],_testData[33], false);
                        Int16smallintE0M.AssertModel(models[1],_testData[34], false);
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
                foreach(var batchResult in  ((IInt16SingleTypesmallint)this).DbConnectionSTSelectModelBatch(connection, 64, 37))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        Int16smallintE0M.AssertModel(models[0],_testData[12], false);
                        Int16smallintE0M.AssertModel(models[1],_testData[13], false);
                        Int16smallintE0M.AssertModel(models[2],_testData[14], false);
                        Int16smallintE0M.AssertModel(models[3],_testData[15], false);
                        Int16smallintE0M.AssertModel(models[4],_testData[16], false);
                        Int16smallintE0M.AssertModel(models[5],_testData[17], false);
                        Int16smallintE0M.AssertModel(models[6],_testData[18], false);
                        Int16smallintE0M.AssertModel(models[7],_testData[19], false);
                        Int16smallintE0M.AssertModel(models[8],_testData[20], false);
                        Int16smallintE0M.AssertModel(models[9],_testData[21], false);
                        Int16smallintE0M.AssertModel(models[10],_testData[22], false);
                        Int16smallintE0M.AssertModel(models[11],_testData[23], false);
                        Int16smallintE0M.AssertModel(models[12],_testData[24], false);
                        Int16smallintE0M.AssertModel(models[13],_testData[25], false);
                        Int16smallintE0M.AssertModel(models[14],_testData[26], false);
                        Int16smallintE0M.AssertModel(models[15],_testData[27], false);
                        Int16smallintE0M.AssertModel(models[16],_testData[28], false);
                        Int16smallintE0M.AssertModel(models[17],_testData[29], false);
                        Int16smallintE0M.AssertModel(models[18],_testData[30], false);
                        Int16smallintE0M.AssertModel(models[19],_testData[31], false);
                        Int16smallintE0M.AssertModel(models[20],_testData[32], false);
                        Int16smallintE0M.AssertModel(models[21],_testData[33], false);
                        Int16smallintE0M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                ((IInt16SingleTypesmallint)this).SetDbConnectionSelectModelParametrs(cmd, 114);
                var models = await ((IInt16SingleTypesmallint)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(13));

                Int16smallintE0M.AssertModel(models[0],_testData[22], false);
                Int16smallintE0M.AssertModel(models[1],_testData[23], false);
                Int16smallintE0M.AssertModel(models[2],_testData[24], false);
                Int16smallintE0M.AssertModel(models[3],_testData[25], false);
                Int16smallintE0M.AssertModel(models[4],_testData[26], false);
                Int16smallintE0M.AssertModel(models[5],_testData[27], false);
                Int16smallintE0M.AssertModel(models[6],_testData[28], false);
                Int16smallintE0M.AssertModel(models[7],_testData[29], false);
                Int16smallintE0M.AssertModel(models[8],_testData[30], false);
                Int16smallintE0M.AssertModel(models[9],_testData[31], false);
                Int16smallintE0M.AssertModel(models[10],_testData[32], false);
                Int16smallintE0M.AssertModel(models[11],_testData[33], false);
                Int16smallintE0M.AssertModel(models[12],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt16SingleTypesmallint)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt16SingleTypesmallint)this).SetDbConnectionSelectModelParametrs(cmd, 106);
                var models =  ((IInt16SingleTypesmallint)this).ExecuteDbConnectionSelectModelCommand(cmd);

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
FROM gedaqtests.int16smallinte0m m
LEFT JOIN gedaqtests.int16smallinte0mi mi ON mi.id = m.int16smallinte0mi_id
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
                Assert.That((System.Int32)model[0], Is.EqualTo((4)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((26674)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((23457)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((5668)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((8039)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((27663)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((6907)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((17761)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((1728)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((9668)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((4446)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((18157)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((13359)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((23359)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((19677)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((26037)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((6889)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((8611)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((20375)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((8869)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((20570)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((14896)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((21)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((27912)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((9756)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((20334)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((25039)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((15310)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((9844)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((24995)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((24118)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((23497)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((17500)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((4862)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((12173)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((15404)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((25702)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((20502)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((38)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((32410)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((18061)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((15037)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((24014)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((31317)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((19113)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((31556)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((25164)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((6766)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((10118)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((28295)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((14930)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((28172)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((20827)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((62)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((4316)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((20660)));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((3730)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((14359)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((22701)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((28045)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((24024)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((7448)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((159)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((27292)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((2070)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((5151)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((162)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((31868)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((168)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((8056)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((75)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((13858)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((14385)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((175)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((27432)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((178)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((11429)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((83)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((25994)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((181)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((29940)));//Value

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
                var models =  ((IInt16SingleTypesmallint)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((4)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((26674)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((23457)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((5668)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((8039)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((27663)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((6907)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((17761)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((1728)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((9668)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((4446)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((18157)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((13359)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((23359)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((19677)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((26037)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((6889)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((8611)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((20375)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((8869)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((20570)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((14896)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((21)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((27912)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((9756)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((20334)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((25039)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((15310)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((9844)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((24995)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((24118)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((23497)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((17500)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((4862)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((12173)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((15404)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((25702)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((20502)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((38)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((32410)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int16?)model[5], Is.EqualTo((18061)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((15037)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((24014)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((31317)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((19113)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((31556)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((25164)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((6766)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((10118)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((28295)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((14930)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((28172)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((20827)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((62)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((4316)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((20660)));//InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((3730)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((14359)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int16?)model[5], Is.EqualTo((22701)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((28045)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((24024)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((7448)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((159)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((27292)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((2070)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((5151)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((162)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((31868)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((168)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((8056)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((75)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((13858)));//InnerModel.Value

                Assert.That((System.Int16?)model[4], Is.EqualTo((14385)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((175)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((27432)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((178)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((11429)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((83)));//InnerModel.Id
                Assert.That((System.Int16)model[3], Is.EqualTo((25994)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((181)));//Id
                Assert.That((System.Int16)model[1], Is.EqualTo((29940)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

#endregion

    }
}

