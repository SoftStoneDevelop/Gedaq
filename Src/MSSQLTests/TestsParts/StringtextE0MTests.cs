

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

        private readonly StringtextE0M[] _testData = new StringtextE0M[]
        {
            new StringtextE0M
{
    Id = 6,
    Value = "fwjvxslqvegiamxmicyhdfynamr",
    ModelInner = null,
    NullableValue = null,
},
            new StringtextE0M
{
    Id = 11,
    Value = "nfqaxuvbkgappmagbbxr",
    ModelInner = new StringtextE0MI
{
    Id = 7,
    Value = "noosurdyxsicfteojyhcrhiunju",
    NullableValue = "ylqkhrqtmvlflinliuhlvaubtjsg",
},
    NullableValue = "frb",
},
            new StringtextE0M
{
    Id = 13,
    Value = "okytvdbptbhmfgy",
    ModelInner = null,
    NullableValue = "pffeaanypxaofrahxko",
},
            new StringtextE0M
{
    Id = 18,
    Value = "cl",
    ModelInner = new StringtextE0MI
{
    Id = 13,
    Value = "fyipfequrct",
    NullableValue = "luiyrfgtcngp",
},
    NullableValue = null,
},
            new StringtextE0M
{
    Id = 21,
    Value = "bnqxxqrccdakgpw",
    ModelInner = null,
    NullableValue = "nvgybtglga",
},
            new StringtextE0M
{
    Id = 23,
    Value = "hpriarw",
    ModelInner = new StringtextE0MI
{
    Id = 17,
    Value = "tk",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringtextE0M
{
    Id = 25,
    Value = "oyvyrcxxvynymphnlqxfjh",
    ModelInner = null,
    NullableValue = null,
},
            new StringtextE0M
{
    Id = 34,
    Value = "qhbplgicadkredqkvbkierc",
    ModelInner = new StringtextE0MI
{
    Id = 20,
    Value = "yjxmauwavffajtifqvd",
    NullableValue = null,
},
    NullableValue = "sufbnkcibfwonstlpo",
},
            new StringtextE0M
{
    Id = 43,
    Value = "xqaipshfl",
    ModelInner = null,
    NullableValue = "fanuujvdfgpwhokjshklsorfxby",
},
            new StringtextE0M
{
    Id = 47,
    Value = "djasmritaaxsdehi",
    ModelInner = new StringtextE0MI
{
    Id = 25,
    Value = "hvtwhavtyvfgxcnxyr",
    NullableValue = "cklmwaggmrwttusmummyvddc",
},
    NullableValue = "rerljrrsfhigeajbtris",
},
            new StringtextE0M
{
    Id = 52,
    Value = "mtqcadposscqkfeofyleiame",
    ModelInner = null,
    NullableValue = "uitadnbqxajkyjkhcafmvfdfxhfq",
},
            new StringtextE0M
{
    Id = 61,
    Value = "ixfcplajky",
    ModelInner = new StringtextE0MI
{
    Id = 33,
    Value = "ahuxnodqoviuri",
    NullableValue = "mpcythhekgbirmxi",
},
    NullableValue = "qskufhimgnado",
},
            new StringtextE0M
{
    Id = 64,
    Value = "krdonagarjengoynyumdgkbj",
    ModelInner = null,
    NullableValue = "qglsvomfjrdlkhkoyupotmtmp",
},
            new StringtextE0M
{
    Id = 70,
    Value = "yyabounatalcmhoghxlrgvb",
    ModelInner = new StringtextE0MI
{
    Id = 34,
    Value = "ucimohxdmibbubdsk",
    NullableValue = "gtpvmfscwddvldedvoymefvrwtxg",
},
    NullableValue = "ytxidpvfestjiybpmvkgae",
},
            new StringtextE0M
{
    Id = 73,
    Value = "dnbopraodotuacsbildutrbqaafi",
    ModelInner = null,
    NullableValue = "oqyjwtxrlpbofky",
},
            new StringtextE0M
{
    Id = 80,
    Value = "jwjxpolavwqamwpgc",
    ModelInner = new StringtextE0MI
{
    Id = 42,
    Value = "iayo",
    NullableValue = "lcmaebtnujnqvnjyexkmb",
},
    NullableValue = "oxtlsgemal",
},
            new StringtextE0M
{
    Id = 83,
    Value = "kcmhsfgbwgecwwristknyojarmwp",
    ModelInner = null,
    NullableValue = "fhofbxxluqwphjidqbchtudhxft",
},
            new StringtextE0M
{
    Id = 85,
    Value = "iuxpohuqfpvmlvnptoqtr",
    ModelInner = new StringtextE0MI
{
    Id = 49,
    Value = "ary",
    NullableValue = "mjatrctxggxr",
},
    NullableValue = null,
},
            new StringtextE0M
{
    Id = 92,
    Value = "ydm",
    ModelInner = null,
    NullableValue = null,
},
            new StringtextE0M
{
    Id = 99,
    Value = "oiihcpuqhnonnkb",
    ModelInner = new StringtextE0MI
{
    Id = 52,
    Value = "",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringtextE0M
{
    Id = 103,
    Value = "iggnuqh",
    ModelInner = null,
    NullableValue = "mmxbgkbutchovltvvatoqiyhh",
},
            new StringtextE0M
{
    Id = 109,
    Value = "vw",
    ModelInner = new StringtextE0MI
{
    Id = 54,
    Value = "vbqioqpcw",
    NullableValue = "smoirvvvelchrubjjyckaihymuh",
},
    NullableValue = "wamddlg",
},
            new StringtextE0M
{
    Id = 117,
    Value = "qwikwmjsjt",
    ModelInner = null,
    NullableValue = null,
},
            new StringtextE0M
{
    Id = 123,
    Value = "hmempnoalpkne",
    ModelInner = new StringtextE0MI
{
    Id = 56,
    Value = "",
    NullableValue = "kvmieggsfxeycqusommg",
},
    NullableValue = null,
},
            new StringtextE0M
{
    Id = 132,
    Value = "dcxgqrsqc",
    ModelInner = null,
    NullableValue = "hjhkalqiphprjsxibvyvtt",
},
            new StringtextE0M
{
    Id = 141,
    Value = "byirnknqfsd",
    ModelInner = new StringtextE0MI
{
    Id = 61,
    Value = "wquilcqgq",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringtextE0M
{
    Id = 142,
    Value = "q",
    ModelInner = null,
    NullableValue = "kvdfjqpcottaqdh",
},
            new StringtextE0M
{
    Id = 150,
    Value = "sltxkfpgtlf",
    ModelInner = new StringtextE0MI
{
    Id = 68,
    Value = "qbiklduylcojrgfkwyrye",
    NullableValue = "",
},
    NullableValue = null,
},
            new StringtextE0M
{
    Id = 151,
    Value = "ioyjkpwygefhacnxlfnovjfbfl",
    ModelInner = null,
    NullableValue = "hggwqscjnhyq",
},
            new StringtextE0M
{
    Id = 160,
    Value = "xrilavlbuvivssdgnmcogd",
    ModelInner = new StringtextE0MI
{
    Id = 71,
    Value = "tvkav",
    NullableValue = "bf",
},
    NullableValue = null,
},
            new StringtextE0M
{
    Id = 167,
    Value = "tx",
    ModelInner = null,
    NullableValue = "nv",
},
            new StringtextE0M
{
    Id = 172,
    Value = "wlikmogrhpfveqcce",
    ModelInner = new StringtextE0MI
{
    Id = 78,
    Value = "bvbqrpejabklk",
    NullableValue = "r",
},
    NullableValue = null,
},
            new StringtextE0M
{
    Id = 181,
    Value = "valioqbgarsk",
    ModelInner = null,
    NullableValue = null,
},
            new StringtextE0M
{
    Id = 182,
    Value = "efyppaxptmaujbbjcoibemgkd",
    ModelInner = new StringtextE0MI
{
    Id = 85,
    Value = "ipkywyqxphxpvllmbbmdnndy",
    NullableValue = "nvcyqrnqpnihaqupuhypew",
},
    NullableValue = null,
},
            new StringtextE0M
{
    Id = 185,
    Value = "lh",
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.SqlClient.Attributes.Query(
            query: @"
INSERT INTO dbo.stringtexte0mi(
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
INSERT INTO dbo.stringtexte0mi(
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

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertInnerModelAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertInnerModelAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.SqlClient.Attributes.Query(
            query: @"
INSERT INTO dbo.stringtexte0m(
	id,
    value,
    nullablevalue,
    stringtexte0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @stringtexte0mi_id
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
                parametrName: "stringtexte0mi_id", 
                methodParametrName: "stringtexte0mi_id", 
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
INSERT INTO dbo.stringtexte0m(
	id,
    value,
    nullablevalue,
    stringtexte0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @stringtexte0mi_id
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
                parametrName: "stringtexte0mi_id", 
                methodParametrName: "stringtexte0mi_id", 
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

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatStringtextE0M), typeof(FlatStringtextE0M)],
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
FROM dbo.stringtexte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models1 = new List<FlatStringtextE0M>();
                var models2 = new List<FlatStringtextE0M>();
                await((IStringSingleTypetext)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatStringtextE0M.AssertModel(models1[i],_testData[i], false);
                    FlatStringtextE0M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.stringtexte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new SqlParameter();
                parametr1.Value = 0;
                parametr1.SqlDbType = System.Data.SqlDbType.Int;
                parametr1.ParameterName = "id";
                var models1 = new List<FlatStringtextE0M>();
                var models2 = new List<FlatStringtextE0M>();
                ((IStringSingleTypetext)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatStringtextE0M.AssertModel(models1[i],_testData[i], false);
                    FlatStringtextE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatStringtextE0M)],
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
FROM dbo.stringtexte0m m
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatStringtextE0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.stringtexte0m m
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatStringtextE0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.stringtexte0m m
LEFT JOIN dbo.stringtexte0mi mi ON mi.id = m.stringtexte0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(StringtextE0M)],
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    StringtextE0M.AssertModel(models[i],_testData[i], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    StringtextE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatStringtextE0M), typeof(FlatStringtextE0M)],
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
FROM dbo.stringtexte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatStringtextE0M>();
                var models2 = new List<FlatStringtextE0M>();
                await((IStringSingleTypetext)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatStringtextE0M.AssertModel(models1[i],_testData[i], false);
                    FlatStringtextE0M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.stringtexte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatStringtextE0M>();
                var models2 = new List<FlatStringtextE0M>();
                ((IStringSingleTypetext)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatStringtextE0M.AssertModel(models1[i],_testData[i], false);
                    FlatStringtextE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.SqlClient.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatStringtextE0M)],
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
FROM dbo.stringtexte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IStringSingleTypetext)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatStringtextE0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.stringtexte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IStringSingleTypetext)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatStringtextE0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.stringtexte0m m
LEFT JOIN dbo.stringtexte0mi mi ON mi.id = m.stringtexte0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(StringtextE0M)],
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    StringtextE0M.AssertModel(models[i],_testData[i], false);
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
                    StringtextE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatStringtextE0M), typeof(FlatStringtextE0M)],
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
FROM dbo.stringtexte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatStringtextE0M>();
                var models2 = new List<FlatStringtextE0M>();
                await((IStringSingleTypetext)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatStringtextE0M.AssertModel(models1[i],_testData[i], false);
                    FlatStringtextE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 18;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 92;
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
FROM dbo.stringtexte0m m
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
FROM dbo.stringtexte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatStringtextE0M>();
                var firstItems2 = new List<FlatStringtextE0M>();
                var secondItems1 = new List<FlatStringtextE0M>();
                var secondItems2 = new List<FlatStringtextE0M>();
                await ((IStringSingleTypetext)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatStringtextE0M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatStringtextE0M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatStringtextE0M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatStringtextE0M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatStringtextE0M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatStringtextE0M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatStringtextE0M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatStringtextE0M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatStringtextE0M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatStringtextE0M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatStringtextE0M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatStringtextE0M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatStringtextE0M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatStringtextE0M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatStringtextE0M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatStringtextE0M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatStringtextE0M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatStringtextE0M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatStringtextE0M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatStringtextE0M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatStringtextE0M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatStringtextE0M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatStringtextE0M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatStringtextE0M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatStringtextE0M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatStringtextE0M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatStringtextE0M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatStringtextE0M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatStringtextE0M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatStringtextE0M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatStringtextE0M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatStringtextE0M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatStringtextE0M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatStringtextE0M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatStringtextE0M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatStringtextE0M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatStringtextE0M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatStringtextE0M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatStringtextE0M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatStringtextE0M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatStringtextE0M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatStringtextE0M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatStringtextE0M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatStringtextE0M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatStringtextE0M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatStringtextE0M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatStringtextE0M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatStringtextE0M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatStringtextE0M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatStringtextE0M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatStringtextE0M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatStringtextE0M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatStringtextE0M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatStringtextE0M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatStringtextE0M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatStringtextE0M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatStringtextE0M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatStringtextE0M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatStringtextE0M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatStringtextE0M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatStringtextE0M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatStringtextE0M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatStringtextE0M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatStringtextE0M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatStringtextE0M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatStringtextE0M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatStringtextE0M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatStringtextE0M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatStringtextE0M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatStringtextE0M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatStringtextE0M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatStringtextE0M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatStringtextE0M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatStringtextE0M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatStringtextE0M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatStringtextE0M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatStringtextE0M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatStringtextE0M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatStringtextE0M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatStringtextE0M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatStringtextE0M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatStringtextE0M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatStringtextE0M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatStringtextE0M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatStringtextE0M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatStringtextE0M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatStringtextE0M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatStringtextE0M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatStringtextE0M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatStringtextE0M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatStringtextE0M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatStringtextE0M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatStringtextE0M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatStringtextE0M.AssertModel(secondItems2[15],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 85;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 13;
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
FROM dbo.stringtexte0m m
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
FROM dbo.stringtexte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatStringtextE0M>();
                var firstItems2 = new List<FlatStringtextE0M>();
                var secondItems1 = new List<FlatStringtextE0M>();
                await ((IStringSingleTypetext)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatStringtextE0M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatStringtextE0M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatStringtextE0M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatStringtextE0M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatStringtextE0M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatStringtextE0M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatStringtextE0M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatStringtextE0M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatStringtextE0M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatStringtextE0M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatStringtextE0M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatStringtextE0M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatStringtextE0M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatStringtextE0M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatStringtextE0M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatStringtextE0M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatStringtextE0M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatStringtextE0M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatStringtextE0M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatStringtextE0M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatStringtextE0M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatStringtextE0M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatStringtextE0M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatStringtextE0M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatStringtextE0M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatStringtextE0M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatStringtextE0M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatStringtextE0M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatStringtextE0M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatStringtextE0M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatStringtextE0M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatStringtextE0M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatStringtextE0M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatStringtextE0M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                        FlatStringtextE0M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatStringtextE0M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatStringtextE0M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatStringtextE0M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatStringtextE0M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatStringtextE0M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatStringtextE0M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatStringtextE0M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatStringtextE0M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatStringtextE0M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatStringtextE0M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatStringtextE0M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatStringtextE0M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatStringtextE0M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatStringtextE0M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatStringtextE0M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatStringtextE0M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatStringtextE0M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatStringtextE0M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatStringtextE0M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatStringtextE0M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatStringtextE0M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatStringtextE0M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatStringtextE0M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatStringtextE0M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatStringtextE0M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatStringtextE0M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatStringtextE0M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatStringtextE0M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatStringtextE0M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatStringtextE0M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatStringtextE0M.AssertModel(secondItems1[31],_testData[34], false);
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
FROM dbo.stringtexte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatStringtextE0M>();
                var models2 = new List<FlatStringtextE0M>();
                ((IStringSingleTypetext)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatStringtextE0M.AssertModel(models1[i],_testData[i], false);
                    FlatStringtextE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 23;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 117;
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
FROM dbo.stringtexte0m m
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
FROM dbo.stringtexte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatStringtextE0M>();
                var firstItems2 = new List<FlatStringtextE0M>();
                var secondItems1 = new List<FlatStringtextE0M>();
                var secondItems2 = new List<FlatStringtextE0M>();
                 ((IStringSingleTypetext)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatStringtextE0M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatStringtextE0M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatStringtextE0M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatStringtextE0M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatStringtextE0M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatStringtextE0M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatStringtextE0M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatStringtextE0M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatStringtextE0M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatStringtextE0M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatStringtextE0M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatStringtextE0M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatStringtextE0M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatStringtextE0M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatStringtextE0M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatStringtextE0M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatStringtextE0M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatStringtextE0M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatStringtextE0M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatStringtextE0M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatStringtextE0M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatStringtextE0M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatStringtextE0M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatStringtextE0M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatStringtextE0M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatStringtextE0M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatStringtextE0M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatStringtextE0M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatStringtextE0M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatStringtextE0M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatStringtextE0M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatStringtextE0M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatStringtextE0M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatStringtextE0M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatStringtextE0M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatStringtextE0M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatStringtextE0M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatStringtextE0M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatStringtextE0M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatStringtextE0M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatStringtextE0M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatStringtextE0M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatStringtextE0M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatStringtextE0M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatStringtextE0M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatStringtextE0M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatStringtextE0M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatStringtextE0M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatStringtextE0M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatStringtextE0M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatStringtextE0M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatStringtextE0M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatStringtextE0M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatStringtextE0M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatStringtextE0M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatStringtextE0M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatStringtextE0M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatStringtextE0M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatStringtextE0M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatStringtextE0M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatStringtextE0M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatStringtextE0M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatStringtextE0M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatStringtextE0M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatStringtextE0M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatStringtextE0M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatStringtextE0M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatStringtextE0M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatStringtextE0M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatStringtextE0M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatStringtextE0M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatStringtextE0M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatStringtextE0M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatStringtextE0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatStringtextE0M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatStringtextE0M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatStringtextE0M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatStringtextE0M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatStringtextE0M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatStringtextE0M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatStringtextE0M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatStringtextE0M.AssertModel(secondItems2[11],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 47;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 142;
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
FROM dbo.stringtexte0m m
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
FROM dbo.stringtexte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatStringtextE0M>();
                var firstItems2 = new List<FlatStringtextE0M>();
                var secondItems1 = new List<FlatStringtextE0M>();
                 ((IStringSingleTypetext)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatStringtextE0M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatStringtextE0M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatStringtextE0M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatStringtextE0M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatStringtextE0M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatStringtextE0M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatStringtextE0M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatStringtextE0M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatStringtextE0M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatStringtextE0M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatStringtextE0M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatStringtextE0M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatStringtextE0M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatStringtextE0M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatStringtextE0M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatStringtextE0M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatStringtextE0M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatStringtextE0M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatStringtextE0M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatStringtextE0M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatStringtextE0M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatStringtextE0M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatStringtextE0M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatStringtextE0M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatStringtextE0M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatStringtextE0M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatStringtextE0M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatStringtextE0M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatStringtextE0M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatStringtextE0M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatStringtextE0M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatStringtextE0M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatStringtextE0M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatStringtextE0M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatStringtextE0M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatStringtextE0M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatStringtextE0M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatStringtextE0M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatStringtextE0M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatStringtextE0M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatStringtextE0M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatStringtextE0M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatStringtextE0M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatStringtextE0M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatStringtextE0M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatStringtextE0M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatStringtextE0M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatStringtextE0M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatStringtextE0M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatStringtextE0M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatStringtextE0M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatStringtextE0M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatStringtextE0M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatStringtextE0M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatStringtextE0M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatStringtextE0M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatStringtextE0M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatStringtextE0M.AssertModel(secondItems1[7],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatStringtextE0M)],
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
FROM dbo.stringtexte0m m
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
                    FlatStringtextE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 80;
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
FROM dbo.stringtexte0m m
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
FROM dbo.stringtexte0m m
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
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatStringtextE0M.AssertModel(models[0],_testData[16], false);
                        FlatStringtextE0M.AssertModel(models[1],_testData[17], false);
                        FlatStringtextE0M.AssertModel(models[2],_testData[18], false);
                        FlatStringtextE0M.AssertModel(models[3],_testData[19], false);
                        FlatStringtextE0M.AssertModel(models[4],_testData[20], false);
                        FlatStringtextE0M.AssertModel(models[5],_testData[21], false);
                        FlatStringtextE0M.AssertModel(models[6],_testData[22], false);
                        FlatStringtextE0M.AssertModel(models[7],_testData[23], false);
                        FlatStringtextE0M.AssertModel(models[8],_testData[24], false);
                        FlatStringtextE0M.AssertModel(models[9],_testData[25], false);
                        FlatStringtextE0M.AssertModel(models[10],_testData[26], false);
                        FlatStringtextE0M.AssertModel(models[11],_testData[27], false);
                        FlatStringtextE0M.AssertModel(models[12],_testData[28], false);
                        FlatStringtextE0M.AssertModel(models[13],_testData[29], false);
                        FlatStringtextE0M.AssertModel(models[14],_testData[30], false);
                        FlatStringtextE0M.AssertModel(models[15],_testData[31], false);
                        FlatStringtextE0M.AssertModel(models[16],_testData[32], false);
                        FlatStringtextE0M.AssertModel(models[17],_testData[33], false);
                        FlatStringtextE0M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatStringtextE0M.AssertModel(models[0],_testData[9], false);
                        FlatStringtextE0M.AssertModel(models[1],_testData[10], false);
                        FlatStringtextE0M.AssertModel(models[2],_testData[11], false);
                        FlatStringtextE0M.AssertModel(models[3],_testData[12], false);
                        FlatStringtextE0M.AssertModel(models[4],_testData[13], false);
                        FlatStringtextE0M.AssertModel(models[5],_testData[14], false);
                        FlatStringtextE0M.AssertModel(models[6],_testData[15], false);
                        FlatStringtextE0M.AssertModel(models[7],_testData[16], false);
                        FlatStringtextE0M.AssertModel(models[8],_testData[17], false);
                        FlatStringtextE0M.AssertModel(models[9],_testData[18], false);
                        FlatStringtextE0M.AssertModel(models[10],_testData[19], false);
                        FlatStringtextE0M.AssertModel(models[11],_testData[20], false);
                        FlatStringtextE0M.AssertModel(models[12],_testData[21], false);
                        FlatStringtextE0M.AssertModel(models[13],_testData[22], false);
                        FlatStringtextE0M.AssertModel(models[14],_testData[23], false);
                        FlatStringtextE0M.AssertModel(models[15],_testData[24], false);
                        FlatStringtextE0M.AssertModel(models[16],_testData[25], false);
                        FlatStringtextE0M.AssertModel(models[17],_testData[26], false);
                        FlatStringtextE0M.AssertModel(models[18],_testData[27], false);
                        FlatStringtextE0M.AssertModel(models[19],_testData[28], false);
                        FlatStringtextE0M.AssertModel(models[20],_testData[29], false);
                        FlatStringtextE0M.AssertModel(models[21],_testData[30], false);
                        FlatStringtextE0M.AssertModel(models[22],_testData[31], false);
                        FlatStringtextE0M.AssertModel(models[23],_testData[32], false);
                        FlatStringtextE0M.AssertModel(models[24],_testData[33], false);
                        FlatStringtextE0M.AssertModel(models[25],_testData[34], false);
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
                parametr1.Value = 34;
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
FROM dbo.stringtexte0m m
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
FROM dbo.stringtexte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatStringtextE0M>();
                var secondItems1 = new List<FlatStringtextE0M>();
                var secondItems2 = new List<FlatStringtextE0M>();
                await ((IStringSingleTypetext)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatStringtextE0M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatStringtextE0M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatStringtextE0M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatStringtextE0M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatStringtextE0M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatStringtextE0M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatStringtextE0M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatStringtextE0M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatStringtextE0M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatStringtextE0M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatStringtextE0M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatStringtextE0M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatStringtextE0M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatStringtextE0M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatStringtextE0M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatStringtextE0M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatStringtextE0M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatStringtextE0M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatStringtextE0M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatStringtextE0M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatStringtextE0M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatStringtextE0M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatStringtextE0M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatStringtextE0M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatStringtextE0M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatStringtextE0M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatStringtextE0M.AssertModel(firstItems1[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatStringtextE0M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatStringtextE0M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatStringtextE0M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatStringtextE0M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatStringtextE0M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatStringtextE0M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatStringtextE0M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatStringtextE0M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatStringtextE0M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatStringtextE0M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatStringtextE0M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatStringtextE0M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatStringtextE0M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatStringtextE0M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatStringtextE0M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatStringtextE0M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatStringtextE0M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatStringtextE0M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatStringtextE0M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatStringtextE0M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatStringtextE0M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatStringtextE0M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatStringtextE0M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatStringtextE0M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatStringtextE0M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatStringtextE0M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatStringtextE0M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatStringtextE0M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatStringtextE0M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatStringtextE0M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatStringtextE0M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatStringtextE0M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatStringtextE0M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatStringtextE0M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatStringtextE0M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatStringtextE0M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatStringtextE0M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatStringtextE0M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatStringtextE0M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatStringtextE0M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatStringtextE0M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatStringtextE0M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatStringtextE0M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatStringtextE0M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatStringtextE0M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatStringtextE0M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatStringtextE0M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatStringtextE0M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatStringtextE0M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatStringtextE0M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatStringtextE0M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatStringtextE0M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatStringtextE0M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatStringtextE0M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatStringtextE0M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatStringtextE0M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatStringtextE0M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatStringtextE0M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatStringtextE0M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatStringtextE0M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatStringtextE0M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatStringtextE0M.AssertModel(secondItems2[30],_testData[34], false);
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
FROM dbo.stringtexte0m m
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
                    FlatStringtextE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 25;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 6;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.stringtexte0m m
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
FROM dbo.stringtexte0m m
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
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatStringtextE0M.AssertModel(models[0],_testData[7], false);
                        FlatStringtextE0M.AssertModel(models[1],_testData[8], false);
                        FlatStringtextE0M.AssertModel(models[2],_testData[9], false);
                        FlatStringtextE0M.AssertModel(models[3],_testData[10], false);
                        FlatStringtextE0M.AssertModel(models[4],_testData[11], false);
                        FlatStringtextE0M.AssertModel(models[5],_testData[12], false);
                        FlatStringtextE0M.AssertModel(models[6],_testData[13], false);
                        FlatStringtextE0M.AssertModel(models[7],_testData[14], false);
                        FlatStringtextE0M.AssertModel(models[8],_testData[15], false);
                        FlatStringtextE0M.AssertModel(models[9],_testData[16], false);
                        FlatStringtextE0M.AssertModel(models[10],_testData[17], false);
                        FlatStringtextE0M.AssertModel(models[11],_testData[18], false);
                        FlatStringtextE0M.AssertModel(models[12],_testData[19], false);
                        FlatStringtextE0M.AssertModel(models[13],_testData[20], false);
                        FlatStringtextE0M.AssertModel(models[14],_testData[21], false);
                        FlatStringtextE0M.AssertModel(models[15],_testData[22], false);
                        FlatStringtextE0M.AssertModel(models[16],_testData[23], false);
                        FlatStringtextE0M.AssertModel(models[17],_testData[24], false);
                        FlatStringtextE0M.AssertModel(models[18],_testData[25], false);
                        FlatStringtextE0M.AssertModel(models[19],_testData[26], false);
                        FlatStringtextE0M.AssertModel(models[20],_testData[27], false);
                        FlatStringtextE0M.AssertModel(models[21],_testData[28], false);
                        FlatStringtextE0M.AssertModel(models[22],_testData[29], false);
                        FlatStringtextE0M.AssertModel(models[23],_testData[30], false);
                        FlatStringtextE0M.AssertModel(models[24],_testData[31], false);
                        FlatStringtextE0M.AssertModel(models[25],_testData[32], false);
                        FlatStringtextE0M.AssertModel(models[26],_testData[33], false);
                        FlatStringtextE0M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatStringtextE0M.AssertModel(models[0],_testData[1], false);
                        FlatStringtextE0M.AssertModel(models[1],_testData[2], false);
                        FlatStringtextE0M.AssertModel(models[2],_testData[3], false);
                        FlatStringtextE0M.AssertModel(models[3],_testData[4], false);
                        FlatStringtextE0M.AssertModel(models[4],_testData[5], false);
                        FlatStringtextE0M.AssertModel(models[5],_testData[6], false);
                        FlatStringtextE0M.AssertModel(models[6],_testData[7], false);
                        FlatStringtextE0M.AssertModel(models[7],_testData[8], false);
                        FlatStringtextE0M.AssertModel(models[8],_testData[9], false);
                        FlatStringtextE0M.AssertModel(models[9],_testData[10], false);
                        FlatStringtextE0M.AssertModel(models[10],_testData[11], false);
                        FlatStringtextE0M.AssertModel(models[11],_testData[12], false);
                        FlatStringtextE0M.AssertModel(models[12],_testData[13], false);
                        FlatStringtextE0M.AssertModel(models[13],_testData[14], false);
                        FlatStringtextE0M.AssertModel(models[14],_testData[15], false);
                        FlatStringtextE0M.AssertModel(models[15],_testData[16], false);
                        FlatStringtextE0M.AssertModel(models[16],_testData[17], false);
                        FlatStringtextE0M.AssertModel(models[17],_testData[18], false);
                        FlatStringtextE0M.AssertModel(models[18],_testData[19], false);
                        FlatStringtextE0M.AssertModel(models[19],_testData[20], false);
                        FlatStringtextE0M.AssertModel(models[20],_testData[21], false);
                        FlatStringtextE0M.AssertModel(models[21],_testData[22], false);
                        FlatStringtextE0M.AssertModel(models[22],_testData[23], false);
                        FlatStringtextE0M.AssertModel(models[23],_testData[24], false);
                        FlatStringtextE0M.AssertModel(models[24],_testData[25], false);
                        FlatStringtextE0M.AssertModel(models[25],_testData[26], false);
                        FlatStringtextE0M.AssertModel(models[26],_testData[27], false);
                        FlatStringtextE0M.AssertModel(models[27],_testData[28], false);
                        FlatStringtextE0M.AssertModel(models[28],_testData[29], false);
                        FlatStringtextE0M.AssertModel(models[29],_testData[30], false);
                        FlatStringtextE0M.AssertModel(models[30],_testData[31], false);
                        FlatStringtextE0M.AssertModel(models[31],_testData[32], false);
                        FlatStringtextE0M.AssertModel(models[32],_testData[33], false);
                        FlatStringtextE0M.AssertModel(models[33],_testData[34], false);
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
                parametr1.Value = 151;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 13;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM dbo.stringtexte0m m
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
FROM dbo.stringtexte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatStringtextE0M>();
                var secondItems1 = new List<FlatStringtextE0M>();
                var secondItems2 = new List<FlatStringtextE0M>();
                 ((IStringSingleTypetext)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatStringtextE0M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatStringtextE0M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatStringtextE0M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatStringtextE0M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatStringtextE0M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatStringtextE0M.AssertModel(firstItems1[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatStringtextE0M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatStringtextE0M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatStringtextE0M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatStringtextE0M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatStringtextE0M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatStringtextE0M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatStringtextE0M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatStringtextE0M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatStringtextE0M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatStringtextE0M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatStringtextE0M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatStringtextE0M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatStringtextE0M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatStringtextE0M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatStringtextE0M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatStringtextE0M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatStringtextE0M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatStringtextE0M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatStringtextE0M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatStringtextE0M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatStringtextE0M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatStringtextE0M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatStringtextE0M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatStringtextE0M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatStringtextE0M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatStringtextE0M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatStringtextE0M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatStringtextE0M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatStringtextE0M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatStringtextE0M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatStringtextE0M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatStringtextE0M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatStringtextE0M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatStringtextE0M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatStringtextE0M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatStringtextE0M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatStringtextE0M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatStringtextE0M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatStringtextE0M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatStringtextE0M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatStringtextE0M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatStringtextE0M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatStringtextE0M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatStringtextE0M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatStringtextE0M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatStringtextE0M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatStringtextE0M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatStringtextE0M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatStringtextE0M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatStringtextE0M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatStringtextE0M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatStringtextE0M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatStringtextE0M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatStringtextE0M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatStringtextE0M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatStringtextE0M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatStringtextE0M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatStringtextE0M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatStringtextE0M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatStringtextE0M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatStringtextE0M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatStringtextE0M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatStringtextE0M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatStringtextE0M.AssertModel(secondItems2[31],_testData[34], false);
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
FROM dbo.stringtexte0m m
LEFT JOIN dbo.stringtexte0mi mi ON mi.id = m.stringtexte0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(StringtextE0M)],
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
                    StringtextE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 43;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 21;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IStringSingleTypetext)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        StringtextE0M.AssertModel(models[0],_testData[9], false);
                        StringtextE0M.AssertModel(models[1],_testData[10], false);
                        StringtextE0M.AssertModel(models[2],_testData[11], false);
                        StringtextE0M.AssertModel(models[3],_testData[12], false);
                        StringtextE0M.AssertModel(models[4],_testData[13], false);
                        StringtextE0M.AssertModel(models[5],_testData[14], false);
                        StringtextE0M.AssertModel(models[6],_testData[15], false);
                        StringtextE0M.AssertModel(models[7],_testData[16], false);
                        StringtextE0M.AssertModel(models[8],_testData[17], false);
                        StringtextE0M.AssertModel(models[9],_testData[18], false);
                        StringtextE0M.AssertModel(models[10],_testData[19], false);
                        StringtextE0M.AssertModel(models[11],_testData[20], false);
                        StringtextE0M.AssertModel(models[12],_testData[21], false);
                        StringtextE0M.AssertModel(models[13],_testData[22], false);
                        StringtextE0M.AssertModel(models[14],_testData[23], false);
                        StringtextE0M.AssertModel(models[15],_testData[24], false);
                        StringtextE0M.AssertModel(models[16],_testData[25], false);
                        StringtextE0M.AssertModel(models[17],_testData[26], false);
                        StringtextE0M.AssertModel(models[18],_testData[27], false);
                        StringtextE0M.AssertModel(models[19],_testData[28], false);
                        StringtextE0M.AssertModel(models[20],_testData[29], false);
                        StringtextE0M.AssertModel(models[21],_testData[30], false);
                        StringtextE0M.AssertModel(models[22],_testData[31], false);
                        StringtextE0M.AssertModel(models[23],_testData[32], false);
                        StringtextE0M.AssertModel(models[24],_testData[33], false);
                        StringtextE0M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        StringtextE0M.AssertModel(models[0],_testData[5], false);
                        StringtextE0M.AssertModel(models[1],_testData[6], false);
                        StringtextE0M.AssertModel(models[2],_testData[7], false);
                        StringtextE0M.AssertModel(models[3],_testData[8], false);
                        StringtextE0M.AssertModel(models[4],_testData[9], false);
                        StringtextE0M.AssertModel(models[5],_testData[10], false);
                        StringtextE0M.AssertModel(models[6],_testData[11], false);
                        StringtextE0M.AssertModel(models[7],_testData[12], false);
                        StringtextE0M.AssertModel(models[8],_testData[13], false);
                        StringtextE0M.AssertModel(models[9],_testData[14], false);
                        StringtextE0M.AssertModel(models[10],_testData[15], false);
                        StringtextE0M.AssertModel(models[11],_testData[16], false);
                        StringtextE0M.AssertModel(models[12],_testData[17], false);
                        StringtextE0M.AssertModel(models[13],_testData[18], false);
                        StringtextE0M.AssertModel(models[14],_testData[19], false);
                        StringtextE0M.AssertModel(models[15],_testData[20], false);
                        StringtextE0M.AssertModel(models[16],_testData[21], false);
                        StringtextE0M.AssertModel(models[17],_testData[22], false);
                        StringtextE0M.AssertModel(models[18],_testData[23], false);
                        StringtextE0M.AssertModel(models[19],_testData[24], false);
                        StringtextE0M.AssertModel(models[20],_testData[25], false);
                        StringtextE0M.AssertModel(models[21],_testData[26], false);
                        StringtextE0M.AssertModel(models[22],_testData[27], false);
                        StringtextE0M.AssertModel(models[23],_testData[28], false);
                        StringtextE0M.AssertModel(models[24],_testData[29], false);
                        StringtextE0M.AssertModel(models[25],_testData[30], false);
                        StringtextE0M.AssertModel(models[26],_testData[31], false);
                        StringtextE0M.AssertModel(models[27],_testData[32], false);
                        StringtextE0M.AssertModel(models[28],_testData[33], false);
                        StringtextE0M.AssertModel(models[29],_testData[34], false);
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
                    StringtextE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 99;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 167;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IStringSingleTypetext)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        StringtextE0M.AssertModel(models[0],_testData[20], false);
                        StringtextE0M.AssertModel(models[1],_testData[21], false);
                        StringtextE0M.AssertModel(models[2],_testData[22], false);
                        StringtextE0M.AssertModel(models[3],_testData[23], false);
                        StringtextE0M.AssertModel(models[4],_testData[24], false);
                        StringtextE0M.AssertModel(models[5],_testData[25], false);
                        StringtextE0M.AssertModel(models[6],_testData[26], false);
                        StringtextE0M.AssertModel(models[7],_testData[27], false);
                        StringtextE0M.AssertModel(models[8],_testData[28], false);
                        StringtextE0M.AssertModel(models[9],_testData[29], false);
                        StringtextE0M.AssertModel(models[10],_testData[30], false);
                        StringtextE0M.AssertModel(models[11],_testData[31], false);
                        StringtextE0M.AssertModel(models[12],_testData[32], false);
                        StringtextE0M.AssertModel(models[13],_testData[33], false);
                        StringtextE0M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        StringtextE0M.AssertModel(models[0],_testData[31], false);
                        StringtextE0M.AssertModel(models[1],_testData[32], false);
                        StringtextE0M.AssertModel(models[2],_testData[33], false);
                        StringtextE0M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatStringtextE0M), typeof(FlatStringtextE0M)],
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
FROM dbo.stringtexte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatStringtextE0M>();
                var models2 = new List<FlatStringtextE0M>();
                await((IStringSingleTypetext)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatStringtextE0M.AssertModel(models1[i],_testData[i], false);
                    FlatStringtextE0M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.stringtexte0m m
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
FROM dbo.stringtexte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatStringtextE0M>();
                var firstItems2 = new List<FlatStringtextE0M>();
                var secondItems1 = new List<FlatStringtextE0M>();
                var secondItems2 = new List<FlatStringtextE0M>();
                await ((IStringSingleTypetext)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 70, query1, 99, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatStringtextE0M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatStringtextE0M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatStringtextE0M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatStringtextE0M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatStringtextE0M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatStringtextE0M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatStringtextE0M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatStringtextE0M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatStringtextE0M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatStringtextE0M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatStringtextE0M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatStringtextE0M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatStringtextE0M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatStringtextE0M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatStringtextE0M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatStringtextE0M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatStringtextE0M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatStringtextE0M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatStringtextE0M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatStringtextE0M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatStringtextE0M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatStringtextE0M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatStringtextE0M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatStringtextE0M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatStringtextE0M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatStringtextE0M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatStringtextE0M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatStringtextE0M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatStringtextE0M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatStringtextE0M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatStringtextE0M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatStringtextE0M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatStringtextE0M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatStringtextE0M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatStringtextE0M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatStringtextE0M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatStringtextE0M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatStringtextE0M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatStringtextE0M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatStringtextE0M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatStringtextE0M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatStringtextE0M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatStringtextE0M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatStringtextE0M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatStringtextE0M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatStringtextE0M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatStringtextE0M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatStringtextE0M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatStringtextE0M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatStringtextE0M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatStringtextE0M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatStringtextE0M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatStringtextE0M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatStringtextE0M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatStringtextE0M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatStringtextE0M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatStringtextE0M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatStringtextE0M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatStringtextE0M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatStringtextE0M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatStringtextE0M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatStringtextE0M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatStringtextE0M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatStringtextE0M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatStringtextE0M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatStringtextE0M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatStringtextE0M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatStringtextE0M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatStringtextE0M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatStringtextE0M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatStringtextE0M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatStringtextE0M.AssertModel(secondItems2[14],_testData[34], false);
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
FROM dbo.stringtexte0m m
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
FROM dbo.stringtexte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatStringtextE0M>();
                var firstItems2 = new List<FlatStringtextE0M>();
                var secondItems1 = new List<FlatStringtextE0M>();
                await ((IStringSingleTypetext)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 132, query1, 109, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatStringtextE0M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatStringtextE0M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatStringtextE0M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatStringtextE0M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatStringtextE0M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatStringtextE0M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatStringtextE0M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatStringtextE0M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatStringtextE0M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatStringtextE0M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatStringtextE0M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatStringtextE0M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatStringtextE0M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatStringtextE0M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatStringtextE0M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatStringtextE0M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatStringtextE0M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatStringtextE0M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatStringtextE0M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatStringtextE0M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatStringtextE0M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatStringtextE0M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatStringtextE0M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatStringtextE0M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatStringtextE0M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatStringtextE0M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatStringtextE0M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatStringtextE0M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatStringtextE0M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatStringtextE0M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatStringtextE0M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatStringtextE0M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatStringtextE0M.AssertModel(secondItems1[12],_testData[34], false);
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
FROM dbo.stringtexte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatStringtextE0M>();
                var models2 = new List<FlatStringtextE0M>();
                ((IStringSingleTypetext)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatStringtextE0M.AssertModel(models1[i],_testData[i], false);
                    FlatStringtextE0M.AssertModel(models2[i],_testData[i], false);
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
FROM dbo.stringtexte0m m
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
FROM dbo.stringtexte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatStringtextE0M>();
                var firstItems2 = new List<FlatStringtextE0M>();
                var secondItems1 = new List<FlatStringtextE0M>();
                var secondItems2 = new List<FlatStringtextE0M>();
                 ((IStringSingleTypetext)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 43, query1, 64, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatStringtextE0M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatStringtextE0M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatStringtextE0M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatStringtextE0M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatStringtextE0M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatStringtextE0M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatStringtextE0M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatStringtextE0M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatStringtextE0M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatStringtextE0M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatStringtextE0M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatStringtextE0M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatStringtextE0M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatStringtextE0M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatStringtextE0M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatStringtextE0M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatStringtextE0M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatStringtextE0M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatStringtextE0M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatStringtextE0M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatStringtextE0M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatStringtextE0M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatStringtextE0M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatStringtextE0M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatStringtextE0M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatStringtextE0M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatStringtextE0M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatStringtextE0M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatStringtextE0M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatStringtextE0M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatStringtextE0M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatStringtextE0M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatStringtextE0M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatStringtextE0M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatStringtextE0M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatStringtextE0M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatStringtextE0M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatStringtextE0M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatStringtextE0M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatStringtextE0M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatStringtextE0M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatStringtextE0M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatStringtextE0M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatStringtextE0M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatStringtextE0M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatStringtextE0M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatStringtextE0M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatStringtextE0M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatStringtextE0M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatStringtextE0M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatStringtextE0M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatStringtextE0M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatStringtextE0M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatStringtextE0M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatStringtextE0M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatStringtextE0M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatStringtextE0M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatStringtextE0M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatStringtextE0M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatStringtextE0M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatStringtextE0M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatStringtextE0M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatStringtextE0M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatStringtextE0M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatStringtextE0M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatStringtextE0M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatStringtextE0M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatStringtextE0M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatStringtextE0M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatStringtextE0M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatStringtextE0M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatStringtextE0M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatStringtextE0M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatStringtextE0M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatStringtextE0M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatStringtextE0M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatStringtextE0M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatStringtextE0M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatStringtextE0M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatStringtextE0M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatStringtextE0M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatStringtextE0M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatStringtextE0M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatStringtextE0M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatStringtextE0M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatStringtextE0M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatStringtextE0M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatStringtextE0M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatStringtextE0M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatStringtextE0M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatStringtextE0M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatStringtextE0M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatStringtextE0M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatStringtextE0M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatStringtextE0M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatStringtextE0M.AssertModel(secondItems2[21],_testData[34], false);
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
FROM dbo.stringtexte0m m
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
FROM dbo.stringtexte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatStringtextE0M>();
                var firstItems2 = new List<FlatStringtextE0M>();
                var secondItems1 = new List<FlatStringtextE0M>();
                 ((IStringSingleTypetext)this).DbConnectionMMDynQuerySelectModelBatch(connection, 73, query1, 172, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatStringtextE0M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatStringtextE0M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatStringtextE0M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatStringtextE0M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatStringtextE0M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatStringtextE0M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatStringtextE0M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatStringtextE0M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatStringtextE0M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatStringtextE0M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatStringtextE0M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatStringtextE0M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatStringtextE0M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatStringtextE0M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatStringtextE0M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatStringtextE0M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatStringtextE0M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatStringtextE0M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatStringtextE0M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatStringtextE0M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatStringtextE0M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatStringtextE0M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatStringtextE0M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatStringtextE0M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatStringtextE0M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatStringtextE0M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatStringtextE0M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatStringtextE0M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatStringtextE0M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatStringtextE0M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatStringtextE0M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatStringtextE0M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatStringtextE0M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatStringtextE0M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatStringtextE0M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatStringtextE0M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatStringtextE0M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatStringtextE0M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatStringtextE0M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatStringtextE0M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatStringtextE0M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatStringtextE0M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatStringtextE0M.AssertModel(secondItems1[2],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatStringtextE0M)],
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
FROM dbo.stringtexte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IStringSingleTypetext)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatStringtextE0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.stringtexte0m m
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
FROM dbo.stringtexte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IStringSingleTypetext)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 141, query1, 123, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatStringtextE0M.AssertModel(models[0],_testData[26], false);
                        FlatStringtextE0M.AssertModel(models[1],_testData[27], false);
                        FlatStringtextE0M.AssertModel(models[2],_testData[28], false);
                        FlatStringtextE0M.AssertModel(models[3],_testData[29], false);
                        FlatStringtextE0M.AssertModel(models[4],_testData[30], false);
                        FlatStringtextE0M.AssertModel(models[5],_testData[31], false);
                        FlatStringtextE0M.AssertModel(models[6],_testData[32], false);
                        FlatStringtextE0M.AssertModel(models[7],_testData[33], false);
                        FlatStringtextE0M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatStringtextE0M.AssertModel(models[0],_testData[24], false);
                        FlatStringtextE0M.AssertModel(models[1],_testData[25], false);
                        FlatStringtextE0M.AssertModel(models[2],_testData[26], false);
                        FlatStringtextE0M.AssertModel(models[3],_testData[27], false);
                        FlatStringtextE0M.AssertModel(models[4],_testData[28], false);
                        FlatStringtextE0M.AssertModel(models[5],_testData[29], false);
                        FlatStringtextE0M.AssertModel(models[6],_testData[30], false);
                        FlatStringtextE0M.AssertModel(models[7],_testData[31], false);
                        FlatStringtextE0M.AssertModel(models[8],_testData[32], false);
                        FlatStringtextE0M.AssertModel(models[9],_testData[33], false);
                        FlatStringtextE0M.AssertModel(models[10],_testData[34], false);
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
FROM dbo.stringtexte0m m
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
FROM dbo.stringtexte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatStringtextE0M>();
                var secondItems1 = new List<FlatStringtextE0M>();
                var secondItems2 = new List<FlatStringtextE0M>();
                await ((IStringSingleTypetext)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 172, query1, 109, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatStringtextE0M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatStringtextE0M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatStringtextE0M.AssertModel(firstItems1[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatStringtextE0M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatStringtextE0M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatStringtextE0M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatStringtextE0M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatStringtextE0M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatStringtextE0M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatStringtextE0M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatStringtextE0M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatStringtextE0M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatStringtextE0M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatStringtextE0M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatStringtextE0M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatStringtextE0M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatStringtextE0M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatStringtextE0M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatStringtextE0M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatStringtextE0M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatStringtextE0M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatStringtextE0M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatStringtextE0M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatStringtextE0M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatStringtextE0M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatStringtextE0M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatStringtextE0M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatStringtextE0M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatStringtextE0M.AssertModel(secondItems2[12],_testData[34], false);
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
FROM dbo.stringtexte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IStringSingleTypetext)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatStringtextE0M.AssertModel(models[i],_testData[i], false);
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
FROM dbo.stringtexte0m m
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
FROM dbo.stringtexte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IStringSingleTypetext)this).DbConnectionSTDynQuerySelectModelBatch(connection, 18, query1, 172, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatStringtextE0M.AssertModel(models[0],_testData[4], false);
                        FlatStringtextE0M.AssertModel(models[1],_testData[5], false);
                        FlatStringtextE0M.AssertModel(models[2],_testData[6], false);
                        FlatStringtextE0M.AssertModel(models[3],_testData[7], false);
                        FlatStringtextE0M.AssertModel(models[4],_testData[8], false);
                        FlatStringtextE0M.AssertModel(models[5],_testData[9], false);
                        FlatStringtextE0M.AssertModel(models[6],_testData[10], false);
                        FlatStringtextE0M.AssertModel(models[7],_testData[11], false);
                        FlatStringtextE0M.AssertModel(models[8],_testData[12], false);
                        FlatStringtextE0M.AssertModel(models[9],_testData[13], false);
                        FlatStringtextE0M.AssertModel(models[10],_testData[14], false);
                        FlatStringtextE0M.AssertModel(models[11],_testData[15], false);
                        FlatStringtextE0M.AssertModel(models[12],_testData[16], false);
                        FlatStringtextE0M.AssertModel(models[13],_testData[17], false);
                        FlatStringtextE0M.AssertModel(models[14],_testData[18], false);
                        FlatStringtextE0M.AssertModel(models[15],_testData[19], false);
                        FlatStringtextE0M.AssertModel(models[16],_testData[20], false);
                        FlatStringtextE0M.AssertModel(models[17],_testData[21], false);
                        FlatStringtextE0M.AssertModel(models[18],_testData[22], false);
                        FlatStringtextE0M.AssertModel(models[19],_testData[23], false);
                        FlatStringtextE0M.AssertModel(models[20],_testData[24], false);
                        FlatStringtextE0M.AssertModel(models[21],_testData[25], false);
                        FlatStringtextE0M.AssertModel(models[22],_testData[26], false);
                        FlatStringtextE0M.AssertModel(models[23],_testData[27], false);
                        FlatStringtextE0M.AssertModel(models[24],_testData[28], false);
                        FlatStringtextE0M.AssertModel(models[25],_testData[29], false);
                        FlatStringtextE0M.AssertModel(models[26],_testData[30], false);
                        FlatStringtextE0M.AssertModel(models[27],_testData[31], false);
                        FlatStringtextE0M.AssertModel(models[28],_testData[32], false);
                        FlatStringtextE0M.AssertModel(models[29],_testData[33], false);
                        FlatStringtextE0M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatStringtextE0M.AssertModel(models[0],_testData[32], false);
                        FlatStringtextE0M.AssertModel(models[1],_testData[33], false);
                        FlatStringtextE0M.AssertModel(models[2],_testData[34], false);
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
FROM dbo.stringtexte0m m
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
FROM dbo.stringtexte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatStringtextE0M>();
                var secondItems1 = new List<FlatStringtextE0M>();
                var secondItems2 = new List<FlatStringtextE0M>();
                 ((IStringSingleTypetext)this).DbConnectionDynQuerySelectModelBatch(connection, 99, query1, 151, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatStringtextE0M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatStringtextE0M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatStringtextE0M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatStringtextE0M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatStringtextE0M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatStringtextE0M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatStringtextE0M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatStringtextE0M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatStringtextE0M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatStringtextE0M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatStringtextE0M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatStringtextE0M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatStringtextE0M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatStringtextE0M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatStringtextE0M.AssertModel(firstItems1[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatStringtextE0M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatStringtextE0M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatStringtextE0M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatStringtextE0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatStringtextE0M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatStringtextE0M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatStringtextE0M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatStringtextE0M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatStringtextE0M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatStringtextE0M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatStringtextE0M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatStringtextE0M.AssertModel(secondItems2[5],_testData[34], false);
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
FROM dbo.stringtexte0m m
LEFT JOIN dbo.stringtexte0mi mi ON mi.id = m.stringtexte0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(StringtextE0M)],
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    StringtextE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IStringSingleTypetext)this).DbConnectionSTSelectModelBatchAsync(connection, 172, 141))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        StringtextE0M.AssertModel(models[0],_testData[32], false);
                        StringtextE0M.AssertModel(models[1],_testData[33], false);
                        StringtextE0M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        StringtextE0M.AssertModel(models[0],_testData[26], false);
                        StringtextE0M.AssertModel(models[1],_testData[27], false);
                        StringtextE0M.AssertModel(models[2],_testData[28], false);
                        StringtextE0M.AssertModel(models[3],_testData[29], false);
                        StringtextE0M.AssertModel(models[4],_testData[30], false);
                        StringtextE0M.AssertModel(models[5],_testData[31], false);
                        StringtextE0M.AssertModel(models[6],_testData[32], false);
                        StringtextE0M.AssertModel(models[7],_testData[33], false);
                        StringtextE0M.AssertModel(models[8],_testData[34], false);
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
                    StringtextE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IStringSingleTypetext)this).DbConnectionSTSelectModelBatch(connection, 123, 167))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        StringtextE0M.AssertModel(models[0],_testData[24], false);
                        StringtextE0M.AssertModel(models[1],_testData[25], false);
                        StringtextE0M.AssertModel(models[2],_testData[26], false);
                        StringtextE0M.AssertModel(models[3],_testData[27], false);
                        StringtextE0M.AssertModel(models[4],_testData[28], false);
                        StringtextE0M.AssertModel(models[5],_testData[29], false);
                        StringtextE0M.AssertModel(models[6],_testData[30], false);
                        StringtextE0M.AssertModel(models[7],_testData[31], false);
                        StringtextE0M.AssertModel(models[8],_testData[32], false);
                        StringtextE0M.AssertModel(models[9],_testData[33], false);
                        StringtextE0M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        StringtextE0M.AssertModel(models[0],_testData[31], false);
                        StringtextE0M.AssertModel(models[1],_testData[32], false);
                        StringtextE0M.AssertModel(models[2],_testData[33], false);
                        StringtextE0M.AssertModel(models[3],_testData[34], false);
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
                ((IStringSingleTypetext)this).SetDbConnectionSelectModelParametrs(cmd, 103);
                var models = await ((IStringSingleTypetext)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(14));

                StringtextE0M.AssertModel(models[0],_testData[21], false);
                StringtextE0M.AssertModel(models[1],_testData[22], false);
                StringtextE0M.AssertModel(models[2],_testData[23], false);
                StringtextE0M.AssertModel(models[3],_testData[24], false);
                StringtextE0M.AssertModel(models[4],_testData[25], false);
                StringtextE0M.AssertModel(models[5],_testData[26], false);
                StringtextE0M.AssertModel(models[6],_testData[27], false);
                StringtextE0M.AssertModel(models[7],_testData[28], false);
                StringtextE0M.AssertModel(models[8],_testData[29], false);
                StringtextE0M.AssertModel(models[9],_testData[30], false);
                StringtextE0M.AssertModel(models[10],_testData[31], false);
                StringtextE0M.AssertModel(models[11],_testData[32], false);
                StringtextE0M.AssertModel(models[12],_testData[33], false);
                StringtextE0M.AssertModel(models[13],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IStringSingleTypetext)this).CreateDbConnectionSelectModelCommand(connection);
                ((IStringSingleTypetext)this).SetDbConnectionSelectModelParametrs(cmd, 109);
                var models =  ((IStringSingleTypetext)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(13));

                StringtextE0M.AssertModel(models[0],_testData[22], false);
                StringtextE0M.AssertModel(models[1],_testData[23], false);
                StringtextE0M.AssertModel(models[2],_testData[24], false);
                StringtextE0M.AssertModel(models[3],_testData[25], false);
                StringtextE0M.AssertModel(models[4],_testData[26], false);
                StringtextE0M.AssertModel(models[5],_testData[27], false);
                StringtextE0M.AssertModel(models[6],_testData[28], false);
                StringtextE0M.AssertModel(models[7],_testData[29], false);
                StringtextE0M.AssertModel(models[8],_testData[30], false);
                StringtextE0M.AssertModel(models[9],_testData[31], false);
                StringtextE0M.AssertModel(models[10],_testData[32], false);
                StringtextE0M.AssertModel(models[11],_testData[33], false);
                StringtextE0M.AssertModel(models[12],_testData[34], false);
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
FROM dbo.stringtexte0m m
LEFT JOIN dbo.stringtexte0mi mi ON mi.id = m.stringtexte0mi_id
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
                Assert.That((System.String)model[1], Is.EqualTo(("fwjvxslqvegiamxmicyhdfynamr")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((11)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("nfqaxuvbkgappmagbbxr")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("noosurdyxsicfteojyhcrhiunju")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("ylqkhrqtmvlflinliuhlvaubtjsg")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("frb")));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("okytvdbptbhmfgy")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("pffeaanypxaofrahxko")));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("cl")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("fyipfequrct")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("luiyrfgtcngp")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("bnqxxqrccdakgpw")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("nvgybtglga")));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("hpriarw")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("tk")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("oyvyrcxxvynymphnlqxfjh")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("qhbplgicadkredqkvbkierc")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("yjxmauwavffajtifqvd")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("sufbnkcibfwonstlpo")));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("xqaipshfl")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("fanuujvdfgpwhokjshklsorfxby")));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("djasmritaaxsdehi")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("hvtwhavtyvfgxcnxyr")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("cklmwaggmrwttusmummyvddc")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("rerljrrsfhigeajbtris")));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("mtqcadposscqkfeofyleiame")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("uitadnbqxajkyjkhcafmvfdfxhfq")));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("ixfcplajky")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("ahuxnodqoviuri")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("mpcythhekgbirmxi")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("qskufhimgnado")));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("krdonagarjengoynyumdgkbj")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("qglsvomfjrdlkhkoyupotmtmp")));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("yyabounatalcmhoghxlrgvb")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("ucimohxdmibbubdsk")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("gtpvmfscwddvldedvoymefvrwtxg")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("ytxidpvfestjiybpmvkgae")));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("dnbopraodotuacsbildutrbqaafi")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("oqyjwtxrlpbofky")));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("jwjxpolavwqamwpgc")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("iayo")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("lcmaebtnujnqvnjyexkmb")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("oxtlsgemal")));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((83)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("kcmhsfgbwgecwwristknyojarmwp")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("fhofbxxluqwphjidqbchtudhxft")));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("iuxpohuqfpvmlvnptoqtr")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("ary")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("mjatrctxggxr")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("ydm")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("oiihcpuqhnonnkb")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("iggnuqh")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("mmxbgkbutchovltvvatoqiyhh")));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("vw")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("vbqioqpcw")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("smoirvvvelchrubjjyckaihymuh")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("wamddlg")));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("qwikwmjsjt")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("hmempnoalpkne")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((56)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("kvmieggsfxeycqusommg")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("dcxgqrsqc")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("hjhkalqiphprjsxibvyvtt")));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("byirnknqfsd")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("wquilcqgq")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((142)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("q")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("kvdfjqpcottaqdh")));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("sltxkfpgtlf")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((68)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("qbiklduylcojrgfkwyrye")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("ioyjkpwygefhacnxlfnovjfbfl")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("hggwqscjnhyq")));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((160)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("xrilavlbuvivssdgnmcogd")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("tvkav")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("bf")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((167)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("tx")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("nv")));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((172)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("wlikmogrhpfveqcce")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((78)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("bvbqrpejabklk")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("r")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((181)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("valioqbgarsk")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((182)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("efyppaxptmaujbbjcoibemgkd")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((85)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("ipkywyqxphxpvllmbbmdnndy")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("nvcyqrnqpnihaqupuhypew")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((185)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("lh")));//Value

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
                Assert.That((System.String)model[1], Is.EqualTo(("fwjvxslqvegiamxmicyhdfynamr")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((11)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("nfqaxuvbkgappmagbbxr")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("noosurdyxsicfteojyhcrhiunju")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("ylqkhrqtmvlflinliuhlvaubtjsg")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("frb")));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("okytvdbptbhmfgy")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("pffeaanypxaofrahxko")));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("cl")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("fyipfequrct")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("luiyrfgtcngp")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("bnqxxqrccdakgpw")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("nvgybtglga")));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("hpriarw")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("tk")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("oyvyrcxxvynymphnlqxfjh")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("qhbplgicadkredqkvbkierc")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("yjxmauwavffajtifqvd")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("sufbnkcibfwonstlpo")));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("xqaipshfl")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("fanuujvdfgpwhokjshklsorfxby")));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("djasmritaaxsdehi")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("hvtwhavtyvfgxcnxyr")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("cklmwaggmrwttusmummyvddc")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("rerljrrsfhigeajbtris")));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("mtqcadposscqkfeofyleiame")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("uitadnbqxajkyjkhcafmvfdfxhfq")));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("ixfcplajky")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("ahuxnodqoviuri")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("mpcythhekgbirmxi")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("qskufhimgnado")));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("krdonagarjengoynyumdgkbj")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("qglsvomfjrdlkhkoyupotmtmp")));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("yyabounatalcmhoghxlrgvb")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("ucimohxdmibbubdsk")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("gtpvmfscwddvldedvoymefvrwtxg")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("ytxidpvfestjiybpmvkgae")));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("dnbopraodotuacsbildutrbqaafi")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("oqyjwtxrlpbofky")));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("jwjxpolavwqamwpgc")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("iayo")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("lcmaebtnujnqvnjyexkmb")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("oxtlsgemal")));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((83)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("kcmhsfgbwgecwwristknyojarmwp")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("fhofbxxluqwphjidqbchtudhxft")));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("iuxpohuqfpvmlvnptoqtr")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("ary")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("mjatrctxggxr")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("ydm")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("oiihcpuqhnonnkb")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("iggnuqh")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("mmxbgkbutchovltvvatoqiyhh")));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("vw")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("vbqioqpcw")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("smoirvvvelchrubjjyckaihymuh")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("wamddlg")));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("qwikwmjsjt")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("hmempnoalpkne")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((56)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("kvmieggsfxeycqusommg")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("dcxgqrsqc")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("hjhkalqiphprjsxibvyvtt")));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("byirnknqfsd")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("wquilcqgq")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((142)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("q")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("kvdfjqpcottaqdh")));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("sltxkfpgtlf")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((68)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("qbiklduylcojrgfkwyrye")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("ioyjkpwygefhacnxlfnovjfbfl")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("hggwqscjnhyq")));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((160)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("xrilavlbuvivssdgnmcogd")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("tvkav")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("bf")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((167)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("tx")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("nv")));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((172)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("wlikmogrhpfveqcce")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((78)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("bvbqrpejabklk")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("r")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((181)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("valioqbgarsk")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((182)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("efyppaxptmaujbbjcoibemgkd")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((85)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("ipkywyqxphxpvllmbbmdnndy")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("nvcyqrnqpnihaqupuhypew")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((185)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("lh")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

#endregion

    }
}

