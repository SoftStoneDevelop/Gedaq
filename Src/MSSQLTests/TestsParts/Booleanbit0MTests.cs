

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
    internal partial interface IBooleanSingleTypebit
    {
    }
    
    internal partial class BooleanSingleTypebit : IBooleanSingleTypebit
    {


#region TestData

        private readonly Booleanbit0M[] _testData = new Booleanbit0M[]
        {
            new Booleanbit0M
{
    Id = 7,
    Value = false,
    ModelInner = null,
    NullableValue = false,
},
            new Booleanbit0M
{
    Id = 15,
    Value = false,
    ModelInner = new Booleanbit0MI
{
    Id = 6,
    Value = false,
    NullableValue = false,
},
    NullableValue = false,
},
            new Booleanbit0M
{
    Id = 21,
    Value = false,
    ModelInner = null,
    NullableValue = null,
},
            new Booleanbit0M
{
    Id = 26,
    Value = false,
    ModelInner = new Booleanbit0MI
{
    Id = 9,
    Value = false,
    NullableValue = false,
},
    NullableValue = false,
},
            new Booleanbit0M
{
    Id = 34,
    Value = false,
    ModelInner = null,
    NullableValue = null,
},
            new Booleanbit0M
{
    Id = 39,
    Value = false,
    ModelInner = new Booleanbit0MI
{
    Id = 13,
    Value = false,
    NullableValue = false,
},
    NullableValue = false,
},
            new Booleanbit0M
{
    Id = 42,
    Value = false,
    ModelInner = null,
    NullableValue = false,
},
            new Booleanbit0M
{
    Id = 50,
    Value = false,
    ModelInner = new Booleanbit0MI
{
    Id = 21,
    Value = false,
    NullableValue = false,
},
    NullableValue = false,
},
            new Booleanbit0M
{
    Id = 57,
    Value = false,
    ModelInner = null,
    NullableValue = false,
},
            new Booleanbit0M
{
    Id = 65,
    Value = false,
    ModelInner = new Booleanbit0MI
{
    Id = 22,
    Value = false,
    NullableValue = false,
},
    NullableValue = null,
},
            new Booleanbit0M
{
    Id = 73,
    Value = false,
    ModelInner = null,
    NullableValue = false,
},
            new Booleanbit0M
{
    Id = 81,
    Value = false,
    ModelInner = new Booleanbit0MI
{
    Id = 25,
    Value = false,
    NullableValue = false,
},
    NullableValue = false,
},
            new Booleanbit0M
{
    Id = 84,
    Value = false,
    ModelInner = null,
    NullableValue = null,
},
            new Booleanbit0M
{
    Id = 87,
    Value = false,
    ModelInner = new Booleanbit0MI
{
    Id = 32,
    Value = false,
    NullableValue = false,
},
    NullableValue = null,
},
            new Booleanbit0M
{
    Id = 90,
    Value = false,
    ModelInner = null,
    NullableValue = null,
},
            new Booleanbit0M
{
    Id = 93,
    Value = false,
    ModelInner = new Booleanbit0MI
{
    Id = 41,
    Value = false,
    NullableValue = null,
},
    NullableValue = false,
},
            new Booleanbit0M
{
    Id = 101,
    Value = false,
    ModelInner = null,
    NullableValue = false,
},
            new Booleanbit0M
{
    Id = 106,
    Value = false,
    ModelInner = new Booleanbit0MI
{
    Id = 46,
    Value = false,
    NullableValue = false,
},
    NullableValue = null,
},
            new Booleanbit0M
{
    Id = 108,
    Value = false,
    ModelInner = null,
    NullableValue = false,
},
            new Booleanbit0M
{
    Id = 117,
    Value = false,
    ModelInner = new Booleanbit0MI
{
    Id = 50,
    Value = false,
    NullableValue = null,
},
    NullableValue = null,
},
            new Booleanbit0M
{
    Id = 123,
    Value = false,
    ModelInner = null,
    NullableValue = null,
},
            new Booleanbit0M
{
    Id = 126,
    Value = false,
    ModelInner = new Booleanbit0MI
{
    Id = 54,
    Value = false,
    NullableValue = false,
},
    NullableValue = null,
},
            new Booleanbit0M
{
    Id = 133,
    Value = false,
    ModelInner = null,
    NullableValue = false,
},
            new Booleanbit0M
{
    Id = 135,
    Value = false,
    ModelInner = new Booleanbit0MI
{
    Id = 60,
    Value = false,
    NullableValue = false,
},
    NullableValue = false,
},
            new Booleanbit0M
{
    Id = 142,
    Value = false,
    ModelInner = null,
    NullableValue = false,
},
            new Booleanbit0M
{
    Id = 145,
    Value = false,
    ModelInner = new Booleanbit0MI
{
    Id = 64,
    Value = false,
    NullableValue = false,
},
    NullableValue = false,
},
            new Booleanbit0M
{
    Id = 146,
    Value = false,
    ModelInner = null,
    NullableValue = false,
},
            new Booleanbit0M
{
    Id = 150,
    Value = false,
    ModelInner = new Booleanbit0MI
{
    Id = 72,
    Value = false,
    NullableValue = null,
},
    NullableValue = false,
},
            new Booleanbit0M
{
    Id = 151,
    Value = false,
    ModelInner = null,
    NullableValue = null,
},
            new Booleanbit0M
{
    Id = 159,
    Value = false,
    ModelInner = new Booleanbit0MI
{
    Id = 73,
    Value = false,
    NullableValue = null,
},
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.SqlClient.Attributes.Query(
            query: @"
INSERT INTO dbo.booleanbit0mi(
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
            asPartInterface: typeof(IBooleanSingleTypebit)), 
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                parametrName: "id",
                methodParametrName: "id", 
                sqlDbType: (System.Data.SqlDbType)(8)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Boolean),
                parametrName: "value",
                methodParametrName: "value",
                sqlDbType: (System.Data.SqlDbType)(2)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Boolean?), 
                parametrName: "nullablevalue",
                methodParametrName: "nullablevalue",
                sqlDbType: (System.Data.SqlDbType)(2))
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

                changedRows =  ((IBooleanSingleTypebit)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IBooleanSingleTypebit)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IBooleanSingleTypebit)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBooleanSingleTypebit)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO dbo.booleanbit0mi(
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
            asPartInterface: typeof(IBooleanSingleTypebit)), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)11),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Boolean), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)3),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Boolean?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)3, 
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

                changedRows =  ((IBooleanSingleTypebit)this).DbConnectionInsertInnerModel(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
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

                changedRows = await ((IBooleanSingleTypebit)this).DbConnectionInsertInnerModelAsync(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBooleanSingleTypebit)this).DbConnectionInsertInnerModelAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBooleanSingleTypebit)this).DbConnectionInsertInnerModelAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBooleanSingleTypebit)this).DbConnectionInsertInnerModelAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBooleanSingleTypebit)this).DbConnectionInsertInnerModelAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBooleanSingleTypebit)this).DbConnectionInsertInnerModelAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBooleanSingleTypebit)this).DbConnectionInsertInnerModelAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBooleanSingleTypebit)this).DbConnectionInsertInnerModelAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBooleanSingleTypebit)this).DbConnectionInsertInnerModelAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBooleanSingleTypebit)this).DbConnectionInsertInnerModelAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.SqlClient.Attributes.Query(
            query: @"
INSERT INTO dbo.booleanbit0m(
	id,
    value,
    nullablevalue,
    booleanbit0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @booleanbit0mi_id
)
",
            methodName:"InsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanSingleTypebit)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                parametrName: "id",
                methodParametrName: "id",
                sqlDbType: (System.Data.SqlDbType)(8)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Boolean), 
                parametrName: "value", 
                methodParametrName: "value", 
                sqlDbType: (System.Data.SqlDbType)(2)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Boolean?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                sqlDbType: (System.Data.SqlDbType)(2),
                nullable: true),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "booleanbit0mi_id", 
                methodParametrName: "booleanbit0mi_id", 
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

                changedRows =  ((IBooleanSingleTypebit)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IBooleanSingleTypebit)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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

                changedRows = await ((IBooleanSingleTypebit)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBooleanSingleTypebit)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO dbo.booleanbit0m(
	id,
    value,
    nullablevalue,
    booleanbit0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @booleanbit0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanSingleTypebit)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)11),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Boolean), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)3),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Boolean?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)3,
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "booleanbit0mi_id", 
                methodParametrName: "booleanbit0mi_id", 
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

                changedRows =  ((IBooleanSingleTypebit)this).DbConnectionInsertModel(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IBooleanSingleTypebit)this).DbConnectionInsertModel(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
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

                changedRows = await ((IBooleanSingleTypebit)this).DbConnectionInsertModelAsync(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBooleanSingleTypebit)this).DbConnectionInsertModelAsync(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBooleanSingleTypebit)this).DbConnectionInsertModelAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBooleanSingleTypebit)this).DbConnectionInsertModelAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBooleanSingleTypebit)this).DbConnectionInsertModelAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBooleanSingleTypebit)this).DbConnectionInsertModelAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBooleanSingleTypebit)this).DbConnectionInsertModelAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBooleanSingleTypebit)this).DbConnectionInsertModelAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBooleanSingleTypebit)this).DbConnectionInsertModelAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBooleanSingleTypebit)this).DbConnectionInsertModelAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBooleanSingleTypebit)this).DbConnectionInsertModelAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBooleanSingleTypebit)this).DbConnectionInsertModelAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBooleanSingleTypebit)this).DbConnectionInsertModelAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBooleanSingleTypebit)this).DbConnectionInsertModelAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBooleanSingleTypebit)this).DbConnectionInsertModelAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBooleanSingleTypebit)this).DbConnectionInsertModelAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBooleanSingleTypebit)this).DbConnectionInsertModelAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBooleanSingleTypebit)this).DbConnectionInsertModelAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBooleanSingleTypebit)this).DbConnectionInsertModelAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBooleanSingleTypebit)this).DbConnectionInsertModelAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBooleanSingleTypebit)this).DbConnectionInsertModelAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBooleanSingleTypebit)this).DbConnectionInsertModelAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBooleanSingleTypebit)this).DbConnectionInsertModelAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBooleanSingleTypebit)this).DbConnectionInsertModelAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBooleanbit0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanSingleTypebit)),
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
FROM dbo.booleanbit0m m
LEFT JOIN dbo.booleanbit0mi mi ON mi.id = m.booleanbit0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";

                var models = await ((IBooleanSingleTypebit)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBooleanbit0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.booleanbit0m m
LEFT JOIN dbo.booleanbit0mi mi ON mi.id = m.booleanbit0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";

                var models =  ((IBooleanSingleTypebit)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBooleanbit0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.booleanbit0m m
LEFT JOIN dbo.booleanbit0mi mi ON mi.id = m.booleanbit0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Booleanbit0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanSingleTypebit)),
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

                var models = await ((IBooleanSingleTypebit)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Booleanbit0M.AssertModel(models[i],_testData[i], false);
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

                var models =  ((IBooleanSingleTypebit)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Booleanbit0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatBooleanbit0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanSingleTypebit)),
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
FROM dbo.booleanbit0m m
LEFT JOIN dbo.booleanbit0mi mi ON mi.id = m.booleanbit0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await ((IBooleanSingleTypebit)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBooleanbit0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.booleanbit0m m
LEFT JOIN dbo.booleanbit0mi mi ON mi.id = m.booleanbit0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models =  ((IBooleanSingleTypebit)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBooleanbit0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.booleanbit0m m
LEFT JOIN dbo.booleanbit0mi mi ON mi.id = m.booleanbit0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Booleanbit0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanSingleTypebit)),
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
                var models = await ((IBooleanSingleTypebit)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Booleanbit0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IBooleanSingleTypebit)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Booleanbit0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBooleanbit0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanSingleTypebit)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanSingleTypebit)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModelDynPar",
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
FROM dbo.booleanbit0m m
LEFT JOIN dbo.booleanbit0mi mi ON mi.id = m.booleanbit0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models = await ((IBooleanSingleTypebit)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBooleanbit0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 90;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 42;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.booleanbit0m m
LEFT JOIN dbo.booleanbit0mi mi ON mi.id = m.booleanbit0mi_id
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
FROM dbo.booleanbit0m m
LEFT JOIN dbo.booleanbit0mi mi ON mi.id = m.booleanbit0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IBooleanSingleTypebit)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));
FlatBooleanbit0M.AssertModel(models[0],_testData[15], false);FlatBooleanbit0M.AssertModel(models[1],_testData[16], false);FlatBooleanbit0M.AssertModel(models[2],_testData[17], false);FlatBooleanbit0M.AssertModel(models[3],_testData[18], false);FlatBooleanbit0M.AssertModel(models[4],_testData[19], false);FlatBooleanbit0M.AssertModel(models[5],_testData[20], false);FlatBooleanbit0M.AssertModel(models[6],_testData[21], false);FlatBooleanbit0M.AssertModel(models[7],_testData[22], false);FlatBooleanbit0M.AssertModel(models[8],_testData[23], false);FlatBooleanbit0M.AssertModel(models[9],_testData[24], false);FlatBooleanbit0M.AssertModel(models[10],_testData[25], false);FlatBooleanbit0M.AssertModel(models[11],_testData[26], false);FlatBooleanbit0M.AssertModel(models[12],_testData[27], false);FlatBooleanbit0M.AssertModel(models[13],_testData[28], false);FlatBooleanbit0M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));
FlatBooleanbit0M.AssertModel(models[0],_testData[7], false);FlatBooleanbit0M.AssertModel(models[1],_testData[8], false);FlatBooleanbit0M.AssertModel(models[2],_testData[9], false);FlatBooleanbit0M.AssertModel(models[3],_testData[10], false);FlatBooleanbit0M.AssertModel(models[4],_testData[11], false);FlatBooleanbit0M.AssertModel(models[5],_testData[12], false);FlatBooleanbit0M.AssertModel(models[6],_testData[13], false);FlatBooleanbit0M.AssertModel(models[7],_testData[14], false);FlatBooleanbit0M.AssertModel(models[8],_testData[15], false);FlatBooleanbit0M.AssertModel(models[9],_testData[16], false);FlatBooleanbit0M.AssertModel(models[10],_testData[17], false);FlatBooleanbit0M.AssertModel(models[11],_testData[18], false);FlatBooleanbit0M.AssertModel(models[12],_testData[19], false);FlatBooleanbit0M.AssertModel(models[13],_testData[20], false);FlatBooleanbit0M.AssertModel(models[14],_testData[21], false);FlatBooleanbit0M.AssertModel(models[15],_testData[22], false);FlatBooleanbit0M.AssertModel(models[16],_testData[23], false);FlatBooleanbit0M.AssertModel(models[17],_testData[24], false);FlatBooleanbit0M.AssertModel(models[18],_testData[25], false);FlatBooleanbit0M.AssertModel(models[19],_testData[26], false);FlatBooleanbit0M.AssertModel(models[20],_testData[27], false);FlatBooleanbit0M.AssertModel(models[21],_testData[28], false);FlatBooleanbit0M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
FROM dbo.booleanbit0m m
LEFT JOIN dbo.booleanbit0mi mi ON mi.id = m.booleanbit0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models =  ((IBooleanSingleTypebit)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBooleanbit0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 42;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 87;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.booleanbit0m m
LEFT JOIN dbo.booleanbit0mi mi ON mi.id = m.booleanbit0mi_id
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
FROM dbo.booleanbit0m m
LEFT JOIN dbo.booleanbit0mi mi ON mi.id = m.booleanbit0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IBooleanSingleTypebit)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));
FlatBooleanbit0M.AssertModel(models[0],_testData[7], false);FlatBooleanbit0M.AssertModel(models[1],_testData[8], false);FlatBooleanbit0M.AssertModel(models[2],_testData[9], false);FlatBooleanbit0M.AssertModel(models[3],_testData[10], false);FlatBooleanbit0M.AssertModel(models[4],_testData[11], false);FlatBooleanbit0M.AssertModel(models[5],_testData[12], false);FlatBooleanbit0M.AssertModel(models[6],_testData[13], false);FlatBooleanbit0M.AssertModel(models[7],_testData[14], false);FlatBooleanbit0M.AssertModel(models[8],_testData[15], false);FlatBooleanbit0M.AssertModel(models[9],_testData[16], false);FlatBooleanbit0M.AssertModel(models[10],_testData[17], false);FlatBooleanbit0M.AssertModel(models[11],_testData[18], false);FlatBooleanbit0M.AssertModel(models[12],_testData[19], false);FlatBooleanbit0M.AssertModel(models[13],_testData[20], false);FlatBooleanbit0M.AssertModel(models[14],_testData[21], false);FlatBooleanbit0M.AssertModel(models[15],_testData[22], false);FlatBooleanbit0M.AssertModel(models[16],_testData[23], false);FlatBooleanbit0M.AssertModel(models[17],_testData[24], false);FlatBooleanbit0M.AssertModel(models[18],_testData[25], false);FlatBooleanbit0M.AssertModel(models[19],_testData[26], false);FlatBooleanbit0M.AssertModel(models[20],_testData[27], false);FlatBooleanbit0M.AssertModel(models[21],_testData[28], false);FlatBooleanbit0M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));
FlatBooleanbit0M.AssertModel(models[0],_testData[14], false);FlatBooleanbit0M.AssertModel(models[1],_testData[15], false);FlatBooleanbit0M.AssertModel(models[2],_testData[16], false);FlatBooleanbit0M.AssertModel(models[3],_testData[17], false);FlatBooleanbit0M.AssertModel(models[4],_testData[18], false);FlatBooleanbit0M.AssertModel(models[5],_testData[19], false);FlatBooleanbit0M.AssertModel(models[6],_testData[20], false);FlatBooleanbit0M.AssertModel(models[7],_testData[21], false);FlatBooleanbit0M.AssertModel(models[8],_testData[22], false);FlatBooleanbit0M.AssertModel(models[9],_testData[23], false);FlatBooleanbit0M.AssertModel(models[10],_testData[24], false);FlatBooleanbit0M.AssertModel(models[11],_testData[25], false);FlatBooleanbit0M.AssertModel(models[12],_testData[26], false);FlatBooleanbit0M.AssertModel(models[13],_testData[27], false);FlatBooleanbit0M.AssertModel(models[14],_testData[28], false);FlatBooleanbit0M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
FROM dbo.booleanbit0m m
LEFT JOIN dbo.booleanbit0mi mi ON mi.id = m.booleanbit0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Booleanbit0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanSingleTypebit)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanSingleTypebit)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModelDynPar",
            position: 2)]
        private void DbConnectionSelectModelDynParBatchConfig()
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

                var models = await ((IBooleanSingleTypebit)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Booleanbit0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 7;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 133;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((IBooleanSingleTypebit)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));
