

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

        private readonly Int64bigint0M[] _testData = new Int64bigint0M[]
        {
            new Int64bigint0M
{
    Id = 7,
    Value = 3838412274132285745L,
    ModelInner = null,
    NullableValue = 5297134615289211942L,
},
            new Int64bigint0M
{
    Id = 15,
    Value = 2918900223527574078L,
    ModelInner = new Int64bigint0MI
{
    Id = 1,
    Value = 6609034285336093953L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 24,
    Value = 7807471722057129012L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 26,
    Value = 7788855906325230907L,
    ModelInner = new Int64bigint0MI
{
    Id = 8,
    Value = 6594115789149939097L,
    NullableValue = 5387420177263288188L,
},
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 35,
    Value = 3534065212224074738L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 37,
    Value = 4331120120976794316L,
    ModelInner = new Int64bigint0MI
{
    Id = 11,
    Value = 6343657376165115248L,
    NullableValue = 241056491580482093L,
},
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 39,
    Value = 4776694288184882723L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 46,
    Value = 7864175629910890870L,
    ModelInner = new Int64bigint0MI
{
    Id = 18,
    Value = 5240690637735734325L,
    NullableValue = null,
},
    NullableValue = 6981266936822815591L,
},
            new Int64bigint0M
{
    Id = 47,
    Value = 4491294086100654764L,
    ModelInner = null,
    NullableValue = 5923052693857338199L,
},
            new Int64bigint0M
{
    Id = 49,
    Value = 505260512901168282L,
    ModelInner = new Int64bigint0MI
{
    Id = 26,
    Value = 1928825139592984222L,
    NullableValue = null,
},
    NullableValue = 5238820166907723281L,
},
            new Int64bigint0M
{
    Id = 53,
    Value = 1768874622155810338L,
    ModelInner = null,
    NullableValue = 4257556167700646436L,
},
            new Int64bigint0M
{
    Id = 61,
    Value = 3926604168325559284L,
    ModelInner = new Int64bigint0MI
{
    Id = 30,
    Value = 4583181308615700965L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 68,
    Value = 2153798816997643759L,
    ModelInner = null,
    NullableValue = 8371735043000705951L,
},
            new Int64bigint0M
{
    Id = 70,
    Value = 5729435078170332984L,
    ModelInner = new Int64bigint0MI
{
    Id = 39,
    Value = 942630054324212443L,
    NullableValue = null,
},
    NullableValue = 6187035263472083158L,
},
            new Int64bigint0M
{
    Id = 75,
    Value = 85755049368853118L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 82,
    Value = 8784804595442938169L,
    ModelInner = new Int64bigint0MI
{
    Id = 41,
    Value = 9150457663654676034L,
    NullableValue = 5077881888726256583L,
},
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 86,
    Value = 9123991633083051264L,
    ModelInner = null,
    NullableValue = 8398561721105501107L,
},
            new Int64bigint0M
{
    Id = 95,
    Value = 5730390876624584834L,
    ModelInner = new Int64bigint0MI
{
    Id = 46,
    Value = 7783405954086733031L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 101,
    Value = 1592755970787946400L,
    ModelInner = null,
    NullableValue = 8664816167223682101L,
},
            new Int64bigint0M
{
    Id = 103,
    Value = 4757417935233207175L,
    ModelInner = new Int64bigint0MI
{
    Id = 51,
    Value = 2891247309554724470L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 108,
    Value = 4199269098166053346L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 110,
    Value = 3026934379560962816L,
    ModelInner = new Int64bigint0MI
{
    Id = 56,
    Value = 3001186887892755390L,
    NullableValue = null,
},
    NullableValue = 4172628654084866498L,
},
            new Int64bigint0M
{
    Id = 118,
    Value = 6301694980331590570L,
    ModelInner = null,
    NullableValue = 4745313967090943451L,
},
            new Int64bigint0M
{
    Id = 127,
    Value = 6168964963996772492L,
    ModelInner = new Int64bigint0MI
{
    Id = 57,
    Value = 3273434974092780023L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 136,
    Value = 8898410279459012368L,
    ModelInner = null,
    NullableValue = 8787687993485832547L,
},
            new Int64bigint0M
{
    Id = 142,
    Value = 1375611982916830629L,
    ModelInner = new Int64bigint0MI
{
    Id = 58,
    Value = 4601948330752803924L,
    NullableValue = 8089244940540565456L,
},
    NullableValue = 3742852673085618685L,
},
            new Int64bigint0M
{
    Id = 151,
    Value = 2548902896347113326L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 157,
    Value = 591290215707610934L,
    ModelInner = new Int64bigint0MI
{
    Id = 60,
    Value = 5747925636231701316L,
    NullableValue = 8460626187872992630L,
},
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 165,
    Value = 3416857782038153234L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 167,
    Value = 5947227794239551268L,
    ModelInner = new Int64bigint0MI
{
    Id = 64,
    Value = 7767940697965026481L,
    NullableValue = 2507877708380970412L,
},
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 172,
    Value = 7095506000553783512L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 174,
    Value = 2297931848595701893L,
    ModelInner = new Int64bigint0MI
{
    Id = 73,
    Value = 123392568672467832L,
    NullableValue = 4915829798965303079L,
},
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 181,
    Value = 1214436185761457755L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 189,
    Value = 2942775196680891139L,
    ModelInner = new Int64bigint0MI
{
    Id = 80,
    Value = 4142283508233231729L,
    NullableValue = 553313681557419035L,
},
    NullableValue = 6739863497021751680L,
},
            new Int64bigint0M
{
    Id = 190,
    Value = 1267538985692099466L,
    ModelInner = null,
    NullableValue = 3678341312879036916L,
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
INSERT INTO dbo.int64bigint0m(
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
INSERT INTO dbo.int64bigint0m(
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
            queryMapTypes: [typeof(FlatInt64bigint0M), typeof(FlatInt64bigint0M)],
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
FROM dbo.int64bigint0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt64bigint0M>();
                var models2 = new List<FlatInt64bigint0M>();
                await((IInt64SingleTypebigint)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigint0M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.int64bigint0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt64bigint0M>();
                var models2 = new List<FlatInt64bigint0M>();
                ((IInt64SingleTypebigint)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigint0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigint0M)],
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
FROM dbo.int64bigint0m m
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
                    FlatInt64bigint0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.int64bigint0m m
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
                    FlatInt64bigint0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.int64bigint0m m
LEFT JOIN dbo.int64bigint0mi mi ON mi.id = m.int64bigint0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Int64bigint0M)],
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
                    Int64bigint0M.AssertModel(models[i],_testData[i], false);
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
                    Int64bigint0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigint0M), typeof(FlatInt64bigint0M)],
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
FROM dbo.int64bigint0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigint0M>();
                var models2 = new List<FlatInt64bigint0M>();
                await((IInt64SingleTypebigint)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigint0M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.int64bigint0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigint0M>();
                var models2 = new List<FlatInt64bigint0M>();
                ((IInt64SingleTypebigint)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigint0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigint0M)],
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
FROM dbo.int64bigint0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IInt64SingleTypebigint)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigint0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.int64bigint0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IInt64SingleTypebigint)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigint0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.int64bigint0m m
LEFT JOIN dbo.int64bigint0mi mi ON mi.id = m.int64bigint0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Int64bigint0M)],
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
                    Int64bigint0M.AssertModel(models[i],_testData[i], false);
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
                    Int64bigint0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigint0M), typeof(FlatInt64bigint0M)],
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
FROM dbo.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt64bigint0M>();
                var models2 = new List<FlatInt64bigint0M>();
                await((IInt64SingleTypebigint)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigint0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 70;
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
FROM dbo.int64bigint0m m
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
FROM dbo.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigint0M>();
                var firstItems2 = new List<FlatInt64bigint0M>();
                var secondItems1 = new List<FlatInt64bigint0M>();
                var secondItems2 = new List<FlatInt64bigint0M>();
                await ((IInt64SingleTypebigint)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatInt64bigint0M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[33],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 136;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 95;
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
FROM dbo.int64bigint0m m
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
FROM dbo.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigint0M>();
                var firstItems2 = new List<FlatInt64bigint0M>();
                var secondItems1 = new List<FlatInt64bigint0M>();
                await ((IInt64SingleTypebigint)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatInt64bigint0M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[16],_testData[34], false);
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
FROM dbo.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt64bigint0M>();
                var models2 = new List<FlatInt64bigint0M>();
                ((IInt64SingleTypebigint)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigint0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 86;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 108;
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
FROM dbo.int64bigint0m m
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
FROM dbo.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigint0M>();
                var firstItems2 = new List<FlatInt64bigint0M>();
                var secondItems1 = new List<FlatInt64bigint0M>();
                var secondItems2 = new List<FlatInt64bigint0M>();
                 ((IInt64SingleTypebigint)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatInt64bigint0M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[13],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 151;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 39;
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
FROM dbo.int64bigint0m m
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
FROM dbo.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigint0M>();
                var firstItems2 = new List<FlatInt64bigint0M>();
                var secondItems1 = new List<FlatInt64bigint0M>();
                 ((IInt64SingleTypebigint)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatInt64bigint0M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[27],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigint0M)],
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
FROM dbo.int64bigint0m m
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
                    FlatInt64bigint0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 46;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 26;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.int64bigint0m m
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
FROM dbo.int64bigint0m m
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
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatInt64bigint0M.AssertModel(models[0],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(models[1],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(models[2],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(models[3],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(models[4],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(models[5],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(models[6],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(models[7],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(models[8],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(models[9],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(models[10],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(models[11],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(models[12],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(models[13],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(models[14],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(models[15],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(models[16],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(models[17],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(models[18],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(models[19],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(models[20],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(models[21],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(models[22],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(models[23],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(models[24],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(models[25],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatInt64bigint0M.AssertModel(models[0],_testData[4], false);
                        FlatInt64bigint0M.AssertModel(models[1],_testData[5], false);
                        FlatInt64bigint0M.AssertModel(models[2],_testData[6], false);
                        FlatInt64bigint0M.AssertModel(models[3],_testData[7], false);
                        FlatInt64bigint0M.AssertModel(models[4],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(models[5],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(models[6],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(models[7],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(models[8],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(models[9],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(models[10],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(models[11],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(models[12],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(models[13],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(models[14],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(models[15],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(models[16],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(models[17],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(models[18],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(models[19],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(models[20],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(models[21],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(models[22],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(models[23],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(models[24],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(models[25],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(models[26],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(models[27],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(models[28],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(models[29],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(models[30],_testData[34], false);
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
                parametr1.Value = 82;
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
FROM dbo.int64bigint0m m
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
FROM dbo.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigint0M>();
                var secondItems1 = new List<FlatInt64bigint0M>();
                var secondItems2 = new List<FlatInt64bigint0M>();
                await ((IInt64SingleTypebigint)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatInt64bigint0M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[17],_testData[34], false);
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
FROM dbo.int64bigint0m m
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
                    FlatInt64bigint0M.AssertModel(models[i],_testData[i], false);
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
                parametr2.Value = 68;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.int64bigint0m m
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
FROM dbo.int64bigint0m m
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
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatInt64bigint0M.AssertModel(models[0],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(models[1],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(models[2],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(models[3],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(models[4],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(models[5],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(models[6],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(models[7],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(models[8],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(models[9],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(models[10],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(models[11],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(models[12],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(models[13],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(models[14],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(models[15],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(models[16],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(models[17],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatInt64bigint0M.AssertModel(models[0],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(models[1],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(models[2],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(models[3],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(models[4],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(models[5],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(models[6],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(models[7],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(models[8],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(models[9],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(models[10],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(models[11],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(models[12],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(models[13],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(models[14],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(models[15],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(models[16],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(models[17],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(models[18],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(models[19],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(models[20],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(models[21],_testData[34], false);
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
                parametr1.Value = 103;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 82;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.int64bigint0m m
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
FROM dbo.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigint0M>();
                var secondItems1 = new List<FlatInt64bigint0M>();
                var secondItems2 = new List<FlatInt64bigint0M>();
                 ((IInt64SingleTypebigint)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatInt64bigint0M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[18],_testData[34], false);
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
FROM dbo.int64bigint0m m
LEFT JOIN dbo.int64bigint0mi mi ON mi.id = m.int64bigint0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Int64bigint0M)],
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
                    Int64bigint0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 108;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 46;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64SingleTypebigint)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        Int64bigint0M.AssertModel(models[0],_testData[21], false);
                        Int64bigint0M.AssertModel(models[1],_testData[22], false);
                        Int64bigint0M.AssertModel(models[2],_testData[23], false);
                        Int64bigint0M.AssertModel(models[3],_testData[24], false);
                        Int64bigint0M.AssertModel(models[4],_testData[25], false);
                        Int64bigint0M.AssertModel(models[5],_testData[26], false);
                        Int64bigint0M.AssertModel(models[6],_testData[27], false);
                        Int64bigint0M.AssertModel(models[7],_testData[28], false);
                        Int64bigint0M.AssertModel(models[8],_testData[29], false);
                        Int64bigint0M.AssertModel(models[9],_testData[30], false);
                        Int64bigint0M.AssertModel(models[10],_testData[31], false);
                        Int64bigint0M.AssertModel(models[11],_testData[32], false);
                        Int64bigint0M.AssertModel(models[12],_testData[33], false);
                        Int64bigint0M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        Int64bigint0M.AssertModel(models[0],_testData[8], false);
                        Int64bigint0M.AssertModel(models[1],_testData[9], false);
                        Int64bigint0M.AssertModel(models[2],_testData[10], false);
                        Int64bigint0M.AssertModel(models[3],_testData[11], false);
                        Int64bigint0M.AssertModel(models[4],_testData[12], false);
                        Int64bigint0M.AssertModel(models[5],_testData[13], false);
                        Int64bigint0M.AssertModel(models[6],_testData[14], false);
                        Int64bigint0M.AssertModel(models[7],_testData[15], false);
                        Int64bigint0M.AssertModel(models[8],_testData[16], false);
                        Int64bigint0M.AssertModel(models[9],_testData[17], false);
                        Int64bigint0M.AssertModel(models[10],_testData[18], false);
                        Int64bigint0M.AssertModel(models[11],_testData[19], false);
                        Int64bigint0M.AssertModel(models[12],_testData[20], false);
                        Int64bigint0M.AssertModel(models[13],_testData[21], false);
                        Int64bigint0M.AssertModel(models[14],_testData[22], false);
                        Int64bigint0M.AssertModel(models[15],_testData[23], false);
                        Int64bigint0M.AssertModel(models[16],_testData[24], false);
                        Int64bigint0M.AssertModel(models[17],_testData[25], false);
                        Int64bigint0M.AssertModel(models[18],_testData[26], false);
                        Int64bigint0M.AssertModel(models[19],_testData[27], false);
                        Int64bigint0M.AssertModel(models[20],_testData[28], false);
                        Int64bigint0M.AssertModel(models[21],_testData[29], false);
                        Int64bigint0M.AssertModel(models[22],_testData[30], false);
                        Int64bigint0M.AssertModel(models[23],_testData[31], false);
                        Int64bigint0M.AssertModel(models[24],_testData[32], false);
                        Int64bigint0M.AssertModel(models[25],_testData[33], false);
                        Int64bigint0M.AssertModel(models[26],_testData[34], false);
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
                    Int64bigint0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 181;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 7;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64SingleTypebigint)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        Int64bigint0M.AssertModel(models[0],_testData[33], false);
                        Int64bigint0M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        Int64bigint0M.AssertModel(models[0],_testData[1], false);
                        Int64bigint0M.AssertModel(models[1],_testData[2], false);
                        Int64bigint0M.AssertModel(models[2],_testData[3], false);
                        Int64bigint0M.AssertModel(models[3],_testData[4], false);
                        Int64bigint0M.AssertModel(models[4],_testData[5], false);
                        Int64bigint0M.AssertModel(models[5],_testData[6], false);
                        Int64bigint0M.AssertModel(models[6],_testData[7], false);
                        Int64bigint0M.AssertModel(models[7],_testData[8], false);
                        Int64bigint0M.AssertModel(models[8],_testData[9], false);
                        Int64bigint0M.AssertModel(models[9],_testData[10], false);
                        Int64bigint0M.AssertModel(models[10],_testData[11], false);
                        Int64bigint0M.AssertModel(models[11],_testData[12], false);
                        Int64bigint0M.AssertModel(models[12],_testData[13], false);
                        Int64bigint0M.AssertModel(models[13],_testData[14], false);
                        Int64bigint0M.AssertModel(models[14],_testData[15], false);
                        Int64bigint0M.AssertModel(models[15],_testData[16], false);
                        Int64bigint0M.AssertModel(models[16],_testData[17], false);
                        Int64bigint0M.AssertModel(models[17],_testData[18], false);
                        Int64bigint0M.AssertModel(models[18],_testData[19], false);
                        Int64bigint0M.AssertModel(models[19],_testData[20], false);
                        Int64bigint0M.AssertModel(models[20],_testData[21], false);
                        Int64bigint0M.AssertModel(models[21],_testData[22], false);
                        Int64bigint0M.AssertModel(models[22],_testData[23], false);
                        Int64bigint0M.AssertModel(models[23],_testData[24], false);
                        Int64bigint0M.AssertModel(models[24],_testData[25], false);
                        Int64bigint0M.AssertModel(models[25],_testData[26], false);
                        Int64bigint0M.AssertModel(models[26],_testData[27], false);
                        Int64bigint0M.AssertModel(models[27],_testData[28], false);
                        Int64bigint0M.AssertModel(models[28],_testData[29], false);
                        Int64bigint0M.AssertModel(models[29],_testData[30], false);
                        Int64bigint0M.AssertModel(models[30],_testData[31], false);
                        Int64bigint0M.AssertModel(models[31],_testData[32], false);
                        Int64bigint0M.AssertModel(models[32],_testData[33], false);
                        Int64bigint0M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigint0M), typeof(FlatInt64bigint0M)],
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
FROM dbo.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigint0M>();
                var models2 = new List<FlatInt64bigint0M>();
                await((IInt64SingleTypebigint)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigint0M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.int64bigint0m m
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
FROM dbo.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigint0M>();
                var firstItems2 = new List<FlatInt64bigint0M>();
                var secondItems1 = new List<FlatInt64bigint0M>();
                var secondItems2 = new List<FlatInt64bigint0M>();
                await ((IInt64SingleTypebigint)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 172, query1, 49, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatInt64bigint0M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[24],_testData[34], false);
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
FROM dbo.int64bigint0m m
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
FROM dbo.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigint0M>();
                var firstItems2 = new List<FlatInt64bigint0M>();
                var secondItems1 = new List<FlatInt64bigint0M>();
                await ((IInt64SingleTypebigint)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 47, query1, 142, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatInt64bigint0M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[8],_testData[34], false);
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
FROM dbo.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigint0M>();
                var models2 = new List<FlatInt64bigint0M>();
                ((IInt64SingleTypebigint)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigint0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigint0M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.int64bigint0m m
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
FROM dbo.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigint0M>();
                var firstItems2 = new List<FlatInt64bigint0M>();
                var secondItems1 = new List<FlatInt64bigint0M>();
                var secondItems2 = new List<FlatInt64bigint0M>();
                 ((IInt64SingleTypebigint)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 47, query1, 68, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatInt64bigint0M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[21],_testData[34], false);
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
FROM dbo.int64bigint0m m
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
FROM dbo.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigint0M>();
                var firstItems2 = new List<FlatInt64bigint0M>();
                var secondItems1 = new List<FlatInt64bigint0M>();
                 ((IInt64SingleTypebigint)this).DbConnectionMMDynQuerySelectModelBatch(connection, 167, query1, 53, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatInt64bigint0M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[23],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigint0M)],
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
FROM dbo.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IInt64SingleTypebigint)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigint0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.int64bigint0m m
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
FROM dbo.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64SingleTypebigint)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 174, query1, 7, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatInt64bigint0M.AssertModel(models[0],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(models[1],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatInt64bigint0M.AssertModel(models[0],_testData[1], false);
                        FlatInt64bigint0M.AssertModel(models[1],_testData[2], false);
                        FlatInt64bigint0M.AssertModel(models[2],_testData[3], false);
                        FlatInt64bigint0M.AssertModel(models[3],_testData[4], false);
                        FlatInt64bigint0M.AssertModel(models[4],_testData[5], false);
                        FlatInt64bigint0M.AssertModel(models[5],_testData[6], false);
                        FlatInt64bigint0M.AssertModel(models[6],_testData[7], false);
                        FlatInt64bigint0M.AssertModel(models[7],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(models[8],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(models[9],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(models[10],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(models[11],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(models[12],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(models[13],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(models[14],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(models[15],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(models[16],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(models[17],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(models[18],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(models[19],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(models[20],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(models[21],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(models[22],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(models[23],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(models[24],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(models[25],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(models[26],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(models[27],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(models[28],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(models[29],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(models[30],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(models[31],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(models[32],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(models[33],_testData[34], false);
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
FROM dbo.int64bigint0m m
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
FROM dbo.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigint0M>();
                var secondItems1 = new List<FlatInt64bigint0M>();
                var secondItems2 = new List<FlatInt64bigint0M>();
                await ((IInt64SingleTypebigint)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 53, query1, 15, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatInt64bigint0M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[32],_testData[34], false);
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
FROM dbo.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IInt64SingleTypebigint)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigint0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.int64bigint0m m
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
FROM dbo.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64SingleTypebigint)this).DbConnectionSTDynQuerySelectModelBatch(connection, 37, query1, 110, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatInt64bigint0M.AssertModel(models[0],_testData[6], false);
                        FlatInt64bigint0M.AssertModel(models[1],_testData[7], false);
                        FlatInt64bigint0M.AssertModel(models[2],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(models[3],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(models[4],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(models[5],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(models[6],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(models[7],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(models[8],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(models[9],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(models[10],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(models[11],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(models[12],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(models[13],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(models[14],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(models[15],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(models[16],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(models[17],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(models[18],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(models[19],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(models[20],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(models[21],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(models[22],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(models[23],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(models[24],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(models[25],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(models[26],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(models[27],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatInt64bigint0M.AssertModel(models[0],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(models[1],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(models[2],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(models[3],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(models[4],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(models[5],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(models[6],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(models[7],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(models[8],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(models[9],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(models[10],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(models[11],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(models[12],_testData[34], false);
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
FROM dbo.int64bigint0m m
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
FROM dbo.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigint0M>();
                var secondItems1 = new List<FlatInt64bigint0M>();
                var secondItems2 = new List<FlatInt64bigint0M>();
                 ((IInt64SingleTypebigint)this).DbConnectionDynQuerySelectModelBatch(connection, 95, query1, 95, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                        FlatInt64bigint0M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[16],_testData[34], false);
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
FROM dbo.int64bigint0m m
LEFT JOIN dbo.int64bigint0mi mi ON mi.id = m.int64bigint0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Int64bigint0M)],
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
                    Int64bigint0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IInt64SingleTypebigint)this).DbConnectionSTSelectModelBatchAsync(connection, 157, 167))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        Int64bigint0M.AssertModel(models[0],_testData[28], false);
                        Int64bigint0M.AssertModel(models[1],_testData[29], false);
                        Int64bigint0M.AssertModel(models[2],_testData[30], false);
                        Int64bigint0M.AssertModel(models[3],_testData[31], false);
                        Int64bigint0M.AssertModel(models[4],_testData[32], false);
                        Int64bigint0M.AssertModel(models[5],_testData[33], false);
                        Int64bigint0M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        Int64bigint0M.AssertModel(models[0],_testData[30], false);
                        Int64bigint0M.AssertModel(models[1],_testData[31], false);
                        Int64bigint0M.AssertModel(models[2],_testData[32], false);
                        Int64bigint0M.AssertModel(models[3],_testData[33], false);
                        Int64bigint0M.AssertModel(models[4],_testData[34], false);
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
                    Int64bigint0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IInt64SingleTypebigint)this).DbConnectionSTSelectModelBatch(connection, 103, 37))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        Int64bigint0M.AssertModel(models[0],_testData[20], false);
                        Int64bigint0M.AssertModel(models[1],_testData[21], false);
                        Int64bigint0M.AssertModel(models[2],_testData[22], false);
                        Int64bigint0M.AssertModel(models[3],_testData[23], false);
                        Int64bigint0M.AssertModel(models[4],_testData[24], false);
                        Int64bigint0M.AssertModel(models[5],_testData[25], false);
                        Int64bigint0M.AssertModel(models[6],_testData[26], false);
                        Int64bigint0M.AssertModel(models[7],_testData[27], false);
                        Int64bigint0M.AssertModel(models[8],_testData[28], false);
                        Int64bigint0M.AssertModel(models[9],_testData[29], false);
                        Int64bigint0M.AssertModel(models[10],_testData[30], false);
                        Int64bigint0M.AssertModel(models[11],_testData[31], false);
                        Int64bigint0M.AssertModel(models[12],_testData[32], false);
                        Int64bigint0M.AssertModel(models[13],_testData[33], false);
                        Int64bigint0M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        Int64bigint0M.AssertModel(models[0],_testData[6], false);
                        Int64bigint0M.AssertModel(models[1],_testData[7], false);
                        Int64bigint0M.AssertModel(models[2],_testData[8], false);
                        Int64bigint0M.AssertModel(models[3],_testData[9], false);
                        Int64bigint0M.AssertModel(models[4],_testData[10], false);
                        Int64bigint0M.AssertModel(models[5],_testData[11], false);
                        Int64bigint0M.AssertModel(models[6],_testData[12], false);
                        Int64bigint0M.AssertModel(models[7],_testData[13], false);
                        Int64bigint0M.AssertModel(models[8],_testData[14], false);
                        Int64bigint0M.AssertModel(models[9],_testData[15], false);
                        Int64bigint0M.AssertModel(models[10],_testData[16], false);
                        Int64bigint0M.AssertModel(models[11],_testData[17], false);
                        Int64bigint0M.AssertModel(models[12],_testData[18], false);
                        Int64bigint0M.AssertModel(models[13],_testData[19], false);
                        Int64bigint0M.AssertModel(models[14],_testData[20], false);
                        Int64bigint0M.AssertModel(models[15],_testData[21], false);
                        Int64bigint0M.AssertModel(models[16],_testData[22], false);
                        Int64bigint0M.AssertModel(models[17],_testData[23], false);
                        Int64bigint0M.AssertModel(models[18],_testData[24], false);
                        Int64bigint0M.AssertModel(models[19],_testData[25], false);
                        Int64bigint0M.AssertModel(models[20],_testData[26], false);
                        Int64bigint0M.AssertModel(models[21],_testData[27], false);
                        Int64bigint0M.AssertModel(models[22],_testData[28], false);
                        Int64bigint0M.AssertModel(models[23],_testData[29], false);
                        Int64bigint0M.AssertModel(models[24],_testData[30], false);
                        Int64bigint0M.AssertModel(models[25],_testData[31], false);
                        Int64bigint0M.AssertModel(models[26],_testData[32], false);
                        Int64bigint0M.AssertModel(models[27],_testData[33], false);
                        Int64bigint0M.AssertModel(models[28],_testData[34], false);
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
                ((IInt64SingleTypebigint)this).SetDbConnectionSelectModelParametrs(cmd, 157);
                var models = await ((IInt64SingleTypebigint)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(7));
Int64bigint0M.AssertModel(models[0],_testData[28], false);Int64bigint0M.AssertModel(models[1],_testData[29], false);Int64bigint0M.AssertModel(models[2],_testData[30], false);Int64bigint0M.AssertModel(models[3],_testData[31], false);Int64bigint0M.AssertModel(models[4],_testData[32], false);Int64bigint0M.AssertModel(models[5],_testData[33], false);Int64bigint0M.AssertModel(models[6],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt64SingleTypebigint)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt64SingleTypebigint)this).SetDbConnectionSelectModelParametrs(cmd, 151);
                var models =  ((IInt64SingleTypebigint)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(8));
Int64bigint0M.AssertModel(models[0],_testData[27], false);Int64bigint0M.AssertModel(models[1],_testData[28], false);Int64bigint0M.AssertModel(models[2],_testData[29], false);Int64bigint0M.AssertModel(models[3],_testData[30], false);Int64bigint0M.AssertModel(models[4],_testData[31], false);Int64bigint0M.AssertModel(models[5],_testData[32], false);Int64bigint0M.AssertModel(models[6],_testData[33], false);Int64bigint0M.AssertModel(models[7],_testData[34], false);
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
FROM dbo.int64bigint0m m
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
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3838412274132285745L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((5297134615289211942L)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2918900223527574078L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((6609034285336093953L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7807471722057129012L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7788855906325230907L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((6594115789149939097L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((5387420177263288188L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3534065212224074738L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4331120120976794316L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((11)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((6343657376165115248L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((241056491580482093L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4776694288184882723L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7864175629910890870L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((5240690637735734325L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((6981266936822815591L)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4491294086100654764L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((5923052693857338199L)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((49)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((505260512901168282L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((1928825139592984222L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((5238820166907723281L)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((53)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1768874622155810338L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((4257556167700646436L)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3926604168325559284L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((4583181308615700965L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2153798816997643759L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((8371735043000705951L)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5729435078170332984L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((942630054324212443L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((6187035263472083158L)));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((75)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((85755049368853118L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8784804595442938169L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((9150457663654676034L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((5077881888726256583L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((9123991633083051264L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((8398561721105501107L)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5730390876624584834L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((7783405954086733031L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1592755970787946400L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((8664816167223682101L)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4757417935233207175L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((2891247309554724470L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4199269098166053346L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3026934379560962816L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((56)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((3001186887892755390L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((4172628654084866498L)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6301694980331590570L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((4745313967090943451L)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6168964963996772492L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((3273434974092780023L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8898410279459012368L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((8787687993485832547L)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((142)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1375611982916830629L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((4601948330752803924L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((8089244940540565456L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((3742852673085618685L)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2548902896347113326L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((157)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((591290215707610934L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((5747925636231701316L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((8460626187872992630L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((165)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3416857782038153234L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((167)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5947227794239551268L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((7767940697965026481L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((2507877708380970412L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((172)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7095506000553783512L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((174)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2297931848595701893L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((73)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((123392568672467832L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((4915829798965303079L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((181)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1214436185761457755L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((189)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2942775196680891139L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((80)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((4142283508233231729L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((553313681557419035L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((6739863497021751680L)));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((190)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1267538985692099466L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((3678341312879036916L)));

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
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3838412274132285745L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((5297134615289211942L)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2918900223527574078L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((6609034285336093953L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7807471722057129012L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7788855906325230907L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((6594115789149939097L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((5387420177263288188L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3534065212224074738L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4331120120976794316L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((11)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((6343657376165115248L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((241056491580482093L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4776694288184882723L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7864175629910890870L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((5240690637735734325L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((6981266936822815591L)));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4491294086100654764L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((5923052693857338199L)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((49)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((505260512901168282L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((1928825139592984222L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((5238820166907723281L)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((53)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1768874622155810338L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((4257556167700646436L)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3926604168325559284L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((4583181308615700965L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2153798816997643759L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((8371735043000705951L)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5729435078170332984L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((942630054324212443L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((6187035263472083158L)));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((75)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((85755049368853118L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8784804595442938169L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((9150457663654676034L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((5077881888726256583L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((9123991633083051264L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((8398561721105501107L)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5730390876624584834L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((7783405954086733031L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1592755970787946400L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((8664816167223682101L)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4757417935233207175L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((2891247309554724470L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4199269098166053346L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3026934379560962816L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((56)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((3001186887892755390L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((4172628654084866498L)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6301694980331590570L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((4745313967090943451L)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6168964963996772492L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((3273434974092780023L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8898410279459012368L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((8787687993485832547L)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((142)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1375611982916830629L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((4601948330752803924L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((8089244940540565456L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((3742852673085618685L)));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2548902896347113326L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((157)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((591290215707610934L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((5747925636231701316L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((8460626187872992630L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((165)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3416857782038153234L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((167)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5947227794239551268L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((7767940697965026481L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((2507877708380970412L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((172)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7095506000553783512L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((174)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2297931848595701893L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((73)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((123392568672467832L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((4915829798965303079L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((181)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1214436185761457755L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((189)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2942775196680891139L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((80)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((4142283508233231729L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((553313681557419035L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((6739863497021751680L)));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((190)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1267538985692099466L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((3678341312879036916L)));

            }
        }

#endregion

    }
}

