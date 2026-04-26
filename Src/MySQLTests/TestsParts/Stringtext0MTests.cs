

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
    Id = 1,
    Value = "eusbiurf",
    ModelInner = null,
    NullableValue = null,
},
            new Stringtext0M
{
    Id = 9,
    Value = "eifh",
    ModelInner = new Stringtext0MI
{
    Id = 2,
    Value = "uiinrltdtxpxfxnrqyxqh",
    NullableValue = "rxlyqplptivscrgaerrhrtdvavwp",
},
    NullableValue = null,
},
            new Stringtext0M
{
    Id = 12,
    Value = "shnpiiystaeodplgpris",
    ModelInner = null,
    NullableValue = "ouhqfrxfwbdhgoxekjhdfmdqs",
},
            new Stringtext0M
{
    Id = 14,
    Value = "slohijocjbrrrsbgu",
    ModelInner = new Stringtext0MI
{
    Id = 6,
    Value = "privthoxixfptl",
    NullableValue = "dlhefmikclspvwbikehk",
},
    NullableValue = null,
},
            new Stringtext0M
{
    Id = 15,
    Value = "qvpcgxmrnnw",
    ModelInner = null,
    NullableValue = "nlgnpsdvgbtxqxhru",
},
            new Stringtext0M
{
    Id = 22,
    Value = "wxpyoaovjbwjhppl",
    ModelInner = new Stringtext0MI
{
    Id = 9,
    Value = "",
    NullableValue = null,
},
    NullableValue = "gculwujdfbhvvljwhiy",
},
            new Stringtext0M
{
    Id = 26,
    Value = "glrpmsjlq",
    ModelInner = null,
    NullableValue = null,
},
            new Stringtext0M
{
    Id = 32,
    Value = "c",
    ModelInner = new Stringtext0MI
{
    Id = 12,
    Value = "wnk",
    NullableValue = null,
},
    NullableValue = "irpnxdinonos",
},
            new Stringtext0M
{
    Id = 37,
    Value = "bccfxgjlylufxqpeyfyiefge",
    ModelInner = null,
    NullableValue = null,
},
            new Stringtext0M
{
    Id = 46,
    Value = "lyiaixsjokach",
    ModelInner = new Stringtext0MI
{
    Id = 13,
    Value = "hctqkavlcpsxhh",
    NullableValue = "oliek",
},
    NullableValue = "tkrfmedc",
},
            new Stringtext0M
{
    Id = 55,
    Value = "vspiwnc",
    ModelInner = null,
    NullableValue = "gmcggoeenbmgigcsivoy",
},
            new Stringtext0M
{
    Id = 57,
    Value = "kxywhawqhmpis",
    ModelInner = new Stringtext0MI
{
    Id = 18,
    Value = "worhqtwhrupfvmjax",
    NullableValue = "ffnbtepnwbavsq",
},
    NullableValue = null,
},
            new Stringtext0M
{
    Id = 58,
    Value = "",
    ModelInner = null,
    NullableValue = null,
},
            new Stringtext0M
{
    Id = 61,
    Value = "bsltdhdnjmoodkkibql",
    ModelInner = new Stringtext0MI
{
    Id = 27,
    Value = "ndgkyrgvsvlbgcdualdqjfx",
    NullableValue = null,
},
    NullableValue = null,
},
            new Stringtext0M
{
    Id = 70,
    Value = "khblxmxivtnaflsiq",
    ModelInner = null,
    NullableValue = null,
},
            new Stringtext0M
{
    Id = 76,
    Value = "k",
    ModelInner = new Stringtext0MI
{
    Id = 28,
    Value = "wgwlhrimisukosvfulycimfjcueli",
    NullableValue = "dnsnobmxorcsbgbpksa",
},
    NullableValue = "xkitdvfucxrjiy",
},
            new Stringtext0M
{
    Id = 77,
    Value = "mxarnblreopiyxssyrpc",
    ModelInner = null,
    NullableValue = "newguduuuiunmclqmxe",
},
            new Stringtext0M
{
    Id = 78,
    Value = "rd",
    ModelInner = new Stringtext0MI
{
    Id = 35,
    Value = "bxtkv",
    NullableValue = null,
},
    NullableValue = "i",
},
            new Stringtext0M
{
    Id = 82,
    Value = "pakdlbmah",
    ModelInner = null,
    NullableValue = "yxp",
},
            new Stringtext0M
{
    Id = 85,
    Value = "pyltjacruaykyhgyhupfr",
    ModelInner = new Stringtext0MI
{
    Id = 39,
    Value = "llkwrwn",
    NullableValue = "axvsjjbibmnlqbwjawmhiqyn",
},
    NullableValue = "vrhgpdcugucknshjmutdapvthr",
},
            new Stringtext0M
{
    Id = 88,
    Value = "ibwiwkarflfiiyxx",
    ModelInner = null,
    NullableValue = null,
},
            new Stringtext0M
{
    Id = 93,
    Value = "hxysgutswftkbumnsypp",
    ModelInner = new Stringtext0MI
{
    Id = 41,
    Value = "oclysbilbrrwqvjhpmxjpeflh",
    NullableValue = null,
},
    NullableValue = "nquujetqmcgkucujktqvdwo",
},
            new Stringtext0M
{
    Id = 102,
    Value = "",
    ModelInner = null,
    NullableValue = "csxbktkwqbrwgfkicdkdb",
},
            new Stringtext0M
{
    Id = 103,
    Value = "wlhwuxvwmroplxqholjgdeu",
    ModelInner = new Stringtext0MI
{
    Id = 50,
    Value = "swoaybsiiu",
    NullableValue = "eugiugybtxubpngupnghj",
},
    NullableValue = "qpwkuhglednfaiawwcbbkicbf",
},
            new Stringtext0M
{
    Id = 112,
    Value = "",
    ModelInner = null,
    NullableValue = null,
},
            new Stringtext0M
{
    Id = 121,
    Value = "xutdxjyqbnnkhoa",
    ModelInner = new Stringtext0MI
{
    Id = 58,
    Value = "sjpucjtbpkretdvhpjxyjk",
    NullableValue = "",
},
    NullableValue = null,
},
            new Stringtext0M
{
    Id = 127,
    Value = "cgidxvuhnirguncrev",
    ModelInner = null,
    NullableValue = "q",
},
            new Stringtext0M
{
    Id = 135,
    Value = "kgqururycjipfpur",
    ModelInner = new Stringtext0MI
{
    Id = 64,
    Value = "tcdtdruxhwxtjboblrmvwtomtn",
    NullableValue = null,
},
    NullableValue = "httep",
},
            new Stringtext0M
{
    Id = 142,
    Value = "lp",
    ModelInner = null,
    NullableValue = null,
},
            new Stringtext0M
{
    Id = 146,
    Value = "nbtiyiiasjfauwvu",
    ModelInner = new Stringtext0MI
{
    Id = 70,
    Value = "yjckttqvlnunaaadik",
    NullableValue = "dvlurosgxaps",
},
    NullableValue = "xolnhel",
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

            }
        }