Booleanbit0M.AssertModel(models[0],_testData[1], false);Booleanbit0M.AssertModel(models[1],_testData[2], false);Booleanbit0M.AssertModel(models[2],_testData[3], false);Booleanbit0M.AssertModel(models[3],_testData[4], false);Booleanbit0M.AssertModel(models[4],_testData[5], false);Booleanbit0M.AssertModel(models[5],_testData[6], false);Booleanbit0M.AssertModel(models[6],_testData[7], false);Booleanbit0M.AssertModel(models[7],_testData[8], false);Booleanbit0M.AssertModel(models[8],_testData[9], false);Booleanbit0M.AssertModel(models[9],_testData[10], false);Booleanbit0M.AssertModel(models[10],_testData[11], false);Booleanbit0M.AssertModel(models[11],_testData[12], false);Booleanbit0M.AssertModel(models[12],_testData[13], false);Booleanbit0M.AssertModel(models[13],_testData[14], false);Booleanbit0M.AssertModel(models[14],_testData[15], false);Booleanbit0M.AssertModel(models[15],_testData[16], false);Booleanbit0M.AssertModel(models[16],_testData[17], false);Booleanbit0M.AssertModel(models[17],_testData[18], false);Booleanbit0M.AssertModel(models[18],_testData[19], false);Booleanbit0M.AssertModel(models[19],_testData[20], false);Booleanbit0M.AssertModel(models[20],_testData[21], false);Booleanbit0M.AssertModel(models[21],_testData[22], false);Booleanbit0M.AssertModel(models[22],_testData[23], false);Booleanbit0M.AssertModel(models[23],_testData[24], false);Booleanbit0M.AssertModel(models[24],_testData[25], false);Booleanbit0M.AssertModel(models[25],_testData[26], false);Booleanbit0M.AssertModel(models[26],_testData[27], false);Booleanbit0M.AssertModel(models[27],_testData[28], false);Booleanbit0M.AssertModel(models[28],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));
Booleanbit0M.AssertModel(models[0],_testData[23], false);Booleanbit0M.AssertModel(models[1],_testData[24], false);Booleanbit0M.AssertModel(models[2],_testData[25], false);Booleanbit0M.AssertModel(models[3],_testData[26], false);Booleanbit0M.AssertModel(models[4],_testData[27], false);Booleanbit0M.AssertModel(models[5],_testData[28], false);Booleanbit0M.AssertModel(models[6],_testData[29], false);
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

                var models =  ((IBooleanSingleTypebit)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Booleanbit0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 65;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 39;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((IBooleanSingleTypebit)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));
