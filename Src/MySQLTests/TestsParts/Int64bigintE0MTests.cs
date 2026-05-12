

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

        private readonly Int64bigintE0M[] _testData = new Int64bigintE0M[]
        {
            new Int64bigintE0M
{
    Id = 8,
    Value = 5059952617398825947L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 17,
    Value = 8118856946259347614L,
    ModelInner = new Int64bigintE0MI
{
    Id = 2,
    Value = 2358445248609101590L,
    NullableValue = 6419034339145376809L,
},
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 23,
    Value = 671839315697464531L,
    ModelInner = null,
    NullableValue = 6526333354968588160L,
},
            new Int64bigintE0M
{
    Id = 26,
    Value = 6496934805497218355L,
    ModelInner = new Int64bigintE0MI
{
    Id = 5,
    Value = 893071040213952016L,
    NullableValue = 5245256143563569281L,
},
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 32,
    Value = 8727874482929245263L,
    ModelInner = null,
    NullableValue = 9050800538629851831L,
},
            new Int64bigintE0M
{
    Id = 38,
    Value = 757552084467895738L,
    ModelInner = new Int64bigintE0MI
{
    Id = 6,
    Value = 8002007889372855409L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 39,
    Value = 4991045700359874785L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 40,
    Value = 2228819512395397506L,
    ModelInner = new Int64bigintE0MI
{
    Id = 15,
    Value = 6925109452147023162L,
    NullableValue = 8621232426652486881L,
},
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 46,
    Value = 6453978269851780631L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 51,
    Value = 3762585043807046161L,
    ModelInner = new Int64bigintE0MI
{
    Id = 20,
    Value = 1439843117132539604L,
    NullableValue = null,
},
    NullableValue = 7238499288793909537L,
},
            new Int64bigintE0M
{
    Id = 54,
    Value = 8038551632354852541L,
    ModelInner = null,
    NullableValue = 8449644788244418369L,
},
            new Int64bigintE0M
{
    Id = 60,
    Value = 1844464147316667208L,
    ModelInner = new Int64bigintE0MI
{
    Id = 27,
    Value = 7377703745783711930L,
    NullableValue = 5733008115552139425L,
},
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 69,
    Value = 8255794139011061236L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 70,
    Value = 130843974774891014L,
    ModelInner = new Int64bigintE0MI
{
    Id = 31,
    Value = 5416363897243163281L,
    NullableValue = 8117267670627825216L,
},
    NullableValue = 149873974026098260L,
},
            new Int64bigintE0M
{
    Id = 79,
    Value = 6090394813017037204L,
    ModelInner = null,
    NullableValue = 4521596023684845638L,
},
            new Int64bigintE0M
{
    Id = 84,
    Value = 6156377755482132227L,
    ModelInner = new Int64bigintE0MI
{
    Id = 34,
    Value = 4318171034236298042L,
    NullableValue = 6781781922769673322L,
},
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 88,
    Value = 8662937837891595707L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 89,
    Value = 482489240782745980L,
    ModelInner = new Int64bigintE0MI
{
    Id = 35,
    Value = 8882473057392273425L,
    NullableValue = null,
},
    NullableValue = 1824062239683600221L,
},
            new Int64bigintE0M
{
    Id = 94,
    Value = 7543368266882243299L,
    ModelInner = null,
    NullableValue = 5502460261035936995L,
},
            new Int64bigintE0M
{
    Id = 100,
    Value = 4260746103674920957L,
    ModelInner = new Int64bigintE0MI
{
    Id = 44,
    Value = 2796554700084526155L,
    NullableValue = 1602577112978248590L,
},
    NullableValue = 735866119953798645L,
},
            new Int64bigintE0M
{
    Id = 102,
    Value = 4057755191846580771L,
    ModelInner = null,
    NullableValue = 4208787093822722750L,
},
            new Int64bigintE0M
{
    Id = 108,
    Value = 8643234341541680227L,
    ModelInner = new Int64bigintE0MI
{
    Id = 47,
    Value = 2981002927394509568L,
    NullableValue = null,
},
    NullableValue = 1098968277245301398L,
},
            new Int64bigintE0M
{
    Id = 110,
    Value = 2628635613804644487L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 114,
    Value = 1749391339348098757L,
    ModelInner = new Int64bigintE0MI
{
    Id = 48,
    Value = 1002031698921414992L,
    NullableValue = 288899569129919617L,
},
    NullableValue = 6244509637832299583L,
},
            new Int64bigintE0M
{
    Id = 123,
    Value = 3306418861507276268L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 128,
    Value = 6930374531982968529L,
    ModelInner = new Int64bigintE0MI
{
    Id = 55,
    Value = 9182457759791817714L,
    NullableValue = 4020131733005238495L,
},
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 134,
    Value = 4557073371804029450L,
    ModelInner = null,
    NullableValue = 1129304843711915883L,
},
            new Int64bigintE0M
{
    Id = 135,
    Value = 4310972046623527925L,
    ModelInner = new Int64bigintE0MI
{
    Id = 59,
    Value = 7299393778034594528L,
    NullableValue = 6208523174708119354L,
},
    NullableValue = 947055267873806241L,
},
            new Int64bigintE0M
{
    Id = 136,
    Value = 2136256116176096594L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 137,
    Value = 960583294471664678L,
    ModelInner = new Int64bigintE0MI
{
    Id = 66,
    Value = 597683205838638978L,
    NullableValue = 1228910243741071838L,
},
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 143,
    Value = 5839090589089144434L,
    ModelInner = null,
    NullableValue = 72128488355428791L,
},
            new Int64bigintE0M
{
    Id = 151,
    Value = 940166765585990329L,
    ModelInner = new Int64bigintE0MI
{
    Id = 67,
    Value = 4623873291471983547L,
    NullableValue = 9177917057610149951L,
},
    NullableValue = 719552006346694160L,
},
            new Int64bigintE0M
{
    Id = 159,
    Value = 7712218765575776369L,
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 165,
    Value = 871427361016662963L,
    ModelInner = new Int64bigintE0MI
{
    Id = 73,
    Value = 6381780960382146312L,
    NullableValue = 1964543092109546636L,
},
    NullableValue = null,
},
            new Int64bigintE0M
{
    Id = 172,
    Value = 8144919532128545839L,
    ModelInner = null,
    NullableValue = 4352324657457291651L,
},
        };

#endregion

#region InsertModelInner

[Gedaq.MySqlConnector.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.int64biginte0mi(
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
INSERT INTO gedaqtests.int64biginte0mi(
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
INSERT INTO gedaqtests.int64biginte0m(
	id,
    value,
    nullablevalue,
    int64biginte0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @int64biginte0mi_id
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
                parametrName: "int64biginte0mi_id", 
                methodParametrName: "int64biginte0mi_id", 
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
INSERT INTO gedaqtests.int64biginte0m(
	id,
    value,
    nullablevalue,
    int64biginte0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @int64biginte0mi_id
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
                parametrName: "int64biginte0mi_id", 
                methodParametrName: "int64biginte0mi_id", 
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
            queryMapTypes: [typeof(FlatInt64bigintE0M), typeof(FlatInt64bigintE0M)],
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
FROM gedaqtests.int64biginte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
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
FROM gedaqtests.int64biginte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
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

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintE0M)],
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
FROM gedaqtests.int64biginte0m m
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
FROM gedaqtests.int64biginte0m m
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
                    FlatInt64bigintE0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.int64biginte0m m
LEFT JOIN gedaqtests.int64biginte0mi mi ON mi.id = m.int64biginte0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            sourceType: SourceType.MySqlConnection,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Int64bigintE0M)],
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
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
                var models = ((IInt64SingleTypebigint)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintE0M), typeof(FlatInt64bigintE0M)],
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
FROM gedaqtests.int64biginte0m m
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
FROM gedaqtests.int64biginte0m m
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

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintE0M)],
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
FROM gedaqtests.int64biginte0m m
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
FROM gedaqtests.int64biginte0m m
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
FROM gedaqtests.int64biginte0m m
LEFT JOIN gedaqtests.int64biginte0mi mi ON mi.id = m.int64biginte0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            sourceType: SourceType.MySqlConnection,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Int64bigintE0M)],
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
FROM gedaqtests.int64biginte0m m
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
                parametr1.Value = 69;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 137;
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
FROM gedaqtests.int64biginte0m m
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
FROM gedaqtests.int64biginte0m m
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
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatInt64bigintE0M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatInt64bigintE0M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[4],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 79;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 69;
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
FROM gedaqtests.int64biginte0m m
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
FROM gedaqtests.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintE0M>();
                var firstItems2 = new List<FlatInt64bigintE0M>();
                var secondItems1 = new List<FlatInt64bigintE0M>();
                await ((IInt64SingleTypebigint)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatInt64bigintE0M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatInt64bigintE0M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[21],_testData[34], false);
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
FROM gedaqtests.int64biginte0m m
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
                parametr1.Value = 39;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 102;
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
FROM gedaqtests.int64biginte0m m
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
FROM gedaqtests.int64biginte0m m
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
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatInt64bigintE0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[13],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 17;
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
FROM gedaqtests.int64biginte0m m
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
FROM gedaqtests.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintE0M>();
                var firstItems2 = new List<FlatInt64bigintE0M>();
                var secondItems1 = new List<FlatInt64bigintE0M>();
                 ((IInt64SingleTypebigint)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatInt64bigintE0M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                        FlatInt64bigintE0M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[31],_testData[34], false);
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
FROM gedaqtests.int64biginte0m m
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
                parametr1.Value = 46;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 40;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.int64biginte0m m
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
FROM gedaqtests.int64biginte0m m
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

                    if(resultIndex == 2)
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
                parametr1.Value = 143;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 38;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.int64biginte0m m
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
FROM gedaqtests.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintE0M>();
                var secondItems1 = new List<FlatInt64bigintE0M>();
                var secondItems2 = new List<FlatInt64bigintE0M>();
                await ((IInt64SingleTypebigint)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatInt64bigintE0M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[3],_testData[34], false);
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
FROM gedaqtests.int64biginte0m m
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
                parametr1.Value = 108;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 159;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.int64biginte0m m
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
FROM gedaqtests.int64biginte0m m
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
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatInt64bigintE0M.AssertModel(models[0],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(models[1],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(models[2],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(models[3],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(models[4],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(models[5],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(models[6],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(models[7],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(models[8],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(models[9],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(models[10],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(models[11],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatInt64bigintE0M.AssertModel(models[0],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(models[1],_testData[34], false);
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
                parametr1.Value = 54;
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
FROM gedaqtests.int64biginte0m m
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
FROM gedaqtests.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintE0M>();
                var secondItems1 = new List<FlatInt64bigintE0M>();
                var secondItems2 = new List<FlatInt64bigintE0M>();
                 ((IInt64SingleTypebigint)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatInt64bigintE0M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatInt64bigintE0M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[5],_testData[34], false);
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
FROM gedaqtests.int64biginte0m m
LEFT JOIN gedaqtests.int64biginte0mi mi ON mi.id = m.int64biginte0mi_id
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
                parametr1.Value = 39;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 39;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64SingleTypebigint)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        Int64bigintE0M.AssertModel(models[0],_testData[7], false);
                        Int64bigintE0M.AssertModel(models[1],_testData[8], false);
                        Int64bigintE0M.AssertModel(models[2],_testData[9], false);
                        Int64bigintE0M.AssertModel(models[3],_testData[10], false);
                        Int64bigintE0M.AssertModel(models[4],_testData[11], false);
                        Int64bigintE0M.AssertModel(models[5],_testData[12], false);
                        Int64bigintE0M.AssertModel(models[6],_testData[13], false);
                        Int64bigintE0M.AssertModel(models[7],_testData[14], false);
                        Int64bigintE0M.AssertModel(models[8],_testData[15], false);
                        Int64bigintE0M.AssertModel(models[9],_testData[16], false);
                        Int64bigintE0M.AssertModel(models[10],_testData[17], false);
                        Int64bigintE0M.AssertModel(models[11],_testData[18], false);
                        Int64bigintE0M.AssertModel(models[12],_testData[19], false);
                        Int64bigintE0M.AssertModel(models[13],_testData[20], false);
                        Int64bigintE0M.AssertModel(models[14],_testData[21], false);
                        Int64bigintE0M.AssertModel(models[15],_testData[22], false);
                        Int64bigintE0M.AssertModel(models[16],_testData[23], false);
                        Int64bigintE0M.AssertModel(models[17],_testData[24], false);
                        Int64bigintE0M.AssertModel(models[18],_testData[25], false);
                        Int64bigintE0M.AssertModel(models[19],_testData[26], false);
                        Int64bigintE0M.AssertModel(models[20],_testData[27], false);
                        Int64bigintE0M.AssertModel(models[21],_testData[28], false);
                        Int64bigintE0M.AssertModel(models[22],_testData[29], false);
                        Int64bigintE0M.AssertModel(models[23],_testData[30], false);
                        Int64bigintE0M.AssertModel(models[24],_testData[31], false);
                        Int64bigintE0M.AssertModel(models[25],_testData[32], false);
                        Int64bigintE0M.AssertModel(models[26],_testData[33], false);
                        Int64bigintE0M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        Int64bigintE0M.AssertModel(models[0],_testData[7], false);
                        Int64bigintE0M.AssertModel(models[1],_testData[8], false);
                        Int64bigintE0M.AssertModel(models[2],_testData[9], false);
                        Int64bigintE0M.AssertModel(models[3],_testData[10], false);
                        Int64bigintE0M.AssertModel(models[4],_testData[11], false);
                        Int64bigintE0M.AssertModel(models[5],_testData[12], false);
                        Int64bigintE0M.AssertModel(models[6],_testData[13], false);
                        Int64bigintE0M.AssertModel(models[7],_testData[14], false);
                        Int64bigintE0M.AssertModel(models[8],_testData[15], false);
                        Int64bigintE0M.AssertModel(models[9],_testData[16], false);
                        Int64bigintE0M.AssertModel(models[10],_testData[17], false);
                        Int64bigintE0M.AssertModel(models[11],_testData[18], false);
                        Int64bigintE0M.AssertModel(models[12],_testData[19], false);
                        Int64bigintE0M.AssertModel(models[13],_testData[20], false);
                        Int64bigintE0M.AssertModel(models[14],_testData[21], false);
                        Int64bigintE0M.AssertModel(models[15],_testData[22], false);
                        Int64bigintE0M.AssertModel(models[16],_testData[23], false);
                        Int64bigintE0M.AssertModel(models[17],_testData[24], false);
                        Int64bigintE0M.AssertModel(models[18],_testData[25], false);
                        Int64bigintE0M.AssertModel(models[19],_testData[26], false);
                        Int64bigintE0M.AssertModel(models[20],_testData[27], false);
                        Int64bigintE0M.AssertModel(models[21],_testData[28], false);
                        Int64bigintE0M.AssertModel(models[22],_testData[29], false);
                        Int64bigintE0M.AssertModel(models[23],_testData[30], false);
                        Int64bigintE0M.AssertModel(models[24],_testData[31], false);
                        Int64bigintE0M.AssertModel(models[25],_testData[32], false);
                        Int64bigintE0M.AssertModel(models[26],_testData[33], false);
                        Int64bigintE0M.AssertModel(models[27],_testData[34], false);
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
                parametr1.Value = 70;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 110;
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
                        Assert.That(models, Has.Count.EqualTo(12));

                        Int64bigintE0M.AssertModel(models[0],_testData[23], false);
                        Int64bigintE0M.AssertModel(models[1],_testData[24], false);
                        Int64bigintE0M.AssertModel(models[2],_testData[25], false);
                        Int64bigintE0M.AssertModel(models[3],_testData[26], false);
                        Int64bigintE0M.AssertModel(models[4],_testData[27], false);
                        Int64bigintE0M.AssertModel(models[5],_testData[28], false);
                        Int64bigintE0M.AssertModel(models[6],_testData[29], false);
                        Int64bigintE0M.AssertModel(models[7],_testData[30], false);
                        Int64bigintE0M.AssertModel(models[8],_testData[31], false);
                        Int64bigintE0M.AssertModel(models[9],_testData[32], false);
                        Int64bigintE0M.AssertModel(models[10],_testData[33], false);
                        Int64bigintE0M.AssertModel(models[11],_testData[34], false);
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
FROM gedaqtests.int64biginte0m m
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
FROM gedaqtests.int64biginte0m m
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
FROM gedaqtests.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintE0M>();
                var firstItems2 = new List<FlatInt64bigintE0M>();
                var secondItems1 = new List<FlatInt64bigintE0M>();
                var secondItems2 = new List<FlatInt64bigintE0M>();
                await ((IInt64SingleTypebigint)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 135, query1, 123, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatInt64bigintE0M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[9],_testData[34], false);
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
FROM gedaqtests.int64biginte0m m
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
FROM gedaqtests.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintE0M>();
                var firstItems2 = new List<FlatInt64bigintE0M>();
                var secondItems1 = new List<FlatInt64bigintE0M>();
                await ((IInt64SingleTypebigint)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 89, query1, 110, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatInt64bigintE0M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatInt64bigintE0M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[11],_testData[34], false);
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
FROM gedaqtests.int64biginte0m m
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
FROM gedaqtests.int64biginte0m m
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
FROM gedaqtests.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintE0M>();
                var firstItems2 = new List<FlatInt64bigintE0M>();
                var secondItems1 = new List<FlatInt64bigintE0M>();
                var secondItems2 = new List<FlatInt64bigintE0M>();
                 ((IInt64SingleTypebigint)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 39, query1, 17, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatInt64bigintE0M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[32],_testData[34], false);
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
FROM gedaqtests.int64biginte0m m
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
FROM gedaqtests.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintE0M>();
                var firstItems2 = new List<FlatInt64bigintE0M>();
                var secondItems1 = new List<FlatInt64bigintE0M>();
                 ((IInt64SingleTypebigint)this).DbConnectionMMDynQuerySelectModelBatch(connection, 69, query1, 51, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatInt64bigintE0M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatInt64bigintE0M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[24],_testData[34], false);
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
FROM gedaqtests.int64biginte0m m
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
FROM gedaqtests.int64biginte0m m
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
FROM gedaqtests.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64SingleTypebigint)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 100, query1, 110, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatInt64bigintE0M.AssertModel(models[0],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(models[1],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(models[2],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(models[3],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(models[4],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(models[5],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(models[6],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(models[7],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(models[8],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(models[9],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(models[10],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(models[11],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(models[12],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(models[13],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatInt64bigintE0M.AssertModel(models[0],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(models[1],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(models[2],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(models[3],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(models[4],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(models[5],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(models[6],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(models[7],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(models[8],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(models[9],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(models[10],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(models[11],_testData[34], false);
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
FROM gedaqtests.int64biginte0m m
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
FROM gedaqtests.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintE0M>();
                var secondItems1 = new List<FlatInt64bigintE0M>();
                var secondItems2 = new List<FlatInt64bigintE0M>();
                await ((IInt64SingleTypebigint)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 151, query1, 134, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatInt64bigintE0M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[2],_testData[34], false);
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
FROM gedaqtests.int64biginte0m m
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
FROM gedaqtests.int64biginte0m m
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
FROM gedaqtests.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64SingleTypebigint)this).DbConnectionSTDynQuerySelectModelBatch(connection, 46, query1, 38, query2))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatInt64bigintE0M.AssertModel(models[0],_testData[6], false);
                        FlatInt64bigintE0M.AssertModel(models[1],_testData[7], false);
                        FlatInt64bigintE0M.AssertModel(models[2],_testData[8], false);
                        FlatInt64bigintE0M.AssertModel(models[3],_testData[9], false);
                        FlatInt64bigintE0M.AssertModel(models[4],_testData[10], false);
                        FlatInt64bigintE0M.AssertModel(models[5],_testData[11], false);
                        FlatInt64bigintE0M.AssertModel(models[6],_testData[12], false);
                        FlatInt64bigintE0M.AssertModel(models[7],_testData[13], false);
                        FlatInt64bigintE0M.AssertModel(models[8],_testData[14], false);
                        FlatInt64bigintE0M.AssertModel(models[9],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(models[10],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(models[11],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(models[12],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(models[13],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(models[14],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(models[15],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(models[16],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(models[17],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(models[18],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(models[19],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(models[20],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(models[21],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(models[22],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(models[23],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(models[24],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(models[25],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(models[26],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(models[27],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(models[28],_testData[34], false);
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
FROM gedaqtests.int64biginte0m m
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
FROM gedaqtests.int64biginte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintE0M>();
                var secondItems1 = new List<FlatInt64bigintE0M>();
                var secondItems2 = new List<FlatInt64bigintE0M>();
                 ((IInt64SingleTypebigint)this).DbConnectionDynQuerySelectModelBatch(connection, 134, query1, 79, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatInt64bigintE0M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(firstItems1[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatInt64bigintE0M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatInt64bigintE0M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatInt64bigintE0M.AssertModel(secondItems2[19],_testData[34], false);
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
FROM gedaqtests.int64biginte0m m
LEFT JOIN gedaqtests.int64biginte0mi mi ON mi.id = m.int64biginte0mi_id
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
                foreach(var batchResult in await ((IInt64SingleTypebigint)this).DbConnectionSTSelectModelBatchAsync(connection, 123, 100))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        Int64bigintE0M.AssertModel(models[0],_testData[25], false);
                        Int64bigintE0M.AssertModel(models[1],_testData[26], false);
                        Int64bigintE0M.AssertModel(models[2],_testData[27], false);
                        Int64bigintE0M.AssertModel(models[3],_testData[28], false);
                        Int64bigintE0M.AssertModel(models[4],_testData[29], false);
                        Int64bigintE0M.AssertModel(models[5],_testData[30], false);
                        Int64bigintE0M.AssertModel(models[6],_testData[31], false);
                        Int64bigintE0M.AssertModel(models[7],_testData[32], false);
                        Int64bigintE0M.AssertModel(models[8],_testData[33], false);
                        Int64bigintE0M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        Int64bigintE0M.AssertModel(models[0],_testData[20], false);
                        Int64bigintE0M.AssertModel(models[1],_testData[21], false);
                        Int64bigintE0M.AssertModel(models[2],_testData[22], false);
                        Int64bigintE0M.AssertModel(models[3],_testData[23], false);
                        Int64bigintE0M.AssertModel(models[4],_testData[24], false);
                        Int64bigintE0M.AssertModel(models[5],_testData[25], false);
                        Int64bigintE0M.AssertModel(models[6],_testData[26], false);
                        Int64bigintE0M.AssertModel(models[7],_testData[27], false);
                        Int64bigintE0M.AssertModel(models[8],_testData[28], false);
                        Int64bigintE0M.AssertModel(models[9],_testData[29], false);
                        Int64bigintE0M.AssertModel(models[10],_testData[30], false);
                        Int64bigintE0M.AssertModel(models[11],_testData[31], false);
                        Int64bigintE0M.AssertModel(models[12],_testData[32], false);
                        Int64bigintE0M.AssertModel(models[13],_testData[33], false);
                        Int64bigintE0M.AssertModel(models[14],_testData[34], false);
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
                foreach(var batchResult in  ((IInt64SingleTypebigint)this).DbConnectionSTSelectModelBatch(connection, 38, 38))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        Int64bigintE0M.AssertModel(models[0],_testData[6], false);
                        Int64bigintE0M.AssertModel(models[1],_testData[7], false);
                        Int64bigintE0M.AssertModel(models[2],_testData[8], false);
                        Int64bigintE0M.AssertModel(models[3],_testData[9], false);
                        Int64bigintE0M.AssertModel(models[4],_testData[10], false);
                        Int64bigintE0M.AssertModel(models[5],_testData[11], false);
                        Int64bigintE0M.AssertModel(models[6],_testData[12], false);
                        Int64bigintE0M.AssertModel(models[7],_testData[13], false);
                        Int64bigintE0M.AssertModel(models[8],_testData[14], false);
                        Int64bigintE0M.AssertModel(models[9],_testData[15], false);
                        Int64bigintE0M.AssertModel(models[10],_testData[16], false);
                        Int64bigintE0M.AssertModel(models[11],_testData[17], false);
                        Int64bigintE0M.AssertModel(models[12],_testData[18], false);
                        Int64bigintE0M.AssertModel(models[13],_testData[19], false);
                        Int64bigintE0M.AssertModel(models[14],_testData[20], false);
                        Int64bigintE0M.AssertModel(models[15],_testData[21], false);
                        Int64bigintE0M.AssertModel(models[16],_testData[22], false);
                        Int64bigintE0M.AssertModel(models[17],_testData[23], false);
                        Int64bigintE0M.AssertModel(models[18],_testData[24], false);
                        Int64bigintE0M.AssertModel(models[19],_testData[25], false);
                        Int64bigintE0M.AssertModel(models[20],_testData[26], false);
                        Int64bigintE0M.AssertModel(models[21],_testData[27], false);
                        Int64bigintE0M.AssertModel(models[22],_testData[28], false);
                        Int64bigintE0M.AssertModel(models[23],_testData[29], false);
                        Int64bigintE0M.AssertModel(models[24],_testData[30], false);
                        Int64bigintE0M.AssertModel(models[25],_testData[31], false);
                        Int64bigintE0M.AssertModel(models[26],_testData[32], false);
                        Int64bigintE0M.AssertModel(models[27],_testData[33], false);
                        Int64bigintE0M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        Int64bigintE0M.AssertModel(models[0],_testData[6], false);
                        Int64bigintE0M.AssertModel(models[1],_testData[7], false);
                        Int64bigintE0M.AssertModel(models[2],_testData[8], false);
                        Int64bigintE0M.AssertModel(models[3],_testData[9], false);
                        Int64bigintE0M.AssertModel(models[4],_testData[10], false);
                        Int64bigintE0M.AssertModel(models[5],_testData[11], false);
                        Int64bigintE0M.AssertModel(models[6],_testData[12], false);
                        Int64bigintE0M.AssertModel(models[7],_testData[13], false);
                        Int64bigintE0M.AssertModel(models[8],_testData[14], false);
                        Int64bigintE0M.AssertModel(models[9],_testData[15], false);
                        Int64bigintE0M.AssertModel(models[10],_testData[16], false);
                        Int64bigintE0M.AssertModel(models[11],_testData[17], false);
                        Int64bigintE0M.AssertModel(models[12],_testData[18], false);
                        Int64bigintE0M.AssertModel(models[13],_testData[19], false);
                        Int64bigintE0M.AssertModel(models[14],_testData[20], false);
                        Int64bigintE0M.AssertModel(models[15],_testData[21], false);
                        Int64bigintE0M.AssertModel(models[16],_testData[22], false);
                        Int64bigintE0M.AssertModel(models[17],_testData[23], false);
                        Int64bigintE0M.AssertModel(models[18],_testData[24], false);
                        Int64bigintE0M.AssertModel(models[19],_testData[25], false);
                        Int64bigintE0M.AssertModel(models[20],_testData[26], false);
                        Int64bigintE0M.AssertModel(models[21],_testData[27], false);
                        Int64bigintE0M.AssertModel(models[22],_testData[28], false);
                        Int64bigintE0M.AssertModel(models[23],_testData[29], false);
                        Int64bigintE0M.AssertModel(models[24],_testData[30], false);
                        Int64bigintE0M.AssertModel(models[25],_testData[31], false);
                        Int64bigintE0M.AssertModel(models[26],_testData[32], false);
                        Int64bigintE0M.AssertModel(models[27],_testData[33], false);
                        Int64bigintE0M.AssertModel(models[28],_testData[34], false);
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
                ((IInt64SingleTypebigint)this).SetDbConnectionSelectModelParametrs(cmd, 123);
                var models = await ((IInt64SingleTypebigint)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(10));

                Int64bigintE0M.AssertModel(models[0],_testData[25], false);
                Int64bigintE0M.AssertModel(models[1],_testData[26], false);
                Int64bigintE0M.AssertModel(models[2],_testData[27], false);
                Int64bigintE0M.AssertModel(models[3],_testData[28], false);
                Int64bigintE0M.AssertModel(models[4],_testData[29], false);
                Int64bigintE0M.AssertModel(models[5],_testData[30], false);
                Int64bigintE0M.AssertModel(models[6],_testData[31], false);
                Int64bigintE0M.AssertModel(models[7],_testData[32], false);
                Int64bigintE0M.AssertModel(models[8],_testData[33], false);
                Int64bigintE0M.AssertModel(models[9],_testData[34], false);
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

                Assert.That(models, Has.Count.EqualTo(3));

                Int64bigintE0M.AssertModel(models[0],_testData[32], false);
                Int64bigintE0M.AssertModel(models[1],_testData[33], false);
                Int64bigintE0M.AssertModel(models[2],_testData[34], false);
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
FROM gedaqtests.int64biginte0m m
LEFT JOIN gedaqtests.int64biginte0mi mi ON mi.id = m.int64biginte0mi_id
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
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5059952617398825947L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8118856946259347614L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((2358445248609101590L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((6419034339145376809L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((671839315697464531L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((6526333354968588160L)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6496934805497218355L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((5)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((893071040213952016L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((5245256143563569281L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((32)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8727874482929245263L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((9050800538629851831L)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((757552084467895738L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((8002007889372855409L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4991045700359874785L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2228819512395397506L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((6925109452147023162L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((8621232426652486881L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6453978269851780631L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3762585043807046161L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((1439843117132539604L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((7238499288793909537L)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8038551632354852541L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((8449644788244418369L)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1844464147316667208L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((7377703745783711930L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((5733008115552139425L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8255794139011061236L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((130843974774891014L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((5416363897243163281L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((8117267670627825216L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((149873974026098260L)));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6090394813017037204L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((4521596023684845638L)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6156377755482132227L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((4318171034236298042L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((6781781922769673322L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8662937837891595707L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((482489240782745980L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((8882473057392273425L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((1824062239683600221L)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7543368266882243299L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((5502460261035936995L)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4260746103674920957L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((2796554700084526155L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((1602577112978248590L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((735866119953798645L)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4057755191846580771L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((4208787093822722750L)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8643234341541680227L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((2981002927394509568L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((1098968277245301398L)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2628635613804644487L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1749391339348098757L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((1002031698921414992L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((288899569129919617L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((6244509637832299583L)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3306418861507276268L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6930374531982968529L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((9182457759791817714L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((4020131733005238495L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((134)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4557073371804029450L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((1129304843711915883L)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4310972046623527925L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((7299393778034594528L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((6208523174708119354L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((947055267873806241L)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2136256116176096594L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((960583294471664678L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((597683205838638978L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((1228910243741071838L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5839090589089144434L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((72128488355428791L)));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((940166765585990329L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((67)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((4623873291471983547L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((9177917057610149951L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((719552006346694160L)));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((159)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7712218765575776369L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((165)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((871427361016662963L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((73)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((6381780960382146312L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((1964543092109546636L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((172)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8144919532128545839L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((4352324657457291651L)));

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
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5059952617398825947L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8118856946259347614L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((2358445248609101590L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((6419034339145376809L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((671839315697464531L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((6526333354968588160L)));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6496934805497218355L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((5)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((893071040213952016L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((5245256143563569281L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((32)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8727874482929245263L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((9050800538629851831L)));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((757552084467895738L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((8002007889372855409L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4991045700359874785L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2228819512395397506L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((6925109452147023162L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((8621232426652486881L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6453978269851780631L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3762585043807046161L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((1439843117132539604L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((7238499288793909537L)));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8038551632354852541L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((8449644788244418369L)));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1844464147316667208L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((7377703745783711930L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((5733008115552139425L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8255794139011061236L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((130843974774891014L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((5416363897243163281L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((8117267670627825216L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((149873974026098260L)));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6090394813017037204L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((4521596023684845638L)));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6156377755482132227L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((4318171034236298042L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((6781781922769673322L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8662937837891595707L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((482489240782745980L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((8882473057392273425L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((1824062239683600221L)));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7543368266882243299L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((5502460261035936995L)));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4260746103674920957L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((2796554700084526155L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((1602577112978248590L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((735866119953798645L)));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4057755191846580771L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((4208787093822722750L)));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8643234341541680227L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((2981002927394509568L)));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Int64?)model[5], Is.EqualTo((1098968277245301398L)));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2628635613804644487L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((1749391339348098757L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((1002031698921414992L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((288899569129919617L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((6244509637832299583L)));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((3306418861507276268L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((6930374531982968529L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((9182457759791817714L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((4020131733005238495L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((134)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4557073371804029450L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((1129304843711915883L)));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((4310972046623527925L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((7299393778034594528L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((6208523174708119354L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((947055267873806241L)));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((2136256116176096594L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((960583294471664678L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((597683205838638978L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((1228910243741071838L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((5839090589089144434L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((72128488355428791L)));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((940166765585990329L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((67)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((4623873291471983547L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((9177917057610149951L)));//InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((719552006346694160L)));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((159)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((7712218765575776369L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((165)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((871427361016662963L)));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((73)));//InnerModel.Id
                Assert.That((System.Int64)model[3], Is.EqualTo((6381780960382146312L)));//InnerModel.Value

                Assert.That((System.Int64?)model[4], Is.EqualTo((1964543092109546636L)));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((172)));//Id
                Assert.That((System.Int64)model[1], Is.EqualTo((8144919532128545839L)));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Int64?)model[5], Is.EqualTo((4352324657457291651L)));

            }
        }

#endregion

    }
}