#endregion

#region Select Models

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatStringtext0M)],
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
LEFT JOIN gedaqtests.stringtext0mi mi ON mi.id = m.stringtext0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";

                var models = await ((IStringSingleTypetext)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
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
FROM gedaqtests.stringtext0m m
LEFT JOIN gedaqtests.stringtext0mi mi ON mi.id = m.stringtext0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";

                var models =  ((IStringSingleTypetext)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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

                var models = await ((IStringSingleTypetext)this).SelectModelDynParAsync(connection, [parametr1]);
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
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";

                var models =  ((IStringSingleTypetext)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Stringtext0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatStringtext0M)],
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
LEFT JOIN gedaqtests.stringtext0mi mi ON mi.id = m.stringtext0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await ((IStringSingleTypetext)this).DynQuerySelectModelAsync(connection,  query, 0);
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
FROM gedaqtests.stringtext0m m
LEFT JOIN gedaqtests.stringtext0mi mi ON mi.id = m.stringtext0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models =  ((IStringSingleTypetext)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                var models = await ((IStringSingleTypetext)this).SelectModelAsync(connection, 0);
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
                var models =  ((IStringSingleTypetext)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Stringtext0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatStringtext0M)],
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
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
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
LEFT JOIN gedaqtests.stringtext0mi mi ON mi.id = m.stringtext0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models = await ((IStringSingleTypetext)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatStringtext0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 76;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 121;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.stringtext0m m
LEFT JOIN gedaqtests.stringtext0mi mi ON mi.id = m.stringtext0mi_id
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
LEFT JOIN gedaqtests.stringtext0mi mi ON mi.id = m.stringtext0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IStringSingleTypetext)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));
FlatStringtext0M.AssertModel(models[0],_testData[16], false);FlatStringtext0M.AssertModel(models[1],_testData[17], false);FlatStringtext0M.AssertModel(models[2],_testData[18], false);FlatStringtext0M.AssertModel(models[3],_testData[19], false);FlatStringtext0M.AssertModel(models[4],_testData[20], false);FlatStringtext0M.AssertModel(models[5],_testData[21], false);FlatStringtext0M.AssertModel(models[6],_testData[22], false);FlatStringtext0M.AssertModel(models[7],_testData[23], false);FlatStringtext0M.AssertModel(models[8],_testData[24], false);FlatStringtext0M.AssertModel(models[9],_testData[25], false);FlatStringtext0M.AssertModel(models[10],_testData[26], false);FlatStringtext0M.AssertModel(models[11],_testData[27], false);FlatStringtext0M.AssertModel(models[12],_testData[28], false);FlatStringtext0M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));
FlatStringtext0M.AssertModel(models[0],_testData[26], false);FlatStringtext0M.AssertModel(models[1],_testData[27], false);FlatStringtext0M.AssertModel(models[2],_testData[28], false);FlatStringtext0M.AssertModel(models[3],_testData[29], false);
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
FROM gedaqtests.stringtext0m m
LEFT JOIN gedaqtests.stringtext0mi mi ON mi.id = m.stringtext0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models =  ((IStringSingleTypetext)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatStringtext0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 55;
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
LEFT JOIN gedaqtests.stringtext0mi mi ON mi.id = m.stringtext0mi_id
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
LEFT JOIN gedaqtests.stringtext0mi mi ON mi.id = m.stringtext0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IStringSingleTypetext)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));
FlatStringtext0M.AssertModel(models[0],_testData[11], false);FlatStringtext0M.AssertModel(models[1],_testData[12], false);FlatStringtext0M.AssertModel(models[2],_testData[13], false);FlatStringtext0M.AssertModel(models[3],_testData[14], false);FlatStringtext0M.AssertModel(models[4],_testData[15], false);FlatStringtext0M.AssertModel(models[5],_testData[16], false);FlatStringtext0M.AssertModel(models[6],_testData[17], false);FlatStringtext0M.AssertModel(models[7],_testData[18], false);FlatStringtext0M.AssertModel(models[8],_testData[19], false);FlatStringtext0M.AssertModel(models[9],_testData[20], false);FlatStringtext0M.AssertModel(models[10],_testData[21], false);FlatStringtext0M.AssertModel(models[11],_testData[22], false);FlatStringtext0M.AssertModel(models[12],_testData[23], false);FlatStringtext0M.AssertModel(models[13],_testData[24], false);FlatStringtext0M.AssertModel(models[14],_testData[25], false);FlatStringtext0M.AssertModel(models[15],_testData[26], false);FlatStringtext0M.AssertModel(models[16],_testData[27], false);FlatStringtext0M.AssertModel(models[17],_testData[28], false);FlatStringtext0M.AssertModel(models[18],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));
FlatStringtext0M.AssertModel(models[0],_testData[25], false);FlatStringtext0M.AssertModel(models[1],_testData[26], false);FlatStringtext0M.AssertModel(models[2],_testData[27], false);FlatStringtext0M.AssertModel(models[3],_testData[28], false);FlatStringtext0M.AssertModel(models[4],_testData[29], false);
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
            batchName: "DbConnectionSelectModelDynParBatch",
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

                var models = await ((IStringSingleTypetext)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Stringtext0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 61;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 58;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((IStringSingleTypetext)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));