Booleanbit0M.AssertModel(models[0],_testData[10], false);Booleanbit0M.AssertModel(models[1],_testData[11], false);Booleanbit0M.AssertModel(models[2],_testData[12], false);Booleanbit0M.AssertModel(models[3],_testData[13], false);Booleanbit0M.AssertModel(models[4],_testData[14], false);Booleanbit0M.AssertModel(models[5],_testData[15], false);Booleanbit0M.AssertModel(models[6],_testData[16], false);Booleanbit0M.AssertModel(models[7],_testData[17], false);Booleanbit0M.AssertModel(models[8],_testData[18], false);Booleanbit0M.AssertModel(models[9],_testData[19], false);Booleanbit0M.AssertModel(models[10],_testData[20], false);Booleanbit0M.AssertModel(models[11],_testData[21], false);Booleanbit0M.AssertModel(models[12],_testData[22], false);Booleanbit0M.AssertModel(models[13],_testData[23], false);Booleanbit0M.AssertModel(models[14],_testData[24], false);Booleanbit0M.AssertModel(models[15],_testData[25], false);Booleanbit0M.AssertModel(models[16],_testData[26], false);Booleanbit0M.AssertModel(models[17],_testData[27], false);Booleanbit0M.AssertModel(models[18],_testData[28], false);Booleanbit0M.AssertModel(models[19],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));
Booleanbit0M.AssertModel(models[0],_testData[6], false);Booleanbit0M.AssertModel(models[1],_testData[7], false);Booleanbit0M.AssertModel(models[2],_testData[8], false);Booleanbit0M.AssertModel(models[3],_testData[9], false);Booleanbit0M.AssertModel(models[4],_testData[10], false);Booleanbit0M.AssertModel(models[5],_testData[11], false);Booleanbit0M.AssertModel(models[6],_testData[12], false);Booleanbit0M.AssertModel(models[7],_testData[13], false);Booleanbit0M.AssertModel(models[8],_testData[14], false);Booleanbit0M.AssertModel(models[9],_testData[15], false);Booleanbit0M.AssertModel(models[10],_testData[16], false);Booleanbit0M.AssertModel(models[11],_testData[17], false);Booleanbit0M.AssertModel(models[12],_testData[18], false);Booleanbit0M.AssertModel(models[13],_testData[19], false);Booleanbit0M.AssertModel(models[14],_testData[20], false);Booleanbit0M.AssertModel(models[15],_testData[21], false);Booleanbit0M.AssertModel(models[16],_testData[22], false);Booleanbit0M.AssertModel(models[17],_testData[23], false);Booleanbit0M.AssertModel(models[18],_testData[24], false);Booleanbit0M.AssertModel(models[19],_testData[25], false);Booleanbit0M.AssertModel(models[20],_testData[26], false);Booleanbit0M.AssertModel(models[21],_testData[27], false);Booleanbit0M.AssertModel(models[22],_testData[28], false);Booleanbit0M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBooleanbit0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanSingleTypebit)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)11)]
        private void DbConnectionDynQuerySelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanSingleTypebit)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModel",
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
FROM dbo.booleanbit0m m
LEFT JOIN dbo.booleanbit0mi mi ON mi.id = m.booleanbit0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await ((IBooleanSingleTypebit)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBooleanbit0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.booleanbit0m m
LEFT JOIN dbo.booleanbit0mi mi ON mi.id = m.booleanbit0mi_id
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
FROM dbo.booleanbit0m m
LEFT JOIN dbo.booleanbit0mi mi ON mi.id = m.booleanbit0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IBooleanSingleTypebit)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 123, query1, 34, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));
FlatBooleanbit0M.AssertModel(models[0],_testData[21], false);FlatBooleanbit0M.AssertModel(models[1],_testData[22], false);FlatBooleanbit0M.AssertModel(models[2],_testData[23], false);FlatBooleanbit0M.AssertModel(models[3],_testData[24], false);FlatBooleanbit0M.AssertModel(models[4],_testData[25], false);FlatBooleanbit0M.AssertModel(models[5],_testData[26], false);FlatBooleanbit0M.AssertModel(models[6],_testData[27], false);FlatBooleanbit0M.AssertModel(models[7],_testData[28], false);FlatBooleanbit0M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));
FlatBooleanbit0M.AssertModel(models[0],_testData[5], false);FlatBooleanbit0M.AssertModel(models[1],_testData[6], false);FlatBooleanbit0M.AssertModel(models[2],_testData[7], false);FlatBooleanbit0M.AssertModel(models[3],_testData[8], false);FlatBooleanbit0M.AssertModel(models[4],_testData[9], false);FlatBooleanbit0M.AssertModel(models[5],_testData[10], false);FlatBooleanbit0M.AssertModel(models[6],_testData[11], false);FlatBooleanbit0M.AssertModel(models[7],_testData[12], false);FlatBooleanbit0M.AssertModel(models[8],_testData[13], false);FlatBooleanbit0M.AssertModel(models[9],_testData[14], false);FlatBooleanbit0M.AssertModel(models[10],_testData[15], false);FlatBooleanbit0M.AssertModel(models[11],_testData[16], false);FlatBooleanbit0M.AssertModel(models[12],_testData[17], false);FlatBooleanbit0M.AssertModel(models[13],_testData[18], false);FlatBooleanbit0M.AssertModel(models[14],_testData[19], false);FlatBooleanbit0M.AssertModel(models[15],_testData[20], false);FlatBooleanbit0M.AssertModel(models[16],_testData[21], false);FlatBooleanbit0M.AssertModel(models[17],_testData[22], false);FlatBooleanbit0M.AssertModel(models[18],_testData[23], false);FlatBooleanbit0M.AssertModel(models[19],_testData[24], false);FlatBooleanbit0M.AssertModel(models[20],_testData[25], false);FlatBooleanbit0M.AssertModel(models[21],_testData[26], false);FlatBooleanbit0M.AssertModel(models[22],_testData[27], false);FlatBooleanbit0M.AssertModel(models[23],_testData[28], false);FlatBooleanbit0M.AssertModel(models[24],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
FROM dbo.booleanbit0m m
LEFT JOIN dbo.booleanbit0mi mi ON mi.id = m.booleanbit0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models =  ((IBooleanSingleTypebit)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatBooleanbit0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.booleanbit0m m
LEFT JOIN dbo.booleanbit0mi mi ON mi.id = m.booleanbit0mi_id
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
FROM dbo.booleanbit0m m
LEFT JOIN dbo.booleanbit0mi mi ON mi.id = m.booleanbit0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IBooleanSingleTypebit)this).DbConnectionDynQuerySelectModelBatch(connection, 108, query1, 42, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));
FlatBooleanbit0M.AssertModel(models[0],_testData[19], false);FlatBooleanbit0M.AssertModel(models[1],_testData[20], false);FlatBooleanbit0M.AssertModel(models[2],_testData[21], false);FlatBooleanbit0M.AssertModel(models[3],_testData[22], false);FlatBooleanbit0M.AssertModel(models[4],_testData[23], false);FlatBooleanbit0M.AssertModel(models[5],_testData[24], false);FlatBooleanbit0M.AssertModel(models[6],_testData[25], false);FlatBooleanbit0M.AssertModel(models[7],_testData[26], false);FlatBooleanbit0M.AssertModel(models[8],_testData[27], false);FlatBooleanbit0M.AssertModel(models[9],_testData[28], false);FlatBooleanbit0M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));
FlatBooleanbit0M.AssertModel(models[0],_testData[7], false);FlatBooleanbit0M.AssertModel(models[1],_testData[8], false);FlatBooleanbit0M.AssertModel(models[2],_testData[9], false);FlatBooleanbit0M.AssertModel(models[3],_testData[10], false);FlatBooleanbit0M.AssertModel(models[4],_testData[11], false);FlatBooleanbit0M.AssertModel(models[5],_testData[12], false);FlatBooleanbit0M.AssertModel(models[6],_testData[13], false);FlatBooleanbit0M.AssertModel(models[7],_testData[14], false);FlatBooleanbit0M.AssertModel(models[8],_testData[15], false);FlatBooleanbit0M.AssertModel(models[9],_testData[16], false);FlatBooleanbit0M.AssertModel(models[10],_testData[17], false);FlatBooleanbit0M.AssertModel(models[11],_testData[18], false);FlatBooleanbit0M.AssertModel(models[12],_testData[19], false);FlatBooleanbit0M.AssertModel(models[13],_testData[20], false);FlatBooleanbit0M.AssertModel(models[14],_testData[21], false);FlatBooleanbit0M.AssertModel(models[15],_testData[22], false);FlatBooleanbit0M.AssertModel(models[16],_testData[23], false);FlatBooleanbit0M.AssertModel(models[17],_testData[24], false);FlatBooleanbit0M.AssertModel(models[18],_testData[25], false);FlatBooleanbit0M.AssertModel(models[19],_testData[26], false);FlatBooleanbit0M.AssertModel(models[20],_testData[27], false);FlatBooleanbit0M.AssertModel(models[21],_testData[28], false);FlatBooleanbit0M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
FROM dbo.booleanbit0m m
LEFT JOIN dbo.booleanbit0mi mi ON mi.id = m.booleanbit0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Booleanbit0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanSingleTypebit)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)11)]
        private void DbConnectionSelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBooleanSingleTypebit)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModel",
            position: 2)]
        private void DbConnectionSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IBooleanSingleTypebit)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Booleanbit0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in await ((IBooleanSingleTypebit)this).DbConnectionSelectModelBatchAsync(connection, 93, 126))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));
