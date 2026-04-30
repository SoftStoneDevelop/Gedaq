

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
    Id = 8,
    Value = "hd",
    ModelInner = null,
    NullableValue = null,
},
            new Stringtext0M
{
    Id = 11,
    Value = "kcutqbdslephojtqugq",
    ModelInner = new Stringtext0MI
{
    Id = 4,
    Value = "ryjkxfevpgbajbqgm",
    NullableValue = null,
},
    NullableValue = "iulvvq",
},
            new Stringtext0M
{
    Id = 12,
    Value = "swiiotplbphsltog",
    ModelInner = null,
    NullableValue = "fkcnwyiqhsxfqtpawgjpqn",
},
            new Stringtext0M
{
    Id = 20,
    Value = "qsleyeaqjpiwfealtq",
    ModelInner = new Stringtext0MI
{
    Id = 12,
    Value = "bvynilelqdlkxa",
    NullableValue = "xv",
},
    NullableValue = null,
},
            new Stringtext0M
{
    Id = 26,
    Value = "mxxnxyc",
    ModelInner = null,
    NullableValue = "cyje",
},
            new Stringtext0M
{
    Id = 31,
    Value = "aegdlwdojjowyynrvnse",
    ModelInner = new Stringtext0MI
{
    Id = 19,
    Value = "ggwhdkeyvanyao",
    NullableValue = null,
},
    NullableValue = null,
},
            new Stringtext0M
{
    Id = 35,
    Value = "qomepowwkoorekmwcycrq",
    ModelInner = null,
    NullableValue = null,
},
            new Stringtext0M
{
    Id = 38,
    Value = "jptmgcpmcsuidgvwqjeyv",
    ModelInner = new Stringtext0MI
{
    Id = 21,
    Value = "nlvmvbh",
    NullableValue = "whaxqxdiv",
},
    NullableValue = "pgvsyptbbxcjrtd",
},
            new Stringtext0M
{
    Id = 40,
    Value = "qjqcqruxtxwobewiwdyklove",
    ModelInner = null,
    NullableValue = "gpkyvkinlpvcodclnmhcdxpfeimy",
},
            new Stringtext0M
{
    Id = 46,
    Value = "xjbjnukpleeuyciex",
    ModelInner = new Stringtext0MI
{
    Id = 29,
    Value = "a",
    NullableValue = null,
},
    NullableValue = "njmnypf",
},
            new Stringtext0M
{
    Id = 51,
    Value = "yrdhvilxmiawxpjexsbcnholp",
    ModelInner = null,
    NullableValue = null,
},
            new Stringtext0M
{
    Id = 52,
    Value = "bljufcnvcq",
    ModelInner = new Stringtext0MI
{
    Id = 31,
    Value = "vjvqockkxbnintwvqia",
    NullableValue = "kmkbkvfpowgbjnhorllxt",
},
    NullableValue = "fiiaybxsehtgmot",
},
            new Stringtext0M
{
    Id = 55,
    Value = "njlomynmbraht",
    ModelInner = null,
    NullableValue = null,
},
            new Stringtext0M
{
    Id = 56,
    Value = "whjvsbibcttlqnwxkvwcnvbkrtccj",
    ModelInner = new Stringtext0MI
{
    Id = 34,
    Value = "wdijhplstswxu",
    NullableValue = null,
},
    NullableValue = null,
},
            new Stringtext0M
{
    Id = 62,
    Value = "uloioyqjalrvfpbcqkcqrxoyxbgiw",
    ModelInner = null,
    NullableValue = "fhxygihkhhjujjdey",
},
            new Stringtext0M
{
    Id = 67,
    Value = "tmhplvedp",
    ModelInner = new Stringtext0MI
{
    Id = 42,
    Value = "uhkptpdqlr",
    NullableValue = null,
},
    NullableValue = null,
},
            new Stringtext0M
{
    Id = 70,
    Value = "d",
    ModelInner = null,
    NullableValue = "mlrewjsnndqmsscuygfwqakubm",
},
            new Stringtext0M
{
    Id = 76,
    Value = "eye",
    ModelInner = new Stringtext0MI
{
    Id = 44,
    Value = "vuamuhydcpbotgbmwkacrhuwnmnv",
    NullableValue = "rpfwgeqtlhbp",
},
    NullableValue = "f",
},
            new Stringtext0M
{
    Id = 84,
    Value = "vvdoochknei",
    ModelInner = null,
    NullableValue = null,
},
            new Stringtext0M
{
    Id = 88,
    Value = "mlqsjuu",
    ModelInner = new Stringtext0MI
{
    Id = 50,
    Value = "jnuwcqccadkivgxtjjwngxv",
    NullableValue = "uctbanqxpr",
},
    NullableValue = "jqqwymdfknglnflbvhn",
},
            new Stringtext0M
{
    Id = 90,
    Value = "oalvpvxg",
    ModelInner = null,
    NullableValue = "rcusgtpmrevsktmxfbyskygpqqxhf",
},
            new Stringtext0M
{
    Id = 98,
    Value = "vaeoidr",
    ModelInner = new Stringtext0MI
{
    Id = 59,
    Value = "trgvcxkp",
    NullableValue = "nftrrckukaahibtisexpkjp",
},
    NullableValue = "mhvqnrilmpxvcwlancvxyejaqekk",
},
            new Stringtext0M
{
    Id = 103,
    Value = "cwaaavthu",
    ModelInner = null,
    NullableValue = "krkwvcqhxtvssferjhbjd",
},
            new Stringtext0M
{
    Id = 109,
    Value = "ropepihrmclyakgetbol",
    ModelInner = new Stringtext0MI
{
    Id = 68,
    Value = "yklqllsrieybopblipttdjmpi",
    NullableValue = null,
},
    NullableValue = null,
},
            new Stringtext0M
{
    Id = 112,
    Value = "nsskwtnfitx",
    ModelInner = null,
    NullableValue = "sxikooko",
},
            new Stringtext0M
{
    Id = 120,
    Value = "dhlmjybcnqtoyoibseoybj",
    ModelInner = new Stringtext0MI
{
    Id = 69,
    Value = "gmftt",
    NullableValue = "suegcfckjosjbufd",
},
    NullableValue = null,
},
            new Stringtext0M
{
    Id = 128,
    Value = "bbuoirb",
    ModelInner = null,
    NullableValue = "cnjjmxdl",
},
            new Stringtext0M
{
    Id = 134,
    Value = "xpxaxkk",
    ModelInner = new Stringtext0MI
{
    Id = 75,
    Value = "gfu",
    NullableValue = "yqwjubpknnxhadmfc",
},
    NullableValue = null,
},
            new Stringtext0M
{
    Id = 143,
    Value = "fpfofmtnirdrkbgwjidinoingbcs",
    ModelInner = null,
    NullableValue = "p",
},
            new Stringtext0M
{
    Id = 147,
    Value = "chprpmvbduyrllnsmcqpslqejmkv",
    ModelInner = new Stringtext0MI
{
    Id = 79,
    Value = "psukcqkjlagjsikgjflw",
    NullableValue = "nmakcvmytc",
},
    NullableValue = "jimv",
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
                parametr1.Value = 62;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 84;
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
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
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
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatStringtext0M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatStringtext0M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatStringtext0M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatStringtext0M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatStringtext0M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatStringtext0M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatStringtext0M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatStringtext0M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatStringtext0M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatStringtext0M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatStringtext0M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatStringtext0M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatStringtext0M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatStringtext0M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatStringtext0M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatStringtext0M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatStringtext0M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatStringtext0M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatStringtext0M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatStringtext0M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatStringtext0M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatStringtext0M.AssertModel(secondItems2[10],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 134;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 8;
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
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatStringtext0M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatStringtext0M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatStringtext0M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatStringtext0M.AssertModel(firstItems2[1],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatStringtext0M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatStringtext0M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatStringtext0M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatStringtext0M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatStringtext0M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatStringtext0M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatStringtext0M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatStringtext0M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatStringtext0M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatStringtext0M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatStringtext0M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatStringtext0M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatStringtext0M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatStringtext0M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatStringtext0M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatStringtext0M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatStringtext0M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatStringtext0M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatStringtext0M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatStringtext0M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatStringtext0M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatStringtext0M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatStringtext0M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatStringtext0M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatStringtext0M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatStringtext0M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatStringtext0M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatStringtext0M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatStringtext0M.AssertModel(secondItems1[28],_testData[29], false);
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
                parametr1.Value = 88;
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
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatStringtext0M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatStringtext0M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatStringtext0M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatStringtext0M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatStringtext0M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatStringtext0M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatStringtext0M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatStringtext0M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatStringtext0M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatStringtext0M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatStringtext0M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatStringtext0M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatStringtext0M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatStringtext0M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatStringtext0M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatStringtext0M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatStringtext0M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatStringtext0M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatStringtext0M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatStringtext0M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatStringtext0M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatStringtext0M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatStringtext0M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatStringtext0M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatStringtext0M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatStringtext0M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatStringtext0M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatStringtext0M.AssertModel(secondItems2[13],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 31;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 84;
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
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatStringtext0M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatStringtext0M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatStringtext0M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatStringtext0M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatStringtext0M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatStringtext0M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatStringtext0M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatStringtext0M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatStringtext0M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatStringtext0M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatStringtext0M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatStringtext0M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatStringtext0M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatStringtext0M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatStringtext0M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatStringtext0M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatStringtext0M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatStringtext0M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatStringtext0M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatStringtext0M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatStringtext0M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatStringtext0M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatStringtext0M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatStringtext0M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatStringtext0M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatStringtext0M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatStringtext0M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatStringtext0M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatStringtext0M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatStringtext0M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatStringtext0M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatStringtext0M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatStringtext0M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatStringtext0M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatStringtext0M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatStringtext0M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatStringtext0M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatStringtext0M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatStringtext0M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatStringtext0M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatStringtext0M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatStringtext0M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatStringtext0M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatStringtext0M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatStringtext0M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatStringtext0M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatStringtext0M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatStringtext0M.AssertModel(firstItems2[23],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatStringtext0M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatStringtext0M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatStringtext0M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatStringtext0M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatStringtext0M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatStringtext0M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatStringtext0M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatStringtext0M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatStringtext0M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatStringtext0M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatStringtext0M.AssertModel(secondItems1[10],_testData[29], false);
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
                parametr1.Value = 109;
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
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatStringtext0M.AssertModel(models[0],_testData[15], false);
                        FlatStringtext0M.AssertModel(models[1],_testData[16], false);
                        FlatStringtext0M.AssertModel(models[2],_testData[17], false);
                        FlatStringtext0M.AssertModel(models[3],_testData[18], false);
                        FlatStringtext0M.AssertModel(models[4],_testData[19], false);
                        FlatStringtext0M.AssertModel(models[5],_testData[20], false);
                        FlatStringtext0M.AssertModel(models[6],_testData[21], false);
                        FlatStringtext0M.AssertModel(models[7],_testData[22], false);
                        FlatStringtext0M.AssertModel(models[8],_testData[23], false);
                        FlatStringtext0M.AssertModel(models[9],_testData[24], false);
                        FlatStringtext0M.AssertModel(models[10],_testData[25], false);
                        FlatStringtext0M.AssertModel(models[11],_testData[26], false);
                        FlatStringtext0M.AssertModel(models[12],_testData[27], false);
                        FlatStringtext0M.AssertModel(models[13],_testData[28], false);
                        FlatStringtext0M.AssertModel(models[14],_testData[29], false);
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
                parametr1.Value = 35;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 128;
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
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatStringtext0M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatStringtext0M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatStringtext0M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatStringtext0M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatStringtext0M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatStringtext0M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatStringtext0M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatStringtext0M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatStringtext0M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatStringtext0M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatStringtext0M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatStringtext0M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatStringtext0M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatStringtext0M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatStringtext0M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatStringtext0M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatStringtext0M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatStringtext0M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatStringtext0M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatStringtext0M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatStringtext0M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatStringtext0M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatStringtext0M.AssertModel(firstItems1[22],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatStringtext0M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatStringtext0M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatStringtext0M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatStringtext0M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatStringtext0M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatStringtext0M.AssertModel(secondItems2[2],_testData[29], false);
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
                parametr1.Value = 11;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 70;
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
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatStringtext0M.AssertModel(models[0],_testData[2], false);
                        FlatStringtext0M.AssertModel(models[1],_testData[3], false);
                        FlatStringtext0M.AssertModel(models[2],_testData[4], false);
                        FlatStringtext0M.AssertModel(models[3],_testData[5], false);
                        FlatStringtext0M.AssertModel(models[4],_testData[6], false);
                        FlatStringtext0M.AssertModel(models[5],_testData[7], false);
                        FlatStringtext0M.AssertModel(models[6],_testData[8], false);
                        FlatStringtext0M.AssertModel(models[7],_testData[9], false);
                        FlatStringtext0M.AssertModel(models[8],_testData[10], false);
                        FlatStringtext0M.AssertModel(models[9],_testData[11], false);
                        FlatStringtext0M.AssertModel(models[10],_testData[12], false);
                        FlatStringtext0M.AssertModel(models[11],_testData[13], false);
                        FlatStringtext0M.AssertModel(models[12],_testData[14], false);
                        FlatStringtext0M.AssertModel(models[13],_testData[15], false);
                        FlatStringtext0M.AssertModel(models[14],_testData[16], false);
                        FlatStringtext0M.AssertModel(models[15],_testData[17], false);
                        FlatStringtext0M.AssertModel(models[16],_testData[18], false);
                        FlatStringtext0M.AssertModel(models[17],_testData[19], false);
                        FlatStringtext0M.AssertModel(models[18],_testData[20], false);
                        FlatStringtext0M.AssertModel(models[19],_testData[21], false);
                        FlatStringtext0M.AssertModel(models[20],_testData[22], false);
                        FlatStringtext0M.AssertModel(models[21],_testData[23], false);
                        FlatStringtext0M.AssertModel(models[22],_testData[24], false);
                        FlatStringtext0M.AssertModel(models[23],_testData[25], false);
                        FlatStringtext0M.AssertModel(models[24],_testData[26], false);
                        FlatStringtext0M.AssertModel(models[25],_testData[27], false);
                        FlatStringtext0M.AssertModel(models[26],_testData[28], false);
                        FlatStringtext0M.AssertModel(models[27],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                parametr1.Value = 52;
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
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                        FlatStringtext0M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatStringtext0M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatStringtext0M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatStringtext0M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatStringtext0M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatStringtext0M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatStringtext0M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatStringtext0M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatStringtext0M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatStringtext0M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatStringtext0M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatStringtext0M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatStringtext0M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatStringtext0M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatStringtext0M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatStringtext0M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatStringtext0M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatStringtext0M.AssertModel(firstItems1[17],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatStringtext0M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatStringtext0M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatStringtext0M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatStringtext0M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatStringtext0M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatStringtext0M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatStringtext0M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatStringtext0M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatStringtext0M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatStringtext0M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatStringtext0M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatStringtext0M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatStringtext0M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatStringtext0M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatStringtext0M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatStringtext0M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatStringtext0M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatStringtext0M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatStringtext0M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatStringtext0M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatStringtext0M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatStringtext0M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatStringtext0M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatStringtext0M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatStringtext0M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatStringtext0M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatStringtext0M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatStringtext0M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatStringtext0M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatStringtext0M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatStringtext0M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatStringtext0M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatStringtext0M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatStringtext0M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatStringtext0M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatStringtext0M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatStringtext0M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatStringtext0M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatStringtext0M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatStringtext0M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatStringtext0M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatStringtext0M.AssertModel(secondItems2[20],_testData[29], false);
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
                parametr1.Value = 31;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 46;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IStringSingleTypetext)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        Stringtext0M.AssertModel(models[0],_testData[10], false);
                        Stringtext0M.AssertModel(models[1],_testData[11], false);
                        Stringtext0M.AssertModel(models[2],_testData[12], false);
                        Stringtext0M.AssertModel(models[3],_testData[13], false);
                        Stringtext0M.AssertModel(models[4],_testData[14], false);
                        Stringtext0M.AssertModel(models[5],_testData[15], false);
                        Stringtext0M.AssertModel(models[6],_testData[16], false);
                        Stringtext0M.AssertModel(models[7],_testData[17], false);
                        Stringtext0M.AssertModel(models[8],_testData[18], false);
                        Stringtext0M.AssertModel(models[9],_testData[19], false);
                        Stringtext0M.AssertModel(models[10],_testData[20], false);
                        Stringtext0M.AssertModel(models[11],_testData[21], false);
                        Stringtext0M.AssertModel(models[12],_testData[22], false);
                        Stringtext0M.AssertModel(models[13],_testData[23], false);
                        Stringtext0M.AssertModel(models[14],_testData[24], false);
                        Stringtext0M.AssertModel(models[15],_testData[25], false);
                        Stringtext0M.AssertModel(models[16],_testData[26], false);
                        Stringtext0M.AssertModel(models[17],_testData[27], false);
                        Stringtext0M.AssertModel(models[18],_testData[28], false);
                        Stringtext0M.AssertModel(models[19],_testData[29], false);
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
                parametr1.Value = 52;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 76;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IStringSingleTypetext)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
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
                        Assert.That(models, Has.Count.EqualTo(12));

                        Stringtext0M.AssertModel(models[0],_testData[18], false);
                        Stringtext0M.AssertModel(models[1],_testData[19], false);
                        Stringtext0M.AssertModel(models[2],_testData[20], false);
                        Stringtext0M.AssertModel(models[3],_testData[21], false);
                        Stringtext0M.AssertModel(models[4],_testData[22], false);
                        Stringtext0M.AssertModel(models[5],_testData[23], false);
                        Stringtext0M.AssertModel(models[6],_testData[24], false);
                        Stringtext0M.AssertModel(models[7],_testData[25], false);
                        Stringtext0M.AssertModel(models[8],_testData[26], false);
                        Stringtext0M.AssertModel(models[9],_testData[27], false);
                        Stringtext0M.AssertModel(models[10],_testData[28], false);
                        Stringtext0M.AssertModel(models[11],_testData[29], false);
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
                await ((IStringSingleTypetext)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 98, query1, 70, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                await ((IStringSingleTypetext)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 51, query1, 8, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatStringtext0M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatStringtext0M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatStringtext0M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatStringtext0M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatStringtext0M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatStringtext0M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatStringtext0M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatStringtext0M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatStringtext0M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatStringtext0M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatStringtext0M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatStringtext0M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatStringtext0M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatStringtext0M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatStringtext0M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatStringtext0M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatStringtext0M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatStringtext0M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatStringtext0M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatStringtext0M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatStringtext0M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatStringtext0M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatStringtext0M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatStringtext0M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatStringtext0M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatStringtext0M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatStringtext0M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatStringtext0M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatStringtext0M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatStringtext0M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatStringtext0M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatStringtext0M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatStringtext0M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatStringtext0M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatStringtext0M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatStringtext0M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatStringtext0M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatStringtext0M.AssertModel(firstItems2[18],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatStringtext0M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatStringtext0M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatStringtext0M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatStringtext0M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatStringtext0M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatStringtext0M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatStringtext0M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatStringtext0M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatStringtext0M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatStringtext0M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatStringtext0M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatStringtext0M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatStringtext0M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatStringtext0M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatStringtext0M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatStringtext0M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatStringtext0M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatStringtext0M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatStringtext0M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatStringtext0M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatStringtext0M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatStringtext0M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatStringtext0M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatStringtext0M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatStringtext0M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatStringtext0M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatStringtext0M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatStringtext0M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatStringtext0M.AssertModel(secondItems1[28],_testData[29], false);
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
                 ((IStringSingleTypetext)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 38, query1, 128, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatStringtext0M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatStringtext0M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatStringtext0M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatStringtext0M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatStringtext0M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatStringtext0M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatStringtext0M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatStringtext0M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatStringtext0M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatStringtext0M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatStringtext0M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatStringtext0M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatStringtext0M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatStringtext0M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatStringtext0M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatStringtext0M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatStringtext0M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatStringtext0M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatStringtext0M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatStringtext0M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatStringtext0M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatStringtext0M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatStringtext0M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatStringtext0M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatStringtext0M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatStringtext0M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatStringtext0M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatStringtext0M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatStringtext0M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatStringtext0M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatStringtext0M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatStringtext0M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatStringtext0M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatStringtext0M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatStringtext0M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatStringtext0M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatStringtext0M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatStringtext0M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatStringtext0M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatStringtext0M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatStringtext0M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatStringtext0M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatStringtext0M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatStringtext0M.AssertModel(firstItems2[21],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatStringtext0M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatStringtext0M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatStringtext0M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatStringtext0M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatStringtext0M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatStringtext0M.AssertModel(secondItems2[2],_testData[29], false);
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
                 ((IStringSingleTypetext)this).DbConnectionMMDynQuerySelectModelBatch(connection, 51, query1, 88, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatStringtext0M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatStringtext0M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatStringtext0M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatStringtext0M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatStringtext0M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatStringtext0M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatStringtext0M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatStringtext0M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatStringtext0M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatStringtext0M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatStringtext0M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatStringtext0M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatStringtext0M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatStringtext0M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatStringtext0M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatStringtext0M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatStringtext0M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatStringtext0M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatStringtext0M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatStringtext0M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatStringtext0M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatStringtext0M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatStringtext0M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatStringtext0M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatStringtext0M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatStringtext0M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatStringtext0M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatStringtext0M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatStringtext0M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatStringtext0M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatStringtext0M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatStringtext0M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatStringtext0M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatStringtext0M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatStringtext0M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatStringtext0M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatStringtext0M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatStringtext0M.AssertModel(firstItems2[18],_testData[29], false);
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
                foreach(var batchResult in await ((IStringSingleTypetext)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 70, query1, 90, query2))
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
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatStringtext0M.AssertModel(models[0],_testData[21], false);
                        FlatStringtext0M.AssertModel(models[1],_testData[22], false);
                        FlatStringtext0M.AssertModel(models[2],_testData[23], false);
                        FlatStringtext0M.AssertModel(models[3],_testData[24], false);
                        FlatStringtext0M.AssertModel(models[4],_testData[25], false);
                        FlatStringtext0M.AssertModel(models[5],_testData[26], false);
                        FlatStringtext0M.AssertModel(models[6],_testData[27], false);
                        FlatStringtext0M.AssertModel(models[7],_testData[28], false);
                        FlatStringtext0M.AssertModel(models[8],_testData[29], false);
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
                await ((IStringSingleTypetext)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 38, query1, 46, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatStringtext0M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatStringtext0M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatStringtext0M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatStringtext0M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatStringtext0M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatStringtext0M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatStringtext0M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatStringtext0M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatStringtext0M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatStringtext0M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatStringtext0M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatStringtext0M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatStringtext0M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatStringtext0M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatStringtext0M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatStringtext0M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatStringtext0M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatStringtext0M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatStringtext0M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatStringtext0M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatStringtext0M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatStringtext0M.AssertModel(firstItems1[21],_testData[29], false);
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
                foreach(var batchResult in  ((IStringSingleTypetext)this).DbConnectionSTDynQuerySelectModelBatch(connection, 51, query1, 31, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatStringtext0M.AssertModel(models[0],_testData[6], false);
                        FlatStringtext0M.AssertModel(models[1],_testData[7], false);
                        FlatStringtext0M.AssertModel(models[2],_testData[8], false);
                        FlatStringtext0M.AssertModel(models[3],_testData[9], false);
                        FlatStringtext0M.AssertModel(models[4],_testData[10], false);
                        FlatStringtext0M.AssertModel(models[5],_testData[11], false);
                        FlatStringtext0M.AssertModel(models[6],_testData[12], false);
                        FlatStringtext0M.AssertModel(models[7],_testData[13], false);
                        FlatStringtext0M.AssertModel(models[8],_testData[14], false);
                        FlatStringtext0M.AssertModel(models[9],_testData[15], false);
                        FlatStringtext0M.AssertModel(models[10],_testData[16], false);
                        FlatStringtext0M.AssertModel(models[11],_testData[17], false);
                        FlatStringtext0M.AssertModel(models[12],_testData[18], false);
                        FlatStringtext0M.AssertModel(models[13],_testData[19], false);
                        FlatStringtext0M.AssertModel(models[14],_testData[20], false);
                        FlatStringtext0M.AssertModel(models[15],_testData[21], false);
                        FlatStringtext0M.AssertModel(models[16],_testData[22], false);
                        FlatStringtext0M.AssertModel(models[17],_testData[23], false);
                        FlatStringtext0M.AssertModel(models[18],_testData[24], false);
                        FlatStringtext0M.AssertModel(models[19],_testData[25], false);
                        FlatStringtext0M.AssertModel(models[20],_testData[26], false);
                        FlatStringtext0M.AssertModel(models[21],_testData[27], false);
                        FlatStringtext0M.AssertModel(models[22],_testData[28], false);
                        FlatStringtext0M.AssertModel(models[23],_testData[29], false);
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
                 ((IStringSingleTypetext)this).DbConnectionDynQuerySelectModelBatch(connection, 31, query1, 109, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatStringtext0M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatStringtext0M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatStringtext0M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatStringtext0M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatStringtext0M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatStringtext0M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatStringtext0M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatStringtext0M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatStringtext0M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatStringtext0M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatStringtext0M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatStringtext0M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatStringtext0M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatStringtext0M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatStringtext0M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatStringtext0M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatStringtext0M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatStringtext0M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatStringtext0M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatStringtext0M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatStringtext0M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatStringtext0M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatStringtext0M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatStringtext0M.AssertModel(firstItems1[23],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatStringtext0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatStringtext0M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatStringtext0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatStringtext0M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatStringtext0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatStringtext0M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatStringtext0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatStringtext0M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatStringtext0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatStringtext0M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatStringtext0M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatStringtext0M.AssertModel(secondItems2[5],_testData[29], false);
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
                foreach(var batchResult in await ((IStringSingleTypetext)this).DbConnectionSTSelectModelBatchAsync(connection, 26, 56))
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
                        Assert.That(models, Has.Count.EqualTo(16));

                        Stringtext0M.AssertModel(models[0],_testData[14], false);
                        Stringtext0M.AssertModel(models[1],_testData[15], false);
                        Stringtext0M.AssertModel(models[2],_testData[16], false);
                        Stringtext0M.AssertModel(models[3],_testData[17], false);
                        Stringtext0M.AssertModel(models[4],_testData[18], false);
                        Stringtext0M.AssertModel(models[5],_testData[19], false);
                        Stringtext0M.AssertModel(models[6],_testData[20], false);
                        Stringtext0M.AssertModel(models[7],_testData[21], false);
                        Stringtext0M.AssertModel(models[8],_testData[22], false);
                        Stringtext0M.AssertModel(models[9],_testData[23], false);
                        Stringtext0M.AssertModel(models[10],_testData[24], false);
                        Stringtext0M.AssertModel(models[11],_testData[25], false);
                        Stringtext0M.AssertModel(models[12],_testData[26], false);
                        Stringtext0M.AssertModel(models[13],_testData[27], false);
                        Stringtext0M.AssertModel(models[14],_testData[28], false);
                        Stringtext0M.AssertModel(models[15],_testData[29], false);
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
                foreach(var batchResult in  ((IStringSingleTypetext)this).DbConnectionSTSelectModelBatch(connection, 84, 120))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

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
        public async Task DbConnectionCommandSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                await using var cmd = await ((IStringSingleTypetext)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IStringSingleTypetext)this).SetDbConnectionSelectModelParametrs(cmd, 38);
                var models = await ((IStringSingleTypetext)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(22));
Stringtext0M.AssertModel(models[0],_testData[8], false);Stringtext0M.AssertModel(models[1],_testData[9], false);Stringtext0M.AssertModel(models[2],_testData[10], false);Stringtext0M.AssertModel(models[3],_testData[11], false);Stringtext0M.AssertModel(models[4],_testData[12], false);Stringtext0M.AssertModel(models[5],_testData[13], false);Stringtext0M.AssertModel(models[6],_testData[14], false);Stringtext0M.AssertModel(models[7],_testData[15], false);Stringtext0M.AssertModel(models[8],_testData[16], false);Stringtext0M.AssertModel(models[9],_testData[17], false);Stringtext0M.AssertModel(models[10],_testData[18], false);Stringtext0M.AssertModel(models[11],_testData[19], false);Stringtext0M.AssertModel(models[12],_testData[20], false);Stringtext0M.AssertModel(models[13],_testData[21], false);Stringtext0M.AssertModel(models[14],_testData[22], false);Stringtext0M.AssertModel(models[15],_testData[23], false);Stringtext0M.AssertModel(models[16],_testData[24], false);Stringtext0M.AssertModel(models[17],_testData[25], false);Stringtext0M.AssertModel(models[18],_testData[26], false);Stringtext0M.AssertModel(models[19],_testData[27], false);Stringtext0M.AssertModel(models[20],_testData[28], false);Stringtext0M.AssertModel(models[21],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IStringSingleTypetext)this).CreateDbConnectionSelectModelCommand(connection);
                ((IStringSingleTypetext)this).SetDbConnectionSelectModelParametrs(cmd, 52);
                var models =  ((IStringSingleTypetext)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(18));
Stringtext0M.AssertModel(models[0],_testData[12], false);Stringtext0M.AssertModel(models[1],_testData[13], false);Stringtext0M.AssertModel(models[2],_testData[14], false);Stringtext0M.AssertModel(models[3],_testData[15], false);Stringtext0M.AssertModel(models[4],_testData[16], false);Stringtext0M.AssertModel(models[5],_testData[17], false);Stringtext0M.AssertModel(models[6],_testData[18], false);Stringtext0M.AssertModel(models[7],_testData[19], false);Stringtext0M.AssertModel(models[8],_testData[20], false);Stringtext0M.AssertModel(models[9],_testData[21], false);Stringtext0M.AssertModel(models[10],_testData[22], false);Stringtext0M.AssertModel(models[11],_testData[23], false);Stringtext0M.AssertModel(models[12],_testData[24], false);Stringtext0M.AssertModel(models[13],_testData[25], false);Stringtext0M.AssertModel(models[14],_testData[26], false);Stringtext0M.AssertModel(models[15],_testData[27], false);Stringtext0M.AssertModel(models[16],_testData[28], false);Stringtext0M.AssertModel(models[17],_testData[29], false);
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
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("hd")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((11)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("kcutqbdslephojtqugq")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((4)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("ryjkxfevpgbajbqgm")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("iulvvq")));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("swiiotplbphsltog")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("fkcnwyiqhsxfqtpawgjpqn")));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("qsleyeaqjpiwfealtq")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("bvynilelqdlkxa")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("xv")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("mxxnxyc")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("cyje")));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("aegdlwdojjowyynrvnse")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("ggwhdkeyvanyao")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("qomepowwkoorekmwcycrq")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("jptmgcpmcsuidgvwqjeyv")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((21)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("nlvmvbh")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("whaxqxdiv")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("pgvsyptbbxcjrtd")));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("qjqcqruxtxwobewiwdyklove")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("gpkyvkinlpvcodclnmhcdxpfeimy")));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("xjbjnukpleeuyciex")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("a")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("njmnypf")));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("yrdhvilxmiawxpjexsbcnholp")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("bljufcnvcq")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("vjvqockkxbnintwvqia")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("kmkbkvfpowgbjnhorllxt")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("fiiaybxsehtgmot")));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("njlomynmbraht")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("whjvsbibcttlqnwxkvwcnvbkrtccj")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("wdijhplstswxu")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("uloioyqjalrvfpbcqkcqrxoyxbgiw")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("fhxygihkhhjujjdey")));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("tmhplvedp")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("uhkptpdqlr")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("d")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("mlrewjsnndqmsscuygfwqakubm")));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("eye")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("vuamuhydcpbotgbmwkacrhuwnmnv")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("rpfwgeqtlhbp")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("f")));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("vvdoochknei")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("mlqsjuu")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((50)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("jnuwcqccadkivgxtjjwngxv")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("uctbanqxpr")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("jqqwymdfknglnflbvhn")));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("oalvpvxg")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("rcusgtpmrevsktmxfbyskygpqqxhf")));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("vaeoidr")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("trgvcxkp")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("nftrrckukaahibtisexpkjp")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("mhvqnrilmpxvcwlancvxyejaqekk")));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("cwaaavthu")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("krkwvcqhxtvssferjhbjd")));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("ropepihrmclyakgetbol")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((68)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("yklqllsrieybopblipttdjmpi")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("nsskwtnfitx")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("sxikooko")));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("dhlmjybcnqtoyoibseoybj")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("gmftt")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("suegcfckjosjbufd")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("bbuoirb")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("cnjjmxdl")));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((134)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("xpxaxkk")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((75)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("gfu")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("yqwjubpknnxhadmfc")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("fpfofmtnirdrkbgwjidinoingbcs")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("p")));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("chprpmvbduyrllnsmcqpslqejmkv")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((79)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("psukcqkjlagjsikgjflw")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("nmakcvmytc")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("jimv")));

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
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("hd")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((11)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("kcutqbdslephojtqugq")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((4)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("ryjkxfevpgbajbqgm")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("iulvvq")));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("swiiotplbphsltog")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("fkcnwyiqhsxfqtpawgjpqn")));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("qsleyeaqjpiwfealtq")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("bvynilelqdlkxa")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("xv")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("mxxnxyc")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("cyje")));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("aegdlwdojjowyynrvnse")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("ggwhdkeyvanyao")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("qomepowwkoorekmwcycrq")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("jptmgcpmcsuidgvwqjeyv")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((21)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("nlvmvbh")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("whaxqxdiv")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("pgvsyptbbxcjrtd")));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("qjqcqruxtxwobewiwdyklove")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("gpkyvkinlpvcodclnmhcdxpfeimy")));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("xjbjnukpleeuyciex")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("a")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("njmnypf")));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("yrdhvilxmiawxpjexsbcnholp")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("bljufcnvcq")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("vjvqockkxbnintwvqia")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("kmkbkvfpowgbjnhorllxt")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("fiiaybxsehtgmot")));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("njlomynmbraht")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("whjvsbibcttlqnwxkvwcnvbkrtccj")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("wdijhplstswxu")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("uloioyqjalrvfpbcqkcqrxoyxbgiw")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("fhxygihkhhjujjdey")));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("tmhplvedp")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("uhkptpdqlr")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("d")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("mlrewjsnndqmsscuygfwqakubm")));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("eye")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("vuamuhydcpbotgbmwkacrhuwnmnv")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("rpfwgeqtlhbp")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("f")));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("vvdoochknei")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("mlqsjuu")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((50)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("jnuwcqccadkivgxtjjwngxv")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("uctbanqxpr")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("jqqwymdfknglnflbvhn")));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("oalvpvxg")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("rcusgtpmrevsktmxfbyskygpqqxhf")));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("vaeoidr")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("trgvcxkp")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("nftrrckukaahibtisexpkjp")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("mhvqnrilmpxvcwlancvxyejaqekk")));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("cwaaavthu")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("krkwvcqhxtvssferjhbjd")));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("ropepihrmclyakgetbol")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((68)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("yklqllsrieybopblipttdjmpi")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("nsskwtnfitx")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("sxikooko")));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("dhlmjybcnqtoyoibseoybj")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("gmftt")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("suegcfckjosjbufd")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("bbuoirb")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("cnjjmxdl")));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((134)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("xpxaxkk")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((75)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("gfu")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("yqwjubpknnxhadmfc")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("fpfofmtnirdrkbgwjidinoingbcs")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("p")));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("chprpmvbduyrllnsmcqpslqejmkv")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((79)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("psukcqkjlagjsikgjflw")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("nmakcvmytc")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("jimv")));

            }
        }

#endregion

    }
}

