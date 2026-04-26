

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
    Id = 2,
    Value = "jsmojpcogdhgtwwcegyrmowwdawwq",
    ModelInner = null,
    NullableValue = null,
},
            new Stringtext0M
{
    Id = 8,
    Value = "taqkdteilfnmregbboy",
    ModelInner = new Stringtext0MI
{
    Id = 9,
    Value = "vqj",
    NullableValue = null,
},
    NullableValue = "njvbaeau",
},
            new Stringtext0M
{
    Id = 16,
    Value = "euwalirfqrcx",
    ModelInner = null,
    NullableValue = null,
},
            new Stringtext0M
{
    Id = 18,
    Value = "anqlfs",
    ModelInner = new Stringtext0MI
{
    Id = 13,
    Value = "sioajxnfhisuobf",
    NullableValue = null,
},
    NullableValue = "uqd",
},
            new Stringtext0M
{
    Id = 27,
    Value = "w",
    ModelInner = null,
    NullableValue = "opbq",
},
            new Stringtext0M
{
    Id = 35,
    Value = "aoktaxqlchocmtqbjqflx",
    ModelInner = new Stringtext0MI
{
    Id = 15,
    Value = "helwvsjdqskxmrakhxceppwxwkihc",
    NullableValue = "qdjvmaxyjgwybvoita",
},
    NullableValue = "ehfgfropijoqbulltkeubsof",
},
            new Stringtext0M
{
    Id = 39,
    Value = "pyiaknocoxikokvwfeuycg",
    ModelInner = null,
    NullableValue = "qmkcuvqfudvqphfcdn",
},
            new Stringtext0M
{
    Id = 45,
    Value = "eehyjegxykytekpljaiujouvh",
    ModelInner = new Stringtext0MI
{
    Id = 18,
    Value = "fguwlkficselffdm",
    NullableValue = null,
},
    NullableValue = null,
},
            new Stringtext0M
{
    Id = 51,
    Value = "fxwwgiplyo",
    ModelInner = null,
    NullableValue = null,
},
            new Stringtext0M
{
    Id = 52,
    Value = "nlmjhhrgwowfca",
    ModelInner = new Stringtext0MI
{
    Id = 23,
    Value = "d",
    NullableValue = null,
},
    NullableValue = "xqojadrwrtnqcs",
},
            new Stringtext0M
{
    Id = 54,
    Value = "yw",
    ModelInner = null,
    NullableValue = "iatsehfaqwcichuoxdwikfvafmyt",
},
            new Stringtext0M
{
    Id = 62,
    Value = "iugtb",
    ModelInner = new Stringtext0MI
{
    Id = 31,
    Value = "vjntyvvclvl",
    NullableValue = null,
},
    NullableValue = "msbbiumhfakosuudlxc",
},
            new Stringtext0M
{
    Id = 71,
    Value = "aiusqaugbjdgpsnrmatqubexkly",
    ModelInner = null,
    NullableValue = "toejv",
},
            new Stringtext0M
{
    Id = 77,
    Value = "lgpgpdj",
    ModelInner = new Stringtext0MI
{
    Id = 34,
    Value = "xuwaylthgaeenxvcpkvekcwyugy",
    NullableValue = "ndvfrugoovpqlbdkoar",
},
    NullableValue = "ujfbigjngrpndbrnysfpwwcdqia",
},
            new Stringtext0M
{
    Id = 80,
    Value = "xqlgeylyg",
    ModelInner = null,
    NullableValue = null,
},
            new Stringtext0M
{
    Id = 89,
    Value = "ajogafdhmfhwatqecggjtktmtr",
    ModelInner = new Stringtext0MI
{
    Id = 41,
    Value = "impfxvmjgc",
    NullableValue = null,
},
    NullableValue = "moqrsqko",
},
            new Stringtext0M
{
    Id = 90,
    Value = "hyelhka",
    ModelInner = null,
    NullableValue = "fnnotiw",
},
            new Stringtext0M
{
    Id = 92,
    Value = "xencaqivxyiiamkojlni",
    ModelInner = new Stringtext0MI
{
    Id = 45,
    Value = "efagvcmvhupfwtavyfcsqxeepcic",
    NullableValue = null,
},
    NullableValue = "kaeuasvqfqjmbiypbmiigohn",
},
            new Stringtext0M
{
    Id = 97,
    Value = "askkiqop",
    ModelInner = null,
    NullableValue = null,
},
            new Stringtext0M
{
    Id = 98,
    Value = "thkirnwsbnwwqenfdctvfy",
    ModelInner = new Stringtext0MI
{
    Id = 51,
    Value = "yfyyrcvxqwsqllpsknsmgatchsqw",
    NullableValue = null,
},
    NullableValue = "hgbaxwvkxpkkfi",
},
            new Stringtext0M
{
    Id = 103,
    Value = "xlubrykkwyeomtolbdowakksupepu",
    ModelInner = null,
    NullableValue = null,
},
            new Stringtext0M
{
    Id = 108,
    Value = "ttikalokedggvrffscogb",
    ModelInner = new Stringtext0MI
{
    Id = 52,
    Value = "ibfkoyqqimwnycldqswdoojiemuy",
    NullableValue = "ha",
},
    NullableValue = null,
},
            new Stringtext0M
{
    Id = 116,
    Value = "pcqmeydjquirltg",
    ModelInner = null,
    NullableValue = null,
},
            new Stringtext0M
{
    Id = 124,
    Value = "rlkqhnvueorxbaduoseqquatiubch",
    ModelInner = new Stringtext0MI
{
    Id = 53,
    Value = "pxilwaxgvnunxgjnatoagrkr",
    NullableValue = null,
},
    NullableValue = "bvqr",
},
            new Stringtext0M
{
    Id = 128,
    Value = "jlhifrkrurajigrjseul",
    ModelInner = null,
    NullableValue = "tiqmkaqvcgbbngwcbogckx",
},
            new Stringtext0M
{
    Id = 136,
    Value = "fkqdapgclkiswwxdtdwom",
    ModelInner = new Stringtext0MI
{
    Id = 61,
    Value = "",
    NullableValue = null,
},
    NullableValue = "puvmpbadavbubwfgr",
},
            new Stringtext0M
{
    Id = 138,
    Value = "jdgntecswkben",
    ModelInner = null,
    NullableValue = null,
},
            new Stringtext0M
{
    Id = 144,
    Value = "ufrkcsyslwffrggdaaka",
    ModelInner = new Stringtext0MI
{
    Id = 63,
    Value = "gsfdtqnisulxqsc",
    NullableValue = null,
},
    NullableValue = "ormvpnldypgybyxcyrxfp",
},
            new Stringtext0M
{
    Id = 151,
    Value = "tqmquygygalpdyesopewnwuxp",
    ModelInner = null,
    NullableValue = "o",
},
            new Stringtext0M
{
    Id = 152,
    Value = "mcuuenfkiececjmfafmsoddc",
    ModelInner = new Stringtext0MI
{
    Id = 71,
    Value = "fsjaqsjcrwmeihq",
    NullableValue = null,
},
    NullableValue = null,
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
                parametr1.Value = 89;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 51;
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
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
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

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 89;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 97;
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
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
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
                parametr1.Value = 116;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 54;
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
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
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
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatStringtext0M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatStringtext0M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatStringtext0M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatStringtext0M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatStringtext0M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatStringtext0M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatStringtext0M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatStringtext0M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatStringtext0M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatStringtext0M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatStringtext0M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatStringtext0M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatStringtext0M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatStringtext0M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatStringtext0M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatStringtext0M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatStringtext0M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatStringtext0M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatStringtext0M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatStringtext0M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatStringtext0M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatStringtext0M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatStringtext0M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatStringtext0M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatStringtext0M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatStringtext0M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatStringtext0M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatStringtext0M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatStringtext0M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatStringtext0M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatStringtext0M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatStringtext0M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatStringtext0M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatStringtext0M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatStringtext0M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatStringtext0M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatStringtext0M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatStringtext0M.AssertModel(secondItems2[18],_testData[29], false);
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
                parametr1.Value = 124;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 128;
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
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatStringtext0M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatStringtext0M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatStringtext0M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatStringtext0M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatStringtext0M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatStringtext0M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatStringtext0M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatStringtext0M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatStringtext0M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatStringtext0M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatStringtext0M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatStringtext0M.AssertModel(firstItems2[5],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                        FlatStringtext0M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatStringtext0M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatStringtext0M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatStringtext0M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatStringtext0M.AssertModel(secondItems1[4],_testData[29], false);
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
                parametr1.Value = 89;
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatStringtext0M.AssertModel(models[0],_testData[26], false);
                        FlatStringtext0M.AssertModel(models[1],_testData[27], false);
                        FlatStringtext0M.AssertModel(models[2],_testData[28], false);
                        FlatStringtext0M.AssertModel(models[3],_testData[29], false);
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
                parametr1.Value = 71;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 35;
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
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                        FlatStringtext0M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatStringtext0M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatStringtext0M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatStringtext0M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatStringtext0M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatStringtext0M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatStringtext0M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatStringtext0M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatStringtext0M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatStringtext0M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatStringtext0M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatStringtext0M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatStringtext0M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatStringtext0M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatStringtext0M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatStringtext0M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatStringtext0M.AssertModel(firstItems1[16],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatStringtext0M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatStringtext0M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatStringtext0M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatStringtext0M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatStringtext0M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatStringtext0M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatStringtext0M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatStringtext0M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatStringtext0M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatStringtext0M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatStringtext0M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatStringtext0M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatStringtext0M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatStringtext0M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatStringtext0M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatStringtext0M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatStringtext0M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatStringtext0M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatStringtext0M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatStringtext0M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatStringtext0M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatStringtext0M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatStringtext0M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatStringtext0M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatStringtext0M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatStringtext0M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatStringtext0M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatStringtext0M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatStringtext0M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatStringtext0M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatStringtext0M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatStringtext0M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatStringtext0M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatStringtext0M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatStringtext0M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatStringtext0M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatStringtext0M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatStringtext0M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatStringtext0M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatStringtext0M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatStringtext0M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatStringtext0M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatStringtext0M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatStringtext0M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatStringtext0M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatStringtext0M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatStringtext0M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatStringtext0M.AssertModel(secondItems2[23],_testData[29], false);
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
                parametr1.Value = 18;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 80;
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
        public async Task DbConnectionDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 116;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 35;
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
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatStringtext0M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatStringtext0M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatStringtext0M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatStringtext0M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatStringtext0M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatStringtext0M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatStringtext0M.AssertModel(firstItems1[6],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatStringtext0M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatStringtext0M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatStringtext0M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatStringtext0M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatStringtext0M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatStringtext0M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatStringtext0M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatStringtext0M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatStringtext0M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatStringtext0M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatStringtext0M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatStringtext0M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatStringtext0M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatStringtext0M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatStringtext0M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatStringtext0M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatStringtext0M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatStringtext0M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatStringtext0M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatStringtext0M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatStringtext0M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatStringtext0M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatStringtext0M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatStringtext0M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatStringtext0M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatStringtext0M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatStringtext0M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatStringtext0M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatStringtext0M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatStringtext0M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatStringtext0M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatStringtext0M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatStringtext0M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatStringtext0M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatStringtext0M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatStringtext0M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatStringtext0M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatStringtext0M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatStringtext0M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatStringtext0M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatStringtext0M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatStringtext0M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatStringtext0M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatStringtext0M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatStringtext0M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatStringtext0M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatStringtext0M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatStringtext0M.AssertModel(secondItems2[23],_testData[29], false);
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
                parametr1.Value = 62;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 39;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((IStringSingleTypetext)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
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
                        Assert.That(models, Has.Count.EqualTo(23));

                        Stringtext0M.AssertModel(models[0],_testData[7], false);
                        Stringtext0M.AssertModel(models[1],_testData[8], false);
                        Stringtext0M.AssertModel(models[2],_testData[9], false);
                        Stringtext0M.AssertModel(models[3],_testData[10], false);
                        Stringtext0M.AssertModel(models[4],_testData[11], false);
                        Stringtext0M.AssertModel(models[5],_testData[12], false);
                        Stringtext0M.AssertModel(models[6],_testData[13], false);
                        Stringtext0M.AssertModel(models[7],_testData[14], false);
                        Stringtext0M.AssertModel(models[8],_testData[15], false);
                        Stringtext0M.AssertModel(models[9],_testData[16], false);
                        Stringtext0M.AssertModel(models[10],_testData[17], false);
                        Stringtext0M.AssertModel(models[11],_testData[18], false);
                        Stringtext0M.AssertModel(models[12],_testData[19], false);
                        Stringtext0M.AssertModel(models[13],_testData[20], false);
                        Stringtext0M.AssertModel(models[14],_testData[21], false);
                        Stringtext0M.AssertModel(models[15],_testData[22], false);
                        Stringtext0M.AssertModel(models[16],_testData[23], false);
                        Stringtext0M.AssertModel(models[17],_testData[24], false);
                        Stringtext0M.AssertModel(models[18],_testData[25], false);
                        Stringtext0M.AssertModel(models[19],_testData[26], false);
                        Stringtext0M.AssertModel(models[20],_testData[27], false);
                        Stringtext0M.AssertModel(models[21],_testData[28], false);
                        Stringtext0M.AssertModel(models[22],_testData[29], false);
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
                parametr1.Value = 98;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 108;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((IStringSingleTypetext)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        Stringtext0M.AssertModel(models[0],_testData[22], false);
                        Stringtext0M.AssertModel(models[1],_testData[23], false);
                        Stringtext0M.AssertModel(models[2],_testData[24], false);
                        Stringtext0M.AssertModel(models[3],_testData[25], false);
                        Stringtext0M.AssertModel(models[4],_testData[26], false);
                        Stringtext0M.AssertModel(models[5],_testData[27], false);
                        Stringtext0M.AssertModel(models[6],_testData[28], false);
                        Stringtext0M.AssertModel(models[7],_testData[29], false);
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
                await ((IStringSingleTypetext)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 54, query1, 39, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatStringtext0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatStringtext0M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatStringtext0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatStringtext0M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatStringtext0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatStringtext0M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatStringtext0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatStringtext0M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatStringtext0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatStringtext0M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatStringtext0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatStringtext0M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatStringtext0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatStringtext0M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatStringtext0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatStringtext0M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatStringtext0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatStringtext0M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatStringtext0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatStringtext0M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatStringtext0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatStringtext0M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatStringtext0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatStringtext0M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatStringtext0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatStringtext0M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatStringtext0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatStringtext0M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatStringtext0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatStringtext0M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatStringtext0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatStringtext0M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatStringtext0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatStringtext0M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatStringtext0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatStringtext0M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatStringtext0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatStringtext0M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatStringtext0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatStringtext0M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatStringtext0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatStringtext0M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatStringtext0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatStringtext0M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatStringtext0M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatStringtext0M.AssertModel(secondItems2[22],_testData[29], false);
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
                await ((IStringSingleTypetext)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 128, query1, 35, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatStringtext0M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatStringtext0M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatStringtext0M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatStringtext0M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatStringtext0M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatStringtext0M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatStringtext0M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatStringtext0M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatStringtext0M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatStringtext0M.AssertModel(firstItems2[4],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatStringtext0M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatStringtext0M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatStringtext0M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatStringtext0M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatStringtext0M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatStringtext0M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatStringtext0M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatStringtext0M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatStringtext0M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatStringtext0M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatStringtext0M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatStringtext0M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatStringtext0M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatStringtext0M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatStringtext0M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatStringtext0M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatStringtext0M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatStringtext0M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatStringtext0M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatStringtext0M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatStringtext0M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatStringtext0M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatStringtext0M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatStringtext0M.AssertModel(secondItems1[23],_testData[29], false);
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
                 ((IStringSingleTypetext)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 90, query1, 103, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatStringtext0M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatStringtext0M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatStringtext0M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatStringtext0M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatStringtext0M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatStringtext0M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatStringtext0M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatStringtext0M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatStringtext0M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatStringtext0M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatStringtext0M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatStringtext0M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatStringtext0M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatStringtext0M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatStringtext0M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatStringtext0M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatStringtext0M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatStringtext0M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatStringtext0M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatStringtext0M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatStringtext0M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatStringtext0M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatStringtext0M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatStringtext0M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatStringtext0M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatStringtext0M.AssertModel(firstItems2[12],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatStringtext0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatStringtext0M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatStringtext0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatStringtext0M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatStringtext0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatStringtext0M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatStringtext0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatStringtext0M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatStringtext0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatStringtext0M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatStringtext0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatStringtext0M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatStringtext0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatStringtext0M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatStringtext0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatStringtext0M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatStringtext0M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatStringtext0M.AssertModel(secondItems2[8],_testData[29], false);
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
                 ((IStringSingleTypetext)this).DbConnectionMMDynQuerySelectModelBatch(connection, 138, query1, 71, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatStringtext0M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatStringtext0M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatStringtext0M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatStringtext0M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatStringtext0M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatStringtext0M.AssertModel(firstItems2[2],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                        FlatStringtext0M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatStringtext0M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatStringtext0M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatStringtext0M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatStringtext0M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatStringtext0M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatStringtext0M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatStringtext0M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatStringtext0M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatStringtext0M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatStringtext0M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatStringtext0M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatStringtext0M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatStringtext0M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatStringtext0M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatStringtext0M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatStringtext0M.AssertModel(secondItems1[16],_testData[29], false);
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
                foreach(var batchResult in await ((IStringSingleTypetext)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 71, query1, 136, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatStringtext0M.AssertModel(models[0],_testData[13], false);
                        FlatStringtext0M.AssertModel(models[1],_testData[14], false);
                        FlatStringtext0M.AssertModel(models[2],_testData[15], false);
                        FlatStringtext0M.AssertModel(models[3],_testData[16], false);
                        FlatStringtext0M.AssertModel(models[4],_testData[17], false);
                        FlatStringtext0M.AssertModel(models[5],_testData[18], false);
                        FlatStringtext0M.AssertModel(models[6],_testData[19], false);
                        FlatStringtext0M.AssertModel(models[7],_testData[20], false);
                        FlatStringtext0M.AssertModel(models[8],_testData[21], false);
                        FlatStringtext0M.AssertModel(models[9],_testData[22], false);
                        FlatStringtext0M.AssertModel(models[10],_testData[23], false);
                        FlatStringtext0M.AssertModel(models[11],_testData[24], false);
                        FlatStringtext0M.AssertModel(models[12],_testData[25], false);
                        FlatStringtext0M.AssertModel(models[13],_testData[26], false);
                        FlatStringtext0M.AssertModel(models[14],_testData[27], false);
                        FlatStringtext0M.AssertModel(models[15],_testData[28], false);
                        FlatStringtext0M.AssertModel(models[16],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatStringtext0M.AssertModel(models[0],_testData[26], false);
                        FlatStringtext0M.AssertModel(models[1],_testData[27], false);
                        FlatStringtext0M.AssertModel(models[2],_testData[28], false);
                        FlatStringtext0M.AssertModel(models[3],_testData[29], false);
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
                await ((IStringSingleTypetext)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 89, query1, 16, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
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
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatStringtext0M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatStringtext0M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatStringtext0M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatStringtext0M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatStringtext0M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatStringtext0M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatStringtext0M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatStringtext0M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatStringtext0M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatStringtext0M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatStringtext0M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatStringtext0M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatStringtext0M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatStringtext0M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatStringtext0M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatStringtext0M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatStringtext0M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatStringtext0M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatStringtext0M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatStringtext0M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatStringtext0M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatStringtext0M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatStringtext0M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatStringtext0M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatStringtext0M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatStringtext0M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatStringtext0M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatStringtext0M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatStringtext0M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatStringtext0M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatStringtext0M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatStringtext0M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatStringtext0M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatStringtext0M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatStringtext0M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatStringtext0M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatStringtext0M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatStringtext0M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatStringtext0M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatStringtext0M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatStringtext0M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatStringtext0M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatStringtext0M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatStringtext0M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatStringtext0M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatStringtext0M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatStringtext0M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatStringtext0M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatStringtext0M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatStringtext0M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatStringtext0M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatStringtext0M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatStringtext0M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatStringtext0M.AssertModel(secondItems2[26],_testData[29], false);
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
                foreach(var batchResult in  ((IStringSingleTypetext)this).DbConnectionSTDynQuerySelectModelBatch(connection, 71, query1, 80, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatStringtext0M.AssertModel(models[0],_testData[13], false);
                        FlatStringtext0M.AssertModel(models[1],_testData[14], false);
                        FlatStringtext0M.AssertModel(models[2],_testData[15], false);
                        FlatStringtext0M.AssertModel(models[3],_testData[16], false);
                        FlatStringtext0M.AssertModel(models[4],_testData[17], false);
                        FlatStringtext0M.AssertModel(models[5],_testData[18], false);
                        FlatStringtext0M.AssertModel(models[6],_testData[19], false);
                        FlatStringtext0M.AssertModel(models[7],_testData[20], false);
                        FlatStringtext0M.AssertModel(models[8],_testData[21], false);
                        FlatStringtext0M.AssertModel(models[9],_testData[22], false);
                        FlatStringtext0M.AssertModel(models[10],_testData[23], false);
                        FlatStringtext0M.AssertModel(models[11],_testData[24], false);
                        FlatStringtext0M.AssertModel(models[12],_testData[25], false);
                        FlatStringtext0M.AssertModel(models[13],_testData[26], false);
                        FlatStringtext0M.AssertModel(models[14],_testData[27], false);
                        FlatStringtext0M.AssertModel(models[15],_testData[28], false);
                        FlatStringtext0M.AssertModel(models[16],_testData[29], false);
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
                 ((IStringSingleTypetext)this).DbConnectionDynQuerySelectModelBatch(connection, 27, query1, 8, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatStringtext0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatStringtext0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatStringtext0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatStringtext0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatStringtext0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatStringtext0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatStringtext0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatStringtext0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatStringtext0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatStringtext0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatStringtext0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatStringtext0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatStringtext0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatStringtext0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatStringtext0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatStringtext0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatStringtext0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatStringtext0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatStringtext0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatStringtext0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatStringtext0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatStringtext0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatStringtext0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatStringtext0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatStringtext0M.AssertModel(firstItems1[24],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatStringtext0M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatStringtext0M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatStringtext0M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatStringtext0M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatStringtext0M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatStringtext0M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatStringtext0M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatStringtext0M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatStringtext0M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatStringtext0M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatStringtext0M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatStringtext0M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatStringtext0M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatStringtext0M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatStringtext0M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatStringtext0M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatStringtext0M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatStringtext0M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatStringtext0M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatStringtext0M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatStringtext0M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatStringtext0M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatStringtext0M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatStringtext0M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatStringtext0M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatStringtext0M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatStringtext0M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatStringtext0M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatStringtext0M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatStringtext0M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatStringtext0M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatStringtext0M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatStringtext0M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatStringtext0M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatStringtext0M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatStringtext0M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatStringtext0M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatStringtext0M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatStringtext0M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatStringtext0M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatStringtext0M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatStringtext0M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatStringtext0M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatStringtext0M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatStringtext0M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatStringtext0M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatStringtext0M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatStringtext0M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatStringtext0M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatStringtext0M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatStringtext0M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatStringtext0M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatStringtext0M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatStringtext0M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatStringtext0M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatStringtext0M.AssertModel(secondItems2[27],_testData[29], false);
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
                foreach(var batchResult in await ((IStringSingleTypetext)this).DbConnectionSTSelectModelBatchAsync(connection, 71, 71))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        Stringtext0M.AssertModel(models[0],_testData[13], false);
                        Stringtext0M.AssertModel(models[1],_testData[14], false);
                        Stringtext0M.AssertModel(models[2],_testData[15], false);
                        Stringtext0M.AssertModel(models[3],_testData[16], false);
                        Stringtext0M.AssertModel(models[4],_testData[17], false);
                        Stringtext0M.AssertModel(models[5],_testData[18], false);
                        Stringtext0M.AssertModel(models[6],_testData[19], false);
                        Stringtext0M.AssertModel(models[7],_testData[20], false);
                        Stringtext0M.AssertModel(models[8],_testData[21], false);
                        Stringtext0M.AssertModel(models[9],_testData[22], false);
                        Stringtext0M.AssertModel(models[10],_testData[23], false);
                        Stringtext0M.AssertModel(models[11],_testData[24], false);
                        Stringtext0M.AssertModel(models[12],_testData[25], false);
                        Stringtext0M.AssertModel(models[13],_testData[26], false);
                        Stringtext0M.AssertModel(models[14],_testData[27], false);
                        Stringtext0M.AssertModel(models[15],_testData[28], false);
                        Stringtext0M.AssertModel(models[16],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        Stringtext0M.AssertModel(models[0],_testData[13], false);
                        Stringtext0M.AssertModel(models[1],_testData[14], false);
                        Stringtext0M.AssertModel(models[2],_testData[15], false);
                        Stringtext0M.AssertModel(models[3],_testData[16], false);
                        Stringtext0M.AssertModel(models[4],_testData[17], false);
                        Stringtext0M.AssertModel(models[5],_testData[18], false);
                        Stringtext0M.AssertModel(models[6],_testData[19], false);
                        Stringtext0M.AssertModel(models[7],_testData[20], false);
                        Stringtext0M.AssertModel(models[8],_testData[21], false);
                        Stringtext0M.AssertModel(models[9],_testData[22], false);
                        Stringtext0M.AssertModel(models[10],_testData[23], false);
                        Stringtext0M.AssertModel(models[11],_testData[24], false);
                        Stringtext0M.AssertModel(models[12],_testData[25], false);
                        Stringtext0M.AssertModel(models[13],_testData[26], false);
                        Stringtext0M.AssertModel(models[14],_testData[27], false);
                        Stringtext0M.AssertModel(models[15],_testData[28], false);
                        Stringtext0M.AssertModel(models[16],_testData[29], false);
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
                foreach(var batchResult in  ((IStringSingleTypetext)this).DbConnectionSTSelectModelBatch(connection, 2, 71))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        Stringtext0M.AssertModel(models[0],_testData[13], false);
                        Stringtext0M.AssertModel(models[1],_testData[14], false);
                        Stringtext0M.AssertModel(models[2],_testData[15], false);
                        Stringtext0M.AssertModel(models[3],_testData[16], false);
                        Stringtext0M.AssertModel(models[4],_testData[17], false);
                        Stringtext0M.AssertModel(models[5],_testData[18], false);
                        Stringtext0M.AssertModel(models[6],_testData[19], false);
                        Stringtext0M.AssertModel(models[7],_testData[20], false);
                        Stringtext0M.AssertModel(models[8],_testData[21], false);
                        Stringtext0M.AssertModel(models[9],_testData[22], false);
                        Stringtext0M.AssertModel(models[10],_testData[23], false);
                        Stringtext0M.AssertModel(models[11],_testData[24], false);
                        Stringtext0M.AssertModel(models[12],_testData[25], false);
                        Stringtext0M.AssertModel(models[13],_testData[26], false);
                        Stringtext0M.AssertModel(models[14],_testData[27], false);
                        Stringtext0M.AssertModel(models[15],_testData[28], false);
                        Stringtext0M.AssertModel(models[16],_testData[29], false);
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
                ((IStringSingleTypetext)this).SetDbConnectionSelectModelParametrs(cmd, 92);
                var models = await ((IStringSingleTypetext)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(12));
Stringtext0M.AssertModel(models[0],_testData[18], false);Stringtext0M.AssertModel(models[1],_testData[19], false);Stringtext0M.AssertModel(models[2],_testData[20], false);Stringtext0M.AssertModel(models[3],_testData[21], false);Stringtext0M.AssertModel(models[4],_testData[22], false);Stringtext0M.AssertModel(models[5],_testData[23], false);Stringtext0M.AssertModel(models[6],_testData[24], false);Stringtext0M.AssertModel(models[7],_testData[25], false);Stringtext0M.AssertModel(models[8],_testData[26], false);Stringtext0M.AssertModel(models[9],_testData[27], false);Stringtext0M.AssertModel(models[10],_testData[28], false);Stringtext0M.AssertModel(models[11],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IStringSingleTypetext)this).CreateDbConnectionSelectModelCommand(connection);
                ((IStringSingleTypetext)this).SetDbConnectionSelectModelParametrs(cmd, 27);
                var models =  ((IStringSingleTypetext)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(25));
Stringtext0M.AssertModel(models[0],_testData[5], false);Stringtext0M.AssertModel(models[1],_testData[6], false);Stringtext0M.AssertModel(models[2],_testData[7], false);Stringtext0M.AssertModel(models[3],_testData[8], false);Stringtext0M.AssertModel(models[4],_testData[9], false);Stringtext0M.AssertModel(models[5],_testData[10], false);Stringtext0M.AssertModel(models[6],_testData[11], false);Stringtext0M.AssertModel(models[7],_testData[12], false);Stringtext0M.AssertModel(models[8],_testData[13], false);Stringtext0M.AssertModel(models[9],_testData[14], false);Stringtext0M.AssertModel(models[10],_testData[15], false);Stringtext0M.AssertModel(models[11],_testData[16], false);Stringtext0M.AssertModel(models[12],_testData[17], false);Stringtext0M.AssertModel(models[13],_testData[18], false);Stringtext0M.AssertModel(models[14],_testData[19], false);Stringtext0M.AssertModel(models[15],_testData[20], false);Stringtext0M.AssertModel(models[16],_testData[21], false);Stringtext0M.AssertModel(models[17],_testData[22], false);Stringtext0M.AssertModel(models[18],_testData[23], false);Stringtext0M.AssertModel(models[19],_testData[24], false);Stringtext0M.AssertModel(models[20],_testData[25], false);Stringtext0M.AssertModel(models[21],_testData[26], false);Stringtext0M.AssertModel(models[22],_testData[27], false);Stringtext0M.AssertModel(models[23],_testData[28], false);Stringtext0M.AssertModel(models[24],_testData[29], false);
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
                Assert.That((System.Int32)model[0], Is.EqualTo((2)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("jsmojpcogdhgtwwcegyrmowwdawwq")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("taqkdteilfnmregbboy")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("vqj")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("njvbaeau")));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("euwalirfqrcx")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("anqlfs")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("sioajxnfhisuobf")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("uqd")));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("w")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("opbq")));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("aoktaxqlchocmtqbjqflx")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("helwvsjdqskxmrakhxceppwxwkihc")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("qdjvmaxyjgwybvoita")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("ehfgfropijoqbulltkeubsof")));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("pyiaknocoxikokvwfeuycg")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("qmkcuvqfudvqphfcdn")));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((45)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("eehyjegxykytekpljaiujouvh")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("fguwlkficselffdm")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("fxwwgiplyo")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("nlmjhhrgwowfca")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("d")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("xqojadrwrtnqcs")));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("yw")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("iatsehfaqwcichuoxdwikfvafmyt")));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("iugtb")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("vjntyvvclvl")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("msbbiumhfakosuudlxc")));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("aiusqaugbjdgpsnrmatqubexkly")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("toejv")));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("lgpgpdj")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("xuwaylthgaeenxvcpkvekcwyugy")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("ndvfrugoovpqlbdkoar")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("ujfbigjngrpndbrnysfpwwcdqia")));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("xqlgeylyg")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("ajogafdhmfhwatqecggjtktmtr")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("impfxvmjgc")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("moqrsqko")));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("hyelhka")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("fnnotiw")));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("xencaqivxyiiamkojlni")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("efagvcmvhupfwtavyfcsqxeepcic")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("kaeuasvqfqjmbiypbmiigohn")));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("askkiqop")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("thkirnwsbnwwqenfdctvfy")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("yfyyrcvxqwsqllpsknsmgatchsqw")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("hgbaxwvkxpkkfi")));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("xlubrykkwyeomtolbdowakksupepu")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("ttikalokedggvrffscogb")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("ibfkoyqqimwnycldqswdoojiemuy")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("ha")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((116)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("pcqmeydjquirltg")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("rlkqhnvueorxbaduoseqquatiubch")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("pxilwaxgvnunxgjnatoagrkr")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("bvqr")));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("jlhifrkrurajigrjseul")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("tiqmkaqvcgbbngwcbogckx")));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("fkqdapgclkiswwxdtdwom")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("puvmpbadavbubwfgr")));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("jdgntecswkben")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("ufrkcsyslwffrggdaaka")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("gsfdtqnisulxqsc")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("ormvpnldypgybyxcyrxfp")));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("tqmquygygalpdyesopewnwuxp")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("o")));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((152)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("mcuuenfkiececjmfafmsoddc")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("fsjaqsjcrwmeihq")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

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
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("jsmojpcogdhgtwwcegyrmowwdawwq")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("taqkdteilfnmregbboy")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("vqj")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("njvbaeau")));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("euwalirfqrcx")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("anqlfs")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("sioajxnfhisuobf")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("uqd")));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("w")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("opbq")));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("aoktaxqlchocmtqbjqflx")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("helwvsjdqskxmrakhxceppwxwkihc")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("qdjvmaxyjgwybvoita")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("ehfgfropijoqbulltkeubsof")));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("pyiaknocoxikokvwfeuycg")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("qmkcuvqfudvqphfcdn")));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((45)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("eehyjegxykytekpljaiujouvh")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("fguwlkficselffdm")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("fxwwgiplyo")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("nlmjhhrgwowfca")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("d")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("xqojadrwrtnqcs")));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((54)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("yw")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("iatsehfaqwcichuoxdwikfvafmyt")));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("iugtb")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("vjntyvvclvl")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("msbbiumhfakosuudlxc")));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("aiusqaugbjdgpsnrmatqubexkly")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("toejv")));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("lgpgpdj")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("xuwaylthgaeenxvcpkvekcwyugy")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("ndvfrugoovpqlbdkoar")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("ujfbigjngrpndbrnysfpwwcdqia")));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("xqlgeylyg")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("ajogafdhmfhwatqecggjtktmtr")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("impfxvmjgc")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("moqrsqko")));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("hyelhka")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("fnnotiw")));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("xencaqivxyiiamkojlni")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("efagvcmvhupfwtavyfcsqxeepcic")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("kaeuasvqfqjmbiypbmiigohn")));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("askkiqop")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("thkirnwsbnwwqenfdctvfy")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("yfyyrcvxqwsqllpsknsmgatchsqw")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("hgbaxwvkxpkkfi")));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("xlubrykkwyeomtolbdowakksupepu")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("ttikalokedggvrffscogb")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("ibfkoyqqimwnycldqswdoojiemuy")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("ha")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((116)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("pcqmeydjquirltg")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("rlkqhnvueorxbaduoseqquatiubch")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("pxilwaxgvnunxgjnatoagrkr")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("bvqr")));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("jlhifrkrurajigrjseul")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("tiqmkaqvcgbbngwcbogckx")));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("fkqdapgclkiswwxdtdwom")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("puvmpbadavbubwfgr")));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("jdgntecswkben")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("ufrkcsyslwffrggdaaka")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("gsfdtqnisulxqsc")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("ormvpnldypgybyxcyrxfp")));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("tqmquygygalpdyesopewnwuxp")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("o")));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((152)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("mcuuenfkiececjmfafmsoddc")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("fsjaqsjcrwmeihq")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

#endregion

    }
}