Booleanbit0M.AssertModel(models[0],_testData[16], false);Booleanbit0M.AssertModel(models[1],_testData[17], false);Booleanbit0M.AssertModel(models[2],_testData[18], false);Booleanbit0M.AssertModel(models[3],_testData[19], false);Booleanbit0M.AssertModel(models[4],_testData[20], false);Booleanbit0M.AssertModel(models[5],_testData[21], false);Booleanbit0M.AssertModel(models[6],_testData[22], false);Booleanbit0M.AssertModel(models[7],_testData[23], false);Booleanbit0M.AssertModel(models[8],_testData[24], false);Booleanbit0M.AssertModel(models[9],_testData[25], false);Booleanbit0M.AssertModel(models[10],_testData[26], false);Booleanbit0M.AssertModel(models[11],_testData[27], false);Booleanbit0M.AssertModel(models[12],_testData[28], false);Booleanbit0M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));
Booleanbit0M.AssertModel(models[0],_testData[22], false);Booleanbit0M.AssertModel(models[1],_testData[23], false);Booleanbit0M.AssertModel(models[2],_testData[24], false);Booleanbit0M.AssertModel(models[3],_testData[25], false);Booleanbit0M.AssertModel(models[4],_testData[26], false);Booleanbit0M.AssertModel(models[5],_testData[27], false);Booleanbit0M.AssertModel(models[6],_testData[28], false);Booleanbit0M.AssertModel(models[7],_testData[29], false);
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
                var models =  ((IBooleanSingleTypebit)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Booleanbit0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in  ((IBooleanSingleTypebit)this).DbConnectionSelectModelBatch(connection, 84, 87))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));