Stringtext0M.AssertModel(models[0],_testData[14], false);Stringtext0M.AssertModel(models[1],_testData[15], false);Stringtext0M.AssertModel(models[2],_testData[16], false);Stringtext0M.AssertModel(models[3],_testData[17], false);Stringtext0M.AssertModel(models[4],_testData[18], false);Stringtext0M.AssertModel(models[5],_testData[19], false);Stringtext0M.AssertModel(models[6],_testData[20], false);Stringtext0M.AssertModel(models[7],_testData[21], false);Stringtext0M.AssertModel(models[8],_testData[22], false);Stringtext0M.AssertModel(models[9],_testData[23], false);Stringtext0M.AssertModel(models[10],_testData[24], false);Stringtext0M.AssertModel(models[11],_testData[25], false);Stringtext0M.AssertModel(models[12],_testData[26], false);Stringtext0M.AssertModel(models[13],_testData[27], false);Stringtext0M.AssertModel(models[14],_testData[28], false);Stringtext0M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));
Stringtext0M.AssertModel(models[0],_testData[13], false);Stringtext0M.AssertModel(models[1],_testData[14], false);Stringtext0M.AssertModel(models[2],_testData[15], false);Stringtext0M.AssertModel(models[3],_testData[16], false);Stringtext0M.AssertModel(models[4],_testData[17], false);Stringtext0M.AssertModel(models[5],_testData[18], false);Stringtext0M.AssertModel(models[6],_testData[19], false);Stringtext0M.AssertModel(models[7],_testData[20], false);Stringtext0M.AssertModel(models[8],_testData[21], false);Stringtext0M.AssertModel(models[9],_testData[22], false);Stringtext0M.AssertModel(models[10],_testData[23], false);Stringtext0M.AssertModel(models[11],_testData[24], false);Stringtext0M.AssertModel(models[12],_testData[25], false);Stringtext0M.AssertModel(models[13],_testData[26], false);Stringtext0M.AssertModel(models[14],_testData[27], false);Stringtext0M.AssertModel(models[15],_testData[28], false);Stringtext0M.AssertModel(models[16],_testData[29], false);
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

                var models =  ((IStringSingleTypetext)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Stringtext0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 37;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 85;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((IStringSingleTypetext)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));
