

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
    internal partial interface IBooleanSingleTypeboolean
    {
    }
    
    internal partial class BooleanSingleTypeboolean : IBooleanSingleTypeboolean
    {


#region TestData

        private readonly Booleanboolean0M[] _testData = new Booleanboolean0M[]
        {
            new Booleanboolean0M
{
    Id = 6,
    Value = false,
    ModelInner = null,
    NullableValue = false,
},
            new Booleanboolean0M
{
    Id = 10,
    Value = false,
    ModelInner = new Booleanboolean0MI
{
    Id = 5,
    Value = false,
    NullableValue = null,
},
    NullableValue = false,
},
            new Booleanboolean0M
{
    Id = 17,
    Value = false,
    ModelInner = null,
    NullableValue = false,
},
            new Booleanboolean0M
{
    Id = 20,
    Value = false,
    ModelInner = new Booleanboolean0MI
{
    Id = 12,
    Value = false,
    NullableValue = null,
},
    NullableValue = null,
},
            new Booleanboolean0M
{
    Id = 23,
    Value = false,
    ModelInner = null,
    NullableValue = false,
},
            new Booleanboolean0M
{
    Id = 27,
    Value = false,
    ModelInner = new Booleanboolean0MI
{
    Id = 14,
    Value = false,
    NullableValue = false,
},
    NullableValue = null,
},
            new Booleanboolean0M
{
    Id = 35,
    Value = false,
    ModelInner = null,
    NullableValue = null,
},
            new Booleanboolean0M
{
    Id = 37,
    Value = false,
    ModelInner = new Booleanboolean0MI
{
    Id = 21,
    Value = false,
    NullableValue = false,
},
    NullableValue = null,
},
            new Booleanboolean0M
{
    Id = 46,
    Value = false,
    ModelInner = null,
    NullableValue = false,
},
            new Booleanboolean0M
{
    Id = 55,
    Value = false,
    ModelInner = new Booleanboolean0MI
{
    Id = 26,
    Value = false,
    NullableValue = null,
},
    NullableValue = null,
},
            new Booleanboolean0M
{
    Id = 56,
    Value = false,
    ModelInner = null,
    NullableValue = null,
},
            new Booleanboolean0M
{
    Id = 65,
    Value = false,
    ModelInner = new Booleanboolean0MI
{
    Id = 28,
    Value = false,
    NullableValue = false,
},
    NullableValue = null,
},
            new Booleanboolean0M
{
    Id = 69,
    Value = false,
    ModelInner = null,
    NullableValue = null,
},
            new Booleanboolean0M
{
    Id = 70,
    Value = false,
    ModelInner = new Booleanboolean0MI
{
    Id = 29,
    Value = false,
    NullableValue = false,
},
    NullableValue = false,
},
            new Booleanboolean0M
{
    Id = 77,
    Value = false,
    ModelInner = null,
    NullableValue = false,
},
            new Booleanboolean0M
{
    Id = 83,
    Value = false,
    ModelInner = new Booleanboolean0MI
{
    Id = 31,
    Value = false,
    NullableValue = null,
},
    NullableValue = null,
},
            new Booleanboolean0M
{
    Id = 91,
    Value = false,
    ModelInner = null,
    NullableValue = false,
},
            new Booleanboolean0M
{
    Id = 92,
    Value = false,
    ModelInner = new Booleanboolean0MI
{
    Id = 40,
    Value = false,
    NullableValue = null,
},
    NullableValue = false,
},
            new Booleanboolean0M
{
    Id = 96,
    Value = false,
    ModelInner = null,
    NullableValue = null,
},
            new Booleanboolean0M
{
    Id = 105,
    Value = false,
    ModelInner = new Booleanboolean0MI
{
    Id = 41,
    Value = false,
    NullableValue = false,
},
    NullableValue = false,
},
            new Booleanboolean0M
{
    Id = 112,
    Value = false,
    ModelInner = null,
    NullableValue = false,
},
            new Booleanboolean0M
{
    Id = 119,
    Value = false,
    ModelInner = new Booleanboolean0MI
{
    Id = 48,
    Value = false,
    NullableValue = null,
},
    NullableValue = null,
},
            new Booleanboolean0M
{
    Id = 122,
    Value = false,
    ModelInner = null,
    NullableValue = null,
},
            new Booleanboolean0M
{
    Id = 123,
    Value = false,
    ModelInner = new Booleanboolean0MI
{
    Id = 54,
    Value = false,
    NullableValue = null,
},
    NullableValue = false,
},
            new Booleanboolean0M
{
    Id = 131,
    Value = false,
    ModelInner = null,
    NullableValue = null,
},
            new Booleanboolean0M
{
    Id = 136,
    Value = false,
    ModelInner = new Booleanboolean0MI
{
    Id = 58,
    Value = false,
    NullableValue = null,
},
    NullableValue = null,
},
            new Booleanboolean0M
{
    Id = 138,
    Value = false,
    ModelInner = null,
    NullableValue = null,
},
            new Booleanboolean0M
{
    Id = 142,
    Value = false,
    ModelInner = new Booleanboolean0MI
{
    Id = 64,
    Value = false,
    NullableValue = false,
},
    NullableValue = null,
},
            new Booleanboolean0M
{
    Id = 143,
    Value = false,
    ModelInner = null,
    NullableValue = false,
},
            new Booleanboolean0M
{
    Id = 151,
    Value = false,
    ModelInner = new Booleanboolean0MI
{
    Id = 73,
    Value = false,
    NullableValue = false,
},
    NullableValue = false,
},
        };

#endregion

#region InsertModelInner

[Gedaq.MySqlConnector.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.booleanboolean0mi(
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
            asPartInterface: typeof(IBooleanSingleTypeboolean)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                parametrName: "id",
                methodParametrName: "id", 
                dbType: (MySqlConnector.MySqlDbType)(3)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Boolean),
                parametrName: "value",
                methodParametrName: "value",
                dbType: (MySqlConnector.MySqlDbType)(-1)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Boolean?), 
                parametrName: "nullablevalue",
                methodParametrName: "nullablevalue",
                dbType: (MySqlConnector.MySqlDbType)(-1))]
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

                changedRows =  ((IBooleanSingleTypeboolean)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IBooleanSingleTypeboolean)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IBooleanSingleTypeboolean)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBooleanSingleTypeboolean)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.booleanboolean0mi(
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
            asPartInterface: typeof(IBooleanSingleTypeboolean)), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Boolean), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(3)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Boolean?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(3), 
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

                changedRows =  ((IBooleanSingleTypeboolean)this).DbConnectionInsertInnerModel(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
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

                changedRows = await ((IBooleanSingleTypeboolean)this).DbConnectionInsertInnerModelAsync(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBooleanSingleTypeboolean)this).DbConnectionInsertInnerModelAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBooleanSingleTypeboolean)this).DbConnectionInsertInnerModelAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBooleanSingleTypeboolean)this).DbConnectionInsertInnerModelAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBooleanSingleTypeboolean)this).DbConnectionInsertInnerModelAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBooleanSingleTypeboolean)this).DbConnectionInsertInnerModelAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBooleanSingleTypeboolean)this).DbConnectionInsertInnerModelAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBooleanSingleTypeboolean)this).DbConnectionInsertInnerModelAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBooleanSingleTypeboolean)this).DbConnectionInsertInnerModelAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBooleanSingleTypeboolean)this).DbConnectionInsertInnerModelAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.MySqlConnector.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.booleanboolean0m(
	id,
    value,
    nullablevalue,
    booleanboolean0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @booleanboolean0mi_id
)
",
            methodName:"InsertModel",
            sourceType: SourceType.MySqlConnection,
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanSingleTypeboolean)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (MySqlConnector.MySqlDbType)(3)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Boolean), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (MySqlConnector.MySqlDbType)(-1)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Boolean?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (MySqlConnector.MySqlDbType)(-1),
                nullable: true),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "booleanboolean0mi_id", 
                methodParametrName: "booleanboolean0mi_id", 
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

                changedRows =  ((IBooleanSingleTypeboolean)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IBooleanSingleTypeboolean)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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

                changedRows = await ((IBooleanSingleTypeboolean)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBooleanSingleTypeboolean)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.booleanboolean0m(
	id,
    value,
    nullablevalue,
    booleanboolean0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @booleanboolean0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanSingleTypeboolean)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Boolean), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(3)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Boolean?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(3),
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "booleanboolean0mi_id", 
                methodParametrName: "booleanboolean0mi_id", 
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

                changedRows =  ((IBooleanSingleTypeboolean)this).DbConnectionInsertModel(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IBooleanSingleTypeboolean)this).DbConnectionInsertModel(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
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

                changedRows = await ((IBooleanSingleTypeboolean)this).DbConnectionInsertModelAsync(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBooleanSingleTypeboolean)this).DbConnectionInsertModelAsync(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBooleanSingleTypeboolean)this).DbConnectionInsertModelAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBooleanSingleTypeboolean)this).DbConnectionInsertModelAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBooleanSingleTypeboolean)this).DbConnectionInsertModelAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBooleanSingleTypeboolean)this).DbConnectionInsertModelAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBooleanSingleTypeboolean)this).DbConnectionInsertModelAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBooleanSingleTypeboolean)this).DbConnectionInsertModelAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBooleanSingleTypeboolean)this).DbConnectionInsertModelAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBooleanSingleTypeboolean)this).DbConnectionInsertModelAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBooleanSingleTypeboolean)this).DbConnectionInsertModelAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBooleanSingleTypeboolean)this).DbConnectionInsertModelAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBooleanSingleTypeboolean)this).DbConnectionInsertModelAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBooleanSingleTypeboolean)this).DbConnectionInsertModelAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBooleanSingleTypeboolean)this).DbConnectionInsertModelAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBooleanSingleTypeboolean)this).DbConnectionInsertModelAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBooleanSingleTypeboolean)this).DbConnectionInsertModelAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBooleanSingleTypeboolean)this).DbConnectionInsertModelAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBooleanSingleTypeboolean)this).DbConnectionInsertModelAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBooleanSingleTypeboolean)this).DbConnectionInsertModelAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBooleanSingleTypeboolean)this).DbConnectionInsertModelAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBooleanSingleTypeboolean)this).DbConnectionInsertModelAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBooleanSingleTypeboolean)this).DbConnectionInsertModelAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBooleanSingleTypeboolean)this).DbConnectionInsertModelAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBooleanboolean0M), typeof(FlatBooleanboolean0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanSingleTypeboolean)),
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
FROM gedaqtests.booleanboolean0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatBooleanboolean0M>();
                var models2 = new List<FlatBooleanboolean0M>();
                await((IBooleanSingleTypeboolean)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBooleanboolean0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBooleanboolean0M.AssertModel(models2[i],_testData[i], false);
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
FROM gedaqtests.booleanboolean0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatBooleanboolean0M>();
                var models2 = new List<FlatBooleanboolean0M>();
                ((IBooleanSingleTypeboolean)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBooleanboolean0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBooleanboolean0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBooleanboolean0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanSingleTypeboolean)),
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
FROM gedaqtests.booleanboolean0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
                var models = await((IBooleanSingleTypeboolean)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBooleanboolean0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.booleanboolean0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
                var models = ((IBooleanSingleTypeboolean)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBooleanboolean0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.booleanboolean0m m
LEFT JOIN gedaqtests.booleanboolean0mi mi ON mi.id = m.booleanboolean0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            sourceType: SourceType.MySqlConnection,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Booleanboolean0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanSingleTypeboolean)),
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
                var models = await((IBooleanSingleTypeboolean)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Booleanboolean0M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IBooleanSingleTypeboolean)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Booleanboolean0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBooleanboolean0M), typeof(FlatBooleanboolean0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanSingleTypeboolean)),
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
FROM gedaqtests.booleanboolean0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBooleanboolean0M>();
                var models2 = new List<FlatBooleanboolean0M>();
                await((IBooleanSingleTypeboolean)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBooleanboolean0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBooleanboolean0M.AssertModel(models2[i],_testData[i], false);
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
FROM gedaqtests.booleanboolean0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBooleanboolean0M>();
                var models2 = new List<FlatBooleanboolean0M>();
                ((IBooleanSingleTypeboolean)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBooleanboolean0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBooleanboolean0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatBooleanboolean0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanSingleTypeboolean)),
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
FROM gedaqtests.booleanboolean0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IBooleanSingleTypeboolean)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBooleanboolean0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.booleanboolean0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IBooleanSingleTypeboolean)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBooleanboolean0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.booleanboolean0m m
LEFT JOIN gedaqtests.booleanboolean0mi mi ON mi.id = m.booleanboolean0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            sourceType: SourceType.MySqlConnection,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Booleanboolean0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanSingleTypeboolean)),
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
                var models = await((IBooleanSingleTypeboolean)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Booleanboolean0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IBooleanSingleTypeboolean)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Booleanboolean0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBooleanboolean0M), typeof(FlatBooleanboolean0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanSingleTypeboolean)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanSingleTypeboolean)),
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
            asPartInterface: typeof(IBooleanSingleTypeboolean)),
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
FROM gedaqtests.booleanboolean0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatBooleanboolean0M>();
                var models2 = new List<FlatBooleanboolean0M>();
                await((IBooleanSingleTypeboolean)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBooleanboolean0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBooleanboolean0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 27;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 112;
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
FROM gedaqtests.booleanboolean0m m
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
FROM gedaqtests.booleanboolean0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBooleanboolean0M>();
                var firstItems2 = new List<FlatBooleanboolean0M>();
                var secondItems1 = new List<FlatBooleanboolean0M>();
                var secondItems2 = new List<FlatBooleanboolean0M>();
                await ((IBooleanSingleTypeboolean)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatBooleanboolean0M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[23],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatBooleanboolean0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[8],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 46;
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
FROM gedaqtests.booleanboolean0m m
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
FROM gedaqtests.booleanboolean0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBooleanboolean0M>();
                var firstItems2 = new List<FlatBooleanboolean0M>();
                var secondItems1 = new List<FlatBooleanboolean0M>();
                await ((IBooleanSingleTypeboolean)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatBooleanboolean0M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[20],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatBooleanboolean0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[5],_testData[29], false);
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
FROM gedaqtests.booleanboolean0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatBooleanboolean0M>();
                var models2 = new List<FlatBooleanboolean0M>();
                ((IBooleanSingleTypeboolean)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBooleanboolean0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBooleanboolean0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 37;
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
FROM gedaqtests.booleanboolean0m m
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
FROM gedaqtests.booleanboolean0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBooleanboolean0M>();
                var firstItems2 = new List<FlatBooleanboolean0M>();
                var secondItems1 = new List<FlatBooleanboolean0M>();
                var secondItems2 = new List<FlatBooleanboolean0M>();
                 ((IBooleanSingleTypeboolean)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatBooleanboolean0M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[21],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatBooleanboolean0M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[19],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 142;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 27;
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
FROM gedaqtests.booleanboolean0m m
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
FROM gedaqtests.booleanboolean0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBooleanboolean0M>();
                var firstItems2 = new List<FlatBooleanboolean0M>();
                var secondItems1 = new List<FlatBooleanboolean0M>();
                 ((IBooleanSingleTypeboolean)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatBooleanboolean0M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[1],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatBooleanboolean0M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[23],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBooleanboolean0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanSingleTypeboolean)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanSingleTypeboolean)),
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
            asPartInterface: typeof(IBooleanSingleTypeboolean)),
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
FROM gedaqtests.booleanboolean0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IBooleanSingleTypeboolean)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBooleanboolean0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 83;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 112;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.booleanboolean0m m
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
FROM gedaqtests.booleanboolean0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBooleanSingleTypeboolean)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatBooleanboolean0M.AssertModel(models[0],_testData[16], false);
                        FlatBooleanboolean0M.AssertModel(models[1],_testData[17], false);
                        FlatBooleanboolean0M.AssertModel(models[2],_testData[18], false);
                        FlatBooleanboolean0M.AssertModel(models[3],_testData[19], false);
                        FlatBooleanboolean0M.AssertModel(models[4],_testData[20], false);
                        FlatBooleanboolean0M.AssertModel(models[5],_testData[21], false);
                        FlatBooleanboolean0M.AssertModel(models[6],_testData[22], false);
                        FlatBooleanboolean0M.AssertModel(models[7],_testData[23], false);
                        FlatBooleanboolean0M.AssertModel(models[8],_testData[24], false);
                        FlatBooleanboolean0M.AssertModel(models[9],_testData[25], false);
                        FlatBooleanboolean0M.AssertModel(models[10],_testData[26], false);
                        FlatBooleanboolean0M.AssertModel(models[11],_testData[27], false);
                        FlatBooleanboolean0M.AssertModel(models[12],_testData[28], false);
                        FlatBooleanboolean0M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatBooleanboolean0M.AssertModel(models[0],_testData[21], false);
                        FlatBooleanboolean0M.AssertModel(models[1],_testData[22], false);
                        FlatBooleanboolean0M.AssertModel(models[2],_testData[23], false);
                        FlatBooleanboolean0M.AssertModel(models[3],_testData[24], false);
                        FlatBooleanboolean0M.AssertModel(models[4],_testData[25], false);
                        FlatBooleanboolean0M.AssertModel(models[5],_testData[26], false);
                        FlatBooleanboolean0M.AssertModel(models[6],_testData[27], false);
                        FlatBooleanboolean0M.AssertModel(models[7],_testData[28], false);
                        FlatBooleanboolean0M.AssertModel(models[8],_testData[29], false);
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
                parametr1.Value = 142;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 112;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.booleanboolean0m m
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
FROM gedaqtests.booleanboolean0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBooleanboolean0M>();
                var secondItems1 = new List<FlatBooleanboolean0M>();
                var secondItems2 = new List<FlatBooleanboolean0M>();
                await ((IBooleanSingleTypeboolean)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatBooleanboolean0M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[1],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatBooleanboolean0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[8],_testData[29], false);
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
FROM gedaqtests.booleanboolean0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IBooleanSingleTypeboolean)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBooleanboolean0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 10;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 65;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.booleanboolean0m m
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
FROM gedaqtests.booleanboolean0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBooleanSingleTypeboolean)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatBooleanboolean0M.AssertModel(models[0],_testData[2], false);
                        FlatBooleanboolean0M.AssertModel(models[1],_testData[3], false);
                        FlatBooleanboolean0M.AssertModel(models[2],_testData[4], false);
                        FlatBooleanboolean0M.AssertModel(models[3],_testData[5], false);
                        FlatBooleanboolean0M.AssertModel(models[4],_testData[6], false);
                        FlatBooleanboolean0M.AssertModel(models[5],_testData[7], false);
                        FlatBooleanboolean0M.AssertModel(models[6],_testData[8], false);
                        FlatBooleanboolean0M.AssertModel(models[7],_testData[9], false);
                        FlatBooleanboolean0M.AssertModel(models[8],_testData[10], false);
                        FlatBooleanboolean0M.AssertModel(models[9],_testData[11], false);
                        FlatBooleanboolean0M.AssertModel(models[10],_testData[12], false);
                        FlatBooleanboolean0M.AssertModel(models[11],_testData[13], false);
                        FlatBooleanboolean0M.AssertModel(models[12],_testData[14], false);
                        FlatBooleanboolean0M.AssertModel(models[13],_testData[15], false);
                        FlatBooleanboolean0M.AssertModel(models[14],_testData[16], false);
                        FlatBooleanboolean0M.AssertModel(models[15],_testData[17], false);
                        FlatBooleanboolean0M.AssertModel(models[16],_testData[18], false);
                        FlatBooleanboolean0M.AssertModel(models[17],_testData[19], false);
                        FlatBooleanboolean0M.AssertModel(models[18],_testData[20], false);
                        FlatBooleanboolean0M.AssertModel(models[19],_testData[21], false);
                        FlatBooleanboolean0M.AssertModel(models[20],_testData[22], false);
                        FlatBooleanboolean0M.AssertModel(models[21],_testData[23], false);
                        FlatBooleanboolean0M.AssertModel(models[22],_testData[24], false);
                        FlatBooleanboolean0M.AssertModel(models[23],_testData[25], false);
                        FlatBooleanboolean0M.AssertModel(models[24],_testData[26], false);
                        FlatBooleanboolean0M.AssertModel(models[25],_testData[27], false);
                        FlatBooleanboolean0M.AssertModel(models[26],_testData[28], false);
                        FlatBooleanboolean0M.AssertModel(models[27],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatBooleanboolean0M.AssertModel(models[0],_testData[12], false);
                        FlatBooleanboolean0M.AssertModel(models[1],_testData[13], false);
                        FlatBooleanboolean0M.AssertModel(models[2],_testData[14], false);
                        FlatBooleanboolean0M.AssertModel(models[3],_testData[15], false);
                        FlatBooleanboolean0M.AssertModel(models[4],_testData[16], false);
                        FlatBooleanboolean0M.AssertModel(models[5],_testData[17], false);
                        FlatBooleanboolean0M.AssertModel(models[6],_testData[18], false);
                        FlatBooleanboolean0M.AssertModel(models[7],_testData[19], false);
                        FlatBooleanboolean0M.AssertModel(models[8],_testData[20], false);
                        FlatBooleanboolean0M.AssertModel(models[9],_testData[21], false);
                        FlatBooleanboolean0M.AssertModel(models[10],_testData[22], false);
                        FlatBooleanboolean0M.AssertModel(models[11],_testData[23], false);
                        FlatBooleanboolean0M.AssertModel(models[12],_testData[24], false);
                        FlatBooleanboolean0M.AssertModel(models[13],_testData[25], false);
                        FlatBooleanboolean0M.AssertModel(models[14],_testData[26], false);
                        FlatBooleanboolean0M.AssertModel(models[15],_testData[27], false);
                        FlatBooleanboolean0M.AssertModel(models[16],_testData[28], false);
                        FlatBooleanboolean0M.AssertModel(models[17],_testData[29], false);
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
                parametr1.Value = 20;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 136;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.booleanboolean0m m
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
FROM gedaqtests.booleanboolean0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBooleanboolean0M>();
                var secondItems1 = new List<FlatBooleanboolean0M>();
                var secondItems2 = new List<FlatBooleanboolean0M>();
                 ((IBooleanSingleTypeboolean)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                        FlatBooleanboolean0M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[25],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatBooleanboolean0M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[3],_testData[29], false);
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
FROM gedaqtests.booleanboolean0m m
LEFT JOIN gedaqtests.booleanboolean0mi mi ON mi.id = m.booleanboolean0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Booleanboolean0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanSingleTypeboolean)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanSingleTypeboolean)),
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
                var models = await((IBooleanSingleTypeboolean)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Booleanboolean0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 17;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 122;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBooleanSingleTypeboolean)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        Booleanboolean0M.AssertModel(models[0],_testData[3], false);
                        Booleanboolean0M.AssertModel(models[1],_testData[4], false);
                        Booleanboolean0M.AssertModel(models[2],_testData[5], false);
                        Booleanboolean0M.AssertModel(models[3],_testData[6], false);
                        Booleanboolean0M.AssertModel(models[4],_testData[7], false);
                        Booleanboolean0M.AssertModel(models[5],_testData[8], false);
                        Booleanboolean0M.AssertModel(models[6],_testData[9], false);
                        Booleanboolean0M.AssertModel(models[7],_testData[10], false);
                        Booleanboolean0M.AssertModel(models[8],_testData[11], false);
                        Booleanboolean0M.AssertModel(models[9],_testData[12], false);
                        Booleanboolean0M.AssertModel(models[10],_testData[13], false);
                        Booleanboolean0M.AssertModel(models[11],_testData[14], false);
                        Booleanboolean0M.AssertModel(models[12],_testData[15], false);
                        Booleanboolean0M.AssertModel(models[13],_testData[16], false);
                        Booleanboolean0M.AssertModel(models[14],_testData[17], false);
                        Booleanboolean0M.AssertModel(models[15],_testData[18], false);
                        Booleanboolean0M.AssertModel(models[16],_testData[19], false);
                        Booleanboolean0M.AssertModel(models[17],_testData[20], false);
                        Booleanboolean0M.AssertModel(models[18],_testData[21], false);
                        Booleanboolean0M.AssertModel(models[19],_testData[22], false);
                        Booleanboolean0M.AssertModel(models[20],_testData[23], false);
                        Booleanboolean0M.AssertModel(models[21],_testData[24], false);
                        Booleanboolean0M.AssertModel(models[22],_testData[25], false);
                        Booleanboolean0M.AssertModel(models[23],_testData[26], false);
                        Booleanboolean0M.AssertModel(models[24],_testData[27], false);
                        Booleanboolean0M.AssertModel(models[25],_testData[28], false);
                        Booleanboolean0M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        Booleanboolean0M.AssertModel(models[0],_testData[23], false);
                        Booleanboolean0M.AssertModel(models[1],_testData[24], false);
                        Booleanboolean0M.AssertModel(models[2],_testData[25], false);
                        Booleanboolean0M.AssertModel(models[3],_testData[26], false);
                        Booleanboolean0M.AssertModel(models[4],_testData[27], false);
                        Booleanboolean0M.AssertModel(models[5],_testData[28], false);
                        Booleanboolean0M.AssertModel(models[6],_testData[29], false);
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
                var models = ((IBooleanSingleTypeboolean)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Booleanboolean0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 119;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 56;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBooleanSingleTypeboolean)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        Booleanboolean0M.AssertModel(models[0],_testData[22], false);
                        Booleanboolean0M.AssertModel(models[1],_testData[23], false);
                        Booleanboolean0M.AssertModel(models[2],_testData[24], false);
                        Booleanboolean0M.AssertModel(models[3],_testData[25], false);
                        Booleanboolean0M.AssertModel(models[4],_testData[26], false);
                        Booleanboolean0M.AssertModel(models[5],_testData[27], false);
                        Booleanboolean0M.AssertModel(models[6],_testData[28], false);
                        Booleanboolean0M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        Booleanboolean0M.AssertModel(models[0],_testData[11], false);
                        Booleanboolean0M.AssertModel(models[1],_testData[12], false);
                        Booleanboolean0M.AssertModel(models[2],_testData[13], false);
                        Booleanboolean0M.AssertModel(models[3],_testData[14], false);
                        Booleanboolean0M.AssertModel(models[4],_testData[15], false);
                        Booleanboolean0M.AssertModel(models[5],_testData[16], false);
                        Booleanboolean0M.AssertModel(models[6],_testData[17], false);
                        Booleanboolean0M.AssertModel(models[7],_testData[18], false);
                        Booleanboolean0M.AssertModel(models[8],_testData[19], false);
                        Booleanboolean0M.AssertModel(models[9],_testData[20], false);
                        Booleanboolean0M.AssertModel(models[10],_testData[21], false);
                        Booleanboolean0M.AssertModel(models[11],_testData[22], false);
                        Booleanboolean0M.AssertModel(models[12],_testData[23], false);
                        Booleanboolean0M.AssertModel(models[13],_testData[24], false);
                        Booleanboolean0M.AssertModel(models[14],_testData[25], false);
                        Booleanboolean0M.AssertModel(models[15],_testData[26], false);
                        Booleanboolean0M.AssertModel(models[16],_testData[27], false);
                        Booleanboolean0M.AssertModel(models[17],_testData[28], false);
                        Booleanboolean0M.AssertModel(models[18],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBooleanboolean0M), typeof(FlatBooleanboolean0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanSingleTypeboolean)),
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
            asPartInterface: typeof(IBooleanSingleTypeboolean)),
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
            asPartInterface: typeof(IBooleanSingleTypeboolean)),
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
FROM gedaqtests.booleanboolean0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBooleanboolean0M>();
                var models2 = new List<FlatBooleanboolean0M>();
                await((IBooleanSingleTypeboolean)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBooleanboolean0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBooleanboolean0M.AssertModel(models2[i],_testData[i], false);
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
FROM gedaqtests.booleanboolean0m m
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
FROM gedaqtests.booleanboolean0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBooleanboolean0M>();
                var firstItems2 = new List<FlatBooleanboolean0M>();
                var secondItems1 = new List<FlatBooleanboolean0M>();
                var secondItems2 = new List<FlatBooleanboolean0M>();
                await ((IBooleanSingleTypeboolean)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 119, query1, 131, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatBooleanboolean0M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[7],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatBooleanboolean0M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[4],_testData[29], false);
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
FROM gedaqtests.booleanboolean0m m
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
FROM gedaqtests.booleanboolean0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBooleanboolean0M>();
                var firstItems2 = new List<FlatBooleanboolean0M>();
                var secondItems1 = new List<FlatBooleanboolean0M>();
                await ((IBooleanSingleTypeboolean)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 91, query1, 123, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatBooleanboolean0M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[12],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatBooleanboolean0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[5],_testData[29], false);
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
FROM gedaqtests.booleanboolean0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBooleanboolean0M>();
                var models2 = new List<FlatBooleanboolean0M>();
                ((IBooleanSingleTypeboolean)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBooleanboolean0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBooleanboolean0M.AssertModel(models2[i],_testData[i], false);
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
FROM gedaqtests.booleanboolean0m m
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
FROM gedaqtests.booleanboolean0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBooleanboolean0M>();
                var firstItems2 = new List<FlatBooleanboolean0M>();
                var secondItems1 = new List<FlatBooleanboolean0M>();
                var secondItems2 = new List<FlatBooleanboolean0M>();
                 ((IBooleanSingleTypeboolean)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 105, query1, 20, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatBooleanboolean0M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[9],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatBooleanboolean0M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[25],_testData[29], false);
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
FROM gedaqtests.booleanboolean0m m
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
FROM gedaqtests.booleanboolean0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBooleanboolean0M>();
                var firstItems2 = new List<FlatBooleanboolean0M>();
                var secondItems1 = new List<FlatBooleanboolean0M>();
                 ((IBooleanSingleTypeboolean)this).DbConnectionMMDynQuerySelectModelBatch(connection, 92, query1, 37, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatBooleanboolean0M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatBooleanboolean0M.AssertModel(firstItems2[11],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatBooleanboolean0M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[21],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBooleanboolean0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanSingleTypeboolean)),
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
            asPartInterface: typeof(IBooleanSingleTypeboolean)),
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
            asPartInterface: typeof(IBooleanSingleTypeboolean)),
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
FROM gedaqtests.booleanboolean0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IBooleanSingleTypeboolean)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBooleanboolean0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.booleanboolean0m m
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
FROM gedaqtests.booleanboolean0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBooleanSingleTypeboolean)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 6, query1, 27, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatBooleanboolean0M.AssertModel(models[0],_testData[1], false);
                        FlatBooleanboolean0M.AssertModel(models[1],_testData[2], false);
                        FlatBooleanboolean0M.AssertModel(models[2],_testData[3], false);
                        FlatBooleanboolean0M.AssertModel(models[3],_testData[4], false);
                        FlatBooleanboolean0M.AssertModel(models[4],_testData[5], false);
                        FlatBooleanboolean0M.AssertModel(models[5],_testData[6], false);
                        FlatBooleanboolean0M.AssertModel(models[6],_testData[7], false);
                        FlatBooleanboolean0M.AssertModel(models[7],_testData[8], false);
                        FlatBooleanboolean0M.AssertModel(models[8],_testData[9], false);
                        FlatBooleanboolean0M.AssertModel(models[9],_testData[10], false);
                        FlatBooleanboolean0M.AssertModel(models[10],_testData[11], false);
                        FlatBooleanboolean0M.AssertModel(models[11],_testData[12], false);
                        FlatBooleanboolean0M.AssertModel(models[12],_testData[13], false);
                        FlatBooleanboolean0M.AssertModel(models[13],_testData[14], false);
                        FlatBooleanboolean0M.AssertModel(models[14],_testData[15], false);
                        FlatBooleanboolean0M.AssertModel(models[15],_testData[16], false);
                        FlatBooleanboolean0M.AssertModel(models[16],_testData[17], false);
                        FlatBooleanboolean0M.AssertModel(models[17],_testData[18], false);
                        FlatBooleanboolean0M.AssertModel(models[18],_testData[19], false);
                        FlatBooleanboolean0M.AssertModel(models[19],_testData[20], false);
                        FlatBooleanboolean0M.AssertModel(models[20],_testData[21], false);
                        FlatBooleanboolean0M.AssertModel(models[21],_testData[22], false);
                        FlatBooleanboolean0M.AssertModel(models[22],_testData[23], false);
                        FlatBooleanboolean0M.AssertModel(models[23],_testData[24], false);
                        FlatBooleanboolean0M.AssertModel(models[24],_testData[25], false);
                        FlatBooleanboolean0M.AssertModel(models[25],_testData[26], false);
                        FlatBooleanboolean0M.AssertModel(models[26],_testData[27], false);
                        FlatBooleanboolean0M.AssertModel(models[27],_testData[28], false);
                        FlatBooleanboolean0M.AssertModel(models[28],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatBooleanboolean0M.AssertModel(models[0],_testData[6], false);
                        FlatBooleanboolean0M.AssertModel(models[1],_testData[7], false);
                        FlatBooleanboolean0M.AssertModel(models[2],_testData[8], false);
                        FlatBooleanboolean0M.AssertModel(models[3],_testData[9], false);
                        FlatBooleanboolean0M.AssertModel(models[4],_testData[10], false);
                        FlatBooleanboolean0M.AssertModel(models[5],_testData[11], false);
                        FlatBooleanboolean0M.AssertModel(models[6],_testData[12], false);
                        FlatBooleanboolean0M.AssertModel(models[7],_testData[13], false);
                        FlatBooleanboolean0M.AssertModel(models[8],_testData[14], false);
                        FlatBooleanboolean0M.AssertModel(models[9],_testData[15], false);
                        FlatBooleanboolean0M.AssertModel(models[10],_testData[16], false);
                        FlatBooleanboolean0M.AssertModel(models[11],_testData[17], false);
                        FlatBooleanboolean0M.AssertModel(models[12],_testData[18], false);
                        FlatBooleanboolean0M.AssertModel(models[13],_testData[19], false);
                        FlatBooleanboolean0M.AssertModel(models[14],_testData[20], false);
                        FlatBooleanboolean0M.AssertModel(models[15],_testData[21], false);
                        FlatBooleanboolean0M.AssertModel(models[16],_testData[22], false);
                        FlatBooleanboolean0M.AssertModel(models[17],_testData[23], false);
                        FlatBooleanboolean0M.AssertModel(models[18],_testData[24], false);
                        FlatBooleanboolean0M.AssertModel(models[19],_testData[25], false);
                        FlatBooleanboolean0M.AssertModel(models[20],_testData[26], false);
                        FlatBooleanboolean0M.AssertModel(models[21],_testData[27], false);
                        FlatBooleanboolean0M.AssertModel(models[22],_testData[28], false);
                        FlatBooleanboolean0M.AssertModel(models[23],_testData[29], false);
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
FROM gedaqtests.booleanboolean0m m
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
FROM gedaqtests.booleanboolean0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBooleanboolean0M>();
                var secondItems1 = new List<FlatBooleanboolean0M>();
                var secondItems2 = new List<FlatBooleanboolean0M>();
                await ((IBooleanSingleTypeboolean)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 10, query1, 138, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatBooleanboolean0M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[27],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatBooleanboolean0M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[2],_testData[29], false);
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
FROM gedaqtests.booleanboolean0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IBooleanSingleTypeboolean)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBooleanboolean0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.booleanboolean0m m
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
FROM gedaqtests.booleanboolean0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBooleanSingleTypeboolean)this).DbConnectionSTDynQuerySelectModelBatch(connection, 56, query1, 91, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatBooleanboolean0M.AssertModel(models[0],_testData[11], false);
                        FlatBooleanboolean0M.AssertModel(models[1],_testData[12], false);
                        FlatBooleanboolean0M.AssertModel(models[2],_testData[13], false);
                        FlatBooleanboolean0M.AssertModel(models[3],_testData[14], false);
                        FlatBooleanboolean0M.AssertModel(models[4],_testData[15], false);
                        FlatBooleanboolean0M.AssertModel(models[5],_testData[16], false);
                        FlatBooleanboolean0M.AssertModel(models[6],_testData[17], false);
                        FlatBooleanboolean0M.AssertModel(models[7],_testData[18], false);
                        FlatBooleanboolean0M.AssertModel(models[8],_testData[19], false);
                        FlatBooleanboolean0M.AssertModel(models[9],_testData[20], false);
                        FlatBooleanboolean0M.AssertModel(models[10],_testData[21], false);
                        FlatBooleanboolean0M.AssertModel(models[11],_testData[22], false);
                        FlatBooleanboolean0M.AssertModel(models[12],_testData[23], false);
                        FlatBooleanboolean0M.AssertModel(models[13],_testData[24], false);
                        FlatBooleanboolean0M.AssertModel(models[14],_testData[25], false);
                        FlatBooleanboolean0M.AssertModel(models[15],_testData[26], false);
                        FlatBooleanboolean0M.AssertModel(models[16],_testData[27], false);
                        FlatBooleanboolean0M.AssertModel(models[17],_testData[28], false);
                        FlatBooleanboolean0M.AssertModel(models[18],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatBooleanboolean0M.AssertModel(models[0],_testData[17], false);
                        FlatBooleanboolean0M.AssertModel(models[1],_testData[18], false);
                        FlatBooleanboolean0M.AssertModel(models[2],_testData[19], false);
                        FlatBooleanboolean0M.AssertModel(models[3],_testData[20], false);
                        FlatBooleanboolean0M.AssertModel(models[4],_testData[21], false);
                        FlatBooleanboolean0M.AssertModel(models[5],_testData[22], false);
                        FlatBooleanboolean0M.AssertModel(models[6],_testData[23], false);
                        FlatBooleanboolean0M.AssertModel(models[7],_testData[24], false);
                        FlatBooleanboolean0M.AssertModel(models[8],_testData[25], false);
                        FlatBooleanboolean0M.AssertModel(models[9],_testData[26], false);
                        FlatBooleanboolean0M.AssertModel(models[10],_testData[27], false);
                        FlatBooleanboolean0M.AssertModel(models[11],_testData[28], false);
                        FlatBooleanboolean0M.AssertModel(models[12],_testData[29], false);
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
FROM gedaqtests.booleanboolean0m m
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
FROM gedaqtests.booleanboolean0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBooleanboolean0M>();
                var secondItems1 = new List<FlatBooleanboolean0M>();
                var secondItems2 = new List<FlatBooleanboolean0M>();
                 ((IBooleanSingleTypeboolean)this).DbConnectionDynQuerySelectModelBatch(connection, 138, query1, 136, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatBooleanboolean0M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatBooleanboolean0M.AssertModel(firstItems1[2],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatBooleanboolean0M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatBooleanboolean0M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatBooleanboolean0M.AssertModel(secondItems2[3],_testData[29], false);
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
FROM gedaqtests.booleanboolean0m m
LEFT JOIN gedaqtests.booleanboolean0mi mi ON mi.id = m.booleanboolean0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Booleanboolean0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanSingleTypeboolean)),
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
            asPartInterface: typeof(IBooleanSingleTypeboolean)),
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
                var models = await((IBooleanSingleTypeboolean)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Booleanboolean0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IBooleanSingleTypeboolean)this).DbConnectionSTSelectModelBatchAsync(connection, 136, 10))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        Booleanboolean0M.AssertModel(models[0],_testData[26], false);
                        Booleanboolean0M.AssertModel(models[1],_testData[27], false);
                        Booleanboolean0M.AssertModel(models[2],_testData[28], false);
                        Booleanboolean0M.AssertModel(models[3],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        Booleanboolean0M.AssertModel(models[0],_testData[2], false);
                        Booleanboolean0M.AssertModel(models[1],_testData[3], false);
                        Booleanboolean0M.AssertModel(models[2],_testData[4], false);
                        Booleanboolean0M.AssertModel(models[3],_testData[5], false);
                        Booleanboolean0M.AssertModel(models[4],_testData[6], false);
                        Booleanboolean0M.AssertModel(models[5],_testData[7], false);
                        Booleanboolean0M.AssertModel(models[6],_testData[8], false);
                        Booleanboolean0M.AssertModel(models[7],_testData[9], false);
                        Booleanboolean0M.AssertModel(models[8],_testData[10], false);
                        Booleanboolean0M.AssertModel(models[9],_testData[11], false);
                        Booleanboolean0M.AssertModel(models[10],_testData[12], false);
                        Booleanboolean0M.AssertModel(models[11],_testData[13], false);
                        Booleanboolean0M.AssertModel(models[12],_testData[14], false);
                        Booleanboolean0M.AssertModel(models[13],_testData[15], false);
                        Booleanboolean0M.AssertModel(models[14],_testData[16], false);
                        Booleanboolean0M.AssertModel(models[15],_testData[17], false);
                        Booleanboolean0M.AssertModel(models[16],_testData[18], false);
                        Booleanboolean0M.AssertModel(models[17],_testData[19], false);
                        Booleanboolean0M.AssertModel(models[18],_testData[20], false);
                        Booleanboolean0M.AssertModel(models[19],_testData[21], false);
                        Booleanboolean0M.AssertModel(models[20],_testData[22], false);
                        Booleanboolean0M.AssertModel(models[21],_testData[23], false);
                        Booleanboolean0M.AssertModel(models[22],_testData[24], false);
                        Booleanboolean0M.AssertModel(models[23],_testData[25], false);
                        Booleanboolean0M.AssertModel(models[24],_testData[26], false);
                        Booleanboolean0M.AssertModel(models[25],_testData[27], false);
                        Booleanboolean0M.AssertModel(models[26],_testData[28], false);
                        Booleanboolean0M.AssertModel(models[27],_testData[29], false);
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
                var models = ((IBooleanSingleTypeboolean)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Booleanboolean0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IBooleanSingleTypeboolean)this).DbConnectionSTSelectModelBatch(connection, 122, 136))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        Booleanboolean0M.AssertModel(models[0],_testData[23], false);
                        Booleanboolean0M.AssertModel(models[1],_testData[24], false);
                        Booleanboolean0M.AssertModel(models[2],_testData[25], false);
                        Booleanboolean0M.AssertModel(models[3],_testData[26], false);
                        Booleanboolean0M.AssertModel(models[4],_testData[27], false);
                        Booleanboolean0M.AssertModel(models[5],_testData[28], false);
                        Booleanboolean0M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        Booleanboolean0M.AssertModel(models[0],_testData[26], false);
                        Booleanboolean0M.AssertModel(models[1],_testData[27], false);
                        Booleanboolean0M.AssertModel(models[2],_testData[28], false);
                        Booleanboolean0M.AssertModel(models[3],_testData[29], false);
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
                await using var cmd = await ((IBooleanSingleTypeboolean)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IBooleanSingleTypeboolean)this).SetDbConnectionSelectModelParametrs(cmd, 136);
                var models = await ((IBooleanSingleTypeboolean)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(4));
