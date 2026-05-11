

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
    Id = 3,
    Value = "ksfrpcldgytxheqqfr",
    ModelInner = null,
    NullableValue = null,
},
            new StringtextE0M
{
    Id = 6,
    Value = "qvihsoyndghbklbpddqach",
    ModelInner = new StringtextE0MI
{
    Id = 1,
    Value = "oyvygbnrcaxameqbndgnmp",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringtextE0M
{
    Id = 12,
    Value = "jtqyahapyvqacnjvqmqnovpur",
    ModelInner = null,
    NullableValue = null,
},
            new StringtextE0M
{
    Id = 14,
    Value = "xwunvjbfumchsjmsqhcdtetcdjtpv",
    ModelInner = new StringtextE0MI
{
    Id = 9,
    Value = "lirvso",
    NullableValue = "ddn",
},
    NullableValue = "pnstauubyvurpb",
},
            new StringtextE0M
{
    Id = 19,
    Value = "suur",
    ModelInner = null,
    NullableValue = null,
},
            new StringtextE0M
{
    Id = 20,
    Value = "a",
    ModelInner = new StringtextE0MI
{
    Id = 12,
    Value = "cq",
    NullableValue = "cwbpsiqmp",
},
    NullableValue = null,
},
            new StringtextE0M
{
    Id = 22,
    Value = "rxhrfmlabrci",
    ModelInner = null,
    NullableValue = "pspbeockyl",
},
            new StringtextE0M
{
    Id = 28,
    Value = "bdfbdoxknpojcktdhda",
    ModelInner = new StringtextE0MI
{
    Id = 17,
    Value = "wnycamkrjnwmkupywhpludbomhw",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringtextE0M
{
    Id = 29,
    Value = "hwcelgg",
    ModelInner = null,
    NullableValue = null,
},
            new StringtextE0M
{
    Id = 37,
    Value = "xknmmpgapmqwgrydkatakfv",
    ModelInner = new StringtextE0MI
{
    Id = 22,
    Value = "eomuqxyqotmvdfrsbobvqysnxuqdm",
    NullableValue = "uesvljkoewmaxxaygmvfg",
},
    NullableValue = "e",
},
            new StringtextE0M
{
    Id = 44,
    Value = "wuxpseuslsxrliurlsgbv",
    ModelInner = null,
    NullableValue = null,
},
            new StringtextE0M
{
    Id = 45,
    Value = "jfrynmobsxsrepxc",
    ModelInner = new StringtextE0MI
{
    Id = 27,
    Value = "suukuvipgurmsqd",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringtextE0M
{
    Id = 52,
    Value = "",
    ModelInner = null,
    NullableValue = "cgastkitksdfakpw",
},
            new StringtextE0M
{
    Id = 61,
    Value = "enbikggtutnoxkuuvdibckvi",
    ModelInner = new StringtextE0MI
{
    Id = 30,
    Value = "pvubyqxyctayvjfbrywobmksddibg",
    NullableValue = "jdptiefpvfmmiyrbtuebpqkqgp",
},
    NullableValue = null,
},
            new StringtextE0M
{
    Id = 63,
    Value = "tlkghooytxcxtmvi",
    ModelInner = null,
    NullableValue = null,
},
            new StringtextE0M
{
    Id = 67,
    Value = "iihwleuxsyhqntoirlwymitmq",
    ModelInner = new StringtextE0MI
{
    Id = 35,
    Value = "uyictifmaxugtptvotru",
    NullableValue = null,
},
    NullableValue = "toksaowronrbhuifruwbt",
},
            new StringtextE0M
{
    Id = 68,
    Value = "wpyioeeofvjgaivnoxksbgqagx",
    ModelInner = null,
    NullableValue = null,
},
            new StringtextE0M
{
    Id = 70,
    Value = "msmarenouf",
    ModelInner = new StringtextE0MI
{
    Id = 41,
    Value = "bugdpwkvj",
    NullableValue = null,
},
    NullableValue = "luqyceyewoqbafhettffjnl",
},
            new StringtextE0M
{
    Id = 78,
    Value = "coonssowiusmelxxusekwub",
    ModelInner = null,
    NullableValue = null,
},
            new StringtextE0M
{
    Id = 83,
    Value = "xqbcuogougqglqgjolctoouoodxqa",
    ModelInner = new StringtextE0MI
{
    Id = 42,
    Value = "exbmxmdllnkbhs",
    NullableValue = null,
},
    NullableValue = "p",
},
            new StringtextE0M
{
    Id = 90,
    Value = "imyyjo",
    ModelInner = null,
    NullableValue = "cothhoaxlxrjidntouddcwdiy",
},
            new StringtextE0M
{
    Id = 94,
    Value = "kikeqjepdpiqj",
    ModelInner = new StringtextE0MI
{
    Id = 48,
    Value = "yqdsoacaekt",
    NullableValue = "myupwtguaomduokroiwogchfmpoo",
},
    NullableValue = null,
},
            new StringtextE0M
{
    Id = 97,
    Value = "nf",
    ModelInner = null,
    NullableValue = null,
},
            new StringtextE0M
{
    Id = 104,
    Value = "pkgpnrumerwsspnrxu",
    ModelInner = new StringtextE0MI
{
    Id = 51,
    Value = "lxreouloupvmixc",
    NullableValue = "okxwlyukindcoduxnemd",
},
    NullableValue = null,
},
            new StringtextE0M
{
    Id = 112,
    Value = "obg",
    ModelInner = null,
    NullableValue = null,
},
            new StringtextE0M
{
    Id = 120,
    Value = "lwnweqobhbdpgyvhmhicaia",
    ModelInner = new StringtextE0MI
{
    Id = 58,
    Value = "bhhegtkhjvtoes",
    NullableValue = null,
},
    NullableValue = "elyrn",
},
            new StringtextE0M
{
    Id = 125,
    Value = "wnnalqcevmgcofequ",
    ModelInner = null,
    NullableValue = null,
},
            new StringtextE0M
{
    Id = 129,
    Value = "m",
    ModelInner = new StringtextE0MI
{
    Id = 63,
    Value = "ptkiwmhochsqeenul",
    NullableValue = null,
},
    NullableValue = "xgulkomgjxbl",
},
            new StringtextE0M
{
    Id = 135,
    Value = "hxklfhomjupyhqlqsw",
    ModelInner = null,
    NullableValue = null,
},
            new StringtextE0M
{
    Id = 140,
    Value = "votsh",
    ModelInner = new StringtextE0MI
{
    Id = 64,
    Value = "vhqmpytaqvegyxrfhlgnqgn",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringtextE0M
{
    Id = 141,
    Value = "bvciakgoswvyburccenbgabmkg",
    ModelInner = null,
    NullableValue = null,
},
            new StringtextE0M
{
    Id = 147,
    Value = "yy",
    ModelInner = new StringtextE0MI
{
    Id = 70,
    Value = "ymsee",
    NullableValue = null,
},
    NullableValue = "trojgdcyncislf",
},
            new StringtextE0M
{
    Id = 155,
    Value = "jlgsngnyjnaoqhofdn",
    ModelInner = null,
    NullableValue = null,
},
            new StringtextE0M
{
    Id = 160,
    Value = "ihnltefsfcxlsyxfimj",
    ModelInner = new StringtextE0MI
{
    Id = 76,
    Value = "srt",
    NullableValue = null,
},
    NullableValue = "iopjttpj",
},
            new StringtextE0M
{
    Id = 161,
    Value = "susudpwsdmiapuynkqxwrdqu",
    ModelInner = null,
    NullableValue = "gulwuxrtmlfdlupgkuxrgupbl",
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
                parametr1.Value = 22;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 104;
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
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatStringtextE0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatStringtextE0M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatStringtextE0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatStringtextE0M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatStringtextE0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatStringtextE0M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatStringtextE0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatStringtextE0M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatStringtextE0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatStringtextE0M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatStringtextE0M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatStringtextE0M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatStringtextE0M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatStringtextE0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatStringtextE0M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatStringtextE0M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatStringtextE0M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatStringtextE0M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatStringtextE0M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatStringtextE0M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatStringtextE0M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatStringtextE0M.AssertModel(secondItems2[10],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 3;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 90;
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
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatStringtextE0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatStringtextE0M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatStringtextE0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatStringtextE0M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatStringtextE0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatStringtextE0M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatStringtextE0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatStringtextE0M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatStringtextE0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatStringtextE0M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatStringtextE0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatStringtextE0M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatStringtextE0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatStringtextE0M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatStringtextE0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatStringtextE0M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatStringtextE0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatStringtextE0M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatStringtextE0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatStringtextE0M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatStringtextE0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatStringtextE0M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatStringtextE0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatStringtextE0M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatStringtextE0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatStringtextE0M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatStringtextE0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatStringtextE0M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatStringtextE0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatStringtextE0M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatStringtextE0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatStringtextE0M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatStringtextE0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatStringtextE0M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatStringtextE0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatStringtextE0M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatStringtextE0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatStringtextE0M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatStringtextE0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatStringtextE0M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatStringtextE0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatStringtextE0M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatStringtextE0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatStringtextE0M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatStringtextE0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatStringtextE0M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatStringtextE0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatStringtextE0M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatStringtextE0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatStringtextE0M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatStringtextE0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatStringtextE0M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatStringtextE0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatStringtextE0M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatStringtextE0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatStringtextE0M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatStringtextE0M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatStringtextE0M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatStringtextE0M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatStringtextE0M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatStringtextE0M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatStringtextE0M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatStringtextE0M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatStringtextE0M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatStringtextE0M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatStringtextE0M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatStringtextE0M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatStringtextE0M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                        FlatStringtextE0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatStringtextE0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatStringtextE0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatStringtextE0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatStringtextE0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatStringtextE0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatStringtextE0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatStringtextE0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatStringtextE0M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatStringtextE0M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatStringtextE0M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatStringtextE0M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatStringtextE0M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatStringtextE0M.AssertModel(secondItems1[13],_testData[34], false);
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
                parametr1.Value = 90;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 67;
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
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatStringtextE0M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatStringtextE0M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatStringtextE0M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatStringtextE0M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatStringtextE0M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatStringtextE0M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatStringtextE0M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatStringtextE0M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatStringtextE0M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatStringtextE0M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatStringtextE0M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatStringtextE0M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatStringtextE0M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatStringtextE0M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatStringtextE0M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatStringtextE0M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatStringtextE0M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatStringtextE0M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatStringtextE0M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatStringtextE0M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatStringtextE0M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatStringtextE0M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatStringtextE0M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatStringtextE0M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatStringtextE0M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatStringtextE0M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatStringtextE0M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatStringtextE0M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatStringtextE0M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatStringtextE0M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatStringtextE0M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatStringtextE0M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatStringtextE0M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatStringtextE0M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatStringtextE0M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatStringtextE0M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatStringtextE0M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatStringtextE0M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatStringtextE0M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatStringtextE0M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatStringtextE0M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatStringtextE0M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatStringtextE0M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatStringtextE0M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatStringtextE0M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatStringtextE0M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatStringtextE0M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatStringtextE0M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatStringtextE0M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatStringtextE0M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatStringtextE0M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatStringtextE0M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatStringtextE0M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatStringtextE0M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatStringtextE0M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatStringtextE0M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatStringtextE0M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatStringtextE0M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatStringtextE0M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatStringtextE0M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatStringtextE0M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatStringtextE0M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatStringtextE0M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatStringtextE0M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatStringtextE0M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatStringtextE0M.AssertModel(secondItems2[18],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 12;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 14;
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
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                        FlatStringtextE0M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatStringtextE0M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatStringtextE0M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatStringtextE0M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatStringtextE0M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatStringtextE0M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatStringtextE0M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatStringtextE0M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatStringtextE0M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatStringtextE0M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatStringtextE0M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatStringtextE0M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatStringtextE0M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatStringtextE0M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatStringtextE0M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatStringtextE0M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatStringtextE0M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatStringtextE0M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatStringtextE0M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatStringtextE0M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatStringtextE0M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatStringtextE0M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatStringtextE0M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatStringtextE0M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatStringtextE0M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatStringtextE0M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatStringtextE0M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatStringtextE0M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatStringtextE0M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatStringtextE0M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatStringtextE0M.AssertModel(secondItems1[30],_testData[34], false);
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
                parametr1.Value = 67;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 129;
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
        public async Task DbConnectionDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 45;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 129;
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
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatStringtextE0M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatStringtextE0M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatStringtextE0M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatStringtextE0M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatStringtextE0M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatStringtextE0M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatStringtextE0M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatStringtextE0M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatStringtextE0M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatStringtextE0M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatStringtextE0M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatStringtextE0M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatStringtextE0M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatStringtextE0M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatStringtextE0M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatStringtextE0M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatStringtextE0M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatStringtextE0M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatStringtextE0M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatStringtextE0M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatStringtextE0M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatStringtextE0M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatStringtextE0M.AssertModel(firstItems1[22],_testData[34], false);
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
                parametr1.Value = 61;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 67;
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
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatStringtextE0M.AssertModel(models[0],_testData[14], false);
                        FlatStringtextE0M.AssertModel(models[1],_testData[15], false);
                        FlatStringtextE0M.AssertModel(models[2],_testData[16], false);
                        FlatStringtextE0M.AssertModel(models[3],_testData[17], false);
                        FlatStringtextE0M.AssertModel(models[4],_testData[18], false);
                        FlatStringtextE0M.AssertModel(models[5],_testData[19], false);
                        FlatStringtextE0M.AssertModel(models[6],_testData[20], false);
                        FlatStringtextE0M.AssertModel(models[7],_testData[21], false);
                        FlatStringtextE0M.AssertModel(models[8],_testData[22], false);
                        FlatStringtextE0M.AssertModel(models[9],_testData[23], false);
                        FlatStringtextE0M.AssertModel(models[10],_testData[24], false);
                        FlatStringtextE0M.AssertModel(models[11],_testData[25], false);
                        FlatStringtextE0M.AssertModel(models[12],_testData[26], false);
                        FlatStringtextE0M.AssertModel(models[13],_testData[27], false);
                        FlatStringtextE0M.AssertModel(models[14],_testData[28], false);
                        FlatStringtextE0M.AssertModel(models[15],_testData[29], false);
                        FlatStringtextE0M.AssertModel(models[16],_testData[30], false);
                        FlatStringtextE0M.AssertModel(models[17],_testData[31], false);
                        FlatStringtextE0M.AssertModel(models[18],_testData[32], false);
                        FlatStringtextE0M.AssertModel(models[19],_testData[33], false);
                        FlatStringtextE0M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                parametr1.Value = 12;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 22;
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
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatStringtextE0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatStringtextE0M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatStringtextE0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatStringtextE0M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatStringtextE0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatStringtextE0M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatStringtextE0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatStringtextE0M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatStringtextE0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatStringtextE0M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatStringtextE0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatStringtextE0M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatStringtextE0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatStringtextE0M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatStringtextE0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatStringtextE0M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatStringtextE0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatStringtextE0M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatStringtextE0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatStringtextE0M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatStringtextE0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatStringtextE0M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatStringtextE0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatStringtextE0M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatStringtextE0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatStringtextE0M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatStringtextE0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatStringtextE0M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatStringtextE0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatStringtextE0M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatStringtextE0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatStringtextE0M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatStringtextE0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatStringtextE0M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatStringtextE0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatStringtextE0M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatStringtextE0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatStringtextE0M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatStringtextE0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatStringtextE0M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatStringtextE0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatStringtextE0M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatStringtextE0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatStringtextE0M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatStringtextE0M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatStringtextE0M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatStringtextE0M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatStringtextE0M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatStringtextE0M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatStringtextE0M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatStringtextE0M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatStringtextE0M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatStringtextE0M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatStringtextE0M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatStringtextE0M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatStringtextE0M.AssertModel(secondItems2[27],_testData[34], false);
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
                parametr1.Value = 37;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 125;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IStringSingleTypetext)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        StringtextE0M.AssertModel(models[0],_testData[10], false);
                        StringtextE0M.AssertModel(models[1],_testData[11], false);
                        StringtextE0M.AssertModel(models[2],_testData[12], false);
                        StringtextE0M.AssertModel(models[3],_testData[13], false);
                        StringtextE0M.AssertModel(models[4],_testData[14], false);
                        StringtextE0M.AssertModel(models[5],_testData[15], false);
                        StringtextE0M.AssertModel(models[6],_testData[16], false);
                        StringtextE0M.AssertModel(models[7],_testData[17], false);
                        StringtextE0M.AssertModel(models[8],_testData[18], false);
                        StringtextE0M.AssertModel(models[9],_testData[19], false);
                        StringtextE0M.AssertModel(models[10],_testData[20], false);
                        StringtextE0M.AssertModel(models[11],_testData[21], false);
                        StringtextE0M.AssertModel(models[12],_testData[22], false);
                        StringtextE0M.AssertModel(models[13],_testData[23], false);
                        StringtextE0M.AssertModel(models[14],_testData[24], false);
                        StringtextE0M.AssertModel(models[15],_testData[25], false);
                        StringtextE0M.AssertModel(models[16],_testData[26], false);
                        StringtextE0M.AssertModel(models[17],_testData[27], false);
                        StringtextE0M.AssertModel(models[18],_testData[28], false);
                        StringtextE0M.AssertModel(models[19],_testData[29], false);
                        StringtextE0M.AssertModel(models[20],_testData[30], false);
                        StringtextE0M.AssertModel(models[21],_testData[31], false);
                        StringtextE0M.AssertModel(models[22],_testData[32], false);
                        StringtextE0M.AssertModel(models[23],_testData[33], false);
                        StringtextE0M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        StringtextE0M.AssertModel(models[0],_testData[27], false);
                        StringtextE0M.AssertModel(models[1],_testData[28], false);
                        StringtextE0M.AssertModel(models[2],_testData[29], false);
                        StringtextE0M.AssertModel(models[3],_testData[30], false);
                        StringtextE0M.AssertModel(models[4],_testData[31], false);
                        StringtextE0M.AssertModel(models[5],_testData[32], false);
                        StringtextE0M.AssertModel(models[6],_testData[33], false);
                        StringtextE0M.AssertModel(models[7],_testData[34], false);
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
                parametr1.Value = 78;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 68;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IStringSingleTypetext)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        StringtextE0M.AssertModel(models[0],_testData[17], false);
                        StringtextE0M.AssertModel(models[1],_testData[18], false);
                        StringtextE0M.AssertModel(models[2],_testData[19], false);
                        StringtextE0M.AssertModel(models[3],_testData[20], false);
                        StringtextE0M.AssertModel(models[4],_testData[21], false);
                        StringtextE0M.AssertModel(models[5],_testData[22], false);
                        StringtextE0M.AssertModel(models[6],_testData[23], false);
                        StringtextE0M.AssertModel(models[7],_testData[24], false);
                        StringtextE0M.AssertModel(models[8],_testData[25], false);
                        StringtextE0M.AssertModel(models[9],_testData[26], false);
                        StringtextE0M.AssertModel(models[10],_testData[27], false);
                        StringtextE0M.AssertModel(models[11],_testData[28], false);
                        StringtextE0M.AssertModel(models[12],_testData[29], false);
                        StringtextE0M.AssertModel(models[13],_testData[30], false);
                        StringtextE0M.AssertModel(models[14],_testData[31], false);
                        StringtextE0M.AssertModel(models[15],_testData[32], false);
                        StringtextE0M.AssertModel(models[16],_testData[33], false);
                        StringtextE0M.AssertModel(models[17],_testData[34], false);
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
                await ((IStringSingleTypetext)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 22, query1, 97, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                await ((IStringSingleTypetext)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 22, query1, 68, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatStringtextE0M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatStringtextE0M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatStringtextE0M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatStringtextE0M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatStringtextE0M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatStringtextE0M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatStringtextE0M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatStringtextE0M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatStringtextE0M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatStringtextE0M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatStringtextE0M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatStringtextE0M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatStringtextE0M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatStringtextE0M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatStringtextE0M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatStringtextE0M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatStringtextE0M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatStringtextE0M.AssertModel(secondItems1[17],_testData[34], false);
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
                 ((IStringSingleTypetext)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 3, query1, 90, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatStringtextE0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatStringtextE0M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatStringtextE0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatStringtextE0M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatStringtextE0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatStringtextE0M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatStringtextE0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatStringtextE0M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatStringtextE0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatStringtextE0M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatStringtextE0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatStringtextE0M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatStringtextE0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatStringtextE0M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatStringtextE0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatStringtextE0M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatStringtextE0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatStringtextE0M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatStringtextE0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatStringtextE0M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatStringtextE0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatStringtextE0M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatStringtextE0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatStringtextE0M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatStringtextE0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatStringtextE0M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatStringtextE0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatStringtextE0M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatStringtextE0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatStringtextE0M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatStringtextE0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatStringtextE0M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatStringtextE0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatStringtextE0M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatStringtextE0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatStringtextE0M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatStringtextE0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatStringtextE0M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatStringtextE0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatStringtextE0M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatStringtextE0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatStringtextE0M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatStringtextE0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatStringtextE0M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatStringtextE0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatStringtextE0M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatStringtextE0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatStringtextE0M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatStringtextE0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatStringtextE0M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatStringtextE0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatStringtextE0M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatStringtextE0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatStringtextE0M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatStringtextE0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatStringtextE0M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatStringtextE0M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatStringtextE0M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatStringtextE0M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatStringtextE0M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatStringtextE0M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatStringtextE0M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatStringtextE0M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatStringtextE0M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatStringtextE0M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatStringtextE0M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatStringtextE0M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatStringtextE0M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatStringtextE0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatStringtextE0M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatStringtextE0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatStringtextE0M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatStringtextE0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatStringtextE0M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatStringtextE0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatStringtextE0M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatStringtextE0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatStringtextE0M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatStringtextE0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatStringtextE0M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatStringtextE0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatStringtextE0M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatStringtextE0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatStringtextE0M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatStringtextE0M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatStringtextE0M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatStringtextE0M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatStringtextE0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatStringtextE0M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatStringtextE0M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatStringtextE0M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatStringtextE0M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatStringtextE0M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatStringtextE0M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatStringtextE0M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatStringtextE0M.AssertModel(secondItems2[13],_testData[34], false);
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
                 ((IStringSingleTypetext)this).DbConnectionMMDynQuerySelectModelBatch(connection, 14, query1, 19, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                        FlatStringtextE0M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatStringtextE0M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatStringtextE0M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatStringtextE0M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatStringtextE0M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatStringtextE0M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatStringtextE0M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatStringtextE0M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatStringtextE0M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatStringtextE0M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatStringtextE0M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatStringtextE0M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatStringtextE0M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatStringtextE0M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatStringtextE0M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatStringtextE0M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatStringtextE0M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatStringtextE0M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatStringtextE0M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatStringtextE0M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatStringtextE0M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatStringtextE0M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatStringtextE0M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatStringtextE0M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatStringtextE0M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatStringtextE0M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatStringtextE0M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatStringtextE0M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatStringtextE0M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatStringtextE0M.AssertModel(secondItems1[29],_testData[34], false);
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
                foreach(var batchResult in await ((IStringSingleTypetext)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 37, query1, 83, query2))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatStringtextE0M.AssertModel(models[0],_testData[20], false);
                        FlatStringtextE0M.AssertModel(models[1],_testData[21], false);
                        FlatStringtextE0M.AssertModel(models[2],_testData[22], false);
                        FlatStringtextE0M.AssertModel(models[3],_testData[23], false);
                        FlatStringtextE0M.AssertModel(models[4],_testData[24], false);
                        FlatStringtextE0M.AssertModel(models[5],_testData[25], false);
                        FlatStringtextE0M.AssertModel(models[6],_testData[26], false);
                        FlatStringtextE0M.AssertModel(models[7],_testData[27], false);
                        FlatStringtextE0M.AssertModel(models[8],_testData[28], false);
                        FlatStringtextE0M.AssertModel(models[9],_testData[29], false);
                        FlatStringtextE0M.AssertModel(models[10],_testData[30], false);
                        FlatStringtextE0M.AssertModel(models[11],_testData[31], false);
                        FlatStringtextE0M.AssertModel(models[12],_testData[32], false);
                        FlatStringtextE0M.AssertModel(models[13],_testData[33], false);
                        FlatStringtextE0M.AssertModel(models[14],_testData[34], false);
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
                await ((IStringSingleTypetext)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 140, query1, 22, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatStringtextE0M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatStringtextE0M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatStringtextE0M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatStringtextE0M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatStringtextE0M.AssertModel(firstItems1[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatStringtextE0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatStringtextE0M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatStringtextE0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatStringtextE0M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatStringtextE0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatStringtextE0M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatStringtextE0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatStringtextE0M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatStringtextE0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatStringtextE0M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatStringtextE0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatStringtextE0M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatStringtextE0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatStringtextE0M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatStringtextE0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatStringtextE0M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatStringtextE0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatStringtextE0M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatStringtextE0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatStringtextE0M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatStringtextE0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatStringtextE0M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatStringtextE0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatStringtextE0M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatStringtextE0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatStringtextE0M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatStringtextE0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatStringtextE0M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatStringtextE0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatStringtextE0M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatStringtextE0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatStringtextE0M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatStringtextE0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatStringtextE0M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatStringtextE0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatStringtextE0M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatStringtextE0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatStringtextE0M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatStringtextE0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatStringtextE0M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatStringtextE0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatStringtextE0M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatStringtextE0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatStringtextE0M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatStringtextE0M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatStringtextE0M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatStringtextE0M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatStringtextE0M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatStringtextE0M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatStringtextE0M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatStringtextE0M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatStringtextE0M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatStringtextE0M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatStringtextE0M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatStringtextE0M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatStringtextE0M.AssertModel(secondItems2[27],_testData[34], false);
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
                foreach(var batchResult in  ((IStringSingleTypetext)this).DbConnectionSTDynQuerySelectModelBatch(connection, 68, query1, 83, query2))
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
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatStringtextE0M.AssertModel(models[0],_testData[20], false);
                        FlatStringtextE0M.AssertModel(models[1],_testData[21], false);
                        FlatStringtextE0M.AssertModel(models[2],_testData[22], false);
                        FlatStringtextE0M.AssertModel(models[3],_testData[23], false);
                        FlatStringtextE0M.AssertModel(models[4],_testData[24], false);
                        FlatStringtextE0M.AssertModel(models[5],_testData[25], false);
                        FlatStringtextE0M.AssertModel(models[6],_testData[26], false);
                        FlatStringtextE0M.AssertModel(models[7],_testData[27], false);
                        FlatStringtextE0M.AssertModel(models[8],_testData[28], false);
                        FlatStringtextE0M.AssertModel(models[9],_testData[29], false);
                        FlatStringtextE0M.AssertModel(models[10],_testData[30], false);
                        FlatStringtextE0M.AssertModel(models[11],_testData[31], false);
                        FlatStringtextE0M.AssertModel(models[12],_testData[32], false);
                        FlatStringtextE0M.AssertModel(models[13],_testData[33], false);
                        FlatStringtextE0M.AssertModel(models[14],_testData[34], false);
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
                 ((IStringSingleTypetext)this).DbConnectionDynQuerySelectModelBatch(connection, 12, query1, 67, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatStringtextE0M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatStringtextE0M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatStringtextE0M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatStringtextE0M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatStringtextE0M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatStringtextE0M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatStringtextE0M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatStringtextE0M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatStringtextE0M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatStringtextE0M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatStringtextE0M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatStringtextE0M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatStringtextE0M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatStringtextE0M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatStringtextE0M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatStringtextE0M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatStringtextE0M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatStringtextE0M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatStringtextE0M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatStringtextE0M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatStringtextE0M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatStringtextE0M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatStringtextE0M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatStringtextE0M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatStringtextE0M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatStringtextE0M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatStringtextE0M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatStringtextE0M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatStringtextE0M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatStringtextE0M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatStringtextE0M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatStringtextE0M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatStringtextE0M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatStringtextE0M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatStringtextE0M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatStringtextE0M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatStringtextE0M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatStringtextE0M.AssertModel(secondItems2[18],_testData[34], false);
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
                foreach(var batchResult in await ((IStringSingleTypetext)this).DbConnectionSTSelectModelBatchAsync(connection, 120, 155))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        StringtextE0M.AssertModel(models[0],_testData[33], false);
                        StringtextE0M.AssertModel(models[1],_testData[34], false);
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
                foreach(var batchResult in  ((IStringSingleTypetext)this).DbConnectionSTSelectModelBatch(connection, 20, 135))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        StringtextE0M.AssertModel(models[0],_testData[6], false);
                        StringtextE0M.AssertModel(models[1],_testData[7], false);
                        StringtextE0M.AssertModel(models[2],_testData[8], false);
                        StringtextE0M.AssertModel(models[3],_testData[9], false);
                        StringtextE0M.AssertModel(models[4],_testData[10], false);
                        StringtextE0M.AssertModel(models[5],_testData[11], false);
                        StringtextE0M.AssertModel(models[6],_testData[12], false);
                        StringtextE0M.AssertModel(models[7],_testData[13], false);
                        StringtextE0M.AssertModel(models[8],_testData[14], false);
                        StringtextE0M.AssertModel(models[9],_testData[15], false);
                        StringtextE0M.AssertModel(models[10],_testData[16], false);
                        StringtextE0M.AssertModel(models[11],_testData[17], false);
                        StringtextE0M.AssertModel(models[12],_testData[18], false);
                        StringtextE0M.AssertModel(models[13],_testData[19], false);
                        StringtextE0M.AssertModel(models[14],_testData[20], false);
                        StringtextE0M.AssertModel(models[15],_testData[21], false);
                        StringtextE0M.AssertModel(models[16],_testData[22], false);
                        StringtextE0M.AssertModel(models[17],_testData[23], false);
                        StringtextE0M.AssertModel(models[18],_testData[24], false);
                        StringtextE0M.AssertModel(models[19],_testData[25], false);
                        StringtextE0M.AssertModel(models[20],_testData[26], false);
                        StringtextE0M.AssertModel(models[21],_testData[27], false);
                        StringtextE0M.AssertModel(models[22],_testData[28], false);
                        StringtextE0M.AssertModel(models[23],_testData[29], false);
                        StringtextE0M.AssertModel(models[24],_testData[30], false);
                        StringtextE0M.AssertModel(models[25],_testData[31], false);
                        StringtextE0M.AssertModel(models[26],_testData[32], false);
                        StringtextE0M.AssertModel(models[27],_testData[33], false);
                        StringtextE0M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        StringtextE0M.AssertModel(models[0],_testData[29], false);
                        StringtextE0M.AssertModel(models[1],_testData[30], false);
                        StringtextE0M.AssertModel(models[2],_testData[31], false);
                        StringtextE0M.AssertModel(models[3],_testData[32], false);
                        StringtextE0M.AssertModel(models[4],_testData[33], false);
                        StringtextE0M.AssertModel(models[5],_testData[34], false);
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
                ((IStringSingleTypetext)this).SetDbConnectionSelectModelParametrs(cmd, 28);
                var models = await ((IStringSingleTypetext)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(27));

                StringtextE0M.AssertModel(models[0],_testData[8], false);
                StringtextE0M.AssertModel(models[1],_testData[9], false);
                StringtextE0M.AssertModel(models[2],_testData[10], false);
                StringtextE0M.AssertModel(models[3],_testData[11], false);
                StringtextE0M.AssertModel(models[4],_testData[12], false);
                StringtextE0M.AssertModel(models[5],_testData[13], false);
                StringtextE0M.AssertModel(models[6],_testData[14], false);
                StringtextE0M.AssertModel(models[7],_testData[15], false);
                StringtextE0M.AssertModel(models[8],_testData[16], false);
                StringtextE0M.AssertModel(models[9],_testData[17], false);
                StringtextE0M.AssertModel(models[10],_testData[18], false);
                StringtextE0M.AssertModel(models[11],_testData[19], false);
                StringtextE0M.AssertModel(models[12],_testData[20], false);
                StringtextE0M.AssertModel(models[13],_testData[21], false);
                StringtextE0M.AssertModel(models[14],_testData[22], false);
                StringtextE0M.AssertModel(models[15],_testData[23], false);
                StringtextE0M.AssertModel(models[16],_testData[24], false);
                StringtextE0M.AssertModel(models[17],_testData[25], false);
                StringtextE0M.AssertModel(models[18],_testData[26], false);
                StringtextE0M.AssertModel(models[19],_testData[27], false);
                StringtextE0M.AssertModel(models[20],_testData[28], false);
                StringtextE0M.AssertModel(models[21],_testData[29], false);
                StringtextE0M.AssertModel(models[22],_testData[30], false);
                StringtextE0M.AssertModel(models[23],_testData[31], false);
                StringtextE0M.AssertModel(models[24],_testData[32], false);
                StringtextE0M.AssertModel(models[25],_testData[33], false);
                StringtextE0M.AssertModel(models[26],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IStringSingleTypetext)this).CreateDbConnectionSelectModelCommand(connection);
                ((IStringSingleTypetext)this).SetDbConnectionSelectModelParametrs(cmd, 147);
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
                Assert.That((System.Int32)model[0], Is.EqualTo((3)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("ksfrpcldgytxheqqfr")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("qvihsoyndghbklbpddqach")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("oyvygbnrcaxameqbndgnmp")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("jtqyahapyvqacnjvqmqnovpur")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("xwunvjbfumchsjmsqhcdtetcdjtpv")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("lirvso")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("ddn")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("pnstauubyvurpb")));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("suur")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("a")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("cq")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("cwbpsiqmp")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("rxhrfmlabrci")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("pspbeockyl")));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("bdfbdoxknpojcktdhda")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("wnycamkrjnwmkupywhpludbomhw")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("hwcelgg")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("xknmmpgapmqwgrydkatakfv")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("eomuqxyqotmvdfrsbobvqysnxuqdm")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("uesvljkoewmaxxaygmvfg")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("e")));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("wuxpseuslsxrliurlsgbv")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((45)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("jfrynmobsxsrepxc")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("suukuvipgurmsqd")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("cgastkitksdfakpw")));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("enbikggtutnoxkuuvdibckvi")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("pvubyqxyctayvjfbrywobmksddibg")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("jdptiefpvfmmiyrbtuebpqkqgp")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("tlkghooytxcxtmvi")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("iihwleuxsyhqntoirlwymitmq")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("uyictifmaxugtptvotru")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("toksaowronrbhuifruwbt")));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("wpyioeeofvjgaivnoxksbgqagx")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("msmarenouf")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("bugdpwkvj")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("luqyceyewoqbafhettffjnl")));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((78)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("coonssowiusmelxxusekwub")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((83)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("xqbcuogougqglqgjolctoouoodxqa")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("exbmxmdllnkbhs")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("p")));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("imyyjo")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("cothhoaxlxrjidntouddcwdiy")));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("kikeqjepdpiqj")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("yqdsoacaekt")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("myupwtguaomduokroiwogchfmpoo")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("nf")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("pkgpnrumerwsspnrxu")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("lxreouloupvmixc")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("okxwlyukindcoduxnemd")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("obg")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("lwnweqobhbdpgyvhmhicaia")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("bhhegtkhjvtoes")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("elyrn")));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("wnnalqcevmgcofequ")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("m")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("ptkiwmhochsqeenul")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("xgulkomgjxbl")));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("hxklfhomjupyhqlqsw")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("votsh")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("vhqmpytaqvegyxrfhlgnqgn")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("bvciakgoswvyburccenbgabmkg")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("yy")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((70)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("ymsee")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("trojgdcyncislf")));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("jlgsngnyjnaoqhofdn")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((160)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("ihnltefsfcxlsyxfimj")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((76)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("srt")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("iopjttpj")));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((161)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("susudpwsdmiapuynkqxwrdqu")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("gulwuxrtmlfdlupgkuxrgupbl")));

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
                Assert.That((System.Int32)model[0], Is.EqualTo((3)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("ksfrpcldgytxheqqfr")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("qvihsoyndghbklbpddqach")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("oyvygbnrcaxameqbndgnmp")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("jtqyahapyvqacnjvqmqnovpur")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("xwunvjbfumchsjmsqhcdtetcdjtpv")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("lirvso")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("ddn")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("pnstauubyvurpb")));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("suur")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("a")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("cq")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("cwbpsiqmp")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("rxhrfmlabrci")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("pspbeockyl")));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("bdfbdoxknpojcktdhda")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("wnycamkrjnwmkupywhpludbomhw")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("hwcelgg")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("xknmmpgapmqwgrydkatakfv")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("eomuqxyqotmvdfrsbobvqysnxuqdm")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("uesvljkoewmaxxaygmvfg")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("e")));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("wuxpseuslsxrliurlsgbv")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((45)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("jfrynmobsxsrepxc")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("suukuvipgurmsqd")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("cgastkitksdfakpw")));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("enbikggtutnoxkuuvdibckvi")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("pvubyqxyctayvjfbrywobmksddibg")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("jdptiefpvfmmiyrbtuebpqkqgp")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("tlkghooytxcxtmvi")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("iihwleuxsyhqntoirlwymitmq")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("uyictifmaxugtptvotru")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("toksaowronrbhuifruwbt")));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("wpyioeeofvjgaivnoxksbgqagx")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("msmarenouf")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("bugdpwkvj")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("luqyceyewoqbafhettffjnl")));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((78)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("coonssowiusmelxxusekwub")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((83)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("xqbcuogougqglqgjolctoouoodxqa")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("exbmxmdllnkbhs")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("p")));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("imyyjo")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("cothhoaxlxrjidntouddcwdiy")));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("kikeqjepdpiqj")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("yqdsoacaekt")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("myupwtguaomduokroiwogchfmpoo")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("nf")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("pkgpnrumerwsspnrxu")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("lxreouloupvmixc")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("okxwlyukindcoduxnemd")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("obg")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("lwnweqobhbdpgyvhmhicaia")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("bhhegtkhjvtoes")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("elyrn")));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("wnnalqcevmgcofequ")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("m")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("ptkiwmhochsqeenul")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("xgulkomgjxbl")));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("hxklfhomjupyhqlqsw")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("votsh")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("vhqmpytaqvegyxrfhlgnqgn")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("bvciakgoswvyburccenbgabmkg")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("yy")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((70)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("ymsee")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("trojgdcyncislf")));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("jlgsngnyjnaoqhofdn")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((160)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("ihnltefsfcxlsyxfimj")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((76)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("srt")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("iopjttpj")));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((161)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("susudpwsdmiapuynkqxwrdqu")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("gulwuxrtmlfdlupgkuxrgupbl")));

            }
        }

#endregion

    }
}