Stringtext0M.AssertModel(models[0],_testData[9], false);Stringtext0M.AssertModel(models[1],_testData[10], false);Stringtext0M.AssertModel(models[2],_testData[11], false);Stringtext0M.AssertModel(models[3],_testData[12], false);Stringtext0M.AssertModel(models[4],_testData[13], false);Stringtext0M.AssertModel(models[5],_testData[14], false);Stringtext0M.AssertModel(models[6],_testData[15], false);Stringtext0M.AssertModel(models[7],_testData[16], false);Stringtext0M.AssertModel(models[8],_testData[17], false);Stringtext0M.AssertModel(models[9],_testData[18], false);Stringtext0M.AssertModel(models[10],_testData[19], false);Stringtext0M.AssertModel(models[11],_testData[20], false);Stringtext0M.AssertModel(models[12],_testData[21], false);Stringtext0M.AssertModel(models[13],_testData[22], false);Stringtext0M.AssertModel(models[14],_testData[23], false);Stringtext0M.AssertModel(models[15],_testData[24], false);Stringtext0M.AssertModel(models[16],_testData[25], false);Stringtext0M.AssertModel(models[17],_testData[26], false);Stringtext0M.AssertModel(models[18],_testData[27], false);Stringtext0M.AssertModel(models[19],_testData[28], false);Stringtext0M.AssertModel(models[20],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));
Stringtext0M.AssertModel(models[0],_testData[20], false);Stringtext0M.AssertModel(models[1],_testData[21], false);Stringtext0M.AssertModel(models[2],_testData[22], false);Stringtext0M.AssertModel(models[3],_testData[23], false);Stringtext0M.AssertModel(models[4],_testData[24], false);Stringtext0M.AssertModel(models[5],_testData[25], false);Stringtext0M.AssertModel(models[6],_testData[26], false);Stringtext0M.AssertModel(models[7],_testData[27], false);Stringtext0M.AssertModel(models[8],_testData[28], false);Stringtext0M.AssertModel(models[9],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatStringtext0M)],
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
            batchName: "DbConnectionDynQuerySelectModelBatch",
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
LEFT JOIN gedaqtests.stringtext0mi mi ON mi.id = m.stringtext0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await ((IStringSingleTypetext)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatStringtext0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.stringtext0m m
LEFT JOIN gedaqtests.stringtext0mi mi ON mi.id = m.stringtext0mi_id
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
LEFT JOIN gedaqtests.stringtext0mi mi ON mi.id = m.stringtext0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IStringSingleTypetext)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 22, query1, 15, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));
FlatStringtext0M.AssertModel(models[0],_testData[6], false);FlatStringtext0M.AssertModel(models[1],_testData[7], false);FlatStringtext0M.AssertModel(models[2],_testData[8], false);FlatStringtext0M.AssertModel(models[3],_testData[9], false);FlatStringtext0M.AssertModel(models[4],_testData[10], false);FlatStringtext0M.AssertModel(models[5],_testData[11], false);FlatStringtext0M.AssertModel(models[6],_testData[12], false);FlatStringtext0M.AssertModel(models[7],_testData[13], false);FlatStringtext0M.AssertModel(models[8],_testData[14], false);FlatStringtext0M.AssertModel(models[9],_testData[15], false);FlatStringtext0M.AssertModel(models[10],_testData[16], false);FlatStringtext0M.AssertModel(models[11],_testData[17], false);FlatStringtext0M.AssertModel(models[12],_testData[18], false);FlatStringtext0M.AssertModel(models[13],_testData[19], false);FlatStringtext0M.AssertModel(models[14],_testData[20], false);FlatStringtext0M.AssertModel(models[15],_testData[21], false);FlatStringtext0M.AssertModel(models[16],_testData[22], false);FlatStringtext0M.AssertModel(models[17],_testData[23], false);FlatStringtext0M.AssertModel(models[18],_testData[24], false);FlatStringtext0M.AssertModel(models[19],_testData[25], false);FlatStringtext0M.AssertModel(models[20],_testData[26], false);FlatStringtext0M.AssertModel(models[21],_testData[27], false);FlatStringtext0M.AssertModel(models[22],_testData[28], false);FlatStringtext0M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));
FlatStringtext0M.AssertModel(models[0],_testData[5], false);FlatStringtext0M.AssertModel(models[1],_testData[6], false);FlatStringtext0M.AssertModel(models[2],_testData[7], false);FlatStringtext0M.AssertModel(models[3],_testData[8], false);FlatStringtext0M.AssertModel(models[4],_testData[9], false);FlatStringtext0M.AssertModel(models[5],_testData[10], false);FlatStringtext0M.AssertModel(models[6],_testData[11], false);FlatStringtext0M.AssertModel(models[7],_testData[12], false);FlatStringtext0M.AssertModel(models[8],_testData[13], false);FlatStringtext0M.AssertModel(models[9],_testData[14], false);FlatStringtext0M.AssertModel(models[10],_testData[15], false);FlatStringtext0M.AssertModel(models[11],_testData[16], false);FlatStringtext0M.AssertModel(models[12],_testData[17], false);FlatStringtext0M.AssertModel(models[13],_testData[18], false);FlatStringtext0M.AssertModel(models[14],_testData[19], false);FlatStringtext0M.AssertModel(models[15],_testData[20], false);FlatStringtext0M.AssertModel(models[16],_testData[21], false);FlatStringtext0M.AssertModel(models[17],_testData[22], false);FlatStringtext0M.AssertModel(models[18],_testData[23], false);FlatStringtext0M.AssertModel(models[19],_testData[24], false);FlatStringtext0M.AssertModel(models[20],_testData[25], false);FlatStringtext0M.AssertModel(models[21],_testData[26], false);FlatStringtext0M.AssertModel(models[22],_testData[27], false);FlatStringtext0M.AssertModel(models[23],_testData[28], false);FlatStringtext0M.AssertModel(models[24],_testData[29], false);
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
FROM gedaqtests.stringtext0m m
LEFT JOIN gedaqtests.stringtext0mi mi ON mi.id = m.stringtext0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models =  ((IStringSingleTypetext)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatStringtext0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.stringtext0m m
LEFT JOIN gedaqtests.stringtext0mi mi ON mi.id = m.stringtext0mi_id
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
LEFT JOIN gedaqtests.stringtext0mi mi ON mi.id = m.stringtext0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IStringSingleTypetext)this).DbConnectionDynQuerySelectModelBatch(connection, 93, query1, 93, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));
FlatStringtext0M.AssertModel(models[0],_testData[22], false);FlatStringtext0M.AssertModel(models[1],_testData[23], false);FlatStringtext0M.AssertModel(models[2],_testData[24], false);FlatStringtext0M.AssertModel(models[3],_testData[25], false);FlatStringtext0M.AssertModel(models[4],_testData[26], false);FlatStringtext0M.AssertModel(models[5],_testData[27], false);FlatStringtext0M.AssertModel(models[6],_testData[28], false);FlatStringtext0M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));
FlatStringtext0M.AssertModel(models[0],_testData[22], false);FlatStringtext0M.AssertModel(models[1],_testData[23], false);FlatStringtext0M.AssertModel(models[2],_testData[24], false);FlatStringtext0M.AssertModel(models[3],_testData[25], false);FlatStringtext0M.AssertModel(models[4],_testData[26], false);FlatStringtext0M.AssertModel(models[5],_testData[27], false);FlatStringtext0M.AssertModel(models[6],_testData[28], false);FlatStringtext0M.AssertModel(models[7],_testData[29], false);
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
            batchName: "DbConnectionSelectModelBatch",
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
        private void DbConnectionSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IStringSingleTypetext)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Stringtext0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IStringSingleTypetext)this).DbConnectionSelectModelBatchAsync(connection, 102, 46))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));
