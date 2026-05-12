

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
    internal partial interface IUInt64SingleTypebigint_UNSIGNED
    {
    }
    
    internal partial class UInt64SingleTypebigint_UNSIGNED : IUInt64SingleTypebigint_UNSIGNED
    {


#region TestData

        private readonly UInt64bigint_UNSIGNEDE0M[] _testData = new UInt64bigint_UNSIGNEDE0M[]
        {
            new UInt64bigint_UNSIGNEDE0M
{
    Id = 7,
    Value = 3326328208631001546L,
    ModelInner = null,
    NullableValue = null,
},
            new UInt64bigint_UNSIGNEDE0M
{
    Id = 14,
    Value = 1127514237533774558L,
    ModelInner = new UInt64bigint_UNSIGNEDE0MI
{
    Id = 2,
    Value = 6282174264988682579L,
    NullableValue = 1652782592033677052L,
},
    NullableValue = 6845555402196836707L,
},
            new UInt64bigint_UNSIGNEDE0M
{
    Id = 23,
    Value = 6427212915278215953L,
    ModelInner = null,
    NullableValue = null,
},
            new UInt64bigint_UNSIGNEDE0M
{
    Id = 27,
    Value = 1563490293556766336L,
    ModelInner = new UInt64bigint_UNSIGNEDE0MI
{
    Id = 10,
    Value = 8822060071849185851L,
    NullableValue = 2309312359655228365L,
},
    NullableValue = 7413576231313303857L,
},
            new UInt64bigint_UNSIGNEDE0M
{
    Id = 29,
    Value = 3298758737682668171L,
    ModelInner = null,
    NullableValue = 7689369689221818571L,
},
            new UInt64bigint_UNSIGNEDE0M
{
    Id = 38,
    Value = 3026486277418387449L,
    ModelInner = new UInt64bigint_UNSIGNEDE0MI
{
    Id = 16,
    Value = 2370445187818430655L,
    NullableValue = 2810598740212392790L,
},
    NullableValue = null,
},
            new UInt64bigint_UNSIGNEDE0M
{
    Id = 45,
    Value = 6728026094780514535L,
    ModelInner = null,
    NullableValue = null,
},
            new UInt64bigint_UNSIGNEDE0M
{
    Id = 48,
    Value = 1257837367529108261L,
    ModelInner = new UInt64bigint_UNSIGNEDE0MI
{
    Id = 22,
    Value = 2155942189478141576L,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64bigint_UNSIGNEDE0M
{
    Id = 56,
    Value = 3033840729745027423L,
    ModelInner = null,
    NullableValue = 3077534085005806785L,
},
            new UInt64bigint_UNSIGNEDE0M
{
    Id = 60,
    Value = 5379689564092594447L,
    ModelInner = new UInt64bigint_UNSIGNEDE0MI
{
    Id = 28,
    Value = 5353550725416462779L,
    NullableValue = 568717731251499970L,
},
    NullableValue = 3737809610260592375L,
},
            new UInt64bigint_UNSIGNEDE0M
{
    Id = 62,
    Value = 8421621516787038893L,
    ModelInner = null,
    NullableValue = 6871880572863193845L,
},
            new UInt64bigint_UNSIGNEDE0M
{
    Id = 63,
    Value = 8596525691144441509L,
    ModelInner = new UInt64bigint_UNSIGNEDE0MI
{
    Id = 34,
    Value = 8334580199061054370L,
    NullableValue = 8952085892780258621L,
},
    NullableValue = null,
},
            new UInt64bigint_UNSIGNEDE0M
{
    Id = 66,
    Value = 7296189388543226285L,
    ModelInner = null,
    NullableValue = null,
},
            new UInt64bigint_UNSIGNEDE0M
{
    Id = 71,
    Value = 2697250668770816969L,
    ModelInner = new UInt64bigint_UNSIGNEDE0MI
{
    Id = 43,
    Value = 7902015607753206885L,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64bigint_UNSIGNEDE0M
{
    Id = 77,
    Value = 3936570564336353930L,
    ModelInner = null,
    NullableValue = 5495031895904028696L,
},
            new UInt64bigint_UNSIGNEDE0M
{
    Id = 78,
    Value = 9003084313577550847L,
    ModelInner = new UInt64bigint_UNSIGNEDE0MI
{
    Id = 49,
    Value = 3204769544947305880L,
    NullableValue = null,
},
    NullableValue = 4280703425248131737L,
},
            new UInt64bigint_UNSIGNEDE0M
{
    Id = 87,
    Value = 8018200136001252468L,
    ModelInner = null,
    NullableValue = null,
},
            new UInt64bigint_UNSIGNEDE0M
{
    Id = 95,
    Value = 4797708351832694944L,
    ModelInner = new UInt64bigint_UNSIGNEDE0MI
{
    Id = 53,
    Value = 2763626773298437785L,
    NullableValue = 3836493027312298455L,
},
    NullableValue = 8957491403673676203L,
},
            new UInt64bigint_UNSIGNEDE0M
{
    Id = 100,
    Value = 71331149550786339L,
    ModelInner = null,
    NullableValue = null,
},
            new UInt64bigint_UNSIGNEDE0M
{
    Id = 101,
    Value = 3988018845933190209L,
    ModelInner = new UInt64bigint_UNSIGNEDE0MI
{
    Id = 62,
    Value = 3340125843602037032L,
    NullableValue = null,
},
    NullableValue = 6343189747195244967L,
},
            new UInt64bigint_UNSIGNEDE0M
{
    Id = 109,
    Value = 5208473905419004004L,
    ModelInner = null,
    NullableValue = null,
},
            new UInt64bigint_UNSIGNEDE0M
{
    Id = 110,
    Value = 2715150893685755245L,
    ModelInner = new UInt64bigint_UNSIGNEDE0MI
{
    Id = 69,
    Value = 1766011262363382596L,
    NullableValue = null,
},
    NullableValue = 7865753651667161403L,
},
            new UInt64bigint_UNSIGNEDE0M
{
    Id = 116,
    Value = 2269249044262186228L,
    ModelInner = null,
    NullableValue = 6193730615459748151L,
},
            new UInt64bigint_UNSIGNEDE0M
{
    Id = 121,
    Value = 5011417220945293241L,
    ModelInner = new UInt64bigint_UNSIGNEDE0MI
{
    Id = 71,
    Value = 631805544336514785L,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64bigint_UNSIGNEDE0M
{
    Id = 123,
    Value = 6694348135678246976L,
    ModelInner = null,
    NullableValue = 5183874126079044547L,
},
            new UInt64bigint_UNSIGNEDE0M
{
    Id = 124,
    Value = 4273871987419063772L,
    ModelInner = new UInt64bigint_UNSIGNEDE0MI
{
    Id = 75,
    Value = 3172012819689408860L,
    NullableValue = 5130819823500163683L,
},
    NullableValue = null,
},
            new UInt64bigint_UNSIGNEDE0M
{
    Id = 130,
    Value = 798392558283210322L,
    ModelInner = null,
    NullableValue = null,
},
            new UInt64bigint_UNSIGNEDE0M
{
    Id = 135,
    Value = 2347735583608214873L,
    ModelInner = new UInt64bigint_UNSIGNEDE0MI
{
    Id = 80,
    Value = 5552323042583054929L,
    NullableValue = null,
},
    NullableValue = 2298512579211727238L,
},
            new UInt64bigint_UNSIGNEDE0M
{
    Id = 136,
    Value = 277844415197176487L,
    ModelInner = null,
    NullableValue = 5855867403801569571L,
},
            new UInt64bigint_UNSIGNEDE0M
{
    Id = 144,
    Value = 8308520396801473020L,
    ModelInner = new UInt64bigint_UNSIGNEDE0MI
{
    Id = 83,
    Value = 3271916870166667180L,
    NullableValue = 2985725830075378474L,
},
    NullableValue = 1656526844879090432L,
},
            new UInt64bigint_UNSIGNEDE0M
{
    Id = 150,
    Value = 9151737998775174052L,
    ModelInner = null,
    NullableValue = null,
},
            new UInt64bigint_UNSIGNEDE0M
{
    Id = 152,
    Value = 5306241330234387367L,
    ModelInner = new UInt64bigint_UNSIGNEDE0MI
{
    Id = 88,
    Value = 1954640464192142710L,
    NullableValue = null,
},
    NullableValue = 1536495077208395849L,
},
            new UInt64bigint_UNSIGNEDE0M
{
    Id = 161,
    Value = 803097277718118609L,
    ModelInner = null,
    NullableValue = null,
},
            new UInt64bigint_UNSIGNEDE0M
{
    Id = 170,
    Value = 5707304714892995948L,
    ModelInner = new UInt64bigint_UNSIGNEDE0MI
{
    Id = 94,
    Value = 7375608255357084109L,
    NullableValue = null,
},
    NullableValue = 1503865886987757995L,
},
            new UInt64bigint_UNSIGNEDE0M
{
    Id = 179,
    Value = 579971687958887282L,
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.MySqlConnector.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.uint64bigint_unsignede0mi(
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
            asPartInterface: typeof(IUInt64SingleTypebigint_UNSIGNED)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                parametrName: "id",
                methodParametrName: "id", 
                dbType: (MySqlConnector.MySqlDbType)(3)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.UInt64),
                parametrName: "value",
                methodParametrName: "value",
                dbType: (MySqlConnector.MySqlDbType)(508)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.UInt64?), 
                parametrName: "nullablevalue",
                methodParametrName: "nullablevalue",
                dbType: (MySqlConnector.MySqlDbType)(508))]
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

                changedRows =  ((IUInt64SingleTypebigint_UNSIGNED)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IUInt64SingleTypebigint_UNSIGNED)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IUInt64SingleTypebigint_UNSIGNED)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt64SingleTypebigint_UNSIGNED)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.uint64bigint_unsignede0mi(
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
            asPartInterface: typeof(IUInt64SingleTypebigint_UNSIGNED)), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.UInt64), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(20)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.UInt64?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(20), 
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

                changedRows =  ((IUInt64SingleTypebigint_UNSIGNED)this).DbConnectionInsertInnerModel(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
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

                changedRows = await ((IUInt64SingleTypebigint_UNSIGNED)this).DbConnectionInsertInnerModelAsync(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt64SingleTypebigint_UNSIGNED)this).DbConnectionInsertInnerModelAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt64SingleTypebigint_UNSIGNED)this).DbConnectionInsertInnerModelAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt64SingleTypebigint_UNSIGNED)this).DbConnectionInsertInnerModelAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt64SingleTypebigint_UNSIGNED)this).DbConnectionInsertInnerModelAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt64SingleTypebigint_UNSIGNED)this).DbConnectionInsertInnerModelAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt64SingleTypebigint_UNSIGNED)this).DbConnectionInsertInnerModelAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt64SingleTypebigint_UNSIGNED)this).DbConnectionInsertInnerModelAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt64SingleTypebigint_UNSIGNED)this).DbConnectionInsertInnerModelAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt64SingleTypebigint_UNSIGNED)this).DbConnectionInsertInnerModelAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt64SingleTypebigint_UNSIGNED)this).DbConnectionInsertInnerModelAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt64SingleTypebigint_UNSIGNED)this).DbConnectionInsertInnerModelAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.MySqlConnector.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.uint64bigint_unsignede0m(
	id,
    value,
    nullablevalue,
    uint64bigint_unsignede0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @uint64bigint_unsignede0mi_id
)
",
            methodName:"InsertModel",
            sourceType: SourceType.MySqlConnection,
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt64SingleTypebigint_UNSIGNED)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (MySqlConnector.MySqlDbType)(3)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.UInt64), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (MySqlConnector.MySqlDbType)(508)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.UInt64?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (MySqlConnector.MySqlDbType)(508),
                nullable: true),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "uint64bigint_unsignede0mi_id", 
                methodParametrName: "uint64bigint_unsignede0mi_id", 
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

                changedRows =  ((IUInt64SingleTypebigint_UNSIGNED)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IUInt64SingleTypebigint_UNSIGNED)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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

                changedRows = await ((IUInt64SingleTypebigint_UNSIGNED)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt64SingleTypebigint_UNSIGNED)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.uint64bigint_unsignede0m(
	id,
    value,
    nullablevalue,
    uint64bigint_unsignede0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @uint64bigint_unsignede0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt64SingleTypebigint_UNSIGNED)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.UInt64), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(20)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.UInt64?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(20),
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "uint64bigint_unsignede0mi_id", 
                methodParametrName: "uint64bigint_unsignede0mi_id", 
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

                changedRows =  ((IUInt64SingleTypebigint_UNSIGNED)this).DbConnectionInsertModel(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IUInt64SingleTypebigint_UNSIGNED)this).DbConnectionInsertModel(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
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

                changedRows = await ((IUInt64SingleTypebigint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt64SingleTypebigint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt64SingleTypebigint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt64SingleTypebigint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt64SingleTypebigint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt64SingleTypebigint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt64SingleTypebigint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt64SingleTypebigint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt64SingleTypebigint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt64SingleTypebigint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt64SingleTypebigint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt64SingleTypebigint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt64SingleTypebigint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt64SingleTypebigint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt64SingleTypebigint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt64SingleTypebigint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt64SingleTypebigint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt64SingleTypebigint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt64SingleTypebigint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt64SingleTypebigint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt64SingleTypebigint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt64SingleTypebigint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt64SingleTypebigint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt64SingleTypebigint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt64SingleTypebigint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt64SingleTypebigint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt64SingleTypebigint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt64SingleTypebigint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IUInt64SingleTypebigint_UNSIGNED)this).DbConnectionInsertModelAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatUInt64bigint_UNSIGNEDE0M), typeof(FlatUInt64bigint_UNSIGNEDE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt64SingleTypebigint_UNSIGNED)),
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
FROM gedaqtests.uint64bigint_unsignede0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatUInt64bigint_UNSIGNEDE0M>();
                var models2 = new List<FlatUInt64bigint_UNSIGNEDE0M>();
                await((IUInt64SingleTypebigint_UNSIGNED)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models1[i],_testData[i], false);
                    FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models2[i],_testData[i], false);
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
FROM gedaqtests.uint64bigint_unsignede0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatUInt64bigint_UNSIGNEDE0M>();
                var models2 = new List<FlatUInt64bigint_UNSIGNEDE0M>();
                ((IUInt64SingleTypebigint_UNSIGNED)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models1[i],_testData[i], false);
                    FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatUInt64bigint_UNSIGNEDE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt64SingleTypebigint_UNSIGNED)),
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
FROM gedaqtests.uint64bigint_unsignede0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
                var models = await((IUInt64SingleTypebigint_UNSIGNED)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.uint64bigint_unsignede0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
                var models = ((IUInt64SingleTypebigint_UNSIGNED)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.uint64bigint_unsignede0m m
LEFT JOIN gedaqtests.uint64bigint_unsignede0mi mi ON mi.id = m.uint64bigint_unsignede0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            sourceType: SourceType.MySqlConnection,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(UInt64bigint_UNSIGNEDE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt64SingleTypebigint_UNSIGNED)),
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
                var models = await((IUInt64SingleTypebigint_UNSIGNED)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    UInt64bigint_UNSIGNEDE0M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IUInt64SingleTypebigint_UNSIGNED)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    UInt64bigint_UNSIGNEDE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatUInt64bigint_UNSIGNEDE0M), typeof(FlatUInt64bigint_UNSIGNEDE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt64SingleTypebigint_UNSIGNED)),
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
FROM gedaqtests.uint64bigint_unsignede0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatUInt64bigint_UNSIGNEDE0M>();
                var models2 = new List<FlatUInt64bigint_UNSIGNEDE0M>();
                await((IUInt64SingleTypebigint_UNSIGNED)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models1[i],_testData[i], false);
                    FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models2[i],_testData[i], false);
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
FROM gedaqtests.uint64bigint_unsignede0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatUInt64bigint_UNSIGNEDE0M>();
                var models2 = new List<FlatUInt64bigint_UNSIGNEDE0M>();
                ((IUInt64SingleTypebigint_UNSIGNED)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models1[i],_testData[i], false);
                    FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatUInt64bigint_UNSIGNEDE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt64SingleTypebigint_UNSIGNED)),
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
FROM gedaqtests.uint64bigint_unsignede0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IUInt64SingleTypebigint_UNSIGNED)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.uint64bigint_unsignede0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IUInt64SingleTypebigint_UNSIGNED)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.uint64bigint_unsignede0m m
LEFT JOIN gedaqtests.uint64bigint_unsignede0mi mi ON mi.id = m.uint64bigint_unsignede0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            sourceType: SourceType.MySqlConnection,
            methodName:"SelectModel",
            queryMapTypes: [typeof(UInt64bigint_UNSIGNEDE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt64SingleTypebigint_UNSIGNED)),
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
                var models = await((IUInt64SingleTypebigint_UNSIGNED)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    UInt64bigint_UNSIGNEDE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IUInt64SingleTypebigint_UNSIGNED)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    UInt64bigint_UNSIGNEDE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatUInt64bigint_UNSIGNEDE0M), typeof(FlatUInt64bigint_UNSIGNEDE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt64SingleTypebigint_UNSIGNED)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt64SingleTypebigint_UNSIGNED)),
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
            asPartInterface: typeof(IUInt64SingleTypebigint_UNSIGNED)),
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
FROM gedaqtests.uint64bigint_unsignede0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatUInt64bigint_UNSIGNEDE0M>();
                var models2 = new List<FlatUInt64bigint_UNSIGNEDE0M>();
                await((IUInt64SingleTypebigint_UNSIGNED)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models1[i],_testData[i], false);
                    FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 161;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 130;
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
FROM gedaqtests.uint64bigint_unsignede0m m
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
FROM gedaqtests.uint64bigint_unsignede0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatUInt64bigint_UNSIGNEDE0M>();
                var firstItems2 = new List<FlatUInt64bigint_UNSIGNEDE0M>();
                var secondItems1 = new List<FlatUInt64bigint_UNSIGNEDE0M>();
                var secondItems2 = new List<FlatUInt64bigint_UNSIGNEDE0M>();
                await ((IUInt64SingleTypebigint_UNSIGNED)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[7],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 124;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 48;
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
FROM gedaqtests.uint64bigint_unsignede0m m
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
FROM gedaqtests.uint64bigint_unsignede0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatUInt64bigint_UNSIGNEDE0M>();
                var firstItems2 = new List<FlatUInt64bigint_UNSIGNEDE0M>();
                var secondItems1 = new List<FlatUInt64bigint_UNSIGNEDE0M>();
                await ((IUInt64SingleTypebigint_UNSIGNED)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[26],_testData[34], false);
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
FROM gedaqtests.uint64bigint_unsignede0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatUInt64bigint_UNSIGNEDE0M>();
                var models2 = new List<FlatUInt64bigint_UNSIGNEDE0M>();
                ((IUInt64SingleTypebigint_UNSIGNED)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models1[i],_testData[i], false);
                    FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 77;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 23;
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
FROM gedaqtests.uint64bigint_unsignede0m m
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
FROM gedaqtests.uint64bigint_unsignede0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatUInt64bigint_UNSIGNEDE0M>();
                var firstItems2 = new List<FlatUInt64bigint_UNSIGNEDE0M>();
                var secondItems1 = new List<FlatUInt64bigint_UNSIGNEDE0M>();
                var secondItems2 = new List<FlatUInt64bigint_UNSIGNEDE0M>();
                 ((IUInt64SingleTypebigint_UNSIGNED)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[31],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 63;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 62;
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
FROM gedaqtests.uint64bigint_unsignede0m m
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
FROM gedaqtests.uint64bigint_unsignede0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatUInt64bigint_UNSIGNEDE0M>();
                var firstItems2 = new List<FlatUInt64bigint_UNSIGNEDE0M>();
                var secondItems1 = new List<FlatUInt64bigint_UNSIGNEDE0M>();
                 ((IUInt64SingleTypebigint_UNSIGNED)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[23],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatUInt64bigint_UNSIGNEDE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt64SingleTypebigint_UNSIGNED)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt64SingleTypebigint_UNSIGNED)),
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
            asPartInterface: typeof(IUInt64SingleTypebigint_UNSIGNED)),
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
FROM gedaqtests.uint64bigint_unsignede0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IUInt64SingleTypebigint_UNSIGNED)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 29;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 62;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.uint64bigint_unsignede0m m
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
FROM gedaqtests.uint64bigint_unsignede0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IUInt64SingleTypebigint_UNSIGNED)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[0],_testData[5], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[1],_testData[6], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[2],_testData[7], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[3],_testData[8], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[4],_testData[9], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[5],_testData[10], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[6],_testData[11], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[7],_testData[12], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[8],_testData[13], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[9],_testData[14], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[10],_testData[15], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[11],_testData[16], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[12],_testData[17], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[13],_testData[18], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[14],_testData[19], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[15],_testData[20], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[16],_testData[21], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[17],_testData[22], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[18],_testData[23], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[19],_testData[24], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[20],_testData[25], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[21],_testData[26], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[22],_testData[27], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[23],_testData[28], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[24],_testData[29], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[25],_testData[30], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[26],_testData[31], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[27],_testData[32], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[28],_testData[33], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[0],_testData[11], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[1],_testData[12], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[2],_testData[13], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[3],_testData[14], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[4],_testData[15], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[5],_testData[16], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[6],_testData[17], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[7],_testData[18], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[8],_testData[19], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[9],_testData[20], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[10],_testData[21], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[11],_testData[22], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[12],_testData[23], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[13],_testData[24], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[14],_testData[25], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[15],_testData[26], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[16],_testData[27], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[17],_testData[28], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[18],_testData[29], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[19],_testData[30], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[20],_testData[31], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[21],_testData[32], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[22],_testData[33], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[23],_testData[34], false);
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
                parametr1.Value = 7;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 101;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.uint64bigint_unsignede0m m
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
FROM gedaqtests.uint64bigint_unsignede0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatUInt64bigint_UNSIGNEDE0M>();
                var secondItems1 = new List<FlatUInt64bigint_UNSIGNEDE0M>();
                var secondItems2 = new List<FlatUInt64bigint_UNSIGNEDE0M>();
                await ((IUInt64SingleTypebigint_UNSIGNED)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[14],_testData[34], false);
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
FROM gedaqtests.uint64bigint_unsignede0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IUInt64SingleTypebigint_UNSIGNED)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 136;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 60;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.uint64bigint_unsignede0m m
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
FROM gedaqtests.uint64bigint_unsignede0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IUInt64SingleTypebigint_UNSIGNED)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[0],_testData[29], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[1],_testData[30], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[2],_testData[31], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[3],_testData[32], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[4],_testData[33], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[0],_testData[10], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[1],_testData[11], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[2],_testData[12], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[3],_testData[13], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[4],_testData[14], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[5],_testData[15], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[6],_testData[16], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[7],_testData[17], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[8],_testData[18], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[9],_testData[19], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[10],_testData[20], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[11],_testData[21], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[12],_testData[22], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[13],_testData[23], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[14],_testData[24], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[15],_testData[25], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[16],_testData[26], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[17],_testData[27], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[18],_testData[28], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[19],_testData[29], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[20],_testData[30], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[21],_testData[31], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[22],_testData[32], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[23],_testData[33], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[24],_testData[34], false);
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
                parametr1.Value = 101;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 130;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.uint64bigint_unsignede0m m
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
FROM gedaqtests.uint64bigint_unsignede0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatUInt64bigint_UNSIGNEDE0M>();
                var secondItems1 = new List<FlatUInt64bigint_UNSIGNEDE0M>();
                var secondItems2 = new List<FlatUInt64bigint_UNSIGNEDE0M>();
                 ((IUInt64SingleTypebigint_UNSIGNED)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[7],_testData[34], false);
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
FROM gedaqtests.uint64bigint_unsignede0m m
LEFT JOIN gedaqtests.uint64bigint_unsignede0mi mi ON mi.id = m.uint64bigint_unsignede0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(UInt64bigint_UNSIGNEDE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt64SingleTypebigint_UNSIGNED)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt64SingleTypebigint_UNSIGNED)),
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
                var models = await((IUInt64SingleTypebigint_UNSIGNED)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    UInt64bigint_UNSIGNEDE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 56;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 161;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IUInt64SingleTypebigint_UNSIGNED)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        UInt64bigint_UNSIGNEDE0M.AssertModel(models[0],_testData[9], false);
                        UInt64bigint_UNSIGNEDE0M.AssertModel(models[1],_testData[10], false);
                        UInt64bigint_UNSIGNEDE0M.AssertModel(models[2],_testData[11], false);
                        UInt64bigint_UNSIGNEDE0M.AssertModel(models[3],_testData[12], false);
                        UInt64bigint_UNSIGNEDE0M.AssertModel(models[4],_testData[13], false);
                        UInt64bigint_UNSIGNEDE0M.AssertModel(models[5],_testData[14], false);
                        UInt64bigint_UNSIGNEDE0M.AssertModel(models[6],_testData[15], false);
                        UInt64bigint_UNSIGNEDE0M.AssertModel(models[7],_testData[16], false);
                        UInt64bigint_UNSIGNEDE0M.AssertModel(models[8],_testData[17], false);
                        UInt64bigint_UNSIGNEDE0M.AssertModel(models[9],_testData[18], false);
                        UInt64bigint_UNSIGNEDE0M.AssertModel(models[10],_testData[19], false);
                        UInt64bigint_UNSIGNEDE0M.AssertModel(models[11],_testData[20], false);
                        UInt64bigint_UNSIGNEDE0M.AssertModel(models[12],_testData[21], false);
                        UInt64bigint_UNSIGNEDE0M.AssertModel(models[13],_testData[22], false);
                        UInt64bigint_UNSIGNEDE0M.AssertModel(models[14],_testData[23], false);
                        UInt64bigint_UNSIGNEDE0M.AssertModel(models[15],_testData[24], false);
                        UInt64bigint_UNSIGNEDE0M.AssertModel(models[16],_testData[25], false);
                        UInt64bigint_UNSIGNEDE0M.AssertModel(models[17],_testData[26], false);
                        UInt64bigint_UNSIGNEDE0M.AssertModel(models[18],_testData[27], false);
                        UInt64bigint_UNSIGNEDE0M.AssertModel(models[19],_testData[28], false);
                        UInt64bigint_UNSIGNEDE0M.AssertModel(models[20],_testData[29], false);
                        UInt64bigint_UNSIGNEDE0M.AssertModel(models[21],_testData[30], false);
                        UInt64bigint_UNSIGNEDE0M.AssertModel(models[22],_testData[31], false);
                        UInt64bigint_UNSIGNEDE0M.AssertModel(models[23],_testData[32], false);
                        UInt64bigint_UNSIGNEDE0M.AssertModel(models[24],_testData[33], false);
                        UInt64bigint_UNSIGNEDE0M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        UInt64bigint_UNSIGNEDE0M.AssertModel(models[0],_testData[33], false);
                        UInt64bigint_UNSIGNEDE0M.AssertModel(models[1],_testData[34], false);
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
                var models = ((IUInt64SingleTypebigint_UNSIGNED)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    UInt64bigint_UNSIGNEDE0M.AssertModel(models[i],_testData[i], false);
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
                parametr2.Value = 136;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IUInt64SingleTypebigint_UNSIGNED)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        UInt64bigint_UNSIGNEDE0M.AssertModel(models[0],_testData[11], false);
                        UInt64bigint_UNSIGNEDE0M.AssertModel(models[1],_testData[12], false);
                        UInt64bigint_UNSIGNEDE0M.AssertModel(models[2],_testData[13], false);
                        UInt64bigint_UNSIGNEDE0M.AssertModel(models[3],_testData[14], false);
                        UInt64bigint_UNSIGNEDE0M.AssertModel(models[4],_testData[15], false);
                        UInt64bigint_UNSIGNEDE0M.AssertModel(models[5],_testData[16], false);
                        UInt64bigint_UNSIGNEDE0M.AssertModel(models[6],_testData[17], false);
                        UInt64bigint_UNSIGNEDE0M.AssertModel(models[7],_testData[18], false);
                        UInt64bigint_UNSIGNEDE0M.AssertModel(models[8],_testData[19], false);
                        UInt64bigint_UNSIGNEDE0M.AssertModel(models[9],_testData[20], false);
                        UInt64bigint_UNSIGNEDE0M.AssertModel(models[10],_testData[21], false);
                        UInt64bigint_UNSIGNEDE0M.AssertModel(models[11],_testData[22], false);
                        UInt64bigint_UNSIGNEDE0M.AssertModel(models[12],_testData[23], false);
                        UInt64bigint_UNSIGNEDE0M.AssertModel(models[13],_testData[24], false);
                        UInt64bigint_UNSIGNEDE0M.AssertModel(models[14],_testData[25], false);
                        UInt64bigint_UNSIGNEDE0M.AssertModel(models[15],_testData[26], false);
                        UInt64bigint_UNSIGNEDE0M.AssertModel(models[16],_testData[27], false);
                        UInt64bigint_UNSIGNEDE0M.AssertModel(models[17],_testData[28], false);
                        UInt64bigint_UNSIGNEDE0M.AssertModel(models[18],_testData[29], false);
                        UInt64bigint_UNSIGNEDE0M.AssertModel(models[19],_testData[30], false);
                        UInt64bigint_UNSIGNEDE0M.AssertModel(models[20],_testData[31], false);
                        UInt64bigint_UNSIGNEDE0M.AssertModel(models[21],_testData[32], false);
                        UInt64bigint_UNSIGNEDE0M.AssertModel(models[22],_testData[33], false);
                        UInt64bigint_UNSIGNEDE0M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        UInt64bigint_UNSIGNEDE0M.AssertModel(models[0],_testData[29], false);
                        UInt64bigint_UNSIGNEDE0M.AssertModel(models[1],_testData[30], false);
                        UInt64bigint_UNSIGNEDE0M.AssertModel(models[2],_testData[31], false);
                        UInt64bigint_UNSIGNEDE0M.AssertModel(models[3],_testData[32], false);
                        UInt64bigint_UNSIGNEDE0M.AssertModel(models[4],_testData[33], false);
                        UInt64bigint_UNSIGNEDE0M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatUInt64bigint_UNSIGNEDE0M), typeof(FlatUInt64bigint_UNSIGNEDE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt64SingleTypebigint_UNSIGNED)),
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
            asPartInterface: typeof(IUInt64SingleTypebigint_UNSIGNED)),
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
            asPartInterface: typeof(IUInt64SingleTypebigint_UNSIGNED)),
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
FROM gedaqtests.uint64bigint_unsignede0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatUInt64bigint_UNSIGNEDE0M>();
                var models2 = new List<FlatUInt64bigint_UNSIGNEDE0M>();
                await((IUInt64SingleTypebigint_UNSIGNED)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models1[i],_testData[i], false);
                    FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models2[i],_testData[i], false);
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
FROM gedaqtests.uint64bigint_unsignede0m m
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
FROM gedaqtests.uint64bigint_unsignede0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatUInt64bigint_UNSIGNEDE0M>();
                var firstItems2 = new List<FlatUInt64bigint_UNSIGNEDE0M>();
                var secondItems1 = new List<FlatUInt64bigint_UNSIGNEDE0M>();
                var secondItems2 = new List<FlatUInt64bigint_UNSIGNEDE0M>();
                await ((IUInt64SingleTypebigint_UNSIGNED)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 63, query1, 124, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[8],_testData[34], false);
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
FROM gedaqtests.uint64bigint_unsignede0m m
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
FROM gedaqtests.uint64bigint_unsignede0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatUInt64bigint_UNSIGNEDE0M>();
                var firstItems2 = new List<FlatUInt64bigint_UNSIGNEDE0M>();
                var secondItems1 = new List<FlatUInt64bigint_UNSIGNEDE0M>();
                await ((IUInt64SingleTypebigint_UNSIGNED)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 136, query1, 27, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[30],_testData[34], false);
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
FROM gedaqtests.uint64bigint_unsignede0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatUInt64bigint_UNSIGNEDE0M>();
                var models2 = new List<FlatUInt64bigint_UNSIGNEDE0M>();
                ((IUInt64SingleTypebigint_UNSIGNED)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models1[i],_testData[i], false);
                    FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models2[i],_testData[i], false);
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
FROM gedaqtests.uint64bigint_unsignede0m m
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
FROM gedaqtests.uint64bigint_unsignede0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatUInt64bigint_UNSIGNEDE0M>();
                var firstItems2 = new List<FlatUInt64bigint_UNSIGNEDE0M>();
                var secondItems1 = new List<FlatUInt64bigint_UNSIGNEDE0M>();
                var secondItems2 = new List<FlatUInt64bigint_UNSIGNEDE0M>();
                 ((IUInt64SingleTypebigint_UNSIGNED)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 136, query1, 101, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[14],_testData[34], false);
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
FROM gedaqtests.uint64bigint_unsignede0m m
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
FROM gedaqtests.uint64bigint_unsignede0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatUInt64bigint_UNSIGNEDE0M>();
                var firstItems2 = new List<FlatUInt64bigint_UNSIGNEDE0M>();
                var secondItems1 = new List<FlatUInt64bigint_UNSIGNEDE0M>();
                 ((IUInt64SingleTypebigint_UNSIGNED)this).DbConnectionMMDynQuerySelectModelBatch(connection, 60, query1, 78, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[18],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatUInt64bigint_UNSIGNEDE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt64SingleTypebigint_UNSIGNED)),
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
            asPartInterface: typeof(IUInt64SingleTypebigint_UNSIGNED)),
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
            asPartInterface: typeof(IUInt64SingleTypebigint_UNSIGNED)),
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
FROM gedaqtests.uint64bigint_unsignede0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IUInt64SingleTypebigint_UNSIGNED)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.uint64bigint_unsignede0m m
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
FROM gedaqtests.uint64bigint_unsignede0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IUInt64SingleTypebigint_UNSIGNED)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 56, query1, 56, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[0],_testData[9], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[1],_testData[10], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[2],_testData[11], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[3],_testData[12], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[4],_testData[13], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[5],_testData[14], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[6],_testData[15], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[7],_testData[16], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[8],_testData[17], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[9],_testData[18], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[10],_testData[19], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[11],_testData[20], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[12],_testData[21], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[13],_testData[22], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[14],_testData[23], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[15],_testData[24], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[16],_testData[25], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[17],_testData[26], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[18],_testData[27], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[19],_testData[28], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[20],_testData[29], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[21],_testData[30], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[22],_testData[31], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[23],_testData[32], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[24],_testData[33], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[0],_testData[9], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[1],_testData[10], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[2],_testData[11], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[3],_testData[12], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[4],_testData[13], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[5],_testData[14], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[6],_testData[15], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[7],_testData[16], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[8],_testData[17], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[9],_testData[18], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[10],_testData[19], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[11],_testData[20], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[12],_testData[21], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[13],_testData[22], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[14],_testData[23], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[15],_testData[24], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[16],_testData[25], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[17],_testData[26], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[18],_testData[27], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[19],_testData[28], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[20],_testData[29], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[21],_testData[30], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[22],_testData[31], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[23],_testData[32], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[24],_testData[33], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[25],_testData[34], false);
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
FROM gedaqtests.uint64bigint_unsignede0m m
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
FROM gedaqtests.uint64bigint_unsignede0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatUInt64bigint_UNSIGNEDE0M>();
                var secondItems1 = new List<FlatUInt64bigint_UNSIGNEDE0M>();
                var secondItems2 = new List<FlatUInt64bigint_UNSIGNEDE0M>();
                await ((IUInt64SingleTypebigint_UNSIGNED)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 29, query1, 38, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[28],_testData[34], false);
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
FROM gedaqtests.uint64bigint_unsignede0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IUInt64SingleTypebigint_UNSIGNED)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.uint64bigint_unsignede0m m
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
FROM gedaqtests.uint64bigint_unsignede0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IUInt64SingleTypebigint_UNSIGNED)this).DbConnectionSTDynQuerySelectModelBatch(connection, 95, query1, 60, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[0],_testData[18], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[1],_testData[19], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[2],_testData[20], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[3],_testData[21], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[4],_testData[22], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[5],_testData[23], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[6],_testData[24], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[7],_testData[25], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[8],_testData[26], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[9],_testData[27], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[10],_testData[28], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[11],_testData[29], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[12],_testData[30], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[13],_testData[31], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[14],_testData[32], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[15],_testData[33], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[0],_testData[10], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[1],_testData[11], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[2],_testData[12], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[3],_testData[13], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[4],_testData[14], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[5],_testData[15], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[6],_testData[16], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[7],_testData[17], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[8],_testData[18], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[9],_testData[19], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[10],_testData[20], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[11],_testData[21], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[12],_testData[22], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[13],_testData[23], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[14],_testData[24], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[15],_testData[25], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[16],_testData[26], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[17],_testData[27], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[18],_testData[28], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[19],_testData[29], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[20],_testData[30], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[21],_testData[31], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[22],_testData[32], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[23],_testData[33], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(models[24],_testData[34], false);
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
FROM gedaqtests.uint64bigint_unsignede0m m
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
FROM gedaqtests.uint64bigint_unsignede0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatUInt64bigint_UNSIGNEDE0M>();
                var secondItems1 = new List<FlatUInt64bigint_UNSIGNEDE0M>();
                var secondItems2 = new List<FlatUInt64bigint_UNSIGNEDE0M>();
                 ((IUInt64SingleTypebigint_UNSIGNED)this).DbConnectionDynQuerySelectModelBatch(connection, 109, query1, 71, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(firstItems1[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatUInt64bigint_UNSIGNEDE0M.AssertModel(secondItems2[20],_testData[34], false);
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
FROM gedaqtests.uint64bigint_unsignede0m m
LEFT JOIN gedaqtests.uint64bigint_unsignede0mi mi ON mi.id = m.uint64bigint_unsignede0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(UInt64bigint_UNSIGNEDE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt64SingleTypebigint_UNSIGNED)),
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
            asPartInterface: typeof(IUInt64SingleTypebigint_UNSIGNED)),
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
                var models = await((IUInt64SingleTypebigint_UNSIGNED)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    UInt64bigint_UNSIGNEDE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IUInt64SingleTypebigint_UNSIGNED)this).DbConnectionSTSelectModelBatchAsync(connection, 101, 121))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        UInt64bigint_UNSIGNEDE0M.AssertModel(models[0],_testData[20], false);
                        UInt64bigint_UNSIGNEDE0M.AssertModel(models[1],_testData[21], false);
                        UInt64bigint_UNSIGNEDE0M.AssertModel(models[2],_testData[22], false);
                        UInt64bigint_UNSIGNEDE0M.AssertModel(models[3],_testData[23], false);
                        UInt64bigint_UNSIGNEDE0M.AssertModel(models[4],_testData[24], false);
                        UInt64bigint_UNSIGNEDE0M.AssertModel(models[5],_testData[25], false);
                        UInt64bigint_UNSIGNEDE0M.AssertModel(models[6],_testData[26], false);
                        UInt64bigint_UNSIGNEDE0M.AssertModel(models[7],_testData[27], false);
                        UInt64bigint_UNSIGNEDE0M.AssertModel(models[8],_testData[28], false);
                        UInt64bigint_UNSIGNEDE0M.AssertModel(models[9],_testData[29], false);
                        UInt64bigint_UNSIGNEDE0M.AssertModel(models[10],_testData[30], false);
                        UInt64bigint_UNSIGNEDE0M.AssertModel(models[11],_testData[31], false);
                        UInt64bigint_UNSIGNEDE0M.AssertModel(models[12],_testData[32], false);
                        UInt64bigint_UNSIGNEDE0M.AssertModel(models[13],_testData[33], false);
                        UInt64bigint_UNSIGNEDE0M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        UInt64bigint_UNSIGNEDE0M.AssertModel(models[0],_testData[24], false);
                        UInt64bigint_UNSIGNEDE0M.AssertModel(models[1],_testData[25], false);
                        UInt64bigint_UNSIGNEDE0M.AssertModel(models[2],_testData[26], false);
                        UInt64bigint_UNSIGNEDE0M.AssertModel(models[3],_testData[27], false);
                        UInt64bigint_UNSIGNEDE0M.AssertModel(models[4],_testData[28], false);
                        UInt64bigint_UNSIGNEDE0M.AssertModel(models[5],_testData[29], false);
                        UInt64bigint_UNSIGNEDE0M.AssertModel(models[6],_testData[30], false);
                        UInt64bigint_UNSIGNEDE0M.AssertModel(models[7],_testData[31], false);
                        UInt64bigint_UNSIGNEDE0M.AssertModel(models[8],_testData[32], false);
                        UInt64bigint_UNSIGNEDE0M.AssertModel(models[9],_testData[33], false);
                        UInt64bigint_UNSIGNEDE0M.AssertModel(models[10],_testData[34], false);
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
                var models = ((IUInt64SingleTypebigint_UNSIGNED)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    UInt64bigint_UNSIGNEDE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IUInt64SingleTypebigint_UNSIGNED)this).DbConnectionSTSelectModelBatch(connection, 135, 71))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        UInt64bigint_UNSIGNEDE0M.AssertModel(models[0],_testData[28], false);
                        UInt64bigint_UNSIGNEDE0M.AssertModel(models[1],_testData[29], false);
                        UInt64bigint_UNSIGNEDE0M.AssertModel(models[2],_testData[30], false);
                        UInt64bigint_UNSIGNEDE0M.AssertModel(models[3],_testData[31], false);
                        UInt64bigint_UNSIGNEDE0M.AssertModel(models[4],_testData[32], false);
                        UInt64bigint_UNSIGNEDE0M.AssertModel(models[5],_testData[33], false);
                        UInt64bigint_UNSIGNEDE0M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        UInt64bigint_UNSIGNEDE0M.AssertModel(models[0],_testData[14], false);
                        UInt64bigint_UNSIGNEDE0M.AssertModel(models[1],_testData[15], false);
                        UInt64bigint_UNSIGNEDE0M.AssertModel(models[2],_testData[16], false);
                        UInt64bigint_UNSIGNEDE0M.AssertModel(models[3],_testData[17], false);
                        UInt64bigint_UNSIGNEDE0M.AssertModel(models[4],_testData[18], false);
                        UInt64bigint_UNSIGNEDE0M.AssertModel(models[5],_testData[19], false);
                        UInt64bigint_UNSIGNEDE0M.AssertModel(models[6],_testData[20], false);
                        UInt64bigint_UNSIGNEDE0M.AssertModel(models[7],_testData[21], false);
                        UInt64bigint_UNSIGNEDE0M.AssertModel(models[8],_testData[22], false);
                        UInt64bigint_UNSIGNEDE0M.AssertModel(models[9],_testData[23], false);
                        UInt64bigint_UNSIGNEDE0M.AssertModel(models[10],_testData[24], false);
                        UInt64bigint_UNSIGNEDE0M.AssertModel(models[11],_testData[25], false);
                        UInt64bigint_UNSIGNEDE0M.AssertModel(models[12],_testData[26], false);
                        UInt64bigint_UNSIGNEDE0M.AssertModel(models[13],_testData[27], false);
                        UInt64bigint_UNSIGNEDE0M.AssertModel(models[14],_testData[28], false);
                        UInt64bigint_UNSIGNEDE0M.AssertModel(models[15],_testData[29], false);
                        UInt64bigint_UNSIGNEDE0M.AssertModel(models[16],_testData[30], false);
                        UInt64bigint_UNSIGNEDE0M.AssertModel(models[17],_testData[31], false);
                        UInt64bigint_UNSIGNEDE0M.AssertModel(models[18],_testData[32], false);
                        UInt64bigint_UNSIGNEDE0M.AssertModel(models[19],_testData[33], false);
                        UInt64bigint_UNSIGNEDE0M.AssertModel(models[20],_testData[34], false);
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
                await using var cmd = await ((IUInt64SingleTypebigint_UNSIGNED)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IUInt64SingleTypebigint_UNSIGNED)this).SetDbConnectionSelectModelParametrs(cmd, 161);
                var models = await ((IUInt64SingleTypebigint_UNSIGNED)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(2));

                UInt64bigint_UNSIGNEDE0M.AssertModel(models[0],_testData[33], false);
                UInt64bigint_UNSIGNEDE0M.AssertModel(models[1],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IUInt64SingleTypebigint_UNSIGNED)this).CreateDbConnectionSelectModelCommand(connection);
                ((IUInt64SingleTypebigint_UNSIGNED)this).SetDbConnectionSelectModelParametrs(cmd, 77);
                var models =  ((IUInt64SingleTypebigint_UNSIGNED)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(20));

                UInt64bigint_UNSIGNEDE0M.AssertModel(models[0],_testData[15], false);
                UInt64bigint_UNSIGNEDE0M.AssertModel(models[1],_testData[16], false);
                UInt64bigint_UNSIGNEDE0M.AssertModel(models[2],_testData[17], false);
                UInt64bigint_UNSIGNEDE0M.AssertModel(models[3],_testData[18], false);
                UInt64bigint_UNSIGNEDE0M.AssertModel(models[4],_testData[19], false);
                UInt64bigint_UNSIGNEDE0M.AssertModel(models[5],_testData[20], false);
                UInt64bigint_UNSIGNEDE0M.AssertModel(models[6],_testData[21], false);
                UInt64bigint_UNSIGNEDE0M.AssertModel(models[7],_testData[22], false);
                UInt64bigint_UNSIGNEDE0M.AssertModel(models[8],_testData[23], false);
                UInt64bigint_UNSIGNEDE0M.AssertModel(models[9],_testData[24], false);
                UInt64bigint_UNSIGNEDE0M.AssertModel(models[10],_testData[25], false);
                UInt64bigint_UNSIGNEDE0M.AssertModel(models[11],_testData[26], false);
                UInt64bigint_UNSIGNEDE0M.AssertModel(models[12],_testData[27], false);
                UInt64bigint_UNSIGNEDE0M.AssertModel(models[13],_testData[28], false);
                UInt64bigint_UNSIGNEDE0M.AssertModel(models[14],_testData[29], false);
                UInt64bigint_UNSIGNEDE0M.AssertModel(models[15],_testData[30], false);
                UInt64bigint_UNSIGNEDE0M.AssertModel(models[16],_testData[31], false);
                UInt64bigint_UNSIGNEDE0M.AssertModel(models[17],_testData[32], false);
                UInt64bigint_UNSIGNEDE0M.AssertModel(models[18],_testData[33], false);
                UInt64bigint_UNSIGNEDE0M.AssertModel(models[19],_testData[34], false);
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
FROM gedaqtests.uint64bigint_unsignede0m m
LEFT JOIN gedaqtests.uint64bigint_unsignede0mi mi ON mi.id = m.uint64bigint_unsignede0mi_id
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
            asPartInterface: typeof(IUInt64SingleTypebigint_UNSIGNED))]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IUInt64SingleTypebigint_UNSIGNED)this).DbConnectionSelectModelToObjArrAsync(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((System.UInt64)model[1], Is.EqualTo((3326328208631001546L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((System.UInt64)model[1], Is.EqualTo((1127514237533774558L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2)));//InnerModel.Id
                Assert.That((System.UInt64)model[3], Is.EqualTo((6282174264988682579L)));//InnerModel.Value

                Assert.That((System.UInt64?)model[4], Is.EqualTo((1652782592033677052L)));//InnerModel.NullableValue

                Assert.That((System.UInt64?)model[5], Is.EqualTo((6845555402196836707L)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((System.UInt64)model[1], Is.EqualTo((6427212915278215953L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((System.UInt64)model[1], Is.EqualTo((1563490293556766336L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((System.UInt64)model[3], Is.EqualTo((8822060071849185851L)));//InnerModel.Value

                Assert.That((System.UInt64?)model[4], Is.EqualTo((2309312359655228365L)));//InnerModel.NullableValue

                Assert.That((System.UInt64?)model[5], Is.EqualTo((7413576231313303857L)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((System.UInt64)model[1], Is.EqualTo((3298758737682668171L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt64?)model[5], Is.EqualTo((7689369689221818571L)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((System.UInt64)model[1], Is.EqualTo((3026486277418387449L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((System.UInt64)model[3], Is.EqualTo((2370445187818430655L)));//InnerModel.Value

                Assert.That((System.UInt64?)model[4], Is.EqualTo((2810598740212392790L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((45)));//Id
                Assert.That((System.UInt64)model[1], Is.EqualTo((6728026094780514535L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((System.UInt64)model[1], Is.EqualTo((1257837367529108261L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((System.UInt64)model[3], Is.EqualTo((2155942189478141576L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((System.UInt64)model[1], Is.EqualTo((3033840729745027423L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt64?)model[5], Is.EqualTo((3077534085005806785L)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((System.UInt64)model[1], Is.EqualTo((5379689564092594447L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((System.UInt64)model[3], Is.EqualTo((5353550725416462779L)));//InnerModel.Value

                Assert.That((System.UInt64?)model[4], Is.EqualTo((568717731251499970L)));//InnerModel.NullableValue

                Assert.That((System.UInt64?)model[5], Is.EqualTo((3737809610260592375L)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((System.UInt64)model[1], Is.EqualTo((8421621516787038893L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt64?)model[5], Is.EqualTo((6871880572863193845L)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((System.UInt64)model[1], Is.EqualTo((8596525691144441509L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((System.UInt64)model[3], Is.EqualTo((8334580199061054370L)));//InnerModel.Value

                Assert.That((System.UInt64?)model[4], Is.EqualTo((8952085892780258621L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((System.UInt64)model[1], Is.EqualTo((7296189388543226285L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((System.UInt64)model[1], Is.EqualTo((2697250668770816969L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((System.UInt64)model[3], Is.EqualTo((7902015607753206885L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((System.UInt64)model[1], Is.EqualTo((3936570564336353930L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt64?)model[5], Is.EqualTo((5495031895904028696L)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((78)));//Id
                Assert.That((System.UInt64)model[1], Is.EqualTo((9003084313577550847L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((System.UInt64)model[3], Is.EqualTo((3204769544947305880L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.UInt64?)model[5], Is.EqualTo((4280703425248131737L)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((System.UInt64)model[1], Is.EqualTo((8018200136001252468L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((System.UInt64)model[1], Is.EqualTo((4797708351832694944L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53)));//InnerModel.Id
                Assert.That((System.UInt64)model[3], Is.EqualTo((2763626773298437785L)));//InnerModel.Value

                Assert.That((System.UInt64?)model[4], Is.EqualTo((3836493027312298455L)));//InnerModel.NullableValue

                Assert.That((System.UInt64?)model[5], Is.EqualTo((8957491403673676203L)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((System.UInt64)model[1], Is.EqualTo((71331149550786339L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((System.UInt64)model[1], Is.EqualTo((3988018845933190209L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((62)));//InnerModel.Id
                Assert.That((System.UInt64)model[3], Is.EqualTo((3340125843602037032L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.UInt64?)model[5], Is.EqualTo((6343189747195244967L)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((System.UInt64)model[1], Is.EqualTo((5208473905419004004L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((System.UInt64)model[1], Is.EqualTo((2715150893685755245L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((System.UInt64)model[3], Is.EqualTo((1766011262363382596L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.UInt64?)model[5], Is.EqualTo((7865753651667161403L)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((116)));//Id
                Assert.That((System.UInt64)model[1], Is.EqualTo((2269249044262186228L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt64?)model[5], Is.EqualTo((6193730615459748151L)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((System.UInt64)model[1], Is.EqualTo((5011417220945293241L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((System.UInt64)model[3], Is.EqualTo((631805544336514785L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((System.UInt64)model[1], Is.EqualTo((6694348135678246976L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt64?)model[5], Is.EqualTo((5183874126079044547L)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((System.UInt64)model[1], Is.EqualTo((4273871987419063772L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((75)));//InnerModel.Id
                Assert.That((System.UInt64)model[3], Is.EqualTo((3172012819689408860L)));//InnerModel.Value

                Assert.That((System.UInt64?)model[4], Is.EqualTo((5130819823500163683L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((System.UInt64)model[1], Is.EqualTo((798392558283210322L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((System.UInt64)model[1], Is.EqualTo((2347735583608214873L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((80)));//InnerModel.Id
                Assert.That((System.UInt64)model[3], Is.EqualTo((5552323042583054929L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.UInt64?)model[5], Is.EqualTo((2298512579211727238L)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((System.UInt64)model[1], Is.EqualTo((277844415197176487L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt64?)model[5], Is.EqualTo((5855867403801569571L)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((System.UInt64)model[1], Is.EqualTo((8308520396801473020L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((83)));//InnerModel.Id
                Assert.That((System.UInt64)model[3], Is.EqualTo((3271916870166667180L)));//InnerModel.Value

                Assert.That((System.UInt64?)model[4], Is.EqualTo((2985725830075378474L)));//InnerModel.NullableValue

                Assert.That((System.UInt64?)model[5], Is.EqualTo((1656526844879090432L)));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((System.UInt64)model[1], Is.EqualTo((9151737998775174052L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((152)));//Id
                Assert.That((System.UInt64)model[1], Is.EqualTo((5306241330234387367L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((88)));//InnerModel.Id
                Assert.That((System.UInt64)model[3], Is.EqualTo((1954640464192142710L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.UInt64?)model[5], Is.EqualTo((1536495077208395849L)));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((161)));//Id
                Assert.That((System.UInt64)model[1], Is.EqualTo((803097277718118609L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((170)));//Id
                Assert.That((System.UInt64)model[1], Is.EqualTo((5707304714892995948L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((94)));//InnerModel.Id
                Assert.That((System.UInt64)model[3], Is.EqualTo((7375608255357084109L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.UInt64?)model[5], Is.EqualTo((1503865886987757995L)));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((179)));//Id
                Assert.That((System.UInt64)model[1], Is.EqualTo((579971687958887282L)));//Value

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
                var models =  ((IUInt64SingleTypebigint_UNSIGNED)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((System.UInt64)model[1], Is.EqualTo((3326328208631001546L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((System.UInt64)model[1], Is.EqualTo((1127514237533774558L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2)));//InnerModel.Id
                Assert.That((System.UInt64)model[3], Is.EqualTo((6282174264988682579L)));//InnerModel.Value

                Assert.That((System.UInt64?)model[4], Is.EqualTo((1652782592033677052L)));//InnerModel.NullableValue

                Assert.That((System.UInt64?)model[5], Is.EqualTo((6845555402196836707L)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((System.UInt64)model[1], Is.EqualTo((6427212915278215953L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((System.UInt64)model[1], Is.EqualTo((1563490293556766336L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((System.UInt64)model[3], Is.EqualTo((8822060071849185851L)));//InnerModel.Value

                Assert.That((System.UInt64?)model[4], Is.EqualTo((2309312359655228365L)));//InnerModel.NullableValue

                Assert.That((System.UInt64?)model[5], Is.EqualTo((7413576231313303857L)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((System.UInt64)model[1], Is.EqualTo((3298758737682668171L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt64?)model[5], Is.EqualTo((7689369689221818571L)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((System.UInt64)model[1], Is.EqualTo((3026486277418387449L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((System.UInt64)model[3], Is.EqualTo((2370445187818430655L)));//InnerModel.Value

                Assert.That((System.UInt64?)model[4], Is.EqualTo((2810598740212392790L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((45)));//Id
                Assert.That((System.UInt64)model[1], Is.EqualTo((6728026094780514535L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((System.UInt64)model[1], Is.EqualTo((1257837367529108261L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((System.UInt64)model[3], Is.EqualTo((2155942189478141576L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((System.UInt64)model[1], Is.EqualTo((3033840729745027423L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt64?)model[5], Is.EqualTo((3077534085005806785L)));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((System.UInt64)model[1], Is.EqualTo((5379689564092594447L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((System.UInt64)model[3], Is.EqualTo((5353550725416462779L)));//InnerModel.Value

                Assert.That((System.UInt64?)model[4], Is.EqualTo((568717731251499970L)));//InnerModel.NullableValue

                Assert.That((System.UInt64?)model[5], Is.EqualTo((3737809610260592375L)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((System.UInt64)model[1], Is.EqualTo((8421621516787038893L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt64?)model[5], Is.EqualTo((6871880572863193845L)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((System.UInt64)model[1], Is.EqualTo((8596525691144441509L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((System.UInt64)model[3], Is.EqualTo((8334580199061054370L)));//InnerModel.Value

                Assert.That((System.UInt64?)model[4], Is.EqualTo((8952085892780258621L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((System.UInt64)model[1], Is.EqualTo((7296189388543226285L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((System.UInt64)model[1], Is.EqualTo((2697250668770816969L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((System.UInt64)model[3], Is.EqualTo((7902015607753206885L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((System.UInt64)model[1], Is.EqualTo((3936570564336353930L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt64?)model[5], Is.EqualTo((5495031895904028696L)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((78)));//Id
                Assert.That((System.UInt64)model[1], Is.EqualTo((9003084313577550847L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((System.UInt64)model[3], Is.EqualTo((3204769544947305880L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.UInt64?)model[5], Is.EqualTo((4280703425248131737L)));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((System.UInt64)model[1], Is.EqualTo((8018200136001252468L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((System.UInt64)model[1], Is.EqualTo((4797708351832694944L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53)));//InnerModel.Id
                Assert.That((System.UInt64)model[3], Is.EqualTo((2763626773298437785L)));//InnerModel.Value

                Assert.That((System.UInt64?)model[4], Is.EqualTo((3836493027312298455L)));//InnerModel.NullableValue

                Assert.That((System.UInt64?)model[5], Is.EqualTo((8957491403673676203L)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((System.UInt64)model[1], Is.EqualTo((71331149550786339L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((System.UInt64)model[1], Is.EqualTo((3988018845933190209L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((62)));//InnerModel.Id
                Assert.That((System.UInt64)model[3], Is.EqualTo((3340125843602037032L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.UInt64?)model[5], Is.EqualTo((6343189747195244967L)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((System.UInt64)model[1], Is.EqualTo((5208473905419004004L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((System.UInt64)model[1], Is.EqualTo((2715150893685755245L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((System.UInt64)model[3], Is.EqualTo((1766011262363382596L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.UInt64?)model[5], Is.EqualTo((7865753651667161403L)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((116)));//Id
                Assert.That((System.UInt64)model[1], Is.EqualTo((2269249044262186228L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt64?)model[5], Is.EqualTo((6193730615459748151L)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((System.UInt64)model[1], Is.EqualTo((5011417220945293241L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((System.UInt64)model[3], Is.EqualTo((631805544336514785L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((System.UInt64)model[1], Is.EqualTo((6694348135678246976L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt64?)model[5], Is.EqualTo((5183874126079044547L)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((System.UInt64)model[1], Is.EqualTo((4273871987419063772L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((75)));//InnerModel.Id
                Assert.That((System.UInt64)model[3], Is.EqualTo((3172012819689408860L)));//InnerModel.Value

                Assert.That((System.UInt64?)model[4], Is.EqualTo((5130819823500163683L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((System.UInt64)model[1], Is.EqualTo((798392558283210322L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((System.UInt64)model[1], Is.EqualTo((2347735583608214873L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((80)));//InnerModel.Id
                Assert.That((System.UInt64)model[3], Is.EqualTo((5552323042583054929L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.UInt64?)model[5], Is.EqualTo((2298512579211727238L)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((System.UInt64)model[1], Is.EqualTo((277844415197176487L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.UInt64?)model[5], Is.EqualTo((5855867403801569571L)));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((System.UInt64)model[1], Is.EqualTo((8308520396801473020L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((83)));//InnerModel.Id
                Assert.That((System.UInt64)model[3], Is.EqualTo((3271916870166667180L)));//InnerModel.Value

                Assert.That((System.UInt64?)model[4], Is.EqualTo((2985725830075378474L)));//InnerModel.NullableValue

                Assert.That((System.UInt64?)model[5], Is.EqualTo((1656526844879090432L)));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((System.UInt64)model[1], Is.EqualTo((9151737998775174052L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((152)));//Id
                Assert.That((System.UInt64)model[1], Is.EqualTo((5306241330234387367L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((88)));//InnerModel.Id
                Assert.That((System.UInt64)model[3], Is.EqualTo((1954640464192142710L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.UInt64?)model[5], Is.EqualTo((1536495077208395849L)));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((161)));//Id
                Assert.That((System.UInt64)model[1], Is.EqualTo((803097277718118609L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((170)));//Id
                Assert.That((System.UInt64)model[1], Is.EqualTo((5707304714892995948L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((94)));//InnerModel.Id
                Assert.That((System.UInt64)model[3], Is.EqualTo((7375608255357084109L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.UInt64?)model[5], Is.EqualTo((1503865886987757995L)));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((179)));//Id
                Assert.That((System.UInt64)model[1], Is.EqualTo((579971687958887282L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

#endregion

    }
}

