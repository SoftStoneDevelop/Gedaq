

using Npgsql;
using NpgsqlTypes;
using Gedaq.Common.Enums;
using Gedaq.Npgsql.Attributes;
using Gedaq.Npgsql.Enums;
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
    Id = 5,
    Value = "mdnjkyxffgypbrtfhgbxeg",
    ModelInner = null,
    NullableValue = null,
},
            new StringtextE0M
{
    Id = 10,
    Value = "pbsvlwxdjhnwxlxygvskfkni",
    ModelInner = new StringtextE0MI
{
    Id = 7,
    Value = "rowjdbxmjfdourjdewuqqriwklcdw",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringtextE0M
{
    Id = 14,
    Value = "vdjvijgvurh",
    ModelInner = null,
    NullableValue = "egu",
},
            new StringtextE0M
{
    Id = 15,
    Value = "ahylskgaufcuxxcnaxrhcs",
    ModelInner = new StringtextE0MI
{
    Id = 9,
    Value = "xwjvqqbvxuktcjskcrd",
    NullableValue = null,
},
    NullableValue = "dnawmraeqjixyv",
},
            new StringtextE0M
{
    Id = 20,
    Value = "srynjgrbmahavrtmkqnpccr",
    ModelInner = null,
    NullableValue = "sajeaqbrwxcml",
},
            new StringtextE0M
{
    Id = 21,
    Value = "rxnnhfjljddnaltflbyjnw",
    ModelInner = new StringtextE0MI
{
    Id = 15,
    Value = "hmgrqedfkvfnlgbvaauhp",
    NullableValue = null,
},
    NullableValue = "pfuthlf",
},
            new StringtextE0M
{
    Id = 27,
    Value = "fahmbrigjjbowpec",
    ModelInner = null,
    NullableValue = "isahhonbnepqwhdseqebwr",
},
            new StringtextE0M
{
    Id = 31,
    Value = "hlcrriu",
    ModelInner = new StringtextE0MI
{
    Id = 18,
    Value = "ktauaocrwgfaaqxdpkefgooxhow",
    NullableValue = null,
},
    NullableValue = "obrevxnbdjgdscpxdcj",
},
            new StringtextE0M
{
    Id = 32,
    Value = "okpl",
    ModelInner = null,
    NullableValue = null,
},
            new StringtextE0M
{
    Id = 39,
    Value = "xnqxogfxsrtojluuhwawxmrstxuys",
    ModelInner = new StringtextE0MI
{
    Id = 27,
    Value = "ckvrydxxtgey",
    NullableValue = null,
},
    NullableValue = "mdupoaxld",
},
            new StringtextE0M
{
    Id = 44,
    Value = "bqfootjivyebscx",
    ModelInner = null,
    NullableValue = "edfcohgmdatiaddiyvjlyirdspv",
},
            new StringtextE0M
{
    Id = 50,
    Value = "ifgpceeloj",
    ModelInner = new StringtextE0MI
{
    Id = 33,
    Value = "ftmackhgjjps",
    NullableValue = "wtetlwecrwtth",
},
    NullableValue = null,
},
            new StringtextE0M
{
    Id = 57,
    Value = "yaaswbmgycfgnvkr",
    ModelInner = null,
    NullableValue = null,
},
            new StringtextE0M
{
    Id = 63,
    Value = "aamqpsbucvjyyjx",
    ModelInner = new StringtextE0MI
{
    Id = 35,
    Value = "brlnitiokomoyukvcrev",
    NullableValue = "uawjuhso",
},
    NullableValue = null,
},
            new StringtextE0M
{
    Id = 69,
    Value = "lfvi",
    ModelInner = null,
    NullableValue = null,
},
            new StringtextE0M
{
    Id = 78,
    Value = "vbybpmfxphmdsfkku",
    ModelInner = new StringtextE0MI
{
    Id = 38,
    Value = "oquaolsykmywgqykkym",
    NullableValue = "fjmapxatoqhe",
},
    NullableValue = "f",
},
            new StringtextE0M
{
    Id = 84,
    Value = "dth",
    ModelInner = null,
    NullableValue = "eolynjduubumfroalutxt",
},
            new StringtextE0M
{
    Id = 89,
    Value = "vyevmfxgwcuvftyxvlkdfboavxjms",
    ModelInner = new StringtextE0MI
{
    Id = 43,
    Value = "rvqjupwlthgynrdv",
    NullableValue = null,
},
    NullableValue = "jglsayiebomrac",
},
            new StringtextE0M
{
    Id = 92,
    Value = "vvufobldnokbthao",
    ModelInner = null,
    NullableValue = "hntxvitt",
},
            new StringtextE0M
{
    Id = 97,
    Value = "uw",
    ModelInner = new StringtextE0MI
{
    Id = 52,
    Value = "fbpogvneiuliac",
    NullableValue = "wadrkjadkxdyfxtjfiro",
},
    NullableValue = null,
},
            new StringtextE0M
{
    Id = 105,
    Value = "nkyokvqrctqrvcuyrluuwljie",
    ModelInner = null,
    NullableValue = "vwdurgnfybvpygexm",
},
            new StringtextE0M
{
    Id = 111,
    Value = "lcvqlfkk",
    ModelInner = new StringtextE0MI
{
    Id = 54,
    Value = "thovpuflfadkniqdyxruqoed",
    NullableValue = "p",
},
    NullableValue = null,
},
            new StringtextE0M
{
    Id = 120,
    Value = "vleeerxl",
    ModelInner = null,
    NullableValue = null,
},
            new StringtextE0M
{
    Id = 121,
    Value = "rsuplocivo",
    ModelInner = new StringtextE0MI
{
    Id = 59,
    Value = "wtwoipalrhqwwcysnhioirjobx",
    NullableValue = "wwbfmeqr",
},
    NullableValue = null,
},
            new StringtextE0M
{
    Id = 128,
    Value = "hdgxoqsubpkkfkgyxbwri",
    ModelInner = null,
    NullableValue = "ysdanhjnswdmbqygkwc",
},
            new StringtextE0M
{
    Id = 133,
    Value = "iwihn",
    ModelInner = new StringtextE0MI
{
    Id = 66,
    Value = "jrgudcijhx",
    NullableValue = "cllto",
},
    NullableValue = null,
},
            new StringtextE0M
{
    Id = 137,
    Value = "vhrangaggfgdehmmupwencilvjj",
    ModelInner = null,
    NullableValue = null,
},
            new StringtextE0M
{
    Id = 140,
    Value = "cycbqilxcrixtydsch",
    ModelInner = new StringtextE0MI
{
    Id = 73,
    Value = "uvxymxdhdlxeahdmisyightlrc",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringtextE0M
{
    Id = 147,
    Value = "yxwxsafefj",
    ModelInner = null,
    NullableValue = null,
},
            new StringtextE0M
{
    Id = 153,
    Value = "arlvunm",
    ModelInner = new StringtextE0MI
{
    Id = 78,
    Value = "fgcygmpjrmtnmk",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringtextE0M
{
    Id = 157,
    Value = "thhsorpoyurcfjqjjtlajh",
    ModelInner = null,
    NullableValue = null,
},
            new StringtextE0M
{
    Id = 160,
    Value = "oqowriyrrrbw",
    ModelInner = new StringtextE0MI
{
    Id = 82,
    Value = "cq",
    NullableValue = "ccw",
},
    NullableValue = null,
},
            new StringtextE0M
{
    Id = 162,
    Value = "ujnludppwmlbxalwh",
    ModelInner = null,
    NullableValue = null,
},
            new StringtextE0M
{
    Id = 171,
    Value = "cmgjvnpbtfiduldxiuhq",
    ModelInner = new StringtextE0MI
{
    Id = 85,
    Value = "fyyfvcvjylesscewuytcl",
    NullableValue = "fuurtmxt",
},
    NullableValue = "mlcprbs",
},
            new StringtextE0M
{
    Id = 180,
    Value = "evdgvjwxertuchquqjwgijmnatfoj",
    ModelInner = null,
    NullableValue = "iddq",
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.stringtexte0mi(
	id,
    value,
    nullablevalue
)
VALUES (
    $1, 
    $2, 
    $3
);
",
            methodName:"InsertModelInner",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringSingleTypetext)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.String),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(19)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.String), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(19))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.stringtexte0mi(
	id,
    value,
    nullablevalue
)
VALUES (
    $1, 
    $2, 
    $3
)
RETURNING
    id,
    value,
    nullablevalue
;
",
            methodName:"InsertModelInnerReturning",
            queryMapTypes: [typeof(StringtextE0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringSingleTypetext)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.String),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(19)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.String), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(19))]
        public void InsertModelInnerReturningConfig()
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

        [Test, Order(0)]
        public async Task InsertModelInnerTestReturningScalar()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32 id = default;

                id =  ((IStringSingleTypetext)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IStringSingleTypetext)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[11].ModelInner.Id));

            }
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32 id = default;

                id = await ((IStringSingleTypetext)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IStringSingleTypetext)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.stringtexte0mi(
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

                changedRows =  ((IStringSingleTypetext)this).DbConnectionInsertInnerModel(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
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

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.stringtexte0m(
	id,
    value,
    nullablevalue,
    stringtexte0mi_id
)
VALUES (
    $1, 
    $2, 
    $3,
    $4
);
",
            methodName:"InsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringSingleTypetext)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.String),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(19)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.String), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(19)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "stringtexte0mi_id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
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

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.stringtexte0m(
	id,
    value,
    nullablevalue,
    stringtexte0mi_id
)
VALUES (
    $1, 
    $2, 
    $3,
    $4
)
RETURNING
    nullablevalue,
    value,
~StartInner::ModelInner:Id~
~Reinterpret::Id~
    stringtexte0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(StringtextE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringSingleTypetext)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalar()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.String nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<System.String>();
                    ((NpgsqlParameter<System.String>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(19);
                    ((NpgsqlParameter<System.String>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(19);
                    if (_testData[4].NullableValue != null)
                    {
                        parameters[2].Value = _testData[4].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[4].ModelInner != null)
                    {
                        parameters[3].Value = _testData[4].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable =  ((IStringSingleTypetext)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo("sajeaqbrwxcml"));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<System.String>();
                    ((NpgsqlParameter<System.String>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(19);
                    ((NpgsqlParameter<System.String>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(19);
                    if (_testData[5].NullableValue != null)
                    {
                        parameters[2].Value = _testData[5].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[5].ModelInner != null)
                    {
                        parameters[3].Value = _testData[5].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable =  ((IStringSingleTypetext)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo("pfuthlf"));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.String nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<System.String>();
                    ((NpgsqlParameter<System.String>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(19);
                    ((NpgsqlParameter<System.String>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(19);
                    if (_testData[6].NullableValue != null)
                    {
                        parameters[2].Value = _testData[6].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[6].ModelInner != null)
                    {
                        parameters[3].Value = _testData[6].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable = await ((IStringSingleTypetext)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo("isahhonbnepqwhdseqebwr"));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<System.String>();
                    ((NpgsqlParameter<System.String>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(19);
                    ((NpgsqlParameter<System.String>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(19);
                    if (_testData[7].NullableValue != null)
                    {
                        parameters[2].Value = _testData[7].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[7].ModelInner != null)
                    {
                        parameters[3].Value = _testData[7].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable = await ((IStringSingleTypetext)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo("obrevxnbdjgdscpxdcj"));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.stringtexte0m(
	id,
    value,
    nullablevalue,
    stringtexte0mi_id
)
VALUES (
    $1, 
    $2, 
    $3,
    $4
)
RETURNING
    nullablevalue,
    value,
~StartInner::ModelInner:Id~
~Reinterpret::Id~
    stringtexte0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(StringtextE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringSingleTypetext)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.String),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(19)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.String), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(19)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "stringtexte0mi_id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        public void InsertModelReturningConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalar()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.String nullable = null;
                nullable =  ((IStringSingleTypetext)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((IStringSingleTypetext)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo("mdupoaxld"));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.String nullable = null;
                nullable = await ((IStringSingleTypetext)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo("edfcohgmdatiaddiyvjlyirdspv"));
                nullable = await ((IStringSingleTypetext)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<StringtextE0M> models = null;

                models =  ((IStringSingleTypetext)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextE0M.AssertModel(models[0],_testData[12], true);
                models =  ((IStringSingleTypetext)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextE0M.AssertModel(models[0],_testData[13], true);
                models =  ((IStringSingleTypetext)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextE0M.AssertModel(models[0],_testData[14], true);
                models =  ((IStringSingleTypetext)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextE0M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<StringtextE0M> models = null;

                models = await ((IStringSingleTypetext)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextE0M.AssertModel(models[0],_testData[16], true);
                models = await ((IStringSingleTypetext)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextE0M.AssertModel(models[0],_testData[17], true);
                models = await ((IStringSingleTypetext)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextE0M.AssertModel(models[0],_testData[18], true);
                models = await ((IStringSingleTypetext)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextE0M.AssertModel(models[0],_testData[19], true);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.stringtexte0m(
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

                changedRows =  ((IStringSingleTypetext)this).DbConnectionInsertModel(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IStringSingleTypetext)this).DbConnectionInsertModel(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
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

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatStringtextE0M), typeof(FlatStringtextE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringSingleTypetext)),
Gedaq.Npgsql.Attributes.DynamicParametr()]
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
FROM public.stringtexte0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatStringtextE0M>();
                var models2 = new List<FlatStringtextE0M>();
                await ((IStringSingleTypetext)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
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
FROM public.stringtexte0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
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

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatStringtextE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringSingleTypetext)),
Gedaq.Npgsql.Attributes.DynamicParametr()]
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
FROM public.stringtexte0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IStringSingleTypetext)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
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
FROM public.stringtexte0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IStringSingleTypetext)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatStringtextE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
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
FROM public.stringtexte0m m
LEFT JOIN public.stringtexte0mi mi ON mi.id = m.stringtexte0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(StringtextE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringSingleTypetext)),
Gedaq.Npgsql.Attributes.DynamicParametr()]
        private void SelectModelDynParConfig()
        {
        }

        [Test, Order(2)]
        public async Task SelectModelDynParTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IStringSingleTypetext)this).SelectModelDynParAsync(connection, [parametr1]);
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
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IStringSingleTypetext)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    StringtextE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatStringtextE0M), typeof(FlatStringtextE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringSingleTypetext)),
Gedaq.Npgsql.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            position: 1,
            methodParametrName: "id",
            dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
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
FROM public.stringtexte0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatStringtextE0M>();
                var models2 = new List<FlatStringtextE0M>();
                await ((IStringSingleTypetext)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
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
FROM public.stringtexte0m m
WHERE 
    m.id > $1
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

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatStringtextE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringSingleTypetext)),
Gedaq.Npgsql.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            position: 1,
            methodParametrName: "id",
            dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
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
FROM public.stringtexte0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IStringSingleTypetext)this).DynQuerySelectModelAsync(connection,  query, 0);
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
FROM public.stringtexte0m m
WHERE 
    m.id > $1
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

[Gedaq.Npgsql.Attributes.Query(
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
FROM public.stringtexte0m m
LEFT JOIN public.stringtexte0mi mi ON mi.id = m.stringtexte0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(StringtextE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringSingleTypetext)),
Gedaq.Npgsql.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            position: 1,
            methodParametrName: "id",
            dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
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
FROM public.stringtexte0m m
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
                parametr1.Value = 160;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 44;
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
FROM public.stringtexte0m m
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
FROM public.stringtexte0m m
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
                parametr1.Value = 63;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 20;
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
FROM public.stringtexte0m m
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
FROM public.stringtexte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatStringtextE0M>();
                var firstItems2 = new List<FlatStringtextE0M>();
                var secondItems1 = new List<FlatStringtextE0M>();
                await ((IStringSingleTypetext)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
FROM public.stringtexte0m m
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
                parametr1.Value = 20;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 133;
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
FROM public.stringtexte0m m
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
FROM public.stringtexte0m m
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
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatStringtextE0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatStringtextE0M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatStringtextE0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatStringtextE0M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatStringtextE0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatStringtextE0M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatStringtextE0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatStringtextE0M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatStringtextE0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatStringtextE0M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatStringtextE0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatStringtextE0M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatStringtextE0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatStringtextE0M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatStringtextE0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatStringtextE0M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatStringtextE0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatStringtextE0M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatStringtextE0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatStringtextE0M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatStringtextE0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatStringtextE0M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatStringtextE0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatStringtextE0M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatStringtextE0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatStringtextE0M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatStringtextE0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatStringtextE0M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatStringtextE0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatStringtextE0M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatStringtextE0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatStringtextE0M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatStringtextE0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatStringtextE0M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatStringtextE0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatStringtextE0M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatStringtextE0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatStringtextE0M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatStringtextE0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatStringtextE0M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatStringtextE0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatStringtextE0M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatStringtextE0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatStringtextE0M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatStringtextE0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatStringtextE0M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatStringtextE0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatStringtextE0M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatStringtextE0M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatStringtextE0M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatStringtextE0M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatStringtextE0M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatStringtextE0M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatStringtextE0M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatStringtextE0M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatStringtextE0M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatStringtextE0M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatStringtextE0M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatStringtextE0M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatStringtextE0M.AssertModel(firstItems2[29],_testData[34], false);
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
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 27;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 10;
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
FROM public.stringtexte0m m
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
FROM public.stringtexte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatStringtextE0M>();
                var firstItems2 = new List<FlatStringtextE0M>();
                var secondItems1 = new List<FlatStringtextE0M>();
                 ((IStringSingleTypetext)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
FROM public.stringtexte0m m
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
                parametr1.Value = 84;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 69;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.stringtexte0m m
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
FROM public.stringtexte0m m
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
                parametr1.Value = 14;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 21;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.stringtexte0m m
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
FROM public.stringtexte0m m
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
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatStringtextE0M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatStringtextE0M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatStringtextE0M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatStringtextE0M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatStringtextE0M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatStringtextE0M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatStringtextE0M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatStringtextE0M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatStringtextE0M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatStringtextE0M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatStringtextE0M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatStringtextE0M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatStringtextE0M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatStringtextE0M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatStringtextE0M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatStringtextE0M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatStringtextE0M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatStringtextE0M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatStringtextE0M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatStringtextE0M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatStringtextE0M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatStringtextE0M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatStringtextE0M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatStringtextE0M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatStringtextE0M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatStringtextE0M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatStringtextE0M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatStringtextE0M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatStringtextE0M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatStringtextE0M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatStringtextE0M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatStringtextE0M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatStringtextE0M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatStringtextE0M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatStringtextE0M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatStringtextE0M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatStringtextE0M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatStringtextE0M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatStringtextE0M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatStringtextE0M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatStringtextE0M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatStringtextE0M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatStringtextE0M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatStringtextE0M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatStringtextE0M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatStringtextE0M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatStringtextE0M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatStringtextE0M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatStringtextE0M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatStringtextE0M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatStringtextE0M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatStringtextE0M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatStringtextE0M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatStringtextE0M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatStringtextE0M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatStringtextE0M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatStringtextE0M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatStringtextE0M.AssertModel(secondItems2[28],_testData[34], false);
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
FROM public.stringtexte0m m
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
                parametr1.Value = 105;
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
FROM public.stringtexte0m m
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
FROM public.stringtexte0m m
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
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatStringtextE0M.AssertModel(models[0],_testData[21], false);
                        FlatStringtextE0M.AssertModel(models[1],_testData[22], false);
                        FlatStringtextE0M.AssertModel(models[2],_testData[23], false);
                        FlatStringtextE0M.AssertModel(models[3],_testData[24], false);
                        FlatStringtextE0M.AssertModel(models[4],_testData[25], false);
                        FlatStringtextE0M.AssertModel(models[5],_testData[26], false);
                        FlatStringtextE0M.AssertModel(models[6],_testData[27], false);
                        FlatStringtextE0M.AssertModel(models[7],_testData[28], false);
                        FlatStringtextE0M.AssertModel(models[8],_testData[29], false);
                        FlatStringtextE0M.AssertModel(models[9],_testData[30], false);
                        FlatStringtextE0M.AssertModel(models[10],_testData[31], false);
                        FlatStringtextE0M.AssertModel(models[11],_testData[32], false);
                        FlatStringtextE0M.AssertModel(models[12],_testData[33], false);
                        FlatStringtextE0M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatStringtextE0M.AssertModel(models[0],_testData[23], false);
                        FlatStringtextE0M.AssertModel(models[1],_testData[24], false);
                        FlatStringtextE0M.AssertModel(models[2],_testData[25], false);
                        FlatStringtextE0M.AssertModel(models[3],_testData[26], false);
                        FlatStringtextE0M.AssertModel(models[4],_testData[27], false);
                        FlatStringtextE0M.AssertModel(models[5],_testData[28], false);
                        FlatStringtextE0M.AssertModel(models[6],_testData[29], false);
                        FlatStringtextE0M.AssertModel(models[7],_testData[30], false);
                        FlatStringtextE0M.AssertModel(models[8],_testData[31], false);
                        FlatStringtextE0M.AssertModel(models[9],_testData[32], false);
                        FlatStringtextE0M.AssertModel(models[10],_testData[33], false);
                        FlatStringtextE0M.AssertModel(models[11],_testData[34], false);
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
                parametr2.Value = 5;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.stringtexte0m m
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
FROM public.stringtexte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatStringtextE0M>();
                var secondItems1 = new List<FlatStringtextE0M>();
                var secondItems2 = new List<FlatStringtextE0M>();
                 ((IStringSingleTypetext)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatStringtextE0M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatStringtextE0M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatStringtextE0M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatStringtextE0M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatStringtextE0M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatStringtextE0M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatStringtextE0M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatStringtextE0M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatStringtextE0M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatStringtextE0M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatStringtextE0M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatStringtextE0M.AssertModel(firstItems1[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatStringtextE0M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatStringtextE0M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatStringtextE0M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatStringtextE0M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatStringtextE0M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatStringtextE0M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatStringtextE0M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatStringtextE0M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatStringtextE0M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatStringtextE0M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatStringtextE0M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatStringtextE0M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatStringtextE0M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatStringtextE0M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatStringtextE0M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatStringtextE0M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatStringtextE0M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatStringtextE0M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatStringtextE0M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatStringtextE0M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatStringtextE0M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatStringtextE0M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatStringtextE0M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatStringtextE0M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatStringtextE0M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatStringtextE0M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatStringtextE0M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatStringtextE0M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatStringtextE0M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatStringtextE0M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatStringtextE0M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatStringtextE0M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatStringtextE0M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatStringtextE0M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatStringtextE0M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatStringtextE0M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatStringtextE0M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatStringtextE0M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatStringtextE0M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatStringtextE0M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatStringtextE0M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatStringtextE0M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatStringtextE0M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatStringtextE0M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatStringtextE0M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatStringtextE0M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatStringtextE0M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatStringtextE0M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatStringtextE0M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatStringtextE0M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatStringtextE0M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatStringtextE0M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatStringtextE0M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatStringtextE0M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatStringtextE0M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatStringtextE0M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatStringtextE0M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatStringtextE0M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatStringtextE0M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatStringtextE0M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatStringtextE0M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatStringtextE0M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatStringtextE0M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatStringtextE0M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatStringtextE0M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatStringtextE0M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatStringtextE0M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatStringtextE0M.AssertModel(secondItems2[33],_testData[34], false);
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
FROM public.stringtexte0m m
LEFT JOIN public.stringtexte0mi mi ON mi.id = m.stringtexte0mi_id
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
                parametr1.Value = 63;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 50;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IStringSingleTypetext)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
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
                parametr1.Value = 27;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 57;
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
                        Assert.That(models, Has.Count.EqualTo(22));

                        StringtextE0M.AssertModel(models[0],_testData[13], false);
                        StringtextE0M.AssertModel(models[1],_testData[14], false);
                        StringtextE0M.AssertModel(models[2],_testData[15], false);
                        StringtextE0M.AssertModel(models[3],_testData[16], false);
                        StringtextE0M.AssertModel(models[4],_testData[17], false);
                        StringtextE0M.AssertModel(models[5],_testData[18], false);
                        StringtextE0M.AssertModel(models[6],_testData[19], false);
                        StringtextE0M.AssertModel(models[7],_testData[20], false);
                        StringtextE0M.AssertModel(models[8],_testData[21], false);
                        StringtextE0M.AssertModel(models[9],_testData[22], false);
                        StringtextE0M.AssertModel(models[10],_testData[23], false);
                        StringtextE0M.AssertModel(models[11],_testData[24], false);
                        StringtextE0M.AssertModel(models[12],_testData[25], false);
                        StringtextE0M.AssertModel(models[13],_testData[26], false);
                        StringtextE0M.AssertModel(models[14],_testData[27], false);
                        StringtextE0M.AssertModel(models[15],_testData[28], false);
                        StringtextE0M.AssertModel(models[16],_testData[29], false);
                        StringtextE0M.AssertModel(models[17],_testData[30], false);
                        StringtextE0M.AssertModel(models[18],_testData[31], false);
                        StringtextE0M.AssertModel(models[19],_testData[32], false);
                        StringtextE0M.AssertModel(models[20],_testData[33], false);
                        StringtextE0M.AssertModel(models[21],_testData[34], false);
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
FROM public.stringtexte0m m
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
FROM public.stringtexte0m m
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
FROM public.stringtexte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatStringtextE0M>();
                var firstItems2 = new List<FlatStringtextE0M>();
                var secondItems1 = new List<FlatStringtextE0M>();
                var secondItems2 = new List<FlatStringtextE0M>();
                await ((IStringSingleTypetext)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 5, query1, 15, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
FROM public.stringtexte0m m
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
FROM public.stringtexte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatStringtextE0M>();
                var firstItems2 = new List<FlatStringtextE0M>();
                var secondItems1 = new List<FlatStringtextE0M>();
                await ((IStringSingleTypetext)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 105, query1, 89, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                        FlatStringtextE0M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatStringtextE0M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatStringtextE0M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatStringtextE0M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatStringtextE0M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatStringtextE0M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatStringtextE0M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatStringtextE0M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatStringtextE0M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatStringtextE0M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatStringtextE0M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatStringtextE0M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatStringtextE0M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatStringtextE0M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatStringtextE0M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatStringtextE0M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatStringtextE0M.AssertModel(secondItems1[16],_testData[34], false);
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
FROM public.stringtexte0m m
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
FROM public.stringtexte0m m
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
FROM public.stringtexte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatStringtextE0M>();
                var firstItems2 = new List<FlatStringtextE0M>();
                var secondItems1 = new List<FlatStringtextE0M>();
                var secondItems2 = new List<FlatStringtextE0M>();
                 ((IStringSingleTypetext)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 128, query1, 162, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatStringtextE0M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatStringtextE0M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatStringtextE0M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatStringtextE0M.AssertModel(secondItems2[1],_testData[34], false);
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
FROM public.stringtexte0m m
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
FROM public.stringtexte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatStringtextE0M>();
                var firstItems2 = new List<FlatStringtextE0M>();
                var secondItems1 = new List<FlatStringtextE0M>();
                 ((IStringSingleTypetext)this).DbConnectionMMDynQuerySelectModelBatch(connection, 15, query1, 50, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
FROM public.stringtexte0m m
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
FROM public.stringtexte0m m
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
FROM public.stringtexte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IStringSingleTypetext)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 27, query1, 133, query2))
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
FROM public.stringtexte0m m
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
FROM public.stringtexte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatStringtextE0M>();
                var secondItems1 = new List<FlatStringtextE0M>();
                var secondItems2 = new List<FlatStringtextE0M>();
                await ((IStringSingleTypetext)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 69, query1, 147, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                        FlatStringtextE0M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatStringtextE0M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatStringtextE0M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatStringtextE0M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatStringtextE0M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatStringtextE0M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatStringtextE0M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatStringtextE0M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatStringtextE0M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatStringtextE0M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatStringtextE0M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatStringtextE0M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatStringtextE0M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatStringtextE0M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatStringtextE0M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatStringtextE0M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatStringtextE0M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatStringtextE0M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatStringtextE0M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatStringtextE0M.AssertModel(firstItems1[19],_testData[34], false);
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
FROM public.stringtexte0m m
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
FROM public.stringtexte0m m
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
FROM public.stringtexte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IStringSingleTypetext)this).DbConnectionSTDynQuerySelectModelBatch(connection, 121, query1, 157, query2))
                {
                    if(++resultIndex == 1)
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
FROM public.stringtexte0m m
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
FROM public.stringtexte0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatStringtextE0M>();
                var secondItems1 = new List<FlatStringtextE0M>();
                var secondItems2 = new List<FlatStringtextE0M>();
                 ((IStringSingleTypetext)this).DbConnectionDynQuerySelectModelBatch(connection, 10, query1, 140, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                        FlatStringtextE0M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatStringtextE0M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatStringtextE0M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatStringtextE0M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatStringtextE0M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatStringtextE0M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatStringtextE0M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatStringtextE0M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatStringtextE0M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatStringtextE0M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatStringtextE0M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatStringtextE0M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatStringtextE0M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatStringtextE0M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatStringtextE0M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatStringtextE0M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatStringtextE0M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatStringtextE0M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatStringtextE0M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatStringtextE0M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatStringtextE0M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatStringtextE0M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatStringtextE0M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatStringtextE0M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatStringtextE0M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatStringtextE0M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatStringtextE0M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatStringtextE0M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatStringtextE0M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatStringtextE0M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatStringtextE0M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatStringtextE0M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatStringtextE0M.AssertModel(firstItems1[32],_testData[34], false);
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
FROM public.stringtexte0m m
LEFT JOIN public.stringtexte0mi mi ON mi.id = m.stringtexte0mi_id
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
                foreach(var batchResult in await ((IStringSingleTypetext)this).DbConnectionSTSelectModelBatchAsync(connection, 78, 162))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        StringtextE0M.AssertModel(models[0],_testData[16], false);
                        StringtextE0M.AssertModel(models[1],_testData[17], false);
                        StringtextE0M.AssertModel(models[2],_testData[18], false);
                        StringtextE0M.AssertModel(models[3],_testData[19], false);
                        StringtextE0M.AssertModel(models[4],_testData[20], false);
                        StringtextE0M.AssertModel(models[5],_testData[21], false);
                        StringtextE0M.AssertModel(models[6],_testData[22], false);
                        StringtextE0M.AssertModel(models[7],_testData[23], false);
                        StringtextE0M.AssertModel(models[8],_testData[24], false);
                        StringtextE0M.AssertModel(models[9],_testData[25], false);
                        StringtextE0M.AssertModel(models[10],_testData[26], false);
                        StringtextE0M.AssertModel(models[11],_testData[27], false);
                        StringtextE0M.AssertModel(models[12],_testData[28], false);
                        StringtextE0M.AssertModel(models[13],_testData[29], false);
                        StringtextE0M.AssertModel(models[14],_testData[30], false);
                        StringtextE0M.AssertModel(models[15],_testData[31], false);
                        StringtextE0M.AssertModel(models[16],_testData[32], false);
                        StringtextE0M.AssertModel(models[17],_testData[33], false);
                        StringtextE0M.AssertModel(models[18],_testData[34], false);
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
                foreach(var batchResult in  ((IStringSingleTypetext)this).DbConnectionSTSelectModelBatch(connection, 5, 32))
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
                ((IStringSingleTypetext)this).SetDbConnectionSelectModelParametrs(cmd, 27);
                var models = await ((IStringSingleTypetext)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

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
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IStringSingleTypetext)this).CreateDbConnectionSelectModelCommand(connection);
                ((IStringSingleTypetext)this).SetDbConnectionSelectModelParametrs(cmd, 121);
                var models =  ((IStringSingleTypetext)this).ExecuteDbConnectionSelectModelCommand(cmd);

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
FROM public.stringtexte0m m
LEFT JOIN public.stringtexte0mi mi ON mi.id = m.stringtexte0mi_id
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
                Assert.That((System.Int32)model[0], Is.EqualTo((5)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("mdnjkyxffgypbrtfhgbxeg")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("pbsvlwxdjhnwxlxygvskfkni")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("rowjdbxmjfdourjdewuqqriwklcdw")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("vdjvijgvurh")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("egu")));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("ahylskgaufcuxxcnaxrhcs")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("xwjvqqbvxuktcjskcrd")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("dnawmraeqjixyv")));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("srynjgrbmahavrtmkqnpccr")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("sajeaqbrwxcml")));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("rxnnhfjljddnaltflbyjnw")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("hmgrqedfkvfnlgbvaauhp")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("pfuthlf")));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("fahmbrigjjbowpec")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("isahhonbnepqwhdseqebwr")));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("hlcrriu")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("ktauaocrwgfaaqxdpkefgooxhow")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("obrevxnbdjgdscpxdcj")));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((32)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("okpl")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("xnqxogfxsrtojluuhwawxmrstxuys")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("ckvrydxxtgey")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("mdupoaxld")));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("bqfootjivyebscx")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("edfcohgmdatiaddiyvjlyirdspv")));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("ifgpceeloj")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("ftmackhgjjps")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("wtetlwecrwtth")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("yaaswbmgycfgnvkr")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("aamqpsbucvjyyjx")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("brlnitiokomoyukvcrev")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("uawjuhso")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("lfvi")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((78)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("vbybpmfxphmdsfkku")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((38)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("oquaolsykmywgqykkym")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("fjmapxatoqhe")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("f")));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("dth")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("eolynjduubumfroalutxt")));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("vyevmfxgwcuvftyxvlkdfboavxjms")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("rvqjupwlthgynrdv")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("jglsayiebomrac")));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("vvufobldnokbthao")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("hntxvitt")));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("uw")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("fbpogvneiuliac")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("wadrkjadkxdyfxtjfiro")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("nkyokvqrctqrvcuyrluuwljie")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("vwdurgnfybvpygexm")));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((111)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("lcvqlfkk")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("thovpuflfadkniqdyxruqoed")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("p")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("vleeerxl")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("rsuplocivo")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("wtwoipalrhqwwcysnhioirjobx")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("wwbfmeqr")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("hdgxoqsubpkkfkgyxbwri")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("ysdanhjnswdmbqygkwc")));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("iwihn")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("jrgudcijhx")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("cllto")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("vhrangaggfgdehmmupwencilvjj")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("cycbqilxcrixtydsch")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((73)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("uvxymxdhdlxeahdmisyightlrc")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("yxwxsafefj")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((153)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("arlvunm")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((78)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("fgcygmpjrmtnmk")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((157)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("thhsorpoyurcfjqjjtlajh")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((160)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("oqowriyrrrbw")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((82)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("cq")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("ccw")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((162)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("ujnludppwmlbxalwh")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((171)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("cmgjvnpbtfiduldxiuhq")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((85)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("fyyfvcvjylesscewuytcl")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("fuurtmxt")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("mlcprbs")));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((180)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("evdgvjwxertuchquqjwgijmnatfoj")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("iddq")));

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
                Assert.That((System.Int32)model[0], Is.EqualTo((5)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("mdnjkyxffgypbrtfhgbxeg")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("pbsvlwxdjhnwxlxygvskfkni")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("rowjdbxmjfdourjdewuqqriwklcdw")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("vdjvijgvurh")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("egu")));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("ahylskgaufcuxxcnaxrhcs")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("xwjvqqbvxuktcjskcrd")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("dnawmraeqjixyv")));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("srynjgrbmahavrtmkqnpccr")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("sajeaqbrwxcml")));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("rxnnhfjljddnaltflbyjnw")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("hmgrqedfkvfnlgbvaauhp")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("pfuthlf")));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("fahmbrigjjbowpec")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("isahhonbnepqwhdseqebwr")));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("hlcrriu")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("ktauaocrwgfaaqxdpkefgooxhow")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("obrevxnbdjgdscpxdcj")));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((32)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("okpl")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("xnqxogfxsrtojluuhwawxmrstxuys")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("ckvrydxxtgey")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("mdupoaxld")));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("bqfootjivyebscx")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("edfcohgmdatiaddiyvjlyirdspv")));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("ifgpceeloj")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("ftmackhgjjps")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("wtetlwecrwtth")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("yaaswbmgycfgnvkr")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("aamqpsbucvjyyjx")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("brlnitiokomoyukvcrev")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("uawjuhso")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("lfvi")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((78)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("vbybpmfxphmdsfkku")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((38)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("oquaolsykmywgqykkym")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("fjmapxatoqhe")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("f")));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("dth")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("eolynjduubumfroalutxt")));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("vyevmfxgwcuvftyxvlkdfboavxjms")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("rvqjupwlthgynrdv")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("jglsayiebomrac")));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("vvufobldnokbthao")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("hntxvitt")));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("uw")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("fbpogvneiuliac")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("wadrkjadkxdyfxtjfiro")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("nkyokvqrctqrvcuyrluuwljie")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("vwdurgnfybvpygexm")));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((111)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("lcvqlfkk")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("thovpuflfadkniqdyxruqoed")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("p")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("vleeerxl")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("rsuplocivo")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("wtwoipalrhqwwcysnhioirjobx")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("wwbfmeqr")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("hdgxoqsubpkkfkgyxbwri")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("ysdanhjnswdmbqygkwc")));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("iwihn")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("jrgudcijhx")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("cllto")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("vhrangaggfgdehmmupwencilvjj")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("cycbqilxcrixtydsch")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((73)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("uvxymxdhdlxeahdmisyightlrc")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("yxwxsafefj")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((153)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("arlvunm")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((78)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("fgcygmpjrmtnmk")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((157)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("thhsorpoyurcfjqjjtlajh")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((160)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("oqowriyrrrbw")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((82)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("cq")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("ccw")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((162)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("ujnludppwmlbxalwh")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((171)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("cmgjvnpbtfiduldxiuhq")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((85)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("fyyfvcvjylesscewuytcl")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("fuurtmxt")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("mlcprbs")));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((180)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("evdgvjwxertuchquqjwgijmnatfoj")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("iddq")));

            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.DbConnection.Attributes.Query(
            query: 
@"
SELECT
    mi.nullablevalue,
    mi.id,
    mi.value
FROM public.binary_stringtexte0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(StringtextE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringSingleTypetext))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(StringtextE0MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(19),
                (NpgsqlTypes.NpgsqlDbType)(19)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringSingleTypetext))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<StringtextE0MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new StringtextE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IStringSingleTypetext)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_stringtexte0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IStringSingleTypetext)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    StringtextE0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(1)]
        public  void DynQueryWAImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<StringtextE0MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new StringtextE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IStringSingleTypetext)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_stringtexte0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IStringSingleTypetext)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    StringtextE0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: 