Stringtext0M.AssertModel(models[0],_testData[23], false);Stringtext0M.AssertModel(models[1],_testData[24], false);Stringtext0M.AssertModel(models[2],_testData[25], false);Stringtext0M.AssertModel(models[3],_testData[26], false);Stringtext0M.AssertModel(models[4],_testData[27], false);Stringtext0M.AssertModel(models[5],_testData[28], false);Stringtext0M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));
Stringtext0M.AssertModel(models[0],_testData[10], false);Stringtext0M.AssertModel(models[1],_testData[11], false);Stringtext0M.AssertModel(models[2],_testData[12], false);Stringtext0M.AssertModel(models[3],_testData[13], false);Stringtext0M.AssertModel(models[4],_testData[14], false);Stringtext0M.AssertModel(models[5],_testData[15], false);Stringtext0M.AssertModel(models[6],_testData[16], false);Stringtext0M.AssertModel(models[7],_testData[17], false);Stringtext0M.AssertModel(models[8],_testData[18], false);Stringtext0M.AssertModel(models[9],_testData[19], false);Stringtext0M.AssertModel(models[10],_testData[20], false);Stringtext0M.AssertModel(models[11],_testData[21], false);Stringtext0M.AssertModel(models[12],_testData[22], false);Stringtext0M.AssertModel(models[13],_testData[23], false);Stringtext0M.AssertModel(models[14],_testData[24], false);Stringtext0M.AssertModel(models[15],_testData[25], false);Stringtext0M.AssertModel(models[16],_testData[26], false);Stringtext0M.AssertModel(models[17],_testData[27], false);Stringtext0M.AssertModel(models[18],_testData[28], false);Stringtext0M.AssertModel(models[19],_testData[29], false);
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
                var models =  ((IStringSingleTypetext)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Stringtext0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IStringSingleTypetext)this).DbConnectionSelectModelBatch(connection, 102, 82))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));
