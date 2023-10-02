

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
            queryMapType: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringSingleTypetext)
            ), 
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                parametrName: "id",
                methodParametrName: "id", 
                dbType: (MySqlConnector.MySqlDbType)(3)
                ),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.String),
                parametrName: "value",
                methodParametrName: "value",
                dbType: (MySqlConnector.MySqlDbType)(752)
                ),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.String), 
                parametrName: "nullablevalue",
                methodParametrName: "nullablevalue",
                dbType: (MySqlConnector.MySqlDbType)(752)
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

                changedRows =  ((IStringSingleTypetext)this).InsertModelInner(connection, 1940474468, "tidbpqyhaxqqeweheayt", "wjlynobfawmkwongdhtsf");
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IStringSingleTypetext)this).InsertModelInner(connection, 2226021, "hyuxbdmwuxhmtmhrk", null);
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

                changedRows = await ((IStringSingleTypetext)this).InsertModelInnerAsync(connection, 1939606812, "gebgm", "hdmiiqijkjhirxyvlcxl");
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).InsertModelInnerAsync(connection, 1658888405, "ihuoivwjxaeuppqpjafuyabyepfx", "jwsotfcpdahodtdusjindwgq");
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
                dbType: (System.Data.DbType)(11)
                ),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.String), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(16)
                ),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.String), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(16), 
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

                changedRows =  ((IStringSingleTypetext)this).DbConnectionInsertInnerModel(connection, 2050310934, "yyhyrhnjxvufi", null);
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

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertInnerModelAsync(connection, 1753416003, "fexckkvl", "smelahduylehglodcnawwb");
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertInnerModelAsync(connection, 87445043, "eqjigdkcsbquqqxn", "bchqcfbnutypftt");
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertInnerModelAsync(connection, 1721043254, "xglpwfepkoqwfmfymvyckddth", null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertInnerModelAsync(connection, 1743439641, "uluh", "gatnsqf");
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertInnerModelAsync(connection, 2109835250, "aexwbhcdkx", null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertInnerModelAsync(connection, 374965926, "bwpvvsvusxkwtjpgdky", "lfnbpkr");
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertInnerModelAsync(connection, 1022425685, "freabjruh", "twceuqer");
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertInnerModelAsync(connection, 1107945570, "dhgqcjl", null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertInnerModelAsync(connection, 1608653137, "rmccg", "qnnnyohorodxgjkrpeisuv");
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertInnerModelAsync(connection, 665411996, "qss", "daeiuelowvn");
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
            queryMapType: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringSingleTypetext)
            ), 
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (MySqlConnector.MySqlDbType)(3)
            ),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.String), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (MySqlConnector.MySqlDbType)(752)
            ),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.String), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (MySqlConnector.MySqlDbType)(752),
                nullable: true
            ),
            Gedaq.MySqlConnector.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "stringtext0mi_id", 
                methodParametrName: "stringtext0mi_id", 
                dbType: (MySqlConnector.MySqlDbType)(3),
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

                changedRows =  ((IStringSingleTypetext)this).InsertModel(connection, 139609746, "arunhp", "", null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IStringSingleTypetext)this).InsertModel(connection, 1481720908, "qpshnlus", "jbanuunrrdna", 1940474468);
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

                changedRows = await ((IStringSingleTypetext)this).InsertModelAsync(connection, 1931560927, "ywfhrje", "gxsgfqrg", null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).InsertModelAsync(connection, 14757608, "ipmooujfaatsirilxdlapp", null, 2226021);
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
            queryMapType: null,
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
                nullable: true
),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "stringtext0mi_id", 
                methodParametrName: "stringtext0mi_id", 
                dbType: (System.Data.DbType)(11),
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

                changedRows =  ((IStringSingleTypetext)this).DbConnectionInsertModel(connection, 1780751115, "amqcphqkutxuejxad", "vqqbxxbcwavhu", null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IStringSingleTypetext)this).DbConnectionInsertModel(connection, 608460427, "", null, 1939606812);
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

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertModelAsync(connection, 1254473920, "ebkuvcaxtcxfevxd", "gyydkiuvlnwvtgshltvqfm", null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertModelAsync(connection, 913744506, "ooxmarfjmbuxpksnkbo", "ihqtdeudoriruavenu", 1658888405);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertModelAsync(connection, 1802400137, "kxepmqwnyfbxye", "ebksjixxexfeohg", null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertModelAsync(connection, 1092279008, "cxbecsykrltfyxkchtlbqaeek", null, 2050310934);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertModelAsync(connection, 178840786, "rhqbulk", "udygunbj", null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertModelAsync(connection, 1082479129, "hamqoqxpjfuybtplxu", null, 1753416003);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertModelAsync(connection, 1981244764, "wnvhbcqkbtcj", "neakdcg", null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertModelAsync(connection, 1058873480, "novgsxrmujmayooytesrxfxqyfqg", "oeoesjuye", 87445043);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertModelAsync(connection, 1902472190, "ljcp", "aumrmtynvishbygjysdqt", null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertModelAsync(connection, 1953014780, "vabkgcoqtalkco", "bhuaxvfrdoc", 1721043254);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertModelAsync(connection, 864081612, "", null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertModelAsync(connection, 738372288, "mckpyaehqysr", "jyec", 1743439641);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertModelAsync(connection, 787262827, "dmojijjigjvuk", null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertModelAsync(connection, 1942405729, "htokuanavyrbhqqdvnagqrsbangfk", "aueftsrrlycatffkpfodjjnydnt", 2109835250);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertModelAsync(connection, 1267388319, "friwkbqw", null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertModelAsync(connection, 906852092, "nwhurnbtxwmuusa", null, 374965926);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertModelAsync(connection, 1709228362, "veisjxwi", null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertModelAsync(connection, 227394632, "ovihfr", null, 1022425685);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertModelAsync(connection, 249195449, "rmylyahgcmnvxlnldeftwno", "tkgpxemteoissuk", null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertModelAsync(connection, 652948993, "svhwdxwjejcu", null, 1107945570);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertModelAsync(connection, 1870930699, "xsltolgmlpvfrohdxnx", "euiimid", null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertModelAsync(connection, 171086619, "", null, 1608653137);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertModelAsync(connection, 1045323454, "rmv", "qsjjde", null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringSingleTypetext)this).DbConnectionInsertModelAsync(connection, 1537897125, "prndbvwnioehfugepmf", "fts", 665411996);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        #endregion

#region Select Models

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
            queryMapType: typeof(Stringtext0M),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringSingleTypetext)
            ),
Gedaq.MySqlConnector.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            parametrName: "id",
            methodParametrName: "id",
            dbType: (MySqlConnector.MySqlDbType)(3)
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
                Assert.That(model.Id, Is.EqualTo(14757608));
                Assert.That(model.Value, Is.EqualTo("ipmooujfaatsirilxdlapp"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2226021));

                Assert.That(model.ModelInner.Value, Is.EqualTo("hyuxbdmwuxhmtmhrk"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(139609746));
                Assert.That(model.Value, Is.EqualTo("arunhp"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(""));

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(171086619));
                Assert.That(model.Value, Is.EqualTo(""));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1608653137));

                Assert.That(model.ModelInner.Value, Is.EqualTo("rmccg"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("qnnnyohorodxgjkrpeisuv"));

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(178840786));
                Assert.That(model.Value, Is.EqualTo("rhqbulk"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("udygunbj"));

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(227394632));
                Assert.That(model.Value, Is.EqualTo("ovihfr"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1022425685));

                Assert.That(model.ModelInner.Value, Is.EqualTo("freabjruh"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("twceuqer"));

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(249195449));
                Assert.That(model.Value, Is.EqualTo("rmylyahgcmnvxlnldeftwno"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("tkgpxemteoissuk"));

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(608460427));
                Assert.That(model.Value, Is.EqualTo(""));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1939606812));

                Assert.That(model.ModelInner.Value, Is.EqualTo("gebgm"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("hdmiiqijkjhirxyvlcxl"));

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(652948993));
                Assert.That(model.Value, Is.EqualTo("svhwdxwjejcu"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1107945570));

                Assert.That(model.ModelInner.Value, Is.EqualTo("dhgqcjl"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(738372288));
                Assert.That(model.Value, Is.EqualTo("mckpyaehqysr"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("jyec"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1743439641));

                Assert.That(model.ModelInner.Value, Is.EqualTo("uluh"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("gatnsqf"));

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(787262827));
                Assert.That(model.Value, Is.EqualTo("dmojijjigjvuk"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(864081612));
                Assert.That(model.Value, Is.EqualTo(""));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(906852092));
                Assert.That(model.Value, Is.EqualTo("nwhurnbtxwmuusa"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(374965926));

                Assert.That(model.ModelInner.Value, Is.EqualTo("bwpvvsvusxkwtjpgdky"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("lfnbpkr"));

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(913744506));
                Assert.That(model.Value, Is.EqualTo("ooxmarfjmbuxpksnkbo"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("ihqtdeudoriruavenu"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1658888405));

                Assert.That(model.ModelInner.Value, Is.EqualTo("ihuoivwjxaeuppqpjafuyabyepfx"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("jwsotfcpdahodtdusjindwgq"));

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1045323454));
                Assert.That(model.Value, Is.EqualTo("rmv"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("qsjjde"));

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1058873480));
                Assert.That(model.Value, Is.EqualTo("novgsxrmujmayooytesrxfxqyfqg"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("oeoesjuye"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(87445043));

                Assert.That(model.ModelInner.Value, Is.EqualTo("eqjigdkcsbquqqxn"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("bchqcfbnutypftt"));

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1082479129));
                Assert.That(model.Value, Is.EqualTo("hamqoqxpjfuybtplxu"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1753416003));

                Assert.That(model.ModelInner.Value, Is.EqualTo("fexckkvl"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("smelahduylehglodcnawwb"));

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1092279008));
                Assert.That(model.Value, Is.EqualTo("cxbecsykrltfyxkchtlbqaeek"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2050310934));

                Assert.That(model.ModelInner.Value, Is.EqualTo("yyhyrhnjxvufi"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1254473920));
                Assert.That(model.Value, Is.EqualTo("ebkuvcaxtcxfevxd"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("gyydkiuvlnwvtgshltvqfm"));

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1267388319));
                Assert.That(model.Value, Is.EqualTo("friwkbqw"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1481720908));
                Assert.That(model.Value, Is.EqualTo("qpshnlus"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("jbanuunrrdna"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1940474468));

                Assert.That(model.ModelInner.Value, Is.EqualTo("tidbpqyhaxqqeweheayt"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("wjlynobfawmkwongdhtsf"));

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1537897125));
                Assert.That(model.Value, Is.EqualTo("prndbvwnioehfugepmf"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("fts"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(665411996));

                Assert.That(model.ModelInner.Value, Is.EqualTo("qss"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("daeiuelowvn"));

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1709228362));
                Assert.That(model.Value, Is.EqualTo("veisjxwi"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1780751115));
                Assert.That(model.Value, Is.EqualTo("amqcphqkutxuejxad"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("vqqbxxbcwavhu"));

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1802400137));
                Assert.That(model.Value, Is.EqualTo("kxepmqwnyfbxye"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("ebksjixxexfeohg"));

                Assert.That(model.ModelInner, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1870930699));
                Assert.That(model.Value, Is.EqualTo("xsltolgmlpvfrohdxnx"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("euiimid"));

                Assert.That(model.ModelInner, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1902472190));
                Assert.That(model.Value, Is.EqualTo("ljcp"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("aumrmtynvishbygjysdqt"));

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1931560927));
                Assert.That(model.Value, Is.EqualTo("ywfhrje"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("gxsgfqrg"));

                Assert.That(model.ModelInner, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1942405729));
                Assert.That(model.Value, Is.EqualTo("htokuanavyrbhqqdvnagqrsbangfk"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("aueftsrrlycatffkpfodjjnydnt"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2109835250));

                Assert.That(model.ModelInner.Value, Is.EqualTo("aexwbhcdkx"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1953014780));
                Assert.That(model.Value, Is.EqualTo("vabkgcoqtalkco"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("bhuaxvfrdoc"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1721043254));

                Assert.That(model.ModelInner.Value, Is.EqualTo("xglpwfepkoqwfmfymvyckddth"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1981244764));
                Assert.That(model.Value, Is.EqualTo("wnvhbcqkbtcj"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("neakdcg"));

                Assert.That(model.ModelInner, Is.Null);

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
                Assert.That(model.Id, Is.EqualTo(14757608));
                Assert.That(model.Value, Is.EqualTo("ipmooujfaatsirilxdlapp"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2226021));

                Assert.That(model.ModelInner.Value, Is.EqualTo("hyuxbdmwuxhmtmhrk"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(139609746));
                Assert.That(model.Value, Is.EqualTo("arunhp"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(""));

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(171086619));
                Assert.That(model.Value, Is.EqualTo(""));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1608653137));

                Assert.That(model.ModelInner.Value, Is.EqualTo("rmccg"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("qnnnyohorodxgjkrpeisuv"));

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(178840786));
                Assert.That(model.Value, Is.EqualTo("rhqbulk"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("udygunbj"));

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(227394632));
                Assert.That(model.Value, Is.EqualTo("ovihfr"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1022425685));

                Assert.That(model.ModelInner.Value, Is.EqualTo("freabjruh"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("twceuqer"));

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(249195449));
                Assert.That(model.Value, Is.EqualTo("rmylyahgcmnvxlnldeftwno"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("tkgpxemteoissuk"));

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(608460427));
                Assert.That(model.Value, Is.EqualTo(""));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1939606812));

                Assert.That(model.ModelInner.Value, Is.EqualTo("gebgm"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("hdmiiqijkjhirxyvlcxl"));

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(652948993));
                Assert.That(model.Value, Is.EqualTo("svhwdxwjejcu"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1107945570));

                Assert.That(model.ModelInner.Value, Is.EqualTo("dhgqcjl"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(738372288));
                Assert.That(model.Value, Is.EqualTo("mckpyaehqysr"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("jyec"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1743439641));

                Assert.That(model.ModelInner.Value, Is.EqualTo("uluh"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("gatnsqf"));

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(787262827));
                Assert.That(model.Value, Is.EqualTo("dmojijjigjvuk"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(864081612));
                Assert.That(model.Value, Is.EqualTo(""));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(906852092));
                Assert.That(model.Value, Is.EqualTo("nwhurnbtxwmuusa"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(374965926));

                Assert.That(model.ModelInner.Value, Is.EqualTo("bwpvvsvusxkwtjpgdky"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("lfnbpkr"));

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(913744506));
                Assert.That(model.Value, Is.EqualTo("ooxmarfjmbuxpksnkbo"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("ihqtdeudoriruavenu"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1658888405));

                Assert.That(model.ModelInner.Value, Is.EqualTo("ihuoivwjxaeuppqpjafuyabyepfx"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("jwsotfcpdahodtdusjindwgq"));

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1045323454));
                Assert.That(model.Value, Is.EqualTo("rmv"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("qsjjde"));

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1058873480));
                Assert.That(model.Value, Is.EqualTo("novgsxrmujmayooytesrxfxqyfqg"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("oeoesjuye"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(87445043));

                Assert.That(model.ModelInner.Value, Is.EqualTo("eqjigdkcsbquqqxn"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("bchqcfbnutypftt"));

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1082479129));
                Assert.That(model.Value, Is.EqualTo("hamqoqxpjfuybtplxu"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1753416003));

                Assert.That(model.ModelInner.Value, Is.EqualTo("fexckkvl"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("smelahduylehglodcnawwb"));

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1092279008));
                Assert.That(model.Value, Is.EqualTo("cxbecsykrltfyxkchtlbqaeek"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2050310934));

                Assert.That(model.ModelInner.Value, Is.EqualTo("yyhyrhnjxvufi"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1254473920));
                Assert.That(model.Value, Is.EqualTo("ebkuvcaxtcxfevxd"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("gyydkiuvlnwvtgshltvqfm"));

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1267388319));
                Assert.That(model.Value, Is.EqualTo("friwkbqw"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1481720908));
                Assert.That(model.Value, Is.EqualTo("qpshnlus"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("jbanuunrrdna"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1940474468));

                Assert.That(model.ModelInner.Value, Is.EqualTo("tidbpqyhaxqqeweheayt"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("wjlynobfawmkwongdhtsf"));

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1537897125));
                Assert.That(model.Value, Is.EqualTo("prndbvwnioehfugepmf"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("fts"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(665411996));

                Assert.That(model.ModelInner.Value, Is.EqualTo("qss"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("daeiuelowvn"));

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1709228362));
                Assert.That(model.Value, Is.EqualTo("veisjxwi"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1780751115));
                Assert.That(model.Value, Is.EqualTo("amqcphqkutxuejxad"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("vqqbxxbcwavhu"));

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1802400137));
                Assert.That(model.Value, Is.EqualTo("kxepmqwnyfbxye"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("ebksjixxexfeohg"));

                Assert.That(model.ModelInner, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1870930699));
                Assert.That(model.Value, Is.EqualTo("xsltolgmlpvfrohdxnx"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("euiimid"));

                Assert.That(model.ModelInner, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1902472190));
                Assert.That(model.Value, Is.EqualTo("ljcp"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("aumrmtynvishbygjysdqt"));

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1931560927));
                Assert.That(model.Value, Is.EqualTo("ywfhrje"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("gxsgfqrg"));

                Assert.That(model.ModelInner, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1942405729));
                Assert.That(model.Value, Is.EqualTo("htokuanavyrbhqqdvnagqrsbangfk"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("aueftsrrlycatffkpfodjjnydnt"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2109835250));

                Assert.That(model.ModelInner.Value, Is.EqualTo("aexwbhcdkx"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1953014780));
                Assert.That(model.Value, Is.EqualTo("vabkgcoqtalkco"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("bhuaxvfrdoc"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1721043254));

                Assert.That(model.ModelInner.Value, Is.EqualTo("xglpwfepkoqwfmfymvyckddth"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1981244764));
                Assert.That(model.Value, Is.EqualTo("wnvhbcqkbtcj"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("neakdcg"));

                Assert.That(model.ModelInner, Is.Null);

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
            dbType: (System.Data.DbType)(11)
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
                Assert.That(model.Id, Is.EqualTo(14757608));
                Assert.That(model.Value, Is.EqualTo("ipmooujfaatsirilxdlapp"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2226021));

                Assert.That(model.ModelInner.Value, Is.EqualTo("hyuxbdmwuxhmtmhrk"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(139609746));
                Assert.That(model.Value, Is.EqualTo("arunhp"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(""));

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(171086619));
                Assert.That(model.Value, Is.EqualTo(""));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1608653137));

                Assert.That(model.ModelInner.Value, Is.EqualTo("rmccg"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("qnnnyohorodxgjkrpeisuv"));

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(178840786));
                Assert.That(model.Value, Is.EqualTo("rhqbulk"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("udygunbj"));

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(227394632));
                Assert.That(model.Value, Is.EqualTo("ovihfr"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1022425685));

                Assert.That(model.ModelInner.Value, Is.EqualTo("freabjruh"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("twceuqer"));

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(249195449));
                Assert.That(model.Value, Is.EqualTo("rmylyahgcmnvxlnldeftwno"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("tkgpxemteoissuk"));

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(608460427));
                Assert.That(model.Value, Is.EqualTo(""));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1939606812));

                Assert.That(model.ModelInner.Value, Is.EqualTo("gebgm"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("hdmiiqijkjhirxyvlcxl"));

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(652948993));
                Assert.That(model.Value, Is.EqualTo("svhwdxwjejcu"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1107945570));

                Assert.That(model.ModelInner.Value, Is.EqualTo("dhgqcjl"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(738372288));
                Assert.That(model.Value, Is.EqualTo("mckpyaehqysr"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("jyec"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1743439641));

                Assert.That(model.ModelInner.Value, Is.EqualTo("uluh"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("gatnsqf"));

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(787262827));
                Assert.That(model.Value, Is.EqualTo("dmojijjigjvuk"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(864081612));
                Assert.That(model.Value, Is.EqualTo(""));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(906852092));
                Assert.That(model.Value, Is.EqualTo("nwhurnbtxwmuusa"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(374965926));

                Assert.That(model.ModelInner.Value, Is.EqualTo("bwpvvsvusxkwtjpgdky"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("lfnbpkr"));

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(913744506));
                Assert.That(model.Value, Is.EqualTo("ooxmarfjmbuxpksnkbo"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("ihqtdeudoriruavenu"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1658888405));

                Assert.That(model.ModelInner.Value, Is.EqualTo("ihuoivwjxaeuppqpjafuyabyepfx"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("jwsotfcpdahodtdusjindwgq"));

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1045323454));
                Assert.That(model.Value, Is.EqualTo("rmv"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("qsjjde"));

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1058873480));
                Assert.That(model.Value, Is.EqualTo("novgsxrmujmayooytesrxfxqyfqg"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("oeoesjuye"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(87445043));

                Assert.That(model.ModelInner.Value, Is.EqualTo("eqjigdkcsbquqqxn"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("bchqcfbnutypftt"));

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1082479129));
                Assert.That(model.Value, Is.EqualTo("hamqoqxpjfuybtplxu"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1753416003));

                Assert.That(model.ModelInner.Value, Is.EqualTo("fexckkvl"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("smelahduylehglodcnawwb"));

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1092279008));
                Assert.That(model.Value, Is.EqualTo("cxbecsykrltfyxkchtlbqaeek"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2050310934));

                Assert.That(model.ModelInner.Value, Is.EqualTo("yyhyrhnjxvufi"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1254473920));
                Assert.That(model.Value, Is.EqualTo("ebkuvcaxtcxfevxd"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("gyydkiuvlnwvtgshltvqfm"));

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1267388319));
                Assert.That(model.Value, Is.EqualTo("friwkbqw"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1481720908));
                Assert.That(model.Value, Is.EqualTo("qpshnlus"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("jbanuunrrdna"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1940474468));

                Assert.That(model.ModelInner.Value, Is.EqualTo("tidbpqyhaxqqeweheayt"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("wjlynobfawmkwongdhtsf"));

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1537897125));
                Assert.That(model.Value, Is.EqualTo("prndbvwnioehfugepmf"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("fts"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(665411996));

                Assert.That(model.ModelInner.Value, Is.EqualTo("qss"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("daeiuelowvn"));

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1709228362));
                Assert.That(model.Value, Is.EqualTo("veisjxwi"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1780751115));
                Assert.That(model.Value, Is.EqualTo("amqcphqkutxuejxad"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("vqqbxxbcwavhu"));

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1802400137));
                Assert.That(model.Value, Is.EqualTo("kxepmqwnyfbxye"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("ebksjixxexfeohg"));

                Assert.That(model.ModelInner, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1870930699));
                Assert.That(model.Value, Is.EqualTo("xsltolgmlpvfrohdxnx"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("euiimid"));

                Assert.That(model.ModelInner, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1902472190));
                Assert.That(model.Value, Is.EqualTo("ljcp"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("aumrmtynvishbygjysdqt"));

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1931560927));
                Assert.That(model.Value, Is.EqualTo("ywfhrje"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("gxsgfqrg"));

                Assert.That(model.ModelInner, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1942405729));
                Assert.That(model.Value, Is.EqualTo("htokuanavyrbhqqdvnagqrsbangfk"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("aueftsrrlycatffkpfodjjnydnt"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2109835250));

                Assert.That(model.ModelInner.Value, Is.EqualTo("aexwbhcdkx"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1953014780));
                Assert.That(model.Value, Is.EqualTo("vabkgcoqtalkco"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("bhuaxvfrdoc"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1721043254));

                Assert.That(model.ModelInner.Value, Is.EqualTo("xglpwfepkoqwfmfymvyckddth"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1981244764));
                Assert.That(model.Value, Is.EqualTo("wnvhbcqkbtcj"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("neakdcg"));

                Assert.That(model.ModelInner, Is.Null);

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
                Assert.That(model.Id, Is.EqualTo(14757608));
                Assert.That(model.Value, Is.EqualTo("ipmooujfaatsirilxdlapp"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2226021));

                Assert.That(model.ModelInner.Value, Is.EqualTo("hyuxbdmwuxhmtmhrk"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(139609746));
                Assert.That(model.Value, Is.EqualTo("arunhp"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo(""));

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(171086619));
                Assert.That(model.Value, Is.EqualTo(""));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1608653137));

                Assert.That(model.ModelInner.Value, Is.EqualTo("rmccg"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("qnnnyohorodxgjkrpeisuv"));

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(178840786));
                Assert.That(model.Value, Is.EqualTo("rhqbulk"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("udygunbj"));

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(227394632));
                Assert.That(model.Value, Is.EqualTo("ovihfr"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1022425685));

                Assert.That(model.ModelInner.Value, Is.EqualTo("freabjruh"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("twceuqer"));

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(249195449));
                Assert.That(model.Value, Is.EqualTo("rmylyahgcmnvxlnldeftwno"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("tkgpxemteoissuk"));

                Assert.That(model.ModelInner, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(608460427));
                Assert.That(model.Value, Is.EqualTo(""));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1939606812));

                Assert.That(model.ModelInner.Value, Is.EqualTo("gebgm"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("hdmiiqijkjhirxyvlcxl"));

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(652948993));
                Assert.That(model.Value, Is.EqualTo("svhwdxwjejcu"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1107945570));

                Assert.That(model.ModelInner.Value, Is.EqualTo("dhgqcjl"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(738372288));
                Assert.That(model.Value, Is.EqualTo("mckpyaehqysr"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("jyec"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1743439641));

                Assert.That(model.ModelInner.Value, Is.EqualTo("uluh"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("gatnsqf"));

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(787262827));
                Assert.That(model.Value, Is.EqualTo("dmojijjigjvuk"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(864081612));
                Assert.That(model.Value, Is.EqualTo(""));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(906852092));
                Assert.That(model.Value, Is.EqualTo("nwhurnbtxwmuusa"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(374965926));

                Assert.That(model.ModelInner.Value, Is.EqualTo("bwpvvsvusxkwtjpgdky"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("lfnbpkr"));

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(913744506));
                Assert.That(model.Value, Is.EqualTo("ooxmarfjmbuxpksnkbo"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("ihqtdeudoriruavenu"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1658888405));

                Assert.That(model.ModelInner.Value, Is.EqualTo("ihuoivwjxaeuppqpjafuyabyepfx"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("jwsotfcpdahodtdusjindwgq"));

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1045323454));
                Assert.That(model.Value, Is.EqualTo("rmv"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("qsjjde"));

                Assert.That(model.ModelInner, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1058873480));
                Assert.That(model.Value, Is.EqualTo("novgsxrmujmayooytesrxfxqyfqg"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("oeoesjuye"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(87445043));

                Assert.That(model.ModelInner.Value, Is.EqualTo("eqjigdkcsbquqqxn"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("bchqcfbnutypftt"));

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1082479129));
                Assert.That(model.Value, Is.EqualTo("hamqoqxpjfuybtplxu"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1753416003));

                Assert.That(model.ModelInner.Value, Is.EqualTo("fexckkvl"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("smelahduylehglodcnawwb"));

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1092279008));
                Assert.That(model.Value, Is.EqualTo("cxbecsykrltfyxkchtlbqaeek"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2050310934));

                Assert.That(model.ModelInner.Value, Is.EqualTo("yyhyrhnjxvufi"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1254473920));
                Assert.That(model.Value, Is.EqualTo("ebkuvcaxtcxfevxd"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("gyydkiuvlnwvtgshltvqfm"));

                Assert.That(model.ModelInner, Is.Null);

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1267388319));
                Assert.That(model.Value, Is.EqualTo("friwkbqw"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1481720908));
                Assert.That(model.Value, Is.EqualTo("qpshnlus"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("jbanuunrrdna"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1940474468));

                Assert.That(model.ModelInner.Value, Is.EqualTo("tidbpqyhaxqqeweheayt"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("wjlynobfawmkwongdhtsf"));

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1537897125));
                Assert.That(model.Value, Is.EqualTo("prndbvwnioehfugepmf"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("fts"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(665411996));

                Assert.That(model.ModelInner.Value, Is.EqualTo("qss"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("daeiuelowvn"));

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1709228362));
                Assert.That(model.Value, Is.EqualTo("veisjxwi"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1780751115));
                Assert.That(model.Value, Is.EqualTo("amqcphqkutxuejxad"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("vqqbxxbcwavhu"));

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1802400137));
                Assert.That(model.Value, Is.EqualTo("kxepmqwnyfbxye"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("ebksjixxexfeohg"));

                Assert.That(model.ModelInner, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1870930699));
                Assert.That(model.Value, Is.EqualTo("xsltolgmlpvfrohdxnx"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("euiimid"));

                Assert.That(model.ModelInner, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1902472190));
                Assert.That(model.Value, Is.EqualTo("ljcp"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("aumrmtynvishbygjysdqt"));

                Assert.That(model.ModelInner, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1931560927));
                Assert.That(model.Value, Is.EqualTo("ywfhrje"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("gxsgfqrg"));

                Assert.That(model.ModelInner, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1942405729));
                Assert.That(model.Value, Is.EqualTo("htokuanavyrbhqqdvnagqrsbangfk"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("aueftsrrlycatffkpfodjjnydnt"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2109835250));

                Assert.That(model.ModelInner.Value, Is.EqualTo("aexwbhcdkx"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1953014780));
                Assert.That(model.Value, Is.EqualTo("vabkgcoqtalkco"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("bhuaxvfrdoc"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1721043254));

                Assert.That(model.ModelInner.Value, Is.EqualTo("xglpwfepkoqwfmfymvyckddth"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1981244764));
                Assert.That(model.Value, Is.EqualTo("wnvhbcqkbtcj"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("neakdcg"));

                Assert.That(model.ModelInner, Is.Null);

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IStringSingleTypetext)this).CreateDbConnectionSelectModelCommand(connection);
                ((IStringSingleTypetext)this).SetDbConnectionSelectModelParametrs(cmd, 1045323454);
                var models =  ((IStringSingleTypetext)this).ExecuteDbConnectionSelectModelCommand(cmd).ToList();

                Assert.That(models, Has.Count.EqualTo(16));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1058873480));
                Assert.That(model.Value, Is.EqualTo("novgsxrmujmayooytesrxfxqyfqg"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("oeoesjuye"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(87445043));

                Assert.That(model.ModelInner.Value, Is.EqualTo("eqjigdkcsbquqqxn"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("bchqcfbnutypftt"));

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1082479129));
                Assert.That(model.Value, Is.EqualTo("hamqoqxpjfuybtplxu"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1753416003));

                Assert.That(model.ModelInner.Value, Is.EqualTo("fexckkvl"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("smelahduylehglodcnawwb"));

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1092279008));
                Assert.That(model.Value, Is.EqualTo("cxbecsykrltfyxkchtlbqaeek"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2050310934));

                Assert.That(model.ModelInner.Value, Is.EqualTo("yyhyrhnjxvufi"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1254473920));
                Assert.That(model.Value, Is.EqualTo("ebkuvcaxtcxfevxd"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("gyydkiuvlnwvtgshltvqfm"));

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1267388319));
                Assert.That(model.Value, Is.EqualTo("friwkbqw"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1481720908));
                Assert.That(model.Value, Is.EqualTo("qpshnlus"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("jbanuunrrdna"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1940474468));

                Assert.That(model.ModelInner.Value, Is.EqualTo("tidbpqyhaxqqeweheayt"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("wjlynobfawmkwongdhtsf"));

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1537897125));
                Assert.That(model.Value, Is.EqualTo("prndbvwnioehfugepmf"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("fts"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(665411996));

                Assert.That(model.ModelInner.Value, Is.EqualTo("qss"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("daeiuelowvn"));

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1709228362));
                Assert.That(model.Value, Is.EqualTo("veisjxwi"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1780751115));
                Assert.That(model.Value, Is.EqualTo("amqcphqkutxuejxad"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("vqqbxxbcwavhu"));

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1802400137));
                Assert.That(model.Value, Is.EqualTo("kxepmqwnyfbxye"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("ebksjixxexfeohg"));

                Assert.That(model.ModelInner, Is.Null);

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1870930699));
                Assert.That(model.Value, Is.EqualTo("xsltolgmlpvfrohdxnx"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("euiimid"));

                Assert.That(model.ModelInner, Is.Null);

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1902472190));
                Assert.That(model.Value, Is.EqualTo("ljcp"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("aumrmtynvishbygjysdqt"));

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1931560927));
                Assert.That(model.Value, Is.EqualTo("ywfhrje"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("gxsgfqrg"));

                Assert.That(model.ModelInner, Is.Null);

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1942405729));
                Assert.That(model.Value, Is.EqualTo("htokuanavyrbhqqdvnagqrsbangfk"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("aueftsrrlycatffkpfodjjnydnt"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2109835250));

                Assert.That(model.ModelInner.Value, Is.EqualTo("aexwbhcdkx"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1953014780));
                Assert.That(model.Value, Is.EqualTo("vabkgcoqtalkco"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("bhuaxvfrdoc"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1721043254));

                Assert.That(model.ModelInner.Value, Is.EqualTo("xglpwfepkoqwfmfymvyckddth"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1981244764));
                Assert.That(model.Value, Is.EqualTo("wnvhbcqkbtcj"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("neakdcg"));

                Assert.That(model.ModelInner, Is.Null);

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                await using var cmd = await ((IStringSingleTypetext)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IStringSingleTypetext)this).SetDbConnectionSelectModelParametrs(cmd, 139609746);
                var models = await ((IStringSingleTypetext)this).ExecuteDbConnectionSelectModelCommandAsync(cmd).ToListAsync();

                Assert.That(models, Has.Count.EqualTo(28));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(171086619));
                Assert.That(model.Value, Is.EqualTo(""));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1608653137));

                Assert.That(model.ModelInner.Value, Is.EqualTo("rmccg"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("qnnnyohorodxgjkrpeisuv"));

                model = models[1];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(178840786));
                Assert.That(model.Value, Is.EqualTo("rhqbulk"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("udygunbj"));

                Assert.That(model.ModelInner, Is.Null);

                model = models[2];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(227394632));
                Assert.That(model.Value, Is.EqualTo("ovihfr"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1022425685));

                Assert.That(model.ModelInner.Value, Is.EqualTo("freabjruh"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("twceuqer"));

                model = models[3];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(249195449));
                Assert.That(model.Value, Is.EqualTo("rmylyahgcmnvxlnldeftwno"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("tkgpxemteoissuk"));

                Assert.That(model.ModelInner, Is.Null);

                model = models[4];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(608460427));
                Assert.That(model.Value, Is.EqualTo(""));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1939606812));

                Assert.That(model.ModelInner.Value, Is.EqualTo("gebgm"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("hdmiiqijkjhirxyvlcxl"));

                model = models[5];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(652948993));
                Assert.That(model.Value, Is.EqualTo("svhwdxwjejcu"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1107945570));

                Assert.That(model.ModelInner.Value, Is.EqualTo("dhgqcjl"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[6];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(738372288));
                Assert.That(model.Value, Is.EqualTo("mckpyaehqysr"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("jyec"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1743439641));

                Assert.That(model.ModelInner.Value, Is.EqualTo("uluh"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("gatnsqf"));

                model = models[7];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(787262827));
                Assert.That(model.Value, Is.EqualTo("dmojijjigjvuk"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[8];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(864081612));
                Assert.That(model.Value, Is.EqualTo(""));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[9];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(906852092));
                Assert.That(model.Value, Is.EqualTo("nwhurnbtxwmuusa"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(374965926));

                Assert.That(model.ModelInner.Value, Is.EqualTo("bwpvvsvusxkwtjpgdky"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("lfnbpkr"));

                model = models[10];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(913744506));
                Assert.That(model.Value, Is.EqualTo("ooxmarfjmbuxpksnkbo"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("ihqtdeudoriruavenu"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1658888405));

                Assert.That(model.ModelInner.Value, Is.EqualTo("ihuoivwjxaeuppqpjafuyabyepfx"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("jwsotfcpdahodtdusjindwgq"));

                model = models[11];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1045323454));
                Assert.That(model.Value, Is.EqualTo("rmv"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("qsjjde"));

                Assert.That(model.ModelInner, Is.Null);

                model = models[12];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1058873480));
                Assert.That(model.Value, Is.EqualTo("novgsxrmujmayooytesrxfxqyfqg"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("oeoesjuye"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(87445043));

                Assert.That(model.ModelInner.Value, Is.EqualTo("eqjigdkcsbquqqxn"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("bchqcfbnutypftt"));

                model = models[13];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1082479129));
                Assert.That(model.Value, Is.EqualTo("hamqoqxpjfuybtplxu"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1753416003));

                Assert.That(model.ModelInner.Value, Is.EqualTo("fexckkvl"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("smelahduylehglodcnawwb"));

                model = models[14];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1092279008));
                Assert.That(model.Value, Is.EqualTo("cxbecsykrltfyxkchtlbqaeek"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2050310934));

                Assert.That(model.ModelInner.Value, Is.EqualTo("yyhyrhnjxvufi"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[15];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1254473920));
                Assert.That(model.Value, Is.EqualTo("ebkuvcaxtcxfevxd"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("gyydkiuvlnwvtgshltvqfm"));

                Assert.That(model.ModelInner, Is.Null);

                model = models[16];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1267388319));
                Assert.That(model.Value, Is.EqualTo("friwkbqw"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[17];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1481720908));
                Assert.That(model.Value, Is.EqualTo("qpshnlus"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("jbanuunrrdna"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1940474468));

                Assert.That(model.ModelInner.Value, Is.EqualTo("tidbpqyhaxqqeweheayt"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("wjlynobfawmkwongdhtsf"));

                model = models[18];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1537897125));
                Assert.That(model.Value, Is.EqualTo("prndbvwnioehfugepmf"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("fts"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(665411996));

                Assert.That(model.ModelInner.Value, Is.EqualTo("qss"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("daeiuelowvn"));

                model = models[19];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1709228362));
                Assert.That(model.Value, Is.EqualTo("veisjxwi"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[20];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1780751115));
                Assert.That(model.Value, Is.EqualTo("amqcphqkutxuejxad"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("vqqbxxbcwavhu"));

                Assert.That(model.ModelInner, Is.Null);

                model = models[21];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1802400137));
                Assert.That(model.Value, Is.EqualTo("kxepmqwnyfbxye"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("ebksjixxexfeohg"));

                Assert.That(model.ModelInner, Is.Null);

                model = models[22];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1870930699));
                Assert.That(model.Value, Is.EqualTo("xsltolgmlpvfrohdxnx"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("euiimid"));

                Assert.That(model.ModelInner, Is.Null);

                model = models[23];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1902472190));
                Assert.That(model.Value, Is.EqualTo("ljcp"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("aumrmtynvishbygjysdqt"));

                Assert.That(model.ModelInner, Is.Null);

                model = models[24];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1931560927));
                Assert.That(model.Value, Is.EqualTo("ywfhrje"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("gxsgfqrg"));

                Assert.That(model.ModelInner, Is.Null);

                model = models[25];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1942405729));
                Assert.That(model.Value, Is.EqualTo("htokuanavyrbhqqdvnagqrsbangfk"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("aueftsrrlycatffkpfodjjnydnt"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2109835250));

                Assert.That(model.ModelInner.Value, Is.EqualTo("aexwbhcdkx"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[26];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1953014780));
                Assert.That(model.Value, Is.EqualTo("vabkgcoqtalkco"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("bhuaxvfrdoc"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1721043254));

                Assert.That(model.ModelInner.Value, Is.EqualTo("xglpwfepkoqwfmfymvyckddth"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1981244764));
                Assert.That(model.Value, Is.EqualTo("wnvhbcqkbtcj"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("neakdcg"));

                Assert.That(model.ModelInner, Is.Null);

            }
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringSingleTypetext)
            ),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModel",
            position: 1
            ),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModel",
            position: 2
            )
            ]
        private void DbConnectionSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                 foreach(var batchResult in ((IStringSingleTypetext)this).DbConnectionSelectModelBatch(connection, 608460427, 1254473920))
                {
                    if(++resultIndex == 1)
                    {
                        var models =  batchResult.ToList();

                        Assert.That(models, Has.Count.EqualTo(23));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(652948993));
                Assert.That(model.Value, Is.EqualTo("svhwdxwjejcu"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1107945570));

                Assert.That(model.ModelInner.Value, Is.EqualTo("dhgqcjl"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(738372288));
                Assert.That(model.Value, Is.EqualTo("mckpyaehqysr"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("jyec"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1743439641));

                Assert.That(model.ModelInner.Value, Is.EqualTo("uluh"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("gatnsqf"));

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(787262827));
                Assert.That(model.Value, Is.EqualTo("dmojijjigjvuk"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(864081612));
                Assert.That(model.Value, Is.EqualTo(""));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(906852092));
                Assert.That(model.Value, Is.EqualTo("nwhurnbtxwmuusa"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(374965926));

                Assert.That(model.ModelInner.Value, Is.EqualTo("bwpvvsvusxkwtjpgdky"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("lfnbpkr"));

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(913744506));
                Assert.That(model.Value, Is.EqualTo("ooxmarfjmbuxpksnkbo"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("ihqtdeudoriruavenu"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1658888405));

                Assert.That(model.ModelInner.Value, Is.EqualTo("ihuoivwjxaeuppqpjafuyabyepfx"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("jwsotfcpdahodtdusjindwgq"));

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1045323454));
                Assert.That(model.Value, Is.EqualTo("rmv"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("qsjjde"));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1058873480));
                Assert.That(model.Value, Is.EqualTo("novgsxrmujmayooytesrxfxqyfqg"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("oeoesjuye"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(87445043));

                Assert.That(model.ModelInner.Value, Is.EqualTo("eqjigdkcsbquqqxn"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("bchqcfbnutypftt"));

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1082479129));
                Assert.That(model.Value, Is.EqualTo("hamqoqxpjfuybtplxu"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1753416003));

                Assert.That(model.ModelInner.Value, Is.EqualTo("fexckkvl"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("smelahduylehglodcnawwb"));

                        model = models[9];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1092279008));
                Assert.That(model.Value, Is.EqualTo("cxbecsykrltfyxkchtlbqaeek"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2050310934));

                Assert.That(model.ModelInner.Value, Is.EqualTo("yyhyrhnjxvufi"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[10];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1254473920));
                Assert.That(model.Value, Is.EqualTo("ebkuvcaxtcxfevxd"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("gyydkiuvlnwvtgshltvqfm"));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[11];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1267388319));
                Assert.That(model.Value, Is.EqualTo("friwkbqw"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[12];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1481720908));
                Assert.That(model.Value, Is.EqualTo("qpshnlus"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("jbanuunrrdna"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1940474468));

                Assert.That(model.ModelInner.Value, Is.EqualTo("tidbpqyhaxqqeweheayt"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("wjlynobfawmkwongdhtsf"));

                        model = models[13];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1537897125));
                Assert.That(model.Value, Is.EqualTo("prndbvwnioehfugepmf"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("fts"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(665411996));

                Assert.That(model.ModelInner.Value, Is.EqualTo("qss"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("daeiuelowvn"));

                        model = models[14];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1709228362));
                Assert.That(model.Value, Is.EqualTo("veisjxwi"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[15];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1780751115));
                Assert.That(model.Value, Is.EqualTo("amqcphqkutxuejxad"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("vqqbxxbcwavhu"));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[16];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1802400137));
                Assert.That(model.Value, Is.EqualTo("kxepmqwnyfbxye"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("ebksjixxexfeohg"));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[17];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1870930699));
                Assert.That(model.Value, Is.EqualTo("xsltolgmlpvfrohdxnx"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("euiimid"));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[18];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1902472190));
                Assert.That(model.Value, Is.EqualTo("ljcp"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("aumrmtynvishbygjysdqt"));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[19];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1931560927));
                Assert.That(model.Value, Is.EqualTo("ywfhrje"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("gxsgfqrg"));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[20];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1942405729));
                Assert.That(model.Value, Is.EqualTo("htokuanavyrbhqqdvnagqrsbangfk"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("aueftsrrlycatffkpfodjjnydnt"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2109835250));

                Assert.That(model.ModelInner.Value, Is.EqualTo("aexwbhcdkx"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[21];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1953014780));
                Assert.That(model.Value, Is.EqualTo("vabkgcoqtalkco"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("bhuaxvfrdoc"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1721043254));

                Assert.That(model.ModelInner.Value, Is.EqualTo("xglpwfepkoqwfmfymvyckddth"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[22];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1981244764));
                Assert.That(model.Value, Is.EqualTo("wnvhbcqkbtcj"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("neakdcg"));

                Assert.That(model.ModelInner, Is.Null);

                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models =  batchResult.ToList();
                        Assert.That(models, Has.Count.EqualTo(12));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1267388319));
                Assert.That(model.Value, Is.EqualTo("friwkbqw"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1481720908));
                Assert.That(model.Value, Is.EqualTo("qpshnlus"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("jbanuunrrdna"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1940474468));

                Assert.That(model.ModelInner.Value, Is.EqualTo("tidbpqyhaxqqeweheayt"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("wjlynobfawmkwongdhtsf"));

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1537897125));
                Assert.That(model.Value, Is.EqualTo("prndbvwnioehfugepmf"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("fts"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(665411996));

                Assert.That(model.ModelInner.Value, Is.EqualTo("qss"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("daeiuelowvn"));

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1709228362));
                Assert.That(model.Value, Is.EqualTo("veisjxwi"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1780751115));
                Assert.That(model.Value, Is.EqualTo("amqcphqkutxuejxad"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("vqqbxxbcwavhu"));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1802400137));
                Assert.That(model.Value, Is.EqualTo("kxepmqwnyfbxye"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("ebksjixxexfeohg"));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1870930699));
                Assert.That(model.Value, Is.EqualTo("xsltolgmlpvfrohdxnx"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("euiimid"));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1902472190));
                Assert.That(model.Value, Is.EqualTo("ljcp"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("aumrmtynvishbygjysdqt"));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1931560927));
                Assert.That(model.Value, Is.EqualTo("ywfhrje"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("gxsgfqrg"));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[9];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1942405729));
                Assert.That(model.Value, Is.EqualTo("htokuanavyrbhqqdvnagqrsbangfk"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("aueftsrrlycatffkpfodjjnydnt"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2109835250));

                Assert.That(model.ModelInner.Value, Is.EqualTo("aexwbhcdkx"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[10];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1953014780));
                Assert.That(model.Value, Is.EqualTo("vabkgcoqtalkco"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("bhuaxvfrdoc"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1721043254));

                Assert.That(model.ModelInner.Value, Is.EqualTo("xglpwfepkoqwfmfymvyckddth"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[11];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1981244764));
                Assert.That(model.Value, Is.EqualTo("wnvhbcqkbtcj"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("neakdcg"));

                Assert.That(model.ModelInner, Is.Null);

                        continue;
                    }
                    
                    //todo return false
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
                await foreach(var batchResult in ((IStringSingleTypetext)this).DbConnectionSelectModelBatchAsync(connection, 178840786, 1870930699))
                {
                    if(++resultIndex == 1)
                    {
                        var models = await batchResult.ToListAsync();

                        Assert.That(models, Has.Count.EqualTo(26));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(227394632));
                Assert.That(model.Value, Is.EqualTo("ovihfr"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1022425685));

                Assert.That(model.ModelInner.Value, Is.EqualTo("freabjruh"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("twceuqer"));

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(249195449));
                Assert.That(model.Value, Is.EqualTo("rmylyahgcmnvxlnldeftwno"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("tkgpxemteoissuk"));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(608460427));
                Assert.That(model.Value, Is.EqualTo(""));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1939606812));

                Assert.That(model.ModelInner.Value, Is.EqualTo("gebgm"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("hdmiiqijkjhirxyvlcxl"));

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(652948993));
                Assert.That(model.Value, Is.EqualTo("svhwdxwjejcu"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1107945570));

                Assert.That(model.ModelInner.Value, Is.EqualTo("dhgqcjl"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(738372288));
                Assert.That(model.Value, Is.EqualTo("mckpyaehqysr"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("jyec"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1743439641));

                Assert.That(model.ModelInner.Value, Is.EqualTo("uluh"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("gatnsqf"));

                        model = models[5];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(787262827));
                Assert.That(model.Value, Is.EqualTo("dmojijjigjvuk"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[6];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(864081612));
                Assert.That(model.Value, Is.EqualTo(""));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[7];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(906852092));
                Assert.That(model.Value, Is.EqualTo("nwhurnbtxwmuusa"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(374965926));

                Assert.That(model.ModelInner.Value, Is.EqualTo("bwpvvsvusxkwtjpgdky"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("lfnbpkr"));

                        model = models[8];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(913744506));
                Assert.That(model.Value, Is.EqualTo("ooxmarfjmbuxpksnkbo"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("ihqtdeudoriruavenu"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1658888405));

                Assert.That(model.ModelInner.Value, Is.EqualTo("ihuoivwjxaeuppqpjafuyabyepfx"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("jwsotfcpdahodtdusjindwgq"));

                        model = models[9];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1045323454));
                Assert.That(model.Value, Is.EqualTo("rmv"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("qsjjde"));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[10];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1058873480));
                Assert.That(model.Value, Is.EqualTo("novgsxrmujmayooytesrxfxqyfqg"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("oeoesjuye"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(87445043));

                Assert.That(model.ModelInner.Value, Is.EqualTo("eqjigdkcsbquqqxn"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("bchqcfbnutypftt"));

                        model = models[11];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1082479129));
                Assert.That(model.Value, Is.EqualTo("hamqoqxpjfuybtplxu"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1753416003));

                Assert.That(model.ModelInner.Value, Is.EqualTo("fexckkvl"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("smelahduylehglodcnawwb"));

                        model = models[12];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1092279008));
                Assert.That(model.Value, Is.EqualTo("cxbecsykrltfyxkchtlbqaeek"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2050310934));

                Assert.That(model.ModelInner.Value, Is.EqualTo("yyhyrhnjxvufi"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[13];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1254473920));
                Assert.That(model.Value, Is.EqualTo("ebkuvcaxtcxfevxd"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("gyydkiuvlnwvtgshltvqfm"));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[14];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1267388319));
                Assert.That(model.Value, Is.EqualTo("friwkbqw"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[15];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1481720908));
                Assert.That(model.Value, Is.EqualTo("qpshnlus"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("jbanuunrrdna"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1940474468));

                Assert.That(model.ModelInner.Value, Is.EqualTo("tidbpqyhaxqqeweheayt"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("wjlynobfawmkwongdhtsf"));

                        model = models[16];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1537897125));
                Assert.That(model.Value, Is.EqualTo("prndbvwnioehfugepmf"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("fts"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(665411996));

                Assert.That(model.ModelInner.Value, Is.EqualTo("qss"));

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                Assert.That(model.ModelInner.NullableValue, Is.EqualTo("daeiuelowvn"));

                        model = models[17];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1709228362));
                Assert.That(model.Value, Is.EqualTo("veisjxwi"));

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[18];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1780751115));
                Assert.That(model.Value, Is.EqualTo("amqcphqkutxuejxad"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("vqqbxxbcwavhu"));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[19];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1802400137));
                Assert.That(model.Value, Is.EqualTo("kxepmqwnyfbxye"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("ebksjixxexfeohg"));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[20];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1870930699));
                Assert.That(model.Value, Is.EqualTo("xsltolgmlpvfrohdxnx"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("euiimid"));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[21];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1902472190));
                Assert.That(model.Value, Is.EqualTo("ljcp"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("aumrmtynvishbygjysdqt"));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[22];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1931560927));
                Assert.That(model.Value, Is.EqualTo("ywfhrje"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("gxsgfqrg"));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[23];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1942405729));
                Assert.That(model.Value, Is.EqualTo("htokuanavyrbhqqdvnagqrsbangfk"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("aueftsrrlycatffkpfodjjnydnt"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2109835250));

                Assert.That(model.ModelInner.Value, Is.EqualTo("aexwbhcdkx"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[24];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1953014780));
                Assert.That(model.Value, Is.EqualTo("vabkgcoqtalkco"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("bhuaxvfrdoc"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1721043254));

                Assert.That(model.ModelInner.Value, Is.EqualTo("xglpwfepkoqwfmfymvyckddth"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[25];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1981244764));
                Assert.That(model.Value, Is.EqualTo("wnvhbcqkbtcj"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("neakdcg"));

                Assert.That(model.ModelInner, Is.Null);

                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = await batchResult.ToListAsync();
                        Assert.That(models, Has.Count.EqualTo(5));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1902472190));
                Assert.That(model.Value, Is.EqualTo("ljcp"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("aumrmtynvishbygjysdqt"));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[1];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1931560927));
                Assert.That(model.Value, Is.EqualTo("ywfhrje"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("gxsgfqrg"));

                Assert.That(model.ModelInner, Is.Null);

                        model = models[2];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1942405729));
                Assert.That(model.Value, Is.EqualTo("htokuanavyrbhqqdvnagqrsbangfk"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("aueftsrrlycatffkpfodjjnydnt"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2109835250));

                Assert.That(model.ModelInner.Value, Is.EqualTo("aexwbhcdkx"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[3];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1953014780));
                Assert.That(model.Value, Is.EqualTo("vabkgcoqtalkco"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("bhuaxvfrdoc"));

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1721043254));

                Assert.That(model.ModelInner.Value, Is.EqualTo("xglpwfepkoqwfmfymvyckddth"));

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        model = models[4];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1981244764));
                Assert.That(model.Value, Is.EqualTo("wnvhbcqkbtcj"));

                Assert.That(model.NullableValue, Is.Not.Null);
                Assert.That(model.NullableValue, Is.EqualTo("neakdcg"));

                Assert.That(model.ModelInner, Is.Null);

                        continue;
                    }
                    
                    //todo return false
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
                Assert.That((System.Int32)model[0], Is.EqualTo((14757608)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("ipmooujfaatsirilxdlapp")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2226021)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("hyuxbdmwuxhmtmhrk")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139609746)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("arunhp")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("")));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((171086619)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1608653137)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("rmccg")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("qnnnyohorodxgjkrpeisuv")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((178840786)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("rhqbulk")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("udygunbj")));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((227394632)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("ovihfr")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1022425685)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("freabjruh")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("twceuqer")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((249195449)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("rmylyahgcmnvxlnldeftwno")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("tkgpxemteoissuk")));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((608460427)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1939606812)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("gebgm")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("hdmiiqijkjhirxyvlcxl")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((652948993)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("svhwdxwjejcu")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1107945570)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("dhgqcjl")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((738372288)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("mckpyaehqysr")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1743439641)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("uluh")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("gatnsqf")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("jyec")));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((787262827)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("dmojijjigjvuk")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((864081612)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((906852092)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("nwhurnbtxwmuusa")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((374965926)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("bwpvvsvusxkwtjpgdky")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("lfnbpkr")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((913744506)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("ooxmarfjmbuxpksnkbo")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1658888405)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("ihuoivwjxaeuppqpjafuyabyepfx")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("jwsotfcpdahodtdusjindwgq")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("ihqtdeudoriruavenu")));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1045323454)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("rmv")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("qsjjde")));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1058873480)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("novgsxrmujmayooytesrxfxqyfqg")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((87445043)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("eqjigdkcsbquqqxn")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("bchqcfbnutypftt")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("oeoesjuye")));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1082479129)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("hamqoqxpjfuybtplxu")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1753416003)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("fexckkvl")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("smelahduylehglodcnawwb")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1092279008)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("cxbecsykrltfyxkchtlbqaeek")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2050310934)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("yyhyrhnjxvufi")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1254473920)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("ebkuvcaxtcxfevxd")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("gyydkiuvlnwvtgshltvqfm")));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1267388319)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("friwkbqw")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1481720908)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("qpshnlus")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1940474468)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("tidbpqyhaxqqeweheayt")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("wjlynobfawmkwongdhtsf")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("jbanuunrrdna")));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1537897125)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("prndbvwnioehfugepmf")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((665411996)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("qss")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("daeiuelowvn")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("fts")));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1709228362)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("veisjxwi")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1780751115)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("amqcphqkutxuejxad")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("vqqbxxbcwavhu")));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1802400137)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("kxepmqwnyfbxye")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("ebksjixxexfeohg")));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1870930699)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("xsltolgmlpvfrohdxnx")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("euiimid")));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1902472190)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("ljcp")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("aumrmtynvishbygjysdqt")));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1931560927)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("ywfhrje")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("gxsgfqrg")));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1942405729)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("htokuanavyrbhqqdvnagqrsbangfk")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2109835250)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("aexwbhcdkx")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("aueftsrrlycatffkpfodjjnydnt")));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1953014780)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("vabkgcoqtalkco")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1721043254)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("xglpwfepkoqwfmfymvyckddth")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("bhuaxvfrdoc")));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1981244764)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("wnvhbcqkbtcj")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("neakdcg")));

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
                Assert.That((System.Int32)model[0], Is.EqualTo((14757608)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("ipmooujfaatsirilxdlapp")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2226021)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("hyuxbdmwuxhmtmhrk")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139609746)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("arunhp")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("")));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((171086619)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1608653137)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("rmccg")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("qnnnyohorodxgjkrpeisuv")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((178840786)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("rhqbulk")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("udygunbj")));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((227394632)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("ovihfr")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1022425685)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("freabjruh")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("twceuqer")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((249195449)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("rmylyahgcmnvxlnldeftwno")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("tkgpxemteoissuk")));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((608460427)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1939606812)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("gebgm")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("hdmiiqijkjhirxyvlcxl")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((652948993)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("svhwdxwjejcu")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1107945570)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("dhgqcjl")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((738372288)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("mckpyaehqysr")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1743439641)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("uluh")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("gatnsqf")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("jyec")));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((787262827)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("dmojijjigjvuk")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((864081612)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((906852092)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("nwhurnbtxwmuusa")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((374965926)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("bwpvvsvusxkwtjpgdky")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("lfnbpkr")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((913744506)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("ooxmarfjmbuxpksnkbo")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1658888405)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("ihuoivwjxaeuppqpjafuyabyepfx")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("jwsotfcpdahodtdusjindwgq")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("ihqtdeudoriruavenu")));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1045323454)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("rmv")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("qsjjde")));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1058873480)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("novgsxrmujmayooytesrxfxqyfqg")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((87445043)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("eqjigdkcsbquqqxn")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("bchqcfbnutypftt")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("oeoesjuye")));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1082479129)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("hamqoqxpjfuybtplxu")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1753416003)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("fexckkvl")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("smelahduylehglodcnawwb")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1092279008)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("cxbecsykrltfyxkchtlbqaeek")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2050310934)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("yyhyrhnjxvufi")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1254473920)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("ebkuvcaxtcxfevxd")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("gyydkiuvlnwvtgshltvqfm")));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1267388319)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("friwkbqw")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1481720908)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("qpshnlus")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1940474468)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("tidbpqyhaxqqeweheayt")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("wjlynobfawmkwongdhtsf")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("jbanuunrrdna")));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1537897125)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("prndbvwnioehfugepmf")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((665411996)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("qss")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("daeiuelowvn")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("fts")));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1709228362)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("veisjxwi")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1780751115)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("amqcphqkutxuejxad")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("vqqbxxbcwavhu")));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1802400137)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("kxepmqwnyfbxye")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("ebksjixxexfeohg")));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1870930699)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("xsltolgmlpvfrohdxnx")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("euiimid")));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1902472190)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("ljcp")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("aumrmtynvishbygjysdqt")));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1931560927)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("ywfhrje")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("gxsgfqrg")));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1942405729)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("htokuanavyrbhqqdvnagqrsbangfk")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2109835250)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("aexwbhcdkx")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("aueftsrrlycatffkpfodjjnydnt")));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1953014780)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("vabkgcoqtalkco")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1721043254)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("xglpwfepkoqwfmfymvyckddth")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("bhuaxvfrdoc")));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1981244764)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("wnvhbcqkbtcj")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value));//InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value));//InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("neakdcg")));

            }
        }

        #endregion

    }
}

