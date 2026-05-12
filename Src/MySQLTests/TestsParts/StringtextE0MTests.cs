

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

        private readonly StringtextE0M[] _testData = new StringtextE0M[]
        {
            new StringtextE0M
{
    Id = 9,
    Value = "pruaxlejvwf",
    ModelInner = null,
    NullableValue = null,
},
            new StringtextE0M
{
    Id = 12,
    Value = "vgdqoonmjynlmomruvxmpbqgc",
    ModelInner = new StringtextE0MI
{
    Id = 8,
    Value = "fhgdoplshvwgjvxydqxipjvhx",
    NullableValue = "uoboouvskrtqcinxnbthbnipnkrg",
},
    NullableValue = null,
},
            new StringtextE0M
{
    Id = 15,
    Value = "koejpjywfwnbxmqsndqkvemyttk",
    ModelInner = null,
    NullableValue = null,
},
            new StringtextE0M
{
    Id = 16,
    Value = "xqdgphylj",
    ModelInner = new StringtextE0MI
{
    Id = 16,
    Value = "",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringtextE0M
{
    Id = 21,
    Value = "gqeouhgfnpnqxcyfp",
    ModelInner = null,
    NullableValue = null,
},
            new StringtextE0M
{
    Id = 30,
    Value = "meunmrvixpklprq",
    ModelInner = new StringtextE0MI
{
    Id = 23,
    Value = "yfcsp",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringtextE0M
{
    Id = 39,
    Value = "kugsrv",
    ModelInner = null,
    NullableValue = null,
},
            new StringtextE0M
{
    Id = 45,
    Value = "gmhywvjpjhxsdkh",
    ModelInner = new StringtextE0MI
{
    Id = 32,
    Value = "",
    NullableValue = "qmbkr",
},
    NullableValue = null,
},
            new StringtextE0M
{
    Id = 49,
    Value = "lhoql",
    ModelInner = null,
    NullableValue = "dumxhnqworvxycpcrhmiie",
},
            new StringtextE0M
{
    Id = 50,
    Value = "csjadjktyahriqmguqh",
    ModelInner = new StringtextE0MI
{
    Id = 34,
    Value = "",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringtextE0M
{
    Id = 56,
    Value = "itkifkqkodefguldvcwy",
    ModelInner = null,
    NullableValue = "fledngl",
},
            new StringtextE0M
{
    Id = 62,
    Value = "vilvqithxrd",
    ModelInner = new StringtextE0MI
{
    Id = 37,
    Value = "climgw",
    NullableValue = "yrjetwbwnmgtpnbreyxlv",
},
    NullableValue = "sqbhpvvxv",
},
            new StringtextE0M
{
    Id = 71,
    Value = "rqecvktpyfotoxtv",
    ModelInner = null,
    NullableValue = null,
},
            new StringtextE0M
{
    Id = 75,
    Value = "nnupdefsbdjsxanjupo",
    ModelInner = new StringtextE0MI
{
    Id = 39,
    Value = "exvinewmcvp",
    NullableValue = "ccchvjjohfeigftoftxnliab",
},
    NullableValue = null,
},
            new StringtextE0M
{
    Id = 79,
    Value = "nvogni",
    ModelInner = null,
    NullableValue = "lklivwmxlpbmulxjmliqjork",
},
            new StringtextE0M
{
    Id = 84,
    Value = "pwsuhxrxpmxbiryjlugeqj",
    ModelInner = new StringtextE0MI
{
    Id = 40,
    Value = "ahicnudfb",
    NullableValue = null,
},
    NullableValue = "ynwdyxkxpuvefteqqui",
},
            new StringtextE0M
{
    Id = 91,
    Value = "jccbwodttehdvf",
    ModelInner = null,
    NullableValue = "v",
},
            new StringtextE0M
{
    Id = 92,
    Value = "nywmuheegqofwyftoqblumrcud",
    ModelInner = new StringtextE0MI
{
    Id = 42,
    Value = "usc",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringtextE0M
{
    Id = 93,
    Value = "waoohgtnnoghaeeassnmstskboax",
    ModelInner = null,
    NullableValue = "ti",
},
            new StringtextE0M
{
    Id = 95,
    Value = "ftqbuffhxajylyphi",
    ModelInner = new StringtextE0MI
{
    Id = 47,
    Value = "lrgyhwbkoufdlyvrnugtxd",
    NullableValue = "shyuwbgofhavqbemaxkvyxpwdbj",
},
    NullableValue = null,
},
            new StringtextE0M
{
    Id = 100,
    Value = "tliq",
    ModelInner = null,
    NullableValue = "mglxixwxiulvmhkkrittjotxud",
},
            new StringtextE0M
{
    Id = 108,
    Value = "tyxlhrobmdugxehlvdmgygnfag",
    ModelInner = new StringtextE0MI
{
    Id = 51,
    Value = "xvokdkdfohweppnwtjs",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringtextE0M
{
    Id = 110,
    Value = "q",
    ModelInner = null,
    NullableValue = null,
},
            new StringtextE0M
{
    Id = 115,
    Value = "fxqrdqeljpbhyiiprifhbonx",
    ModelInner = new StringtextE0MI
{
    Id = 54,
    Value = "kibnvlirmpgktfcbcstg",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringtextE0M
{
    Id = 118,
    Value = "xsiqrjbvsycsinkjbsdf",
    ModelInner = null,
    NullableValue = null,
},
            new StringtextE0M
{
    Id = 120,
    Value = "clmnxpfpdrgwwh",
    ModelInner = new StringtextE0MI
{
    Id = 60,
    Value = "uxthbmpenmlfaynaferk",
    NullableValue = "fqbqjcubgpbiccxc",
},
    NullableValue = null,
},
            new StringtextE0M
{
    Id = 124,
    Value = "pcr",
    ModelInner = null,
    NullableValue = "dqyphyhn",
},
            new StringtextE0M
{
    Id = 130,
    Value = "sxcprm",
    ModelInner = new StringtextE0MI
{
    Id = 69,
    Value = "otjjgedacepkflelrowhbce",
    NullableValue = "aonaektfyu",
},
    NullableValue = "wcnckgjtfnpkhbdgsyweqwh",
},
            new StringtextE0M
{
    Id = 133,
    Value = "biksanftsehhbftxqdwyuuvnm",
    ModelInner = null,
    NullableValue = "hxlgqdhcabydqyqoduairdsebf",
},
            new StringtextE0M
{
    Id = 134,
    Value = "aniumfwgbkqv",
    ModelInner = new StringtextE0MI
{
    Id = 72,
    Value = "ukcrmnfhdyogffvshawsmqsnekud",
    NullableValue = "",
},
    NullableValue = "cgjrghoiiwplfbgbqxoab",
},
            new StringtextE0M
{
    Id = 138,
    Value = "uibfomdarjgiency",
    ModelInner = null,
    NullableValue = null,
},
            new StringtextE0M
{
    Id = 147,
    Value = "its",
    ModelInner = new StringtextE0MI
{
    Id = 78,
    Value = "oqkxdaanpmpqnjwsoqfjcwmmshr",
    NullableValue = null,
},
    NullableValue = "f",
},
            new StringtextE0M
{
    Id = 156,
    Value = "mtnsushcugnlboxdyrlvjcqymuky",
    ModelInner = null,
    NullableValue = null,
},
            new StringtextE0M
{
    Id = 165,
    Value = "vkvdwdy",
    ModelInner = new StringtextE0MI
{
    Id = 81,
    Value = "rshapiglmcfwrwwcilwoaidxjlflh",
    NullableValue = null,
},
    NullableValue = "r",
},
            new StringtextE0M
{
    Id = 167,
    Value = "csgtrurolfsg",
    ModelInner = null,
    NullableValue = "axexg",
},
        };

#endregion

#region InsertModelInner

[Gedaq.MySqlConnector.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.stringtexte0mi(
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
INSERT INTO gedaqtests.stringtexte0mi(
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
INSERT INTO gedaqtests.stringtexte0m(
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
                parametrName: "stringtexte0mi_id", 
                methodParametrName: "stringtexte0mi_id", 
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
INSERT INTO gedaqtests.stringtexte0m(
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
                parametrName: "stringtexte0mi_id", 
                methodParametrName: "stringtexte0mi_id", 
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
            queryMapTypes: [typeof(FlatStringtextE0M), typeof(FlatStringtextE0M)],
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
FROM gedaqtests.stringtexte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
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
FROM gedaqtests.stringtexte0m m
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
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

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatStringtextE0M)],
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
FROM gedaqtests.stringtexte0m m
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
FROM gedaqtests.stringtexte0m m
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
                    FlatStringtextE0M.AssertModel(models[i],_testData[i], false);
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
FROM gedaqtests.stringtexte0m m
LEFT JOIN gedaqtests.stringtexte0mi mi ON mi.id = m.stringtexte0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            sourceType: SourceType.MySqlConnection,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(StringtextE0M)],
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
                var parametr1 = new MySqlParameter();
                parametr1.Value = 0;
                parametr1.MySqlDbType = (MySqlConnector.MySqlDbType)(3);
                parametr1.ParameterName = "id";
                var models = ((IStringSingleTypetext)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    StringtextE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatStringtextE0M), typeof(FlatStringtextE0M)],
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
FROM gedaqtests.stringtexte0m m
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
FROM gedaqtests.stringtexte0m m
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

[Gedaq.MySqlConnector.Attributes.Query(
            query: null,
            sourceType: SourceType.MySqlConnection,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatStringtextE0M)],
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
FROM gedaqtests.stringtexte0m m
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
FROM gedaqtests.stringtexte0m m
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
FROM gedaqtests.stringtexte0m m
LEFT JOIN gedaqtests.stringtexte0mi mi ON mi.id = m.stringtexte0mi_id
WHERE 
    m.id > @id
ORDER BY
    m.id ASC
"
,
            sourceType: SourceType.MySqlConnection,
            methodName:"SelectModel",
            queryMapTypes: [typeof(StringtextE0M)],
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
FROM gedaqtests.stringtexte0m m
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
                parametr1.Value = 147;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 45;
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
FROM gedaqtests.stringtexte0m m
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
FROM gedaqtests.stringtexte0m m
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
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatStringtextE0M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatStringtextE0M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatStringtextE0M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatStringtextE0M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatStringtextE0M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatStringtextE0M.AssertModel(firstItems2[2],_testData[34], false);
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

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 115;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 12;
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
FROM gedaqtests.stringtexte0m m
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
FROM gedaqtests.stringtexte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatStringtextE0M>();
                var firstItems2 = new List<FlatStringtextE0M>();
                var secondItems1 = new List<FlatStringtextE0M>();
                await ((IStringSingleTypetext)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                        FlatStringtextE0M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatStringtextE0M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatStringtextE0M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatStringtextE0M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatStringtextE0M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatStringtextE0M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatStringtextE0M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatStringtextE0M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatStringtextE0M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatStringtextE0M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatStringtextE0M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatStringtextE0M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatStringtextE0M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatStringtextE0M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatStringtextE0M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatStringtextE0M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatStringtextE0M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatStringtextE0M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatStringtextE0M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatStringtextE0M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatStringtextE0M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatStringtextE0M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatStringtextE0M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatStringtextE0M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatStringtextE0M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatStringtextE0M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatStringtextE0M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatStringtextE0M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatStringtextE0M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatStringtextE0M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatStringtextE0M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatStringtextE0M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatStringtextE0M.AssertModel(secondItems1[32],_testData[34], false);
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
FROM gedaqtests.stringtexte0m m
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
                parametr1.Value = 110;
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
FROM gedaqtests.stringtexte0m m
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
FROM gedaqtests.stringtexte0m m
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
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatStringtextE0M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatStringtextE0M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatStringtextE0M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatStringtextE0M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatStringtextE0M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatStringtextE0M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatStringtextE0M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatStringtextE0M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatStringtextE0M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatStringtextE0M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatStringtextE0M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatStringtextE0M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatStringtextE0M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatStringtextE0M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatStringtextE0M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatStringtextE0M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatStringtextE0M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatStringtextE0M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatStringtextE0M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatStringtextE0M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatStringtextE0M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatStringtextE0M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatStringtextE0M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatStringtextE0M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatStringtextE0M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatStringtextE0M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatStringtextE0M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatStringtextE0M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatStringtextE0M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatStringtextE0M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatStringtextE0M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatStringtextE0M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatStringtextE0M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatStringtextE0M.AssertModel(secondItems2[16],_testData[34], false);
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
                parametr2.Value = 110;
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
FROM gedaqtests.stringtexte0m m
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
FROM gedaqtests.stringtexte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatStringtextE0M>();
                var firstItems2 = new List<FlatStringtextE0M>();
                var secondItems1 = new List<FlatStringtextE0M>();
                 ((IStringSingleTypetext)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatStringtextE0M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatStringtextE0M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatStringtextE0M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatStringtextE0M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatStringtextE0M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatStringtextE0M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatStringtextE0M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatStringtextE0M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatStringtextE0M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatStringtextE0M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatStringtextE0M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatStringtextE0M.AssertModel(secondItems1[11],_testData[34], false);
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
FROM gedaqtests.stringtexte0m m
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
                parametr1.Value = 91;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 120;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.stringtexte0m m
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
FROM gedaqtests.stringtexte0m m
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
                parametr1.Value = 15;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 133;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.stringtexte0m m
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
FROM gedaqtests.stringtexte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatStringtextE0M>();
                var secondItems1 = new List<FlatStringtextE0M>();
                var secondItems2 = new List<FlatStringtextE0M>();
                await ((IStringSingleTypetext)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
FROM gedaqtests.stringtexte0m m
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
                parametr1.Value = 79;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 120;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.stringtexte0m m
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
FROM gedaqtests.stringtexte0m m
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
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatStringtextE0M.AssertModel(models[0],_testData[15], false);
                        FlatStringtextE0M.AssertModel(models[1],_testData[16], false);
                        FlatStringtextE0M.AssertModel(models[2],_testData[17], false);
                        FlatStringtextE0M.AssertModel(models[3],_testData[18], false);
                        FlatStringtextE0M.AssertModel(models[4],_testData[19], false);
                        FlatStringtextE0M.AssertModel(models[5],_testData[20], false);
                        FlatStringtextE0M.AssertModel(models[6],_testData[21], false);
                        FlatStringtextE0M.AssertModel(models[7],_testData[22], false);
                        FlatStringtextE0M.AssertModel(models[8],_testData[23], false);
                        FlatStringtextE0M.AssertModel(models[9],_testData[24], false);
                        FlatStringtextE0M.AssertModel(models[10],_testData[25], false);
                        FlatStringtextE0M.AssertModel(models[11],_testData[26], false);
                        FlatStringtextE0M.AssertModel(models[12],_testData[27], false);
                        FlatStringtextE0M.AssertModel(models[13],_testData[28], false);
                        FlatStringtextE0M.AssertModel(models[14],_testData[29], false);
                        FlatStringtextE0M.AssertModel(models[15],_testData[30], false);
                        FlatStringtextE0M.AssertModel(models[16],_testData[31], false);
                        FlatStringtextE0M.AssertModel(models[17],_testData[32], false);
                        FlatStringtextE0M.AssertModel(models[18],_testData[33], false);
                        FlatStringtextE0M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                parametr1.Value = 84;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 49;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM gedaqtests.stringtexte0m m
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
FROM gedaqtests.stringtexte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatStringtextE0M>();
                var secondItems1 = new List<FlatStringtextE0M>();
                var secondItems2 = new List<FlatStringtextE0M>();
                 ((IStringSingleTypetext)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatStringtextE0M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatStringtextE0M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatStringtextE0M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatStringtextE0M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatStringtextE0M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatStringtextE0M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatStringtextE0M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatStringtextE0M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatStringtextE0M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatStringtextE0M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatStringtextE0M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatStringtextE0M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatStringtextE0M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatStringtextE0M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatStringtextE0M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatStringtextE0M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatStringtextE0M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatStringtextE0M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatStringtextE0M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatStringtextE0M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatStringtextE0M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatStringtextE0M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatStringtextE0M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatStringtextE0M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatStringtextE0M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatStringtextE0M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatStringtextE0M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatStringtextE0M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatStringtextE0M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatStringtextE0M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatStringtextE0M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatStringtextE0M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatStringtextE0M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatStringtextE0M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatStringtextE0M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatStringtextE0M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatStringtextE0M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatStringtextE0M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatStringtextE0M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatStringtextE0M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatStringtextE0M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatStringtextE0M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatStringtextE0M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatStringtextE0M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatStringtextE0M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatStringtextE0M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatStringtextE0M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatStringtextE0M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatStringtextE0M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatStringtextE0M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatStringtextE0M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatStringtextE0M.AssertModel(secondItems2[25],_testData[34], false);
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
FROM gedaqtests.stringtexte0m m
LEFT JOIN gedaqtests.stringtexte0mi mi ON mi.id = m.stringtexte0mi_id
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
                parametr1.Value = 21;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 12;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IStringSingleTypetext)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
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
                parametr1.Value = 9;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 45;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IStringSingleTypetext)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        StringtextE0M.AssertModel(models[0],_testData[1], false);
                        StringtextE0M.AssertModel(models[1],_testData[2], false);
                        StringtextE0M.AssertModel(models[2],_testData[3], false);
                        StringtextE0M.AssertModel(models[3],_testData[4], false);
                        StringtextE0M.AssertModel(models[4],_testData[5], false);
                        StringtextE0M.AssertModel(models[5],_testData[6], false);
                        StringtextE0M.AssertModel(models[6],_testData[7], false);
                        StringtextE0M.AssertModel(models[7],_testData[8], false);
                        StringtextE0M.AssertModel(models[8],_testData[9], false);
                        StringtextE0M.AssertModel(models[9],_testData[10], false);
                        StringtextE0M.AssertModel(models[10],_testData[11], false);
                        StringtextE0M.AssertModel(models[11],_testData[12], false);
                        StringtextE0M.AssertModel(models[12],_testData[13], false);
                        StringtextE0M.AssertModel(models[13],_testData[14], false);
                        StringtextE0M.AssertModel(models[14],_testData[15], false);
                        StringtextE0M.AssertModel(models[15],_testData[16], false);
                        StringtextE0M.AssertModel(models[16],_testData[17], false);
                        StringtextE0M.AssertModel(models[17],_testData[18], false);
                        StringtextE0M.AssertModel(models[18],_testData[19], false);
                        StringtextE0M.AssertModel(models[19],_testData[20], false);
                        StringtextE0M.AssertModel(models[20],_testData[21], false);
                        StringtextE0M.AssertModel(models[21],_testData[22], false);
                        StringtextE0M.AssertModel(models[22],_testData[23], false);
                        StringtextE0M.AssertModel(models[23],_testData[24], false);
                        StringtextE0M.AssertModel(models[24],_testData[25], false);
                        StringtextE0M.AssertModel(models[25],_testData[26], false);
                        StringtextE0M.AssertModel(models[26],_testData[27], false);
                        StringtextE0M.AssertModel(models[27],_testData[28], false);
                        StringtextE0M.AssertModel(models[28],_testData[29], false);
                        StringtextE0M.AssertModel(models[29],_testData[30], false);
                        StringtextE0M.AssertModel(models[30],_testData[31], false);
                        StringtextE0M.AssertModel(models[31],_testData[32], false);
                        StringtextE0M.AssertModel(models[32],_testData[33], false);
                        StringtextE0M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
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
FROM gedaqtests.stringtexte0m m
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
FROM gedaqtests.stringtexte0m m
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
FROM gedaqtests.stringtexte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatStringtextE0M>();
                var firstItems2 = new List<FlatStringtextE0M>();
                var secondItems1 = new List<FlatStringtextE0M>();
                var secondItems2 = new List<FlatStringtextE0M>();
                await ((IStringSingleTypetext)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 30, query1, 124, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
FROM gedaqtests.stringtexte0m m
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
FROM gedaqtests.stringtexte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatStringtextE0M>();
                var firstItems2 = new List<FlatStringtextE0M>();
                var secondItems1 = new List<FlatStringtextE0M>();
                await ((IStringSingleTypetext)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 124, query1, 9, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatStringtextE0M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatStringtextE0M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatStringtextE0M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatStringtextE0M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatStringtextE0M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatStringtextE0M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatStringtextE0M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatStringtextE0M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatStringtextE0M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatStringtextE0M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatStringtextE0M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatStringtextE0M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatStringtextE0M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatStringtextE0M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatStringtextE0M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatStringtextE0M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                        FlatStringtextE0M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatStringtextE0M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatStringtextE0M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatStringtextE0M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatStringtextE0M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatStringtextE0M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatStringtextE0M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatStringtextE0M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatStringtextE0M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatStringtextE0M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatStringtextE0M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatStringtextE0M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatStringtextE0M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatStringtextE0M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatStringtextE0M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatStringtextE0M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatStringtextE0M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatStringtextE0M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatStringtextE0M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatStringtextE0M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatStringtextE0M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatStringtextE0M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatStringtextE0M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatStringtextE0M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatStringtextE0M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatStringtextE0M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatStringtextE0M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatStringtextE0M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatStringtextE0M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatStringtextE0M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatStringtextE0M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatStringtextE0M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatStringtextE0M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatStringtextE0M.AssertModel(secondItems1[33],_testData[34], false);
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
FROM gedaqtests.stringtexte0m m
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
FROM gedaqtests.stringtexte0m m
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
FROM gedaqtests.stringtexte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatStringtextE0M>();
                var firstItems2 = new List<FlatStringtextE0M>();
                var secondItems1 = new List<FlatStringtextE0M>();
                var secondItems2 = new List<FlatStringtextE0M>();
                 ((IStringSingleTypetext)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 12, query1, 115, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatStringtextE0M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatStringtextE0M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatStringtextE0M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatStringtextE0M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatStringtextE0M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatStringtextE0M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatStringtextE0M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatStringtextE0M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatStringtextE0M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatStringtextE0M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatStringtextE0M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatStringtextE0M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatStringtextE0M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatStringtextE0M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatStringtextE0M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatStringtextE0M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatStringtextE0M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatStringtextE0M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatStringtextE0M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatStringtextE0M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatStringtextE0M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatStringtextE0M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatStringtextE0M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatStringtextE0M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatStringtextE0M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatStringtextE0M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatStringtextE0M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatStringtextE0M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatStringtextE0M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatStringtextE0M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatStringtextE0M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatStringtextE0M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatStringtextE0M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatStringtextE0M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatStringtextE0M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatStringtextE0M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatStringtextE0M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatStringtextE0M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatStringtextE0M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatStringtextE0M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatStringtextE0M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatStringtextE0M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatStringtextE0M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatStringtextE0M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatStringtextE0M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatStringtextE0M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatStringtextE0M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatStringtextE0M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatStringtextE0M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatStringtextE0M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatStringtextE0M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatStringtextE0M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatStringtextE0M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatStringtextE0M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatStringtextE0M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatStringtextE0M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatStringtextE0M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatStringtextE0M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatStringtextE0M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatStringtextE0M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatStringtextE0M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatStringtextE0M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatStringtextE0M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatStringtextE0M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatStringtextE0M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatStringtextE0M.AssertModel(firstItems2[32],_testData[34], false);
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
FROM gedaqtests.stringtexte0m m
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
FROM gedaqtests.stringtexte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatStringtextE0M>();
                var firstItems2 = new List<FlatStringtextE0M>();
                var secondItems1 = new List<FlatStringtextE0M>();
                 ((IStringSingleTypetext)this).DbConnectionMMDynQuerySelectModelBatch(connection, 12, query1, 84, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatStringtextE0M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatStringtextE0M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatStringtextE0M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatStringtextE0M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatStringtextE0M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatStringtextE0M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatStringtextE0M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatStringtextE0M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatStringtextE0M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatStringtextE0M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatStringtextE0M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatStringtextE0M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatStringtextE0M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatStringtextE0M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatStringtextE0M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatStringtextE0M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatStringtextE0M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatStringtextE0M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatStringtextE0M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatStringtextE0M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatStringtextE0M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatStringtextE0M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatStringtextE0M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatStringtextE0M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatStringtextE0M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatStringtextE0M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatStringtextE0M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatStringtextE0M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatStringtextE0M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatStringtextE0M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatStringtextE0M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatStringtextE0M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatStringtextE0M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatStringtextE0M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatStringtextE0M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatStringtextE0M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatStringtextE0M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatStringtextE0M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatStringtextE0M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatStringtextE0M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatStringtextE0M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatStringtextE0M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatStringtextE0M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatStringtextE0M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatStringtextE0M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatStringtextE0M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatStringtextE0M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatStringtextE0M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatStringtextE0M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatStringtextE0M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatStringtextE0M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatStringtextE0M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatStringtextE0M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatStringtextE0M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatStringtextE0M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatStringtextE0M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatStringtextE0M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatStringtextE0M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatStringtextE0M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatStringtextE0M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatStringtextE0M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatStringtextE0M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatStringtextE0M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatStringtextE0M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatStringtextE0M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatStringtextE0M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatStringtextE0M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatStringtextE0M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatStringtextE0M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatStringtextE0M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatStringtextE0M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatStringtextE0M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatStringtextE0M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatStringtextE0M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatStringtextE0M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatStringtextE0M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatStringtextE0M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatStringtextE0M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatStringtextE0M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatStringtextE0M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatStringtextE0M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatStringtextE0M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatStringtextE0M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatStringtextE0M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatStringtextE0M.AssertModel(secondItems1[18],_testData[34], false);
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
FROM gedaqtests.stringtexte0m m
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
FROM gedaqtests.stringtexte0m m
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
FROM gedaqtests.stringtexte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IStringSingleTypetext)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 49, query1, 84, query2))
                {
                    if(++resultIndex == 1)
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
FROM gedaqtests.stringtexte0m m
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
FROM gedaqtests.stringtexte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatStringtextE0M>();
                var secondItems1 = new List<FlatStringtextE0M>();
                var secondItems2 = new List<FlatStringtextE0M>();
                await ((IStringSingleTypetext)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 92, query1, 84, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                        FlatStringtextE0M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatStringtextE0M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatStringtextE0M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatStringtextE0M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatStringtextE0M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatStringtextE0M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatStringtextE0M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatStringtextE0M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatStringtextE0M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatStringtextE0M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatStringtextE0M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatStringtextE0M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatStringtextE0M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatStringtextE0M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatStringtextE0M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatStringtextE0M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatStringtextE0M.AssertModel(firstItems1[16],_testData[34], false);
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
FROM gedaqtests.stringtexte0m m
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
FROM gedaqtests.stringtexte0m m
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
FROM gedaqtests.stringtexte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IStringSingleTypetext)this).DbConnectionSTDynQuerySelectModelBatch(connection, 45, query1, 50, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatStringtextE0M.AssertModel(models[0],_testData[8], false);
                        FlatStringtextE0M.AssertModel(models[1],_testData[9], false);
                        FlatStringtextE0M.AssertModel(models[2],_testData[10], false);
                        FlatStringtextE0M.AssertModel(models[3],_testData[11], false);
                        FlatStringtextE0M.AssertModel(models[4],_testData[12], false);
                        FlatStringtextE0M.AssertModel(models[5],_testData[13], false);
                        FlatStringtextE0M.AssertModel(models[6],_testData[14], false);
                        FlatStringtextE0M.AssertModel(models[7],_testData[15], false);
                        FlatStringtextE0M.AssertModel(models[8],_testData[16], false);
                        FlatStringtextE0M.AssertModel(models[9],_testData[17], false);
                        FlatStringtextE0M.AssertModel(models[10],_testData[18], false);
                        FlatStringtextE0M.AssertModel(models[11],_testData[19], false);
                        FlatStringtextE0M.AssertModel(models[12],_testData[20], false);
                        FlatStringtextE0M.AssertModel(models[13],_testData[21], false);
                        FlatStringtextE0M.AssertModel(models[14],_testData[22], false);
                        FlatStringtextE0M.AssertModel(models[15],_testData[23], false);
                        FlatStringtextE0M.AssertModel(models[16],_testData[24], false);
                        FlatStringtextE0M.AssertModel(models[17],_testData[25], false);
                        FlatStringtextE0M.AssertModel(models[18],_testData[26], false);
                        FlatStringtextE0M.AssertModel(models[19],_testData[27], false);
                        FlatStringtextE0M.AssertModel(models[20],_testData[28], false);
                        FlatStringtextE0M.AssertModel(models[21],_testData[29], false);
                        FlatStringtextE0M.AssertModel(models[22],_testData[30], false);
                        FlatStringtextE0M.AssertModel(models[23],_testData[31], false);
                        FlatStringtextE0M.AssertModel(models[24],_testData[32], false);
                        FlatStringtextE0M.AssertModel(models[25],_testData[33], false);
                        FlatStringtextE0M.AssertModel(models[26],_testData[34], false);
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
FROM gedaqtests.stringtexte0m m
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
FROM gedaqtests.stringtexte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatStringtextE0M>();
                var secondItems1 = new List<FlatStringtextE0M>();
                var secondItems2 = new List<FlatStringtextE0M>();
                 ((IStringSingleTypetext)this).DbConnectionDynQuerySelectModelBatch(connection, 84, query1, 156, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatStringtextE0M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatStringtextE0M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatStringtextE0M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatStringtextE0M.AssertModel(secondItems2[1],_testData[34], false);
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
FROM gedaqtests.stringtexte0m m
LEFT JOIN gedaqtests.stringtexte0mi mi ON mi.id = m.stringtexte0mi_id
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
                foreach(var batchResult in await ((IStringSingleTypetext)this).DbConnectionSTSelectModelBatchAsync(connection, 9, 130))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        StringtextE0M.AssertModel(models[0],_testData[1], false);
                        StringtextE0M.AssertModel(models[1],_testData[2], false);
                        StringtextE0M.AssertModel(models[2],_testData[3], false);
                        StringtextE0M.AssertModel(models[3],_testData[4], false);
                        StringtextE0M.AssertModel(models[4],_testData[5], false);
                        StringtextE0M.AssertModel(models[5],_testData[6], false);
                        StringtextE0M.AssertModel(models[6],_testData[7], false);
                        StringtextE0M.AssertModel(models[7],_testData[8], false);
                        StringtextE0M.AssertModel(models[8],_testData[9], false);
                        StringtextE0M.AssertModel(models[9],_testData[10], false);
                        StringtextE0M.AssertModel(models[10],_testData[11], false);
                        StringtextE0M.AssertModel(models[11],_testData[12], false);
                        StringtextE0M.AssertModel(models[12],_testData[13], false);
                        StringtextE0M.AssertModel(models[13],_testData[14], false);
                        StringtextE0M.AssertModel(models[14],_testData[15], false);
                        StringtextE0M.AssertModel(models[15],_testData[16], false);
                        StringtextE0M.AssertModel(models[16],_testData[17], false);
                        StringtextE0M.AssertModel(models[17],_testData[18], false);
                        StringtextE0M.AssertModel(models[18],_testData[19], false);
                        StringtextE0M.AssertModel(models[19],_testData[20], false);
                        StringtextE0M.AssertModel(models[20],_testData[21], false);
                        StringtextE0M.AssertModel(models[21],_testData[22], false);
                        StringtextE0M.AssertModel(models[22],_testData[23], false);
                        StringtextE0M.AssertModel(models[23],_testData[24], false);
                        StringtextE0M.AssertModel(models[24],_testData[25], false);
                        StringtextE0M.AssertModel(models[25],_testData[26], false);
                        StringtextE0M.AssertModel(models[26],_testData[27], false);
                        StringtextE0M.AssertModel(models[27],_testData[28], false);
                        StringtextE0M.AssertModel(models[28],_testData[29], false);
                        StringtextE0M.AssertModel(models[29],_testData[30], false);
                        StringtextE0M.AssertModel(models[30],_testData[31], false);
                        StringtextE0M.AssertModel(models[31],_testData[32], false);
                        StringtextE0M.AssertModel(models[32],_testData[33], false);
                        StringtextE0M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        StringtextE0M.AssertModel(models[0],_testData[28], false);
                        StringtextE0M.AssertModel(models[1],_testData[29], false);
                        StringtextE0M.AssertModel(models[2],_testData[30], false);
                        StringtextE0M.AssertModel(models[3],_testData[31], false);
                        StringtextE0M.AssertModel(models[4],_testData[32], false);
                        StringtextE0M.AssertModel(models[5],_testData[33], false);
                        StringtextE0M.AssertModel(models[6],_testData[34], false);
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
                foreach(var batchResult in  ((IStringSingleTypetext)this).DbConnectionSTSelectModelBatch(connection, 120, 110))
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
                        Assert.That(models, Has.Count.EqualTo(12));

                        StringtextE0M.AssertModel(models[0],_testData[23], false);
                        StringtextE0M.AssertModel(models[1],_testData[24], false);
                        StringtextE0M.AssertModel(models[2],_testData[25], false);
                        StringtextE0M.AssertModel(models[3],_testData[26], false);
                        StringtextE0M.AssertModel(models[4],_testData[27], false);
                        StringtextE0M.AssertModel(models[5],_testData[28], false);
                        StringtextE0M.AssertModel(models[6],_testData[29], false);
                        StringtextE0M.AssertModel(models[7],_testData[30], false);
                        StringtextE0M.AssertModel(models[8],_testData[31], false);
                        StringtextE0M.AssertModel(models[9],_testData[32], false);
                        StringtextE0M.AssertModel(models[10],_testData[33], false);
                        StringtextE0M.AssertModel(models[11],_testData[34], false);
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
                ((IStringSingleTypetext)this).SetDbConnectionSelectModelParametrs(cmd, 75);
                var models = await ((IStringSingleTypetext)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

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
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IStringSingleTypetext)this).CreateDbConnectionSelectModelCommand(connection);
                ((IStringSingleTypetext)this).SetDbConnectionSelectModelParametrs(cmd, 110);
                var models =  ((IStringSingleTypetext)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(12));

                StringtextE0M.AssertModel(models[0],_testData[23], false);
                StringtextE0M.AssertModel(models[1],_testData[24], false);
                StringtextE0M.AssertModel(models[2],_testData[25], false);
                StringtextE0M.AssertModel(models[3],_testData[26], false);
                StringtextE0M.AssertModel(models[4],_testData[27], false);
                StringtextE0M.AssertModel(models[5],_testData[28], false);
                StringtextE0M.AssertModel(models[6],_testData[29], false);
                StringtextE0M.AssertModel(models[7],_testData[30], false);
                StringtextE0M.AssertModel(models[8],_testData[31], false);
                StringtextE0M.AssertModel(models[9],_testData[32], false);
                StringtextE0M.AssertModel(models[10],_testData[33], false);
                StringtextE0M.AssertModel(models[11],_testData[34], false);
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
FROM gedaqtests.stringtexte0m m
LEFT JOIN gedaqtests.stringtexte0mi mi ON mi.id = m.stringtexte0mi_id
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
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("pruaxlejvwf")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("vgdqoonmjynlmomruvxmpbqgc")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("fhgdoplshvwgjvxydqxipjvhx")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("uoboouvskrtqcinxnbthbnipnkrg")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("koejpjywfwnbxmqsndqkvemyttk")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("xqdgphylj")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("gqeouhgfnpnqxcyfp")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("meunmrvixpklprq")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("yfcsp")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("kugsrv")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((45)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("gmhywvjpjhxsdkh")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("qmbkr")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((49)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("lhoql")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("dumxhnqworvxycpcrhmiie")));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("csjadjktyahriqmguqh")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("itkifkqkodefguldvcwy")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("fledngl")));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("vilvqithxrd")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("climgw")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("yrjetwbwnmgtpnbreyxlv")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("sqbhpvvxv")));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("rqecvktpyfotoxtv")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((75)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("nnupdefsbdjsxanjupo")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("exvinewmcvp")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("ccchvjjohfeigftoftxnliab")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("nvogni")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("lklivwmxlpbmulxjmliqjork")));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("pwsuhxrxpmxbiryjlugeqj")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("ahicnudfb")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("ynwdyxkxpuvefteqqui")));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("jccbwodttehdvf")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("v")));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("nywmuheegqofwyftoqblumrcud")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("usc")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("waoohgtnnoghaeeassnmstskboax")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("ti")));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("ftqbuffhxajylyphi")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("lrgyhwbkoufdlyvrnugtxd")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("shyuwbgofhavqbemaxkvyxpwdbj")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("tliq")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("mglxixwxiulvmhkkrittjotxud")));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("tyxlhrobmdugxehlvdmgygnfag")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("xvokdkdfohweppnwtjs")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("q")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("fxqrdqeljpbhyiiprifhbonx")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("kibnvlirmpgktfcbcstg")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("xsiqrjbvsycsinkjbsdf")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("clmnxpfpdrgwwh")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("uxthbmpenmlfaynaferk")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("fqbqjcubgpbiccxc")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("pcr")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("dqyphyhn")));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("sxcprm")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("otjjgedacepkflelrowhbce")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("aonaektfyu")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("wcnckgjtfnpkhbdgsyweqwh")));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("biksanftsehhbftxqdwyuuvnm")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("hxlgqdhcabydqyqoduairdsebf")));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((134)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("aniumfwgbkqv")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("ukcrmnfhdyogffvshawsmqsnekud")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("cgjrghoiiwplfbgbqxoab")));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("uibfomdarjgiency")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("its")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((78)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("oqkxdaanpmpqnjwsoqfjcwmmshr")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("f")));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((156)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("mtnsushcugnlboxdyrlvjcqymuky")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((165)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("vkvdwdy")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((81)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("rshapiglmcfwrwwcilwoaidxjlflh")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("r")));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((167)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("csgtrurolfsg")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("axexg")));

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
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("pruaxlejvwf")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("vgdqoonmjynlmomruvxmpbqgc")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("fhgdoplshvwgjvxydqxipjvhx")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("uoboouvskrtqcinxnbthbnipnkrg")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("koejpjywfwnbxmqsndqkvemyttk")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("xqdgphylj")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("gqeouhgfnpnqxcyfp")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("meunmrvixpklprq")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("yfcsp")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("kugsrv")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((45)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("gmhywvjpjhxsdkh")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("qmbkr")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((49)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("lhoql")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("dumxhnqworvxycpcrhmiie")));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("csjadjktyahriqmguqh")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("itkifkqkodefguldvcwy")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("fledngl")));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("vilvqithxrd")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("climgw")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("yrjetwbwnmgtpnbreyxlv")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("sqbhpvvxv")));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("rqecvktpyfotoxtv")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((75)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("nnupdefsbdjsxanjupo")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("exvinewmcvp")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("ccchvjjohfeigftoftxnliab")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("nvogni")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("lklivwmxlpbmulxjmliqjork")));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("pwsuhxrxpmxbiryjlugeqj")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("ahicnudfb")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("ynwdyxkxpuvefteqqui")));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("jccbwodttehdvf")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("v")));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("nywmuheegqofwyftoqblumrcud")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("usc")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("waoohgtnnoghaeeassnmstskboax")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("ti")));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("ftqbuffhxajylyphi")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("lrgyhwbkoufdlyvrnugtxd")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("shyuwbgofhavqbemaxkvyxpwdbj")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("tliq")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("mglxixwxiulvmhkkrittjotxud")));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("tyxlhrobmdugxehlvdmgygnfag")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("xvokdkdfohweppnwtjs")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("q")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("fxqrdqeljpbhyiiprifhbonx")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("kibnvlirmpgktfcbcstg")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("xsiqrjbvsycsinkjbsdf")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("clmnxpfpdrgwwh")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("uxthbmpenmlfaynaferk")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("fqbqjcubgpbiccxc")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("pcr")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("dqyphyhn")));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("sxcprm")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("otjjgedacepkflelrowhbce")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("aonaektfyu")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("wcnckgjtfnpkhbdgsyweqwh")));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("biksanftsehhbftxqdwyuuvnm")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("hxlgqdhcabydqyqoduairdsebf")));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((134)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("aniumfwgbkqv")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("ukcrmnfhdyogffvshawsmqsnekud")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("cgjrghoiiwplfbgbqxoab")));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("uibfomdarjgiency")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("its")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((78)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("oqkxdaanpmpqnjwsoqfjcwmmshr")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("f")));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((156)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("mtnsushcugnlboxdyrlvjcqymuky")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((165)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("vkvdwdy")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((81)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("rshapiglmcfwrwwcilwoaidxjlflh")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("r")));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((167)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("csgtrurolfsg")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("axexg")));

            }
        }

#endregion

    }
}