Stringtext0M.AssertModel(models[0],_testData[23], false);Stringtext0M.AssertModel(models[1],_testData[24], false);Stringtext0M.AssertModel(models[2],_testData[25], false);Stringtext0M.AssertModel(models[3],_testData[26], false);Stringtext0M.AssertModel(models[4],_testData[27], false);Stringtext0M.AssertModel(models[5],_testData[28], false);Stringtext0M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));
Stringtext0M.AssertModel(models[0],_testData[19], false);Stringtext0M.AssertModel(models[1],_testData[20], false);Stringtext0M.AssertModel(models[2],_testData[21], false);Stringtext0M.AssertModel(models[3],_testData[22], false);Stringtext0M.AssertModel(models[4],_testData[23], false);Stringtext0M.AssertModel(models[5],_testData[24], false);Stringtext0M.AssertModel(models[6],_testData[25], false);Stringtext0M.AssertModel(models[7],_testData[26], false);Stringtext0M.AssertModel(models[8],_testData[27], false);Stringtext0M.AssertModel(models[9],_testData[28], false);Stringtext0M.AssertModel(models[10],_testData[29], false);
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
                ((IStringSingleTypetext)this).SetDbConnectionSelectModelParametrs(cmd, 1);
                var models = await ((IStringSingleTypetext)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(29));
