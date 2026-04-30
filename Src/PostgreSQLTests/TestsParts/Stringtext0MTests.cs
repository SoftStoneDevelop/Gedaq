

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

        private readonly Stringtext0M[] _testData = new Stringtext0M[]
        {
            new Stringtext0M
{
    Id = 1,
    Value = "uhfksnwvvijhcgbppxsc",
    ModelInner = null,
    NullableValue = "rfbnepgdq",
},
            new Stringtext0M
{
    Id = 2,
    Value = "twctmlqqaxgwllsb",
    ModelInner = new Stringtext0MI
{
    Id = 8,
    Value = "conqnvwoilncyarrwqwlayyatepjf",
    NullableValue = "oecvfvnaiewb",
},
    NullableValue = null,
},
            new Stringtext0M
{
    Id = 3,
    Value = "vhrnqrexdhgel",
    ModelInner = null,
    NullableValue = "pqhtwggiqxftj",
},
            new Stringtext0M
{
    Id = 5,
    Value = "oa",
    ModelInner = new Stringtext0MI
{
    Id = 13,
    Value = "nkmyxnccwnwsqatbyifjsrwuexqv",
    NullableValue = null,
},
    NullableValue = null,
},
            new Stringtext0M
{
    Id = 8,
    Value = "hevxxxqkyrrekrplwa",
    ModelInner = null,
    NullableValue = null,
},
            new Stringtext0M
{
    Id = 12,
    Value = "syxqwbhlyywylxykqosyrsr",
    ModelInner = new Stringtext0MI
{
    Id = 14,
    Value = "lxlbtatrabfb",
    NullableValue = null,
},
    NullableValue = null,
},
            new Stringtext0M
{
    Id = 21,
    Value = "vxvmesuveuadrrgfmrhvunkufct",
    ModelInner = null,
    NullableValue = "klodyfivccrdjailko",
},
            new Stringtext0M
{
    Id = 23,
    Value = "ph",
    ModelInner = new Stringtext0MI
{
    Id = 16,
    Value = "oswcoulh",
    NullableValue = null,
},
    NullableValue = "bmildrmk",
},
            new Stringtext0M
{
    Id = 28,
    Value = "e",
    ModelInner = null,
    NullableValue = null,
},
            new Stringtext0M
{
    Id = 37,
    Value = "rms",
    ModelInner = new Stringtext0MI
{
    Id = 18,
    Value = "hnkcujflihnurcdxdcikblu",
    NullableValue = null,
},
    NullableValue = "rfoknpchceejvsaia",
},
            new Stringtext0M
{
    Id = 46,
    Value = "ogmfdqsnymoatorycwwiyg",
    ModelInner = null,
    NullableValue = "gkqbunkfetmorihivpfy",
},
            new Stringtext0M
{
    Id = 52,
    Value = "hjaejqjmilhpqdbvew",
    ModelInner = new Stringtext0MI
{
    Id = 22,
    Value = "uleewcmeoksduuwmganpxd",
    NullableValue = "uvbmfseeljfuqiosiidcish",
},
    NullableValue = null,
},
            new Stringtext0M
{
    Id = 53,
    Value = "iqraaagdtymvjsiyo",
    ModelInner = null,
    NullableValue = null,
},
            new Stringtext0M
{
    Id = 61,
    Value = "cujhap",
    ModelInner = new Stringtext0MI
{
    Id = 23,
    Value = "yrlrtguujhrufbgbiyciejmt",
    NullableValue = "xtuixlptjschkgapisxqehd",
},
    NullableValue = "uqgvknpiolw",
},
            new Stringtext0M
{
    Id = 69,
    Value = "",
    ModelInner = null,
    NullableValue = null,
},
            new Stringtext0M
{
    Id = 72,
    Value = "wqfugrocvyff",
    ModelInner = new Stringtext0MI
{
    Id = 27,
    Value = "tn",
    NullableValue = "jkewrctsxu",
},
    NullableValue = null,
},
            new Stringtext0M
{
    Id = 81,
    Value = "gjr",
    ModelInner = null,
    NullableValue = null,
},
            new Stringtext0M
{
    Id = 82,
    Value = "kdgnnxqfjntrqljexpln",
    ModelInner = new Stringtext0MI
{
    Id = 28,
    Value = "oehxrypeudcpl",
    NullableValue = null,
},
    NullableValue = null,
},
            new Stringtext0M
{
    Id = 86,
    Value = "xtquicnomkwsjeha",
    ModelInner = null,
    NullableValue = "ijx",
},
            new Stringtext0M
{
    Id = 91,
    Value = "whbmrqurifwsuusmufiimvegav",
    ModelInner = new Stringtext0MI
{
    Id = 33,
    Value = "nmixkjy",
    NullableValue = "hnwsvgdjbeqomjltqkud",
},
    NullableValue = "c",
},
            new Stringtext0M
{
    Id = 94,
    Value = "vulshaxmwoeotutb",
    ModelInner = null,
    NullableValue = "umgmvpmryhkkppdbxwksbrwubnink",
},
            new Stringtext0M
{
    Id = 102,
    Value = "bvfgkdr",
    ModelInner = new Stringtext0MI
{
    Id = 42,
    Value = "duskwhlkbjogsqseuaunoextec",
    NullableValue = "",
},
    NullableValue = null,
},
            new Stringtext0M
{
    Id = 110,
    Value = "soiatmypfql",
    ModelInner = null,
    NullableValue = null,
},
            new Stringtext0M
{
    Id = 116,
    Value = "sqwycdhycyxfavufbkrxjdk",
    ModelInner = new Stringtext0MI
{
    Id = 45,
    Value = "taitmwbokrygpcroibxcxakntele",
    NullableValue = "nq",
},
    NullableValue = "o",
},
            new Stringtext0M
{
    Id = 123,
    Value = "jklhomlds",
    ModelInner = null,
    NullableValue = null,
},
            new Stringtext0M
{
    Id = 129,
    Value = "nhuqublsigvh",
    ModelInner = new Stringtext0MI
{
    Id = 49,
    Value = "ulvyqkklqlalwnphharrxgexem",
    NullableValue = "fjngjy",
},
    NullableValue = "xkmcxtsaorphmsmy",
},
            new Stringtext0M
{
    Id = 133,
    Value = "rckdejdvqktvdpcsfrtynslweo",
    ModelInner = null,
    NullableValue = null,
},
            new Stringtext0M
{
    Id = 139,
    Value = "nmwhbeqdlmedxjbjqxe",
    ModelInner = new Stringtext0MI
{
    Id = 58,
    Value = "rugt",
    NullableValue = "gons",
},
    NullableValue = "cex",
},
            new Stringtext0M
{
    Id = 143,
    Value = "n",
    ModelInner = null,
    NullableValue = "jtjyiumpdyudanchfnvdsmltn",
},
            new Stringtext0M
{
    Id = 150,
    Value = "wjitrqfgmnwniabosnfiqy",
    ModelInner = new Stringtext0MI
{
    Id = 63,
    Value = "hraycfnxarmakboklmcyrb",
    NullableValue = "okrbiouoal",
},
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.stringtext0mi(
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
INSERT INTO public.stringtext0mi(
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
            queryMapTypes: [typeof(Stringtext0MI)],
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
INSERT INTO public.stringtext0mi(
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

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.stringtext0m(
	id,
    value,
    nullablevalue,
    stringtext0mi_id
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
                methodParametrName: "stringtext0mi_id", 
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
INSERT INTO public.stringtext0m(
	id,
    value,
    nullablevalue,
    stringtext0mi_id
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
    stringtext0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(Stringtext0M)],
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.EqualTo("klodyfivccrdjailko"));
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
                Assert.That(nullable, Is.EqualTo("bmildrmk"));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.stringtext0m(
	id,
    value,
    nullablevalue,
    stringtext0mi_id
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
    stringtext0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(Stringtext0M)],
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
                methodParametrName: "stringtext0mi_id", 
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
                Assert.That(nullable, Is.EqualTo("rfoknpchceejvsaia"));
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
                Assert.That(nullable, Is.EqualTo("gkqbunkfetmorihivpfy"));
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
                List<Stringtext0M> models = null;

                models =  ((IStringSingleTypetext)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Stringtext0M.AssertModel(models[0],_testData[12], true);
                models =  ((IStringSingleTypetext)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Stringtext0M.AssertModel(models[0],_testData[13], true);
                models =  ((IStringSingleTypetext)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Stringtext0M.AssertModel(models[0],_testData[14], true);
                models =  ((IStringSingleTypetext)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Stringtext0M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Stringtext0M> models = null;

                models = await ((IStringSingleTypetext)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Stringtext0M.AssertModel(models[0],_testData[16], true);
                models = await ((IStringSingleTypetext)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Stringtext0M.AssertModel(models[0],_testData[17], true);
                models = await ((IStringSingleTypetext)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Stringtext0M.AssertModel(models[0],_testData[18], true);
                models = await ((IStringSingleTypetext)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Stringtext0M.AssertModel(models[0],_testData[19], true);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.stringtext0m(
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
                parametrName: "stringtext0mi_id", 
                methodParametrName: "stringtext0mi_id", 
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

            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatStringtext0M), typeof(FlatStringtext0M)],
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
FROM public.stringtext0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatStringtext0M>();
                var models2 = new List<FlatStringtext0M>();
                await ((IStringSingleTypetext)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
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
FROM public.stringtext0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
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

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatStringtext0M)],
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
FROM public.stringtext0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IStringSingleTypetext)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
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
FROM public.stringtext0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IStringSingleTypetext)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatStringtext0M.AssertModel(models[i],_testData[i], false);
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
FROM public.stringtext0m m
LEFT JOIN public.stringtext0mi mi ON mi.id = m.stringtext0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Stringtext0M)],
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
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IStringSingleTypetext)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Stringtext0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatStringtext0M), typeof(FlatStringtext0M)],
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
FROM public.stringtext0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatStringtext0M>();
                var models2 = new List<FlatStringtext0M>();
                await ((IStringSingleTypetext)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
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
FROM public.stringtext0m m
WHERE 
    m.id > $1
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

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatStringtext0M)],
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
FROM public.stringtext0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IStringSingleTypetext)this).DynQuerySelectModelAsync(connection,  query, 0);
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
FROM public.stringtext0m m
WHERE 
    m.id > $1
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
FROM public.stringtext0m m
LEFT JOIN public.stringtext0mi mi ON mi.id = m.stringtext0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Stringtext0M)],
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
FROM public.stringtext0m m
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
                parametr1.Value = 110;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 123;
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
FROM public.stringtext0m m
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
FROM public.stringtext0m m
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
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatStringtext0M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatStringtext0M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatStringtext0M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatStringtext0M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatStringtext0M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatStringtext0M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatStringtext0M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatStringtext0M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatStringtext0M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatStringtext0M.AssertModel(secondItems2[4],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 46;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 86;
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
FROM public.stringtext0m m
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
FROM public.stringtext0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatStringtext0M>();
                var firstItems2 = new List<FlatStringtext0M>();
                var secondItems1 = new List<FlatStringtext0M>();
                await ((IStringSingleTypetext)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
FROM public.stringtext0m m
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
                parametr1.Value = 2;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 21;
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
FROM public.stringtext0m m
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
FROM public.stringtext0m m
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
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 139;
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
FROM public.stringtext0m m
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
FROM public.stringtext0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatStringtext0M>();
                var firstItems2 = new List<FlatStringtext0M>();
                var secondItems1 = new List<FlatStringtext0M>();
                 ((IStringSingleTypetext)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatStringtext0M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatStringtext0M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatStringtext0M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatStringtext0M.AssertModel(firstItems2[1],_testData[29], false);
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
FROM public.stringtext0m m
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
                parametr1.Value = 81;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 12;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.stringtext0m m
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
FROM public.stringtext0m m
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
        public async Task DbConnectionDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 23;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 53;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.stringtext0m m
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
FROM public.stringtext0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatStringtext0M>();
                var secondItems1 = new List<FlatStringtext0M>();
                var secondItems2 = new List<FlatStringtext0M>();
                await ((IStringSingleTypetext)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
FROM public.stringtext0m m
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
                parametr1.Value = 82;
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
FROM public.stringtext0m m
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
FROM public.stringtext0m m
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
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatStringtext0M.AssertModel(models[0],_testData[18], false);
                        FlatStringtext0M.AssertModel(models[1],_testData[19], false);
                        FlatStringtext0M.AssertModel(models[2],_testData[20], false);
                        FlatStringtext0M.AssertModel(models[3],_testData[21], false);
                        FlatStringtext0M.AssertModel(models[4],_testData[22], false);
                        FlatStringtext0M.AssertModel(models[5],_testData[23], false);
                        FlatStringtext0M.AssertModel(models[6],_testData[24], false);
                        FlatStringtext0M.AssertModel(models[7],_testData[25], false);
                        FlatStringtext0M.AssertModel(models[8],_testData[26], false);
                        FlatStringtext0M.AssertModel(models[9],_testData[27], false);
                        FlatStringtext0M.AssertModel(models[10],_testData[28], false);
                        FlatStringtext0M.AssertModel(models[11],_testData[29], false);
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
        public async Task DbConnectionDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 133;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 82;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.stringtext0m m
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
FROM public.stringtext0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatStringtext0M>();
                var secondItems1 = new List<FlatStringtext0M>();
                var secondItems2 = new List<FlatStringtext0M>();
                 ((IStringSingleTypetext)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatStringtext0M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatStringtext0M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatStringtext0M.AssertModel(firstItems1[2],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatStringtext0M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatStringtext0M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatStringtext0M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatStringtext0M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatStringtext0M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatStringtext0M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatStringtext0M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatStringtext0M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatStringtext0M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatStringtext0M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatStringtext0M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatStringtext0M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatStringtext0M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatStringtext0M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatStringtext0M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatStringtext0M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatStringtext0M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatStringtext0M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatStringtext0M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatStringtext0M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatStringtext0M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatStringtext0M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatStringtext0M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatStringtext0M.AssertModel(secondItems2[11],_testData[29], false);
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
FROM public.stringtext0m m
LEFT JOIN public.stringtext0mi mi ON mi.id = m.stringtext0mi_id
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
                parametr1.Value = 82;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 37;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IStringSingleTypetext)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
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
                parametr1.Value = 12;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 3;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IStringSingleTypetext)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
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
                        Assert.That(models, Has.Count.EqualTo(27));

                        Stringtext0M.AssertModel(models[0],_testData[3], false);
                        Stringtext0M.AssertModel(models[1],_testData[4], false);
                        Stringtext0M.AssertModel(models[2],_testData[5], false);
                        Stringtext0M.AssertModel(models[3],_testData[6], false);
                        Stringtext0M.AssertModel(models[4],_testData[7], false);
                        Stringtext0M.AssertModel(models[5],_testData[8], false);
                        Stringtext0M.AssertModel(models[6],_testData[9], false);
                        Stringtext0M.AssertModel(models[7],_testData[10], false);
                        Stringtext0M.AssertModel(models[8],_testData[11], false);
                        Stringtext0M.AssertModel(models[9],_testData[12], false);
                        Stringtext0M.AssertModel(models[10],_testData[13], false);
                        Stringtext0M.AssertModel(models[11],_testData[14], false);
                        Stringtext0M.AssertModel(models[12],_testData[15], false);
                        Stringtext0M.AssertModel(models[13],_testData[16], false);
                        Stringtext0M.AssertModel(models[14],_testData[17], false);
                        Stringtext0M.AssertModel(models[15],_testData[18], false);
                        Stringtext0M.AssertModel(models[16],_testData[19], false);
                        Stringtext0M.AssertModel(models[17],_testData[20], false);
                        Stringtext0M.AssertModel(models[18],_testData[21], false);
                        Stringtext0M.AssertModel(models[19],_testData[22], false);
                        Stringtext0M.AssertModel(models[20],_testData[23], false);
                        Stringtext0M.AssertModel(models[21],_testData[24], false);
                        Stringtext0M.AssertModel(models[22],_testData[25], false);
                        Stringtext0M.AssertModel(models[23],_testData[26], false);
                        Stringtext0M.AssertModel(models[24],_testData[27], false);
                        Stringtext0M.AssertModel(models[25],_testData[28], false);
                        Stringtext0M.AssertModel(models[26],_testData[29], false);
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
FROM public.stringtext0m m
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
FROM public.stringtext0m m
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
FROM public.stringtext0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatStringtext0M>();
                var firstItems2 = new List<FlatStringtext0M>();
                var secondItems1 = new List<FlatStringtext0M>();
                var secondItems2 = new List<FlatStringtext0M>();
                await ((IStringSingleTypetext)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 123, query1, 37, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
FROM public.stringtext0m m
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
FROM public.stringtext0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatStringtext0M>();
                var firstItems2 = new List<FlatStringtext0M>();
                var secondItems1 = new List<FlatStringtext0M>();
                await ((IStringSingleTypetext)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 86, query1, 52, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatStringtext0M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatStringtext0M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatStringtext0M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatStringtext0M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatStringtext0M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatStringtext0M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatStringtext0M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatStringtext0M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatStringtext0M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatStringtext0M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatStringtext0M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatStringtext0M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatStringtext0M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatStringtext0M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatStringtext0M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatStringtext0M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatStringtext0M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatStringtext0M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatStringtext0M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatStringtext0M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatStringtext0M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatStringtext0M.AssertModel(firstItems2[10],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatStringtext0M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatStringtext0M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatStringtext0M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatStringtext0M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatStringtext0M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatStringtext0M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatStringtext0M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatStringtext0M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatStringtext0M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatStringtext0M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatStringtext0M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatStringtext0M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatStringtext0M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatStringtext0M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatStringtext0M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatStringtext0M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatStringtext0M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatStringtext0M.AssertModel(secondItems1[17],_testData[29], false);
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
FROM public.stringtext0m m
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
FROM public.stringtext0m m
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
FROM public.stringtext0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatStringtext0M>();
                var firstItems2 = new List<FlatStringtext0M>();
                var secondItems1 = new List<FlatStringtext0M>();
                var secondItems2 = new List<FlatStringtext0M>();
                 ((IStringSingleTypetext)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 69, query1, 46, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
FROM public.stringtext0m m
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
FROM public.stringtext0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatStringtext0M>();
                var firstItems2 = new List<FlatStringtext0M>();
                var secondItems1 = new List<FlatStringtext0M>();
                 ((IStringSingleTypetext)this).DbConnectionMMDynQuerySelectModelBatch(connection, 61, query1, 8, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatStringtext0M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatStringtext0M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatStringtext0M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatStringtext0M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatStringtext0M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatStringtext0M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatStringtext0M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatStringtext0M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatStringtext0M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatStringtext0M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatStringtext0M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatStringtext0M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatStringtext0M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatStringtext0M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatStringtext0M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatStringtext0M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatStringtext0M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatStringtext0M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatStringtext0M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatStringtext0M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatStringtext0M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatStringtext0M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatStringtext0M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatStringtext0M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatStringtext0M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatStringtext0M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatStringtext0M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatStringtext0M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatStringtext0M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatStringtext0M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatStringtext0M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatStringtext0M.AssertModel(firstItems2[15],_testData[29], false);
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
FROM public.stringtext0m m
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
FROM public.stringtext0m m
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
FROM public.stringtext0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IStringSingleTypetext)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 53, query1, 133, query2))
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
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatStringtext0M.AssertModel(models[0],_testData[27], false);
                        FlatStringtext0M.AssertModel(models[1],_testData[28], false);
                        FlatStringtext0M.AssertModel(models[2],_testData[29], false);
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
FROM public.stringtext0m m
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
FROM public.stringtext0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatStringtext0M>();
                var secondItems1 = new List<FlatStringtext0M>();
                var secondItems2 = new List<FlatStringtext0M>();
                await ((IStringSingleTypetext)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 82, query1, 110, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatStringtext0M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatStringtext0M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatStringtext0M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatStringtext0M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatStringtext0M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatStringtext0M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatStringtext0M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatStringtext0M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatStringtext0M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatStringtext0M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatStringtext0M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatStringtext0M.AssertModel(firstItems1[11],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatStringtext0M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatStringtext0M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatStringtext0M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatStringtext0M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatStringtext0M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatStringtext0M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatStringtext0M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatStringtext0M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatStringtext0M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatStringtext0M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatStringtext0M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatStringtext0M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatStringtext0M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatStringtext0M.AssertModel(secondItems2[6],_testData[29], false);
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
FROM public.stringtext0m m
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
FROM public.stringtext0m m
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
FROM public.stringtext0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IStringSingleTypetext)this).DbConnectionSTDynQuerySelectModelBatch(connection, 21, query1, 12, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatStringtext0M.AssertModel(models[0],_testData[7], false);
                        FlatStringtext0M.AssertModel(models[1],_testData[8], false);
                        FlatStringtext0M.AssertModel(models[2],_testData[9], false);
                        FlatStringtext0M.AssertModel(models[3],_testData[10], false);
                        FlatStringtext0M.AssertModel(models[4],_testData[11], false);
                        FlatStringtext0M.AssertModel(models[5],_testData[12], false);
                        FlatStringtext0M.AssertModel(models[6],_testData[13], false);
                        FlatStringtext0M.AssertModel(models[7],_testData[14], false);
                        FlatStringtext0M.AssertModel(models[8],_testData[15], false);
                        FlatStringtext0M.AssertModel(models[9],_testData[16], false);
                        FlatStringtext0M.AssertModel(models[10],_testData[17], false);
                        FlatStringtext0M.AssertModel(models[11],_testData[18], false);
                        FlatStringtext0M.AssertModel(models[12],_testData[19], false);
                        FlatStringtext0M.AssertModel(models[13],_testData[20], false);
                        FlatStringtext0M.AssertModel(models[14],_testData[21], false);
                        FlatStringtext0M.AssertModel(models[15],_testData[22], false);
                        FlatStringtext0M.AssertModel(models[16],_testData[23], false);
                        FlatStringtext0M.AssertModel(models[17],_testData[24], false);
                        FlatStringtext0M.AssertModel(models[18],_testData[25], false);
                        FlatStringtext0M.AssertModel(models[19],_testData[26], false);
                        FlatStringtext0M.AssertModel(models[20],_testData[27], false);
                        FlatStringtext0M.AssertModel(models[21],_testData[28], false);
                        FlatStringtext0M.AssertModel(models[22],_testData[29], false);
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
FROM public.stringtext0m m
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
FROM public.stringtext0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatStringtext0M>();
                var secondItems1 = new List<FlatStringtext0M>();
                var secondItems2 = new List<FlatStringtext0M>();
                 ((IStringSingleTypetext)this).DbConnectionDynQuerySelectModelBatch(connection, 28, query1, 53, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                        FlatStringtext0M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatStringtext0M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatStringtext0M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatStringtext0M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatStringtext0M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatStringtext0M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatStringtext0M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatStringtext0M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatStringtext0M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatStringtext0M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatStringtext0M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatStringtext0M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatStringtext0M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatStringtext0M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatStringtext0M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatStringtext0M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatStringtext0M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatStringtext0M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatStringtext0M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatStringtext0M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatStringtext0M.AssertModel(firstItems1[20],_testData[29], false);
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
FROM public.stringtext0m m
LEFT JOIN public.stringtext0mi mi ON mi.id = m.stringtext0mi_id
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
                foreach(var batchResult in await ((IStringSingleTypetext)this).DbConnectionSTSelectModelBatchAsync(connection, 46, 94))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
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
                foreach(var batchResult in  ((IStringSingleTypetext)this).DbConnectionSTSelectModelBatch(connection, 23, 91))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        Stringtext0M.AssertModel(models[0],_testData[8], false);
                        Stringtext0M.AssertModel(models[1],_testData[9], false);
                        Stringtext0M.AssertModel(models[2],_testData[10], false);
                        Stringtext0M.AssertModel(models[3],_testData[11], false);
                        Stringtext0M.AssertModel(models[4],_testData[12], false);
                        Stringtext0M.AssertModel(models[5],_testData[13], false);
                        Stringtext0M.AssertModel(models[6],_testData[14], false);
                        Stringtext0M.AssertModel(models[7],_testData[15], false);
                        Stringtext0M.AssertModel(models[8],_testData[16], false);
                        Stringtext0M.AssertModel(models[9],_testData[17], false);
                        Stringtext0M.AssertModel(models[10],_testData[18], false);
                        Stringtext0M.AssertModel(models[11],_testData[19], false);
                        Stringtext0M.AssertModel(models[12],_testData[20], false);
                        Stringtext0M.AssertModel(models[13],_testData[21], false);
                        Stringtext0M.AssertModel(models[14],_testData[22], false);
                        Stringtext0M.AssertModel(models[15],_testData[23], false);
                        Stringtext0M.AssertModel(models[16],_testData[24], false);
                        Stringtext0M.AssertModel(models[17],_testData[25], false);
                        Stringtext0M.AssertModel(models[18],_testData[26], false);
                        Stringtext0M.AssertModel(models[19],_testData[27], false);
                        Stringtext0M.AssertModel(models[20],_testData[28], false);
                        Stringtext0M.AssertModel(models[21],_testData[29], false);
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
                ((IStringSingleTypetext)this).SetDbConnectionSelectModelParametrs(cmd, 133);
                var models = await ((IStringSingleTypetext)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(3));
Stringtext0M.AssertModel(models[0],_testData[27], false);Stringtext0M.AssertModel(models[1],_testData[28], false);Stringtext0M.AssertModel(models[2],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IStringSingleTypetext)this).CreateDbConnectionSelectModelCommand(connection);
                ((IStringSingleTypetext)this).SetDbConnectionSelectModelParametrs(cmd, 21);
                var models =  ((IStringSingleTypetext)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(23));
Stringtext0M.AssertModel(models[0],_testData[7], false);Stringtext0M.AssertModel(models[1],_testData[8], false);Stringtext0M.AssertModel(models[2],_testData[9], false);Stringtext0M.AssertModel(models[3],_testData[10], false);Stringtext0M.AssertModel(models[4],_testData[11], false);Stringtext0M.AssertModel(models[5],_testData[12], false);Stringtext0M.AssertModel(models[6],_testData[13], false);Stringtext0M.AssertModel(models[7],_testData[14], false);Stringtext0M.AssertModel(models[8],_testData[15], false);Stringtext0M.AssertModel(models[9],_testData[16], false);Stringtext0M.AssertModel(models[10],_testData[17], false);Stringtext0M.AssertModel(models[11],_testData[18], false);Stringtext0M.AssertModel(models[12],_testData[19], false);Stringtext0M.AssertModel(models[13],_testData[20], false);Stringtext0M.AssertModel(models[14],_testData[21], false);Stringtext0M.AssertModel(models[15],_testData[22], false);Stringtext0M.AssertModel(models[16],_testData[23], false);Stringtext0M.AssertModel(models[17],_testData[24], false);Stringtext0M.AssertModel(models[18],_testData[25], false);Stringtext0M.AssertModel(models[19],_testData[26], false);Stringtext0M.AssertModel(models[20],_testData[27], false);Stringtext0M.AssertModel(models[21],_testData[28], false);Stringtext0M.AssertModel(models[22],_testData[29], false);
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
FROM public.stringtext0m m
LEFT JOIN public.stringtext0mi mi ON mi.id = m.stringtext0mi_id
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
                Assert.That((System.Int32)model[0], Is.EqualTo((1)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("uhfksnwvvijhcgbppxsc")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("rfbnepgdq")));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("twctmlqqaxgwllsb")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("conqnvwoilncyarrwqwlayyatepjf")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("oecvfvnaiewb")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((3)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("vhrnqrexdhgel")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("pqhtwggiqxftj")));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((5)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("oa")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("nkmyxnccwnwsqatbyifjsrwuexqv")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("hevxxxqkyrrekrplwa")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("syxqwbhlyywylxykqosyrsr")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("lxlbtatrabfb")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("vxvmesuveuadrrgfmrhvunkufct")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("klodyfivccrdjailko")));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("ph")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("oswcoulh")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("bmildrmk")));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("e")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("rms")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("hnkcujflihnurcdxdcikblu")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("rfoknpchceejvsaia")));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("ogmfdqsnymoatorycwwiyg")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("gkqbunkfetmorihivpfy")));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("hjaejqjmilhpqdbvew")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("uleewcmeoksduuwmganpxd")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("uvbmfseeljfuqiosiidcish")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((53)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("iqraaagdtymvjsiyo")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("cujhap")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("yrlrtguujhrufbgbiyciejmt")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("xtuixlptjschkgapisxqehd")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("uqgvknpiolw")));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("wqfugrocvyff")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("tn")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("jkewrctsxu")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("gjr")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("kdgnnxqfjntrqljexpln")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("oehxrypeudcpl")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("xtquicnomkwsjeha")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("ijx")));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("whbmrqurifwsuusmufiimvegav")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("nmixkjy")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("hnwsvgdjbeqomjltqkud")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("c")));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("vulshaxmwoeotutb")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("umgmvpmryhkkppdbxwksbrwubnink")));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("bvfgkdr")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("duskwhlkbjogsqseuaunoextec")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("soiatmypfql")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((116)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("sqwycdhycyxfavufbkrxjdk")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("taitmwbokrygpcroibxcxakntele")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("nq")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("o")));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("jklhomlds")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("nhuqublsigvh")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("ulvyqkklqlalwnphharrxgexem")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("fjngjy")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("xkmcxtsaorphmsmy")));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("rckdejdvqktvdpcsfrtynslweo")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("nmwhbeqdlmedxjbjqxe")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("rugt")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("gons")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("cex")));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("n")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("jtjyiumpdyudanchfnvdsmltn")));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("wjitrqfgmnwniabosnfiqy")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("hraycfnxarmakboklmcyrb")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("okrbiouoal")));//InnerModel.NullableValue

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
                Assert.That((System.Int32)model[0], Is.EqualTo((1)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("uhfksnwvvijhcgbppxsc")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("rfbnepgdq")));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("twctmlqqaxgwllsb")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("conqnvwoilncyarrwqwlayyatepjf")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("oecvfvnaiewb")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((3)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("vhrnqrexdhgel")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("pqhtwggiqxftj")));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((5)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("oa")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("nkmyxnccwnwsqatbyifjsrwuexqv")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("hevxxxqkyrrekrplwa")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("syxqwbhlyywylxykqosyrsr")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("lxlbtatrabfb")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("vxvmesuveuadrrgfmrhvunkufct")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("klodyfivccrdjailko")));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("ph")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("oswcoulh")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("bmildrmk")));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("e")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("rms")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("hnkcujflihnurcdxdcikblu")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.String)model[5], Is.EqualTo(("rfoknpchceejvsaia")));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("ogmfdqsnymoatorycwwiyg")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("gkqbunkfetmorihivpfy")));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("hjaejqjmilhpqdbvew")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("uleewcmeoksduuwmganpxd")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("uvbmfseeljfuqiosiidcish")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((53)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("iqraaagdtymvjsiyo")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("cujhap")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("yrlrtguujhrufbgbiyciejmt")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("xtuixlptjschkgapisxqehd")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("uqgvknpiolw")));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("wqfugrocvyff")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("tn")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("jkewrctsxu")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("gjr")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("kdgnnxqfjntrqljexpln")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("oehxrypeudcpl")));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("xtquicnomkwsjeha")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("ijx")));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("whbmrqurifwsuusmufiimvegav")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("nmixkjy")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("hnwsvgdjbeqomjltqkud")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("c")));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("vulshaxmwoeotutb")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("umgmvpmryhkkppdbxwksbrwubnink")));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("bvfgkdr")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("duskwhlkbjogsqseuaunoextec")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("soiatmypfql")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((116)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("sqwycdhycyxfavufbkrxjdk")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("taitmwbokrygpcroibxcxakntele")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("nq")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("o")));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("jklhomlds")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("nhuqublsigvh")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("ulvyqkklqlalwnphharrxgexem")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("fjngjy")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("xkmcxtsaorphmsmy")));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("rckdejdvqktvdpcsfrtynslweo")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("nmwhbeqdlmedxjbjqxe")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("rugt")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("gons")));//InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("cex")));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("n")));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.String)model[5], Is.EqualTo(("jtjyiumpdyudanchfnvdsmltn")));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((System.String)model[1], Is.EqualTo(("wjitrqfgmnwniabosnfiqy")));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((System.String)model[3], Is.EqualTo(("hraycfnxarmakboklmcyrb")));//InnerModel.Value

                Assert.That((System.String)model[4], Is.EqualTo(("okrbiouoal")));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

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
FROM public.binary_stringtext0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(Stringtext0MIWA)],
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
            queryMapType: typeof(Stringtext0MIWA),
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
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Stringtext0MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Stringtext0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IStringSingleTypetext)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_stringtext0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IStringSingleTypetext)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Stringtext0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(1)]
        public  void DynQueryImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<Stringtext0MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Stringtext0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IStringSingleTypetext)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_stringtext0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IStringSingleTypetext)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Stringtext0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_stringtext0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(Stringtext0MI)],
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
COPY public.binary_stringtext0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(Stringtext0MI),
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
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Stringtext0MI>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IStringSingleTypetext)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IStringSingleTypetext)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Stringtext0MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(3)]
        public  void ImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<Stringtext0MI>(2);
                for (int i = 12; i < 30; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IStringSingleTypetext)this).ImportModelInner(connection, importCollection);
                var models = ((IStringSingleTypetext)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Stringtext0MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_stringtext0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
stringtext0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(Stringtext0M),
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
FROM public.binary_stringtext0m m
LEFT JOIN public.binary_stringtext0mi mi ON mi.id = m.stringtext0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(Stringtext0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringSingleTypetext))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(5)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<Stringtext0M>(15);

                    importCollection.Add(_testData[0]);
                    importCollection.Add(_testData[1]);
                    importCollection.Add(_testData[2]);
                    importCollection.Add(_testData[3]);
                    importCollection.Add(_testData[4]);
                    importCollection.Add(_testData[5]);
                    importCollection.Add(_testData[6]);
                    importCollection.Add(_testData[7]);
                    importCollection.Add(_testData[8]);
                    importCollection.Add(_testData[9]);
                    importCollection.Add(_testData[10]);
                    importCollection.Add(_testData[11]);
                    importCollection.Add(_testData[12]);
                    importCollection.Add(_testData[13]);
                    importCollection.Add(_testData[14]);
                ((IStringSingleTypetext)this).ImportModel(connection, importCollection);
                var models = ((IStringSingleTypetext)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                Stringtext0M.AssertModel(models[0],_testData[0], false);
                Stringtext0M.AssertModel(models[1],_testData[1], false);
                Stringtext0M.AssertModel(models[2],_testData[2], false);
                Stringtext0M.AssertModel(models[3],_testData[3], false);
                Stringtext0M.AssertModel(models[4],_testData[4], false);
                Stringtext0M.AssertModel(models[5],_testData[5], false);
                Stringtext0M.AssertModel(models[6],_testData[6], false);
                Stringtext0M.AssertModel(models[7],_testData[7], false);
                Stringtext0M.AssertModel(models[8],_testData[8], false);
                Stringtext0M.AssertModel(models[9],_testData[9], false);
                Stringtext0M.AssertModel(models[10],_testData[10], false);
                Stringtext0M.AssertModel(models[11],_testData[11], false);
                Stringtext0M.AssertModel(models[12],_testData[12], false);
                Stringtext0M.AssertModel(models[13],_testData[13], false);
                Stringtext0M.AssertModel(models[14],_testData[14], false);
                importCollection.Clear();

                    importCollection.Add(_testData[15]);
                    importCollection.Add(_testData[16]);
                    importCollection.Add(_testData[17]);
                    importCollection.Add(_testData[18]);
                    importCollection.Add(_testData[19]);
                    importCollection.Add(_testData[20]);
                    importCollection.Add(_testData[21]);
                    importCollection.Add(_testData[22]);
                    importCollection.Add(_testData[23]);
                    importCollection.Add(_testData[24]);
                    importCollection.Add(_testData[25]);
                    importCollection.Add(_testData[26]);
                    importCollection.Add(_testData[27]);
                    importCollection.Add(_testData[28]);
                    importCollection.Add(_testData[29]);
                await ((IStringSingleTypetext)this).ImportModelAsync(connection, importCollection);
                models = await ((IStringSingleTypetext)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                Stringtext0M.AssertModel(models[0],_testData[0], false);
                Stringtext0M.AssertModel(models[1],_testData[1], false);
                Stringtext0M.AssertModel(models[2],_testData[2], false);
                Stringtext0M.AssertModel(models[3],_testData[3], false);
                Stringtext0M.AssertModel(models[4],_testData[4], false);
                Stringtext0M.AssertModel(models[5],_testData[5], false);
                Stringtext0M.AssertModel(models[6],_testData[6], false);
                Stringtext0M.AssertModel(models[7],_testData[7], false);
                Stringtext0M.AssertModel(models[8],_testData[8], false);
                Stringtext0M.AssertModel(models[9],_testData[9], false);
                Stringtext0M.AssertModel(models[10],_testData[10], false);
                Stringtext0M.AssertModel(models[11],_testData[11], false);
                Stringtext0M.AssertModel(models[12],_testData[12], false);
                Stringtext0M.AssertModel(models[13],_testData[13], false);
                Stringtext0M.AssertModel(models[14],_testData[14], false);
                Stringtext0M.AssertModel(models[15],_testData[15], false);
                Stringtext0M.AssertModel(models[16],_testData[16], false);
                Stringtext0M.AssertModel(models[17],_testData[17], false);
                Stringtext0M.AssertModel(models[18],_testData[18], false);
                Stringtext0M.AssertModel(models[19],_testData[19], false);
                Stringtext0M.AssertModel(models[20],_testData[20], false);
                Stringtext0M.AssertModel(models[21],_testData[21], false);
                Stringtext0M.AssertModel(models[22],_testData[22], false);
                Stringtext0M.AssertModel(models[23],_testData[23], false);
                Stringtext0M.AssertModel(models[24],_testData[24], false);
                Stringtext0M.AssertModel(models[25],_testData[25], false);
                Stringtext0M.AssertModel(models[26],_testData[26], false);
                Stringtext0M.AssertModel(models[27],_testData[27], false);
                Stringtext0M.AssertModel(models[28],_testData[28], false);
                Stringtext0M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_stringtext0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    stringtext0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(Stringtext0M)],
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
        private void ExportModelConfig()
        {
        }

        [Test, Order(6)]
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
                    Stringtext0M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(6)]
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
                    Stringtext0M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(Stringtext0MIWA)],
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
        private void DynQueryExportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task DynQueryExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IStringSingleTypetext)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_stringtext0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Stringtext0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(6)]
        public  void DynQueryExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var models = ((IStringSingleTypetext)this).DynQueryExportModelInner(connection, @"
COPY public.binary_stringtext0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Stringtext0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_stringtext0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(Stringtext0MI)],
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
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IStringSingleTypetext)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Stringtext0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(6)]
        public  void ExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var models = ((IStringSingleTypetext)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Stringtext0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