Booleanboolean0M.AssertModel(models[0],_testData[26], false);Booleanboolean0M.AssertModel(models[1],_testData[27], false);Booleanboolean0M.AssertModel(models[2],_testData[28], false);Booleanboolean0M.AssertModel(models[3],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IBooleanSingleTypeboolean)this).CreateDbConnectionSelectModelCommand(connection);
                ((IBooleanSingleTypeboolean)this).SetDbConnectionSelectModelParametrs(cmd, 55);
                var models =  ((IBooleanSingleTypeboolean)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(20));
Booleanboolean0M.AssertModel(models[0],_testData[10], false);Booleanboolean0M.AssertModel(models[1],_testData[11], false);Booleanboolean0M.AssertModel(models[2],_testData[12], false);Booleanboolean0M.AssertModel(models[3],_testData[13], false);Booleanboolean0M.AssertModel(models[4],_testData[14], false);Booleanboolean0M.AssertModel(models[5],_testData[15], false);Booleanboolean0M.AssertModel(models[6],_testData[16], false);Booleanboolean0M.AssertModel(models[7],_testData[17], false);Booleanboolean0M.AssertModel(models[8],_testData[18], false);Booleanboolean0M.AssertModel(models[9],_testData[19], false);Booleanboolean0M.AssertModel(models[10],_testData[20], false);Booleanboolean0M.AssertModel(models[11],_testData[21], false);Booleanboolean0M.AssertModel(models[12],_testData[22], false);Booleanboolean0M.AssertModel(models[13],_testData[23], false);Booleanboolean0M.AssertModel(models[14],_testData[24], false);Booleanboolean0M.AssertModel(models[15],_testData[25], false);Booleanboolean0M.AssertModel(models[16],_testData[26], false);Booleanboolean0M.AssertModel(models[17],_testData[27], false);Booleanboolean0M.AssertModel(models[18],_testData[28], false);Booleanboolean0M.AssertModel(models[19],_testData[29], false);
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
FROM gedaqtests.booleanboolean0m m
LEFT JOIN gedaqtests.booleanboolean0mi mi ON mi.id = m.booleanboolean0mi_id
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
            asPartInterface: typeof(IBooleanSingleTypeboolean))]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IBooleanSingleTypeboolean)this).DbConnectionSelectModelToObjArrAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((5)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((System.Boolean?)model[4], Is.EqualTo((false)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((21)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((System.Boolean?)model[4], Is.EqualTo((false)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((System.Boolean?)model[4], Is.EqualTo((false)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((System.Boolean?)model[4], Is.EqualTo((false)));//InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((83)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((96)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((System.Boolean?)model[4], Is.EqualTo((false)));//InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((142)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((System.Boolean?)model[4], Is.EqualTo((false)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((73)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((System.Boolean?)model[4], Is.EqualTo((false)));//InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((IBooleanSingleTypeboolean)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((5)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((System.Boolean?)model[4], Is.EqualTo((false)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((21)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((System.Boolean?)model[4], Is.EqualTo((false)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((System.Boolean?)model[4], Is.EqualTo((false)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((System.Boolean?)model[4], Is.EqualTo((false)));//InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((83)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((96)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((System.Boolean?)model[4], Is.EqualTo((false)));//InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((142)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((System.Boolean?)model[4], Is.EqualTo((false)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((73)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((System.Boolean?)model[4], Is.EqualTo((false)));//InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

            }
        }

#endregion

    }
}