Stringtext0M.AssertModel(models[0],_testData[1], false);Stringtext0M.AssertModel(models[1],_testData[2], false);Stringtext0M.AssertModel(models[2],_testData[3], false);Stringtext0M.AssertModel(models[3],_testData[4], false);Stringtext0M.AssertModel(models[4],_testData[5], false);Stringtext0M.AssertModel(models[5],_testData[6], false);Stringtext0M.AssertModel(models[6],_testData[7], false);Stringtext0M.AssertModel(models[7],_testData[8], false);Stringtext0M.AssertModel(models[8],_testData[9], false);Stringtext0M.AssertModel(models[9],_testData[10], false);Stringtext0M.AssertModel(models[10],_testData[11], false);Stringtext0M.AssertModel(models[11],_testData[12], false);Stringtext0M.AssertModel(models[12],_testData[13], false);Stringtext0M.AssertModel(models[13],_testData[14], false);Stringtext0M.AssertModel(models[14],_testData[15], false);Stringtext0M.AssertModel(models[15],_testData[16], false);Stringtext0M.AssertModel(models[16],_testData[17], false);Stringtext0M.AssertModel(models[17],_testData[18], false);Stringtext0M.AssertModel(models[18],_testData[19], false);Stringtext0M.AssertModel(models[19],_testData[20], false);Stringtext0M.AssertModel(models[20],_testData[21], false);Stringtext0M.AssertModel(models[21],_testData[22], false);Stringtext0M.AssertModel(models[22],_testData[23], false);Stringtext0M.AssertModel(models[23],_testData[24], false);Stringtext0M.AssertModel(models[24],_testData[25], false);Stringtext0M.AssertModel(models[25],_testData[26], false);Stringtext0M.AssertModel(models[26],_testData[27], false);Stringtext0M.AssertModel(models[27],_testData[28], false);Stringtext0M.AssertModel(models[28],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IStringSingleTypetext)this).CreateDbConnectionSelectModelCommand(connection);
                ((IStringSingleTypetext)this).SetDbConnectionSelectModelParametrs(cmd, 55);
                var models =  ((IStringSingleTypetext)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(19));
