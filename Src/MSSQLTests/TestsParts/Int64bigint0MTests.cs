

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
    Id = 3,
    Value = 4800391452489070502L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 5,
    Value = 8637463657221674363L,
    ModelInner = new Int64bigint0MI
{
    Id = 3,
    Value = 567865080071417419L,
    NullableValue = 7575478873044498806L,
},
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 12,
    Value = 4661646069846683709L,
    ModelInner = null,
    NullableValue = 2778629732895035401L,
},
            new Int64bigint0M
{
    Id = 14,
    Value = 1935049815050172457L,
    ModelInner = new Int64bigint0MI
{
    Id = 11,
    Value = 3383150263902284542L,
    NullableValue = 7849733022215130264L,
},
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 19,
    Value = 3713634125844948546L,
    ModelInner = null,
    NullableValue = 1347694893252272437L,
},
            new Int64bigint0M
{
    Id = 25,
    Value = 98818475783764853L,
    ModelInner = new Int64bigint0MI
{
    Id = 16,
    Value = 8641638886270896010L,
    NullableValue = null,
},
    NullableValue = 5380502635608737486L,
},
            new Int64bigint0M
{
    Id = 30,
    Value = 815324675109494910L,
    ModelInner = null,
    NullableValue = 7136289027201090196L,
},
            new Int64bigint0M
{
    Id = 37,
    Value = 5600890986508767039L,
    ModelInner = new Int64bigint0MI
{
    Id = 24,
    Value = 3169072753181077922L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 44,
    Value = 4851691203369126812L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 46,
    Value = 463388638254071161L,
    ModelInner = new Int64bigint0MI
{
    Id = 27,
    Value = 4605086373592580740L,
    NullableValue = 6469776999459322918L,
},
    NullableValue = 494032153796259844L,
},
            new Int64bigint0M
{
    Id = 50,
    Value = 2276362898295649829L,
    ModelInner = null,
    NullableValue = 7208480771067076L,
},
            new Int64bigint0M
{
    Id = 59,
    Value = 7743368924293794456L,
    ModelInner = new Int64bigint0MI
{
    Id = 35,
    Value = 6307370981861176686L,
    NullableValue = 4220619337470912309L,
},
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 67,
    Value = 8636987363395225043L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 70,
    Value = 8145389158405143516L,
    ModelInner = new Int64bigint0MI
{
    Id = 41,
    Value = 6986661802947830098L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 75,
    Value = 3343842830816442336L,
    ModelInner = null,
    NullableValue = 1564668672330378784L,
},
            new Int64bigint0M
{
    Id = 77,
    Value = 8609912623325977871L,
    ModelInner = new Int64bigint0MI
{
    Id = 45,
    Value = 43797055457008792L,
    NullableValue = 3464315470792711255L,
},
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 86,
    Value = 2539870915162626915L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 89,
    Value = 4431267805616267138L,
    ModelInner = new Int64bigint0MI
{
    Id = 47,
    Value = 2462107966351507762L,
    NullableValue = null,
},
    NullableValue = 3513138579699833352L,
},
            new Int64bigint0M
{
    Id = 96,
    Value = 4023337588101524211L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 105,
    Value = 5047956447042744468L,
    ModelInner = new Int64bigint0MI
{
    Id = 55,
    Value = 1178027503855804428L,
    NullableValue = null,
},
    NullableValue = 8045253827526531795L,
},
            new Int64bigint0M
{
    Id = 110,
    Value = 5243819140784185650L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 118,
    Value = 1159179578453777428L,
    ModelInner = new Int64bigint0MI
{
    Id = 63,
    Value = 6842635697581288435L,
    NullableValue = 975512316123124332L,
},
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 123,
    Value = 4109484867648078258L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 130,
    Value = 9001442875701355999L,
    ModelInner = new Int64bigint0MI
{
    Id = 70,
    Value = 3383042392064322231L,
    NullableValue = 6117839707873671965L,
},
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 132,
    Value = 2405300348302481416L,
    ModelInner = null,
    NullableValue = 3813302162250313876L,
},
            new Int64bigint0M
{
    Id = 141,
    Value = 6304663647303933627L,
    ModelInner = new Int64bigint0MI
{
    Id = 76,
    Value = 5246473524824631887L,
    NullableValue = 8274131847085030963L,
},
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 148,
    Value = 1002426045068511174L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 156,
    Value = 2353007971306526631L,
    ModelInner = new Int64bigint0MI
{
    Id = 85,
    Value = 8468095736352890731L,
    NullableValue = 2240797284742409365L,
},
    NullableValue = 327940131143374276L,
},
            new Int64bigint0M
{
    Id = 157,
    Value = 1796764261725843508L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 163,
    Value = 6356456830918059562L,
    ModelInner = new Int64bigint0MI
{
    Id = 87,
    Value = 383355478410552014L,
    NullableValue = 3630361007907602401L,
},
    NullableValue = 7265507073158028732L,
},
            new Int64bigint0M
{
    Id = 170,
    Value = 1461850562472204306L,
    ModelInner = null,
    NullableValue = 803277012811585198L,
},
            new Int64bigint0M
{
    Id = 178,
    Value = 9199552979472938303L,
    ModelInner = new Int64bigint0MI
{
    Id = 92,
    Value = 6347566054313613764L,
    NullableValue = 8206475753039525008L,
},
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 186,
    Value = 5612420776086802839L,
    ModelInner = null,
    NullableValue = 6590224803272032251L,
},
            new Int64bigint0M
{
    Id = 195,
    Value = 450587331529260322L,
    ModelInner = new Int64bigint0MI
{
    Id = 100,
    Value = 4867029296398830147L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 199,
    Value = 8351893823852987368L,
    ModelInner = null,
    NullableValue = 2571740298649172314L,
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigint0M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigint0M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigint0M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigint0M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigint0M.AssertModel(models1[i],_testData[i], false);
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
                parametr1.Value = 148;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 163;
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
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[4],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 132;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 96;
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
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[15],_testData[34], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigint0M.AssertModel(models1[i],_testData[i], false);
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
                parametr1.Value = 148;
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
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 157;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 12;
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
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatInt64bigint0M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[31],_testData[34], false);
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
                parametr1.Value = 3;
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

                    if(resultIndex == 2)
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
                parametr1.Value = 157;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 75;
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
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatInt64bigint0M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[19],_testData[34], false);
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
                parametr1.Value = 70;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 30;
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
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatInt64bigint0M.AssertModel(models[0],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(models[1],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(models[2],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(models[3],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(models[4],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(models[5],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(models[6],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(models[7],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(models[8],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(models[9],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(models[10],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(models[11],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(models[12],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(models[13],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(models[14],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(models[15],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(models[16],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(models[17],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(models[18],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(models[19],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatInt64bigint0M.AssertModel(models[0],_testData[7], false);
                        FlatInt64bigint0M.AssertModel(models[1],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(models[2],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(models[3],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(models[4],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(models[5],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(models[6],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(models[7],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(models[8],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(models[9],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(models[10],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(models[11],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(models[12],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(models[13],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(models[14],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(models[15],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(models[16],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(models[17],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(models[18],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(models[19],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(models[20],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(models[21],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(models[22],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(models[23],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(models[24],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(models[25],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(models[26],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(models[27],_testData[34], false);
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
                parametr1.Value = 25;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 141;
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
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatInt64bigint0M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[8],_testData[34], false);
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
                parametr1.Value = 89;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 30;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64SingleTypebigint)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        Int64bigint0M.AssertModel(models[0],_testData[18], false);
                        Int64bigint0M.AssertModel(models[1],_testData[19], false);
                        Int64bigint0M.AssertModel(models[2],_testData[20], false);
                        Int64bigint0M.AssertModel(models[3],_testData[21], false);
                        Int64bigint0M.AssertModel(models[4],_testData[22], false);
                        Int64bigint0M.AssertModel(models[5],_testData[23], false);
                        Int64bigint0M.AssertModel(models[6],_testData[24], false);
                        Int64bigint0M.AssertModel(models[7],_testData[25], false);
                        Int64bigint0M.AssertModel(models[8],_testData[26], false);
                        Int64bigint0M.AssertModel(models[9],_testData[27], false);
                        Int64bigint0M.AssertModel(models[10],_testData[28], false);
                        Int64bigint0M.AssertModel(models[11],_testData[29], false);
                        Int64bigint0M.AssertModel(models[12],_testData[30], false);
                        Int64bigint0M.AssertModel(models[13],_testData[31], false);
                        Int64bigint0M.AssertModel(models[14],_testData[32], false);
                        Int64bigint0M.AssertModel(models[15],_testData[33], false);
                        Int64bigint0M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        Int64bigint0M.AssertModel(models[0],_testData[7], false);
                        Int64bigint0M.AssertModel(models[1],_testData[8], false);
                        Int64bigint0M.AssertModel(models[2],_testData[9], false);
                        Int64bigint0M.AssertModel(models[3],_testData[10], false);
                        Int64bigint0M.AssertModel(models[4],_testData[11], false);
                        Int64bigint0M.AssertModel(models[5],_testData[12], false);
                        Int64bigint0M.AssertModel(models[6],_testData[13], false);
                        Int64bigint0M.AssertModel(models[7],_testData[14], false);
                        Int64bigint0M.AssertModel(models[8],_testData[15], false);
                        Int64bigint0M.AssertModel(models[9],_testData[16], false);
                        Int64bigint0M.AssertModel(models[10],_testData[17], false);
                        Int64bigint0M.AssertModel(models[11],_testData[18], false);
                        Int64bigint0M.AssertModel(models[12],_testData[19], false);
                        Int64bigint0M.AssertModel(models[13],_testData[20], false);
                        Int64bigint0M.AssertModel(models[14],_testData[21], false);
                        Int64bigint0M.AssertModel(models[15],_testData[22], false);
                        Int64bigint0M.AssertModel(models[16],_testData[23], false);
                        Int64bigint0M.AssertModel(models[17],_testData[24], false);
                        Int64bigint0M.AssertModel(models[18],_testData[25], false);
                        Int64bigint0M.AssertModel(models[19],_testData[26], false);
                        Int64bigint0M.AssertModel(models[20],_testData[27], false);
                        Int64bigint0M.AssertModel(models[21],_testData[28], false);
                        Int64bigint0M.AssertModel(models[22],_testData[29], false);
                        Int64bigint0M.AssertModel(models[23],_testData[30], false);
                        Int64bigint0M.AssertModel(models[24],_testData[31], false);
                        Int64bigint0M.AssertModel(models[25],_testData[32], false);
                        Int64bigint0M.AssertModel(models[26],_testData[33], false);
                        Int64bigint0M.AssertModel(models[27],_testData[34], false);
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
                parametr1.Value = 186;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 46;
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
                        Assert.That(models, Has.Count.EqualTo(25));

                        Int64bigint0M.AssertModel(models[0],_testData[10], false);
                        Int64bigint0M.AssertModel(models[1],_testData[11], false);
                        Int64bigint0M.AssertModel(models[2],_testData[12], false);
                        Int64bigint0M.AssertModel(models[3],_testData[13], false);
                        Int64bigint0M.AssertModel(models[4],_testData[14], false);
                        Int64bigint0M.AssertModel(models[5],_testData[15], false);
                        Int64bigint0M.AssertModel(models[6],_testData[16], false);
                        Int64bigint0M.AssertModel(models[7],_testData[17], false);
                        Int64bigint0M.AssertModel(models[8],_testData[18], false);
                        Int64bigint0M.AssertModel(models[9],_testData[19], false);
                        Int64bigint0M.AssertModel(models[10],_testData[20], false);
                        Int64bigint0M.AssertModel(models[11],_testData[21], false);
                        Int64bigint0M.AssertModel(models[12],_testData[22], false);
                        Int64bigint0M.AssertModel(models[13],_testData[23], false);
                        Int64bigint0M.AssertModel(models[14],_testData[24], false);
                        Int64bigint0M.AssertModel(models[15],_testData[25], false);
                        Int64bigint0M.AssertModel(models[16],_testData[26], false);
                        Int64bigint0M.AssertModel(models[17],_testData[27], false);
                        Int64bigint0M.AssertModel(models[18],_testData[28], false);
                        Int64bigint0M.AssertModel(models[19],_testData[29], false);
                        Int64bigint0M.AssertModel(models[20],_testData[30], false);
                        Int64bigint0M.AssertModel(models[21],_testData[31], false);
                        Int64bigint0M.AssertModel(models[22],_testData[32], false);
                        Int64bigint0M.AssertModel(models[23],_testData[33], false);
                        Int64bigint0M.AssertModel(models[24],_testData[34], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigint0M.AssertModel(models1[i],_testData[i], false);
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
                await ((IInt64SingleTypebigint)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 3, query1, 25, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatInt64bigint0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[28],_testData[34], false);
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
                await ((IInt64SingleTypebigint)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 59, query1, 77, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatInt64bigint0M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[18],_testData[34], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigint0M.AssertModel(models1[i],_testData[i], false);
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
                 ((IInt64SingleTypebigint)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 156, query1, 14, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatInt64bigint0M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[30],_testData[34], false);
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
                 ((IInt64SingleTypebigint)this).DbConnectionMMDynQuerySelectModelBatch(connection, 110, query1, 25, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatInt64bigint0M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[28],_testData[34], false);
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
                foreach(var batchResult in await ((IInt64SingleTypebigint)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 3, query1, 77, query2))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
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
                await ((IInt64SingleTypebigint)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 77, query1, 5, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                foreach(var batchResult in  ((IInt64SingleTypebigint)this).DbConnectionSTDynQuerySelectModelBatch(connection, 37, query1, 118, query2))
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
                 ((IInt64SingleTypebigint)this).DbConnectionDynQuerySelectModelBatch(connection, 14, query1, 170, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                        FlatInt64bigint0M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[3],_testData[34], false);
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
                foreach(var batchResult in await ((IInt64SingleTypebigint)this).DbConnectionSTSelectModelBatchAsync(connection, 156, 170))
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
                        Assert.That(models, Has.Count.EqualTo(4));

                        Int64bigint0M.AssertModel(models[0],_testData[31], false);
                        Int64bigint0M.AssertModel(models[1],_testData[32], false);
                        Int64bigint0M.AssertModel(models[2],_testData[33], false);
                        Int64bigint0M.AssertModel(models[3],_testData[34], false);
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
                foreach(var batchResult in  ((IInt64SingleTypebigint)this).DbConnectionSTSelectModelBatch(connection, 14, 148))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        Int64bigint0M.AssertModel(models[0],_testData[4], false);
                        Int64bigint0M.AssertModel(models[1],_testData[5], false);
                        Int64bigint0M.AssertModel(models[2],_testData[6], false);
                        Int64bigint0M.AssertModel(models[3],_testData[7], false);
                        Int64bigint0M.AssertModel(models[4],_testData[8], false);
                        Int64bigint0M.AssertModel(models[5],_testData[9], false);
                        Int64bigint0M.AssertModel(models[6],_testData[10], false);
                        Int64bigint0M.AssertModel(models[7],_testData[11], false);
                        Int64bigint0M.AssertModel(models[8],_testData[12], false);
                        Int64bigint0M.AssertModel(models[9],_testData[13], false);
                        Int64bigint0M.AssertModel(models[10],_testData[14], false);
                        Int64bigint0M.AssertModel(models[11],_testData[15], false);
                        Int64bigint0M.AssertModel(models[12],_testData[16], false);
                        Int64bigint0M.AssertModel(models[13],_testData[17], false);
                        Int64bigint0M.AssertModel(models[14],_testData[18], false);
                        Int64bigint0M.AssertModel(models[15],_testData[19], false);
                        Int64bigint0M.AssertModel(models[16],_testData[20], false);
                        Int64bigint0M.AssertModel(models[17],_testData[21], false);
                        Int64bigint0M.AssertModel(models[18],_testData[22], false);
                        Int64bigint0M.AssertModel(models[19],_testData[23], false);
                        Int64bigint0M.AssertModel(models[20],_testData[24], false);
                        Int64bigint0M.AssertModel(models[21],_testData[25], false);
                        Int64bigint0M.AssertModel(models[22],_testData[26], false);
                        Int64bigint0M.AssertModel(models[23],_testData[27], false);
                        Int64bigint0M.AssertModel(models[24],_testData[28], false);
                        Int64bigint0M.AssertModel(models[25],_testData[29], false);
                        Int64bigint0M.AssertModel(models[26],_testData[30], false);
                        Int64bigint0M.AssertModel(models[27],_testData[31], false);
                        Int64bigint0M.AssertModel(models[28],_testData[32], false);
                        Int64bigint0M.AssertModel(models[29],_testData[33], false);
                        Int64bigint0M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        Int64bigint0M.AssertModel(models[0],_testData[27], false);
                        Int64bigint0M.AssertModel(models[1],_testData[28], false);
                        Int64bigint0M.AssertModel(models[2],_testData[29], false);
                        Int64bigint0M.AssertModel(models[3],_testData[30], false);
                        Int64bigint0M.AssertModel(models[4],_testData[31], false);
                        Int64bigint0M.AssertModel(models[5],_testData[32], false);
                        Int64bigint0M.AssertModel(models[6],_testData[33], false);
                        Int64bigint0M.AssertModel(models[7],_testData[34], false);
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
                ((IInt64SingleTypebigint)this).SetDbConnectionSelectModelParametrs(cmd, 77);
                var models = await ((IInt64SingleTypebigint)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(19));

                Int64bigint0M.AssertModel(models[0],_testData[16], false);
                Int64bigint0M.AssertModel(models[1],_testData[17], false);
                Int64bigint0M.AssertModel(models[2],_testData[18], false);
                Int64bigint0M.AssertModel(models[3],_testData[19], false);
                Int64bigint0M.AssertModel(models[4],_testData[20], false);
                Int64bigint0M.AssertModel(models[5],_testData[21], false);
                Int64bigint0M.AssertModel(models[6],_testData[22], false);
                Int64bigint0M.AssertModel(models[7],_testData[23], false);
                Int64bigint0M.AssertModel(models[8],_testData[24], false);
                Int64bigint0M.AssertModel(models[9],_testData[25], false);
                Int64bigint0M.AssertModel(models[10],_testData[26], false);
                Int64bigint0M.AssertModel(models[11],_testData[27], false);
                Int64bigint0M.AssertModel(models[12],_testData[28], false);
                Int64bigint0M.AssertModel(models[13],_testData[29], false);
                Int64bigint0M.AssertModel(models[14],_testData[30], false);
                Int64bigint0M.AssertModel(models[15],_testData[31], false);
                Int64bigint0M.AssertModel(models[16],_testData[32], false);
                Int64bigint0M.AssertModel(models[17],_testData[33], false);
                Int64bigint0M.AssertModel(models[18],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt64SingleTypebigint)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt64SingleTypebigint)this).SetDbConnectionSelectModelParametrs(cmd, 77);
                var models =  ((IInt64SingleTypebigint)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(19));

                Int64bigint0M.AssertModel(models[0],_testData[16], false);
                Int64bigint0M.AssertModel(models[1],_testData[17], false);
                Int64bigint0M.AssertModel(models[2],_testData[18], false);
                Int64bigint0M.AssertModel(models[3],_testData[19], false);
                Int64bigint0M.AssertModel(models[4],_testData[20], false);
                Int64bigint0M.AssertModel(models[5],_testData[21], false);
                Int64bigint0M.AssertModel(models[6],_testData[22], false);
                Int64bigint0M.AssertModel(models[7],_testData[23], false);
                Int64bigint0M.AssertModel(models[8],_testData[24], false);
                Int64bigint0M.AssertModel(models[9],_testData[25], false);
                Int64bigint0M.AssertModel(models[10],_testData[26], false);
                Int64bigint0M.AssertModel(models[11],_testData[27], false);
                Int64bigint0M.AssertModel(models[12],_testData[28], false);
                Int64bigint0M.AssertModel(models[13],_testData[29], false);
                Int64bigint0M.AssertModel(models[14],_testData[30], false);
                Int64bigint0M.AssertModel(models[15],_testData[31], false);
                Int64bigint0M.AssertModel(models[16],_testData[32], false);
                Int64bigint0M.AssertModel(models[17],_testData[33], false);
                Int64bigint0M.AssertModel(models[18],_testData[34], false);
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
                Assert.That((System.Int32)model[0], Is.EqualTo((3)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4800391452489070502L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((5)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8637463657221674363L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((3)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((567865080071417419L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((7575478873044498806L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4661646069846683709L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((2778629732895035401L)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1935049815050172457L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((11)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((3383150263902284542L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((7849733022215130264L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3713634125844948546L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((1347694893252272437L)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((98818475783764853L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((8641638886270896010L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((5380502635608737486L)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((815324675109494910L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((7136289027201090196L)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5600890986508767039L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((3169072753181077922L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4851691203369126812L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((463388638254071161L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((4605086373592580740L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((6469776999459322918L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((494032153796259844L)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2276362898295649829L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((7208480771067076L)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7743368924293794456L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((6307370981861176686L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((4220619337470912309L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8636987363395225043L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8145389158405143516L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((6986661802947830098L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((75)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3343842830816442336L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((1564668672330378784L)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8609912623325977871L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((43797055457008792L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((3464315470792711255L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2539870915162626915L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4431267805616267138L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((2462107966351507762L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((3513138579699833352L)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((96)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4023337588101524211L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5047956447042744468L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((1178027503855804428L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((8045253827526531795L)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5243819140784185650L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1159179578453777428L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((6842635697581288435L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((975512316123124332L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4109484867648078258L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((9001442875701355999L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((70)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((3383042392064322231L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((6117839707873671965L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2405300348302481416L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((3813302162250313876L)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6304663647303933627L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((76)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((5246473524824631887L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((8274131847085030963L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1002426045068511174L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((156)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2353007971306526631L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((85)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((8468095736352890731L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((2240797284742409365L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((327940131143374276L)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((157)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1796764261725843508L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((163)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6356456830918059562L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((87)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((383355478410552014L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((3630361007907602401L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((7265507073158028732L)));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((170)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1461850562472204306L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((803277012811585198L)));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((178)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((9199552979472938303L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((92)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((6347566054313613764L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((8206475753039525008L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((186)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5612420776086802839L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((6590224803272032251L)));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((195)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((450587331529260322L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((100)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((4867029296398830147L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((199)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8351893823852987368L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((2571740298649172314L)));

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
                Assert.That((System.Int32)model[0], Is.EqualTo((3)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4800391452489070502L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((5)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8637463657221674363L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((3)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((567865080071417419L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((7575478873044498806L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4661646069846683709L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((2778629732895035401L)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1935049815050172457L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((11)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((3383150263902284542L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((7849733022215130264L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3713634125844948546L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((1347694893252272437L)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((98818475783764853L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((8641638886270896010L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((5380502635608737486L)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((815324675109494910L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((7136289027201090196L)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5600890986508767039L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((3169072753181077922L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4851691203369126812L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((463388638254071161L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((4605086373592580740L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((6469776999459322918L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((494032153796259844L)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2276362898295649829L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((7208480771067076L)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7743368924293794456L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((6307370981861176686L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((4220619337470912309L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8636987363395225043L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8145389158405143516L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((6986661802947830098L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((75)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3343842830816442336L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((1564668672330378784L)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8609912623325977871L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((43797055457008792L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((3464315470792711255L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2539870915162626915L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4431267805616267138L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((2462107966351507762L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((3513138579699833352L)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((96)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4023337588101524211L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5047956447042744468L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((1178027503855804428L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((8045253827526531795L)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5243819140784185650L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1159179578453777428L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((6842635697581288435L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((975512316123124332L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4109484867648078258L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((9001442875701355999L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((70)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((3383042392064322231L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((6117839707873671965L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2405300348302481416L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((3813302162250313876L)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6304663647303933627L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((76)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((5246473524824631887L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((8274131847085030963L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1002426045068511174L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((156)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2353007971306526631L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((85)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((8468095736352890731L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((2240797284742409365L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((327940131143374276L)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((157)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1796764261725843508L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((163)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6356456830918059562L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((87)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((383355478410552014L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((3630361007907602401L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((7265507073158028732L)));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((170)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1461850562472204306L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((803277012811585198L)));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((178)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((9199552979472938303L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((92)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((6347566054313613764L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((8206475753039525008L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((186)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5612420776086802839L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((6590224803272032251L)));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((195)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((450587331529260322L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((100)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((4867029296398830147L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((199)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8351893823852987368L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((2571740298649172314L)));

            }
        }

#endregion

    }
}