Booleanbit0M.AssertModel(models[0],_testData[13], false);Booleanbit0M.AssertModel(models[1],_testData[14], false);Booleanbit0M.AssertModel(models[2],_testData[15], false);Booleanbit0M.AssertModel(models[3],_testData[16], false);Booleanbit0M.AssertModel(models[4],_testData[17], false);Booleanbit0M.AssertModel(models[5],_testData[18], false);Booleanbit0M.AssertModel(models[6],_testData[19], false);Booleanbit0M.AssertModel(models[7],_testData[20], false);Booleanbit0M.AssertModel(models[8],_testData[21], false);Booleanbit0M.AssertModel(models[9],_testData[22], false);Booleanbit0M.AssertModel(models[10],_testData[23], false);Booleanbit0M.AssertModel(models[11],_testData[24], false);Booleanbit0M.AssertModel(models[12],_testData[25], false);Booleanbit0M.AssertModel(models[13],_testData[26], false);Booleanbit0M.AssertModel(models[14],_testData[27], false);Booleanbit0M.AssertModel(models[15],_testData[28], false);Booleanbit0M.AssertModel(models[16],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));
Booleanbit0M.AssertModel(models[0],_testData[14], false);Booleanbit0M.AssertModel(models[1],_testData[15], false);Booleanbit0M.AssertModel(models[2],_testData[16], false);Booleanbit0M.AssertModel(models[3],_testData[17], false);Booleanbit0M.AssertModel(models[4],_testData[18], false);Booleanbit0M.AssertModel(models[5],_testData[19], false);Booleanbit0M.AssertModel(models[6],_testData[20], false);Booleanbit0M.AssertModel(models[7],_testData[21], false);Booleanbit0M.AssertModel(models[8],_testData[22], false);Booleanbit0M.AssertModel(models[9],_testData[23], false);Booleanbit0M.AssertModel(models[10],_testData[24], false);Booleanbit0M.AssertModel(models[11],_testData[25], false);Booleanbit0M.AssertModel(models[12],_testData[26], false);Booleanbit0M.AssertModel(models[13],_testData[27], false);Booleanbit0M.AssertModel(models[14],_testData[28], false);Booleanbit0M.AssertModel(models[15],_testData[29], false);
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
                await using var cmd = await ((IBooleanSingleTypebit)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IBooleanSingleTypebit)this).SetDbConnectionSelectModelParametrs(cmd, 42);
                var models = await ((IBooleanSingleTypebit)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(23));
