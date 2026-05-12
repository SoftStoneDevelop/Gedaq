

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

        private readonly BooleanbooleanE0M[] _testData = new BooleanbooleanE0M[]
        {
            new BooleanbooleanE0M
{
    Id = 6,
    Value = false,
    ModelInner = null,
    NullableValue = null,
},
            new BooleanbooleanE0M
{
    Id = 14,
    Value = false,
    ModelInner = new BooleanbooleanE0MI
{
    Id = 6,
    Value = false,
    NullableValue = null,
},
    NullableValue = false,
},
            new BooleanbooleanE0M
{
    Id = 15,
    Value = false,
    ModelInner = null,
    NullableValue = null,
},
            new BooleanbooleanE0M
{
    Id = 17,
    Value = false,
    ModelInner = new BooleanbooleanE0MI
{
    Id = 8,
    Value = false,
    NullableValue = false,
},
    NullableValue = false,
},
            new BooleanbooleanE0M
{
    Id = 18,
    Value = false,
    ModelInner = null,
    NullableValue = false,
},
            new BooleanbooleanE0M
{
    Id = 27,
    Value = false,
    ModelInner = new BooleanbooleanE0MI
{
    Id = 10,
    Value = false,
    NullableValue = false,
},
    NullableValue = null,
},
            new BooleanbooleanE0M
{
    Id = 35,
    Value = false,
    ModelInner = null,
    NullableValue = null,
},
            new BooleanbooleanE0M
{
    Id = 43,
    Value = false,
    ModelInner = new BooleanbooleanE0MI
{
    Id = 17,
    Value = false,
    NullableValue = null,
},
    NullableValue = false,
},
            new BooleanbooleanE0M
{
    Id = 46,
    Value = false,
    ModelInner = null,
    NullableValue = null,
},
            new BooleanbooleanE0M
{
    Id = 50,
    Value = false,
    ModelInner = new BooleanbooleanE0MI
{
    Id = 24,
    Value = false,
    NullableValue = false,
},
    NullableValue = null,
},
            new BooleanbooleanE0M
{
    Id = 53,
    Value = false,
    ModelInner = null,
    NullableValue = null,
},
            new BooleanbooleanE0M
{
    Id = 57,
    Value = false,
    ModelInner = new BooleanbooleanE0MI
{
    Id = 31,
    Value = false,
    NullableValue = false,
},
    NullableValue = false,
},
            new BooleanbooleanE0M
{
    Id = 60,
    Value = false,
    ModelInner = null,
    NullableValue = false,
},
            new BooleanbooleanE0M
{
    Id = 67,
    Value = false,
    ModelInner = new BooleanbooleanE0MI
{
    Id = 40,
    Value = false,
    NullableValue = false,
},
    NullableValue = null,
},
            new BooleanbooleanE0M
{
    Id = 71,
    Value = false,
    ModelInner = null,
    NullableValue = false,
},
            new BooleanbooleanE0M
{
    Id = 73,
    Value = false,
    ModelInner = new BooleanbooleanE0MI
{
    Id = 46,
    Value = false,
    NullableValue = false,
},
    NullableValue = null,
},
            new BooleanbooleanE0M
{
    Id = 77,
    Value = false,
    ModelInner = null,
    NullableValue = null,
},
            new BooleanbooleanE0M
{
    Id = 78,
    Value = false,
    ModelInner = new BooleanbooleanE0MI
{
    Id = 51,
    Value = false,
    NullableValue = null,
},
    NullableValue = false,
},
            new BooleanbooleanE0M
{
    Id = 80,
    Value = false,
    ModelInner = null,
    NullableValue = false,
},
            new BooleanbooleanE0M
{
    Id = 88,
    Value = false,
    ModelInner = new BooleanbooleanE0MI
{
    Id = 59,
    Value = false,
    NullableValue = false,
},
    NullableValue = null,
},
            new BooleanbooleanE0M
{
    Id = 89,
    Value = false,
    ModelInner = null,
    NullableValue = false,
},
            new BooleanbooleanE0M
{
    Id = 98,
    Value = false,
    ModelInner = new BooleanbooleanE0MI
{
    Id = 60,
    Value = false,
    NullableValue = false,
},
    NullableValue = null,
},
            new BooleanbooleanE0M
{
    Id = 106,
    Value = false,
    ModelInner = null,
    NullableValue = false,
},
            new BooleanbooleanE0M
{
    Id = 114,
    Value = false,
    ModelInner = new BooleanbooleanE0MI
{
    Id = 65,
    Value = false,
    NullableValue = null,
},
    NullableValue = false,
},
            new BooleanbooleanE0M
{
    Id = 117,
    Value = false,
    ModelInner = null,
    NullableValue = null,
},
            new BooleanbooleanE0M
{
    Id = 122,
    Value = false,
    ModelInner = new BooleanbooleanE0MI
{
    Id = 66,
    Value = false,
    NullableValue = false,
},
    NullableValue = false,
},
            new BooleanbooleanE0M
{
    Id = 125,
    Value = false,
    ModelInner = null,
    NullableValue = false,
},
            new BooleanbooleanE0M
{
    Id = 126,
    Value = false,
    ModelInner = new BooleanbooleanE0MI
{
    Id = 70,
    Value = false,
    NullableValue = false,
},
    NullableValue = false,
},
            new BooleanbooleanE0M
{
    Id = 127,
    Value = false,
    ModelInner = null,
    NullableValue = null,
},
            new BooleanbooleanE0M
{
    Id = 131,
    Value = false,
    ModelInner = new BooleanbooleanE0MI
{
    Id = 76,
    Value = false,
    NullableValue = false,
},
    NullableValue = null,
},
            new BooleanbooleanE0M
{
    Id = 133,
    Value = false,
    ModelInner = null,
    NullableValue = null,
},
            new BooleanbooleanE0M
{
    Id = 135,
    Value = false,
    ModelInner = new BooleanbooleanE0MI
{
    Id = 78,
    Value = false,
    NullableValue = false,
},
    NullableValue = null,
},
            new BooleanbooleanE0M
{
    Id = 143,
    Value = false,
    ModelInner = null,
    NullableValue = null,
},
            new BooleanbooleanE0M
{
    Id = 145,
    Value = false,
    ModelInner = new BooleanbooleanE0MI
{
    Id = 87,
    Value = false,
    NullableValue = null,
},
    NullableValue = false,
},
            new BooleanbooleanE0M
{
    Id = 148,
    Value = false,
    ModelInner = null,
    NullableValue = false,
},
        };

