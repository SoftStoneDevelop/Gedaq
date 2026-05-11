

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
    internal partial interface IBigIntegerSingleTypenumeric
    {
    }
    
    internal partial class BigIntegerSingleTypenumeric : IBigIntegerSingleTypenumeric
    {


#region TestData

        private readonly BigIntegernumericE0M[] _testData = new BigIntegernumericE0M[]
        {
            new BigIntegernumericE0M
{
    Id = 8,
    Value = new System.Numerics.BigInteger(6229808299720094274L),
    ModelInner = null,
    NullableValue = new System.Numerics.BigInteger(623578651345817888L),
},
            new BigIntegernumericE0M
{
    Id = 9,
    Value = new System.Numerics.BigInteger(7155407909266417285L),
    ModelInner = new BigIntegernumericE0MI
{
    Id = 8,
    Value = new System.Numerics.BigInteger(985524926325129206L),
    NullableValue = new System.Numerics.BigInteger(8011048432235211382L),
},
    NullableValue = null,
},
            new BigIntegernumericE0M
{
    Id = 10,
    Value = new System.Numerics.BigInteger(7682912151835959740L),
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericE0M
{
    Id = 14,
    Value = new System.Numerics.BigInteger(2461175391337434036L),
    ModelInner = new BigIntegernumericE0MI
{
    Id = 11,
    Value = new System.Numerics.BigInteger(3971414812046826499L),
    NullableValue = null,
},
    NullableValue = new System.Numerics.BigInteger(1075082172366296960L),
},
            new BigIntegernumericE0M
{
    Id = 20,
    Value = new System.Numerics.BigInteger(6982214865456048622L),
    ModelInner = null,
    NullableValue = new System.Numerics.BigInteger(8299400533190940083L),
},
            new BigIntegernumericE0M
{
    Id = 29,
    Value = new System.Numerics.BigInteger(1757125833529530353L),
    ModelInner = new BigIntegernumericE0MI
{
    Id = 12,
    Value = new System.Numerics.BigInteger(2997945603824867419L),
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericE0M
{
    Id = 36,
    Value = new System.Numerics.BigInteger(1706100616769463339L),
    ModelInner = null,
    NullableValue = new System.Numerics.BigInteger(4762487269898989110L),
},
            new BigIntegernumericE0M
{
    Id = 44,
    Value = new System.Numerics.BigInteger(7427584064774836140L),
    ModelInner = new BigIntegernumericE0MI
{
    Id = 19,
    Value = new System.Numerics.BigInteger(1464741641771633193L),
    NullableValue = new System.Numerics.BigInteger(7711850622309797943L),
},
    NullableValue = null,
},
            new BigIntegernumericE0M
{
    Id = 46,
    Value = new System.Numerics.BigInteger(834732193234466710L),
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericE0M
{
    Id = 47,
    Value = new System.Numerics.BigInteger(1204623586492746748L),
    ModelInner = new BigIntegernumericE0MI
{
    Id = 26,
    Value = new System.Numerics.BigInteger(5346413697853745040L),
    NullableValue = null,
},
    NullableValue = new System.Numerics.BigInteger(5614732563044963573L),
},
            new BigIntegernumericE0M
{
    Id = 55,
    Value = new System.Numerics.BigInteger(2951015348996015484L),
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericE0M
{
    Id = 58,
    Value = new System.Numerics.BigInteger(2136914400271271731L),
    ModelInner = new BigIntegernumericE0MI
{
    Id = 32,
    Value = new System.Numerics.BigInteger(3950438247822649548L),
    NullableValue = new System.Numerics.BigInteger(1203566144648050269L),
},
    NullableValue = new System.Numerics.BigInteger(3214207748142775805L),
},
            new BigIntegernumericE0M
{
    Id = 63,
    Value = new System.Numerics.BigInteger(4298663839661597991L),
    ModelInner = null,
    NullableValue = new System.Numerics.BigInteger(7932801006718458533L),
},
            new BigIntegernumericE0M
{
    Id = 69,
    Value = new System.Numerics.BigInteger(1182271718151598043L),
    ModelInner = new BigIntegernumericE0MI
{
    Id = 40,
    Value = new System.Numerics.BigInteger(7829064666780129698L),
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericE0M
{
    Id = 76,
    Value = new System.Numerics.BigInteger(4754670046593914402L),
    ModelInner = null,
    NullableValue = new System.Numerics.BigInteger(2338477630144848686L),
},
            new BigIntegernumericE0M
{
    Id = 79,
    Value = new System.Numerics.BigInteger(8353057741191510763L),
    ModelInner = new BigIntegernumericE0MI
{
    Id = 48,
    Value = new System.Numerics.BigInteger(5903140545241389128L),
    NullableValue = null,
},
    NullableValue = new System.Numerics.BigInteger(1729993904050611184L),
},
            new BigIntegernumericE0M
{
    Id = 84,
    Value = new System.Numerics.BigInteger(4526815713109859321L),
    ModelInner = null,
    NullableValue = new System.Numerics.BigInteger(2383967307621764616L),
},
            new BigIntegernumericE0M
{
    Id = 91,
    Value = new System.Numerics.BigInteger(4951601937714061594L),
    ModelInner = new BigIntegernumericE0MI
{
    Id = 56,
    Value = new System.Numerics.BigInteger(5768144947261306748L),
    NullableValue = new System.Numerics.BigInteger(5500130300001975521L),
},
    NullableValue = new System.Numerics.BigInteger(2685434619087207412L),
},
            new BigIntegernumericE0M
{
    Id = 96,
    Value = new System.Numerics.BigInteger(274129803651370578L),
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericE0M
{
    Id = 104,
    Value = new System.Numerics.BigInteger(3622985873962890621L),
    ModelInner = new BigIntegernumericE0MI
{
    Id = 65,
    Value = new System.Numerics.BigInteger(7208042808568529539L),
    NullableValue = null,
},
    NullableValue = new System.Numerics.BigInteger(1324366990998784884L),
},
            new BigIntegernumericE0M
{
    Id = 112,
    Value = new System.Numerics.BigInteger(8420742988718810407L),
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericE0M
{
    Id = 115,
    Value = new System.Numerics.BigInteger(1245999726970333341L),
    ModelInner = new BigIntegernumericE0MI
{
    Id = 71,
    Value = new System.Numerics.BigInteger(6209391291887608826L),
    NullableValue = new System.Numerics.BigInteger(7098612549978888963L),
},
    NullableValue = new System.Numerics.BigInteger(2242515384211900197L),
},
            new BigIntegernumericE0M
{
    Id = 123,
    Value = new System.Numerics.BigInteger(7440025106831881302L),
    ModelInner = null,
    NullableValue = new System.Numerics.BigInteger(6409133558181049267L),
},
            new BigIntegernumericE0M
{
    Id = 128,
    Value = new System.Numerics.BigInteger(6330926033567928434L),
    ModelInner = new BigIntegernumericE0MI
{
    Id = 80,
    Value = new System.Numerics.BigInteger(950328107169493266L),
    NullableValue = null,
},
    NullableValue = new System.Numerics.BigInteger(808965492845648540L),
},
            new BigIntegernumericE0M
{
    Id = 135,
    Value = new System.Numerics.BigInteger(1401858144244708912L),
    ModelInner = null,
    NullableValue = new System.Numerics.BigInteger(1639892924509525755L),
},
            new BigIntegernumericE0M
{
    Id = 136,
    Value = new System.Numerics.BigInteger(6689986449541705982L),
    ModelInner = new BigIntegernumericE0MI
{
    Id = 89,
    Value = new System.Numerics.BigInteger(155655528541487768L),
    NullableValue = new System.Numerics.BigInteger(8848310673795379509L),
},
    NullableValue = null,
},
            new BigIntegernumericE0M
{
    Id = 142,
    Value = new System.Numerics.BigInteger(8013226697240023187L),
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericE0M
{
    Id = 146,
    Value = new System.Numerics.BigInteger(7333613890517627321L),
    ModelInner = new BigIntegernumericE0MI
{
    Id = 93,
    Value = new System.Numerics.BigInteger(672493321671511114L),
    NullableValue = new System.Numerics.BigInteger(7898603241457134208L),
},
    NullableValue = new System.Numerics.BigInteger(6716855592697717402L),
},
            new BigIntegernumericE0M
{
    Id = 154,
    Value = new System.Numerics.BigInteger(4473652767065451667L),
    ModelInner = null,
    NullableValue = new System.Numerics.BigInteger(8511644696231676888L),
},
            new BigIntegernumericE0M
{
    Id = 157,
    Value = new System.Numerics.BigInteger(7277655365756058676L),
    ModelInner = new BigIntegernumericE0MI
{
    Id = 99,
    Value = new System.Numerics.BigInteger(2322665923669925942L),
    NullableValue = null,
},
    NullableValue = new System.Numerics.BigInteger(5840251407078207918L),
},
            new BigIntegernumericE0M
{
    Id = 165,
    Value = new System.Numerics.BigInteger(4702044887329139780L),
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericE0M
{
    Id = 169,
    Value = new System.Numerics.BigInteger(6964431432170178878L),
    ModelInner = new BigIntegernumericE0MI
{
    Id = 101,
    Value = new System.Numerics.BigInteger(7837643323819045469L),
    NullableValue = new System.Numerics.BigInteger(445343244602628537L),
},
    NullableValue = new System.Numerics.BigInteger(8440361212211656399L),
},
            new BigIntegernumericE0M
{
    Id = 178,
    Value = new System.Numerics.BigInteger(379196198609215822L),
    ModelInner = null,
    NullableValue = new System.Numerics.BigInteger(5898126706956795276L),
},
            new BigIntegernumericE0M
{
    Id = 186,
    Value = new System.Numerics.BigInteger(6726395566217662984L),
    ModelInner = new BigIntegernumericE0MI
{
    Id = 107,
    Value = new System.Numerics.BigInteger(2787313002077770163L),
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericE0M
{
    Id = 190,
    Value = new System.Numerics.BigInteger(6246718467070328682L),
    ModelInner = null,
    NullableValue = new System.Numerics.BigInteger(5873667305767538819L),
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumerice0mi(
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
            asPartInterface: typeof(IBigIntegerSingleTypenumeric)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(13)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger?), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(13))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumerice0mi(
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
            queryMapTypes: [typeof(BigIntegernumericE0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerSingleTypenumeric)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(13)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(13))]
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

                changedRows =  ((IBigIntegerSingleTypenumeric)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IBigIntegerSingleTypenumeric)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IBigIntegerSingleTypenumeric)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBigIntegerSingleTypenumeric)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IBigIntegerSingleTypenumeric)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IBigIntegerSingleTypenumeric)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IBigIntegerSingleTypenumeric)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IBigIntegerSingleTypenumeric)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumerice0mi(
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
            asPartInterface: typeof(IBigIntegerSingleTypenumeric)), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(7)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(7), 
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

                changedRows =  ((IBigIntegerSingleTypenumeric)this).DbConnectionInsertInnerModel(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
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

                changedRows = await ((IBigIntegerSingleTypenumeric)this).DbConnectionInsertInnerModelAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBigIntegerSingleTypenumeric)this).DbConnectionInsertInnerModelAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBigIntegerSingleTypenumeric)this).DbConnectionInsertInnerModelAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBigIntegerSingleTypenumeric)this).DbConnectionInsertInnerModelAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBigIntegerSingleTypenumeric)this).DbConnectionInsertInnerModelAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBigIntegerSingleTypenumeric)this).DbConnectionInsertInnerModelAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBigIntegerSingleTypenumeric)this).DbConnectionInsertInnerModelAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBigIntegerSingleTypenumeric)this).DbConnectionInsertInnerModelAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumerice0m(
	id,
    value,
    nullablevalue,
    bigintegernumerice0mi_id
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
            asPartInterface: typeof(IBigIntegerSingleTypenumeric)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(13)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(13)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "bigintegernumerice0mi_id", 
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
                changedRows =  ((IBigIntegerSingleTypenumeric)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IBigIntegerSingleTypenumeric)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IBigIntegerSingleTypenumeric)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IBigIntegerSingleTypenumeric)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumerice0m(
	id,
    value,
    nullablevalue,
    bigintegernumerice0mi_id
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
    bigintegernumerice0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(BigIntegernumericE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerSingleTypenumeric)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

        [Ignore("Invalid cast, ExecuteScalar provider return wrong type")]
        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalar()
        {
        }

        [Ignore("Invalid cast, ExecuteScalar provider return wrong type")]
        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumerice0m(
	id,
    value,
    nullablevalue,
    bigintegernumerice0mi_id
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
    bigintegernumerice0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(BigIntegernumericE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerSingleTypenumeric)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(13)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(13)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "bigintegernumerice0mi_id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        public void InsertModelReturningConfig()
        {
        }

        [Ignore("Invalid cast, ExecuteScalar provider return wrong type")]
        [Test, Order(1)]
        public async Task InsertModelTestReturningScalar()
        {
        }

        [Ignore("Invalid cast, ExecuteScalar provider return wrong type")]
        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<BigIntegernumericE0M> models = null;

                models =  ((IBigIntegerSingleTypenumeric)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericE0M.AssertModel(models[0],_testData[4], true);
                models =  ((IBigIntegerSingleTypenumeric)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericE0M.AssertModel(models[0],_testData[5], true);
                models =  ((IBigIntegerSingleTypenumeric)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericE0M.AssertModel(models[0],_testData[6], true);
                models =  ((IBigIntegerSingleTypenumeric)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericE0M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<BigIntegernumericE0M> models = null;

                models = await ((IBigIntegerSingleTypenumeric)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericE0M.AssertModel(models[0],_testData[8], true);
                models = await ((IBigIntegerSingleTypenumeric)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericE0M.AssertModel(models[0],_testData[9], true);
                models = await ((IBigIntegerSingleTypenumeric)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericE0M.AssertModel(models[0],_testData[10], true);
                models = await ((IBigIntegerSingleTypenumeric)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericE0M.AssertModel(models[0],_testData[11], true);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumerice0m(
	id,
    value,
    nullablevalue,
    bigintegernumerice0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @bigintegernumerice0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerSingleTypenumeric)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Numerics.BigInteger), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(7)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(7),
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "bigintegernumerice0mi_id", 
                methodParametrName: "bigintegernumerice0mi_id", 
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

                changedRows =  ((IBigIntegerSingleTypenumeric)this).DbConnectionInsertModel(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IBigIntegerSingleTypenumeric)this).DbConnectionInsertModel(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
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

                changedRows = await ((IBigIntegerSingleTypenumeric)this).DbConnectionInsertModelAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBigIntegerSingleTypenumeric)this).DbConnectionInsertModelAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBigIntegerSingleTypenumeric)this).DbConnectionInsertModelAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBigIntegerSingleTypenumeric)this).DbConnectionInsertModelAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBigIntegerSingleTypenumeric)this).DbConnectionInsertModelAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBigIntegerSingleTypenumeric)this).DbConnectionInsertModelAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBigIntegerSingleTypenumeric)this).DbConnectionInsertModelAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBigIntegerSingleTypenumeric)this).DbConnectionInsertModelAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBigIntegerSingleTypenumeric)this).DbConnectionInsertModelAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBigIntegerSingleTypenumeric)this).DbConnectionInsertModelAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBigIntegerSingleTypenumeric)this).DbConnectionInsertModelAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBigIntegerSingleTypenumeric)this).DbConnectionInsertModelAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBigIntegerSingleTypenumeric)this).DbConnectionInsertModelAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBigIntegerSingleTypenumeric)this).DbConnectionInsertModelAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBigIntegerSingleTypenumeric)this).DbConnectionInsertModelAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBigIntegerSingleTypenumeric)this).DbConnectionInsertModelAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBigIntegerSingleTypenumeric)this).DbConnectionInsertModelAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBigIntegerSingleTypenumeric)this).DbConnectionInsertModelAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBigIntegerSingleTypenumeric)this).DbConnectionInsertModelAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBigIntegerSingleTypenumeric)this).DbConnectionInsertModelAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBigIntegerSingleTypenumeric)this).DbConnectionInsertModelAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericE0M), typeof(FlatBigIntegernumericE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerSingleTypenumeric)),
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
FROM public.bigintegernumerice0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatBigIntegernumericE0M>();
                var models2 = new List<FlatBigIntegernumericE0M>();
                await ((IBigIntegerSingleTypenumeric)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericE0M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumerice0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatBigIntegernumericE0M>();
                var models2 = new List<FlatBigIntegernumericE0M>();
                ((IBigIntegerSingleTypenumeric)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericE0M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerSingleTypenumeric)),
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
FROM public.bigintegernumerice0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IBigIntegerSingleTypenumeric)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumerice0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IBigIntegerSingleTypenumeric)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumerice0m m
LEFT JOIN public.bigintegernumerice0mi mi ON mi.id = m.bigintegernumerice0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(BigIntegernumericE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerSingleTypenumeric)),
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
                var models = await ((IBigIntegerSingleTypenumeric)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericE0M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IBigIntegerSingleTypenumeric)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericE0M), typeof(FlatBigIntegernumericE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerSingleTypenumeric)),
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
FROM public.bigintegernumerice0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericE0M>();
                var models2 = new List<FlatBigIntegernumericE0M>();
                await ((IBigIntegerSingleTypenumeric)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericE0M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumerice0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericE0M>();
                var models2 = new List<FlatBigIntegernumericE0M>();
                ((IBigIntegerSingleTypenumeric)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericE0M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerSingleTypenumeric)),
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
FROM public.bigintegernumerice0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IBigIntegerSingleTypenumeric)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumerice0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IBigIntegerSingleTypenumeric)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumerice0m m
LEFT JOIN public.bigintegernumerice0mi mi ON mi.id = m.bigintegernumerice0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(BigIntegernumericE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerSingleTypenumeric)),
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
                var models = await ((IBigIntegerSingleTypenumeric)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IBigIntegerSingleTypenumeric)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericE0M), typeof(FlatBigIntegernumericE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerSingleTypenumeric)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerSingleTypenumeric)),
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
            asPartInterface: typeof(IBigIntegerSingleTypenumeric)),
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
FROM public.bigintegernumerice0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatBigIntegernumericE0M>();
                var models2 = new List<FlatBigIntegernumericE0M>();
                await((IBigIntegerSingleTypenumeric)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericE0M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 135;
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
FROM public.bigintegernumerice0m m
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
FROM public.bigintegernumerice0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericE0M>();
                var firstItems2 = new List<FlatBigIntegernumericE0M>();
                var secondItems1 = new List<FlatBigIntegernumericE0M>();
                var secondItems2 = new List<FlatBigIntegernumericE0M>();
                await ((IBigIntegerSingleTypenumeric)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[31],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 96;
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
FROM public.bigintegernumerice0m m
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
FROM public.bigintegernumerice0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericE0M>();
                var firstItems2 = new List<FlatBigIntegernumericE0M>();
                var secondItems1 = new List<FlatBigIntegernumericE0M>();
                await ((IBigIntegerSingleTypenumeric)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[30],_testData[34], false);
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
FROM public.bigintegernumerice0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatBigIntegernumericE0M>();
                var models2 = new List<FlatBigIntegernumericE0M>();
                ((IBigIntegerSingleTypenumeric)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericE0M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 154;
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
FROM public.bigintegernumerice0m m
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
FROM public.bigintegernumerice0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericE0M>();
                var firstItems2 = new List<FlatBigIntegernumericE0M>();
                var secondItems1 = new List<FlatBigIntegernumericE0M>();
                var secondItems2 = new List<FlatBigIntegernumericE0M>();
                 ((IBigIntegerSingleTypenumeric)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[14],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 154;
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
FROM public.bigintegernumerice0m m
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
FROM public.bigintegernumerice0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericE0M>();
                var firstItems2 = new List<FlatBigIntegernumericE0M>();
                var secondItems1 = new List<FlatBigIntegernumericE0M>();
                 ((IBigIntegerSingleTypenumeric)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[7],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerSingleTypenumeric)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerSingleTypenumeric)),
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
            asPartInterface: typeof(IBigIntegerSingleTypenumeric)),
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
FROM public.bigintegernumerice0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IBigIntegerSingleTypenumeric)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 157;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 79;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumerice0m m
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
FROM public.bigintegernumerice0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerSingleTypenumeric)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatBigIntegernumericE0M.AssertModel(models[0],_testData[30], false);
                        FlatBigIntegernumericE0M.AssertModel(models[1],_testData[31], false);
                        FlatBigIntegernumericE0M.AssertModel(models[2],_testData[32], false);
                        FlatBigIntegernumericE0M.AssertModel(models[3],_testData[33], false);
                        FlatBigIntegernumericE0M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatBigIntegernumericE0M.AssertModel(models[0],_testData[16], false);
                        FlatBigIntegernumericE0M.AssertModel(models[1],_testData[17], false);
                        FlatBigIntegernumericE0M.AssertModel(models[2],_testData[18], false);
                        FlatBigIntegernumericE0M.AssertModel(models[3],_testData[19], false);
                        FlatBigIntegernumericE0M.AssertModel(models[4],_testData[20], false);
                        FlatBigIntegernumericE0M.AssertModel(models[5],_testData[21], false);
                        FlatBigIntegernumericE0M.AssertModel(models[6],_testData[22], false);
                        FlatBigIntegernumericE0M.AssertModel(models[7],_testData[23], false);
                        FlatBigIntegernumericE0M.AssertModel(models[8],_testData[24], false);
                        FlatBigIntegernumericE0M.AssertModel(models[9],_testData[25], false);
                        FlatBigIntegernumericE0M.AssertModel(models[10],_testData[26], false);
                        FlatBigIntegernumericE0M.AssertModel(models[11],_testData[27], false);
                        FlatBigIntegernumericE0M.AssertModel(models[12],_testData[28], false);
                        FlatBigIntegernumericE0M.AssertModel(models[13],_testData[29], false);
                        FlatBigIntegernumericE0M.AssertModel(models[14],_testData[30], false);
                        FlatBigIntegernumericE0M.AssertModel(models[15],_testData[31], false);
                        FlatBigIntegernumericE0M.AssertModel(models[16],_testData[32], false);
                        FlatBigIntegernumericE0M.AssertModel(models[17],_testData[33], false);
                        FlatBigIntegernumericE0M.AssertModel(models[18],_testData[34], false);
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
                parametr1.Value = 36;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 46;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumerice0m m
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
FROM public.bigintegernumerice0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericE0M>();
                var secondItems1 = new List<FlatBigIntegernumericE0M>();
                var secondItems2 = new List<FlatBigIntegernumericE0M>();
                await ((IBigIntegerSingleTypenumeric)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[25],_testData[34], false);
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
FROM public.bigintegernumerice0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IBigIntegerSingleTypenumeric)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 63;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 10;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumerice0m m
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
FROM public.bigintegernumerice0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerSingleTypenumeric)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatBigIntegernumericE0M.AssertModel(models[0],_testData[13], false);
                        FlatBigIntegernumericE0M.AssertModel(models[1],_testData[14], false);
                        FlatBigIntegernumericE0M.AssertModel(models[2],_testData[15], false);
                        FlatBigIntegernumericE0M.AssertModel(models[3],_testData[16], false);
                        FlatBigIntegernumericE0M.AssertModel(models[4],_testData[17], false);
                        FlatBigIntegernumericE0M.AssertModel(models[5],_testData[18], false);
                        FlatBigIntegernumericE0M.AssertModel(models[6],_testData[19], false);
                        FlatBigIntegernumericE0M.AssertModel(models[7],_testData[20], false);
                        FlatBigIntegernumericE0M.AssertModel(models[8],_testData[21], false);
                        FlatBigIntegernumericE0M.AssertModel(models[9],_testData[22], false);
                        FlatBigIntegernumericE0M.AssertModel(models[10],_testData[23], false);
                        FlatBigIntegernumericE0M.AssertModel(models[11],_testData[24], false);
                        FlatBigIntegernumericE0M.AssertModel(models[12],_testData[25], false);
                        FlatBigIntegernumericE0M.AssertModel(models[13],_testData[26], false);
                        FlatBigIntegernumericE0M.AssertModel(models[14],_testData[27], false);
                        FlatBigIntegernumericE0M.AssertModel(models[15],_testData[28], false);
                        FlatBigIntegernumericE0M.AssertModel(models[16],_testData[29], false);
                        FlatBigIntegernumericE0M.AssertModel(models[17],_testData[30], false);
                        FlatBigIntegernumericE0M.AssertModel(models[18],_testData[31], false);
                        FlatBigIntegernumericE0M.AssertModel(models[19],_testData[32], false);
                        FlatBigIntegernumericE0M.AssertModel(models[20],_testData[33], false);
                        FlatBigIntegernumericE0M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatBigIntegernumericE0M.AssertModel(models[0],_testData[3], false);
                        FlatBigIntegernumericE0M.AssertModel(models[1],_testData[4], false);
                        FlatBigIntegernumericE0M.AssertModel(models[2],_testData[5], false);
                        FlatBigIntegernumericE0M.AssertModel(models[3],_testData[6], false);
                        FlatBigIntegernumericE0M.AssertModel(models[4],_testData[7], false);
                        FlatBigIntegernumericE0M.AssertModel(models[5],_testData[8], false);
                        FlatBigIntegernumericE0M.AssertModel(models[6],_testData[9], false);
                        FlatBigIntegernumericE0M.AssertModel(models[7],_testData[10], false);
                        FlatBigIntegernumericE0M.AssertModel(models[8],_testData[11], false);
                        FlatBigIntegernumericE0M.AssertModel(models[9],_testData[12], false);
                        FlatBigIntegernumericE0M.AssertModel(models[10],_testData[13], false);
                        FlatBigIntegernumericE0M.AssertModel(models[11],_testData[14], false);
                        FlatBigIntegernumericE0M.AssertModel(models[12],_testData[15], false);
                        FlatBigIntegernumericE0M.AssertModel(models[13],_testData[16], false);
                        FlatBigIntegernumericE0M.AssertModel(models[14],_testData[17], false);
                        FlatBigIntegernumericE0M.AssertModel(models[15],_testData[18], false);
                        FlatBigIntegernumericE0M.AssertModel(models[16],_testData[19], false);
                        FlatBigIntegernumericE0M.AssertModel(models[17],_testData[20], false);
                        FlatBigIntegernumericE0M.AssertModel(models[18],_testData[21], false);
                        FlatBigIntegernumericE0M.AssertModel(models[19],_testData[22], false);
                        FlatBigIntegernumericE0M.AssertModel(models[20],_testData[23], false);
                        FlatBigIntegernumericE0M.AssertModel(models[21],_testData[24], false);
                        FlatBigIntegernumericE0M.AssertModel(models[22],_testData[25], false);
                        FlatBigIntegernumericE0M.AssertModel(models[23],_testData[26], false);
                        FlatBigIntegernumericE0M.AssertModel(models[24],_testData[27], false);
                        FlatBigIntegernumericE0M.AssertModel(models[25],_testData[28], false);
                        FlatBigIntegernumericE0M.AssertModel(models[26],_testData[29], false);
                        FlatBigIntegernumericE0M.AssertModel(models[27],_testData[30], false);
                        FlatBigIntegernumericE0M.AssertModel(models[28],_testData[31], false);
                        FlatBigIntegernumericE0M.AssertModel(models[29],_testData[32], false);
                        FlatBigIntegernumericE0M.AssertModel(models[30],_testData[33], false);
                        FlatBigIntegernumericE0M.AssertModel(models[31],_testData[34], false);
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
                parametr1.Value = 8;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 9;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumerice0m m
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
FROM public.bigintegernumerice0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericE0M>();
                var secondItems1 = new List<FlatBigIntegernumericE0M>();
                var secondItems2 = new List<FlatBigIntegernumericE0M>();
                 ((IBigIntegerSingleTypenumeric)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[32],_testData[34], false);
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
FROM public.bigintegernumerice0m m
LEFT JOIN public.bigintegernumerice0mi mi ON mi.id = m.bigintegernumerice0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(BigIntegernumericE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerSingleTypenumeric)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerSingleTypenumeric)),
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
                var models = await((IBigIntegerSingleTypenumeric)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 123;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 128;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerSingleTypenumeric)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        BigIntegernumericE0M.AssertModel(models[0],_testData[23], false);
                        BigIntegernumericE0M.AssertModel(models[1],_testData[24], false);
                        BigIntegernumericE0M.AssertModel(models[2],_testData[25], false);
                        BigIntegernumericE0M.AssertModel(models[3],_testData[26], false);
                        BigIntegernumericE0M.AssertModel(models[4],_testData[27], false);
                        BigIntegernumericE0M.AssertModel(models[5],_testData[28], false);
                        BigIntegernumericE0M.AssertModel(models[6],_testData[29], false);
                        BigIntegernumericE0M.AssertModel(models[7],_testData[30], false);
                        BigIntegernumericE0M.AssertModel(models[8],_testData[31], false);
                        BigIntegernumericE0M.AssertModel(models[9],_testData[32], false);
                        BigIntegernumericE0M.AssertModel(models[10],_testData[33], false);
                        BigIntegernumericE0M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        BigIntegernumericE0M.AssertModel(models[0],_testData[24], false);
                        BigIntegernumericE0M.AssertModel(models[1],_testData[25], false);
                        BigIntegernumericE0M.AssertModel(models[2],_testData[26], false);
                        BigIntegernumericE0M.AssertModel(models[3],_testData[27], false);
                        BigIntegernumericE0M.AssertModel(models[4],_testData[28], false);
                        BigIntegernumericE0M.AssertModel(models[5],_testData[29], false);
                        BigIntegernumericE0M.AssertModel(models[6],_testData[30], false);
                        BigIntegernumericE0M.AssertModel(models[7],_testData[31], false);
                        BigIntegernumericE0M.AssertModel(models[8],_testData[32], false);
                        BigIntegernumericE0M.AssertModel(models[9],_testData[33], false);
                        BigIntegernumericE0M.AssertModel(models[10],_testData[34], false);
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
                var models = ((IBigIntegerSingleTypenumeric)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 69;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 165;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerSingleTypenumeric)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        BigIntegernumericE0M.AssertModel(models[0],_testData[14], false);
                        BigIntegernumericE0M.AssertModel(models[1],_testData[15], false);
                        BigIntegernumericE0M.AssertModel(models[2],_testData[16], false);
                        BigIntegernumericE0M.AssertModel(models[3],_testData[17], false);
                        BigIntegernumericE0M.AssertModel(models[4],_testData[18], false);
                        BigIntegernumericE0M.AssertModel(models[5],_testData[19], false);
                        BigIntegernumericE0M.AssertModel(models[6],_testData[20], false);
                        BigIntegernumericE0M.AssertModel(models[7],_testData[21], false);
                        BigIntegernumericE0M.AssertModel(models[8],_testData[22], false);
                        BigIntegernumericE0M.AssertModel(models[9],_testData[23], false);
                        BigIntegernumericE0M.AssertModel(models[10],_testData[24], false);
                        BigIntegernumericE0M.AssertModel(models[11],_testData[25], false);
                        BigIntegernumericE0M.AssertModel(models[12],_testData[26], false);
                        BigIntegernumericE0M.AssertModel(models[13],_testData[27], false);
                        BigIntegernumericE0M.AssertModel(models[14],_testData[28], false);
                        BigIntegernumericE0M.AssertModel(models[15],_testData[29], false);
                        BigIntegernumericE0M.AssertModel(models[16],_testData[30], false);
                        BigIntegernumericE0M.AssertModel(models[17],_testData[31], false);
                        BigIntegernumericE0M.AssertModel(models[18],_testData[32], false);
                        BigIntegernumericE0M.AssertModel(models[19],_testData[33], false);
                        BigIntegernumericE0M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        BigIntegernumericE0M.AssertModel(models[0],_testData[31], false);
                        BigIntegernumericE0M.AssertModel(models[1],_testData[32], false);
                        BigIntegernumericE0M.AssertModel(models[2],_testData[33], false);
                        BigIntegernumericE0M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericE0M), typeof(FlatBigIntegernumericE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerSingleTypenumeric)),
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
            asPartInterface: typeof(IBigIntegerSingleTypenumeric)),
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
            asPartInterface: typeof(IBigIntegerSingleTypenumeric)),
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
FROM public.bigintegernumerice0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericE0M>();
                var models2 = new List<FlatBigIntegernumericE0M>();
                await((IBigIntegerSingleTypenumeric)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericE0M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumerice0m m
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
FROM public.bigintegernumerice0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericE0M>();
                var firstItems2 = new List<FlatBigIntegernumericE0M>();
                var secondItems1 = new List<FlatBigIntegernumericE0M>();
                var secondItems2 = new List<FlatBigIntegernumericE0M>();
                await ((IBigIntegerSingleTypenumeric)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 178, query1, 169, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[2],_testData[34], false);
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
FROM public.bigintegernumerice0m m
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
FROM public.bigintegernumerice0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericE0M>();
                var firstItems2 = new List<FlatBigIntegernumericE0M>();
                var secondItems1 = new List<FlatBigIntegernumericE0M>();
                await ((IBigIntegerSingleTypenumeric)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 136, query1, 142, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[7],_testData[34], false);
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
FROM public.bigintegernumerice0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericE0M>();
                var models2 = new List<FlatBigIntegernumericE0M>();
                ((IBigIntegerSingleTypenumeric)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericE0M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumerice0m m
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
FROM public.bigintegernumerice0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericE0M>();
                var firstItems2 = new List<FlatBigIntegernumericE0M>();
                var secondItems1 = new List<FlatBigIntegernumericE0M>();
                var secondItems2 = new List<FlatBigIntegernumericE0M>();
                 ((IBigIntegerSingleTypenumeric)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 76, query1, 123, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[11],_testData[34], false);
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
FROM public.bigintegernumerice0m m
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
FROM public.bigintegernumerice0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericE0M>();
                var firstItems2 = new List<FlatBigIntegernumericE0M>();
                var secondItems1 = new List<FlatBigIntegernumericE0M>();
                 ((IBigIntegerSingleTypenumeric)this).DbConnectionMMDynQuerySelectModelBatch(connection, 47, query1, 69, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[20],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerSingleTypenumeric)),
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
            asPartInterface: typeof(IBigIntegerSingleTypenumeric)),
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
            asPartInterface: typeof(IBigIntegerSingleTypenumeric)),
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
FROM public.bigintegernumerice0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IBigIntegerSingleTypenumeric)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumerice0m m
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
FROM public.bigintegernumerice0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerSingleTypenumeric)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 63, query1, 84, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatBigIntegernumericE0M.AssertModel(models[0],_testData[13], false);
                        FlatBigIntegernumericE0M.AssertModel(models[1],_testData[14], false);
                        FlatBigIntegernumericE0M.AssertModel(models[2],_testData[15], false);
                        FlatBigIntegernumericE0M.AssertModel(models[3],_testData[16], false);
                        FlatBigIntegernumericE0M.AssertModel(models[4],_testData[17], false);
                        FlatBigIntegernumericE0M.AssertModel(models[5],_testData[18], false);
                        FlatBigIntegernumericE0M.AssertModel(models[6],_testData[19], false);
                        FlatBigIntegernumericE0M.AssertModel(models[7],_testData[20], false);
                        FlatBigIntegernumericE0M.AssertModel(models[8],_testData[21], false);
                        FlatBigIntegernumericE0M.AssertModel(models[9],_testData[22], false);
                        FlatBigIntegernumericE0M.AssertModel(models[10],_testData[23], false);
                        FlatBigIntegernumericE0M.AssertModel(models[11],_testData[24], false);
                        FlatBigIntegernumericE0M.AssertModel(models[12],_testData[25], false);
                        FlatBigIntegernumericE0M.AssertModel(models[13],_testData[26], false);
                        FlatBigIntegernumericE0M.AssertModel(models[14],_testData[27], false);
                        FlatBigIntegernumericE0M.AssertModel(models[15],_testData[28], false);
                        FlatBigIntegernumericE0M.AssertModel(models[16],_testData[29], false);
                        FlatBigIntegernumericE0M.AssertModel(models[17],_testData[30], false);
                        FlatBigIntegernumericE0M.AssertModel(models[18],_testData[31], false);
                        FlatBigIntegernumericE0M.AssertModel(models[19],_testData[32], false);
                        FlatBigIntegernumericE0M.AssertModel(models[20],_testData[33], false);
                        FlatBigIntegernumericE0M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatBigIntegernumericE0M.AssertModel(models[0],_testData[17], false);
                        FlatBigIntegernumericE0M.AssertModel(models[1],_testData[18], false);
                        FlatBigIntegernumericE0M.AssertModel(models[2],_testData[19], false);
                        FlatBigIntegernumericE0M.AssertModel(models[3],_testData[20], false);
                        FlatBigIntegernumericE0M.AssertModel(models[4],_testData[21], false);
                        FlatBigIntegernumericE0M.AssertModel(models[5],_testData[22], false);
                        FlatBigIntegernumericE0M.AssertModel(models[6],_testData[23], false);
                        FlatBigIntegernumericE0M.AssertModel(models[7],_testData[24], false);
                        FlatBigIntegernumericE0M.AssertModel(models[8],_testData[25], false);
                        FlatBigIntegernumericE0M.AssertModel(models[9],_testData[26], false);
                        FlatBigIntegernumericE0M.AssertModel(models[10],_testData[27], false);
                        FlatBigIntegernumericE0M.AssertModel(models[11],_testData[28], false);
                        FlatBigIntegernumericE0M.AssertModel(models[12],_testData[29], false);
                        FlatBigIntegernumericE0M.AssertModel(models[13],_testData[30], false);
                        FlatBigIntegernumericE0M.AssertModel(models[14],_testData[31], false);
                        FlatBigIntegernumericE0M.AssertModel(models[15],_testData[32], false);
                        FlatBigIntegernumericE0M.AssertModel(models[16],_testData[33], false);
                        FlatBigIntegernumericE0M.AssertModel(models[17],_testData[34], false);
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
FROM public.bigintegernumerice0m m
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
FROM public.bigintegernumerice0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericE0M>();
                var secondItems1 = new List<FlatBigIntegernumericE0M>();
                var secondItems2 = new List<FlatBigIntegernumericE0M>();
                await ((IBigIntegerSingleTypenumeric)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 29, query1, 63, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[21],_testData[34], false);
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
FROM public.bigintegernumerice0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IBigIntegerSingleTypenumeric)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumerice0m m
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
FROM public.bigintegernumerice0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerSingleTypenumeric)this).DbConnectionSTDynQuerySelectModelBatch(connection, 135, query1, 128, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatBigIntegernumericE0M.AssertModel(models[0],_testData[25], false);
                        FlatBigIntegernumericE0M.AssertModel(models[1],_testData[26], false);
                        FlatBigIntegernumericE0M.AssertModel(models[2],_testData[27], false);
                        FlatBigIntegernumericE0M.AssertModel(models[3],_testData[28], false);
                        FlatBigIntegernumericE0M.AssertModel(models[4],_testData[29], false);
                        FlatBigIntegernumericE0M.AssertModel(models[5],_testData[30], false);
                        FlatBigIntegernumericE0M.AssertModel(models[6],_testData[31], false);
                        FlatBigIntegernumericE0M.AssertModel(models[7],_testData[32], false);
                        FlatBigIntegernumericE0M.AssertModel(models[8],_testData[33], false);
                        FlatBigIntegernumericE0M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatBigIntegernumericE0M.AssertModel(models[0],_testData[24], false);
                        FlatBigIntegernumericE0M.AssertModel(models[1],_testData[25], false);
                        FlatBigIntegernumericE0M.AssertModel(models[2],_testData[26], false);
                        FlatBigIntegernumericE0M.AssertModel(models[3],_testData[27], false);
                        FlatBigIntegernumericE0M.AssertModel(models[4],_testData[28], false);
                        FlatBigIntegernumericE0M.AssertModel(models[5],_testData[29], false);
                        FlatBigIntegernumericE0M.AssertModel(models[6],_testData[30], false);
                        FlatBigIntegernumericE0M.AssertModel(models[7],_testData[31], false);
                        FlatBigIntegernumericE0M.AssertModel(models[8],_testData[32], false);
                        FlatBigIntegernumericE0M.AssertModel(models[9],_testData[33], false);
                        FlatBigIntegernumericE0M.AssertModel(models[10],_testData[34], false);
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
FROM public.bigintegernumerice0m m
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
FROM public.bigintegernumerice0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericE0M>();
                var secondItems1 = new List<FlatBigIntegernumericE0M>();
                var secondItems2 = new List<FlatBigIntegernumericE0M>();
                 ((IBigIntegerSingleTypenumeric)this).DbConnectionDynQuerySelectModelBatch(connection, 123, query1, 63, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatBigIntegernumericE0M.AssertModel(firstItems1[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatBigIntegernumericE0M.AssertModel(secondItems2[21],_testData[34], false);
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
FROM public.bigintegernumerice0m m
LEFT JOIN public.bigintegernumerice0mi mi ON mi.id = m.bigintegernumerice0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(BigIntegernumericE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerSingleTypenumeric)),
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
            asPartInterface: typeof(IBigIntegerSingleTypenumeric)),
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
                var models = await((IBigIntegerSingleTypenumeric)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IBigIntegerSingleTypenumeric)this).DbConnectionSTSelectModelBatchAsync(connection, 8, 142))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        BigIntegernumericE0M.AssertModel(models[0],_testData[1], false);
                        BigIntegernumericE0M.AssertModel(models[1],_testData[2], false);
                        BigIntegernumericE0M.AssertModel(models[2],_testData[3], false);
                        BigIntegernumericE0M.AssertModel(models[3],_testData[4], false);
                        BigIntegernumericE0M.AssertModel(models[4],_testData[5], false);
                        BigIntegernumericE0M.AssertModel(models[5],_testData[6], false);
                        BigIntegernumericE0M.AssertModel(models[6],_testData[7], false);
                        BigIntegernumericE0M.AssertModel(models[7],_testData[8], false);
                        BigIntegernumericE0M.AssertModel(models[8],_testData[9], false);
                        BigIntegernumericE0M.AssertModel(models[9],_testData[10], false);
                        BigIntegernumericE0M.AssertModel(models[10],_testData[11], false);
                        BigIntegernumericE0M.AssertModel(models[11],_testData[12], false);
                        BigIntegernumericE0M.AssertModel(models[12],_testData[13], false);
                        BigIntegernumericE0M.AssertModel(models[13],_testData[14], false);
                        BigIntegernumericE0M.AssertModel(models[14],_testData[15], false);
                        BigIntegernumericE0M.AssertModel(models[15],_testData[16], false);
                        BigIntegernumericE0M.AssertModel(models[16],_testData[17], false);
                        BigIntegernumericE0M.AssertModel(models[17],_testData[18], false);
                        BigIntegernumericE0M.AssertModel(models[18],_testData[19], false);
                        BigIntegernumericE0M.AssertModel(models[19],_testData[20], false);
                        BigIntegernumericE0M.AssertModel(models[20],_testData[21], false);
                        BigIntegernumericE0M.AssertModel(models[21],_testData[22], false);
                        BigIntegernumericE0M.AssertModel(models[22],_testData[23], false);
                        BigIntegernumericE0M.AssertModel(models[23],_testData[24], false);
                        BigIntegernumericE0M.AssertModel(models[24],_testData[25], false);
                        BigIntegernumericE0M.AssertModel(models[25],_testData[26], false);
                        BigIntegernumericE0M.AssertModel(models[26],_testData[27], false);
                        BigIntegernumericE0M.AssertModel(models[27],_testData[28], false);
                        BigIntegernumericE0M.AssertModel(models[28],_testData[29], false);
                        BigIntegernumericE0M.AssertModel(models[29],_testData[30], false);
                        BigIntegernumericE0M.AssertModel(models[30],_testData[31], false);
                        BigIntegernumericE0M.AssertModel(models[31],_testData[32], false);
                        BigIntegernumericE0M.AssertModel(models[32],_testData[33], false);
                        BigIntegernumericE0M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        BigIntegernumericE0M.AssertModel(models[0],_testData[27], false);
                        BigIntegernumericE0M.AssertModel(models[1],_testData[28], false);
                        BigIntegernumericE0M.AssertModel(models[2],_testData[29], false);
                        BigIntegernumericE0M.AssertModel(models[3],_testData[30], false);
                        BigIntegernumericE0M.AssertModel(models[4],_testData[31], false);
                        BigIntegernumericE0M.AssertModel(models[5],_testData[32], false);
                        BigIntegernumericE0M.AssertModel(models[6],_testData[33], false);
                        BigIntegernumericE0M.AssertModel(models[7],_testData[34], false);
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
                var models = ((IBigIntegerSingleTypenumeric)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IBigIntegerSingleTypenumeric)this).DbConnectionSTSelectModelBatch(connection, 84, 84))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        BigIntegernumericE0M.AssertModel(models[0],_testData[17], false);
                        BigIntegernumericE0M.AssertModel(models[1],_testData[18], false);
                        BigIntegernumericE0M.AssertModel(models[2],_testData[19], false);
                        BigIntegernumericE0M.AssertModel(models[3],_testData[20], false);
                        BigIntegernumericE0M.AssertModel(models[4],_testData[21], false);
                        BigIntegernumericE0M.AssertModel(models[5],_testData[22], false);
                        BigIntegernumericE0M.AssertModel(models[6],_testData[23], false);
                        BigIntegernumericE0M.AssertModel(models[7],_testData[24], false);
                        BigIntegernumericE0M.AssertModel(models[8],_testData[25], false);
                        BigIntegernumericE0M.AssertModel(models[9],_testData[26], false);
                        BigIntegernumericE0M.AssertModel(models[10],_testData[27], false);
                        BigIntegernumericE0M.AssertModel(models[11],_testData[28], false);
                        BigIntegernumericE0M.AssertModel(models[12],_testData[29], false);
                        BigIntegernumericE0M.AssertModel(models[13],_testData[30], false);
                        BigIntegernumericE0M.AssertModel(models[14],_testData[31], false);
                        BigIntegernumericE0M.AssertModel(models[15],_testData[32], false);
                        BigIntegernumericE0M.AssertModel(models[16],_testData[33], false);
                        BigIntegernumericE0M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        BigIntegernumericE0M.AssertModel(models[0],_testData[17], false);
                        BigIntegernumericE0M.AssertModel(models[1],_testData[18], false);
                        BigIntegernumericE0M.AssertModel(models[2],_testData[19], false);
                        BigIntegernumericE0M.AssertModel(models[3],_testData[20], false);
                        BigIntegernumericE0M.AssertModel(models[4],_testData[21], false);
                        BigIntegernumericE0M.AssertModel(models[5],_testData[22], false);
                        BigIntegernumericE0M.AssertModel(models[6],_testData[23], false);
                        BigIntegernumericE0M.AssertModel(models[7],_testData[24], false);
                        BigIntegernumericE0M.AssertModel(models[8],_testData[25], false);
                        BigIntegernumericE0M.AssertModel(models[9],_testData[26], false);
                        BigIntegernumericE0M.AssertModel(models[10],_testData[27], false);
                        BigIntegernumericE0M.AssertModel(models[11],_testData[28], false);
                        BigIntegernumericE0M.AssertModel(models[12],_testData[29], false);
                        BigIntegernumericE0M.AssertModel(models[13],_testData[30], false);
                        BigIntegernumericE0M.AssertModel(models[14],_testData[31], false);
                        BigIntegernumericE0M.AssertModel(models[15],_testData[32], false);
                        BigIntegernumericE0M.AssertModel(models[16],_testData[33], false);
                        BigIntegernumericE0M.AssertModel(models[17],_testData[34], false);
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
                await using var cmd = await ((IBigIntegerSingleTypenumeric)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IBigIntegerSingleTypenumeric)this).SetDbConnectionSelectModelParametrs(cmd, 20);
                var models = await ((IBigIntegerSingleTypenumeric)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(30));

                BigIntegernumericE0M.AssertModel(models[0],_testData[5], false);
                BigIntegernumericE0M.AssertModel(models[1],_testData[6], false);
                BigIntegernumericE0M.AssertModel(models[2],_testData[7], false);
                BigIntegernumericE0M.AssertModel(models[3],_testData[8], false);
                BigIntegernumericE0M.AssertModel(models[4],_testData[9], false);
                BigIntegernumericE0M.AssertModel(models[5],_testData[10], false);
                BigIntegernumericE0M.AssertModel(models[6],_testData[11], false);
                BigIntegernumericE0M.AssertModel(models[7],_testData[12], false);
                BigIntegernumericE0M.AssertModel(models[8],_testData[13], false);
                BigIntegernumericE0M.AssertModel(models[9],_testData[14], false);
                BigIntegernumericE0M.AssertModel(models[10],_testData[15], false);
                BigIntegernumericE0M.AssertModel(models[11],_testData[16], false);
                BigIntegernumericE0M.AssertModel(models[12],_testData[17], false);
                BigIntegernumericE0M.AssertModel(models[13],_testData[18], false);
                BigIntegernumericE0M.AssertModel(models[14],_testData[19], false);
                BigIntegernumericE0M.AssertModel(models[15],_testData[20], false);
                BigIntegernumericE0M.AssertModel(models[16],_testData[21], false);
                BigIntegernumericE0M.AssertModel(models[17],_testData[22], false);
                BigIntegernumericE0M.AssertModel(models[18],_testData[23], false);
                BigIntegernumericE0M.AssertModel(models[19],_testData[24], false);
                BigIntegernumericE0M.AssertModel(models[20],_testData[25], false);
                BigIntegernumericE0M.AssertModel(models[21],_testData[26], false);
                BigIntegernumericE0M.AssertModel(models[22],_testData[27], false);
                BigIntegernumericE0M.AssertModel(models[23],_testData[28], false);
                BigIntegernumericE0M.AssertModel(models[24],_testData[29], false);
                BigIntegernumericE0M.AssertModel(models[25],_testData[30], false);
                BigIntegernumericE0M.AssertModel(models[26],_testData[31], false);
                BigIntegernumericE0M.AssertModel(models[27],_testData[32], false);
                BigIntegernumericE0M.AssertModel(models[28],_testData[33], false);
                BigIntegernumericE0M.AssertModel(models[29],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IBigIntegerSingleTypenumeric)this).CreateDbConnectionSelectModelCommand(connection);
                ((IBigIntegerSingleTypenumeric)this).SetDbConnectionSelectModelParametrs(cmd, 123);
                var models =  ((IBigIntegerSingleTypenumeric)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(12));

                BigIntegernumericE0M.AssertModel(models[0],_testData[23], false);
                BigIntegernumericE0M.AssertModel(models[1],_testData[24], false);
                BigIntegernumericE0M.AssertModel(models[2],_testData[25], false);
                BigIntegernumericE0M.AssertModel(models[3],_testData[26], false);
                BigIntegernumericE0M.AssertModel(models[4],_testData[27], false);
                BigIntegernumericE0M.AssertModel(models[5],_testData[28], false);
                BigIntegernumericE0M.AssertModel(models[6],_testData[29], false);
                BigIntegernumericE0M.AssertModel(models[7],_testData[30], false);
                BigIntegernumericE0M.AssertModel(models[8],_testData[31], false);
                BigIntegernumericE0M.AssertModel(models[9],_testData[32], false);
                BigIntegernumericE0M.AssertModel(models[10],_testData[33], false);
                BigIntegernumericE0M.AssertModel(models[11],_testData[34], false);
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
FROM public.bigintegernumerice0m m
LEFT JOIN public.bigintegernumerice0mi mi ON mi.id = m.bigintegernumerice0mi_id
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
            asPartInterface: typeof(IBigIntegerSingleTypenumeric))]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IBigIntegerSingleTypenumeric)this).DbConnectionSelectModelToObjArrAsync(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6229808299720094274L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(623578651345817888L))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7155407909266417285L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(985524926325129206L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8011048432235211382L))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7682912151835959740L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2461175391337434036L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((11)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(3971414812046826499L))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1075082172366296960L))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6982214865456048622L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8299400533190940083L))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1757125833529530353L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2997945603824867419L))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1706100616769463339L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(4762487269898989110L))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7427584064774836140L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1464741641771633193L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7711850622309797943L))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(834732193234466710L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1204623586492746748L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(5346413697853745040L))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(5614732563044963573L))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2951015348996015484L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2136914400271271731L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(3950438247822649548L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1203566144648050269L))));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(3214207748142775805L))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(4298663839661597991L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7932801006718458533L))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1182271718151598043L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7829064666780129698L))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(4754670046593914402L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2338477630144848686L))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8353057741191510763L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(5903140545241389128L))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1729993904050611184L))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(4526815713109859321L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2383967307621764616L))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(4951601937714061594L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((56)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(5768144947261306748L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(5500130300001975521L))));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2685434619087207412L))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((96)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(274129803651370578L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(3622985873962890621L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7208042808568529539L))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1324366990998784884L))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8420742988718810407L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1245999726970333341L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6209391291887608826L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7098612549978888963L))));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2242515384211900197L))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7440025106831881302L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6409133558181049267L))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6330926033567928434L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((80)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(950328107169493266L))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(808965492845648540L))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1401858144244708912L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1639892924509525755L))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6689986449541705982L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((89)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(155655528541487768L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8848310673795379509L))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((142)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8013226697240023187L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7333613890517627321L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((93)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(672493321671511114L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7898603241457134208L))));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6716855592697717402L))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(4473652767065451667L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8511644696231676888L))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((157)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7277655365756058676L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((99)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2322665923669925942L))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(5840251407078207918L))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((165)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(4702044887329139780L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((169)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6964431432170178878L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((101)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7837643323819045469L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(445343244602628537L))));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8440361212211656399L))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((178)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(379196198609215822L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(5898126706956795276L))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((186)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6726395566217662984L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((107)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2787313002077770163L))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((190)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6246718467070328682L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(5873667305767538819L))));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((IBigIntegerSingleTypenumeric)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6229808299720094274L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(623578651345817888L))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7155407909266417285L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(985524926325129206L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8011048432235211382L))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7682912151835959740L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2461175391337434036L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((11)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(3971414812046826499L))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1075082172366296960L))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6982214865456048622L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8299400533190940083L))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1757125833529530353L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2997945603824867419L))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1706100616769463339L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(4762487269898989110L))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7427584064774836140L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1464741641771633193L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7711850622309797943L))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(834732193234466710L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1204623586492746748L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(5346413697853745040L))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(5614732563044963573L))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2951015348996015484L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2136914400271271731L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(3950438247822649548L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1203566144648050269L))));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(3214207748142775805L))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(4298663839661597991L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7932801006718458533L))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1182271718151598043L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7829064666780129698L))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(4754670046593914402L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2338477630144848686L))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8353057741191510763L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(5903140545241389128L))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1729993904050611184L))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(4526815713109859321L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2383967307621764616L))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(4951601937714061594L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((56)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(5768144947261306748L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(5500130300001975521L))));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2685434619087207412L))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((96)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(274129803651370578L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(3622985873962890621L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7208042808568529539L))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1324366990998784884L))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8420742988718810407L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1245999726970333341L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6209391291887608826L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7098612549978888963L))));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2242515384211900197L))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7440025106831881302L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6409133558181049267L))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6330926033567928434L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((80)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(950328107169493266L))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(808965492845648540L))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1401858144244708912L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(1639892924509525755L))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6689986449541705982L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((89)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(155655528541487768L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8848310673795379509L))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((142)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8013226697240023187L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7333613890517627321L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((93)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(672493321671511114L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7898603241457134208L))));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6716855592697717402L))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(4473652767065451667L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8511644696231676888L))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((157)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7277655365756058676L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((99)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2322665923669925942L))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(5840251407078207918L))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((165)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(4702044887329139780L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((169)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6964431432170178878L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((101)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(7837643323819045469L))));//InnerModel.Value

                Assert.That((System.Decimal?)model[4], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(445343244602628537L))));//InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(8440361212211656399L))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((178)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(379196198609215822L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(5898126706956795276L))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((186)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6726395566217662984L))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((107)));//InnerModel.Id
                Assert.That((System.Decimal)model[3], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(2787313002077770163L))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((190)));//Id
                Assert.That((System.Decimal)model[1], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(6246718467070328682L))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((System.Decimal?)model[5], Is.EqualTo(((System.Decimal)new System.Numerics.BigInteger(5873667305767538819L))));

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
FROM public.binary_bigintegernumerice0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerSingleTypenumeric))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(BigIntegernumericE0MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(13),
                (NpgsqlTypes.NpgsqlDbType)(13)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerSingleTypenumeric))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericE0MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IBigIntegerSingleTypenumeric)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_bigintegernumerice0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IBigIntegerSingleTypenumeric)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericE0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericE0MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IBigIntegerSingleTypenumeric)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_bigintegernumerice0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IBigIntegerSingleTypenumeric)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericE0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_bigintegernumerice0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerSingleTypenumeric))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(BigIntegernumericE0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerSingleTypenumeric))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericE0MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IBigIntegerSingleTypenumeric)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_bigintegernumerice0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IBigIntegerSingleTypenumeric)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericE0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericE0MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IBigIntegerSingleTypenumeric)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_bigintegernumerice0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IBigIntegerSingleTypenumeric)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericE0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_bigintegernumerice0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericE0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerSingleTypenumeric))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_bigintegernumerice0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(BigIntegernumericE0MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(13),
                (NpgsqlTypes.NpgsqlDbType)(13)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerSingleTypenumeric))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericE0MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IBigIntegerSingleTypenumeric)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IBigIntegerSingleTypenumeric)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericE0MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericE0MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IBigIntegerSingleTypenumeric)this).WAImportModelInner(connection, importCollection);
                var models = ((IBigIntegerSingleTypenumeric)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericE0MI.AssertModel(actual, expect, false);
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
FROM public.binary_bigintegernumerice0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerSingleTypenumeric))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_bigintegernumerice0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(BigIntegernumericE0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerSingleTypenumeric))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericE0MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IBigIntegerSingleTypenumeric)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IBigIntegerSingleTypenumeric)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericE0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericE0MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IBigIntegerSingleTypenumeric)this).ImportModelInner(connection, importCollection);
                var models = ((IBigIntegerSingleTypenumeric)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericE0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_bigintegernumerice0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
bigintegernumerice0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(BigIntegernumericE0M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(13),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(13)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerSingleTypenumeric))]
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
FROM public.binary_bigintegernumerice0m m
LEFT JOIN public.binary_bigintegernumerice0mi mi ON mi.id = m.bigintegernumerice0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(BigIntegernumericE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerSingleTypenumeric))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericE0M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IBigIntegerSingleTypenumeric)this).ImportModelAsync(connection, importCollection);
                var models = await ((IBigIntegerSingleTypenumeric)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    BigIntegernumericE0M.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericE0M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IBigIntegerSingleTypenumeric)this).ImportModel(connection, importCollection);
                var models = ((IBigIntegerSingleTypenumeric)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    BigIntegernumericE0M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bigintegernumerice0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    bigintegernumerice0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(BigIntegernumericE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerSingleTypenumeric)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(13),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(13)
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
                var models =  ((IBigIntegerSingleTypenumeric)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    BigIntegernumericE0M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IBigIntegerSingleTypenumeric)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    BigIntegernumericE0M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericE0MIWA), typeof(BigIntegernumericE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerSingleTypenumeric)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(13),
                (NpgsqlTypes.NpgsqlDbType)(13)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(13),
                (NpgsqlTypes.NpgsqlDbType)(13)
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
                var models1 = new List<BigIntegernumericE0MIWA>();
                var models2 = new List<BigIntegernumericE0MIWA>();
                await ((IBigIntegerSingleTypenumeric)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bigintegernumerice0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericE0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BigIntegernumericE0MIWA>();
                var models2 = new List<BigIntegernumericE0MIWA>();
                ((IBigIntegerSingleTypenumeric)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bigintegernumerice0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerSingleTypenumeric)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(13),
                (NpgsqlTypes.NpgsqlDbType)(13)
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
                var models = await ((IBigIntegerSingleTypenumeric)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_bigintegernumerice0mi
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
                    BigIntegernumericE0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IBigIntegerSingleTypenumeric)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_bigintegernumerice0mi
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
                    BigIntegernumericE0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericE0MIWA), typeof(BigIntegernumericE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerSingleTypenumeric))]
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
                var models1 = new List<BigIntegernumericE0MIWA>();
                var models2 = new List<BigIntegernumericE0MIWA>();
                await ((IBigIntegerSingleTypenumeric)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bigintegernumerice0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericE0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BigIntegernumericE0MIWA>();
                var models2 = new List<BigIntegernumericE0MIWA>();
                ((IBigIntegerSingleTypenumeric)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bigintegernumerice0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerSingleTypenumeric))]
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
                var models = await ((IBigIntegerSingleTypenumeric)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_bigintegernumerice0mi
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
                    BigIntegernumericE0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IBigIntegerSingleTypenumeric)this).DynQueryExportModelInner(connection, @"
COPY public.binary_bigintegernumerice0mi
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
                    BigIntegernumericE0MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_bigintegernumerice0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericE0MI), typeof(BigIntegernumericE0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerSingleTypenumeric)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(13),
                (NpgsqlTypes.NpgsqlDbType)(13)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(13),
                (NpgsqlTypes.NpgsqlDbType)(13)
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
                var models1 = new List<BigIntegernumericE0MI>();
                var models2 = new List<BigIntegernumericE0MI>();
                await ((IBigIntegerSingleTypenumeric)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericE0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericE0MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BigIntegernumericE0MI>();
                var models2 = new List<BigIntegernumericE0MI>();
                ((IBigIntegerSingleTypenumeric)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericE0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericE0MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bigintegernumerice0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericE0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerSingleTypenumeric)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(13),
                (NpgsqlTypes.NpgsqlDbType)(13)
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
                var models = await ((IBigIntegerSingleTypenumeric)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericE0MI.AssertModel(model, expectedModel, false);
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
                var models = ((IBigIntegerSingleTypenumeric)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericE0MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_bigintegernumerice0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericE0MIWA), typeof(BigIntegernumericE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerSingleTypenumeric))]
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
                var models1 = new List<BigIntegernumericE0MIWA>();
                var models2 = new List<BigIntegernumericE0MIWA>();
                await ((IBigIntegerSingleTypenumeric)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericE0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BigIntegernumericE0MIWA>();
                var models2 = new List<BigIntegernumericE0MIWA>();
                ((IBigIntegerSingleTypenumeric)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bigintegernumerice0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerSingleTypenumeric))]
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
                var models = await ((IBigIntegerSingleTypenumeric)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericE0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IBigIntegerSingleTypenumeric)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericE0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

