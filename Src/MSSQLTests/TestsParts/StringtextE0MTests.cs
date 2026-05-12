

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
    Id = 2,
    Value = "ufxnmpjkguopchfrnoprcj",
    ModelInner = null,
    NullableValue = "fwcgvycwwmfdwoswjermunenhsbha",
},
            new StringtextE0M
{
    Id = 3,
    Value = "dsvtvaychpi",
    ModelInner = new StringtextE0MI
{
    Id = 9,
    Value = "gnxj",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringtextE0M
{
    Id = 7,
    Value = "wfjspcljttxpwdffltaopafidvub",
    ModelInner = null,
    NullableValue = null,
},
            new StringtextE0M
{
    Id = 9,
    Value = "jxjcontcinlnkd",
    ModelInner = new StringtextE0MI
{
    Id = 10,
    Value = "",
    NullableValue = "eavlycecaqymv",
},
    NullableValue = null,
},
            new StringtextE0M
{
    Id = 14,
    Value = "rgskxrlsymnuhdnulibfbxan",
    ModelInner = null,
    NullableValue = null,
},
            new StringtextE0M
{
    Id = 17,
    Value = "enqyrvivg",
    ModelInner = new StringtextE0MI
{
    Id = 18,
    Value = "bthmkawqwxtbetpibuef",
    NullableValue = "tfuurntrymbxjjsegqnycftisir",
},
    NullableValue = "gsrdynopemvcldacenbysbbhm",
},
            new StringtextE0M
{
    Id = 26,
    Value = "nfgyesttjwr",
    ModelInner = null,
    NullableValue = "osjxfkuntagpnrbeecxwdnt",
},
            new StringtextE0M
{
    Id = 29,
    Value = "",
    ModelInner = new StringtextE0MI
{
    Id = 25,
    Value = "gbrtafloydlcrmjodbkflish",
    NullableValue = null,
},
    NullableValue = "jesvlywfgeiqcbimk",
},
            new StringtextE0M
{
    Id = 35,
    Value = "jeyqkafhflfrdauwqxcaotmpdvf",
    ModelInner = null,
    NullableValue = null,
},
            new StringtextE0M
{
    Id = 38,
    Value = "yd",
    ModelInner = new StringtextE0MI
{
    Id = 27,
    Value = "hqnpdfowrhlnyuwbykwcvjxmduwfi",
    NullableValue = null,
},
    NullableValue = "stoddxwtytjxx",
},
            new StringtextE0M
{
    Id = 40,
    Value = "uptmxni",
    ModelInner = null,
    NullableValue = null,
},
            new StringtextE0M
{
    Id = 43,
    Value = "wlqggyybbvto",
    ModelInner = new StringtextE0MI
{
    Id = 34,
    Value = "sbadtuneuucuhcu",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringtextE0M
{
    Id = 44,
    Value = "glxmoljcmmxxebqyp",
    ModelInner = null,
    NullableValue = null,
},
            new StringtextE0M
{
    Id = 45,
    Value = "mqkgkjkx",
    ModelInner = new StringtextE0MI
{
    Id = 36,
    Value = "okkrtelp",
    NullableValue = "cr",
},
    NullableValue = "dadrxvbrsjygtp",
},
            new StringtextE0M
{
    Id = 52,
    Value = "bblplrjtbketqhdfrvcipcqsmxlxp",
    ModelInner = null,
    NullableValue = "uhneimydtaqychi",
},
            new StringtextE0M
{
    Id = 54,
    Value = "xjaxinspdqwfbdneubruoabvymhgl",
    ModelInner = new StringtextE0MI
{
    Id = 43,
    Value = "bnyriguaagtrojrvllwiaavkjw",
    NullableValue = "hxgiribixkycgyabkhakysolmeg",
},
    NullableValue = "grsq",
},
            new StringtextE0M
{
    Id = 62,
    Value = "lmfusifqyy",
    ModelInner = null,
    NullableValue = "lhhggirqutlpswjpxvtofmcalsa",
},
            new StringtextE0M
{
    Id = 68,
    Value = "",
    ModelInner = new StringtextE0MI
{
    Id = 49,
    Value = "td",
    NullableValue = null,
},
    NullableValue = "mpbrghodrxkbrlo",
},
            new StringtextE0M
{
    Id = 72,
    Value = "",
    ModelInner = null,
    NullableValue = "fhrvgkohlolnbju",
},
            new StringtextE0M
{
    Id = 77,
    Value = "",
    ModelInner = new StringtextE0MI
{
    Id = 55,
    Value = "ythulfvkxudlxoybvjpba",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringtextE0M
{
    Id = 84,
    Value = "vdaynrdmjlqwmtrpemearuekpwji",
    ModelInner = null,
    NullableValue = null,
},
            new StringtextE0M
{
    Id = 92,
    Value = "nxcjjnpeoxslneqtyxhwyhlpdl",
    ModelInner = new StringtextE0MI
{
    Id = 58,
    Value = "uoppruxplaljnjuuhdtsbagmmytpp",
    NullableValue = "yjkdlni",
},
    NullableValue = "hgypjsxdrpcelvlyk",
},
            new StringtextE0M
{
    Id = 97,
    Value = "avlwcbr",
    ModelInner = null,
    NullableValue = "jgirhmwsbxnsmfgglj",
},
            new StringtextE0M
{
    Id = 104,
    Value = "phhaxtqxihybbfvvmvxec",
    ModelInner = new StringtextE0MI
{
    Id = 64,
    Value = "lbgxytynxmvfpo",
    NullableValue = "",
},
    NullableValue = "djtlfqs",
},
            new StringtextE0M
{
    Id = 105,
    Value = "tgvxkjwrowejlmotto",
    ModelInner = null,
    NullableValue = "xjpxjkwysjamybiisvwaqc",
},
            new StringtextE0M
{
    Id = 114,
    Value = "rphqxrkgcokgruym",
    ModelInner = new StringtextE0MI
{
    Id = 65,
    Value = "adcbmccjogmocinpnltyc",
    NullableValue = "sxuldtbcghtdnh",
},
    NullableValue = "hovyqdfltrmyuv",
},
            new StringtextE0M
{
    Id = 118,
    Value = "dkocydtvbxhidpnbcmihuq",
    ModelInner = null,
    NullableValue = null,
},
            new StringtextE0M
{
    Id = 125,
    Value = "hlwqyocivarmtlplefwxahytwxen",
    ModelInner = new StringtextE0MI
{
    Id = 74,
    Value = "yfqgfryrtubaligihffvwx",
    NullableValue = null,
},
    NullableValue = "nxplbdoudnansqapjjh",
},
            new StringtextE0M
{
    Id = 128,
    Value = "amvtrqyebolv",
    ModelInner = null,
    NullableValue = "cifnk",
},
            new StringtextE0M
{
    Id = 136,
    Value = "rbicstjovlxgh",
    ModelInner = new StringtextE0MI
{
    Id = 78,
    Value = "nnjh",
    NullableValue = null,
},
    NullableValue = "ikmfxcyjy",
},
            new StringtextE0M
{
    Id = 139,
    Value = "u",
    ModelInner = null,
    NullableValue = "mfg",
},
            new StringtextE0M
{
    Id = 144,
    Value = "wewrccvhmacrthkv",
    ModelInner = new StringtextE0MI
{
    Id = 84,
    Value = "cbuehfnnmnxpoibvcxwhn",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringtextE0M
{
    Id = 151,
    Value = "sxcl",
    ModelInner = null,
    NullableValue = null,
},
            new StringtextE0M
{
    Id = 160,
    Value = "phoipriuftrlwmmqovrketvuagip",
    ModelInner = new StringtextE0MI
{
    Id = 87,
    Value = "goevsmjnrtsxfbpyfyamaidhljrln",
    NullableValue = null,
},
    NullableValue = "yrknqpsn",
},
            new StringtextE0M
{
    Id = 168,
    Value = "ukyntcukblsjmycnhk",
    ModelInner = null,
    NullableValue = "slhkcjqarkolot",
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
                parametr1.Value = 97;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 40;
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
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatStringtextE0M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatStringtextE0M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatStringtextE0M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatStringtextE0M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatStringtextE0M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatStringtextE0M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatStringtextE0M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatStringtextE0M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatStringtextE0M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatStringtextE0M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatStringtextE0M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatStringtextE0M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatStringtextE0M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatStringtextE0M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatStringtextE0M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatStringtextE0M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatStringtextE0M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatStringtextE0M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatStringtextE0M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatStringtextE0M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatStringtextE0M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatStringtextE0M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatStringtextE0M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatStringtextE0M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatStringtextE0M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatStringtextE0M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatStringtextE0M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatStringtextE0M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatStringtextE0M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatStringtextE0M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatStringtextE0M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatStringtextE0M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatStringtextE0M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatStringtextE0M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatStringtextE0M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatStringtextE0M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatStringtextE0M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatStringtextE0M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatStringtextE0M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatStringtextE0M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatStringtextE0M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatStringtextE0M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatStringtextE0M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatStringtextE0M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatStringtextE0M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatStringtextE0M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatStringtextE0M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatStringtextE0M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatStringtextE0M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatStringtextE0M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatStringtextE0M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatStringtextE0M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatStringtextE0M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatStringtextE0M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatStringtextE0M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatStringtextE0M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatStringtextE0M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatStringtextE0M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatStringtextE0M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatStringtextE0M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatStringtextE0M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatStringtextE0M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatStringtextE0M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatStringtextE0M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatStringtextE0M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatStringtextE0M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatStringtextE0M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatStringtextE0M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatStringtextE0M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatStringtextE0M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatStringtextE0M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatStringtextE0M.AssertModel(secondItems2[23],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 77;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 40;
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
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatStringtextE0M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatStringtextE0M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatStringtextE0M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatStringtextE0M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatStringtextE0M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatStringtextE0M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatStringtextE0M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatStringtextE0M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatStringtextE0M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatStringtextE0M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatStringtextE0M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatStringtextE0M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatStringtextE0M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatStringtextE0M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatStringtextE0M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatStringtextE0M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatStringtextE0M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatStringtextE0M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatStringtextE0M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatStringtextE0M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatStringtextE0M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatStringtextE0M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatStringtextE0M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatStringtextE0M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatStringtextE0M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatStringtextE0M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatStringtextE0M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatStringtextE0M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatStringtextE0M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatStringtextE0M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatStringtextE0M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatStringtextE0M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatStringtextE0M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatStringtextE0M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatStringtextE0M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatStringtextE0M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatStringtextE0M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatStringtextE0M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatStringtextE0M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatStringtextE0M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatStringtextE0M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatStringtextE0M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatStringtextE0M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatStringtextE0M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatStringtextE0M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatStringtextE0M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatStringtextE0M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatStringtextE0M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatStringtextE0M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatStringtextE0M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatStringtextE0M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatStringtextE0M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatStringtextE0M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatStringtextE0M.AssertModel(secondItems1[23],_testData[34], false);
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
                parametr1.Value = 7;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 105;
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
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatStringtextE0M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatStringtextE0M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatStringtextE0M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatStringtextE0M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatStringtextE0M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatStringtextE0M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatStringtextE0M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatStringtextE0M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatStringtextE0M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatStringtextE0M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatStringtextE0M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatStringtextE0M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatStringtextE0M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatStringtextE0M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatStringtextE0M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatStringtextE0M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatStringtextE0M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatStringtextE0M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatStringtextE0M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatStringtextE0M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatStringtextE0M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatStringtextE0M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatStringtextE0M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatStringtextE0M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatStringtextE0M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatStringtextE0M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatStringtextE0M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatStringtextE0M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatStringtextE0M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatStringtextE0M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatStringtextE0M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatStringtextE0M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatStringtextE0M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatStringtextE0M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatStringtextE0M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatStringtextE0M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatStringtextE0M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatStringtextE0M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatStringtextE0M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatStringtextE0M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatStringtextE0M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatStringtextE0M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatStringtextE0M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatStringtextE0M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatStringtextE0M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatStringtextE0M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatStringtextE0M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatStringtextE0M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatStringtextE0M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatStringtextE0M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatStringtextE0M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatStringtextE0M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatStringtextE0M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatStringtextE0M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatStringtextE0M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatStringtextE0M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatStringtextE0M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatStringtextE0M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatStringtextE0M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatStringtextE0M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatStringtextE0M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatStringtextE0M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatStringtextE0M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatStringtextE0M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatStringtextE0M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatStringtextE0M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatStringtextE0M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatStringtextE0M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatStringtextE0M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatStringtextE0M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatStringtextE0M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatStringtextE0M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatStringtextE0M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatStringtextE0M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatStringtextE0M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatStringtextE0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatStringtextE0M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatStringtextE0M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatStringtextE0M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatStringtextE0M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatStringtextE0M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatStringtextE0M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatStringtextE0M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatStringtextE0M.AssertModel(secondItems2[9],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 62;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 43;
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
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatStringtextE0M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatStringtextE0M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatStringtextE0M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatStringtextE0M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatStringtextE0M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatStringtextE0M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatStringtextE0M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatStringtextE0M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatStringtextE0M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatStringtextE0M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatStringtextE0M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatStringtextE0M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatStringtextE0M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatStringtextE0M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatStringtextE0M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatStringtextE0M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatStringtextE0M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatStringtextE0M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatStringtextE0M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatStringtextE0M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatStringtextE0M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatStringtextE0M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatStringtextE0M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatStringtextE0M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatStringtextE0M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatStringtextE0M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatStringtextE0M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatStringtextE0M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatStringtextE0M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatStringtextE0M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatStringtextE0M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatStringtextE0M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatStringtextE0M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatStringtextE0M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatStringtextE0M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatStringtextE0M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatStringtextE0M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatStringtextE0M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatStringtextE0M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatStringtextE0M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatStringtextE0M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatStringtextE0M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatStringtextE0M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatStringtextE0M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatStringtextE0M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatStringtextE0M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatStringtextE0M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatStringtextE0M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatStringtextE0M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatStringtextE0M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatStringtextE0M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatStringtextE0M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatStringtextE0M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatStringtextE0M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatStringtextE0M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatStringtextE0M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatStringtextE0M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatStringtextE0M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatStringtextE0M.AssertModel(secondItems1[22],_testData[34], false);
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
                parametr1.Value = 139;
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
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatStringtextE0M.AssertModel(models[0],_testData[31], false);
                        FlatStringtextE0M.AssertModel(models[1],_testData[32], false);
                        FlatStringtextE0M.AssertModel(models[2],_testData[33], false);
                        FlatStringtextE0M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatStringtextE0M.AssertModel(models[0],_testData[10], false);
                        FlatStringtextE0M.AssertModel(models[1],_testData[11], false);
                        FlatStringtextE0M.AssertModel(models[2],_testData[12], false);
                        FlatStringtextE0M.AssertModel(models[3],_testData[13], false);
                        FlatStringtextE0M.AssertModel(models[4],_testData[14], false);
                        FlatStringtextE0M.AssertModel(models[5],_testData[15], false);
                        FlatStringtextE0M.AssertModel(models[6],_testData[16], false);
                        FlatStringtextE0M.AssertModel(models[7],_testData[17], false);
                        FlatStringtextE0M.AssertModel(models[8],_testData[18], false);
                        FlatStringtextE0M.AssertModel(models[9],_testData[19], false);
                        FlatStringtextE0M.AssertModel(models[10],_testData[20], false);
                        FlatStringtextE0M.AssertModel(models[11],_testData[21], false);
                        FlatStringtextE0M.AssertModel(models[12],_testData[22], false);
                        FlatStringtextE0M.AssertModel(models[13],_testData[23], false);
                        FlatStringtextE0M.AssertModel(models[14],_testData[24], false);
                        FlatStringtextE0M.AssertModel(models[15],_testData[25], false);
                        FlatStringtextE0M.AssertModel(models[16],_testData[26], false);
                        FlatStringtextE0M.AssertModel(models[17],_testData[27], false);
                        FlatStringtextE0M.AssertModel(models[18],_testData[28], false);
                        FlatStringtextE0M.AssertModel(models[19],_testData[29], false);
                        FlatStringtextE0M.AssertModel(models[20],_testData[30], false);
                        FlatStringtextE0M.AssertModel(models[21],_testData[31], false);
                        FlatStringtextE0M.AssertModel(models[22],_testData[32], false);
                        FlatStringtextE0M.AssertModel(models[23],_testData[33], false);
                        FlatStringtextE0M.AssertModel(models[24],_testData[34], false);
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
                parametr1.Value = 29;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 125;
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
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatStringtextE0M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatStringtextE0M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatStringtextE0M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatStringtextE0M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatStringtextE0M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatStringtextE0M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatStringtextE0M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatStringtextE0M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatStringtextE0M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatStringtextE0M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatStringtextE0M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatStringtextE0M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatStringtextE0M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatStringtextE0M.AssertModel(secondItems2[6],_testData[34], false);
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
                parametr1.Value = 139;
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
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatStringtextE0M.AssertModel(models[0],_testData[31], false);
                        FlatStringtextE0M.AssertModel(models[1],_testData[32], false);
                        FlatStringtextE0M.AssertModel(models[2],_testData[33], false);
                        FlatStringtextE0M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatStringtextE0M.AssertModel(models[0],_testData[18], false);
                        FlatStringtextE0M.AssertModel(models[1],_testData[19], false);
                        FlatStringtextE0M.AssertModel(models[2],_testData[20], false);
                        FlatStringtextE0M.AssertModel(models[3],_testData[21], false);
                        FlatStringtextE0M.AssertModel(models[4],_testData[22], false);
                        FlatStringtextE0M.AssertModel(models[5],_testData[23], false);
                        FlatStringtextE0M.AssertModel(models[6],_testData[24], false);
                        FlatStringtextE0M.AssertModel(models[7],_testData[25], false);
                        FlatStringtextE0M.AssertModel(models[8],_testData[26], false);
                        FlatStringtextE0M.AssertModel(models[9],_testData[27], false);
                        FlatStringtextE0M.AssertModel(models[10],_testData[28], false);
                        FlatStringtextE0M.AssertModel(models[11],_testData[29], false);
                        FlatStringtextE0M.AssertModel(models[12],_testData[30], false);
                        FlatStringtextE0M.AssertModel(models[13],_testData[31], false);
                        FlatStringtextE0M.AssertModel(models[14],_testData[32], false);
                        FlatStringtextE0M.AssertModel(models[15],_testData[33], false);
                        FlatStringtextE0M.AssertModel(models[16],_testData[34], false);
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
                parametr1.Value = 7;
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
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                        FlatStringtextE0M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatStringtextE0M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatStringtextE0M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatStringtextE0M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatStringtextE0M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatStringtextE0M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatStringtextE0M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatStringtextE0M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatStringtextE0M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatStringtextE0M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatStringtextE0M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatStringtextE0M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatStringtextE0M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatStringtextE0M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatStringtextE0M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatStringtextE0M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatStringtextE0M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatStringtextE0M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatStringtextE0M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatStringtextE0M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatStringtextE0M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatStringtextE0M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatStringtextE0M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatStringtextE0M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatStringtextE0M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatStringtextE0M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatStringtextE0M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatStringtextE0M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatStringtextE0M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatStringtextE0M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatStringtextE0M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatStringtextE0M.AssertModel(firstItems1[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatStringtextE0M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatStringtextE0M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatStringtextE0M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatStringtextE0M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatStringtextE0M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatStringtextE0M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatStringtextE0M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatStringtextE0M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatStringtextE0M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatStringtextE0M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatStringtextE0M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatStringtextE0M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatStringtextE0M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatStringtextE0M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatStringtextE0M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatStringtextE0M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatStringtextE0M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatStringtextE0M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatStringtextE0M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatStringtextE0M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatStringtextE0M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatStringtextE0M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatStringtextE0M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatStringtextE0M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatStringtextE0M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatStringtextE0M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatStringtextE0M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatStringtextE0M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatStringtextE0M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatStringtextE0M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatStringtextE0M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatStringtextE0M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatStringtextE0M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatStringtextE0M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatStringtextE0M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatStringtextE0M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatStringtextE0M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatStringtextE0M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatStringtextE0M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatStringtextE0M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatStringtextE0M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatStringtextE0M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatStringtextE0M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatStringtextE0M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatStringtextE0M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatStringtextE0M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatStringtextE0M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatStringtextE0M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatStringtextE0M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatStringtextE0M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatStringtextE0M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatStringtextE0M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatStringtextE0M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatStringtextE0M.AssertModel(secondItems2[26],_testData[34], false);
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
                parametr1.Value = 84;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 72;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IStringSingleTypetext)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        StringtextE0M.AssertModel(models[0],_testData[19], false);
                        StringtextE0M.AssertModel(models[1],_testData[20], false);
                        StringtextE0M.AssertModel(models[2],_testData[21], false);
                        StringtextE0M.AssertModel(models[3],_testData[22], false);
                        StringtextE0M.AssertModel(models[4],_testData[23], false);
                        StringtextE0M.AssertModel(models[5],_testData[24], false);
                        StringtextE0M.AssertModel(models[6],_testData[25], false);
                        StringtextE0M.AssertModel(models[7],_testData[26], false);
                        StringtextE0M.AssertModel(models[8],_testData[27], false);
                        StringtextE0M.AssertModel(models[9],_testData[28], false);
                        StringtextE0M.AssertModel(models[10],_testData[29], false);
                        StringtextE0M.AssertModel(models[11],_testData[30], false);
                        StringtextE0M.AssertModel(models[12],_testData[31], false);
                        StringtextE0M.AssertModel(models[13],_testData[32], false);
                        StringtextE0M.AssertModel(models[14],_testData[33], false);
                        StringtextE0M.AssertModel(models[15],_testData[34], false);
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
                parametr1.Value = 26;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 52;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IStringSingleTypetext)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        StringtextE0M.AssertModel(models[0],_testData[7], false);
                        StringtextE0M.AssertModel(models[1],_testData[8], false);
                        StringtextE0M.AssertModel(models[2],_testData[9], false);
                        StringtextE0M.AssertModel(models[3],_testData[10], false);
                        StringtextE0M.AssertModel(models[4],_testData[11], false);
                        StringtextE0M.AssertModel(models[5],_testData[12], false);
                        StringtextE0M.AssertModel(models[6],_testData[13], false);
                        StringtextE0M.AssertModel(models[7],_testData[14], false);
                        StringtextE0M.AssertModel(models[8],_testData[15], false);
                        StringtextE0M.AssertModel(models[9],_testData[16], false);
                        StringtextE0M.AssertModel(models[10],_testData[17], false);
                        StringtextE0M.AssertModel(models[11],_testData[18], false);
                        StringtextE0M.AssertModel(models[12],_testData[19], false);
                        StringtextE0M.AssertModel(models[13],_testData[20], false);
                        StringtextE0M.AssertModel(models[14],_testData[21], false);
                        StringtextE0M.AssertModel(models[15],_testData[22], false);
                        StringtextE0M.AssertModel(models[16],_testData[23], false);
                        StringtextE0M.AssertModel(models[17],_testData[24], false);
                        StringtextE0M.AssertModel(models[18],_testData[25], false);
                        StringtextE0M.AssertModel(models[19],_testData[26], false);
                        StringtextE0M.AssertModel(models[20],_testData[27], false);
                        StringtextE0M.AssertModel(models[21],_testData[28], false);
                        StringtextE0M.AssertModel(models[22],_testData[29], false);
                        StringtextE0M.AssertModel(models[23],_testData[30], false);
                        StringtextE0M.AssertModel(models[24],_testData[31], false);
                        StringtextE0M.AssertModel(models[25],_testData[32], false);
                        StringtextE0M.AssertModel(models[26],_testData[33], false);
                        StringtextE0M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        StringtextE0M.AssertModel(models[0],_testData[15], false);
                        StringtextE0M.AssertModel(models[1],_testData[16], false);
                        StringtextE0M.AssertModel(models[2],_testData[17], false);
                        StringtextE0M.AssertModel(models[3],_testData[18], false);
                        StringtextE0M.AssertModel(models[4],_testData[19], false);
                        StringtextE0M.AssertModel(models[5],_testData[20], false);
                        StringtextE0M.AssertModel(models[6],_testData[21], false);
                        StringtextE0M.AssertModel(models[7],_testData[22], false);
                        StringtextE0M.AssertModel(models[8],_testData[23], false);
                        StringtextE0M.AssertModel(models[9],_testData[24], false);
                        StringtextE0M.AssertModel(models[10],_testData[25], false);
                        StringtextE0M.AssertModel(models[11],_testData[26], false);
                        StringtextE0M.AssertModel(models[12],_testData[27], false);
                        StringtextE0M.AssertModel(models[13],_testData[28], false);
                        StringtextE0M.AssertModel(models[14],_testData[29], false);
                        StringtextE0M.AssertModel(models[15],_testData[30], false);
                        StringtextE0M.AssertModel(models[16],_testData[31], false);
                        StringtextE0M.AssertModel(models[17],_testData[32], false);
                        StringtextE0M.AssertModel(models[18],_testData[33], false);
                        StringtextE0M.AssertModel(models[19],_testData[34], false);
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
                await ((IStringSingleTypetext)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 17, query1, 118, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatStringtextE0M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatStringtextE0M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatStringtextE0M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatStringtextE0M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatStringtextE0M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatStringtextE0M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatStringtextE0M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatStringtextE0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatStringtextE0M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatStringtextE0M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatStringtextE0M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatStringtextE0M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatStringtextE0M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatStringtextE0M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatStringtextE0M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatStringtextE0M.AssertModel(secondItems2[7],_testData[34], false);
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
                await ((IStringSingleTypetext)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 104, query1, 77, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatStringtextE0M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatStringtextE0M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatStringtextE0M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatStringtextE0M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatStringtextE0M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatStringtextE0M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatStringtextE0M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatStringtextE0M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatStringtextE0M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatStringtextE0M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatStringtextE0M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatStringtextE0M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatStringtextE0M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatStringtextE0M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatStringtextE0M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatStringtextE0M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatStringtextE0M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatStringtextE0M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatStringtextE0M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatStringtextE0M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatStringtextE0M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatStringtextE0M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatStringtextE0M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatStringtextE0M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatStringtextE0M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatStringtextE0M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatStringtextE0M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatStringtextE0M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatStringtextE0M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatStringtextE0M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatStringtextE0M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatStringtextE0M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatStringtextE0M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatStringtextE0M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatStringtextE0M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatStringtextE0M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatStringtextE0M.AssertModel(secondItems1[14],_testData[34], false);
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
                 ((IStringSingleTypetext)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 43, query1, 114, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatStringtextE0M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatStringtextE0M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatStringtextE0M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatStringtextE0M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatStringtextE0M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatStringtextE0M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatStringtextE0M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatStringtextE0M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatStringtextE0M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatStringtextE0M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatStringtextE0M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatStringtextE0M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatStringtextE0M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatStringtextE0M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatStringtextE0M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatStringtextE0M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatStringtextE0M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatStringtextE0M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatStringtextE0M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatStringtextE0M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatStringtextE0M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatStringtextE0M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatStringtextE0M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatStringtextE0M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatStringtextE0M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatStringtextE0M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatStringtextE0M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatStringtextE0M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatStringtextE0M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatStringtextE0M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatStringtextE0M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatStringtextE0M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatStringtextE0M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatStringtextE0M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatStringtextE0M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatStringtextE0M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatStringtextE0M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatStringtextE0M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatStringtextE0M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatStringtextE0M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatStringtextE0M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatStringtextE0M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatStringtextE0M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatStringtextE0M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatStringtextE0M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatStringtextE0M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatStringtextE0M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatStringtextE0M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatStringtextE0M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatStringtextE0M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatStringtextE0M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatStringtextE0M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatStringtextE0M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatStringtextE0M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatStringtextE0M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatStringtextE0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatStringtextE0M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatStringtextE0M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatStringtextE0M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatStringtextE0M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatStringtextE0M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatStringtextE0M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatStringtextE0M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatStringtextE0M.AssertModel(secondItems2[8],_testData[34], false);
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
                 ((IStringSingleTypetext)this).DbConnectionMMDynQuerySelectModelBatch(connection, 26, query1, 104, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatStringtextE0M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatStringtextE0M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatStringtextE0M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatStringtextE0M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatStringtextE0M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatStringtextE0M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatStringtextE0M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatStringtextE0M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatStringtextE0M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatStringtextE0M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatStringtextE0M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatStringtextE0M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatStringtextE0M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatStringtextE0M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatStringtextE0M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatStringtextE0M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatStringtextE0M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatStringtextE0M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatStringtextE0M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatStringtextE0M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatStringtextE0M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatStringtextE0M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatStringtextE0M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatStringtextE0M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatStringtextE0M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatStringtextE0M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatStringtextE0M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatStringtextE0M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatStringtextE0M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatStringtextE0M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatStringtextE0M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatStringtextE0M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatStringtextE0M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatStringtextE0M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatStringtextE0M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatStringtextE0M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatStringtextE0M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatStringtextE0M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatStringtextE0M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatStringtextE0M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatStringtextE0M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatStringtextE0M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatStringtextE0M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatStringtextE0M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatStringtextE0M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatStringtextE0M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatStringtextE0M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatStringtextE0M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatStringtextE0M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatStringtextE0M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatStringtextE0M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatStringtextE0M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatStringtextE0M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatStringtextE0M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatStringtextE0M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatStringtextE0M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatStringtextE0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatStringtextE0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatStringtextE0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatStringtextE0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatStringtextE0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatStringtextE0M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatStringtextE0M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatStringtextE0M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatStringtextE0M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatStringtextE0M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatStringtextE0M.AssertModel(secondItems1[10],_testData[34], false);
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
                foreach(var batchResult in await ((IStringSingleTypetext)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 62, query1, 125, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatStringtextE0M.AssertModel(models[0],_testData[17], false);
                        FlatStringtextE0M.AssertModel(models[1],_testData[18], false);
                        FlatStringtextE0M.AssertModel(models[2],_testData[19], false);
                        FlatStringtextE0M.AssertModel(models[3],_testData[20], false);
                        FlatStringtextE0M.AssertModel(models[4],_testData[21], false);
                        FlatStringtextE0M.AssertModel(models[5],_testData[22], false);
                        FlatStringtextE0M.AssertModel(models[6],_testData[23], false);
                        FlatStringtextE0M.AssertModel(models[7],_testData[24], false);
                        FlatStringtextE0M.AssertModel(models[8],_testData[25], false);
                        FlatStringtextE0M.AssertModel(models[9],_testData[26], false);
                        FlatStringtextE0M.AssertModel(models[10],_testData[27], false);
                        FlatStringtextE0M.AssertModel(models[11],_testData[28], false);
                        FlatStringtextE0M.AssertModel(models[12],_testData[29], false);
                        FlatStringtextE0M.AssertModel(models[13],_testData[30], false);
                        FlatStringtextE0M.AssertModel(models[14],_testData[31], false);
                        FlatStringtextE0M.AssertModel(models[15],_testData[32], false);
                        FlatStringtextE0M.AssertModel(models[16],_testData[33], false);
                        FlatStringtextE0M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatStringtextE0M.AssertModel(models[0],_testData[28], false);
                        FlatStringtextE0M.AssertModel(models[1],_testData[29], false);
                        FlatStringtextE0M.AssertModel(models[2],_testData[30], false);
                        FlatStringtextE0M.AssertModel(models[3],_testData[31], false);
                        FlatStringtextE0M.AssertModel(models[4],_testData[32], false);
                        FlatStringtextE0M.AssertModel(models[5],_testData[33], false);
                        FlatStringtextE0M.AssertModel(models[6],_testData[34], false);
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
                await ((IStringSingleTypetext)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 54, query1, 118, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatStringtextE0M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatStringtextE0M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatStringtextE0M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatStringtextE0M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatStringtextE0M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatStringtextE0M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatStringtextE0M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatStringtextE0M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatStringtextE0M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatStringtextE0M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatStringtextE0M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatStringtextE0M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatStringtextE0M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatStringtextE0M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatStringtextE0M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatStringtextE0M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatStringtextE0M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatStringtextE0M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatStringtextE0M.AssertModel(firstItems1[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatStringtextE0M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatStringtextE0M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatStringtextE0M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatStringtextE0M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatStringtextE0M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatStringtextE0M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatStringtextE0M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatStringtextE0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatStringtextE0M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatStringtextE0M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatStringtextE0M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatStringtextE0M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatStringtextE0M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatStringtextE0M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatStringtextE0M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatStringtextE0M.AssertModel(secondItems2[7],_testData[34], false);
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
                foreach(var batchResult in  ((IStringSingleTypetext)this).DbConnectionSTDynQuerySelectModelBatch(connection, 125, query1, 139, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatStringtextE0M.AssertModel(models[0],_testData[28], false);
                        FlatStringtextE0M.AssertModel(models[1],_testData[29], false);
                        FlatStringtextE0M.AssertModel(models[2],_testData[30], false);
                        FlatStringtextE0M.AssertModel(models[3],_testData[31], false);
                        FlatStringtextE0M.AssertModel(models[4],_testData[32], false);
                        FlatStringtextE0M.AssertModel(models[5],_testData[33], false);
                        FlatStringtextE0M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatStringtextE0M.AssertModel(models[0],_testData[31], false);
                        FlatStringtextE0M.AssertModel(models[1],_testData[32], false);
                        FlatStringtextE0M.AssertModel(models[2],_testData[33], false);
                        FlatStringtextE0M.AssertModel(models[3],_testData[34], false);
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
                 ((IStringSingleTypetext)this).DbConnectionDynQuerySelectModelBatch(connection, 92, query1, 62, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatStringtextE0M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatStringtextE0M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatStringtextE0M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatStringtextE0M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatStringtextE0M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatStringtextE0M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatStringtextE0M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatStringtextE0M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatStringtextE0M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatStringtextE0M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatStringtextE0M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatStringtextE0M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatStringtextE0M.AssertModel(firstItems1[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatStringtextE0M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatStringtextE0M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatStringtextE0M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatStringtextE0M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatStringtextE0M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatStringtextE0M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatStringtextE0M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatStringtextE0M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatStringtextE0M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatStringtextE0M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatStringtextE0M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatStringtextE0M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatStringtextE0M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatStringtextE0M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatStringtextE0M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatStringtextE0M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatStringtextE0M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatStringtextE0M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatStringtextE0M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatStringtextE0M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatStringtextE0M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatStringtextE0M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatStringtextE0M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatStringtextE0M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatStringtextE0M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatStringtextE0M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatStringtextE0M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatStringtextE0M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatStringtextE0M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatStringtextE0M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatStringtextE0M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatStringtextE0M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatStringtextE0M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatStringtextE0M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatStringtextE0M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatStringtextE0M.AssertModel(secondItems2[17],_testData[34], false);
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
                foreach(var batchResult in await ((IStringSingleTypetext)this).DbConnectionSTSelectModelBatchAsync(connection, 105, 43))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        StringtextE0M.AssertModel(models[0],_testData[25], false);
                        StringtextE0M.AssertModel(models[1],_testData[26], false);
                        StringtextE0M.AssertModel(models[2],_testData[27], false);
                        StringtextE0M.AssertModel(models[3],_testData[28], false);
                        StringtextE0M.AssertModel(models[4],_testData[29], false);
                        StringtextE0M.AssertModel(models[5],_testData[30], false);
                        StringtextE0M.AssertModel(models[6],_testData[31], false);
                        StringtextE0M.AssertModel(models[7],_testData[32], false);
                        StringtextE0M.AssertModel(models[8],_testData[33], false);
                        StringtextE0M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        StringtextE0M.AssertModel(models[0],_testData[12], false);
                        StringtextE0M.AssertModel(models[1],_testData[13], false);
                        StringtextE0M.AssertModel(models[2],_testData[14], false);
                        StringtextE0M.AssertModel(models[3],_testData[15], false);
                        StringtextE0M.AssertModel(models[4],_testData[16], false);
                        StringtextE0M.AssertModel(models[5],_testData[17], false);
                        StringtextE0M.AssertModel(models[6],_testData[18], false);
                        StringtextE0M.AssertModel(models[7],_testData[19], false);
                        StringtextE0M.AssertModel(models[8],_testData[20], false);
                        StringtextE0M.AssertModel(models[9],_testData[21], false);
                        StringtextE0M.AssertModel(models[10],_testData[22], false);
                        StringtextE0M.AssertModel(models[11],_testData[23], false);
                        StringtextE0M.AssertModel(models[12],_testData[24], false);
                        StringtextE0M.AssertModel(models[13],_testData[25], false);
                        StringtextE0M.AssertModel(models[14],_testData[26], false);
                        StringtextE0M.AssertModel(models[15],_testData[27], false);
                        StringtextE0M.AssertModel(models[16],_testData[28], false);
                        StringtextE0M.AssertModel(models[17],_testData[29], false);
                        StringtextE0M.AssertModel(models[18],_testData[30], false);
                        StringtextE0M.AssertModel(models[19],_testData[31], false);
                        StringtextE0M.AssertModel(models[20],_testData[32], false);
                        StringtextE0M.AssertModel(models[21],_testData[33], false);
                        StringtextE0M.AssertModel(models[22],_testData[34], false);
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
                foreach(var batchResult in  ((IStringSingleTypetext)this).DbConnectionSTSelectModelBatch(connection, 45, 26))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        StringtextE0M.AssertModel(models[0],_testData[14], false);
                        StringtextE0M.AssertModel(models[1],_testData[15], false);
                        StringtextE0M.AssertModel(models[2],_testData[16], false);
                        StringtextE0M.AssertModel(models[3],_testData[17], false);
                        StringtextE0M.AssertModel(models[4],_testData[18], false);
                        StringtextE0M.AssertModel(models[5],_testData[19], false);
                        StringtextE0M.AssertModel(models[6],_testData[20], false);
                        StringtextE0M.AssertModel(models[7],_testData[21], false);
                        StringtextE0M.AssertModel(models[8],_testData[22], false);
                        StringtextE0M.AssertModel(models[9],_testData[23], false);
                        StringtextE0M.AssertModel(models[10],_testData[24], false);
                        StringtextE0M.AssertModel(models[11],_testData[25], false);
                        StringtextE0M.AssertModel(models[12],_testData[26], false);
                        StringtextE0M.AssertModel(models[13],_testData[27], false);
                        StringtextE0M.AssertModel(models[14],_testData[28], false);
                        StringtextE0M.AssertModel(models[15],_testData[29], false);
                        StringtextE0M.AssertModel(models[16],_testData[30], false);
                        StringtextE0M.AssertModel(models[17],_testData[31], false);
                        StringtextE0M.AssertModel(models[18],_testData[32], false);
                        StringtextE0M.AssertModel(models[19],_testData[33], false);
                        StringtextE0M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        StringtextE0M.AssertModel(models[0],_testData[7], false);
                        StringtextE0M.AssertModel(models[1],_testData[8], false);
                        StringtextE0M.AssertModel(models[2],_testData[9], false);
                        StringtextE0M.AssertModel(models[3],_testData[10], false);
                        StringtextE0M.AssertModel(models[4],_testData[11], false);
                        StringtextE0M.AssertModel(models[5],_testData[12], false);
                        StringtextE0M.AssertModel(models[6],_testData[13], false);
                        StringtextE0M.AssertModel(models[7],_testData[14], false);
                        StringtextE0M.AssertModel(models[8],_testData[15], false);
                        StringtextE0M.AssertModel(models[9],_testData[16], false);
                        StringtextE0M.AssertModel(models[10],_testData[17], false);
                        StringtextE0M.AssertModel(models[11],_testData[18], false);
                        StringtextE0M.AssertModel(models[12],_testData[19], false);
                        StringtextE0M.AssertModel(models[13],_testData[20], false);
                        StringtextE0M.AssertModel(models[14],_testData[21], false);
                        StringtextE0M.AssertModel(models[15],_testData[22], false);
                        StringtextE0M.AssertModel(models[16],_testData[23], false);
                        StringtextE0M.AssertModel(models[17],_testData[24], false);
                        StringtextE0M.AssertModel(models[18],_testData[25], false);
                        StringtextE0M.AssertModel(models[19],_testData[26], false);
                        StringtextE0M.AssertModel(models[20],_testData[27], false);
                        StringtextE0M.AssertModel(models[21],_testData[28], false);
                        StringtextE0M.AssertModel(models[22],_testData[29], false);
                        StringtextE0M.AssertModel(models[23],_testData[30], false);
                        StringtextE0M.AssertModel(models[24],_testData[31], false);
                        StringtextE0M.AssertModel(models[25],_testData[32], false);
                        StringtextE0M.AssertModel(models[26],_testData[33], false);
                        StringtextE0M.AssertModel(models[27],_testData[34], false);
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
                ((IStringSingleTypetext)this).SetDbConnectionSelectModelParametrs(cmd, 3);
                var models = await ((IStringSingleTypetext)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(33));

                StringtextE0M.AssertModel(models[0],_testData[2], false);
                StringtextE0M.AssertModel(models[1],_testData[3], false);
                StringtextE0M.AssertModel(models[2],_testData[4], false);
                StringtextE0M.AssertModel(models[3],_testData[5], false);
                StringtextE0M.AssertModel(models[4],_testData[6], false);
                StringtextE0M.AssertModel(models[5],_testData[7], false);
                StringtextE0M.AssertModel(models[6],_testData[8], false);
                StringtextE0M.AssertModel(models[7],_testData[9], false);
                StringtextE0M.AssertModel(models[8],_testData[10], false);
                StringtextE0M.AssertModel(models[9],_testData[11], false);
                StringtextE0M.AssertModel(models[10],_testData[12], false);
                StringtextE0M.AssertModel(models[11],_testData[13], false);
                StringtextE0M.AssertModel(models[12],_testData[14], false);
                StringtextE0M.AssertModel(models[13],_testData[15], false);
                StringtextE0M.AssertModel(models[14],_testData[16], false);
                StringtextE0M.AssertModel(models[15],_testData[17], false);
                StringtextE0M.AssertModel(models[16],_testData[18], false);
                StringtextE0M.AssertModel(models[17],_testData[19], false);
                StringtextE0M.AssertModel(models[18],_testData[20], false);
                StringtextE0M.AssertModel(models[19],_testData[21], false);
                StringtextE0M.AssertModel(models[20],_testData[22], false);
                StringtextE0M.AssertModel(models[21],_testData[23], false);
                StringtextE0M.AssertModel(models[22],_testData[24], false);
                StringtextE0M.AssertModel(models[23],_testData[25], false);
                StringtextE0M.AssertModel(models[24],_testData[26], false);
                StringtextE0M.AssertModel(models[25],_testData[27], false);
                StringtextE0M.AssertModel(models[26],_testData[28], false);
                StringtextE0M.AssertModel(models[27],_testData[29], false);
                StringtextE0M.AssertModel(models[28],_testData[30], false);
                StringtextE0M.AssertModel(models[29],_testData[31], false);
                StringtextE0M.AssertModel(models[30],_testData[32], false);
                StringtextE0M.AssertModel(models[31],_testData[33], false);
                StringtextE0M.AssertModel(models[32],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IStringSingleTypetext)this).CreateDbConnectionSelectModelCommand(connection);
                ((IStringSingleTypetext)this).SetDbConnectionSelectModelParametrs(cmd, 144);
                var models =  ((IStringSingleTypetext)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(3));

                StringtextE0M.AssertModel(models[0],_testData[32], false);
                StringtextE0M.AssertModel(models[1],_testData[33], false);
                StringtextE0M.AssertModel(models[2],_testData[34], false);
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
                Assert.That((System.Int32)model[0], Is.EqualTo((2)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("ufxnmpjkguopchfrnoprcj")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("fwcgvycwwmfdwoswjermunenhsbha")));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((3)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("dsvtvaychpi")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("gnxj")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("wfjspcljttxpwdffltaopafidvub")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("jxjcontcinlnkd")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("eavlycecaqymv")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("rgskxrlsymnuhdnulibfbxan")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("enqyrvivg")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("bthmkawqwxtbetpibuef")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("tfuurntrymbxjjsegqnycftisir")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("gsrdynopemvcldacenbysbbhm")));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("nfgyesttjwr")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("osjxfkuntagpnrbeecxwdnt")));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("gbrtafloydlcrmjodbkflish")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("jesvlywfgeiqcbimk")));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("jeyqkafhflfrdauwqxcaotmpdvf")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("yd")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("hqnpdfowrhlnyuwbykwcvjxmduwfi")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("stoddxwtytjxx")));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("uptmxni")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("wlqggyybbvto")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("sbadtuneuucuhcu")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("glxmoljcmmxxebqyp")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((45)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("mqkgkjkx")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("okkrtelp")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("cr")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("dadrxvbrsjygtp")));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("bblplrjtbketqhdfrvcipcqsmxlxp")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("uhneimydtaqychi")));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("xjaxinspdqwfbdneubruoabvymhgl")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("bnyriguaagtrojrvllwiaavkjw")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("hxgiribixkycgyabkhakysolmeg")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("grsq")));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("lmfusifqyy")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("lhhggirqutlpswjpxvtofmcalsa")));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("td")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("mpbrghodrxkbrlo")));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("fhrvgkohlolnbju")));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("ythulfvkxudlxoybvjpba")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("vdaynrdmjlqwmtrpemearuekpwji")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("nxcjjnpeoxslneqtyxhwyhlpdl")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("uoppruxplaljnjuuhdtsbagmmytpp")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("yjkdlni")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("hgypjsxdrpcelvlyk")));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("avlwcbr")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("jgirhmwsbxnsmfgglj")));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("phhaxtqxihybbfvvmvxec")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("lbgxytynxmvfpo")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("djtlfqs")));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("tgvxkjwrowejlmotto")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("xjpxjkwysjamybiisvwaqc")));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("rphqxrkgcokgruym")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("adcbmccjogmocinpnltyc")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("sxuldtbcghtdnh")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("hovyqdfltrmyuv")));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("dkocydtvbxhidpnbcmihuq")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("hlwqyocivarmtlplefwxahytwxen")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((74)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("yfqgfryrtubaligihffvwx")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("nxplbdoudnansqapjjh")));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("amvtrqyebolv")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("cifnk")));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("rbicstjovlxgh")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((78)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("nnjh")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("ikmfxcyjy")));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("u")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("mfg")));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("wewrccvhmacrthkv")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((84)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("cbuehfnnmnxpoibvcxwhn")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("sxcl")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((160)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("phoipriuftrlwmmqovrketvuagip")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((87)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("goevsmjnrtsxfbpyfyamaidhljrln")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("yrknqpsn")));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((168)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("ukyntcukblsjmycnhk")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("slhkcjqarkolot")));

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
                Assert.That((System.Int32)model[0], Is.EqualTo((2)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("ufxnmpjkguopchfrnoprcj")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("fwcgvycwwmfdwoswjermunenhsbha")));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((3)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("dsvtvaychpi")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("gnxj")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("wfjspcljttxpwdffltaopafidvub")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("jxjcontcinlnkd")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("eavlycecaqymv")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("rgskxrlsymnuhdnulibfbxan")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("enqyrvivg")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("bthmkawqwxtbetpibuef")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("tfuurntrymbxjjsegqnycftisir")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("gsrdynopemvcldacenbysbbhm")));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("nfgyesttjwr")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("osjxfkuntagpnrbeecxwdnt")));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("gbrtafloydlcrmjodbkflish")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("jesvlywfgeiqcbimk")));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("jeyqkafhflfrdauwqxcaotmpdvf")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("yd")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("hqnpdfowrhlnyuwbykwcvjxmduwfi")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("stoddxwtytjxx")));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("uptmxni")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("wlqggyybbvto")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("sbadtuneuucuhcu")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("glxmoljcmmxxebqyp")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((45)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("mqkgkjkx")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("okkrtelp")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("cr")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("dadrxvbrsjygtp")));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("bblplrjtbketqhdfrvcipcqsmxlxp")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("uhneimydtaqychi")));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("xjaxinspdqwfbdneubruoabvymhgl")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("bnyriguaagtrojrvllwiaavkjw")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("hxgiribixkycgyabkhakysolmeg")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("grsq")));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("lmfusifqyy")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("lhhggirqutlpswjpxvtofmcalsa")));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("td")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("mpbrghodrxkbrlo")));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("fhrvgkohlolnbju")));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("ythulfvkxudlxoybvjpba")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("vdaynrdmjlqwmtrpemearuekpwji")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("nxcjjnpeoxslneqtyxhwyhlpdl")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("uoppruxplaljnjuuhdtsbagmmytpp")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("yjkdlni")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("hgypjsxdrpcelvlyk")));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("avlwcbr")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("jgirhmwsbxnsmfgglj")));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("phhaxtqxihybbfvvmvxec")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("lbgxytynxmvfpo")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("djtlfqs")));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("tgvxkjwrowejlmotto")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("xjpxjkwysjamybiisvwaqc")));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("rphqxrkgcokgruym")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("adcbmccjogmocinpnltyc")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("sxuldtbcghtdnh")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("hovyqdfltrmyuv")));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("dkocydtvbxhidpnbcmihuq")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("hlwqyocivarmtlplefwxahytwxen")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((74)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("yfqgfryrtubaligihffvwx")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("nxplbdoudnansqapjjh")));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("amvtrqyebolv")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("cifnk")));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("rbicstjovlxgh")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((78)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("nnjh")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("ikmfxcyjy")));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("u")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("mfg")));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("wewrccvhmacrthkv")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((84)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("cbuehfnnmnxpoibvcxwhn")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("sxcl")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((160)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("phoipriuftrlwmmqovrketvuagip")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((87)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("goevsmjnrtsxfbpyfyamaidhljrln")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("yrknqpsn")));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((168)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("ukyntcukblsjmycnhk")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("slhkcjqarkolot")));

            }
        }

#endregion

    }
}