#endregion

#region InsertModelInner

[Gedaq.MySqlConnector.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.booleanbooleane0mi(
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
INSERT INTO gedaqtests.booleanbooleane0mi(
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

                changedRows = await ((IBooleanSingleTypeboolean)this).DbConnectionInsertInnerModelAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBooleanSingleTypeboolean)this).DbConnectionInsertInnerModelAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.MySqlConnector.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.booleanbooleane0m(
	id,
    value,
    nullablevalue,
    booleanbooleane0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @booleanbooleane0mi_id
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
                parametrName: "booleanbooleane0mi_id", 
                methodParametrName: "booleanbooleane0mi_id", 
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
INSERT INTO gedaqtests.booleanbooleane0m(
	id,
    value,
    nullablevalue,
    booleanbooleane0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @booleanbooleane0mi_id
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
                parametrName: "booleanbooleane0mi_id", 
                methodParametrName: "booleanbooleane0mi_id", 
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

                changedRows = await ((IBooleanSingleTypeboolean)this).DbConnectionInsertModelAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBooleanSingleTypeboolean)this).DbConnectionInsertModelAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBooleanSingleTypeboolean)this).DbConnectionInsertModelAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBooleanSingleTypeboolean)this).DbConnectionInsertModelAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBooleanSingleTypeboolean)this).DbConnectionInsertModelAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBooleanbooleanE0M), typeof(FlatBooleanbooleanE0M)],
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
FROM gedaqtests.booleanbooleane0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatBooleanbooleanE0M>();
                var models2 = new List<FlatBooleanbooleanE0M>();
                await((IBooleanSingleTypeboolean)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBooleanbooleanE0M.AssertModel(models1[i],_testData[i], false);
                    FlatBooleanbooleanE0M.AssertModel(models2[i],_testData[i], false);
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
FROM gedaqtests.booleanbooleane0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatBooleanbooleanE0M>();
                var models2 = new List<FlatBooleanbooleanE0M>();
                ((IBooleanSingleTypeboolean)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBooleanbooleanE0M.AssertModel(models1[i],_testData[i], false);
                    FlatBooleanbooleanE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBooleanbooleanE0M)],
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
FROM gedaqtests.booleanbooleane0m m
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBooleanbooleanE0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.booleanbooleane0m m
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBooleanbooleanE0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.booleanbooleane0m m
LEFT JOIN gedaqtests.booleanbooleane0mi mi ON mi.id = m.booleanbooleane0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            sourceType: SourceType.MySqlConnection,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(BooleanbooleanE0M)],
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BooleanbooleanE0M.AssertModel(models[i],_testData[i], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BooleanbooleanE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBooleanbooleanE0M), typeof(FlatBooleanbooleanE0M)],
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
FROM gedaqtests.booleanbooleane0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBooleanbooleanE0M>();
                var models2 = new List<FlatBooleanbooleanE0M>();
                await((IBooleanSingleTypeboolean)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBooleanbooleanE0M.AssertModel(models1[i],_testData[i], false);
                    FlatBooleanbooleanE0M.AssertModel(models2[i],_testData[i], false);
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
FROM gedaqtests.booleanbooleane0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBooleanbooleanE0M>();
                var models2 = new List<FlatBooleanbooleanE0M>();
                ((IBooleanSingleTypeboolean)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBooleanbooleanE0M.AssertModel(models1[i],_testData[i], false);
                    FlatBooleanbooleanE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatBooleanbooleanE0M)],
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
FROM gedaqtests.booleanbooleane0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IBooleanSingleTypeboolean)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBooleanbooleanE0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.booleanbooleane0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IBooleanSingleTypeboolean)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBooleanbooleanE0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.booleanbooleane0m m
LEFT JOIN gedaqtests.booleanbooleane0mi mi ON mi.id = m.booleanbooleane0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            sourceType: SourceType.MySqlConnection,
            methodName:"SelectModel",
            queryMapTypes: [typeof(BooleanbooleanE0M)],
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BooleanbooleanE0M.AssertModel(models[i],_testData[i], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BooleanbooleanE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBooleanbooleanE0M), typeof(FlatBooleanbooleanE0M)],
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
FROM gedaqtests.booleanbooleane0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatBooleanbooleanE0M>();
                var models2 = new List<FlatBooleanbooleanE0M>();
                await((IBooleanSingleTypeboolean)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBooleanbooleanE0M.AssertModel(models1[i],_testData[i], false);
                    FlatBooleanbooleanE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 117;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 126;
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
FROM gedaqtests.booleanbooleane0m m
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
FROM gedaqtests.booleanbooleane0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBooleanbooleanE0M>();
                var firstItems2 = new List<FlatBooleanbooleanE0M>();
                var secondItems1 = new List<FlatBooleanbooleanE0M>();
                var secondItems2 = new List<FlatBooleanbooleanE0M>();
                await ((IBooleanSingleTypeboolean)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[6],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 6;
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
FROM gedaqtests.booleanbooleane0m m
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
FROM gedaqtests.booleanbooleane0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBooleanbooleanE0M>();
                var firstItems2 = new List<FlatBooleanbooleanE0M>();
                var secondItems1 = new List<FlatBooleanbooleanE0M>();
                await ((IBooleanSingleTypeboolean)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[20],_testData[34], false);
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
FROM gedaqtests.booleanbooleane0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatBooleanbooleanE0M>();
                var models2 = new List<FlatBooleanbooleanE0M>();
                ((IBooleanSingleTypeboolean)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBooleanbooleanE0M.AssertModel(models1[i],_testData[i], false);
                    FlatBooleanbooleanE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 88;
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
FROM gedaqtests.booleanbooleane0m m
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
FROM gedaqtests.booleanbooleane0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBooleanbooleanE0M>();
                var firstItems2 = new List<FlatBooleanbooleanE0M>();
                var secondItems1 = new List<FlatBooleanbooleanE0M>();
                var secondItems2 = new List<FlatBooleanbooleanE0M>();
                 ((IBooleanSingleTypeboolean)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[25],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 71;
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
FROM gedaqtests.booleanbooleane0m m
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
FROM gedaqtests.booleanbooleane0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBooleanbooleanE0M>();
                var firstItems2 = new List<FlatBooleanbooleanE0M>();
                var secondItems1 = new List<FlatBooleanbooleanE0M>();
                 ((IBooleanSingleTypeboolean)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[11],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBooleanbooleanE0M)],
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
FROM gedaqtests.booleanbooleane0m m
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBooleanbooleanE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 57;
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
FROM gedaqtests.booleanbooleane0m m
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
FROM gedaqtests.booleanbooleane0m m
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
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatBooleanbooleanE0M.AssertModel(models[0],_testData[12], false);
                        FlatBooleanbooleanE0M.AssertModel(models[1],_testData[13], false);
                        FlatBooleanbooleanE0M.AssertModel(models[2],_testData[14], false);
                        FlatBooleanbooleanE0M.AssertModel(models[3],_testData[15], false);
                        FlatBooleanbooleanE0M.AssertModel(models[4],_testData[16], false);
                        FlatBooleanbooleanE0M.AssertModel(models[5],_testData[17], false);
                        FlatBooleanbooleanE0M.AssertModel(models[6],_testData[18], false);
                        FlatBooleanbooleanE0M.AssertModel(models[7],_testData[19], false);
                        FlatBooleanbooleanE0M.AssertModel(models[8],_testData[20], false);
                        FlatBooleanbooleanE0M.AssertModel(models[9],_testData[21], false);
                        FlatBooleanbooleanE0M.AssertModel(models[10],_testData[22], false);
                        FlatBooleanbooleanE0M.AssertModel(models[11],_testData[23], false);
                        FlatBooleanbooleanE0M.AssertModel(models[12],_testData[24], false);
                        FlatBooleanbooleanE0M.AssertModel(models[13],_testData[25], false);
                        FlatBooleanbooleanE0M.AssertModel(models[14],_testData[26], false);
                        FlatBooleanbooleanE0M.AssertModel(models[15],_testData[27], false);
                        FlatBooleanbooleanE0M.AssertModel(models[16],_testData[28], false);
                        FlatBooleanbooleanE0M.AssertModel(models[17],_testData[29], false);
                        FlatBooleanbooleanE0M.AssertModel(models[18],_testData[30], false);
                        FlatBooleanbooleanE0M.AssertModel(models[19],_testData[31], false);
                        FlatBooleanbooleanE0M.AssertModel(models[20],_testData[32], false);
                        FlatBooleanbooleanE0M.AssertModel(models[21],_testData[33], false);
                        FlatBooleanbooleanE0M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatBooleanbooleanE0M.AssertModel(models[0],_testData[6], false);
                        FlatBooleanbooleanE0M.AssertModel(models[1],_testData[7], false);
                        FlatBooleanbooleanE0M.AssertModel(models[2],_testData[8], false);
                        FlatBooleanbooleanE0M.AssertModel(models[3],_testData[9], false);
                        FlatBooleanbooleanE0M.AssertModel(models[4],_testData[10], false);
                        FlatBooleanbooleanE0M.AssertModel(models[5],_testData[11], false);
                        FlatBooleanbooleanE0M.AssertModel(models[6],_testData[12], false);
                        FlatBooleanbooleanE0M.AssertModel(models[7],_testData[13], false);
                        FlatBooleanbooleanE0M.AssertModel(models[8],_testData[14], false);
                        FlatBooleanbooleanE0M.AssertModel(models[9],_testData[15], false);
                        FlatBooleanbooleanE0M.AssertModel(models[10],_testData[16], false);
                        FlatBooleanbooleanE0M.AssertModel(models[11],_testData[17], false);
                        FlatBooleanbooleanE0M.AssertModel(models[12],_testData[18], false);
                        FlatBooleanbooleanE0M.AssertModel(models[13],_testData[19], false);
                        FlatBooleanbooleanE0M.AssertModel(models[14],_testData[20], false);
                        FlatBooleanbooleanE0M.AssertModel(models[15],_testData[21], false);
                        FlatBooleanbooleanE0M.AssertModel(models[16],_testData[22], false);
                        FlatBooleanbooleanE0M.AssertModel(models[17],_testData[23], false);
                        FlatBooleanbooleanE0M.AssertModel(models[18],_testData[24], false);
                        FlatBooleanbooleanE0M.AssertModel(models[19],_testData[25], false);
                        FlatBooleanbooleanE0M.AssertModel(models[20],_testData[26], false);
                        FlatBooleanbooleanE0M.AssertModel(models[21],_testData[27], false);
                        FlatBooleanbooleanE0M.AssertModel(models[22],_testData[28], false);
                        FlatBooleanbooleanE0M.AssertModel(models[23],_testData[29], false);
                        FlatBooleanbooleanE0M.AssertModel(models[24],_testData[30], false);
                        FlatBooleanbooleanE0M.AssertModel(models[25],_testData[31], false);
                        FlatBooleanbooleanE0M.AssertModel(models[26],_testData[32], false);
                        FlatBooleanbooleanE0M.AssertModel(models[27],_testData[33], false);
                        FlatBooleanbooleanE0M.AssertModel(models[28],_testData[34], false);
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
                parametr1.Value = 77;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 14;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.booleanbooleane0m m
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
FROM gedaqtests.booleanbooleane0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBooleanbooleanE0M>();
                var secondItems1 = new List<FlatBooleanbooleanE0M>();
                var secondItems2 = new List<FlatBooleanbooleanE0M>();
                await ((IBooleanSingleTypeboolean)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[32],_testData[34], false);
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
FROM gedaqtests.booleanbooleane0m m
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBooleanbooleanE0M.AssertModel(models[i],_testData[i], false);
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
                parametr2.Value = 125;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.booleanbooleane0m m
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
FROM gedaqtests.booleanbooleane0m m
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
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatBooleanbooleanE0M.AssertModel(models[0],_testData[15], false);
                        FlatBooleanbooleanE0M.AssertModel(models[1],_testData[16], false);
                        FlatBooleanbooleanE0M.AssertModel(models[2],_testData[17], false);
                        FlatBooleanbooleanE0M.AssertModel(models[3],_testData[18], false);
                        FlatBooleanbooleanE0M.AssertModel(models[4],_testData[19], false);
                        FlatBooleanbooleanE0M.AssertModel(models[5],_testData[20], false);
                        FlatBooleanbooleanE0M.AssertModel(models[6],_testData[21], false);
                        FlatBooleanbooleanE0M.AssertModel(models[7],_testData[22], false);
                        FlatBooleanbooleanE0M.AssertModel(models[8],_testData[23], false);
                        FlatBooleanbooleanE0M.AssertModel(models[9],_testData[24], false);
                        FlatBooleanbooleanE0M.AssertModel(models[10],_testData[25], false);
                        FlatBooleanbooleanE0M.AssertModel(models[11],_testData[26], false);
                        FlatBooleanbooleanE0M.AssertModel(models[12],_testData[27], false);
                        FlatBooleanbooleanE0M.AssertModel(models[13],_testData[28], false);
                        FlatBooleanbooleanE0M.AssertModel(models[14],_testData[29], false);
                        FlatBooleanbooleanE0M.AssertModel(models[15],_testData[30], false);
                        FlatBooleanbooleanE0M.AssertModel(models[16],_testData[31], false);
                        FlatBooleanbooleanE0M.AssertModel(models[17],_testData[32], false);
                        FlatBooleanbooleanE0M.AssertModel(models[18],_testData[33], false);
                        FlatBooleanbooleanE0M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatBooleanbooleanE0M.AssertModel(models[0],_testData[27], false);
                        FlatBooleanbooleanE0M.AssertModel(models[1],_testData[28], false);
                        FlatBooleanbooleanE0M.AssertModel(models[2],_testData[29], false);
                        FlatBooleanbooleanE0M.AssertModel(models[3],_testData[30], false);
                        FlatBooleanbooleanE0M.AssertModel(models[4],_testData[31], false);
                        FlatBooleanbooleanE0M.AssertModel(models[5],_testData[32], false);
                        FlatBooleanbooleanE0M.AssertModel(models[6],_testData[33], false);
                        FlatBooleanbooleanE0M.AssertModel(models[7],_testData[34], false);
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
                parametr1.Value = 46;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 133;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.booleanbooleane0m m
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
FROM gedaqtests.booleanbooleane0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBooleanbooleanE0M>();
                var secondItems1 = new List<FlatBooleanbooleanE0M>();
                var secondItems2 = new List<FlatBooleanbooleanE0M>();
                 ((IBooleanSingleTypeboolean)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[3],_testData[34], false);
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
FROM gedaqtests.booleanbooleane0m m
LEFT JOIN gedaqtests.booleanbooleane0mi mi ON mi.id = m.booleanbooleane0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(BooleanbooleanE0M)],
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BooleanbooleanE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 6;
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
                        Assert.That(models, Has.Count.EqualTo(34));

                        BooleanbooleanE0M.AssertModel(models[0],_testData[1], false);
                        BooleanbooleanE0M.AssertModel(models[1],_testData[2], false);
                        BooleanbooleanE0M.AssertModel(models[2],_testData[3], false);
                        BooleanbooleanE0M.AssertModel(models[3],_testData[4], false);
                        BooleanbooleanE0M.AssertModel(models[4],_testData[5], false);
                        BooleanbooleanE0M.AssertModel(models[5],_testData[6], false);
                        BooleanbooleanE0M.AssertModel(models[6],_testData[7], false);
                        BooleanbooleanE0M.AssertModel(models[7],_testData[8], false);
                        BooleanbooleanE0M.AssertModel(models[8],_testData[9], false);
                        BooleanbooleanE0M.AssertModel(models[9],_testData[10], false);
                        BooleanbooleanE0M.AssertModel(models[10],_testData[11], false);
                        BooleanbooleanE0M.AssertModel(models[11],_testData[12], false);
                        BooleanbooleanE0M.AssertModel(models[12],_testData[13], false);
                        BooleanbooleanE0M.AssertModel(models[13],_testData[14], false);
                        BooleanbooleanE0M.AssertModel(models[14],_testData[15], false);
                        BooleanbooleanE0M.AssertModel(models[15],_testData[16], false);
                        BooleanbooleanE0M.AssertModel(models[16],_testData[17], false);
                        BooleanbooleanE0M.AssertModel(models[17],_testData[18], false);
                        BooleanbooleanE0M.AssertModel(models[18],_testData[19], false);
                        BooleanbooleanE0M.AssertModel(models[19],_testData[20], false);
                        BooleanbooleanE0M.AssertModel(models[20],_testData[21], false);
                        BooleanbooleanE0M.AssertModel(models[21],_testData[22], false);
                        BooleanbooleanE0M.AssertModel(models[22],_testData[23], false);
                        BooleanbooleanE0M.AssertModel(models[23],_testData[24], false);
                        BooleanbooleanE0M.AssertModel(models[24],_testData[25], false);
                        BooleanbooleanE0M.AssertModel(models[25],_testData[26], false);
                        BooleanbooleanE0M.AssertModel(models[26],_testData[27], false);
                        BooleanbooleanE0M.AssertModel(models[27],_testData[28], false);
                        BooleanbooleanE0M.AssertModel(models[28],_testData[29], false);
                        BooleanbooleanE0M.AssertModel(models[29],_testData[30], false);
                        BooleanbooleanE0M.AssertModel(models[30],_testData[31], false);
                        BooleanbooleanE0M.AssertModel(models[31],_testData[32], false);
                        BooleanbooleanE0M.AssertModel(models[32],_testData[33], false);
                        BooleanbooleanE0M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        BooleanbooleanE0M.AssertModel(models[0],_testData[26], false);
                        BooleanbooleanE0M.AssertModel(models[1],_testData[27], false);
                        BooleanbooleanE0M.AssertModel(models[2],_testData[28], false);
                        BooleanbooleanE0M.AssertModel(models[3],_testData[29], false);
                        BooleanbooleanE0M.AssertModel(models[4],_testData[30], false);
                        BooleanbooleanE0M.AssertModel(models[5],_testData[31], false);
                        BooleanbooleanE0M.AssertModel(models[6],_testData[32], false);
                        BooleanbooleanE0M.AssertModel(models[7],_testData[33], false);
                        BooleanbooleanE0M.AssertModel(models[8],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BooleanbooleanE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 126;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 125;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBooleanSingleTypeboolean)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        BooleanbooleanE0M.AssertModel(models[0],_testData[28], false);
                        BooleanbooleanE0M.AssertModel(models[1],_testData[29], false);
                        BooleanbooleanE0M.AssertModel(models[2],_testData[30], false);
                        BooleanbooleanE0M.AssertModel(models[3],_testData[31], false);
                        BooleanbooleanE0M.AssertModel(models[4],_testData[32], false);
                        BooleanbooleanE0M.AssertModel(models[5],_testData[33], false);
                        BooleanbooleanE0M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        BooleanbooleanE0M.AssertModel(models[0],_testData[27], false);
                        BooleanbooleanE0M.AssertModel(models[1],_testData[28], false);
                        BooleanbooleanE0M.AssertModel(models[2],_testData[29], false);
                        BooleanbooleanE0M.AssertModel(models[3],_testData[30], false);
                        BooleanbooleanE0M.AssertModel(models[4],_testData[31], false);
                        BooleanbooleanE0M.AssertModel(models[5],_testData[32], false);
                        BooleanbooleanE0M.AssertModel(models[6],_testData[33], false);
                        BooleanbooleanE0M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBooleanbooleanE0M), typeof(FlatBooleanbooleanE0M)],
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
FROM gedaqtests.booleanbooleane0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBooleanbooleanE0M>();
                var models2 = new List<FlatBooleanbooleanE0M>();
                await((IBooleanSingleTypeboolean)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBooleanbooleanE0M.AssertModel(models1[i],_testData[i], false);
                    FlatBooleanbooleanE0M.AssertModel(models2[i],_testData[i], false);
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
FROM gedaqtests.booleanbooleane0m m
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
FROM gedaqtests.booleanbooleane0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBooleanbooleanE0M>();
                var firstItems2 = new List<FlatBooleanbooleanE0M>();
                var secondItems1 = new List<FlatBooleanbooleanE0M>();
                var secondItems2 = new List<FlatBooleanbooleanE0M>();
                await ((IBooleanSingleTypeboolean)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 114, query1, 18, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[29],_testData[34], false);
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
FROM gedaqtests.booleanbooleane0m m
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
FROM gedaqtests.booleanbooleane0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBooleanbooleanE0M>();
                var firstItems2 = new List<FlatBooleanbooleanE0M>();
                var secondItems1 = new List<FlatBooleanbooleanE0M>();
                await ((IBooleanSingleTypeboolean)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 143, query1, 122, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[8],_testData[34], false);
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
FROM gedaqtests.booleanbooleane0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBooleanbooleanE0M>();
                var models2 = new List<FlatBooleanbooleanE0M>();
                ((IBooleanSingleTypeboolean)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBooleanbooleanE0M.AssertModel(models1[i],_testData[i], false);
                    FlatBooleanbooleanE0M.AssertModel(models2[i],_testData[i], false);
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
FROM gedaqtests.booleanbooleane0m m
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
FROM gedaqtests.booleanbooleane0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBooleanbooleanE0M>();
                var firstItems2 = new List<FlatBooleanbooleanE0M>();
                var secondItems1 = new List<FlatBooleanbooleanE0M>();
                var secondItems2 = new List<FlatBooleanbooleanE0M>();
                 ((IBooleanSingleTypeboolean)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 18, query1, 18, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[29],_testData[34], false);
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
FROM gedaqtests.booleanbooleane0m m
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
FROM gedaqtests.booleanbooleane0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBooleanbooleanE0M>();
                var firstItems2 = new List<FlatBooleanbooleanE0M>();
                var secondItems1 = new List<FlatBooleanbooleanE0M>();
                 ((IBooleanSingleTypeboolean)this).DbConnectionMMDynQuerySelectModelBatch(connection, 53, query1, 98, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[12],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBooleanbooleanE0M)],
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
FROM gedaqtests.booleanbooleane0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IBooleanSingleTypeboolean)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBooleanbooleanE0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.booleanbooleane0m m
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
FROM gedaqtests.booleanbooleane0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBooleanSingleTypeboolean)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 133, query1, 73, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatBooleanbooleanE0M.AssertModel(models[0],_testData[31], false);
                        FlatBooleanbooleanE0M.AssertModel(models[1],_testData[32], false);
                        FlatBooleanbooleanE0M.AssertModel(models[2],_testData[33], false);
                        FlatBooleanbooleanE0M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatBooleanbooleanE0M.AssertModel(models[0],_testData[16], false);
                        FlatBooleanbooleanE0M.AssertModel(models[1],_testData[17], false);
                        FlatBooleanbooleanE0M.AssertModel(models[2],_testData[18], false);
                        FlatBooleanbooleanE0M.AssertModel(models[3],_testData[19], false);
                        FlatBooleanbooleanE0M.AssertModel(models[4],_testData[20], false);
                        FlatBooleanbooleanE0M.AssertModel(models[5],_testData[21], false);
                        FlatBooleanbooleanE0M.AssertModel(models[6],_testData[22], false);
                        FlatBooleanbooleanE0M.AssertModel(models[7],_testData[23], false);
                        FlatBooleanbooleanE0M.AssertModel(models[8],_testData[24], false);
                        FlatBooleanbooleanE0M.AssertModel(models[9],_testData[25], false);
                        FlatBooleanbooleanE0M.AssertModel(models[10],_testData[26], false);
                        FlatBooleanbooleanE0M.AssertModel(models[11],_testData[27], false);
                        FlatBooleanbooleanE0M.AssertModel(models[12],_testData[28], false);
                        FlatBooleanbooleanE0M.AssertModel(models[13],_testData[29], false);
                        FlatBooleanbooleanE0M.AssertModel(models[14],_testData[30], false);
                        FlatBooleanbooleanE0M.AssertModel(models[15],_testData[31], false);
                        FlatBooleanbooleanE0M.AssertModel(models[16],_testData[32], false);
                        FlatBooleanbooleanE0M.AssertModel(models[17],_testData[33], false);
                        FlatBooleanbooleanE0M.AssertModel(models[18],_testData[34], false);
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
FROM gedaqtests.booleanbooleane0m m
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
FROM gedaqtests.booleanbooleane0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBooleanbooleanE0M>();
                var secondItems1 = new List<FlatBooleanbooleanE0M>();
                var secondItems2 = new List<FlatBooleanbooleanE0M>();
                await ((IBooleanSingleTypeboolean)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 133, query1, 57, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[22],_testData[34], false);
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
FROM gedaqtests.booleanbooleane0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IBooleanSingleTypeboolean)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBooleanbooleanE0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.booleanbooleane0m m
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
FROM gedaqtests.booleanbooleane0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBooleanSingleTypeboolean)this).DbConnectionSTDynQuerySelectModelBatch(connection, 125, query1, 53, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatBooleanbooleanE0M.AssertModel(models[0],_testData[27], false);
                        FlatBooleanbooleanE0M.AssertModel(models[1],_testData[28], false);
                        FlatBooleanbooleanE0M.AssertModel(models[2],_testData[29], false);
                        FlatBooleanbooleanE0M.AssertModel(models[3],_testData[30], false);
                        FlatBooleanbooleanE0M.AssertModel(models[4],_testData[31], false);
                        FlatBooleanbooleanE0M.AssertModel(models[5],_testData[32], false);
                        FlatBooleanbooleanE0M.AssertModel(models[6],_testData[33], false);
                        FlatBooleanbooleanE0M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatBooleanbooleanE0M.AssertModel(models[0],_testData[11], false);
                        FlatBooleanbooleanE0M.AssertModel(models[1],_testData[12], false);
                        FlatBooleanbooleanE0M.AssertModel(models[2],_testData[13], false);
                        FlatBooleanbooleanE0M.AssertModel(models[3],_testData[14], false);
                        FlatBooleanbooleanE0M.AssertModel(models[4],_testData[15], false);
                        FlatBooleanbooleanE0M.AssertModel(models[5],_testData[16], false);
                        FlatBooleanbooleanE0M.AssertModel(models[6],_testData[17], false);
                        FlatBooleanbooleanE0M.AssertModel(models[7],_testData[18], false);
                        FlatBooleanbooleanE0M.AssertModel(models[8],_testData[19], false);
                        FlatBooleanbooleanE0M.AssertModel(models[9],_testData[20], false);
                        FlatBooleanbooleanE0M.AssertModel(models[10],_testData[21], false);
                        FlatBooleanbooleanE0M.AssertModel(models[11],_testData[22], false);
                        FlatBooleanbooleanE0M.AssertModel(models[12],_testData[23], false);
                        FlatBooleanbooleanE0M.AssertModel(models[13],_testData[24], false);
                        FlatBooleanbooleanE0M.AssertModel(models[14],_testData[25], false);
                        FlatBooleanbooleanE0M.AssertModel(models[15],_testData[26], false);
                        FlatBooleanbooleanE0M.AssertModel(models[16],_testData[27], false);
                        FlatBooleanbooleanE0M.AssertModel(models[17],_testData[28], false);
                        FlatBooleanbooleanE0M.AssertModel(models[18],_testData[29], false);
                        FlatBooleanbooleanE0M.AssertModel(models[19],_testData[30], false);
                        FlatBooleanbooleanE0M.AssertModel(models[20],_testData[31], false);
                        FlatBooleanbooleanE0M.AssertModel(models[21],_testData[32], false);
                        FlatBooleanbooleanE0M.AssertModel(models[22],_testData[33], false);
                        FlatBooleanbooleanE0M.AssertModel(models[23],_testData[34], false);
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
FROM gedaqtests.booleanbooleane0m m
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
FROM gedaqtests.booleanbooleane0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBooleanbooleanE0M>();
                var secondItems1 = new List<FlatBooleanbooleanE0M>();
                var secondItems2 = new List<FlatBooleanbooleanE0M>();
                 ((IBooleanSingleTypeboolean)this).DbConnectionDynQuerySelectModelBatch(connection, 71, query1, 71, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatBooleanbooleanE0M.AssertModel(firstItems1[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatBooleanbooleanE0M.AssertModel(secondItems2[19],_testData[34], false);
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
FROM gedaqtests.booleanbooleane0m m
LEFT JOIN gedaqtests.booleanbooleane0mi mi ON mi.id = m.booleanbooleane0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(BooleanbooleanE0M)],
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BooleanbooleanE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IBooleanSingleTypeboolean)this).DbConnectionSTSelectModelBatchAsync(connection, 14, 53))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        BooleanbooleanE0M.AssertModel(models[0],_testData[2], false);
                        BooleanbooleanE0M.AssertModel(models[1],_testData[3], false);
                        BooleanbooleanE0M.AssertModel(models[2],_testData[4], false);
                        BooleanbooleanE0M.AssertModel(models[3],_testData[5], false);
                        BooleanbooleanE0M.AssertModel(models[4],_testData[6], false);
                        BooleanbooleanE0M.AssertModel(models[5],_testData[7], false);
                        BooleanbooleanE0M.AssertModel(models[6],_testData[8], false);
                        BooleanbooleanE0M.AssertModel(models[7],_testData[9], false);
                        BooleanbooleanE0M.AssertModel(models[8],_testData[10], false);
                        BooleanbooleanE0M.AssertModel(models[9],_testData[11], false);
                        BooleanbooleanE0M.AssertModel(models[10],_testData[12], false);
                        BooleanbooleanE0M.AssertModel(models[11],_testData[13], false);
                        BooleanbooleanE0M.AssertModel(models[12],_testData[14], false);
                        BooleanbooleanE0M.AssertModel(models[13],_testData[15], false);
                        BooleanbooleanE0M.AssertModel(models[14],_testData[16], false);
                        BooleanbooleanE0M.AssertModel(models[15],_testData[17], false);
                        BooleanbooleanE0M.AssertModel(models[16],_testData[18], false);
                        BooleanbooleanE0M.AssertModel(models[17],_testData[19], false);
                        BooleanbooleanE0M.AssertModel(models[18],_testData[20], false);
                        BooleanbooleanE0M.AssertModel(models[19],_testData[21], false);
                        BooleanbooleanE0M.AssertModel(models[20],_testData[22], false);
                        BooleanbooleanE0M.AssertModel(models[21],_testData[23], false);
                        BooleanbooleanE0M.AssertModel(models[22],_testData[24], false);
                        BooleanbooleanE0M.AssertModel(models[23],_testData[25], false);
                        BooleanbooleanE0M.AssertModel(models[24],_testData[26], false);
                        BooleanbooleanE0M.AssertModel(models[25],_testData[27], false);
                        BooleanbooleanE0M.AssertModel(models[26],_testData[28], false);
                        BooleanbooleanE0M.AssertModel(models[27],_testData[29], false);
                        BooleanbooleanE0M.AssertModel(models[28],_testData[30], false);
                        BooleanbooleanE0M.AssertModel(models[29],_testData[31], false);
                        BooleanbooleanE0M.AssertModel(models[30],_testData[32], false);
                        BooleanbooleanE0M.AssertModel(models[31],_testData[33], false);
                        BooleanbooleanE0M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        BooleanbooleanE0M.AssertModel(models[0],_testData[11], false);
                        BooleanbooleanE0M.AssertModel(models[1],_testData[12], false);
                        BooleanbooleanE0M.AssertModel(models[2],_testData[13], false);
                        BooleanbooleanE0M.AssertModel(models[3],_testData[14], false);
                        BooleanbooleanE0M.AssertModel(models[4],_testData[15], false);
                        BooleanbooleanE0M.AssertModel(models[5],_testData[16], false);
                        BooleanbooleanE0M.AssertModel(models[6],_testData[17], false);
                        BooleanbooleanE0M.AssertModel(models[7],_testData[18], false);
                        BooleanbooleanE0M.AssertModel(models[8],_testData[19], false);
                        BooleanbooleanE0M.AssertModel(models[9],_testData[20], false);
                        BooleanbooleanE0M.AssertModel(models[10],_testData[21], false);
                        BooleanbooleanE0M.AssertModel(models[11],_testData[22], false);
                        BooleanbooleanE0M.AssertModel(models[12],_testData[23], false);
                        BooleanbooleanE0M.AssertModel(models[13],_testData[24], false);
                        BooleanbooleanE0M.AssertModel(models[14],_testData[25], false);
                        BooleanbooleanE0M.AssertModel(models[15],_testData[26], false);
                        BooleanbooleanE0M.AssertModel(models[16],_testData[27], false);
                        BooleanbooleanE0M.AssertModel(models[17],_testData[28], false);
                        BooleanbooleanE0M.AssertModel(models[18],_testData[29], false);
                        BooleanbooleanE0M.AssertModel(models[19],_testData[30], false);
                        BooleanbooleanE0M.AssertModel(models[20],_testData[31], false);
                        BooleanbooleanE0M.AssertModel(models[21],_testData[32], false);
                        BooleanbooleanE0M.AssertModel(models[22],_testData[33], false);
                        BooleanbooleanE0M.AssertModel(models[23],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BooleanbooleanE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IBooleanSingleTypeboolean)this).DbConnectionSTSelectModelBatch(connection, 71, 98))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        BooleanbooleanE0M.AssertModel(models[0],_testData[15], false);
                        BooleanbooleanE0M.AssertModel(models[1],_testData[16], false);
                        BooleanbooleanE0M.AssertModel(models[2],_testData[17], false);
                        BooleanbooleanE0M.AssertModel(models[3],_testData[18], false);
                        BooleanbooleanE0M.AssertModel(models[4],_testData[19], false);
                        BooleanbooleanE0M.AssertModel(models[5],_testData[20], false);
                        BooleanbooleanE0M.AssertModel(models[6],_testData[21], false);
                        BooleanbooleanE0M.AssertModel(models[7],_testData[22], false);
                        BooleanbooleanE0M.AssertModel(models[8],_testData[23], false);
                        BooleanbooleanE0M.AssertModel(models[9],_testData[24], false);
                        BooleanbooleanE0M.AssertModel(models[10],_testData[25], false);
                        BooleanbooleanE0M.AssertModel(models[11],_testData[26], false);
                        BooleanbooleanE0M.AssertModel(models[12],_testData[27], false);
                        BooleanbooleanE0M.AssertModel(models[13],_testData[28], false);
                        BooleanbooleanE0M.AssertModel(models[14],_testData[29], false);
                        BooleanbooleanE0M.AssertModel(models[15],_testData[30], false);
                        BooleanbooleanE0M.AssertModel(models[16],_testData[31], false);
                        BooleanbooleanE0M.AssertModel(models[17],_testData[32], false);
                        BooleanbooleanE0M.AssertModel(models[18],_testData[33], false);
                        BooleanbooleanE0M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        BooleanbooleanE0M.AssertModel(models[0],_testData[22], false);
                        BooleanbooleanE0M.AssertModel(models[1],_testData[23], false);
                        BooleanbooleanE0M.AssertModel(models[2],_testData[24], false);
                        BooleanbooleanE0M.AssertModel(models[3],_testData[25], false);
                        BooleanbooleanE0M.AssertModel(models[4],_testData[26], false);
                        BooleanbooleanE0M.AssertModel(models[5],_testData[27], false);
                        BooleanbooleanE0M.AssertModel(models[6],_testData[28], false);
                        BooleanbooleanE0M.AssertModel(models[7],_testData[29], false);
                        BooleanbooleanE0M.AssertModel(models[8],_testData[30], false);
                        BooleanbooleanE0M.AssertModel(models[9],_testData[31], false);
                        BooleanbooleanE0M.AssertModel(models[10],_testData[32], false);
                        BooleanbooleanE0M.AssertModel(models[11],_testData[33], false);
                        BooleanbooleanE0M.AssertModel(models[12],_testData[34], false);
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
                ((IBooleanSingleTypeboolean)this).SetDbConnectionSelectModelParametrs(cmd, 122);
                var models = await ((IBooleanSingleTypeboolean)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(9));

                BooleanbooleanE0M.AssertModel(models[0],_testData[26], false);
                BooleanbooleanE0M.AssertModel(models[1],_testData[27], false);
                BooleanbooleanE0M.AssertModel(models[2],_testData[28], false);
                BooleanbooleanE0M.AssertModel(models[3],_testData[29], false);
                BooleanbooleanE0M.AssertModel(models[4],_testData[30], false);
                BooleanbooleanE0M.AssertModel(models[5],_testData[31], false);
                BooleanbooleanE0M.AssertModel(models[6],_testData[32], false);
                BooleanbooleanE0M.AssertModel(models[7],_testData[33], false);
                BooleanbooleanE0M.AssertModel(models[8],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IBooleanSingleTypeboolean)this).CreateDbConnectionSelectModelCommand(connection);
                ((IBooleanSingleTypeboolean)this).SetDbConnectionSelectModelParametrs(cmd, 35);
                var models =  ((IBooleanSingleTypeboolean)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(28));

                BooleanbooleanE0M.AssertModel(models[0],_testData[7], false);
                BooleanbooleanE0M.AssertModel(models[1],_testData[8], false);
                BooleanbooleanE0M.AssertModel(models[2],_testData[9], false);
                BooleanbooleanE0M.AssertModel(models[3],_testData[10], false);
                BooleanbooleanE0M.AssertModel(models[4],_testData[11], false);
                BooleanbooleanE0M.AssertModel(models[5],_testData[12], false);
                BooleanbooleanE0M.AssertModel(models[6],_testData[13], false);
                BooleanbooleanE0M.AssertModel(models[7],_testData[14], false);
                BooleanbooleanE0M.AssertModel(models[8],_testData[15], false);
                BooleanbooleanE0M.AssertModel(models[9],_testData[16], false);
                BooleanbooleanE0M.AssertModel(models[10],_testData[17], false);
                BooleanbooleanE0M.AssertModel(models[11],_testData[18], false);
                BooleanbooleanE0M.AssertModel(models[12],_testData[19], false);
                BooleanbooleanE0M.AssertModel(models[13],_testData[20], false);
                BooleanbooleanE0M.AssertModel(models[14],_testData[21], false);
                BooleanbooleanE0M.AssertModel(models[15],_testData[22], false);
                BooleanbooleanE0M.AssertModel(models[16],_testData[23], false);
                BooleanbooleanE0M.AssertModel(models[17],_testData[24], false);
                BooleanbooleanE0M.AssertModel(models[18],_testData[25], false);
                BooleanbooleanE0M.AssertModel(models[19],_testData[26], false);
                BooleanbooleanE0M.AssertModel(models[20],_testData[27], false);
                BooleanbooleanE0M.AssertModel(models[21],_testData[28], false);
                BooleanbooleanE0M.AssertModel(models[22],_testData[29], false);
                BooleanbooleanE0M.AssertModel(models[23],_testData[30], false);
                BooleanbooleanE0M.AssertModel(models[24],_testData[31], false);
                BooleanbooleanE0M.AssertModel(models[25],_testData[32], false);
                BooleanbooleanE0M.AssertModel(models[26],_testData[33], false);
                BooleanbooleanE0M.AssertModel(models[27],_testData[34], false);
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
FROM gedaqtests.booleanbooleane0m m
LEFT JOIN gedaqtests.booleanbooleane0mi mi ON mi.id = m.booleanbooleane0mi_id
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
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((System.Boolean?)model[4], Is.EqualTo((false)));//InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
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

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
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
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((System.Boolean?)model[4], Is.EqualTo((false)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((53)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((System.Boolean?)model[4], Is.EqualTo((false)));//InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((System.Boolean?)model[4], Is.EqualTo((false)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((System.Boolean?)model[4], Is.EqualTo((false)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((78)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((System.Boolean?)model[4], Is.EqualTo((false)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((System.Boolean?)model[4], Is.EqualTo((false)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((System.Boolean?)model[4], Is.EqualTo((false)));//InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((70)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((System.Boolean?)model[4], Is.EqualTo((false)));//InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((76)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((System.Boolean?)model[4], Is.EqualTo((false)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((78)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((System.Boolean?)model[4], Is.EqualTo((false)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((145)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((87)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

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
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((System.Boolean?)model[4], Is.EqualTo((false)));//InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
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

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
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
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((System.Boolean?)model[4], Is.EqualTo((false)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((53)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((System.Boolean?)model[4], Is.EqualTo((false)));//InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((System.Boolean?)model[4], Is.EqualTo((false)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((System.Boolean?)model[4], Is.EqualTo((false)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((78)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((System.Boolean?)model[4], Is.EqualTo((false)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((System.Boolean?)model[4], Is.EqualTo((false)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((122)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((System.Boolean?)model[4], Is.EqualTo((false)));//InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((70)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((System.Boolean?)model[4], Is.EqualTo((false)));//InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((76)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((System.Boolean?)model[4], Is.EqualTo((false)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((78)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((System.Boolean?)model[4], Is.EqualTo((false)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((145)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((87)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

            }
        }

#endregion

    }
}