Stringtext0M.AssertModel(models[0],_testData[11], false);Stringtext0M.AssertModel(models[1],_testData[12], false);Stringtext0M.AssertModel(models[2],_testData[13], false);Stringtext0M.AssertModel(models[3],_testData[14], false);Stringtext0M.AssertModel(models[4],_testData[15], false);Stringtext0M.AssertModel(models[5],_testData[16], false);Stringtext0M.AssertModel(models[6],_testData[17], false);Stringtext0M.AssertModel(models[7],_testData[18], false);Stringtext0M.AssertModel(models[8],_testData[19], false);Stringtext0M.AssertModel(models[9],_testData[20], false);Stringtext0M.AssertModel(models[10],_testData[21], false);Stringtext0M.AssertModel(models[11],_testData[22], false);Stringtext0M.AssertModel(models[12],_testData[23], false);Stringtext0M.AssertModel(models[13],_testData[24], false);Stringtext0M.AssertModel(models[14],_testData[25], false);Stringtext0M.AssertModel(models[15],_testData[26], false);Stringtext0M.AssertModel(models[16],_testData[27], false);Stringtext0M.AssertModel(models[17],_testData[28], false);Stringtext0M.AssertModel(models[18],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("eusbiurf")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("eifh")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("uiinrltdtxpxfxnrqyxqh")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("rxlyqplptivscrgaerrhrtdvavwp")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("shnpiiystaeodplgpris")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("ouhqfrxfwbdhgoxekjhdfmdqs")));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("slohijocjbrrrsbgu")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("privthoxixfptl")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("dlhefmikclspvwbikehk")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("qvpcgxmrnnw")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("nlgnpsdvgbtxqxhru")));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("wxpyoaovjbwjhppl")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("gculwujdfbhvvljwhiy")));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("glrpmsjlq")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((32)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("c")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("wnk")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("irpnxdinonos")));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("bccfxgjlylufxqpeyfyiefge")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("lyiaixsjokach")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("hctqkavlcpsxhh")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("oliek")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("tkrfmedc")));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("vspiwnc")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("gmcggoeenbmgigcsivoy")));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("kxywhawqhmpis")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("worhqtwhrupfvmjax")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("ffnbtepnwbavsq")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("bsltdhdnjmoodkkibql")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("ndgkyrgvsvlbgcdualdqjfx")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("khblxmxivtnaflsiq")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("k")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("wgwlhrimisukosvfulycimfjcueli")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("dnsnobmxorcsbgbpksa")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("xkitdvfucxrjiy")));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("mxarnblreopiyxssyrpc")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("newguduuuiunmclqmxe")));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((78)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("rd")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("bxtkv")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("i")));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("pakdlbmah")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("yxp")));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("pyltjacruaykyhgyhupfr")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("llkwrwn")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("axvsjjbibmnlqbwjawmhiqyn")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("vrhgpdcugucknshjmutdapvthr")));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("ibwiwkarflfiiyxx")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("hxysgutswftkbumnsypp")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("oclysbilbrrwqvjhpmxjpeflh")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("nquujetqmcgkucujktqvdwo")));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("csxbktkwqbrwgfkicdkdb")));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("wlhwuxvwmroplxqholjgdeu")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((50)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("swoaybsiiu")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("eugiugybtxubpngupnghj")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("qpwkuhglednfaiawwcbbkicbf")));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("xutdxjyqbnnkhoa")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("sjpucjtbpkretdvhpjxyjk")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("cgidxvuhnirguncrev")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("q")));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("kgqururycjipfpur")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("tcdtdruxhwxtjboblrmvwtomtn")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("httep")));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((142)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("lp")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("nbtiyiiasjfauwvu")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((70)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("yjckttqvlnunaaadik")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("dvlurosgxaps")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("xolnhel")));

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
                Assert.That((System.Int32)model[0], Is.EqualTo((1)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("eusbiurf")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("eifh")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("uiinrltdtxpxfxnrqyxqh")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("rxlyqplptivscrgaerrhrtdvavwp")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("shnpiiystaeodplgpris")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("ouhqfrxfwbdhgoxekjhdfmdqs")));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("slohijocjbrrrsbgu")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("privthoxixfptl")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("dlhefmikclspvwbikehk")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("qvpcgxmrnnw")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("nlgnpsdvgbtxqxhru")));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("wxpyoaovjbwjhppl")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("gculwujdfbhvvljwhiy")));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("glrpmsjlq")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((32)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("c")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("wnk")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("irpnxdinonos")));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("bccfxgjlylufxqpeyfyiefge")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("lyiaixsjokach")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("hctqkavlcpsxhh")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("oliek")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("tkrfmedc")));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("vspiwnc")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("gmcggoeenbmgigcsivoy")));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("kxywhawqhmpis")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("worhqtwhrupfvmjax")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("ffnbtepnwbavsq")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("bsltdhdnjmoodkkibql")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("ndgkyrgvsvlbgcdualdqjfx")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("khblxmxivtnaflsiq")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("k")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("wgwlhrimisukosvfulycimfjcueli")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("dnsnobmxorcsbgbpksa")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("xkitdvfucxrjiy")));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("mxarnblreopiyxssyrpc")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("newguduuuiunmclqmxe")));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((78)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("rd")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("bxtkv")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("i")));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("pakdlbmah")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("yxp")));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("pyltjacruaykyhgyhupfr")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("llkwrwn")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("axvsjjbibmnlqbwjawmhiqyn")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("vrhgpdcugucknshjmutdapvthr")));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("ibwiwkarflfiiyxx")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("hxysgutswftkbumnsypp")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("oclysbilbrrwqvjhpmxjpeflh")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("nquujetqmcgkucujktqvdwo")));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("csxbktkwqbrwgfkicdkdb")));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("wlhwuxvwmroplxqholjgdeu")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((50)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("swoaybsiiu")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("eugiugybtxubpngupnghj")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("qpwkuhglednfaiawwcbbkicbf")));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("xutdxjyqbnnkhoa")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("sjpucjtbpkretdvhpjxyjk")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("cgidxvuhnirguncrev")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("q")));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("kgqururycjipfpur")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("tcdtdruxhwxtjboblrmvwtomtn")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("httep")));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((142)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("lp")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("nbtiyiiasjfauwvu")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((70)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("yjckttqvlnunaaadik")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("dvlurosgxaps")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("xolnhel")));

            }
        }

#endregion

    }
}