@"
SELECT
    mi.nullablevalue,
    mi.id,
    mi.value
FROM public.binary_stringtexte0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(StringtextE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringSingleTypetext))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(StringtextE0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringSingleTypetext))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<StringtextE0MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new StringtextE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IStringSingleTypetext)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_stringtexte0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IStringSingleTypetext)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    StringtextE0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(3)]
        public  void DynQueryImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<StringtextE0MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new StringtextE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IStringSingleTypetext)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_stringtexte0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IStringSingleTypetext)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    StringtextE0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: 
@"
SELECT
    mi.nullablevalue,
    mi.id,
    mi.value
FROM public.binary_stringtexte0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(StringtextE0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringSingleTypetext))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_stringtexte0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(StringtextE0MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(19),
                (NpgsqlTypes.NpgsqlDbType)(19)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringSingleTypetext))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<StringtextE0MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IStringSingleTypetext)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IStringSingleTypetext)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    StringtextE0MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(5)]
        public  void WAImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<StringtextE0MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IStringSingleTypetext)this).WAImportModelInner(connection, importCollection);
                var models = ((IStringSingleTypetext)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    StringtextE0MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: 
@"
SELECT
    mi.nullablevalue,
    mi.id,
    mi.value
FROM public.binary_stringtexte0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(StringtextE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringSingleTypetext))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_stringtexte0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(StringtextE0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringSingleTypetext))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<StringtextE0MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new StringtextE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IStringSingleTypetext)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IStringSingleTypetext)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    StringtextE0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(7)]
        public  void ImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<StringtextE0MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new StringtextE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IStringSingleTypetext)this).ImportModelInner(connection, importCollection);
                var models = ((IStringSingleTypetext)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    StringtextE0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_stringtexte0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
stringtexte0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(StringtextE0M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(19),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(19)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringSingleTypetext))]
        private void ImportModelConfig()
        {
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
FROM public.binary_stringtexte0m m
LEFT JOIN public.binary_stringtexte0mi mi ON mi.id = m.stringtexte0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(StringtextE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringSingleTypetext))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<StringtextE0M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IStringSingleTypetext)this).ImportModelAsync(connection, importCollection);
                var models = await ((IStringSingleTypetext)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    StringtextE0M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(10)]
        public  void ImportModelTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<StringtextE0M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IStringSingleTypetext)this).ImportModel(connection, importCollection);
                var models = ((IStringSingleTypetext)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    StringtextE0M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_stringtexte0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    stringtexte0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(StringtextE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringSingleTypetext)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(19),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(19)
            })]
        private void ExportModelConfig()
        {
        }

        [Test, Order(13)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IStringSingleTypetext)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    StringtextE0M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IStringSingleTypetext)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    StringtextE0M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(StringtextE0MIWA), typeof(StringtextE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringSingleTypetext)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(19),
                (NpgsqlTypes.NpgsqlDbType)(19)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(19),
                (NpgsqlTypes.NpgsqlDbType)(19)
            })]
        private void MMDynQueryWAExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task MMDynQueryWAExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<StringtextE0MIWA>();
                var models2 = new List<StringtextE0MIWA>();
                await ((IStringSingleTypetext)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_stringtexte0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    StringtextE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    StringtextE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void MMDynQueryWAExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<StringtextE0MIWA>();
                var models2 = new List<StringtextE0MIWA>();
                ((IStringSingleTypetext)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_stringtexte0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    StringtextE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    StringtextE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(StringtextE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringSingleTypetext)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(19),
                (NpgsqlTypes.NpgsqlDbType)(19)
            })]
        private void DynQueryWAExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task DynQueryWAExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = await ((IStringSingleTypetext)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_stringtexte0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    StringtextE0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void DynQueryWAExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = ((IStringSingleTypetext)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_stringtexte0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    StringtextE0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(StringtextE0MIWA), typeof(StringtextE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringSingleTypetext))]
        private void MMDynQueryExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task MMDynQueryExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<StringtextE0MIWA>();
                var models2 = new List<StringtextE0MIWA>();
                await ((IStringSingleTypetext)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_stringtexte0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    StringtextE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    StringtextE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void MMDynQueryExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<StringtextE0MIWA>();
                var models2 = new List<StringtextE0MIWA>();
                ((IStringSingleTypetext)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_stringtexte0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    StringtextE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    StringtextE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(StringtextE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringSingleTypetext))]
        private void DynQueryExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task DynQueryExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = await ((IStringSingleTypetext)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_stringtexte0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    StringtextE0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void DynQueryExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = ((IStringSingleTypetext)this).DynQueryExportModelInner(connection, @"
COPY public.binary_stringtexte0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    StringtextE0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_stringtexte0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(StringtextE0MI), typeof(StringtextE0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringSingleTypetext)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(19),
                (NpgsqlTypes.NpgsqlDbType)(19)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(19),
                (NpgsqlTypes.NpgsqlDbType)(19)
            })]
        private void MMWAExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task MMWAExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<StringtextE0MI>();
                var models2 = new List<StringtextE0MI>();
                await ((IStringSingleTypetext)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    StringtextE0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    StringtextE0MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void MMWAExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<StringtextE0MI>();
                var models2 = new List<StringtextE0MI>();
                ((IStringSingleTypetext)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    StringtextE0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    StringtextE0MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_stringtexte0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(StringtextE0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringSingleTypetext)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(19),
                (NpgsqlTypes.NpgsqlDbType)(19)
            })]
        private void WAExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task WAExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = await ((IStringSingleTypetext)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    StringtextE0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void WAExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = ((IStringSingleTypetext)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    StringtextE0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_stringtexte0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(StringtextE0MIWA), typeof(StringtextE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringSingleTypetext))]
        private void MMExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task MMExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<StringtextE0MIWA>();
                var models2 = new List<StringtextE0MIWA>();
                await ((IStringSingleTypetext)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    StringtextE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    StringtextE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void MMExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<StringtextE0MIWA>();
                var models2 = new List<StringtextE0MIWA>();
                ((IStringSingleTypetext)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    StringtextE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    StringtextE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_stringtexte0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(StringtextE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringSingleTypetext))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = await ((IStringSingleTypetext)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    StringtextE0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void ExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = ((IStringSingleTypetext)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    StringtextE0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