Booleanbit0M.AssertModel(models[0],_testData[7], false);Booleanbit0M.AssertModel(models[1],_testData[8], false);Booleanbit0M.AssertModel(models[2],_testData[9], false);Booleanbit0M.AssertModel(models[3],_testData[10], false);Booleanbit0M.AssertModel(models[4],_testData[11], false);Booleanbit0M.AssertModel(models[5],_testData[12], false);Booleanbit0M.AssertModel(models[6],_testData[13], false);Booleanbit0M.AssertModel(models[7],_testData[14], false);Booleanbit0M.AssertModel(models[8],_testData[15], false);Booleanbit0M.AssertModel(models[9],_testData[16], false);Booleanbit0M.AssertModel(models[10],_testData[17], false);Booleanbit0M.AssertModel(models[11],_testData[18], false);Booleanbit0M.AssertModel(models[12],_testData[19], false);Booleanbit0M.AssertModel(models[13],_testData[20], false);Booleanbit0M.AssertModel(models[14],_testData[21], false);Booleanbit0M.AssertModel(models[15],_testData[22], false);Booleanbit0M.AssertModel(models[16],_testData[23], false);Booleanbit0M.AssertModel(models[17],_testData[24], false);Booleanbit0M.AssertModel(models[18],_testData[25], false);Booleanbit0M.AssertModel(models[19],_testData[26], false);Booleanbit0M.AssertModel(models[20],_testData[27], false);Booleanbit0M.AssertModel(models[21],_testData[28], false);Booleanbit0M.AssertModel(models[22],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IBooleanSingleTypebit)this).CreateDbConnectionSelectModelCommand(connection);
                ((IBooleanSingleTypebit)this).SetDbConnectionSelectModelParametrs(cmd, 34);
                var models =  ((IBooleanSingleTypebit)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(25));
