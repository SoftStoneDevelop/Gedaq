

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
    internal partial interface IStringSingleTypetext
    {
    }
    
    internal partial class StringSingleTypetext : IStringSingleTypetext
    {


#region TestData

        private readonly Stringtext0M[] _testData = new Stringtext0M[]
        {
            new Stringtext0M
{
    Id = 9,
    Value = "ijsijrqksxrxctdsl",
    ModelInner = null,
    NullableValue = "dfbiekojy",
},
            new Stringtext0M
{
    Id = 11,
    Value = "rjle",
    ModelInner = new Stringtext0MI
{
    Id = 1,
    Value = "csrto",
    NullableValue = null,
},
    NullableValue = null,
},
            new Stringtext0M
{
    Id = 15,
    Value = "r",
    ModelInner = null,
    NullableValue = null,
},
            new Stringtext0M
{
    Id = 16,
    Value = "xejnvxvsmoajwldbeerq",
    ModelInner = new Stringtext0MI
{
    Id = 4,
    Value = "alvpovy",
    NullableValue = "vhohi",
},
    NullableValue = null,
},
            new Stringtext0M
{
    Id = 24,
    Value = "ctjtvi",
    ModelInner = null,
    NullableValue = null,
},
            new Stringtext0M
{
    Id = 25,
    Value = "r",
    ModelInner = new Stringtext0MI
{
    Id = 8,
    Value = "uswwgouilxsdoloaxmqyxmmrw",
    NullableValue = null,
},
    NullableValue = null,
},
            new Stringtext0M
{
    Id = 28,
    Value = "outqjn",
    ModelInner = null,
    NullableValue = "qwxmhpxcyevf",
},
            new Stringtext0M
{
    Id = 36,
    Value = "jbxtdjxpj",
    ModelInner = new Stringtext0MI
{
    Id = 12,
    Value = "hblkkbisqttglbilvso",
    NullableValue = null,
},
    NullableValue = null,
},
            new Stringtext0M
{
    Id = 42,
    Value = "mneyeriqtykchbjwdmhel",
    ModelInner = null,
    NullableValue = null,
},
            new Stringtext0M
{
    Id = 48,
    Value = "eoeoofonoxfonedvvqtqivifyviis",
    ModelInner = new Stringtext0MI
{
    Id = 17,
    Value = "wnqmslhehwalefhfprecrqbmot",
    NullableValue = "sfdsev",
},
    NullableValue = "bmnbkdffmjjnwrx",
},
            new Stringtext0M
{
    Id = 57,
    Value = "jhdgswoppsqhprdkfenlhw",
    ModelInner = null,
    NullableValue = null,
},
            new Stringtext0M
{
    Id = 64,
    Value = "",
    ModelInner = new Stringtext0MI
{
    Id = 22,
    Value = "laahilwiayguuslxwilcbxyaw",
    NullableValue = null,
},
    NullableValue = "d",
},
            new Stringtext0M
{
    Id = 69,
    Value = "smolsd",
    ModelInner = null,
    NullableValue = "gfmqp",
},
            new Stringtext0M
{
    Id = 72,
    Value = "daknskcbrobvmjurfjbgaqlcp",
    ModelInner = new Stringtext0MI
{
    Id = 23,
    Value = "ffoflqdvtbyrdx",
    NullableValue = null,
},
    NullableValue = null,
},
            new Stringtext0M
{
    Id = 81,
    Value = "kpimqjbhwjqqypauqmnnv",
    ModelInner = null,
    NullableValue = "rbqdqpgnawrvffaslslbuc",
},
            new Stringtext0M
{
    Id = 88,
    Value = "qtvptgxrg",
    ModelInner = new Stringtext0MI
{
    Id = 28,
    Value = "cymkwwhhflggpckcaextil",
    NullableValue = null,
},
    NullableValue = null,
},
            new Stringtext0M
{
    Id = 89,
    Value = "ljqrwmenmgoofignepphrissvdqqm",
    ModelInner = null,
    NullableValue = null,
},
            new Stringtext0M
{
    Id = 98,
    Value = "xkcorueofx",
    ModelInner = new Stringtext0MI
{
    Id = 30,
    Value = "yrbuwsye",
    NullableValue = "wnf",
},
    NullableValue = "rkqbtrgvcowasvy",
},
            new Stringtext0M
{
    Id = 105,
    Value = "gjdrnkvwhtxoxb",
    ModelInner = null,
    NullableValue = "wlavwatvgthcrnakr",
},
            new Stringtext0M
{
    Id = 114,
    Value = "yvehrfl",
    ModelInner = new Stringtext0MI
{
    Id = 36,
    Value = "jxypuumalypfjtymklbfuu",
    NullableValue = null,
},
    NullableValue = null,
},
            new Stringtext0M
{
    Id = 119,
    Value = "hcdacbmsdxphsmgbhkrscyps",
    ModelInner = null,
    NullableValue = "oo",
},
            new Stringtext0M
{
    Id = 124,
    Value = "v",
    ModelInner = new Stringtext0MI
{
    Id = 41,
    Value = "poykqdidrdyssgpderce",
    NullableValue = "fhfgbhboidgaqerbqlwvvimgdodd",
},
    NullableValue = null,
},
            new Stringtext0M
{
    Id = 131,
    Value = "b",
    ModelInner = null,
    NullableValue = null,
},
            new Stringtext0M
{
    Id = 132,
    Value = "ohlprvncvjbalivwktvjecdrw",
    ModelInner = new Stringtext0MI
{
    Id = 50,
    Value = "xjiprrvlfbgfdjogfaqvniwm",
    NullableValue = "sajxxcnbahvqiavppk",
},
    NullableValue = null,
},
            new Stringtext0M
{
    Id = 133,
    Value = "qmeathyystdtpsxgxrnyb",
    ModelInner = null,
    NullableValue = "pydnvrjbmitntqnclgvmtdwftq",
},
            new Stringtext0M
{
    Id = 138,
    Value = "ssixmuoqlrnearhubackt",
    ModelInner = new Stringtext0MI
{
    Id = 52,
    Value = "pprals",
    NullableValue = "tofeihetqfwxjieuhsnl",
},
    NullableValue = "phkwyyuqvopiqbvfhmalfjrqtvdr",
},
            new Stringtext0M
{
    Id = 145,
    Value = "bdtxklogrmyvaplgwpbcvlff",
    ModelInner = null,
    NullableValue = null,
},
            new Stringtext0M
{
    Id = 152,
    Value = "ehrsxmw",
    ModelInner = new Stringtext0MI
{
    Id = 57,
    Value = "yhvwrwujbgjbgpycfgxtls",
    NullableValue = null,
},
    NullableValue = "tof",
},
            new Stringtext0M
{
    Id = 154,
    Value = "v",
    ModelInner = null,
    NullableValue = "sjqgxycgjqu",
},
            new Stringtext0M
{
    Id = 158,
    Value = "vsscopoa",
    ModelInner = new Stringtext0MI
{
    Id = 59,
    Value = "lueffvpbbofketjisdwbsagdu",
    NullableValue = null,
},
    NullableValue = "npclsqxwrhorfvk",
},
        };

#endregion

#region InsertModelInner

[Gedaq.SqlClient.Attributes.Query(
            query: @"
INSERT INTO dbo.stringtext0mi(
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
            asPartInterface: typeof(IStringSingleTypetext)), 
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                parametrName: "id",
                methodParametrName: "id", 
                sqlDbType: (System.Data.SqlDbType)(8)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.String),
                parametrName: "value",
                methodParametrName: "value",
                sqlDbType: (System.Data.SqlDbType)(18)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.String), 
                parametrName: "nullablevalue",
                methodParametrName: "nullablevalue",
                sqlDbType: (System.Data.SqlDbType)(18))
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

                changedRows =  ((IStringSingleTypetext)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IStringSingleTypetext)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IStringSingleTypetext)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO dbo.stringtext0mi(
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
            asPartInterface: typeof(IStringSingleTypetext)), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)11),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.String), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)0),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.String), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)0, 
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

                changedRows =  ((IStringSingleTypetext)this).DbConnectionInsertInnerModel(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
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

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertInnerModelAsync(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertInnerModelAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertInnerModelAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertInnerModelAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertInnerModelAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertInnerModelAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertInnerModelAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertInnerModelAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertInnerModelAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertInnerModelAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.SqlClient.Attributes.Query(
            query: @"
INSERT INTO dbo.stringtext0m(
	id,
    value,
    nullablevalue,
    stringtext0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @stringtext0mi_id
)
",
            methodName:"InsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringSingleTypetext)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                parametrName: "id",
                methodParametrName: "id",
                sqlDbType: (System.Data.SqlDbType)(8)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.String), 
                parametrName: "value", 
                methodParametrName: "value", 
                sqlDbType: (System.Data.SqlDbType)(18)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.String), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                sqlDbType: (System.Data.SqlDbType)(18),
                nullable: true),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "stringtext0mi_id", 
                methodParametrName: "stringtext0mi_id", 
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

                changedRows =  ((IStringSingleTypetext)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IStringSingleTypetext)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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

                changedRows = await ((IStringSingleTypetext)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO dbo.stringtext0m(
	id,
    value,
    nullablevalue,
    stringtext0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @stringtext0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringSingleTypetext)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)11),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.String), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)0),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.String), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)0,
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "stringtext0mi_id", 
                methodParametrName: "stringtext0mi_id", 
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

                changedRows =  ((IStringSingleTypetext)this).DbConnectionInsertModel(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IStringSingleTypetext)this).DbConnectionInsertModel(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
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

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertModelAsync(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertModelAsync(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertModelAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertModelAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertModelAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertModelAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertModelAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertModelAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertModelAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertModelAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertModelAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertModelAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertModelAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertModelAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertModelAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertModelAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertModelAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertModelAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertModelAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertModelAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertModelAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertModelAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertModelAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertModelAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatStringtext0M), typeof(FlatStringtext0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringSingleTypetext)),
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
FROM dbo.stringtext0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models1 = new List<FlatStringtext0M>();
                var models2 = new List<FlatStringtext0M>();
                await((IStringSingleTypetext)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatStringtext0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatStringtext0M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.stringtext0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models1 = new List<FlatStringtext0M>();
                var models2 = new List<FlatStringtext0M>();
                ((IStringSingleTypetext)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatStringtext0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatStringtext0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatStringtext0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringSingleTypetext)),
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
FROM dbo.stringtext0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models = await((IStringSingleTypetext)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatStringtext0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.stringtext0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models = ((IStringSingleTypetext)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatStringtext0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.stringtext0m m
LEFT JOIN dbo.stringtext0mi mi ON mi.id = m.stringtext0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Stringtext0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringSingleTypetext)),
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
                var models = await((IStringSingleTypetext)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Stringtext0M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IStringSingleTypetext)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Stringtext0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatStringtext0M), typeof(FlatStringtext0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringSingleTypetext)),
