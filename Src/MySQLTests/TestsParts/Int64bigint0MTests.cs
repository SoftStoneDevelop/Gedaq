

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
    Id = 2,
    Value = 3595072252117834128L,
    ModelInner = null,
    NullableValue = 4536854875028640715L,
},
            new Int64bigint0M
{
    Id = 4,
    Value = 334482684834355245L,
    ModelInner = new Int64bigint0MI
{
    Id = 1,
    Value = 6011383367658642679L,
    NullableValue = null,
},
    NullableValue = 8644961951916957171L,
},
            new Int64bigint0M
{
    Id = 8,
    Value = 6181449129440159477L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 10,
    Value = 7001893967287125171L,
    ModelInner = new Int64bigint0MI
{
    Id = 6,
    Value = 4622435507487760089L,
    NullableValue = 6578045772352047175L,
},
    NullableValue = 7187941771643043960L,
},
            new Int64bigint0M
{
    Id = 12,
    Value = 723996340144205019L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 18,
    Value = 2213206949330839509L,
    ModelInner = new Int64bigint0MI
{
    Id = 8,
    Value = 1753290384050742668L,
    NullableValue = null,
},
    NullableValue = 8761537046019632853L,
},
            new Int64bigint0M
{
    Id = 25,
    Value = 5401749353535565133L,
    ModelInner = null,
    NullableValue = 6913277464432090500L,
},
            new Int64bigint0M
{
    Id = 29,
    Value = 5529018718867568227L,
    ModelInner = new Int64bigint0MI
{
    Id = 13,
    Value = 3211766464428032353L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 35,
    Value = 8072341970734941008L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 38,
    Value = 6072013844308094939L,
    ModelInner = new Int64bigint0MI
{
    Id = 22,
    Value = 2529345234404434319L,
    NullableValue = null,
},
    NullableValue = 2629050892213763983L,
},
            new Int64bigint0M
{
    Id = 46,
    Value = 8838036960964490095L,
    ModelInner = null,
    NullableValue = 8752404449836234190L,
},
            new Int64bigint0M
{
    Id = 52,
    Value = 5875764066786198950L,
    ModelInner = new Int64bigint0MI
{
    Id = 28,
    Value = 6667487347314494241L,
    NullableValue = null,
},
    NullableValue = 4506014050618400495L,
},
            new Int64bigint0M
{
    Id = 53,
    Value = 785930672535008873L,
    ModelInner = null,
    NullableValue = 2029248221621286784L,
},
            new Int64bigint0M
{
    Id = 62,
    Value = 6244150517077916531L,
    ModelInner = new Int64bigint0MI
{
    Id = 30,
    Value = 1682781005624435730L,
    NullableValue = 2693878478453529344L,
},
    NullableValue = 1659197514098691543L,
},
            new Int64bigint0M
{
    Id = 64,
    Value = 660089225838516820L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 65,
    Value = 8407856830189102905L,
    ModelInner = new Int64bigint0MI
{
    Id = 36,
    Value = 5756320557072140687L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 69,
    Value = 4480406854079907558L,
    ModelInner = null,
    NullableValue = 5415623664636054709L,
},
            new Int64bigint0M
{
    Id = 70,
    Value = 4893932740815095535L,
    ModelInner = new Int64bigint0MI
{
    Id = 45,
    Value = 5160585051222668788L,
    NullableValue = 4434105888610029137L,
},
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 72,
    Value = 3716210119740204164L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 73,
    Value = 5206513898505310343L,
    ModelInner = new Int64bigint0MI
{
    Id = 46,
    Value = 2870909537069983693L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 81,
    Value = 807515635920473189L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 86,
    Value = 7826243734103351356L,
    ModelInner = new Int64bigint0MI
{
    Id = 49,
    Value = 2487168136674691603L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 92,
    Value = 1087471944929383076L,
    ModelInner = null,
    NullableValue = 6307205439738066816L,
},
            new Int64bigint0M
{
    Id = 96,
    Value = 6912212980161357986L,
    ModelInner = new Int64bigint0MI
{
    Id = 57,
    Value = 925516241158307326L,
    NullableValue = 9156881629474256152L,
},
    NullableValue = 6069658042067709581L,
},
            new Int64bigint0M
{
    Id = 104,
    Value = 8784918632987881421L,
    ModelInner = null,
    NullableValue = 3324755054237093821L,
},
            new Int64bigint0M
{
    Id = 105,
    Value = 6977115310950339273L,
    ModelInner = new Int64bigint0MI
{
    Id = 63,
    Value = 8831228814689341641L,
    NullableValue = 6410809649179327768L,
},
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 114,
    Value = 8247141970766126259L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 120,
    Value = 9010451340319070771L,
    ModelInner = new Int64bigint0MI
{
    Id = 67,
    Value = 3959706065601924376L,
    NullableValue = null,
},
    NullableValue = 8923369850133355934L,
},
            new Int64bigint0M
{
    Id = 128,
    Value = 8901965639027879329L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 137,
    Value = 9120950771794790361L,
    ModelInner = new Int64bigint0MI
{
    Id = 73,
    Value = 109642874109377302L,
    NullableValue = null,
},
    NullableValue = 8876542714665540055L,
},
            new Int64bigint0M
{
    Id = 141,
    Value = 6746866710020765694L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 145,
    Value = 718587947214455020L,
    ModelInner = new Int64bigint0MI
{
    Id = 81,
    Value = 4115905273586636402L,
    NullableValue = 213657933295951623L,
},
    NullableValue = null,
},
            new Int64bigint0M
{
    Id = 152,
    Value = 5214797318360462524L,
    ModelInner = null,
    NullableValue = 7074991521534419813L,
},
            new Int64bigint0M
{
    Id = 154,
    Value = 624529345318479375L,
    ModelInner = new Int64bigint0MI
{
    Id = 83,
    Value = 2895549351660586883L,
    NullableValue = null,
},
    NullableValue = 3917673822480859126L,
},
            new Int64bigint0M
{
    Id = 157,
    Value = 5326436437368460141L,
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.MySqlConnector.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.int64bigint0mi(
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
            asPartInterface: typeof(IInt64SingleTypebigint)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                parametrName: "id",
                methodParametrName: "id", 
                dbType: (MySqlConnector.MySqlDbType)(3)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int64),
                parametrName: "value",
                methodParametrName: "value",
                dbType: (MySqlConnector.MySqlDbType)(8)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int64?), 
                parametrName: "nullablevalue",
                methodParametrName: "nullablevalue",
                dbType: (MySqlConnector.MySqlDbType)(8))]
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
INSERT INTO gedaqtests.int64bigint0mi(
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
                dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int64), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(12)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int64?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(12), 
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

[Gedaq.MySqlConnector.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.int64bigint0m(
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
            sourceType: SourceType.MySqlConnection,
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (MySqlConnector.MySqlDbType)(3)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int64), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (MySqlConnector.MySqlDbType)(8)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int64?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (MySqlConnector.MySqlDbType)(8),
                nullable: true),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "int64bigint0mi_id", 
                methodParametrName: "int64bigint0mi_id", 
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
INSERT INTO gedaqtests.int64bigint0m(
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
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int64), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(12)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int64?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(12),
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "int64bigint0mi_id", 
                methodParametrName: "int64bigint0mi_id", 
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

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigint0M), typeof(FlatInt64bigint0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
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
FROM gedaqtests.int64bigint0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
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
FROM gedaqtests.int64bigint0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
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

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigint0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
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
FROM gedaqtests.int64bigint0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
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
FROM gedaqtests.int64bigint0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
                var models = ((IInt64SingleTypebigint)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigint0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.int64bigint0m m
LEFT JOIN gedaqtests.int64bigint0mi mi ON mi.id = m.int64bigint0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            sourceType: SourceType.MySqlConnection,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Int64bigint0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
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
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
                var models = ((IInt64SingleTypebigint)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigint0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigint0M), typeof(FlatInt64bigint0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
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
FROM gedaqtests.int64bigint0m m
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
FROM gedaqtests.int64bigint0m m
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

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigint0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
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
FROM gedaqtests.int64bigint0m m
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
FROM gedaqtests.int64bigint0m m
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
FROM gedaqtests.int64bigint0m m
LEFT JOIN gedaqtests.int64bigint0mi mi ON mi.id = m.int64bigint0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            sourceType: SourceType.MySqlConnection,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Int64bigint0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypebigint)),
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
FROM gedaqtests.int64bigint0m m
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
                parametr1.Value = 92;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 4;
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
FROM gedaqtests.int64bigint0m m
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
FROM gedaqtests.int64bigint0m m
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
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatInt64bigint0M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[11],_testData[34], false);
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
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 35;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 128;
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
FROM gedaqtests.int64bigint0m m
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
FROM gedaqtests.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigint0M>();
                var firstItems2 = new List<FlatInt64bigint0M>();
                var secondItems1 = new List<FlatInt64bigint0M>();
                await ((IInt64SingleTypebigint)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[5],_testData[34], false);
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
FROM gedaqtests.int64bigint0m m
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
                parametr1.Value = 10;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 70;
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
FROM gedaqtests.int64bigint0m m
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
FROM gedaqtests.int64bigint0m m
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
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatInt64bigint0M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[30],_testData[34], false);
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

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 70;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 10;
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
FROM gedaqtests.int64bigint0m m
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
FROM gedaqtests.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigint0M>();
                var firstItems2 = new List<FlatInt64bigint0M>();
                var secondItems1 = new List<FlatInt64bigint0M>();
                 ((IInt64SingleTypebigint)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatInt64bigint0M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[30],_testData[34], false);
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
FROM gedaqtests.int64bigint0m m
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
                parametr1.Value = 137;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 18;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.int64bigint0m m
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
FROM gedaqtests.int64bigint0m m
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
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatInt64bigint0M.AssertModel(models[0],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(models[1],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(models[2],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(models[3],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                parametr1.Value = 64;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 29;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.int64bigint0m m
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
FROM gedaqtests.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigint0M>();
                var secondItems1 = new List<FlatInt64bigint0M>();
                var secondItems2 = new List<FlatInt64bigint0M>();
                await ((IInt64SingleTypebigint)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                        FlatInt64bigint0M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[26],_testData[34], false);
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
FROM gedaqtests.int64bigint0m m
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
                parametr1.Value = 152;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 52;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.int64bigint0m m
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
FROM gedaqtests.int64bigint0m m
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
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatInt64bigint0M.AssertModel(models[0],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatInt64bigint0M.AssertModel(models[0],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(models[1],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(models[2],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(models[3],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(models[4],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(models[5],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(models[6],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(models[7],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(models[8],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(models[9],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(models[10],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(models[11],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(models[12],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(models[13],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(models[14],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(models[15],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(models[16],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(models[17],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(models[18],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(models[19],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(models[20],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(models[21],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(models[22],_testData[34], false);
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
                parametr1.Value = 69;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 10;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.int64bigint0m m
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
FROM gedaqtests.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigint0M>();
                var secondItems1 = new List<FlatInt64bigint0M>();
                var secondItems2 = new List<FlatInt64bigint0M>();
                 ((IInt64SingleTypebigint)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                        FlatInt64bigint0M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[17],_testData[34], false);
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
FROM gedaqtests.int64bigint0m m
LEFT JOIN gedaqtests.int64bigint0mi mi ON mi.id = m.int64bigint0mi_id
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
                parametr1.Value = 137;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 137;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64SingleTypebigint)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
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
                parametr1.Value = 141;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 18;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64SingleTypebigint)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        Int64bigint0M.AssertModel(models[0],_testData[31], false);
                        Int64bigint0M.AssertModel(models[1],_testData[32], false);
                        Int64bigint0M.AssertModel(models[2],_testData[33], false);
                        Int64bigint0M.AssertModel(models[3],_testData[34], false);
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
            dbType: (System.Data.DbType)(11))]
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
FROM gedaqtests.int64bigint0m m
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
FROM gedaqtests.int64bigint0m m
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
FROM gedaqtests.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigint0M>();
                var firstItems2 = new List<FlatInt64bigint0M>();
                var secondItems1 = new List<FlatInt64bigint0M>();
                var secondItems2 = new List<FlatInt64bigint0M>();
                await ((IInt64SingleTypebigint)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 120, query1, 18, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
FROM gedaqtests.int64bigint0m m
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
FROM gedaqtests.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigint0M>();
                var firstItems2 = new List<FlatInt64bigint0M>();
                var secondItems1 = new List<FlatInt64bigint0M>();
                await ((IInt64SingleTypebigint)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 8, query1, 137, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatInt64bigint0M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[4],_testData[34], false);
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
FROM gedaqtests.int64bigint0m m
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
FROM gedaqtests.int64bigint0m m
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
FROM gedaqtests.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigint0M>();
                var firstItems2 = new List<FlatInt64bigint0M>();
                var secondItems1 = new List<FlatInt64bigint0M>();
                var secondItems2 = new List<FlatInt64bigint0M>();
                 ((IInt64SingleTypebigint)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 25, query1, 81, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatInt64bigint0M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatInt64bigint0M.AssertModel(firstItems2[27],_testData[34], false);
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
FROM gedaqtests.int64bigint0m m
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
FROM gedaqtests.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigint0M>();
                var firstItems2 = new List<FlatInt64bigint0M>();
                var secondItems1 = new List<FlatInt64bigint0M>();
                 ((IInt64SingleTypebigint)this).DbConnectionMMDynQuerySelectModelBatch(connection, 128, query1, 81, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[13],_testData[34], false);
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
            dbType: (System.Data.DbType)(11))]
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
FROM gedaqtests.int64bigint0m m
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
FROM gedaqtests.int64bigint0m m
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
FROM gedaqtests.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64SingleTypebigint)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 52, query1, 53, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatInt64bigint0M.AssertModel(models[0],_testData[12], false);
                        FlatInt64bigint0M.AssertModel(models[1],_testData[13], false);
                        FlatInt64bigint0M.AssertModel(models[2],_testData[14], false);
                        FlatInt64bigint0M.AssertModel(models[3],_testData[15], false);
                        FlatInt64bigint0M.AssertModel(models[4],_testData[16], false);
                        FlatInt64bigint0M.AssertModel(models[5],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(models[6],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(models[7],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(models[8],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(models[9],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(models[10],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(models[11],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(models[12],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(models[13],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(models[14],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(models[15],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(models[16],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(models[17],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(models[18],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(models[19],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(models[20],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(models[21],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(models[22],_testData[34], false);
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
FROM gedaqtests.int64bigint0m m
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
FROM gedaqtests.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigint0M>();
                var secondItems1 = new List<FlatInt64bigint0M>();
                var secondItems2 = new List<FlatInt64bigint0M>();
                await ((IInt64SingleTypebigint)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 120, query1, 120, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatInt64bigint0M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatInt64bigint0M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatInt64bigint0M.AssertModel(secondItems2[6],_testData[34], false);
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
FROM gedaqtests.int64bigint0m m
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
FROM gedaqtests.int64bigint0m m
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
FROM gedaqtests.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64SingleTypebigint)this).DbConnectionSTDynQuerySelectModelBatch(connection, 10, query1, 18, query2))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
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
FROM gedaqtests.int64bigint0m m
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
FROM gedaqtests.int64bigint0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigint0M>();
                var secondItems1 = new List<FlatInt64bigint0M>();
                var secondItems2 = new List<FlatInt64bigint0M>();
                 ((IInt64SingleTypebigint)this).DbConnectionDynQuerySelectModelBatch(connection, 69, query1, 10, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                        FlatInt64bigint0M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatInt64bigint0M.AssertModel(firstItems1[17],_testData[34], false);
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
FROM gedaqtests.int64bigint0m m
LEFT JOIN gedaqtests.int64bigint0mi mi ON mi.id = m.int64bigint0mi_id
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
            dbType: (System.Data.DbType)(11))]
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
                foreach(var batchResult in await ((IInt64SingleTypebigint)this).DbConnectionSTSelectModelBatchAsync(connection, 25, 70))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
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
                foreach(var batchResult in  ((IInt64SingleTypebigint)this).DbConnectionSTSelectModelBatch(connection, 38, 96))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        Int64bigint0M.AssertModel(models[0],_testData[24], false);
                        Int64bigint0M.AssertModel(models[1],_testData[25], false);
                        Int64bigint0M.AssertModel(models[2],_testData[26], false);
                        Int64bigint0M.AssertModel(models[3],_testData[27], false);
                        Int64bigint0M.AssertModel(models[4],_testData[28], false);
                        Int64bigint0M.AssertModel(models[5],_testData[29], false);
                        Int64bigint0M.AssertModel(models[6],_testData[30], false);
                        Int64bigint0M.AssertModel(models[7],_testData[31], false);
                        Int64bigint0M.AssertModel(models[8],_testData[32], false);
                        Int64bigint0M.AssertModel(models[9],_testData[33], false);
                        Int64bigint0M.AssertModel(models[10],_testData[34], false);
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
                ((IInt64SingleTypebigint)this).SetDbConnectionSelectModelParametrs(cmd, 29);
                var models = await ((IInt64SingleTypebigint)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

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
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt64SingleTypebigint)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt64SingleTypebigint)this).SetDbConnectionSelectModelParametrs(cmd, 81);
                var models =  ((IInt64SingleTypebigint)this).ExecuteDbConnectionSelectModelCommand(cmd);

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
FROM gedaqtests.int64bigint0m m
LEFT JOIN gedaqtests.int64bigint0mi mi ON mi.id = m.int64bigint0mi_id
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
                Assert.That((System.Int32)model[0], Is.EqualTo((2)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3595072252117834128L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((4536854875028640715L)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((4)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((334482684834355245L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((6011383367658642679L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((8644961951916957171L)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6181449129440159477L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7001893967287125171L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((4622435507487760089L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((6578045772352047175L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((7187941771643043960L)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((723996340144205019L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2213206949330839509L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((1753290384050742668L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((8761537046019632853L)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5401749353535565133L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((6913277464432090500L)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5529018718867568227L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((3211766464428032353L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8072341970734941008L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6072013844308094939L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((2529345234404434319L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((2629050892213763983L)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8838036960964490095L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((8752404449836234190L)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5875764066786198950L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((6667487347314494241L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((4506014050618400495L)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((53)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((785930672535008873L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((2029248221621286784L)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6244150517077916531L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((1682781005624435730L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((2693878478453529344L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((1659197514098691543L)));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((660089225838516820L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8407856830189102905L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((5756320557072140687L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4480406854079907558L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((5415623664636054709L)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4893932740815095535L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((5160585051222668788L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((4434105888610029137L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3716210119740204164L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5206513898505310343L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((2870909537069983693L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((807515635920473189L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7826243734103351356L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((2487168136674691603L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1087471944929383076L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((6307205439738066816L)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((96)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6912212980161357986L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((925516241158307326L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((9156881629474256152L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((6069658042067709581L)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8784918632987881421L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((3324755054237093821L)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6977115310950339273L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((8831228814689341641L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((6410809649179327768L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8247141970766126259L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((9010451340319070771L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((67)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((3959706065601924376L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((8923369850133355934L)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8901965639027879329L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((9120950771794790361L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((73)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((109642874109377302L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((8876542714665540055L)));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6746866710020765694L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((145)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((718587947214455020L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((81)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((4115905273586636402L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((213657933295951623L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((152)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5214797318360462524L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((7074991521534419813L)));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((624529345318479375L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((83)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((2895549351660586883L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((3917673822480859126L)));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((157)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5326436437368460141L)));//Value

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
                Assert.That((System.Int32)model[0], Is.EqualTo((2)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3595072252117834128L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((4536854875028640715L)));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((4)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((334482684834355245L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((6011383367658642679L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((8644961951916957171L)));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6181449129440159477L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7001893967287125171L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((4622435507487760089L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((6578045772352047175L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((7187941771643043960L)));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((723996340144205019L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2213206949330839509L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((1753290384050742668L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((8761537046019632853L)));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5401749353535565133L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((6913277464432090500L)));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5529018718867568227L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((3211766464428032353L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8072341970734941008L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6072013844308094939L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((2529345234404434319L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((2629050892213763983L)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8838036960964490095L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((8752404449836234190L)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5875764066786198950L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((6667487347314494241L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((4506014050618400495L)));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((53)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((785930672535008873L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((2029248221621286784L)));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6244150517077916531L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((1682781005624435730L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((2693878478453529344L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((1659197514098691543L)));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((660089225838516820L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8407856830189102905L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((5756320557072140687L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4480406854079907558L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((5415623664636054709L)));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4893932740815095535L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((5160585051222668788L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((4434105888610029137L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3716210119740204164L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5206513898505310343L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((2870909537069983693L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((807515635920473189L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7826243734103351356L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((2487168136674691603L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1087471944929383076L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((6307205439738066816L)));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((96)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6912212980161357986L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((925516241158307326L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((9156881629474256152L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((6069658042067709581L)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8784918632987881421L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((3324755054237093821L)));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6977115310950339273L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((8831228814689341641L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((6410809649179327768L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8247141970766126259L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((9010451340319070771L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((67)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((3959706065601924376L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((8923369850133355934L)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8901965639027879329L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((9120950771794790361L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((73)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((109642874109377302L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((8876542714665540055L)));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6746866710020765694L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((145)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((718587947214455020L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((81)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((4115905273586636402L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((213657933295951623L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((152)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5214797318360462524L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((7074991521534419813L)));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((624529345318479375L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((83)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((2895549351660586883L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((3917673822480859126L)));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((157)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5326436437368460141L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

#endregion

    }
}

