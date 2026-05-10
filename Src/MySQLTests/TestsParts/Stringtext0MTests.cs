

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
    Id = 6,
    Value = "mostetklfynkskkrtxgmpdarubtyr",
    ModelInner = null,
    NullableValue = null,
},
            new Stringtext0M
{
    Id = 13,
    Value = "topqv",
    ModelInner = new Stringtext0MI
{
    Id = 5,
    Value = "pdxmhi",
    NullableValue = null,
},
    NullableValue = null,
},
            new Stringtext0M
{
    Id = 17,
    Value = "vclunrikory",
    ModelInner = null,
    NullableValue = "aahyxajcmnhsglcblgdi",
},
            new Stringtext0M
{
    Id = 21,
    Value = "ffyqctgv",
    ModelInner = new Stringtext0MI
{
    Id = 14,
    Value = "qtatusawriqlwhdaegbciotm",
    NullableValue = "ydodqy",
},
    NullableValue = null,
},
            new Stringtext0M
{
    Id = 26,
    Value = "uxbqhouvwpcylqqxqmhraktana",
    ModelInner = null,
    NullableValue = "xghgmbolbihipwbyepwwanapyw",
},
            new Stringtext0M
{
    Id = 29,
    Value = "ptwhlacjclvttykfkpxvk",
    ModelInner = new Stringtext0MI
{
    Id = 22,
    Value = "yo",
    NullableValue = null,
},
    NullableValue = null,
},
            new Stringtext0M
{
    Id = 37,
    Value = "mujhhejegujaowyqwacikvrfvnkb",
    ModelInner = null,
    NullableValue = "hawrbxphqimyflxshaxmujynv",
},
            new Stringtext0M
{
    Id = 46,
    Value = "jwiypbxubinsixeuggaebd",
    ModelInner = new Stringtext0MI
{
    Id = 23,
    Value = "xqeeougjgpmhtyixqhiuueg",
    NullableValue = null,
},
    NullableValue = "onxnaedrqydmwgilack",
},
            new Stringtext0M
{
    Id = 50,
    Value = "fnvs",
    ModelInner = null,
    NullableValue = "dwpvyqppyyppgwvtxxbxfygswubcu",
},
            new Stringtext0M
{
    Id = 56,
    Value = "edamoutjxynabeyohqg",
    ModelInner = new Stringtext0MI
{
    Id = 26,
    Value = "uitmdued",
    NullableValue = "taiarh",
},
    NullableValue = "ftwntw",
},
            new Stringtext0M
{
    Id = 63,
    Value = "ghoykywpgnhcts",
    ModelInner = null,
    NullableValue = "stmsmamnlokqlqqivnhic",
},
            new Stringtext0M
{
    Id = 71,
    Value = "bv",
    ModelInner = new Stringtext0MI
{
    Id = 31,
    Value = "cgsinepnxwqjabdjb",
    NullableValue = null,
},
    NullableValue = null,
},
            new Stringtext0M
{
    Id = 72,
    Value = "uu",
    ModelInner = null,
    NullableValue = "dhuxbjhgmrdduiqrf",
},
            new Stringtext0M
{
    Id = 81,
    Value = "th",
    ModelInner = new Stringtext0MI
{
    Id = 36,
    Value = "bn",
    NullableValue = "tegumgd",
},
    NullableValue = "v",
},
            new Stringtext0M
{
    Id = 90,
    Value = "wvrpehilo",
    ModelInner = null,
    NullableValue = "",
},
            new Stringtext0M
{
    Id = 98,
    Value = "eyscyxijmugfabbcgsfavgvwr",
    ModelInner = new Stringtext0MI
{
    Id = 40,
    Value = "ybmfkwiplpsjyywkm",
    NullableValue = "mhmmmjeloicc",
},
    NullableValue = "xdekukgwoxslivgrpiacnhudcs",
},
            new Stringtext0M
{
    Id = 107,
    Value = "dqxvwecjtwsyfrgdvwu",
    ModelInner = null,
    NullableValue = "netp",
},
            new Stringtext0M
{
    Id = 112,
    Value = "movohrccvxxdjrpx",
    ModelInner = new Stringtext0MI
{
    Id = 45,
    Value = "",
    NullableValue = null,
},
    NullableValue = null,
},
            new Stringtext0M
{
    Id = 114,
    Value = "ojdkueutmkmahasgomqnlv",
    ModelInner = null,
    NullableValue = null,
},
            new Stringtext0M
{
    Id = 118,
    Value = "cmbaornkqjobwccdlplmgawoag",
    ModelInner = new Stringtext0MI
{
    Id = 48,
    Value = "eph",
    NullableValue = null,
},
    NullableValue = null,
},
            new Stringtext0M
{
    Id = 119,
    Value = "wpwsogjlujyqoocn",
    ModelInner = null,
    NullableValue = null,
},
            new Stringtext0M
{
    Id = 125,
    Value = "elojswbvqprcr",
    ModelInner = new Stringtext0MI
{
    Id = 55,
    Value = "wxktahjwmaqh",
    NullableValue = null,
},
    NullableValue = "agmfkfqy",
},
            new Stringtext0M
{
    Id = 126,
    Value = "covvpbhymqenuhsccqnvm",
    ModelInner = null,
    NullableValue = "qvwnpsmsuxpyhmllksrgyhsbc",
},
            new Stringtext0M
{
    Id = 135,
    Value = "v",
    ModelInner = new Stringtext0MI
{
    Id = 64,
    Value = "hognqawktlsjicoexa",
    NullableValue = null,
},
    NullableValue = "fhfjqgjxeusmugfoyeykmsxk",
},
            new Stringtext0M
{
    Id = 140,
    Value = "qvfxpsxytdcrxqf",
    ModelInner = null,
    NullableValue = null,
},
            new Stringtext0M
{
    Id = 148,
    Value = "tfyvagtvhuinmgqsj",
    ModelInner = new Stringtext0MI
{
    Id = 72,
    Value = "ritcxdayssdkabsxk",
    NullableValue = null,
},
    NullableValue = "oeotfouyjwyfqnfwqjecsocoqiqa",
},
            new Stringtext0M
{
    Id = 150,
    Value = "ohwnhiorrweifptbkcmux",
    ModelInner = null,
    NullableValue = "okflnkkxrmxdsh",
},
            new Stringtext0M
{
    Id = 155,
    Value = "",
    ModelInner = new Stringtext0MI
{
    Id = 77,
    Value = "qavatdpholuycqa",
    NullableValue = "ojnwqsm",
},
    NullableValue = "dwhqdqxbiqgqomsquscsgxtbl",
},
            new Stringtext0M
{
    Id = 164,
    Value = "loq",
    ModelInner = null,
    NullableValue = null,
},
            new Stringtext0M
{
    Id = 165,
    Value = "cvitf",
    ModelInner = new Stringtext0MI
{
    Id = 82,
    Value = "yjybyjmspvrwphht",
    NullableValue = null,
},
    NullableValue = "wlqgneqpongmavbgdjcmqkhcfhev",
},
            new Stringtext0M
{
    Id = 166,
    Value = "crkdpesusmkmtefpqxaconk",
    ModelInner = null,
    NullableValue = null,
},
            new Stringtext0M
{
    Id = 170,
    Value = "pjbewamd",
    ModelInner = new Stringtext0MI
{
    Id = 89,
    Value = "kprinyvvmtmwhbbcvbahwm",
    NullableValue = null,
},
    NullableValue = null,
},
            new Stringtext0M
{
    Id = 177,
    Value = "jfnneitkxeaescr",
    ModelInner = null,
    NullableValue = "wcsjlgoxfoncbovjymv",
},
            new Stringtext0M
{
    Id = 180,
    Value = "xo",
    ModelInner = new Stringtext0MI
{
    Id = 91,
    Value = "lchqcs",
    NullableValue = "hgr",
},
    NullableValue = "oqmwsaibyhbxdfurlfbdua",
},
            new Stringtext0M
{
    Id = 183,
    Value = "mybgdtcfadelchgktq",
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.MySqlConnector.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.stringtext0mi(
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
            asPartInterface: typeof(IStringSingleTypetext)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                parametrName: "id",
                methodParametrName: "id", 
                dbType: (MySqlConnector.MySqlDbType)(3)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.String),
                parametrName: "value",
                methodParametrName: "value",
                dbType: (MySqlConnector.MySqlDbType)(752)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.String), 
                parametrName: "nullablevalue",
                methodParametrName: "nullablevalue",
                dbType: (MySqlConnector.MySqlDbType)(752))]
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
INSERT INTO gedaqtests.stringtext0mi(
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
                dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.String), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(16)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.String), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(16), 
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

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertInnerModelAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertInnerModelAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.MySqlConnector.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.stringtext0m(
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
            sourceType: SourceType.MySqlConnection,
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringSingleTypetext)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (MySqlConnector.MySqlDbType)(3)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.String), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (MySqlConnector.MySqlDbType)(752)),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.String), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (MySqlConnector.MySqlDbType)(752),
                nullable: true),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "stringtext0mi_id", 
                methodParametrName: "stringtext0mi_id", 
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
INSERT INTO gedaqtests.stringtext0m(
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
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.String), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(16)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.String), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(16),
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "stringtext0mi_id", 
                methodParametrName: "stringtext0mi_id", 
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

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertModelAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertModelAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertModelAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertModelAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertModelAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatStringtext0M), typeof(FlatStringtext0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringSingleTypetext)),
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
FROM gedaqtests.stringtext0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatStringtext0M>();
                var models2 = new List<FlatStringtext0M>();
                await((IStringSingleTypetext)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatStringtext0M.AssertModel(models1[i],_testData[i], false);
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
FROM gedaqtests.stringtext0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatStringtext0M>();
                var models2 = new List<FlatStringtext0M>();
                ((IStringSingleTypetext)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatStringtext0M.AssertModel(models1[i],_testData[i], false);
                    FlatStringtext0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatStringtext0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringSingleTypetext)),
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
FROM gedaqtests.stringtext0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
                var models = await((IStringSingleTypetext)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
FROM gedaqtests.stringtext0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
                var models = ((IStringSingleTypetext)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatStringtext0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.stringtext0m m
LEFT JOIN gedaqtests.stringtext0mi mi ON mi.id = m.stringtext0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            sourceType: SourceType.MySqlConnection,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Stringtext0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringSingleTypetext)),
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
                var models = await((IStringSingleTypetext)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
                var models = ((IStringSingleTypetext)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Stringtext0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatStringtext0M), typeof(FlatStringtext0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringSingleTypetext)),
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
FROM gedaqtests.stringtext0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatStringtext0M>();
                var models2 = new List<FlatStringtext0M>();
                await((IStringSingleTypetext)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatStringtext0M.AssertModel(models1[i],_testData[i], false);
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
FROM gedaqtests.stringtext0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatStringtext0M>();
                var models2 = new List<FlatStringtext0M>();
                ((IStringSingleTypetext)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatStringtext0M.AssertModel(models1[i],_testData[i], false);
                    FlatStringtext0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatStringtext0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringSingleTypetext)),
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
FROM gedaqtests.stringtext0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IStringSingleTypetext)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
FROM gedaqtests.stringtext0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IStringSingleTypetext)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatStringtext0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.stringtext0m m
LEFT JOIN gedaqtests.stringtext0mi mi ON mi.id = m.stringtext0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            sourceType: SourceType.MySqlConnection,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Stringtext0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringSingleTypetext)),
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
                var models = await((IStringSingleTypetext)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
FROM gedaqtests.stringtext0m m
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatStringtext0M.AssertModel(models1[i],_testData[i], false);
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 21;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 118;
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
FROM gedaqtests.stringtext0m m
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
FROM gedaqtests.stringtext0m m
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
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatStringtext0M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatStringtext0M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatStringtext0M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatStringtext0M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatStringtext0M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatStringtext0M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatStringtext0M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatStringtext0M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatStringtext0M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatStringtext0M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatStringtext0M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatStringtext0M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatStringtext0M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatStringtext0M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatStringtext0M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatStringtext0M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatStringtext0M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatStringtext0M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatStringtext0M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatStringtext0M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatStringtext0M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatStringtext0M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatStringtext0M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatStringtext0M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatStringtext0M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatStringtext0M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatStringtext0M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatStringtext0M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatStringtext0M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatStringtext0M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatStringtext0M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatStringtext0M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatStringtext0M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatStringtext0M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatStringtext0M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatStringtext0M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatStringtext0M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatStringtext0M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatStringtext0M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatStringtext0M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatStringtext0M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatStringtext0M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatStringtext0M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatStringtext0M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatStringtext0M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatStringtext0M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatStringtext0M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatStringtext0M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatStringtext0M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatStringtext0M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatStringtext0M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatStringtext0M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatStringtext0M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatStringtext0M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatStringtext0M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatStringtext0M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatStringtext0M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatStringtext0M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatStringtext0M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatStringtext0M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatStringtext0M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatStringtext0M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatStringtext0M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatStringtext0M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatStringtext0M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatStringtext0M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatStringtext0M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatStringtext0M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatStringtext0M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatStringtext0M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatStringtext0M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatStringtext0M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatStringtext0M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatStringtext0M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatStringtext0M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatStringtext0M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatStringtext0M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatStringtext0M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatStringtext0M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatStringtext0M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatStringtext0M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatStringtext0M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatStringtext0M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatStringtext0M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatStringtext0M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatStringtext0M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatStringtext0M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatStringtext0M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatStringtext0M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatStringtext0M.AssertModel(secondItems2[14],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 126;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 140;
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
FROM gedaqtests.stringtext0m m
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
FROM gedaqtests.stringtext0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatStringtext0M>();
                var firstItems2 = new List<FlatStringtext0M>();
                var secondItems1 = new List<FlatStringtext0M>();
                await ((IStringSingleTypetext)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatStringtext0M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatStringtext0M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatStringtext0M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatStringtext0M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatStringtext0M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatStringtext0M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatStringtext0M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatStringtext0M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatStringtext0M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatStringtext0M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatStringtext0M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatStringtext0M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatStringtext0M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatStringtext0M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatStringtext0M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatStringtext0M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatStringtext0M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatStringtext0M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatStringtext0M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatStringtext0M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatStringtext0M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatStringtext0M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatStringtext0M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatStringtext0M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                        FlatStringtext0M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatStringtext0M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatStringtext0M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatStringtext0M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatStringtext0M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatStringtext0M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatStringtext0M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatStringtext0M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatStringtext0M.AssertModel(secondItems1[9],_testData[34], false);
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
FROM gedaqtests.stringtext0m m
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatStringtext0M.AssertModel(models1[i],_testData[i], false);
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 164;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 155;
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
FROM gedaqtests.stringtext0m m
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
FROM gedaqtests.stringtext0m m
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
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatStringtext0M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatStringtext0M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatStringtext0M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatStringtext0M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatStringtext0M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatStringtext0M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatStringtext0M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatStringtext0M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatStringtext0M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatStringtext0M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatStringtext0M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatStringtext0M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatStringtext0M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatStringtext0M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatStringtext0M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatStringtext0M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatStringtext0M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatStringtext0M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatStringtext0M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatStringtext0M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatStringtext0M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatStringtext0M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatStringtext0M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatStringtext0M.AssertModel(secondItems2[6],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 170;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 50;
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
FROM gedaqtests.stringtext0m m
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
FROM gedaqtests.stringtext0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatStringtext0M>();
                var firstItems2 = new List<FlatStringtext0M>();
                var secondItems1 = new List<FlatStringtext0M>();
                 ((IStringSingleTypetext)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatStringtext0M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatStringtext0M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatStringtext0M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatStringtext0M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatStringtext0M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatStringtext0M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                        FlatStringtext0M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatStringtext0M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatStringtext0M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatStringtext0M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatStringtext0M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatStringtext0M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatStringtext0M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatStringtext0M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatStringtext0M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatStringtext0M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatStringtext0M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatStringtext0M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatStringtext0M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatStringtext0M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatStringtext0M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatStringtext0M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatStringtext0M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatStringtext0M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatStringtext0M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatStringtext0M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatStringtext0M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatStringtext0M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatStringtext0M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatStringtext0M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatStringtext0M.AssertModel(secondItems1[25],_testData[34], false);
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
FROM gedaqtests.stringtext0m m
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 126;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 148;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.stringtext0m m
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
FROM gedaqtests.stringtext0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IStringSingleTypetext)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatStringtext0M.AssertModel(models[0],_testData[23], false);
                        FlatStringtext0M.AssertModel(models[1],_testData[24], false);
                        FlatStringtext0M.AssertModel(models[2],_testData[25], false);
                        FlatStringtext0M.AssertModel(models[3],_testData[26], false);
                        FlatStringtext0M.AssertModel(models[4],_testData[27], false);
                        FlatStringtext0M.AssertModel(models[5],_testData[28], false);
                        FlatStringtext0M.AssertModel(models[6],_testData[29], false);
                        FlatStringtext0M.AssertModel(models[7],_testData[30], false);
                        FlatStringtext0M.AssertModel(models[8],_testData[31], false);
                        FlatStringtext0M.AssertModel(models[9],_testData[32], false);
                        FlatStringtext0M.AssertModel(models[10],_testData[33], false);
                        FlatStringtext0M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatStringtext0M.AssertModel(models[0],_testData[26], false);
                        FlatStringtext0M.AssertModel(models[1],_testData[27], false);
                        FlatStringtext0M.AssertModel(models[2],_testData[28], false);
                        FlatStringtext0M.AssertModel(models[3],_testData[29], false);
                        FlatStringtext0M.AssertModel(models[4],_testData[30], false);
                        FlatStringtext0M.AssertModel(models[5],_testData[31], false);
                        FlatStringtext0M.AssertModel(models[6],_testData[32], false);
                        FlatStringtext0M.AssertModel(models[7],_testData[33], false);
                        FlatStringtext0M.AssertModel(models[8],_testData[34], false);
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
                parametr1.Value = 107;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 177;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.stringtext0m m
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
FROM gedaqtests.stringtext0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatStringtext0M>();
                var secondItems1 = new List<FlatStringtext0M>();
                var secondItems2 = new List<FlatStringtext0M>();
                await ((IStringSingleTypetext)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                        FlatStringtext0M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatStringtext0M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatStringtext0M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatStringtext0M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatStringtext0M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatStringtext0M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatStringtext0M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatStringtext0M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatStringtext0M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatStringtext0M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatStringtext0M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatStringtext0M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatStringtext0M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatStringtext0M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatStringtext0M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatStringtext0M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatStringtext0M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatStringtext0M.AssertModel(firstItems1[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatStringtext0M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatStringtext0M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatStringtext0M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatStringtext0M.AssertModel(secondItems2[1],_testData[34], false);
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
FROM gedaqtests.stringtext0m m
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 63;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 150;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.stringtext0m m
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
FROM gedaqtests.stringtext0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IStringSingleTypetext)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatStringtext0M.AssertModel(models[0],_testData[11], false);
                        FlatStringtext0M.AssertModel(models[1],_testData[12], false);
                        FlatStringtext0M.AssertModel(models[2],_testData[13], false);
                        FlatStringtext0M.AssertModel(models[3],_testData[14], false);
                        FlatStringtext0M.AssertModel(models[4],_testData[15], false);
                        FlatStringtext0M.AssertModel(models[5],_testData[16], false);
                        FlatStringtext0M.AssertModel(models[6],_testData[17], false);
                        FlatStringtext0M.AssertModel(models[7],_testData[18], false);
                        FlatStringtext0M.AssertModel(models[8],_testData[19], false);
                        FlatStringtext0M.AssertModel(models[9],_testData[20], false);
                        FlatStringtext0M.AssertModel(models[10],_testData[21], false);
                        FlatStringtext0M.AssertModel(models[11],_testData[22], false);
                        FlatStringtext0M.AssertModel(models[12],_testData[23], false);
                        FlatStringtext0M.AssertModel(models[13],_testData[24], false);
                        FlatStringtext0M.AssertModel(models[14],_testData[25], false);
                        FlatStringtext0M.AssertModel(models[15],_testData[26], false);
                        FlatStringtext0M.AssertModel(models[16],_testData[27], false);
                        FlatStringtext0M.AssertModel(models[17],_testData[28], false);
                        FlatStringtext0M.AssertModel(models[18],_testData[29], false);
                        FlatStringtext0M.AssertModel(models[19],_testData[30], false);
                        FlatStringtext0M.AssertModel(models[20],_testData[31], false);
                        FlatStringtext0M.AssertModel(models[21],_testData[32], false);
                        FlatStringtext0M.AssertModel(models[22],_testData[33], false);
                        FlatStringtext0M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatStringtext0M.AssertModel(models[0],_testData[27], false);
                        FlatStringtext0M.AssertModel(models[1],_testData[28], false);
                        FlatStringtext0M.AssertModel(models[2],_testData[29], false);
                        FlatStringtext0M.AssertModel(models[3],_testData[30], false);
                        FlatStringtext0M.AssertModel(models[4],_testData[31], false);
                        FlatStringtext0M.AssertModel(models[5],_testData[32], false);
                        FlatStringtext0M.AssertModel(models[6],_testData[33], false);
                        FlatStringtext0M.AssertModel(models[7],_testData[34], false);
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
                parametr1.Value = 98;
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
FROM gedaqtests.stringtext0m m
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
FROM gedaqtests.stringtext0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatStringtext0M>();
                var secondItems1 = new List<FlatStringtext0M>();
                var secondItems2 = new List<FlatStringtext0M>();
                 ((IStringSingleTypetext)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatStringtext0M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatStringtext0M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatStringtext0M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatStringtext0M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatStringtext0M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatStringtext0M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatStringtext0M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatStringtext0M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatStringtext0M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatStringtext0M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatStringtext0M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatStringtext0M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatStringtext0M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatStringtext0M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatStringtext0M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatStringtext0M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatStringtext0M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatStringtext0M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatStringtext0M.AssertModel(firstItems1[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatStringtext0M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatStringtext0M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatStringtext0M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatStringtext0M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatStringtext0M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatStringtext0M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatStringtext0M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatStringtext0M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatStringtext0M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatStringtext0M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatStringtext0M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatStringtext0M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatStringtext0M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatStringtext0M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatStringtext0M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatStringtext0M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatStringtext0M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatStringtext0M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatStringtext0M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatStringtext0M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatStringtext0M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatStringtext0M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatStringtext0M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatStringtext0M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatStringtext0M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatStringtext0M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatStringtext0M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatStringtext0M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatStringtext0M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatStringtext0M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatStringtext0M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatStringtext0M.AssertModel(secondItems2[16],_testData[34], false);
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
FROM gedaqtests.stringtext0m m
LEFT JOIN gedaqtests.stringtext0mi mi ON mi.id = m.stringtext0mi_id
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 164;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 177;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IStringSingleTypetext)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        Stringtext0M.AssertModel(models[0],_testData[29], false);
                        Stringtext0M.AssertModel(models[1],_testData[30], false);
                        Stringtext0M.AssertModel(models[2],_testData[31], false);
                        Stringtext0M.AssertModel(models[3],_testData[32], false);
                        Stringtext0M.AssertModel(models[4],_testData[33], false);
                        Stringtext0M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        Stringtext0M.AssertModel(models[0],_testData[33], false);
                        Stringtext0M.AssertModel(models[1],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 140;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 125;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IStringSingleTypetext)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        Stringtext0M.AssertModel(models[0],_testData[25], false);
                        Stringtext0M.AssertModel(models[1],_testData[26], false);
                        Stringtext0M.AssertModel(models[2],_testData[27], false);
                        Stringtext0M.AssertModel(models[3],_testData[28], false);
                        Stringtext0M.AssertModel(models[4],_testData[29], false);
                        Stringtext0M.AssertModel(models[5],_testData[30], false);
                        Stringtext0M.AssertModel(models[6],_testData[31], false);
                        Stringtext0M.AssertModel(models[7],_testData[32], false);
                        Stringtext0M.AssertModel(models[8],_testData[33], false);
                        Stringtext0M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        Stringtext0M.AssertModel(models[0],_testData[22], false);
                        Stringtext0M.AssertModel(models[1],_testData[23], false);
                        Stringtext0M.AssertModel(models[2],_testData[24], false);
                        Stringtext0M.AssertModel(models[3],_testData[25], false);
                        Stringtext0M.AssertModel(models[4],_testData[26], false);
                        Stringtext0M.AssertModel(models[5],_testData[27], false);
                        Stringtext0M.AssertModel(models[6],_testData[28], false);
                        Stringtext0M.AssertModel(models[7],_testData[29], false);
                        Stringtext0M.AssertModel(models[8],_testData[30], false);
                        Stringtext0M.AssertModel(models[9],_testData[31], false);
                        Stringtext0M.AssertModel(models[10],_testData[32], false);
                        Stringtext0M.AssertModel(models[11],_testData[33], false);
                        Stringtext0M.AssertModel(models[12],_testData[34], false);
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
            dbType: (System.Data.DbType)(11))]
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
FROM gedaqtests.stringtext0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatStringtext0M>();
                var models2 = new List<FlatStringtext0M>();
                await((IStringSingleTypetext)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatStringtext0M.AssertModel(models1[i],_testData[i], false);
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
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM gedaqtests.stringtext0m m
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
FROM gedaqtests.stringtext0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatStringtext0M>();
                var firstItems2 = new List<FlatStringtext0M>();
                var secondItems1 = new List<FlatStringtext0M>();
                var secondItems2 = new List<FlatStringtext0M>();
                await ((IStringSingleTypetext)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 90, query1, 155, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatStringtext0M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatStringtext0M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatStringtext0M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatStringtext0M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatStringtext0M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatStringtext0M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatStringtext0M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatStringtext0M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatStringtext0M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatStringtext0M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatStringtext0M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatStringtext0M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatStringtext0M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatStringtext0M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatStringtext0M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatStringtext0M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatStringtext0M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatStringtext0M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatStringtext0M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatStringtext0M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatStringtext0M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatStringtext0M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatStringtext0M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatStringtext0M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatStringtext0M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatStringtext0M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatStringtext0M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatStringtext0M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatStringtext0M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatStringtext0M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatStringtext0M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatStringtext0M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatStringtext0M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatStringtext0M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatStringtext0M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatStringtext0M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatStringtext0M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatStringtext0M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatStringtext0M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatStringtext0M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatStringtext0M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatStringtext0M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatStringtext0M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatStringtext0M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatStringtext0M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatStringtext0M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatStringtext0M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatStringtext0M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatStringtext0M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatStringtext0M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatStringtext0M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatStringtext0M.AssertModel(secondItems2[6],_testData[34], false);
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
FROM gedaqtests.stringtext0m m
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
FROM gedaqtests.stringtext0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatStringtext0M>();
                var firstItems2 = new List<FlatStringtext0M>();
                var secondItems1 = new List<FlatStringtext0M>();
                await ((IStringSingleTypetext)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 170, query1, 90, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatStringtext0M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatStringtext0M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatStringtext0M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatStringtext0M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatStringtext0M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatStringtext0M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatStringtext0M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatStringtext0M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatStringtext0M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatStringtext0M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatStringtext0M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatStringtext0M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatStringtext0M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatStringtext0M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatStringtext0M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatStringtext0M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatStringtext0M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatStringtext0M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatStringtext0M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatStringtext0M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatStringtext0M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatStringtext0M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatStringtext0M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatStringtext0M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatStringtext0M.AssertModel(secondItems1[19],_testData[34], false);
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
FROM gedaqtests.stringtext0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatStringtext0M>();
                var models2 = new List<FlatStringtext0M>();
                ((IStringSingleTypetext)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatStringtext0M.AssertModel(models1[i],_testData[i], false);
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
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM gedaqtests.stringtext0m m
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
FROM gedaqtests.stringtext0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatStringtext0M>();
                var firstItems2 = new List<FlatStringtext0M>();
                var secondItems1 = new List<FlatStringtext0M>();
                var secondItems2 = new List<FlatStringtext0M>();
                 ((IStringSingleTypetext)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 170, query1, 21, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatStringtext0M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatStringtext0M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatStringtext0M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatStringtext0M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatStringtext0M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatStringtext0M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatStringtext0M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatStringtext0M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatStringtext0M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatStringtext0M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatStringtext0M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatStringtext0M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatStringtext0M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatStringtext0M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatStringtext0M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatStringtext0M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatStringtext0M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatStringtext0M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatStringtext0M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatStringtext0M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatStringtext0M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatStringtext0M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatStringtext0M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatStringtext0M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatStringtext0M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatStringtext0M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatStringtext0M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatStringtext0M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatStringtext0M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatStringtext0M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatStringtext0M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatStringtext0M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatStringtext0M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatStringtext0M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatStringtext0M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatStringtext0M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatStringtext0M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatStringtext0M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatStringtext0M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatStringtext0M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatStringtext0M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatStringtext0M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatStringtext0M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatStringtext0M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatStringtext0M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatStringtext0M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatStringtext0M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatStringtext0M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatStringtext0M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatStringtext0M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatStringtext0M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatStringtext0M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatStringtext0M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatStringtext0M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatStringtext0M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatStringtext0M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatStringtext0M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatStringtext0M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatStringtext0M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatStringtext0M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatStringtext0M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatStringtext0M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatStringtext0M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatStringtext0M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatStringtext0M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatStringtext0M.AssertModel(secondItems2[30],_testData[34], false);
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
FROM gedaqtests.stringtext0m m
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
FROM gedaqtests.stringtext0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatStringtext0M>();
                var firstItems2 = new List<FlatStringtext0M>();
                var secondItems1 = new List<FlatStringtext0M>();
                 ((IStringSingleTypetext)this).DbConnectionMMDynQuerySelectModelBatch(connection, 98, query1, 118, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatStringtext0M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatStringtext0M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatStringtext0M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatStringtext0M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatStringtext0M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatStringtext0M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatStringtext0M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatStringtext0M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatStringtext0M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatStringtext0M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatStringtext0M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatStringtext0M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatStringtext0M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatStringtext0M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatStringtext0M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatStringtext0M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatStringtext0M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatStringtext0M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatStringtext0M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatStringtext0M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatStringtext0M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatStringtext0M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatStringtext0M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatStringtext0M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatStringtext0M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatStringtext0M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatStringtext0M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatStringtext0M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatStringtext0M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatStringtext0M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatStringtext0M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatStringtext0M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatStringtext0M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatStringtext0M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatStringtext0M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatStringtext0M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatStringtext0M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatStringtext0M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
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
                        FlatStringtext0M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatStringtext0M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatStringtext0M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatStringtext0M.AssertModel(secondItems1[14],_testData[34], false);
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
            dbType: (System.Data.DbType)(11))]
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
FROM gedaqtests.stringtext0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IStringSingleTypetext)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.stringtext0m m
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
FROM gedaqtests.stringtext0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IStringSingleTypetext)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 170, query1, 107, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatStringtext0M.AssertModel(models[0],_testData[32], false);
                        FlatStringtext0M.AssertModel(models[1],_testData[33], false);
                        FlatStringtext0M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

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
                        FlatStringtext0M.AssertModel(models[13],_testData[30], false);
                        FlatStringtext0M.AssertModel(models[14],_testData[31], false);
                        FlatStringtext0M.AssertModel(models[15],_testData[32], false);
                        FlatStringtext0M.AssertModel(models[16],_testData[33], false);
                        FlatStringtext0M.AssertModel(models[17],_testData[34], false);
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
FROM gedaqtests.stringtext0m m
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
FROM gedaqtests.stringtext0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatStringtext0M>();
                var secondItems1 = new List<FlatStringtext0M>();
                var secondItems2 = new List<FlatStringtext0M>();
                await ((IStringSingleTypetext)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 135, query1, 177, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatStringtext0M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatStringtext0M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatStringtext0M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatStringtext0M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatStringtext0M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatStringtext0M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatStringtext0M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatStringtext0M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatStringtext0M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatStringtext0M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatStringtext0M.AssertModel(firstItems1[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatStringtext0M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatStringtext0M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatStringtext0M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatStringtext0M.AssertModel(secondItems2[1],_testData[34], false);
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
FROM gedaqtests.stringtext0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IStringSingleTypetext)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.stringtext0m m
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
FROM gedaqtests.stringtext0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IStringSingleTypetext)this).DbConnectionSTDynQuerySelectModelBatch(connection, 140, query1, 118, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatStringtext0M.AssertModel(models[0],_testData[25], false);
                        FlatStringtext0M.AssertModel(models[1],_testData[26], false);
                        FlatStringtext0M.AssertModel(models[2],_testData[27], false);
                        FlatStringtext0M.AssertModel(models[3],_testData[28], false);
                        FlatStringtext0M.AssertModel(models[4],_testData[29], false);
                        FlatStringtext0M.AssertModel(models[5],_testData[30], false);
                        FlatStringtext0M.AssertModel(models[6],_testData[31], false);
                        FlatStringtext0M.AssertModel(models[7],_testData[32], false);
                        FlatStringtext0M.AssertModel(models[8],_testData[33], false);
                        FlatStringtext0M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

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
                        FlatStringtext0M.AssertModel(models[10],_testData[30], false);
                        FlatStringtext0M.AssertModel(models[11],_testData[31], false);
                        FlatStringtext0M.AssertModel(models[12],_testData[32], false);
                        FlatStringtext0M.AssertModel(models[13],_testData[33], false);
                        FlatStringtext0M.AssertModel(models[14],_testData[34], false);
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
FROM gedaqtests.stringtext0m m
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
FROM gedaqtests.stringtext0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatStringtext0M>();
                var secondItems1 = new List<FlatStringtext0M>();
                var secondItems2 = new List<FlatStringtext0M>();
                 ((IStringSingleTypetext)this).DbConnectionDynQuerySelectModelBatch(connection, 63, query1, 71, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatStringtext0M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatStringtext0M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatStringtext0M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatStringtext0M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatStringtext0M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatStringtext0M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatStringtext0M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatStringtext0M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatStringtext0M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatStringtext0M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatStringtext0M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatStringtext0M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatStringtext0M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatStringtext0M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatStringtext0M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatStringtext0M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatStringtext0M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatStringtext0M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatStringtext0M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatStringtext0M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatStringtext0M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatStringtext0M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatStringtext0M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatStringtext0M.AssertModel(firstItems1[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatStringtext0M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatStringtext0M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatStringtext0M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatStringtext0M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatStringtext0M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatStringtext0M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatStringtext0M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatStringtext0M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatStringtext0M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatStringtext0M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatStringtext0M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatStringtext0M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatStringtext0M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatStringtext0M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatStringtext0M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatStringtext0M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatStringtext0M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatStringtext0M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatStringtext0M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatStringtext0M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatStringtext0M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatStringtext0M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatStringtext0M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatStringtext0M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatStringtext0M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatStringtext0M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatStringtext0M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatStringtext0M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatStringtext0M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatStringtext0M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatStringtext0M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatStringtext0M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatStringtext0M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatStringtext0M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatStringtext0M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatStringtext0M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatStringtext0M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatStringtext0M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatStringtext0M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatStringtext0M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatStringtext0M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatStringtext0M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatStringtext0M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatStringtext0M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatStringtext0M.AssertModel(secondItems2[22],_testData[34], false);
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
FROM gedaqtests.stringtext0m m
LEFT JOIN gedaqtests.stringtext0mi mi ON mi.id = m.stringtext0mi_id
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
            dbType: (System.Data.DbType)(11))]
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in await ((IStringSingleTypetext)this).DbConnectionSTSelectModelBatchAsync(connection, 6, 148))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        Stringtext0M.AssertModel(models[0],_testData[1], false);
                        Stringtext0M.AssertModel(models[1],_testData[2], false);
                        Stringtext0M.AssertModel(models[2],_testData[3], false);
                        Stringtext0M.AssertModel(models[3],_testData[4], false);
                        Stringtext0M.AssertModel(models[4],_testData[5], false);
                        Stringtext0M.AssertModel(models[5],_testData[6], false);
                        Stringtext0M.AssertModel(models[6],_testData[7], false);
                        Stringtext0M.AssertModel(models[7],_testData[8], false);
                        Stringtext0M.AssertModel(models[8],_testData[9], false);
                        Stringtext0M.AssertModel(models[9],_testData[10], false);
                        Stringtext0M.AssertModel(models[10],_testData[11], false);
                        Stringtext0M.AssertModel(models[11],_testData[12], false);
                        Stringtext0M.AssertModel(models[12],_testData[13], false);
                        Stringtext0M.AssertModel(models[13],_testData[14], false);
                        Stringtext0M.AssertModel(models[14],_testData[15], false);
                        Stringtext0M.AssertModel(models[15],_testData[16], false);
                        Stringtext0M.AssertModel(models[16],_testData[17], false);
                        Stringtext0M.AssertModel(models[17],_testData[18], false);
                        Stringtext0M.AssertModel(models[18],_testData[19], false);
                        Stringtext0M.AssertModel(models[19],_testData[20], false);
                        Stringtext0M.AssertModel(models[20],_testData[21], false);
                        Stringtext0M.AssertModel(models[21],_testData[22], false);
                        Stringtext0M.AssertModel(models[22],_testData[23], false);
                        Stringtext0M.AssertModel(models[23],_testData[24], false);
                        Stringtext0M.AssertModel(models[24],_testData[25], false);
                        Stringtext0M.AssertModel(models[25],_testData[26], false);
                        Stringtext0M.AssertModel(models[26],_testData[27], false);
                        Stringtext0M.AssertModel(models[27],_testData[28], false);
                        Stringtext0M.AssertModel(models[28],_testData[29], false);
                        Stringtext0M.AssertModel(models[29],_testData[30], false);
                        Stringtext0M.AssertModel(models[30],_testData[31], false);
                        Stringtext0M.AssertModel(models[31],_testData[32], false);
                        Stringtext0M.AssertModel(models[32],_testData[33], false);
                        Stringtext0M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        Stringtext0M.AssertModel(models[0],_testData[26], false);
                        Stringtext0M.AssertModel(models[1],_testData[27], false);
                        Stringtext0M.AssertModel(models[2],_testData[28], false);
                        Stringtext0M.AssertModel(models[3],_testData[29], false);
                        Stringtext0M.AssertModel(models[4],_testData[30], false);
                        Stringtext0M.AssertModel(models[5],_testData[31], false);
                        Stringtext0M.AssertModel(models[6],_testData[32], false);
                        Stringtext0M.AssertModel(models[7],_testData[33], false);
                        Stringtext0M.AssertModel(models[8],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in  ((IStringSingleTypetext)this).DbConnectionSTSelectModelBatch(connection, 107, 114))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        Stringtext0M.AssertModel(models[0],_testData[17], false);
                        Stringtext0M.AssertModel(models[1],_testData[18], false);
                        Stringtext0M.AssertModel(models[2],_testData[19], false);
                        Stringtext0M.AssertModel(models[3],_testData[20], false);
                        Stringtext0M.AssertModel(models[4],_testData[21], false);
                        Stringtext0M.AssertModel(models[5],_testData[22], false);
                        Stringtext0M.AssertModel(models[6],_testData[23], false);
                        Stringtext0M.AssertModel(models[7],_testData[24], false);
                        Stringtext0M.AssertModel(models[8],_testData[25], false);
                        Stringtext0M.AssertModel(models[9],_testData[26], false);
                        Stringtext0M.AssertModel(models[10],_testData[27], false);
                        Stringtext0M.AssertModel(models[11],_testData[28], false);
                        Stringtext0M.AssertModel(models[12],_testData[29], false);
                        Stringtext0M.AssertModel(models[13],_testData[30], false);
                        Stringtext0M.AssertModel(models[14],_testData[31], false);
                        Stringtext0M.AssertModel(models[15],_testData[32], false);
                        Stringtext0M.AssertModel(models[16],_testData[33], false);
                        Stringtext0M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        Stringtext0M.AssertModel(models[0],_testData[19], false);
                        Stringtext0M.AssertModel(models[1],_testData[20], false);
                        Stringtext0M.AssertModel(models[2],_testData[21], false);
                        Stringtext0M.AssertModel(models[3],_testData[22], false);
                        Stringtext0M.AssertModel(models[4],_testData[23], false);
                        Stringtext0M.AssertModel(models[5],_testData[24], false);
                        Stringtext0M.AssertModel(models[6],_testData[25], false);
                        Stringtext0M.AssertModel(models[7],_testData[26], false);
                        Stringtext0M.AssertModel(models[8],_testData[27], false);
                        Stringtext0M.AssertModel(models[9],_testData[28], false);
                        Stringtext0M.AssertModel(models[10],_testData[29], false);
                        Stringtext0M.AssertModel(models[11],_testData[30], false);
                        Stringtext0M.AssertModel(models[12],_testData[31], false);
                        Stringtext0M.AssertModel(models[13],_testData[32], false);
                        Stringtext0M.AssertModel(models[14],_testData[33], false);
                        Stringtext0M.AssertModel(models[15],_testData[34], false);
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
                ((IStringSingleTypetext)this).SetDbConnectionSelectModelParametrs(cmd, 98);
                var models = await ((IStringSingleTypetext)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(19));

                Stringtext0M.AssertModel(models[0],_testData[16], false);
                Stringtext0M.AssertModel(models[1],_testData[17], false);
                Stringtext0M.AssertModel(models[2],_testData[18], false);
                Stringtext0M.AssertModel(models[3],_testData[19], false);
                Stringtext0M.AssertModel(models[4],_testData[20], false);
                Stringtext0M.AssertModel(models[5],_testData[21], false);
                Stringtext0M.AssertModel(models[6],_testData[22], false);
                Stringtext0M.AssertModel(models[7],_testData[23], false);
                Stringtext0M.AssertModel(models[8],_testData[24], false);
                Stringtext0M.AssertModel(models[9],_testData[25], false);
                Stringtext0M.AssertModel(models[10],_testData[26], false);
                Stringtext0M.AssertModel(models[11],_testData[27], false);
                Stringtext0M.AssertModel(models[12],_testData[28], false);
                Stringtext0M.AssertModel(models[13],_testData[29], false);
                Stringtext0M.AssertModel(models[14],_testData[30], false);
                Stringtext0M.AssertModel(models[15],_testData[31], false);
                Stringtext0M.AssertModel(models[16],_testData[32], false);
                Stringtext0M.AssertModel(models[17],_testData[33], false);
                Stringtext0M.AssertModel(models[18],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IStringSingleTypetext)this).CreateDbConnectionSelectModelCommand(connection);
                ((IStringSingleTypetext)this).SetDbConnectionSelectModelParametrs(cmd, 166);
                var models =  ((IStringSingleTypetext)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(4));

                Stringtext0M.AssertModel(models[0],_testData[31], false);
                Stringtext0M.AssertModel(models[1],_testData[32], false);
                Stringtext0M.AssertModel(models[2],_testData[33], false);
                Stringtext0M.AssertModel(models[3],_testData[34], false);
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
FROM gedaqtests.stringtext0m m
LEFT JOIN gedaqtests.stringtext0mi mi ON mi.id = m.stringtext0mi_id
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
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("mostetklfynkskkrtxgmpdarubtyr")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("topqv")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((5)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("pdxmhi")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("vclunrikory")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("aahyxajcmnhsglcblgdi")));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("ffyqctgv")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("qtatusawriqlwhdaegbciotm")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("ydodqy")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("uxbqhouvwpcylqqxqmhraktana")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("xghgmbolbihipwbyepwwanapyw")));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("ptwhlacjclvttykfkpxvk")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("yo")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("mujhhejegujaowyqwacikvrfvnkb")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("hawrbxphqimyflxshaxmujynv")));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("jwiypbxubinsixeuggaebd")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("xqeeougjgpmhtyixqhiuueg")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("onxnaedrqydmwgilack")));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("fnvs")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("dwpvyqppyyppgwvtxxbxfygswubcu")));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("edamoutjxynabeyohqg")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("uitmdued")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("taiarh")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("ftwntw")));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("ghoykywpgnhcts")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("stmsmamnlokqlqqivnhic")));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("bv")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("cgsinepnxwqjabdjb")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("uu")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("dhuxbjhgmrdduiqrf")));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("th")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("bn")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("tegumgd")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("v")));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("wvrpehilo")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("")));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("eyscyxijmugfabbcgsfavgvwr")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("ybmfkwiplpsjyywkm")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("mhmmmjeloicc")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("xdekukgwoxslivgrpiacnhudcs")));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("dqxvwecjtwsyfrgdvwu")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("netp")));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("movohrccvxxdjrpx")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("ojdkueutmkmahasgomqnlv")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("cmbaornkqjobwccdlplmgawoag")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("eph")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("wpwsogjlujyqoocn")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("elojswbvqprcr")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("wxktahjwmaqh")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("agmfkfqy")));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("covvpbhymqenuhsccqnvm")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("qvwnpsmsuxpyhmllksrgyhsbc")));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("v")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("hognqawktlsjicoexa")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("fhfjqgjxeusmugfoyeykmsxk")));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("qvfxpsxytdcrxqf")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("tfyvagtvhuinmgqsj")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("ritcxdayssdkabsxk")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("oeotfouyjwyfqnfwqjecsocoqiqa")));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("ohwnhiorrweifptbkcmux")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("okflnkkxrmxdsh")));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((77)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("qavatdpholuycqa")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("ojnwqsm")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("dwhqdqxbiqgqomsquscsgxtbl")));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((164)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("loq")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((165)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("cvitf")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((82)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("yjybyjmspvrwphht")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("wlqgneqpongmavbgdjcmqkhcfhev")));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((166)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("crkdpesusmkmtefpqxaconk")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((170)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("pjbewamd")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((89)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("kprinyvvmtmwhbbcvbahwm")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((177)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("jfnneitkxeaescr")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("wcsjlgoxfoncbovjymv")));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((180)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("xo")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((91)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("lchqcs")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("hgr")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("oqmwsaibyhbxdfurlfbdua")));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((183)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("mybgdtcfadelchgktq")));//Value

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
                var models =  ((IStringSingleTypetext)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("mostetklfynkskkrtxgmpdarubtyr")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("topqv")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((5)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("pdxmhi")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("vclunrikory")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("aahyxajcmnhsglcblgdi")));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("ffyqctgv")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("qtatusawriqlwhdaegbciotm")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("ydodqy")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("uxbqhouvwpcylqqxqmhraktana")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("xghgmbolbihipwbyepwwanapyw")));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("ptwhlacjclvttykfkpxvk")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("yo")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("mujhhejegujaowyqwacikvrfvnkb")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("hawrbxphqimyflxshaxmujynv")));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("jwiypbxubinsixeuggaebd")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("xqeeougjgpmhtyixqhiuueg")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("onxnaedrqydmwgilack")));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("fnvs")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("dwpvyqppyyppgwvtxxbxfygswubcu")));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("edamoutjxynabeyohqg")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("uitmdued")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("taiarh")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("ftwntw")));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("ghoykywpgnhcts")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("stmsmamnlokqlqqivnhic")));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("bv")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("cgsinepnxwqjabdjb")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("uu")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("dhuxbjhgmrdduiqrf")));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("th")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("bn")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("tegumgd")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("v")));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("wvrpehilo")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("")));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("eyscyxijmugfabbcgsfavgvwr")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("ybmfkwiplpsjyywkm")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("mhmmmjeloicc")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("xdekukgwoxslivgrpiacnhudcs")));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("dqxvwecjtwsyfrgdvwu")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("netp")));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("movohrccvxxdjrpx")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("ojdkueutmkmahasgomqnlv")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("cmbaornkqjobwccdlplmgawoag")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("eph")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("wpwsogjlujyqoocn")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("elojswbvqprcr")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("wxktahjwmaqh")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("agmfkfqy")));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("covvpbhymqenuhsccqnvm")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("qvwnpsmsuxpyhmllksrgyhsbc")));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("v")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("hognqawktlsjicoexa")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("fhfjqgjxeusmugfoyeykmsxk")));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("qvfxpsxytdcrxqf")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("tfyvagtvhuinmgqsj")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("ritcxdayssdkabsxk")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("oeotfouyjwyfqnfwqjecsocoqiqa")));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("ohwnhiorrweifptbkcmux")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("okflnkkxrmxdsh")));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((77)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("qavatdpholuycqa")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("ojnwqsm")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("dwhqdqxbiqgqomsquscsgxtbl")));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((164)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("loq")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((165)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("cvitf")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((82)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("yjybyjmspvrwphht")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("wlqgneqpongmavbgdjcmqkhcfhev")));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((166)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("crkdpesusmkmtefpqxaconk")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((170)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("pjbewamd")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((89)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("kprinyvvmtmwhbbcvbahwm")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((177)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("jfnneitkxeaescr")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("wcsjlgoxfoncbovjymv")));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((180)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("xo")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((91)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("lchqcs")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("hgr")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("oqmwsaibyhbxdfurlfbdua")));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((183)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("mybgdtcfadelchgktq")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

#endregion

    }
}

