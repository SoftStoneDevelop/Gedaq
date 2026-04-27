

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
    Value = "pgekkjgcgukbwhbvagxog",
    ModelInner = null,
    NullableValue = null,
},
            new Stringtext0M
{
    Id = 10,
    Value = "efqdlawhxqhdevdffsypupgsgdr",
    ModelInner = new Stringtext0MI
{
    Id = 1,
    Value = "wyn",
    NullableValue = "pdeibxvcvblbkl",
},
    NullableValue = null,
},
            new Stringtext0M
{
    Id = 17,
    Value = "hsjwqwrmkcpfekw",
    ModelInner = null,
    NullableValue = "ynttdnytucplclvyaxvwemnbyokgg",
},
            new Stringtext0M
{
    Id = 21,
    Value = "lsrqlfevxwdtl",
    ModelInner = new Stringtext0MI
{
    Id = 5,
    Value = "o",
    NullableValue = "xfnkajyugdobwfrkhsijy",
},
    NullableValue = "fhblrpqqprjdhhavhylmfef",
},
            new Stringtext0M
{
    Id = 25,
    Value = "dwkdpadfucttpuwbggy",
    ModelInner = null,
    NullableValue = "",
},
            new Stringtext0M
{
    Id = 27,
    Value = "sg",
    ModelInner = new Stringtext0MI
{
    Id = 6,
    Value = "lgginubcytkhwajj",
    NullableValue = null,
},
    NullableValue = "mgreqqicp",
},
            new Stringtext0M
{
    Id = 33,
    Value = "kxn",
    ModelInner = null,
    NullableValue = null,
},
            new Stringtext0M
{
    Id = 38,
    Value = "ooaimtibh",
    ModelInner = new Stringtext0MI
{
    Id = 8,
    Value = "hgevxiuoxr",
    NullableValue = "ctihmyqojoqouoffgfnsy",
},
    NullableValue = "ggsjtolmobrrkrbfgt",
},
            new Stringtext0M
{
    Id = 39,
    Value = "gtjydh",
    ModelInner = null,
    NullableValue = "pdp",
},
            new Stringtext0M
{
    Id = 46,
    Value = "yjxkdtwgeyawohdv",
    ModelInner = new Stringtext0MI
{
    Id = 15,
    Value = "uvtmegcpujlptvojfy",
    NullableValue = null,
},
    NullableValue = null,
},
            new Stringtext0M
{
    Id = 51,
    Value = "wlvny",
    ModelInner = null,
    NullableValue = "aojwvu",
},
            new Stringtext0M
{
    Id = 60,
    Value = "",
    ModelInner = new Stringtext0MI
{
    Id = 19,
    Value = "swgkqfetsy",
    NullableValue = null,
},
    NullableValue = null,
},
            new Stringtext0M
{
    Id = 64,
    Value = "bty",
    ModelInner = null,
    NullableValue = "mugfom",
},
            new Stringtext0M
{
    Id = 72,
    Value = "rmaiedncdesimv",
    ModelInner = new Stringtext0MI
{
    Id = 22,
    Value = "blphqbc",
    NullableValue = "onypsfngccjxptdxajgdxqtwb",
},
    NullableValue = "ep",
},
            new Stringtext0M
{
    Id = 79,
    Value = "mj",
    ModelInner = null,
    NullableValue = "wuajw",
},
            new Stringtext0M
{
    Id = 85,
    Value = "qfuxqx",
    ModelInner = new Stringtext0MI
{
    Id = 23,
    Value = "aixmpfotchprpgtvwrsdotdehh",
    NullableValue = "yivwen",
},
    NullableValue = null,
},
            new Stringtext0M
{
    Id = 93,
    Value = "aixsvchrtyeoibkyolwoehk",
    ModelInner = null,
    NullableValue = null,
},
            new Stringtext0M
{
    Id = 102,
    Value = "qfevpxfkxqkqtpnnkkbicjbybs",
    ModelInner = new Stringtext0MI
{
    Id = 24,
    Value = "braipi",
    NullableValue = null,
},
    NullableValue = null,
},
            new Stringtext0M
{
    Id = 106,
    Value = "",
    ModelInner = null,
    NullableValue = null,
},
            new Stringtext0M
{
    Id = 112,
    Value = "arhjjiws",
    ModelInner = new Stringtext0MI
{
    Id = 33,
    Value = "jjxxltposjfcuyuxsxyylxhj",
    NullableValue = null,
},
    NullableValue = "qrielkauuaodcmdiievabapasp",
},
            new Stringtext0M
{
    Id = 119,
    Value = "edcihkk",
    ModelInner = null,
    NullableValue = "jtaytqwarlqtdscvloh",
},
            new Stringtext0M
{
    Id = 120,
    Value = "sheqtapjnu",
    ModelInner = new Stringtext0MI
{
    Id = 42,
    Value = "tlkrcdjcycaqtfek",
    NullableValue = null,
},
    NullableValue = "bgqysk",
},
            new Stringtext0M
{
    Id = 126,
    Value = "iybrqgfckmm",
    ModelInner = null,
    NullableValue = "lrafilwixnixvvymvhtxgyi",
},
            new Stringtext0M
{
    Id = 128,
    Value = "ulnbwtcquosxgerwqohlcavdtnn",
    ModelInner = new Stringtext0MI
{
    Id = 43,
    Value = "iaytmrvitvcqhuqpnw",
    NullableValue = null,
},
    NullableValue = null,
},
            new Stringtext0M
{
    Id = 135,
    Value = "hltxfjdxtsi",
    ModelInner = null,
    NullableValue = null,
},
            new Stringtext0M
{
    Id = 143,
    Value = "sowwhpmyi",
    ModelInner = new Stringtext0MI
{
    Id = 47,
    Value = "tqtawmvjgfwyjkghwidfxsavb",
    NullableValue = "cmmf",
},
    NullableValue = "cvtgjdmyogjakdnnwtbhbtbi",
},
            new Stringtext0M
{
    Id = 147,
    Value = "uqd",
    ModelInner = null,
    NullableValue = "jgymxjubdygnvwtxgqxry",
},
            new Stringtext0M
{
    Id = 151,
    Value = "ofcwaddvkvrirlqrerfnftmyixdok",
    ModelInner = new Stringtext0MI
{
    Id = 54,
    Value = "muvqigvimihchmj",
    NullableValue = "satalmlbiesilqjphsuyiehh",
},
    NullableValue = "redewxlpvlqvanlrxumepcjx",
},
            new Stringtext0M
{
    Id = 160,
    Value = "kdxpndamspcykhsug",
    ModelInner = null,
    NullableValue = null,
},
            new Stringtext0M
{
    Id = 163,
    Value = "sdfsdxkvqqbyhwnkvrrcgfwbds",
    ModelInner = new Stringtext0MI
{
    Id = 56,
    Value = "sfjofvy",
    NullableValue = null,
},
    NullableValue = "rtdupvxeeuqnawnhppx",
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
                dbType: (System.Data.SqlDbType)(8)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.String),
                parametrName: "value",
                methodParametrName: "value",
                dbType: (System.Data.SqlDbType)(18)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.String), 
                parametrName: "nullablevalue",
                methodParametrName: "nullablevalue",
                dbType: (System.Data.SqlDbType)(18))
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
                dbType: (System.Data.SqlDbType)(8)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.String), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.SqlDbType)(18)),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.String), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.SqlDbType)(18),
                nullable: true),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "stringtext0mi_id", 
                methodParametrName: "stringtext0mi_id", 
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 46;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 46;
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
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatStringtext0M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatStringtext0M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatStringtext0M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatStringtext0M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatStringtext0M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatStringtext0M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatStringtext0M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatStringtext0M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatStringtext0M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatStringtext0M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatStringtext0M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatStringtext0M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatStringtext0M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatStringtext0M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatStringtext0M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatStringtext0M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatStringtext0M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatStringtext0M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatStringtext0M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatStringtext0M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatStringtext0M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatStringtext0M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatStringtext0M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatStringtext0M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatStringtext0M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatStringtext0M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatStringtext0M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatStringtext0M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatStringtext0M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatStringtext0M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatStringtext0M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatStringtext0M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatStringtext0M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatStringtext0M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatStringtext0M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatStringtext0M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatStringtext0M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatStringtext0M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatStringtext0M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatStringtext0M.AssertModel(secondItems2[19],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 119;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 151;
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
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatStringtext0M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatStringtext0M.AssertModel(secondItems1[1],_testData[29], false);
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 17;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 60;
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
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatStringtext0M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatStringtext0M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatStringtext0M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatStringtext0M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatStringtext0M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatStringtext0M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatStringtext0M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatStringtext0M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatStringtext0M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatStringtext0M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatStringtext0M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatStringtext0M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatStringtext0M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatStringtext0M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatStringtext0M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatStringtext0M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatStringtext0M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatStringtext0M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatStringtext0M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatStringtext0M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatStringtext0M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatStringtext0M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatStringtext0M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatStringtext0M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatStringtext0M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatStringtext0M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatStringtext0M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatStringtext0M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatStringtext0M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatStringtext0M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatStringtext0M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatStringtext0M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatStringtext0M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatStringtext0M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatStringtext0M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatStringtext0M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatStringtext0M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatStringtext0M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatStringtext0M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatStringtext0M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatStringtext0M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatStringtext0M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatStringtext0M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatStringtext0M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatStringtext0M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatStringtext0M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatStringtext0M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatStringtext0M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatStringtext0M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatStringtext0M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatStringtext0M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatStringtext0M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatStringtext0M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatStringtext0M.AssertModel(firstItems2[26],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
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
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 10;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 46;
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
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatStringtext0M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatStringtext0M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatStringtext0M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatStringtext0M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatStringtext0M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatStringtext0M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatStringtext0M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatStringtext0M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatStringtext0M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatStringtext0M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatStringtext0M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatStringtext0M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatStringtext0M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatStringtext0M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatStringtext0M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatStringtext0M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatStringtext0M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatStringtext0M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatStringtext0M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatStringtext0M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatStringtext0M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatStringtext0M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatStringtext0M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatStringtext0M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatStringtext0M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatStringtext0M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatStringtext0M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatStringtext0M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatStringtext0M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatStringtext0M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatStringtext0M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatStringtext0M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatStringtext0M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatStringtext0M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatStringtext0M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatStringtext0M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatStringtext0M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatStringtext0M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatStringtext0M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatStringtext0M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatStringtext0M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatStringtext0M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatStringtext0M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatStringtext0M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatStringtext0M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatStringtext0M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatStringtext0M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatStringtext0M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatStringtext0M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatStringtext0M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatStringtext0M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatStringtext0M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatStringtext0M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatStringtext0M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatStringtext0M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatStringtext0M.AssertModel(firstItems2[27],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatStringtext0M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatStringtext0M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatStringtext0M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatStringtext0M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatStringtext0M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatStringtext0M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatStringtext0M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatStringtext0M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatStringtext0M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatStringtext0M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatStringtext0M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatStringtext0M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatStringtext0M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatStringtext0M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatStringtext0M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatStringtext0M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatStringtext0M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatStringtext0M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatStringtext0M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatStringtext0M.AssertModel(secondItems1[19],_testData[29], false);
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 135;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 46;
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
                int resultIndex = 0;
                foreach(var batchResult in await ((IStringSingleTypetext)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatStringtext0M.AssertModel(models[0],_testData[25], false);
                        FlatStringtext0M.AssertModel(models[1],_testData[26], false);
                        FlatStringtext0M.AssertModel(models[2],_testData[27], false);
                        FlatStringtext0M.AssertModel(models[3],_testData[28], false);
                        FlatStringtext0M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatStringtext0M.AssertModel(models[0],_testData[10], false);
                        FlatStringtext0M.AssertModel(models[1],_testData[11], false);
                        FlatStringtext0M.AssertModel(models[2],_testData[12], false);
                        FlatStringtext0M.AssertModel(models[3],_testData[13], false);
                        FlatStringtext0M.AssertModel(models[4],_testData[14], false);
                        FlatStringtext0M.AssertModel(models[5],_testData[15], false);
                        FlatStringtext0M.AssertModel(models[6],_testData[16], false);
                        FlatStringtext0M.AssertModel(models[7],_testData[17], false);
                        FlatStringtext0M.AssertModel(models[8],_testData[18], false);
                        FlatStringtext0M.AssertModel(models[9],_testData[19], false);
                        FlatStringtext0M.AssertModel(models[10],_testData[20], false);
                        FlatStringtext0M.AssertModel(models[11],_testData[21], false);
                        FlatStringtext0M.AssertModel(models[12],_testData[22], false);
                        FlatStringtext0M.AssertModel(models[13],_testData[23], false);
                        FlatStringtext0M.AssertModel(models[14],_testData[24], false);
                        FlatStringtext0M.AssertModel(models[15],_testData[25], false);
                        FlatStringtext0M.AssertModel(models[16],_testData[26], false);
                        FlatStringtext0M.AssertModel(models[17],_testData[27], false);
                        FlatStringtext0M.AssertModel(models[18],_testData[28], false);
                        FlatStringtext0M.AssertModel(models[19],_testData[29], false);
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
                parametr1.Value = 112;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 151;
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
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                        FlatStringtext0M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatStringtext0M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatStringtext0M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatStringtext0M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatStringtext0M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatStringtext0M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatStringtext0M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatStringtext0M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatStringtext0M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatStringtext0M.AssertModel(firstItems1[9],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatStringtext0M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatStringtext0M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatStringtext0M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatStringtext0M.AssertModel(secondItems2[1],_testData[29], false);
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 21;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 126;
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
                int resultIndex = 0;
                foreach(var batchResult in  ((IStringSingleTypetext)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatStringtext0M.AssertModel(models[0],_testData[23], false);
                        FlatStringtext0M.AssertModel(models[1],_testData[24], false);
                        FlatStringtext0M.AssertModel(models[2],_testData[25], false);
                        FlatStringtext0M.AssertModel(models[3],_testData[26], false);
                        FlatStringtext0M.AssertModel(models[4],_testData[27], false);
                        FlatStringtext0M.AssertModel(models[5],_testData[28], false);
                        FlatStringtext0M.AssertModel(models[6],_testData[29], false);
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
                parametr1.Value = 120;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 64;
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
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatStringtext0M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatStringtext0M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatStringtext0M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatStringtext0M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatStringtext0M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatStringtext0M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatStringtext0M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatStringtext0M.AssertModel(firstItems1[7],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatStringtext0M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatStringtext0M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatStringtext0M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatStringtext0M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatStringtext0M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatStringtext0M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatStringtext0M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatStringtext0M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatStringtext0M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatStringtext0M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatStringtext0M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatStringtext0M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatStringtext0M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatStringtext0M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatStringtext0M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatStringtext0M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatStringtext0M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatStringtext0M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatStringtext0M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatStringtext0M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatStringtext0M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatStringtext0M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatStringtext0M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatStringtext0M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatStringtext0M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatStringtext0M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatStringtext0M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatStringtext0M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatStringtext0M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatStringtext0M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatStringtext0M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatStringtext0M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatStringtext0M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatStringtext0M.AssertModel(secondItems2[16],_testData[29], false);
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 119;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 51;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IStringSingleTypetext)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        Stringtext0M.AssertModel(models[0],_testData[11], false);
                        Stringtext0M.AssertModel(models[1],_testData[12], false);
                        Stringtext0M.AssertModel(models[2],_testData[13], false);
                        Stringtext0M.AssertModel(models[3],_testData[14], false);
                        Stringtext0M.AssertModel(models[4],_testData[15], false);
                        Stringtext0M.AssertModel(models[5],_testData[16], false);
                        Stringtext0M.AssertModel(models[6],_testData[17], false);
                        Stringtext0M.AssertModel(models[7],_testData[18], false);
                        Stringtext0M.AssertModel(models[8],_testData[19], false);
                        Stringtext0M.AssertModel(models[9],_testData[20], false);
                        Stringtext0M.AssertModel(models[10],_testData[21], false);
                        Stringtext0M.AssertModel(models[11],_testData[22], false);
                        Stringtext0M.AssertModel(models[12],_testData[23], false);
                        Stringtext0M.AssertModel(models[13],_testData[24], false);
                        Stringtext0M.AssertModel(models[14],_testData[25], false);
                        Stringtext0M.AssertModel(models[15],_testData[26], false);
                        Stringtext0M.AssertModel(models[16],_testData[27], false);
                        Stringtext0M.AssertModel(models[17],_testData[28], false);
                        Stringtext0M.AssertModel(models[18],_testData[29], false);
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 135;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 143;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
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
                await ((IStringSingleTypetext)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 120, query1, 112, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatStringtext0M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatStringtext0M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatStringtext0M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatStringtext0M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatStringtext0M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatStringtext0M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatStringtext0M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatStringtext0M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatStringtext0M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatStringtext0M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatStringtext0M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatStringtext0M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatStringtext0M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatStringtext0M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatStringtext0M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatStringtext0M.AssertModel(firstItems2[7],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
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
                await ((IStringSingleTypetext)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 17, query1, 51, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatStringtext0M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatStringtext0M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatStringtext0M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatStringtext0M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatStringtext0M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatStringtext0M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatStringtext0M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatStringtext0M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatStringtext0M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatStringtext0M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatStringtext0M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatStringtext0M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatStringtext0M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatStringtext0M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatStringtext0M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatStringtext0M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatStringtext0M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatStringtext0M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatStringtext0M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatStringtext0M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatStringtext0M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatStringtext0M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatStringtext0M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatStringtext0M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatStringtext0M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatStringtext0M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatStringtext0M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatStringtext0M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatStringtext0M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatStringtext0M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatStringtext0M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatStringtext0M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatStringtext0M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatStringtext0M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatStringtext0M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatStringtext0M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatStringtext0M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatStringtext0M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatStringtext0M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatStringtext0M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatStringtext0M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatStringtext0M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatStringtext0M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatStringtext0M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatStringtext0M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatStringtext0M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatStringtext0M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatStringtext0M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatStringtext0M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatStringtext0M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatStringtext0M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatStringtext0M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatStringtext0M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatStringtext0M.AssertModel(firstItems2[26],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatStringtext0M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatStringtext0M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatStringtext0M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatStringtext0M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatStringtext0M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatStringtext0M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatStringtext0M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatStringtext0M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatStringtext0M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatStringtext0M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatStringtext0M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatStringtext0M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatStringtext0M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatStringtext0M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatStringtext0M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatStringtext0M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatStringtext0M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatStringtext0M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatStringtext0M.AssertModel(secondItems1[18],_testData[29], false);
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
                 ((IStringSingleTypetext)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 21, query1, 72, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
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
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatStringtext0M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatStringtext0M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatStringtext0M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatStringtext0M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatStringtext0M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatStringtext0M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatStringtext0M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatStringtext0M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatStringtext0M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatStringtext0M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatStringtext0M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatStringtext0M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatStringtext0M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatStringtext0M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatStringtext0M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatStringtext0M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatStringtext0M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatStringtext0M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatStringtext0M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatStringtext0M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatStringtext0M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatStringtext0M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatStringtext0M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatStringtext0M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatStringtext0M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatStringtext0M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatStringtext0M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatStringtext0M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatStringtext0M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatStringtext0M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatStringtext0M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatStringtext0M.AssertModel(secondItems2[15],_testData[29], false);
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
                 ((IStringSingleTypetext)this).DbConnectionMMDynQuerySelectModelBatch(connection, 120, query1, 25, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatStringtext0M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatStringtext0M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatStringtext0M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatStringtext0M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatStringtext0M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatStringtext0M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatStringtext0M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatStringtext0M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatStringtext0M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatStringtext0M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatStringtext0M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatStringtext0M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatStringtext0M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatStringtext0M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatStringtext0M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatStringtext0M.AssertModel(firstItems2[7],_testData[29], false);
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
                int resultIndex = 0;
                foreach(var batchResult in await ((IStringSingleTypetext)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 126, query1, 60, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatStringtext0M.AssertModel(models[0],_testData[23], false);
                        FlatStringtext0M.AssertModel(models[1],_testData[24], false);
                        FlatStringtext0M.AssertModel(models[2],_testData[25], false);
                        FlatStringtext0M.AssertModel(models[3],_testData[26], false);
                        FlatStringtext0M.AssertModel(models[4],_testData[27], false);
                        FlatStringtext0M.AssertModel(models[5],_testData[28], false);
                        FlatStringtext0M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                await ((IStringSingleTypetext)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 93, query1, 93, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
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
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatStringtext0M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatStringtext0M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatStringtext0M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatStringtext0M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatStringtext0M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatStringtext0M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatStringtext0M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatStringtext0M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatStringtext0M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatStringtext0M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatStringtext0M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatStringtext0M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatStringtext0M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatStringtext0M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatStringtext0M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatStringtext0M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatStringtext0M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatStringtext0M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatStringtext0M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatStringtext0M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatStringtext0M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatStringtext0M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatStringtext0M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatStringtext0M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatStringtext0M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatStringtext0M.AssertModel(secondItems2[12],_testData[29], false);
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
                int resultIndex = 0;
                foreach(var batchResult in  ((IStringSingleTypetext)this).DbConnectionSTDynQuerySelectModelBatch(connection, 46, query1, 135, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatStringtext0M.AssertModel(models[0],_testData[10], false);
                        FlatStringtext0M.AssertModel(models[1],_testData[11], false);
                        FlatStringtext0M.AssertModel(models[2],_testData[12], false);
                        FlatStringtext0M.AssertModel(models[3],_testData[13], false);
                        FlatStringtext0M.AssertModel(models[4],_testData[14], false);
                        FlatStringtext0M.AssertModel(models[5],_testData[15], false);
                        FlatStringtext0M.AssertModel(models[6],_testData[16], false);
                        FlatStringtext0M.AssertModel(models[7],_testData[17], false);
                        FlatStringtext0M.AssertModel(models[8],_testData[18], false);
                        FlatStringtext0M.AssertModel(models[9],_testData[19], false);
                        FlatStringtext0M.AssertModel(models[10],_testData[20], false);
                        FlatStringtext0M.AssertModel(models[11],_testData[21], false);
                        FlatStringtext0M.AssertModel(models[12],_testData[22], false);
                        FlatStringtext0M.AssertModel(models[13],_testData[23], false);
                        FlatStringtext0M.AssertModel(models[14],_testData[24], false);
                        FlatStringtext0M.AssertModel(models[15],_testData[25], false);
                        FlatStringtext0M.AssertModel(models[16],_testData[26], false);
                        FlatStringtext0M.AssertModel(models[17],_testData[27], false);
                        FlatStringtext0M.AssertModel(models[18],_testData[28], false);
                        FlatStringtext0M.AssertModel(models[19],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatStringtext0M.AssertModel(models[0],_testData[25], false);
                        FlatStringtext0M.AssertModel(models[1],_testData[26], false);
                        FlatStringtext0M.AssertModel(models[2],_testData[27], false);
                        FlatStringtext0M.AssertModel(models[3],_testData[28], false);
                        FlatStringtext0M.AssertModel(models[4],_testData[29], false);
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
                 ((IStringSingleTypetext)this).DbConnectionDynQuerySelectModelBatch(connection, 143, query1, 72, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatStringtext0M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatStringtext0M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatStringtext0M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatStringtext0M.AssertModel(firstItems1[3],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatStringtext0M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatStringtext0M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatStringtext0M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatStringtext0M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatStringtext0M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatStringtext0M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatStringtext0M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatStringtext0M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatStringtext0M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatStringtext0M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatStringtext0M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatStringtext0M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatStringtext0M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatStringtext0M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatStringtext0M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatStringtext0M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatStringtext0M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatStringtext0M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatStringtext0M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatStringtext0M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatStringtext0M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatStringtext0M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatStringtext0M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatStringtext0M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatStringtext0M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatStringtext0M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatStringtext0M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatStringtext0M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatStringtext0M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatStringtext0M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatStringtext0M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatStringtext0M.AssertModel(secondItems2[15],_testData[29], false);
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
                foreach(var batchResult in await ((IStringSingleTypetext)this).DbConnectionSTSelectModelBatchAsync(connection, 25, 10))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        Stringtext0M.AssertModel(models[0],_testData[5], false);
                        Stringtext0M.AssertModel(models[1],_testData[6], false);
                        Stringtext0M.AssertModel(models[2],_testData[7], false);
                        Stringtext0M.AssertModel(models[3],_testData[8], false);
                        Stringtext0M.AssertModel(models[4],_testData[9], false);
                        Stringtext0M.AssertModel(models[5],_testData[10], false);
                        Stringtext0M.AssertModel(models[6],_testData[11], false);
                        Stringtext0M.AssertModel(models[7],_testData[12], false);
                        Stringtext0M.AssertModel(models[8],_testData[13], false);
                        Stringtext0M.AssertModel(models[9],_testData[14], false);
                        Stringtext0M.AssertModel(models[10],_testData[15], false);
                        Stringtext0M.AssertModel(models[11],_testData[16], false);
                        Stringtext0M.AssertModel(models[12],_testData[17], false);
                        Stringtext0M.AssertModel(models[13],_testData[18], false);
                        Stringtext0M.AssertModel(models[14],_testData[19], false);
                        Stringtext0M.AssertModel(models[15],_testData[20], false);
                        Stringtext0M.AssertModel(models[16],_testData[21], false);
                        Stringtext0M.AssertModel(models[17],_testData[22], false);
                        Stringtext0M.AssertModel(models[18],_testData[23], false);
                        Stringtext0M.AssertModel(models[19],_testData[24], false);
                        Stringtext0M.AssertModel(models[20],_testData[25], false);
                        Stringtext0M.AssertModel(models[21],_testData[26], false);
                        Stringtext0M.AssertModel(models[22],_testData[27], false);
                        Stringtext0M.AssertModel(models[23],_testData[28], false);
                        Stringtext0M.AssertModel(models[24],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        Stringtext0M.AssertModel(models[0],_testData[2], false);
                        Stringtext0M.AssertModel(models[1],_testData[3], false);
                        Stringtext0M.AssertModel(models[2],_testData[4], false);
                        Stringtext0M.AssertModel(models[3],_testData[5], false);
                        Stringtext0M.AssertModel(models[4],_testData[6], false);
                        Stringtext0M.AssertModel(models[5],_testData[7], false);
                        Stringtext0M.AssertModel(models[6],_testData[8], false);
                        Stringtext0M.AssertModel(models[7],_testData[9], false);
                        Stringtext0M.AssertModel(models[8],_testData[10], false);
                        Stringtext0M.AssertModel(models[9],_testData[11], false);
                        Stringtext0M.AssertModel(models[10],_testData[12], false);
                        Stringtext0M.AssertModel(models[11],_testData[13], false);
                        Stringtext0M.AssertModel(models[12],_testData[14], false);
                        Stringtext0M.AssertModel(models[13],_testData[15], false);
                        Stringtext0M.AssertModel(models[14],_testData[16], false);
                        Stringtext0M.AssertModel(models[15],_testData[17], false);
                        Stringtext0M.AssertModel(models[16],_testData[18], false);
                        Stringtext0M.AssertModel(models[17],_testData[19], false);
                        Stringtext0M.AssertModel(models[18],_testData[20], false);
                        Stringtext0M.AssertModel(models[19],_testData[21], false);
                        Stringtext0M.AssertModel(models[20],_testData[22], false);
                        Stringtext0M.AssertModel(models[21],_testData[23], false);
                        Stringtext0M.AssertModel(models[22],_testData[24], false);
                        Stringtext0M.AssertModel(models[23],_testData[25], false);
                        Stringtext0M.AssertModel(models[24],_testData[26], false);
                        Stringtext0M.AssertModel(models[25],_testData[27], false);
                        Stringtext0M.AssertModel(models[26],_testData[28], false);
                        Stringtext0M.AssertModel(models[27],_testData[29], false);
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
                foreach(var batchResult in  ((IStringSingleTypetext)this).DbConnectionSTSelectModelBatch(connection, 60, 112))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        Stringtext0M.AssertModel(models[0],_testData[12], false);
                        Stringtext0M.AssertModel(models[1],_testData[13], false);
                        Stringtext0M.AssertModel(models[2],_testData[14], false);
                        Stringtext0M.AssertModel(models[3],_testData[15], false);
                        Stringtext0M.AssertModel(models[4],_testData[16], false);
                        Stringtext0M.AssertModel(models[5],_testData[17], false);
                        Stringtext0M.AssertModel(models[6],_testData[18], false);
                        Stringtext0M.AssertModel(models[7],_testData[19], false);
                        Stringtext0M.AssertModel(models[8],_testData[20], false);
                        Stringtext0M.AssertModel(models[9],_testData[21], false);
                        Stringtext0M.AssertModel(models[10],_testData[22], false);
                        Stringtext0M.AssertModel(models[11],_testData[23], false);
                        Stringtext0M.AssertModel(models[12],_testData[24], false);
                        Stringtext0M.AssertModel(models[13],_testData[25], false);
                        Stringtext0M.AssertModel(models[14],_testData[26], false);
                        Stringtext0M.AssertModel(models[15],_testData[27], false);
                        Stringtext0M.AssertModel(models[16],_testData[28], false);
                        Stringtext0M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        Stringtext0M.AssertModel(models[0],_testData[20], false);
                        Stringtext0M.AssertModel(models[1],_testData[21], false);
                        Stringtext0M.AssertModel(models[2],_testData[22], false);
                        Stringtext0M.AssertModel(models[3],_testData[23], false);
                        Stringtext0M.AssertModel(models[4],_testData[24], false);
                        Stringtext0M.AssertModel(models[5],_testData[25], false);
                        Stringtext0M.AssertModel(models[6],_testData[26], false);
                        Stringtext0M.AssertModel(models[7],_testData[27], false);
                        Stringtext0M.AssertModel(models[8],_testData[28], false);
                        Stringtext0M.AssertModel(models[9],_testData[29], false);
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
                ((IStringSingleTypetext)this).SetDbConnectionSelectModelParametrs(cmd, 126);
                var models = await ((IStringSingleTypetext)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(7));
Stringtext0M.AssertModel(models[0],_testData[23], false);Stringtext0M.AssertModel(models[1],_testData[24], false);Stringtext0M.AssertModel(models[2],_testData[25], false);Stringtext0M.AssertModel(models[3],_testData[26], false);Stringtext0M.AssertModel(models[4],_testData[27], false);Stringtext0M.AssertModel(models[5],_testData[28], false);Stringtext0M.AssertModel(models[6],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IStringSingleTypetext)this).CreateDbConnectionSelectModelCommand(connection);
                ((IStringSingleTypetext)this).SetDbConnectionSelectModelParametrs(cmd, 135);
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
                Assert.That((System.String)model[1], Is.EqualTo(("pgekkjgcgukbwhbvagxog")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("efqdlawhxqhdevdffsypupgsgdr")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("wyn")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("pdeibxvcvblbkl")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("hsjwqwrmkcpfekw")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("ynttdnytucplclvyaxvwemnbyokgg")));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("lsrqlfevxwdtl")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((5)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("o")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("xfnkajyugdobwfrkhsijy")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("fhblrpqqprjdhhavhylmfef")));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("dwkdpadfucttpuwbggy")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("")));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("sg")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("lgginubcytkhwajj")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("mgreqqicp")));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("kxn")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("ooaimtibh")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("hgevxiuoxr")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("ctihmyqojoqouoffgfnsy")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("ggsjtolmobrrkrbfgt")));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("gtjydh")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("pdp")));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("yjxkdtwgeyawohdv")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("uvtmegcpujlptvojfy")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("wlvny")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("aojwvu")));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("swgkqfetsy")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("bty")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("mugfom")));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("rmaiedncdesimv")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("blphqbc")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("onypsfngccjxptdxajgdxqtwb")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("ep")));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("mj")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("wuajw")));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("qfuxqx")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("aixmpfotchprpgtvwrsdotdehh")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("yivwen")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("aixsvchrtyeoibkyolwoehk")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("qfevpxfkxqkqtpnnkkbicjbybs")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("braipi")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("arhjjiws")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("jjxxltposjfcuyuxsxyylxhj")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("qrielkauuaodcmdiievabapasp")));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("edcihkk")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("jtaytqwarlqtdscvloh")));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("sheqtapjnu")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("tlkrcdjcycaqtfek")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("bgqysk")));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("iybrqgfckmm")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("lrafilwixnixvvymvhtxgyi")));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("ulnbwtcquosxgerwqohlcavdtnn")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("iaytmrvitvcqhuqpnw")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("hltxfjdxtsi")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("sowwhpmyi")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("tqtawmvjgfwyjkghwidfxsavb")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("cmmf")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("cvtgjdmyogjakdnnwtbhbtbi")));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("uqd")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("jgymxjubdygnvwtxgqxry")));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("ofcwaddvkvrirlqrerfnftmyixdok")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("muvqigvimihchmj")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("satalmlbiesilqjphsuyiehh")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("redewxlpvlqvanlrxumepcjx")));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((160)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("kdxpndamspcykhsug")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((163)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("sdfsdxkvqqbyhwnkvrrcgfwbds")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((56)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("sfjofvy")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("rtdupvxeeuqnawnhppx")));

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
                Assert.That((System.String)model[1], Is.EqualTo(("pgekkjgcgukbwhbvagxog")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("efqdlawhxqhdevdffsypupgsgdr")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("wyn")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("pdeibxvcvblbkl")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("hsjwqwrmkcpfekw")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("ynttdnytucplclvyaxvwemnbyokgg")));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("lsrqlfevxwdtl")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((5)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("o")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("xfnkajyugdobwfrkhsijy")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("fhblrpqqprjdhhavhylmfef")));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("dwkdpadfucttpuwbggy")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("")));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("sg")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("lgginubcytkhwajj")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("mgreqqicp")));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("kxn")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("ooaimtibh")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("hgevxiuoxr")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("ctihmyqojoqouoffgfnsy")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("ggsjtolmobrrkrbfgt")));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("gtjydh")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("pdp")));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("yjxkdtwgeyawohdv")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("uvtmegcpujlptvojfy")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("wlvny")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("aojwvu")));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("swgkqfetsy")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("bty")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("mugfom")));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("rmaiedncdesimv")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("blphqbc")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("onypsfngccjxptdxajgdxqtwb")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("ep")));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("mj")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("wuajw")));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("qfuxqx")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("aixmpfotchprpgtvwrsdotdehh")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("yivwen")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("aixsvchrtyeoibkyolwoehk")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("qfevpxfkxqkqtpnnkkbicjbybs")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("braipi")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("arhjjiws")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("jjxxltposjfcuyuxsxyylxhj")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("qrielkauuaodcmdiievabapasp")));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("edcihkk")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("jtaytqwarlqtdscvloh")));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("sheqtapjnu")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("tlkrcdjcycaqtfek")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("bgqysk")));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("iybrqgfckmm")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("lrafilwixnixvvymvhtxgyi")));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("ulnbwtcquosxgerwqohlcavdtnn")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("iaytmrvitvcqhuqpnw")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("hltxfjdxtsi")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("sowwhpmyi")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("tqtawmvjgfwyjkghwidfxsavb")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("cmmf")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("cvtgjdmyogjakdnnwtbhbtbi")));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("uqd")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("jgymxjubdygnvwtxgqxry")));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("ofcwaddvkvrirlqrerfnftmyixdok")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("muvqigvimihchmj")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("satalmlbiesilqjphsuyiehh")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("redewxlpvlqvanlrxumepcjx")));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((160)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("kdxpndamspcykhsug")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((163)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("sdfsdxkvqqbyhwnkvrrcgfwbds")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((56)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("sfjofvy")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("rtdupvxeeuqnawnhppx")));

            }
        }

#endregion

    }
}

