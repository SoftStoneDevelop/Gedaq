

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
    internal partial interface IInt64SingleTypebigint
    {
    }
    
    internal partial class Int64SingleTypebigint : IInt64SingleTypebigint
    {


#region TestData

        private readonly Int64bigintE0M[] _testData = new Int64bigintE0M[]
        {
            new Int64bigintE0M
{
    Id = 6,
    Value = 30338870458203208L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 8,
    Value = 4388602603431776169L,
    ModelInner = new Int64bigint0MI
{
    Id = 6,
    Value = 8978815824754770328L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 11,
    Value = 2251980475124171594L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 19,
    Value = 333361581407437596L,
    ModelInner = new Int64bigint0MI
{
    Id = 12,
    Value = 7512053888756313369L,
    NullableValue = 2694139537634285596L,
},
    NullableValue = 6848915794432874147L,
},
            new Int64bigintE0M
{
    Id = 24,
    Value = 8937685055913761564L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 31,
    Value = 7253329084759940679L,
    ModelInner = new Int64bigint0MI
{
    Id = 15,
    Value = 8389439359648048725L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 40,
    Value = 167083696851158012L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 41,
    Value = 6761601564869142314L,
    ModelInner = new Int64bigint0MI
{
    Id = 18,
    Value = 8342017475733971881L,
    NullableValue = null,
},
    NullableValue = 4840564196060032139L,
},
            new Int64bigintE0M
{
    Id = 43,
    Value = 123476629920921951L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 52,
    Value = 3864105645068728905L,
    ModelInner = new Int64bigint0MI
{
    Id = 23,
    Value = 1083624934223758353L,
    NullableValue = 177222626280607533L,
},
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 59,
    Value = 4966121989367568198L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 64,
    Value = 3728801696566185167L,
    ModelInner = new Int64bigint0MI
{
    Id = 25,
    Value = 8968273216297379323L,
    NullableValue = 342386865916234536L,
},
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 68,
    Value = 597206782183444795L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 76,
    Value = 8252469202804777650L,
    ModelInner = new Int64bigint0MI
{
    Id = 26,
    Value = 1480978358327358876L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 80,
    Value = 3210090778448467509L,
    ModelInner = null,
    NullableValue = 4663808699855873694L,
},
            new Int64bigintE0M
{
    Id = 83,
    Value = 5921260228570015342L,
    ModelInner = new Int64bigint0MI
{
    Id = 30,
    Value = 3131350739827165436L,
    NullableValue = 1625332773167811805L,
},
    NullableValue = 4037568007986925077L,
},
            new Int64bigintE0M
{
    Id = 86,
    Value = 3685627215191332724L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 87,
    Value = 68081455076488163L,
    ModelInner = new Int64bigint0MI
{
    Id = 38,
    Value = 3771336928392219315L,
    NullableValue = null,
},
    NullableValue = 4209706489939556746L,
},
            new Int64bigintE0M
{
    Id = 94,
    Value = 7690485931433422598L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 98,
    Value = 3072475807265548307L,
    ModelInner = new Int64bigint0MI
{
    Id = 39,
    Value = 2836326997889712819L,
    NullableValue = null,
},
    NullableValue = 6611551080621589510L,
},
            new Int64bigintE0M
{
    Id = 103,
    Value = 231676573024461380L,
    ModelInner = null,
    NullableValue = 5519896626344484533L,
},
            new Int64bigintE0M
{
    Id = 112,
    Value = 1018413611844699341L,
    ModelInner = new Int64bigint0MI
{
    Id = 40,
    Value = 1970496317643522353L,
    NullableValue = 4448520683491495835L,
},
    NullableValue = 8356035381513245005L,
},
            new Int64bigintE0M
{
    Id = 119,
    Value = 1593512372035613521L,
    ModelInner = null,
    NullableValue = 222584959939992203L,
},
            new Int64bigintE0M
{
    Id = 126,
    Value = 1321850455803132111L,
    ModelInner = new Int64bigint0MI
{
    Id = 47,
    Value = 7408705437132355958L,
    NullableValue = 4983377418569574666L,
},
    NullableValue = 1676245000076272972L,
},
            new Int64bigintE0M
{
    Id = 129,
    Value = 1705432201838571730L,
    ModelInner = null,
    NullableValue = 8392073654209579311L,
},
            new Int64bigintE0M
{
    Id = 135,
    Value = 6574968732809543974L,
    ModelInner = new Int64bigint0MI
{
    Id = 51,
    Value = 3314584281683989970L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 141,
    Value = 8293893247953697077L,
    ModelInner = null,
    NullableValue = 1706914984662316796L,
},
            new Int64bigintE0M
{
    Id = 145,
    Value = 6670096046764311743L,
    ModelInner = new Int64bigint0MI
{
    Id = 57,
    Value = 6565080384145402851L,
    NullableValue = 6567272566607620849L,
},
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 152,
    Value = 7384524704297118741L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 156,
    Value = 7308819837791587467L,
    ModelInner = new Int64bigint0MI
{
    Id = 58,
    Value = 5284646734268855483L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 157,
    Value = 689394174108087144L,
    ModelInner = null,
    NullableValue = 2450184031047429852L,
},
            new Int64bigintE0M
{
    Id = 159,
    Value = 8621225403229817569L,
    ModelInner = new Int64bigint0MI
{
    Id = 60,
    Value = 1383454006888657771L,
    NullableValue = 2680363333456468200L,
},
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 164,
    Value = 7442891904083123016L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 168,
    Value = 2152327352604882553L,
    ModelInner = new Int64bigint0MI
{
    Id = 63,
    Value = 5008354502894765864L,
    NullableValue = 8242176440798583598L,
},
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 175,
    Value = 2795395377371824644L,
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.SqlClient.Attributes.Query(
            query: @"
INSERT INTO dbo.int64bigint0mi(
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
            asPartInterface: typeof(IInt64SingleTypebigint)), 
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                parametrName: "id",
                methodParametrName: "id", 
                dbType: (System.Data.SqlDbType)(8)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int64),
                parametrName: "value",
                methodParametrName: "value",
                dbType: (System.Data.SqlDbType)(0)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int64?), 
                parametrName: "nullablevalue",
                methodParametrName: "nullablevalue",
                dbType: (System.Data.SqlDbType)(0))
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

                changedRows =  ((IInt64SingleTypebigint)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IInt64SingleTypebigint)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IInt64SingleTypebigint)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO dbo.int64bigint0mi(
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
            asPartInterface: typeof(IInt64SingleTypebigint)), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)11),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int64), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)12),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int64?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)12, 
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

                changedRows =  ((IInt64SingleTypebigint)this).DbConnectionInsertInnerModel(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
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

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertInnerModelAsync(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertInnerModelAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertInnerModelAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertInnerModelAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertInnerModelAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertInnerModelAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertInnerModelAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertInnerModelAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertInnerModelAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertInnerModelAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertInnerModelAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertInnerModelAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.SqlClient.Attributes.Query(
            query: @"
INSERT INTO dbo.int64biginte0m(
	id,
    value,
    nullablevalue,
    int64bigint0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @int64bigint0mi_id
)
",
            methodName:"InsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                parametrName: "id",
                methodParametrName: "id",
                dbType: (System.Data.SqlDbType)(8)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int64), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.SqlDbType)(0)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int64?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.SqlDbType)(0),
                nullable: true),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "int64bigint0mi_id", 
                methodParametrName: "int64bigint0mi_id", 
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

                changedRows =  ((IInt64SingleTypebigint)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IInt64SingleTypebigint)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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

                changedRows = await ((IInt64SingleTypebigint)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO dbo.int64biginte0m(
	id,
    value,
    nullablevalue,
    int64bigint0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @int64bigint0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)11),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int64), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)12),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int64?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)12,
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "int64bigint0mi_id", 
                methodParametrName: "int64bigint0mi_id", 
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

                changedRows =  ((IInt64SingleTypebigint)this).DbConnectionInsertModel(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IInt64SingleTypebigint)this).DbConnectionInsertModel(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
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

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64SingleTypebigint)this).DbConnectionInsertModelAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintE0M), typeof(FlatInt64bigintE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
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
FROM dbo.int64biginte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt64bigintE0M>();
                var models2 = new List<FlatInt64bigintE0M>();
                await((IInt64SingleTypebigint)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintE0M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintE0M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.int64biginte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt64bigintE0M>();
                var models2 = new List<FlatInt64bigintE0M>();
                ((IInt64SingleTypebigint)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintE0M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
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
FROM dbo.int64biginte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models = await((IInt64SingleTypebigint)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintE0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.int64biginte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models = ((IInt64SingleTypebigint)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintE0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.int64biginte0m m
LEFT JOIN dbo.int64bigint0mi mi ON mi.id = m.int64bigint0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Int64bigintE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
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
                var models = await((IInt64SingleTypebigint)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintE0M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IInt64SingleTypebigint)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintE0M), typeof(FlatInt64bigintE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
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
FROM dbo.int64biginte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigintE0M>();
                var models2 = new List<FlatInt64bigintE0M>();
                await((IInt64SingleTypebigint)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintE0M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintE0M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.int64biginte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigintE0M>();
                var models2 = new List<FlatInt64bigintE0M>();
                ((IInt64SingleTypebigint)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintE0M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
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
FROM dbo.int64biginte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IInt64SingleTypebigint)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintE0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.int64biginte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IInt64SingleTypebigint)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintE0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.int64biginte0m m
LEFT JOIN dbo.int64bigint0mi mi ON mi.id = m.int64bigint0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Int64bigintE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
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
                var models = await((IInt64SingleTypebigint)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IInt64SingleTypebigint)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintE0M), typeof(FlatInt64bigintE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
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
            asPartInterface: typeof(IInt64SingleTypebigint)),
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
FROM dbo.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt64bigintE0M>();
                var models2 = new List<FlatInt64bigintE0M>();
                await((IInt64SingleTypebigint)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintE0M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 31;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 145;
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
FROM dbo.int64biginte0m m
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
FROM dbo.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintE0M>();
                var firstItems2 = new List<FlatInt64bigintE0M>();
                var secondItems1 = new List<FlatInt64bigintE0M>();
                var secondItems2 = new List<FlatInt64bigintE0M>();
                await ((IInt64SingleTypebigint)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatInt64bigintE0M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatInt64bigintE0M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[6],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 103;
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
FROM dbo.int64biginte0m m
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
FROM dbo.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintE0M>();
                var firstItems2 = new List<FlatInt64bigintE0M>();
                var secondItems1 = new List<FlatInt64bigintE0M>();
                await ((IInt64SingleTypebigint)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatInt64bigintE0M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatInt64bigintE0M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[12],_testData[34], false);
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
FROM dbo.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt64bigintE0M>();
                var models2 = new List<FlatInt64bigintE0M>();
                ((IInt64SingleTypebigint)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintE0M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 41;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 19;
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
FROM dbo.int64biginte0m m
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
FROM dbo.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintE0M>();
                var firstItems2 = new List<FlatInt64bigintE0M>();
                var secondItems1 = new List<FlatInt64bigintE0M>();
                var secondItems2 = new List<FlatInt64bigintE0M>();
                 ((IInt64SingleTypebigint)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatInt64bigintE0M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatInt64bigintE0M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[30],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 159;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 80;
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
FROM dbo.int64biginte0m m
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
FROM dbo.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintE0M>();
                var firstItems2 = new List<FlatInt64bigintE0M>();
                var secondItems1 = new List<FlatInt64bigintE0M>();
                 ((IInt64SingleTypebigint)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatInt64bigintE0M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatInt64bigintE0M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[19],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
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
            asPartInterface: typeof(IInt64SingleTypebigint)),
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
FROM dbo.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IInt64SingleTypebigint)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 145;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 86;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.int64biginte0m m
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
FROM dbo.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64SingleTypebigint)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatInt64bigintE0M.AssertModel(models[0],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(models[1],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(models[2],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(models[3],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(models[4],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(models[5],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatInt64bigintE0M.AssertModel(models[0],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(models[1],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(models[2],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(models[3],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(models[4],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(models[5],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(models[6],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(models[7],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(models[8],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(models[9],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(models[10],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(models[11],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(models[12],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(models[13],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(models[14],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(models[15],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(models[16],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(models[17],_testData[34], false);
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
                parametr1.Value = 159;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 145;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.int64biginte0m m
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
FROM dbo.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintE0M>();
                var secondItems1 = new List<FlatInt64bigintE0M>();
                var secondItems2 = new List<FlatInt64bigintE0M>();
                await ((IInt64SingleTypebigint)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatInt64bigintE0M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatInt64bigintE0M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[6],_testData[34], false);
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
FROM dbo.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IInt64SingleTypebigint)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 87;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 43;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.int64biginte0m m
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
FROM dbo.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64SingleTypebigint)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatInt64bigintE0M.AssertModel(models[0],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(models[1],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(models[2],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(models[3],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(models[4],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(models[5],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(models[6],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(models[7],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(models[8],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(models[9],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(models[10],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(models[11],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(models[12],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(models[13],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(models[14],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(models[15],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatInt64bigintE0M.AssertModel(models[0],_testData[9], false);
                        FlatInt64bigintE0M.AssertModel(models[1],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(models[2],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(models[3],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(models[4],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(models[5],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(models[6],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(models[7],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(models[8],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(models[9],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(models[10],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(models[11],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(models[12],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(models[13],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(models[14],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(models[15],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(models[16],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(models[17],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(models[18],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(models[19],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(models[20],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(models[21],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(models[22],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(models[23],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(models[24],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(models[25],_testData[34], false);
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
                parametr1.Value = 83;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 31;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.int64biginte0m m
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
FROM dbo.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintE0M>();
                var secondItems1 = new List<FlatInt64bigintE0M>();
                var secondItems2 = new List<FlatInt64bigintE0M>();
                 ((IInt64SingleTypebigint)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatInt64bigintE0M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatInt64bigintE0M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[28],_testData[34], false);
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
FROM dbo.int64biginte0m m
LEFT JOIN dbo.int64bigint0mi mi ON mi.id = m.int64bigint0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Int64bigintE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
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
                var models = await((IInt64SingleTypebigint)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 80;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 59;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64SingleTypebigint)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        Int64bigintE0M.AssertModel(models[0],_testData[15], false);
                        Int64bigintE0M.AssertModel(models[1],_testData[16], false);
                        Int64bigintE0M.AssertModel(models[2],_testData[17], false);
                        Int64bigintE0M.AssertModel(models[3],_testData[18], false);
                        Int64bigintE0M.AssertModel(models[4],_testData[19], false);
                        Int64bigintE0M.AssertModel(models[5],_testData[20], false);
                        Int64bigintE0M.AssertModel(models[6],_testData[21], false);
                        Int64bigintE0M.AssertModel(models[7],_testData[22], false);
                        Int64bigintE0M.AssertModel(models[8],_testData[23], false);
                        Int64bigintE0M.AssertModel(models[9],_testData[24], false);
                        Int64bigintE0M.AssertModel(models[10],_testData[25], false);
                        Int64bigintE0M.AssertModel(models[11],_testData[26], false);
                        Int64bigintE0M.AssertModel(models[12],_testData[27], false);
                        Int64bigintE0M.AssertModel(models[13],_testData[28], false);
                        Int64bigintE0M.AssertModel(models[14],_testData[29], false);
                        Int64bigintE0M.AssertModel(models[15],_testData[30], false);
                        Int64bigintE0M.AssertModel(models[16],_testData[31], false);
                        Int64bigintE0M.AssertModel(models[17],_testData[32], false);
                        Int64bigintE0M.AssertModel(models[18],_testData[33], false);
                        Int64bigintE0M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        Int64bigintE0M.AssertModel(models[0],_testData[11], false);
                        Int64bigintE0M.AssertModel(models[1],_testData[12], false);
                        Int64bigintE0M.AssertModel(models[2],_testData[13], false);
                        Int64bigintE0M.AssertModel(models[3],_testData[14], false);
                        Int64bigintE0M.AssertModel(models[4],_testData[15], false);
                        Int64bigintE0M.AssertModel(models[5],_testData[16], false);
                        Int64bigintE0M.AssertModel(models[6],_testData[17], false);
                        Int64bigintE0M.AssertModel(models[7],_testData[18], false);
                        Int64bigintE0M.AssertModel(models[8],_testData[19], false);
                        Int64bigintE0M.AssertModel(models[9],_testData[20], false);
                        Int64bigintE0M.AssertModel(models[10],_testData[21], false);
                        Int64bigintE0M.AssertModel(models[11],_testData[22], false);
                        Int64bigintE0M.AssertModel(models[12],_testData[23], false);
                        Int64bigintE0M.AssertModel(models[13],_testData[24], false);
                        Int64bigintE0M.AssertModel(models[14],_testData[25], false);
                        Int64bigintE0M.AssertModel(models[15],_testData[26], false);
                        Int64bigintE0M.AssertModel(models[16],_testData[27], false);
                        Int64bigintE0M.AssertModel(models[17],_testData[28], false);
                        Int64bigintE0M.AssertModel(models[18],_testData[29], false);
                        Int64bigintE0M.AssertModel(models[19],_testData[30], false);
                        Int64bigintE0M.AssertModel(models[20],_testData[31], false);
                        Int64bigintE0M.AssertModel(models[21],_testData[32], false);
                        Int64bigintE0M.AssertModel(models[22],_testData[33], false);
                        Int64bigintE0M.AssertModel(models[23],_testData[34], false);
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
                var models = ((IInt64SingleTypebigint)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 76;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 6;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64SingleTypebigint)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        Int64bigintE0M.AssertModel(models[0],_testData[14], false);
                        Int64bigintE0M.AssertModel(models[1],_testData[15], false);
                        Int64bigintE0M.AssertModel(models[2],_testData[16], false);
                        Int64bigintE0M.AssertModel(models[3],_testData[17], false);
                        Int64bigintE0M.AssertModel(models[4],_testData[18], false);
                        Int64bigintE0M.AssertModel(models[5],_testData[19], false);
                        Int64bigintE0M.AssertModel(models[6],_testData[20], false);
                        Int64bigintE0M.AssertModel(models[7],_testData[21], false);
                        Int64bigintE0M.AssertModel(models[8],_testData[22], false);
                        Int64bigintE0M.AssertModel(models[9],_testData[23], false);
                        Int64bigintE0M.AssertModel(models[10],_testData[24], false);
                        Int64bigintE0M.AssertModel(models[11],_testData[25], false);
                        Int64bigintE0M.AssertModel(models[12],_testData[26], false);
                        Int64bigintE0M.AssertModel(models[13],_testData[27], false);
                        Int64bigintE0M.AssertModel(models[14],_testData[28], false);
                        Int64bigintE0M.AssertModel(models[15],_testData[29], false);
                        Int64bigintE0M.AssertModel(models[16],_testData[30], false);
                        Int64bigintE0M.AssertModel(models[17],_testData[31], false);
                        Int64bigintE0M.AssertModel(models[18],_testData[32], false);
                        Int64bigintE0M.AssertModel(models[19],_testData[33], false);
                        Int64bigintE0M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        Int64bigintE0M.AssertModel(models[0],_testData[1], false);
                        Int64bigintE0M.AssertModel(models[1],_testData[2], false);
                        Int64bigintE0M.AssertModel(models[2],_testData[3], false);
                        Int64bigintE0M.AssertModel(models[3],_testData[4], false);
                        Int64bigintE0M.AssertModel(models[4],_testData[5], false);
                        Int64bigintE0M.AssertModel(models[5],_testData[6], false);
                        Int64bigintE0M.AssertModel(models[6],_testData[7], false);
                        Int64bigintE0M.AssertModel(models[7],_testData[8], false);
                        Int64bigintE0M.AssertModel(models[8],_testData[9], false);
                        Int64bigintE0M.AssertModel(models[9],_testData[10], false);
                        Int64bigintE0M.AssertModel(models[10],_testData[11], false);
                        Int64bigintE0M.AssertModel(models[11],_testData[12], false);
                        Int64bigintE0M.AssertModel(models[12],_testData[13], false);
                        Int64bigintE0M.AssertModel(models[13],_testData[14], false);
                        Int64bigintE0M.AssertModel(models[14],_testData[15], false);
                        Int64bigintE0M.AssertModel(models[15],_testData[16], false);
                        Int64bigintE0M.AssertModel(models[16],_testData[17], false);
                        Int64bigintE0M.AssertModel(models[17],_testData[18], false);
                        Int64bigintE0M.AssertModel(models[18],_testData[19], false);
                        Int64bigintE0M.AssertModel(models[19],_testData[20], false);
                        Int64bigintE0M.AssertModel(models[20],_testData[21], false);
                        Int64bigintE0M.AssertModel(models[21],_testData[22], false);
                        Int64bigintE0M.AssertModel(models[22],_testData[23], false);
                        Int64bigintE0M.AssertModel(models[23],_testData[24], false);
                        Int64bigintE0M.AssertModel(models[24],_testData[25], false);
                        Int64bigintE0M.AssertModel(models[25],_testData[26], false);
                        Int64bigintE0M.AssertModel(models[26],_testData[27], false);
                        Int64bigintE0M.AssertModel(models[27],_testData[28], false);
                        Int64bigintE0M.AssertModel(models[28],_testData[29], false);
                        Int64bigintE0M.AssertModel(models[29],_testData[30], false);
                        Int64bigintE0M.AssertModel(models[30],_testData[31], false);
                        Int64bigintE0M.AssertModel(models[31],_testData[32], false);
                        Int64bigintE0M.AssertModel(models[32],_testData[33], false);
                        Int64bigintE0M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintE0M), typeof(FlatInt64bigintE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
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
            asPartInterface: typeof(IInt64SingleTypebigint)),
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
            asPartInterface: typeof(IInt64SingleTypebigint)),
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
FROM dbo.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigintE0M>();
                var models2 = new List<FlatInt64bigintE0M>();
                await((IInt64SingleTypebigint)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintE0M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintE0M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.int64biginte0m m
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
FROM dbo.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintE0M>();
                var firstItems2 = new List<FlatInt64bigintE0M>();
                var secondItems1 = new List<FlatInt64bigintE0M>();
                var secondItems2 = new List<FlatInt64bigintE0M>();
                await ((IInt64SingleTypebigint)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 145, query1, 141, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatInt64bigintE0M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatInt64bigintE0M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[7],_testData[34], false);
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
FROM dbo.int64biginte0m m
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
FROM dbo.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintE0M>();
                var firstItems2 = new List<FlatInt64bigintE0M>();
                var secondItems1 = new List<FlatInt64bigintE0M>();
                await ((IInt64SingleTypebigint)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 98, query1, 6, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatInt64bigintE0M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                        FlatInt64bigintE0M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[33],_testData[34], false);
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
FROM dbo.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigintE0M>();
                var models2 = new List<FlatInt64bigintE0M>();
                ((IInt64SingleTypebigint)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintE0M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintE0M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.int64biginte0m m
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
FROM dbo.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintE0M>();
                var firstItems2 = new List<FlatInt64bigintE0M>();
                var secondItems1 = new List<FlatInt64bigintE0M>();
                var secondItems2 = new List<FlatInt64bigintE0M>();
                 ((IInt64SingleTypebigint)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 40, query1, 135, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatInt64bigintE0M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatInt64bigintE0M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[8],_testData[34], false);
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
FROM dbo.int64biginte0m m
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
FROM dbo.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintE0M>();
                var firstItems2 = new List<FlatInt64bigintE0M>();
                var secondItems1 = new List<FlatInt64bigintE0M>();
                 ((IInt64SingleTypebigint)this).DbConnectionMMDynQuerySelectModelBatch(connection, 164, query1, 64, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatInt64bigintE0M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatInt64bigintE0M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[22],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
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
            asPartInterface: typeof(IInt64SingleTypebigint)),
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
            asPartInterface: typeof(IInt64SingleTypebigint)),
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
FROM dbo.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IInt64SingleTypebigint)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintE0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.int64biginte0m m
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
FROM dbo.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64SingleTypebigint)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 80, query1, 43, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatInt64bigintE0M.AssertModel(models[0],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(models[1],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(models[2],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(models[3],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(models[4],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(models[5],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(models[6],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(models[7],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(models[8],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(models[9],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(models[10],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(models[11],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(models[12],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(models[13],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(models[14],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(models[15],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(models[16],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(models[17],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(models[18],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatInt64bigintE0M.AssertModel(models[0],_testData[9], false);
                        FlatInt64bigintE0M.AssertModel(models[1],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(models[2],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(models[3],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(models[4],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(models[5],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(models[6],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(models[7],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(models[8],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(models[9],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(models[10],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(models[11],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(models[12],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(models[13],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(models[14],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(models[15],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(models[16],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(models[17],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(models[18],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(models[19],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(models[20],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(models[21],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(models[22],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(models[23],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(models[24],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(models[25],_testData[34], false);
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
FROM dbo.int64biginte0m m
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
FROM dbo.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintE0M>();
                var secondItems1 = new List<FlatInt64bigintE0M>();
                var secondItems2 = new List<FlatInt64bigintE0M>();
                await ((IInt64SingleTypebigint)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 145, query1, 59, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatInt64bigintE0M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatInt64bigintE0M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[23],_testData[34], false);
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
FROM dbo.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IInt64SingleTypebigint)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintE0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.int64biginte0m m
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
FROM dbo.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64SingleTypebigint)this).DbConnectionSTDynQuerySelectModelBatch(connection, 41, query1, 24, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatInt64bigintE0M.AssertModel(models[0],_testData[8], false);
                        FlatInt64bigintE0M.AssertModel(models[1],_testData[9], false);
                        FlatInt64bigintE0M.AssertModel(models[2],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(models[3],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(models[4],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(models[5],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(models[6],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(models[7],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(models[8],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(models[9],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(models[10],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(models[11],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(models[12],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(models[13],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(models[14],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(models[15],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(models[16],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(models[17],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(models[18],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(models[19],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(models[20],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(models[21],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(models[22],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(models[23],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(models[24],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(models[25],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatInt64bigintE0M.AssertModel(models[0],_testData[5], false);
                        FlatInt64bigintE0M.AssertModel(models[1],_testData[6], false);
                        FlatInt64bigintE0M.AssertModel(models[2],_testData[7], false);
                        FlatInt64bigintE0M.AssertModel(models[3],_testData[8], false);
                        FlatInt64bigintE0M.AssertModel(models[4],_testData[9], false);
                        FlatInt64bigintE0M.AssertModel(models[5],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(models[6],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(models[7],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(models[8],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(models[9],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(models[10],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(models[11],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(models[12],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(models[13],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(models[14],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(models[15],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(models[16],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(models[17],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(models[18],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(models[19],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(models[20],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(models[21],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(models[22],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(models[23],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(models[24],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(models[25],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(models[26],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(models[27],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(models[28],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(models[29],_testData[34], false);
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
FROM dbo.int64biginte0m m
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
FROM dbo.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintE0M>();
                var secondItems1 = new List<FlatInt64bigintE0M>();
                var secondItems2 = new List<FlatInt64bigintE0M>();
                 ((IInt64SingleTypebigint)this).DbConnectionDynQuerySelectModelBatch(connection, 159, query1, 31, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatInt64bigintE0M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatInt64bigintE0M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[28],_testData[34], false);
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
FROM dbo.int64biginte0m m
LEFT JOIN dbo.int64bigint0mi mi ON mi.id = m.int64bigint0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Int64bigintE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
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
            asPartInterface: typeof(IInt64SingleTypebigint)),
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
                var models = await((IInt64SingleTypebigint)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IInt64SingleTypebigint)this).DbConnectionSTSelectModelBatchAsync(connection, 135, 59))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        Int64bigintE0M.AssertModel(models[0],_testData[26], false);
                        Int64bigintE0M.AssertModel(models[1],_testData[27], false);
                        Int64bigintE0M.AssertModel(models[2],_testData[28], false);
                        Int64bigintE0M.AssertModel(models[3],_testData[29], false);
                        Int64bigintE0M.AssertModel(models[4],_testData[30], false);
                        Int64bigintE0M.AssertModel(models[5],_testData[31], false);
                        Int64bigintE0M.AssertModel(models[6],_testData[32], false);
                        Int64bigintE0M.AssertModel(models[7],_testData[33], false);
                        Int64bigintE0M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        Int64bigintE0M.AssertModel(models[0],_testData[11], false);
                        Int64bigintE0M.AssertModel(models[1],_testData[12], false);
                        Int64bigintE0M.AssertModel(models[2],_testData[13], false);
                        Int64bigintE0M.AssertModel(models[3],_testData[14], false);
                        Int64bigintE0M.AssertModel(models[4],_testData[15], false);
                        Int64bigintE0M.AssertModel(models[5],_testData[16], false);
                        Int64bigintE0M.AssertModel(models[6],_testData[17], false);
                        Int64bigintE0M.AssertModel(models[7],_testData[18], false);
                        Int64bigintE0M.AssertModel(models[8],_testData[19], false);
                        Int64bigintE0M.AssertModel(models[9],_testData[20], false);
                        Int64bigintE0M.AssertModel(models[10],_testData[21], false);
                        Int64bigintE0M.AssertModel(models[11],_testData[22], false);
                        Int64bigintE0M.AssertModel(models[12],_testData[23], false);
                        Int64bigintE0M.AssertModel(models[13],_testData[24], false);
                        Int64bigintE0M.AssertModel(models[14],_testData[25], false);
                        Int64bigintE0M.AssertModel(models[15],_testData[26], false);
                        Int64bigintE0M.AssertModel(models[16],_testData[27], false);
                        Int64bigintE0M.AssertModel(models[17],_testData[28], false);
                        Int64bigintE0M.AssertModel(models[18],_testData[29], false);
                        Int64bigintE0M.AssertModel(models[19],_testData[30], false);
                        Int64bigintE0M.AssertModel(models[20],_testData[31], false);
                        Int64bigintE0M.AssertModel(models[21],_testData[32], false);
                        Int64bigintE0M.AssertModel(models[22],_testData[33], false);
                        Int64bigintE0M.AssertModel(models[23],_testData[34], false);
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
                var models = ((IInt64SingleTypebigint)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IInt64SingleTypebigint)this).DbConnectionSTSelectModelBatch(connection, 6, 6))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        Int64bigintE0M.AssertModel(models[0],_testData[1], false);
                        Int64bigintE0M.AssertModel(models[1],_testData[2], false);
                        Int64bigintE0M.AssertModel(models[2],_testData[3], false);
                        Int64bigintE0M.AssertModel(models[3],_testData[4], false);
                        Int64bigintE0M.AssertModel(models[4],_testData[5], false);
                        Int64bigintE0M.AssertModel(models[5],_testData[6], false);
                        Int64bigintE0M.AssertModel(models[6],_testData[7], false);
                        Int64bigintE0M.AssertModel(models[7],_testData[8], false);
                        Int64bigintE0M.AssertModel(models[8],_testData[9], false);
                        Int64bigintE0M.AssertModel(models[9],_testData[10], false);
                        Int64bigintE0M.AssertModel(models[10],_testData[11], false);
                        Int64bigintE0M.AssertModel(models[11],_testData[12], false);
                        Int64bigintE0M.AssertModel(models[12],_testData[13], false);
                        Int64bigintE0M.AssertModel(models[13],_testData[14], false);
                        Int64bigintE0M.AssertModel(models[14],_testData[15], false);
                        Int64bigintE0M.AssertModel(models[15],_testData[16], false);
                        Int64bigintE0M.AssertModel(models[16],_testData[17], false);
                        Int64bigintE0M.AssertModel(models[17],_testData[18], false);
                        Int64bigintE0M.AssertModel(models[18],_testData[19], false);
                        Int64bigintE0M.AssertModel(models[19],_testData[20], false);
                        Int64bigintE0M.AssertModel(models[20],_testData[21], false);
                        Int64bigintE0M.AssertModel(models[21],_testData[22], false);
                        Int64bigintE0M.AssertModel(models[22],_testData[23], false);
                        Int64bigintE0M.AssertModel(models[23],_testData[24], false);
                        Int64bigintE0M.AssertModel(models[24],_testData[25], false);
                        Int64bigintE0M.AssertModel(models[25],_testData[26], false);
                        Int64bigintE0M.AssertModel(models[26],_testData[27], false);
                        Int64bigintE0M.AssertModel(models[27],_testData[28], false);
                        Int64bigintE0M.AssertModel(models[28],_testData[29], false);
                        Int64bigintE0M.AssertModel(models[29],_testData[30], false);
                        Int64bigintE0M.AssertModel(models[30],_testData[31], false);
                        Int64bigintE0M.AssertModel(models[31],_testData[32], false);
                        Int64bigintE0M.AssertModel(models[32],_testData[33], false);
                        Int64bigintE0M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        Int64bigintE0M.AssertModel(models[0],_testData[1], false);
                        Int64bigintE0M.AssertModel(models[1],_testData[2], false);
                        Int64bigintE0M.AssertModel(models[2],_testData[3], false);
                        Int64bigintE0M.AssertModel(models[3],_testData[4], false);
                        Int64bigintE0M.AssertModel(models[4],_testData[5], false);
                        Int64bigintE0M.AssertModel(models[5],_testData[6], false);
                        Int64bigintE0M.AssertModel(models[6],_testData[7], false);
                        Int64bigintE0M.AssertModel(models[7],_testData[8], false);
                        Int64bigintE0M.AssertModel(models[8],_testData[9], false);
                        Int64bigintE0M.AssertModel(models[9],_testData[10], false);
                        Int64bigintE0M.AssertModel(models[10],_testData[11], false);
                        Int64bigintE0M.AssertModel(models[11],_testData[12], false);
                        Int64bigintE0M.AssertModel(models[12],_testData[13], false);
                        Int64bigintE0M.AssertModel(models[13],_testData[14], false);
                        Int64bigintE0M.AssertModel(models[14],_testData[15], false);
                        Int64bigintE0M.AssertModel(models[15],_testData[16], false);
                        Int64bigintE0M.AssertModel(models[16],_testData[17], false);
                        Int64bigintE0M.AssertModel(models[17],_testData[18], false);
                        Int64bigintE0M.AssertModel(models[18],_testData[19], false);
                        Int64bigintE0M.AssertModel(models[19],_testData[20], false);
                        Int64bigintE0M.AssertModel(models[20],_testData[21], false);
                        Int64bigintE0M.AssertModel(models[21],_testData[22], false);
                        Int64bigintE0M.AssertModel(models[22],_testData[23], false);
                        Int64bigintE0M.AssertModel(models[23],_testData[24], false);
                        Int64bigintE0M.AssertModel(models[24],_testData[25], false);
                        Int64bigintE0M.AssertModel(models[25],_testData[26], false);
                        Int64bigintE0M.AssertModel(models[26],_testData[27], false);
                        Int64bigintE0M.AssertModel(models[27],_testData[28], false);
                        Int64bigintE0M.AssertModel(models[28],_testData[29], false);
                        Int64bigintE0M.AssertModel(models[29],_testData[30], false);
                        Int64bigintE0M.AssertModel(models[30],_testData[31], false);
                        Int64bigintE0M.AssertModel(models[31],_testData[32], false);
                        Int64bigintE0M.AssertModel(models[32],_testData[33], false);
                        Int64bigintE0M.AssertModel(models[33],_testData[34], false);
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
                await using var cmd = await ((IInt64SingleTypebigint)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IInt64SingleTypebigint)this).SetDbConnectionSelectModelParametrs(cmd, 135);
                var models = await ((IInt64SingleTypebigint)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(9));

                Int64bigintE0M.AssertModel(models[0],_testData[26], false);
                Int64bigintE0M.AssertModel(models[1],_testData[27], false);
                Int64bigintE0M.AssertModel(models[2],_testData[28], false);
                Int64bigintE0M.AssertModel(models[3],_testData[29], false);
                Int64bigintE0M.AssertModel(models[4],_testData[30], false);
                Int64bigintE0M.AssertModel(models[5],_testData[31], false);
                Int64bigintE0M.AssertModel(models[6],_testData[32], false);
                Int64bigintE0M.AssertModel(models[7],_testData[33], false);
                Int64bigintE0M.AssertModel(models[8],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt64SingleTypebigint)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt64SingleTypebigint)this).SetDbConnectionSelectModelParametrs(cmd, 112);
                var models =  ((IInt64SingleTypebigint)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(13));

                Int64bigintE0M.AssertModel(models[0],_testData[22], false);
                Int64bigintE0M.AssertModel(models[1],_testData[23], false);
                Int64bigintE0M.AssertModel(models[2],_testData[24], false);
                Int64bigintE0M.AssertModel(models[3],_testData[25], false);
                Int64bigintE0M.AssertModel(models[4],_testData[26], false);
                Int64bigintE0M.AssertModel(models[5],_testData[27], false);
                Int64bigintE0M.AssertModel(models[6],_testData[28], false);
                Int64bigintE0M.AssertModel(models[7],_testData[29], false);
                Int64bigintE0M.AssertModel(models[8],_testData[30], false);
                Int64bigintE0M.AssertModel(models[9],_testData[31], false);
                Int64bigintE0M.AssertModel(models[10],_testData[32], false);
                Int64bigintE0M.AssertModel(models[11],_testData[33], false);
                Int64bigintE0M.AssertModel(models[12],_testData[34], false);
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
FROM dbo.int64biginte0m m
LEFT JOIN dbo.int64bigint0mi mi ON mi.id = m.int64bigint0mi_id
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
            asPartInterface: typeof(IInt64SingleTypebigint))]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IInt64SingleTypebigint)this).DbConnectionSelectModelToObjArrAsync(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((30338870458203208L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4388602603431776169L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((8978815824754770328L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((11)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2251980475124171594L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((333361581407437596L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((7512053888756313369L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((2694139537634285596L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((6848915794432874147L)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8937685055913761564L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7253329084759940679L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((8389439359648048725L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((167083696851158012L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6761601564869142314L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((8342017475733971881L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((4840564196060032139L)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((123476629920921951L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3864105645068728905L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((1083624934223758353L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((177222626280607533L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4966121989367568198L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3728801696566185167L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((8968273216297379323L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((342386865916234536L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((597206782183444795L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8252469202804777650L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((1480978358327358876L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3210090778448467509L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((4663808699855873694L)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((83)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5921260228570015342L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((3131350739827165436L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((1625332773167811805L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((4037568007986925077L)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3685627215191332724L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((68081455076488163L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((38)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((3771336928392219315L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((4209706489939556746L)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7690485931433422598L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3072475807265548307L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((2836326997889712819L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((6611551080621589510L)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((231676573024461380L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((5519896626344484533L)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1018413611844699341L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((1970496317643522353L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((4448520683491495835L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((8356035381513245005L)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1593512372035613521L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((222584959939992203L)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1321850455803132111L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((7408705437132355958L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((4983377418569574666L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((1676245000076272972L)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1705432201838571730L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((8392073654209579311L)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6574968732809543974L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((3314584281683989970L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8293893247953697077L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((1706914984662316796L)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((145)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6670096046764311743L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((6565080384145402851L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((6567272566607620849L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((152)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7384524704297118741L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((156)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7308819837791587467L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((5284646734268855483L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((157)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((689394174108087144L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((2450184031047429852L)));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((159)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8621225403229817569L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((1383454006888657771L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((2680363333456468200L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((164)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7442891904083123016L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((168)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2152327352604882553L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((5008354502894765864L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((8242176440798583598L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((175)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2795395377371824644L)));//Value

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
                var models =  ((IInt64SingleTypebigint)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((30338870458203208L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4388602603431776169L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((8978815824754770328L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((11)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2251980475124171594L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((333361581407437596L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((7512053888756313369L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((2694139537634285596L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((6848915794432874147L)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8937685055913761564L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7253329084759940679L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((8389439359648048725L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((167083696851158012L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6761601564869142314L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((8342017475733971881L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((4840564196060032139L)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((123476629920921951L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3864105645068728905L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((1083624934223758353L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((177222626280607533L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4966121989367568198L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3728801696566185167L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((8968273216297379323L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((342386865916234536L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((597206782183444795L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8252469202804777650L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((1480978358327358876L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3210090778448467509L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((4663808699855873694L)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((83)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5921260228570015342L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((3131350739827165436L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((1625332773167811805L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((4037568007986925077L)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3685627215191332724L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((68081455076488163L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((38)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((3771336928392219315L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((4209706489939556746L)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7690485931433422598L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3072475807265548307L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((2836326997889712819L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((6611551080621589510L)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((231676573024461380L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((5519896626344484533L)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1018413611844699341L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((1970496317643522353L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((4448520683491495835L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((8356035381513245005L)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1593512372035613521L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((222584959939992203L)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1321850455803132111L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((7408705437132355958L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((4983377418569574666L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((1676245000076272972L)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1705432201838571730L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((8392073654209579311L)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6574968732809543974L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((3314584281683989970L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8293893247953697077L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((1706914984662316796L)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((145)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6670096046764311743L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((6565080384145402851L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((6567272566607620849L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((152)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7384524704297118741L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((156)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7308819837791587467L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((5284646734268855483L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((157)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((689394174108087144L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((2450184031047429852L)));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((159)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8621225403229817569L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((1383454006888657771L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((2680363333456468200L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((164)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7442891904083123016L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((168)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2152327352604882553L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((5008354502894765864L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((8242176440798583598L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((175)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2795395377371824644L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

#endregion

    }
}

