

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
            queryMapType: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringSingleTypetext)
            ), 
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                parametrName: "id",
                methodParametrName: "id", 
                sqlDbType: (System.Data.SqlDbType)(8)
                ),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.String),
                parametrName: "value",
                methodParametrName: "value",
                sqlDbType: (System.Data.SqlDbType)(18)
                ),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.String), 
                parametrName: "nullablevalue",
                methodParametrName: "nullablevalue",
                sqlDbType: (System.Data.SqlDbType)(18)
                )
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

                changedRows =  ((IStringSingleTypetext)this).InsertModelInner(connection, 787283776, "rlmeequwkdxydcuikswadxudmg", null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IStringSingleTypetext)this).InsertModelInner(connection, 76172232, "fwgtsdpdunhbwcwgrtcsas", null);
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

                changedRows = await ((IStringSingleTypetext)this).InsertModelInnerAsync(connection, 270065568, "hkqebnbyxxfbry", "t");
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).InsertModelInnerAsync(connection, 224209119, "ykp", null);
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
            queryMapType: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringSingleTypetext)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)11
                ),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.String), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)0
                ),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.String), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)0, 
                nullable: true
                )
            ]
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

                changedRows =  ((IStringSingleTypetext)this).DbConnectionInsertInnerModel(connection, 1426085088, "ioo", "jntquhlvvhaexxhue");
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

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertInnerModelAsync(connection, 1904673088, "ngiymkoxvrnorcqrhsouuitbly", null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertInnerModelAsync(connection, 1939530278, "bm", "vtfgwskgwy");
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertInnerModelAsync(connection, 1692068371, "", null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertInnerModelAsync(connection, 678758467, "cjhsyp", "ukfrhdltcqwualdg");
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertInnerModelAsync(connection, 1367930567, "bpfpvqkdwwatnhlgbwrye", "pheiitrjudgsfp");
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertInnerModelAsync(connection, 446504904, "wgjryc", null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertInnerModelAsync(connection, 1624956286, "uotyykivgnolvlcybrifjnyhvpcon", "jajhhlwitjwkhuhiuoayxwxi");
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertInnerModelAsync(connection, 2056145983, "muvawanfbratcxbjryksiktmdxn", "duuuqdylwknpkprcsklfp");
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertInnerModelAsync(connection, 1292527774, "gswswtemxlccmidpapoehrmadkbo", null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertInnerModelAsync(connection, 1633287873, "bqeobus", "hytnbvrrlkhjjdamduo");
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
            queryMapType: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringSingleTypetext)
            ), 
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                parametrName: "id",
                methodParametrName: "id",
                sqlDbType: (System.Data.SqlDbType)(8)
            ),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.String), 
                parametrName: "value", 
                methodParametrName: "value", 
                sqlDbType: (System.Data.SqlDbType)(18)
            ),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.String), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                sqlDbType: (System.Data.SqlDbType)(18),
                nullable: true
            ),
            Gedaq.SqlClient.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "stringtext0mi_id", 
                methodParametrName: "stringtext0mi_id", 
                sqlDbType: (System.Data.SqlDbType)(8),
                nullable: true
            )
            ]
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

                changedRows =  ((IStringSingleTypetext)this).InsertModel(connection, 1591264898, "tmdctgbyi", null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IStringSingleTypetext)this).InsertModel(connection, 254008058, "aqefcrhafeyfrenvtnhg", null, 787283776);
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

                changedRows = await ((IStringSingleTypetext)this).InsertModelAsync(connection, 939168337, "sjietmnsovprt", null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).InsertModelAsync(connection, 773576257, "icrbhluhfeclqcwiybvw", "kstvhlvsbpvjtmn", 76172232);
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
            queryMapType: null,
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
                nullable: true
),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "stringtext0mi_id", 
                methodParametrName: "stringtext0mi_id", 
                dbType: (System.Data.DbType)11,
                nullable: true
            )
            ]
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

                changedRows =  ((IStringSingleTypetext)this).DbConnectionInsertModel(connection, 44923757, "aanabbybtahdpkslhqnrymnw", "oqctqjmkvhflqkusvhyyillalglm", null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IStringSingleTypetext)this).DbConnectionInsertModel(connection, 20408822, "as", null, 270065568);
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

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertModelAsync(connection, 871194289, "", "wuoi", null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertModelAsync(connection, 1853952493, "eooisvbdiry", "stiapivepjrlwo", 224209119);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertModelAsync(connection, 1506426512, "hpwvip", "wc", null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertModelAsync(connection, 14315462, "aecn", null, 1426085088);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertModelAsync(connection, 1075729036, "wwddimlixwpryfgavhlvicuhtpmc", null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertModelAsync(connection, 1029817369, "ekiexnoahopnomudounsuwnqioyt", "ipm", 1904673088);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertModelAsync(connection, 2009683237, "g", "esanbtlohpqojcwlvce", null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertModelAsync(connection, 909526490, "rkpjbjol", null, 1939530278);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertModelAsync(connection, 1983632651, "hstcvbdiancuvhnkvxnuyls", "bxeexniantpprwwsi", null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertModelAsync(connection, 1930029542, "olvmfeortflhbjkblilryc", "ygygumifrw", 1692068371);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertModelAsync(connection, 1730990346, "ughlfokkphpdyvmexqfqwaw", "tjkkucxgvypfouv", null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertModelAsync(connection, 128817615, "rwcoifruqkoscflae", "dbfpoqpvhokctqh", 678758467);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertModelAsync(connection, 320230804, "tpwlhaonkejrqseexrkcspeteos", "byqkiciwbk", null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertModelAsync(connection, 726288705, "vlgdphlqjgyeokeupjkidot", "qewpmqurcnael", 1367930567);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertModelAsync(connection, 702765260, "errgadvvyp", "cltgv", null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertModelAsync(connection, 517689674, "omvkhaccqeqgl", "qjmsugwmvdse", 446504904);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertModelAsync(connection, 1956613322, "veinjgpawbisnivanefccw", "", null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertModelAsync(connection, 2112261214, "dhbjbpdcvmjvr", "ddkgxnlmqrrwcffifpse", 1624956286);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertModelAsync(connection, 511300623, "mserckqnyymnlxagwxvfcrutsmiqx", null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertModelAsync(connection, 586044985, "mtpekvxsfufhnvpfs", "hunkptbartiyvvjmqi", 2056145983);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertModelAsync(connection, 1751190228, "jxsniljkalworujyidi", null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertModelAsync(connection, 1337948693, "mfllkvwwpftvntbbiomndcj", null, 1292527774);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertModelAsync(connection, 1133257314, "unewvaybmpilafaobdvuckcj", null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertModelAsync(connection, 2028093643, "eygavaulnfugjlmgryw", "clgbocgula", 1633287873);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        #endregion

#region Select Models

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
            queryMapType: typeof(Stringtext0M),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringSingleTypetext)
            ),
Gedaq.SqlClient.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            parametrName: "id",
            methodParametrName: "id",
            sqlDbType: (System.Data.SqlDbType)(8)
            )
            ]
        private void SelectModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IStringSingleTypetext)this).SelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(14315462));
                Assert.That(model.Value, Is.EqualTo("aecn"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1426085088));

                Assert.That(model.ModelInner.Value, Is.EqualTo("ioo"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("jntquhlvvhaexxhue"));

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(20408822));
                Assert.That(model.Value, Is.EqualTo("as"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(270065568));

                Assert.That(model.ModelInner.Value, Is.EqualTo("hkqebnbyxxfbry"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("t"));

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(44923757));
                Assert.That(model.Value, Is.EqualTo("aanabbybtahdpkslhqnrymnw"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("oqctqjmkvhflqkusvhyyillalglm"));

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(128817615));
                Assert.That(model.Value, Is.EqualTo("rwcoifruqkoscflae"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("dbfpoqpvhokctqh"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(678758467));

                Assert.That(model.ModelInner.Value, Is.EqualTo("cjhsyp"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("ukfrhdltcqwualdg"));

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(254008058));
                Assert.That(model.Value, Is.EqualTo("aqefcrhafeyfrenvtnhg"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(787283776));

                Assert.That(model.ModelInner.Value, Is.EqualTo("rlmeequwkdxydcuikswadxudmg"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(320230804));
                Assert.That(model.Value, Is.EqualTo("tpwlhaonkejrqseexrkcspeteos"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("byqkiciwbk"));

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(511300623));
                Assert.That(model.Value, Is.EqualTo("mserckqnyymnlxagwxvfcrutsmiqx"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(517689674));
                Assert.That(model.Value, Is.EqualTo("omvkhaccqeqgl"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("qjmsugwmvdse"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(446504904));

                Assert.That(model.ModelInner.Value, Is.EqualTo("wgjryc"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(586044985));
                Assert.That(model.Value, Is.EqualTo("mtpekvxsfufhnvpfs"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("hunkptbartiyvvjmqi"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2056145983));

                Assert.That(model.ModelInner.Value, Is.EqualTo("muvawanfbratcxbjryksiktmdxn"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("duuuqdylwknpkprcsklfp"));

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(702765260));
                Assert.That(model.Value, Is.EqualTo("errgadvvyp"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("cltgv"));

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(726288705));
                Assert.That(model.Value, Is.EqualTo("vlgdphlqjgyeokeupjkidot"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("qewpmqurcnael"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1367930567));

                Assert.That(model.ModelInner.Value, Is.EqualTo("bpfpvqkdwwatnhlgbwrye"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("pheiitrjudgsfp"));

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(773576257));
                Assert.That(model.Value, Is.EqualTo("icrbhluhfeclqcwiybvw"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("kstvhlvsbpvjtmn"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(76172232));

                Assert.That(model.ModelInner.Value, Is.EqualTo("fwgtsdpdunhbwcwgrtcsas"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(871194289));
                Assert.That(model.Value, Is.EqualTo(""));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("wuoi"));

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(909526490));
                Assert.That(model.Value, Is.EqualTo("rkpjbjol"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1939530278));

                Assert.That(model.ModelInner.Value, Is.EqualTo("bm"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("vtfgwskgwy"));

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(939168337));
                Assert.That(model.Value, Is.EqualTo("sjietmnsovprt"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1029817369));
                Assert.That(model.Value, Is.EqualTo("ekiexnoahopnomudounsuwnqioyt"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("ipm"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1904673088));

                Assert.That(model.ModelInner.Value, Is.EqualTo("ngiymkoxvrnorcqrhsouuitbly"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1075729036));
                Assert.That(model.Value, Is.EqualTo("wwddimlixwpryfgavhlvicuhtpmc"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1133257314));
                Assert.That(model.Value, Is.EqualTo("unewvaybmpilafaobdvuckcj"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1337948693));
                Assert.That(model.Value, Is.EqualTo("mfllkvwwpftvntbbiomndcj"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1292527774));

                Assert.That(model.ModelInner.Value, Is.EqualTo("gswswtemxlccmidpapoehrmadkbo"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1506426512));
                Assert.That(model.Value, Is.EqualTo("hpwvip"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("wc"));

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1591264898));
                Assert.That(model.Value, Is.EqualTo("tmdctgbyi"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1730990346));
                Assert.That(model.Value, Is.EqualTo("ughlfokkphpdyvmexqfqwaw"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("tjkkucxgvypfouv"));

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1751190228));
                Assert.That(model.Value, Is.EqualTo("jxsniljkalworujyidi"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1853952493));
                Assert.That(model.Value, Is.EqualTo("eooisvbdiry"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("stiapivepjrlwo"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(224209119));

                Assert.That(model.ModelInner.Value, Is.EqualTo("ykp"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1930029542));
                Assert.That(model.Value, Is.EqualTo("olvmfeortflhbjkblilryc"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("ygygumifrw"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1692068371));

                Assert.That(model.ModelInner.Value, Is.EqualTo(""));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1956613322));
                Assert.That(model.Value, Is.EqualTo("veinjgpawbisnivanefccw"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(""));

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1983632651));
                Assert.That(model.Value, Is.EqualTo("hstcvbdiancuvhnkvxnuyls"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("bxeexniantpprwwsi"));

                Assert.That(model.ModelInner, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2009683237));
                Assert.That(model.Value, Is.EqualTo("g"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("esanbtlohpqojcwlvce"));

                Assert.That(model.ModelInner, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2028093643));
                Assert.That(model.Value, Is.EqualTo("eygavaulnfugjlmgryw"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("clgbocgula"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1633287873));

                Assert.That(model.ModelInner.Value, Is.EqualTo("bqeobus"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("hytnbvrrlkhjjdamduo"));

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2112261214));
                Assert.That(model.Value, Is.EqualTo("dhbjbpdcvmjvr"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("ddkgxnlmqrrwcffifpse"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1624956286));

                Assert.That(model.ModelInner.Value, Is.EqualTo("uotyykivgnolvlcybrifjnyhvpcon"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("jajhhlwitjwkhuhiuoayxwxi"));

            }
        }

        [Test, Order(2)]
        public async Task SelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IStringSingleTypetext)this).SelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(14315462));
                Assert.That(model.Value, Is.EqualTo("aecn"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1426085088));

                Assert.That(model.ModelInner.Value, Is.EqualTo("ioo"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("jntquhlvvhaexxhue"));

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(20408822));
                Assert.That(model.Value, Is.EqualTo("as"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(270065568));

                Assert.That(model.ModelInner.Value, Is.EqualTo("hkqebnbyxxfbry"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("t"));

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(44923757));
                Assert.That(model.Value, Is.EqualTo("aanabbybtahdpkslhqnrymnw"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("oqctqjmkvhflqkusvhyyillalglm"));

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(128817615));
                Assert.That(model.Value, Is.EqualTo("rwcoifruqkoscflae"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("dbfpoqpvhokctqh"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(678758467));

                Assert.That(model.ModelInner.Value, Is.EqualTo("cjhsyp"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("ukfrhdltcqwualdg"));

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(254008058));
                Assert.That(model.Value, Is.EqualTo("aqefcrhafeyfrenvtnhg"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(787283776));

                Assert.That(model.ModelInner.Value, Is.EqualTo("rlmeequwkdxydcuikswadxudmg"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(320230804));
                Assert.That(model.Value, Is.EqualTo("tpwlhaonkejrqseexrkcspeteos"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("byqkiciwbk"));

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(511300623));
                Assert.That(model.Value, Is.EqualTo("mserckqnyymnlxagwxvfcrutsmiqx"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(517689674));
                Assert.That(model.Value, Is.EqualTo("omvkhaccqeqgl"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("qjmsugwmvdse"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(446504904));

                Assert.That(model.ModelInner.Value, Is.EqualTo("wgjryc"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(586044985));
                Assert.That(model.Value, Is.EqualTo("mtpekvxsfufhnvpfs"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("hunkptbartiyvvjmqi"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2056145983));

                Assert.That(model.ModelInner.Value, Is.EqualTo("muvawanfbratcxbjryksiktmdxn"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("duuuqdylwknpkprcsklfp"));

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(702765260));
                Assert.That(model.Value, Is.EqualTo("errgadvvyp"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("cltgv"));

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(726288705));
                Assert.That(model.Value, Is.EqualTo("vlgdphlqjgyeokeupjkidot"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("qewpmqurcnael"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1367930567));

                Assert.That(model.ModelInner.Value, Is.EqualTo("bpfpvqkdwwatnhlgbwrye"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("pheiitrjudgsfp"));

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(773576257));
                Assert.That(model.Value, Is.EqualTo("icrbhluhfeclqcwiybvw"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("kstvhlvsbpvjtmn"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(76172232));

                Assert.That(model.ModelInner.Value, Is.EqualTo("fwgtsdpdunhbwcwgrtcsas"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(871194289));
                Assert.That(model.Value, Is.EqualTo(""));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("wuoi"));

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(909526490));
                Assert.That(model.Value, Is.EqualTo("rkpjbjol"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1939530278));

                Assert.That(model.ModelInner.Value, Is.EqualTo("bm"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("vtfgwskgwy"));

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(939168337));
                Assert.That(model.Value, Is.EqualTo("sjietmnsovprt"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1029817369));
                Assert.That(model.Value, Is.EqualTo("ekiexnoahopnomudounsuwnqioyt"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("ipm"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1904673088));

                Assert.That(model.ModelInner.Value, Is.EqualTo("ngiymkoxvrnorcqrhsouuitbly"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1075729036));
                Assert.That(model.Value, Is.EqualTo("wwddimlixwpryfgavhlvicuhtpmc"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1133257314));
                Assert.That(model.Value, Is.EqualTo("unewvaybmpilafaobdvuckcj"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1337948693));
                Assert.That(model.Value, Is.EqualTo("mfllkvwwpftvntbbiomndcj"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1292527774));

                Assert.That(model.ModelInner.Value, Is.EqualTo("gswswtemxlccmidpapoehrmadkbo"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1506426512));
                Assert.That(model.Value, Is.EqualTo("hpwvip"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("wc"));

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1591264898));
                Assert.That(model.Value, Is.EqualTo("tmdctgbyi"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1730990346));
                Assert.That(model.Value, Is.EqualTo("ughlfokkphpdyvmexqfqwaw"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("tjkkucxgvypfouv"));

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1751190228));
                Assert.That(model.Value, Is.EqualTo("jxsniljkalworujyidi"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1853952493));
                Assert.That(model.Value, Is.EqualTo("eooisvbdiry"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("stiapivepjrlwo"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(224209119));

                Assert.That(model.ModelInner.Value, Is.EqualTo("ykp"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1930029542));
                Assert.That(model.Value, Is.EqualTo("olvmfeortflhbjkblilryc"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("ygygumifrw"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1692068371));

                Assert.That(model.ModelInner.Value, Is.EqualTo(""));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1956613322));
                Assert.That(model.Value, Is.EqualTo("veinjgpawbisnivanefccw"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(""));

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1983632651));
                Assert.That(model.Value, Is.EqualTo("hstcvbdiancuvhnkvxnuyls"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("bxeexniantpprwwsi"));

                Assert.That(model.ModelInner, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2009683237));
                Assert.That(model.Value, Is.EqualTo("g"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("esanbtlohpqojcwlvce"));

                Assert.That(model.ModelInner, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2028093643));
                Assert.That(model.Value, Is.EqualTo("eygavaulnfugjlmgryw"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("clgbocgula"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1633287873));

                Assert.That(model.ModelInner.Value, Is.EqualTo("bqeobus"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("hytnbvrrlkhjjdamduo"));

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2112261214));
                Assert.That(model.Value, Is.EqualTo("dhbjbpdcvmjvr"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("ddkgxnlmqrrwcffifpse"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1624956286));

                Assert.That(model.ModelInner.Value, Is.EqualTo("uotyykivgnolvlcybrifjnyhvpcon"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("jajhhlwitjwkhuhiuoayxwxi"));

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
            queryMapType: typeof(Stringtext0M),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringSingleTypetext)
            ),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)11
                )
            ]
        private void DbConnectionSelectModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((IStringSingleTypetext)this).DbConnectionSelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(14315462));
                Assert.That(model.Value, Is.EqualTo("aecn"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1426085088));

                Assert.That(model.ModelInner.Value, Is.EqualTo("ioo"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("jntquhlvvhaexxhue"));

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(20408822));
                Assert.That(model.Value, Is.EqualTo("as"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(270065568));

                Assert.That(model.ModelInner.Value, Is.EqualTo("hkqebnbyxxfbry"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("t"));

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(44923757));
                Assert.That(model.Value, Is.EqualTo("aanabbybtahdpkslhqnrymnw"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("oqctqjmkvhflqkusvhyyillalglm"));

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(128817615));
                Assert.That(model.Value, Is.EqualTo("rwcoifruqkoscflae"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("dbfpoqpvhokctqh"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(678758467));

                Assert.That(model.ModelInner.Value, Is.EqualTo("cjhsyp"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("ukfrhdltcqwualdg"));

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(254008058));
                Assert.That(model.Value, Is.EqualTo("aqefcrhafeyfrenvtnhg"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(787283776));

                Assert.That(model.ModelInner.Value, Is.EqualTo("rlmeequwkdxydcuikswadxudmg"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(320230804));
                Assert.That(model.Value, Is.EqualTo("tpwlhaonkejrqseexrkcspeteos"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("byqkiciwbk"));

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(511300623));
                Assert.That(model.Value, Is.EqualTo("mserckqnyymnlxagwxvfcrutsmiqx"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(517689674));
                Assert.That(model.Value, Is.EqualTo("omvkhaccqeqgl"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("qjmsugwmvdse"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(446504904));

                Assert.That(model.ModelInner.Value, Is.EqualTo("wgjryc"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(586044985));
                Assert.That(model.Value, Is.EqualTo("mtpekvxsfufhnvpfs"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("hunkptbartiyvvjmqi"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2056145983));

                Assert.That(model.ModelInner.Value, Is.EqualTo("muvawanfbratcxbjryksiktmdxn"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("duuuqdylwknpkprcsklfp"));

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(702765260));
                Assert.That(model.Value, Is.EqualTo("errgadvvyp"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("cltgv"));

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(726288705));
                Assert.That(model.Value, Is.EqualTo("vlgdphlqjgyeokeupjkidot"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("qewpmqurcnael"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1367930567));

                Assert.That(model.ModelInner.Value, Is.EqualTo("bpfpvqkdwwatnhlgbwrye"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("pheiitrjudgsfp"));

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(773576257));
                Assert.That(model.Value, Is.EqualTo("icrbhluhfeclqcwiybvw"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("kstvhlvsbpvjtmn"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(76172232));

                Assert.That(model.ModelInner.Value, Is.EqualTo("fwgtsdpdunhbwcwgrtcsas"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(871194289));
                Assert.That(model.Value, Is.EqualTo(""));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("wuoi"));

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(909526490));
                Assert.That(model.Value, Is.EqualTo("rkpjbjol"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1939530278));

                Assert.That(model.ModelInner.Value, Is.EqualTo("bm"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("vtfgwskgwy"));

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(939168337));
                Assert.That(model.Value, Is.EqualTo("sjietmnsovprt"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1029817369));
                Assert.That(model.Value, Is.EqualTo("ekiexnoahopnomudounsuwnqioyt"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("ipm"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1904673088));

                Assert.That(model.ModelInner.Value, Is.EqualTo("ngiymkoxvrnorcqrhsouuitbly"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1075729036));
                Assert.That(model.Value, Is.EqualTo("wwddimlixwpryfgavhlvicuhtpmc"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1133257314));
                Assert.That(model.Value, Is.EqualTo("unewvaybmpilafaobdvuckcj"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1337948693));
                Assert.That(model.Value, Is.EqualTo("mfllkvwwpftvntbbiomndcj"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1292527774));

                Assert.That(model.ModelInner.Value, Is.EqualTo("gswswtemxlccmidpapoehrmadkbo"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1506426512));
                Assert.That(model.Value, Is.EqualTo("hpwvip"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("wc"));

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1591264898));
                Assert.That(model.Value, Is.EqualTo("tmdctgbyi"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1730990346));
                Assert.That(model.Value, Is.EqualTo("ughlfokkphpdyvmexqfqwaw"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("tjkkucxgvypfouv"));

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1751190228));
                Assert.That(model.Value, Is.EqualTo("jxsniljkalworujyidi"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1853952493));
                Assert.That(model.Value, Is.EqualTo("eooisvbdiry"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("stiapivepjrlwo"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(224209119));

                Assert.That(model.ModelInner.Value, Is.EqualTo("ykp"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1930029542));
                Assert.That(model.Value, Is.EqualTo("olvmfeortflhbjkblilryc"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("ygygumifrw"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1692068371));

                Assert.That(model.ModelInner.Value, Is.EqualTo(""));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1956613322));
                Assert.That(model.Value, Is.EqualTo("veinjgpawbisnivanefccw"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(""));

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1983632651));
                Assert.That(model.Value, Is.EqualTo("hstcvbdiancuvhnkvxnuyls"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("bxeexniantpprwwsi"));

                Assert.That(model.ModelInner, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2009683237));
                Assert.That(model.Value, Is.EqualTo("g"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("esanbtlohpqojcwlvce"));

                Assert.That(model.ModelInner, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2028093643));
                Assert.That(model.Value, Is.EqualTo("eygavaulnfugjlmgryw"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("clgbocgula"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1633287873));

                Assert.That(model.ModelInner.Value, Is.EqualTo("bqeobus"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("hytnbvrrlkhjjdamduo"));

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2112261214));
                Assert.That(model.Value, Is.EqualTo("dhbjbpdcvmjvr"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("ddkgxnlmqrrwcffifpse"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1624956286));

                Assert.That(model.ModelInner.Value, Is.EqualTo("uotyykivgnolvlcybrifjnyhvpcon"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("jajhhlwitjwkhuhiuoayxwxi"));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IStringSingleTypetext)this).DbConnectionSelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(14315462));
                Assert.That(model.Value, Is.EqualTo("aecn"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1426085088));

                Assert.That(model.ModelInner.Value, Is.EqualTo("ioo"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("jntquhlvvhaexxhue"));

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(20408822));
                Assert.That(model.Value, Is.EqualTo("as"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(270065568));

                Assert.That(model.ModelInner.Value, Is.EqualTo("hkqebnbyxxfbry"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("t"));

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(44923757));
                Assert.That(model.Value, Is.EqualTo("aanabbybtahdpkslhqnrymnw"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("oqctqjmkvhflqkusvhyyillalglm"));

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(128817615));
                Assert.That(model.Value, Is.EqualTo("rwcoifruqkoscflae"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("dbfpoqpvhokctqh"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(678758467));

                Assert.That(model.ModelInner.Value, Is.EqualTo("cjhsyp"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("ukfrhdltcqwualdg"));

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(254008058));
                Assert.That(model.Value, Is.EqualTo("aqefcrhafeyfrenvtnhg"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(787283776));

                Assert.That(model.ModelInner.Value, Is.EqualTo("rlmeequwkdxydcuikswadxudmg"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(320230804));
                Assert.That(model.Value, Is.EqualTo("tpwlhaonkejrqseexrkcspeteos"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("byqkiciwbk"));

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(511300623));
                Assert.That(model.Value, Is.EqualTo("mserckqnyymnlxagwxvfcrutsmiqx"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(517689674));
                Assert.That(model.Value, Is.EqualTo("omvkhaccqeqgl"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("qjmsugwmvdse"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(446504904));

                Assert.That(model.ModelInner.Value, Is.EqualTo("wgjryc"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(586044985));
                Assert.That(model.Value, Is.EqualTo("mtpekvxsfufhnvpfs"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("hunkptbartiyvvjmqi"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2056145983));

                Assert.That(model.ModelInner.Value, Is.EqualTo("muvawanfbratcxbjryksiktmdxn"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("duuuqdylwknpkprcsklfp"));

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(702765260));
                Assert.That(model.Value, Is.EqualTo("errgadvvyp"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("cltgv"));

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(726288705));
                Assert.That(model.Value, Is.EqualTo("vlgdphlqjgyeokeupjkidot"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("qewpmqurcnael"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1367930567));

                Assert.That(model.ModelInner.Value, Is.EqualTo("bpfpvqkdwwatnhlgbwrye"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("pheiitrjudgsfp"));

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(773576257));
                Assert.That(model.Value, Is.EqualTo("icrbhluhfeclqcwiybvw"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("kstvhlvsbpvjtmn"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(76172232));

                Assert.That(model.ModelInner.Value, Is.EqualTo("fwgtsdpdunhbwcwgrtcsas"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(871194289));
                Assert.That(model.Value, Is.EqualTo(""));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("wuoi"));

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(909526490));
                Assert.That(model.Value, Is.EqualTo("rkpjbjol"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1939530278));

                Assert.That(model.ModelInner.Value, Is.EqualTo("bm"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("vtfgwskgwy"));

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(939168337));
                Assert.That(model.Value, Is.EqualTo("sjietmnsovprt"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1029817369));
                Assert.That(model.Value, Is.EqualTo("ekiexnoahopnomudounsuwnqioyt"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("ipm"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1904673088));

                Assert.That(model.ModelInner.Value, Is.EqualTo("ngiymkoxvrnorcqrhsouuitbly"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1075729036));
                Assert.That(model.Value, Is.EqualTo("wwddimlixwpryfgavhlvicuhtpmc"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1133257314));
                Assert.That(model.Value, Is.EqualTo("unewvaybmpilafaobdvuckcj"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1337948693));
                Assert.That(model.Value, Is.EqualTo("mfllkvwwpftvntbbiomndcj"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1292527774));

                Assert.That(model.ModelInner.Value, Is.EqualTo("gswswtemxlccmidpapoehrmadkbo"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1506426512));
                Assert.That(model.Value, Is.EqualTo("hpwvip"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("wc"));

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1591264898));
                Assert.That(model.Value, Is.EqualTo("tmdctgbyi"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1730990346));
                Assert.That(model.Value, Is.EqualTo("ughlfokkphpdyvmexqfqwaw"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("tjkkucxgvypfouv"));

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1751190228));
                Assert.That(model.Value, Is.EqualTo("jxsniljkalworujyidi"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1853952493));
                Assert.That(model.Value, Is.EqualTo("eooisvbdiry"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("stiapivepjrlwo"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(224209119));

                Assert.That(model.ModelInner.Value, Is.EqualTo("ykp"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1930029542));
                Assert.That(model.Value, Is.EqualTo("olvmfeortflhbjkblilryc"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("ygygumifrw"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1692068371));

                Assert.That(model.ModelInner.Value, Is.EqualTo(""));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1956613322));
                Assert.That(model.Value, Is.EqualTo("veinjgpawbisnivanefccw"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(""));

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1983632651));
                Assert.That(model.Value, Is.EqualTo("hstcvbdiancuvhnkvxnuyls"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("bxeexniantpprwwsi"));

                Assert.That(model.ModelInner, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2009683237));
                Assert.That(model.Value, Is.EqualTo("g"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("esanbtlohpqojcwlvce"));

                Assert.That(model.ModelInner, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2028093643));
                Assert.That(model.Value, Is.EqualTo("eygavaulnfugjlmgryw"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("clgbocgula"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1633287873));

                Assert.That(model.ModelInner.Value, Is.EqualTo("bqeobus"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("hytnbvrrlkhjjdamduo"));

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2112261214));
                Assert.That(model.Value, Is.EqualTo("dhbjbpdcvmjvr"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("ddkgxnlmqrrwcffifpse"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1624956286));

                Assert.That(model.ModelInner.Value, Is.EqualTo("uotyykivgnolvlcybrifjnyhvpcon"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("jajhhlwitjwkhuhiuoayxwxi"));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IStringSingleTypetext)this).CreateDbConnectionSelectModelCommand(connection);
                ((IStringSingleTypetext)this).SetDbConnectionSelectModelParametrs(cmd, 1029817369);
                var models =  ((IStringSingleTypetext)this).ExecuteDbConnectionSelectModelCommand(cmd).ToList();

                Assert.That(models, Has.Count.EqualTo(14));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1075729036));
                Assert.That(model.Value, Is.EqualTo("wwddimlixwpryfgavhlvicuhtpmc"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1133257314));
                Assert.That(model.Value, Is.EqualTo("unewvaybmpilafaobdvuckcj"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1337948693));
                Assert.That(model.Value, Is.EqualTo("mfllkvwwpftvntbbiomndcj"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1292527774));

                Assert.That(model.ModelInner.Value, Is.EqualTo("gswswtemxlccmidpapoehrmadkbo"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1506426512));
                Assert.That(model.Value, Is.EqualTo("hpwvip"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("wc"));

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1591264898));
                Assert.That(model.Value, Is.EqualTo("tmdctgbyi"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1730990346));
                Assert.That(model.Value, Is.EqualTo("ughlfokkphpdyvmexqfqwaw"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("tjkkucxgvypfouv"));

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1751190228));
                Assert.That(model.Value, Is.EqualTo("jxsniljkalworujyidi"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1853952493));
                Assert.That(model.Value, Is.EqualTo("eooisvbdiry"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("stiapivepjrlwo"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(224209119));

                Assert.That(model.ModelInner.Value, Is.EqualTo("ykp"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1930029542));
                Assert.That(model.Value, Is.EqualTo("olvmfeortflhbjkblilryc"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("ygygumifrw"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1692068371));

                Assert.That(model.ModelInner.Value, Is.EqualTo(""));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1956613322));
                Assert.That(model.Value, Is.EqualTo("veinjgpawbisnivanefccw"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(""));

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1983632651));
                Assert.That(model.Value, Is.EqualTo("hstcvbdiancuvhnkvxnuyls"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("bxeexniantpprwwsi"));

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2009683237));
                Assert.That(model.Value, Is.EqualTo("g"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("esanbtlohpqojcwlvce"));

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2028093643));
                Assert.That(model.Value, Is.EqualTo("eygavaulnfugjlmgryw"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("clgbocgula"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1633287873));

                Assert.That(model.ModelInner.Value, Is.EqualTo("bqeobus"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("hytnbvrrlkhjjdamduo"));

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2112261214));
                Assert.That(model.Value, Is.EqualTo("dhbjbpdcvmjvr"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("ddkgxnlmqrrwcffifpse"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1624956286));

                Assert.That(model.ModelInner.Value, Is.EqualTo("uotyykivgnolvlcybrifjnyhvpcon"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("jajhhlwitjwkhuhiuoayxwxi"));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                await using var cmd = await ((IStringSingleTypetext)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IStringSingleTypetext)this).SetDbConnectionSelectModelParametrs(cmd, 511300623);
                var models = await ((IStringSingleTypetext)this).ExecuteDbConnectionSelectModelCommandAsync(cmd).ToListAsync();

                Assert.That(models, Has.Count.EqualTo(23));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(517689674));
                Assert.That(model.Value, Is.EqualTo("omvkhaccqeqgl"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("qjmsugwmvdse"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(446504904));

                Assert.That(model.ModelInner.Value, Is.EqualTo("wgjryc"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(586044985));
                Assert.That(model.Value, Is.EqualTo("mtpekvxsfufhnvpfs"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("hunkptbartiyvvjmqi"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2056145983));

                Assert.That(model.ModelInner.Value, Is.EqualTo("muvawanfbratcxbjryksiktmdxn"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("duuuqdylwknpkprcsklfp"));

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(702765260));
                Assert.That(model.Value, Is.EqualTo("errgadvvyp"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("cltgv"));

                Assert.That(model.ModelInner, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(726288705));
                Assert.That(model.Value, Is.EqualTo("vlgdphlqjgyeokeupjkidot"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("qewpmqurcnael"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1367930567));

                Assert.That(model.ModelInner.Value, Is.EqualTo("bpfpvqkdwwatnhlgbwrye"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("pheiitrjudgsfp"));

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(773576257));
                Assert.That(model.Value, Is.EqualTo("icrbhluhfeclqcwiybvw"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("kstvhlvsbpvjtmn"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(76172232));

                Assert.That(model.ModelInner.Value, Is.EqualTo("fwgtsdpdunhbwcwgrtcsas"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(871194289));
                Assert.That(model.Value, Is.EqualTo(""));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("wuoi"));

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(909526490));
                Assert.That(model.Value, Is.EqualTo("rkpjbjol"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1939530278));

                Assert.That(model.ModelInner.Value, Is.EqualTo("bm"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("vtfgwskgwy"));

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(939168337));
                Assert.That(model.Value, Is.EqualTo("sjietmnsovprt"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1029817369));
                Assert.That(model.Value, Is.EqualTo("ekiexnoahopnomudounsuwnqioyt"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("ipm"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1904673088));

                Assert.That(model.ModelInner.Value, Is.EqualTo("ngiymkoxvrnorcqrhsouuitbly"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1075729036));
                Assert.That(model.Value, Is.EqualTo("wwddimlixwpryfgavhlvicuhtpmc"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1133257314));
                Assert.That(model.Value, Is.EqualTo("unewvaybmpilafaobdvuckcj"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1337948693));
                Assert.That(model.Value, Is.EqualTo("mfllkvwwpftvntbbiomndcj"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1292527774));

                Assert.That(model.ModelInner.Value, Is.EqualTo("gswswtemxlccmidpapoehrmadkbo"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1506426512));
                Assert.That(model.Value, Is.EqualTo("hpwvip"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("wc"));

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1591264898));
                Assert.That(model.Value, Is.EqualTo("tmdctgbyi"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1730990346));
                Assert.That(model.Value, Is.EqualTo("ughlfokkphpdyvmexqfqwaw"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("tjkkucxgvypfouv"));

                Assert.That(model.ModelInner, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1751190228));
                Assert.That(model.Value, Is.EqualTo("jxsniljkalworujyidi"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1853952493));
                Assert.That(model.Value, Is.EqualTo("eooisvbdiry"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("stiapivepjrlwo"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(224209119));

                Assert.That(model.ModelInner.Value, Is.EqualTo("ykp"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1930029542));
                Assert.That(model.Value, Is.EqualTo("olvmfeortflhbjkblilryc"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("ygygumifrw"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1692068371));

                Assert.That(model.ModelInner.Value, Is.EqualTo(""));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1956613322));
                Assert.That(model.Value, Is.EqualTo("veinjgpawbisnivanefccw"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(""));

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1983632651));
                Assert.That(model.Value, Is.EqualTo("hstcvbdiancuvhnkvxnuyls"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("bxeexniantpprwwsi"));

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2009683237));
                Assert.That(model.Value, Is.EqualTo("g"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("esanbtlohpqojcwlvce"));

                Assert.That(model.ModelInner, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2028093643));
                Assert.That(model.Value, Is.EqualTo("eygavaulnfugjlmgryw"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("clgbocgula"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1633287873));

                Assert.That(model.ModelInner.Value, Is.EqualTo("bqeobus"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("hytnbvrrlkhjjdamduo"));

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2112261214));
                Assert.That(model.Value, Is.EqualTo("dhbjbpdcvmjvr"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("ddkgxnlmqrrwcffifpse"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1624956286));

                Assert.That(model.ModelInner.Value, Is.EqualTo("uotyykivgnolvlcybrifjnyhvpcon"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("jajhhlwitjwkhuhiuoayxwxi"));

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
            queryMapType: typeof(object[]),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringSingleTypetext)
            )
            ]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((IStringSingleTypetext)this).DbConnectionSelectModelToObjArr(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14315462)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("aecn")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1426085088)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("ioo")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("jntquhlvvhaexxhue")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20408822)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("as")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((270065568)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("hkqebnbyxxfbry")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("t")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44923757)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("aanabbybtahdpkslhqnrymnw")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("oqctqjmkvhflqkusvhyyillalglm")));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128817615)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("rwcoifruqkoscflae")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((678758467)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("cjhsyp")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("ukfrhdltcqwualdg")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("dbfpoqpvhokctqh")));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((254008058)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("aqefcrhafeyfrenvtnhg")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((787283776)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("rlmeequwkdxydcuikswadxudmg")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((320230804)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("tpwlhaonkejrqseexrkcspeteos")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("byqkiciwbk")));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((511300623)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("mserckqnyymnlxagwxvfcrutsmiqx")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((517689674)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("omvkhaccqeqgl")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((446504904)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("wgjryc")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("qjmsugwmvdse")));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((586044985)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("mtpekvxsfufhnvpfs")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2056145983)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("muvawanfbratcxbjryksiktmdxn")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("duuuqdylwknpkprcsklfp")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("hunkptbartiyvvjmqi")));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((702765260)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("errgadvvyp")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("cltgv")));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((726288705)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("vlgdphlqjgyeokeupjkidot")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1367930567)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("bpfpvqkdwwatnhlgbwrye")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("pheiitrjudgsfp")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("qewpmqurcnael")));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((773576257)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("icrbhluhfeclqcwiybvw")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((76172232)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("fwgtsdpdunhbwcwgrtcsas")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("kstvhlvsbpvjtmn")));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((871194289)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("wuoi")));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((909526490)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("rkpjbjol")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1939530278)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("bm")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("vtfgwskgwy")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((939168337)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("sjietmnsovprt")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1029817369)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("ekiexnoahopnomudounsuwnqioyt")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1904673088)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("ngiymkoxvrnorcqrhsouuitbly")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("ipm")));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1075729036)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("wwddimlixwpryfgavhlvicuhtpmc")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1133257314)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("unewvaybmpilafaobdvuckcj")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1337948693)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("mfllkvwwpftvntbbiomndcj")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1292527774)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("gswswtemxlccmidpapoehrmadkbo")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1506426512)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("hpwvip")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("wc")));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1591264898)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("tmdctgbyi")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1730990346)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("ughlfokkphpdyvmexqfqwaw")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("tjkkucxgvypfouv")));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1751190228)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("jxsniljkalworujyidi")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1853952493)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("eooisvbdiry")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((224209119)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("ykp")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("stiapivepjrlwo")));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1930029542)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("olvmfeortflhbjkblilryc")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1692068371)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("ygygumifrw")));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1956613322)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("veinjgpawbisnivanefccw")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("")));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1983632651)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("hstcvbdiancuvhnkvxnuyls")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("bxeexniantpprwwsi")));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2009683237)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("g")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("esanbtlohpqojcwlvce")));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2028093643)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("eygavaulnfugjlmgryw")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1633287873)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("bqeobus")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("hytnbvrrlkhjjdamduo")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("clgbocgula")));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2112261214)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("dhbjbpdcvmjvr")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1624956286)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("uotyykivgnolvlcybrifjnyhvpcon")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("jajhhlwitjwkhuhiuoayxwxi")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("ddkgxnlmqrrwcffifpse")));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IStringSingleTypetext)this).DbConnectionSelectModelToObjArrAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14315462)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("aecn")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1426085088)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("ioo")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("jntquhlvvhaexxhue")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20408822)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("as")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((270065568)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("hkqebnbyxxfbry")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("t")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44923757)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("aanabbybtahdpkslhqnrymnw")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("oqctqjmkvhflqkusvhyyillalglm")));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128817615)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("rwcoifruqkoscflae")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((678758467)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("cjhsyp")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("ukfrhdltcqwualdg")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("dbfpoqpvhokctqh")));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((254008058)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("aqefcrhafeyfrenvtnhg")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((787283776)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("rlmeequwkdxydcuikswadxudmg")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((320230804)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("tpwlhaonkejrqseexrkcspeteos")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("byqkiciwbk")));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((511300623)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("mserckqnyymnlxagwxvfcrutsmiqx")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((517689674)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("omvkhaccqeqgl")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((446504904)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("wgjryc")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("qjmsugwmvdse")));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((586044985)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("mtpekvxsfufhnvpfs")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2056145983)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("muvawanfbratcxbjryksiktmdxn")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("duuuqdylwknpkprcsklfp")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("hunkptbartiyvvjmqi")));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((702765260)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("errgadvvyp")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("cltgv")));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((726288705)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("vlgdphlqjgyeokeupjkidot")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1367930567)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("bpfpvqkdwwatnhlgbwrye")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("pheiitrjudgsfp")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("qewpmqurcnael")));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((773576257)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("icrbhluhfeclqcwiybvw")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((76172232)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("fwgtsdpdunhbwcwgrtcsas")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("kstvhlvsbpvjtmn")));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((871194289)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("wuoi")));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((909526490)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("rkpjbjol")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1939530278)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("bm")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("vtfgwskgwy")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((939168337)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("sjietmnsovprt")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1029817369)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("ekiexnoahopnomudounsuwnqioyt")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1904673088)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("ngiymkoxvrnorcqrhsouuitbly")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("ipm")));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1075729036)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("wwddimlixwpryfgavhlvicuhtpmc")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1133257314)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("unewvaybmpilafaobdvuckcj")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1337948693)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("mfllkvwwpftvntbbiomndcj")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1292527774)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("gswswtemxlccmidpapoehrmadkbo")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1506426512)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("hpwvip")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("wc")));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1591264898)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("tmdctgbyi")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1730990346)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("ughlfokkphpdyvmexqfqwaw")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("tjkkucxgvypfouv")));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1751190228)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("jxsniljkalworujyidi")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1853952493)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("eooisvbdiry")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((224209119)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("ykp")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("stiapivepjrlwo")));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1930029542)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("olvmfeortflhbjkblilryc")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1692068371)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("ygygumifrw")));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1956613322)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("veinjgpawbisnivanefccw")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("")));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1983632651)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("hstcvbdiancuvhnkvxnuyls")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("bxeexniantpprwwsi")));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2009683237)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("g")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("esanbtlohpqojcwlvce")));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2028093643)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("eygavaulnfugjlmgryw")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1633287873)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("bqeobus")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("hytnbvrrlkhjjdamduo")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("clgbocgula")));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2112261214)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("dhbjbpdcvmjvr")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1624956286)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("uotyykivgnolvlcybrifjnyhvpcon")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("jajhhlwitjwkhuhiuoayxwxi")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("ddkgxnlmqrrwcffifpse")));

            }
        }

        #endregion

    }
}