Booleanbit0M.AssertModel(models[0],_testData[5], false);Booleanbit0M.AssertModel(models[1],_testData[6], false);Booleanbit0M.AssertModel(models[2],_testData[7], false);Booleanbit0M.AssertModel(models[3],_testData[8], false);Booleanbit0M.AssertModel(models[4],_testData[9], false);Booleanbit0M.AssertModel(models[5],_testData[10], false);Booleanbit0M.AssertModel(models[6],_testData[11], false);Booleanbit0M.AssertModel(models[7],_testData[12], false);Booleanbit0M.AssertModel(models[8],_testData[13], false);Booleanbit0M.AssertModel(models[9],_testData[14], false);Booleanbit0M.AssertModel(models[10],_testData[15], false);Booleanbit0M.AssertModel(models[11],_testData[16], false);Booleanbit0M.AssertModel(models[12],_testData[17], false);Booleanbit0M.AssertModel(models[13],_testData[18], false);Booleanbit0M.AssertModel(models[14],_testData[19], false);Booleanbit0M.AssertModel(models[15],_testData[20], false);Booleanbit0M.AssertModel(models[16],_testData[21], false);Booleanbit0M.AssertModel(models[17],_testData[22], false);Booleanbit0M.AssertModel(models[18],_testData[23], false);Booleanbit0M.AssertModel(models[19],_testData[24], false);Booleanbit0M.AssertModel(models[20],_testData[25], false);Booleanbit0M.AssertModel(models[21],_testData[26], false);Booleanbit0M.AssertModel(models[22],_testData[27], false);Booleanbit0M.AssertModel(models[23],_testData[28], false);Booleanbit0M.AssertModel(models[24],_testData[29], false);
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
FROM dbo.booleanbit0m m
LEFT JOIN dbo.booleanbit0mi mi ON mi.id = m.booleanbit0mi_id
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
            asPartInterface: typeof(IBooleanSingleTypebit))]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IBooleanSingleTypebit)this).DbConnectionSelectModelToObjArrAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((System.Boolean?)model[4], Is.EqualTo((false)));//InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((System.Boolean?)model[4], Is.EqualTo((false)));//InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((System.Boolean?)model[4], Is.EqualTo((false)));//InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((21)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((System.Boolean?)model[4], Is.EqualTo((false)));//InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((System.Boolean?)model[4], Is.EqualTo((false)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((System.Boolean?)model[4], Is.EqualTo((false)));//InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((System.Boolean?)model[4], Is.EqualTo((false)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((System.Boolean?)model[4], Is.EqualTo((false)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((50)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((System.Boolean?)model[4], Is.EqualTo((false)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((System.Boolean?)model[4], Is.EqualTo((false)));//InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((142)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((145)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((System.Boolean?)model[4], Is.EqualTo((false)));//InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((159)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((73)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

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
                var models =  ((IBooleanSingleTypebit)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((System.Boolean?)model[4], Is.EqualTo((false)));//InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((System.Boolean?)model[4], Is.EqualTo((false)));//InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((System.Boolean?)model[4], Is.EqualTo((false)));//InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((21)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((System.Boolean?)model[4], Is.EqualTo((false)));//InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((System.Boolean?)model[4], Is.EqualTo((false)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((System.Boolean?)model[4], Is.EqualTo((false)));//InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((System.Boolean?)model[4], Is.EqualTo((false)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((System.Boolean?)model[4], Is.EqualTo((false)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((50)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((System.Boolean?)model[4], Is.EqualTo((false)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((System.Boolean?)model[4], Is.EqualTo((false)));//InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((142)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((145)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((System.Boolean?)model[4], Is.EqualTo((false)));//InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Boolean?)model[5], Is.EqualTo((false)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((159)));//Id
                Assert.That((System.Boolean)model[1], Is.EqualTo((false)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((73)));//InnerModel.Id
                Assert.That((System.Boolean)model[3], Is.EqualTo((false)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

#endregion

    }
}