Gedaq.SqlClient.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            parametrName: "id",
            methodParametrName: "id",
            sqlDbType: (System.Data.SqlDbType)(8))]
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
FROM dbo.stringtext0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatStringtext0M>();
                var models2 = new List<FlatStringtext0M>();
                await((IStringSingleTypetext)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatStringtext0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatStringtext0M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.stringtext0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatStringtext0M>();
                var models2 = new List<FlatStringtext0M>();
                ((IStringSingleTypetext)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatStringtext0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatStringtext0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatStringtext0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringSingleTypetext)),
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
FROM dbo.stringtext0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IStringSingleTypetext)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatStringtext0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.stringtext0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IStringSingleTypetext)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatStringtext0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.stringtext0m m
LEFT JOIN dbo.stringtext0mi mi ON mi.id = m.stringtext0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Stringtext0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringSingleTypetext)),
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
                var models = await((IStringSingleTypetext)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Stringtext0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IStringSingleTypetext)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Stringtext0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatStringtext0M), typeof(FlatStringtext0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringSingleTypetext)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringSingleTypetext)),
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
            asPartInterface: typeof(IStringSingleTypetext)),
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
FROM dbo.stringtext0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatStringtext0M>();
                var models2 = new List<FlatStringtext0M>();
                await((IStringSingleTypetext)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatStringtext0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatStringtext0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 98;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 89;
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
FROM dbo.stringtext0m m
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
FROM dbo.stringtext0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatStringtext0M>();
                var firstItems2 = new List<FlatStringtext0M>();
                var secondItems1 = new List<FlatStringtext0M>();
                var secondItems2 = new List<FlatStringtext0M>();
                await ((IStringSingleTypetext)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatStringtext0M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatStringtext0M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatStringtext0M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatStringtext0M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatStringtext0M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatStringtext0M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatStringtext0M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatStringtext0M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatStringtext0M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatStringtext0M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatStringtext0M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatStringtext0M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatStringtext0M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatStringtext0M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatStringtext0M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatStringtext0M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatStringtext0M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatStringtext0M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatStringtext0M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatStringtext0M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatStringtext0M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatStringtext0M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatStringtext0M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatStringtext0M.AssertModel(firstItems2[11],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatStringtext0M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatStringtext0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatStringtext0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatStringtext0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatStringtext0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatStringtext0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatStringtext0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatStringtext0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatStringtext0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatStringtext0M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatStringtext0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatStringtext0M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatStringtext0M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatStringtext0M.AssertModel(secondItems2[12],_testData[30], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 28;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 114;
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
FROM dbo.stringtext0m m
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
FROM dbo.stringtext0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatStringtext0M>();
                var firstItems2 = new List<FlatStringtext0M>();
                var secondItems1 = new List<FlatStringtext0M>();
                await ((IStringSingleTypetext)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatStringtext0M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatStringtext0M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatStringtext0M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatStringtext0M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatStringtext0M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatStringtext0M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatStringtext0M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatStringtext0M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatStringtext0M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatStringtext0M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatStringtext0M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatStringtext0M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatStringtext0M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatStringtext0M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatStringtext0M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatStringtext0M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatStringtext0M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatStringtext0M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatStringtext0M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatStringtext0M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatStringtext0M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatStringtext0M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatStringtext0M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatStringtext0M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatStringtext0M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatStringtext0M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatStringtext0M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatStringtext0M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatStringtext0M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatStringtext0M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatStringtext0M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatStringtext0M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatStringtext0M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatStringtext0M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatStringtext0M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatStringtext0M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatStringtext0M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatStringtext0M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatStringtext0M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatStringtext0M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatStringtext0M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatStringtext0M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatStringtext0M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatStringtext0M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatStringtext0M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatStringtext0M.AssertModel(firstItems2[22],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                        FlatStringtext0M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatStringtext0M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatStringtext0M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatStringtext0M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatStringtext0M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatStringtext0M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatStringtext0M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatStringtext0M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatStringtext0M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatStringtext0M.AssertModel(secondItems1[9],_testData[29], false);
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
FROM dbo.stringtext0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatStringtext0M>();
                var models2 = new List<FlatStringtext0M>();
                ((IStringSingleTypetext)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatStringtext0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatStringtext0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 48;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 88;
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
FROM dbo.stringtext0m m
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
FROM dbo.stringtext0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatStringtext0M>();
                var firstItems2 = new List<FlatStringtext0M>();
                var secondItems1 = new List<FlatStringtext0M>();
                var secondItems2 = new List<FlatStringtext0M>();
                 ((IStringSingleTypetext)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatStringtext0M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatStringtext0M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatStringtext0M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatStringtext0M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatStringtext0M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatStringtext0M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatStringtext0M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatStringtext0M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatStringtext0M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatStringtext0M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatStringtext0M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatStringtext0M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatStringtext0M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatStringtext0M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatStringtext0M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatStringtext0M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatStringtext0M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatStringtext0M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatStringtext0M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatStringtext0M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatStringtext0M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatStringtext0M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatStringtext0M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatStringtext0M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatStringtext0M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatStringtext0M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatStringtext0M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatStringtext0M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatStringtext0M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatStringtext0M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatStringtext0M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatStringtext0M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatStringtext0M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatStringtext0M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatStringtext0M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatStringtext0M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatStringtext0M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatStringtext0M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatStringtext0M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatStringtext0M.AssertModel(firstItems2[19],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatStringtext0M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatStringtext0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatStringtext0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatStringtext0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatStringtext0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatStringtext0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatStringtext0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatStringtext0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatStringtext0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatStringtext0M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatStringtext0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatStringtext0M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatStringtext0M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatStringtext0M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatStringtext0M.AssertModel(secondItems2[13],_testData[30], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 114;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 132;
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
FROM dbo.stringtext0m m
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
FROM dbo.stringtext0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatStringtext0M>();
                var firstItems2 = new List<FlatStringtext0M>();
                var secondItems1 = new List<FlatStringtext0M>();
                 ((IStringSingleTypetext)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatStringtext0M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatStringtext0M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatStringtext0M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatStringtext0M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatStringtext0M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatStringtext0M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatStringtext0M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatStringtext0M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatStringtext0M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatStringtext0M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatStringtext0M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatStringtext0M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatStringtext0M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatStringtext0M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatStringtext0M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatStringtext0M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatStringtext0M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatStringtext0M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatStringtext0M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatStringtext0M.AssertModel(firstItems2[9],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatStringtext0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatStringtext0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatStringtext0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatStringtext0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatStringtext0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatStringtext0M.AssertModel(secondItems1[5],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatStringtext0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringSingleTypetext)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringSingleTypetext)),
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
            asPartInterface: typeof(IStringSingleTypetext)),
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
FROM dbo.stringtext0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IStringSingleTypetext)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatStringtext0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 132;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 88;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.stringtext0m m
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
FROM dbo.stringtext0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IStringSingleTypetext)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatStringtext0M.AssertModel(models[0],_testData[24], false);
                        FlatStringtext0M.AssertModel(models[1],_testData[25], false);
                        FlatStringtext0M.AssertModel(models[2],_testData[26], false);
                        FlatStringtext0M.AssertModel(models[3],_testData[27], false);
                        FlatStringtext0M.AssertModel(models[4],_testData[28], false);
                        FlatStringtext0M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatStringtext0M.AssertModel(models[0],_testData[16], false);
                        FlatStringtext0M.AssertModel(models[1],_testData[17], false);
                        FlatStringtext0M.AssertModel(models[2],_testData[18], false);
                        FlatStringtext0M.AssertModel(models[3],_testData[19], false);
                        FlatStringtext0M.AssertModel(models[4],_testData[20], false);
                        FlatStringtext0M.AssertModel(models[5],_testData[21], false);
                        FlatStringtext0M.AssertModel(models[6],_testData[22], false);
                        FlatStringtext0M.AssertModel(models[7],_testData[23], false);
                        FlatStringtext0M.AssertModel(models[8],_testData[24], false);
                        FlatStringtext0M.AssertModel(models[9],_testData[25], false);
                        FlatStringtext0M.AssertModel(models[10],_testData[26], false);
                        FlatStringtext0M.AssertModel(models[11],_testData[27], false);
                        FlatStringtext0M.AssertModel(models[12],_testData[28], false);
                        FlatStringtext0M.AssertModel(models[13],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 15;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 28;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.stringtext0m m
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
FROM dbo.stringtext0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatStringtext0M>();
                var secondItems1 = new List<FlatStringtext0M>();
                var secondItems2 = new List<FlatStringtext0M>();
                await ((IStringSingleTypetext)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatStringtext0M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatStringtext0M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatStringtext0M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatStringtext0M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatStringtext0M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatStringtext0M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatStringtext0M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatStringtext0M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatStringtext0M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatStringtext0M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatStringtext0M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatStringtext0M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatStringtext0M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatStringtext0M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatStringtext0M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatStringtext0M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatStringtext0M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatStringtext0M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatStringtext0M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatStringtext0M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatStringtext0M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatStringtext0M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatStringtext0M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatStringtext0M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatStringtext0M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatStringtext0M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatStringtext0M.AssertModel(firstItems1[26],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatStringtext0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatStringtext0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatStringtext0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatStringtext0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatStringtext0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatStringtext0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatStringtext0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatStringtext0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatStringtext0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatStringtext0M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatStringtext0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatStringtext0M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatStringtext0M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatStringtext0M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatStringtext0M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatStringtext0M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatStringtext0M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatStringtext0M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatStringtext0M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatStringtext0M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatStringtext0M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatStringtext0M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatStringtext0M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatStringtext0M.AssertModel(secondItems2[22],_testData[30], false);
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
FROM dbo.stringtext0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IStringSingleTypetext)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatStringtext0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 105;
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
FROM dbo.stringtext0m m
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
FROM dbo.stringtext0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IStringSingleTypetext)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatStringtext0M.AssertModel(models[0],_testData[19], false);
                        FlatStringtext0M.AssertModel(models[1],_testData[20], false);
                        FlatStringtext0M.AssertModel(models[2],_testData[21], false);
                        FlatStringtext0M.AssertModel(models[3],_testData[22], false);
                        FlatStringtext0M.AssertModel(models[4],_testData[23], false);
                        FlatStringtext0M.AssertModel(models[5],_testData[24], false);
                        FlatStringtext0M.AssertModel(models[6],_testData[25], false);
                        FlatStringtext0M.AssertModel(models[7],_testData[26], false);
                        FlatStringtext0M.AssertModel(models[8],_testData[27], false);
                        FlatStringtext0M.AssertModel(models[9],_testData[28], false);
                        FlatStringtext0M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatStringtext0M.AssertModel(models[0],_testData[27], false);
                        FlatStringtext0M.AssertModel(models[1],_testData[28], false);
                        FlatStringtext0M.AssertModel(models[2],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 81;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 132;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.stringtext0m m
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
FROM dbo.stringtext0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatStringtext0M>();
                var secondItems1 = new List<FlatStringtext0M>();
                var secondItems2 = new List<FlatStringtext0M>();
                 ((IStringSingleTypetext)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatStringtext0M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatStringtext0M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatStringtext0M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatStringtext0M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatStringtext0M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatStringtext0M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatStringtext0M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatStringtext0M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatStringtext0M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatStringtext0M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatStringtext0M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatStringtext0M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatStringtext0M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatStringtext0M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatStringtext0M.AssertModel(firstItems1[14],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatStringtext0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatStringtext0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatStringtext0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatStringtext0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatStringtext0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatStringtext0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatStringtext0M.AssertModel(secondItems2[5],_testData[30], false);
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
FROM dbo.stringtext0m m
LEFT JOIN dbo.stringtext0mi mi ON mi.id = m.stringtext0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Stringtext0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringSingleTypetext)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringSingleTypetext)),
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
                var models = await((IStringSingleTypetext)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Stringtext0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTSelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 36;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 138;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((IStringSingleTypetext)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        Stringtext0M.AssertModel(models[0],_testData[8], false);
                        Stringtext0M.AssertModel(models[1],_testData[9], false);
                        Stringtext0M.AssertModel(models[2],_testData[10], false);
                        Stringtext0M.AssertModel(models[3],_testData[11], false);
                        Stringtext0M.AssertModel(models[4],_testData[12], false);
                        Stringtext0M.AssertModel(models[5],_testData[13], false);
                        Stringtext0M.AssertModel(models[6],_testData[14], false);
                        Stringtext0M.AssertModel(models[7],_testData[15], false);
                        Stringtext0M.AssertModel(models[8],_testData[16], false);
                        Stringtext0M.AssertModel(models[9],_testData[17], false);
                        Stringtext0M.AssertModel(models[10],_testData[18], false);
                        Stringtext0M.AssertModel(models[11],_testData[19], false);
                        Stringtext0M.AssertModel(models[12],_testData[20], false);
                        Stringtext0M.AssertModel(models[13],_testData[21], false);
                        Stringtext0M.AssertModel(models[14],_testData[22], false);
                        Stringtext0M.AssertModel(models[15],_testData[23], false);
                        Stringtext0M.AssertModel(models[16],_testData[24], false);
                        Stringtext0M.AssertModel(models[17],_testData[25], false);
                        Stringtext0M.AssertModel(models[18],_testData[26], false);
                        Stringtext0M.AssertModel(models[19],_testData[27], false);
                        Stringtext0M.AssertModel(models[20],_testData[28], false);
                        Stringtext0M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        Stringtext0M.AssertModel(models[0],_testData[26], false);
                        Stringtext0M.AssertModel(models[1],_testData[27], false);
                        Stringtext0M.AssertModel(models[2],_testData[28], false);
                        Stringtext0M.AssertModel(models[3],_testData[29], false);
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
                var models = ((IStringSingleTypetext)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Stringtext0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTSelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 133;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 119;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((IStringSingleTypetext)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        Stringtext0M.AssertModel(models[0],_testData[25], false);
                        Stringtext0M.AssertModel(models[1],_testData[26], false);
                        Stringtext0M.AssertModel(models[2],_testData[27], false);
                        Stringtext0M.AssertModel(models[3],_testData[28], false);
                        Stringtext0M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        Stringtext0M.AssertModel(models[0],_testData[21], false);
                        Stringtext0M.AssertModel(models[1],_testData[22], false);
                        Stringtext0M.AssertModel(models[2],_testData[23], false);
                        Stringtext0M.AssertModel(models[3],_testData[24], false);
                        Stringtext0M.AssertModel(models[4],_testData[25], false);
                        Stringtext0M.AssertModel(models[5],_testData[26], false);
                        Stringtext0M.AssertModel(models[6],_testData[27], false);
                        Stringtext0M.AssertModel(models[7],_testData[28], false);
                        Stringtext0M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatStringtext0M), typeof(FlatStringtext0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringSingleTypetext)),
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
            asPartInterface: typeof(IStringSingleTypetext)),
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
            asPartInterface: typeof(IStringSingleTypetext)),
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
FROM dbo.stringtext0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatStringtext0M>();
                var models2 = new List<FlatStringtext0M>();
                await((IStringSingleTypetext)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatStringtext0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatStringtext0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM dbo.stringtext0m m
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
FROM dbo.stringtext0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatStringtext0M>();
                var firstItems2 = new List<FlatStringtext0M>();
                var secondItems1 = new List<FlatStringtext0M>();
                var secondItems2 = new List<FlatStringtext0M>();
                await ((IStringSingleTypetext)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 69, query1, 69, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatStringtext0M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatStringtext0M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatStringtext0M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatStringtext0M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatStringtext0M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatStringtext0M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatStringtext0M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatStringtext0M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatStringtext0M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatStringtext0M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatStringtext0M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatStringtext0M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatStringtext0M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatStringtext0M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatStringtext0M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatStringtext0M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatStringtext0M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatStringtext0M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatStringtext0M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatStringtext0M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatStringtext0M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatStringtext0M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatStringtext0M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatStringtext0M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatStringtext0M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatStringtext0M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatStringtext0M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatStringtext0M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatStringtext0M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatStringtext0M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatStringtext0M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatStringtext0M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatStringtext0M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatStringtext0M.AssertModel(firstItems2[16],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatStringtext0M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatStringtext0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatStringtext0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatStringtext0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatStringtext0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatStringtext0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatStringtext0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatStringtext0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatStringtext0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatStringtext0M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatStringtext0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatStringtext0M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatStringtext0M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatStringtext0M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatStringtext0M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatStringtext0M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatStringtext0M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatStringtext0M.AssertModel(secondItems2[16],_testData[30], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM dbo.stringtext0m m
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
FROM dbo.stringtext0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatStringtext0M>();
                var firstItems2 = new List<FlatStringtext0M>();
                var secondItems1 = new List<FlatStringtext0M>();
                await ((IStringSingleTypetext)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 119, query1, 89, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatStringtext0M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatStringtext0M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatStringtext0M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatStringtext0M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatStringtext0M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatStringtext0M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatStringtext0M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatStringtext0M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatStringtext0M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatStringtext0M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatStringtext0M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatStringtext0M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatStringtext0M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatStringtext0M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatStringtext0M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatStringtext0M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatStringtext0M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatStringtext0M.AssertModel(firstItems2[8],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatStringtext0M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatStringtext0M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatStringtext0M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatStringtext0M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatStringtext0M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatStringtext0M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatStringtext0M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatStringtext0M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatStringtext0M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatStringtext0M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatStringtext0M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatStringtext0M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatStringtext0M.AssertModel(secondItems1[12],_testData[29], false);
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
FROM dbo.stringtext0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatStringtext0M>();
                var models2 = new List<FlatStringtext0M>();
                ((IStringSingleTypetext)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatStringtext0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatStringtext0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM dbo.stringtext0m m
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
FROM dbo.stringtext0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatStringtext0M>();
                var firstItems2 = new List<FlatStringtext0M>();
                var secondItems1 = new List<FlatStringtext0M>();
                var secondItems2 = new List<FlatStringtext0M>();
                 ((IStringSingleTypetext)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 72, query1, 24, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatStringtext0M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatStringtext0M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatStringtext0M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatStringtext0M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatStringtext0M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatStringtext0M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatStringtext0M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatStringtext0M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatStringtext0M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatStringtext0M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatStringtext0M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatStringtext0M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatStringtext0M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatStringtext0M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatStringtext0M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatStringtext0M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatStringtext0M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatStringtext0M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatStringtext0M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatStringtext0M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatStringtext0M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatStringtext0M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatStringtext0M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatStringtext0M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatStringtext0M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatStringtext0M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatStringtext0M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatStringtext0M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatStringtext0M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatStringtext0M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatStringtext0M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatStringtext0M.AssertModel(firstItems2[15],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatStringtext0M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatStringtext0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatStringtext0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatStringtext0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatStringtext0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatStringtext0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatStringtext0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatStringtext0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatStringtext0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatStringtext0M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatStringtext0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatStringtext0M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatStringtext0M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatStringtext0M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatStringtext0M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatStringtext0M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatStringtext0M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatStringtext0M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatStringtext0M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatStringtext0M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatStringtext0M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatStringtext0M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatStringtext0M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatStringtext0M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatStringtext0M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatStringtext0M.AssertModel(secondItems2[24],_testData[30], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM dbo.stringtext0m m
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
FROM dbo.stringtext0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatStringtext0M>();
                var firstItems2 = new List<FlatStringtext0M>();
                var secondItems1 = new List<FlatStringtext0M>();
                 ((IStringSingleTypetext)this).DbConnectionMMDynQuerySelectModelBatch(connection, 145, query1, 24, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatStringtext0M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatStringtext0M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatStringtext0M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatStringtext0M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatStringtext0M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatStringtext0M.AssertModel(firstItems2[2],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatStringtext0M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatStringtext0M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatStringtext0M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatStringtext0M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatStringtext0M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatStringtext0M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatStringtext0M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatStringtext0M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatStringtext0M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatStringtext0M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatStringtext0M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatStringtext0M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatStringtext0M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatStringtext0M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatStringtext0M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatStringtext0M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatStringtext0M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatStringtext0M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatStringtext0M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatStringtext0M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatStringtext0M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatStringtext0M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatStringtext0M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatStringtext0M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatStringtext0M.AssertModel(secondItems1[24],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatStringtext0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringSingleTypetext)),
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
            asPartInterface: typeof(IStringSingleTypetext)),
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
            asPartInterface: typeof(IStringSingleTypetext)),
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
FROM dbo.stringtext0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IStringSingleTypetext)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatStringtext0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelBatchTestAsync()
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
FROM dbo.stringtext0m m
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
FROM dbo.stringtext0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IStringSingleTypetext)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 89, query1, 16, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatStringtext0M.AssertModel(models[0],_testData[17], false);
                        FlatStringtext0M.AssertModel(models[1],_testData[18], false);
                        FlatStringtext0M.AssertModel(models[2],_testData[19], false);
                        FlatStringtext0M.AssertModel(models[3],_testData[20], false);
                        FlatStringtext0M.AssertModel(models[4],_testData[21], false);
                        FlatStringtext0M.AssertModel(models[5],_testData[22], false);
                        FlatStringtext0M.AssertModel(models[6],_testData[23], false);
                        FlatStringtext0M.AssertModel(models[7],_testData[24], false);
                        FlatStringtext0M.AssertModel(models[8],_testData[25], false);
                        FlatStringtext0M.AssertModel(models[9],_testData[26], false);
                        FlatStringtext0M.AssertModel(models[10],_testData[27], false);
                        FlatStringtext0M.AssertModel(models[11],_testData[28], false);
                        FlatStringtext0M.AssertModel(models[12],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatStringtext0M.AssertModel(models[0],_testData[4], false);
                        FlatStringtext0M.AssertModel(models[1],_testData[5], false);
                        FlatStringtext0M.AssertModel(models[2],_testData[6], false);
                        FlatStringtext0M.AssertModel(models[3],_testData[7], false);
                        FlatStringtext0M.AssertModel(models[4],_testData[8], false);
                        FlatStringtext0M.AssertModel(models[5],_testData[9], false);
                        FlatStringtext0M.AssertModel(models[6],_testData[10], false);
                        FlatStringtext0M.AssertModel(models[7],_testData[11], false);
                        FlatStringtext0M.AssertModel(models[8],_testData[12], false);
                        FlatStringtext0M.AssertModel(models[9],_testData[13], false);
                        FlatStringtext0M.AssertModel(models[10],_testData[14], false);
                        FlatStringtext0M.AssertModel(models[11],_testData[15], false);
                        FlatStringtext0M.AssertModel(models[12],_testData[16], false);
                        FlatStringtext0M.AssertModel(models[13],_testData[17], false);
                        FlatStringtext0M.AssertModel(models[14],_testData[18], false);
                        FlatStringtext0M.AssertModel(models[15],_testData[19], false);
                        FlatStringtext0M.AssertModel(models[16],_testData[20], false);
                        FlatStringtext0M.AssertModel(models[17],_testData[21], false);
                        FlatStringtext0M.AssertModel(models[18],_testData[22], false);
                        FlatStringtext0M.AssertModel(models[19],_testData[23], false);
                        FlatStringtext0M.AssertModel(models[20],_testData[24], false);
                        FlatStringtext0M.AssertModel(models[21],_testData[25], false);
                        FlatStringtext0M.AssertModel(models[22],_testData[26], false);
                        FlatStringtext0M.AssertModel(models[23],_testData[27], false);
                        FlatStringtext0M.AssertModel(models[24],_testData[28], false);
                        FlatStringtext0M.AssertModel(models[25],_testData[29], false);
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
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.stringtext0m m
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
FROM dbo.stringtext0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatStringtext0M>();
                var secondItems1 = new List<FlatStringtext0M>();
                var secondItems2 = new List<FlatStringtext0M>();
                await ((IStringSingleTypetext)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 105, query1, 114, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatStringtext0M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatStringtext0M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatStringtext0M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatStringtext0M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatStringtext0M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatStringtext0M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatStringtext0M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatStringtext0M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatStringtext0M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatStringtext0M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatStringtext0M.AssertModel(firstItems1[10],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatStringtext0M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatStringtext0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatStringtext0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatStringtext0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatStringtext0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatStringtext0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatStringtext0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatStringtext0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatStringtext0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatStringtext0M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatStringtext0M.AssertModel(secondItems2[9],_testData[30], false);
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
FROM dbo.stringtext0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IStringSingleTypetext)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatStringtext0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelBatchTest()
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
FROM dbo.stringtext0m m
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
FROM dbo.stringtext0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IStringSingleTypetext)this).DbConnectionSTDynQuerySelectModelBatch(connection, 64, query1, 114, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatStringtext0M.AssertModel(models[0],_testData[12], false);
                        FlatStringtext0M.AssertModel(models[1],_testData[13], false);
                        FlatStringtext0M.AssertModel(models[2],_testData[14], false);
                        FlatStringtext0M.AssertModel(models[3],_testData[15], false);
                        FlatStringtext0M.AssertModel(models[4],_testData[16], false);
                        FlatStringtext0M.AssertModel(models[5],_testData[17], false);
                        FlatStringtext0M.AssertModel(models[6],_testData[18], false);
                        FlatStringtext0M.AssertModel(models[7],_testData[19], false);
                        FlatStringtext0M.AssertModel(models[8],_testData[20], false);
                        FlatStringtext0M.AssertModel(models[9],_testData[21], false);
                        FlatStringtext0M.AssertModel(models[10],_testData[22], false);
                        FlatStringtext0M.AssertModel(models[11],_testData[23], false);
                        FlatStringtext0M.AssertModel(models[12],_testData[24], false);
                        FlatStringtext0M.AssertModel(models[13],_testData[25], false);
                        FlatStringtext0M.AssertModel(models[14],_testData[26], false);
                        FlatStringtext0M.AssertModel(models[15],_testData[27], false);
                        FlatStringtext0M.AssertModel(models[16],_testData[28], false);
                        FlatStringtext0M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatStringtext0M.AssertModel(models[0],_testData[20], false);
                        FlatStringtext0M.AssertModel(models[1],_testData[21], false);
                        FlatStringtext0M.AssertModel(models[2],_testData[22], false);
                        FlatStringtext0M.AssertModel(models[3],_testData[23], false);
                        FlatStringtext0M.AssertModel(models[4],_testData[24], false);
                        FlatStringtext0M.AssertModel(models[5],_testData[25], false);
                        FlatStringtext0M.AssertModel(models[6],_testData[26], false);
                        FlatStringtext0M.AssertModel(models[7],_testData[27], false);
                        FlatStringtext0M.AssertModel(models[8],_testData[28], false);
                        FlatStringtext0M.AssertModel(models[9],_testData[29], false);
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
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.stringtext0m m
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
FROM dbo.stringtext0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatStringtext0M>();
                var secondItems1 = new List<FlatStringtext0M>();
                var secondItems2 = new List<FlatStringtext0M>();
                 ((IStringSingleTypetext)this).DbConnectionDynQuerySelectModelBatch(connection, 42, query1, 28, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                        FlatStringtext0M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatStringtext0M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatStringtext0M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatStringtext0M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatStringtext0M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatStringtext0M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatStringtext0M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatStringtext0M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatStringtext0M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatStringtext0M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatStringtext0M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatStringtext0M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatStringtext0M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatStringtext0M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatStringtext0M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatStringtext0M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatStringtext0M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatStringtext0M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatStringtext0M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatStringtext0M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatStringtext0M.AssertModel(firstItems1[20],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatStringtext0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatStringtext0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatStringtext0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatStringtext0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatStringtext0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatStringtext0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatStringtext0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatStringtext0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatStringtext0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatStringtext0M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatStringtext0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatStringtext0M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatStringtext0M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatStringtext0M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatStringtext0M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatStringtext0M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatStringtext0M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatStringtext0M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatStringtext0M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatStringtext0M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatStringtext0M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatStringtext0M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatStringtext0M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatStringtext0M.AssertModel(secondItems2[22],_testData[30], false);
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
FROM dbo.stringtext0m m
LEFT JOIN dbo.stringtext0mi mi ON mi.id = m.stringtext0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Stringtext0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringSingleTypetext)),
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
            asPartInterface: typeof(IStringSingleTypetext)),
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
                var models = await((IStringSingleTypetext)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Stringtext0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IStringSingleTypetext)this).DbConnectionSTSelectModelBatchAsync(connection, 152, 119))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        Stringtext0M.AssertModel(models[0],_testData[28], false);
                        Stringtext0M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        Stringtext0M.AssertModel(models[0],_testData[21], false);
                        Stringtext0M.AssertModel(models[1],_testData[22], false);
                        Stringtext0M.AssertModel(models[2],_testData[23], false);
                        Stringtext0M.AssertModel(models[3],_testData[24], false);
                        Stringtext0M.AssertModel(models[4],_testData[25], false);
                        Stringtext0M.AssertModel(models[5],_testData[26], false);
                        Stringtext0M.AssertModel(models[6],_testData[27], false);
                        Stringtext0M.AssertModel(models[7],_testData[28], false);
                        Stringtext0M.AssertModel(models[8],_testData[29], false);
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
                var models = ((IStringSingleTypetext)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Stringtext0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IStringSingleTypetext)this).DbConnectionSTSelectModelBatch(connection, 132, 25))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        Stringtext0M.AssertModel(models[0],_testData[24], false);
                        Stringtext0M.AssertModel(models[1],_testData[25], false);
                        Stringtext0M.AssertModel(models[2],_testData[26], false);
                        Stringtext0M.AssertModel(models[3],_testData[27], false);
                        Stringtext0M.AssertModel(models[4],_testData[28], false);
                        Stringtext0M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        Stringtext0M.AssertModel(models[0],_testData[6], false);
                        Stringtext0M.AssertModel(models[1],_testData[7], false);
                        Stringtext0M.AssertModel(models[2],_testData[8], false);
                        Stringtext0M.AssertModel(models[3],_testData[9], false);
                        Stringtext0M.AssertModel(models[4],_testData[10], false);
                        Stringtext0M.AssertModel(models[5],_testData[11], false);
                        Stringtext0M.AssertModel(models[6],_testData[12], false);
                        Stringtext0M.AssertModel(models[7],_testData[13], false);
                        Stringtext0M.AssertModel(models[8],_testData[14], false);
                        Stringtext0M.AssertModel(models[9],_testData[15], false);
                        Stringtext0M.AssertModel(models[10],_testData[16], false);
                        Stringtext0M.AssertModel(models[11],_testData[17], false);
                        Stringtext0M.AssertModel(models[12],_testData[18], false);
                        Stringtext0M.AssertModel(models[13],_testData[19], false);
                        Stringtext0M.AssertModel(models[14],_testData[20], false);
                        Stringtext0M.AssertModel(models[15],_testData[21], false);
                        Stringtext0M.AssertModel(models[16],_testData[22], false);
                        Stringtext0M.AssertModel(models[17],_testData[23], false);
                        Stringtext0M.AssertModel(models[18],_testData[24], false);
                        Stringtext0M.AssertModel(models[19],_testData[25], false);
                        Stringtext0M.AssertModel(models[20],_testData[26], false);
                        Stringtext0M.AssertModel(models[21],_testData[27], false);
                        Stringtext0M.AssertModel(models[22],_testData[28], false);
                        Stringtext0M.AssertModel(models[23],_testData[29], false);
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
                await using var cmd = await ((IStringSingleTypetext)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IStringSingleTypetext)this).SetDbConnectionSelectModelParametrs(cmd, 48);
                var models = await ((IStringSingleTypetext)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(20));
Stringtext0M.AssertModel(models[0],_testData[10], false);Stringtext0M.AssertModel(models[1],_testData[11], false);Stringtext0M.AssertModel(models[2],_testData[12], false);Stringtext0M.AssertModel(models[3],_testData[13], false);Stringtext0M.AssertModel(models[4],_testData[14], false);Stringtext0M.AssertModel(models[5],_testData[15], false);Stringtext0M.AssertModel(models[6],_testData[16], false);Stringtext0M.AssertModel(models[7],_testData[17], false);Stringtext0M.AssertModel(models[8],_testData[18], false);Stringtext0M.AssertModel(models[9],_testData[19], false);Stringtext0M.AssertModel(models[10],_testData[20], false);Stringtext0M.AssertModel(models[11],_testData[21], false);Stringtext0M.AssertModel(models[12],_testData[22], false);Stringtext0M.AssertModel(models[13],_testData[23], false);Stringtext0M.AssertModel(models[14],_testData[24], false);Stringtext0M.AssertModel(models[15],_testData[25], false);Stringtext0M.AssertModel(models[16],_testData[26], false);Stringtext0M.AssertModel(models[17],_testData[27], false);Stringtext0M.AssertModel(models[18],_testData[28], false);Stringtext0M.AssertModel(models[19],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IStringSingleTypetext)this).CreateDbConnectionSelectModelCommand(connection);
                ((IStringSingleTypetext)this).SetDbConnectionSelectModelParametrs(cmd, 133);
                var models =  ((IStringSingleTypetext)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(5));
Stringtext0M.AssertModel(models[0],_testData[25], false);Stringtext0M.AssertModel(models[1],_testData[26], false);Stringtext0M.AssertModel(models[2],_testData[27], false);Stringtext0M.AssertModel(models[3],_testData[28], false);Stringtext0M.AssertModel(models[4],_testData[29], false);
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
FROM dbo.stringtext0m m
LEFT JOIN dbo.stringtext0mi mi ON mi.id = m.stringtext0mi_id
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
            asPartInterface: typeof(IStringSingleTypetext))]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IStringSingleTypetext)this).DbConnectionSelectModelToObjArrAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("ijsijrqksxrxctdsl")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("dfbiekojy")));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((11)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("rjle")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("csrto")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("r")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("xejnvxvsmoajwldbeerq")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((4)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("alvpovy")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("vhohi")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("ctjtvi")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("r")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("uswwgouilxsdoloaxmqyxmmrw")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("outqjn")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("qwxmhpxcyevf")));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("jbxtdjxpj")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("hblkkbisqttglbilvso")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("mneyeriqtykchbjwdmhel")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("eoeoofonoxfonedvvqtqivifyviis")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("wnqmslhehwalefhfprecrqbmot")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("sfdsev")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("bmnbkdffmjjnwrx")));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("jhdgswoppsqhprdkfenlhw")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("laahilwiayguuslxwilcbxyaw")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("d")));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("smolsd")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("gfmqp")));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("daknskcbrobvmjurfjbgaqlcp")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("ffoflqdvtbyrdx")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("kpimqjbhwjqqypauqmnnv")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("rbqdqpgnawrvffaslslbuc")));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("qtvptgxrg")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("cymkwwhhflggpckcaextil")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("ljqrwmenmgoofignepphrissvdqqm")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("xkcorueofx")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("yrbuwsye")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("wnf")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("rkqbtrgvcowasvy")));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("gjdrnkvwhtxoxb")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("wlavwatvgthcrnakr")));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("yvehrfl")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("jxypuumalypfjtymklbfuu")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("hcdacbmsdxphsmgbhkrscyps")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("oo")));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("v")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("poykqdidrdyssgpderce")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("fhfgbhboidgaqerbqlwvvimgdodd")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("b")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("ohlprvncvjbalivwktvjecdrw")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((50)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("xjiprrvlfbgfdjogfaqvniwm")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("sajxxcnbahvqiavppk")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("qmeathyystdtpsxgxrnyb")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("pydnvrjbmitntqnclgvmtdwftq")));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("ssixmuoqlrnearhubackt")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("pprals")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("tofeihetqfwxjieuhsnl")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("phkwyyuqvopiqbvfhmalfjrqtvdr")));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((145)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("bdtxklogrmyvaplgwpbcvlff")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((152)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("ehrsxmw")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("yhvwrwujbgjbgpycfgxtls")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("tof")));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("v")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("sjqgxycgjqu")));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((158)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("vsscopoa")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("lueffvpbbofketjisdwbsagdu")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("npclsqxwrhorfvk")));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((IStringSingleTypetext)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("ijsijrqksxrxctdsl")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("dfbiekojy")));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((11)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("rjle")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("csrto")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("r")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("xejnvxvsmoajwldbeerq")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((4)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("alvpovy")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("vhohi")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("ctjtvi")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("r")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("uswwgouilxsdoloaxmqyxmmrw")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("outqjn")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("qwxmhpxcyevf")));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("jbxtdjxpj")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("hblkkbisqttglbilvso")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("mneyeriqtykchbjwdmhel")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("eoeoofonoxfonedvvqtqivifyviis")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("wnqmslhehwalefhfprecrqbmot")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("sfdsev")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("bmnbkdffmjjnwrx")));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("jhdgswoppsqhprdkfenlhw")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("laahilwiayguuslxwilcbxyaw")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("d")));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("smolsd")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("gfmqp")));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("daknskcbrobvmjurfjbgaqlcp")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("ffoflqdvtbyrdx")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("kpimqjbhwjqqypauqmnnv")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("rbqdqpgnawrvffaslslbuc")));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("qtvptgxrg")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("cymkwwhhflggpckcaextil")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("ljqrwmenmgoofignepphrissvdqqm")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("xkcorueofx")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("yrbuwsye")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("wnf")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("rkqbtrgvcowasvy")));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("gjdrnkvwhtxoxb")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("wlavwatvgthcrnakr")));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("yvehrfl")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("jxypuumalypfjtymklbfuu")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("hcdacbmsdxphsmgbhkrscyps")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("oo")));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("v")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("poykqdidrdyssgpderce")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("fhfgbhboidgaqerbqlwvvimgdodd")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("b")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("ohlprvncvjbalivwktvjecdrw")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((50)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("xjiprrvlfbgfdjogfaqvniwm")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("sajxxcnbahvqiavppk")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("qmeathyystdtpsxgxrnyb")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("pydnvrjbmitntqnclgvmtdwftq")));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("ssixmuoqlrnearhubackt")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("pprals")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("tofeihetqfwxjieuhsnl")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("phkwyyuqvopiqbvfhmalfjrqtvdr")));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((145)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("bdtxklogrmyvaplgwpbcvlff")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((152)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("ehrsxmw")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("yhvwrwujbgjbgpycfgxtls")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("tof")));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("v")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("sjqgxycgjqu")));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((158)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("vsscopoa")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("lueffvpbbofketjisdwbsagdu")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("npclsqxwrhorfvk")));

            }
        }

#endregion

    }
}

